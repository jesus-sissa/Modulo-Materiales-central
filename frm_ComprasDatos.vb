Public Class frm_ComprasDatos

    Public Domicilio_Entrega As String = ""
    Public Condiciones_Pago As String = ""


    Private Sub frm_ComprasDatos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tbx_DomicilioEntrega.Text = Domicilio_Entrega
        tbx_CondicionesPago.Text = Condiciones_Pago
    End Sub

    Private Sub btn_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Aceptar.Click
        Domicilio_Entrega = tbx_DomicilioEntrega.Text.Trim
        Condiciones_Pago = tbx_CondicionesPago.Text.Trim
        tbx_DomicilioEntrega.Clear()
        tbx_CondicionesPago.Clear()
        Me.Close()
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        Me.Close()
    End Sub

End Class