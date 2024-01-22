Public Class frm_Dialogo

    Public Id_MatVenta As Integer
    Public Envases As Integer = 0
    Public EnvasesSN As Integer = 0
    Public IdCajaBancaria As String
    Public ImporteTotal As Decimal = 0.0
    Public TipodeCambio As Decimal = 1.0
    Public Moneda As Integer = MonedaID
    Public Tipo As Integer = 1
    Private Info(3) As String

    Private Sub frm_Dialago_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Select Case Tipo

            Case 1
                'lbl_NombreCompañia.Text = Cn_Materiales.fn_ValidaMateriales_Cia(Ciaid)
                'cmb_TipoEnvase.Actualizar()

                lbl_NombreCompañia.Text = Cn_Materiales.fn_ValidaMateriales_Cia(Ciaid)
                cmb_TipoEnvase.Actualizar()
                Info = Cn_Materiales.fn_Materiales_Cliente(IdCajaBancaria)
                lbl_NombreCliente.Text = Info(1)

            Case 2
                lbl_NombreCompañia.Text = Cn_Materiales.fn_ValidaMateriales_Cia(Ciaid)
                cmb_TipoEnvase.Actualizar()
                Info = Cn_Materiales.fn_Materiales_Depto(IdCajaBancaria)
                lbl_NombreCliente.Text = Info(1)

        End Select


        lsv_Envases.Columns.Add("Tipo de Envase")
        lsv_Envases.Columns.Add("Numero de Envase")

        FuncionesGlobales.fn_Columna(lsv_Envases, 50, 50, 0, 0, 0, 0, 0, 0, 0, 0)

        btn_Guardar.Enabled = False
        Btn_Agregar.Enabled = False
        btn_Eliminar.Enabled = False

    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub Btn_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Agregar.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0

        'Inicializar la variable de desconexion
        SegundosDesconexion = 0

        For Each item As ListViewItem In lsv_Envases.Items
            If item.SubItems(1).Text = tbx_Numero.Text Then
                MsgBox("El envase ya existe en la lista", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
        Next

        If cmb_TipoEnvase.SelectedValue = 0 Or tbx_Numero.Text.Trim = "" Then
            Exit Sub
        Else
            With lsv_Envases.Items.Add(cmb_TipoEnvase.Text)
                .Tag = cmb_TipoEnvase.SelectedValue.ToString
                .SubItems.Add(tbx_Numero.Text)
            End With
        End If

        tbx_Numero.Clear()
        tbx_Numero.Focus()


    End Sub

    Private Sub btn_Cerrar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub btn_Imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Imprimir.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0

        Dim Contador As Integer = 0
        Dim Cadena As String = ""
        Dim Elemento As ListViewItem

        If tbx_Remision.Text.Trim <> "" Then

            ' validar numero de remision
            If Cn_Materiales.fn_ValidaMateriales_ValidaRemision(tbx_Remision.Text) = True Then

                If lsv_Envases.Items IsNot Nothing Then
                    Envases = lsv_Envases.Items.Count
                End If

                If tbx_Envases.Text.Trim <> "" Then
                    EnvasesSN = tbx_Envases.Text
                End If

                Contador = Envases + EnvasesSN

                If Contador > 0 Then
                    btn_Guardar.Enabled = True
                Else
                    MsgBox("Indique por lo menos un Envase.", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                End If
            Else
                MsgBox("El Número de Remisión ya existe.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If


            If Envases > 0 Then

                For Each Elemento In lsv_Envases.Items
                    Cadena += Elemento.SubItems(1).Text + ", "
                Next

            End If

            Select Case Tipo

                Case 1

                    FuncionesGlobales.fn_ImprimeRemision(Moneda, Ciaid, lbl_NombreCompañia.Text, Info(0), "", Info(1), Info(2), ImporteTotal, 0, 0, Mid(Cadena, 1, Cadena.Length - 2), Envases, EnvasesSN, 1, tbx_Remision.Text, False, ChkImportes.Checked, TipodeCambio)

                Case 2

                    FuncionesGlobales.fn_ImprimeRemision(Moneda, Ciaid, lbl_NombreCompañia.Text, "", Info(0), Info(1), "", ImporteTotal, 0, 0, Mid(Cadena, 1, Cadena.Length - 2), Envases, EnvasesSN, 1, tbx_Remision.Text, False, ChkImportes.Checked, TipodeCambio)

            End Select

        Else
            MsgBox("Capture Número de Remisión.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If


    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0

        Dim Envases As Integer = 0
        Dim EnvasesSN As Integer = 0

        If lsv_Envases.Items IsNot Nothing Then
            Envases = lsv_Envases.Items.Count
        End If
        If tbx_Envases.Text.Trim <> "" Then
            EnvasesSN += tbx_Envases.Text
        End If
        'El ultimo parametro (0) es para que descuente del inventario General
        If Cn_Materiales.fn_ValidaMateriales_Create(Id_MatVenta, Envases, EnvasesSN, tbx_Remision.Text, 0) = True Then
            Me.Close()
        Else
            MsgBox("No se pudo guardar la Remisión.", MsgBoxStyle.Critical, frm_MENU.Text)
            Me.Close()
        End If
    End Sub

    Private Sub cmb_TipoEnvase_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_TipoEnvase.SelectedIndexChanged
        validabotonagregar()
    End Sub

    Private Sub tbx_Numero_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbx_Numero.TextChanged
        validabotonagregar()
    End Sub

    Private Sub validabotonagregar()

        If cmb_TipoEnvase.SelectedValue <> 0 Then

            If tbx_Numero.Text.Trim <> "" Then
                Btn_Agregar.Enabled = True
            End If

        Else
            Btn_Agregar.Enabled = False
        End If

    End Sub

    Private Sub btn_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Eliminar.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0

        lsv_Envases.Items(lsv_Envases.SelectedItems(0).Index).Remove()
    End Sub

    Private Sub lsv_Envases_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Envases.SelectedIndexChanged

        If lsv_Envases.SelectedItems.Count > 0 Then
            btn_Eliminar.Enabled = True
        Else
            btn_Eliminar.Enabled = False
        End If

    End Sub

End Class