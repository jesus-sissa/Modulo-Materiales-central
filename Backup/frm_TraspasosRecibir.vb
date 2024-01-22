Public Class frm_TraspasosRecibir

    Dim Clave_SucursalO As String

    Private Sub frm_Valida_Ventas_Materiales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lsv_Traspasos.Columns.Add("Fecha")
        lsv_Traspasos.Columns.Add("Hora")
        lsv_Traspasos.Columns.Add("Origen")
        lsv_Traspasos.Columns.Add("UsuarioEnvia")
        lsv_Traspasos.Columns.Add("Comentarios")

        lsv_TraspasosD.Columns.Add("Descripcion")
        lsv_TraspasosD.Columns.Add("Cantidad", 10, HorizontalAlignment.Right)

        If Cnx_Central = "" Then
            MsgBox("No se han definido los parámetros de conexión con la Base de Datos Central de SIAC. Si no captura estos parámetros no podrá tener acceso a las pantallas de este Módulo." & Chr(13) & "Para configurar estos parámetros vaya al Menu Archivo y seleccione la opción «Parámetros de Servidor Central».", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        Dim Dt_SucursalesP As DataTable = Cn_Materiales.Fn_SuscursalesPropias_Combo()
        'Quitar de la lista la Sucursal actual ya que no se pueden hacer envios a uno mismo
        For Each dr As DataRow In Dt_SucursalesP.Rows
            If dr("Clave SP") = SucursalClave Then
                Dt_SucursalesP.Rows.Remove(dr)
                Exit For
            End If
        Next
        FuncionesGlobales.fn_CargaCombo(cmb_Sucursal, Dt_SucursalesP, "Sucursal Id", "Nombre")

    End Sub

    Private Sub cmb_Sucursal_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Sucursal.SelectedValueChanged
        Call LlenarLista()
    End Sub

    Sub LlenarLista()
        SegundosDesconexion = 0
        lsv_Traspasos.Items.Clear()
        lsv_TraspasosD.Items.Clear()
        lbl_TotalVentas.Text = "Por Validar: " & lsv_Traspasos.Items.Count.ToString
        btn_Validar.Enabled = False
        Clave_SucursalO = ""
        Cnx_Sucursal = ""
        If cmb_Sucursal.SelectedValue = 0 Then Exit Sub

        Dim Dt_Temp As DataTable = cmb_Sucursal.DataSource
        Cnx_Sucursal = "Data Source=" & Cn_Encripta.fn_Decode(Dt_Temp.Rows(cmb_Sucursal.SelectedIndex)("Servidor")) & ";Initial Catalog=" & Cn_Encripta.fn_Decode(Dt_Temp.Rows(cmb_Sucursal.SelectedIndex)("Base Datos")) & ";User Id=" & Cn_Encripta.fn_Decode(Dt_Temp.Rows(cmb_Sucursal.SelectedIndex)("Usuario")) & ";Password=" & Cn_Encripta.fn_Decode(Dt_Temp.Rows(cmb_Sucursal.SelectedIndex)("Clave")) & ";"
        'Consultar Cat_Sucursales en la Sucursal Seleccionada para sacar el Id_Sucursal
        Clave_SucursalO = Dt_Temp.Rows(cmb_Sucursal.SelectedIndex)("Clave SP")

        If Not Cn_Materiales.fn_TraspasosRecibir_Consultar(lsv_Traspasos, SucursalClave, Clave_SucursalO) Then
            MsgBox("Ocurrió un error al intentar consultar los Traspasos pendientes.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
            Exit Sub
        End If

        lbl_TotalVentas.Text = "Por Validar: " & lsv_Traspasos.Items.Count.ToString
    End Sub

    Private Sub lsv_Ventas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Traspasos.SelectedIndexChanged
        SegundosDesconexion = 0

        If lsv_Traspasos.SelectedItems.Count = 0 Then
            lsv_TraspasosD.Items.Clear()
            btn_Validar.Enabled = False
            Exit Sub
        Else
            btn_Validar.Enabled = True
            If Not Cn_Materiales.fn_TraspasosRecibir_ConsultarD(lsv_TraspasosD, lsv_Traspasos.SelectedItems(0).Tag) Then
                MsgBox("Ocurrió un error al intentar consultar el detalle de Materiales.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
                Exit Sub
            End If
            lsv_TraspasosD.Columns(2).TextAlign = HorizontalAlignment.Right
        End If

    End Sub

    Private Sub btn_Validar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Validar.Click
        SegundosDesconexion = 0
        If lsv_Traspasos.SelectedItems.Count = 0 Then Exit Sub

        Dim frm As New frm_FirmaElectronica
        frm.Bloquear = True
        frm.Empleado = UsuarioId
        frm.PedirObservaciones = False
        frm.ShowDialog()
        If Not frm.Firma Then Exit Sub

        'Consultar Cat_Sucursales en la Sucursal Seleccionada para sacar el Id_Sucursal
        Dim Dt_Sucursales As DataTable
        Dim Clave_SucursalO As String = ""
        Dim Clave_SucursalD As String = ""
        Dim Id_SucursalO As Integer = 0
        Dim Id_SucursalD As Integer = 0
        Clave_SucursalO = lsv_Traspasos.SelectedItems(0).SubItems(5).Text 'Clave_Sucursal Origen
        Clave_SucursalD = lsv_Traspasos.SelectedItems(0).SubItems(6).Text 'Clave_Sucursal Destino
        Dt_Sucursales = Cn_Materiales.fn_ConsultaSucursales(Clave_SucursalO)
        If Dt_Sucursales Is Nothing Then
            MsgBox("Ocurrió un error al intentar consultar la Clave de la Sucursal Origen.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
            Exit Sub
        End If
        If Dt_Sucursales.Rows.Count = 0 Then
            MsgBox("No se pudo obtener la calve de la Sucursal Origen.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
            Exit Sub
        End If
        Id_SucursalO = Dt_Sucursales.Rows(0)("Id_Sucursal")
        Dt_Sucursales.Dispose()
        Dim MensajeRetorno As String = ""
        'Verificar que haya sufucuentes existencias en la sucursal origen
        If Not Cn_Materiales.fn_TraspasosRecibir_Validar(lsv_Traspasos.SelectedItems(0).Tag, Clave_SucursalO, Id_SucursalO, lsv_TraspasosD, MensajeRetorno) Then
            MsgBox(MensajeRetorno, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
            Exit Sub
        End If


        MsgBox("Los Materiales se han recibido correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
        Call LlenarLista()

    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0
        Me.Close()
    End Sub


End Class