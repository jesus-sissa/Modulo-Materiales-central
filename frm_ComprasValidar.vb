Public Class frm_ComprasValidar

    Private Sub frm_ValidarCompras_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        dtp_FechaFactura.Value = DateTime.Now
        cmb_Proveedor.Actualizar()
    End Sub

    Sub LlenarLista()
        SegundosDesconexion = 0

        lsv_Compras.Items.Clear()
        btn_Validar.Enabled = False
        Ds.Mat_ComprasD_Get.Rows.Clear()
        If Not Cn_Materiales.fn_ValidarCompras_LlenarEncabezado(lsv_Compras, dtp_Desde.Value, dtp_Hasta.Value, cmb_Proveedor.SelectedValue) Then
            MsgBox("Ha ocurrido un error al al consultar las Compras Pendientes.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
        Lbl_Registros.Text = "Registros: " & lsv_Compras.Items.Count
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0
        Me.Close()
    End Sub

    Private Function Validar() As Boolean
        SegundosDesconexion = 0
        If lsv_Compras.SelectedItems.Count = 0 Then
            MsgBox("Debe seleccionar una orden de Compra.", MsgBoxStyle.Critical, frm_MENU.Text)
            lsv_Compras.Focus()
            Return False
        End If

        If tbx_FolioFactura.Text = "" Then
            MsgBox("Debe indicar el Folio de la Factura.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_FolioFactura.Focus()
            Return False
        End If

        If tbx_ImporteFactura.Text = "" Then
            MsgBox("Debe indicar el Importe de la Factura.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_ImporteFactura.Focus()
            Return False
        End If

        'sumar el importe del GridView y compararlo contra el importe de la factura
        'Si el importe de la factura es >0 y el importe del grid es =0 avisarle al usuario.
        Dim Importe As Decimal = 0.0

        For Each fila As DataGridViewRow In dgv_Detalle.Rows

            'cantidad surtida x precio surtido
            If IsDBNull(fila.Cells("CantidadSurtidaDataGridViewTextBoxColumn").Value) Then
                fila.Cells("CantidadSurtidaDataGridViewTextBoxColumn").Value = 0
            End If

            If IsDBNull(fila.Cells("PrecioSurtidoDataGridViewTextBoxColumn").Value) Then
                fila.Cells("PrecioSurtidoDataGridViewTextBoxColumn").Value = 0
            End If

            Importe += (fila.Cells("CantidadSurtidaDataGridViewTextBoxColumn").Value * _
                        fila.Cells("PrecioSurtidoDataGridViewTextBoxColumn").Value)
            'Importe += (fila.Cells(7).Value * fila.Cells(8).Value)
        Next
        If Importe = 0 And CDec(tbx_ImporteFactura.Text) > 0 Then
            MsgBox("El importe de la Factura es Mayor que cero y la cantidad de Materiales comprados es Igual a Cero.", MsgBoxStyle.Critical, frm_MENU.Text)
            Return False
        End If
        Return True
    End Function


    Private Sub lsv_Compras_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Compras.SelectedIndexChanged
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        tbx_FolioFactura.Clear()
        tbx_ImporteFactura.Clear()
        Ds.Mat_ComprasD_Get.Clear()
        btn_Validar.Enabled = lsv_Compras.SelectedItems.Count > 0
        If lsv_Compras.SelectedItems.Count > 0 Then
            If Not Cn_Materiales.fn_ValidarCompras_LlenarDetalle(Ds.Mat_ComprasD_Get, lsv_Compras.SelectedItems(0).Tag) Then
                MsgBox("Ocurrió un Error al intentar consultar el detalle de la Orden de Compra.", MsgBoxStyle.Critical, frm_MENU.Text)
            End If
        End If
    End Sub

    Private Sub btn_Validar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Validar.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0

        If Validar() Then
            Dim firma As New frm_FirmaElectronica
            firma.ShowDialog()
            firma.PedirObservaciones = False
            If firma.Firma Then
                If Not Cn_Materiales.fn_ValidarCompras_Validar(lsv_Compras.SelectedItems(0).Tag, CInt(lsv_Compras.SelectedItems(0).SubItems(8).Text), tbx_FolioFactura.Text, tbx_ImporteFactura.Text, _
                                                           dtp_FechaFactura.Value, Ds.Mat_ComprasD_Get, firma.tbx_Empleado.Text) Then
                    MsgBox("Ocurrió un Error al validar la Compra.", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                End If
                tbx_FolioFactura.Clear()
                tbx_ImporteFactura.Clear()
                Call LlenarLista()
            End If
        End If
    End Sub

    Private Sub lsv_Compras_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Compras.MouseHover
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
    End Sub

    Private Sub dtp_FechaFactura_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_FechaFactura.ValueChanged
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
    End Sub

    Private Sub dgv_Detalle_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgv_Detalle.DataError
        SegundosDesconexion = 0
        If e.ColumnIndex = 7 Then
            MsgBox("Dato no válido. Solo se aceptan números.", MsgBoxStyle.Critical, frm_MENU.Text)
            dgv_Detalle.Rows(e.RowIndex).Cells(7).Selected = True
            dgv_Detalle.CurrentCell = dgv_Detalle.Rows(e.RowIndex).Cells(7)
            dgv_Detalle.BeginEdit(True)
        ElseIf e.ColumnIndex = 8 Then
            MsgBox("Dato no válido. Solo se aceptan números.", MsgBoxStyle.Critical, frm_MENU.Text)
            dgv_Detalle.Rows(e.RowIndex).Cells(8).Selected = True
            dgv_Detalle.CurrentCell = dgv_Detalle.Rows(e.RowIndex).Cells(8)
            dgv_Detalle.BeginEdit(True)
        End If
    End Sub

    Private Sub dgv_Detalle_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgv_Detalle.EditingControlShowing
        SegundosDesconexion = 0
        ' referencia a la celda   
        Dim validar As TextBox = CType(e.Control, TextBox)

        ' agregar el controlador de eventos para el KeyPress   
        AddHandler validar.KeyPress, AddressOf ValidarTexbox_Keypress
    End Sub

    Private Sub ValidarTexbox_Keypress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        SegundosDesconexion = 0
        ' obtener indice de la columna   
        Dim columna As Integer = dgv_Detalle.CurrentCell.ColumnIndex
        Dim txtcelda As TextBox = CType(sender, TextBox)

        If columna = 7 OrElse columna = 8 Then 'Valida solo para decimales y enteros
            If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar) OrElse e.KeyChar = "." _
              AndAlso txtcelda.Text.Contains(".") = False) Then
                e.Handled = True 'no escribe NO avanza el carro 
            End If
        End If

        If columna = 9 Then
            e.KeyChar = Char.ToUpper(e.KeyChar) 'va connviertiendo a MAYUSCULAS
        End If

    End Sub

    Private Sub btn_Mostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Mostrar.Click
        If dtp_Desde.Value > dtp_Hasta.Value Then
            MsgBox("Las Fechas no Son Correctas", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        If cmb_Proveedor.SelectedValue = 0 And chk_Proveedores.Checked = False Then
            MsgBox("Seleccione Un Proveedor", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        Call LlenarLista()
    End Sub

    Private Sub dtp_Desde_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_Desde.ValueChanged
        SegundosDesconexion = 0

        lsv_Compras.Items.Clear()
        btn_Validar.Enabled = False
    End Sub

    Private Sub dtp_Hasta_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_Hasta.ValueChanged
        SegundosDesconexion = 0

        lsv_Compras.Items.Clear()
        btn_Validar.Enabled = False
    End Sub

    Private Sub cmb_Proveedor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Proveedor.SelectedIndexChanged
        SegundosDesconexion = 0

        lsv_Compras.Items.Clear()
        btn_Validar.Enabled = False
    End Sub

    Private Sub chk_Proveedores_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Proveedores.CheckedChanged
        SegundosDesconexion = 0

        lsv_Compras.Items.Clear()
        btn_Validar.Enabled = False

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
End Class