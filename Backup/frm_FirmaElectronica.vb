Imports System.Web.Security

Public Class frm_FirmaElectronica
    Public Empleado As Integer = 0
    Public Bloquear As Boolean = False
    Private Veces As Integer = 0
    Public Firma As Boolean
    Public Id_Usuario As Integer
    Public Num_Usuario As String
    Public PedirObservaciones As Boolean = False
    Public Observaciones As String = ""
    Public LongitudObservaciones As Integer = 150

    Private Sub frm_FirmaElectronica_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        SegundosDesconexion = 0
        If e.KeyData = Keys.F2 Then
            Call Validar()
        ElseIf e.KeyData = Keys.Escape Then
            Firma = False
            Me.Close()
        End If
    End Sub

    Private Sub frm_FirmaElectronica_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Firma = False
        If Bloquear = True Then
            tbx_Empleado.Text = Empleado
            tbx_Empleado.Enabled = False
            tbx_Contraseña.Focus()
        Else
            tbx_Empleado.Text = ""
            tbx_Empleado.Enabled = True
            tbx_Empleado.Focus()
        End If
        tbx_Observaciones.Clear()
        gbx_Observaciones.Enabled = PedirObservaciones
        lbl_Longitud.Text = "Máximo " & LongitudObservaciones.ToString & " Caracteres."
        tbx_Observaciones.MaxLength = LongitudObservaciones
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0
        Firma = False
        Me.Close()
    End Sub

    Private Sub btn_Validar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Validar.Click
        SegundosDesconexion = 0
        Call Validar()
    End Sub

    Private Sub tbx_Contraseña_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbx_Contraseña.KeyPress
        If Asc(e.KeyChar) = 13 Then
            SegundosDesconexion = 0
            If Tbx_Observaciones.Enabled Then
                Tbx_Observaciones.Focus()
            Else
                Call Validar()
            End If
        End If
    End Sub

    Sub Validar()
        Dim Contra As String = tbx_Contraseña.Text

        If tbx_Empleado.Text.Trim = "" Then
            MsgBox("Indique el ID de Empleado.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Empleado.Focus()
            Exit Sub
        End If
        If Not FuncionesGlobales.fn_Valida_Cadena(tbx_Empleado.Text.Trim, FuncionesGlobales.Validar_Cadena.Numeros_Enteros) Then
            MsgBox("'" & tbx_Empleado.Text.Trim & "', No es un ID de Empleado válido.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        If Contra = "" Then
            MsgBox("Indique la Contraseña.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Contraseña.Focus()
            Exit Sub
        End If
        If Not FuncionesGlobales.fn_Valida_Cadena(Contra, FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar) Then
            MsgBox("Indique una Contraseña válida.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Contraseña.Focus()
            Exit Sub
        End If
        If PedirObservaciones And Tbx_Observaciones.Text.Length = 0 Then
            MsgBox("Debe indicar Observaciones.", MsgBoxStyle.Critical, frm_MENU.Text)
            Tbx_Observaciones.Focus()
            Exit Sub
        End If
        If PedirObservaciones And Tbx_Observaciones.Text.Length < 10 Then
            MsgBox("Debe indicar Observaciones mas descriptivas.", MsgBoxStyle.Critical, frm_MENU.Text)
            Tbx_Observaciones.Focus()
            Exit Sub
        End If
        tbx_Contraseña.Text = ""
        Veces = Veces + 1
        If Veces > Intentos_Login Then
            ResP = Cn_Login.Usuarios_Bloquear(Integer.Parse(tbx_Empleado.Text.Trim))
            If ResP > 0 Then
                MsgBox("Usted ha sido Bloqueado por exceder los Intentos de Entrada.", MsgBoxStyle.Critical, frm_MENU.Text)
                Veces = 0
                Exit Sub
            Else
                MsgBox("Usted ha excedido los Intentos de Entrada.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
        End If
        Dim DT As DataTable = Cn_Login.Usuarios_Read(Integer.Parse(tbx_Empleado.Text.Trim))
        If DT.Rows.Count = 0 Then
            MsgBox("Usuario no encontrado.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        Else
            ContraHash = FormsAuthentication.HashPasswordForStoringInConfigFile(Contra, "SHA1")
            If DT.Rows(0)("Password") <> ContraHash Then
                DT.Dispose()
                MsgBox("Usuario o Contraseña Incorrecta.", MsgBoxStyle.Critical, frm_MENU.Text)
                tbx_Contraseña.Focus()
                Exit Sub
            ElseIf DT.Rows(0)("Status") <> "A" Then
                DT.Dispose()
                MsgBox("Usuario Bloqueado. Imposible Continuar, Consulte al Administrador.", MsgBoxStyle.Critical, frm_MENU.Text)
                tbx_Contraseña.Focus()
                Exit Sub
            ElseIf DT.Rows(0)("Dias_Expira") < 1 Then
                MsgBox("La Contraseña está expirada. Imposible Continuar, Consulte al Administrador.", MsgBoxStyle.Critical, frm_MENU.Text)
                DT.Dispose()
                tbx_Contraseña.Focus()
                Exit Sub
            Else
                Firma = True
                Veces = 0
            End If
        End If
        Observaciones = Tbx_Observaciones.Text.Trim
        Me.Close()
    End Sub



End Class