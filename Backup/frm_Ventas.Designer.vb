<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Ventas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Ventas))
        Me.grbMenu = New System.Windows.Forms.GroupBox
        Me.dtp_FechaEntrega = New System.Windows.Forms.DateTimePicker
        Me.btn_Agregar = New System.Windows.Forms.Button
        Me.lbl_Cantidad = New System.Windows.Forms.Label
        Me.lbl_Material = New System.Windows.Forms.Label
        Me.lbl_FechaEnt = New System.Windows.Forms.Label
        Me.lbl_Depto = New System.Windows.Forms.Label
        Me.Gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_Guardar = New System.Windows.Forms.Button
        Me.btn_Borrar = New System.Windows.Forms.Button
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.gbx_Lista = New System.Windows.Forms.GroupBox
        Me.Lbl_Registros = New System.Windows.Forms.Label
        Me.Lsv_Ventas = New Modulo_MaterialesCentral.cp_Listview
        Me.cmb_ClaveDepto = New Modulo_MaterialesCentral.cp_cmb_Manual
        Me.tbx_Cantidad = New Modulo_MaterialesCentral.cp_Textbox
        Me.cmb_Material = New Modulo_MaterialesCentral.cp_cmb_SimpleFiltradoParam
        Me.tbx_ClaveMaterial = New Modulo_MaterialesCentral.cp_Textbox
        Me.grbMenu.SuspendLayout()
        Me.Gbx_Botones.SuspendLayout()
        Me.gbx_Lista.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbMenu
        '
        Me.grbMenu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grbMenu.Controls.Add(Me.cmb_ClaveDepto)
        Me.grbMenu.Controls.Add(Me.btn_Agregar)
        Me.grbMenu.Controls.Add(Me.lbl_Cantidad)
        Me.grbMenu.Controls.Add(Me.tbx_Cantidad)
        Me.grbMenu.Controls.Add(Me.cmb_Material)
        Me.grbMenu.Controls.Add(Me.lbl_Material)
        Me.grbMenu.Controls.Add(Me.tbx_ClaveMaterial)
        Me.grbMenu.Controls.Add(Me.dtp_FechaEntrega)
        Me.grbMenu.Controls.Add(Me.lbl_FechaEnt)
        Me.grbMenu.Controls.Add(Me.lbl_Depto)
        Me.grbMenu.Location = New System.Drawing.Point(9, 1)
        Me.grbMenu.Name = "grbMenu"
        Me.grbMenu.Size = New System.Drawing.Size(768, 129)
        Me.grbMenu.TabIndex = 0
        Me.grbMenu.TabStop = False
        '
        'dtp_FechaEntrega
        '
        Me.dtp_FechaEntrega.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaEntrega.Location = New System.Drawing.Point(101, 15)
        Me.dtp_FechaEntrega.MinDate = New Date(2009, 7, 23, 0, 0, 0, 0)
        Me.dtp_FechaEntrega.Name = "dtp_FechaEntrega"
        Me.dtp_FechaEntrega.Size = New System.Drawing.Size(100, 20)
        Me.dtp_FechaEntrega.TabIndex = 1
        '
        'btn_Agregar
        '
        Me.btn_Agregar.Image = Global.Modulo_MaterialesCentral.My.Resources.Resources.Agregar
        Me.btn_Agregar.Location = New System.Drawing.Point(174, 91)
        Me.btn_Agregar.Name = "btn_Agregar"
        Me.btn_Agregar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Agregar.TabIndex = 9
        Me.btn_Agregar.Text = "&Agregar"
        Me.btn_Agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Agregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Agregar.UseVisualStyleBackColor = True
        '
        'lbl_Cantidad
        '
        Me.lbl_Cantidad.AutoSize = True
        Me.lbl_Cantidad.Location = New System.Drawing.Point(46, 98)
        Me.lbl_Cantidad.Name = "lbl_Cantidad"
        Me.lbl_Cantidad.Size = New System.Drawing.Size(49, 13)
        Me.lbl_Cantidad.TabIndex = 7
        Me.lbl_Cantidad.Text = "Cantidad"
        '
        'lbl_Material
        '
        Me.lbl_Material.AutoSize = True
        Me.lbl_Material.Location = New System.Drawing.Point(51, 67)
        Me.lbl_Material.Name = "lbl_Material"
        Me.lbl_Material.Size = New System.Drawing.Size(44, 13)
        Me.lbl_Material.TabIndex = 4
        Me.lbl_Material.Text = "Material"
        '
        'lbl_FechaEnt
        '
        Me.lbl_FechaEnt.AutoSize = True
        Me.lbl_FechaEnt.BackColor = System.Drawing.Color.Transparent
        Me.lbl_FechaEnt.Location = New System.Drawing.Point(3, 19)
        Me.lbl_FechaEnt.Name = "lbl_FechaEnt"
        Me.lbl_FechaEnt.Size = New System.Drawing.Size(92, 13)
        Me.lbl_FechaEnt.TabIndex = 0
        Me.lbl_FechaEnt.Text = "Fecha de Entrega"
        '
        'lbl_Depto
        '
        Me.lbl_Depto.AutoSize = True
        Me.lbl_Depto.Location = New System.Drawing.Point(21, 42)
        Me.lbl_Depto.Name = "lbl_Depto"
        Me.lbl_Depto.Size = New System.Drawing.Size(74, 13)
        Me.lbl_Depto.TabIndex = 2
        Me.lbl_Depto.Text = "Departamento"
        '
        'Gbx_Botones
        '
        Me.Gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Botones.Controls.Add(Me.btn_Guardar)
        Me.Gbx_Botones.Controls.Add(Me.btn_Borrar)
        Me.Gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.Gbx_Botones.Location = New System.Drawing.Point(9, 503)
        Me.Gbx_Botones.Name = "Gbx_Botones"
        Me.Gbx_Botones.Size = New System.Drawing.Size(768, 50)
        Me.Gbx_Botones.TabIndex = 2
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
        'btn_Borrar
        '
        Me.btn_Borrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btn_Borrar.Enabled = False
        Me.btn_Borrar.Image = Global.Modulo_MaterialesCentral.My.Resources.Resources.BajaReing
        Me.btn_Borrar.Location = New System.Drawing.Point(314, 14)
        Me.btn_Borrar.Name = "btn_Borrar"
        Me.btn_Borrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Borrar.TabIndex = 1
        Me.btn_Borrar.Text = "&Borrar"
        Me.btn_Borrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Borrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Borrar.UseVisualStyleBackColor = True
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_MaterialesCentral.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(622, 14)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 2
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'gbx_Lista
        '
        Me.gbx_Lista.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Lista.Controls.Add(Me.Lbl_Registros)
        Me.gbx_Lista.Controls.Add(Me.Lsv_Ventas)
        Me.gbx_Lista.Location = New System.Drawing.Point(9, 136)
        Me.gbx_Lista.Name = "gbx_Lista"
        Me.gbx_Lista.Size = New System.Drawing.Size(768, 363)
        Me.gbx_Lista.TabIndex = 4
        Me.gbx_Lista.TabStop = False
        '
        'Lbl_Registros
        '
        Me.Lbl_Registros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Registros.Location = New System.Drawing.Point(624, 16)
        Me.Lbl_Registros.Name = "Lbl_Registros"
        Me.Lbl_Registros.Size = New System.Drawing.Size(140, 19)
        Me.Lbl_Registros.TabIndex = 10
        Me.Lbl_Registros.Text = "Registros: 0"
        Me.Lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lsv_Ventas
        '
        Me.Lsv_Ventas.AllowColumnReorder = True
        Me.Lsv_Ventas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lsv_Ventas.FullRowSelect = True
        Me.Lsv_Ventas.HideSelection = False
        Me.Lsv_Ventas.Location = New System.Drawing.Point(6, 38)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.Lsv_Ventas.Lvs = ListViewColumnSorter1
        Me.Lsv_Ventas.MultiSelect = False
        Me.Lsv_Ventas.Name = "Lsv_Ventas"
        Me.Lsv_Ventas.Ocultar = ""
        Me.Lsv_Ventas.Row1 = 15
        Me.Lsv_Ventas.Row10 = 0
        Me.Lsv_Ventas.Row2 = 40
        Me.Lsv_Ventas.Row3 = 10
        Me.Lsv_Ventas.Row4 = 10
        Me.Lsv_Ventas.Row5 = 20
        Me.Lsv_Ventas.Row6 = 0
        Me.Lsv_Ventas.Row7 = 0
        Me.Lsv_Ventas.Row8 = 0
        Me.Lsv_Ventas.Row9 = 0
        Me.Lsv_Ventas.Size = New System.Drawing.Size(756, 319)
        Me.Lsv_Ventas.TabIndex = 1
        Me.Lsv_Ventas.TabStop = False
        Me.Lsv_Ventas.UseCompatibleStateImageBehavior = False
        Me.Lsv_Ventas.View = System.Windows.Forms.View.Details
        '
        'cmb_ClaveDepto
        '
        Me.cmb_ClaveDepto.Control_Siguiente = Me.dtp_FechaEntrega
        Me.cmb_ClaveDepto.DisplayMember = "display"
        Me.cmb_ClaveDepto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ClaveDepto.FormattingEnabled = True
        Me.cmb_ClaveDepto.Location = New System.Drawing.Point(101, 39)
        Me.cmb_ClaveDepto.MaxDropDownItems = 20
        Me.cmb_ClaveDepto.Name = "cmb_ClaveDepto"
        Me.cmb_ClaveDepto.Size = New System.Drawing.Size(357, 21)
        Me.cmb_ClaveDepto.TabIndex = 3
        Me.cmb_ClaveDepto.ValueMember = "value"
        '
        'tbx_Cantidad
        '
        Me.tbx_Cantidad.Control_Siguiente = Me.btn_Agregar
        Me.tbx_Cantidad.Filtrado = True
        Me.tbx_Cantidad.Location = New System.Drawing.Point(101, 95)
        Me.tbx_Cantidad.MaxLength = 10
        Me.tbx_Cantidad.Name = "tbx_Cantidad"
        Me.tbx_Cantidad.Size = New System.Drawing.Size(67, 20)
        Me.tbx_Cantidad.TabIndex = 8
        Me.tbx_Cantidad.TipoDatos = Modulo_MaterialesCentral.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'cmb_Material
        '
        Me.cmb_Material.Clave = "Clave"
        Me.cmb_Material.Control_Siguiente = Me.tbx_Cantidad
        Me.cmb_Material.DisplayMember = "Descripcion"
        Me.cmb_Material.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Material.Empresa = False
        Me.cmb_Material.Filtro = Me.tbx_ClaveMaterial
        Me.cmb_Material.FormattingEnabled = True
        Me.cmb_Material.Location = New System.Drawing.Point(157, 64)
        Me.cmb_Material.MaxDropDownItems = 20
        Me.cmb_Material.Name = "cmb_Material"
        Me.cmb_Material.Pista = False
        Me.cmb_Material.Size = New System.Drawing.Size(301, 21)
        Me.cmb_Material.StoredProcedure = "Mat_Inventario_Get"
        Me.cmb_Material.Sucursal = True
        Me.cmb_Material.TabIndex = 6
        Me.cmb_Material.Tipo = 0
        Me.cmb_Material.ValueMember = "Id_Inventario"
        '
        'tbx_ClaveMaterial
        '
        Me.tbx_ClaveMaterial.Control_Siguiente = Me.cmb_Material
        Me.tbx_ClaveMaterial.Filtrado = True
        Me.tbx_ClaveMaterial.Location = New System.Drawing.Point(101, 65)
        Me.tbx_ClaveMaterial.MaxLength = 4
        Me.tbx_ClaveMaterial.Name = "tbx_ClaveMaterial"
        Me.tbx_ClaveMaterial.Size = New System.Drawing.Size(50, 20)
        Me.tbx_ClaveMaterial.TabIndex = 5
        Me.tbx_ClaveMaterial.TipoDatos = Modulo_MaterialesCentral.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'frm_Ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.gbx_Lista)
        Me.Controls.Add(Me.Gbx_Botones)
        Me.Controls.Add(Me.grbMenu)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_Ventas"
        Me.Text = "Asignación de Materiales"
        Me.grbMenu.ResumeLayout(False)
        Me.grbMenu.PerformLayout()
        Me.Gbx_Botones.ResumeLayout(False)
        Me.gbx_Lista.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents Lsv_Ventas As Modulo_MaterialesCentral.cp_Listview
    Friend WithEvents btn_Borrar As System.Windows.Forms.Button
    Friend WithEvents grbMenu As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_ClaveDepto As Modulo_MaterialesCentral.cp_cmb_Manual
    Friend WithEvents btn_Agregar As System.Windows.Forms.Button
    Friend WithEvents lbl_Cantidad As System.Windows.Forms.Label
    Friend WithEvents tbx_Cantidad As Modulo_MaterialesCentral.cp_textbox
    Friend WithEvents cmb_Material As Modulo_MaterialesCentral.cp_cmb_SimpleFiltradoParam
    Friend WithEvents tbx_ClaveMaterial As Modulo_MaterialesCentral.cp_textbox
    Friend WithEvents lbl_Material As System.Windows.Forms.Label
    Friend WithEvents dtp_FechaEntrega As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_FechaEnt As System.Windows.Forms.Label
    Friend WithEvents lbl_Depto As System.Windows.Forms.Label
    Friend WithEvents Gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_Lista As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl_Registros As System.Windows.Forms.Label
End Class
