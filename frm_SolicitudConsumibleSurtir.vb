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
        Dt_Guardar.Columns.Add(New DataColumn("CantidadValidada", GetType(Integer)))
        Dt_Guardar.Columns.Add(New DataColumn("CantidadSurtida", GetType(Integer)))
        Dt_Guardar.Columns.Add(New DataColumn("Status", GetType(String)))
        Dt_Guardar.Columns.Add(New DataColumn("Faltantes", GetType(Integer)))
        Dt_Guardar.Columns.Add(New DataColumn("Acumulador", GetType(Integer)))


        Dim Dr As DataRow

        For Each row As DataGridViewRow In dgv_Detalle.Rows
            Dr = Dt_Guardar.NewRow()
            Dr("Id_Solicitud") = lsv_Solicitudes.SelectedItems(0).Tag
            Dr("Id_Consumible") = row.Cells("Descripcion").Tag
            Dr("Descripcion") = row.Cells("Descripcion").Value.ToString
            Dr("CantidadValidada") = row.Cells("CantidadValidada").Value
            Dr("Faltantes") = 0
            Dr("Acumulador") = 0
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

            If Not fn_SurtirSolicitudMaterial_Local(lsv_Solicitudes.SelectedItems(0).Tag, "S", Dt_Guardar) Then
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

        Dim DetalleHTML As String = "<html><body style=font-family: 'Lucida Console', 'Courier New', monospace; > <Table style=background-color: '#E3DFD9;' width='100%'><tr><td colspan='4' align='center'><b style='color: #D68910;'>Boletín Informativo</b></td></tr>" _
                                    & "<tr><td colspan='4' align='center'><b style='color: #D68910;'>NOTIFICACION DE MATERIAL SURTIDO </b></td></tr>" _
                                    & "<tr><td colspan='4' align='center'><label>Sucursal:</label> " & SucursalN & " </td></tr>" _
                                    & "<tr><td colspan='4' align='center'><label>Fecha Surtido:</label> " & Now.Date.ToShortDateString & " </td></tr>" _
                                    & "<tr><td colspan='4' align='center'><label>Usuario Solicita:</label> " & lsv_Solicitudes.SelectedItems(0).SubItems(3).Text & " </td></tr>" _
                                    & "<tr><td colspan='4'><br><hr/></td></tr></Table>" _
                                    & FuncionesGlobales.fn_DatatableToHTML(Dt_Datos, "DETALLE MATERIAL SURTIDO", 2, 0, 13) _
                                    & "<table style='background-color: #E3DFD9; ' width='100%'><tr><td align='center'><label><b>Fecha de Notificación:</b></label></td><td>" & Now.ToShortDateString & " - " & Now.ToShortTimeString & "</td></tr>" _
                                    & "<tr><td colspan='2'><hr/></td></tr><tr><td style='color: #D68910; font-size: 20PX;' colspan='2' align='center'>Agente de Servicios SIAC 2012</td></tr></table><br/></body></html>"
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
            btn_CancelarSolicitud.Enabled = False

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
            Celda.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            Celda.MaxInputLength = 5
            If row("Status") = "VALIDADA" Then
                Celda.Value = row("CantidadValidada")
            Else

                Celda.Value = row("CantidadSurtida")

            End If
            Celda.Style.BackColor = Color.LightBlue
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
        btn_CancelarSolicitud.Enabled = dgv_Detalle.Rows.Count > 0
    End Sub

    Private Sub dgv_Detalle_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgv_Detalle.DataError
        If e.ColumnIndex = 3 Then
            MsgBox("Dato no válido. Solo se aceptan números.", MsgBoxStyle.Critical, frm_MENU.Text)
            dgv_Detalle.Rows(e.RowIndex).Cells(3).Selected = True
            dgv_Detalle.CurrentCell = dgv_Detalle.Rows(e.RowIndex).Cells(3)
            dgv_Detalle.BeginEdit(True)
        End If
    End Sub

    Private Sub Gbx_Lista_Enter(sender As Object, e As EventArgs) Handles Gbx_Lista.Enter

    End Sub
    Private Sub dgv_Detalle_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Detalle.CellClick
        SegundosDesconexion = 0
        If dgv_Detalle.Columns(e.ColumnIndex).Name = "Quitar" Then
            dgv_Detalle.Rows.Remove(dgv_Detalle.CurrentRow)

        End If
    End Sub

    Private Sub dgv_Detalle_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgv_Detalle.EditingControlShowing
        ' referencia a la celda   
        Dim validar As TextBox = CType(e.Control, TextBox)

        ' agregar el controlador de eventos para el KeyPress   
        AddHandler validar.KeyPress, AddressOf ValidarTexbox_Keypress

    End Sub

    Private Sub ValidarTexbox_Keypress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        ' obtener indice de la columna   
        Dim columna As Integer = dgv_Detalle.CurrentCell.ColumnIndex

        If dgv_Detalle.Columns(columna).Name = "CantidadSurtida" OrElse dgv_Detalle.Columns(columna).Name = "Cantidad" Then
            If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
                e.Handled = True 'no escribe nmo avanza el carro '

            End If
        End If
        If dgv_Detalle.Columns(columna).Name = "Observaciones" Then
            If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
                e.KeyChar = Char.ToUpper(e.KeyChar) 'va connviertiendo a MAYUSCULAS
            End If
        End If

    End Sub

    Private Sub btn_CancelarSolicitud_Click(sender As Object, e As EventArgs) Handles btn_CancelarSolicitud.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0

        'Guardar Los Datos
        Dim Dt As New DataTable
        Dt.Columns.Add(New DataColumn("Id_Solicitud", GetType(Integer)))
        Dt.Columns.Add(New DataColumn("Id_Consumible", GetType(Integer)))

        Dim Dr As DataRow

        For Each row As DataGridViewRow In dgv_Detalle.Rows
            Dr = Dt.NewRow()
            Dr("Id_Solicitud") = lsv_Solicitudes.SelectedItems(0).Tag
            'Dr("Id_Subclase") = row.Cells(0).Tag
            Dr("Id_Consumible") = row.Cells("Descripcion").Tag
            'Dr("CantidadValidada") = row.Cells(2).Value

            Dt.Rows.Add(Dr)
        Next

        If Dt.Rows.Count > 0 Then

            If MsgBox("Confirma que desea CANCELAR la Solicitud ?", MsgBoxStyle.Question & MsgBoxStyle.YesNo, frm_MENU.Text) = MsgBoxResult.No Then
                Exit Sub
            End If
            If Not fn_ValidarSolicitudesConsumibles_Cancelar(lsv_Solicitudes.SelectedItems(0).Tag, Dt) Then
                MsgBox("Ha Ocurrido un error al intentar guardar los datos.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            Else
                MsgBox("La Solicitud ha sido marcada como CANCELADA.", MsgBoxStyle.Information, frm_MENU.Text)
            End If
            LlenarSolicitudes()
            dgv_Detalle.Rows.Clear()
            btn_Surtir.Enabled = False
            btn_CancelarSolicitud.Enabled = False

        End If
    End Sub
End Class