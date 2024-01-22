<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_SolicitudMaterialSurtir
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_SolicitudMaterialSurtir))
        Dim ListViewColumnSorter1 As Modulo_MaterialesCentral.ListViewColumnSorter = New Modulo_MaterialesCentral.ListViewColumnSorter()
        Me.Gbx_Lista = New System.Windows.Forms.GroupBox()
        Me.dgv_Detalle = New System.Windows.Forms.DataGridView()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadValidada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadSurtida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Faltantes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Observaciones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Foliado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Folio_Inicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Folio_Fin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Acumulador = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_Cerrar = New System.Windows.Forms.Button()
        Me.btn_Surtir = New System.Windows.Forms.Button()
        Me.BTN_Exportar = New System.Windows.Forms.Button()
        Me.btn_Surtir_local = New System.Windows.Forms.Button()
        Me.Gbx_Botones = New System.Windows.Forms.GroupBox()
        Me.Btn_Parcial = New System.Windows.Forms.Button()
        Me.Lbl_Registros = New System.Windows.Forms.Label()
        Me.btn_Consultar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Gbx_Solicitudes = New System.Windows.Forms.GroupBox()
        Me.cbx_TipoSurtido = New Modulo_MaterialesCentral.cp_cmb_Manual()
        Me.lsv_Solicitudes = New Modulo_MaterialesCentral.cp_Listview()
        Me.Gbx_Lista.SuspendLayout()
        CType(Me.dgv_Detalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gbx_Botones.SuspendLayout()
        Me.Gbx_Solicitudes.SuspendLayout()
        Me.SuspendLayout()
        '
        'Gbx_Lista
        '
        Me.Gbx_Lista.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Lista.Controls.Add(Me.dgv_Detalle)
        Me.Gbx_Lista.Location = New System.Drawing.Point(9, 285)
        Me.Gbx_Lista.Name = "Gbx_Lista"
        Me.Gbx_Lista.Size = New System.Drawing.Size(1011, 364)
        Me.Gbx_Lista.TabIndex = 9
        Me.Gbx_Lista.TabStop = False
        '
        'dgv_Detalle
        '
        Me.dgv_Detalle.AllowUserToAddRows = False
        Me.dgv_Detalle.AllowUserToDeleteRows = False
        Me.dgv_Detalle.AllowUserToResizeColumns = False
        Me.dgv_Detalle.AllowUserToResizeRows = False
        Me.dgv_Detalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Detalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Descripcion, Me.Cantidad, Me.CantidadValidada, Me.CantidadSurtida, Me.Faltantes, Me.Observaciones, Me.Status, Me.Foliado, Me.Folio_Inicio, Me.Folio_Fin, Me.Acumulador})
        Me.dgv_Detalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_Detalle.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgv_Detalle.Location = New System.Drawing.Point(3, 16)
        Me.dgv_Detalle.Name = "dgv_Detalle"
        Me.dgv_Detalle.RowHeadersVisible = False
        Me.dgv_Detalle.Size = New System.Drawing.Size(1005, 345)
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
        Me.CantidadSurtida.MaxInputLength = 5
        Me.CantidadSurtida.Name = "CantidadSurtida"
        Me.CantidadSurtida.Width = 70
        '
        'Faltantes
        '
        Me.Faltantes.HeaderText = "Faltantes"
        Me.Faltantes.Name = "Faltantes"
        Me.Faltantes.ReadOnly = True
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
        'Acumulador
        '
        Me.Acumulador.HeaderText = "Acumulador"
        Me.Acumulador.Name = "Acumulador"
        Me.Acumulador.Visible = False
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_MaterialesCentral.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(868, 14)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 0
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'btn_Surtir
        '
        Me.btn_Surtir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Surtir.Enabled = False
        Me.btn_Surtir.Image = Global.Modulo_MaterialesCentral.My.Resources.Resources.HoraSi
        Me.btn_Surtir.Location = New System.Drawing.Point(6, 14)
        Me.btn_Surtir.Name = "btn_Surtir"
        Me.btn_Surtir.Size = New System.Drawing.Size(140, 30)
        Me.btn_Surtir.TabIndex = 1
        Me.btn_Surtir.Text = "&Agregar Compra"
        Me.btn_Surtir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Surtir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Surtir.UseVisualStyleBackColor = True
        '
        'BTN_Exportar
        '
        Me.BTN_Exportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BTN_Exportar.Enabled = False
        Me.BTN_Exportar.Image = Global.Modulo_MaterialesCentral.My.Resources.Resources.ActualizacionesInstaladas
        Me.BTN_Exportar.Location = New System.Drawing.Point(161, 14)
        Me.BTN_Exportar.Name = "BTN_Exportar"
        Me.BTN_Exportar.Size = New System.Drawing.Size(140, 30)
        Me.BTN_Exportar.TabIndex = 7
        Me.BTN_Exportar.Text = "&Imprimir Formato"
        Me.BTN_Exportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_Exportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_Exportar.UseVisualStyleBackColor = True
        '
        'btn_Surtir_local
        '
        Me.btn_Surtir_local.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Surtir_local.Enabled = False
        Me.btn_Surtir_local.Image = Global.Modulo_MaterialesCentral.My.Resources.Resources.HoraSi
        Me.btn_Surtir_local.Location = New System.Drawing.Point(318, 14)
        Me.btn_Surtir_local.Name = "btn_Surtir_local"
        Me.btn_Surtir_local.Size = New System.Drawing.Size(140, 30)
        Me.btn_Surtir_local.TabIndex = 8
        Me.btn_Surtir_local.Text = "&Surtir_"
        Me.btn_Surtir_local.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Surtir_local.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Surtir_local.UseVisualStyleBackColor = True
        '
        'Gbx_Botones
        '
        Me.Gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Botones.Controls.Add(Me.Btn_Parcial)
        Me.Gbx_Botones.Controls.Add(Me.btn_Surtir_local)
        Me.Gbx_Botones.Controls.Add(Me.BTN_Exportar)
        Me.Gbx_Botones.Controls.Add(Me.btn_Surtir)
        Me.Gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.Gbx_Botones.Location = New System.Drawing.Point(6, 652)
        Me.Gbx_Botones.Name = "Gbx_Botones"
        Me.Gbx_Botones.Size = New System.Drawing.Size(1014, 50)
        Me.Gbx_Botones.TabIndex = 10
        Me.Gbx_Botones.TabStop = False
        '
        'Btn_Parcial
        '
        Me.Btn_Parcial.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn_Parcial.Enabled = False
        Me.Btn_Parcial.Image = Global.Modulo_MaterialesCentral.My.Resources.Resources.HoraSi
        Me.Btn_Parcial.Location = New System.Drawing.Point(474, 14)
        Me.Btn_Parcial.Name = "Btn_Parcial"
        Me.Btn_Parcial.Size = New System.Drawing.Size(140, 30)
        Me.Btn_Parcial.TabIndex = 9
        Me.Btn_Parcial.Text = "&Agregar Parcialidad_"
        Me.Btn_Parcial.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Parcial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Parcial.UseVisualStyleBackColor = True
        '
        'Lbl_Registros
        '
        Me.Lbl_Registros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Registros.Location = New System.Drawing.Point(868, 16)
        Me.Lbl_Registros.Name = "Lbl_Registros"
        Me.Lbl_Registros.Size = New System.Drawing.Size(140, 19)
        Me.Lbl_Registros.TabIndex = 6
        Me.Lbl_Registros.Text = "Registros: 0"
        Me.Lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_Consultar
        '
        Me.btn_Consultar.Image = Global.Modulo_MaterialesCentral.My.Resources.Resources._1rightarrow1
        Me.btn_Consultar.Location = New System.Drawing.Point(332, 4)
        Me.btn_Consultar.Name = "btn_Consultar"
        Me.btn_Consultar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Consultar.TabIndex = 8
        Me.btn_Consultar.Text = "&Consultar"
        Me.btn_Consultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Consultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Consultar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Tipo de Solicitud"
        '
        'Gbx_Solicitudes
        '
        Me.Gbx_Solicitudes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Solicitudes.Controls.Add(Me.Label2)
        Me.Gbx_Solicitudes.Controls.Add(Me.Label1)
        Me.Gbx_Solicitudes.Controls.Add(Me.btn_Consultar)
        Me.Gbx_Solicitudes.Controls.Add(Me.cbx_TipoSurtido)
        Me.Gbx_Solicitudes.Controls.Add(Me.Lbl_Registros)
        Me.Gbx_Solicitudes.Controls.Add(Me.lsv_Solicitudes)
        Me.Gbx_Solicitudes.Location = New System.Drawing.Point(12, 1)
        Me.Gbx_Solicitudes.Name = "Gbx_Solicitudes"
        Me.Gbx_Solicitudes.Size = New System.Drawing.Size(1014, 281)
        Me.Gbx_Solicitudes.TabIndex = 7
        Me.Gbx_Solicitudes.TabStop = False
        '
        'cbx_TipoSurtido
        '
        Me.cbx_TipoSurtido.Control_Siguiente = Nothing
        Me.cbx_TipoSurtido.DisplayMember = "display"
        Me.cbx_TipoSurtido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_TipoSurtido.FormattingEnabled = True
        Me.cbx_TipoSurtido.Location = New System.Drawing.Point(98, 10)
        Me.cbx_TipoSurtido.MaxDropDownItems = 20
        Me.cbx_TipoSurtido.Name = "cbx_TipoSurtido"
        Me.cbx_TipoSurtido.Size = New System.Drawing.Size(228, 21)
        Me.cbx_TipoSurtido.TabIndex = 7
        Me.cbx_TipoSurtido.ValueMember = "value"
        '
        'lsv_Solicitudes
        '
        Me.lsv_Solicitudes.AllowColumnReorder = True
        Me.lsv_Solicitudes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Solicitudes.FullRowSelect = True
        Me.lsv_Solicitudes.HideSelection = False
        Me.lsv_Solicitudes.Location = New System.Drawing.Point(3, 40)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Solicitudes.Lvs = ListViewColumnSorter1
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
        Me.lsv_Solicitudes.Size = New System.Drawing.Size(1005, 238)
        Me.lsv_Solicitudes.TabIndex = 0
        Me.lsv_Solicitudes.UseCompatibleStateImageBehavior = False
        Me.lsv_Solicitudes.View = System.Windows.Forms.View.Details
        '
        'frm_SolicitudMaterialSurtir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 705)
        Me.Controls.Add(Me.Gbx_Botones)
        Me.Controls.Add(Me.Gbx_Lista)
        Me.Controls.Add(Me.Gbx_Solicitudes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_SolicitudMaterialSurtir"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_SolicitudMaterialSurtir"
        Me.Gbx_Lista.ResumeLayout(False)
        CType(Me.dgv_Detalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gbx_Botones.ResumeLayout(False)
        Me.Gbx_Solicitudes.ResumeLayout(False)
        Me.Gbx_Solicitudes.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Gbx_Lista As GroupBox
    Friend WithEvents dgv_Detalle As DataGridView
    Friend WithEvents btn_Cerrar As Button
    Friend WithEvents btn_Surtir As Button
    Friend WithEvents BTN_Exportar As Button
    Friend WithEvents btn_Surtir_local As Button
    Friend WithEvents Gbx_Botones As GroupBox
    Friend WithEvents lsv_Solicitudes As cp_Listview
    Friend WithEvents Lbl_Registros As Label
    Friend WithEvents cbx_TipoSurtido As cp_cmb_Manual
    Friend WithEvents btn_Consultar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Gbx_Solicitudes As GroupBox
    Friend WithEvents Btn_Parcial As Button
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents CantidadValidada As DataGridViewTextBoxColumn
    Friend WithEvents CantidadSurtida As DataGridViewTextBoxColumn
    Friend WithEvents Faltantes As DataGridViewTextBoxColumn
    Friend WithEvents Observaciones As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewTextBoxColumn
    Friend WithEvents Foliado As DataGridViewTextBoxColumn
    Friend WithEvents Folio_Inicio As DataGridViewTextBoxColumn
    Friend WithEvents Folio_Fin As DataGridViewTextBoxColumn
    Friend WithEvents Acumulador As DataGridViewTextBoxColumn
End Class
