<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Proveedores
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Proveedores))
        Dim ListViewColumnSorter1 As Modulo_MaterialesCentral.ListViewColumnSorter = New Modulo_MaterialesCentral.ListViewColumnSorter
        Dim ListViewColumnSorter2 As Modulo_MaterialesCentral.ListViewColumnSorter = New Modulo_MaterialesCentral.ListViewColumnSorter
        Dim ListViewColumnSorter3 As Modulo_MaterialesCentral.ListViewColumnSorter = New Modulo_MaterialesCentral.ListViewColumnSorter
        Me.Tab_Catalogo = New System.Windows.Forms.TabControl
        Me.tab_Listado = New System.Windows.Forms.TabPage
        Me.btn_Mostrar = New System.Windows.Forms.Button
        Me.chk_Todos = New System.Windows.Forms.CheckBox
        Me.Lbl_Status = New System.Windows.Forms.Label
        Me.Lbl_Registros = New System.Windows.Forms.Label
        Me.Lbl_ContactosProv = New System.Windows.Forms.Label
        Me.BTN_Modificar = New System.Windows.Forms.Button
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.BTN_Exportar = New System.Windows.Forms.Button
        Me.Btn_Baja = New System.Windows.Forms.Button
        Me.BTN_Buscar = New System.Windows.Forms.Button
        Me.Lbl_Buscar = New System.Windows.Forms.Label
        Me.Tab_Nuevo = New System.Windows.Forms.TabPage
        Me.gbx_Contactos = New System.Windows.Forms.GroupBox
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.btn_Agregar = New System.Windows.Forms.Button
        Me.Lbl_TelMov = New System.Windows.Forms.Label
        Me.Lbl_Mail = New System.Windows.Forms.Label
        Me.Lbl_TelFijo = New System.Windows.Forms.Label
        Me.Lbl_Puesto = New System.Windows.Forms.Label
        Me.btn_Eliminar = New System.Windows.Forms.Button
        Me.lbl_Nombre = New System.Windows.Forms.Label
        Me.Lbl_DiasCredito = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Lbl_Col = New System.Windows.Forms.Label
        Me.Lbl_NumInt = New System.Windows.Forms.Label
        Me.Lbl_NumExt = New System.Windows.Forms.Label
        Me.Lbl_Colonia = New System.Windows.Forms.Label
        Me.Lbl_NInt = New System.Windows.Forms.Label
        Me.Lbl_NExterior = New System.Windows.Forms.Label
        Me.lbl_Observaciones = New System.Windows.Forms.Label
        Me.Lbl_Retencion = New System.Windows.Forms.Label
        Me.Lbl_IVA = New System.Windows.Forms.Label
        Me.lbl_CorreoE = New System.Windows.Forms.Label
        Me.lbl_Fax = New System.Windows.Forms.Label
        Me.lbl_Telefono = New System.Windows.Forms.Label
        Me.lbl_Contacto = New System.Windows.Forms.Label
        Me.lbl_CiudadC = New System.Windows.Forms.Label
        Me.lbl_DireccionC = New System.Windows.Forms.Label
        Me.lbl_NombreC = New System.Windows.Forms.Label
        Me.lbl_RFC = New System.Windows.Forms.Label
        Me.lbl_CiudadF = New System.Windows.Forms.Label
        Me.lbl_DireccionF = New System.Windows.Forms.Label
        Me.btn_Cancelar = New System.Windows.Forms.Button
        Me.btn_Guardar = New System.Windows.Forms.Button
        Me.lbl_NombreF = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lbl_Clave = New System.Windows.Forms.Label
        Me.cmb_Status = New Modulo_MaterialesCentral.cp_cmb_Manual
        Me.lsv_Contactos = New Modulo_MaterialesCentral.cp_Listview
        Me.tbx_Buscar = New Modulo_MaterialesCentral.cp_Textbox
        Me.lsv_Catalogo = New Modulo_MaterialesCentral.cp_Listview
        Me.tbx_TelMovil = New Modulo_MaterialesCentral.cp_Textbox
        Me.tbx_Mail = New Modulo_MaterialesCentral.cp_Textbox
        Me.tbx_TelFijo = New Modulo_MaterialesCentral.cp_Textbox
        Me.tbx_Puesto = New Modulo_MaterialesCentral.cp_Textbox
        Me.tbx_Nombre = New Modulo_MaterialesCentral.cp_Textbox
        Me.lsv_ContactosAgregar = New Modulo_MaterialesCentral.cp_Listview
        Me.tbx_Dias = New Modulo_MaterialesCentral.cp_Textbox
        Me.tbx_Observaciones = New Modulo_MaterialesCentral.cp_Textbox
        Me.tbx_ColoniaC = New Modulo_MaterialesCentral.cp_Textbox
        Me.cmb_CiudadC = New Modulo_MaterialesCentral.cp_cmb_SimpleFiltradoParam
        Me.tbx_Contacto = New Modulo_MaterialesCentral.cp_Textbox
        Me.tbx_Telefono = New Modulo_MaterialesCentral.cp_Textbox
        Me.tbx_Fax = New Modulo_MaterialesCentral.cp_Textbox
        Me.tbx_CorreoE = New Modulo_MaterialesCentral.cp_Textbox
        Me.tbx_IVA = New Modulo_MaterialesCentral.cp_Textbox
        Me.tbx_Retencion = New Modulo_MaterialesCentral.cp_Textbox
        Me.tbx_NumeroIC = New Modulo_MaterialesCentral.cp_Textbox
        Me.tbx_NumeroEC = New Modulo_MaterialesCentral.cp_Textbox
        Me.tbx_ColoniaF = New Modulo_MaterialesCentral.cp_Textbox
        Me.cmb_CiudadF = New Modulo_MaterialesCentral.cp_cmb_SimpleFiltradoParam
        Me.tbx_RFC = New Modulo_MaterialesCentral.cp_Textbox
        Me.tbx_NombreC = New Modulo_MaterialesCentral.cp_Textbox
        Me.tbx_DireccionC = New Modulo_MaterialesCentral.cp_Textbox
        Me.tbx_NumeroIF = New Modulo_MaterialesCentral.cp_Textbox
        Me.tbx_NumeroEF = New Modulo_MaterialesCentral.cp_Textbox
        Me.tbx_DireccionF = New Modulo_MaterialesCentral.cp_Textbox
        Me.tbx_NombreF = New Modulo_MaterialesCentral.cp_Textbox
        Me.tbx_Clave = New Modulo_MaterialesCentral.cp_Textbox
        Me.Tab_Catalogo.SuspendLayout()
        Me.tab_Listado.SuspendLayout()
        Me.Tab_Nuevo.SuspendLayout()
        Me.gbx_Contactos.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tab_Catalogo
        '
        Me.Tab_Catalogo.Controls.Add(Me.tab_Listado)
        Me.Tab_Catalogo.Controls.Add(Me.Tab_Nuevo)
        Me.Tab_Catalogo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tab_Catalogo.Location = New System.Drawing.Point(0, 0)
        Me.Tab_Catalogo.Name = "Tab_Catalogo"
        Me.Tab_Catalogo.SelectedIndex = 0
        Me.Tab_Catalogo.Size = New System.Drawing.Size(884, 611)
        Me.Tab_Catalogo.TabIndex = 0
        '
        'tab_Listado
        '
        Me.tab_Listado.Controls.Add(Me.btn_Mostrar)
        Me.tab_Listado.Controls.Add(Me.cmb_Status)
        Me.tab_Listado.Controls.Add(Me.chk_Todos)
        Me.tab_Listado.Controls.Add(Me.Lbl_Status)
        Me.tab_Listado.Controls.Add(Me.Lbl_Registros)
        Me.tab_Listado.Controls.Add(Me.Lbl_ContactosProv)
        Me.tab_Listado.Controls.Add(Me.lsv_Contactos)
        Me.tab_Listado.Controls.Add(Me.BTN_Modificar)
        Me.tab_Listado.Controls.Add(Me.btn_Cerrar)
        Me.tab_Listado.Controls.Add(Me.BTN_Exportar)
        Me.tab_Listado.Controls.Add(Me.Btn_Baja)
        Me.tab_Listado.Controls.Add(Me.BTN_Buscar)
        Me.tab_Listado.Controls.Add(Me.tbx_Buscar)
        Me.tab_Listado.Controls.Add(Me.Lbl_Buscar)
        Me.tab_Listado.Controls.Add(Me.lsv_Catalogo)
        Me.tab_Listado.Location = New System.Drawing.Point(4, 22)
        Me.tab_Listado.Name = "tab_Listado"
        Me.tab_Listado.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_Listado.Size = New System.Drawing.Size(876, 585)
        Me.tab_Listado.TabIndex = 0
        Me.tab_Listado.Text = "Listado"
        Me.tab_Listado.UseVisualStyleBackColor = True
        '
        'btn_Mostrar
        '
        Me.btn_Mostrar.Image = Global.Modulo_MaterialesCentral.My.Resources.Resources._1rightarrow1
        Me.btn_Mostrar.Location = New System.Drawing.Point(287, 28)
        Me.btn_Mostrar.Name = "btn_Mostrar"
        Me.btn_Mostrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Mostrar.TabIndex = 7
        Me.btn_Mostrar.Text = "&Mostrar"
        Me.btn_Mostrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Mostrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Mostrar.UseVisualStyleBackColor = True
        '
        'chk_Todos
        '
        Me.chk_Todos.AutoSize = True
        Me.chk_Todos.Checked = True
        Me.chk_Todos.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_Todos.Location = New System.Drawing.Point(225, 36)
        Me.chk_Todos.Name = "chk_Todos"
        Me.chk_Todos.Size = New System.Drawing.Size(56, 17)
        Me.chk_Todos.TabIndex = 6
        Me.chk_Todos.Text = "Todos"
        Me.chk_Todos.UseVisualStyleBackColor = True
        '
        'Lbl_Status
        '
        Me.Lbl_Status.AutoSize = True
        Me.Lbl_Status.Location = New System.Drawing.Point(14, 37)
        Me.Lbl_Status.Name = "Lbl_Status"
        Me.Lbl_Status.Size = New System.Drawing.Size(37, 13)
        Me.Lbl_Status.TabIndex = 4
        Me.Lbl_Status.Text = "Status"
        '
        'Lbl_Registros
        '
        Me.Lbl_Registros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Registros.Location = New System.Drawing.Point(728, 6)
        Me.Lbl_Registros.Name = "Lbl_Registros"
        Me.Lbl_Registros.Size = New System.Drawing.Size(140, 19)
        Me.Lbl_Registros.TabIndex = 3
        Me.Lbl_Registros.Text = "Registros: 0"
        Me.Lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lbl_ContactosProv
        '
        Me.Lbl_ContactosProv.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Lbl_ContactosProv.AutoSize = True
        Me.Lbl_ContactosProv.Location = New System.Drawing.Point(8, 358)
        Me.Lbl_ContactosProv.Name = "Lbl_ContactosProv"
        Me.Lbl_ContactosProv.Size = New System.Drawing.Size(125, 13)
        Me.Lbl_ContactosProv.TabIndex = 9
        Me.Lbl_ContactosProv.Text = "Contactos por Proveedor"
        '
        'BTN_Modificar
        '
        Me.BTN_Modificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BTN_Modificar.Enabled = False
        Me.BTN_Modificar.Image = Global.Modulo_MaterialesCentral.My.Resources.Resources.Editar
        Me.BTN_Modificar.Location = New System.Drawing.Point(151, 547)
        Me.BTN_Modificar.Name = "BTN_Modificar"
        Me.BTN_Modificar.Size = New System.Drawing.Size(140, 30)
        Me.BTN_Modificar.TabIndex = 12
        Me.BTN_Modificar.Text = "&Modificar"
        Me.BTN_Modificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_Modificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_Modificar.UseVisualStyleBackColor = True
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_MaterialesCentral.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(728, 547)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 14
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'BTN_Exportar
        '
        Me.BTN_Exportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BTN_Exportar.Image = Global.Modulo_MaterialesCentral.My.Resources.Resources.Exportar
        Me.BTN_Exportar.Location = New System.Drawing.Point(297, 547)
        Me.BTN_Exportar.Name = "BTN_Exportar"
        Me.BTN_Exportar.Size = New System.Drawing.Size(140, 30)
        Me.BTN_Exportar.TabIndex = 13
        Me.BTN_Exportar.Text = "&Exportar"
        Me.BTN_Exportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_Exportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_Exportar.UseVisualStyleBackColor = True
        '
        'Btn_Baja
        '
        Me.Btn_Baja.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn_Baja.Enabled = False
        Me.Btn_Baja.Image = Global.Modulo_MaterialesCentral.My.Resources.Resources.BajaReing
        Me.Btn_Baja.Location = New System.Drawing.Point(5, 547)
        Me.Btn_Baja.Name = "Btn_Baja"
        Me.Btn_Baja.Size = New System.Drawing.Size(140, 30)
        Me.Btn_Baja.TabIndex = 11
        Me.Btn_Baja.Text = "&Baja / Reing."
        Me.Btn_Baja.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Baja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Baja.UseVisualStyleBackColor = True
        '
        'BTN_Buscar
        '
        Me.BTN_Buscar.Image = Global.Modulo_MaterialesCentral.My.Resources.Resources.Buscar
        Me.BTN_Buscar.Location = New System.Drawing.Point(631, 4)
        Me.BTN_Buscar.Name = "BTN_Buscar"
        Me.BTN_Buscar.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Buscar.TabIndex = 2
        Me.BTN_Buscar.Text = "B&uscar"
        Me.BTN_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_Buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_Buscar.UseVisualStyleBackColor = True
        '
        'Lbl_Buscar
        '
        Me.Lbl_Buscar.AutoSize = True
        Me.Lbl_Buscar.Location = New System.Drawing.Point(3, 9)
        Me.Lbl_Buscar.Name = "Lbl_Buscar"
        Me.Lbl_Buscar.Size = New System.Drawing.Size(43, 13)
        Me.Lbl_Buscar.TabIndex = 0
        Me.Lbl_Buscar.Text = "Buscar:"
        '
        'Tab_Nuevo
        '
        Me.Tab_Nuevo.Controls.Add(Me.gbx_Contactos)
        Me.Tab_Nuevo.Controls.Add(Me.Lbl_DiasCredito)
        Me.Tab_Nuevo.Controls.Add(Me.Label19)
        Me.Tab_Nuevo.Controls.Add(Me.Lbl_Col)
        Me.Tab_Nuevo.Controls.Add(Me.Lbl_NumInt)
        Me.Tab_Nuevo.Controls.Add(Me.Lbl_NumExt)
        Me.Tab_Nuevo.Controls.Add(Me.Lbl_Colonia)
        Me.Tab_Nuevo.Controls.Add(Me.Lbl_NInt)
        Me.Tab_Nuevo.Controls.Add(Me.Lbl_NExterior)
        Me.Tab_Nuevo.Controls.Add(Me.lbl_Observaciones)
        Me.Tab_Nuevo.Controls.Add(Me.Lbl_Retencion)
        Me.Tab_Nuevo.Controls.Add(Me.Lbl_IVA)
        Me.Tab_Nuevo.Controls.Add(Me.lbl_CorreoE)
        Me.Tab_Nuevo.Controls.Add(Me.lbl_Fax)
        Me.Tab_Nuevo.Controls.Add(Me.lbl_Telefono)
        Me.Tab_Nuevo.Controls.Add(Me.lbl_Contacto)
        Me.Tab_Nuevo.Controls.Add(Me.lbl_CiudadC)
        Me.Tab_Nuevo.Controls.Add(Me.lbl_DireccionC)
        Me.Tab_Nuevo.Controls.Add(Me.lbl_NombreC)
        Me.Tab_Nuevo.Controls.Add(Me.lbl_RFC)
        Me.Tab_Nuevo.Controls.Add(Me.lbl_CiudadF)
        Me.Tab_Nuevo.Controls.Add(Me.lbl_DireccionF)
        Me.Tab_Nuevo.Controls.Add(Me.btn_Cancelar)
        Me.Tab_Nuevo.Controls.Add(Me.btn_Guardar)
        Me.Tab_Nuevo.Controls.Add(Me.lbl_NombreF)
        Me.Tab_Nuevo.Controls.Add(Me.Label7)
        Me.Tab_Nuevo.Controls.Add(Me.Label6)
        Me.Tab_Nuevo.Controls.Add(Me.Label11)
        Me.Tab_Nuevo.Controls.Add(Me.Label10)
        Me.Tab_Nuevo.Controls.Add(Me.Label5)
        Me.Tab_Nuevo.Controls.Add(Me.Label4)
        Me.Tab_Nuevo.Controls.Add(Me.Label3)
        Me.Tab_Nuevo.Controls.Add(Me.Label8)
        Me.Tab_Nuevo.Controls.Add(Me.Label2)
        Me.Tab_Nuevo.Controls.Add(Me.Label1)
        Me.Tab_Nuevo.Controls.Add(Me.lbl_Clave)
        Me.Tab_Nuevo.Controls.Add(Me.tbx_Dias)
        Me.Tab_Nuevo.Controls.Add(Me.tbx_ColoniaC)
        Me.Tab_Nuevo.Controls.Add(Me.tbx_NumeroIC)
        Me.Tab_Nuevo.Controls.Add(Me.tbx_NumeroEC)
        Me.Tab_Nuevo.Controls.Add(Me.tbx_ColoniaF)
        Me.Tab_Nuevo.Controls.Add(Me.tbx_NumeroIF)
        Me.Tab_Nuevo.Controls.Add(Me.tbx_NumeroEF)
        Me.Tab_Nuevo.Controls.Add(Me.tbx_Observaciones)
        Me.Tab_Nuevo.Controls.Add(Me.tbx_Retencion)
        Me.Tab_Nuevo.Controls.Add(Me.tbx_IVA)
        Me.Tab_Nuevo.Controls.Add(Me.tbx_CorreoE)
        Me.Tab_Nuevo.Controls.Add(Me.tbx_Fax)
        Me.Tab_Nuevo.Controls.Add(Me.tbx_Telefono)
        Me.Tab_Nuevo.Controls.Add(Me.tbx_Contacto)
        Me.Tab_Nuevo.Controls.Add(Me.cmb_CiudadC)
        Me.Tab_Nuevo.Controls.Add(Me.tbx_DireccionC)
        Me.Tab_Nuevo.Controls.Add(Me.tbx_NombreC)
        Me.Tab_Nuevo.Controls.Add(Me.tbx_RFC)
        Me.Tab_Nuevo.Controls.Add(Me.cmb_CiudadF)
        Me.Tab_Nuevo.Controls.Add(Me.tbx_DireccionF)
        Me.Tab_Nuevo.Controls.Add(Me.tbx_NombreF)
        Me.Tab_Nuevo.Controls.Add(Me.tbx_Clave)
        Me.Tab_Nuevo.Location = New System.Drawing.Point(4, 22)
        Me.Tab_Nuevo.Name = "Tab_Nuevo"
        Me.Tab_Nuevo.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_Nuevo.Size = New System.Drawing.Size(876, 585)
        Me.Tab_Nuevo.TabIndex = 1
        Me.Tab_Nuevo.Text = "Nuevo"
        Me.Tab_Nuevo.UseVisualStyleBackColor = True
        '
        'gbx_Contactos
        '
        Me.gbx_Contactos.Controls.Add(Me.Label26)
        Me.gbx_Contactos.Controls.Add(Me.Label25)
        Me.gbx_Contactos.Controls.Add(Me.tbx_TelMovil)
        Me.gbx_Contactos.Controls.Add(Me.Lbl_TelMov)
        Me.gbx_Contactos.Controls.Add(Me.tbx_Mail)
        Me.gbx_Contactos.Controls.Add(Me.Lbl_Mail)
        Me.gbx_Contactos.Controls.Add(Me.tbx_TelFijo)
        Me.gbx_Contactos.Controls.Add(Me.Lbl_TelFijo)
        Me.gbx_Contactos.Controls.Add(Me.tbx_Puesto)
        Me.gbx_Contactos.Controls.Add(Me.Lbl_Puesto)
        Me.gbx_Contactos.Controls.Add(Me.btn_Eliminar)
        Me.gbx_Contactos.Controls.Add(Me.btn_Agregar)
        Me.gbx_Contactos.Controls.Add(Me.tbx_Nombre)
        Me.gbx_Contactos.Controls.Add(Me.lbl_Nombre)
        Me.gbx_Contactos.Controls.Add(Me.lsv_ContactosAgregar)
        Me.gbx_Contactos.Location = New System.Drawing.Point(469, 268)
        Me.gbx_Contactos.Name = "gbx_Contactos"
        Me.gbx_Contactos.Size = New System.Drawing.Size(387, 242)
        Me.gbx_Contactos.TabIndex = 55
        Me.gbx_Contactos.TabStop = False
        Me.gbx_Contactos.Text = "Contactos"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Red
        Me.Label26.Location = New System.Drawing.Point(336, 44)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(12, 13)
        Me.Label26.TabIndex = 5
        Me.Label26.Text = "*"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Red
        Me.Label25.Location = New System.Drawing.Point(336, 16)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(12, 13)
        Me.Label25.TabIndex = 2
        Me.Label25.Text = "*"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_Agregar
        '
        Me.btn_Agregar.Image = Global.Modulo_MaterialesCentral.My.Resources.Resources.Agregar
        Me.btn_Agregar.Location = New System.Drawing.Point(336, 86)
        Me.btn_Agregar.Name = "btn_Agregar"
        Me.btn_Agregar.Size = New System.Drawing.Size(45, 30)
        Me.btn_Agregar.TabIndex = 13
        Me.btn_Agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Agregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Agregar.UseVisualStyleBackColor = True
        '
        'Lbl_TelMov
        '
        Me.Lbl_TelMov.AutoSize = True
        Me.Lbl_TelMov.Location = New System.Drawing.Point(169, 72)
        Me.Lbl_TelMov.Name = "Lbl_TelMov"
        Me.Lbl_TelMov.Size = New System.Drawing.Size(50, 13)
        Me.Lbl_TelMov.TabIndex = 8
        Me.Lbl_TelMov.Text = "Tel Movil"
        '
        'Lbl_Mail
        '
        Me.Lbl_Mail.AutoSize = True
        Me.Lbl_Mail.Location = New System.Drawing.Point(24, 99)
        Me.Lbl_Mail.Name = "Lbl_Mail"
        Me.Lbl_Mail.Size = New System.Drawing.Size(26, 13)
        Me.Lbl_Mail.TabIndex = 10
        Me.Lbl_Mail.Text = "Mail"
        '
        'Lbl_TelFijo
        '
        Me.Lbl_TelFijo.AutoSize = True
        Me.Lbl_TelFijo.Location = New System.Drawing.Point(10, 72)
        Me.Lbl_TelFijo.Name = "Lbl_TelFijo"
        Me.Lbl_TelFijo.Size = New System.Drawing.Size(41, 13)
        Me.Lbl_TelFijo.TabIndex = 6
        Me.Lbl_TelFijo.Text = "Tel Fijo"
        '
        'Lbl_Puesto
        '
        Me.Lbl_Puesto.AutoSize = True
        Me.Lbl_Puesto.Location = New System.Drawing.Point(10, 46)
        Me.Lbl_Puesto.Name = "Lbl_Puesto"
        Me.Lbl_Puesto.Size = New System.Drawing.Size(40, 13)
        Me.Lbl_Puesto.TabIndex = 3
        Me.Lbl_Puesto.Text = "Puesto"
        '
        'btn_Eliminar
        '
        Me.btn_Eliminar.Enabled = False
        Me.btn_Eliminar.Image = Global.Modulo_MaterialesCentral.My.Resources.Resources.Baja
        Me.btn_Eliminar.Location = New System.Drawing.Point(336, 122)
        Me.btn_Eliminar.Name = "btn_Eliminar"
        Me.btn_Eliminar.Size = New System.Drawing.Size(45, 30)
        Me.btn_Eliminar.TabIndex = 14
        Me.btn_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Eliminar.UseVisualStyleBackColor = True
        '
        'lbl_Nombre
        '
        Me.lbl_Nombre.AutoSize = True
        Me.lbl_Nombre.Location = New System.Drawing.Point(6, 21)
        Me.lbl_Nombre.Name = "lbl_Nombre"
        Me.lbl_Nombre.Size = New System.Drawing.Size(44, 13)
        Me.lbl_Nombre.TabIndex = 0
        Me.lbl_Nombre.Text = "Nombre"
        '
        'Lbl_DiasCredito
        '
        Me.Lbl_DiasCredito.AutoSize = True
        Me.Lbl_DiasCredito.Location = New System.Drawing.Point(25, 427)
        Me.Lbl_DiasCredito.Name = "Lbl_DiasCredito"
        Me.Lbl_DiasCredito.Size = New System.Drawing.Size(79, 13)
        Me.Lbl_DiasCredito.TabIndex = 50
        Me.Lbl_DiasCredito.Text = "Dias de Crédito"
        Me.Lbl_DiasCredito.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Red
        Me.Label19.Location = New System.Drawing.Point(166, 424)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(12, 13)
        Me.Label19.TabIndex = 52
        Me.Label19.Text = "*"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lbl_Col
        '
        Me.Lbl_Col.AutoSize = True
        Me.Lbl_Col.Location = New System.Drawing.Point(290, 218)
        Me.Lbl_Col.Name = "Lbl_Col"
        Me.Lbl_Col.Size = New System.Drawing.Size(42, 13)
        Me.Lbl_Col.TabIndex = 31
        Me.Lbl_Col.Text = "Colonia"
        Me.Lbl_Col.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lbl_NumInt
        '
        Me.Lbl_NumInt.AutoSize = True
        Me.Lbl_NumInt.Location = New System.Drawing.Point(169, 218)
        Me.Lbl_NumInt.Name = "Lbl_NumInt"
        Me.Lbl_NumInt.Size = New System.Drawing.Size(59, 13)
        Me.Lbl_NumInt.TabIndex = 29
        Me.Lbl_NumInt.Text = "No. Interior"
        Me.Lbl_NumInt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lbl_NumExt
        '
        Me.Lbl_NumExt.AutoSize = True
        Me.Lbl_NumExt.Location = New System.Drawing.Point(42, 218)
        Me.Lbl_NumExt.Name = "Lbl_NumExt"
        Me.Lbl_NumExt.Size = New System.Drawing.Size(62, 13)
        Me.Lbl_NumExt.TabIndex = 27
        Me.Lbl_NumExt.Text = "No. Exterior"
        Me.Lbl_NumExt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lbl_Colonia
        '
        Me.Lbl_Colonia.AutoSize = True
        Me.Lbl_Colonia.Location = New System.Drawing.Point(290, 87)
        Me.Lbl_Colonia.Name = "Lbl_Colonia"
        Me.Lbl_Colonia.Size = New System.Drawing.Size(42, 13)
        Me.Lbl_Colonia.TabIndex = 13
        Me.Lbl_Colonia.Text = "Colonia"
        Me.Lbl_Colonia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lbl_NInt
        '
        Me.Lbl_NInt.AutoSize = True
        Me.Lbl_NInt.Location = New System.Drawing.Point(169, 87)
        Me.Lbl_NInt.Name = "Lbl_NInt"
        Me.Lbl_NInt.Size = New System.Drawing.Size(59, 13)
        Me.Lbl_NInt.TabIndex = 11
        Me.Lbl_NInt.Text = "No. Interior"
        Me.Lbl_NInt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lbl_NExterior
        '
        Me.Lbl_NExterior.AutoSize = True
        Me.Lbl_NExterior.Location = New System.Drawing.Point(42, 87)
        Me.Lbl_NExterior.Name = "Lbl_NExterior"
        Me.Lbl_NExterior.Size = New System.Drawing.Size(62, 13)
        Me.Lbl_NExterior.TabIndex = 9
        Me.Lbl_NExterior.Text = "No. Exterior"
        Me.Lbl_NExterior.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_Observaciones
        '
        Me.lbl_Observaciones.AutoSize = True
        Me.lbl_Observaciones.Location = New System.Drawing.Point(26, 453)
        Me.lbl_Observaciones.Name = "lbl_Observaciones"
        Me.lbl_Observaciones.Size = New System.Drawing.Size(78, 13)
        Me.lbl_Observaciones.TabIndex = 53
        Me.lbl_Observaciones.Text = "Observaciones"
        Me.lbl_Observaciones.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lbl_Retencion
        '
        Me.Lbl_Retencion.AutoSize = True
        Me.Lbl_Retencion.Location = New System.Drawing.Point(48, 401)
        Me.Lbl_Retencion.Name = "Lbl_Retencion"
        Me.Lbl_Retencion.Size = New System.Drawing.Size(56, 13)
        Me.Lbl_Retencion.TabIndex = 47
        Me.Lbl_Retencion.Text = "Retención"
        Me.Lbl_Retencion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lbl_IVA
        '
        Me.Lbl_IVA.AutoSize = True
        Me.Lbl_IVA.Location = New System.Drawing.Point(80, 375)
        Me.Lbl_IVA.Name = "Lbl_IVA"
        Me.Lbl_IVA.Size = New System.Drawing.Size(24, 13)
        Me.Lbl_IVA.TabIndex = 44
        Me.Lbl_IVA.Text = "IVA"
        Me.Lbl_IVA.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_CorreoE
        '
        Me.lbl_CorreoE.AutoSize = True
        Me.lbl_CorreoE.Location = New System.Drawing.Point(10, 349)
        Me.lbl_CorreoE.Name = "lbl_CorreoE"
        Me.lbl_CorreoE.Size = New System.Drawing.Size(94, 13)
        Me.lbl_CorreoE.TabIndex = 42
        Me.lbl_CorreoE.Text = "Correo Electrónico"
        Me.lbl_CorreoE.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_Fax
        '
        Me.lbl_Fax.AutoSize = True
        Me.lbl_Fax.Location = New System.Drawing.Point(80, 323)
        Me.lbl_Fax.Name = "lbl_Fax"
        Me.lbl_Fax.Size = New System.Drawing.Size(24, 13)
        Me.lbl_Fax.TabIndex = 40
        Me.lbl_Fax.Text = "Fax"
        Me.lbl_Fax.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_Telefono
        '
        Me.lbl_Telefono.AutoSize = True
        Me.lbl_Telefono.Location = New System.Drawing.Point(55, 297)
        Me.lbl_Telefono.Name = "lbl_Telefono"
        Me.lbl_Telefono.Size = New System.Drawing.Size(49, 13)
        Me.lbl_Telefono.TabIndex = 38
        Me.lbl_Telefono.Text = "Teléfono"
        Me.lbl_Telefono.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_Contacto
        '
        Me.lbl_Contacto.AutoSize = True
        Me.lbl_Contacto.Location = New System.Drawing.Point(54, 271)
        Me.lbl_Contacto.Name = "lbl_Contacto"
        Me.lbl_Contacto.Size = New System.Drawing.Size(50, 13)
        Me.lbl_Contacto.TabIndex = 36
        Me.lbl_Contacto.Text = "Contacto"
        Me.lbl_Contacto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_CiudadC
        '
        Me.lbl_CiudadC.AutoSize = True
        Me.lbl_CiudadC.Location = New System.Drawing.Point(15, 244)
        Me.lbl_CiudadC.Name = "lbl_CiudadC"
        Me.lbl_CiudadC.Size = New System.Drawing.Size(89, 13)
        Me.lbl_CiudadC.TabIndex = 33
        Me.lbl_CiudadC.Text = "Ciudad Comercial"
        '
        'lbl_DireccionC
        '
        Me.lbl_DireccionC.AutoSize = True
        Me.lbl_DireccionC.Location = New System.Drawing.Point(25, 192)
        Me.lbl_DireccionC.Name = "lbl_DireccionC"
        Me.lbl_DireccionC.Size = New System.Drawing.Size(79, 13)
        Me.lbl_DireccionC.TabIndex = 24
        Me.lbl_DireccionC.Text = "Calle Comercial"
        Me.lbl_DireccionC.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_NombreC
        '
        Me.lbl_NombreC.AutoSize = True
        Me.lbl_NombreC.Location = New System.Drawing.Point(11, 166)
        Me.lbl_NombreC.Name = "lbl_NombreC"
        Me.lbl_NombreC.Size = New System.Drawing.Size(93, 13)
        Me.lbl_NombreC.TabIndex = 21
        Me.lbl_NombreC.Text = "Nombre Comercial"
        Me.lbl_NombreC.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_RFC
        '
        Me.lbl_RFC.AutoSize = True
        Me.lbl_RFC.Location = New System.Drawing.Point(76, 140)
        Me.lbl_RFC.Name = "lbl_RFC"
        Me.lbl_RFC.Size = New System.Drawing.Size(28, 13)
        Me.lbl_RFC.TabIndex = 18
        Me.lbl_RFC.Text = "RFC"
        Me.lbl_RFC.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_CiudadF
        '
        Me.lbl_CiudadF.AutoSize = True
        Me.lbl_CiudadF.Location = New System.Drawing.Point(34, 113)
        Me.lbl_CiudadF.Name = "lbl_CiudadF"
        Me.lbl_CiudadF.Size = New System.Drawing.Size(70, 13)
        Me.lbl_CiudadF.TabIndex = 15
        Me.lbl_CiudadF.Text = "Ciudad Fiscal"
        '
        'lbl_DireccionF
        '
        Me.lbl_DireccionF.AutoSize = True
        Me.lbl_DireccionF.Location = New System.Drawing.Point(44, 61)
        Me.lbl_DireccionF.Name = "lbl_DireccionF"
        Me.lbl_DireccionF.Size = New System.Drawing.Size(60, 13)
        Me.lbl_DireccionF.TabIndex = 6
        Me.lbl_DireccionF.Text = "Calle Fiscal"
        Me.lbl_DireccionF.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Image = Global.Modulo_MaterialesCentral.My.Resources.Resources.Cancelar
        Me.btn_Cancelar.Location = New System.Drawing.Point(256, 517)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cancelar.TabIndex = 57
        Me.btn_Cancelar.Text = "&Cancelar"
        Me.btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Image = Global.Modulo_MaterialesCentral.My.Resources.Resources.Guardar
        Me.btn_Guardar.Location = New System.Drawing.Point(110, 518)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Guardar.TabIndex = 56
        Me.btn_Guardar.Text = "&Guardar"
        Me.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'lbl_NombreF
        '
        Me.lbl_NombreF.AutoSize = True
        Me.lbl_NombreF.Location = New System.Drawing.Point(30, 35)
        Me.lbl_NombreF.Name = "lbl_NombreF"
        Me.lbl_NombreF.Size = New System.Drawing.Size(74, 13)
        Me.lbl_NombreF.TabIndex = 3
        Me.lbl_NombreF.Text = "Nombre Fiscal"
        Me.lbl_NombreF.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(466, 61)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(12, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "*"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(652, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(12, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "*"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(191, 398)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(12, 13)
        Me.Label11.TabIndex = 49
        Me.Label11.Text = "*"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(191, 372)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(12, 13)
        Me.Label10.TabIndex = 46
        Me.Label10.Text = "*"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(340, 241)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(12, 13)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "*"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(466, 189)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(12, 13)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "*"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(652, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(12, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "*"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(340, 110)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(12, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "*"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(340, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(12, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "*"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(166, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(12, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "*"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_Clave
        '
        Me.lbl_Clave.AutoSize = True
        Me.lbl_Clave.Location = New System.Drawing.Point(70, 9)
        Me.lbl_Clave.Name = "lbl_Clave"
        Me.lbl_Clave.Size = New System.Drawing.Size(34, 13)
        Me.lbl_Clave.TabIndex = 0
        Me.lbl_Clave.Text = "Clave"
        Me.lbl_Clave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_Status
        '
        Me.cmb_Status.Control_Siguiente = Nothing
        Me.cmb_Status.DisplayMember = "display"
        Me.cmb_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Status.FormattingEnabled = True
        Me.cmb_Status.Location = New System.Drawing.Point(57, 32)
        Me.cmb_Status.MaxDropDownItems = 20
        Me.cmb_Status.Name = "cmb_Status"
        Me.cmb_Status.Size = New System.Drawing.Size(162, 21)
        Me.cmb_Status.TabIndex = 5
        Me.cmb_Status.ValueMember = "value"
        '
        'lsv_Contactos
        '
        Me.lsv_Contactos.AllowColumnReorder = True
        Me.lsv_Contactos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Contactos.FullRowSelect = True
        Me.lsv_Contactos.HideSelection = False
        Me.lsv_Contactos.Location = New System.Drawing.Point(8, 374)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Contactos.Lvs = ListViewColumnSorter1
        Me.lsv_Contactos.MultiSelect = False
        Me.lsv_Contactos.Name = "lsv_Contactos"
        Me.lsv_Contactos.Ocultar = ""
        Me.lsv_Contactos.Row1 = 25
        Me.lsv_Contactos.Row10 = 0
        Me.lsv_Contactos.Row2 = 20
        Me.lsv_Contactos.Row3 = 12
        Me.lsv_Contactos.Row4 = 12
        Me.lsv_Contactos.Row5 = 15
        Me.lsv_Contactos.Row6 = 10
        Me.lsv_Contactos.Row7 = 0
        Me.lsv_Contactos.Row8 = 0
        Me.lsv_Contactos.Row9 = 0
        Me.lsv_Contactos.Size = New System.Drawing.Size(862, 167)
        Me.lsv_Contactos.TabIndex = 10
        Me.lsv_Contactos.UseCompatibleStateImageBehavior = False
        Me.lsv_Contactos.View = System.Windows.Forms.View.Details
        '
        'tbx_Buscar
        '
        Me.tbx_Buscar.Control_Siguiente = Me.BTN_Buscar
        Me.tbx_Buscar.Filtrado = True
        Me.tbx_Buscar.Location = New System.Drawing.Point(57, 6)
        Me.tbx_Buscar.MaxLength = 50
        Me.tbx_Buscar.Name = "tbx_Buscar"
        Me.tbx_Buscar.Size = New System.Drawing.Size(568, 20)
        Me.tbx_Buscar.TabIndex = 1
        Me.tbx_Buscar.TipoDatos = Modulo_MaterialesCentral.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'lsv_Catalogo
        '
        Me.lsv_Catalogo.AllowColumnReorder = True
        Me.lsv_Catalogo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Catalogo.FullRowSelect = True
        Me.lsv_Catalogo.HideSelection = False
        Me.lsv_Catalogo.Location = New System.Drawing.Point(7, 59)
        ListViewColumnSorter2.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter2.SortColumn = 0
        Me.lsv_Catalogo.Lvs = ListViewColumnSorter2
        Me.lsv_Catalogo.MultiSelect = False
        Me.lsv_Catalogo.Name = "lsv_Catalogo"
        Me.lsv_Catalogo.Ocultar = ""
        Me.lsv_Catalogo.Row1 = 10
        Me.lsv_Catalogo.Row10 = 10
        Me.lsv_Catalogo.Row2 = 25
        Me.lsv_Catalogo.Row3 = 10
        Me.lsv_Catalogo.Row4 = 20
        Me.lsv_Catalogo.Row5 = 15
        Me.lsv_Catalogo.Row6 = 8
        Me.lsv_Catalogo.Row7 = 10
        Me.lsv_Catalogo.Row8 = 10
        Me.lsv_Catalogo.Row9 = 10
        Me.lsv_Catalogo.Size = New System.Drawing.Size(862, 285)
        Me.lsv_Catalogo.TabIndex = 8
        Me.lsv_Catalogo.UseCompatibleStateImageBehavior = False
        Me.lsv_Catalogo.View = System.Windows.Forms.View.Details
        '
        'tbx_TelMovil
        '
        Me.tbx_TelMovil.Control_Siguiente = Me.tbx_Mail
        Me.tbx_TelMovil.Filtrado = False
        Me.tbx_TelMovil.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tbx_TelMovil.Location = New System.Drawing.Point(223, 69)
        Me.tbx_TelMovil.MaxLength = 20
        Me.tbx_TelMovil.Name = "tbx_TelMovil"
        Me.tbx_TelMovil.Size = New System.Drawing.Size(107, 20)
        Me.tbx_TelMovil.TabIndex = 9
        Me.tbx_TelMovil.TipoDatos = Modulo_MaterialesCentral.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'tbx_Mail
        '
        Me.tbx_Mail.Control_Siguiente = Me.btn_Agregar
        Me.tbx_Mail.Filtrado = False
        Me.tbx_Mail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tbx_Mail.Location = New System.Drawing.Point(56, 96)
        Me.tbx_Mail.MaxLength = 70
        Me.tbx_Mail.Name = "tbx_Mail"
        Me.tbx_Mail.Size = New System.Drawing.Size(274, 20)
        Me.tbx_Mail.TabIndex = 11
        Me.tbx_Mail.TipoDatos = Modulo_MaterialesCentral.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'tbx_TelFijo
        '
        Me.tbx_TelFijo.Control_Siguiente = Me.tbx_TelMovil
        Me.tbx_TelFijo.Filtrado = False
        Me.tbx_TelFijo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tbx_TelFijo.Location = New System.Drawing.Point(56, 70)
        Me.tbx_TelFijo.MaxLength = 20
        Me.tbx_TelFijo.Name = "tbx_TelFijo"
        Me.tbx_TelFijo.Size = New System.Drawing.Size(107, 20)
        Me.tbx_TelFijo.TabIndex = 7
        Me.tbx_TelFijo.TipoDatos = Modulo_MaterialesCentral.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'tbx_Puesto
        '
        Me.tbx_Puesto.Control_Siguiente = Me.tbx_TelFijo
        Me.tbx_Puesto.Filtrado = False
        Me.tbx_Puesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tbx_Puesto.Location = New System.Drawing.Point(56, 44)
        Me.tbx_Puesto.MaxLength = 50
        Me.tbx_Puesto.Name = "tbx_Puesto"
        Me.tbx_Puesto.Size = New System.Drawing.Size(274, 20)
        Me.tbx_Puesto.TabIndex = 4
        Me.tbx_Puesto.TipoDatos = Modulo_MaterialesCentral.FuncionesGlobales.Validar_Cadena.Letras
        '
        'tbx_Nombre
        '
        Me.tbx_Nombre.Control_Siguiente = Me.tbx_Puesto
        Me.tbx_Nombre.Filtrado = False
        Me.tbx_Nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tbx_Nombre.Location = New System.Drawing.Point(56, 18)
        Me.tbx_Nombre.MaxLength = 50
        Me.tbx_Nombre.Name = "tbx_Nombre"
        Me.tbx_Nombre.Size = New System.Drawing.Size(274, 20)
        Me.tbx_Nombre.TabIndex = 1
        Me.tbx_Nombre.TipoDatos = Modulo_MaterialesCentral.FuncionesGlobales.Validar_Cadena.Letras
        '
        'lsv_ContactosAgregar
        '
        Me.lsv_ContactosAgregar.AllowColumnReorder = True
        Me.lsv_ContactosAgregar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_ContactosAgregar.FullRowSelect = True
        Me.lsv_ContactosAgregar.HideSelection = False
        Me.lsv_ContactosAgregar.Location = New System.Drawing.Point(6, 122)
        ListViewColumnSorter3.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter3.SortColumn = 0
        Me.lsv_ContactosAgregar.Lvs = ListViewColumnSorter3
        Me.lsv_ContactosAgregar.MultiSelect = False
        Me.lsv_ContactosAgregar.Name = "lsv_ContactosAgregar"
        Me.lsv_ContactosAgregar.Ocultar = ""
        Me.lsv_ContactosAgregar.Row1 = 50
        Me.lsv_ContactosAgregar.Row10 = 0
        Me.lsv_ContactosAgregar.Row2 = 40
        Me.lsv_ContactosAgregar.Row3 = 30
        Me.lsv_ContactosAgregar.Row4 = 30
        Me.lsv_ContactosAgregar.Row5 = 30
        Me.lsv_ContactosAgregar.Row6 = 20
        Me.lsv_ContactosAgregar.Row7 = 0
        Me.lsv_ContactosAgregar.Row8 = 0
        Me.lsv_ContactosAgregar.Row9 = 0
        Me.lsv_ContactosAgregar.Size = New System.Drawing.Size(324, 114)
        Me.lsv_ContactosAgregar.TabIndex = 12
        Me.lsv_ContactosAgregar.UseCompatibleStateImageBehavior = False
        Me.lsv_ContactosAgregar.View = System.Windows.Forms.View.Details
        '
        'tbx_Dias
        '
        Me.tbx_Dias.Control_Siguiente = Me.tbx_Observaciones
        Me.tbx_Dias.Filtrado = True
        Me.tbx_Dias.Location = New System.Drawing.Point(110, 424)
        Me.tbx_Dias.MaxLength = 3
        Me.tbx_Dias.Name = "tbx_Dias"
        Me.tbx_Dias.Size = New System.Drawing.Size(50, 20)
        Me.tbx_Dias.TabIndex = 51
        Me.tbx_Dias.TipoDatos = Modulo_MaterialesCentral.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'tbx_Observaciones
        '
        Me.tbx_Observaciones.Control_Siguiente = Me.btn_Guardar
        Me.tbx_Observaciones.Filtrado = True
        Me.tbx_Observaciones.Location = New System.Drawing.Point(110, 450)
        Me.tbx_Observaciones.MaxLength = 150
        Me.tbx_Observaciones.Multiline = True
        Me.tbx_Observaciones.Name = "tbx_Observaciones"
        Me.tbx_Observaciones.Size = New System.Drawing.Size(350, 60)
        Me.tbx_Observaciones.TabIndex = 54
        Me.tbx_Observaciones.TipoDatos = Modulo_MaterialesCentral.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'tbx_ColoniaC
        '
        Me.tbx_ColoniaC.Control_Siguiente = Me.cmb_CiudadC
        Me.tbx_ColoniaC.Filtrado = True
        Me.tbx_ColoniaC.Location = New System.Drawing.Point(338, 215)
        Me.tbx_ColoniaC.MaxLength = 100
        Me.tbx_ColoniaC.Name = "tbx_ColoniaC"
        Me.tbx_ColoniaC.Size = New System.Drawing.Size(308, 20)
        Me.tbx_ColoniaC.TabIndex = 32
        Me.tbx_ColoniaC.TipoDatos = Modulo_MaterialesCentral.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'cmb_CiudadC
        '
        Me.cmb_CiudadC.Clave = Nothing
        Me.cmb_CiudadC.Control_Siguiente = Me.tbx_Contacto
        Me.cmb_CiudadC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_CiudadC.Empresa = False
        Me.cmb_CiudadC.Filtro = Nothing
        Me.cmb_CiudadC.FormattingEnabled = True
        Me.cmb_CiudadC.Location = New System.Drawing.Point(110, 241)
        Me.cmb_CiudadC.MaxDropDownItems = 20
        Me.cmb_CiudadC.Name = "cmb_CiudadC"
        Me.cmb_CiudadC.Pista = True
        Me.cmb_CiudadC.Size = New System.Drawing.Size(224, 21)
        Me.cmb_CiudadC.StoredProcedure = Nothing
        Me.cmb_CiudadC.Sucursal = False
        Me.cmb_CiudadC.TabIndex = 34
        Me.cmb_CiudadC.Tipo = 0
        '
        'tbx_Contacto
        '
        Me.tbx_Contacto.Control_Siguiente = Me.tbx_Telefono
        Me.tbx_Contacto.Filtrado = True
        Me.tbx_Contacto.Location = New System.Drawing.Point(110, 268)
        Me.tbx_Contacto.MaxLength = 50
        Me.tbx_Contacto.Name = "tbx_Contacto"
        Me.tbx_Contacto.Size = New System.Drawing.Size(350, 20)
        Me.tbx_Contacto.TabIndex = 37
        Me.tbx_Contacto.TipoDatos = Modulo_MaterialesCentral.FuncionesGlobales.Validar_Cadena.Letras
        '
        'tbx_Telefono
        '
        Me.tbx_Telefono.Control_Siguiente = Me.tbx_Fax
        Me.tbx_Telefono.Filtrado = True
        Me.tbx_Telefono.Location = New System.Drawing.Point(110, 294)
        Me.tbx_Telefono.MaxLength = 50
        Me.tbx_Telefono.Name = "tbx_Telefono"
        Me.tbx_Telefono.Size = New System.Drawing.Size(224, 20)
        Me.tbx_Telefono.TabIndex = 39
        Me.tbx_Telefono.TipoDatos = Modulo_MaterialesCentral.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'tbx_Fax
        '
        Me.tbx_Fax.Control_Siguiente = Me.tbx_CorreoE
        Me.tbx_Fax.Filtrado = True
        Me.tbx_Fax.Location = New System.Drawing.Point(110, 320)
        Me.tbx_Fax.MaxLength = 50
        Me.tbx_Fax.Name = "tbx_Fax"
        Me.tbx_Fax.Size = New System.Drawing.Size(224, 20)
        Me.tbx_Fax.TabIndex = 41
        Me.tbx_Fax.TipoDatos = Modulo_MaterialesCentral.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'tbx_CorreoE
        '
        Me.tbx_CorreoE.Control_Siguiente = Me.tbx_IVA
        Me.tbx_CorreoE.Filtrado = True
        Me.tbx_CorreoE.Location = New System.Drawing.Point(110, 346)
        Me.tbx_CorreoE.MaxLength = 50
        Me.tbx_CorreoE.Name = "tbx_CorreoE"
        Me.tbx_CorreoE.Size = New System.Drawing.Size(350, 20)
        Me.tbx_CorreoE.TabIndex = 43
        Me.tbx_CorreoE.TipoDatos = Modulo_MaterialesCentral.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'tbx_IVA
        '
        Me.tbx_IVA.Control_Siguiente = Me.tbx_Retencion
        Me.tbx_IVA.Filtrado = True
        Me.tbx_IVA.Location = New System.Drawing.Point(110, 372)
        Me.tbx_IVA.MaxLength = 5
        Me.tbx_IVA.Name = "tbx_IVA"
        Me.tbx_IVA.Size = New System.Drawing.Size(75, 20)
        Me.tbx_IVA.TabIndex = 45
        Me.tbx_IVA.TipoDatos = Modulo_MaterialesCentral.FuncionesGlobales.Validar_Cadena.Numeros_Decimales
        '
        'tbx_Retencion
        '
        Me.tbx_Retencion.Control_Siguiente = Me.tbx_Dias
        Me.tbx_Retencion.Filtrado = True
        Me.tbx_Retencion.Location = New System.Drawing.Point(110, 398)
        Me.tbx_Retencion.MaxLength = 5
        Me.tbx_Retencion.Name = "tbx_Retencion"
        Me.tbx_Retencion.Size = New System.Drawing.Size(75, 20)
        Me.tbx_Retencion.TabIndex = 48
        Me.tbx_Retencion.TipoDatos = Modulo_MaterialesCentral.FuncionesGlobales.Validar_Cadena.Numeros_Decimales
        '
        'tbx_NumeroIC
        '
        Me.tbx_NumeroIC.Control_Siguiente = Me.tbx_ColoniaC
        Me.tbx_NumeroIC.Filtrado = True
        Me.tbx_NumeroIC.Location = New System.Drawing.Point(234, 215)
        Me.tbx_NumeroIC.MaxLength = 10
        Me.tbx_NumeroIC.Name = "tbx_NumeroIC"
        Me.tbx_NumeroIC.Size = New System.Drawing.Size(50, 20)
        Me.tbx_NumeroIC.TabIndex = 30
        Me.tbx_NumeroIC.TipoDatos = Modulo_MaterialesCentral.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'tbx_NumeroEC
        '
        Me.tbx_NumeroEC.Control_Siguiente = Me.tbx_NumeroIC
        Me.tbx_NumeroEC.Filtrado = True
        Me.tbx_NumeroEC.Location = New System.Drawing.Point(110, 215)
        Me.tbx_NumeroEC.MaxLength = 6
        Me.tbx_NumeroEC.Name = "tbx_NumeroEC"
        Me.tbx_NumeroEC.Size = New System.Drawing.Size(50, 20)
        Me.tbx_NumeroEC.TabIndex = 28
        Me.tbx_NumeroEC.TipoDatos = Modulo_MaterialesCentral.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'tbx_ColoniaF
        '
        Me.tbx_ColoniaF.Control_Siguiente = Me.cmb_CiudadF
        Me.tbx_ColoniaF.Filtrado = True
        Me.tbx_ColoniaF.Location = New System.Drawing.Point(338, 84)
        Me.tbx_ColoniaF.MaxLength = 100
        Me.tbx_ColoniaF.Name = "tbx_ColoniaF"
        Me.tbx_ColoniaF.Size = New System.Drawing.Size(308, 20)
        Me.tbx_ColoniaF.TabIndex = 14
        Me.tbx_ColoniaF.TipoDatos = Modulo_MaterialesCentral.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'cmb_CiudadF
        '
        Me.cmb_CiudadF.Clave = Nothing
        Me.cmb_CiudadF.Control_Siguiente = Me.tbx_RFC
        Me.cmb_CiudadF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_CiudadF.Empresa = False
        Me.cmb_CiudadF.Filtro = Nothing
        Me.cmb_CiudadF.FormattingEnabled = True
        Me.cmb_CiudadF.Location = New System.Drawing.Point(110, 110)
        Me.cmb_CiudadF.MaxDropDownItems = 20
        Me.cmb_CiudadF.Name = "cmb_CiudadF"
        Me.cmb_CiudadF.Pista = True
        Me.cmb_CiudadF.Size = New System.Drawing.Size(224, 21)
        Me.cmb_CiudadF.StoredProcedure = Nothing
        Me.cmb_CiudadF.Sucursal = False
        Me.cmb_CiudadF.TabIndex = 16
        Me.cmb_CiudadF.Tipo = 0
        '
        'tbx_RFC
        '
        Me.tbx_RFC.Control_Siguiente = Me.tbx_NombreC
        Me.tbx_RFC.Filtrado = True
        Me.tbx_RFC.Location = New System.Drawing.Point(110, 137)
        Me.tbx_RFC.MaxLength = 14
        Me.tbx_RFC.Name = "tbx_RFC"
        Me.tbx_RFC.Size = New System.Drawing.Size(224, 20)
        Me.tbx_RFC.TabIndex = 19
        Me.tbx_RFC.TipoDatos = Modulo_MaterialesCentral.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'tbx_NombreC
        '
        Me.tbx_NombreC.Control_Siguiente = Me.tbx_DireccionC
        Me.tbx_NombreC.Filtrado = True
        Me.tbx_NombreC.Location = New System.Drawing.Point(110, 163)
        Me.tbx_NombreC.MaxLength = 150
        Me.tbx_NombreC.Name = "tbx_NombreC"
        Me.tbx_NombreC.Size = New System.Drawing.Size(536, 20)
        Me.tbx_NombreC.TabIndex = 22
        Me.tbx_NombreC.TipoDatos = Modulo_MaterialesCentral.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'tbx_DireccionC
        '
        Me.tbx_DireccionC.Control_Siguiente = Me.tbx_NumeroEC
        Me.tbx_DireccionC.Filtrado = True
        Me.tbx_DireccionC.Location = New System.Drawing.Point(110, 189)
        Me.tbx_DireccionC.MaxLength = 150
        Me.tbx_DireccionC.Multiline = True
        Me.tbx_DireccionC.Name = "tbx_DireccionC"
        Me.tbx_DireccionC.Size = New System.Drawing.Size(350, 20)
        Me.tbx_DireccionC.TabIndex = 25
        Me.tbx_DireccionC.TipoDatos = Modulo_MaterialesCentral.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'tbx_NumeroIF
        '
        Me.tbx_NumeroIF.Control_Siguiente = Me.tbx_ColoniaF
        Me.tbx_NumeroIF.Filtrado = True
        Me.tbx_NumeroIF.Location = New System.Drawing.Point(234, 84)
        Me.tbx_NumeroIF.MaxLength = 10
        Me.tbx_NumeroIF.Name = "tbx_NumeroIF"
        Me.tbx_NumeroIF.Size = New System.Drawing.Size(50, 20)
        Me.tbx_NumeroIF.TabIndex = 12
        Me.tbx_NumeroIF.TipoDatos = Modulo_MaterialesCentral.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'tbx_NumeroEF
        '
        Me.tbx_NumeroEF.Control_Siguiente = Me.tbx_NumeroIF
        Me.tbx_NumeroEF.Filtrado = True
        Me.tbx_NumeroEF.Location = New System.Drawing.Point(110, 84)
        Me.tbx_NumeroEF.MaxLength = 6
        Me.tbx_NumeroEF.Name = "tbx_NumeroEF"
        Me.tbx_NumeroEF.Size = New System.Drawing.Size(50, 20)
        Me.tbx_NumeroEF.TabIndex = 10
        Me.tbx_NumeroEF.TipoDatos = Modulo_MaterialesCentral.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'tbx_DireccionF
        '
        Me.tbx_DireccionF.Control_Siguiente = Me.tbx_NumeroEF
        Me.tbx_DireccionF.Filtrado = True
        Me.tbx_DireccionF.Location = New System.Drawing.Point(110, 58)
        Me.tbx_DireccionF.MaxLength = 150
        Me.tbx_DireccionF.Multiline = True
        Me.tbx_DireccionF.Name = "tbx_DireccionF"
        Me.tbx_DireccionF.Size = New System.Drawing.Size(350, 20)
        Me.tbx_DireccionF.TabIndex = 7
        Me.tbx_DireccionF.TipoDatos = Modulo_MaterialesCentral.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'tbx_NombreF
        '
        Me.tbx_NombreF.Control_Siguiente = Me.tbx_DireccionF
        Me.tbx_NombreF.Filtrado = True
        Me.tbx_NombreF.Location = New System.Drawing.Point(110, 32)
        Me.tbx_NombreF.MaxLength = 150
        Me.tbx_NombreF.Name = "tbx_NombreF"
        Me.tbx_NombreF.Size = New System.Drawing.Size(536, 20)
        Me.tbx_NombreF.TabIndex = 4
        Me.tbx_NombreF.TipoDatos = Modulo_MaterialesCentral.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'tbx_Clave
        '
        Me.tbx_Clave.Control_Siguiente = Me.tbx_NombreF
        Me.tbx_Clave.Filtrado = True
        Me.tbx_Clave.Location = New System.Drawing.Point(110, 6)
        Me.tbx_Clave.MaxLength = 4
        Me.tbx_Clave.Name = "tbx_Clave"
        Me.tbx_Clave.Size = New System.Drawing.Size(50, 20)
        Me.tbx_Clave.TabIndex = 1
        Me.tbx_Clave.TipoDatos = Modulo_MaterialesCentral.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'frm_Proveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 611)
        Me.Controls.Add(Me.Tab_Catalogo)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(900, 650)
        Me.Name = "frm_Proveedores"
        Me.Text = "Catalogo de Proveedores"
        Me.Tab_Catalogo.ResumeLayout(False)
        Me.tab_Listado.ResumeLayout(False)
        Me.tab_Listado.PerformLayout()
        Me.Tab_Nuevo.ResumeLayout(False)
        Me.Tab_Nuevo.PerformLayout()
        Me.gbx_Contactos.ResumeLayout(False)
        Me.gbx_Contactos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Tab_Catalogo As System.Windows.Forms.TabControl
    Friend WithEvents tab_Listado As System.Windows.Forms.TabPage
    Friend WithEvents Tab_Nuevo As System.Windows.Forms.TabPage
    Friend WithEvents Lbl_Buscar As System.Windows.Forms.Label
    Friend WithEvents lsv_Catalogo As Modulo_MaterialesCentral.cp_Listview
    Friend WithEvents BTN_Buscar As System.Windows.Forms.Button
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents BTN_Exportar As System.Windows.Forms.Button
    Friend WithEvents Btn_Baja As System.Windows.Forms.Button
    Friend WithEvents BTN_Modificar As System.Windows.Forms.Button
    Friend WithEvents tbx_NombreF As Modulo_MaterialesCentral.cp_Textbox
    Friend WithEvents lbl_NombreF As System.Windows.Forms.Label
    Friend WithEvents tbx_Clave As Modulo_MaterialesCentral.cp_Textbox
    Friend WithEvents lbl_Clave As System.Windows.Forms.Label
    Friend WithEvents btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents tbx_DireccionF As Modulo_MaterialesCentral.cp_Textbox
    Friend WithEvents lbl_DireccionF As System.Windows.Forms.Label
    Friend WithEvents lbl_CiudadF As System.Windows.Forms.Label
    Friend WithEvents cmb_CiudadF As Modulo_MaterialesCentral.cp_cmb_SimpleFiltradoParam
    Friend WithEvents tbx_RFC As Modulo_MaterialesCentral.cp_Textbox
    Friend WithEvents lbl_RFC As System.Windows.Forms.Label
    Friend WithEvents cmb_CiudadC As Modulo_MaterialesCentral.cp_cmb_SimpleFiltradoParam
    Friend WithEvents lbl_CiudadC As System.Windows.Forms.Label
    Friend WithEvents tbx_DireccionC As Modulo_MaterialesCentral.cp_Textbox
    Friend WithEvents lbl_DireccionC As System.Windows.Forms.Label
    Friend WithEvents tbx_NombreC As Modulo_MaterialesCentral.cp_Textbox
    Friend WithEvents lbl_NombreC As System.Windows.Forms.Label
    Friend WithEvents tbx_CorreoE As Modulo_MaterialesCentral.cp_Textbox
    Friend WithEvents lbl_CorreoE As System.Windows.Forms.Label
    Friend WithEvents tbx_Fax As Modulo_MaterialesCentral.cp_Textbox
    Friend WithEvents lbl_Fax As System.Windows.Forms.Label
    Friend WithEvents tbx_Telefono As Modulo_MaterialesCentral.cp_Textbox
    Friend WithEvents lbl_Telefono As System.Windows.Forms.Label
    Friend WithEvents tbx_Contacto As Modulo_MaterialesCentral.cp_Textbox
    Friend WithEvents lbl_Contacto As System.Windows.Forms.Label
    Friend WithEvents tbx_Observaciones As Modulo_MaterialesCentral.cp_Textbox
    Friend WithEvents lbl_Observaciones As System.Windows.Forms.Label
    Friend WithEvents tbx_Retencion As Modulo_MaterialesCentral.cp_Textbox
    Friend WithEvents Lbl_Retencion As System.Windows.Forms.Label
    Friend WithEvents tbx_IVA As Modulo_MaterialesCentral.cp_Textbox
    Friend WithEvents Lbl_IVA As System.Windows.Forms.Label
    Friend WithEvents tbx_Buscar As Modulo_MaterialesCentral.cp_Textbox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents tbx_ColoniaC As Modulo_MaterialesCentral.cp_Textbox
    Friend WithEvents Lbl_Col As System.Windows.Forms.Label
    Friend WithEvents tbx_NumeroIC As Modulo_MaterialesCentral.cp_Textbox
    Friend WithEvents Lbl_NumInt As System.Windows.Forms.Label
    Friend WithEvents tbx_NumeroEC As Modulo_MaterialesCentral.cp_Textbox
    Friend WithEvents Lbl_NumExt As System.Windows.Forms.Label
    Friend WithEvents tbx_ColoniaF As Modulo_MaterialesCentral.cp_Textbox
    Friend WithEvents Lbl_Colonia As System.Windows.Forms.Label
    Friend WithEvents tbx_NumeroIF As Modulo_MaterialesCentral.cp_Textbox
    Friend WithEvents Lbl_NInt As System.Windows.Forms.Label
    Friend WithEvents tbx_NumeroEF As Modulo_MaterialesCentral.cp_Textbox
    Friend WithEvents Lbl_NExterior As System.Windows.Forms.Label
    Friend WithEvents Lbl_DiasCredito As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents tbx_Dias As Modulo_MaterialesCentral.cp_Textbox
    Friend WithEvents Lbl_ContactosProv As System.Windows.Forms.Label
    Friend WithEvents lsv_Contactos As Modulo_MaterialesCentral.cp_Listview
    Friend WithEvents gbx_Contactos As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_ContactosAgregar As Modulo_MaterialesCentral.cp_Listview
    Friend WithEvents btn_Eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_Agregar As System.Windows.Forms.Button
    Friend WithEvents tbx_Nombre As Modulo_MaterialesCentral.cp_Textbox
    Friend WithEvents lbl_Nombre As System.Windows.Forms.Label
    Friend WithEvents tbx_Puesto As Modulo_MaterialesCentral.cp_Textbox
    Friend WithEvents Lbl_Puesto As System.Windows.Forms.Label
    Friend WithEvents tbx_TelMovil As Modulo_MaterialesCentral.cp_Textbox
    Friend WithEvents Lbl_TelMov As System.Windows.Forms.Label
    Friend WithEvents tbx_Mail As Modulo_MaterialesCentral.cp_Textbox
    Friend WithEvents Lbl_Mail As System.Windows.Forms.Label
    Friend WithEvents tbx_TelFijo As Modulo_MaterialesCentral.cp_Textbox
    Friend WithEvents Lbl_TelFijo As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Lbl_Registros As System.Windows.Forms.Label
    Friend WithEvents cmb_Status As Modulo_MaterialesCentral.cp_cmb_Manual
    Friend WithEvents chk_Todos As System.Windows.Forms.CheckBox
    Friend WithEvents Lbl_Status As System.Windows.Forms.Label
    Friend WithEvents btn_Mostrar As System.Windows.Forms.Button
End Class
