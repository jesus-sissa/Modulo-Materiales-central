Public Class frm_Compras

    Dim Id_Proveedor As Integer
    Dim Iva_Proveedor As Decimal = 0.0
    Dim Domicilio_Entrega As String = ""
    Dim Condiciones_Pago As String = ""

    Private Sub frm_Ventas_Materiales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Lsv_Ventas.Columns.Add("Clave")
        Lsv_Ventas.Columns.Add("Descripcion")
        Lsv_Ventas.Columns.Add("Cantidad")
        Lsv_Ventas.Columns.Add("UnidadM")
        Lsv_Ventas.Columns.Add("Precio")
        Lsv_Ventas.Columns.Add("Importe")
        Lsv_Ventas.Columns.Add("TipoEntidad")
        Lsv_Ventas.Columns.Add("Entidad")
        Lsv_Ventas.Columns.Add("TE")
        Lsv_Ventas.Columns.Add("IDE")

        Lsv_Ventas.HeaderStyle = ColumnHeaderStyle.Nonclickable
        Lsv_Ventas.Columns(2).TextAlign = HorizontalAlignment.Right
        Lsv_Ventas.Columns(3).TextAlign = HorizontalAlignment.Right
        Lsv_Ventas.Columns(4).TextAlign = HorizontalAlignment.Right
        Lsv_Ventas.Columns(5).TextAlign = HorizontalAlignment.Right

        cmb_Unidad.AgregarItem("PZ", "PIEZA")
        cmb_Unidad.AgregarItem("KG", "KILO")
        cmb_Unidad.AgregarItem("LT", "LITRO")
        cmb_Unidad.AgregarItem("MI", "MILLAR")
        cmb_Unidad.AgregarItem("SV", "SERVICIO")

        cmb_TipoEntidad.AgregarItem("1", "UNIDADES")
        cmb_TipoEntidad.AgregarItem("2", "DEPARTAMENTOS")

        FuncionesGlobales.fn_Columna(Lsv_Ventas, 10, 45, 10, 10, 15, 0, 0, 0, 0, 0)

        cmb_Material.AgregaParametro("@Tipo", 0, 1)
        cmb_Material.AgregaParametro("@Status", "A", 0)
        cmb_Proveedor.Actualizar()
        cmb_Material.Actualizar()

        cmb_Moneda.Actualizar()

        tbx_SubTotal.Text = "0.00"
        tbx_IVA.Text = "0.00"
        tbx_Total.Text = "0.00"

        SegundosDesconexion = 0

        'COnsultar el domicilio de entrega por default
        Domicilio_Entrega = ""
        Dim dt As DataTable = Cn_Materiales.fn_ComprasMateriales_GetDomicilio
        If dt Is Nothing Then
            MsgBox("Ocurrió un error al intentar obtener el Domicilio de Entrega predeterminado.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        If dt.Rows.Count = 0 Then
            MsgBox("Ocurrió un error al intentar obtener el Domicilio de Entrega predeterminado.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        Domicilio_Entrega = dt.Rows(0)("Direccion") & ", " & dt.Rows(0)("Ciudad") & ", " & dt.Rows(0)("Estado")
        dt.Dispose()
    End Sub

    Private Sub cmb_Proveedor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Proveedor.SelectedIndexChanged
        SegundosDesconexion = 0

        If cmb_Proveedor.SelectedValue Is Nothing Then
            Exit Sub
        End If
        If cmb_Proveedor.SelectedValue = 0 Then
            Iva_Proveedor = 0
            tbx_Precio.Clear()
            Exit Sub
        End If

        Call ObtenerIVA()

        If Lsv_Ventas.Items.Count > 0 Then
            If cmb_Proveedor.SelectedValue <> Id_Proveedor Then
                If MsgBox("Cambiar el Proveedor eliminará los materiales ya capturados. ¿Desea continuar?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, frm_MENU.Text) = MsgBoxResult.Yes Then
                    Lsv_Ventas.Items.Clear()
                    Id_Proveedor = cmb_Proveedor.SelectedValue
                Else
                    cmb_Proveedor.SelectedValue = Id_Proveedor
                End If
            End If
        Else
            Id_Proveedor = cmb_Proveedor.SelectedValue
        End If
    End Sub

    Private Sub cmb_Material_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Material.SelectedIndexChanged
        SegundosDesconexion = 0
        If cmb_Material.SelectedValue Is Nothing Then Exit Sub
        If cmb_Material.SelectedValue = 0 Then
            tbx_Precio.Clear()
            Exit Sub
        End If
    End Sub

    Sub Buscar_Precio()
        tbx_Precio.Text = Cn_Materiales.fn_ComprasMateriales_GetPrecio(cmb_Material.SelectedValue, cmb_Proveedor.SelectedValue)
    End Sub

    Private Sub ObtenerIVA()
        'Obtener IVA del Proveedor seleccionado
        Dim Dt As DataTable = Cn_Materiales.fn_Proveedores_Read(CInt(cmb_Proveedor.SelectedValue))
        If Dt Is Nothing Then
            Iva_Proveedor = 0
            MsgBox("No se encontraron los Datos del Proveedor.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        If Dt.Rows.Count = 0 Then
            Iva_Proveedor = 0
            MsgBox("No se encontraron los Datos del Proveedor.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        Iva_Proveedor = Dt.Rows(0)("IVA") / 100
        lbl_Porcentaje.Text = Dt.Rows(0)("IVA") & "%"
        Dt.Dispose()
    End Sub

    Private Sub btn_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Agregar.Click
        SegundosDesconexion = 0

        If cmb_Proveedor.SelectedValue = 0 Then
            MsgBox("Debe seleccionar un Proveedor.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Proveedor.Focus()
            Exit Sub
        End If
        If Not rdb_Material.Checked And Not rdb_Abierto.Checked Then
            MsgBox("Debe seleccionar el tipo de Orden de Compra.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        If rdb_Material.Checked Then
            If cmb_Material.SelectedValue = 0 Then
                MsgBox("Debe seleccionar un Material para agregar.", MsgBoxStyle.Critical, frm_MENU.Text)
                cmb_Material.Focus()
                Exit Sub
            End If
        Else
            If tbx_Descripcion.Text.Trim = "" Then
                MsgBox("Capture una Descripción.", MsgBoxStyle.Critical, frm_MENU.Text)
                tbx_Descripcion.Focus()
                Exit Sub
            End If
        End If

        If tbx_Cantidad.Text.Trim = "" Then
            MsgBox("Capture la Cantidad.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Cantidad.Focus()
            Exit Sub
        End If
        If Val(tbx_Cantidad.Text.Trim) = 0 Then
            MsgBox("Capture la Cantidad.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Cantidad.Focus()
            Exit Sub
        End If
        If cmb_Unidad.SelectedValue.ToString = "0" Then
            MsgBox("Seleccione la Unidad de Medida.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Unidad.Focus()
            Exit Sub
        End If
        If cmb_Entidad.Enabled AndAlso cmb_Entidad.SelectedValue = 0 Then
            MsgBox("Indique una Entidad o marque la casilla «No Aplica».", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Entidad.Focus()
            Exit Sub
        End If
        If tbx_Precio.Text.Trim = "" Then
            MsgBox("Capture el Precio.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Precio.Focus()
            Exit Sub
        End If

        'Validar SI ya existe el  material
        If rdb_Material.Checked Then
            For Each Elemento As ListViewItem In Lsv_Ventas.Items
                If Elemento.Tag = cmb_Material.SelectedValue.ToString Then
                    MsgBox("El material ya existe en la lista.", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                End If
            Next
        Else
            For Each Elemento As ListViewItem In Lsv_Ventas.Items
                If Elemento.SubItems(1).Text = tbx_Descripcion.Text.Trim Then
                    MsgBox("El artículo ya existe en la lista.", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                End If
            Next
        End If
        Dim Importe As Decimal = 0.0
        Dim Precio As Decimal = CDec(tbx_Precio.Text.Trim)
        'Importe = CDec(tbx_Precio.Text) * CDec(tbx_Cantidad.Text)
        Importe = CDec(Precio) * CDec(tbx_Cantidad.Text.Trim)

        If rdb_Material.Checked Then
            Lsv_Ventas.Items.Add(tbx_ClaveMaterial.Text.Trim)
            Lsv_Ventas.Items(Lsv_Ventas.Items.Count - 1).Tag = cmb_Material.SelectedValue.ToString
            Lsv_Ventas.Items(Lsv_Ventas.Items.Count - 1).SubItems.Add(cmb_Material.Text.Trim)
        ElseIf rdb_Abierto.Checked Then
            Lsv_Ventas.Items.Add("")
            Lsv_Ventas.Items(Lsv_Ventas.Items.Count - 1).Tag = 0
            Lsv_Ventas.Items(Lsv_Ventas.Items.Count - 1).SubItems.Add(tbx_Descripcion.Text.Trim)
        End If
        Lsv_Ventas.Items(Lsv_Ventas.Items.Count - 1).SubItems.Add(tbx_Cantidad.Text.Trim)
        Lsv_Ventas.Items(Lsv_Ventas.Items.Count - 1).SubItems.Add(cmb_Unidad.Text.Trim)
        Lsv_Ventas.Items(Lsv_Ventas.Items.Count - 1).SubItems.Add(Format(CDec(tbx_Precio.Text.Trim), "n2"))
        Lsv_Ventas.Items(Lsv_Ventas.Items.Count - 1).SubItems.Add(Format(Importe, "n2"))
        If cmb_TipoEntidad.SelectedValue = 0 Then
            Lsv_Ventas.Items(Lsv_Ventas.Items.Count - 1).SubItems.Add("")
        Else
            Lsv_Ventas.Items(Lsv_Ventas.Items.Count - 1).SubItems.Add(cmb_TipoEntidad.Text)
        End If
        Lsv_Ventas.Items(Lsv_Ventas.Items.Count - 1).SubItems.Add(cmb_Entidad.Text)
        Lsv_Ventas.Items(Lsv_Ventas.Items.Count - 1).SubItems.Add(cmb_TipoEntidad.SelectedValue)
        If cmb_TipoEntidad.SelectedValue = 0 Then
            Lsv_Ventas.Items(Lsv_Ventas.Items.Count - 1).SubItems.Add(0)
        Else
            Lsv_Ventas.Items(Lsv_Ventas.Items.Count - 1).SubItems.Add(cmb_Entidad.SelectedValue)
        End If

        cmb_Material.SelectedValue = 0
        tbx_Precio.Clear()
        tbx_Cantidad.Clear()
        tbx_Descripcion.Clear()
        Call CalcularImportes()
        If cmb_Material.Visible Then
            tbx_ClaveMaterial.Focus()
        Else
            tbx_Descripcion.Focus()
        End If
    End Sub

    Private Sub CalcularImportes()
        SegundosDesconexion = 0
        btn_Guardar.Enabled = False
        Dim Subtotal As Decimal = 0.0
        For Each item As ListViewItem In Lsv_Ventas.Items
            Subtotal += CDec(item.SubItems(5).Text)
        Next

        If Subtotal >= 0 Then
            tbx_SubTotal.Text = Format(Subtotal, "n2")
            tbx_IVA.Text = Format(Subtotal * Iva_Proveedor, "n2")
            tbx_Total.Text = Format(Subtotal + (Subtotal * Iva_Proveedor), "n2")
            btn_Guardar.Enabled = True
        Else
            tbx_SubTotal.Text = Format(Subtotal, "n2")
            tbx_IVA.Text = Format(0, "n2")
            tbx_Total.Text = Format(0, "n2")
        End If


    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0

        If cmb_Proveedor.SelectedValue = 0 Then
            MsgBox("Debe seleccionar un Proveedor.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Proveedor.Focus()
            Exit Sub
        End If
        If cmb_Moneda.SelectedValue = 0 Then
            MsgBox("Debe seleccionar una Moneda.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Moneda.Focus()
            Exit Sub
        End If
        If Lsv_Ventas.Items.Count = 0 Then
            MsgBox("Debe capturar al menos un Artículo.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        If Domicilio_Entrega = "" Or Condiciones_Pago = "" Then
            If MsgBox("El domicilio de Entrega o las Condiciones de pago no han sido capturadas. Desea continuar?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, frm_MENU.Text) = MsgBoxResult.No Then Exit Sub
        End If

        Dim Id_MatCompra As Long
        Dim Tipo_Orden As Byte
        If rdb_Material.Checked Then
            Tipo_Orden = 1
        ElseIf rdb_Abierto.Checked Then
            Tipo_Orden = 2
        End If
        Me.Cursor = Cursors.WaitCursor
        Id_MatCompra = Cn_Materiales.fn_ComprasMateriales_Guardar(Lsv_Ventas, Tipo_Orden, cmb_Proveedor.SelectedValue, tbx_Atencion.Text, CDec(tbx_SubTotal.Text), CDec(tbx_IVA.Text), CDec(tbx_Total.Text), rtb_Observaciones.Text.Trim, cmb_Moneda.SelectedValue, Domicilio_Entrega, Condiciones_Pago)
        If Id_MatCompra > 0 Then
            Me.Cursor = Cursors.WaitCursor
            Dim frm As New frm_Reporte
            frm.crv.ReportSource = Cn_Materiales.fn_Compras_GenerarReporte(Id_MatCompra)
            Me.Cursor = Cursors.Default
            frm.ShowDialog()
        Else
            Me.Cursor = Cursors.Default
            MsgBox("Ha ocurrido un error al intentar Guardar la Orden de Compra.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        Call LimpiaPantalla()

        cmb_TipoEntidad.SelectedValue = 0

    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0
        Me.Close()
    End Sub

    Private Sub btn_Borrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Borrar.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        Lsv_Ventas.SelectedItems(0).Remove()
        Call CalcularImportes()

    End Sub

    Private Sub Lsv_Ventas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lsv_Ventas.SelectedIndexChanged
        btn_Borrar.Enabled = Lsv_Ventas.SelectedItems.Count > 0
    End Sub

    Private Sub LimpiaPantalla()
        SegundosDesconexion = 0

        tbx_Cantidad.Clear()
        cmb_Proveedor.SelectedValue = 0
        tbx_ClaveProveedor.Clear()
        tbx_Atencion.Clear()
        cmb_TipoEntidad.SelectedValue = 0
        tbx_ClaveMaterial.Clear()
        cmb_Material.SelectedValue = 0
        tbx_Descripcion.Clear()
        Lsv_Ventas.Items.Clear()
        tbx_SubTotal.Text = "0.00"
        tbx_IVA.Text = "0.00"
        tbx_Total.Text = "0.00"
        rtb_Observaciones.Clear()
    End Sub

    Private Sub rdb_Material_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_Material.CheckedChanged
        SegundosDesconexion = 0

        If rdb_Material.Checked Then
            lbl_Material.Visible = True
            tbx_ClaveMaterial.Visible = True
            cmb_Material.Visible = True
            lbl_Descripcion.Visible = False
            tbx_Descripcion.Visible = False

            cmb_Material.Enabled = True
            tbx_ClaveMaterial.Enabled = True

            cmb_Material.SelectedValue = 0
        Else
            lbl_Material.Visible = False
            tbx_ClaveMaterial.Visible = False
            cmb_Material.Visible = False
            lbl_Descripcion.Visible = True
            tbx_Descripcion.Visible = True
        End If
    End Sub

    Private Sub rdb_Abierto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_Abierto.CheckedChanged
        SegundosDesconexion = 0

        If rdb_Abierto.Checked Then
            lbl_Material.Visible = False
            tbx_ClaveMaterial.Visible = False
            cmb_Material.Visible = False
            lbl_Descripcion.Visible = True
            tbx_Descripcion.Visible = True
        Else
            lbl_Material.Visible = True
            tbx_ClaveMaterial.Visible = True
            cmb_Material.Visible = True
            lbl_Descripcion.Visible = False
            tbx_Descripcion.Visible = False

            cmb_Material.SelectedValue = 0
        End If
    End Sub

    Private Sub rtb_Observaciones_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles rtb_Observaciones.KeyPress
        SegundosDesconexion = 0
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub cmb_TipoEntidad_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_TipoEntidad.SelectedIndexChanged
        SegundosDesconexion = 0

        Dim dt As DataTable
        If cmb_TipoEntidad.SelectedValue Is Nothing Then
            Exit Sub
        End If
        If cmb_TipoEntidad.SelectedValue = 0 Then
            cmb_Entidad.SelectedValue = 0
            cmb_Entidad.Enabled = False
            Exit Sub
        End If
        cmb_Entidad.Enabled = True
        cmb_Entidad.DataSource = Nothing
        Select Case cmb_TipoEntidad.SelectedValue
            Case 1
                'cargar el combo con Unidades
                dt = Cn_Materiales.fn_ComprasMateriales_GetUnidades()
                If dt Is Nothing Then
                    MsgBox("Ocurrió un error al intentar consultar el catálogo de Unidades.", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                End If
                FuncionesGlobales.fn_CargaCombo(cmb_Entidad, dt, "Id_Unidad", "Descripcion")
            Case 2
                'cargar el combo con Departamentos
                dt = Cn_Materiales.fn_ComprasMateriales_GetDepartamentos()
                If dt Is Nothing Then
                    MsgBox("Ocurrió un error al intentar consultar el catálogo de Departamentos.", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                End If
                FuncionesGlobales.fn_CargaCombo(cmb_Entidad, dt, "Id_Departamento", "Descripcion")
        End Select

    End Sub

    Private Sub chk_Entidad_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Entidad.CheckedChanged
        SegundosDesconexion = 0

        cmb_TipoEntidad.SelectedValue = 0
        cmb_Entidad.Enabled = False
        If chk_Entidad.Checked Then
            cmb_TipoEntidad.Enabled = False
        Else
            cmb_TipoEntidad.Enabled = True
        End If
    End Sub

    Private Sub btn_CondicionesPago_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_CondicionesPago.Click
        Dim frm As New frm_ComprasDatos
        frm.Domicilio_Entrega = Domicilio_Entrega
        frm.Condiciones_Pago = Condiciones_Pago
        frm.ShowDialog()
        Domicilio_Entrega = frm.Domicilio_Entrega
        Condiciones_Pago = frm.Condiciones_Pago

    End Sub

End Class
