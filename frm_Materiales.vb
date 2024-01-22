Imports System.Data.SqlClient

Public Class frm_Materiales

    Private Sub frm_UnidadesMarcas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call LlenarLista()

        cmb_ControlFolios.AgregarItem("S", "SI")
        cmb_ControlFolios.AgregarItem("N", "NO")

    End Sub

    Sub LlenarLista()
        lsv_Catalogo.Items.Clear()
        Btn_Baja.Enabled = False
        BTN_Exportar.Enabled = False
        BTN_Modificar.Enabled = False

        Cn_Materiales.fn_Materiales_LlenarLista(lsv_Catalogo, lsv_Catalogo.Lvs)
        If lsv_Catalogo.Columns.Count > 0 Then
            lsv_Catalogo.Columns(2).TextAlign = HorizontalAlignment.Right
            lsv_Catalogo.Columns(3).TextAlign = HorizontalAlignment.Right
        End If
        Lbl_Registros.Text = "Registros: " & lsv_Catalogo.Items.Count
    End Sub

    Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click
        tbx_Descripcion.Clear()
        tbx_Clave.Clear()
        tbx_PrecioCompra.Clear()
        Tab_Catalogo.SelectedTab = tab_Listado
        Tab_Nuevo.Text = "Nuevo"
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        If tbx_Clave.Text = "" Then
            MsgBox("Debe indicar una Clave.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Clave.Focus()
            Exit Sub
        End If
        If tbx_Descripcion.Text = "" Then
            MsgBox("Debe indicar una Descripcion.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Descripcion.Focus()
            Exit Sub
        End If
        If tbx_Cantidad_Unidad.Text = "" Then
            MsgBox("Debe indicar una Cantidad por Unidad.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Cantidad_Unidad.Focus()
            Exit Sub
        End If
        If tbx_PrecioCompra.Text = "" Then
            MsgBox("Debe indicar un Precio de Compra.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_PrecioCompra.Focus()
            Exit Sub
        End If

        If cmb_ControlFolios.SelectedValue = "" Then
            MsgBox("Seleccione si es control de folios o no.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_ControlFolios.Focus()
            Exit Sub

        End If

        If Not Cn_Materiales.fn_Materiales_ValidarClave(tbx_Clave.Text, tbx_Clave.Tag) Then
            MsgBox("La Clave ya existe.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        If Tab_Nuevo.Text = "Nuevo" Then
            'Si se esta Insertando
            If Cn_Materiales.fn_Materiales_Nuevo(tbx_Clave.Text.Trim, tbx_Descripcion.Text.Trim, tbx_Cantidad_Unidad.Text.Trim, tbx_PrecioCompra.Text.Trim, cmb_ControlFolios.SelectedValue) Then
                tbx_Descripcion.Clear()
                tbx_Clave.Clear()
                tbx_Cantidad_Unidad.Clear()
                tbx_PrecioCompra.Clear()
                Tab_Nuevo.Text = "Nuevo"
            Else
                MsgBox("No se pudo guardar el Nuevo Registro.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
        Else
            If Cn_Materiales.fn_Materiales_Actualizar(lsv_Catalogo.SelectedItems(0).Tag, tbx_Clave.Text.Trim, tbx_Descripcion.Text.Trim, tbx_Cantidad_Unidad.Text.Trim, tbx_PrecioCompra.Text.Trim, cmb_ControlFolios.SelectedValue) Then
                tbx_Descripcion.Clear()
                tbx_Clave.Clear()
                tbx_Cantidad_Unidad.Clear()
                tbx_PrecioCompra.Clear()
                Tab_Nuevo.Text = "Nuevo"
                Tab_Catalogo.SelectedTab = tab_Listado
            Else
                MsgBox("No se pudo Actualizar el Registro.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
        End If
        Call LlenarLista()
    End Sub

    Private Sub lsv_Catalogo_AlActualizar() Handles lsv_Catalogo.AlActualizar
        If lsv_Catalogo.Items.Count = 0 Then
            BTN_Exportar.Enabled = False
        Else
            BTN_Exportar.Enabled = True
        End If
    End Sub

    Private Sub BTN_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Buscar.Click
        Dim Fila_Inicio As Integer = 0
        If lsv_Catalogo.SelectedItems.Count > 0 Then
            Fila_Inicio = lsv_Catalogo.SelectedItems(0).Index + 1
        End If
        FuncionesGlobales.fn_Buscar_enListView(lsv_Catalogo, tbx_Buscar.Text, 0, Fila_Inicio)
    End Sub

    Private Sub BTN_Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Modificar.Click, lsv_Catalogo.DoubleClick
        SegundosDesconexion = 0
        Dim Dr As DataRow = Cn_Materiales.fn_Materiales_Read(lsv_Catalogo.SelectedItems(0).Tag)
        If Dr IsNot Nothing Then
            tbx_Clave.Tag = Dr("Clave_Material")
            tbx_Clave.Text = Dr("Clave_Material")
            tbx_Descripcion.Text = Dr("Descripcion")
            tbx_Cantidad_Unidad.Text = Dr("Cantidad_unidad")
            tbx_PrecioCompra.Text = Dr("Precio_Compra")
            cmb_ControlFolios.SelectedValue = Dr("Control_Folios")
        End If
        Tab_Nuevo.Text = "Modificar"
        Tab_Catalogo.SelectedTab = Tab_Nuevo
    End Sub

    Private Sub Btn_Baja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Baja.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        If lsv_Catalogo.SelectedItems(0).SubItems(5).Text = "ACTIVO" Then
            Cn_Materiales.fn_Materiales_Baja(lsv_Catalogo.SelectedItems(0).Tag)
        Else
            Cn_Materiales.fn_Materiales_Alta(lsv_Catalogo.SelectedItems(0).Tag)
        End If
        Call LlenarLista()

    End Sub

    Private Sub BTN_Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Exportar.Click
        SegundosDesconexion = 0
        FuncionesGlobales.fn_Exportar_Excel(lsv_Catalogo, 2, Me.Text, 0, 0, frm_MENU.prg_Barra)
        Cn_Login.fn_Log_Create("EXPORTAR REPORTE CATALOGO DE MATERIALES ")
    End Sub

    Private Sub lsv_Catalogo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Catalogo.SelectedIndexChanged
        SegundosDesconexion = 0
        Btn_Baja.Enabled = lsv_Catalogo.SelectedItems.Count > 0
        BTN_Modificar.Enabled = lsv_Catalogo.SelectedItems.Count > 0
    End Sub

    Private Sub Tab_Catalogo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tab_Catalogo.SelectedIndexChanged
        tbx_Clave.Focus()
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0
        Me.Close()
    End Sub
End Class