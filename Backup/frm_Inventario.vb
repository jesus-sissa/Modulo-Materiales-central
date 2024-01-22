Imports System.Data.SqlClient

Public Class frm_Inventario

    Public Sub New(ByVal Departamento As Dpto)
        InitializeComponent()
        _Departamento = Departamento
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0
        Me.Close()
    End Sub

    Private Sub frm_Inv_Materiales_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        BanderA = True
        cmb_Material.Actualizar()
        BanderA = False

        Call LlenarLista()

    End Sub

    Sub LlenarLista()
        SegundosDesconexion = 0
        Btn_Baja.Enabled = False
        BTN_Modificar.Enabled = False
        lsv_Catalogo.Items.Clear()
        Cn_Materiales.fn_InventarioMateriales_LlenarLista(lsv_Catalogo, _Departamento)
        lsv_Catalogo.Columns(2).TextAlign = HorizontalAlignment.Right
        lsv_Catalogo.Columns(3).TextAlign = HorizontalAlignment.Right
        lsv_Catalogo.Columns(4).TextAlign = HorizontalAlignment.Right
        If lsv_Catalogo.Items.Count = 0 Then
            BTN_Exportar.Enabled = False
        Else
            BTN_Exportar.Enabled = True
        End If
        Lbl_Registros.Text = "Registros: " & lsv_Catalogo.Items.Count
    End Sub

    Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click
        SegundosDesconexion = 0
        tbx_Existencia.Clear()
        tbx_Clave.Clear()
        tbx_StockMinimo.Clear()
        tbx_PrecioCompra.Clear()
        cmb_Material.SelectedValue = 0
        Tab_Catalogo.SelectedTab = tab_Listado
        Tab_Nuevo.Text = "Nuevo"
    End Sub

    Public Function Validar() As Boolean
        SegundosDesconexion = 0
        If cmb_Material.SelectedValue = 0 Then
            MsgBox("Debe Seleccionar un Material.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Material.Focus()
            Return False
        End If
        If tbx_StockMinimo.Text = "" Then
            MsgBox("Debe indicar un Stock Mínimo.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_StockMinimo.Focus()
            Return False
        End If
        If tbx_Existencia.Text = "" Then
            MsgBox("Debe indicar la Existencia.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Existencia.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        If Not Validar() Then Exit Sub

        If Tab_Nuevo.Text = "Nuevo" Then
            If Cn_Materiales.fn_InventarioMateriales_ExisteMaterial(cmb_Material.SelectedValue) Then
                MsgBox("El Material Ya Existe.", MsgBoxStyle.Critical, frm_MENU.Text)
                cmb_Material.Focus()
                Exit Sub
            End If
            If Cn_Materiales.fn_InventarioMateriales_Nuevo(cmb_Material.SelectedValue, tbx_StockMinimo.Text, tbx_Existencia.Text) Then
                FuncionesGlobales.fn_Menu_Progreso(30)
                cmb_Material.SelectedValue = 0
                tbx_Existencia.Clear()
                tbx_Clave.Clear()
                tbx_StockMinimo.Clear()
                tbx_PrecioCompra.Clear()
                Tab_Nuevo.Text = "Nuevo"
                FuncionesGlobales.fn_Menu_Progreso(40)
            Else
                MsgBox("No se puede agregar el nuevo Registro.", MsgBoxStyle.Critical, frm_MENU.Text)
                FuncionesGlobales.fn_Menu_Progreso(0)
            End If
        Else
            If Cn_Materiales.fn_InventarioMateriales_Actualizar(lsv_Catalogo.SelectedItems(0).Tag, CDec(tbx_StockMinimo.Text.Trim), CDec(tbx_Existencia.Text.Trim)) Then
                FuncionesGlobales.fn_Menu_Progreso(30)
                cmb_Material.SelectedValue = 0
                tbx_Existencia.Clear()
                tbx_Clave.Clear()
                tbx_StockMinimo.Clear()
                tbx_PrecioCompra.Clear()
                Tab_Nuevo.Text = "Nuevo"
                Tab_Catalogo.SelectedTab = tab_Listado
                FuncionesGlobales.fn_Menu_Progreso(40)
            Else
                MsgBox("No se puede editar el elemento.", MsgBoxStyle.Critical, frm_MENU.Text)
                FuncionesGlobales.fn_Menu_Progreso(0)
            End If
        End If
        FuncionesGlobales.fn_Menu_Progreso(50)
        Call LlenarLista()
        FuncionesGlobales.fn_Menu_Progreso(100)
        FuncionesGlobales.fn_Menu_Progreso(0)
    End Sub

    Private Sub BTN_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Buscar.Click
        Dim Fila_Inicio As Integer = 0
        If lsv_Catalogo.SelectedItems.Count > 0 Then
            Fila_Inicio = lsv_Catalogo.SelectedItems(0).Index + 1
        End If
        FuncionesGlobales.fn_Buscar_enListView(lsv_Catalogo, tbx_Buscar.Text, 2, Fila_Inicio)
    End Sub

    Private Sub BTN_Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Modificar.Click, lsv_Catalogo.DoubleClick
        SegundosDesconexion = 0
        Dim Dr As DataRow = Cn_Materiales.fn_InventarioMateriales_Read(lsv_Catalogo.SelectedItems(0).Tag)
        If Not Dr Is Nothing Then
            tbx_Clave.Text = Dr("Clave_Material")
            tbx_Clave.Tag = Dr("Clave_Material")
            tbx_StockMinimo.Text = Dr("Stock_Minimo")
            tbx_Existencia.Text = Dr("Existencia")
        End If
        Tab_Nuevo.Text = "Modificar"
        Tab_Catalogo.SelectedTab = Tab_Nuevo
    End Sub

    Private Sub Btn_Baja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Baja.Click
        SegundosDesconexion = 0
        If lsv_Catalogo.SelectedItems(0).SubItems(4).Text = "ACTIVO" Then
            Cn_Materiales.fn_InventarioMateriales_Baja(lsv_Catalogo.SelectedItems(0).Tag)
        Else
            Cn_Materiales.fn_InventarioMateriales_Alta(lsv_Catalogo.SelectedItems(0).Tag)
        End If
        Call LlenarLista()

    End Sub

    Private Sub BTN_Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Exportar.Click
        SegundosDesconexion = 0
        FuncionesGlobales.fn_Exportar_Excel(lsv_Catalogo, 2, Me.Text, 0, 0, frm_MENU.prg_Barra)
        Cn_Login.fn_Log_Create("EXPORTAR REPORTE INVENTARIO DE MATERIALES")
    End Sub

    Private Sub lsv_Catalogo_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lsv_Catalogo.SelectedIndexChanged
        SegundosDesconexion = 0
        Btn_Baja.Enabled = lsv_Catalogo.SelectedItems.Count > 0
        BTN_Modificar.Enabled = lsv_Catalogo.SelectedItems.Count > 0
    End Sub

    Private Sub cmb_ClaveMat_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Material.SelectedValueChanged
        tbx_PrecioCompra.Text = ""
        If cmb_Material.SelectedValue Is Nothing Then Exit Sub
        If cmb_Material.SelectedValue = 0 Then Exit Sub
        Dim Dr As DataRow = Cn_Materiales.fn_InventarioMateriales_ReadMaterial(cmb_Material.SelectedValue)
        If Dr IsNot Nothing Then
            tbx_PrecioCompra.Text = Dr("Precio_Compra")
        End If
    End Sub
End Class