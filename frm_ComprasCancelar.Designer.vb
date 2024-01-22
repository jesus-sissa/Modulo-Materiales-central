<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ComprasCancelar
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
        Dim ListViewColumnSorter1 As Modulo_MaterialesCentral.ListViewColumnSorter = New Modulo_MaterialesCentral.ListViewColumnSorter
        Dim ListViewColumnSorter2 As Modulo_MaterialesCentral.ListViewColumnSorter = New Modulo_MaterialesCentral.ListViewColumnSorter
        Me.gbx_Encabezado = New System.Windows.Forms.GroupBox
        Me.Lbl_Registros = New System.Windows.Forms.Label
        Me.lsv_Compras = New Modulo_MaterialesCentral.cp_Listview
        Me.gbx_Detalle = New System.Windows.Forms.GroupBox
        Me.Lbl_Registros2 = New System.Windows.Forms.Label
        Me.lsv_Detalles = New Modulo_MaterialesCentral.cp_Listview
        Me.gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.btn_Cancelar = New System.Windows.Forms.Button
        Me.gbx_Filtro = New System.Windows.Forms.GroupBox
        Me.cmb_Proveedor = New Modulo_MaterialesCentral.cp_cmb_SimpleFiltradoParam
        Me.tbx_ClaveProveedor = New Modulo_MaterialesCentral.cp_Textbox
        Me.lbl_Proveedor = New System.Windows.Forms.Label
        Me.chk_Proveedores = New System.Windows.Forms.CheckBox
        Me.btn_Mostrar = New System.Windows.Forms.Button
        Me.Lbl_Hasta = New System.Windows.Forms.Label
        Me.Lbl_Desde = New System.Windows.Forms.Label
        Me.dtp_Hasta = New System.Windows.Forms.DateTimePicker
        Me.dtp_Desde = New System.Windows.Forms.DateTimePicker
        Me.gbx_Encabezado.SuspendLayout()
        Me.gbx_Detalle.SuspendLayout()
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
        Me.gbx_Encabezado.Location = New System.Drawing.Point(3, 84)
        Me.gbx_Encabezado.Name = "gbx_Encabezado"
        Me.gbx_Encabezado.Size = New System.Drawing.Size(778, 195)
        Me.gbx_Encabezado.TabIndex = 0
        Me.gbx_Encabezado.TabStop = False
        '
        'Lbl_Registros
        '
        Me.Lbl_Registros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Registros.Location = New System.Drawing.Point(629, 10)
        Me.Lbl_Registros.Name = "Lbl_Registros"
        Me.Lbl_Registros.Size = New System.Drawing.Size(140, 19)
        Me.Lbl_Registros.TabIndex = 3
        Me.Lbl_Registros.Text = "Registros: 0"
        Me.Lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lsv_Compras
        '
        Me.lsv_Compras.AllowColumnReorder = True
        Me.lsv_Compras.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Compras.FullRowSelect = True
        Me.lsv_Compras.HideSelection = False
        Me.lsv_Compras.Location = New System.Drawing.Point(3, 32)
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
        Me.lsv_Compras.Row9 = 10
        Me.lsv_Compras.Size = New System.Drawing.Size(772, 157)
        Me.lsv_Compras.TabIndex = 0
        Me.lsv_Compras.UseCompatibleStateImageBehavior = False
        Me.lsv_Compras.View = System.Windows.Forms.View.Details
        '
        'gbx_Detalle
        '
        Me.gbx_Detalle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Detalle.Controls.Add(Me.Lbl_Registros2)
        Me.gbx_Detalle.Controls.Add(Me.lsv_Detalles)
        Me.gbx_Detalle.Location = New System.Drawing.Point(3, 280)
        Me.gbx_Detalle.Name = "gbx_Detalle"
        Me.gbx_Detalle.Size = New System.Drawing.Size(778, 226)
        Me.gbx_Detalle.TabIndex = 2
        Me.gbx_Detalle.TabStop = False
        '
        'Lbl_Registros2
        '
        Me.Lbl_Registros2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Registros2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Registros2.Location = New System.Drawing.Point(635, 11)
        Me.Lbl_Registros2.Name = "Lbl_Registros2"
        Me.Lbl_Registros2.Size = New System.Drawing.Size(140, 19)
        Me.Lbl_Registros2.TabIndex = 3
        Me.Lbl_Registros2.Text = "Registros: 0"
        Me.Lbl_Registros2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lsv_Detalles
        '
        Me.lsv_Detalles.AllowColumnReorder = True
        Me.lsv_Detalles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Detalles.FullRowSelect = True
        Me.lsv_Detalles.HideSelection = False
        Me.lsv_Detalles.Location = New System.Drawing.Point(6, 35)
        ListViewColumnSorter2.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter2.SortColumn = 0
        Me.lsv_Detalles.Lvs = ListViewColumnSorter2
        Me.lsv_Detalles.MultiSelect = False
        Me.lsv_Detalles.Name = "lsv_Detalles"
        Me.lsv_Detalles.Ocultar = ""
        Me.lsv_Detalles.Row1 = 10
        Me.lsv_Detalles.Row10 = 0
        Me.lsv_Detalles.Row2 = 40
        Me.lsv_Detalles.Row3 = 10
        Me.lsv_Detalles.Row4 = 10
        Me.lsv_Detalles.Row5 = 10
        Me.lsv_Detalles.Row6 = 15
        Me.lsv_Detalles.Row7 = 0
        Me.lsv_Detalles.Row8 = 0
        Me.lsv_Detalles.Row9 = 0
        Me.lsv_Detalles.Size = New System.Drawing.Size(767, 182)
        Me.lsv_Detalles.TabIndex = 0
        Me.lsv_Detalles.UseCompatibleStateImageBehavior = False
        Me.lsv_Detalles.View = System.Windows.Forms.View.Details
        '
        'gbx_Botones
        '
        Me.gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Botones.Controls.Add(Me.btn_Cancelar)
        Me.gbx_Botones.Location = New System.Drawing.Point(3, 507)
        Me.gbx_Botones.Name = "gbx_Botones"
        Me.gbx_Botones.Size = New System.Drawing.Size(778, 50)
        Me.gbx_Botones.TabIndex = 3
        Me.gbx_Botones.TabStop = False
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_MaterialesCentral.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(629, 13)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 6
        Me.btn_Cerrar.Text = "Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Cancelar.Enabled = False
        Me.btn_Cancelar.Image = Global.Modulo_MaterialesCentral.My.Resources.Resources.Baja
        Me.btn_Cancelar.Location = New System.Drawing.Point(9, 13)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cancelar.TabIndex = 5
        Me.btn_Cancelar.Text = "Cancelar"
        Me.btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cancelar.UseVisualStyleBackColor = True
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
        Me.gbx_Filtro.Location = New System.Drawing.Point(2, 2)
        Me.gbx_Filtro.Name = "gbx_Filtro"
        Me.gbx_Filtro.Size = New System.Drawing.Size(779, 80)
        Me.gbx_Filtro.TabIndex = 6
        Me.gbx_Filtro.TabStop = False
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
        Me.btn_Mostrar.Location = New System.Drawing.Point(635, 39)
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
        'frm_ComprasCancelar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.gbx_Filtro)
        Me.Controls.Add(Me.gbx_Botones)
        Me.Controls.Add(Me.gbx_Detalle)
        Me.Controls.Add(Me.gbx_Encabezado)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_ComprasCancelar"
        Me.Text = "Cancelar Orden de Compra"
        Me.gbx_Encabezado.ResumeLayout(False)
        Me.gbx_Detalle.ResumeLayout(False)
        Me.gbx_Botones.ResumeLayout(False)
        Me.gbx_Filtro.ResumeLayout(False)
        Me.gbx_Filtro.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbx_Encabezado As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_Compras As Modulo_MaterialesCentral.cp_Listview
    Friend WithEvents gbx_Detalle As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents lsv_Detalles As Modulo_MaterialesCentral.cp_Listview
    Friend WithEvents Lbl_Registros As System.Windows.Forms.Label
    Friend WithEvents Lbl_Registros2 As System.Windows.Forms.Label
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
