Public Class frm_ComprasCancelar

    Private Sub frm_ValidarCompras_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lsv_Compras.Columns.Add("Numero")
        lsv_Compras.Columns.Add("Fecha")
        lsv_Compras.Columns.Add("Hora")
        lsv_Compras.Columns.Add("Proveedor")
        lsv_Compras.Columns.Add("Capturo")
        lsv_Compras.Columns.Add("Importe")
        lsv_Compras.Columns.Add("IVA")
        lsv_Compras.Columns.Add("Total")

        lsv_Detalles.Columns.Add("Clave")
        lsv_Detalles.Columns.Add("Descripcion")
        lsv_Detalles.Columns.Add("Precio")
        lsv_Detalles.Columns.Add("Cantidad")
        lsv_Detalles.Columns.Add("Unidad")
        lsv_Detalles.Columns.Add("Importe")

        cmb_Proveedor.Actualizar()

    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Sub LlenarLista()
        SegundosDesconexion = 0
        Lbl_Registros.Text = "Registros: 0"
        Lbl_Registros2.Text = "Registros: 0"
        lsv_Detalles.Items.Clear()
        btn_Cancelar.Enabled = False
        If Not Cn_Materiales.fn_CancelarCompras_LlenarEncabezado(lsv_Compras, dtp_Desde.Value, dtp_Hasta.Value, cmb_Proveedor.SelectedValue, "A") Then
            MsgBox("Ocurrió un Error al intentar consultar las Ordenes de Compra.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
        Lbl_Registros.Text = "Registros: " & lsv_Compras.Items.Count
    End Sub

    Private Sub lsv_Compras_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Compras.SelectedIndexChanged
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        Lbl_Registros2.Text = "Registros: 0"
        lsv_Detalles.Items.Clear()
        btn_Cancelar.Enabled = lsv_Compras.SelectedItems.Count > 0
        If lsv_Compras.SelectedItems.Count > 0 Then
            If Not Cn_Materiales.fn_CancelarCompras_LlenarDetalle(lsv_Detalles, lsv_Compras.SelectedItems(0).Tag) Then
                MsgBox("Ocurrió un Error al intentar consultar el detalle de la Orden de Compra.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
        End If
        Lbl_Registros2.Text = "Registros: " & lsv_Detalles.Items.Count
    End Sub

    Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        If lsv_Compras.SelectedItems.Count = 0 Then
            MsgBox("Debe seleccionar una Orden de Compra para cancelar.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        Dim firma As New frm_FirmaElectronica
        firma.ShowDialog()
        firma.PedirObservaciones = False
        If firma.Firma Then
            If Not Cn_Materiales.fn_CancelarCompras_Cancelar(lsv_Compras.SelectedItems(0).Tag, firma.tbx_Empleado.Text) Then
                MsgBox("Ha ocurrido un error al cancelar la Orden de Compra.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
            Call LlenarLista()
        End If

    End Sub

    Private Sub lsv_Compras_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Compras.MouseHover, lsv_Detalles.MouseHover
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
    End Sub

    Private Sub btn_Mostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Mostrar.Click
        SegundosDesconexion = 0
        If dtp_Desde.Value > dtp_Hasta.Value Then
            MsgBox("Las Fechas no Son Correctas.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        If cmb_Proveedor.SelectedValue = 0 And chk_Proveedores.Checked = False Then
            MsgBox("Seleccione Un Proveedor.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        Call LlenarLista()
    End Sub

    Private Sub chk_Proveedores_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Proveedores.CheckedChanged
        SegundosDesconexion = 0

        lsv_Compras.Items.Clear()
        lsv_Detalles.Items.Clear()
        btn_Cancelar.Enabled = False

        If chk_Proveedores.Checked Then
            tbx_ClaveProveedor.Clear()
            tbx_ClaveProveedor.Enabled = False
            cmb_Proveedor.SelectedValue = 0
            cmb_Proveedor.Enabled = False
        Else
            tbx_ClaveProveedor.Enabled = True
            cmb_Proveedor.Enabled = True
        End If
    End Sub

    Private Sub dtp_Desde_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_Desde.ValueChanged
        SegundosDesconexion = 0

        lsv_Compras.Items.Clear()
        lsv_Detalles.Items.Clear()
        btn_Cancelar.Enabled = False
    End Sub

    Private Sub dtp_Hasta_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_Hasta.ValueChanged
        SegundosDesconexion = 0

        lsv_Compras.Items.Clear()
        lsv_Detalles.Items.Clear()
        btn_Cancelar.Enabled = False
    End Sub

    Private Sub cmb_Proveedor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Proveedor.SelectedIndexChanged
        SegundosDesconexion = 0

        lsv_Compras.Items.Clear()
        lsv_Detalles.Items.Clear()
        btn_Cancelar.Enabled = False
    End Sub
End Class