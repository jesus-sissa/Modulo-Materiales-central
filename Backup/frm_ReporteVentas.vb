Imports Modulo_MaterialesCentral.Cn_Materiales

Public Class frm_ReporteVentas

    Private Sub frm_ReporteVentas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmb_Depto.AgregarItem("1", "PROCESO")
        cmb_Depto.AgregarItem("2", "MORRALLA")
        cmb_Depto.AgregarItem("3", "CAJEROS")
        cmb_Depto.AgregarItem("4", "TRASLADO")
        cmb_Depto.AgregarItem("5", "NOMINAS")
        cmb_Depto.AgregarItem("6", "PROCESO ATMS")
        cmb_Depto.AgregarItem("7", "AUDITORIA ATMS")

        cmb_Status.AgregarItem("SO", "PENDIENTE")
        cmb_Status.AgregarItem("EM", "RECIBIDO")
        cmb_Status.AgregarItem("CA", "CANCELADO")

        Lsv_Ventas.Columns.Add("Fecha")
        Lsv_Ventas.Columns.Add("Hora")
        Lsv_Ventas.Columns.Add("Asignó")
        Lsv_Ventas.Columns.Add("Departamento")
        Lsv_Ventas.Columns.Add("Status")

        lsv_VentasD.Columns.Add("Clave")
        lsv_VentasD.Columns.Add("Descripcion")
        lsv_VentasD.Columns.Add("Cantidad")

        lsv_Folios.Columns.Add("Material")
        lsv_Folios.Columns.Add("Inicial")
        lsv_Folios.Columns.Add("Final")
        lsv_Folios.Columns.Add("Cantidad")
    End Sub

    Sub LimpiarListas()
        Lsv_Ventas.Items.Clear()
        lsv_VentasD.Items.Clear()
        lsv_Folios.Items.Clear()
        btn_Exportar.Enabled = False
        Lbl_Registros.Text = "Registros: 0"
    End Sub

    Private Sub btn_Mostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Mostrar.Click
        'Inicializar la variable de desconexión
        SegundosDesconexion = 0

        If dtp_Desde.Value.Date > dtp_Hasta.Value.Date Then
            MsgBox("El rango de fechas parece ser incorrecto.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        If cmb_Depto.Enabled = True And cmb_Depto.SelectedValue = "0" Then
            MsgBox("Seleccione un Departamento.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Depto.Focus()
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
        If Not Cn_Materiales.fn_ReporteAsignaciones_LlenarLista(Lsv_Ventas, cmb_Depto.SelectedValue, dtp_Desde.Value.Date, dtp_Hasta.Value.Date, Status) Then
            MsgBox("Ocurrió un error al intentar consultar las Asignaciones de Materiales.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
        Lbl_Registros.Text = "Registros: " & Lsv_Ventas.Items.Count
        btn_Exportar.Enabled = Lsv_Ventas.Items.Count > 0
    End Sub

    Private Sub cbx_Depto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_Depto.CheckedChanged
        SegundosDesconexion = 0

        Call LimpiarListas()
        cmb_Depto.SelectedValue = "0"
        If cbx_Depto.Checked Then
            cmb_Depto.Enabled = False
        Else
            cmb_Depto.Enabled = True
        End If
    End Sub

    Private Sub cbx_Status_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_Status.CheckedChanged
        SegundosDesconexion = 0

        Call LimpiarListas()
        cmb_Status.SelectedValue = "0"
        If cbx_Status.Checked Then
            cmb_Status.Enabled = False
        Else
            cmb_Status.Enabled = True
        End If
    End Sub

    Private Sub cmb_Depto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Depto.SelectedIndexChanged
        Call LimpiarListas()
    End Sub

    Private Sub cmb_Status_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Status.SelectedIndexChanged
        Call LimpiarListas()
    End Sub

    Private Sub dtp_Desde_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_Desde.ValueChanged
        Call LimpiarListas()
    End Sub

    Private Sub dtp_Hasta_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_Hasta.ValueChanged
        Call LimpiarListas()
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub Lsv_Ventas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lsv_Ventas.SelectedIndexChanged
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0

        If Lsv_Ventas.SelectedItems.Count = 0 Then
            lsv_VentasD.Items.Clear()
            lsv_Folios.Items.Clear()
            Exit Sub
        Else
            'Mostrar el detalle de la asignación de Materiales seleccionada
            If Not fn_ValidaMaterialesD_LlenarLista(lsv_VentasD, lsv_VentasD.Lvs, Lsv_Ventas.SelectedItems(0).Tag) Then
                MsgBox("Ha ocurrido un error al intentar consultar el Detalle.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            Else
                lsv_VentasD.Columns(2).TextAlign = HorizontalAlignment.Right
            End If
            'Mostrar los Folios de Remisiones asignadas
            If Not fn_ReporteAsignaciones_DetalleFolios(lsv_Folios, Lsv_Ventas.SelectedItems(0).Tag) Then
                MsgBox("Ha ocurrido un error al intentar consultar los Folios de Remisiones asignadas.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
        End If
        'Lbl_Registros.Text = "Registros: " & lsv_Folios.Items.Count
    End Sub

    Private Sub btn_Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Exportar.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        Dim Dt_Detalle As New DataTable
        Dim UltFila As Integer = 5

        'FuncionesGlobales.fn_Exportar_Excel(Lsv_Ventas, 2, "Asignaciones de Materiales", 0, 0, frm_MENU.prg_Barra)

        Cn_Login.fn_Log_Create("EXPORTAR REPORTE DE ASIGNACION DE MATERIALES. FECHAS: " & dtp_Desde.Value.ToShortDateString & " - " & dtp_Hasta.Value.ToShortDateString & " / DEPARTAMENTO: " & cmb_Depto.Text & " / STATUS: " & cmb_Status.Text)

        frm_MENU.prg_Barra.Maximum = Lsv_Ventas.Items.Count + 1

        'Dim  As New Excel.Application
        Dim App = CreateObject("Excel.Application")
        With App

            'Creando el libro
            .Workbooks.Add()
            .SheetsInNewWorkbook = 1
            .Range("A1:E1").Merge()
            .Range("A1").Value = Me.Text
            .Range("B1").Merge()
            .Range("A2:E2").Merge()
            .Range("A2").Value = "Desde: " & dtp_Desde.Text & " Hasta: " & dtp_Hasta.Text & "  -  Departamento: " & IIf(cbx_Depto.Checked, "Todos", cmb_Depto.SelectedText) & "  -  Status: " & IIf(cbx_Status.Checked, "Todos", cmb_Status.SelectedText)
            .Range("A1").Font.Bold = True
            .Range("A2").Font.Bold = True

            .Range("A4").Value = "Fecha"
            .Range("B4").Value = "Hora"
            .Range("C4").Value = "Asigno"
            .Range("D4").Value = "Destino"
            .Range("E4").Value = "Status"

            Dt_Detalle = Cn_Materiales.fn_ReporteAsignaciones_LlenarRpt(cmb_Depto.SelectedValue, dtp_Desde.Value.Date, dtp_Hasta.Value.Date, IIf(cmb_Status.SelectedValue = 0, "T", cmb_Status.SelectedValue))

            For Each Lvi_Ventas As ListViewItem In Lsv_Ventas.Items

                .Range("A" & UltFila).Value = Lvi_Ventas.SubItems(0).Text
                .Range("B" & UltFila).Value = Lvi_Ventas.SubItems(1).Text
                .Range("C" & UltFila).Value = Lvi_Ventas.SubItems(2).Text
                .Range("D" & UltFila).Value = Lvi_Ventas.SubItems(3).Text
                .Range("E" & UltFila).Value = Lvi_Ventas.SubItems(4).Text

                If Dt_Detalle.Rows.Count <> 0 Then
                    For Each Dr_Detalle As DataRow In Dt_Detalle.Rows
                        If Dr_Detalle("Id_MatVenta") = Lvi_Ventas.Tag Then
                            UltFila += 1
                            .Range("B" & UltFila).Value = "'" & Dr_Detalle("Clave")
                            .Range("C" & UltFila).Value = Dr_Detalle("Descripcion")
                            .Range("D" & UltFila).Value = Dr_Detalle("Cantidad")
                            .Range("B" & UltFila & ":D" & UltFila).Font.Italic = True
                            .Range("B" & UltFila & ":D" & UltFila).Font.Size = 10

                        End If
                    Next
                End If
                UltFila += 1
                frm_MENU.prg_Barra.Value += 1
            Next
            .Range("A4:E4").Font.Bold = True
            .Range("A4:E" & UltFila).EntireColumn.Autofit()
            .Range("A4:E" & UltFila).Borders.Value = True

            'Mostrando el Libro
            .Visible = True
        End With
        frm_MENU.prg_Barra.Value = frm_MENU.prg_Barra.Maximum
        frm_MENU.prg_Barra.Value = frm_MENU.prg_Barra.Minimum

    End Sub

    Private Sub gbx_Filtro_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbx_Filtro.MouseHover
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
    End Sub

    Private Sub Lsv_Ventas_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lsv_Ventas.MouseHover, lsv_VentasD.MouseHover, lsv_Folios.MouseHover
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
    End Sub

    Private Sub frm_ReporteVentas_SizeChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        lbl_Folios.Left = lsv_Folios.Left
    End Sub
End Class