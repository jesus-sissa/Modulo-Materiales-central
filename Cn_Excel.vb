Public Class Cn_Excel
    Public Shared Function LetrA(ByVal ch As Integer) As String
        LetrA = ""
        If ch > 64 And ch < 91 Then
            LetrA = Chr(ch) 'A - Z
        ElseIf ch > 90 And ch < 117 Then
            LetrA = Chr(64 + 1) & Chr(ch - 26) 'AA - AZ
        ElseIf ch > 116 And ch < 143 Then
            LetrA = Chr(64 + 2) & Chr(ch - 52) 'BA - BZ
        ElseIf ch > 142 And ch < 169 Then
            LetrA = Chr(64 + 3) & Chr(ch - 78) 'CA - CZ
        ElseIf ch > 168 And ch < 195 Then
            LetrA = Chr(64 + 4) & Chr(ch - 104) 'DA - DZ
        ElseIf ch > 194 And ch < 221 Then
            LetrA = Chr(64 + 5) & Chr(ch - 130) 'EA - EZ
        ElseIf ch > 220 And ch < 247 Then
            LetrA = Chr(64 + 6) & Chr(ch - 156) 'FA - FZ
        ElseIf ch > 246 And ch < 273 Then
            LetrA = Chr(64 + 7) & Chr(ch - 182) 'GA - GZ
        ElseIf ch > 272 And ch < 299 Then
            LetrA = Chr(64 + 8) & Chr(ch - 208) 'HA - HZ
        ElseIf ch > 298 And ch < 325 Then
            LetrA = Chr(64 + 9) & Chr(ch - 234) 'IA - IZ
        ElseIf ch > 324 And ch < 351 Then
            LetrA = Chr(64 + 10) & Chr(ch - 260) 'JA - JZ
        End If
    End Function
    Public Shared Function fn_ExportarExcel_Microsoft_KingSoft(ByVal Lista As ListView, ByVal Filas_sin_Texto As Integer, ByVal Titulo As String, ByVal Cols_Izquierda_Omitir As Integer, ByVal Cols_Derecha_Omitir As Integer, ByVal Bar As ToolStripProgressBar, ByVal ObjetoHC As String) As Boolean
        'Funcion que exporta a Hoja de Cálculo de Microsoft Office y Kingsoft Office
        Dim I As Integer
        Dim J As Integer
        Dim n As Integer

        If (Cols_Izquierda_Omitir + Cols_Derecha_Omitir) < Lista.Columns.Count Then
            Try
                'mandamos la cadena Objeto ya sea Microsoft o Kinsoft
                Dim objExcel = CreateObject(ObjetoHC)

                Bar.Maximum = (Lista.Columns.Count - Cols_Derecha_Omitir - Cols_Izquierda_Omitir) * Lista.Items.Count + 2
                Bar.Value = 0

                objExcel.UserControl = True
                Dim oldCI As System.Globalization.CultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture
                System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("en-US")
                System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-MX")
                System.Threading.Thread.CurrentThread.CurrentCulture = oldCI

                objExcel.SheetsInNewWorkbook = 1
                objExcel.Workbooks.Add()

                With objExcel
                    For I = (0 + Cols_Izquierda_Omitir) To Lista.Columns.Count - 1 - Cols_Derecha_Omitir
                        For J = 0 To Lista.Items.Count - 1
                            If J = 0 Then
                                .Range(LetrA(64 + I + 1 - Cols_Izquierda_Omitir) & J + Filas_sin_Texto + 1).Value = Lista.Columns(I).Text
                            End If
                            If I = 0 Then
                                .Range(LetrA(64 + I + 1 - Cols_Izquierda_Omitir) & J + 1 + Filas_sin_Texto + 1).Value = "'" & Lista.Items(J).Text
                            Else
                                .Range(LetrA(64 + I + 1 - Cols_Izquierda_Omitir) & J + 1 + Filas_sin_Texto + 1).Value = "'" & Lista.Items(J).SubItems(I).Text
                            End If
                            Bar.Value += 1
                        Next J
                    Next I
                    For n = 0 To I + 1
                        .Range(LetrA(64 + n + 1) & "1").EntireColumn.AutoFit()
                    Next n
                    .Range("A" & (0 + Filas_sin_Texto + 1).ToString & ":" & LetrA(64 + I) & (0 + Filas_sin_Texto + 1).ToString).Font.Bold = True
                    If Filas_sin_Texto > 0 Then
                        .Range("A1").Value = Titulo
                        .Range("A1").Font.Bold = True
                        .Range("A1:" & LetrA(64 + I) & "1").Merge()
                        .Selection.HorizontalAlignment = -4108
                    End If
                End With

                Bar.Value = Bar.Maximum

                fn_ExportarExcel_Microsoft_KingSoft = True
                objExcel.Visible = True
                objExcel = Nothing
                Bar.Value = 0
            Catch ex As Exception
                fn_ExportarExcel_Microsoft_KingSoft = False
                MsgBox("Ocurrió un error." & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
                Bar.Value = Bar.Minimum
            End Try
        Else
            fn_ExportarExcel_Microsoft_KingSoft = False
        End If
    End Function
    Public Shared Function fn_Exportar_Excel(ByVal Lista As ListView, ByVal Filas_sin_Texto As Integer, ByVal Titulo As String, ByVal Cols_Izquierda_Omitir As Integer, ByVal Cols_Derecha_Omitir As Integer, ByVal Bar As ToolStripProgressBar) As Boolean
        Dim versionHC As Boolean = False
        Dim ObjetoHC As String = ""
        Try
            '-----para Microsoft Office(Excel)
            Try
                ObjetoHC = "Excel.Application"
                Dim objExcel = CreateObject(ObjetoHC)
                versionHC = True
                objExcel = Nothing
                Call fn_ExportarExcel_Microsoft_KingSoft(Lista, Filas_sin_Texto, Titulo, Cols_Izquierda_Omitir, Cols_Derecha_Omitir, Bar, ObjetoHC)
            Catch ex As Exception
                versionHC = False
            End Try

            '-----para KingSoft Office (Spreadsheets) 
            If versionHC = False Then
                Try
                    ObjetoHC = "Ket.Application"
                    Dim objExcel = CreateObject(ObjetoHC)
                    versionHC = True
                    objExcel = Nothing
                    Call fn_ExportarExcel_Microsoft_KingSoft(Lista, Filas_sin_Texto, Titulo, Cols_Izquierda_Omitir, Cols_Derecha_Omitir, Bar, ObjetoHC)
                Catch ex As Exception
                    versionHC = False
                End Try
            End If

            '----------para Apache OpenOffice 4.0 (Calc)--
            If versionHC = False Then

                Try
                    Dim objServManager = CreateObject("com.sun.star.ServiceManager")
                    versionHC = True
                    objServManager = Nothing
                    fn_Exportar_CalcOpenOffice(Lista, Filas_sin_Texto, Titulo, Cols_Izquierda_Omitir, Cols_Derecha_Omitir, Bar)

                Catch ex As Exception
                    versionHC = False
                End Try
            End If

            If versionHC = False Then
                MsgBox("No se encontró niguna paqueteria  de gestión de hoja de cálculo para la exportación de la lista, por lo tanto se procederá a guardar el archivo.", MsgBoxStyle.Exclamation, frm_MENU.Text)

                Dim svd As New SaveFileDialog
                svd.Title = "Guardar Como"
                svd.Filter = "Texto CSV (*.csv)|*.csv"
                svd.FilterIndex = 1
                svd.DefaultExt = "csv"
                svd.OverwritePrompt = True
                svd.FileName = "Reporte"
                If svd.ShowDialog = DialogResult.OK Then
                    '--en caso de que no hay paqueteria, solo guarda con .csv
                    If fn_Exporta_ListviewToExcel(Lista, svd.FileName) Then
                        versionHC = True
                        MsgBox("El archivo se ha guardado correctamente en: " & svd.FileName, MsgBoxStyle.Information, frm_MENU.Text)

                    End If
                End If
            End If
            Return versionHC

        Catch ex As Exception
            MsgBox("No se pudo exportar lista a hoja de cálculo", MsgBoxStyle.Critical, frm_MENU.Text)
            Return False
        End Try

    End Function
    Public Shared Function fn_Exportar_CalcOpenOffice(ByVal Lista As ListView, ByVal Filas_sin_Texto As Integer, ByVal Titulo As String, ByVal Cols_Izquierda_Omitir As Integer, ByVal Cols_Derecha_Omitir As Integer, ByVal Bar As ToolStripProgressBar) As Boolean
        Dim I As Integer
        Dim J As Integer
        Dim Cont As Integer = 0
        Dim SumLetra As String = ""

        If (Cols_Izquierda_Omitir + Cols_Derecha_Omitir) < Lista.Columns.Count Then

            Try
                Dim objServManager As Object
                Dim objDesktop As Object
                Dim objDocument As Object '--->
                Dim objSheet1 As Object
                Dim objArguments As Object() = {} 'ok

                objServManager = CreateObject("com.sun.star.ServiceManager")
                objDesktop = objServManager.createInstance("com.sun.star.frame.Desktop")
                objDocument = objDesktop.loadComponentFromURL("private:factory/scalc", "_blank", 0, objArguments)
                Bar.Maximum = (Lista.Columns.Count - Cols_Derecha_Omitir - Cols_Izquierda_Omitir) * Lista.Items.Count + 2
                Bar.Value = 0

                objSheet1 = objDocument.Sheets.getByIndex(0)
                With objSheet1

                    For I = (0 + Cols_Izquierda_Omitir) To Lista.Columns.Count - 1 - Cols_Derecha_Omitir
                        For J = 0 To Lista.Items.Count - 1
                            If J = 0 Then
                                'ESCRIBE ENCABEZADOS
                                .getCellRangeByName(LetrA(64 + I + 1 - Cols_Izquierda_Omitir) & J + Filas_sin_Texto + 1).SetString(Lista.Columns(I).Text)
                            End If
                            If I = 0 Then
                                'ESCRIBE CONTENIDO DE LISTVIEW
                                .getCellRangeByName(LetrA(64 + I + 1 - Cols_Izquierda_Omitir) & J + 1 + Filas_sin_Texto + 1).SetString(Lista.Items(J).Text)
                            Else
                                'ESCRIBE CONTENIDO DE LISTVIEW
                                .getCellRangeByName(LetrA(64 + I + 1 - Cols_Izquierda_Omitir) & J + 1 + Filas_sin_Texto + 1).SetString(Lista.Items(J).SubItems(I).Text)
                            End If
                            Bar.Value += 1
                        Next J
                    Next I

                    '--PONE EN NEGRITA LOS ENCABEZADOS
                    SumLetra = "A" & (0 + Filas_sin_Texto + 1).ToString & ":" & LetrA(64 + I) & (0 + Filas_sin_Texto + 1).ToString
                    .getCellRangeByName(SumLetra).CharWeight = 150 ' negrita encabezado

                    '--AJUSTA LAS COLUMNAS - AUTOFIT
                    For Cont = 0 To I - 1
                        .Columns(Cont).OptimalWidth = True
                    Next Cont

                    If Filas_sin_Texto > 0 Then
                        'TITULO EN NEGRITA CENTRADO Y CELDA COMBINADO
                        .getCellRangeByName("A1").SetString(Titulo)

                        Cont = (Lista.Columns.Count) - (Cols_Derecha_Omitir + Cols_Izquierda_Omitir)
                        SumLetra = "A1:" & LetrA(64 + Cont) & "1"

                        .getCellRangeByName(SumLetra).Merge(True) 'combina celda
                        .getCellRangeByName(SumLetra).VertJustify = 2 'centrar
                        .getCellRangeByName(SumLetra).HoriJustify = 2 ' centrar
                        .getCellRangeByName(SumLetra).CharWeight = 150 ' negrita
                    End If
                End With

                Bar.Value = Bar.Maximum
                fn_Exportar_CalcOpenOffice = True
                objServManager = Nothing
                Bar.Value = 0

            Catch ex As Exception
                fn_Exportar_CalcOpenOffice = False
                MsgBox("Ocurrió un error." & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
                Bar.Value = Bar.Minimum
            End Try
        Else
            fn_Exportar_CalcOpenOffice = False
        End If

    End Function
    Public Shared Function fn_Exporta_ListviewToExcel(ByVal Lista As ListView, ByVal RutaficheroCSV As String) As Boolean
        Try

            'Dim Fecha As String = Format(Now, "_dd-MM-yyyy")
            'Dim Hora As String = Format(Now, "_HH-mm-ss")
            Dim sb As String = ""
            Dim i As Integer = 0, j As Integer = 0
            FileOpen(1, RutaficheroCSV, OpenMode.Output)

            For Each elemento As ColumnHeader In Lista.Columns
                sb &= Trim(elemento.Text) & ";"
            Next
            PrintLine(1, sb)
            '------------
            For i = 0 To Lista.Items.Count - 1
                sb = ""
                For j = 0 To Lista.Columns.Count - 1
                    sb &= Lista.Items(i).SubItems(j).Text.Trim & ";"
                Next j
                'va imprimiendo cada linea
                PrintLine(1, sb)
            Next i

            'cerrando el archivo
            FileClose(1)
            Return True
        Catch ex As Exception
            MsgBox("error al guadar archivo: " & ex.Message, MsgBoxStyle.Critical, frm_MENU.Text)
            FileClose(1)
            Return False
        End Try

    End Function

End Class
