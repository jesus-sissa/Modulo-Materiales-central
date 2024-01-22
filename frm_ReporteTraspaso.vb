Imports Modulo_MaterialesCentral.Cn_Materiales
Public Class frm_ReporteTraspaso
    Private Sub btn_Buscar_Click(sender As Object, e As EventArgs) Handles btn_Buscar.Click


        SegundosDesconexion = 0


        If cmb_Status.Text = "Seleccione..." Then
            MsgBox("Seleccione un Status.", MsgBoxStyle.Critical, Me.Text)
        Else

            Dim Stas = cmb_Status.SelectedValue

                Call LlenarSolicitudes(Stas)
                btn_Exportar.Enabled = False

        End If



    End Sub



    Sub LlenarSolicitudes(Status As String)
        Dim Usuario_Solicita As Integer = 0
        Dim FechaDesde As Date = dtp_Desde.Value
        Dim FechaHasta As Date = dtp_Hasta.Value


        If Not fn_ConsultaSolicitudesMaterial_Trasp(Lsv_Ventas, FechaDesde, FechaHasta, Status) Then
            MsgBox("Ha ocurrido un error al intentar consultar los datos.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        Lbl_Registros.Text = "Registros: " & Lsv_Ventas.Items.Count
    End Sub

    Private Sub frm_ReporteTraspaso_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Cnx_Central = "" Then
            MsgBox("No se han definido los parámetros de conexión con la Base de Datos Central de SIAC. Si no captura estos parámetros no podrá tener acceso a las pantallas de este Módulo." & Chr(13) & "Para configurar estos parámetros vaya al Menu Archivo y seleccione la opción «Parámetros de Servidor Central».", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        cmb_Status.AgregarItem("V", "TRASPASO ACEPTADO")
        cmb_Status.AgregarItem("A", "TRASPASO PENDIENTES")
        cmb_Status.AgregarItem("C", "TRASPASO CANCELADOS")
    End Sub

    Private Sub btn_Exportar_Click(sender As Object, e As EventArgs) Handles btn_Exportar.Click
        Dim Dt_Detalle As New DataTable
        Dim UltFila As Integer = 5
        SegundosDesconexion = 0

        frm_MENU.prg_Barra.Maximum = Lsv_Ventas.Items.Count + 1

        'Dim  As New Excel.Application
        Dim App = CreateObject("Excel.Application")
        With App

            'Creando el libro
            .Workbooks.Add()
            .SheetsInNewWorkbook = 1

            .Range("B1:E1").Merge()
            .Range("B1").Value = Me.Text
            .Range("B1").Font.Bold = True

            .Range("A2:F2").Merge()
            Dim Status As String = ""
            If cmb_Status.SelectedValue = "A" Then
                Status = "PENDIENTES"
            Else
                If cmb_Status.SelectedValue = "V" Then
                    Status = "ACEPTADOS"
                Else
                    Status = "CANCELADOS"
                End If
            End If
            .Range("A2").Value = "Desde: " & dtp_Desde.Text & " Hasta: " & dtp_Hasta.Text & "  -  Status: " & Status


            .Range("A2").Font.Bold = True

            .Range("A4").Value = "Destino"
            .Range("B4").Value = "Nombre"
            .Range("C4").Value = "Fecha"
            .Range("D4").Value = "Material"
            .Range("E4").Value = "Cantidad"
            .Range("F4").Value = "Estatus"

            Dt_Detalle = Cn_Materiales.fn_ConsultaSolicitudesMaterial_LlenarReporte(dtp_Desde.Value.Date, dtp_Hasta.Value.Date, cmb_Status.SelectedValue, 1)

            For Each Lvi_Solicitudes As ListViewItem In Lsv_Ventas.Items

                .Range("A" & UltFila).Value = Lvi_Solicitudes.SubItems(1).Text
                .Range("B" & UltFila).Value = Lvi_Solicitudes.SubItems(2).Text
                .Range("C" & UltFila).Value = Lvi_Solicitudes.SubItems(3).Text
                .Range("D" & UltFila).Value = Lvi_Solicitudes.SubItems(4).Text
                .Range("E" & UltFila).Value = Lvi_Solicitudes.SubItems(5).Text
                '.Range("F" & UltFila & ":H" & UltFila).Merge()
                .Range("F" & UltFila).Value = Lvi_Solicitudes.SubItems(6).Text


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
            .Range("A4:F" & UltFila).EntireColumn.Autofit()
            .Range("A4:F" & UltFila).Borders.Value = True
            .Range("E" & UltFila).ColumnWidth = 9.43
            .Range("F" & UltFila).ColumnWidth = 9.43
            .Range("G" & UltFila).ColumnWidth = 0

            'Mostrando el Libro
            .Visible = True

        End With



        frm_MENU.prg_Barra.Value = frm_MENU.prg_Barra.Maximum
        frm_MENU.prg_Barra.Value = frm_MENU.prg_Barra.Minimum
    End Sub

    Private Sub Lsv_Ventas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Lsv_Ventas.SelectedIndexChanged
        btn_Exportar.Enabled = Lsv_Ventas.Items.Count > 0
    End Sub
End Class