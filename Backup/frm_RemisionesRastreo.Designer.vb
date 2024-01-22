<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_RemisionesRastreo
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
        Me.lbl_Remision = New System.Windows.Forms.Label
        Me.Gbx_Filtro = New System.Windows.Forms.GroupBox
        Me.btn_Buscar = New System.Windows.Forms.Button
        Me.tbx_Remision = New Modulo_MaterialesCentral.cp_Textbox
        Me.Gbx_Contenido = New System.Windows.Forms.GroupBox
        Me.lsv_Folios = New Modulo_MaterialesCentral.cp_Listview
        Me.lsv_Materiales = New Modulo_MaterialesCentral.cp_Listview
        Me.tbx_Asigno = New Modulo_MaterialesCentral.cp_Textbox
        Me.Lbl_Asigno = New System.Windows.Forms.Label
        Me.tbx_Hora = New Modulo_MaterialesCentral.cp_Textbox
        Me.Lbl_Hora = New System.Windows.Forms.Label
        Me.tbx_Departamento = New Modulo_MaterialesCentral.cp_Textbox
        Me.tbx_Fecha = New Modulo_MaterialesCentral.cp_Textbox
        Me.lbl_FechaEnt = New System.Windows.Forms.Label
        Me.lbl_Depto = New System.Windows.Forms.Label
        Me.Gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.Gbx_Filtro.SuspendLayout()
        Me.Gbx_Contenido.SuspendLayout()
        Me.Gbx_Botones.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_Remision
        '
        Me.lbl_Remision.AutoSize = True
        Me.lbl_Remision.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Remision.Location = New System.Drawing.Point(17, 25)
        Me.lbl_Remision.Name = "lbl_Remision"
        Me.lbl_Remision.Size = New System.Drawing.Size(74, 17)
        Me.lbl_Remision.TabIndex = 0
        Me.lbl_Remision.Text = "Remisión"
        '
        'Gbx_Filtro
        '
        Me.Gbx_Filtro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Filtro.Controls.Add(Me.btn_Buscar)
        Me.Gbx_Filtro.Controls.Add(Me.tbx_Remision)
        Me.Gbx_Filtro.Controls.Add(Me.lbl_Remision)
        Me.Gbx_Filtro.Location = New System.Drawing.Point(4, 6)
        Me.Gbx_Filtro.Name = "Gbx_Filtro"
        Me.Gbx_Filtro.Size = New System.Drawing.Size(604, 60)
        Me.Gbx_Filtro.TabIndex = 0
        Me.Gbx_Filtro.TabStop = False
        '
        'btn_Buscar
        '
        Me.btn_Buscar.Image = Global.Modulo_MaterialesCentral.My.Resources.Resources.Buscar
        Me.btn_Buscar.Location = New System.Drawing.Point(303, 19)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(28, 28)
        Me.btn_Buscar.TabIndex = 2
        Me.btn_Buscar.UseVisualStyleBackColor = True
        '
        'tbx_Remision
        '
        Me.tbx_Remision.Control_Siguiente = Me.btn_Buscar
        Me.tbx_Remision.Filtrado = True
        Me.tbx_Remision.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_Remision.Location = New System.Drawing.Point(97, 19)
        Me.tbx_Remision.MaxLength = 20
        Me.tbx_Remision.Name = "tbx_Remision"
        Me.tbx_Remision.Size = New System.Drawing.Size(200, 26)
        Me.tbx_Remision.TabIndex = 1
        Me.tbx_Remision.TipoDatos = Modulo_MaterialesCentral.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'Gbx_Contenido
        '
        Me.Gbx_Contenido.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Contenido.Controls.Add(Me.lsv_Folios)
        Me.Gbx_Contenido.Controls.Add(Me.lsv_Materiales)
        Me.Gbx_Contenido.Controls.Add(Me.tbx_Asigno)
        Me.Gbx_Contenido.Controls.Add(Me.Lbl_Asigno)
        Me.Gbx_Contenido.Controls.Add(Me.tbx_Hora)
        Me.Gbx_Contenido.Controls.Add(Me.Lbl_Hora)
        Me.Gbx_Contenido.Controls.Add(Me.tbx_Departamento)
        Me.Gbx_Contenido.Controls.Add(Me.tbx_Fecha)
        Me.Gbx_Contenido.Controls.Add(Me.lbl_FechaEnt)
        Me.Gbx_Contenido.Controls.Add(Me.lbl_Depto)
        Me.Gbx_Contenido.Location = New System.Drawing.Point(4, 72)
        Me.Gbx_Contenido.Name = "Gbx_Contenido"
        Me.Gbx_Contenido.Size = New System.Drawing.Size(604, 397)
        Me.Gbx_Contenido.TabIndex = 1
        Me.Gbx_Contenido.TabStop = False
        '
        'lsv_Folios
        '
        Me.lsv_Folios.AllowColumnReorder = True
        Me.lsv_Folios.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Folios.FullRowSelect = True
        Me.lsv_Folios.HideSelection = False
        Me.lsv_Folios.Location = New System.Drawing.Point(306, 99)
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
        Me.lsv_Folios.Size = New System.Drawing.Size(292, 292)
        Me.lsv_Folios.TabIndex = 9
        Me.lsv_Folios.TabStop = False
        Me.lsv_Folios.UseCompatibleStateImageBehavior = False
        Me.lsv_Folios.View = System.Windows.Forms.View.Details
        '
        'lsv_Materiales
        '
        Me.lsv_Materiales.AllowColumnReorder = True
        Me.lsv_Materiales.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Materiales.FullRowSelect = True
        Me.lsv_Materiales.HideSelection = False
        Me.lsv_Materiales.Location = New System.Drawing.Point(8, 99)
        ListViewColumnSorter2.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter2.SortColumn = 0
        Me.lsv_Materiales.Lvs = ListViewColumnSorter2
        Me.lsv_Materiales.MultiSelect = False
        Me.lsv_Materiales.Name = "lsv_Materiales"
        Me.lsv_Materiales.Ocultar = ""
        Me.lsv_Materiales.Row1 = 15
        Me.lsv_Materiales.Row10 = 0
        Me.lsv_Materiales.Row2 = 60
        Me.lsv_Materiales.Row3 = 20
        Me.lsv_Materiales.Row4 = 0
        Me.lsv_Materiales.Row5 = 0
        Me.lsv_Materiales.Row6 = 0
        Me.lsv_Materiales.Row7 = 0
        Me.lsv_Materiales.Row8 = 0
        Me.lsv_Materiales.Row9 = 0
        Me.lsv_Materiales.Size = New System.Drawing.Size(292, 292)
        Me.lsv_Materiales.TabIndex = 8
        Me.lsv_Materiales.TabStop = False
        Me.lsv_Materiales.UseCompatibleStateImageBehavior = False
        Me.lsv_Materiales.View = System.Windows.Forms.View.Details
        '
        'tbx_Asigno
        '
        Me.tbx_Asigno.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_Asigno.Control_Siguiente = Nothing
        Me.tbx_Asigno.Filtrado = True
        Me.tbx_Asigno.Location = New System.Drawing.Point(97, 69)
        Me.tbx_Asigno.MaxLength = 50
        Me.tbx_Asigno.Name = "tbx_Asigno"
        Me.tbx_Asigno.ReadOnly = True
        Me.tbx_Asigno.Size = New System.Drawing.Size(300, 20)
        Me.tbx_Asigno.TabIndex = 7
        Me.tbx_Asigno.TabStop = False
        Me.tbx_Asigno.TipoDatos = Modulo_MaterialesCentral.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'Lbl_Asigno
        '
        Me.Lbl_Asigno.AutoSize = True
        Me.Lbl_Asigno.Location = New System.Drawing.Point(52, 72)
        Me.Lbl_Asigno.Name = "Lbl_Asigno"
        Me.Lbl_Asigno.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_Asigno.TabIndex = 6
        Me.Lbl_Asigno.Text = "Asignó"
        '
        'tbx_Hora
        '
        Me.tbx_Hora.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_Hora.Control_Siguiente = Nothing
        Me.tbx_Hora.Filtrado = True
        Me.tbx_Hora.Location = New System.Drawing.Point(229, 17)
        Me.tbx_Hora.MaxLength = 5
        Me.tbx_Hora.Name = "tbx_Hora"
        Me.tbx_Hora.ReadOnly = True
        Me.tbx_Hora.Size = New System.Drawing.Size(50, 20)
        Me.tbx_Hora.TabIndex = 3
        Me.tbx_Hora.TabStop = False
        Me.tbx_Hora.TipoDatos = Modulo_MaterialesCentral.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'Lbl_Hora
        '
        Me.Lbl_Hora.AutoSize = True
        Me.Lbl_Hora.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Hora.Location = New System.Drawing.Point(193, 20)
        Me.Lbl_Hora.Name = "Lbl_Hora"
        Me.Lbl_Hora.Size = New System.Drawing.Size(30, 13)
        Me.Lbl_Hora.TabIndex = 2
        Me.Lbl_Hora.Text = "Hora"
        '
        'tbx_Departamento
        '
        Me.tbx_Departamento.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_Departamento.Control_Siguiente = Nothing
        Me.tbx_Departamento.Filtrado = True
        Me.tbx_Departamento.Location = New System.Drawing.Point(97, 43)
        Me.tbx_Departamento.MaxLength = 50
        Me.tbx_Departamento.Name = "tbx_Departamento"
        Me.tbx_Departamento.ReadOnly = True
        Me.tbx_Departamento.Size = New System.Drawing.Size(300, 20)
        Me.tbx_Departamento.TabIndex = 5
        Me.tbx_Departamento.TabStop = False
        Me.tbx_Departamento.TipoDatos = Modulo_MaterialesCentral.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'tbx_Fecha
        '
        Me.tbx_Fecha.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_Fecha.Control_Siguiente = Nothing
        Me.tbx_Fecha.Filtrado = True
        Me.tbx_Fecha.Location = New System.Drawing.Point(97, 17)
        Me.tbx_Fecha.MaxLength = 10
        Me.tbx_Fecha.Name = "tbx_Fecha"
        Me.tbx_Fecha.ReadOnly = True
        Me.tbx_Fecha.Size = New System.Drawing.Size(90, 20)
        Me.tbx_Fecha.TabIndex = 1
        Me.tbx_Fecha.TabStop = False
        Me.tbx_Fecha.TipoDatos = Modulo_MaterialesCentral.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'lbl_FechaEnt
        '
        Me.lbl_FechaEnt.AutoSize = True
        Me.lbl_FechaEnt.BackColor = System.Drawing.Color.Transparent
        Me.lbl_FechaEnt.Location = New System.Drawing.Point(54, 23)
        Me.lbl_FechaEnt.Name = "lbl_FechaEnt"
        Me.lbl_FechaEnt.Size = New System.Drawing.Size(37, 13)
        Me.lbl_FechaEnt.TabIndex = 0
        Me.lbl_FechaEnt.Text = "Fecha"
        '
        'lbl_Depto
        '
        Me.lbl_Depto.AutoSize = True
        Me.lbl_Depto.Location = New System.Drawing.Point(17, 46)
        Me.lbl_Depto.Name = "lbl_Depto"
        Me.lbl_Depto.Size = New System.Drawing.Size(74, 13)
        Me.lbl_Depto.TabIndex = 4
        Me.lbl_Depto.Text = "Departamento"
        '
        'Gbx_Botones
        '
        Me.Gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.Gbx_Botones.Location = New System.Drawing.Point(4, 469)
        Me.Gbx_Botones.Name = "Gbx_Botones"
        Me.Gbx_Botones.Size = New System.Drawing.Size(604, 50)
        Me.Gbx_Botones.TabIndex = 2
        Me.Gbx_Botones.TabStop = False
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_MaterialesCentral.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(458, 14)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 0
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'frm_RemisionesRastreo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(614, 521)
        Me.Controls.Add(Me.Gbx_Botones)
        Me.Controls.Add(Me.Gbx_Contenido)
        Me.Controls.Add(Me.Gbx_Filtro)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(620, 550)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(620, 550)
        Me.Name = "frm_RemisionesRastreo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rastreo de Remisiones"
        Me.Gbx_Filtro.ResumeLayout(False)
        Me.Gbx_Filtro.PerformLayout()
        Me.Gbx_Contenido.ResumeLayout(False)
        Me.Gbx_Contenido.PerformLayout()
        Me.Gbx_Botones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbl_Remision As System.Windows.Forms.Label
    Friend WithEvents Gbx_Filtro As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Buscar As System.Windows.Forms.Button
    Friend WithEvents tbx_Remision As Modulo_MaterialesCentral.cp_Textbox
    Friend WithEvents Gbx_Contenido As System.Windows.Forms.GroupBox
    Friend WithEvents tbx_Asigno As Modulo_MaterialesCentral.cp_Textbox
    Friend WithEvents Lbl_Asigno As System.Windows.Forms.Label
    Friend WithEvents tbx_Hora As Modulo_MaterialesCentral.cp_Textbox
    Friend WithEvents Lbl_Hora As System.Windows.Forms.Label
    Friend WithEvents tbx_Departamento As Modulo_MaterialesCentral.cp_Textbox
    Friend WithEvents tbx_Fecha As Modulo_MaterialesCentral.cp_Textbox
    Friend WithEvents lbl_FechaEnt As System.Windows.Forms.Label
    Friend WithEvents lbl_Depto As System.Windows.Forms.Label
    Friend WithEvents lsv_Folios As Modulo_MaterialesCentral.cp_Listview
    Friend WithEvents lsv_Materiales As Modulo_MaterialesCentral.cp_Listview
    Friend WithEvents Gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
End Class
