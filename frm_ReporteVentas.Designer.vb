<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_ReporteVentas
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ReporteVentas))
        Me.Gbx_Botones = New System.Windows.Forms.GroupBox()
        Me.btn_Exportar = New System.Windows.Forms.Button()
        Me.btn_Cerrar = New System.Windows.Forms.Button()
        Me.Gbx_Listado = New System.Windows.Forms.GroupBox()
        Me.Lbl_Registros = New System.Windows.Forms.Label()
        Me.Lsv_Ventas = New Modulo_MaterialesCentral.cp_Listview()
        Me.Gbx_Detalle = New System.Windows.Forms.GroupBox()
        Me.dgv_Detalle = New System.Windows.Forms.DataGridView()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadValidada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadSurtida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Observaciones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Foliado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Folio_Inicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Folio_Fin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gbx_Filtro = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbx_Tipo = New Modulo_MaterialesCentral.cp_cmb_Manual()
        Me.btn_Buscar = New System.Windows.Forms.Button()
        Me.cmb_Status = New Modulo_MaterialesCentral.cp_cmb_Manual()
        Me.dtp_Desde = New System.Windows.Forms.DateTimePicker()
        Me.Lbl_Status = New System.Windows.Forms.Label()
        Me.dtp_Hasta = New System.Windows.Forms.DateTimePicker()
        Me.Lbl_Hasta = New System.Windows.Forms.Label()
        Me.lbl_FechaEnt = New System.Windows.Forms.Label()
        Me.Gbx_Botones.SuspendLayout()
        Me.Gbx_Listado.SuspendLayout()
        Me.Gbx_Detalle.SuspendLayout()
        CType(Me.dgv_Detalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbx_Filtro.SuspendLayout()
        Me.SuspendLayout()
        '
        'Gbx_Botones
        '
        Me.Gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Botones.Controls.Add(Me.btn_Exportar)
        Me.Gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.Gbx_Botones.Location = New System.Drawing.Point(4, 508)
        Me.Gbx_Botones.Name = "Gbx_Botones"
        Me.Gbx_Botones.Size = New System.Drawing.Size(1287, 50)
        Me.Gbx_Botones.TabIndex = 3
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
        'Gbx_Listado
        '
        Me.Gbx_Listado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Listado.Controls.Add(Me.Lbl_Registros)
        Me.Gbx_Listado.Controls.Add(Me.Lsv_Ventas)
        Me.Gbx_Listado.Location = New System.Drawing.Point(4, 113)
        Me.Gbx_Listado.Name = "Gbx_Listado"
        Me.Gbx_Listado.Size = New System.Drawing.Size(1287, 125)
        Me.Gbx_Listado.TabIndex = 1
        Me.Gbx_Listado.TabStop = False
        '
        'Lbl_Registros
        '
        Me.Lbl_Registros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Registros.Location = New System.Drawing.Point(1139, 0)
        Me.Lbl_Registros.Name = "Lbl_Registros"
        Me.Lbl_Registros.Size = New System.Drawing.Size(140, 19)
        Me.Lbl_Registros.TabIndex = 7
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
        Me.Lsv_Ventas.Location = New System.Drawing.Point(8, 19)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.Lsv_Ventas.Lvs = ListViewColumnSorter1
        Me.Lsv_Ventas.MultiSelect = False
        Me.Lsv_Ventas.Name = "Lsv_Ventas"
        Me.Lsv_Ventas.Ocultar = ""
        Me.Lsv_Ventas.Row1 = 15
        Me.Lsv_Ventas.Row10 = 0
        Me.Lsv_Ventas.Row2 = 10
        Me.Lsv_Ventas.Row3 = 25
        Me.Lsv_Ventas.Row4 = 15
        Me.Lsv_Ventas.Row5 = 15
        Me.Lsv_Ventas.Row6 = 0
        Me.Lsv_Ventas.Row7 = 0
        Me.Lsv_Ventas.Row8 = 0
        Me.Lsv_Ventas.Row9 = 0
        Me.Lsv_Ventas.Size = New System.Drawing.Size(1273, 100)
        Me.Lsv_Ventas.TabIndex = 0
        Me.Lsv_Ventas.UseCompatibleStateImageBehavior = False
        Me.Lsv_Ventas.View = System.Windows.Forms.View.Details
        '
        'Gbx_Detalle
        '
        Me.Gbx_Detalle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Detalle.Controls.Add(Me.dgv_Detalle)
        Me.Gbx_Detalle.Location = New System.Drawing.Point(4, 257)
        Me.Gbx_Detalle.Name = "Gbx_Detalle"
        Me.Gbx_Detalle.Size = New System.Drawing.Size(1287, 252)
        Me.Gbx_Detalle.TabIndex = 2
        Me.Gbx_Detalle.TabStop = False
        Me.Gbx_Detalle.Text = "Detalle"
        '
        'dgv_Detalle
        '
        Me.dgv_Detalle.AllowUserToAddRows = False
        Me.dgv_Detalle.AllowUserToDeleteRows = False
        Me.dgv_Detalle.AllowUserToResizeColumns = False
        Me.dgv_Detalle.AllowUserToResizeRows = False
        Me.dgv_Detalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Detalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Descripcion, Me.Cantidad, Me.CantidadValidada, Me.CantidadSurtida, Me.Observaciones, Me.Status, Me.Foliado, Me.Folio_Inicio, Me.Folio_Fin})
        Me.dgv_Detalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_Detalle.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgv_Detalle.Location = New System.Drawing.Point(3, 16)
        Me.dgv_Detalle.Name = "dgv_Detalle"
        Me.dgv_Detalle.RowHeadersVisible = False
        Me.dgv_Detalle.Size = New System.Drawing.Size(1281, 233)
        Me.dgv_Detalle.TabIndex = 1
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
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        Me.Cantidad.Width = 70
        '
        'CantidadValidada
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.CantidadValidada.DefaultCellStyle = DataGridViewCellStyle2
        Me.CantidadValidada.HeaderText = "Cantidad Validada"
        Me.CantidadValidada.Name = "CantidadValidada"
        Me.CantidadValidada.ReadOnly = True
        Me.CantidadValidada.Width = 70
        '
        'CantidadSurtida
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.LightBlue
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CantidadSurtida.DefaultCellStyle = DataGridViewCellStyle3
        Me.CantidadSurtida.HeaderText = "Cantidad Surtida"
        Me.CantidadSurtida.Name = "CantidadSurtida"
        Me.CantidadSurtida.ReadOnly = True
        Me.CantidadSurtida.Width = 70
        '
        'Observaciones
        '
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.LightBlue
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Observaciones.DefaultCellStyle = DataGridViewCellStyle4
        Me.Observaciones.HeaderText = "Observaciones"
        Me.Observaciones.Name = "Observaciones"
        Me.Observaciones.Width = 350
        '
        'Status
        '
        Me.Status.HeaderText = "Status"
        Me.Status.Name = "Status"
        Me.Status.ReadOnly = True
        Me.Status.Width = 80
        '
        'Foliado
        '
        Me.Foliado.HeaderText = "Foliado"
        Me.Foliado.Name = "Foliado"
        Me.Foliado.ReadOnly = True
        '
        'Folio_Inicio
        '
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.LightBlue
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Folio_Inicio.DefaultCellStyle = DataGridViewCellStyle5
        Me.Folio_Inicio.HeaderText = "Folio Inicio"
        Me.Folio_Inicio.Name = "Folio_Inicio"
        '
        'Folio_Fin
        '
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.LightBlue
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Folio_Fin.DefaultCellStyle = DataGridViewCellStyle6
        Me.Folio_Fin.HeaderText = "Folio Fin"
        Me.Folio_Fin.Name = "Folio_Fin"
        '
        'gbx_Filtro
        '
        Me.gbx_Filtro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Filtro.Controls.Add(Me.Label1)
        Me.gbx_Filtro.Controls.Add(Me.cbx_Tipo)
        Me.gbx_Filtro.Controls.Add(Me.btn_Buscar)
        Me.gbx_Filtro.Controls.Add(Me.cmb_Status)
        Me.gbx_Filtro.Controls.Add(Me.Lbl_Status)
        Me.gbx_Filtro.Controls.Add(Me.dtp_Hasta)
        Me.gbx_Filtro.Controls.Add(Me.Lbl_Hasta)
        Me.gbx_Filtro.Controls.Add(Me.dtp_Desde)
        Me.gbx_Filtro.Controls.Add(Me.lbl_FechaEnt)
        Me.gbx_Filtro.Location = New System.Drawing.Point(4, 1)
        Me.gbx_Filtro.Name = "gbx_Filtro"
        Me.gbx_Filtro.Size = New System.Drawing.Size(1287, 109)
        Me.gbx_Filtro.TabIndex = 0
        Me.gbx_Filtro.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Tipo"
        '
        'cbx_Tipo
        '
        Me.cbx_Tipo.Control_Siguiente = Nothing
        Me.cbx_Tipo.DisplayMember = "display"
        Me.cbx_Tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_Tipo.FormattingEnabled = True
        Me.cbx_Tipo.Location = New System.Drawing.Point(91, 43)
        Me.cbx_Tipo.MaxDropDownItems = 20
        Me.cbx_Tipo.Name = "cbx_Tipo"
        Me.cbx_Tipo.Size = New System.Drawing.Size(252, 21)
        Me.cbx_Tipo.TabIndex = 16
        Me.cbx_Tipo.ValueMember = "value"
        '
        'btn_Buscar
        '
        Me.btn_Buscar.Image = Global.Modulo_MaterialesCentral.My.Resources.Resources._1rightarrow1
        Me.btn_Buscar.Location = New System.Drawing.Point(370, 61)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Buscar.TabIndex = 15
        Me.btn_Buscar.Text = "&Buscar"
        Me.btn_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Buscar.UseVisualStyleBackColor = True
        '
        'cmb_Status
        '
        Me.cmb_Status.Control_Siguiente = Me.dtp_Desde
        Me.cmb_Status.DisplayMember = "display"
        Me.cmb_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Status.FormattingEnabled = True
        Me.cmb_Status.Location = New System.Drawing.Point(91, 70)
        Me.cmb_Status.MaxDropDownItems = 20
        Me.cmb_Status.Name = "cmb_Status"
        Me.cmb_Status.Size = New System.Drawing.Size(252, 21)
        Me.cmb_Status.TabIndex = 8
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
        Me.Lbl_Status.Location = New System.Drawing.Point(47, 73)
        Me.Lbl_Status.Name = "Lbl_Status"
        Me.Lbl_Status.Size = New System.Drawing.Size(37, 13)
        Me.Lbl_Status.TabIndex = 7
        Me.Lbl_Status.Text = "Status"
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
        'frm_ReporteVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1295, 562)
        Me.Controls.Add(Me.gbx_Filtro)
        Me.Controls.Add(Me.Gbx_Detalle)
        Me.Controls.Add(Me.Gbx_Listado)
        Me.Controls.Add(Me.Gbx_Botones)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_ReporteVentas"
        Me.Text = "Reporte de Asignaciones de Materiales"
        Me.Gbx_Botones.ResumeLayout(False)
        Me.Gbx_Listado.ResumeLayout(False)
        Me.Gbx_Detalle.ResumeLayout(False)
        CType(Me.dgv_Detalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbx_Filtro.ResumeLayout(False)
        Me.gbx_Filtro.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Exportar As System.Windows.Forms.Button
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents Lsv_Ventas As Modulo_MaterialesCentral.cp_Listview
    Friend WithEvents Gbx_Listado As System.Windows.Forms.GroupBox
    Friend WithEvents Gbx_Detalle As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_Filtro As System.Windows.Forms.GroupBox
    Friend WithEvents dtp_Hasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents Lbl_Hasta As System.Windows.Forms.Label
    Friend WithEvents dtp_Desde As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_FechaEnt As System.Windows.Forms.Label
    Friend WithEvents cmb_Status As Modulo_MaterialesCentral.cp_cmb_Manual
    Friend WithEvents Lbl_Status As System.Windows.Forms.Label
    Friend WithEvents Lbl_Registros As System.Windows.Forms.Label
    Friend WithEvents dgv_Detalle As DataGridView
    Friend WithEvents btn_Buscar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cbx_Tipo As cp_cmb_Manual
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents CantidadValidada As DataGridViewTextBoxColumn
    Friend WithEvents CantidadSurtida As DataGridViewTextBoxColumn
    Friend WithEvents Observaciones As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewTextBoxColumn
    Friend WithEvents Foliado As DataGridViewTextBoxColumn
    Friend WithEvents Folio_Inicio As DataGridViewTextBoxColumn
    Friend WithEvents Folio_Fin As DataGridViewTextBoxColumn
End Class
