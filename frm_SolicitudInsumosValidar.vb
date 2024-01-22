
Imports Modulo_MaterialesCentral.Cn_Materiales

Public Class frm_SolicitudInsumosValidar

    Dim Usuario_Solicita As Integer
    'Dim FechaDesde As Date = #1/1/2010#
    'Dim FechaHasta As Date = Now.Date
    'Dim ValorStatus As Char = "A"

    Private Sub frm_SolicitudInsumosValidar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0

        lsv_Solicitudes.Columns.Add("Número")
        lsv_Solicitudes.Columns.Add("Fecha")
        lsv_Solicitudes.Columns.Add("Hora")
        lsv_Solicitudes.Columns.Add("UsuarioSolicita")
        lsv_Solicitudes.Columns.Add("Status")

        cmb_UsuarioSolicita.Actualizar()
        chk_Usuarios.Checked = True
        Call LlenarSolicitudes()
    End Sub

    Private Sub chk_Usuarios_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Usuarios.CheckedChanged
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0

        lsv_Solicitudes.Items.Clear()
        dgv_Detalle.Rows.Clear()
        btn_Validar.Enabled = False
        btn_CancelarSolicitud.Enabled = False
        If chk_Usuarios.Checked Then
            cmb_UsuarioSolicita.Enabled = False
            cmb_UsuarioSolicita.SelectedValue = 0
            tbx_Clave.Enabled = False
            tbx_Clave.Text = 0
        Else
            cmb_UsuarioSolicita.Enabled = True
            tbx_Clave.Enabled = True
        End If
    End Sub

    Private Sub cmb_UsuarioSolicita_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_UsuarioSolicita.SelectedIndexChanged
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0

        lsv_Solicitudes.Items.Clear()
        dgv_Detalle.Rows.Clear()
        btn_Validar.Enabled = False
        btn_CancelarSolicitud.Enabled = False
    End Sub

    Private Sub btn_Consultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Consultar.Click
        Call LlenarSolicitudes()
    End Sub

    Private Sub lsv_Solicitudes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Solicitudes.SelectedIndexChanged
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0

        If lsv_Solicitudes.SelectedItems.Count = 0 Then
            dgv_Detalle.Rows.Clear()
            btn_Validar.Enabled = False
            btn_CancelarSolicitud.Enabled = False
            Exit Sub
        End If

        LlenarDetalle()
    End Sub

    Sub LlenarSolicitudes()
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        Lbl_Registros.Text = "Registros: 0"

        dgv_Detalle.Rows.Clear()
        If cmb_UsuarioSolicita.Enabled And cmb_UsuarioSolicita.SelectedValue = "0" Then
            MsgBox("Seleccione un Usuario.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_UsuarioSolicita.Focus()
            Exit Sub
        Else
            If cmb_UsuarioSolicita.Enabled Then
                Usuario_Solicita = cmb_UsuarioSolicita.SelectedValue
            Else
                Usuario_Solicita = 0
            End If
        End If

        If Not fn_ValidarSolicitudesInsumos_LlenarLista(lsv_Solicitudes, Usuario_Solicita) Then
            MsgBox("Ha ocurrido un error al intentar consultar los datos.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        Lbl_Registros.Text = "Registros: " & lsv_Solicitudes.Items.Count
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
            If row("Status") = "PENDIENTE" Then
                Celda.Value = row("CantidadSolicitada")
            Else
                Celda.Value = row("CantidadValidada")
            End If
            Celda.Style.BackColor = Color.LightBlue
            Fila.Cells.Add(Celda)

            Celda = New DataGridViewTextBoxCell
            Celda.MaxInputLength = 150
            Celda.Value = ""
            Celda.Value.ToString.ToUpper()
            Celda.Style.BackColor = Color.LightBlue
            Fila.Cells.Add(Celda)

            Celda = New DataGridViewTextBoxCell
            Celda.Value = row("Status")
            Fila.Cells.Add(Celda)

            dgv_Detalle.Rows.Add(Fila)
        Next

        btn_Validar.Enabled = dgv_Detalle.Rows.Count > 0
        btn_CancelarSolicitud.Enabled = dgv_Detalle.Rows.Count > 0

    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub btn_Validar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Validar.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0

        Dim TotalValidar As Integer = 0

        'Guardar Los Datos
        Dim Dt As New DataTable
        Dt.Columns.Add(New DataColumn("Id_Solicitud", GetType(Integer)))
        Dt.Columns.Add(New DataColumn("Id_Subclase", GetType(Integer)))
        Dt.Columns.Add(New DataColumn("CantidadValidada", GetType(Integer)))
        Dt.Columns.Add(New DataColumn("Observaciones", GetType(String)))
        Dt.Columns.Add(New DataColumn("Status", GetType(String)))

        Dim Dr As DataRow

        For Each row As DataGridViewRow In dgv_Detalle.Rows
            Dr = Dt.NewRow()
            Dr("Id_Solicitud") = lsv_Solicitudes.SelectedItems(0).Tag
            Dr("Id_Subclase") = row.Cells("Descripcion").Tag
            Dr("CantidadValidada") = row.Cells("CantidadValidada").Value
            Dr("Observaciones") = row.Cells("Observaciones").Value

            If row.Cells("CantidadValidada").Value = 0 Then
                Dr("Status") = "C"
            Else
                Dr("Status") = "V"
                TotalValidar = TotalValidar + row.Cells("CantidadValidada").Value
            End If
            Dt.Rows.Add(Dr)
        Next

        Dim StatusSolicitud As Char
        'Se verifica la cantidad total a validar, si todas las cantidades son cero, 
        'la Solicitud se guarda con Status = CANCELADA
        If TotalValidar = 0 Then
            StatusSolicitud = "C"
        Else
            StatusSolicitud = "V"
        End If

        If Dt.Rows.Count > 0 Then
            'Cn_Login.fn_Log_Create("VALIDAR SOLICITUDES DE INSUMOS")
            If MsgBox("Confirma que desea VALIDAR la Solicitud ?", MsgBoxStyle.Question & MsgBoxStyle.YesNo, frm_MENU.Text) = MsgBoxResult.No Then
                Exit Sub
            End If
            If Not fn_ValidarSolicitudesInsumos_Guardar(lsv_Solicitudes.SelectedItems(0).Tag, Dt, StatusSolicitud) Then
                MsgBox("Ha Ocurrido un error al intentar guardar los datos.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
            LlenarSolicitudes()
            dgv_Detalle.Rows.Clear()
            btn_Validar.Enabled = False
            btn_CancelarSolicitud.Enabled = False
            TotalValidar = 0
            StatusSolicitud = ""
        End If
    End Sub

    Private Sub dgv_Detalle_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgv_Detalle.DataError
        If e.ColumnIndex = 2 Then
            MsgBox("Dato no válido. Solo se aceptan números.", MsgBoxStyle.Critical, frm_MENU.Text)
            dgv_Detalle.Rows(e.RowIndex).Cells(2).Selected = True
            dgv_Detalle.CurrentCell = dgv_Detalle.Rows(e.RowIndex).Cells(2)
            dgv_Detalle.BeginEdit(True)
        End If
    End Sub

    Private Sub lsv_Solicitudes_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Solicitudes.MouseHover
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
    End Sub

    Private Sub dgv_Detalle_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgv_Detalle.MouseHover
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
    End Sub

    Private Sub btn_CancelarSolicitud_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_CancelarSolicitud.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0

        'Guardar Los Datos
        Dim Dt As New DataTable
        Dt.Columns.Add(New DataColumn("Id_Solicitud", GetType(Integer)))
        Dt.Columns.Add(New DataColumn("Id_Subclase", GetType(Integer)))

        Dim Dr As DataRow

        For Each row As DataGridViewRow In dgv_Detalle.Rows
            Dr = Dt.NewRow()
            Dr("Id_Solicitud") = lsv_Solicitudes.SelectedItems(0).Tag
            'Dr("Id_Subclase") = row.Cells(0).Tag
            Dr("Id_Subclase") = row.Cells("Descripcion").Tag
            'Dr("CantidadValidada") = row.Cells(2).Value

            Dt.Rows.Add(Dr)
        Next

        If Dt.Rows.Count > 0 Then
            'Cn_Login.fn_Log_Create("CANCELAR SOLICITUDES DE INSUMOS")
            If MsgBox("Confirma que desea CANCELAR la Solicitud ?", MsgBoxStyle.Question & MsgBoxStyle.YesNo, frm_MENU.Text) = MsgBoxResult.No Then
                Exit Sub
            End If
            If Not fn_ValidarSolicitudesInsumos_Cancelar(lsv_Solicitudes.SelectedItems(0).Tag, Dt) Then
                MsgBox("Ha Ocurrido un error al intentar guardar los datos.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            Else
                MsgBox("La Solicitud ha sido marcada como CANCELADA.", MsgBoxStyle.Information, frm_MENU.Text)
            End If
            LlenarSolicitudes()
            dgv_Detalle.Rows.Clear()
            btn_Validar.Enabled = False
            btn_CancelarSolicitud.Enabled = False

        End If
    End Sub

    Private Sub chk_Usuarios_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles chk_Usuarios.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btn_Consultar.Focus()
        End If
    End Sub
End Class