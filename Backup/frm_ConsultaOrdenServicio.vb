Imports Modulo_MaterialesCentral.Cn_Materiales

Public Class frm_ConsultaOrdenServicio

    Private Sub frm_ConsultaOrdenServicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SegundosDesconexion = 0

        lsv_proveedores.Columns.Add("Folio")
        lsv_proveedores.Columns.Add("Fecha")
        lsv_proveedores.Columns.Add("Hora")
        lsv_proveedores.Columns.Add("Proveedor")
        lsv_proveedores.Columns.Add("TipoEquipo")
        lsv_proveedores.Columns.Add("Marca")
        lsv_proveedores.Columns.Add("Modelo")
        lsv_proveedores.Columns.Add("Serie")
        lsv_proveedores.Columns.Add("Ubicacion")
        lsv_proveedores.Columns.Add("Descripcion")
        lsv_proveedores.Columns.Add("EmpleadoSolicita")
        lsv_proveedores.Columns.Add("Status")

        cmb_Proveedores.Actualizar()

    End Sub

    Private Sub chk_Proveedor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Proveedor.CheckedChanged
        SegundosDesconexion = 0
        Call LimpiarObjetos()
        cmb_Proveedores.SelectedValue = 0
        cmb_Proveedores.Enabled = Not chk_Proveedor.Checked
    End Sub

    Private Sub LimpiarObjetos()
        lsv_proveedores.Items.Clear()
        btn_Imprimir.Enabled = False
        btn_Exportar.Enabled = False
        FuncionesGlobales.fn_NumRegistros(lbl_Registros, lsv_proveedores.Items.Count)
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0
        Me.Close()
    End Sub

    Private Sub btn_Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Exportar.Click
        SegundosDesconexion = 0
        FuncionesGlobales.fn_Exportar_Excel(lsv_proveedores, 2, Me.Text, 0, 0, frm_MENU.prg_Barra)
        Cn_Login.fn_Log_Create("EXPORTAR REPORTE CONSULTA DE ORDEN DE SERVICIO. FECHAS: " & dtp_FechaInicio.Value.ToShortDateString & " - " & dtp_Fechafin.Value.ToShortDateString & " / PROVEEDOR: " & cmb_Proveedores.Text)

    End Sub

    Private Sub btn_Imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Imprimir.Click
        SegundosDesconexion = 0
        Me.Cursor = Cursors.WaitCursor
        Dim frm As New frm_Reporte 'formulario para reporte(contiene crv)
        Dim rpt As New rpt_OrdenServicio 'archivo crystal para reporte
        Dim ds As New ds_OrdenServicio 'archivo datset elque tiene el Store Procedure

        'Nota:pasar el Dataset como parametro el nombre de la tabla que tiene en el Archivo Dataset
        If Not fn_ReporteOrdenServicio(ds.dt_SI_Ordenes_Get, lsv_proveedores.SelectedItems(0).Tag) Then
            MsgBox("Ha Ocurrido un Error al generar el reporte.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        ElseIf Not fn_Reportes_Encabezado(ds.Tbl_DatosEmpresa) Then
            MsgBox("Ha Ocurrido un Error al generar el reporte.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        Else

            '--------------pruebas de imagen en reportes {
            If Not IsDBNull(ds.Tbl_DatosEmpresa.Rows(0)("logo")) Then

                Dim imagenNueva As Image = Nothing
                Dim imagenBytes As Byte() = ds.Tbl_DatosEmpresa.Rows(0)("logo")
                Dim ms_ByteToImagen As New IO.MemoryStream(imagenBytes)
                imagenNueva = Image.FromStream(ms_ByteToImagen, True)

                Dim Ancho As Integer = imagenNueva.Width
                Dim Alto As Integer = imagenNueva.Height
                Dim valordiv As Decimal = 0.0

                With rpt.ReportDefinition.Sections("Section1").ReportObjects("Logo")

                    Dim Top_Obj As Integer = .Top
                    Dim Left_Obj As Integer = .Left '+- 342default
                    Dim Width_Obj As Integer = .Width '1440Default

                    If Ancho > Alto Then valordiv = Width_Obj / Ancho Else valordiv = Width_Obj / Alto
                    Dim nuevoAncho As Integer = Ancho * valordiv
                    Dim NuevoAlto As Integer = Alto * valordiv

                    If Ancho > Alto Then
                        'horizontal
                        Top_Obj = Top_Obj + ((Width_Obj - NuevoAlto) / 2)
                        .Top = Top_Obj
                    Else
                        'vertical,cuadrado
                        Left_Obj = Left_Obj + ((Width_Obj - nuevoAncho) / 2)
                        .Left = Left_Obj
                    End If
                    .Width = nuevoAncho
                    .Height = NuevoAlto
                End With

                '-------liberar objetos
                ms_ByteToImagen.Dispose()
                imagenNueva.Dispose()
            End If
            '--------------}

            rpt.SetDataSource(ds) 'el Archivo crystal obtiene datos de Dataset
            frm.crv.ReportSource = rpt 'luego los pasa al frm que contiene el <crv> LE pasamos el crystal
            frm.WindowState = FormWindowState.Maximized
            frm.ShowDialog()
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub btn_Mostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Mostrar.Click
        SegundosDesconexion = 0
        Dim Id_Proveedor As Integer
        btn_Imprimir.Enabled = False
        btn_Exportar.Enabled = False

        If dtp_FechaInicio.Value.Date > dtp_Fechafin.Value.Date Then
            MsgBox("La fecha inicial Desde Debe Ser menor que la Fecha Hasta", MsgBoxStyle.Critical, frm_MENU.Text)
            dtp_FechaInicio.Focus()
            Exit Sub
        End If

        If cmb_Proveedores.SelectedValue = "0" AndAlso Not chk_Proveedor.Checked Then
            MsgBox("Seleccione algun Proveedor o Marque la casilla <<Todos>>", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Proveedores.Focus()
            Exit Sub
        End If

        If chk_Proveedor.Checked Then
            Id_Proveedor = 0
        Else
            Id_Proveedor = cmb_Proveedores.SelectedValue
        End If

        If Not fn_Consulta_OrdenServicio(lsv_proveedores, dtp_FechaInicio.Value.Date, dtp_Fechafin.Value.Date, Id_Proveedor) Then
            MsgBox("Ocurrió un error al intentar Cargar los Datos de la Consulta", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        btn_Exportar.Enabled = lsv_proveedores.Items.Count > 0
        FuncionesGlobales.fn_NumRegistros(lbl_Registros, lsv_proveedores.Items.Count)
    End Sub

    Private Sub lsv_proveedores_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_proveedores.SelectedIndexChanged
        SegundosDesconexion = 0
        btn_Imprimir.Enabled = lsv_proveedores.SelectedItems.Count > 0
        btn_Exportar.Enabled = lsv_proveedores.Items.Count > 0
    End Sub

End Class