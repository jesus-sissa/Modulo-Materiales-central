<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Traspasos
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
        Dim ListViewColumnSorter1 As Modulo_MaterialesCentral.ListViewColumnSorter = New Modulo_MaterialesCentral.ListViewColumnSorter()
        Me.grbMenu = New System.Windows.Forms.GroupBox()
        Me.cmb_Material = New Modulo_MaterialesCentral.cp_cmb_SimpleFiltradoParam()
        Me.tbx_Cantidad = New Modulo_MaterialesCentral.cp_Textbox()
        Me.btn_Agregar = New System.Windows.Forms.Button()
        Me.tbx_ClaveMaterial = New Modulo_MaterialesCentral.cp_Textbox()
        Me.cmb_Sucursal = New System.Windows.Forms.ComboBox()
        Me.lbl_Cantidad = New System.Windows.Forms.Label()
        Me.lbl_Material = New System.Windows.Forms.Label()
        Me.lbl_Depto = New System.Windows.Forms.Label()
        Me.Gbx_Botones = New System.Windows.Forms.GroupBox()
        Me.btn_Guardar = New System.Windows.Forms.Button()
        Me.btn_Borrar = New System.Windows.Forms.Button()
        Me.btn_Cerrar = New System.Windows.Forms.Button()
        Me.gbx_Lista = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rtb_Comentarios = New System.Windows.Forms.RichTextBox()
        Me.Lbl_Registros = New System.Windows.Forms.Label()
        Me.Lsv_Datos = New Modulo_MaterialesCentral.cp_Listview()
        Me.grbMenu.SuspendLayout()
        Me.Gbx_Botones.SuspendLayout()
        Me.gbx_Lista.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbMenu
        '
        Me.grbMenu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grbMenu.Controls.Add(Me.cmb_Material)
        Me.grbMenu.Controls.Add(Me.tbx_ClaveMaterial)
        Me.grbMenu.Controls.Add(Me.cmb_Sucursal)
        Me.grbMenu.Controls.Add(Me.btn_Agregar)
        Me.grbMenu.Controls.Add(Me.lbl_Cantidad)
        Me.grbMenu.Controls.Add(Me.tbx_Cantidad)
        Me.grbMenu.Controls.Add(Me.lbl_Material)
        Me.grbMenu.Controls.Add(Me.lbl_Depto)
        Me.grbMenu.Location = New System.Drawing.Point(4, 1)
        Me.grbMenu.Name = "grbMenu"
        Me.grbMenu.Size = New System.Drawing.Size(775, 110)
        Me.grbMenu.TabIndex = 0
        Me.grbMenu.TabStop = False
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
        Me.cmb_Material.Location = New System.Drawing.Point(166, 45)
        Me.cmb_Material.MaxDropDownItems = 20
        Me.cmb_Material.Name = "cmb_Material"
        Me.cmb_Material.Pista = False
        Me.cmb_Material.Size = New System.Drawing.Size(301, 21)
        Me.cmb_Material.StoredProcedure = "Mat_Inventario_Get"
        Me.cmb_Material.Sucursal = True
        Me.cmb_Material.TabIndex = 4
        Me.cmb_Material.Tipo = 0
        Me.cmb_Material.ValueMember = "Id_Inventario"
        '
        'tbx_Cantidad
        '
        Me.tbx_Cantidad.Control_Siguiente = Me.btn_Agregar
        Me.tbx_Cantidad.Filtrado = True
        Me.tbx_Cantidad.Location = New System.Drawing.Point(110, 75)
        Me.tbx_Cantidad.MaxLength = 10
        Me.tbx_Cantidad.Name = "tbx_Cantidad"
        Me.tbx_Cantidad.Size = New System.Drawing.Size(67, 20)
        Me.tbx_Cantidad.TabIndex = 6
        Me.tbx_Cantidad.TipoDatos = Modulo_MaterialesCentral.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'btn_Agregar
        '
        Me.btn_Agregar.Image = Global.Modulo_MaterialesCentral.My.Resources.Resources.Agregar
        Me.btn_Agregar.Location = New System.Drawing.Point(183, 72)
        Me.btn_Agregar.Name = "btn_Agregar"
        Me.btn_Agregar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Agregar.TabIndex = 7
        Me.btn_Agregar.Text = "&Agregar"
        Me.btn_Agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Agregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Agregar.UseVisualStyleBackColor = True
        '
        'tbx_ClaveMaterial
        '
        Me.tbx_ClaveMaterial.Control_Siguiente = Me.cmb_Material
        Me.tbx_ClaveMaterial.Filtrado = True
        Me.tbx_ClaveMaterial.Location = New System.Drawing.Point(110, 46)
        Me.tbx_ClaveMaterial.MaxLength = 4
        Me.tbx_ClaveMaterial.Name = "tbx_ClaveMaterial"
        Me.tbx_ClaveMaterial.Size = New System.Drawing.Size(50, 20)
        Me.tbx_ClaveMaterial.TabIndex = 3
        Me.tbx_ClaveMaterial.TipoDatos = Modulo_MaterialesCentral.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'cmb_Sucursal
        '
        Me.cmb_Sucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Sucursal.FormattingEnabled = True
        Me.cmb_Sucursal.Location = New System.Drawing.Point(110, 19)
        Me.cmb_Sucursal.MaxDropDownItems = 20
        Me.cmb_Sucursal.Name = "cmb_Sucursal"
        Me.cmb_Sucursal.Size = New System.Drawing.Size(357, 21)
        Me.cmb_Sucursal.TabIndex = 1
        '
        'lbl_Cantidad
        '
        Me.lbl_Cantidad.AutoSize = True
        Me.lbl_Cantidad.Location = New System.Drawing.Point(55, 78)
        Me.lbl_Cantidad.Name = "lbl_Cantidad"
        Me.lbl_Cantidad.Size = New System.Drawing.Size(49, 13)
        Me.lbl_Cantidad.TabIndex = 5
        Me.lbl_Cantidad.Text = "Cantidad"
        '
        'lbl_Material
        '
        Me.lbl_Material.AutoSize = True
        Me.lbl_Material.Location = New System.Drawing.Point(60, 49)
        Me.lbl_Material.Name = "lbl_Material"
        Me.lbl_Material.Size = New System.Drawing.Size(44, 13)
        Me.lbl_Material.TabIndex = 2
        Me.lbl_Material.Text = "Material"
        '
        'lbl_Depto
        '
        Me.lbl_Depto.AutoSize = True
        Me.lbl_Depto.Location = New System.Drawing.Point(17, 22)
        Me.lbl_Depto.Name = "lbl_Depto"
        Me.lbl_Depto.Size = New System.Drawing.Size(87, 13)
        Me.lbl_Depto.TabIndex = 0
        Me.lbl_Depto.Text = "Sucursal Destino"
        '
        'Gbx_Botones
        '
        Me.Gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Botones.Controls.Add(Me.btn_Guardar)
        Me.Gbx_Botones.Controls.Add(Me.btn_Borrar)
        Me.Gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.Gbx_Botones.Location = New System.Drawing.Point(4, 508)
        Me.Gbx_Botones.Name = "Gbx_Botones"
        Me.Gbx_Botones.Size = New System.Drawing.Size(775, 50)
        Me.Gbx_Botones.TabIndex = 2
        Me.Gbx_Botones.TabStop = False
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Guardar.Enabled = False
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
        Me.btn_Borrar.Location = New System.Drawing.Point(317, 14)
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
        Me.btn_Cerrar.Location = New System.Drawing.Point(629, 14)
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
        Me.gbx_Lista.Controls.Add(Me.Label1)
        Me.gbx_Lista.Controls.Add(Me.rtb_Comentarios)
        Me.gbx_Lista.Controls.Add(Me.Lbl_Registros)
        Me.gbx_Lista.Controls.Add(Me.Lsv_Datos)
        Me.gbx_Lista.Location = New System.Drawing.Point(4, 114)
        Me.gbx_Lista.Name = "gbx_Lista"
        Me.gbx_Lista.Size = New System.Drawing.Size(775, 397)
        Me.gbx_Lista.TabIndex = 1
        Me.gbx_Lista.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 308)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Comentarios Generales"
        '
        'rtb_Comentarios
        '
        Me.rtb_Comentarios.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtb_Comentarios.Location = New System.Drawing.Point(130, 308)
        Me.rtb_Comentarios.MaxLength = 300
        Me.rtb_Comentarios.Name = "rtb_Comentarios"
        Me.rtb_Comentarios.Size = New System.Drawing.Size(638, 80)
        Me.rtb_Comentarios.TabIndex = 3
        Me.rtb_Comentarios.Text = ""
        '
        'Lbl_Registros
        '
        Me.Lbl_Registros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Registros.Location = New System.Drawing.Point(631, 16)
        Me.Lbl_Registros.Name = "Lbl_Registros"
        Me.Lbl_Registros.Size = New System.Drawing.Size(140, 19)
        Me.Lbl_Registros.TabIndex = 0
        Me.Lbl_Registros.Text = "Registros: 0"
        Me.Lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lsv_Datos
        '
        Me.Lsv_Datos.AllowColumnReorder = True
        Me.Lsv_Datos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lsv_Datos.FullRowSelect = True
        Me.Lsv_Datos.HideSelection = False
        Me.Lsv_Datos.Location = New System.Drawing.Point(6, 38)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.Lsv_Datos.Lvs = ListViewColumnSorter1
        Me.Lsv_Datos.MultiSelect = False
        Me.Lsv_Datos.Name = "Lsv_Datos"
        Me.Lsv_Datos.Ocultar = ""
        Me.Lsv_Datos.Row1 = 15
        Me.Lsv_Datos.Row10 = 0
        Me.Lsv_Datos.Row2 = 25
        Me.Lsv_Datos.Row3 = 15
        Me.Lsv_Datos.Row4 = 0
        Me.Lsv_Datos.Row5 = 0
        Me.Lsv_Datos.Row6 = 15
        Me.Lsv_Datos.Row7 = 15
        Me.Lsv_Datos.Row8 = 0
        Me.Lsv_Datos.Row9 = 0
        Me.Lsv_Datos.Size = New System.Drawing.Size(763, 264)
        Me.Lsv_Datos.TabIndex = 1
        Me.Lsv_Datos.TabStop = False
        Me.Lsv_Datos.UseCompatibleStateImageBehavior = False
        Me.Lsv_Datos.View = System.Windows.Forms.View.Details
        '
        'frm_Traspasos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.gbx_Lista)
        Me.Controls.Add(Me.Gbx_Botones)
        Me.Controls.Add(Me.grbMenu)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_Traspasos"
        Me.Text = "Traspaso de Material a Otra Sucursal"
        Me.grbMenu.ResumeLayout(False)
        Me.grbMenu.PerformLayout()
        Me.Gbx_Botones.ResumeLayout(False)
        Me.gbx_Lista.ResumeLayout(False)
        Me.gbx_Lista.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents Lsv_Datos As Modulo_MaterialesCentral.cp_Listview
    Friend WithEvents btn_Borrar As System.Windows.Forms.Button
    Friend WithEvents grbMenu As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_Sucursal As System.Windows.Forms.ComboBox
    Friend WithEvents btn_Agregar As System.Windows.Forms.Button
    Friend WithEvents lbl_Cantidad As System.Windows.Forms.Label
    Friend WithEvents tbx_Cantidad As Modulo_MaterialesCentral.cp_textbox
    Friend WithEvents lbl_Material As System.Windows.Forms.Label
    Friend WithEvents lbl_Depto As System.Windows.Forms.Label
    Friend WithEvents Gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_Lista As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl_Registros As System.Windows.Forms.Label
    Friend WithEvents cmb_Material As Modulo_MaterialesCentral.cp_cmb_SimpleFiltradoParam
    Friend WithEvents tbx_ClaveMaterial As Modulo_MaterialesCentral.cp_Textbox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rtb_Comentarios As System.Windows.Forms.RichTextBox
End Class
