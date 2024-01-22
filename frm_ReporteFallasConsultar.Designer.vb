<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ReporteFallasConsultar
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
        Me.gbx_Datos = New System.Windows.Forms.GroupBox
        Me.Lbl_Registros = New System.Windows.Forms.Label
        Me.gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_Exportar = New System.Windows.Forms.Button
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.gbx_Filtro = New System.Windows.Forms.GroupBox
        Me.chk_Fecha = New System.Windows.Forms.CheckBox
        Me.btn_Consultar = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtp_Hasta = New System.Windows.Forms.DateTimePicker
        Me.dtp_Desde = New System.Windows.Forms.DateTimePicker
        Me.gbx_Detalle = New System.Windows.Forms.GroupBox
        Me.lbl_Incidencia = New System.Windows.Forms.Label
        Me.btn_Incidencia = New System.Windows.Forms.Button
        Me.rtb_Incidencia = New System.Windows.Forms.RichTextBox
        Me.dgv_Seguimiento = New System.Windows.Forms.DataGridView
        Me.Lbl_Seguimiento = New System.Windows.Forms.Label
        Me.lbl_Detalle = New System.Windows.Forms.Label
        Me.tbx_Descripcion = New System.Windows.Forms.RichTextBox
        Me.lsv_Datos = New Modulo_MaterialesCentral.cp_Listview
        Me.gbx_Datos.SuspendLayout()
        Me.gbx_Botones.SuspendLayout()
        Me.gbx_Filtro.SuspendLayout()
        Me.gbx_Detalle.SuspendLayout()
        CType(Me.dgv_Seguimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbx_Datos
        '
        Me.gbx_Datos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Datos.Controls.Add(Me.Lbl_Registros)
        Me.gbx_Datos.Controls.Add(Me.lsv_Datos)
        Me.gbx_Datos.Location = New System.Drawing.Point(4, 55)
        Me.gbx_Datos.Name = "gbx_Datos"
        Me.gbx_Datos.Size = New System.Drawing.Size(775, 149)
        Me.gbx_Datos.TabIndex = 1
        Me.gbx_Datos.TabStop = False
        '
        'Lbl_Registros
        '
        Me.Lbl_Registros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Registros.Location = New System.Drawing.Point(624, 12)
        Me.Lbl_Registros.Name = "Lbl_Registros"
        Me.Lbl_Registros.Size = New System.Drawing.Size(140, 19)
        Me.Lbl_Registros.TabIndex = 3
        Me.Lbl_Registros.Text = "Registros: 0"
        Me.Lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'gbx_Botones
        '
        Me.gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Botones.Controls.Add(Me.btn_Exportar)
        Me.gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Botones.Location = New System.Drawing.Point(4, 513)
        Me.gbx_Botones.Name = "gbx_Botones"
        Me.gbx_Botones.Size = New System.Drawing.Size(775, 46)
        Me.gbx_Botones.TabIndex = 3
        Me.gbx_Botones.TabStop = False
        '
        'btn_Exportar
        '
        Me.btn_Exportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Exportar.Enabled = False
        Me.btn_Exportar.Image = Global.Modulo_MaterialesCentral.My.Resources.Resources.Exportar
        Me.btn_Exportar.Location = New System.Drawing.Point(6, 10)
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
        Me.btn_Cerrar.Location = New System.Drawing.Point(629, 10)
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
        Me.gbx_Filtro.Controls.Add(Me.chk_Fecha)
        Me.gbx_Filtro.Controls.Add(Me.btn_Consultar)
        Me.gbx_Filtro.Controls.Add(Me.Label2)
        Me.gbx_Filtro.Controls.Add(Me.Label1)
        Me.gbx_Filtro.Controls.Add(Me.dtp_Hasta)
        Me.gbx_Filtro.Controls.Add(Me.dtp_Desde)
        Me.gbx_Filtro.Location = New System.Drawing.Point(4, 3)
        Me.gbx_Filtro.Name = "gbx_Filtro"
        Me.gbx_Filtro.Size = New System.Drawing.Size(775, 50)
        Me.gbx_Filtro.TabIndex = 0
        Me.gbx_Filtro.TabStop = False
        '
        'chk_Fecha
        '
        Me.chk_Fecha.AutoSize = True
        Me.chk_Fecha.Location = New System.Drawing.Point(340, 20)
        Me.chk_Fecha.Name = "chk_Fecha"
        Me.chk_Fecha.Size = New System.Drawing.Size(56, 17)
        Me.chk_Fecha.TabIndex = 4
        Me.chk_Fecha.Text = "Todas"
        Me.chk_Fecha.UseVisualStyleBackColor = True
        '
        'btn_Consultar
        '
        Me.btn_Consultar.Image = Global.Modulo_MaterialesCentral.My.Resources.Resources._1rightarrow1
        Me.btn_Consultar.Location = New System.Drawing.Point(416, 12)
        Me.btn_Consultar.Name = "btn_Consultar"
        Me.btn_Consultar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Consultar.TabIndex = 5
        Me.btn_Consultar.Text = "&Consultar"
        Me.btn_Consultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Consultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Consultar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(196, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Hasta"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Desde"
        '
        'dtp_Hasta
        '
        Me.dtp_Hasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Hasta.Location = New System.Drawing.Point(237, 17)
        Me.dtp_Hasta.Name = "dtp_Hasta"
        Me.dtp_Hasta.Size = New System.Drawing.Size(97, 20)
        Me.dtp_Hasta.TabIndex = 3
        '
        'dtp_Desde
        '
        Me.dtp_Desde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Desde.Location = New System.Drawing.Point(78, 17)
        Me.dtp_Desde.Name = "dtp_Desde"
        Me.dtp_Desde.Size = New System.Drawing.Size(99, 20)
        Me.dtp_Desde.TabIndex = 1
        '
        'gbx_Detalle
        '
        Me.gbx_Detalle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Detalle.Controls.Add(Me.lbl_Incidencia)
        Me.gbx_Detalle.Controls.Add(Me.btn_Incidencia)
        Me.gbx_Detalle.Controls.Add(Me.rtb_Incidencia)
        Me.gbx_Detalle.Controls.Add(Me.dgv_Seguimiento)
        Me.gbx_Detalle.Controls.Add(Me.Lbl_Seguimiento)
        Me.gbx_Detalle.Controls.Add(Me.lbl_Detalle)
        Me.gbx_Detalle.Controls.Add(Me.tbx_Descripcion)
        Me.gbx_Detalle.Location = New System.Drawing.Point(4, 203)
        Me.gbx_Detalle.Name = "gbx_Detalle"
        Me.gbx_Detalle.Size = New System.Drawing.Size(775, 304)
        Me.gbx_Detalle.TabIndex = 2
        Me.gbx_Detalle.TabStop = False
        '
        'lbl_Incidencia
        '
        Me.lbl_Incidencia.AutoSize = True
        Me.lbl_Incidencia.Location = New System.Drawing.Point(458, 195)
        Me.lbl_Incidencia.Name = "lbl_Incidencia"
        Me.lbl_Incidencia.Size = New System.Drawing.Size(187, 13)
        Me.lbl_Incidencia.TabIndex = 4
        Me.lbl_Incidencia.Text = "Registrar una Incidencia o Comentario"
        '
        'btn_Incidencia
        '
        Me.btn_Incidencia.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Incidencia.Image = Global.Modulo_MaterialesCentral.My.Resources.Resources.Guardar
        Me.btn_Incidencia.Location = New System.Drawing.Point(458, 267)
        Me.btn_Incidencia.Name = "btn_Incidencia"
        Me.btn_Incidencia.Size = New System.Drawing.Size(140, 30)
        Me.btn_Incidencia.TabIndex = 6
        Me.btn_Incidencia.Text = "Reg &Incidencia"
        Me.btn_Incidencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Incidencia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Incidencia.UseVisualStyleBackColor = True
        '
        'rtb_Incidencia
        '
        Me.rtb_Incidencia.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtb_Incidencia.Location = New System.Drawing.Point(458, 212)
        Me.rtb_Incidencia.MaxLength = 5000
        Me.rtb_Incidencia.Name = "rtb_Incidencia"
        Me.rtb_Incidencia.Size = New System.Drawing.Size(311, 49)
        Me.rtb_Incidencia.TabIndex = 5
        Me.rtb_Incidencia.Text = ""
        '
        'dgv_Seguimiento
        '
        Me.dgv_Seguimiento.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_Seguimiento.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgv_Seguimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Seguimiento.Location = New System.Drawing.Point(458, 28)
        Me.dgv_Seguimiento.Name = "dgv_Seguimiento"
        Me.dgv_Seguimiento.Size = New System.Drawing.Size(311, 163)
        Me.dgv_Seguimiento.TabIndex = 3
        '
        'Lbl_Seguimiento
        '
        Me.Lbl_Seguimiento.AutoSize = True
        Me.Lbl_Seguimiento.Location = New System.Drawing.Point(455, 12)
        Me.Lbl_Seguimiento.Name = "Lbl_Seguimiento"
        Me.Lbl_Seguimiento.Size = New System.Drawing.Size(65, 13)
        Me.Lbl_Seguimiento.TabIndex = 2
        Me.Lbl_Seguimiento.Text = "Seguimiento"
        '
        'lbl_Detalle
        '
        Me.lbl_Detalle.AutoSize = True
        Me.lbl_Detalle.Location = New System.Drawing.Point(3, 12)
        Me.lbl_Detalle.Name = "lbl_Detalle"
        Me.lbl_Detalle.Size = New System.Drawing.Size(40, 13)
        Me.lbl_Detalle.TabIndex = 0
        Me.lbl_Detalle.Text = "Detalle"
        '
        'tbx_Descripcion
        '
        Me.tbx_Descripcion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tbx_Descripcion.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_Descripcion.Location = New System.Drawing.Point(6, 28)
        Me.tbx_Descripcion.Name = "tbx_Descripcion"
        Me.tbx_Descripcion.ReadOnly = True
        Me.tbx_Descripcion.Size = New System.Drawing.Size(446, 267)
        Me.tbx_Descripcion.TabIndex = 1
        Me.tbx_Descripcion.TabStop = False
        Me.tbx_Descripcion.Text = ""
        '
        'lsv_Datos
        '
        Me.lsv_Datos.AllowColumnReorder = True
        Me.lsv_Datos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Datos.FullRowSelect = True
        Me.lsv_Datos.HideSelection = False
        Me.lsv_Datos.Location = New System.Drawing.Point(3, 34)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Datos.Lvs = ListViewColumnSorter1
        Me.lsv_Datos.MultiSelect = False
        Me.lsv_Datos.Name = "lsv_Datos"
        Me.lsv_Datos.Ocultar = ""
        Me.lsv_Datos.Row1 = 10
        Me.lsv_Datos.Row10 = 0
        Me.lsv_Datos.Row2 = 10
        Me.lsv_Datos.Row3 = 10
        Me.lsv_Datos.Row4 = 10
        Me.lsv_Datos.Row5 = 20
        Me.lsv_Datos.Row6 = 0
        Me.lsv_Datos.Row7 = 15
        Me.lsv_Datos.Row8 = 10
        Me.lsv_Datos.Row9 = 10
        Me.lsv_Datos.Size = New System.Drawing.Size(769, 109)
        Me.lsv_Datos.TabIndex = 0
        Me.lsv_Datos.Tag = "id_Bitacora"
        Me.lsv_Datos.UseCompatibleStateImageBehavior = False
        Me.lsv_Datos.View = System.Windows.Forms.View.Details
        '
        'frm_ReporteFallasConsultar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.gbx_Detalle)
        Me.Controls.Add(Me.gbx_Filtro)
        Me.Controls.Add(Me.gbx_Botones)
        Me.Controls.Add(Me.gbx_Datos)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_ReporteFallasConsultar"
        Me.Text = "Seguimiento a Reporte de Fallas"
        Me.gbx_Datos.ResumeLayout(False)
        Me.gbx_Botones.ResumeLayout(False)
        Me.gbx_Filtro.ResumeLayout(False)
        Me.gbx_Filtro.PerformLayout()
        Me.gbx_Detalle.ResumeLayout(False)
        Me.gbx_Detalle.PerformLayout()
        CType(Me.dgv_Seguimiento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbx_Datos As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_Datos As Modulo_MaterialesCentral.cp_Listview
    Friend WithEvents gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents gbx_Filtro As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Consultar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtp_Hasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_Desde As System.Windows.Forms.DateTimePicker
    Friend WithEvents btn_Exportar As System.Windows.Forms.Button
    Friend WithEvents gbx_Detalle As System.Windows.Forms.GroupBox
    Friend WithEvents chk_Fecha As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_Detalle As System.Windows.Forms.Label
    Friend WithEvents tbx_Descripcion As System.Windows.Forms.RichTextBox
    Friend WithEvents Lbl_Seguimiento As System.Windows.Forms.Label
    Friend WithEvents dgv_Seguimiento As System.Windows.Forms.DataGridView
    Friend WithEvents btn_Incidencia As System.Windows.Forms.Button
    Friend WithEvents rtb_Incidencia As System.Windows.Forms.RichTextBox
    Friend WithEvents lbl_Incidencia As System.Windows.Forms.Label
    Friend WithEvents Lbl_Registros As System.Windows.Forms.Label
End Class
