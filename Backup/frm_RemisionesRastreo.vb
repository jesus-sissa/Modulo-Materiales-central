Imports Modulo_MaterialesCentral.Cn_Materiales

Public Class frm_RemisionesRastreo

    Private Sub frm_RemisionesRastreo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lsv_Materiales.Columns.Add("Clave")
        lsv_Materiales.Columns.Add("Descripcion")
        lsv_Materiales.Columns.Add("Cantidad")

        lsv_Folios.Columns.Add("Inicial")
        lsv_Folios.Columns.Add("Final")
        lsv_Folios.Columns.Add("Cantidad")
    End Sub

    Private Sub tbx_Remision_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbx_Remision.TextChanged
        SegundosDesconexion = 0

        tbx_Fecha.Clear()
        tbx_Hora.Clear()
        tbx_Departamento.Clear()
        tbx_Asigno.Clear()

        lsv_Materiales.Items.Clear()
        lsv_Folios.Items.Clear()
    End Sub

    Private Sub btn_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Buscar.Click
        SegundosDesconexion = 0

        If Val(tbx_Remision.Text) = 0 Then
            MsgBox("Capture el Folio de la Remisión.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Remision.Focus()
            Exit Sub
        End If

        If Not fn_RastreoRemisiones_BuscarFolios(lsv_Folios, tbx_Remision.Text.Trim) Then
            MsgBox("Ha ocurrido un error al intentar buscar la Remisión.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        If lsv_Folios.Items.Count = 0 Then
            MsgBox("No se ha encontrado la Remisión " & tbx_Remision.Text & ".", MsgBoxStyle.Exclamation, frm_MENU.Text)
            tbx_Remision.Focus()
            Exit Sub
        End If

        Dim ID_MatVenta = lsv_Folios.Items(0).Tag

        Dim dt As DataTable = fn_RastreoRemisiones_LlenarLista(ID_MatVenta)
        If dt IsNot Nothing And dt.Rows.Count > 0 Then
            tbx_Fecha.Text = dt.Rows(0)("Fecha")
            tbx_Hora.Text = dt.Rows(0)("Hora")
            tbx_Departamento.Text = dt.Rows(0)("Departamento")
            tbx_Asigno.Text = dt.Rows(0)("Asigno")
        Else
            MsgBox("Ha ocurrido un error al intentar buscar la Remisión.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        'Mostrar el detalle de la asignación de Materiales
        If Not fn_ValidaMaterialesD_LlenarLista(lsv_Materiales, lsv_Materiales.Lvs, ID_MatVenta) Then
            MsgBox("Ha ocurrido un error al intentar consultar el Detalle.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        Else
            lsv_Materiales.Columns(2).TextAlign = HorizontalAlignment.Right
        End If
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        Me.Close()
    End Sub

End Class