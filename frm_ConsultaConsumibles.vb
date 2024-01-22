
Imports Modulo_MaterialesCentral.Cn_Materiales

Public Class frm_ConsultaConsumibles
    Dim FechaDesde As Date
    Dim FechaHasta As Date
    Dim ValorStatus As Char
    Dim Usuario_Solicita As Integer

    Private Sub frm_ConsultaConsumibles_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

        'cmb_Status.AgregarItem("0", "Seleccione...")
        cmb_Status.AgregarItem("A", "PENDIENTE")
        cmb_Status.AgregarItem("V", "VALIDADA")
        cmb_Status.AgregarItem("S", "SURTIDA")
        cmb_Status.AgregarItem("C", "CANCELADA")

        lsv_TotalConsumibles.Columns.Add("Descripcion")
        lsv_TotalConsumibles.Columns.Add("Solicitado")
        lsv_TotalConsumibles.Columns.Add("Validado")
        lsv_TotalConsumibles.Columns.Add("Surtido")

        cmb_UsuarioSolicita.Actualizar()
        cmb_UsuarioSolicita.Actualizar()
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0
        Me.Close()
    End Sub

    Private Sub dtp_Desde_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_Desde.ValueChanged
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0

        lsv_Solicitudes.Items.Clear()
        lsv_Detalle.Items.Clear()
        btn_ExportarConc.Enabled = False
        Lbl_Registros.Text = "Registros: " & lsv_Solicitudes.Items.Count
    End Sub

    Private Sub dtp_Hasta_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_Hasta.ValueChanged
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0

        lsv_Solicitudes.Items.Clear()
        lsv_Detalle.Items.Clear()
        btn_ExportarConc.Enabled = False
        Lbl_Registros.Text = "Registros: " & lsv_Solicitudes.Items.Count
    End Sub

    Private Sub cmb_Status_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Status.SelectedIndexChanged
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0

        lsv_Solicitudes.Items.Clear()
        lsv_Detalle.Items.Clear()

        btn_ExportarConc.Enabled = False
    End Sub

    Private Sub chk_Usuarios_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Usuarios.CheckedChanged
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        lsv_TotalConsumibles.Items.Clear()
        lsv_Solicitudes.Items.Clear()
        lsv_Detalle.Items.Clear()
        If chk_Usuarios.Checked Then
            cmb_UsuarioSolicita.Enabled = False
            cmb_UsuarioSolicita.SelectedValue = 0
        Else
            cmb_UsuarioSolicita.Enabled = True
        End If
        btn_ExportarConc.Enabled = False
        Lbl_Registros.Text = "Registros: " & lsv_Solicitudes.Items.Count
    End Sub

    Private Sub chk_Todos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Todos.CheckedChanged
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        lsv_TotalConsumibles.Items.Clear()
        lsv_Solicitudes.Items.Clear()
        lsv_Detalle.Items.Clear()
        If chk_Todos.Checked Then
            cmb_Status.Enabled = False
            cmb_Status.SelectedValue = 0
        Else
            cmb_Status.Enabled = True
        End If
        btn_ExportarConc.Enabled = False
        Lbl_Registros.Text = "Registros: " & lsv_Solicitudes.Items.Count
    End Sub


    Private Sub lsv_Solicitudes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Solicitudes.SelectedIndexChanged
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0

        If lsv_Solicitudes.SelectedItems.Count = 0 Then
            lsv_Detalle.Items.Clear()
            Exit Sub
        End If
        If Not fn_ConsultaSolicitudesConsumibles_LlenarDetalle(lsv_Detalle, lsv_Solicitudes.SelectedItems(0).Tag) Then
            MsgBox("Ha ocurrido un error al intentar consultar los datos.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
    End Sub

    Private Sub lsv_Solicitudes_ItemChecked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemCheckedEventArgs) Handles lsv_Solicitudes.ItemChecked
        SegundosDesconexion = 0

        If lsv_Solicitudes.CheckedItems.Count = 0 Then lsv_TotalConsumibles.Items.Clear()

        Dim SumaIds As String = ""
        For Each Elemento As ListViewItem In lsv_Solicitudes.CheckedItems
            If Elemento.SubItems(4).Text <> "VALIDADA" Then
                e.Item.Checked = False
            Else
                SumaIds &= Elemento.Tag & ","
            End If
        Next
        If SumaIds <> "" Then
            lsv_TotalConsumibles.Items.Clear()
            SumaIds = SumaIds.Substring(0, (SumaIds.Length - 1))
            fn_CuentaTotalesXConsumibles(lsv_TotalConsumibles, SumaIds)
        End If

        btn_ExportarConc.Enabled = lsv_Solicitudes.CheckedItems.Count > 0
    End Sub

    Private Sub btn_Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ExportarSol.Click
        ''FuncionesGlobales.fn_Exportar_Excel(lsv_TotalConsumibles, 2, Me.Text, 0, 0, frm_MENU.prg_Barra)
        Dim Dt_Detalle As New DataTable
        Dim UltFila As Integer = 5
        SegundosDesconexion = 0

        frm_MENU.prg_Barra.Maximum = lsv_Solicitudes.Items.Count + 1

        'Dim  As New Excel.Application
        Dim App = CreateObject("Excel.Application")
        With App

            'Creando el libro
            .Workbooks.Add()
            .SheetsInNewWorkbook = 1

            .Range("B1:H1").Merge()
            .Range("B1").Value = Me.Text
            .Range("B1").Font.Bold = True

            .Range("A2:H2").Merge()
            .Range("A2").Value = "Desde: " & dtp_Desde.Text & " Hasta: " & dtp_Hasta.Text & "  -  Usuario: " & IIf(cmb_UsuarioSolicita.SelectedValue = 0, "Todos", cmb_UsuarioSolicita.SelectedText) & "  -  Status: " & IIf(cmb_Status.SelectedValue = 0, "Todos", cmb_Status.SelectedText)
            .Range("A2").Font.Bold = True

            .Range("A4").Value = "Numero"
            .Range("B4").Value = "Fecha"
            .Range("C4").Value = "Hora"
            .Range("D4").Value = "UsuarioSolicita"
            .Range("E4").Value = "Status"
            .Range("F4").Value = "Observaciones"

            Dt_Detalle = Cn_Materiales.fn_ConsultaSolicitudesConsumibles_LlenarReporte(dtp_Desde.Value.Date, dtp_Hasta.Value.Date, IIf(cmb_Status.SelectedValue = 0, "T", cmb_Status.SelectedValue), cmb_UsuarioSolicita.SelectedValue)

            For Each Lvi_Solicitudes As ListViewItem In lsv_Solicitudes.Items

                .Range("A" & UltFila).Value = Lvi_Solicitudes.SubItems(0).Text
                .Range("B" & UltFila).Value = Lvi_Solicitudes.SubItems(1).Text
                .Range("C" & UltFila).Value = Lvi_Solicitudes.SubItems(2).Text
                .Range("D" & UltFila).Value = Lvi_Solicitudes.SubItems(3).Text
                .Range("E" & UltFila).Value = Lvi_Solicitudes.SubItems(4).Text
                .Range("F" & UltFila & ":H" & UltFila).Merge()
                .Range("F" & UltFila).Value = Lvi_Solicitudes.SubItems(5).Text

                If Dt_Detalle.Rows.Count <> 0 Then
                    For Each Dr_Detalle As DataRow In Dt_Detalle.Rows
                        If Dr_Detalle("Id_Solicitud") = Lvi_Solicitudes.Tag Then
                            UltFila += 1
                            .Range("B" & UltFila).Value = Dr_Detalle("Descripcion")
                            .Range("E" & UltFila).Value = Dr_Detalle("CantidadSolicitada")
                            .Range("F" & UltFila).Value = Dr_Detalle("CantidadValidada")
                            .Range("G" & UltFila).Value = Dr_Detalle("CantidadSurtida")
                            .Range("H" & UltFila).Value = Dr_Detalle("Status")
                            .Range("B" & UltFila & ":H" & UltFila).Font.Italic = True
                            .Range("B" & UltFila & ":H" & UltFila).Font.Size = 10
                            .Range("B" & UltFila & ":D" & UltFila).Merge()
                        End If
                    Next
                End If
                UltFila += 1
                frm_MENU.prg_Barra.Value += 1
            Next
            .Range("A4:F4").Font.Bold = True
            .Range("A4:H" & UltFila).EntireColumn.Autofit()
            .Range("A4:H" & UltFila).Borders.Value = True
            .Range("E" & UltFila).ColumnWidth = 9.43
            .Range("F" & UltFila).ColumnWidth = 9.43
            .Range("G" & UltFila).ColumnWidth = 9.43

            'Mostrando el Libro
            .Visible = True
        End With
        frm_MENU.prg_Barra.Value = frm_MENU.prg_Barra.Maximum
        frm_MENU.prg_Barra.Value = frm_MENU.prg_Barra.Minimum

        Cn_Login.fn_Log_Create("EXPORTAR REPORTE CONSULTA DE CONSUMIBLES. FECHAS: " & dtp_Desde.Value.ToShortDateString & " - " & dtp_Hasta.Value.ToShortDateString & " / USUARIO SOLICITA: " & cmb_UsuarioSolicita.Text & " / STATUS: " & cmb_Status.Text)

    End Sub

    Private Sub btn_Mostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Mostrar.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0

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

        If Not fn_ConsultaSolicitudesConsumibles_LlenarLista(lsv_Solicitudes, FechaDesde, FechaHasta, ValorStatus, Usuario_Solicita) Then
            MsgBox("Ha ocurrido un error al intentar consultar los datos.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        Lbl_Registros.Text = "Registros: " & lsv_Solicitudes.Items.Count
        btn_ExportarSol.Enabled = True
    End Sub

    Private Sub btn_ExportarConc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ExportarConc.Click
        FuncionesGlobales.fn_Exportar_Excel(lsv_TotalConsumibles, 2, Me.Text, 0, 0, frm_MENU.prg_Barra)
    End Sub

    Private Sub cmb_UsuarioSolicita_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_UsuarioSolicita.SelectedIndexChanged
        btn_ExportarConc.Enabled = False
    End Sub
End Class