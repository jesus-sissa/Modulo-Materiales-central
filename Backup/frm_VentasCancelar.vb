Public Class frm_VentasCancelar

    Private Sub frm_Cancela_Ventas_Materiales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Lsv_Ventas.Columns.Add("Fecha")
        Lsv_Ventas.Columns.Add("Hora")
        Lsv_Ventas.Columns.Add("Destino")
        Lsv_Ventas.Columns.Add("Status")

        lsv_VentasD.Columns.Add("Clave")
        lsv_VentasD.Columns.Add("Descripcion")
        lsv_VentasD.Columns.Add("Cantidad")

        lsv_Folios.Columns.Add("Inicial")
        lsv_Folios.Columns.Add("Final")
        lsv_Folios.Columns.Add("Cantidad")

        Call LlenarLista()
    End Sub

    Sub LlenarLista()
        lsv_VentasD.Items.Clear()
        Lsv_Ventas.Items.Clear()
        lsv_Folios.Items.Clear()

        Cn_Materiales.fn_fn_CancelaMateriales_LlenarLista(Lsv_Ventas, "SO")
        Lsv_Ventas.CheckBoxes = True
        Lbl_Registros.Text = "Registros: " & Lsv_Ventas.Items.Count
    End Sub

    Private Sub lsv_Ventas_ItemChecked(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckedEventArgs) Handles Lsv_Ventas.ItemChecked
        btn_Cancelar.Enabled = Lsv_Ventas.CheckedItems.Count > 0
    End Sub

    Private Sub lsv_Ventas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lsv_Ventas.SelectedIndexChanged
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0

        If Lsv_Ventas.SelectedItems.Count = 0 Then
            lsv_VentasD.Items.Clear()
            lsv_Folios.Items.Clear()
            Exit Sub
        Else
            'Mostrar el detalle de la asignación de Materiales seleccionada
            If Not Cn_Materiales.fn_ValidaMaterialesD_LlenarLista(lsv_VentasD, lsv_VentasD.Lvs, Lsv_Ventas.SelectedItems(0).Tag) Then
                MsgBox("Ha ocurrido un error al intentar consultar el Detalle.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            Else
                lsv_VentasD.Columns(2).TextAlign = HorizontalAlignment.Right
            End If
            'Mostrar los Folios de Remisiones asignadas
            If Not Cn_Materiales.fn_ReporteAsignaciones_DetalleFolios(lsv_Folios, Lsv_Ventas.SelectedItems(0).Tag) Then
                MsgBox("Ha ocurrido un error al intentar consultar los Folios de Remisiones asignadas.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
        End If
    End Sub

    Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0

        Dim frm As New frm_FirmaElectronica
        Dim Elementos As ListViewItem
        If Lsv_Ventas.CheckedItems.Count = 0 Then
            MsgBox("Seleccione por lo menos una Asignación.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        frm.Empleado = UsuarioId
        frm.Bloquear = False
        frm.PedirObservaciones = True
        frm.ShowDialog()

        If frm.Firma = True Then
            Try
                'Validar que aún sigan en Status='SO'
                For Each Elementos In Lsv_Ventas.CheckedItems
                    'Tipo 0 es el Inventario de Materiales Central
                    If Not Cn_Materiales.fn_AceptaMateriales_ValidaStatus(Elementos.Tag, "SO") Then
                        MsgBox("Algunos lotes ya no están disponibles. Es posible que ya se hayan recibido o que otro usuario los haya cancelado desde otra estación de trabajo. Se actualizará la lista.", MsgBoxStyle.Exclamation, frm_MENU.Text)
                        Call LlenarLista()
                        Exit Sub
                    End If
                Next
                'Cancelar las Ventas
                For Each Elementos In Lsv_Ventas.CheckedItems
                    'Tipo 0 es el Inventario de Materiales Central
                    If Not Cn_Materiales.fn_CancelaMateriales(Elementos.Tag, 0, frm.Observaciones) Then
                        MsgBox("Ocurrió un error al intentar cancelar una Asignación.", MsgBoxStyle.Critical, frm_MENU.Text)
                        Exit Sub
                    End If
                Next
            Catch ex As Exception

            End Try
            MsgBox("Operacion Exitosa", MsgBoxStyle.Information, frm_MENU.Text)
            Call LlenarLista()
        End If

    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub Lsv_Ventas_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lsv_Ventas.MouseHover, lsv_VentasD.MouseHover
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
    End Sub
End Class