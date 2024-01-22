<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ConsultaOrdenServicio
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
        Me.Gbx_Filtro = New System.Windows.Forms.GroupBox
        Me.btn_Mostrar = New System.Windows.Forms.Button
        Me.chk_Proveedor = New System.Windows.Forms.CheckBox
        Me.lbl_prov = New System.Windows.Forms.Label
        Me.cmb_Proveedores = New Modulo_MaterialesCentral.cp_cmb_SimpleFiltradoParam
        Me.Lbl_Hasta = New System.Windows.Forms.Label
        Me.dtp_Fechafin = New System.Windows.Forms.DateTimePicker
        Me.Lbl_Desde = New System.Windows.Forms.Label
        Me.dtp_FechaInicio = New System.Windows.Forms.DateTimePicker
        Me.lbl_Registros = New System.Windows.Forms.Label
        Me.Gbx_Listado = New System.Windows.Forms.GroupBox
        Me.lsv_proveedores = New Modulo_MaterialesCentral.cp_Listview
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.btn_Imprimir = New System.Windows.Forms.Button
        Me.btn_Exportar = New System.Windows.Forms.Button
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.Gbx_Filtro.SuspendLayout()
        Me.Gbx_Listado.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Gbx_Filtro
        '
        Me.Gbx_Filtro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Filtro.Controls.Add(Me.btn_Mostrar)
        Me.Gbx_Filtro.Controls.Add(Me.chk_Proveedor)
        Me.Gbx_Filtro.Controls.Add(Me.lbl_prov)
        Me.Gbx_Filtro.Controls.Add(Me.cmb_Proveedores)
        Me.Gbx_Filtro.Controls.Add(Me.Lbl_Hasta)
        Me.Gbx_Filtro.Controls.Add(Me.dtp_Fechafin)
        Me.Gbx_Filtro.Controls.Add(Me.Lbl_Desde)
        Me.Gbx_Filtro.Controls.Add(Me.dtp_FechaInicio)
        Me.Gbx_Filtro.Location = New System.Drawing.Point(8, 5)
        Me.Gbx_Filtro.Name = "Gbx_Filtro"
        Me.Gbx_Filtro.Size = New System.Drawing.Size(779, 82)
        Me.Gbx_Filtro.TabIndex = 0
        Me.Gbx_Filtro.TabStop = False
        '
        'btn_Mostrar
        '
        Me.btn_Mostrar.Image = Global.Modulo_MaterialesCentral.My.Resources.Resources._1rightarrow
        Me.btn_Mostrar.Location = New System.Drawing.Point(548, 40)
        Me.btn_Mostrar.Name = "btn_Mostrar"
        Me.btn_Mostrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Mostrar.TabIndex = 7
        Me.btn_Mostrar.Text = "&Mostrar"
        Me.btn_Mostrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Mostrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Mostrar.UseVisualStyleBackColor = True
        '
        'chk_Proveedor
        '
        Me.chk_Proveedor.AutoSize = True
        Me.chk_Proveedor.Location = New System.Drawing.Point(477, 48)
        Me.chk_Proveedor.Name = "chk_Proveedor"
        Me.chk_Proveedor.Size = New System.Drawing.Size(56, 17)
        Me.chk_Proveedor.TabIndex = 6
        Me.chk_Proveedor.Text = "Todos"
        Me.chk_Proveedor.UseVisualStyleBackColor = True
        '
        'lbl_prov
        '
        Me.lbl_prov.AutoSize = True
        Me.lbl_prov.Location = New System.Drawing.Point(9, 49)
        Me.lbl_prov.Name = "lbl_prov"
        Me.lbl_prov.Size = New System.Drawing.Size(59, 13)
        Me.lbl_prov.TabIndex = 4
        Me.lbl_prov.Text = "Proveedor:"
        '
        'cmb_Proveedores
        '
        Me.cmb_Proveedores.Clave = Nothing
        Me.cmb_Proveedores.Control_Siguiente = Nothing
        Me.cmb_Proveedores.DisplayMember = "Nombre"
        Me.cmb_Proveedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Proveedores.Empresa = True
        Me.cmb_Proveedores.Filtro = Nothing
        Me.cmb_Proveedores.FormattingEnabled = True
        Me.cmb_Proveedores.Location = New System.Drawing.Point(71, 46)
        Me.cmb_Proveedores.MaxDropDownItems = 20
        Me.cmb_Proveedores.Name = "cmb_Proveedores"
        Me.cmb_Proveedores.Pista = False
        Me.cmb_Proveedores.Size = New System.Drawing.Size(400, 21)
        Me.cmb_Proveedores.StoredProcedure = "Cat_ProveedoresCombo_Get"
        Me.cmb_Proveedores.Sucursal = False
        Me.cmb_Proveedores.TabIndex = 5
        Me.cmb_Proveedores.Tipo = 0
        Me.cmb_Proveedores.ValueMember = "Id_Proveedor"
        '
        'Lbl_Hasta
        '
        Me.Lbl_Hasta.AutoSize = True
        Me.Lbl_Hasta.Location = New System.Drawing.Point(176, 20)
        Me.Lbl_Hasta.Name = "Lbl_Hasta"
        Me.Lbl_Hasta.Size = New System.Drawing.Size(35, 13)
        Me.Lbl_Hasta.TabIndex = 2
        Me.Lbl_Hasta.Text = "Hasta"
        '
        'dtp_Fechafin
        '
        Me.dtp_Fechafin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Fechafin.Location = New System.Drawing.Point(217, 16)
        Me.dtp_Fechafin.Name = "dtp_Fechafin"
        Me.dtp_Fechafin.Size = New System.Drawing.Size(99, 20)
        Me.dtp_Fechafin.TabIndex = 3
        '
        'Lbl_Desde
        '
        Me.Lbl_Desde.AutoSize = True
        Me.Lbl_Desde.Location = New System.Drawing.Point(27, 20)
        Me.Lbl_Desde.Name = "Lbl_Desde"
        Me.Lbl_Desde.Size = New System.Drawing.Size(41, 13)
        Me.Lbl_Desde.TabIndex = 0
        Me.Lbl_Desde.Text = "Desde:"
        '
        'dtp_FechaInicio
        '
        Me.dtp_FechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaInicio.Location = New System.Drawing.Point(71, 16)
        Me.dtp_FechaInicio.Name = "dtp_FechaInicio"
        Me.dtp_FechaInicio.Size = New System.Drawing.Size(99, 20)
        Me.dtp_FechaInicio.TabIndex = 1
        '
        'lbl_Registros
        '
        Me.lbl_Registros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Registros.Location = New System.Drawing.Point(623, 16)
        Me.lbl_Registros.Name = "lbl_Registros"
        Me.lbl_Registros.Size = New System.Drawing.Size(150, 23)
        Me.lbl_Registros.TabIndex = 8
        Me.lbl_Registros.Text = "Registros: 0"
        Me.lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Gbx_Listado
        '
        Me.Gbx_Listado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Listado.Controls.Add(Me.lbl_Registros)
        Me.Gbx_Listado.Controls.Add(Me.lsv_proveedores)
        Me.Gbx_Listado.Location = New System.Drawing.Point(8, 93)
        Me.Gbx_Listado.Name = "Gbx_Listado"
        Me.Gbx_Listado.Size = New System.Drawing.Size(779, 418)
        Me.Gbx_Listado.TabIndex = 1
        Me.Gbx_Listado.TabStop = False
        '
        'lsv_proveedores
        '
        Me.lsv_proveedores.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_proveedores.FullRowSelect = True
        Me.lsv_proveedores.HideSelection = False
        Me.lsv_proveedores.Location = New System.Drawing.Point(6, 42)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_proveedores.Lvs = ListViewColumnSorter1
        Me.lsv_proveedores.MultiSelect = False
        Me.lsv_proveedores.Name = "lsv_proveedores"
        Me.lsv_proveedores.Ocultar = ""
        Me.lsv_proveedores.Row1 = 10
        Me.lsv_proveedores.Row10 = 10
        Me.lsv_proveedores.Row2 = 10
        Me.lsv_proveedores.Row3 = 10
        Me.lsv_proveedores.Row4 = 20
        Me.lsv_proveedores.Row5 = 15
        Me.lsv_proveedores.Row6 = 12
        Me.lsv_proveedores.Row7 = 12
        Me.lsv_proveedores.Row8 = 10
        Me.lsv_proveedores.Row9 = 10
        Me.lsv_proveedores.Size = New System.Drawing.Size(768, 370)
        Me.lsv_proveedores.TabIndex = 0
        Me.lsv_proveedores.UseCompatibleStateImageBehavior = False
        Me.lsv_proveedores.View = System.Windows.Forms.View.Details
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.btn_Imprimir)
        Me.GroupBox3.Controls.Add(Me.btn_Exportar)
        Me.GroupBox3.Controls.Add(Me.btn_Cerrar)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 512)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(779, 50)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        '
        'btn_Imprimir
        '
        Me.btn_Imprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Imprimir.Enabled = False
        Me.btn_Imprimir.Image = Global.Modulo_MaterialesCentral.My.Resources.Resources.Imprimir
        Me.btn_Imprimir.Location = New System.Drawing.Point(6, 14)
        Me.btn_Imprimir.Name = "btn_Imprimir"
        Me.btn_Imprimir.Size = New System.Drawing.Size(140, 30)
        Me.btn_Imprimir.TabIndex = 0
        Me.btn_Imprimir.Text = "&Reimprimir"
        Me.btn_Imprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Imprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Imprimir.UseVisualStyleBackColor = True
        '
        'btn_Exportar
        '
        Me.btn_Exportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Exportar.Enabled = False
        Me.btn_Exportar.Image = Global.Modulo_MaterialesCentral.My.Resources.Resources.Exportar
        Me.btn_Exportar.Location = New System.Drawing.Point(152, 14)
        Me.btn_Exportar.Name = "btn_Exportar"
        Me.btn_Exportar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Exportar.TabIndex = 1
        Me.btn_Exportar.Text = "&Exportar"
        Me.btn_Exportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Exportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Exportar.UseVisualStyleBackColor = True
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Cerrar.Image = Global.Modulo_MaterialesCentral.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(633, 14)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 2
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'frm_ConsultaOrdenServicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(794, 571)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Gbx_Listado)
        Me.Controls.Add(Me.Gbx_Filtro)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_ConsultaOrdenServicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta Orden de Servicio"
        Me.Gbx_Filtro.ResumeLayout(False)
        Me.Gbx_Filtro.PerformLayout()
        Me.Gbx_Listado.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Gbx_Filtro As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl_Hasta As System.Windows.Forms.Label
    Friend WithEvents dtp_Fechafin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Lbl_Desde As System.Windows.Forms.Label
    Friend WithEvents dtp_FechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_prov As System.Windows.Forms.Label
    Friend WithEvents cmb_Proveedores As Modulo_MaterialesCentral.cp_cmb_SimpleFiltradoParam
    Friend WithEvents chk_Proveedor As System.Windows.Forms.CheckBox
    Friend WithEvents btn_Mostrar As System.Windows.Forms.Button
    Friend WithEvents Gbx_Listado As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_proveedores As Modulo_MaterialesCentral.cp_Listview
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Imprimir As System.Windows.Forms.Button
    Friend WithEvents btn_Exportar As System.Windows.Forms.Button
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents lbl_Registros As System.Windows.Forms.Label
End Class
