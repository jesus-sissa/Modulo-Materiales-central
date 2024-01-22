<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_TraspasosRecibir
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
        Me.gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_Validar = New System.Windows.Forms.Button
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.gbx_Ventas = New System.Windows.Forms.GroupBox
        Me.cmb_Sucursal = New System.Windows.Forms.ComboBox
        Me.lbl_Depto = New System.Windows.Forms.Label
        Me.lbl_TotalVentas = New System.Windows.Forms.Label
        Me.lsv_Traspasos = New Modulo_MaterialesCentral.cp_Listview
        Me.gbx_VentasD = New System.Windows.Forms.GroupBox
        Me.lsv_TraspasosD = New Modulo_MaterialesCentral.cp_Listview
        Me.gbx_Botones.SuspendLayout()
        Me.gbx_Ventas.SuspendLayout()
        Me.gbx_VentasD.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_Botones
        '
        Me.gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Botones.Controls.Add(Me.btn_Validar)
        Me.gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Botones.Location = New System.Drawing.Point(6, 493)
        Me.gbx_Botones.Name = "gbx_Botones"
        Me.gbx_Botones.Size = New System.Drawing.Size(711, 50)
        Me.gbx_Botones.TabIndex = 2
        Me.gbx_Botones.TabStop = False
        '
        'btn_Validar
        '
        Me.btn_Validar.Enabled = False
        Me.btn_Validar.Image = Global.Modulo_MaterialesCentral.My.Resources.Resources.Guardar
        Me.btn_Validar.Location = New System.Drawing.Point(6, 13)
        Me.btn_Validar.Name = "btn_Validar"
        Me.btn_Validar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Validar.TabIndex = 0
        Me.btn_Validar.Text = "&Aceptar"
        Me.btn_Validar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Validar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Validar.UseVisualStyleBackColor = True
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Cerrar.Image = Global.Modulo_MaterialesCentral.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(565, 13)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 1
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'gbx_Ventas
        '
        Me.gbx_Ventas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Ventas.Controls.Add(Me.cmb_Sucursal)
        Me.gbx_Ventas.Controls.Add(Me.lbl_Depto)
        Me.gbx_Ventas.Controls.Add(Me.lbl_TotalVentas)
        Me.gbx_Ventas.Controls.Add(Me.lsv_Traspasos)
        Me.gbx_Ventas.Location = New System.Drawing.Point(6, 2)
        Me.gbx_Ventas.Name = "gbx_Ventas"
        Me.gbx_Ventas.Size = New System.Drawing.Size(711, 294)
        Me.gbx_Ventas.TabIndex = 0
        Me.gbx_Ventas.TabStop = False
        '
        'cmb_Sucursal
        '
        Me.cmb_Sucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Sucursal.FormattingEnabled = True
        Me.cmb_Sucursal.Location = New System.Drawing.Point(109, 19)
        Me.cmb_Sucursal.MaxDropDownItems = 20
        Me.cmb_Sucursal.Name = "cmb_Sucursal"
        Me.cmb_Sucursal.Size = New System.Drawing.Size(357, 21)
        Me.cmb_Sucursal.TabIndex = 1
        '
        'lbl_Depto
        '
        Me.lbl_Depto.AutoSize = True
        Me.lbl_Depto.Location = New System.Drawing.Point(21, 22)
        Me.lbl_Depto.Name = "lbl_Depto"
        Me.lbl_Depto.Size = New System.Drawing.Size(82, 13)
        Me.lbl_Depto.TabIndex = 0
        Me.lbl_Depto.Text = "Sucursal Origen"
        '
        'lbl_TotalVentas
        '
        Me.lbl_TotalVentas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_TotalVentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TotalVentas.Location = New System.Drawing.Point(592, 32)
        Me.lbl_TotalVentas.Name = "lbl_TotalVentas"
        Me.lbl_TotalVentas.Size = New System.Drawing.Size(113, 15)
        Me.lbl_TotalVentas.TabIndex = 2
        Me.lbl_TotalVentas.Text = "Por Validar: "
        Me.lbl_TotalVentas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lsv_Traspasos
        '
        Me.lsv_Traspasos.AllowColumnReorder = True
        Me.lsv_Traspasos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Traspasos.FullRowSelect = True
        Me.lsv_Traspasos.HideSelection = False
        Me.lsv_Traspasos.Location = New System.Drawing.Point(6, 50)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Traspasos.Lvs = ListViewColumnSorter1
        Me.lsv_Traspasos.MultiSelect = False
        Me.lsv_Traspasos.Name = "lsv_Traspasos"
        Me.lsv_Traspasos.Ocultar = ""
        Me.lsv_Traspasos.Row1 = 10
        Me.lsv_Traspasos.Row10 = 0
        Me.lsv_Traspasos.Row2 = 10
        Me.lsv_Traspasos.Row3 = 20
        Me.lsv_Traspasos.Row4 = 20
        Me.lsv_Traspasos.Row5 = 30
        Me.lsv_Traspasos.Row6 = 0
        Me.lsv_Traspasos.Row7 = 0
        Me.lsv_Traspasos.Row8 = 0
        Me.lsv_Traspasos.Row9 = 0
        Me.lsv_Traspasos.Size = New System.Drawing.Size(699, 238)
        Me.lsv_Traspasos.TabIndex = 3
        Me.lsv_Traspasos.UseCompatibleStateImageBehavior = False
        Me.lsv_Traspasos.View = System.Windows.Forms.View.Details
        '
        'gbx_VentasD
        '
        Me.gbx_VentasD.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_VentasD.Controls.Add(Me.lsv_TraspasosD)
        Me.gbx_VentasD.Location = New System.Drawing.Point(6, 302)
        Me.gbx_VentasD.Name = "gbx_VentasD"
        Me.gbx_VentasD.Size = New System.Drawing.Size(711, 189)
        Me.gbx_VentasD.TabIndex = 1
        Me.gbx_VentasD.TabStop = False
        Me.gbx_VentasD.Text = "Detalle"
        '
        'lsv_TraspasosD
        '
        Me.lsv_TraspasosD.AllowColumnReorder = True
        Me.lsv_TraspasosD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lsv_TraspasosD.FullRowSelect = True
        Me.lsv_TraspasosD.HideSelection = False
        Me.lsv_TraspasosD.Location = New System.Drawing.Point(3, 16)
        ListViewColumnSorter2.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter2.SortColumn = 0
        Me.lsv_TraspasosD.Lvs = ListViewColumnSorter2
        Me.lsv_TraspasosD.MultiSelect = False
        Me.lsv_TraspasosD.Name = "lsv_TraspasosD"
        Me.lsv_TraspasosD.Ocultar = ""
        Me.lsv_TraspasosD.Row1 = 40
        Me.lsv_TraspasosD.Row10 = 0
        Me.lsv_TraspasosD.Row2 = 20
        Me.lsv_TraspasosD.Row3 = 0
        Me.lsv_TraspasosD.Row4 = 0
        Me.lsv_TraspasosD.Row5 = 0
        Me.lsv_TraspasosD.Row6 = 0
        Me.lsv_TraspasosD.Row7 = 0
        Me.lsv_TraspasosD.Row8 = 0
        Me.lsv_TraspasosD.Row9 = 0
        Me.lsv_TraspasosD.Size = New System.Drawing.Size(705, 170)
        Me.lsv_TraspasosD.TabIndex = 0
        Me.lsv_TraspasosD.TabStop = False
        Me.lsv_TraspasosD.UseCompatibleStateImageBehavior = False
        Me.lsv_TraspasosD.View = System.Windows.Forms.View.Details
        '
        'frm_TraspasosRecibir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btn_Cerrar
        Me.ClientSize = New System.Drawing.Size(722, 550)
        Me.Controls.Add(Me.gbx_VentasD)
        Me.Controls.Add(Me.gbx_Ventas)
        Me.Controls.Add(Me.gbx_Botones)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(730, 577)
        Me.Name = "frm_TraspasosRecibir"
        Me.Text = "Recibir Material de Otra Sucursal"
        Me.gbx_Botones.ResumeLayout(False)
        Me.gbx_Ventas.ResumeLayout(False)
        Me.gbx_Ventas.PerformLayout()
        Me.gbx_VentasD.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lsv_Traspasos As Modulo_MaterialesCentral.cp_Listview
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_Validar As System.Windows.Forms.Button
    Friend WithEvents lsv_TraspasosD As Modulo_MaterialesCentral.cp_Listview
    Friend WithEvents gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_Ventas As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_TotalVentas As System.Windows.Forms.Label
    Friend WithEvents gbx_VentasD As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_Sucursal As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_Depto As System.Windows.Forms.Label
End Class
