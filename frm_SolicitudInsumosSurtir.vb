
Imports Modulo_MaterialesCentral.Cn_Materiales

Public Class frm_SolicitudInsumosSurtir

    Private Sub frm_SolicitudInsumosSurtir_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0

        lsv_Solicitudes.Columns.Add("Número")
        lsv_Solicitudes.Columns.Add("Fecha")
        lsv_Solicitudes.Columns.Add("Hora")
        lsv_Solicitudes.Columns.Add("UsuarioSolicita")
        lsv_Solicitudes.Columns.Add("Status")

        LlenarSolicitudes()
    End Sub

    Sub LlenarSolicitudes()
        Dim Usuario_Solicita As Integer = 0
        Dim FechaDesde As Date = #1/1/2010#
        Dim FechaHasta As Date = Now.Date
        Dim ValorStatus As Char = "V"
        Lbl_Registros.Text = "Registros: 0"

        If Not fn_ConsultaSolicitudesInsumos_LlenarLista(lsv_Solicitudes, FechaDesde, FechaHasta, ValorStatus, Usuario_Solicita) Then
            MsgBox("Ha ocurrido un error al intentar consultar los datos.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        Lbl_Registros.Text = "Registros: " & lsv_Solicitudes.Items.Count
    End Sub

    Private Sub lsv_Solicitudes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Solicitudes.SelectedIndexChanged
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0

        If lsv_Solicitudes.SelectedItems.Count = 0 Then
            dgv_Detalle.Rows.Clear()
            btn_Surtir.Enabled = False
            Exit Sub
        End If

        LlenarDetalle()
    End Sub

    Sub LlenarDetalle()
        Dim dt_Detalle As DataTable = fn_ValidarSolicitudesInsumos_LlenarDetalle(lsv_Solicitudes.SelectedItems(0).Tag)
        'Llenar el Grid de Detalle manualmente
        If dt_Detalle Is Nothing Then Exit Sub

        Dim Fila As DataGridViewRow
        Dim Celda As DataGridViewTextBoxCell
        For Each row As DataRow In dt_Detalle.Rows
            Fila = New DataGridViewRow

            Celda = New DataGridViewTextBoxCell
            Celda.Value = row("Descripcion")
            Celda.Tag = row("Id_Subclase")
            Fila.Cells.Add(Celda)

            Celda = New DataGridViewTextBoxCell
            Celda.ValueType = GetType(Integer)
            Celda.MaxInputLength = 5
            Celda.Value = row("CantidadSolicitada")
            Fila.Cells.Add(Celda)

            Celda = New DataGridViewTextBoxCell
            Celda.ValueType = GetType(Integer)
            Celda.MaxInputLength = 5
            Celda.Value = row("CantidadValidada")
            Fila.Cells.Add(Celda)

            Celda = New DataGridViewTextBoxCell
            Celda.ValueType = GetType(Integer)
            Celda.MaxInputLength = 5
            Celda.Value = row("CantidadValidada")
            Fila.Cells.Add(Celda)

            Celda = New DataGridViewTextBoxCell
            Celda.MaxInputLength = 150
            Celda.Value = ""
            Fila.Cells.Add(Celda)

            Celda = New DataGridViewTextBoxCell
            Celda.Value = row("Status")
            Fila.Cells.Add(Celda)

            dgv_Detalle.Rows.Add(Fila)
        Next

        btn_Surtir.Enabled = dgv_Detalle.Rows.Count > 0
    End Sub

    Private Sub dgv_Detalle_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgv_Detalle.DataError
        If e.ColumnIndex = 3 Then
            MsgBox("Dato no válido. Solo se aceptan números.", MsgBoxStyle.Critical, frm_MENU.Text)
            dgv_Detalle.Rows(e.RowIndex).Cells(3).Selected = True
            dgv_Detalle.CurrentCell = dgv_Detalle.Rows(e.RowIndex).Cells(3)
            dgv_Detalle.BeginEdit(True)
        End If
    End Sub

    Private Sub btn_Surtir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Surtir.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0

        'Guardar los Datos
        Dim Dt As New DataTable
        Dt.Columns.Add(New DataColumn("Id_Solicitud", GetType(Integer)))
        Dt.Columns.Add(New DataColumn("Id_Subclase", GetType(Integer)))
        Dt.Columns.Add(New DataColumn("CantidadSurtida", GetType(Integer)))
        Dt.Columns.Add(New DataColumn("Status", GetType(String)))

        Dim Dr As DataRow

        For Each row As DataGridViewRow In dgv_Detalle.Rows
            Dr = Dt.NewRow()
            Dr("Id_Solicitud") = lsv_Solicitudes.SelectedItems(0).Tag
            'Dr("Id_Subclase") = row.Cells(0).Tag
            Dr("Id_Subclase") = row.Cells("Descripcion").Tag
            'Dr("CantidadValidada") = row.Cells(2).Value
            Dr("CantidadSurtida") = row.Cells("CantidadSurtida").Value
            'If row.Cells(2).Value = 0 Then
            If row.Cells("CantidadSurtida").Value = 0 Then
                Dr("Status") = "C"
            Else
                Dr("Status") = "S"
            End If

            Dt.Rows.Add(Dr)
        Next

        If Dt.Rows.Count > 0 Then
            'Cn_Login.fn_Log_Create("SURTIR SOLICITUDES DE INSUMOS")
            If MsgBox("Confirma que desea SURTIR la Solicitud ?", MsgBoxStyle.Question & MsgBoxStyle.YesNo, frm_MENU.Text) = MsgBoxResult.No Then
                Exit Sub
            End If
            If Not fn_SurtirSolicitudesInsumos_Guardar(lsv_Solicitudes.SelectedItems(0).Tag, Dt) Then
                MsgBox("Ha Ocurrido un error al intentar guardar los datos.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            Else
                MsgBox("La Solicitud ha sido marcada como SURTIDA.", MsgBoxStyle.Information, frm_MENU.Text)
            End If
            LlenarSolicitudes()
            dgv_Detalle.Rows.Clear()
            btn_Surtir.Enabled = False
        End If

    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        Me.Close()
    End Sub

End Class