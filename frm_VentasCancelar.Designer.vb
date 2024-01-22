<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_VentasCancelar
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
        Dim ListViewColumnSorter3 As Modulo_MaterialesCentral.ListViewColumnSorter = New Modulo_MaterialesCentral.ListViewColumnSorter
        Me.Gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_Cancelar = New System.Windows.Forms.Button
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.Lbl_Material = New System.Windows.Forms.Label
        Me.Lbl_Folios = New System.Windows.Forms.Label
        Me.Lbl_Registros = New System.Windows.Forms.Label
        Me.lsv_Folios = New Modulo_MaterialesCentral.cp_Listview
        Me.lsv_VentasD = New Modulo_MaterialesCentral.cp_Listview
        Me.Lsv_Ventas = New Modulo_MaterialesCentral.cp_Listview
        Me.Gbx_Botones.SuspendLayout()
        Me.SuspendLayout()
        '
        'Gbx_Botones
        '
        Me.Gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Botones.Controls.Add(Me.btn_Cancelar)
        Me.Gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.Gbx_Botones.Location = New System.Drawing.Point(5, 506)
        Me.Gbx_Botones.Name = "Gbx_Botones"
        Me.Gbx_Botones.Size = New System.Drawing.Size(770, 50)
        Me.Gbx_Botones.TabIndex = 47
        Me.Gbx_Botones.TabStop = False
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Cancelar.Enabled = False
        Me.btn_Cancelar.Image = Global.Modulo_MaterialesCentral.My.Resources.Resources.Cancelar
        Me.btn_Cancelar.Location = New System.Drawing.Point(8, 14)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cancelar.TabIndex = 5
        Me.btn_Cancelar.Text = "&Cancelar"
        Me.btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_MaterialesCentral.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(624, 14)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 6
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'Lbl_Material
        '
        Me.Lbl_Material.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Material.AutoSize = True
        Me.Lbl_Material.Location = New System.Drawing.Point(2, 336)
        Me.Lbl_Material.Name = "Lbl_Material"
        Me.Lbl_Material.Size = New System.Drawing.Size(163, 13)
        Me.Lbl_Material.TabIndex = 49
        Me.Lbl_Material.Text = "Material en el Lote seleccionado:"
        '
        'Lbl_Folios
        '
        Me.Lbl_Folios.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Folios.AutoSize = True
        Me.Lbl_Folios.Location = New System.Drawing.Point(472, 336)
        Me.Lbl_Folios.Name = "Lbl_Folios"
        Me.Lbl_Folios.Size = New System.Drawing.Size(109, 13)
        Me.Lbl_Folios.TabIndex = 50
        Me.Lbl_Folios.Text = "Folios de Remisiones:"
        '
        'Lbl_Registros
        '
        Me.Lbl_Registros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Registros.Location = New System.Drawing.Point(635, 6)
        Me.Lbl_Registros.Name = "Lbl_Registros"
        Me.Lbl_Registros.Size = New System.Drawing.Size(140, 19)
        Me.Lbl_Registros.TabIndex = 51
        Me.Lbl_Registros.Text = "Registros: 0"
        Me.Lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lsv_Folios
        '
        Me.lsv_Folios.AllowColumnReorder = True
        Me.lsv_Folios.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Folios.FullRowSelect = True
        Me.lsv_Folios.HideSelection = False
        Me.lsv_Folios.Location = New System.Drawing.Point(475, 352)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Folios.Lvs = ListViewColumnSorter1
        Me.lsv_Folios.MultiSelect = False
        Me.lsv_Folios.Name = "lsv_Folios"
        Me.lsv_Folios.Ocultar = ""
        Me.lsv_Folios.Row1 = 35
        Me.lsv_Folios.Row10 = 0
        Me.lsv_Folios.Row2 = 35
        Me.lsv_Folios.Row3 = 25
        Me.lsv_Folios.Row4 = 0
        Me.lsv_Folios.Row5 = 0
        Me.lsv_Folios.Row6 = 0
        Me.lsv_Folios.Row7 = 0
        Me.lsv_Folios.Row8 = 0
        Me.lsv_Folios.Row9 = 0
        Me.lsv_Folios.Size = New System.Drawing.Size(300, 150)
        Me.lsv_Folios.TabIndex = 48
        Me.lsv_Folios.TabStop = False
        Me.lsv_Folios.UseCompatibleStateImageBehavior = False
        Me.lsv_Folios.View = System.Windows.Forms.View.Details
        '
        'lsv_VentasD
        '
        Me.lsv_VentasD.AllowColumnReorder = True
        Me.lsv_VentasD.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_VentasD.FullRowSelect = True
        Me.lsv_VentasD.HideSelection = False
        Me.lsv_VentasD.Location = New System.Drawing.Point(5, 352)
        ListViewColumnSorter2.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter2.SortColumn = 0
        Me.lsv_VentasD.Lvs = ListViewColumnSorter2
        Me.lsv_VentasD.MultiSelect = False
        Me.lsv_VentasD.Name = "lsv_VentasD"
        Me.lsv_VentasD.Ocultar = ""
        Me.lsv_VentasD.Row1 = 15
        Me.lsv_VentasD.Row10 = 0
        Me.lsv_VentasD.Row2 = 35
        Me.lsv_VentasD.Row3 = 15
        Me.lsv_VentasD.Row4 = 0
        Me.lsv_VentasD.Row5 = 0
        Me.lsv_VentasD.Row6 = 0
        Me.lsv_VentasD.Row7 = 0
        Me.lsv_VentasD.Row8 = 0
        Me.lsv_VentasD.Row9 = 0
        Me.lsv_VentasD.Size = New System.Drawing.Size(464, 150)
        Me.lsv_VentasD.TabIndex = 42
        Me.lsv_VentasD.TabStop = False
        Me.lsv_VentasD.UseCompatibleStateImageBehavior = False
        Me.lsv_VentasD.View = System.Windows.Forms.View.Details
        '
        'Lsv_Ventas
        '
        Me.Lsv_Ventas.AllowColumnReorder = True
        Me.Lsv_Ventas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lsv_Ventas.FullRowSelect = True
        Me.Lsv_Ventas.HideSelection = False
        Me.Lsv_Ventas.Location = New System.Drawing.Point(5, 31)
        ListViewColumnSorter3.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter3.SortColumn = 0
        Me.Lsv_Ventas.Lvs = ListViewColumnSorter3
        Me.Lsv_Ventas.MultiSelect = False
        Me.Lsv_Ventas.Name = "Lsv_Ventas"
        Me.Lsv_Ventas.Ocultar = ""
        Me.Lsv_Ventas.Row1 = 15
        Me.Lsv_Ventas.Row10 = 0
        Me.Lsv_Ventas.Row2 = 10
        Me.Lsv_Ventas.Row3 = 15
        Me.Lsv_Ventas.Row4 = 15
        Me.Lsv_Ventas.Row5 = 0
        Me.Lsv_Ventas.Row6 = 0
        Me.Lsv_Ventas.Row7 = 0
        Me.Lsv_Ventas.Row8 = 0
        Me.Lsv_Ventas.Row9 = 0
        Me.Lsv_Ventas.Size = New System.Drawing.Size(770, 302)
        Me.Lsv_Ventas.TabIndex = 4
        Me.Lsv_Ventas.UseCompatibleStateImageBehavior = False
        Me.Lsv_Ventas.View = System.Windows.Forms.View.Details
        '
        'frm_VentasCancelar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.Lbl_Registros)
        Me.Controls.Add(Me.Lbl_Folios)
        Me.Controls.Add(Me.Lbl_Material)
        Me.Controls.Add(Me.lsv_Folios)
        Me.Controls.Add(Me.Gbx_Botones)
        Me.Controls.Add(Me.lsv_VentasD)
        Me.Controls.Add(Me.Lsv_Ventas)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_VentasCancelar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "CANCELAR ASIGNACION DE MATERIAL"
        Me.Text = "Cancelar Asignación de Materiales"
        Me.Gbx_Botones.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lsv_Ventas As Modulo_MaterialesCentral.cp_Listview
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents lsv_VentasD As Modulo_MaterialesCentral.cp_Listview
    Friend WithEvents Gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_Folios As Modulo_MaterialesCentral.cp_Listview
    Friend WithEvents Lbl_Material As System.Windows.Forms.Label
    Friend WithEvents Lbl_Folios As System.Windows.Forms.Label
    Friend WithEvents Lbl_Registros As System.Windows.Forms.Label
End Class
