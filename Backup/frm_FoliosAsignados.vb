Public Class frm_FoliosAsignados
    Public Cantidad As Integer = 0
    Public Folios As String = ""
    Public Validado As Boolean = False
    Public Id_Inventario As Integer

    Private Sub frm_RotulaCantidad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lsv_Datos.Columns.Clear()
        lsv_Datos.Columns.Add("Folio Inicial", 20, HorizontalAlignment.Right)
        lsv_Datos.Columns.Add("Folio Final", 20, HorizontalAlignment.Right)
        lsv_Datos.Columns.Add("Cantidad", 20, HorizontalAlignment.Right)
        FuncionesGlobales.fn_Columna(lsv_Datos, 30, 30, 30, 0, 0, 0, 0, 0, 0, 0)

        tbx_Comprobantes.Text = Cantidad
    End Sub

    Private Sub btn_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Agregar.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0

        Dim Total As Integer = 0
        If tbx_FolioI.Text = "" Or tbx_FolioI.Text = "0" Then
            MsgBox("Capture el Folio Inicial.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_FolioI.Focus()
            Exit Sub
        End If
        If tbx_FolioF.Text = "" Or tbx_FolioF.Text = "0" Then
            MsgBox("Capture el Folio Final.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_FolioF.Focus()
            Exit Sub
        End If
        If CInt(tbx_FolioI.Text) > CInt(tbx_FolioF.Text) Then
            MsgBox("Los folios parecen ser incorrectos.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_FolioF.Focus()
            Exit Sub
        End If
        'revisar si los folio no se traslapan
        For Each elemento As ListViewItem In lsv_Datos.Items
            If (CLng(tbx_FolioI.Text) >= CLng(elemento.Text)) And (CLng(tbx_FolioI.Text) <= CLng(elemento.SubItems(1).Text)) Then
                MsgBox("Los folios parecen ser incorrectos o se traslapan con los ya capturados.", MsgBoxStyle.Critical, frm_MENU.Text)
                tbx_FolioF.Focus()
                Exit Sub
            End If
            If (CLng(tbx_FolioF.Text) >= CLng(elemento.Text)) And (CLng(tbx_FolioF.Text) <= CLng(elemento.SubItems(1).Text)) Then
                MsgBox("Los folios parecen ser incorrectos o se traslapan con los ya capturados.", MsgBoxStyle.Critical, frm_MENU.Text)
                tbx_FolioF.Focus()
                Exit Sub
            End If
        Next
        'Consultar si los folios capturados no se han vendido ya antes a otro cliente
        Dim Dt As DataTable
        Dim Cantidad As Integer = CInt(tbx_FolioF.Text.Trim) - CInt(tbx_FolioI.Text.Trim) + 1
        Dim Incremento As Integer
        If Cantidad >= 500 Then
            Incremento = 60
        ElseIf Cantidad >= 200 Then
            Incremento = 40
        ElseIf Cantidad >= 100 Then
            Incremento = 30
        Else
            Incremento = 10
        End If

        For I As Long = tbx_FolioI.Text.Trim To tbx_FolioF.Text.Trim Step Incremento
            If I >= tbx_FolioI.Text.Trim And I <= tbx_FolioF.Text.Trim Then
                'Validar que los Folios capturados no se hayan asignado ya a un Departamento
                'Dt = Cn_Materiales.fn_FoliosAsignados_ValidarFoliosDeptos(I)
                Dt = Cn_Materiales.fn_FoliosAsignados_ValidarFolios(Id_Inventario, 2, I)
                If Dt IsNot Nothing Then
                    If Dt.Rows.Count > 0 Then
                        SegundosDesconexion = 0
                        MsgBox("Al parecer uno o mas de los Folios indicados ya han sido asignados anteriormente a otro Departamento." & Chr(13) & Chr(13) & _
                        "Departamento: " & Dt.Rows(0)("Descripcion") & Chr(13) & _
                        "Fecha de Captura: " & Dt.Rows(0)("FechaCaptura") & Chr(13) & _
                        "Folio Inicial: " & Dt.Rows(0)("Folio_Inicial") & Chr(13) & _
                        "Folio Final: " & Dt.Rows(0)("Folio_Final") & Chr(13) & _
                        "Cantidad: " & Dt.Rows(0)("Cantidad") & " Remisiones.", MsgBoxStyle.Critical, frm_MENU.Text)
                        SegundosDesconexion = 0
                        Exit Sub
                    End If
                End If
                'Validar que los Folios capturados no se hayan asignado ya a otros Clientes
                'Dt = Cn_Materiales.fn_FoliosAsignados_ValidarFoliosClientes(I)
                Dt = Cn_Materiales.fn_FoliosAsignados_ValidarFolios(Id_Inventario, 1, I)
                If Dt IsNot Nothing Then
                    If Dt.Rows.Count > 0 Then
                        SegundosDesconexion = 0
                        MsgBox("Al parecer uno o mas de los Folios indicados ya han sido asignados a otro Cliente." & Chr(13) & Chr(13) & _
                        "Cliente: " & Dt.Rows(0)("Clave") & " " & Dt.Rows(0)("Cliente") & Chr(13) & _
                        "Fecha de Captura: " & Dt.Rows(0)("FechaCaptura") & Chr(13) & _
                        "Folio Inicial: " & Dt.Rows(0)("FolioInicial") & Chr(13) & _
                        "Folio Final: " & Dt.Rows(0)("FolioFinal") & Chr(13) & _
                        "Cantidad: " & Dt.Rows(0)("Cantidad") & " Remisiones.", MsgBoxStyle.Critical, frm_MENU.Text)
                        SegundosDesconexion = 0
                        Exit Sub
                    End If
                End If
            End If
        Next

        'Agregar al listview
        lsv_Datos.Items.Add(CInt(tbx_FolioI.Text.Trim))
        lsv_Datos.Items(lsv_Datos.Items.Count - 1).SubItems.Add(CInt(tbx_FolioF.Text.Trim))
        lsv_Datos.Items(lsv_Datos.Items.Count - 1).SubItems.Add(CInt(tbx_FolioF.Text.Trim) - CInt(tbx_FolioI.Text.Trim) + 1)
        Call Recalcular()
        tbx_FolioI.Clear()
        tbx_FolioF.Clear()
        tbx_FolioI.Focus()
    End Sub

    Private Sub lsv_Datos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Datos.SelectedIndexChanged
        SegundosDesconexion = 0

        btn_Eliminar.Enabled = lsv_Datos.SelectedItems.Count > 0
    End Sub

    Private Sub btn_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Eliminar.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0

        lsv_Datos.SelectedItems(0).Remove()
        Call Recalcular()
    End Sub

    Private Sub btn_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Aceptar.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0

        If Validar() Then
            Call ConcatenarFolios()
            Validado = True
            Me.Close()
        Else
            Exit Sub
        End If
        'If Cantidad <> Val(tbx_Total.Text) Then
        '    MsgBox("La cantidad de Folios agregados debe ser igual a la cantidad de Comprobantes por asignar.", MsgBoxStyle.Critical, frm_MENU.Text)
        '    tbx_FolioI.Focus()
        '    Exit Sub
        'End If

        'Call ConcatenarFolios()
        'Validado = True
        'Me.Close()
    End Sub

    Function Validar() As Boolean
        SegundosDesconexion = 0

        If lsv_Datos.Items.Count = 0 Then
            MsgBox("Debe indicar los Folios asignados.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_FolioI.Focus()
            Return False
        End If
        If Cantidad <> Val(tbx_Total.Text.Trim) Then
            MsgBox("La cantidad de Folios agregados debe ser igual a la cantidad de Folios solicitados.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_FolioI.Focus()
            Return False
        End If
        Return True
    End Function

    Sub Recalcular()
        Dim Total As Integer = 0
        For Each elemento As ListViewItem In lsv_Datos.Items
            Total = Total + CInt(elemento.SubItems(2).Text)
        Next
        tbx_Total.Text = Total
    End Sub

    Private Sub ConcatenarFolios()
        For Each item As ListViewItem In lsv_Datos.Items
            If Folios = "" Then
                Folios = item.Text.Trim & "-" & item.SubItems(1).Text.Trim
            Else
                Folios += " / " & item.Text.Trim & "-" & item.SubItems(1).Text.Trim
            End If
        Next
    End Sub

End Class