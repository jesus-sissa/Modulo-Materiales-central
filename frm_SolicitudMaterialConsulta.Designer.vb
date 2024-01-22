<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_SolicitudMaterialConsulta
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim ListViewColumnSorter1 As Modulo_MaterialesCentral.ListViewColumnSorter = New Modulo_MaterialesCentral.ListViewColumnSorter()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.gbx_Filtro = New System.Windows.Forms.GroupBox()
        Me.cmb_UsuarioSolicita = New Modulo_MaterialesCentral.cp_cmb_SimpleFiltradoParam()
        Me.btn_Consultar = New System.Windows.Forms.Button()
        Me.tbx_Clave = New Modulo_MaterialesCentral.cp_Textbox()
        Me.chk_Usuarios = New System.Windows.Forms.CheckBox()
        Me.Lbl_Usuario = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Lbl_Registros = New System.Windows.Forms.Label()
        Me.lsv_Solicitudes = New Modulo_MaterialesCentral.cp_Listview()
        Me.btn_Agregar = New System.Windows.Forms.Button()
        Me.Lbl_Cantidad = New System.Windows.Forms.Label()
        Me.Lbl_Accesorio = New System.Windows.Forms.Label()
        Me.Gbx_Dgv = New System.Windows.Forms.GroupBox()
        Me.dgv_Detalle = New System.Windows.Forms.DataGridView()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadValidada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Observaciones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_Cerrar = New System.Windows.Forms.Button()
        Me.btn_Validar = New System.Windows.Forms.Button()
        Me.btn_CancelarSolicitud = New System.Windows.Forms.Button()
        Me.Gbx_Botones = New System.Windows.Forms.GroupBox()
        Me.tbx_Cantidad = New Modulo_MaterialesCentral.cp_Textbox()
        Me.cmb_Consumibles = New Modulo_MaterialesCentral.cp_cmb_SimpleFiltradoParam()
        Me.gbx_Filtro.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Gbx_Dgv.SuspendLayout()
        CType(Me.dgv_Detalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gbx_Botones.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_Filtro
        '
        Me.gbx_Filtro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Filtro.Controls.Add(Me.cmb_UsuarioSolicita)
        Me.gbx_Filtro.Controls.Add(Me.chk_Usuarios)
        Me.gbx_Filtro.Controls.Add(Me.Lbl_Usuario)
        Me.gbx_Filtro.Controls.Add(Me.btn_Consultar)
        Me.gbx_Filtro.Controls.Add(Me.tbx_Clave)
        Me.gbx_Filtro.Location = New System.Drawing.Point(12, 12)
        Me.gbx_Filtro.Name = "gbx_Filtro"
        Me.gbx_Filtro.Size = New System.Drawing.Size(904, 69)
        Me.gbx_Filtro.TabIndex = 1
        Me.gbx_Filtro.TabStop = False
        '
        'cmb_UsuarioSolicita
        '
        Me.cmb_UsuarioSolicita.Clave = "Clave_Empleado"
        Me.cmb_UsuarioSolicita.Control_Siguiente = Me.btn_Consultar
        Me.cmb_UsuarioSolicita.DisplayMember = "Nombre"
        Me.cmb_UsuarioSolicita.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_UsuarioSolicita.Empresa = False
        Me.cmb_UsuarioSolicita.Filtro = Me.tbx_Clave
        Me.cmb_UsuarioSolicita.FormattingEnabled = True
        Me.cmb_UsuarioSolicita.Location = New System.Drawing.Point(123, 19)
        Me.cmb_UsuarioSolicita.MaxDropDownItems = 20
        Me.cmb_UsuarioSolicita.Name = "cmb_UsuarioSolicita"
        Me.cmb_UsuarioSolicita.Pista = False
        Me.cmb_UsuarioSolicita.Size = New System.Drawing.Size(456, 21)
        Me.cmb_UsuarioSolicita.StoredProcedure = "Cat_EmpleadosCombo_Get"
        Me.cmb_UsuarioSolicita.Sucursal = True
        Me.cmb_UsuarioSolicita.TabIndex = 2
        Me.cmb_UsuarioSolicita.Tipo = 0
        Me.cmb_UsuarioSolicita.ValueMember = "Id_Empleado"
        '
        'btn_Consultar
        '
        Me.btn_Consultar.Image = Global.Modulo_MaterialesCentral.My.Resources.Resources._1rightarrow1
        Me.btn_Consultar.Location = New System.Drawing.Point(647, 19)
        Me.btn_Consultar.Name = "btn_Consultar"
        Me.btn_Consultar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Consultar.TabIndex = 4
        Me.btn_Consultar.Text = "&Consultar"
        Me.btn_Consultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Consultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Consultar.UseVisualStyleBackColor = True
        '
        'tbx_Clave
        '
        Me.tbx_Clave.Control_Siguiente = Me.cmb_UsuarioSolicita
        Me.tbx_Clave.Filtrado = True
        Me.tbx_Clave.Location = New System.Drawing.Point(113, 20)
        Me.tbx_Clave.MaxLength = 8
        Me.tbx_Clave.Name = "tbx_Clave"
        Me.tbx_Clave.Size = New System.Drawing.Size(50, 20)
        Me.tbx_Clave.TabIndex = 1
        Me.tbx_Clave.TipoDatos = Modulo_MaterialesCentral.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        Me.tbx_Clave.Visible = False
        '
        'chk_Usuarios
        '
        Me.chk_Usuarios.AutoSize = True
        Me.chk_Usuarios.Location = New System.Drawing.Point(585, 23)
        Me.chk_Usuarios.Name = "chk_Usuarios"
        Me.chk_Usuarios.Size = New System.Drawing.Size(56, 17)
        Me.chk_Usuarios.TabIndex = 3
        Me.chk_Usuarios.Text = "Todos"
        Me.chk_Usuarios.UseVisualStyleBackColor = True
        '
        'Lbl_Usuario
        '
        Me.Lbl_Usuario.AutoSize = True
        Me.Lbl_Usuario.Location = New System.Drawing.Point(37, 23)
        Me.Lbl_Usuario.Name = "Lbl_Usuario"
        Me.Lbl_Usuario.Size = New System.Drawing.Size(80, 13)
        Me.Lbl_Usuario.TabIndex = 0
        Me.Lbl_Usuario.Text = "Usuario Solicita"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.Lbl_Registros)
        Me.GroupBox3.Controls.Add(Me.lsv_Solicitudes)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 87)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(904, 188)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        '
        'Lbl_Registros
        '
        Me.Lbl_Registros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Registros.Location = New System.Drawing.Point(758, 16)
        Me.Lbl_Registros.Name = "Lbl_Registros"
        Me.Lbl_Registros.Size = New System.Drawing.Size(140, 19)
        Me.Lbl_Registros.TabIndex = 5
        Me.Lbl_Registros.Text = "Registros: 0"
        Me.Lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lsv_Solicitudes
        '
        Me.lsv_Solicitudes.AllowColumnReorder = True
        Me.lsv_Solicitudes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Solicitudes.FullRowSelect = True
        Me.lsv_Solicitudes.HideSelection = False
        Me.lsv_Solicitudes.Location = New System.Drawing.Point(3, 38)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Solicitudes.Lvs = ListViewColumnSorter1
        Me.lsv_Solicitudes.MultiSelect = False
        Me.lsv_Solicitudes.Name = "lsv_Solicitudes"
        Me.lsv_Solicitudes.Ocultar = ""
        Me.lsv_Solicitudes.Row1 = 6
        Me.lsv_Solicitudes.Row10 = 0
        Me.lsv_Solicitudes.Row2 = 7
        Me.lsv_Solicitudes.Row3 = 5
        Me.lsv_Solicitudes.Row4 = 20
        Me.lsv_Solicitudes.Row5 = 7
        Me.lsv_Solicitudes.Row6 = 54
        Me.lsv_Solicitudes.Row7 = 0
        Me.lsv_Solicitudes.Row8 = 0
        Me.lsv_Solicitudes.Row9 = 0
        Me.lsv_Solicitudes.Size = New System.Drawing.Size(895, 144)
        Me.lsv_Solicitudes.TabIndex = 0
        Me.lsv_Solicitudes.UseCompatibleStateImageBehavior = False
        Me.lsv_Solicitudes.View = System.Windows.Forms.View.Details
        '
        'btn_Agregar
        '
        Me.btn_Agregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Agregar.Enabled = False
        Me.btn_Agregar.Image = Global.Modulo_MaterialesCentral.My.Resources.Resources.Agregar
        Me.btn_Agregar.Location = New System.Drawing.Point(688, 285)
        Me.btn_Agregar.Name = "btn_Agregar"
        Me.btn_Agregar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Agregar.TabIndex = 12
        Me.btn_Agregar.Text = "&Agregar"
        Me.btn_Agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Agregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Agregar.UseVisualStyleBackColor = True
        '
        'Lbl_Cantidad
        '
        Me.Lbl_Cantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Cantidad.AutoSize = True
        Me.Lbl_Cantidad.Location = New System.Drawing.Point(586, 295)
        Me.Lbl_Cantidad.Name = "Lbl_Cantidad"
        Me.Lbl_Cantidad.Size = New System.Drawing.Size(49, 13)
        Me.Lbl_Cantidad.TabIndex = 10
        Me.Lbl_Cantidad.Text = "Cantidad"
        '
        'Lbl_Accesorio
        '
        Me.Lbl_Accesorio.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Accesorio.AutoSize = True
        Me.Lbl_Accesorio.Location = New System.Drawing.Point(66, 292)
        Me.Lbl_Accesorio.Name = "Lbl_Accesorio"
        Me.Lbl_Accesorio.Size = New System.Drawing.Size(113, 13)
        Me.Lbl_Accesorio.TabIndex = 13
        Me.Lbl_Accesorio.Text = "Accesorio/Consumible"
        '
        'Gbx_Dgv
        '
        Me.Gbx_Dgv.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Dgv.Controls.Add(Me.dgv_Detalle)
        Me.Gbx_Dgv.Location = New System.Drawing.Point(13, 321)
        Me.Gbx_Dgv.Name = "Gbx_Dgv"
        Me.Gbx_Dgv.Size = New System.Drawing.Size(898, 237)
        Me.Gbx_Dgv.TabIndex = 15
        Me.Gbx_Dgv.TabStop = False
        '
        'dgv_Detalle
        '
        Me.dgv_Detalle.AllowUserToAddRows = False
        Me.dgv_Detalle.AllowUserToDeleteRows = False
        Me.dgv_Detalle.AllowUserToResizeColumns = False
        Me.dgv_Detalle.AllowUserToResizeRows = False
        Me.dgv_Detalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Detalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Descripcion, Me.Cantidad, Me.CantidadValidada, Me.Observaciones, Me.Status})
        Me.dgv_Detalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_Detalle.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgv_Detalle.Location = New System.Drawing.Point(3, 16)
        Me.dgv_Detalle.Name = "dgv_Detalle"
        Me.dgv_Detalle.RowHeadersVisible = False
        Me.dgv_Detalle.Size = New System.Drawing.Size(892, 218)
        Me.dgv_Detalle.TabIndex = 0
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Descripción"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        Me.Descripcion.Width = 300
        '
        'Cantidad
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Cantidad.DefaultCellStyle = DataGridViewCellStyle1
        Me.Cantidad.HeaderText = "Cantidad Solicitada"
        Me.Cantidad.MaxInputLength = 5
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        Me.Cantidad.Width = 70
        '
        'CantidadValidada
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.LightBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CantidadValidada.DefaultCellStyle = DataGridViewCellStyle2
        Me.CantidadValidada.HeaderText = "Cantidad Validada"
        Me.CantidadValidada.MaxInputLength = 5
        Me.CantidadValidada.Name = "CantidadValidada"
        Me.CantidadValidada.Width = 70
        '
        'Observaciones
        '
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.LightBlue
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Observaciones.DefaultCellStyle = DataGridViewCellStyle3
        Me.Observaciones.HeaderText = "Observaciones"
        Me.Observaciones.MaxInputLength = 100
        Me.Observaciones.Name = "Observaciones"
        Me.Observaciones.Width = 300
        '
        'Status
        '
        Me.Status.HeaderText = "Status"
        Me.Status.Name = "Status"
        Me.Status.ReadOnly = True
        Me.Status.Width = 80
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_MaterialesCentral.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(752, 14)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 2
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'btn_Validar
        '
        Me.btn_Validar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Validar.Enabled = False
        Me.btn_Validar.Image = Global.Modulo_MaterialesCentral.My.Resources.Resources.HoraSi
        Me.btn_Validar.Location = New System.Drawing.Point(6, 14)
        Me.btn_Validar.Name = "btn_Validar"
        Me.btn_Validar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Validar.TabIndex = 0
        Me.btn_Validar.Text = "&Validar"
        Me.btn_Validar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Validar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Validar.UseVisualStyleBackColor = True
        '
        'btn_CancelarSolicitud
        '
        Me.btn_CancelarSolicitud.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_CancelarSolicitud.Enabled = False
        Me.btn_CancelarSolicitud.Image = Global.Modulo_MaterialesCentral.My.Resources.Resources.Baja
        Me.btn_CancelarSolicitud.Location = New System.Drawing.Point(152, 14)
        Me.btn_CancelarSolicitud.Name = "btn_CancelarSolicitud"
        Me.btn_CancelarSolicitud.Size = New System.Drawing.Size(140, 30)
        Me.btn_CancelarSolicitud.TabIndex = 1
        Me.btn_CancelarSolicitud.Text = "&Cancelar Solicitud"
        Me.btn_CancelarSolicitud.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_CancelarSolicitud.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_CancelarSolicitud.UseVisualStyleBackColor = True
        '
        'Gbx_Botones
        '
        Me.Gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Botones.Controls.Add(Me.btn_CancelarSolicitud)
        Me.Gbx_Botones.Controls.Add(Me.btn_Validar)
        Me.Gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.Gbx_Botones.Location = New System.Drawing.Point(12, 582)
        Me.Gbx_Botones.Name = "Gbx_Botones"
        Me.Gbx_Botones.Size = New System.Drawing.Size(898, 50)
        Me.Gbx_Botones.TabIndex = 14
        Me.Gbx_Botones.TabStop = False
        '
        'tbx_Cantidad
        '
        Me.tbx_Cantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tbx_Cantidad.Control_Siguiente = Nothing
        Me.tbx_Cantidad.Filtrado = False
        Me.tbx_Cantidad.Location = New System.Drawing.Point(636, 291)
        Me.tbx_Cantidad.MaxLength = 3
        Me.tbx_Cantidad.Name = "tbx_Cantidad"
        Me.tbx_Cantidad.Size = New System.Drawing.Size(46, 20)
        Me.tbx_Cantidad.TabIndex = 11
        Me.tbx_Cantidad.TipoDatos = Modulo_MaterialesCentral.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'cmb_Consumibles
        '
        Me.cmb_Consumibles.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmb_Consumibles.Clave = Nothing
        Me.cmb_Consumibles.Control_Siguiente = Nothing
        Me.cmb_Consumibles.DisplayMember = "Descripcion"
        Me.cmb_Consumibles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Consumibles.Empresa = False
        Me.cmb_Consumibles.Enabled = False
        Me.cmb_Consumibles.Filtro = Nothing
        Me.cmb_Consumibles.FormattingEnabled = True
        Me.cmb_Consumibles.Location = New System.Drawing.Point(180, 290)
        Me.cmb_Consumibles.MaxDropDownItems = 20
        Me.cmb_Consumibles.Name = "cmb_Consumibles"
        Me.cmb_Consumibles.Pista = True
        Me.cmb_Consumibles.Size = New System.Drawing.Size(400, 21)
        Me.cmb_Consumibles.StoredProcedure = "Mat_Mat_Get"
        Me.cmb_Consumibles.Sucursal = False
        Me.cmb_Consumibles.TabIndex = 9
        Me.cmb_Consumibles.Tipo = 0
        Me.cmb_Consumibles.ValueMember = "Id_Material"
        '
        'frm_SolicitudMaterialConsulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(928, 644)
        Me.Controls.Add(Me.Gbx_Dgv)
        Me.Controls.Add(Me.Gbx_Botones)
        Me.Controls.Add(Me.tbx_Cantidad)
        Me.Controls.Add(Me.cmb_Consumibles)
        Me.Controls.Add(Me.btn_Agregar)
        Me.Controls.Add(Me.Lbl_Cantidad)
        Me.Controls.Add(Me.Lbl_Accesorio)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.gbx_Filtro)
        Me.Name = "frm_SolicitudMaterialConsulta"
        Me.Text = "frm_SolicitudMaterial"
        Me.gbx_Filtro.ResumeLayout(False)
        Me.gbx_Filtro.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.Gbx_Dgv.ResumeLayout(False)
        CType(Me.dgv_Detalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gbx_Botones.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbx_Filtro As GroupBox
    Friend WithEvents cmb_UsuarioSolicita As cp_cmb_SimpleFiltradoParam
    Friend WithEvents btn_Consultar As Button
    Friend WithEvents tbx_Clave As cp_Textbox
    Friend WithEvents chk_Usuarios As CheckBox
    Friend WithEvents Lbl_Usuario As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Lbl_Registros As Label
    Friend WithEvents lsv_Solicitudes As cp_Listview
    Friend WithEvents tbx_Cantidad As cp_Textbox
    Friend WithEvents cmb_Consumibles As cp_cmb_SimpleFiltradoParam
    Friend WithEvents btn_Agregar As Button
    Friend WithEvents Lbl_Cantidad As Label
    Friend WithEvents Lbl_Accesorio As Label
    Friend WithEvents Gbx_Dgv As GroupBox
    Friend WithEvents dgv_Detalle As DataGridView
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents CantidadValidada As DataGridViewTextBoxColumn
    Friend WithEvents Observaciones As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewTextBoxColumn
    Friend WithEvents btn_Cerrar As Button
    Friend WithEvents btn_Validar As Button
    Friend WithEvents btn_CancelarSolicitud As Button
    Friend WithEvents Gbx_Botones As GroupBox
End Class
