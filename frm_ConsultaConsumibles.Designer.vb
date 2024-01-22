<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ConsultaConsumibles
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ConsultaConsumibles))
        Dim ListViewColumnSorter3 As Modulo_MaterialesCentral.ListViewColumnSorter = New Modulo_MaterialesCentral.ListViewColumnSorter
        Me.Gbx_Detalle = New System.Windows.Forms.GroupBox
        Me.lsv_Detalle = New Modulo_MaterialesCentral.cp_Listview
        Me.Gbx_Lista = New System.Windows.Forms.GroupBox
        Me.Lbl_Registros = New System.Windows.Forms.Label
        Me.lsv_Solicitudes = New Modulo_MaterialesCentral.cp_Listview
        Me.Gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_ExportarSol = New System.Windows.Forms.Button
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.gbx_Filtro = New System.Windows.Forms.GroupBox
        Me.cmb_UsuarioSolicita = New Modulo_MaterialesCentral.cp_cmb_SimpleFiltradoParam
        Me.cmb_Status = New Modulo_MaterialesCentral.cp_cmb_Manual
        Me.btn_Mostrar = New System.Windows.Forms.Button
        Me.chk_Usuarios = New System.Windows.Forms.CheckBox
        Me.Lbl_UsuarioSolicita = New System.Windows.Forms.Label
        Me.chk_Todos = New System.Windows.Forms.CheckBox
        Me.Lbl_Status = New System.Windows.Forms.Label
        Me.Lbl_Hasta = New System.Windows.Forms.Label
        Me.Lbl_Desde = New System.Windows.Forms.Label
        Me.dtp_Hasta = New System.Windows.Forms.DateTimePicker
        Me.dtp_Desde = New System.Windows.Forms.DateTimePicker
        Me.Gbx_Cantidad = New System.Windows.Forms.GroupBox
        Me.btn_ExportarConc = New System.Windows.Forms.Button
        Me.lsv_TotalConsumibles = New Modulo_MaterialesCentral.cp_Listview
        Me.Lbl_Nota = New System.Windows.Forms.Label
        Me.Gbx_Detalle.SuspendLayout()
        Me.Gbx_Lista.SuspendLayout()
        Me.Gbx_Botones.SuspendLayout()
        Me.gbx_Filtro.SuspendLayout()
        Me.Gbx_Cantidad.SuspendLayout()
        Me.SuspendLayout()
        '
        'Gbx_Detalle
        '
        Me.Gbx_Detalle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Detalle.Controls.Add(Me.lsv_Detalle)
        Me.Gbx_Detalle.Location = New System.Drawing.Point(3, 385)
        Me.Gbx_Detalle.Name = "Gbx_Detalle"
        Me.Gbx_Detalle.Size = New System.Drawing.Size(401, 179)
        Me.Gbx_Detalle.TabIndex = 2
        Me.Gbx_Detalle.TabStop = False
        Me.Gbx_Detalle.Text = "Detalle de Solicitud"
        '
        'lsv_Detalle
        '
        Me.lsv_Detalle.AllowColumnReorder = True
        Me.lsv_Detalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lsv_Detalle.FullRowSelect = True
        Me.lsv_Detalle.HideSelection = False
        Me.lsv_Detalle.Location = New System.Drawing.Point(3, 16)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Detalle.Lvs = ListViewColumnSorter1
        Me.lsv_Detalle.MultiSelect = False
        Me.lsv_Detalle.Name = "lsv_Detalle"
        Me.lsv_Detalle.Ocultar = ""
        Me.lsv_Detalle.Row1 = 40
        Me.lsv_Detalle.Row10 = 0
        Me.lsv_Detalle.Row2 = 20
        Me.lsv_Detalle.Row3 = 20
        Me.lsv_Detalle.Row4 = 20
        Me.lsv_Detalle.Row5 = 25
        Me.lsv_Detalle.Row6 = 0
        Me.lsv_Detalle.Row7 = 0
        Me.lsv_Detalle.Row8 = 0
        Me.lsv_Detalle.Row9 = 0
        Me.lsv_Detalle.Size = New System.Drawing.Size(395, 160)
        Me.lsv_Detalle.TabIndex = 0
        Me.lsv_Detalle.UseCompatibleStateImageBehavior = False
        Me.lsv_Detalle.View = System.Windows.Forms.View.Details
        '
        'Gbx_Lista
        '
        Me.Gbx_Lista.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Lista.Controls.Add(Me.Lbl_Registros)
        Me.Gbx_Lista.Controls.Add(Me.lsv_Solicitudes)
        Me.Gbx_Lista.Location = New System.Drawing.Point(3, 116)
        Me.Gbx_Lista.Name = "Gbx_Lista"
        Me.Gbx_Lista.Size = New System.Drawing.Size(785, 267)
        Me.Gbx_Lista.TabIndex = 1
        Me.Gbx_Lista.TabStop = False
        Me.Gbx_Lista.Text = "Solicitudes"
        '
        'Lbl_Registros
        '
        Me.Lbl_Registros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Registros.Location = New System.Drawing.Point(639, 16)
        Me.Lbl_Registros.Name = "Lbl_Registros"
        Me.Lbl_Registros.Size = New System.Drawing.Size(140, 15)
        Me.Lbl_Registros.TabIndex = 0
        Me.Lbl_Registros.Text = "Registros: 0"
        Me.Lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lsv_Solicitudes
        '
        Me.lsv_Solicitudes.AllowColumnReorder = True
        Me.lsv_Solicitudes.CheckBoxes = True
        Me.lsv_Solicitudes.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lsv_Solicitudes.FullRowSelect = True
        Me.lsv_Solicitudes.HideSelection = False
        Me.lsv_Solicitudes.Location = New System.Drawing.Point(3, 34)
        ListViewColumnSorter2.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter2.SortColumn = 0
        Me.lsv_Solicitudes.Lvs = ListViewColumnSorter2
        Me.lsv_Solicitudes.MultiSelect = False
        Me.lsv_Solicitudes.Name = "lsv_Solicitudes"
        Me.lsv_Solicitudes.Ocultar = ""
        Me.lsv_Solicitudes.Row1 = 6
        Me.lsv_Solicitudes.Row10 = 0
        Me.lsv_Solicitudes.Row2 = 7
        Me.lsv_Solicitudes.Row3 = 5
        Me.lsv_Solicitudes.Row4 = 20
        Me.lsv_Solicitudes.Row5 = 7
        Me.lsv_Solicitudes.Row6 = 53
        Me.lsv_Solicitudes.Row7 = 0
        Me.lsv_Solicitudes.Row8 = 0
        Me.lsv_Solicitudes.Row9 = 0
        Me.lsv_Solicitudes.Size = New System.Drawing.Size(779, 230)
        Me.lsv_Solicitudes.TabIndex = 1
        Me.lsv_Solicitudes.UseCompatibleStateImageBehavior = False
        Me.lsv_Solicitudes.View = System.Windows.Forms.View.Details
        '
        'Gbx_Botones
        '
        Me.Gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Botones.Controls.Add(Me.btn_ExportarSol)
        Me.Gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.Gbx_Botones.Location = New System.Drawing.Point(7, 566)
        Me.Gbx_Botones.Name = "Gbx_Botones"
        Me.Gbx_Botones.Size = New System.Drawing.Size(781, 50)
        Me.Gbx_Botones.TabIndex = 4
        Me.Gbx_Botones.TabStop = False
        '
        'btn_ExportarSol
        '
        Me.btn_ExportarSol.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_ExportarSol.Enabled = False
        Me.btn_ExportarSol.Image = Global.Modulo_MaterialesCentral.My.Resources.Resources.Exportar
        Me.btn_ExportarSol.Location = New System.Drawing.Point(6, 14)
        Me.btn_ExportarSol.Name = "btn_ExportarSol"
        Me.btn_ExportarSol.Size = New System.Drawing.Size(140, 30)
        Me.btn_ExportarSol.TabIndex = 0
        Me.btn_ExportarSol.Text = "&Exportar Solicitud"
        Me.btn_ExportarSol.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_ExportarSol.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_ExportarSol.UseVisualStyleBackColor = True
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_MaterialesCentral.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(635, 14)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 1
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'gbx_Filtro
        '
        Me.gbx_Filtro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Filtro.Controls.Add(Me.cmb_UsuarioSolicita)
        Me.gbx_Filtro.Controls.Add(Me.chk_Usuarios)
        Me.gbx_Filtro.Controls.Add(Me.Lbl_UsuarioSolicita)
        Me.gbx_Filtro.Controls.Add(Me.cmb_Status)
        Me.gbx_Filtro.Controls.Add(Me.btn_Mostrar)
        Me.gbx_Filtro.Controls.Add(Me.chk_Todos)
        Me.gbx_Filtro.Controls.Add(Me.Lbl_Status)
        Me.gbx_Filtro.Controls.Add(Me.Lbl_Hasta)
        Me.gbx_Filtro.Controls.Add(Me.Lbl_Desde)
        Me.gbx_Filtro.Controls.Add(Me.dtp_Hasta)
        Me.gbx_Filtro.Controls.Add(Me.dtp_Desde)
        Me.gbx_Filtro.Location = New System.Drawing.Point(3, 2)
        Me.gbx_Filtro.Name = "gbx_Filtro"
        Me.gbx_Filtro.Size = New System.Drawing.Size(785, 108)
        Me.gbx_Filtro.TabIndex = 0
        Me.gbx_Filtro.TabStop = False
        '
        'cmb_UsuarioSolicita
        '
        Me.cmb_UsuarioSolicita.Clave = "Clave_Empleado"
        Me.cmb_UsuarioSolicita.Control_Siguiente = Me.cmb_Status
        Me.cmb_UsuarioSolicita.DisplayMember = "Nombre"
        Me.cmb_UsuarioSolicita.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_UsuarioSolicita.Empresa = False
        Me.cmb_UsuarioSolicita.Filtro = Nothing
        Me.cmb_UsuarioSolicita.FormattingEnabled = True
        Me.cmb_UsuarioSolicita.Location = New System.Drawing.Point(96, 44)
        Me.cmb_UsuarioSolicita.MaxDropDownItems = 20
        Me.cmb_UsuarioSolicita.Name = "cmb_UsuarioSolicita"
        Me.cmb_UsuarioSolicita.Pista = False
        Me.cmb_UsuarioSolicita.Size = New System.Drawing.Size(388, 21)
        Me.cmb_UsuarioSolicita.StoredProcedure = "Cat_EmpleadosCombo_Get"
        Me.cmb_UsuarioSolicita.Sucursal = True
        Me.cmb_UsuarioSolicita.TabIndex = 6
        Me.cmb_UsuarioSolicita.Tipo = 0
        Me.cmb_UsuarioSolicita.ValueMember = "Id_Empleado"
        '
        'cmb_Status
        '
        Me.cmb_Status.Control_Siguiente = Me.btn_Mostrar
        Me.cmb_Status.DisplayMember = "display"
        Me.cmb_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Status.Enabled = False
        Me.cmb_Status.FormattingEnabled = True
        Me.cmb_Status.Location = New System.Drawing.Point(96, 72)
        Me.cmb_Status.MaxDropDownItems = 20
        Me.cmb_Status.Name = "cmb_Status"
        Me.cmb_Status.Size = New System.Drawing.Size(162, 21)
        Me.cmb_Status.TabIndex = 9
        Me.cmb_Status.ValueMember = "value"
        '
        'btn_Mostrar
        '
        Me.btn_Mostrar.Image = Global.Modulo_MaterialesCentral.My.Resources.Resources._1rightarrow1
        Me.btn_Mostrar.Location = New System.Drawing.Point(344, 68)
        Me.btn_Mostrar.Name = "btn_Mostrar"
        Me.btn_Mostrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Mostrar.TabIndex = 11
        Me.btn_Mostrar.Text = "&Mostrar"
        Me.btn_Mostrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Mostrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Mostrar.UseVisualStyleBackColor = True
        '
        'chk_Usuarios
        '
        Me.chk_Usuarios.AutoSize = True
        Me.chk_Usuarios.Checked = True
        Me.chk_Usuarios.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_Usuarios.Location = New System.Drawing.Point(490, 47)
        Me.chk_Usuarios.Name = "chk_Usuarios"
        Me.chk_Usuarios.Size = New System.Drawing.Size(56, 17)
        Me.chk_Usuarios.TabIndex = 7
        Me.chk_Usuarios.Text = "Todos"
        Me.chk_Usuarios.UseVisualStyleBackColor = True
        '
        'Lbl_UsuarioSolicita
        '
        Me.Lbl_UsuarioSolicita.AutoSize = True
        Me.Lbl_UsuarioSolicita.Location = New System.Drawing.Point(10, 49)
        Me.Lbl_UsuarioSolicita.Name = "Lbl_UsuarioSolicita"
        Me.Lbl_UsuarioSolicita.Size = New System.Drawing.Size(80, 13)
        Me.Lbl_UsuarioSolicita.TabIndex = 4
        Me.Lbl_UsuarioSolicita.Text = "Usuario Solicita"
        '
        'chk_Todos
        '
        Me.chk_Todos.AutoSize = True
        Me.chk_Todos.Checked = True
        Me.chk_Todos.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_Todos.Location = New System.Drawing.Point(264, 76)
        Me.chk_Todos.Name = "chk_Todos"
        Me.chk_Todos.Size = New System.Drawing.Size(56, 17)
        Me.chk_Todos.TabIndex = 10
        Me.chk_Todos.Text = "Todos"
        Me.chk_Todos.UseVisualStyleBackColor = True
        '
        'Lbl_Status
        '
        Me.Lbl_Status.AutoSize = True
        Me.Lbl_Status.Location = New System.Drawing.Point(53, 77)
        Me.Lbl_Status.Name = "Lbl_Status"
        Me.Lbl_Status.Size = New System.Drawing.Size(37, 13)
        Me.Lbl_Status.TabIndex = 8
        Me.Lbl_Status.Text = "Status"
        '
        'Lbl_Hasta
        '
        Me.Lbl_Hasta.AutoSize = True
        Me.Lbl_Hasta.Location = New System.Drawing.Point(206, 23)
        Me.Lbl_Hasta.Name = "Lbl_Hasta"
        Me.Lbl_Hasta.Size = New System.Drawing.Size(35, 13)
        Me.Lbl_Hasta.TabIndex = 2
        Me.Lbl_Hasta.Text = "Hasta"
        '
        'Lbl_Desde
        '
        Me.Lbl_Desde.AutoSize = True
        Me.Lbl_Desde.Location = New System.Drawing.Point(52, 23)
        Me.Lbl_Desde.Name = "Lbl_Desde"
        Me.Lbl_Desde.Size = New System.Drawing.Size(38, 13)
        Me.Lbl_Desde.TabIndex = 0
        Me.Lbl_Desde.Text = "Desde"
        '
        'dtp_Hasta
        '
        Me.dtp_Hasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Hasta.Location = New System.Drawing.Point(247, 19)
        Me.dtp_Hasta.Name = "dtp_Hasta"
        Me.dtp_Hasta.Size = New System.Drawing.Size(96, 20)
        Me.dtp_Hasta.TabIndex = 3
        '
        'dtp_Desde
        '
        Me.dtp_Desde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Desde.Location = New System.Drawing.Point(96, 19)
        Me.dtp_Desde.Name = "dtp_Desde"
        Me.dtp_Desde.Size = New System.Drawing.Size(104, 20)
        Me.dtp_Desde.TabIndex = 1
        '
        'Gbx_Cantidad
        '
        Me.Gbx_Cantidad.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Cantidad.Controls.Add(Me.btn_ExportarConc)
        Me.Gbx_Cantidad.Controls.Add(Me.lsv_TotalConsumibles)
        Me.Gbx_Cantidad.Controls.Add(Me.Lbl_Nota)
        Me.Gbx_Cantidad.Location = New System.Drawing.Point(408, 385)
        Me.Gbx_Cantidad.Name = "Gbx_Cantidad"
        Me.Gbx_Cantidad.Size = New System.Drawing.Size(380, 178)
        Me.Gbx_Cantidad.TabIndex = 3
        Me.Gbx_Cantidad.TabStop = False
        Me.Gbx_Cantidad.Text = "Cantidad Total por Producto"
        '
        'btn_ExportarConc
        '
        Me.btn_ExportarConc.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_ExportarConc.Enabled = False
        Me.btn_ExportarConc.Image = Global.Modulo_MaterialesCentral.My.Resources.Resources.Exportar
        Me.btn_ExportarConc.Location = New System.Drawing.Point(237, 142)
        Me.btn_ExportarConc.Name = "btn_ExportarConc"
        Me.btn_ExportarConc.Size = New System.Drawing.Size(140, 30)
        Me.btn_ExportarConc.TabIndex = 2
        Me.btn_ExportarConc.Text = "&Exportar Total"
        Me.btn_ExportarConc.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_ExportarConc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_ExportarConc.UseVisualStyleBackColor = True
        '
        'lsv_TotalConsumibles
        '
        Me.lsv_TotalConsumibles.AllowColumnReorder = True
        Me.lsv_TotalConsumibles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_TotalConsumibles.FullRowSelect = True
        Me.lsv_TotalConsumibles.HideSelection = False
        Me.lsv_TotalConsumibles.Location = New System.Drawing.Point(3, 19)
        ListViewColumnSorter3.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter3.SortColumn = 0
        Me.lsv_TotalConsumibles.Lvs = ListViewColumnSorter3
        Me.lsv_TotalConsumibles.MultiSelect = False
        Me.lsv_TotalConsumibles.Name = "lsv_TotalConsumibles"
        Me.lsv_TotalConsumibles.Ocultar = ""
        Me.lsv_TotalConsumibles.Row1 = 53
        Me.lsv_TotalConsumibles.Row10 = 0
        Me.lsv_TotalConsumibles.Row2 = 14
        Me.lsv_TotalConsumibles.Row3 = 14
        Me.lsv_TotalConsumibles.Row4 = 14
        Me.lsv_TotalConsumibles.Row5 = 0
        Me.lsv_TotalConsumibles.Row6 = 0
        Me.lsv_TotalConsumibles.Row7 = 0
        Me.lsv_TotalConsumibles.Row8 = 0
        Me.lsv_TotalConsumibles.Row9 = 0
        Me.lsv_TotalConsumibles.Size = New System.Drawing.Size(374, 120)
        Me.lsv_TotalConsumibles.TabIndex = 0
        Me.lsv_TotalConsumibles.UseCompatibleStateImageBehavior = False
        Me.lsv_TotalConsumibles.View = System.Windows.Forms.View.Details
        '
        'Lbl_Nota
        '
        Me.Lbl_Nota.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Nota.AutoSize = True
        Me.Lbl_Nota.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Nota.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Nota.Location = New System.Drawing.Point(6, 148)
        Me.Lbl_Nota.Name = "Lbl_Nota"
        Me.Lbl_Nota.Size = New System.Drawing.Size(174, 26)
        Me.Lbl_Nota.TabIndex = 1
        Me.Lbl_Nota.Text = "Nota: Solo se consideran las " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "         solicitudes validadas."
        '
        'frm_ConsultaConsumibles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(794, 625)
        Me.Controls.Add(Me.Gbx_Cantidad)
        Me.Controls.Add(Me.Gbx_Lista)
        Me.Controls.Add(Me.Gbx_Detalle)
        Me.Controls.Add(Me.Gbx_Botones)
        Me.Controls.Add(Me.gbx_Filtro)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_ConsultaConsumibles"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Solicitud de Consumibles y Accesorios"
        Me.Gbx_Detalle.ResumeLayout(False)
        Me.Gbx_Lista.ResumeLayout(False)
        Me.Gbx_Botones.ResumeLayout(False)
        Me.gbx_Filtro.ResumeLayout(False)
        Me.gbx_Filtro.PerformLayout()
        Me.Gbx_Cantidad.ResumeLayout(False)
        Me.Gbx_Cantidad.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Gbx_Detalle As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_Detalle As Modulo_MaterialesCentral.cp_Listview
    Friend WithEvents Gbx_Lista As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_Solicitudes As Modulo_MaterialesCentral.cp_Listview
    Friend WithEvents Gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents gbx_Filtro As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_UsuarioSolicita As Modulo_MaterialesCentral.cp_cmb_SimpleFiltradoParam
    Friend WithEvents cmb_Status As Modulo_MaterialesCentral.cp_cmb_Manual
    Friend WithEvents btn_Mostrar As System.Windows.Forms.Button
    Friend WithEvents chk_Usuarios As System.Windows.Forms.CheckBox
    Friend WithEvents Lbl_UsuarioSolicita As System.Windows.Forms.Label
    Friend WithEvents chk_Todos As System.Windows.Forms.CheckBox
    Friend WithEvents Lbl_Status As System.Windows.Forms.Label
    Friend WithEvents Lbl_Hasta As System.Windows.Forms.Label
    Friend WithEvents Lbl_Desde As System.Windows.Forms.Label
    Friend WithEvents dtp_Hasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_Desde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Gbx_Cantidad As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_TotalConsumibles As Modulo_MaterialesCentral.cp_Listview
    Friend WithEvents btn_ExportarSol As System.Windows.Forms.Button
    Friend WithEvents Lbl_Nota As System.Windows.Forms.Label
    Friend WithEvents Lbl_Registros As System.Windows.Forms.Label
    Friend WithEvents btn_ExportarConc As System.Windows.Forms.Button
End Class
