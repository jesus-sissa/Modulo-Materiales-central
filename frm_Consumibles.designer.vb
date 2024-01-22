<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Consumibles
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
        Me.gbx_Newconsumibles = New System.Windows.Forms.GroupBox
        Me.Lbl_Tipo = New System.Windows.Forms.Label
        Me.rdb_Consumible = New System.Windows.Forms.RadioButton
        Me.rdb_Accesorio = New System.Windows.Forms.RadioButton
        Me.lbl_Clave = New System.Windows.Forms.Label
        Me.btn_Cancelar = New System.Windows.Forms.Button
        Me.btn_Guardar = New System.Windows.Forms.Button
        Me.lbl_Descripcion = New System.Windows.Forms.Label
        Me.gbx_Consumibles = New System.Windows.Forms.GroupBox
        Me.Lbl_Registros = New System.Windows.Forms.Label
        Me.gbx_botones = New System.Windows.Forms.GroupBox
        Me.BTN_Modificar = New System.Windows.Forms.Button
        Me.Btn_Baja = New System.Windows.Forms.Button
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.BTN_Exportar = New System.Windows.Forms.Button
        Me.lsv_Consumibles = New Modulo_MaterialesCentral.cp_Listview
        Me.tbx_Clave = New Modulo_MaterialesCentral.cp_Textbox
        Me.tbx_Descripcion = New Modulo_MaterialesCentral.cp_Textbox
        Me.gbx_Newconsumibles.SuspendLayout()
        Me.gbx_Consumibles.SuspendLayout()
        Me.gbx_botones.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_Newconsumibles
        '
        Me.gbx_Newconsumibles.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Newconsumibles.Controls.Add(Me.Lbl_Tipo)
        Me.gbx_Newconsumibles.Controls.Add(Me.rdb_Consumible)
        Me.gbx_Newconsumibles.Controls.Add(Me.rdb_Accesorio)
        Me.gbx_Newconsumibles.Controls.Add(Me.lbl_Clave)
        Me.gbx_Newconsumibles.Controls.Add(Me.btn_Cancelar)
        Me.gbx_Newconsumibles.Controls.Add(Me.btn_Guardar)
        Me.gbx_Newconsumibles.Controls.Add(Me.lbl_Descripcion)
        Me.gbx_Newconsumibles.Controls.Add(Me.tbx_Clave)
        Me.gbx_Newconsumibles.Controls.Add(Me.tbx_Descripcion)
        Me.gbx_Newconsumibles.Location = New System.Drawing.Point(5, 5)
        Me.gbx_Newconsumibles.Name = "gbx_Newconsumibles"
        Me.gbx_Newconsumibles.Size = New System.Drawing.Size(785, 141)
        Me.gbx_Newconsumibles.TabIndex = 0
        Me.gbx_Newconsumibles.TabStop = False
        Me.gbx_Newconsumibles.Text = "Consumibles"
        '
        'Lbl_Tipo
        '
        Me.Lbl_Tipo.AutoSize = True
        Me.Lbl_Tipo.Location = New System.Drawing.Point(70, 67)
        Me.Lbl_Tipo.Name = "Lbl_Tipo"
        Me.Lbl_Tipo.Size = New System.Drawing.Size(28, 13)
        Me.Lbl_Tipo.TabIndex = 4
        Me.Lbl_Tipo.Text = "Tipo"
        '
        'rdb_Consumible
        '
        Me.rdb_Consumible.AutoSize = True
        Me.rdb_Consumible.Location = New System.Drawing.Point(182, 67)
        Me.rdb_Consumible.Name = "rdb_Consumible"
        Me.rdb_Consumible.Size = New System.Drawing.Size(79, 17)
        Me.rdb_Consumible.TabIndex = 6
        Me.rdb_Consumible.TabStop = True
        Me.rdb_Consumible.Text = "Consumible"
        Me.rdb_Consumible.UseVisualStyleBackColor = True
        '
        'rdb_Accesorio
        '
        Me.rdb_Accesorio.AutoSize = True
        Me.rdb_Accesorio.Location = New System.Drawing.Point(104, 67)
        Me.rdb_Accesorio.Name = "rdb_Accesorio"
        Me.rdb_Accesorio.Size = New System.Drawing.Size(72, 17)
        Me.rdb_Accesorio.TabIndex = 5
        Me.rdb_Accesorio.TabStop = True
        Me.rdb_Accesorio.Text = "Accesorio"
        Me.rdb_Accesorio.UseVisualStyleBackColor = True
        '
        'lbl_Clave
        '
        Me.lbl_Clave.AutoSize = True
        Me.lbl_Clave.Location = New System.Drawing.Point(64, 16)
        Me.lbl_Clave.Name = "lbl_Clave"
        Me.lbl_Clave.Size = New System.Drawing.Size(34, 13)
        Me.lbl_Clave.TabIndex = 0
        Me.lbl_Clave.Text = "Clave"
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Image = Global.Modulo_MaterialesCentral.My.Resources.Resources.Cancelar
        Me.btn_Cancelar.Location = New System.Drawing.Point(250, 95)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cancelar.TabIndex = 8
        Me.btn_Cancelar.Text = "&Cancelar"
        Me.btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Image = Global.Modulo_MaterialesCentral.My.Resources.Resources.Guardar
        Me.btn_Guardar.Location = New System.Drawing.Point(104, 95)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Guardar.TabIndex = 7
        Me.btn_Guardar.Text = "&Guardar"
        Me.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'lbl_Descripcion
        '
        Me.lbl_Descripcion.AutoSize = True
        Me.lbl_Descripcion.Location = New System.Drawing.Point(35, 42)
        Me.lbl_Descripcion.Name = "lbl_Descripcion"
        Me.lbl_Descripcion.Size = New System.Drawing.Size(63, 13)
        Me.lbl_Descripcion.TabIndex = 2
        Me.lbl_Descripcion.Text = "Descripcion"
        Me.lbl_Descripcion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'gbx_Consumibles
        '
        Me.gbx_Consumibles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Consumibles.Controls.Add(Me.Lbl_Registros)
        Me.gbx_Consumibles.Controls.Add(Me.lsv_Consumibles)
        Me.gbx_Consumibles.Location = New System.Drawing.Point(5, 149)
        Me.gbx_Consumibles.Name = "gbx_Consumibles"
        Me.gbx_Consumibles.Size = New System.Drawing.Size(785, 370)
        Me.gbx_Consumibles.TabIndex = 1
        Me.gbx_Consumibles.TabStop = False
        '
        'Lbl_Registros
        '
        Me.Lbl_Registros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Registros.Location = New System.Drawing.Point(627, 15)
        Me.Lbl_Registros.Name = "Lbl_Registros"
        Me.Lbl_Registros.Size = New System.Drawing.Size(152, 20)
        Me.Lbl_Registros.TabIndex = 2
        Me.Lbl_Registros.Text = "Registros: 0"
        Me.Lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'gbx_botones
        '
        Me.gbx_botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_botones.Controls.Add(Me.BTN_Modificar)
        Me.gbx_botones.Controls.Add(Me.Btn_Baja)
        Me.gbx_botones.Controls.Add(Me.btn_Cerrar)
        Me.gbx_botones.Controls.Add(Me.BTN_Exportar)
        Me.gbx_botones.Location = New System.Drawing.Point(5, 514)
        Me.gbx_botones.Name = "gbx_botones"
        Me.gbx_botones.Size = New System.Drawing.Size(785, 50)
        Me.gbx_botones.TabIndex = 2
        Me.gbx_botones.TabStop = False
        '
        'BTN_Modificar
        '
        Me.BTN_Modificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BTN_Modificar.Enabled = False
        Me.BTN_Modificar.Image = Global.Modulo_MaterialesCentral.My.Resources.Resources.Editar
        Me.BTN_Modificar.Location = New System.Drawing.Point(155, 14)
        Me.BTN_Modificar.Name = "BTN_Modificar"
        Me.BTN_Modificar.Size = New System.Drawing.Size(140, 30)
        Me.BTN_Modificar.TabIndex = 1
        Me.BTN_Modificar.Text = "&Modificar"
        Me.BTN_Modificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_Modificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_Modificar.UseVisualStyleBackColor = True
        '
        'Btn_Baja
        '
        Me.Btn_Baja.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn_Baja.Enabled = False
        Me.Btn_Baja.Image = Global.Modulo_MaterialesCentral.My.Resources.Resources.BajaReing
        Me.Btn_Baja.Location = New System.Drawing.Point(7, 14)
        Me.Btn_Baja.Name = "Btn_Baja"
        Me.Btn_Baja.Size = New System.Drawing.Size(142, 30)
        Me.Btn_Baja.TabIndex = 0
        Me.Btn_Baja.Text = "&Dar de Baja"
        Me.Btn_Baja.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Baja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Baja.UseVisualStyleBackColor = True
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Cerrar.Image = Global.Modulo_MaterialesCentral.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(639, 14)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 3
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'BTN_Exportar
        '
        Me.BTN_Exportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BTN_Exportar.Enabled = False
        Me.BTN_Exportar.Image = Global.Modulo_MaterialesCentral.My.Resources.Resources.Exportar
        Me.BTN_Exportar.Location = New System.Drawing.Point(301, 14)
        Me.BTN_Exportar.Name = "BTN_Exportar"
        Me.BTN_Exportar.Size = New System.Drawing.Size(140, 30)
        Me.BTN_Exportar.TabIndex = 2
        Me.BTN_Exportar.Text = "&Exportar"
        Me.BTN_Exportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_Exportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_Exportar.UseVisualStyleBackColor = True
        '
        'lsv_Consumibles
        '
        Me.lsv_Consumibles.AllowColumnReorder = True
        Me.lsv_Consumibles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Consumibles.FullRowSelect = True
        Me.lsv_Consumibles.HideSelection = False
        Me.lsv_Consumibles.Location = New System.Drawing.Point(6, 38)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Consumibles.Lvs = ListViewColumnSorter1
        Me.lsv_Consumibles.MultiSelect = False
        Me.lsv_Consumibles.Name = "lsv_Consumibles"
        Me.lsv_Consumibles.Ocultar = "3"
        Me.lsv_Consumibles.Row1 = 10
        Me.lsv_Consumibles.Row10 = 0
        Me.lsv_Consumibles.Row2 = 70
        Me.lsv_Consumibles.Row3 = 15
        Me.lsv_Consumibles.Row4 = 0
        Me.lsv_Consumibles.Row5 = 0
        Me.lsv_Consumibles.Row6 = 0
        Me.lsv_Consumibles.Row7 = 0
        Me.lsv_Consumibles.Row8 = 0
        Me.lsv_Consumibles.Row9 = 0
        Me.lsv_Consumibles.Size = New System.Drawing.Size(773, 326)
        Me.lsv_Consumibles.TabIndex = 0
        Me.lsv_Consumibles.UseCompatibleStateImageBehavior = False
        Me.lsv_Consumibles.View = System.Windows.Forms.View.Details
        '
        'tbx_Clave
        '
        Me.tbx_Clave.Control_Siguiente = Me.tbx_Descripcion
        Me.tbx_Clave.Filtrado = True
        Me.tbx_Clave.Location = New System.Drawing.Point(104, 13)
        Me.tbx_Clave.MaxLength = 4
        Me.tbx_Clave.Name = "tbx_Clave"
        Me.tbx_Clave.Size = New System.Drawing.Size(50, 20)
        Me.tbx_Clave.TabIndex = 1
        Me.tbx_Clave.TipoDatos = Modulo_MaterialesCentral.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'tbx_Descripcion
        '
        Me.tbx_Descripcion.Control_Siguiente = Nothing
        Me.tbx_Descripcion.Filtrado = True
        Me.tbx_Descripcion.Location = New System.Drawing.Point(104, 39)
        Me.tbx_Descripcion.MaxLength = 70
        Me.tbx_Descripcion.Name = "tbx_Descripcion"
        Me.tbx_Descripcion.Size = New System.Drawing.Size(461, 20)
        Me.tbx_Descripcion.TabIndex = 3
        Me.tbx_Descripcion.TipoDatos = Modulo_MaterialesCentral.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'frm_Consumibles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btn_Cerrar
        Me.ClientSize = New System.Drawing.Size(794, 571)
        Me.Controls.Add(Me.gbx_botones)
        Me.Controls.Add(Me.gbx_Consumibles)
        Me.Controls.Add(Me.gbx_Newconsumibles)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_Consumibles"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Catalogo de Consumibles"
        Me.gbx_Newconsumibles.ResumeLayout(False)
        Me.gbx_Newconsumibles.PerformLayout()
        Me.gbx_Consumibles.ResumeLayout(False)
        Me.gbx_botones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lsv_Consumibles As Modulo_MaterialesCentral.cp_Listview
    Friend WithEvents gbx_Newconsumibles As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents lbl_Clave As System.Windows.Forms.Label
    Friend WithEvents btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents lbl_Descripcion As System.Windows.Forms.Label
    Friend WithEvents tbx_Clave As Modulo_MaterialesCentral.cp_Textbox
    Friend WithEvents tbx_Descripcion As Modulo_MaterialesCentral.cp_Textbox
    Friend WithEvents gbx_Consumibles As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_botones As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents BTN_Exportar As System.Windows.Forms.Button
    Friend WithEvents BTN_Modificar As System.Windows.Forms.Button
    Friend WithEvents Btn_Baja As System.Windows.Forms.Button
    Friend WithEvents Lbl_Tipo As System.Windows.Forms.Label
    Friend WithEvents rdb_Consumible As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_Accesorio As System.Windows.Forms.RadioButton
    Friend WithEvents Lbl_Registros As System.Windows.Forms.Label
End Class
