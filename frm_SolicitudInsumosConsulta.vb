Imports Modulo_MaterialesCentral.Cn_Materiales

Public Class frm_SolicitudInsumosConsulta
    Dim FechaDesde As Date
    Dim FechaHasta As Date
    Dim ValorStatus As Char
    Dim Usuario_Solicita As Integer

    Private Sub frm_SolicitudInsumosConsulta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        lsv_Solicitudes.Columns.Add("Número")
        lsv_Solicitudes.Columns.Add("Fecha")
        lsv_Solicitudes.Columns.Add("Hora")
        lsv_Solicitudes.Columns.Add("UsuarioSolicita")
        lsv_Solicitudes.Columns.Add("Status")

        lsv_Detalle.Columns.Add("Descripción")
        lsv_Detalle.Columns.Add("CantidadSolicitada")
        lsv_Detalle.Columns.Add("CantidadValidada")
        lsv_Detalle.Columns.Add("CantidadSurtida")
        lsv_Detalle.Columns.Add("Status")

        cmb_Status.AgregarItem("0", "Seleccione...")
        cmb_Status.AgregarItem("A", "PENDIENTE")
        cmb_Status.AgregarItem("V", "VALIDADA")
        cmb_Status.AgregarItem("S", "SURTIDA")
        cmb_Status.AgregarItem("C", "CANCELADA")

        cmb_UsuarioSolicita.Actualizar()
        cmb_UsuarioSolicita.Actualizar()

    End Sub

    Private Sub dtp_Desde_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_Desde.ValueChanged
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0

        lsv_Solicitudes.Items.Clear()
        lsv_Detalle.Items.Clear()
    End Sub

    Private Sub dtp_Hasta_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_Hasta.ValueChanged
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0

        lsv_Solicitudes.Items.Clear()
        lsv_Detalle.Items.Clear()
    End Sub

    Private Sub cmb_Status_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Status.SelectedIndexChanged
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0

        lsv_Solicitudes.Items.Clear()
        lsv_Detalle.Items.Clear()
    End Sub

    Private Sub chk_Todos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Todos.CheckedChanged
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0

        lsv_Solicitudes.Items.Clear()
        lsv_Detalle.Items.Clear()
        If chk_Todos.Checked Then
            cmb_Status.Enabled = False
            cmb_Status.SelectedValue = 0
        Else
            cmb_Status.Enabled = True
        End If
    End Sub

    Private Sub btn_Consultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Consultar.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        Lbl_Registros.Text = "Registros: 0"

        If dtp_Desde.Value.Date > dtp_Hasta.Value.Date Then
            MsgBox("El periodo de fechas parece estar incorrecto.", MsgBoxStyle.Critical, frm_MENU.Text)
            dtp_Desde.Focus()
            Exit Sub
        End If
        FechaDesde = dtp_Desde.Value.Date
        FechaHasta = dtp_Hasta.Value.Date

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

        If cmb_Status.Enabled And cmb_Status.SelectedValue = "0" Then
            MsgBox("Seleccione el Status.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Status.Focus()
            Exit Sub
        Else
            If cmb_Status.Enabled Then
                ValorStatus = cmb_Status.SelectedValue
            Else
                ValorStatus = "T"
            End If
        End If

        If Not fn_ConsultaSolicitudesInsumos_LlenarLista(lsv_Solicitudes, FechaDesde, FechaHasta, ValorStatus, Usuario_Solicita) Then
            MsgBox("Ha ocurrido un error al intentar consultar los datos.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        Lbl_Registros.Text = "Registro: " & lsv_Solicitudes.Items.Count

    End Sub

    Private Sub cmb_UsuarioSolicita_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_UsuarioSolicita.SelectedIndexChanged
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0

        lsv_Solicitudes.Items.Clear()
        lsv_Detalle.Items.Clear()
    End Sub

    Private Sub chk_Usuarios_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Usuarios.CheckedChanged
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0

        lsv_Solicitudes.Items.Clear()
        lsv_Detalle.Items.Clear()
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

    Private Sub lsv_Solicitudes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Solicitudes.SelectedIndexChanged
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        lbl_RegistrosD.Text = "Registros: 0"
        If lsv_Solicitudes.SelectedItems.Count = 0 Then
            lsv_Detalle.Items.Clear()
            Exit Sub
        End If
        If Not fn_ConsultaSolicitudesInsumos_LlenarDetalle(lsv_Detalle, lsv_Solicitudes.SelectedItems(0).Tag) Then
            MsgBox("Ha ocurrido un error al intentar consultar los datos.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        lbl_RegistrosD.Text = "Registros: " & lsv_Detalle.Items.Count
       
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub lsv_Solicitudes_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Solicitudes.MouseHover
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
    End Sub

    Private Sub lsv_Detalle_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Detalle.MouseHover
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
    End Sub

    Private Sub dtp_Desde_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_Desde.KeyPress
        If Asc(e.KeyChar) = 13 Then dtp_Hasta.Focus()
    End Sub

    Private Sub dtp_Hasta_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_Hasta.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If chk_Usuarios.Checked Then chk_Usuarios.Focus() Else tbx_Clave.Focus()
        End If
    End Sub

    Private Sub chk_Todos_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles chk_Todos.KeyPress
        If Asc(e.KeyChar) = 13 Then btn_Consultar.Focus()
    End Sub

    Private Sub chk_Usuarios_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles chk_Usuarios.KeyPress
        If Asc(e.KeyChar) = 13 Then btn_Consultar.Focus()
    End Sub
End Class