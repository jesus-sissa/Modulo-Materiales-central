<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ReporteTraspaso
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ReporteTraspaso))
        Dim ListViewColumnSorter1 As Modulo_MaterialesCentral.ListViewColumnSorter = New Modulo_MaterialesCentral.ListViewColumnSorter()
        Me.gbx_Filtro = New System.Windows.Forms.GroupBox()
        Me.cmb_Status = New Modulo_MaterialesCentral.cp_cmb_Manual()
        Me.dtp_Desde = New System.Windows.Forms.DateTimePicker()
        Me.Lbl_Status = New System.Windows.Forms.Label()
        Me.btn_Buscar = New System.Windows.Forms.Button()
        Me.dtp_Hasta = New System.Windows.Forms.DateTimePicker()
        Me.Lbl_Hasta = New System.Windows.Forms.Label()
        Me.lbl_FechaEnt = New System.Windows.Forms.Label()
        Me.Gbx_Listado = New System.Windows.Forms.GroupBox()
        Me.Lsv_Ventas = New Modulo_MaterialesCentral.cp_Listview()
        Me.Lbl_Registros = New System.Windows.Forms.Label()
        Me.Gbx_Botones = New System.Windows.Forms.GroupBox()
        Me.btn_Exportar = New System.Windows.Forms.Button()
        Me.btn_Cerrar = New System.Windows.Forms.Button()
        Me.gbx_Filtro.SuspendLayout()
        Me.Gbx_Listado.SuspendLayout()
        Me.Gbx_Botones.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_Filtro
        '
        Me.gbx_Filtro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Filtro.Controls.Add(Me.cmb_Status)
        Me.gbx_Filtro.Controls.Add(Me.Lbl_Status)
        Me.gbx_Filtro.Controls.Add(Me.btn_Buscar)
        Me.gbx_Filtro.Controls.Add(Me.dtp_Hasta)
        Me.gbx_Filtro.Controls.Add(Me.Lbl_Hasta)
        Me.gbx_Filtro.Controls.Add(Me.dtp_Desde)
        Me.gbx_Filtro.Controls.Add(Me.lbl_FechaEnt)
        Me.gbx_Filtro.Location = New System.Drawing.Point(5, 4)
        Me.gbx_Filtro.Name = "gbx_Filtro"
        Me.gbx_Filtro.Size = New System.Drawing.Size(1278, 80)
        Me.gbx_Filtro.TabIndex = 1
        Me.gbx_Filtro.TabStop = False
        '
        'cmb_Status
        '
        Me.cmb_Status.Control_Siguiente = Me.dtp_Desde
        Me.cmb_Status.DisplayMember = "display"
        Me.cmb_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Status.FormattingEnabled = True
        Me.cmb_Status.Location = New System.Drawing.Point(91, 51)
        Me.cmb_Status.MaxDropDownItems = 20
        Me.cmb_Status.Name = "cmb_Status"
        Me.cmb_Status.Size = New System.Drawing.Size(252, 21)
        Me.cmb_Status.TabIndex = 17
        Me.cmb_Status.ValueMember = "value"
        '
        'dtp_Desde
        '
        Me.dtp_Desde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Desde.Location = New System.Drawing.Point(91, 17)
        Me.dtp_Desde.MinDate = New Date(2009, 7, 23, 0, 0, 0, 0)
        Me.dtp_Desde.Name = "dtp_Desde"
        Me.dtp_Desde.Size = New System.Drawing.Size(100, 20)
        Me.dtp_Desde.TabIndex = 4
        '
        'Lbl_Status
        '
        Me.Lbl_Status.AutoSize = True
        Me.Lbl_Status.Location = New System.Drawing.Point(47, 54)
        Me.Lbl_Status.Name = "Lbl_Status"
        Me.Lbl_Status.Size = New System.Drawing.Size(37, 13)
        Me.Lbl_Status.TabIndex = 16
        Me.Lbl_Status.Text = "Status"
        '
        'btn_Buscar
        '
        Me.btn_Buscar.Image = Global.Modulo_MaterialesCentral.My.Resources.Resources._1rightarrow1
        Me.btn_Buscar.Location = New System.Drawing.Point(385, 42)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Buscar.TabIndex = 15
        Me.btn_Buscar.Text = "&Buscar"
        Me.btn_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Buscar.UseVisualStyleBackColor = True
        '
        'dtp_Hasta
        '
        Me.dtp_Hasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Hasta.Location = New System.Drawing.Point(243, 17)
        Me.dtp_Hasta.MinDate = New Date(2009, 7, 23, 0, 0, 0, 0)
        Me.dtp_Hasta.Name = "dtp_Hasta"
        Me.dtp_Hasta.Size = New System.Drawing.Size(100, 20)
        Me.dtp_Hasta.TabIndex = 6
        '
        'Lbl_Hasta
        '
        Me.Lbl_Hasta.AutoSize = True
        Me.Lbl_Hasta.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Hasta.Location = New System.Drawing.Point(202, 21)
        Me.Lbl_Hasta.Name = "Lbl_Hasta"
        Me.Lbl_Hasta.Size = New System.Drawing.Size(35, 13)
        Me.Lbl_Hasta.TabIndex = 5
        Me.Lbl_Hasta.Text = "Hasta"
        '
        'lbl_FechaEnt
        '
        Me.lbl_FechaEnt.AutoSize = True
        Me.lbl_FechaEnt.BackColor = System.Drawing.Color.Transparent
        Me.lbl_FechaEnt.Location = New System.Drawing.Point(47, 21)
        Me.lbl_FechaEnt.Name = "lbl_FechaEnt"
        Me.lbl_FechaEnt.Size = New System.Drawing.Size(38, 13)
        Me.lbl_FechaEnt.TabIndex = 3
        Me.lbl_FechaEnt.Text = "Desde"
        '
        'Gbx_Listado
        '
        Me.Gbx_Listado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Listado.Controls.Add(Me.Lsv_Ventas)
        Me.Gbx_Listado.Location = New System.Drawing.Point(4, 109)
        Me.Gbx_Listado.Name = "Gbx_Listado"
        Me.Gbx_Listado.Size = New System.Drawing.Size(1287, 369)
        Me.Gbx_Listado.TabIndex = 2
        Me.Gbx_Listado.TabStop = False
        '
        'Lsv_Ventas
        '
        Me.Lsv_Ventas.AllowColumnReorder = True
        Me.Lsv_Ventas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Lsv_Ventas.FullRowSelect = True
        Me.Lsv_Ventas.HideSelection = False
        Me.Lsv_Ventas.Location = New System.Drawing.Point(3, 16)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.Lsv_Ventas.Lvs = ListViewColumnSorter1
        Me.Lsv_Ventas.MultiSelect = False
        Me.Lsv_Ventas.Name = "Lsv_Ventas"
        Me.Lsv_Ventas.Ocultar = ""
        Me.Lsv_Ventas.Row1 = 10
        Me.Lsv_Ventas.Row10 = 20
        Me.Lsv_Ventas.Row2 = 10
        Me.Lsv_Ventas.Row3 = 15
        Me.Lsv_Ventas.Row4 = 8
        Me.Lsv_Ventas.Row5 = 15
        Me.Lsv_Ventas.Row6 = 6
        Me.Lsv_Ventas.Row7 = 9
        Me.Lsv_Ventas.Row8 = 6
        Me.Lsv_Ventas.Row9 = 6
        Me.Lsv_Ventas.Size = New System.Drawing.Size(1281, 350)
        Me.Lsv_Ventas.TabIndex = 0
        Me.Lsv_Ventas.UseCompatibleStateImageBehavior = False
        Me.Lsv_Ventas.View = System.Windows.Forms.View.Details
        '
        'Lbl_Registros
        '
        Me.Lbl_Registros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Registros.Location = New System.Drawing.Point(1145, 87)
        Me.Lbl_Registros.Name = "Lbl_Registros"
        Me.Lbl_Registros.Size = New System.Drawing.Size(140, 19)
        Me.Lbl_Registros.TabIndex = 7
        Me.Lbl_Registros.Text = "Registros: 0"
        Me.Lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Gbx_Botones
        '
        Me.Gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Botones.Controls.Add(Me.btn_Exportar)
        Me.Gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.Gbx_Botones.Location = New System.Drawing.Point(4, 490)
        Me.Gbx_Botones.Name = "Gbx_Botones"
        Me.Gbx_Botones.Size = New System.Drawing.Size(1287, 50)
        Me.Gbx_Botones.TabIndex = 4
        Me.Gbx_Botones.TabStop = False
        '
        'btn_Exportar
        '
        Me.btn_Exportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Exportar.Enabled = False
        Me.btn_Exportar.Image = Global.Modulo_MaterialesCentral.My.Resources.Resources.Exportar
        Me.btn_Exportar.Location = New System.Drawing.Point(8, 14)
        Me.btn_Exportar.Name = "btn_Exportar"
        Me.btn_Exportar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Exportar.TabIndex = 0
        Me.btn_Exportar.Text = "&Exportar"
        Me.btn_Exportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Exportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Exportar.UseVisualStyleBackColor = True
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_MaterialesCentral.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(1141, 14)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 1
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'frm_ReporteTraspaso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1295, 561)
        Me.Controls.Add(Me.Gbx_Botones)
        Me.Controls.Add(Me.Lbl_Registros)
        Me.Controls.Add(Me.Gbx_Listado)
        Me.Controls.Add(Me.gbx_Filtro)
        Me.Name = "frm_ReporteTraspaso"
        Me.Tag = "Reporte Traspaso"
        Me.Text = "Reporte Traspaso"
        Me.gbx_Filtro.ResumeLayout(False)
        Me.gbx_Filtro.PerformLayout()
        Me.Gbx_Listado.ResumeLayout(False)
        Me.Gbx_Botones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbx_Filtro As GroupBox
    Friend WithEvents btn_Buscar As Button
    Friend WithEvents dtp_Desde As DateTimePicker
    Friend WithEvents dtp_Hasta As DateTimePicker
    Friend WithEvents Lbl_Hasta As Label
    Friend WithEvents lbl_FechaEnt As Label
    Friend WithEvents Gbx_Listado As GroupBox
    Friend WithEvents Lbl_Registros As Label
    Friend WithEvents Lsv_Ventas As cp_Listview
    Friend WithEvents Gbx_Botones As GroupBox
    Friend WithEvents btn_Exportar As Button
    Friend WithEvents btn_Cerrar As Button
    Friend WithEvents cmb_Status As cp_cmb_Manual
    Friend WithEvents Lbl_Status As Label
End Class
