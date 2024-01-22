<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ConsumiblesDeptos
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
        Me.gbx_Deptos = New System.Windows.Forms.GroupBox
        Me.lsv_departamentos = New Modulo_MaterialesCentral.cp_Listview
        Me.gbx_ConsumiblesAsignados = New System.Windows.Forms.GroupBox
        Me.lsv_Asignados = New Modulo_MaterialesCentral.cp_Listview
        Me.gbx_Consumibles = New System.Windows.Forms.GroupBox
        Me.lsv_Consumibles = New Modulo_MaterialesCentral.cp_Listview
        Me.gbx_boton = New System.Windows.Forms.GroupBox
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.btn_Quitar = New System.Windows.Forms.Button
        Me.btn_Agregar = New System.Windows.Forms.Button
        Me.gbx_Deptos.SuspendLayout()
        Me.gbx_ConsumiblesAsignados.SuspendLayout()
        Me.gbx_Consumibles.SuspendLayout()
        Me.gbx_boton.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_Deptos
        '
        Me.gbx_Deptos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbx_Deptos.Controls.Add(Me.lsv_departamentos)
        Me.gbx_Deptos.Location = New System.Drawing.Point(4, 6)
        Me.gbx_Deptos.Name = "gbx_Deptos"
        Me.gbx_Deptos.Size = New System.Drawing.Size(297, 509)
        Me.gbx_Deptos.TabIndex = 0
        Me.gbx_Deptos.TabStop = False
        Me.gbx_Deptos.Text = "Listado de Departamentos"
        '
        'lsv_departamentos
        '
        Me.lsv_departamentos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lsv_departamentos.FullRowSelect = True
        Me.lsv_departamentos.HideSelection = False
        Me.lsv_departamentos.Location = New System.Drawing.Point(3, 16)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_departamentos.Lvs = ListViewColumnSorter1
        Me.lsv_departamentos.MultiSelect = False
        Me.lsv_departamentos.Name = "lsv_departamentos"
        Me.lsv_departamentos.Ocultar = ""
        Me.lsv_departamentos.Row1 = 20
        Me.lsv_departamentos.Row10 = 0
        Me.lsv_departamentos.Row2 = 75
        Me.lsv_departamentos.Row3 = 0
        Me.lsv_departamentos.Row4 = 0
        Me.lsv_departamentos.Row5 = 0
        Me.lsv_departamentos.Row6 = 0
        Me.lsv_departamentos.Row7 = 0
        Me.lsv_departamentos.Row8 = 0
        Me.lsv_departamentos.Row9 = 0
        Me.lsv_departamentos.Size = New System.Drawing.Size(291, 490)
        Me.lsv_departamentos.TabIndex = 0
        Me.lsv_departamentos.UseCompatibleStateImageBehavior = False
        Me.lsv_departamentos.View = System.Windows.Forms.View.Details
        '
        'gbx_ConsumiblesAsignados
        '
        Me.gbx_ConsumiblesAsignados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_ConsumiblesAsignados.Controls.Add(Me.lsv_Asignados)
        Me.gbx_ConsumiblesAsignados.Location = New System.Drawing.Point(431, 1)
        Me.gbx_ConsumiblesAsignados.Name = "gbx_ConsumiblesAsignados"
        Me.gbx_ConsumiblesAsignados.Size = New System.Drawing.Size(357, 514)
        Me.gbx_ConsumiblesAsignados.TabIndex = 4
        Me.gbx_ConsumiblesAsignados.TabStop = False
        Me.gbx_ConsumiblesAsignados.Text = "Consumibles Asignados"
        '
        'lsv_Asignados
        '
        Me.lsv_Asignados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Asignados.CheckBoxes = True
        Me.lsv_Asignados.FullRowSelect = True
        Me.lsv_Asignados.HideSelection = False
        Me.lsv_Asignados.Location = New System.Drawing.Point(6, 19)
        ListViewColumnSorter2.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter2.SortColumn = 0
        Me.lsv_Asignados.Lvs = ListViewColumnSorter2
        Me.lsv_Asignados.MultiSelect = False
        Me.lsv_Asignados.Name = "lsv_Asignados"
        Me.lsv_Asignados.Ocultar = ""
        Me.lsv_Asignados.Row1 = 18
        Me.lsv_Asignados.Row10 = 0
        Me.lsv_Asignados.Row2 = 78
        Me.lsv_Asignados.Row3 = 0
        Me.lsv_Asignados.Row4 = 0
        Me.lsv_Asignados.Row5 = 0
        Me.lsv_Asignados.Row6 = 0
        Me.lsv_Asignados.Row7 = 0
        Me.lsv_Asignados.Row8 = 0
        Me.lsv_Asignados.Row9 = 0
        Me.lsv_Asignados.Size = New System.Drawing.Size(345, 489)
        Me.lsv_Asignados.TabIndex = 0
        Me.lsv_Asignados.UseCompatibleStateImageBehavior = False
        Me.lsv_Asignados.View = System.Windows.Forms.View.Details
        '
        'gbx_Consumibles
        '
        Me.gbx_Consumibles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Consumibles.Controls.Add(Me.lsv_Consumibles)
        Me.gbx_Consumibles.Location = New System.Drawing.Point(307, 6)
        Me.gbx_Consumibles.Name = "gbx_Consumibles"
        Me.gbx_Consumibles.Size = New System.Drawing.Size(62, 509)
        Me.gbx_Consumibles.TabIndex = 1
        Me.gbx_Consumibles.TabStop = False
        Me.gbx_Consumibles.Text = "Consumibles"
        '
        'lsv_Consumibles
        '
        Me.lsv_Consumibles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Consumibles.CheckBoxes = True
        Me.lsv_Consumibles.FullRowSelect = True
        Me.lsv_Consumibles.HideSelection = False
        Me.lsv_Consumibles.Location = New System.Drawing.Point(6, 14)
        ListViewColumnSorter3.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter3.SortColumn = 0
        Me.lsv_Consumibles.Lvs = ListViewColumnSorter3
        Me.lsv_Consumibles.MultiSelect = False
        Me.lsv_Consumibles.Name = "lsv_Consumibles"
        Me.lsv_Consumibles.Ocultar = ""
        Me.lsv_Consumibles.Row1 = 17
        Me.lsv_Consumibles.Row10 = 0
        Me.lsv_Consumibles.Row2 = 70
        Me.lsv_Consumibles.Row3 = 10
        Me.lsv_Consumibles.Row4 = 0
        Me.lsv_Consumibles.Row5 = 0
        Me.lsv_Consumibles.Row6 = 0
        Me.lsv_Consumibles.Row7 = 0
        Me.lsv_Consumibles.Row8 = 0
        Me.lsv_Consumibles.Row9 = 0
        Me.lsv_Consumibles.Size = New System.Drawing.Size(50, 489)
        Me.lsv_Consumibles.TabIndex = 0
        Me.lsv_Consumibles.UseCompatibleStateImageBehavior = False
        Me.lsv_Consumibles.View = System.Windows.Forms.View.Details
        '
        'gbx_boton
        '
        Me.gbx_boton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_boton.Controls.Add(Me.btn_Cerrar)
        Me.gbx_boton.Location = New System.Drawing.Point(4, 515)
        Me.gbx_boton.Name = "gbx_boton"
        Me.gbx_boton.Size = New System.Drawing.Size(784, 50)
        Me.gbx_boton.TabIndex = 5
        Me.gbx_boton.TabStop = False
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_MaterialesCentral.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(638, 14)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 0
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'btn_Quitar
        '
        Me.btn_Quitar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Quitar.Image = Global.Modulo_MaterialesCentral.My.Resources.Resources.previous
        Me.btn_Quitar.Location = New System.Drawing.Point(375, 199)
        Me.btn_Quitar.Name = "btn_Quitar"
        Me.btn_Quitar.Size = New System.Drawing.Size(50, 50)
        Me.btn_Quitar.TabIndex = 3
        Me.btn_Quitar.UseVisualStyleBackColor = True
        '
        'btn_Agregar
        '
        Me.btn_Agregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Agregar.Image = Global.Modulo_MaterialesCentral.My.Resources.Resources._next
        Me.btn_Agregar.Location = New System.Drawing.Point(375, 143)
        Me.btn_Agregar.Name = "btn_Agregar"
        Me.btn_Agregar.Size = New System.Drawing.Size(50, 50)
        Me.btn_Agregar.TabIndex = 2
        Me.btn_Agregar.UseVisualStyleBackColor = True
        '
        'frm_ConsumiblesDeptos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(794, 571)
        Me.Controls.Add(Me.btn_Quitar)
        Me.Controls.Add(Me.btn_Agregar)
        Me.Controls.Add(Me.gbx_Consumibles)
        Me.Controls.Add(Me.gbx_Deptos)
        Me.Controls.Add(Me.gbx_ConsumiblesAsignados)
        Me.Controls.Add(Me.gbx_boton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_ConsumiblesDeptos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Catalogo de Consumibles por Departamento"
        Me.gbx_Deptos.ResumeLayout(False)
        Me.gbx_ConsumiblesAsignados.ResumeLayout(False)
        Me.gbx_Consumibles.ResumeLayout(False)
        Me.gbx_boton.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbx_Deptos As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_ConsumiblesAsignados As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_Consumibles As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_boton As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_Agregar As System.Windows.Forms.Button
    Friend WithEvents btn_Quitar As System.Windows.Forms.Button
    Friend WithEvents lsv_departamentos As Modulo_MaterialesCentral.cp_Listview
    Friend WithEvents lsv_Asignados As Modulo_MaterialesCentral.cp_Listview
    Friend WithEvents lsv_Consumibles As Modulo_MaterialesCentral.cp_Listview
End Class
