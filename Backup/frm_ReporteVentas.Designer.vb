<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ReporteVentas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ReporteVentas))
        Dim ListViewColumnSorter2 As Modulo_MaterialesCentral.ListViewColumnSorter = New Modulo_MaterialesCentral.ListViewColumnSorter
        Dim ListViewColumnSorter3 As Modulo_MaterialesCentral.ListViewColumnSorter = New Modulo_MaterialesCentral.ListViewColumnSorter
        Dim ListViewColumnSorter1 As Modulo_MaterialesCentral.ListViewColumnSorter = New Modulo_MaterialesCentral.ListViewColumnSorter
        Me.Gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_Exportar = New System.Windows.Forms.Button
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.Gbx_Listado = New System.Windows.Forms.GroupBox
        Me.Lbl_Registros = New System.Windows.Forms.Label
        Me.Gbx_Detalle = New System.Windows.Forms.GroupBox
        Me.lbl_Folios = New System.Windows.Forms.Label
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.gbx_Filtro = New System.Windows.Forms.GroupBox
        Me.cbx_Depto = New System.Windows.Forms.CheckBox
        Me.cbx_Status = New System.Windows.Forms.CheckBox
        Me.dtp_Desde = New System.Windows.Forms.DateTimePicker
        Me.Lbl_Status = New System.Windows.Forms.Label
        Me.dtp_Hasta = New System.Windows.Forms.DateTimePicker
        Me.Lbl_Hasta = New System.Windows.Forms.Label
        Me.btn_Mostrar = New System.Windows.Forms.Button
        Me.lbl_FechaEnt = New System.Windows.Forms.Label
        Me.lbl_Depto = New System.Windows.Forms.Label
        Me.cmb_Status = New Modulo_MaterialesCentral.cp_cmb_Manual
        Me.cmb_Depto = New Modulo_MaterialesCentral.cp_cmb_Manual
        Me.lsv_VentasD = New Modulo_MaterialesCentral.cp_Listview
        Me.lsv_Folios = New Modulo_MaterialesCentral.cp_Listview
        Me.Lsv_Ventas = New Modulo_MaterialesCentral.cp_Listview
        Me.Gbx_Botones.SuspendLayout()
        Me.Gbx_Listado.SuspendLayout()
        Me.Gbx_Detalle.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
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
        Me.Gbx_Botones.Size = New System.Drawing.Size(776, 50)
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
        Me.btn_Cerrar.Location = New System.Drawing.Point(630, 14)
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
        Me.Gbx_Listado.Size = New System.Drawing.Size(776, 195)
        Me.Gbx_Listado.TabIndex = 1
        Me.Gbx_Listado.TabStop = False
        Me.Gbx_Listado.Text = "Asignaciones"
        '
        'Lbl_Registros
        '
        Me.Lbl_Registros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Registros.Location = New System.Drawing.Point(628, 16)
        Me.Lbl_Registros.Name = "Lbl_Registros"
        Me.Lbl_Registros.Size = New System.Drawing.Size(140, 19)
        Me.Lbl_Registros.TabIndex = 7
        Me.Lbl_Registros.Text = "Registros: 0"
        Me.Lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Gbx_Detalle
        '
        Me.Gbx_Detalle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Detalle.Controls.Add(Me.lbl_Folios)
        Me.Gbx_Detalle.Controls.Add(Me.TableLayoutPanel1)
        Me.Gbx_Detalle.Location = New System.Drawing.Point(4, 314)
        Me.Gbx_Detalle.Name = "Gbx_Detalle"
        Me.Gbx_Detalle.Size = New System.Drawing.Size(776, 195)
        Me.Gbx_Detalle.TabIndex = 2
        Me.Gbx_Detalle.TabStop = False
        Me.Gbx_Detalle.Text = "Detalle"
        '
        'lbl_Folios
        '
        Me.lbl_Folios.AutoSize = True
        Me.lbl_Folios.Location = New System.Drawing.Point(387, 13)
        Me.lbl_Folios.Name = "lbl_Folios"
        Me.lbl_Folios.Size = New System.Drawing.Size(37, 13)
        Me.lbl_Folios.TabIndex = 2
        Me.lbl_Folios.Text = "Folios:"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lsv_VentasD, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lsv_Folios, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(6, 29)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(762, 159)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'gbx_Filtro
        '
        Me.gbx_Filtro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Filtro.Controls.Add(Me.cbx_Depto)
        Me.gbx_Filtro.Controls.Add(Me.cbx_Status)
        Me.gbx_Filtro.Controls.Add(Me.cmb_Status)
        Me.gbx_Filtro.Controls.Add(Me.Lbl_Status)
        Me.gbx_Filtro.Controls.Add(Me.dtp_Hasta)
        Me.gbx_Filtro.Controls.Add(Me.Lbl_Hasta)
        Me.gbx_Filtro.Controls.Add(Me.cmb_Depto)
        Me.gbx_Filtro.Controls.Add(Me.btn_Mostrar)
        Me.gbx_Filtro.Controls.Add(Me.dtp_Desde)
        Me.gbx_Filtro.Controls.Add(Me.lbl_FechaEnt)
        Me.gbx_Filtro.Controls.Add(Me.lbl_Depto)
        Me.gbx_Filtro.Location = New System.Drawing.Point(4, 1)
        Me.gbx_Filtro.Name = "gbx_Filtro"
        Me.gbx_Filtro.Size = New System.Drawing.Size(776, 108)
        Me.gbx_Filtro.TabIndex = 0
        Me.gbx_Filtro.TabStop = False
        '
        'cbx_Depto
        '
        Me.cbx_Depto.AutoSize = True
        Me.cbx_Depto.Location = New System.Drawing.Point(341, 45)
        Me.cbx_Depto.Name = "cbx_Depto"
        Me.cbx_Depto.Size = New System.Drawing.Size(56, 17)
        Me.cbx_Depto.TabIndex = 2
        Me.cbx_Depto.Text = "Todos"
        Me.cbx_Depto.UseVisualStyleBackColor = True
        '
        'cbx_Status
        '
        Me.cbx_Status.AutoSize = True
        Me.cbx_Status.Location = New System.Drawing.Point(341, 73)
        Me.cbx_Status.Name = "cbx_Status"
        Me.cbx_Status.Size = New System.Drawing.Size(56, 17)
        Me.cbx_Status.TabIndex = 9
        Me.cbx_Status.Text = "Todos"
        Me.cbx_Status.UseVisualStyleBackColor = True
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
        Me.Lbl_Status.Location = New System.Drawing.Point(48, 73)
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
        'btn_Mostrar
        '
        Me.btn_Mostrar.Image = Global.Modulo_MaterialesCentral.My.Resources.Resources._1rightarrow1
        Me.btn_Mostrar.Location = New System.Drawing.Point(403, 61)
        Me.btn_Mostrar.Name = "btn_Mostrar"
        Me.btn_Mostrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Mostrar.TabIndex = 10
        Me.btn_Mostrar.Text = "&Mostrar"
        Me.btn_Mostrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Mostrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Mostrar.UseVisualStyleBackColor = True
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
        'lbl_Depto
        '
        Me.lbl_Depto.AutoSize = True
        Me.lbl_Depto.Location = New System.Drawing.Point(11, 46)
        Me.lbl_Depto.Name = "lbl_Depto"
        Me.lbl_Depto.Size = New System.Drawing.Size(74, 13)
        Me.lbl_Depto.TabIndex = 0
        Me.lbl_Depto.Text = "Departamento"
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
        Me.cmb_Status.Size = New System.Drawing.Size(244, 21)
        Me.cmb_Status.TabIndex = 8
        Me.cmb_Status.ValueMember = "value"
        '
        'cmb_Depto
        '
        Me.cmb_Depto.Control_Siguiente = Me.dtp_Desde
        Me.cmb_Depto.DisplayMember = "display"
        Me.cmb_Depto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Depto.FormattingEnabled = True
        Me.cmb_Depto.Location = New System.Drawing.Point(91, 43)
        Me.cmb_Depto.MaxDropDownItems = 20
        Me.cmb_Depto.Name = "cmb_Depto"
        Me.cmb_Depto.Size = New System.Drawing.Size(244, 21)
        Me.cmb_Depto.TabIndex = 1
        Me.cmb_Depto.ValueMember = "value"
        '
        'lsv_VentasD
        '
        Me.lsv_VentasD.AllowColumnReorder = True
        Me.lsv_VentasD.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_VentasD.FullRowSelect = True
        Me.lsv_VentasD.HideSelection = False
        Me.lsv_VentasD.Location = New System.Drawing.Point(3, 3)
        ListViewColumnSorter2.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter2.SortColumn = 0
        Me.lsv_VentasD.Lvs = ListViewColumnSorter2
        Me.lsv_VentasD.MultiSelect = False
        Me.lsv_VentasD.Name = "lsv_VentasD"
        Me.lsv_VentasD.Ocultar = ""
        Me.lsv_VentasD.Row1 = 20
        Me.lsv_VentasD.Row10 = 0
        Me.lsv_VentasD.Row2 = 50
        Me.lsv_VentasD.Row3 = 25
        Me.lsv_VentasD.Row4 = 0
        Me.lsv_VentasD.Row5 = 0
        Me.lsv_VentasD.Row6 = 0
        Me.lsv_VentasD.Row7 = 0
        Me.lsv_VentasD.Row8 = 0
        Me.lsv_VentasD.Row9 = 0
        Me.lsv_VentasD.Size = New System.Drawing.Size(375, 153)
        Me.lsv_VentasD.TabIndex = 0
        Me.lsv_VentasD.TabStop = False
        Me.lsv_VentasD.UseCompatibleStateImageBehavior = False
        Me.lsv_VentasD.View = System.Windows.Forms.View.Details
        '
        'lsv_Folios
        '
        Me.lsv_Folios.AllowColumnReorder = True
        Me.lsv_Folios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Folios.FullRowSelect = True
        Me.lsv_Folios.HideSelection = False
        Me.lsv_Folios.Location = New System.Drawing.Point(384, 3)
        ListViewColumnSorter3.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter3.SortColumn = 0
        Me.lsv_Folios.Lvs = ListViewColumnSorter3
        Me.lsv_Folios.MultiSelect = False
        Me.lsv_Folios.Name = "lsv_Folios"
        Me.lsv_Folios.Ocultar = ""
        Me.lsv_Folios.Row1 = 30
        Me.lsv_Folios.Row10 = 0
        Me.lsv_Folios.Row2 = 20
        Me.lsv_Folios.Row3 = 20
        Me.lsv_Folios.Row4 = 20
        Me.lsv_Folios.Row5 = 0
        Me.lsv_Folios.Row6 = 0
        Me.lsv_Folios.Row7 = 0
        Me.lsv_Folios.Row8 = 0
        Me.lsv_Folios.Row9 = 0
        Me.lsv_Folios.Size = New System.Drawing.Size(375, 153)
        Me.lsv_Folios.TabIndex = 0
        Me.lsv_Folios.TabStop = False
        Me.lsv_Folios.UseCompatibleStateImageBehavior = False
        Me.lsv_Folios.View = System.Windows.Forms.View.Details
        '
        'Lsv_Ventas
        '
        Me.Lsv_Ventas.AllowColumnReorder = True
        Me.Lsv_Ventas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lsv_Ventas.FullRowSelect = True
        Me.Lsv_Ventas.HideSelection = False
        Me.Lsv_Ventas.Location = New System.Drawing.Point(8, 38)
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
        Me.Lsv_Ventas.Size = New System.Drawing.Size(762, 151)
        Me.Lsv_Ventas.TabIndex = 0
        Me.Lsv_Ventas.UseCompatibleStateImageBehavior = False
        Me.Lsv_Ventas.View = System.Windows.Forms.View.Details
        '
        'frm_ReporteVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
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
        Me.Gbx_Detalle.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.gbx_Filtro.ResumeLayout(False)
        Me.gbx_Filtro.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Exportar As System.Windows.Forms.Button
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents lsv_VentasD As Modulo_MaterialesCentral.cp_Listview
    Friend WithEvents Lsv_Ventas As Modulo_MaterialesCentral.cp_Listview
    Friend WithEvents Gbx_Listado As System.Windows.Forms.GroupBox
    Friend WithEvents Gbx_Detalle As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_Filtro As System.Windows.Forms.GroupBox
    Friend WithEvents dtp_Hasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents Lbl_Hasta As System.Windows.Forms.Label
    Friend WithEvents cmb_Depto As Modulo_MaterialesCentral.cp_cmb_Manual
    Friend WithEvents dtp_Desde As System.Windows.Forms.DateTimePicker
    Friend WithEvents btn_Mostrar As System.Windows.Forms.Button
    Friend WithEvents lbl_FechaEnt As System.Windows.Forms.Label
    Friend WithEvents lbl_Depto As System.Windows.Forms.Label
    Friend WithEvents cmb_Status As Modulo_MaterialesCentral.cp_cmb_Manual
    Friend WithEvents Lbl_Status As System.Windows.Forms.Label
    Friend WithEvents cbx_Depto As System.Windows.Forms.CheckBox
    Friend WithEvents cbx_Status As System.Windows.Forms.CheckBox
    Friend WithEvents lsv_Folios As Modulo_MaterialesCentral.cp_Listview
    Friend WithEvents Lbl_Registros As System.Windows.Forms.Label
    Friend WithEvents lbl_Folios As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
End Class
