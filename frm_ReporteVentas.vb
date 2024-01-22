Imports Modulo_MaterialesCentral.Cn_Materiales

Public Class frm_ReporteVentas
    Dim Tipo As Integer = 0
    Dim Stas As String
    Dim TStas As String
    Private Sub frm_ReporteVentas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        cbx_Tipo.AgregarItem("2", "COMPRA")
        cbx_Tipo.AgregarItem("3", "SURTIDO LOCAL")


        cmb_Status.AgregarItem("A", "PENDIENTE")
        cmb_Status.AgregarItem("S", "SURTIDO")
        cmb_Status.AgregarItem("C", "CANCELADO")
        cmb_Status.AgregarItem("V", "VALIDADO")


        Lsv_Ventas.Columns.Add("Número")
        Lsv_Ventas.Columns.Add("Fecha")
        Lsv_Ventas.Columns.Add("Hora")
        Lsv_Ventas.Columns.Add("UsuarioSolicita")
        Lsv_Ventas.Columns.Add("Status")

    End Sub

    Sub LlenarSolicitudes(Tipo As Integer, Status As String)
        SegundosDesconexion = 0
        Dim Usuario_Solicita As Integer = 0
        Dim FechaDesde As Date = dtp_Desde.Value
        Dim FechaHasta As Date = Now.Date


        If Not fn_ConsultaSolicitudesMaterial_LlenarLista(Lsv_Ventas, FechaDesde, FechaHasta, Status, Usuario_Solicita, Tipo) Then
            MsgBox("Ha ocurrido un error al intentar consultar los datos.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        Lbl_Registros.Text = "Registros: " & Lsv_Ventas.Items.Count
    End Sub

    Private Sub btn_Mostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Inicializar la variable de desconexión
        SegundosDesconexion = 0

        If dtp_Desde.Value.Date > dtp_Hasta.Value.Date Then
            MsgBox("El rango de fechas parece ser incorrecto.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        If cmb_Status.Enabled = True And cmb_Status.SelectedValue = "0" Then
            MsgBox("Seleccione un Status.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Status.Focus()
            Exit Sub
        End If

        Dim Status As String
        If cmb_Status.Enabled Then
            Status = cmb_Status.SelectedValue
        Else
            Status = "T"
        End If
        'If Not Cn_Materiales.fn_ReporteAsignaciones_LlenarLista(Lsv_Ventas, cmb_Depto.SelectedValue, dtp_Desde.Value.Date, dtp_Hasta.Value.Date, Status) Then
        MsgBox("Ocurrió un error al intentar consultar las Asignaciones de Materiales.", MsgBoxStyle.Critical, frm_MENU.Text)
        'End If
        Lbl_Registros.Text = "Registros: " & Lsv_Ventas.Items.Count

    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0

        Me.Close()
    End Sub
    Sub LlenarDetalle_Compra()
        SegundosDesconexion = 0
        Dim dt_Detalle As DataTable = fn_ValidarSolicitudesMaterial_LlenarCompra(Lsv_Ventas.SelectedItems(0).Tag)
        'Llenar el Grid de Detalle manualmente
        Dim Id_MatVenta As Integer
        Id_MatVenta = CInt(dt_Detalle.Rows(0)("Id_MatVenta"))
        Dim tbl As DataTable = fn_ObtenerFolioCompra(Id_MatVenta)
        If dt_Detalle Is Nothing Then Exit Sub

        Dim Fila As DataGridViewRow
        Dim Celda As DataGridViewTextBoxCell
        For Each row As DataRow In dt_Detalle.Rows

            Fila = New DataGridViewRow

            Celda = New DataGridViewTextBoxCell
            Celda.Value = row("Descripcion")
            Celda.Tag = row("Id_Consumible") 'Checar impacto
            Fila.Cells.Add(Celda)

            Celda = New DataGridViewTextBoxCell
            Celda.ValueType = GetType(Integer)
            Celda.MaxInputLength = 5
            Celda.Value = row("CantidadSolicitada")
            Celda.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            Fila.Cells.Add(Celda)

            Celda = New DataGridViewTextBoxCell
            Celda.ValueType = GetType(Integer)
            Celda.MaxInputLength = 5
            Celda.Value = row("CantidadValidada")
            Celda.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            Fila.Cells.Add(Celda)

            Celda = New DataGridViewTextBoxCell
            Celda.ValueType = GetType(Integer)
            Celda.MaxInputLength = 5
            Celda.Value = row("CantidadSurtida")
            Celda.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            Fila.Cells.Add(Celda)

            Celda = New DataGridViewTextBoxCell
            Celda.MaxInputLength = 150
            Celda.Value = ""
            Fila.Cells.Add(Celda)

            If row("Status") = "PARCIAL" Then
                Celda = New DataGridViewTextBoxCell
                Celda.Value = "SURTIDA"
                Celda.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                Fila.Cells.Add(Celda)
            Else
                Celda = New DataGridViewTextBoxCell
                Celda.Value = row("Status")
                Celda.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                Fila.Cells.Add(Celda)
            End If



            Celda = New DataGridViewTextBoxCell
            Celda.Value = row("Foliado")

            Fila.Cells.Add(Celda)
            Try
                If row("Foliado") = "SI" Then
                    Celda.Style.BackColor = Color.LightGreen
                    Celda.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

                    Celda = New DataGridViewTextBoxCell
                    Celda.ValueType = GetType(Integer)
                    Celda.MaxInputLength = 5
                    Celda.Value = tbl.Rows(0)(0).ToString()
                    Celda.Style.BackColor = Color.LightGreen
                    Celda.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                    Fila.Cells.Add(Celda)

                    Celda = New DataGridViewTextBoxCell
                    Celda.ValueType = GetType(Integer)
                    Celda.MaxInputLength = 5
                    Celda.Value = tbl.Rows(0)(1).ToString()
                    Celda.Style.BackColor = Color.LightGreen
                    Celda.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                    Fila.Cells.Add(Celda)
                Else
                    Fila.ReadOnly = True
                    Celda.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                End If

            Catch ex As Exception

            End Try

            dgv_Detalle.Rows.Add(Fila)
        Next

        If Tipo = 3 Then
            'btn_Surtir_local.Enabled = dgv_Detalle.Rows.Count > 0

        Else

            'btn_Exportar.Enabled = dgv_Detalle.Rows.Count > 0
            'btn_Surtir.Enabled = dgv_Detalle.Rows.Count > 0
        End If



    End Sub
    Sub LlenarDetalle()
        SegundosDesconexion = 0
        Dim dt_Detalle As DataTable = fn_ValidarSolicitudesMaterial_LlenarDetalle(Lsv_Ventas.SelectedItems(0).Tag)
        'Llenar el Grid de Detalle manualmente

        If dt_Detalle Is Nothing Then Exit Sub

        Dim Fila As DataGridViewRow
        Dim Celda As DataGridViewTextBoxCell
        For Each row As DataRow In dt_Detalle.Rows
            Fila = New DataGridViewRow

            Celda = New DataGridViewTextBoxCell
            Celda.Value = row("Descripcion")
            Celda.Tag = row("Id_Consumible")
            Fila.Cells.Add(Celda)

            Celda = New DataGridViewTextBoxCell
            Celda.ValueType = GetType(Integer)
            Celda.MaxInputLength = 5
            Celda.Value = row("CantidadSolicitada")
            Celda.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            Fila.Cells.Add(Celda)

            Celda = New DataGridViewTextBoxCell
            Celda.ValueType = GetType(Integer)
            Celda.MaxInputLength = 5
            Celda.Value = row("CantidadValidada")
            Celda.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            Fila.Cells.Add(Celda)

            Celda = New DataGridViewTextBoxCell
            Celda.ValueType = GetType(Integer)
            Celda.MaxInputLength = 5
            Celda.Value = row("CantidadSurtida")
            Celda.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            Fila.Cells.Add(Celda)

            Celda = New DataGridViewTextBoxCell
            Celda.MaxInputLength = 150
            Celda.Value = ""
            Fila.Cells.Add(Celda)

            If row("Status") = "PARCIAL" Then
                Celda = New DataGridViewTextBoxCell
                Celda.Value = "SURTIDA"
                Celda.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                Fila.Cells.Add(Celda)
            Else
                Celda = New DataGridViewTextBoxCell
                Celda.Value = row("Status")
                Celda.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                Fila.Cells.Add(Celda)
            End If



            Celda = New DataGridViewTextBoxCell
            Celda.Value = row("Foliado")

            Fila.Cells.Add(Celda)

            If row("Foliado") = "SI" Then
                Celda.Style.BackColor = Color.LightGreen
                Celda.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

                Celda = New DataGridViewTextBoxCell
                Celda.ValueType = GetType(Integer)
                Celda.MaxInputLength = 5
                Celda.Value = row("Column1")
                Celda.Style.BackColor = Color.LightGreen
                Celda.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                Fila.Cells.Add(Celda)

                Celda = New DataGridViewTextBoxCell
                Celda.ValueType = GetType(Integer)
                Celda.MaxInputLength = 5
                Celda.Value = row("Column2")
                Celda.Style.BackColor = Color.LightGreen
                Celda.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                Fila.Cells.Add(Celda)
            Else
                Fila.ReadOnly = True
                Celda.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            End If





            dgv_Detalle.Rows.Add(Fila)
        Next

        If Tipo = 3 Then
            'btn_Surtir_local.Enabled = dgv_Detalle.Rows.Count > 0

        Else

            'btn_Exportar.Enabled = dgv_Detalle.Rows.Count > 0
            'btn_Surtir.Enabled = dgv_Detalle.Rows.Count > 0
        End If
    End Sub
    Private Sub Lsv_Ventas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lsv_Ventas.SelectedIndexChanged

        'Inicializar la variable de desconexion
        SegundosDesconexion = 0



        btn_Exportar.Enabled = Lsv_Ventas.Items.Count > 0
        If Lsv_Ventas.SelectedItems.Count = 0 Then

            If Tipo = 3 Then
                btn_Exportar.Enabled = False
                dgv_Detalle.Rows.Clear()
            Else
                btn_Exportar.Enabled = False
                dgv_Detalle.Rows.Clear()

            End If
            Exit Sub
        End If

        If (cbx_Tipo.SelectedIndex = 1) Then
            Call LlenarDetalle_Compra()
        ElseIf (cbx_Tipo.SelectedIndex = 2) Then
            Call LlenarDetalle()
        End If

        ''Inicializar la variable de desconexion
        'SegundosDesconexion = 0

        'If Lsv_Ventas.SelectedItems.Count = 0 Then

        '    Exit Sub
        'Else
        '    'Mostrar el detalle de la asignación de Materiales seleccionada
        '    If Not fn_ValidaMaterialesD_LlenarLista(lsv_VentasD, lsv_VentasD.Lvs, Lsv_Ventas.SelectedItems(0).Tag) Then
        '        MsgBox("Ha ocurrido un error al intentar consultar el Detalle.", MsgBoxStyle.Critical, frm_MENU.Text)
        '        Exit Sub
        '    Else
        '        'lsv_VentasD.Columns(2).TextAlign = HorizontalAlignment.Right
        '    End If
        '    'Mostrar los Folios de Remisiones asignadas
        '    If Not fn_ReporteAsignaciones_DetalleFolios(lsv_Folios, Lsv_Ventas.SelectedItems(0).Tag) Then
        '        MsgBox("Ha ocurrido un error al intentar consultar los Folios de Remisiones asignadas.", MsgBoxStyle.Critical, frm_MENU.Text)
        '        Exit Sub
        '    End If
        'End If
        'Lbl_Registros.Text = "Registros: " & lsv_Folios.Items.Count
    End Sub

    Private Sub btn_Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Exportar.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Dim Dt_Detalle As New DataTable
        'Dim UltFila As Integer = 5

        ''FuncionesGlobales.fn_Exportar_Excel(Lsv_Ventas, 2, "Asignaciones de Materiales", 0, 0, frm_MENU.prg_Barra)

        ''Cn_Login.fn_Log_Create("EXPORTAR REPORTE DE ASIGNACION DE MATERIALES. FECHAS: " & dtp_Desde.Value.ToShortDateString & " - " & dtp_Hasta.Value.ToShortDateString & " / DEPARTAMENTO: " & cmb_Depto.Text & " / STATUS: " & cmb_Status.Text)

        'frm_MENU.prg_Barra.Maximum = Lsv_Ventas.Items.Count + 1

        ''Dim  As New Excel.Application
        'Dim App = CreateObject("Excel.Application")
        'With App

        '    'Creando el libro
        '    .Workbooks.Add()
        '    .SheetsInNewWorkbook = 1
        '    .Range("A1:E1").Merge()
        '    .Range("A1").Value = Me.Text
        '    .Range("B1").Merge()
        '    .Range("A2:E2").Merge()
        '    '.Range("A2").Value = "Desde: " & dtp_Desde.Text & " Hasta: " & dtp_Hasta.Text & "  -  Departamento: " & IIf(cbx_Depto.Checked, "Todos", cmb_Depto.SelectedText) & "  -  Status: " & IIf(cbx_Status.Checked, "Todos", cmb_Status.SelectedText)
        '    .Range("A1").Font.Bold = True
        '    .Range("A2").Font.Bold = True

        '    .Range("A4").Value = "Fecha"
        '    .Range("B4").Value = "Hora"
        '    .Range("C4").Value = "Asigno"
        '    .Range("D4").Value = "Destino"
        '    .Range("E4").Value = "Status"

        '    'Dt_Detalle = Cn_Materiales.fn_ReporteAsignaciones_LlenarRpt(cmb_Depto.SelectedValue, dtp_Desde.Value.Date, dtp_Hasta.Value.Date, "S")

        '    For Each Lvi_Ventas As ListViewItem In Lsv_Ventas.Items

        '        .Range("A" & UltFila).Value = Lvi_Ventas.SubItems(0).Text
        '        .Range("B" & UltFila).Value = Lvi_Ventas.SubItems(1).Text
        '        .Range("C" & UltFila).Value = Lvi_Ventas.SubItems(2).Text
        '        .Range("D" & UltFila).Value = Lvi_Ventas.SubItems(3).Text
        '        .Range("E" & UltFila).Value = Lvi_Ventas.SubItems(4).Text

        '        If Dt_Detalle.Rows.Count <> 0 Then
        '            For Each Dr_Detalle As DataRow In Dt_Detalle.Rows
        '                If Dr_Detalle("Id_MatVenta") = Lvi_Ventas.Tag Then
        '                    UltFila += 1
        '                    .Range("B" & UltFila).Value = "'" & Dr_Detalle("Clave")
        '                    .Range("C" & UltFila).Value = Dr_Detalle("Descripcion")
        '                    .Range("D" & UltFila).Value = Dr_Detalle("Cantidad")
        '                    .Range("B" & UltFila & ":D" & UltFila).Font.Italic = True
        '                    .Range("B" & UltFila & ":D" & UltFila).Font.Size = 10

        '                End If
        '            Next
        '        End If
        '        UltFila += 1
        '        frm_MENU.prg_Barra.Value += 1
        '    Next
        '    .Range("A4:E4").Font.Bold = True
        '    .Range("A4:E" & UltFila).EntireColumn.Autofit()
        '    .Range("A4:E" & UltFila).Borders.Value = True

        '    'Mostrando el Libro
        '    .Visible = True
        'End With
        '----------------------------------------------------------------------------------------
        SegundosDesconexion = 0
        'Cn_Login.fn_Log_Create("EXPORTAR REPORTE DE INVENTARIO DE MATERIALES ")
        'If Tipo = 2 Then
        'If dgv_Detalle.Rows.Count < 0 Then
        '    MsgBox("no se ha seleccionado ninguna solicitud.", MsgBoxStyle.Critical, Me.Text)

        'Else
        '    Call ExportarGrid__Compra(dgv_Detalle)
        'End If


        'End If

        '----------------------------------------------------------------------------------------


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

            .Range("B1:H1").Merge()
            .Range("B1").Value = Me.Text
            .Range("B1").Font.Bold = True

            .Range("A2:H2").Merge()
            Dim Status As String = ""
            If cmb_Status.SelectedValue = "C" Then
                Status = "CANCELADO"
            Else
                If cmb_Status.SelectedValue = "V" Then
                    Status = "VALIDADO"
                Else
                    Status = "SURTIDO"
                End If
            End If
            .Range("A2").Value = "Desde: " & dtp_Desde.Text & " Hasta: " & dtp_Hasta.Text & "  -  Status: " & Status


            .Range("A2").Font.Bold = True

            .Range("A4").Value = "Numero"
            .Range("B4").Value = "Fecha"
            .Range("C4").Value = "Hora"
            .Range("D4").Value = "UsuarioSolicita"
            .Range("E4").Value = "Status"
            .Range("F4").Value = "Observaciones"

            Dt_Detalle = Cn_Materiales.fn_ConsultaSolicitudesMaterial_LlenarReporte(dtp_Desde.Value.Date, dtp_Hasta.Value.Date, cmb_Status.SelectedValue, cbx_Tipo.SelectedValue)

            For Each Lvi_Solicitudes As ListViewItem In Lsv_Ventas.Items

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

    End Sub
    Sub ExportarGrid__Compra(EGrid As DataGridView)
        Dim exApp As New Microsoft.Office.Interop.Excel.Application
        Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
        Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet

        exLibro = exApp.Workbooks.Add
        exHoja = exLibro.Worksheets.Add()

        'exHoja.Range("C1", "C5").HorizontalAlignment = HorizontalAlignment.Center
        exHoja.Range("B1:B5").HorizontalAlignment = 4
        exHoja.Range("B1:B5").Font.Bold = 14



        exHoja.Cells.Item(1, 2) = "Número de Solicitud:"
        exHoja.Cells.Item(2, 2) = "Usuario Solicita:"
        exHoja.Cells.Item(3, 2) = "Sucursal:"
        exHoja.Cells.Item(4, 2) = "Departamento:"
        exHoja.Cells.Item(5, 2) = "Fecha Solicitud:"
        exHoja.Cells.Item(43, 1) = "________________"
        exHoja.Cells.Item(44, 1) = "FIRMA"
        exHoja.Cells.Item(45, 1) = UsuarioN
        exHoja.Cells.Item(46, 1) = "ENTREGA"
        exHoja.Range("A43:A46").HorizontalAlignment = 3
        exHoja.Range("D44:D46").HorizontalAlignment = 3

        exHoja.Cells.Item(43, 4) = "________________"
        exHoja.Cells.Item(44, 4) = "FIRMA"
        exHoja.Cells.Item(45, 4) = "Y NOMBRE"
        exHoja.Cells.Item(46, 4) = "RECIBE"

        exHoja.Range("C1", "C5").HorizontalAlignment = 2

        exHoja.Cells.Item(1, 3) = Lsv_Ventas.SelectedItems(0).SubItems(0).Text
        exHoja.Cells.Item(2, 3) = Lsv_Ventas.SelectedItems(0).SubItems(3).Text
        exHoja.Cells.Item(3, 3) = SucursalN
        exHoja.Cells.Item(4, 3) = "TRASLADO"
        exHoja.Cells.Item(5, 3) = Lsv_Ventas.SelectedItems(0).SubItems(1).Text & "-" & Lsv_Ventas.SelectedItems(0).SubItems(2).Text

        'exHoja.Range("a1").VerticalAlignment.

        Dim NCol As Integer = EGrid.ColumnCount
        Dim NRow As Integer = EGrid.RowCount
        For i As Integer = 1 To (NCol - 2)
            exHoja.Cells.Item(6, i) = EGrid.Columns(i - 1).Name.ToString

        Next
        Dim Rango As Integer = 0
        For Fila As Integer = 0 To NRow - 1
            For Col As Integer = 0 To NCol - 1
                exHoja.Cells.Item(Fila + 7, Col + 1) = EGrid.Rows(Fila).Cells(Col).Value
                Rango = Fila
                exHoja.Cells.Item(Fila + 7, 4) = ""
            Next

        Next

        exHoja.Range("B7", "G" & NRow + 7).HorizontalAlignment = 3
        exHoja.Range("A6", "G" & NRow + 6).Borders.LineStyle = 7
        exHoja.Range("A7", "A" & NRow + 7).VerticalAlignment = 2
        exHoja.Cells.Item(9, 4) = ""
        'exHoja.Range("A10", "G13").Borders.Weight = BorderStyle.FixedSingle

        exHoja.Cells.Item(38, 1) = "Observaciones"
        exHoja.Cells.Item(39, 1) = "_________________________________________________________________________________________"
        exHoja.Cells.Item(40, 1) = "_________________________________________________________________________________________"


        'exHoja.Shapes.AddConnector(10, 10, 250, 250).Line

        exHoja.Range("A6", "G10").Font.Size = 10

        exHoja.Cells.Item(6, 2) = "Cantidad Solicitada"
        exHoja.Cells.Item(6, 3) = "Cantidad Valida"
        exHoja.Cells.Item(6, 4) = "Check-in"

        'Dim Ruta As String = fn_ArchivosPath("C:\Users\juan.mora\Documents\RespaldoMora\Nueva carpeta\Modulo_Materiales_Central\Resources\sisssa.jpg")

        'exHoja.Pictures.Insert(Ruta)
        exHoja.Pictures.Insert("C:\Users\juan.mora\Documents\sisssa.jpg")


        exHoja.Columns.AutoFit()
        exHoja.Columns("E").Hidden = True
        exHoja.Columns("G").Hidden = True
        exHoja.Columns("F").Hidden = True
        exHoja.Columns("A").ColumnWidth = 37
        exHoja.Columns("B").ColumnWidth = 15
        exHoja.Columns("C").ColumnWidth = 15
        exHoja.Columns("D").ColumnWidth = 18
        'exHoja.Cells("B43").

        exApp.Application.Visible = True

        exHoja = Nothing
        exLibro = Nothing
        exApp = Nothing

    End Sub

    Private Sub gbx_Filtro_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbx_Filtro.MouseHover
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
    End Sub

    Private Sub Lsv_Ventas_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lsv_Ventas.MouseHover
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
    End Sub

    Private Sub frm_ReporteVentas_SizeChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        'lbl_Folios.Left = lsv_Folios.Left
    End Sub

    Private Sub btn_Buscar_Click(sender As Object, e As EventArgs) Handles btn_Buscar.Click
        dgv_Detalle.Rows.Clear()
        If cbx_Tipo.Text = "Seleccione..." Then
            MsgBox("Seleccione el Tipo.", MsgBoxStyle.Critical, Me.Text)

        Else
            If cmb_Status.Text = "Seleccione..." Then
                MsgBox("Seleccione un Status.", MsgBoxStyle.Critical, Me.Text)
            Else

                Stas = cmb_Status.SelectedValue
                TStas = cbx_Tipo.SelectedValue
                Call LlenarSolicitudes(TStas, Stas)
                btn_Exportar.Enabled = False

            End If

        End If


    End Sub


End Class