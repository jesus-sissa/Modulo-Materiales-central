<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_SolicitudInsumosConsulta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_SolicitudInsumosConsulta))
        Dim ListViewColumnSorter5 As Modulo_MaterialesCentral.ListViewColumnSorter = New Modulo_MaterialesCentral.ListViewColumnSorter()
        Dim ListViewColumnSorter6 As Modulo_MaterialesCentral.ListViewColumnSorter = New Modulo_MaterialesCentral.ListViewColumnSorter()
        Me.gbx_Filtro = New System.Windows.Forms.GroupBox()
        Me.cmb_UsuarioSolicita = New Modulo_MaterialesCentral.cp_cmb_SimpleFiltradoParam()
        Me.cmb_Status = New Modulo_MaterialesCentral.cp_cmb_Manual()
        Me.tbx_Clave = New Modulo_MaterialesCentral.cp_Textbox()
        Me.chk_Usuarios = New System.Windows.Forms.CheckBox()
        Me.Lbl_UsuarioSol = New System.Windows.Forms.Label()
        Me.chk_Todos = New System.Windows.Forms.CheckBox()
        Me.Lbl_Status = New System.Windows.Forms.Label()
        Me.Lbl_Hasta = New System.Windows.Forms.Label()
        Me.Lbl_Desde = New System.Windows.Forms.Label()
        Me.dtp_Hasta = New System.Windows.Forms.DateTimePicker()
        Me.dtp_Desde = New System.Windows.Forms.DateTimePicker()
        Me.gbx_Botones = New System.Windows.Forms.GroupBox()
        Me.gbx_Solicitudes = New System.Windows.Forms.GroupBox()
        Me.Lbl_Registros = New System.Windows.Forms.Label()
        Me.lsv_Solicitudes = New Modulo_MaterialesCentral.cp_Listview()
        Me.Gbx_Detalle = New System.Windows.Forms.GroupBox()
        Me.lbl_RegistrosD = New System.Windows.Forms.Label()
        Me.lsv_Detalle = New Modulo_MaterialesCentral.cp_Listview()
        Me.btn_Cerrar = New System.Windows.Forms.Button()
        Me.btn_Consultar = New System.Windows.Forms.Button()
        Me.gbx_Filtro.SuspendLayout()
        Me.gbx_Botones.SuspendLayout()
        Me.gbx_Solicitudes.SuspendLayout()
        Me.Gbx_Detalle.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_Filtro
        '
        Me.gbx_Filtro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Filtro.Controls.Add(Me.cmb_UsuarioSolicita)
        Me.gbx_Filtro.Controls.Add(Me.chk_Usuarios)
        Me.gbx_Filtro.Controls.Add(Me.Lbl_UsuarioSol)
        Me.gbx_Filtro.Controls.Add(Me.cmb_Status)
        Me.gbx_Filtro.Controls.Add(Me.btn_Consultar)
        Me.gbx_Filtro.Controls.Add(Me.chk_Todos)
        Me.gbx_Filtro.Controls.Add(Me.Lbl_Status)
        Me.gbx_Filtro.Controls.Add(Me.Lbl_Hasta)
        Me.gbx_Filtro.Controls.Add(Me.Lbl_Desde)
        Me.gbx_Filtro.Controls.Add(Me.dtp_Hasta)
        Me.gbx_Filtro.Controls.Add(Me.dtp_Desde)
        Me.gbx_Filtro.Controls.Add(Me.tbx_Clave)
        Me.gbx_Filtro.Location = New System.Drawing.Point(6, 1)
        Me.gbx_Filtro.Name = "gbx_Filtro"
        Me.gbx_Filtro.Size = New System.Drawing.Size(772, 117)
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
        Me.cmb_UsuarioSolicita.Filtro = Me.tbx_Clave
        Me.cmb_UsuarioSolicita.FormattingEnabled = True
        Me.cmb_UsuarioSolicita.Location = New System.Drawing.Point(96, 44)
        Me.cmb_UsuarioSolicita.MaxDropDownItems = 20
        Me.cmb_UsuarioSolicita.Name = "cmb_UsuarioSolicita"
        Me.cmb_UsuarioSolicita.Pista = False
        Me.cmb_UsuarioSolicita.Size = New System.Drawing.Size(456, 21)
        Me.cmb_UsuarioSolicita.StoredProcedure = "Cat_EmpleadosCombo_Get"
        Me.cmb_UsuarioSolicita.Sucursal = True
        Me.cmb_UsuarioSolicita.TabIndex = 1
        Me.cmb_UsuarioSolicita.Tipo = 0
        Me.cmb_UsuarioSolicita.ValueMember = "Id_Empleado"
        '
        'cmb_Status
        '
        Me.cmb_Status.Control_Siguiente = Me.btn_Consultar
        Me.cmb_Status.DisplayMember = "display"
        Me.cmb_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Status.Enabled = False
        Me.cmb_Status.FormattingEnabled = True
        Me.cmb_Status.Location = New System.Drawing.Point(96, 72)
        Me.cmb_Status.MaxDropDownItems = 20
        Me.cmb_Status.Name = "cmb_Status"
        Me.cmb_Status.Size = New System.Drawing.Size(251, 21)
        Me.cmb_Status.TabIndex = 9
        Me.cmb_Status.ValueMember = "value"
        '
        'tbx_Clave
        '
        Me.tbx_Clave.Control_Siguiente = Me.cmb_UsuarioSolicita
        Me.tbx_Clave.Enabled = False
        Me.tbx_Clave.Filtrado = True
        Me.tbx_Clave.Location = New System.Drawing.Point(86, 45)
        Me.tbx_Clave.MaxLength = 8
        Me.tbx_Clave.Name = "tbx_Clave"
        Me.tbx_Clave.Size = New System.Drawing.Size(50, 20)
        Me.tbx_Clave.TabIndex = 13
        Me.tbx_Clave.TipoDatos = Modulo_MaterialesCentral.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        Me.tbx_Clave.Visible = False
        '
        'chk_Usuarios
        '
        Me.chk_Usuarios.AutoSize = True
        Me.chk_Usuarios.Checked = True
        Me.chk_Usuarios.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_Usuarios.Location = New System.Drawing.Point(558, 46)
        Me.chk_Usuarios.Name = "chk_Usuarios"
        Me.chk_Usuarios.Size = New System.Drawing.Size(56, 17)
        Me.chk_Usuarios.TabIndex = 7
        Me.chk_Usuarios.Text = "Todos"
        Me.chk_Usuarios.UseVisualStyleBackColor = True
        '
        'Lbl_UsuarioSol
        '
        Me.Lbl_UsuarioSol.AutoSize = True
        Me.Lbl_UsuarioSol.Location = New System.Drawing.Point(10, 49)
        Me.Lbl_UsuarioSol.Name = "Lbl_UsuarioSol"
        Me.Lbl_UsuarioSol.Size = New System.Drawing.Size(80, 13)
        Me.Lbl_UsuarioSol.TabIndex = 5
        Me.Lbl_UsuarioSol.Text = "Usuario Solicita"
        '
        'chk_Todos
        '
        Me.chk_Todos.AutoSize = True
        Me.chk_Todos.Checked = True
        Me.chk_Todos.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_Todos.Location = New System.Drawing.Point(353, 76)
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
        Me.Lbl_Hasta.Location = New System.Drawing.Point(202, 23)
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
        Me.dtp_Hasta.Location = New System.Drawing.Point(243, 19)
        Me.dtp_Hasta.Name = "dtp_Hasta"
        Me.dtp_Hasta.Size = New System.Drawing.Size(100, 20)
        Me.dtp_Hasta.TabIndex = 3
        '
        'dtp_Desde
        '
        Me.dtp_Desde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Desde.Location = New System.Drawing.Point(96, 19)
        Me.dtp_Desde.Name = "dtp_Desde"
        Me.dtp_Desde.Size = New System.Drawing.Size(100, 20)
        Me.dtp_Desde.TabIndex = 1
        '
        'gbx_Botones
        '
        Me.gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Botones.Location = New System.Drawing.Point(6, 507)
        Me.gbx_Botones.Name = "gbx_Botones"
        Me.gbx_Botones.Size = New System.Drawing.Size(772, 50)
        Me.gbx_Botones.TabIndex = 3
        Me.gbx_Botones.TabStop = False
        '
        'gbx_Solicitudes
        '
        Me.gbx_Solicitudes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Solicitudes.Controls.Add(Me.Lbl_Registros)
        Me.gbx_Solicitudes.Controls.Add(Me.lsv_Solicitudes)
        Me.gbx_Solicitudes.Location = New System.Drawing.Point(6, 116)
        Me.gbx_Solicitudes.Name = "gbx_Solicitudes"
        Me.gbx_Solicitudes.Size = New System.Drawing.Size(772, 247)
        Me.gbx_Solicitudes.TabIndex = 1
        Me.gbx_Solicitudes.TabStop = False
        '
        'Lbl_Registros
        '
        Me.Lbl_Registros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Registros.Location = New System.Drawing.Point(626, 16)
        Me.Lbl_Registros.Name = "Lbl_Registros"
        Me.Lbl_Registros.Size = New System.Drawing.Size(140, 19)
        Me.Lbl_Registros.TabIndex = 6
        Me.Lbl_Registros.Text = "Registros: 0"
        Me.Lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lsv_Solicitudes
        '
        Me.lsv_Solicitudes.AllowColumnReorder = True
        Me.lsv_Solicitudes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Solicitudes.FullRowSelect = True
        Me.lsv_Solicitudes.HideSelection = False
        Me.lsv_Solicitudes.Location = New System.Drawing.Point(3, 42)
        ListViewColumnSorter5.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter5.SortColumn = 0
        Me.lsv_Solicitudes.Lvs = ListViewColumnSorter5
        Me.lsv_Solicitudes.MultiSelect = False
        Me.lsv_Solicitudes.Name = "lsv_Solicitudes"
        Me.lsv_Solicitudes.Ocultar = ""
        Me.lsv_Solicitudes.Row1 = 8
        Me.lsv_Solicitudes.Row10 = 0
        Me.lsv_Solicitudes.Row2 = 10
        Me.lsv_Solicitudes.Row3 = 7
        Me.lsv_Solicitudes.Row4 = 35
        Me.lsv_Solicitudes.Row5 = 20
        Me.lsv_Solicitudes.Row6 = 0
        Me.lsv_Solicitudes.Row7 = 0
        Me.lsv_Solicitudes.Row8 = 0
        Me.lsv_Solicitudes.Row9 = 0
        Me.lsv_Solicitudes.Size = New System.Drawing.Size(763, 195)
        Me.lsv_Solicitudes.TabIndex = 0
        Me.lsv_Solicitudes.UseCompatibleStateImageBehavior = False
        Me.lsv_Solicitudes.View = System.Windows.Forms.View.Details
        '
        'Gbx_Detalle
        '
        Me.Gbx_Detalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Detalle.Controls.Add(Me.lbl_RegistrosD)
        Me.Gbx_Detalle.Controls.Add(Me.lsv_Detalle)
        Me.Gbx_Detalle.Location = New System.Drawing.Point(6, 369)
        Me.Gbx_Detalle.Name = "Gbx_Detalle"
        Me.Gbx_Detalle.Size = New System.Drawing.Size(772, 137)
        Me.Gbx_Detalle.TabIndex = 2
        Me.Gbx_Detalle.TabStop = False
        '
        'lbl_RegistrosD
        '
        Me.lbl_RegistrosD.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_RegistrosD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_RegistrosD.Location = New System.Drawing.Point(626, 16)
        Me.lbl_RegistrosD.Name = "lbl_RegistrosD"
        Me.lbl_RegistrosD.Size = New System.Drawing.Size(140, 19)
        Me.lbl_RegistrosD.TabIndex = 6
        Me.lbl_RegistrosD.Text = "Registros: 0"
        Me.lbl_RegistrosD.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lsv_Detalle
        '
        Me.lsv_Detalle.AllowColumnReorder = True
        Me.lsv_Detalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Detalle.FullRowSelect = True
        Me.lsv_Detalle.HideSelection = False
        Me.lsv_Detalle.Location = New System.Drawing.Point(3, 38)
        ListViewColumnSorter6.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter6.SortColumn = 0
        Me.lsv_Detalle.Lvs = ListViewColumnSorter6
        Me.lsv_Detalle.MultiSelect = False
        Me.lsv_Detalle.Name = "lsv_Detalle"
        Me.lsv_Detalle.Ocultar = ""
        Me.lsv_Detalle.Row1 = 40
        Me.lsv_Detalle.Row10 = 0
        Me.lsv_Detalle.Row2 = 10
        Me.lsv_Detalle.Row3 = 10
        Me.lsv_Detalle.Row4 = 10
        Me.lsv_Detalle.Row5 = 20
        Me.lsv_Detalle.Row6 = 0
        Me.lsv_Detalle.Row7 = 0
        Me.lsv_Detalle.Row8 = 0
        Me.lsv_Detalle.Row9 = 0
        Me.lsv_Detalle.Size = New System.Drawing.Size(763, 94)
        Me.lsv_Detalle.TabIndex = 0
        Me.lsv_Detalle.UseCompatibleStateImageBehavior = False
        Me.lsv_Detalle.View = System.Windows.Forms.View.Details
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_MaterialesCentral.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(626, 14)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 0
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'btn_Consultar
        '
        Me.btn_Consultar.Image = Global.Modulo_MaterialesCentral.My.Resources.Resources._1rightarrow1
        Me.btn_Consultar.Location = New System.Drawing.Point(412, 68)
        Me.btn_Consultar.Name = "btn_Consultar"
        Me.btn_Consultar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Consultar.TabIndex = 11
        Me.btn_Consultar.Text = "&Consultar"
        Me.btn_Consultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Consultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Consultar.UseVisualStyleBackColor = True
        '
        'frm_SolicitudInsumosConsulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.Gbx_Detalle)
        Me.Controls.Add(Me.gbx_Solicitudes)
        Me.Controls.Add(Me.gbx_Botones)
        Me.Controls.Add(Me.gbx_Filtro)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_SolicitudInsumosConsulta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Solicitudes de Insumos"
        Me.gbx_Filtro.ResumeLayout(False)
        Me.gbx_Filtro.PerformLayout()
        Me.gbx_Botones.ResumeLayout(False)
        Me.gbx_Solicitudes.ResumeLayout(False)
        Me.Gbx_Detalle.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbx_Filtro As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_Status As Modulo_MaterialesCentral.cp_cmb_Manual
    Friend WithEvents btn_Consultar As System.Windows.Forms.Button
    Friend WithEvents chk_Todos As System.Windows.Forms.CheckBox
    Friend WithEvents Lbl_Status As System.Windows.Forms.Label
    Friend WithEvents Lbl_Hasta As System.Windows.Forms.Label
    Friend WithEvents Lbl_Desde As System.Windows.Forms.Label
    Friend WithEvents dtp_Hasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_Desde As System.Windows.Forms.DateTimePicker
    Friend WithEvents gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents chk_Usuarios As System.Windows.Forms.CheckBox
    Friend WithEvents Lbl_UsuarioSol As System.Windows.Forms.Label
    Friend WithEvents gbx_Solicitudes As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_Solicitudes As Modulo_MaterialesCentral.cp_Listview
    Friend WithEvents Gbx_Detalle As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_Detalle As Modulo_MaterialesCentral.cp_Listview
    Friend WithEvents tbx_Clave As Modulo_MaterialesCentral.cp_textbox
    Friend WithEvents cmb_UsuarioSolicita As Modulo_MaterialesCentral.cp_cmb_SimpleFiltradoParam
    Friend WithEvents Lbl_Registros As System.Windows.Forms.Label
    Friend WithEvents lbl_RegistrosD As System.Windows.Forms.Label
End Class
