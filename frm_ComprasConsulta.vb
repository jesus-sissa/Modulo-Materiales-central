Imports Modulo_MaterialesCentral.Cn_Materiales

Public Class frm_ComprasConsulta

    Private Sub frm_ComprasConsulta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lsv_Lista.Columns.Add("Numero")
        lsv_Lista.Columns.Add("Fecha")
        lsv_Lista.Columns.Add("Hora")
        lsv_Lista.Columns.Add("Proveedor")
        lsv_Lista.Columns.Add("Capturo")
        lsv_Lista.Columns.Add("Importe")
        lsv_Lista.Columns.Add("IVA")
        lsv_Lista.Columns.Add("Total")
        lsv_Lista.Columns.Add("Tipo Orden")
        lsv_Lista.Columns.Add("Status")

        lsv_Detalles.Columns.Add("Clave")
        lsv_Detalles.Columns.Add("Descripcion")
        lsv_Detalles.Columns.Add("Precio")
        lsv_Detalles.Columns.Add("Cantidad")
        lsv_Detalles.Columns.Add("Unidad")
        lsv_Detalles.Columns.Add("Importe")

        cmb_Status.AgregarItem("A", "PENDIENTE")
        cmb_Status.AgregarItem("C", "CANCELADA")
        cmb_Status.AgregarItem("V", "VALIDADA")

        cmb_Proveedor.Actualizar()
    End Sub

    Private Sub LimpiarLista()
        lsv_Lista.Items.Clear()
        lsv_Detalles.Items.Clear()
        lbl_Registros.Text = "Registros: 0"
        Lbl_Registros2.Text = "Registros: 0"
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0
        Me.Close()
    End Sub

    Private Sub btn_Mostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Mostrar.Click
        If dtp_Desde.Value > dtp_Hasta.Value Then
            MsgBox("Las Fechas son Incorrectas.", MsgBoxStyle.Critical, frm_MENU.Text)
            dtp_Desde.Focus()
            Exit Sub
        End If

        If cmb_Proveedor.SelectedValue = 0 And chk_Proveedores.Checked = False Then
            MsgBox("Seleccione un Proveedor o marque Todos.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Proveedor.Focus()
            Exit Sub
        End If

        If cmb_Status.SelectedValue = "0" And chk_Status.Checked = False Then
            MsgBox("Seleccione un Status o marque Todos.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Status.Focus()
            Exit Sub
        End If

        If fn_CancelarCompras_LlenarEncabezado(lsv_Lista, dtp_Desde.Value, dtp_Hasta.Value, cmb_Proveedor.SelectedValue, IIf(chk_Status.Checked, "T", cmb_Status.SelectedValue)) = False Then
            MsgBox("Error al Cargar los Registros.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        lbl_Registros.Text = "Registros: " & lsv_Lista.Items.Count
    End Sub

    Private Sub chk_Proveedores_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Proveedores.CheckedChanged
        SegundosDesconexion = 0
        Call LimpiarLista()
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
        Call LimpiarLista()
    End Sub

    Private Sub dtp_Hasta_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_Hasta.ValueChanged
        SegundosDesconexion = 0
        Call LimpiarLista
    End Sub

    Private Sub cmb_Proveedor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Proveedor.SelectedIndexChanged
        SegundosDesconexion = 0
        Call LimpiarLista
    End Sub

    Private Sub cmb_Status_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Status.SelectedIndexChanged
        SegundosDesconexion = 0
        Call LimpiarLista()
    End Sub

    Private Sub chk_Status_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Status.CheckedChanged
        SegundosDesconexion = 0
        Call LimpiarLista()
        If chk_Status.Checked Then
            cmb_Status.SelectedValue = 0
            cmb_Status.Enabled = False
        Else
            cmb_Status.Enabled = True
        End If
    End Sub

    Private Sub lsv_Lista_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Lista.SelectedIndexChanged
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        Lbl_Registros2.Text = "Registros: 0"
        lsv_Detalles.Items.Clear()
        If lsv_Lista.SelectedItems.Count > 0 Then
            If Not Cn_Materiales.fn_CancelarCompras_LlenarDetalle(lsv_Detalles, lsv_Lista.SelectedItems(0).Tag) Then
                MsgBox("Ocurrió un Error al intentar consultar el detalle de la Orden de Compra.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
        End If
        Lbl_Registros2.Text = "Registros: " & lsv_Detalles.Items.Count
    End Sub
End Class