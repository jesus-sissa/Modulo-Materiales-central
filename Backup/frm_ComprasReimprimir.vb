Public Class frm_ComprasReimprimir

    Private Sub frm_ReimprimirCompras_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtp_Desde.Value = DateTime.Now
        dtp_Hasta.Value = DateTime.Now
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

    Sub LimpiarListas()
        SegundosDesconexion = 0
        lsv_Compras.Items.Clear()
        lsv_Detalles.Items.Clear()
        Lbl_Registros.Text = "Registros: 0"
        Lbl_Registros2.Text = "Registros: 0"
        btn_Reimprimir.Enabled = False
    End Sub

    Sub LlenarLista()
        Call LimpiarListas()
        If Not Cn_Materiales.fn_ReimprimirCompras_LlenarLista(lsv_Compras, dtp_Desde.Value.Date, dtp_Hasta.Value.Date, cmb_Proveedor.SelectedValue) Then
            MsgBox("Ha ocurrido un error al llenar el listview", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
        Lbl_Registros.Text = "Registros: " & lsv_Compras.Items.Count

    End Sub

    Private Sub lsv_Compras_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Compras.SelectedIndexChanged
        SegundosDesconexion = 0
        Lbl_Registros2.Text = "Registros: 0"
        lsv_Detalles.Items.Clear()
        btn_Reimprimir.Enabled = lsv_Compras.SelectedItems.Count > 0
        If lsv_Compras.SelectedItems.Count > 0 Then
            If Not Cn_Materiales.fn_CancelarCompras_LlenarDetalle(lsv_Detalles, lsv_Compras.SelectedItems(0).Tag) Then
                MsgBox("Ha ocurrido un error al consultar el detalle de la Orden de Compra.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
        End If
        Lbl_Registros2.Text = "Registros: " & lsv_Detalles.Items.Count
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0
        Me.Close()
    End Sub

    Private Sub btn_Reimprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Reimprimir.Click, lsv_Compras.DoubleClick
        SegundosDesconexion = 0
        If lsv_Compras.SelectedItems.Count = 0 Then
            MsgBox("Debe seleccionar una Orden de Compra para Reimprimir.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        Me.Cursor = Cursors.WaitCursor
        Dim frm As New frm_Reporte
        frm.crv.ReportSource = Cn_Materiales.fn_Compras_GenerarReporte(lsv_Compras.SelectedItems(0).Tag)
        Me.Cursor = Cursors.Default
        frm.ShowDialog()
    End Sub

    Private Sub dtp_Desde_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_Desde.ValueChanged
        Call LimpiarListas()
    End Sub

    Private Sub dtp_Hasta_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_Hasta.ValueChanged
        Call LimpiarListas()
    End Sub

    Private Sub cmb_Proveedor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Proveedor.SelectedIndexChanged
        Call LimpiarListas()
    End Sub

    Private Sub chk_Proveedoress_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Proveedores.CheckedChanged
        Call LimpiarListas()

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

    Private Sub btn_Mostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Mostrar.Click
        SegundosDesconexion = 0

        If dtp_Desde.Value.Date > dtp_Hasta.Value.Date Then
            MsgBox("El rango de fechas parece ser incorrecto.", MsgBoxStyle.Critical, frm_MENU.Text)
            dtp_Desde.Focus()
            Exit Sub
        End If

        If cmb_Proveedor.Enabled And cmb_Proveedor.SelectedValue = 0 Then
            MsgBox("Seleccione el Proveedor.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Proveedor.Focus()
            Exit Sub
        End If

        Call LlenarLista()
    End Sub

End Class