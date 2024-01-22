<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Compras
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Compras))
        Dim ListViewColumnSorter1 As Modulo_MaterialesCentral.ListViewColumnSorter = New Modulo_MaterialesCentral.ListViewColumnSorter
        Me.grbMenu = New System.Windows.Forms.GroupBox
        Me.Lbl_Moneda = New System.Windows.Forms.Label
        Me.cmb_Moneda = New Modulo_MaterialesCentral.cp_cmb_SimpleFiltradoParam
        Me.tbx_Descripcion = New Modulo_MaterialesCentral.cp_Textbox
        Me.tbx_Cantidad = New Modulo_MaterialesCentral.cp_Textbox
        Me.cmb_Unidad = New Modulo_MaterialesCentral.cp_cmb_Manual
        Me.tbx_Precio = New Modulo_MaterialesCentral.cp_Textbox
        Me.cmb_TipoEntidad = New Modulo_MaterialesCentral.cp_cmb_Manual
        Me.cmb_Entidad = New Modulo_MaterialesCentral.cp_cmb_SimpleFiltradoParam
        Me.btn_Agregar = New System.Windows.Forms.Button
        Me.tbx_Atencion = New Modulo_MaterialesCentral.cp_Textbox
        Me.Lbl_AtencionA = New System.Windows.Forms.Label
        Me.Gbx_TipoO = New System.Windows.Forms.GroupBox
        Me.rdb_Abierto = New System.Windows.Forms.RadioButton
        Me.rdb_Material = New System.Windows.Forms.RadioButton
        Me.Lbl_TipoOrden = New System.Windows.Forms.Label
        Me.cmb_Proveedor = New Modulo_MaterialesCentral.cp_cmb_SimpleFiltradoParam
        Me.tbx_ClaveProveedor = New Modulo_MaterialesCentral.cp_Textbox
        Me.lbl_Proveedor = New System.Windows.Forms.Label
        Me.chk_Entidad = New System.Windows.Forms.CheckBox
        Me.Lbl_TipoEntidad = New System.Windows.Forms.Label
        Me.Lbl_Entidad = New System.Windows.Forms.Label
        Me.lbl_Precio = New System.Windows.Forms.Label
        Me.lbl_Cantidad = New System.Windows.Forms.Label
        Me.lbl_Descripcion = New System.Windows.Forms.Label
        Me.lbl_Material = New System.Windows.Forms.Label
        Me.Gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_Guardar = New System.Windows.Forms.Button
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.btn_Borrar = New System.Windows.Forms.Button
        Me.Lbl_SubTotal = New System.Windows.Forms.Label
        Me.Lbl_IVA = New System.Windows.Forms.Label
        Me.Lbl_Total = New System.Windows.Forms.Label
        Me.Gbx_Listado = New System.Windows.Forms.GroupBox
        Me.lbl_Porcentaje = New System.Windows.Forms.Label
        Me.Lsv_Ventas = New Modulo_MaterialesCentral.cp_Listview
        Me.tbx_Total = New Modulo_MaterialesCentral.cp_Textbox
        Me.tbx_SubTotal = New Modulo_MaterialesCentral.cp_Textbox
        Me.Label6 = New System.Windows.Forms.Label
        Me.tbx_IVA = New Modulo_MaterialesCentral.cp_Textbox
        Me.cmb_Material = New Modulo_MaterialesCentral.cp_cmb_SimpleFiltradoParam
        Me.tbx_ClaveMaterial = New Modulo_MaterialesCentral.cp_Textbox
        Me.Gbx_Observaciones = New System.Windows.Forms.GroupBox
        Me.rtb_Observaciones = New System.Windows.Forms.RichTextBox
        Me.btn_CondicionesPago = New System.Windows.Forms.Button
        Me.grbMenu.SuspendLayout()
        Me.Gbx_TipoO.SuspendLayout()
        Me.Gbx_Botones.SuspendLayout()
        Me.Gbx_Listado.SuspendLayout()
        Me.Gbx_Observaciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbMenu
        '
        Me.grbMenu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grbMenu.Controls.Add(Me.btn_CondicionesPago)
        Me.grbMenu.Controls.Add(Me.Lbl_Moneda)
        Me.grbMenu.Controls.Add(Me.cmb_Moneda)
        Me.grbMenu.Controls.Add(Me.tbx_Atencion)
        Me.grbMenu.Controls.Add(Me.Lbl_AtencionA)
        Me.grbMenu.Controls.Add(Me.Gbx_TipoO)
        Me.grbMenu.Controls.Add(Me.Lbl_TipoOrden)
        Me.grbMenu.Controls.Add(Me.cmb_Proveedor)
        Me.grbMenu.Controls.Add(Me.lbl_Proveedor)
        Me.grbMenu.Controls.Add(Me.tbx_ClaveProveedor)
        Me.grbMenu.Location = New System.Drawing.Point(4, 1)
        Me.grbMenu.Name = "grbMenu"
        Me.grbMenu.Size = New System.Drawing.Size(776, 112)
        Me.grbMenu.TabIndex = 0
        Me.grbMenu.TabStop = False
        '
        'Lbl_Moneda
        '
        Me.Lbl_Moneda.AutoSize = True
        Me.Lbl_Moneda.Location = New System.Drawing.Point(299, 80)
        Me.Lbl_Moneda.Name = "Lbl_Moneda"
        Me.Lbl_Moneda.Size = New System.Drawing.Size(46, 13)
        Me.Lbl_Moneda.TabIndex = 7
        Me.Lbl_Moneda.Text = "Moneda"
        '
        'cmb_Moneda
        '
        Me.cmb_Moneda.Clave = ""
        Me.cmb_Moneda.Control_Siguiente = Me.tbx_Descripcion
        Me.cmb_Moneda.DisplayMember = "Nombre"
        Me.cmb_Moneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Moneda.Empresa = False
        Me.cmb_Moneda.Filtro = Nothing
        Me.cmb_Moneda.FormattingEnabled = True
        Me.cmb_Moneda.Location = New System.Drawing.Point(351, 75)
        Me.cmb_Moneda.MaxDropDownItems = 20
        Me.cmb_Moneda.Name = "cmb_Moneda"
        Me.cmb_Moneda.Pista = False
        Me.cmb_Moneda.Size = New System.Drawing.Size(241, 21)
        Me.cmb_Moneda.StoredProcedure = "Cat_Monedas_ComboGet"
        Me.cmb_Moneda.Sucursal = False
        Me.cmb_Moneda.TabIndex = 8
        Me.cmb_Moneda.Tipo = 0
        Me.cmb_Moneda.ValueMember = "Id_Moneda"
        '
        'tbx_Descripcion
        '
        Me.tbx_Descripcion.Control_Siguiente = Me.tbx_Cantidad
        Me.tbx_Descripcion.Filtrado = True
        Me.tbx_Descripcion.Location = New System.Drawing.Point(105, 19)
        Me.tbx_Descripcion.MaxLength = 400
        Me.tbx_Descripcion.Name = "tbx_Descripcion"
        Me.tbx_Descripcion.Size = New System.Drawing.Size(487, 20)
        Me.tbx_Descripcion.TabIndex = 2
        Me.tbx_Descripcion.TipoDatos = Modulo_MaterialesCentral.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        Me.tbx_Descripcion.Visible = False
        '
        'tbx_Cantidad
        '
        Me.tbx_Cantidad.Control_Siguiente = Me.cmb_Unidad
        Me.tbx_Cantidad.Filtrado = True
        Me.tbx_Cantidad.Location = New System.Drawing.Point(105, 45)
        Me.tbx_Cantidad.MaxLength = 10
        Me.tbx_Cantidad.Name = "tbx_Cantidad"
        Me.tbx_Cantidad.Size = New System.Drawing.Size(67, 20)
        Me.tbx_Cantidad.TabIndex = 6
        Me.tbx_Cantidad.TipoDatos = Modulo_MaterialesCentral.FuncionesGlobales.Validar_Cadena.Numeros_Decimales
        '
        'cmb_Unidad
        '
        Me.cmb_Unidad.Control_Siguiente = Me.tbx_Precio
        Me.cmb_Unidad.DisplayMember = "display"
        Me.cmb_Unidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Unidad.FormattingEnabled = True
        Me.cmb_Unidad.Location = New System.Drawing.Point(228, 45)
        Me.cmb_Unidad.MaxDropDownItems = 20
        Me.cmb_Unidad.Name = "cmb_Unidad"
        Me.cmb_Unidad.Size = New System.Drawing.Size(86, 21)
        Me.cmb_Unidad.TabIndex = 8
        Me.cmb_Unidad.ValueMember = "value"
        '
        'tbx_Precio
        '
        Me.tbx_Precio.Control_Siguiente = Me.cmb_TipoEntidad
        Me.tbx_Precio.Filtrado = True
        Me.tbx_Precio.Location = New System.Drawing.Point(377, 45)
        Me.tbx_Precio.MaxLength = 10
        Me.tbx_Precio.Name = "tbx_Precio"
        Me.tbx_Precio.Size = New System.Drawing.Size(67, 20)
        Me.tbx_Precio.TabIndex = 10
        Me.tbx_Precio.TipoDatos = Modulo_MaterialesCentral.FuncionesGlobales.Validar_Cadena.Numeros_Decimales
        '
        'cmb_TipoEntidad
        '
        Me.cmb_TipoEntidad.Control_Siguiente = Me.cmb_Entidad
        Me.cmb_TipoEntidad.DisplayMember = "display"
        Me.cmb_TipoEntidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_TipoEntidad.FormattingEnabled = True
        Me.cmb_TipoEntidad.Location = New System.Drawing.Point(105, 72)
        Me.cmb_TipoEntidad.MaxDropDownItems = 20
        Me.cmb_TipoEntidad.Name = "cmb_TipoEntidad"
        Me.cmb_TipoEntidad.Size = New System.Drawing.Size(209, 21)
        Me.cmb_TipoEntidad.TabIndex = 12
        Me.cmb_TipoEntidad.ValueMember = "value"
        '
        'cmb_Entidad
        '
        Me.cmb_Entidad.Clave = "Clave_Proveedor"
        Me.cmb_Entidad.Control_Siguiente = Me.btn_Agregar
        Me.cmb_Entidad.DisplayMember = "Nombre_Comercial"
        Me.cmb_Entidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Entidad.Empresa = True
        Me.cmb_Entidad.Enabled = False
        Me.cmb_Entidad.Filtro = Nothing
        Me.cmb_Entidad.FormattingEnabled = True
        Me.cmb_Entidad.Location = New System.Drawing.Point(105, 99)
        Me.cmb_Entidad.MaxDropDownItems = 20
        Me.cmb_Entidad.Name = "cmb_Entidad"
        Me.cmb_Entidad.Pista = False
        Me.cmb_Entidad.Size = New System.Drawing.Size(487, 21)
        Me.cmb_Entidad.StoredProcedure = "Cat_Proveedores_ComboGet"
        Me.cmb_Entidad.Sucursal = False
        Me.cmb_Entidad.TabIndex = 15
        Me.cmb_Entidad.Tipo = 0
        Me.cmb_Entidad.ValueMember = "Id_Proveedor"
        '
        'btn_Agregar
        '
        Me.btn_Agregar.Image = Global.Modulo_MaterialesCentral.My.Resources.Resources.Agregar
        Me.btn_Agregar.Location = New System.Drawing.Point(105, 124)
        Me.btn_Agregar.Name = "btn_Agregar"
        Me.btn_Agregar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Agregar.TabIndex = 16
        Me.btn_Agregar.Text = "&Agregar"
        Me.btn_Agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Agregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Agregar.UseVisualStyleBackColor = True
        '
        'tbx_Atencion
        '
        Me.tbx_Atencion.Control_Siguiente = Me.cmb_Moneda
        Me.tbx_Atencion.Filtrado = True
        Me.tbx_Atencion.Location = New System.Drawing.Point(105, 45)
        Me.tbx_Atencion.MaxLength = 100
        Me.tbx_Atencion.Name = "tbx_Atencion"
        Me.tbx_Atencion.Size = New System.Drawing.Size(487, 20)
        Me.tbx_Atencion.TabIndex = 4
        Me.tbx_Atencion.TipoDatos = Modulo_MaterialesCentral.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'Lbl_AtencionA
        '
        Me.Lbl_AtencionA.AutoSize = True
        Me.Lbl_AtencionA.Location = New System.Drawing.Point(40, 48)
        Me.Lbl_AtencionA.Name = "Lbl_AtencionA"
        Me.Lbl_AtencionA.Size = New System.Drawing.Size(59, 13)
        Me.Lbl_AtencionA.TabIndex = 3
        Me.Lbl_AtencionA.Text = "Atención A"
        '
        'Gbx_TipoO
        '
        Me.Gbx_TipoO.Controls.Add(Me.rdb_Abierto)
        Me.Gbx_TipoO.Controls.Add(Me.rdb_Material)
        Me.Gbx_TipoO.Location = New System.Drawing.Point(105, 67)
        Me.Gbx_TipoO.Name = "Gbx_TipoO"
        Me.Gbx_TipoO.Size = New System.Drawing.Size(151, 30)
        Me.Gbx_TipoO.TabIndex = 6
        Me.Gbx_TipoO.TabStop = False
        '
        'rdb_Abierto
        '
        Me.rdb_Abierto.AutoSize = True
        Me.rdb_Abierto.Location = New System.Drawing.Point(83, 9)
        Me.rdb_Abierto.Name = "rdb_Abierto"
        Me.rdb_Abierto.Size = New System.Drawing.Size(58, 17)
        Me.rdb_Abierto.TabIndex = 1
        Me.rdb_Abierto.TabStop = True
        Me.rdb_Abierto.Text = "Abierta"
        Me.rdb_Abierto.UseVisualStyleBackColor = True
        '
        'rdb_Material
        '
        Me.rdb_Material.AutoSize = True
        Me.rdb_Material.Location = New System.Drawing.Point(6, 9)
        Me.rdb_Material.Name = "rdb_Material"
        Me.rdb_Material.Size = New System.Drawing.Size(62, 17)
        Me.rdb_Material.TabIndex = 0
        Me.rdb_Material.TabStop = True
        Me.rdb_Material.Text = "Material"
        Me.rdb_Material.UseVisualStyleBackColor = True
        '
        'Lbl_TipoOrden
        '
        Me.Lbl_TipoOrden.AutoSize = True
        Me.Lbl_TipoOrden.Location = New System.Drawing.Point(24, 78)
        Me.Lbl_TipoOrden.Name = "Lbl_TipoOrden"
        Me.Lbl_TipoOrden.Size = New System.Drawing.Size(75, 13)
        Me.Lbl_TipoOrden.TabIndex = 5
        Me.Lbl_TipoOrden.Text = "Tipo de Orden"
        '
        'cmb_Proveedor
        '
        Me.cmb_Proveedor.Clave = "Clave_Proveedor"
        Me.cmb_Proveedor.Control_Siguiente = Me.tbx_Atencion
        Me.cmb_Proveedor.DisplayMember = "Nombre_Comercial"
        Me.cmb_Proveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Proveedor.Empresa = True
        Me.cmb_Proveedor.Filtro = Me.tbx_ClaveProveedor
        Me.cmb_Proveedor.FormattingEnabled = True
        Me.cmb_Proveedor.Location = New System.Drawing.Point(161, 19)
        Me.cmb_Proveedor.MaxDropDownItems = 20
        Me.cmb_Proveedor.Name = "cmb_Proveedor"
        Me.cmb_Proveedor.Pista = False
        Me.cmb_Proveedor.Size = New System.Drawing.Size(431, 21)
        Me.cmb_Proveedor.StoredProcedure = "Cat_Proveedores_ComboGet"
        Me.cmb_Proveedor.Sucursal = False
        Me.cmb_Proveedor.TabIndex = 2
        Me.cmb_Proveedor.Tipo = 0
        Me.cmb_Proveedor.ValueMember = "Id_Proveedor"
        '
        'tbx_ClaveProveedor
        '
        Me.tbx_ClaveProveedor.Control_Siguiente = Me.cmb_Proveedor
        Me.tbx_ClaveProveedor.Filtrado = True
        Me.tbx_ClaveProveedor.Location = New System.Drawing.Point(105, 19)
        Me.tbx_ClaveProveedor.MaxLength = 6
        Me.tbx_ClaveProveedor.Name = "tbx_ClaveProveedor"
        Me.tbx_ClaveProveedor.Size = New System.Drawing.Size(50, 20)
        Me.tbx_ClaveProveedor.TabIndex = 1
        Me.tbx_ClaveProveedor.TipoDatos = Modulo_MaterialesCentral.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'lbl_Proveedor
        '
        Me.lbl_Proveedor.AutoSize = True
        Me.lbl_Proveedor.Location = New System.Drawing.Point(43, 22)
        Me.lbl_Proveedor.Name = "lbl_Proveedor"
        Me.lbl_Proveedor.Size = New System.Drawing.Size(56, 13)
        Me.lbl_Proveedor.TabIndex = 0
        Me.lbl_Proveedor.Text = "Proveedor"
        '
        'chk_Entidad
        '
        Me.chk_Entidad.AutoSize = True
        Me.chk_Entidad.Location = New System.Drawing.Point(326, 76)
        Me.chk_Entidad.Name = "chk_Entidad"
        Me.chk_Entidad.Size = New System.Drawing.Size(72, 17)
        Me.chk_Entidad.TabIndex = 13
        Me.chk_Entidad.Text = "No Aplica"
        Me.chk_Entidad.UseVisualStyleBackColor = True
        '
        'Lbl_TipoEntidad
        '
        Me.Lbl_TipoEntidad.AutoSize = True
        Me.Lbl_TipoEntidad.Location = New System.Drawing.Point(32, 77)
        Me.Lbl_TipoEntidad.Name = "Lbl_TipoEntidad"
        Me.Lbl_TipoEntidad.Size = New System.Drawing.Size(67, 13)
        Me.Lbl_TipoEntidad.TabIndex = 11
        Me.Lbl_TipoEntidad.Text = "Tipo Entidad"
        '
        'Lbl_Entidad
        '
        Me.Lbl_Entidad.AutoSize = True
        Me.Lbl_Entidad.Location = New System.Drawing.Point(56, 102)
        Me.Lbl_Entidad.Name = "Lbl_Entidad"
        Me.Lbl_Entidad.Size = New System.Drawing.Size(43, 13)
        Me.Lbl_Entidad.TabIndex = 14
        Me.Lbl_Entidad.Text = "Entidad"
        '
        'lbl_Precio
        '
        Me.lbl_Precio.AutoSize = True
        Me.lbl_Precio.Location = New System.Drawing.Point(331, 48)
        Me.lbl_Precio.Name = "lbl_Precio"
        Me.lbl_Precio.Size = New System.Drawing.Size(37, 13)
        Me.lbl_Precio.TabIndex = 9
        Me.lbl_Precio.Text = "Precio"
        '
        'lbl_Cantidad
        '
        Me.lbl_Cantidad.AutoSize = True
        Me.lbl_Cantidad.Location = New System.Drawing.Point(50, 48)
        Me.lbl_Cantidad.Name = "lbl_Cantidad"
        Me.lbl_Cantidad.Size = New System.Drawing.Size(49, 13)
        Me.lbl_Cantidad.TabIndex = 5
        Me.lbl_Cantidad.Text = "Cantidad"
        '
        'lbl_Descripcion
        '
        Me.lbl_Descripcion.AutoSize = True
        Me.lbl_Descripcion.Location = New System.Drawing.Point(36, 22)
        Me.lbl_Descripcion.Name = "lbl_Descripcion"
        Me.lbl_Descripcion.Size = New System.Drawing.Size(63, 13)
        Me.lbl_Descripcion.TabIndex = 0
        Me.lbl_Descripcion.Text = "Descripción"
        Me.lbl_Descripcion.Visible = False
        '
        'lbl_Material
        '
        Me.lbl_Material.AutoSize = True
        Me.lbl_Material.Location = New System.Drawing.Point(55, 23)
        Me.lbl_Material.Name = "lbl_Material"
        Me.lbl_Material.Size = New System.Drawing.Size(44, 13)
        Me.lbl_Material.TabIndex = 1
        Me.lbl_Material.Text = "Material"
        '
        'Gbx_Botones
        '
        Me.Gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Botones.Controls.Add(Me.btn_Guardar)
        Me.Gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.Gbx_Botones.Location = New System.Drawing.Point(4, 507)
        Me.Gbx_Botones.Name = "Gbx_Botones"
        Me.Gbx_Botones.Size = New System.Drawing.Size(776, 50)
        Me.Gbx_Botones.TabIndex = 3
        Me.Gbx_Botones.TabStop = False
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Guardar.Image = Global.Modulo_MaterialesCentral.My.Resources.Resources.Guardar
        Me.btn_Guardar.Location = New System.Drawing.Point(6, 14)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Guardar.TabIndex = 0
        Me.btn_Guardar.Text = "&Guardar"
        Me.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_MaterialesCentral.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(630, 14)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 2
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'btn_Borrar
        '
        Me.btn_Borrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Borrar.Enabled = False
        Me.btn_Borrar.Image = Global.Modulo_MaterialesCentral.My.Resources.Resources.Baja
        Me.btn_Borrar.Location = New System.Drawing.Point(6, 238)
        Me.btn_Borrar.Name = "btn_Borrar"
        Me.btn_Borrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Borrar.TabIndex = 18
        Me.btn_Borrar.Text = "&Borrar"
        Me.btn_Borrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Borrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Borrar.UseVisualStyleBackColor = True
        '
        'Lbl_SubTotal
        '
        Me.Lbl_SubTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_SubTotal.AutoSize = True
        Me.Lbl_SubTotal.Location = New System.Drawing.Point(554, 241)
        Me.Lbl_SubTotal.Name = "Lbl_SubTotal"
        Me.Lbl_SubTotal.Size = New System.Drawing.Size(50, 13)
        Me.Lbl_SubTotal.TabIndex = 19
        Me.Lbl_SubTotal.Text = "SubTotal"
        '
        'Lbl_IVA
        '
        Me.Lbl_IVA.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_IVA.AutoSize = True
        Me.Lbl_IVA.Location = New System.Drawing.Point(580, 264)
        Me.Lbl_IVA.Name = "Lbl_IVA"
        Me.Lbl_IVA.Size = New System.Drawing.Size(24, 13)
        Me.Lbl_IVA.TabIndex = 22
        Me.Lbl_IVA.Text = "IVA"
        '
        'Lbl_Total
        '
        Me.Lbl_Total.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Total.AutoSize = True
        Me.Lbl_Total.Location = New System.Drawing.Point(573, 287)
        Me.Lbl_Total.Name = "Lbl_Total"
        Me.Lbl_Total.Size = New System.Drawing.Size(31, 13)
        Me.Lbl_Total.TabIndex = 24
        Me.Lbl_Total.Text = "Total"
        '
        'Gbx_Listado
        '
        Me.Gbx_Listado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Listado.Controls.Add(Me.cmb_Unidad)
        Me.Gbx_Listado.Controls.Add(Me.lbl_Porcentaje)
        Me.Gbx_Listado.Controls.Add(Me.btn_Borrar)
        Me.Gbx_Listado.Controls.Add(Me.Lsv_Ventas)
        Me.Gbx_Listado.Controls.Add(Me.chk_Entidad)
        Me.Gbx_Listado.Controls.Add(Me.tbx_Total)
        Me.Gbx_Listado.Controls.Add(Me.Lbl_TipoEntidad)
        Me.Gbx_Listado.Controls.Add(Me.tbx_Descripcion)
        Me.Gbx_Listado.Controls.Add(Me.lbl_Precio)
        Me.Gbx_Listado.Controls.Add(Me.tbx_SubTotal)
        Me.Gbx_Listado.Controls.Add(Me.tbx_Precio)
        Me.Gbx_Listado.Controls.Add(Me.cmb_TipoEntidad)
        Me.Gbx_Listado.Controls.Add(Me.Label6)
        Me.Gbx_Listado.Controls.Add(Me.cmb_Entidad)
        Me.Gbx_Listado.Controls.Add(Me.lbl_Cantidad)
        Me.Gbx_Listado.Controls.Add(Me.tbx_IVA)
        Me.Gbx_Listado.Controls.Add(Me.tbx_Cantidad)
        Me.Gbx_Listado.Controls.Add(Me.Lbl_Entidad)
        Me.Gbx_Listado.Controls.Add(Me.cmb_Material)
        Me.Gbx_Listado.Controls.Add(Me.Lbl_Total)
        Me.Gbx_Listado.Controls.Add(Me.Lbl_IVA)
        Me.Gbx_Listado.Controls.Add(Me.lbl_Descripcion)
        Me.Gbx_Listado.Controls.Add(Me.Lbl_SubTotal)
        Me.Gbx_Listado.Controls.Add(Me.lbl_Material)
        Me.Gbx_Listado.Controls.Add(Me.btn_Agregar)
        Me.Gbx_Listado.Controls.Add(Me.tbx_ClaveMaterial)
        Me.Gbx_Listado.Location = New System.Drawing.Point(4, 119)
        Me.Gbx_Listado.Name = "Gbx_Listado"
        Me.Gbx_Listado.Size = New System.Drawing.Size(776, 308)
        Me.Gbx_Listado.TabIndex = 1
        Me.Gbx_Listado.TabStop = False
        '
        'lbl_Porcentaje
        '
        Me.lbl_Porcentaje.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Porcentaje.Location = New System.Drawing.Point(519, 264)
        Me.lbl_Porcentaje.Name = "lbl_Porcentaje"
        Me.lbl_Porcentaje.Size = New System.Drawing.Size(57, 13)
        Me.lbl_Porcentaje.TabIndex = 21
        Me.lbl_Porcentaje.Text = "0%"
        Me.lbl_Porcentaje.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lsv_Ventas
        '
        Me.Lsv_Ventas.AllowColumnReorder = True
        Me.Lsv_Ventas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lsv_Ventas.FullRowSelect = True
        Me.Lsv_Ventas.HideSelection = False
        Me.Lsv_Ventas.Location = New System.Drawing.Point(3, 160)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.Lsv_Ventas.Lvs = ListViewColumnSorter1
        Me.Lsv_Ventas.MultiSelect = False
        Me.Lsv_Ventas.Name = "Lsv_Ventas"
        Me.Lsv_Ventas.Ocultar = ""
        Me.Lsv_Ventas.Row1 = 10
        Me.Lsv_Ventas.Row10 = 0
        Me.Lsv_Ventas.Row2 = 25
        Me.Lsv_Ventas.Row3 = 10
        Me.Lsv_Ventas.Row4 = 10
        Me.Lsv_Ventas.Row5 = 10
        Me.Lsv_Ventas.Row6 = 10
        Me.Lsv_Ventas.Row7 = 10
        Me.Lsv_Ventas.Row8 = 10
        Me.Lsv_Ventas.Row9 = 0
        Me.Lsv_Ventas.Size = New System.Drawing.Size(767, 75)
        Me.Lsv_Ventas.TabIndex = 17
        Me.Lsv_Ventas.TabStop = False
        Me.Lsv_Ventas.UseCompatibleStateImageBehavior = False
        Me.Lsv_Ventas.View = System.Windows.Forms.View.Details
        '
        'tbx_Total
        '
        Me.tbx_Total.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbx_Total.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_Total.Control_Siguiente = Nothing
        Me.tbx_Total.Filtrado = True
        Me.tbx_Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_Total.Location = New System.Drawing.Point(610, 284)
        Me.tbx_Total.MaxLength = 20
        Me.tbx_Total.Name = "tbx_Total"
        Me.tbx_Total.ReadOnly = True
        Me.tbx_Total.Size = New System.Drawing.Size(160, 20)
        Me.tbx_Total.TabIndex = 25
        Me.tbx_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbx_Total.TipoDatos = Modulo_MaterialesCentral.FuncionesGlobales.Validar_Cadena.Numeros_Decimales
        '
        'tbx_SubTotal
        '
        Me.tbx_SubTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbx_SubTotal.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_SubTotal.Control_Siguiente = Nothing
        Me.tbx_SubTotal.Filtrado = True
        Me.tbx_SubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_SubTotal.Location = New System.Drawing.Point(610, 238)
        Me.tbx_SubTotal.MaxLength = 20
        Me.tbx_SubTotal.Name = "tbx_SubTotal"
        Me.tbx_SubTotal.ReadOnly = True
        Me.tbx_SubTotal.Size = New System.Drawing.Size(160, 20)
        Me.tbx_SubTotal.TabIndex = 20
        Me.tbx_SubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbx_SubTotal.TipoDatos = Modulo_MaterialesCentral.FuncionesGlobales.Validar_Cadena.Numeros_Decimales
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(184, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Unidad"
        '
        'tbx_IVA
        '
        Me.tbx_IVA.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbx_IVA.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_IVA.Control_Siguiente = Nothing
        Me.tbx_IVA.Filtrado = True
        Me.tbx_IVA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_IVA.Location = New System.Drawing.Point(610, 261)
        Me.tbx_IVA.MaxLength = 20
        Me.tbx_IVA.Name = "tbx_IVA"
        Me.tbx_IVA.ReadOnly = True
        Me.tbx_IVA.Size = New System.Drawing.Size(160, 20)
        Me.tbx_IVA.TabIndex = 23
        Me.tbx_IVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbx_IVA.TipoDatos = Modulo_MaterialesCentral.FuncionesGlobales.Validar_Cadena.Numeros_Decimales
        '
        'cmb_Material
        '
        Me.cmb_Material.Clave = "Clave"
        Me.cmb_Material.Control_Siguiente = Me.tbx_Cantidad
        Me.cmb_Material.DisplayMember = "Descripcion"
        Me.cmb_Material.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Material.Empresa = False
        Me.cmb_Material.Enabled = False
        Me.cmb_Material.Filtro = Me.tbx_ClaveMaterial
        Me.cmb_Material.FormattingEnabled = True
        Me.cmb_Material.Location = New System.Drawing.Point(161, 19)
        Me.cmb_Material.MaxDropDownItems = 20
        Me.cmb_Material.Name = "cmb_Material"
        Me.cmb_Material.Pista = False
        Me.cmb_Material.Size = New System.Drawing.Size(395, 21)
        Me.cmb_Material.StoredProcedure = "Mat_Inventario_Get"
        Me.cmb_Material.Sucursal = True
        Me.cmb_Material.TabIndex = 4
        Me.cmb_Material.Tipo = 0
        Me.cmb_Material.ValueMember = "Id_Inventario"
        '
        'tbx_ClaveMaterial
        '
        Me.tbx_ClaveMaterial.Control_Siguiente = Me.cmb_Material
        Me.tbx_ClaveMaterial.Enabled = False
        Me.tbx_ClaveMaterial.Filtrado = True
        Me.tbx_ClaveMaterial.Location = New System.Drawing.Point(105, 20)
        Me.tbx_ClaveMaterial.MaxLength = 4
        Me.tbx_ClaveMaterial.Name = "tbx_ClaveMaterial"
        Me.tbx_ClaveMaterial.Size = New System.Drawing.Size(50, 20)
        Me.tbx_ClaveMaterial.TabIndex = 3
        Me.tbx_ClaveMaterial.TipoDatos = Modulo_MaterialesCentral.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'Gbx_Observaciones
        '
        Me.Gbx_Observaciones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Observaciones.Controls.Add(Me.rtb_Observaciones)
        Me.Gbx_Observaciones.Location = New System.Drawing.Point(4, 427)
        Me.Gbx_Observaciones.Name = "Gbx_Observaciones"
        Me.Gbx_Observaciones.Size = New System.Drawing.Size(776, 80)
        Me.Gbx_Observaciones.TabIndex = 2
        Me.Gbx_Observaciones.TabStop = False
        Me.Gbx_Observaciones.Text = "Observaciones"
        '
        'rtb_Observaciones
        '
        Me.rtb_Observaciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtb_Observaciones.Location = New System.Drawing.Point(6, 19)
        Me.rtb_Observaciones.MaxLength = 400
        Me.rtb_Observaciones.Name = "rtb_Observaciones"
        Me.rtb_Observaciones.Size = New System.Drawing.Size(764, 55)
        Me.rtb_Observaciones.TabIndex = 0
        Me.rtb_Observaciones.Text = ""
        '
        'btn_CondicionesPago
        '
        Me.btn_CondicionesPago.Image = Global.Modulo_MaterialesCentral.My.Resources.Resources.ordenTrabajo
        Me.btn_CondicionesPago.Location = New System.Drawing.Point(598, 19)
        Me.btn_CondicionesPago.Name = "btn_CondicionesPago"
        Me.btn_CondicionesPago.Size = New System.Drawing.Size(170, 78)
        Me.btn_CondicionesPago.TabIndex = 18
        Me.btn_CondicionesPago.Text = "Domicilio de Entrega y Condiciones de Pago"
        Me.btn_CondicionesPago.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_CondicionesPago.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_CondicionesPago.UseVisualStyleBackColor = True
        '
        'frm_Compras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.Gbx_Observaciones)
        Me.Controls.Add(Me.Gbx_Listado)
        Me.Controls.Add(Me.Gbx_Botones)
        Me.Controls.Add(Me.grbMenu)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_Compras"
        Me.Text = "Orden de Compra"
        Me.grbMenu.ResumeLayout(False)
        Me.grbMenu.PerformLayout()
        Me.Gbx_TipoO.ResumeLayout(False)
        Me.Gbx_TipoO.PerformLayout()
        Me.Gbx_Botones.ResumeLayout(False)
        Me.Gbx_Listado.ResumeLayout(False)
        Me.Gbx_Listado.PerformLayout()
        Me.Gbx_Observaciones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents Lsv_Ventas As Modulo_MaterialesCentral.cp_Listview
    Friend WithEvents btn_Borrar As System.Windows.Forms.Button
    Friend WithEvents grbMenu As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Agregar As System.Windows.Forms.Button
    Friend WithEvents lbl_Cantidad As System.Windows.Forms.Label
    Friend WithEvents tbx_Cantidad As Modulo_MaterialesCentral.cp_Textbox
    Friend WithEvents cmb_Material As Modulo_MaterialesCentral.cp_cmb_SimpleFiltradoParam
    Friend WithEvents tbx_ClaveMaterial As Modulo_MaterialesCentral.cp_Textbox
    Friend WithEvents lbl_Material As System.Windows.Forms.Label
    Friend WithEvents cmb_Proveedor As Modulo_MaterialesCentral.cp_cmb_SimpleFiltradoParam
    Friend WithEvents lbl_Proveedor As System.Windows.Forms.Label
    Friend WithEvents Gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents tbx_ClaveProveedor As Modulo_MaterialesCentral.cp_Textbox
    Friend WithEvents lbl_Precio As System.Windows.Forms.Label
    Friend WithEvents tbx_Precio As Modulo_MaterialesCentral.cp_Textbox
    Friend WithEvents tbx_Descripcion As Modulo_MaterialesCentral.cp_Textbox
    Friend WithEvents Gbx_TipoO As System.Windows.Forms.GroupBox
    Friend WithEvents rdb_Abierto As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_Material As System.Windows.Forms.RadioButton
    Friend WithEvents Lbl_TipoOrden As System.Windows.Forms.Label
    Friend WithEvents Lbl_SubTotal As System.Windows.Forms.Label
    Friend WithEvents Lbl_IVA As System.Windows.Forms.Label
    Friend WithEvents Lbl_Total As System.Windows.Forms.Label
    Friend WithEvents tbx_SubTotal As Modulo_MaterialesCentral.cp_Textbox
    Friend WithEvents tbx_IVA As Modulo_MaterialesCentral.cp_Textbox
    Friend WithEvents tbx_Total As Modulo_MaterialesCentral.cp_Textbox
    Friend WithEvents Gbx_Listado As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Descripcion As System.Windows.Forms.Label
    Friend WithEvents lbl_Porcentaje As System.Windows.Forms.Label
    Friend WithEvents tbx_Atencion As Modulo_MaterialesCentral.cp_Textbox
    Friend WithEvents Lbl_AtencionA As System.Windows.Forms.Label
    Friend WithEvents Lbl_TipoEntidad As System.Windows.Forms.Label
    Friend WithEvents cmb_TipoEntidad As Modulo_MaterialesCentral.cp_cmb_Manual
    Friend WithEvents cmb_Entidad As Modulo_MaterialesCentral.cp_cmb_SimpleFiltradoParam
    Friend WithEvents Lbl_Entidad As System.Windows.Forms.Label
    Friend WithEvents Gbx_Observaciones As System.Windows.Forms.GroupBox
    Friend WithEvents rtb_Observaciones As System.Windows.Forms.RichTextBox
    Friend WithEvents chk_Entidad As System.Windows.Forms.CheckBox
    Friend WithEvents Lbl_Moneda As System.Windows.Forms.Label
    Friend WithEvents cmb_Moneda As Modulo_MaterialesCentral.cp_cmb_SimpleFiltradoParam
    Friend WithEvents cmb_Unidad As Modulo_MaterialesCentral.cp_cmb_Manual
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btn_CondicionesPago As System.Windows.Forms.Button
End Class
