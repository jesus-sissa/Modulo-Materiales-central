Public Class frm_Ventas
    Dim Folios As String = ""
    Dim ClaveRemision As String = ""

    Private Sub frm_Ventas_Materiales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmb_ClaveDepto.AgregarItem("1", "PROCESO")
        cmb_ClaveDepto.AgregarItem("2", "MORRALLA")
        cmb_ClaveDepto.AgregarItem("3", "CAJEROS AUTOMATICOS")
        cmb_ClaveDepto.AgregarItem("4", "TRASLADO(OPERACIONES)")
        cmb_ClaveDepto.AgregarItem("5", "NOMINAS")
        cmb_ClaveDepto.AgregarItem("6", "PROCESO ATMS")
        cmb_ClaveDepto.AgregarItem("7", "AUDITORIA ATMS")

        cmb_Material.AgregaParametro("@Tipo", 0, 1)
        cmb_Material.AgregaParametro("@Status", "A", 0)
        cmb_Material.Actualizar()

        Call LimpiaPantalla()

        ' Obtener la Clave de Remisión de la tabla Parametros Globales
        ' para saber cuando se esta agregando un Comprobante de Traslado
        Dim dt_Parametros As DataTable = FuncionesGlobales.fn_ParametrosGlobales()

        If Not dt_Parametros Is Nothing Then
            If dt_Parametros.Rows.Count > 0 And Not IsDBNull(dt_Parametros.Rows(0)("Clave_Remision")) Then
                ClaveRemision = dt_Parametros.Rows(0)("Clave_Remision")
            Else
                MsgBox("No se ha configurado la Clave del Comprobante de Traslado.", MsgBoxStyle.Critical, frm_MENU.Text)
                Close()
            End If
        Else
            MsgBox("Ocurrio un Error al Consultar la Clave del Comprobante de Traslado.", MsgBoxStyle.Critical, frm_MENU.Text)
            Close()
        End If

    End Sub

    Private Sub btn_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Agregar.Click
        'Inicializar la variable de desconexión
        SegundosDesconexion = 0

        If cmb_Material.SelectedValue = 0 Then
            MsgBox("Seleccione un Material.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Material.Focus()
            Exit Sub
        End If
        If tbx_Cantidad.Text.Trim = "" Then
            MsgBox("Capture la Cantidad.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Cantidad.Focus()
            Exit Sub
        End If

        'Validar SI ya existe el  material
        Dim lsvItem As ListViewItem
        For Each lsvItem In Lsv_Ventas.Items()
            If lsvItem.Tag = cmb_Material.SelectedValue.ToString Then
                MsgBox("El Material ya existe en la lista.", MsgBoxStyle.Critical, frm_MENU.Text)
                Lsv_Ventas.Items(lsvItem.Index).Selected = True
                cmb_Material.Focus()
                Exit Sub
            End If
        Next 
        Dim Dt_Material As DataTable = cmb_Material.DataSource
        'tbx_ClaveMaterial.Text = ClaveRemision Or ----Remplazado por nuevo control de folios
        Folios = ""
        If Dt_Material.Rows(cmb_Material.SelectedIndex)("ControlFolios") = "SI" Then
            Dim frm As New frm_FoliosAsignados
            frm.Cantidad = tbx_Cantidad.Text.Trim
            frm.Id_Inventario = Dt_Material.Rows(cmb_Material.SelectedIndex)("Id_Inventario")
            frm.ShowDialog()
            If frm.Validado Then
                Folios = frm.Folios
            Else
                MsgBox("No se han capturado correctamente los Folios asignados.", MsgBoxStyle.Critical, frm_MENU.Text)
                btn_Agregar.Focus()
                Exit Sub
            End If
        End If
        Lsv_Ventas.Items.Add(tbx_ClaveMaterial.Text)
        Lsv_Ventas.Items(Lsv_Ventas.Items.Count - 1).Tag = cmb_Material.SelectedValue.ToString
        Lsv_Ventas.Items(Lsv_Ventas.Items.Count - 1).SubItems.Add(cmb_Material.Text)
        Lsv_Ventas.Items(Lsv_Ventas.Items.Count - 1).SubItems.Add(tbx_Cantidad.Text)
        Lsv_Ventas.Items(Lsv_Ventas.Items.Count - 1).SubItems.Add(Dt_Material.Rows(cmb_Material.SelectedIndex)("ControlFolios"))
        Lsv_Ventas.Items(Lsv_Ventas.Items.Count - 1).SubItems.Add(Folios)

        cmb_Material.SelectedValue = 0
        tbx_Cantidad.Clear()
        tbx_ClaveMaterial.Focus()
        'Lbl_Registros.Text = "Registros: " & Lsv_Ventas.Items.Count
        FuncionesGlobales.fn_NumRegistros(Lbl_Registros, Lsv_Ventas.Items.Count)
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        'Inicializar la variable de desconexión
        SegundosDesconexion = 0
        If Lsv_Ventas.Items.Count = 0 Then Exit Sub

        Dim lc_dt As New DataTable
        Dim lsvItem As ListViewItem
        Dim lc_dr As DataRow
        Dim Control_Folios As String = "N"

        If cmb_ClaveDepto.SelectedIndex = 0 Then
            MsgBox("Seleccione el Departamento al que se asignará el Material.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_ClaveDepto.Focus()
            Exit Sub
        End If
        lc_dt.TableName = "detalle"
        lc_dt.Columns.Add("Id_Inventario")
        lc_dt.Columns.Add("Cantidad")
        lc_dt.Columns.Add("Folios")
        lc_dt.Columns.Add("Control_Folios")
        For Each lsvItem In Lsv_Ventas.Items()
            lc_dr = lc_dt.NewRow
            lc_dr("Id_Inventario") = lsvItem.Tag.ToString
            lc_dr("Cantidad") = lsvItem.SubItems(2).Text
            lc_dr("Control_Folios") = IIf(lsvItem.SubItems(3).Text = "SI", "S", "N")
            If lsvItem.SubItems(3).Text = "SI" Then Control_Folios = "S"
            lc_dr("Folios") = lsvItem.SubItems(4).Text
            lc_dt.Rows.Add(lc_dr)
        Next

        Dim Interno As String = "S"

        If Cn_Materiales.fn_VentasMateriales_Guardar(0, cmb_ClaveDepto.SelectedValue, FuncionesGlobales.fn_Fecha102(dtp_FechaEntrega.Value.Date.ToString), Interno, lc_dt, Control_Folios) = True Then
            MsgBox("Registro guardado con éxito.", MsgBoxStyle.Information, frm_MENU.Text)
            LimpiaPantalla()
        Else
            MsgBox("Ocurrió un error al intentar guardar la Asignación.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If

    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        'Inicializar la variable de desconexión
        SegundosDesconexion = 0
        Me.Close()
    End Sub

    Private Sub btn_Borrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Borrar.Click
        'Inicializar la variable de desconexión
        SegundosDesconexion = 0

        Lsv_Ventas.Items(Lsv_Ventas.SelectedItems(0).Index).Remove()
        Lbl_Registros.Text = "Registros: " & Lsv_Ventas.Items.Count
    End Sub

    Private Sub Lsv_Ventas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lsv_Ventas.SelectedIndexChanged
        btn_Borrar.Enabled = Lsv_Ventas.SelectedItems.Count > 0
    End Sub

    Private Sub LimpiaPantalla()
        tbx_Cantidad.Clear()
        tbx_ClaveMaterial.Clear()
        cmb_ClaveDepto.SelectedValue = 0
        cmb_Material.SelectedValue = 0
        Lsv_Ventas.Clear()

        Lsv_Ventas.Columns.Add("Material")
        Lsv_Ventas.Columns.Add("Descripcion")
        Lsv_Ventas.Columns.Add("Cantidad")
        Lsv_Ventas.Columns.Add("Foliado")
        Lsv_Ventas.Columns.Add("Folios")
        Lsv_Ventas.HeaderStyle = ColumnHeaderStyle.Nonclickable

        Lsv_Ventas.Columns(2).TextAlign = HorizontalAlignment.Right
        FuncionesGlobales.fn_Columna(Lsv_Ventas, 10, 60, 10, 10, 10, 0, 0, 0, 0, 0)
        btn_Borrar.Enabled = False
        FuncionesGlobales.fn_NumRegistros(Lbl_Registros, Lsv_Ventas.Items.Count)
    End Sub

    Private Sub dtp_FechaEntrega_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_FechaEntrega.KeyPress
        If Asc(e.KeyChar) = 13 Then
            cmb_ClaveDepto.Focus()
        End If
    End Sub

    Private Sub grbMenu_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grbMenu.MouseHover
        'Inicializar la variable de desconexión
        SegundosDesconexion = 0
    End Sub

    Private Sub Lsv_Ventas_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lsv_Ventas.MouseHover
        'Inicializar la variable de desconexión
        SegundosDesconexion = 0
    End Sub

    Private Sub cmb_ClaveDepto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_ClaveDepto.SelectedIndexChanged
        'Inicializar la variable de desconexión
        SegundosDesconexion = 0
    End Sub

End Class
