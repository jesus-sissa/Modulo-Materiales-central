Public Class frm_Traspasos
    
    Dim Dt_MaterialesDestino As DataTable
    Dim Clave_SucursalD As String

    Private Sub frm_Traspasos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Lsv_Datos.Columns.Add("Material")
        Lsv_Datos.Columns.Add("Descripcion")
        Lsv_Datos.Columns.Add("Cantidad")
        Lsv_Datos.Columns.Add("IDID") 'Id_InventarioDestino
        Lsv_Datos.Columns.Add("DescripcionDestino") 'Descripcion de Material en la Sucursal Destino
        Lsv_Datos.HeaderStyle = ColumnHeaderStyle.Nonclickable
        Lsv_Datos.Columns(2).TextAlign = HorizontalAlignment.Right
        FuncionesGlobales.fn_Columna(Lsv_Datos, 15, 50, 15, 0, 0, 0, 0, 0, 0, 0)


        cmb_Material.AgregaParametro("@Tipo", 0, 1)
        cmb_Material.AgregaParametro("@Status", "A", 0)
        cmb_Material.Actualizar()

        If Cnx_Central = "" Then
            MsgBox("No se han definido los parámetros de conexión con la Base de Datos Central de SIAC. Si no captura estos parámetros no podrá tener acceso a las pantallas de este Módulo." & Chr(13) & "Para configurar estos parámetros vaya al Menu Archivo y seleccione la opción «Parámetros de Servidor Central».", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        Dim Dt_SucursalesP As DataTable = Cn_Materiales.Fn_SuscursalesPropias_Combo()
        'Quitar de la lista la Sucursal actual ya que no se pueden hacer envios a uno mismo
        For Each dr As DataRow In Dt_SucursalesP.Rows
            If dr("Clave SP") = SucursalClave Then
                Dt_SucursalesP.Rows.Remove(dr)
                Exit For
            End If
        Next
        FuncionesGlobales.fn_CargaCombo(cmb_Sucursal, Dt_SucursalesP, "Sucursal Id", "Nombre")

    End Sub

    Private Sub LimpiaPantalla()
        tbx_Cantidad.Clear()
        tbx_ClaveMaterial.Clear()
        cmb_Sucursal.SelectedValue = 0
        cmb_Material.SelectedValue = 0
        Lsv_Datos.Items.Clear()
        rtb_Comentarios.Clear()

        btn_Borrar.Enabled = False
        btn_Guardar.Enabled = False
        FuncionesGlobales.fn_NumRegistros(Lbl_Registros, Lsv_Datos.Items.Count)
        cmb_Sucursal.Focus()
    End Sub

    Private Sub cmb_Sucursal_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Sucursal.SelectedIndexChanged
        SegundosDesconexion = 0
        'Aqui debemos traer El inventario de materiales de la sucursal seleccionada para poder insertar los IDs en Mat_TraspasosD
        Dt_MaterialesDestino = Nothing
        Lsv_Datos.Items.Clear()
        btn_Guardar.Enabled = False
        Cnx_Sucursal = ""
        If cmb_Sucursal.SelectedIndex = 0 Then Exit Sub
        'Armar la cadena de conexion 
        Dim Dt_Temp As DataTable = cmb_Sucursal.DataSource
        Cnx_Sucursal = "Data Source=" & Cn_Encripta.fn_Decode(Dt_Temp.Rows(cmb_Sucursal.SelectedIndex)("Servidor")) & ";Initial Catalog=" & Cn_Encripta.fn_Decode(Dt_Temp.Rows(cmb_Sucursal.SelectedIndex)("Base Datos")) & ";User Id=" & Cn_Encripta.fn_Decode(Dt_Temp.Rows(cmb_Sucursal.SelectedIndex)("Usuario")) & ";Password=" & Cn_Encripta.fn_Decode(Dt_Temp.Rows(cmb_Sucursal.SelectedIndex)("Clave")) & ";"
        'Consultar Cat_Sucursales en la Sucursal Seleccionada para sacar el Id_Sucursal
        Dim Dt_Sucursales As DataTable
        Clave_SucursalD = Dt_Temp.Rows(cmb_Sucursal.SelectedIndex)("Clave SP")
        Dt_Sucursales = Cn_Materiales.fn_ConsultaSucursales(Clave_SucursalD)
        If Dt_Sucursales Is Nothing Then
            MsgBox("Ocurrió un error al intentar consultar la Clave de la Sucursal Destino.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
            Exit Sub
        End If
        If Dt_Sucursales.Rows.Count = 0 Then
            MsgBox("No se pudo obtener la calve de la Sucursal Destino.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
            Exit Sub
        End If
        'Consultar el Inventario de Materiales de la Sucursal Seleccionada
        Dt_MaterialesDestino = Cn_Materiales.fn_ConsultaInventarioMateriales(Dpto.GENERAL, Dt_Sucursales.Rows(0)("Id_Sucursal"))
        If Dt_MaterialesDestino Is Nothing Then
            MsgBox("No se pudo obtener el Inventario de Materiales de la Sucursal seleccionada.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
            Exit Sub
        End If
        If Dt_MaterialesDestino.Rows.Count = 0 Then
            MsgBox("No se pudo obtener el Inventario de Materiales de la Sucursal seleccionada.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
            Exit Sub
        End If


    End Sub

    Private Sub btn_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Agregar.Click
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
        If Val(tbx_Cantidad.Text.Trim) = 0 Then
            MsgBox("Capture una cantidad Mayor que Cero.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Cantidad.Focus()
            Exit Sub
        End If

        'Validar SI ya existe el  material en la tabla
        Dim lsvItem As ListViewItem
        For Each lsvItem In Lsv_Datos.Items()
            If lsvItem.Tag = cmb_Material.SelectedValue.ToString Then
                MsgBox("El Material ya existe en la lista.", MsgBoxStyle.Critical, frm_MENU.Text)
                Lsv_Datos.Items(lsvItem.Index).Selected = True
                cmb_Material.Focus()
                Exit Sub
            End If
        Next
        'Dim Dt_Material As DataTable = cmb_Material.DataSource
        'If Dt_Material.Rows(cmb_Material.SelectedIndex)("ControlFolios") = "SI" Then
        '    Dim frm As New frm_FoliosAsignados
        '    frm.Cantidad = tbx_Cantidad.Text.Trim
        '    frm.Id_Inventario = Dt_Material.Rows(cmb_Material.SelectedIndex)("Id_Inventario")
        '    frm.ShowDialog()
        '    If frm.Validado Then
        '        Folios = frm.Folios
        '    Else
        '        MsgBox("No se han capturado correctamente los Folios asignados.", MsgBoxStyle.Critical, frm_MENU.Text)
        '        btn_Agregar.Focus()
        '        Exit Sub
        '    End If
        'End If

        'Antes de agregarlo a la lista debemos recorrer el Dt_MaterialesDestino para agregar tambien el Id_Inventario de la Sucursal Destino
        Dim Id_InventarioDestino As Integer = 0
        Dim DescripcionDestino As String = ""
        For Each Dr_Material As DataRow In Dt_MaterialesDestino.Rows
            If Dr_Material("Descripcion") = cmb_Material.Text Then
                Id_InventarioDestino = Dr_Material("Id_Inventario")
                DescripcionDestino = Dr_Material("Descripcion")
                Exit For
            End If
        Next
        If Id_InventarioDestino = 0 Or DescripcionDestino = "" Then
            MsgBox("No se encontró el Material en la Sucursal Destino.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
            Exit Sub
        End If
        Lsv_Datos.Items.Add(tbx_ClaveMaterial.Text)
        Lsv_Datos.Items(Lsv_Datos.Items.Count - 1).Tag = cmb_Material.SelectedValue.ToString
        Lsv_Datos.Items(Lsv_Datos.Items.Count - 1).SubItems.Add(cmb_Material.Text)
        Lsv_Datos.Items(Lsv_Datos.Items.Count - 1).SubItems.Add(tbx_Cantidad.Text)
        Lsv_Datos.Items(Lsv_Datos.Items.Count - 1).SubItems.Add(Id_InventarioDestino)
        Lsv_Datos.Items(Lsv_Datos.Items.Count - 1).SubItems.Add(DescripcionDestino)
        'Lsv_Datos.Items(Lsv_Datos.Items.Count - 1).SubItems.Add(Dt_Material.Rows(cmb_Material.SelectedIndex)("ControlFolios"))
        'Lsv_Datos.Items(Lsv_Datos.Items.Count - 1).SubItems.Add(Folios)

        cmb_Material.SelectedValue = 0
        tbx_Cantidad.Clear()
        btn_Guardar.Enabled = True
        tbx_ClaveMaterial.Focus()
        FuncionesGlobales.fn_NumRegistros(Lbl_Registros, Lsv_Datos.Items.Count)
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        SegundosDesconexion = 0
        If Lsv_Datos.Items.Count = 0 Then Exit Sub

        Dim Dt_Local As New DataTable
        Dim lsvItem As ListViewItem
        Dim Dr_Local As DataRow
        Dim Control_Folios As String = "N"

        If cmb_Sucursal.SelectedIndex = 0 Then
            MsgBox("Seleccione el Departamento al que se asignará el Material.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Sucursal.Focus()
            Exit Sub
        End If
        Dt_Local.TableName = "detalle"
        Dt_Local.Columns.Add("Id_InventarioO")
        Dt_Local.Columns.Add("DescripcionO")
        Dt_Local.Columns.Add("Cantidad")
        Dt_Local.Columns.Add("Id_InventarioD")
        Dt_Local.Columns.Add("DescripcionD")
        Dt_Local.Columns.Add("Folios")
        Dt_Local.Columns.Add("Control_Folios")
        For Each lsvItem In Lsv_Datos.Items()
            Dr_Local = Dt_Local.NewRow
            Dr_Local("Id_InventarioO") = lsvItem.Tag.ToString
            Dr_Local("DescripcionO") = lsvItem.SubItems(1).Text
            Dr_Local("Cantidad") = lsvItem.SubItems(2).Text
            Dr_Local("Id_InventarioD") = lsvItem.SubItems(3).Text
            Dr_Local("DescripcionD") = lsvItem.SubItems(4).Text
            Dr_Local("Control_Folios") = "N"
            Dr_Local("Folios") = ""
            Dt_Local.Rows.Add(Dr_Local)
        Next

        Dim Interno As String = "S"

        If Cn_Materiales.fn_TraspasosMateriales_Guardar(SucursalClave, SucursalN, Clave_SucursalD, cmb_Sucursal.Text, rtb_Comentarios.Text.Trim, Dt_Local, Control_Folios) = True Then
            MsgBox("Registro guardado correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
            Call LimpiaPantalla()
        Else
            MsgBox("Ocurrió un error al intentar guardar la Asignación.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If

    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0
        Me.Close()
    End Sub

    Private Sub btn_Borrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Borrar.Click
        SegundosDesconexion = 0
        Lsv_Datos.Items(Lsv_Datos.SelectedItems(0).Index).Remove()
        btn_Guardar.Enabled = Lsv_Datos.Items.Count > 0
        btn_Borrar.Enabled = False
        FuncionesGlobales.fn_NumRegistros(Lbl_Registros, Lsv_Datos.Items.Count)
    End Sub

    Private Sub Lsv_Datos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lsv_Datos.SelectedIndexChanged
        btn_Borrar.Enabled = Lsv_Datos.SelectedItems.Count > 0
    End Sub

End Class
