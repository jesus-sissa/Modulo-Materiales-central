Imports System.Data.SqlClient
Imports Modulo_MaterialesCentral.FuncionesGlobales

Public Class frm_Proveedores

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0

        'Aqui se cierra la ventana
        Me.Close()

    End Sub

    Private Sub frm_Proveedores_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lsv_Contactos.Columns.Add("Nombre")
        lsv_Contactos.Columns.Add("Puesto")
        lsv_Contactos.Columns.Add("TelFijo")
        lsv_Contactos.Columns.Add("Telovil")
        lsv_Contactos.Columns.Add("Mail")
        lsv_Contactos.Columns.Add("Status")

        lsv_ContactosAgregar.Columns.Add("Nombre")
        lsv_ContactosAgregar.Columns.Add("Puesto")
        lsv_Contactos.Columns.Add("TelFijo")
        lsv_Contactos.Columns.Add("Telovil")
        lsv_Contactos.Columns.Add("Mail")
        lsv_ContactosAgregar.Columns.Add("Status", 0)
        'Aqui se llena la lista

        cmb_Status.AgregarItem("A", "ACTIVO")
        cmb_Status.AgregarItem("B", "BAJA")

        'Aqui se llenan los combos
        Cn_Materiales.fn_Proveedores_LlenarCombo(cmb_CiudadC)
        Cn_Materiales.fn_Proveedores_LlenarCombo(cmb_CiudadF)

    End Sub

    Sub LlenarLista()
        If cmb_Status.SelectedIndex = 0 And Not chk_Todos.Checked Then Exit Sub
        lsv_Catalogo.Items.Clear()
        Lbl_Registros.Text = "Registros: 0"
        lsv_Contactos.Items.Clear()
        lsv_ContactosAgregar.Items.Clear()
        Cn_Materiales.fn_Proveedores_LlenarLista(lsv_Catalogo, IIf(chk_Todos.Checked, "T", cmb_Status.SelectedValue))
        Lbl_Registros.Text = "Registros: " & lsv_Catalogo.Items.Count
        'Aqui se ocultan y se muestran los botones de reporte
        If lsv_Catalogo.Items.Count = 0 Then
            BTN_Exportar.Enabled = False
        Else
            BTN_Exportar.Enabled = True
        End If
    End Sub

    Sub LimpiarControles()
        'Aqui se limpian los textbox
        tbx_Clave.Clear()
        tbx_NombreF.Clear()
        tbx_DireccionF.Clear()
        tbx_NumeroEF.Clear()
        tbx_NumeroIF.Clear()
        tbx_ColoniaF.Clear()
        cmb_CiudadF.SelectedValue = 0
        tbx_RFC.Clear()
        tbx_NombreC.Clear()
        tbx_DireccionC.Clear()
        tbx_NumeroEC.Clear()
        tbx_NumeroIC.Clear()
        tbx_ColoniaC.Clear()
        cmb_CiudadC.SelectedValue = 0
        tbx_Contacto.Clear()
        tbx_Telefono.Clear()
        tbx_Fax.Clear()
        tbx_CorreoE.Clear()
        tbx_IVA.Clear()
        tbx_Retencion.Clear()
        tbx_Observaciones.Clear()
        tbx_Dias.Clear()
        tbx_Nombre.Clear()
        tbx_Puesto.Clear()
        tbx_TelMovil.Clear()
        tbx_TelFijo.Clear()
        tbx_Mail.Clear()
    End Sub

    Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0

        Call LimpiarControles()

        'Aqui se cambia de pestaña
        Tab_Catalogo.SelectedTab = tab_Listado
        'Aqui se ajusta el titulo de la pestaña
        Tab_Nuevo.Text = "Nuevo"
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0

        If tbx_Clave.Text = "" Then
            MsgBox("Indique una Clave.", 16 + 0, frm_MENU.Text)
            tbx_Clave.Focus()
            Exit Sub
        End If
        If tbx_NombreF.Text = "" Then
            MsgBox("Indique el Nombre Fiscal.", 16 + 0, frm_MENU.Text)
            tbx_NombreF.Focus()
            Exit Sub
        End If
        If tbx_DireccionF.Text = "" Then
            MsgBox("Indique la Calle Fiscal.", 16 + 0, frm_MENU.Text)
            tbx_DireccionF.Focus()
            Exit Sub
        End If
        If cmb_CiudadF.SelectedIndex = 0 Then
            MsgBox("Seleccione la Ciudad Fiscal.", 16 + 0, frm_MENU.Text)
            cmb_CiudadF.Focus()
            Exit Sub
        End If
        If tbx_RFC.Text = "" Then
            MsgBox("Indique el RFC.", 16 + 0, frm_MENU.Text)
            tbx_RFC.Focus()
            Exit Sub
        End If
        If tbx_NombreC.Text = "" Then
            MsgBox("Indique el Nombre Comercial.", 16 + 0, frm_MENU.Text)
            tbx_NombreC.Focus()
            Exit Sub
        End If
        If tbx_DireccionC.Text = "" Then
            MsgBox("Indique la Calle Comercial.", 16 + 0, frm_MENU.Text)
            tbx_DireccionC.Focus()
            Exit Sub
        End If
        If cmb_CiudadC.SelectedIndex = 0 Then
            MsgBox("Seleccione la Ciudad Comercial.", 16 + 0, frm_MENU.Text)
            cmb_CiudadC.Focus()
            Exit Sub
        End If
        If tbx_IVA.Text = "" Then
            MsgBox("Indique el porcentaje del IVA.", 16 + 0, frm_MENU.Text)
            tbx_IVA.Focus()
            Exit Sub
        End If
        If tbx_Retencion.Text = "" Then
            MsgBox("Indique el porcentaje de Retención.", 16 + 0, frm_MENU.Text)
            tbx_Retencion.Focus()
            Exit Sub
        End If
        If tbx_Dias.Text = "" Then
            MsgBox("Indique los Días de Crédito del Proveedor.", 16 + 0, frm_MENU.Text)
            tbx_Dias.Focus()
            Exit Sub
        End If
        If tbx_NumeroEF.Text = "" Then tbx_NumeroEF.Text = 0
        If tbx_NumeroEC.Text = "" Then tbx_NumeroEC.Text = 0


        'En caso de que todo sea valido
        If Tab_Nuevo.Text = "Nuevo" Then

            'Si se esta Insertando
            If Cn_Materiales.fn_Proveedores_Nuevo(tbx_Clave.Text, tbx_NombreF.Text, tbx_DireccionF.Text, tbx_NumeroEF.Text, tbx_NumeroIF.Text, tbx_ColoniaF.Text, cmb_CiudadF.SelectedValue, _
                tbx_RFC.Text, tbx_NombreC.Text, tbx_DireccionC.Text, tbx_NumeroEC.Text, tbx_NumeroIC.Text, tbx_ColoniaC.Text, cmb_CiudadC.SelectedValue, tbx_Contacto.Text, tbx_Telefono.Text, tbx_Fax.Text, _
                tbx_CorreoE.Text, tbx_IVA.Text, tbx_Retencion.Text, tbx_Observaciones.Text, tbx_Dias.Text, lsv_ContactosAgregar) Then

                'En caso de que se haya hecho la transaccion
                Cn_Materiales.fn_Menu_Progreso(30)

                'Aqui se limpian los textbox
                Call LimpiarControles()

                'Aqui se Ajusta el titulo de la pestaña
                Tab_Nuevo.Text = "Nuevo"
                Cn_Materiales.fn_Menu_Progreso(40)
                tbx_Clave.Focus()

            Else
                'En caso de que no se haya hecho la transaccion
                MsgBox("No se puede agregar el nuevo elemento", MsgBoxStyle.Critical, frm_MENU.Text)
                Cn_Materiales.fn_Menu_Progreso(0)

            End If

        Else

            'Si se esta actualizando
            If Cn_Materiales.fn_Proveedores_Actualizar(lsv_Catalogo.SelectedItems(0).Tag, tbx_Clave.Text, tbx_NombreF.Text, tbx_DireccionF.Text, tbx_NumeroEF.Text, tbx_NumeroIF.Text, tbx_ColoniaF.Text, cmb_CiudadF.SelectedValue, _
                tbx_RFC.Text, tbx_NombreC.Text, tbx_DireccionC.Text, tbx_NumeroEC.Text, tbx_NumeroIC.Text, tbx_ColoniaC.Text, cmb_CiudadC.SelectedValue, tbx_Contacto.Text, tbx_Telefono.Text, tbx_Fax.Text, _
                tbx_CorreoE.Text, tbx_IVA.Text, tbx_Retencion.Text, tbx_Observaciones.Text, tbx_Dias.Text) Then

                'En caso de que se haya hecho la transaccion
                Cn_Materiales.fn_Menu_Progreso(30)

                'Aqui se limpian los textbox
                Call LimpiarControles()

                Tab_Nuevo.Text = "Nuevo"

                'Aqui se cambia la pestaña seleccionada
                Tab_Catalogo.SelectedTab = tab_Listado
                Cn_Materiales.fn_Menu_Progreso(40)
            Else
                'En caso de que no se haya hecho la transaccion
                MsgBox("No se puede editar el elemento", MsgBoxStyle.Critical, frm_MENU.Text)
                Cn_Materiales.fn_Menu_Progreso(0)
                Exit Sub
            End If

        End If

        'Aqui se limpia el listview
        lsv_Catalogo.Items.Clear()
        Cn_Materiales.fn_Menu_Progreso(50)

        Call LlenarLista()
        Cn_Materiales.fn_Menu_Progreso(100)

        'Aqui se ocultan los botones
        Btn_Baja.Enabled = False
        BTN_Modificar.Enabled = False

        'Aqui se limpia el contador de progreso
        Cn_Materiales.fn_Menu_Progreso(0)


    End Sub

    Private Sub lsv_Catalogo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lsv_Catalogo.Click
        'Aqui se desactivan los botones de edicion
        Btn_Baja.Enabled = True
        BTN_Modificar.Enabled = True
    End Sub

    Private Sub BTN_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Buscar.Click
        'Aqui se selecciona el objeto que coincida con el criterio de busqueda
        Dim Fila_Inicio As Integer = 0
        If lsv_Catalogo.SelectedItems.Count > 0 Then
            Fila_Inicio = lsv_Catalogo.SelectedItems(0).Index + 1
        End If
        FuncionesGlobales.fn_Buscar_enListView(lsv_Catalogo, tbx_Buscar.Text, 0, Fila_Inicio)
        'Aqui se ocultan los botones
        Btn_Baja.Enabled = True
        BTN_Modificar.Enabled = True
    End Sub

    Private Sub BTN_Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Modificar.Click, lsv_Catalogo.DoubleClick
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0

        'Aqui se establece el texto del objeto seleccionado
        Dim Dr As DataRow = Cn_Materiales.fn_Proveedores_ObtenerValores(lsv_Catalogo.SelectedItems(0).Tag)
        tbx_Clave.Text = Dr("Clave")
        tbx_NombreF.Text = Dr("Nombre_Fiscal")
        tbx_DireccionF.Text = Dr("Direccion_Fiscal")
        cmb_CiudadF.SelectedValue = Dr("Ciudad_Fiscal")
        tbx_RFC.Text = Dr("RFC")
        tbx_NombreC.Text = Dr("Nombre_Comercial")
        tbx_DireccionC.Text = Dr("Direccion_Comercial")
        cmb_CiudadC.SelectedValue = Dr("Ciudad_Comercial")
        tbx_Contacto.Text = Dr("Contacto")
        tbx_Telefono.Text = Dr("Telefono")
        tbx_Fax.Text = Dr("FAX")
        tbx_CorreoE.Text = Dr("Mail")
        tbx_IVA.Text = Dr("IVA")
        tbx_Retencion.Text = Dr("Retencion")
        tbx_Observaciones.Text = Dr("Observaciones")

        tbx_NumeroEF.Text = Dr("Numero_Fiscal")
        tbx_NumeroIF.Text = Dr("NumeroInt_Fiscal")
        tbx_ColoniaF.Text = Dr("Colonia_Fiscal")
        tbx_NumeroEC.Text = Dr("Numero_Comercial")
        tbx_NumeroIC.Text = Dr("NumeroInt_Comercial")
        tbx_ColoniaC.Text = Dr("Colonia_Comercial")
        tbx_Dias.Text = Dr("Dias_Credito")


        'Aqui se cambia el titulo de la pestaña
        Tab_Nuevo.Text = "Modificar"

        'Aqui se cambia la pestaña
        Tab_Catalogo.SelectedTab = Tab_Nuevo


    End Sub

    Private Sub Btn_Baja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Baja.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0

        'Aqui se filtra cuando el objeto esta activo o inactivo
        If lsv_Catalogo.SelectedItems(0).SubItems(7).Text = "ACTIVO" Then
            If Cn_Materiales.fn_Proveedores_ValidarDependencias(lsv_Catalogo.SelectedItems(0).Tag) Then
                Cn_Materiales.fn_Proveedores_Baja(lsv_Catalogo.SelectedItems(0).Tag)
            Else
                MsgBox("No se puede desactivar el elemento porque tiene dependencias registradas", MsgBoxStyle.Critical, frm_MENU.Text)
            End If
        Else
            Cn_Materiales.fn_Proveedores_Alta(lsv_Catalogo.SelectedItems(0).Tag)
        End If
        'Aqui se actualiza la lista
        Call LlenarLista()

        'Aqui se ocultan los botones
        Btn_Baja.Enabled = False
        BTN_Modificar.Enabled = False
    End Sub

    Private Sub BTN_Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Exportar.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        Dim Dt_Detalle As New DataTable
        Dim UltFila As Integer = 4

        'FuncionesGlobales.fn_Exportar_Excel(lsv_Catalogo, 2, Me.Text, 0, 0, frm_MENU.prg_Barra)
        Cn_Login.fn_Log_Create("EXPORTAR REPORTE CATALOGO DE PROVEEDORES")

        frm_MENU.prg_Barra.Maximum = lsv_Catalogo.Items.Count + 1

        'Dim  As New Excel.Application
        Dim App = CreateObject("Excel.Application")
        With App

            'Creando el libro
            .Workbooks.Add()
            .SheetsInNewWorkbook = 1


            .Range("B1").Value = Me.Text
            .Range("A1:K1").Merge()
            .Range("B1:J1").Font.Bold = True

            .Range("A3").Value = "Clave"
            .Range("B3").Value = "RazonSocial"
            .Range("C3").Value = "RFC"
            .Range("D3").Value = "Nombre"
            .Range("E3").Value = "Direccion"
            .Range("F3").Value = "Num"
            .Range("G3").Value = "Colonia"
            .Range("H3").Value = "Ciudad"
            .Range("I3").Value = "Contacto"
            .Range("J3").Value = "Telefono"
            .Range("K3").Value = "Status"

            Dt_Detalle = Cn_Materiales.fn_Proveedores_LlenarRpt()

            For Each Lvi_Catalogo As ListViewItem In lsv_Catalogo.Items

                .Range("A" & UltFila).Value = Lvi_Catalogo.SubItems(0).Text
                .Range("B" & UltFila).Value = Lvi_Catalogo.SubItems(1).Text
                .Range("C" & UltFila).Value = Lvi_Catalogo.SubItems(2).Text
                .Range("D" & UltFila).Value = Lvi_Catalogo.SubItems(3).Text
                .Range("E" & UltFila).Value = Lvi_Catalogo.SubItems(4).Text
                .Range("F" & UltFila).Value = Lvi_Catalogo.SubItems(5).Text
                .Range("G" & UltFila).Value = Lvi_Catalogo.SubItems(6).Text
                .Range("H" & UltFila).Value = Lvi_Catalogo.SubItems(7).Text
                .Range("I" & UltFila).Value = Lvi_Catalogo.SubItems(8).Text
                .Range("J" & UltFila).Value = Lvi_Catalogo.SubItems(9).Text
                .Range("K" & UltFila).Value = Lvi_Catalogo.SubItems(10).Text

                If Dt_Detalle.Rows.Count <> 0 Then
                    For Each Dr_Detalle As DataRow In Dt_Detalle.Rows
                        If Dr_Detalle("Id_Proveedor") = Lvi_Catalogo.Tag Then
                            UltFila += 1
                            .Range("B" & UltFila).Value = Dr_Detalle("Nombre")
                            .Range("C" & UltFila).Value = Dr_Detalle("Puesto")
                            .Range("D" & UltFila).Value = Dr_Detalle("TelFijo")
                            .Range("E" & UltFila).Value = Dr_Detalle("TelMovil")
                            .Range("F" & UltFila).Value = Dr_Detalle("Mail")
                            .Range("H" & UltFila).Value = Dr_Detalle("Status")
                            .Range("F" & UltFila & ":G" & UltFila).Merge()
                            .Range("B" & UltFila & ":F" & UltFila).Font.Italic = True
                            .Range("B" & UltFila & ":F" & UltFila).Font.Size = 10
                        End If
                    Next
                End If
                UltFila += 1
                frm_MENU.prg_Barra.Value += 1
            Next
            .Range("A3:K3").Font.Bold = True
            .Range("A3:K" & UltFila).EntireColumn.Autofit()
            .Range("A3:K" & UltFila).Borders.Value = True

            'Mostrando el libr
            .Visible = True

        End With
        frm_MENU.prg_Barra.Value = frm_MENU.prg_Barra.Maximum
        frm_MENU.prg_Barra.Value = frm_MENU.prg_Barra.Minimum
    End Sub

    Private Sub lsv_Catalogo_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Catalogo.MouseHover
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
    End Sub

    Private Sub btn_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Agregar.Click
        If tbx_Nombre.TextLength < 5 Then
            MsgBox("El Nombre del Contacto debe contener minimo 5 Letras.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Nombre.Focus()
            Exit Sub
        ElseIf tbx_Nombre.Text = "" Then
            MsgBox("Capture el Nombre del Contacto.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Nombre.Focus()
            Exit Sub
        End If
        If tbx_Puesto.TextLength < 5 Then
            MsgBox("El Puesto debe contener minimo 5 Letras", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Contacto.Focus()
            Exit Sub
        ElseIf tbx_Puesto.Text = "" Then
            MsgBox("Capture el Puesto del Contacto.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Puesto.Focus()
            Exit Sub

        End If
        If Tab_Nuevo.Text.ToUpper = "NUEVO" Then
            Dim Elemento As ListViewItem = lsv_ContactosAgregar.Items.Add(tbx_Nombre.Text)
            Elemento.Tag = 0
            Elemento.SubItems.Add(tbx_Puesto.Text)
            Elemento.SubItems.Add(tbx_TelFijo.Text)
            Elemento.SubItems.Add(tbx_TelMovil.Text)
            Elemento.SubItems.Add(tbx_Mail.Text)
            Elemento.SubItems.Add("NUEVO")
        Else
            If Cn_Materiales.fn_ProveedoresContactos_Nuevo(lsv_Catalogo.SelectedItems(0).Tag, tbx_Nombre.Text, tbx_Puesto.Text, tbx_TelFijo.Text, tbx_TelMovil.Text, tbx_Mail.Text) Then
                Call Cn_Materiales.fn_ProveedoresContactos_LlenarLista(lsv_Catalogo.SelectedItems(0).Tag, lsv_Contactos)
                Call Cn_Materiales.fn_ProveedoresContactos_LlenarLista(lsv_Catalogo.SelectedItems(0).Tag, lsv_ContactosAgregar)
            Else
                MsgBox("Ocurrió un Error al intentar guardar el Contacto.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
        End If
        btn_Eliminar.Enabled = False
        tbx_Nombre.Clear()
        tbx_Puesto.Clear()
        tbx_Nombre.Focus()
        tbx_TelFijo.Clear()
        tbx_TelMovil.Clear()
        tbx_Mail.Clear()
        tbx_Nombre.Focus()
    End Sub

    Private Sub lsv_Catalogo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Catalogo.SelectedIndexChanged
        'CARGAR LOS CONTACTOS
        lsv_Contactos.Items.Clear()
        lsv_ContactosAgregar.Items.Clear()
        'BTN_Modificar.Enabled = False
        If lsv_Catalogo.SelectedItems.Count = 0 Then
            Btn_Baja.Enabled = False
            Exit Sub
        Else
            BTN_Modificar.Enabled = True
            Call Cn_Materiales.fn_ProveedoresContactos_LlenarLista(lsv_Catalogo.SelectedItems(0).Tag, lsv_Contactos)
            Call Cn_Materiales.fn_ProveedoresContactos_LlenarLista(lsv_Catalogo.SelectedItems(0).Tag, lsv_ContactosAgregar)
        End If

      
    End Sub

    Private Sub lsv_ContactosAgregar_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_ContactosAgregar.SelectedIndexChanged
        btn_Eliminar.Enabled = False
        If lsv_ContactosAgregar.SelectedItems.Count > 0 Then
            If lsv_ContactosAgregar.SelectedItems(0).SubItems(5).Text = "ACTIVO" Or lsv_ContactosAgregar.SelectedItems(0).SubItems(5).Text = "NUEVO" Then
                btn_Eliminar.Enabled = True
            End If

        End If
    End Sub

    Private Sub btn_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Eliminar.Click
        If lsv_ContactosAgregar.SelectedItems(0).Tag = 0 Then
            lsv_ContactosAgregar.Items.Remove(lsv_ContactosAgregar.SelectedItems(0))
            Exit Sub
        End If
        If lsv_ContactosAgregar.SelectedItems(0).SubItems(5).Text = "ACTIVO" Then
            If lsv_ContactosAgregar.SelectedItems(0).Tag = 0 Then
                lsv_ContactosAgregar.Items.Remove(lsv_ContactosAgregar.SelectedItems(0))
                Exit Sub
            End If
            If MsgBox("Confirma que desea dar de baja el Contacto " & lsv_ContactosAgregar.SelectedItems(0).Text & "?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, frm_MENU.Text) = MsgBoxResult.Yes Then
                If Not Cn_Materiales.fn_ProveedoresContactos_Baja(lsv_ContactosAgregar.SelectedItems(0).Tag) Then
                    MsgBox("Ocurrió un error al intentar dar de Baja el Contacto.", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                End If
                btn_Eliminar.Enabled = False
                Call Cn_Materiales.fn_ProveedoresContactos_LlenarLista(lsv_Catalogo.SelectedItems(0).Tag, lsv_Contactos)
                Call Cn_Materiales.fn_ProveedoresContactos_LlenarLista(lsv_Catalogo.SelectedItems(0).Tag, lsv_ContactosAgregar)
            End If
        End If
    End Sub

    Private Sub Tab_Catalogo_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Tab_Catalogo.SelectedIndexChanged
        If Tab_Catalogo.SelectedTab Is Tab_Nuevo Then
            If Tab_Nuevo.Text.ToUpper = "NUEVO" Then
                lsv_ContactosAgregar.Items.Clear()
                btn_Eliminar.Enabled = False
                tbx_Clave.Focus()
            End If
        End If
    End Sub

    Private Sub btn_Mostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Mostrar.Click
        Call LlenarLista()
    End Sub

    Private Sub chk_Todos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Todos.CheckedChanged
        lsv_Catalogo.Items.Clear()
        Lbl_Registros.Text = "Registros: 0"
        If chk_Todos.Checked Then
            cmb_Status.Enabled = False
            cmb_Status.SelectedValue = 0
        Else
            cmb_Status.Enabled = True
        End If
    End Sub
End Class