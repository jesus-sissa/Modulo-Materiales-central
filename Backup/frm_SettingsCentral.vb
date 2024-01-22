Public Class frm_SettingsCentral

    Private Sub frm_SettingsCentral_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tbx_Servidor.Text = My.Settings.CtrServer.ToString
        tbx_Base.Text = My.Settings.CtrBase.ToString
        tbx_Usuario.Text = My.Settings.CtrUsuario.ToString
        tbx_Clave.Text = Cn_Encripta.fn_Decode(My.Settings.CtrClave.ToString)
    End Sub

    Private Sub tbx_Clave_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbx_Clave.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Call Guardar()
        End If
    End Sub

    Private Sub cmd_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Guardar.Click
        Call Guardar()
    End Sub

    Sub Guardar()
        If tbx_Servidor.Text.Trim = "" Then
            MsgBox("Indique el Nombre o Dirección IP del Servidor Central.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Servidor.Focus()
            Exit Sub
        End If
        If tbx_Base.Text.Trim = "" Then
            MsgBox("Indique el Nombre de la Base de Datos.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Base.Focus()
            Exit Sub
        End If
        If tbx_Usuario.Text.Trim = "" Then
            MsgBox("Indique el Nombre de Usuario o Inicio de Sesión del Servidor.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Usuario.Focus()
            Exit Sub
        End If
        If tbx_Clave.Text.Trim = "" Then
            MsgBox("Indique la Contraseña para la conexión.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Clave.Focus()
            Exit Sub
        End If
        If Not FuncionesGlobales.fn_Valida_Cadena(tbx_Clave.Text.Trim, FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar) Then
            MsgBox("La contraseña contiene caracteres que no son permitidos.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Clave.Focus()
            Exit Sub
        End If

        Try
            My.Settings.CtrServer = tbx_Servidor.Text.Trim
            My.Settings.CtrBase = tbx_Base.Text.Trim
            My.Settings.CtrUsuario = tbx_Usuario.Text.Trim
            My.Settings.CtrClave = Cn_Encripta.fn_Encode(tbx_Clave.Text.Trim)
            My.Settings.Save()
            Cnx_Central = "Data Source=" & tbx_Servidor.Text.Trim & ";Initial Catalog=" & tbx_Base.Text.Trim & ";User Id=" & tbx_Usuario.Text.Trim & ";Password=" & tbx_Clave.Text.Trim & ";"

            Dim cnn As New SqlClient.SqlConnection(Cnx_Central)
            cnn.Open()
            cnn.Close()
            MsgBox("Parámetros guardados correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
            Me.Close()
        Catch ex As Exception
            'FuncionesGlobales.TrataEx(ex, False)
            MsgBox("No se pudo conectar con el Servidor Central verifique los datos de Conexion. " & ex.Message, MsgBoxStyle.Critical, frm_MENU.Text)
        End Try
    End Sub

End Class