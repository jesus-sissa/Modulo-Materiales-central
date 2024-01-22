<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ComprasValidar
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
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim ListViewColumnSorter1 As Modulo_MaterialesCentral.ListViewColumnSorter = New Modulo_MaterialesCentral.ListViewColumnSorter
        Me.gbx_Encabezado = New System.Windows.Forms.GroupBox
        Me.Lbl_Registros = New System.Windows.Forms.Label
        Me.gbx_Factura = New System.Windows.Forms.GroupBox
        Me.lbl_FechaFactura = New System.Windows.Forms.Label
        Me.lbl_ImporteFactura = New System.Windows.Forms.Label
        Me.dtp_FechaFactura = New System.Windows.Forms.DateTimePicker
        Me.lbl_FolioFactura = New System.Windows.Forms.Label
        Me.gbx_Detalle = New System.Windows.Forms.GroupBox
        Me.dgv_Detalle = New System.Windows.Forms.DataGridView
        Me.IdInventarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClaveDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PrecioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CantidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UnidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ImporteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CantidadSurtidaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PrecioSurtidoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ObservacionesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IDPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IDMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds = New Modulo_MaterialesCentral.ds
        Me.gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.btn_Validar = New System.Windows.Forms.Button
        Me.gbx_Filtro = New System.Windows.Forms.GroupBox
        Me.lbl_Proveedor = New System.Windows.Forms.Label
        Me.chk_Proveedores = New System.Windows.Forms.CheckBox
        Me.btn_Mostrar = New System.Windows.Forms.Button
        Me.Lbl_Hasta = New System.Windows.Forms.Label
        Me.Lbl_Desde = New System.Windows.Forms.Label
        Me.dtp_Hasta = New System.Windows.Forms.DateTimePicker
        Me.dtp_Desde = New System.Windows.Forms.DateTimePicker
        Me.cmb_Proveedor = New Modulo_MaterialesCentral.cp_cmb_SimpleFiltradoParam
        Me.tbx_ClaveProveedor = New Modulo_MaterialesCentral.cp_Textbox
        Me.tbx_ImporteFactura = New Modulo_MaterialesCentral.cp_Textbox
        Me.tbx_FolioFactura = New Modulo_MaterialesCentral.cp_Textbox
        Me.lsv_Compras = New Modulo_MaterialesCentral.cp_Listview
        Me.gbx_Encabezado.SuspendLayout()
        Me.gbx_Factura.SuspendLayout()
        Me.gbx_Detalle.SuspendLayout()
        CType(Me.dgv_Detalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbx_Botones.SuspendLayout()
        Me.gbx_Filtro.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_Encabezado
        '
        Me.gbx_Encabezado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Encabezado.Controls.Add(Me.Lbl_Registros)
        Me.gbx_Encabezado.Controls.Add(Me.lsv_Compras)
        Me.gbx_Encabezado.Location = New System.Drawing.Point(3, 88)
        Me.gbx_Encabezado.Name = "gbx_Encabezado"
        Me.gbx_Encabezado.Size = New System.Drawing.Size(777, 142)
        Me.gbx_Encabezado.TabIndex = 0
        Me.gbx_Encabezado.TabStop = False
        '
        'Lbl_Registros
        '
        Me.Lbl_Registros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Registros.Location = New System.Drawing.Point(631, 16)
        Me.Lbl_Registros.Name = "Lbl_Registros"
        Me.Lbl_Registros.Size = New System.Drawing.Size(140, 19)
        Me.Lbl_Registros.TabIndex = 4
        Me.Lbl_Registros.Text = "Registros: 0"
        Me.Lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'gbx_Factura
        '
        Me.gbx_Factura.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Factura.Controls.Add(Me.lbl_FechaFactura)
        Me.gbx_Factura.Controls.Add(Me.lbl_ImporteFactura)
        Me.gbx_Factura.Controls.Add(Me.dtp_FechaFactura)
        Me.gbx_Factura.Controls.Add(Me.tbx_ImporteFactura)
        Me.gbx_Factura.Controls.Add(Me.tbx_FolioFactura)
        Me.gbx_Factura.Controls.Add(Me.lbl_FolioFactura)
        Me.gbx_Factura.Location = New System.Drawing.Point(3, 236)
        Me.gbx_Factura.Name = "gbx_Factura"
        Me.gbx_Factura.Size = New System.Drawing.Size(777, 68)
        Me.gbx_Factura.TabIndex = 1
        Me.gbx_Factura.TabStop = False
        '
        'lbl_FechaFactura
        '
        Me.lbl_FechaFactura.AutoSize = True
        Me.lbl_FechaFactura.Location = New System.Drawing.Point(227, 16)
        Me.lbl_FechaFactura.Name = "lbl_FechaFactura"
        Me.lbl_FechaFactura.Size = New System.Drawing.Size(91, 13)
        Me.lbl_FechaFactura.TabIndex = 5
        Me.lbl_FechaFactura.Text = "Fecha de Factura"
        '
        'lbl_ImporteFactura
        '
        Me.lbl_ImporteFactura.AutoSize = True
        Me.lbl_ImporteFactura.Location = New System.Drawing.Point(9, 42)
        Me.lbl_ImporteFactura.Name = "lbl_ImporteFactura"
        Me.lbl_ImporteFactura.Size = New System.Drawing.Size(96, 13)
        Me.lbl_ImporteFactura.TabIndex = 4
        Me.lbl_ImporteFactura.Text = "Importe de Factura"
        '
        'dtp_FechaFactura
        '
        Me.dtp_FechaFactura.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaFactura.Location = New System.Drawing.Point(324, 12)
        Me.dtp_FechaFactura.Name = "dtp_FechaFactura"
        Me.dtp_FechaFactura.Size = New System.Drawing.Size(99, 20)
        Me.dtp_FechaFactura.TabIndex = 3
        '
        'lbl_FolioFactura
        '
        Me.lbl_FolioFactura.AutoSize = True
        Me.lbl_FolioFactura.Location = New System.Drawing.Point(22, 16)
        Me.lbl_FolioFactura.Name = "lbl_FolioFactura"
        Me.lbl_FolioFactura.Size = New System.Drawing.Size(83, 13)
        Me.lbl_FolioFactura.TabIndex = 0
        Me.lbl_FolioFactura.Text = "Folio de Factura"
        '
        'gbx_Detalle
        '
        Me.gbx_Detalle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Detalle.Controls.Add(Me.dgv_Detalle)
        Me.gbx_Detalle.Location = New System.Drawing.Point(3, 310)
        Me.gbx_Detalle.Name = "gbx_Detalle"
        Me.gbx_Detalle.Size = New System.Drawing.Size(777, 190)
        Me.gbx_Detalle.TabIndex = 2
        Me.gbx_Detalle.TabStop = False
        '
        'dgv_Detalle
        '
        Me.dgv_Detalle.AllowUserToAddRows = False
        Me.dgv_Detalle.AllowUserToDeleteRows = False
        Me.dgv_Detalle.AutoGenerateColumns = False
        Me.dgv_Detalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Detalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdInventarioDataGridViewTextBoxColumn, Me.ClaveDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.PrecioDataGridViewTextBoxColumn, Me.CantidadDataGridViewTextBoxColumn, Me.UnidadDataGridViewTextBoxColumn, Me.ImporteDataGridViewTextBoxColumn, Me.CantidadSurtidaDataGridViewTextBoxColumn, Me.PrecioSurtidoDataGridViewTextBoxColumn, Me.ObservacionesDataGridViewTextBoxColumn, Me.IDPDataGridViewTextBoxColumn, Me.IDMDataGridViewTextBoxColumn})
        Me.dgv_Detalle.DataMember = "Mat_ComprasD_Get"
        Me.dgv_Detalle.DataSource = Me.DsBindingSource
        Me.dgv_Detalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_Detalle.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgv_Detalle.Location = New System.Drawing.Point(3, 16)
        Me.dgv_Detalle.Name = "dgv_Detalle"
        Me.dgv_Detalle.Size = New System.Drawing.Size(771, 171)
        Me.dgv_Detalle.TabIndex = 0
        '
        'IdInventarioDataGridViewTextBoxColumn
        '
        Me.IdInventarioDataGridViewTextBoxColumn.DataPropertyName = "Id_Inventario"
        Me.IdInventarioDataGridViewTextBoxColumn.HeaderText = "Id_Inventario"
        Me.IdInventarioDataGridViewTextBoxColumn.Name = "IdInventarioDataGridViewTextBoxColumn"
        Me.IdInventarioDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdInventarioDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.IdInventarioDataGridViewTextBoxColumn.Visible = False
        Me.IdInventarioDataGridViewTextBoxColumn.Width = 5
        '
        'ClaveDataGridViewTextBoxColumn
        '
        Me.ClaveDataGridViewTextBoxColumn.DataPropertyName = "Clave"
        Me.ClaveDataGridViewTextBoxColumn.HeaderText = "Clave"
        Me.ClaveDataGridViewTextBoxColumn.Name = "ClaveDataGridViewTextBoxColumn"
        Me.ClaveDataGridViewTextBoxColumn.ReadOnly = True
        Me.ClaveDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ClaveDataGridViewTextBoxColumn.Width = 60
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescripcionDataGridViewTextBoxColumn.Width = 300
        '
        'PrecioDataGridViewTextBoxColumn
        '
        Me.PrecioDataGridViewTextBoxColumn.DataPropertyName = "Precio"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.PrecioDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.PrecioDataGridViewTextBoxColumn.HeaderText = "Precio"
        Me.PrecioDataGridViewTextBoxColumn.Name = "PrecioDataGridViewTextBoxColumn"
        Me.PrecioDataGridViewTextBoxColumn.ReadOnly = True
        Me.PrecioDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'CantidadDataGridViewTextBoxColumn
        '
        Me.CantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.CantidadDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.CantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.Name = "CantidadDataGridViewTextBoxColumn"
        Me.CantidadDataGridViewTextBoxColumn.ReadOnly = True
        Me.CantidadDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CantidadDataGridViewTextBoxColumn.Width = 70
        '
        'UnidadDataGridViewTextBoxColumn
        '
        Me.UnidadDataGridViewTextBoxColumn.DataPropertyName = "Unidad"
        Me.UnidadDataGridViewTextBoxColumn.HeaderText = "Unidad"
        Me.UnidadDataGridViewTextBoxColumn.Name = "UnidadDataGridViewTextBoxColumn"
        Me.UnidadDataGridViewTextBoxColumn.ReadOnly = True
        Me.UnidadDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'ImporteDataGridViewTextBoxColumn
        '
        Me.ImporteDataGridViewTextBoxColumn.DataPropertyName = "Importe"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.ImporteDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.ImporteDataGridViewTextBoxColumn.HeaderText = "Importe"
        Me.ImporteDataGridViewTextBoxColumn.Name = "ImporteDataGridViewTextBoxColumn"
        Me.ImporteDataGridViewTextBoxColumn.ReadOnly = True
        Me.ImporteDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'CantidadSurtidaDataGridViewTextBoxColumn
        '
        Me.CantidadSurtidaDataGridViewTextBoxColumn.DataPropertyName = "Cantidad Surtida"
        Me.CantidadSurtidaDataGridViewTextBoxColumn.HeaderText = "Cantidad Surtida"
        Me.CantidadSurtidaDataGridViewTextBoxColumn.Name = "CantidadSurtidaDataGridViewTextBoxColumn"
        Me.CantidadSurtidaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'PrecioSurtidoDataGridViewTextBoxColumn
        '
        Me.PrecioSurtidoDataGridViewTextBoxColumn.DataPropertyName = "Precio Surtido"
        Me.PrecioSurtidoDataGridViewTextBoxColumn.HeaderText = "Precio Surtido"
        Me.PrecioSurtidoDataGridViewTextBoxColumn.Name = "PrecioSurtidoDataGridViewTextBoxColumn"
        Me.PrecioSurtidoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'ObservacionesDataGridViewTextBoxColumn
        '
        Me.ObservacionesDataGridViewTextBoxColumn.DataPropertyName = "Observaciones"
        Me.ObservacionesDataGridViewTextBoxColumn.HeaderText = "Observaciones"
        Me.ObservacionesDataGridViewTextBoxColumn.Name = "ObservacionesDataGridViewTextBoxColumn"
        Me.ObservacionesDataGridViewTextBoxColumn.Width = 400
        '
        'IDPDataGridViewTextBoxColumn
        '
        Me.IDPDataGridViewTextBoxColumn.DataPropertyName = "IDP"
        Me.IDPDataGridViewTextBoxColumn.HeaderText = "IDP"
        Me.IDPDataGridViewTextBoxColumn.Name = "IDPDataGridViewTextBoxColumn"
        Me.IDPDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDPDataGridViewTextBoxColumn.Visible = False
        Me.IDPDataGridViewTextBoxColumn.Width = 5
        '
        'IDMDataGridViewTextBoxColumn
        '
        Me.IDMDataGridViewTextBoxColumn.DataPropertyName = "IDM"
        Me.IDMDataGridViewTextBoxColumn.HeaderText = "IDM"
        Me.IDMDataGridViewTextBoxColumn.Name = "IDMDataGridViewTextBoxColumn"
        Me.IDMDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDMDataGridViewTextBoxColumn.Visible = False
        Me.IDMDataGridViewTextBoxColumn.Width = 5
        '
        'DsBindingSource
        '
        Me.DsBindingSource.DataSource = Me.Ds
        Me.DsBindingSource.Position = 0
        '
        'Ds
        '
        Me.Ds.DataSetName = "ds"
        Me.Ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'gbx_Botones
        '
        Me.gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Botones.Controls.Add(Me.btn_Validar)
        Me.gbx_Botones.Location = New System.Drawing.Point(3, 506)
        Me.gbx_Botones.Name = "gbx_Botones"
        Me.gbx_Botones.Size = New System.Drawing.Size(779, 50)
        Me.gbx_Botones.TabIndex = 3
        Me.gbx_Botones.TabStop = False
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_MaterialesCentral.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(630, 13)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 6
        Me.btn_Cerrar.Text = "Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'btn_Validar
        '
        Me.btn_Validar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Validar.Enabled = False
        Me.btn_Validar.Image = Global.Modulo_MaterialesCentral.My.Resources.Resources.Guardar
        Me.btn_Validar.Location = New System.Drawing.Point(9, 13)
        Me.btn_Validar.Name = "btn_Validar"
        Me.btn_Validar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Validar.TabIndex = 5
        Me.btn_Validar.Text = "Validar"
        Me.btn_Validar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Validar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Validar.UseVisualStyleBackColor = True
        '
        'gbx_Filtro
        '
        Me.gbx_Filtro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Filtro.Controls.Add(Me.cmb_Proveedor)
        Me.gbx_Filtro.Controls.Add(Me.lbl_Proveedor)
        Me.gbx_Filtro.Controls.Add(Me.tbx_ClaveProveedor)
        Me.gbx_Filtro.Controls.Add(Me.chk_Proveedores)
        Me.gbx_Filtro.Controls.Add(Me.btn_Mostrar)
        Me.gbx_Filtro.Controls.Add(Me.Lbl_Hasta)
        Me.gbx_Filtro.Controls.Add(Me.Lbl_Desde)
        Me.gbx_Filtro.Controls.Add(Me.dtp_Hasta)
        Me.gbx_Filtro.Controls.Add(Me.dtp_Desde)
        Me.gbx_Filtro.Location = New System.Drawing.Point(3, 2)
        Me.gbx_Filtro.Name = "gbx_Filtro"
        Me.gbx_Filtro.Size = New System.Drawing.Size(777, 80)
        Me.gbx_Filtro.TabIndex = 6
        Me.gbx_Filtro.TabStop = False
        '
        'lbl_Proveedor
        '
        Me.lbl_Proveedor.AutoSize = True
        Me.lbl_Proveedor.Location = New System.Drawing.Point(18, 48)
        Me.lbl_Proveedor.Name = "lbl_Proveedor"
        Me.lbl_Proveedor.Size = New System.Drawing.Size(56, 13)
        Me.lbl_Proveedor.TabIndex = 12
        Me.lbl_Proveedor.Text = "Proveedor"
        '
        'chk_Proveedores
        '
        Me.chk_Proveedores.AutoSize = True
        Me.chk_Proveedores.Location = New System.Drawing.Point(542, 47)
        Me.chk_Proveedores.Name = "chk_Proveedores"
        Me.chk_Proveedores.Size = New System.Drawing.Size(56, 17)
        Me.chk_Proveedores.TabIndex = 7
        Me.chk_Proveedores.Text = "Todos"
        Me.chk_Proveedores.UseVisualStyleBackColor = True
        '
        'btn_Mostrar
        '
        Me.btn_Mostrar.Image = Global.Modulo_MaterialesCentral.My.Resources.Resources._1rightarrow1
        Me.btn_Mostrar.Location = New System.Drawing.Point(629, 39)
        Me.btn_Mostrar.Name = "btn_Mostrar"
        Me.btn_Mostrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Mostrar.TabIndex = 11
        Me.btn_Mostrar.Text = "&Mostrar"
        Me.btn_Mostrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Mostrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Mostrar.UseVisualStyleBackColor = True
        '
        'Lbl_Hasta
        '
        Me.Lbl_Hasta.AutoSize = True
        Me.Lbl_Hasta.Location = New System.Drawing.Point(181, 23)
        Me.Lbl_Hasta.Name = "Lbl_Hasta"
        Me.Lbl_Hasta.Size = New System.Drawing.Size(35, 13)
        Me.Lbl_Hasta.TabIndex = 2
        Me.Lbl_Hasta.Text = "Hasta"
        '
        'Lbl_Desde
        '
        Me.Lbl_Desde.AutoSize = True
        Me.Lbl_Desde.Location = New System.Drawing.Point(36, 23)
        Me.Lbl_Desde.Name = "Lbl_Desde"
        Me.Lbl_Desde.Size = New System.Drawing.Size(38, 13)
        Me.Lbl_Desde.TabIndex = 0
        Me.Lbl_Desde.Text = "Desde"
        '
        'dtp_Hasta
        '
        Me.dtp_Hasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Hasta.Location = New System.Drawing.Point(222, 19)
        Me.dtp_Hasta.Name = "dtp_Hasta"
        Me.dtp_Hasta.Size = New System.Drawing.Size(98, 20)
        Me.dtp_Hasta.TabIndex = 3
        '
        'dtp_Desde
        '
        Me.dtp_Desde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Desde.Location = New System.Drawing.Point(80, 19)
        Me.dtp_Desde.Name = "dtp_Desde"
        Me.dtp_Desde.Size = New System.Drawing.Size(95, 20)
        Me.dtp_Desde.TabIndex = 1
        '
        'cmb_Proveedor
        '
        Me.cmb_Proveedor.Clave = "Clave_Proveedor"
        Me.cmb_Proveedor.Control_Siguiente = Nothing
        Me.cmb_Proveedor.DisplayMember = "Nombre_Comercial"
        Me.cmb_Proveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Proveedor.Empresa = True
        Me.cmb_Proveedor.Filtro = Me.tbx_ClaveProveedor
        Me.cmb_Proveedor.FormattingEnabled = True
        Me.cmb_Proveedor.Location = New System.Drawing.Point(136, 45)
        Me.cmb_Proveedor.MaxDropDownItems = 20
        Me.cmb_Proveedor.Name = "cmb_Proveedor"
        Me.cmb_Proveedor.Pista = False
        Me.cmb_Proveedor.Size = New System.Drawing.Size(400, 21)
        Me.cmb_Proveedor.StoredProcedure = "Cat_Proveedores_ComboGet"
        Me.cmb_Proveedor.Sucursal = False
        Me.cmb_Proveedor.TabIndex = 14
        Me.cmb_Proveedor.Tipo = 0
        Me.cmb_Proveedor.ValueMember = "Id_Proveedor"
        '
        'tbx_ClaveProveedor
        '
        Me.tbx_ClaveProveedor.Control_Siguiente = Me.cmb_Proveedor
        Me.tbx_ClaveProveedor.Filtrado = True
        Me.tbx_ClaveProveedor.Location = New System.Drawing.Point(80, 45)
        Me.tbx_ClaveProveedor.MaxLength = 6
        Me.tbx_ClaveProveedor.Name = "tbx_ClaveProveedor"
        Me.tbx_ClaveProveedor.Size = New System.Drawing.Size(50, 20)
        Me.tbx_ClaveProveedor.TabIndex = 13
        Me.tbx_ClaveProveedor.TipoDatos = Modulo_MaterialesCentral.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'tbx_ImporteFactura
        '
        Me.tbx_ImporteFactura.Control_Siguiente = Nothing
        Me.tbx_ImporteFactura.Filtrado = True
        Me.tbx_ImporteFactura.Location = New System.Drawing.Point(111, 39)
        Me.tbx_ImporteFactura.MaxLength = 10
        Me.tbx_ImporteFactura.Name = "tbx_ImporteFactura"
        Me.tbx_ImporteFactura.Size = New System.Drawing.Size(110, 20)
        Me.tbx_ImporteFactura.TabIndex = 2
        Me.tbx_ImporteFactura.TipoDatos = Modulo_MaterialesCentral.FuncionesGlobales.Validar_Cadena.Numeros_Decimales
        '
        'tbx_FolioFactura
        '
        Me.tbx_FolioFactura.Control_Siguiente = Nothing
        Me.tbx_FolioFactura.Filtrado = True
        Me.tbx_FolioFactura.Location = New System.Drawing.Point(111, 13)
        Me.tbx_FolioFactura.MaxLength = 50
        Me.tbx_FolioFactura.Name = "tbx_FolioFactura"
        Me.tbx_FolioFactura.Size = New System.Drawing.Size(110, 20)
        Me.tbx_FolioFactura.TabIndex = 1
        Me.tbx_FolioFactura.TipoDatos = Modulo_MaterialesCentral.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'lsv_Compras
        '
        Me.lsv_Compras.AllowColumnReorder = True
        Me.lsv_Compras.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Compras.FullRowSelect = True
        Me.lsv_Compras.HideSelection = False
        Me.lsv_Compras.Location = New System.Drawing.Point(3, 38)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Compras.Lvs = ListViewColumnSorter1
        Me.lsv_Compras.MultiSelect = False
        Me.lsv_Compras.Name = "lsv_Compras"
        Me.lsv_Compras.Ocultar = ""
        Me.lsv_Compras.Row1 = 10
        Me.lsv_Compras.Row10 = 0
        Me.lsv_Compras.Row2 = 10
        Me.lsv_Compras.Row3 = 8
        Me.lsv_Compras.Row4 = 30
        Me.lsv_Compras.Row5 = 30
        Me.lsv_Compras.Row6 = 10
        Me.lsv_Compras.Row7 = 10
        Me.lsv_Compras.Row8 = 10
        Me.lsv_Compras.Row9 = 0
        Me.lsv_Compras.Size = New System.Drawing.Size(771, 98)
        Me.lsv_Compras.TabIndex = 0
        Me.lsv_Compras.UseCompatibleStateImageBehavior = False
        Me.lsv_Compras.View = System.Windows.Forms.View.Details
        '
        'frm_ComprasValidar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.gbx_Filtro)
        Me.Controls.Add(Me.gbx_Factura)
        Me.Controls.Add(Me.gbx_Botones)
        Me.Controls.Add(Me.gbx_Encabezado)
        Me.Controls.Add(Me.gbx_Detalle)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_ComprasValidar"
        Me.Text = "Validar Compras"
        Me.gbx_Encabezado.ResumeLayout(False)
        Me.gbx_Factura.ResumeLayout(False)
        Me.gbx_Factura.PerformLayout()
        Me.gbx_Detalle.ResumeLayout(False)
        CType(Me.dgv_Detalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbx_Botones.ResumeLayout(False)
        Me.gbx_Filtro.ResumeLayout(False)
        Me.gbx_Filtro.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbx_Encabezado As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_Compras As Modulo_MaterialesCentral.cp_Listview
    Friend WithEvents gbx_Factura As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_Detalle As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_FolioFactura As System.Windows.Forms.Label
    Friend WithEvents tbx_FolioFactura As Modulo_MaterialesCentral.cp_Textbox
    Friend WithEvents dtp_FechaFactura As System.Windows.Forms.DateTimePicker
    Friend WithEvents tbx_ImporteFactura As Modulo_MaterialesCentral.cp_Textbox
    Friend WithEvents lbl_ImporteFactura As System.Windows.Forms.Label
    Friend WithEvents lbl_FechaFactura As System.Windows.Forms.Label
    Friend WithEvents gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_Validar As System.Windows.Forms.Button
    Friend WithEvents dgv_Detalle As System.Windows.Forms.DataGridView
    Friend WithEvents MaterialDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioSolicitadoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantidadSolicitadaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ds As Modulo_MaterialesCentral.ds
    Friend WithEvents DsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IdInventarioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClaveDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImporteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantidadSurtidaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioSurtidoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ObservacionesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDPDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDMDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Lbl_Registros As System.Windows.Forms.Label
    Friend WithEvents gbx_Filtro As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_Proveedor As Modulo_MaterialesCentral.cp_cmb_SimpleFiltradoParam
    Friend WithEvents tbx_ClaveProveedor As Modulo_MaterialesCentral.cp_Textbox
    Friend WithEvents lbl_Proveedor As System.Windows.Forms.Label
    Friend WithEvents chk_Proveedores As System.Windows.Forms.CheckBox
    Friend WithEvents btn_Mostrar As System.Windows.Forms.Button
    Friend WithEvents Lbl_Hasta As System.Windows.Forms.Label
    Friend WithEvents Lbl_Desde As System.Windows.Forms.Label
    Friend WithEvents dtp_Hasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_Desde As System.Windows.Forms.DateTimePicker
End Class
