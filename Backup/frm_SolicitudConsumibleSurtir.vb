Imports Modulo_MaterialesCentral.Cn_Materiales

Public Class frm_SolicitudConsumibleSurtir
    Dim dt_MatSurtido As DataTable = Nothing

    Private Sub frm_SolicitudConsumibleSurtir_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0

        lsv_Solicitudes.Columns.Add("Número")
        lsv_Solicitudes.Columns.Add("Fecha")
        lsv_Solicitudes.Columns.Add("Hora")
        lsv_Solicitudes.Columns.Add("UsuarioSolicita")
        lsv_Solicitudes.Columns.Add("Status")
        Call LlenarSolicitudes()
    End Sub

    Sub LlenarSolicitudes()
        Dim Usuario_Solicita As Integer = 0
        Dim FechaDesde As Date = #1/1/2010#
        Dim FechaHasta As Date = Now.Date
        Dim ValorStatus As Char = "V"

        If Not fn_ConsultaSolicitudesConsumibles_LlenarLista(lsv_Solicitudes, FechaDesde, FechaHasta, ValorStatus, Usuario_Solicita) Then
            MsgBox("Ha ocurrido un error al intentar consultar los datos.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        Lbl_Registros.Text = "Registros: " & lsv_Solicitudes.Items.Count
    End Sub

    Private Sub btn_Surtir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Surtir.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0

        'Guardar los Datos
        Dim Dt_Guardar As New DataTable
        Dt_Guardar.Columns.Add(New DataColumn("Id_Solicitud", GetType(Integer)))
        Dt_Guardar.Columns.Add(New DataColumn("Id_Consumible", GetType(Integer)))
        Dt_Guardar.Columns.Add(New DataColumn("Descripcion", GetType(String)))
        Dt_Guardar.Columns.Add(New DataColumn("CantidadSolicitada", GetType(Integer)))
        Dt_Guardar.Columns.Add(New DataColumn("CantidadSurtida", GetType(Integer)))
        Dt_Guardar.Columns.Add(New DataColumn("Status", GetType(String)))

        Dim Dr As DataRow

        For Each row As DataGridViewRow In dgv_Detalle.Rows
            Dr = Dt_Guardar.NewRow()
            Dr("Id_Solicitud") = lsv_Solicitudes.SelectedItems(0).Tag
            Dr("Id_Consumible") = row.Cells("Descripcion").Tag
            Dr("Descripcion") = row.Cells("Descripcion").Value.ToString
            Dr("CantidadSolicitada") = row.Cells("Cantidad").Value
            Dr("CantidadSurtida") = row.Cells("CantidadSurtida").Value
            If row.Cells("CantidadSurtida").Value = 0 Then
                Dr("Status") = "C"
            Else
                Dr("Status") = "S"
            End If

            Dt_Guardar.Rows.Add(Dr)
        Next

        If Dt_Guardar.Rows.Count > 0 Then

            If MsgBox("Confirma que desea SURTIR la Solicitud ?", MsgBoxStyle.Question & MsgBoxStyle.YesNo, frm_MENU.Text) = MsgBoxResult.No Then
                Exit Sub
            End If

            If Not fn_SurtirSolicitudConsumibles_Guardar(lsv_Solicitudes.SelectedItems(0).Tag, Dt_Guardar) Then
                MsgBox("Ha Ocurrido un error al intentar guardar los datos.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            Else
                'Envia ALerta al Usuario Solicitante
                Call Correo(Dt_Guardar)
                MsgBox("La Solicitud ha sido marcada como SURTIDA.", MsgBoxStyle.Information, frm_MENU.Text)
            End If
            Call LlenarSolicitudes()
            dgv_Detalle.Rows.Clear()
            btn_Surtir.Enabled = False
        End If

    End Sub

    Sub Correo(ByVal Dt_Datos As DataTable)
        
        Dim DetalleHTML As String = "<html><body><table style='border: solid 1px' width='100%'><tr><td colspan='4' align='center'><b>Boletín Informativo</b></td></tr>" _
                                    & "<tr><td colspan='4' align='center'>NOTIFICACION DE MATERIAL SURTIDO</td></tr>" _
                                    & "<tr><td colspan='4' align='center'><label>Sucursal:</label> " & SucursalN & " </td></tr>" _
                                    & "<tr><td colspan='4' align='center'><label>Fecha Surtido:</label> " & Now.Date.ToShortDateString & " </td></tr>" _
                                    & "<tr><td colspan='4' align='center'><label>Usuario Solicita:</label> " & lsv_Solicitudes.SelectedItems(0).SubItems(3).Text & " </td></tr>" _
                                    & "<tr><td colspan='4'><br><hr/></td></tr></table>" _
                                    & FuncionesGlobales.fn_DatatableToHTML(Dt_Datos, "DETALLE MATERIAL SURTIDO", 2, 1, 10) _
                                    & "<table style='border: solid 1px' width='100%'><tr><td align='right'><label><b>Fecha de Notificación:</b></label></td><td>" & Now.ToShortDateString & " - " & Now.ToShortTimeString & "</td></tr>" _
                                    & "<tr><td colspan='2'><hr/></td></tr><tr><td colspan='2' align='center'>Agente de Servicios SIAC 2012</td></tr></table><br/></body></html>"
        'Si hay una Mail en la fila se manda, si no no.
        If lsv_Solicitudes.SelectedItems(0).SubItems(6).Text <> "" Then
            'If Not Cn_Mail.fn_Enviar_MailHTML("RAUL.COSS@SISSASEGURIDAD.COM", "MATERIAL SURTIDO", DetalleHTML, "") Then
            '    MsgBox("Ha ocurrido un error al intentar Enviar el Correo.", MsgBoxStyle.Critical, Me.Text)
            'End If
            If Not Cn_Mail.fn_Enviar_MailHTML(lsv_Solicitudes.SelectedItems(0).SubItems(6).Text, "MATERIAL SURTIDO", DetalleHTML, "") Then
                MsgBox("Ha ocurrido un error al intentar Enviar el Correo.", MsgBoxStyle.Critical, Me.Text)
            End If
        End If

    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        Me.Close()
    End Sub

    Private Sub lsv_Solicitudes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Solicitudes.SelectedIndexChanged
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0

        If lsv_Solicitudes.SelectedItems.Count = 0 Then
            dgv_Detalle.Rows.Clear()
            btn_Surtir.Enabled = False
            Exit Sub
        End If

        Call LlenarDetalle()
    End Sub

    Sub LlenarDetalle()
        Dim dt_Detalle As DataTable = fn_ValidarSolicitudesConsumibles_LlenarDetalle(lsv_Solicitudes.SelectedItems(0).Tag)
        'Llenar el Grid de Detalle manualmente

        If dt_Detalle Is Nothing Then Exit Sub

        Dim Fila As DataGridViewRow
        Dim Celda As DataGridViewTextBoxCell
        For Each row As DataRow In dt_Detalle.Rows
            Fila = New DataGridViewRow

            Celda = New DataGridViewTextBoxCell
            Celda.Value = row("Descripcion")
            Celda.Tag = row("Id_Consumible")
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

    Private Sub dgv_Detalle_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgv_Detalle.DataError
        If e.ColumnIndex = 3 Then
            MsgBox("Dato no válido. Solo se aceptan números.", MsgBoxStyle.Critical, frm_MENU.Text)
            dgv_Detalle.Rows(e.RowIndex).Cells(3).Selected = True
            dgv_Detalle.CurrentCell = dgv_Detalle.Rows(e.RowIndex).Cells(3)
            dgv_Detalle.BeginEdit(True)
        End If
    End Sub
End Class