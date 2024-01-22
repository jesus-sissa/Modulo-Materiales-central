<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_SettingsCentral
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
        Me.gbx_Botones = New System.Windows.Forms.GroupBox
        Me.cmd_Guardar = New System.Windows.Forms.Button
        Me.cmd_Cerrar = New System.Windows.Forms.Button
        Me.tbx_Usuario = New Modulo_MaterialesCentral.cp_Textbox
        Me.Label2 = New System.Windows.Forms.Label
        Me.tbx_Servidor = New Modulo_MaterialesCentral.cp_Textbox
        Me.tbx_Base = New Modulo_MaterialesCentral.cp_Textbox
        Me.lbl_bdd = New System.Windows.Forms.Label
        Me.lbl_server = New System.Windows.Forms.Label
        Me.tbx_Clave = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.gbx_Datos = New System.Windows.Forms.GroupBox
        Me.gbx_Botones.SuspendLayout()
        Me.gbx_Datos.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_Botones
        '
        Me.gbx_Botones.Controls.Add(Me.cmd_Guardar)
        Me.gbx_Botones.Controls.Add(Me.cmd_Cerrar)
        Me.gbx_Botones.Location = New System.Drawing.Point(5, 192)
        Me.gbx_Botones.Name = "gbx_Botones"
        Me.gbx_Botones.Size = New System.Drawing.Size(298, 50)
        Me.gbx_Botones.TabIndex = 1
        Me.gbx_Botones.TabStop = False
        '
        'cmd_Guardar
        '
        Me.cmd_Guardar.BackColor = System.Drawing.SystemColors.Control
        Me.cmd_Guardar.CausesValidation = False
        Me.cmd_Guardar.Image = Global.Modulo_MaterialesCentral.My.Resources.Resources._1rightarrow
        Me.cmd_Guardar.Location = New System.Drawing.Point(6, 14)
        Me.cmd_Guardar.Name = "cmd_Guardar"
        Me.cmd_Guardar.Size = New System.Drawing.Size(140, 30)
        Me.cmd_Guardar.TabIndex = 0
        Me.cmd_Guardar.Text = "&Guardar"
        Me.cmd_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_Guardar.UseVisualStyleBackColor = False
        '
        'cmd_Cerrar
        '
        Me.cmd_Cerrar.BackColor = System.Drawing.SystemColors.Control
        Me.cmd_Cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmd_Cerrar.Image = Global.Modulo_MaterialesCentral.My.Resources.Resources.Cerrar
        Me.cmd_Cerrar.Location = New System.Drawing.Point(152, 14)
        Me.cmd_Cerrar.Name = "cmd_Cerrar"
        Me.cmd_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.cmd_Cerrar.TabIndex = 1
        Me.cmd_Cerrar.Text = "&Cerrar"
        Me.cmd_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_Cerrar.UseVisualStyleBackColor = False
        '
        'tbx_Usuario
        '
        Me.tbx_Usuario.Control_Siguiente = Nothing
        Me.tbx_Usuario.Filtrado = True
        Me.tbx_Usuario.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_Usuario.Location = New System.Drawing.Point(99, 83)
        Me.tbx_Usuario.MaxLength = 50
        Me.tbx_Usuario.Name = "tbx_Usuario"
        Me.tbx_Usuario.Size = New System.Drawing.Size(190, 26)
        Me.tbx_Usuario.TabIndex = 5
        Me.tbx_Usuario.TipoDatos = Modulo_MaterialesCentral.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(43, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Usuario"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbx_Servidor
        '
        Me.tbx_Servidor.Control_Siguiente = Me.tbx_Base
        Me.tbx_Servidor.Filtrado = True
        Me.tbx_Servidor.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_Servidor.Location = New System.Drawing.Point(99, 19)
        Me.tbx_Servidor.MaxLength = 50
        Me.tbx_Servidor.Name = "tbx_Servidor"
        Me.tbx_Servidor.Size = New System.Drawing.Size(190, 26)
        Me.tbx_Servidor.TabIndex = 1
        Me.tbx_Servidor.TipoDatos = Modulo_MaterialesCentral.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'tbx_Base
        '
        Me.tbx_Base.Control_Siguiente = Me.tbx_Usuario
        Me.tbx_Base.Filtrado = True
        Me.tbx_Base.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_Base.Location = New System.Drawing.Point(99, 51)
        Me.tbx_Base.MaxLength = 50
        Me.tbx_Base.Name = "tbx_Base"
        Me.tbx_Base.Size = New System.Drawing.Size(190, 26)
        Me.tbx_Base.TabIndex = 3
        Me.tbx_Base.TipoDatos = Modulo_MaterialesCentral.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'lbl_bdd
        '
        Me.lbl_bdd.AutoSize = True
        Me.lbl_bdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_bdd.Location = New System.Drawing.Point(5, 58)
        Me.lbl_bdd.Name = "lbl_bdd"
        Me.lbl_bdd.Size = New System.Drawing.Size(90, 13)
        Me.lbl_bdd.TabIndex = 2
        Me.lbl_bdd.Text = "Base de Datos"
        '
        'lbl_server
        '
        Me.lbl_server.AutoSize = True
        Me.lbl_server.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_server.Location = New System.Drawing.Point(39, 26)
        Me.lbl_server.Name = "lbl_server"
        Me.lbl_server.Size = New System.Drawing.Size(54, 13)
        Me.lbl_server.TabIndex = 0
        Me.lbl_server.Text = "Servidor"
        '
        'tbx_Clave
        '
        Me.tbx_Clave.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_Clave.Location = New System.Drawing.Point(99, 115)
        Me.tbx_Clave.MaxLength = 50
        Me.tbx_Clave.Name = "tbx_Clave"
        Me.tbx_Clave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbx_Clave.Size = New System.Drawing.Size(190, 26)
        Me.tbx_Clave.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(54, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Clave"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'gbx_Datos
        '
        Me.gbx_Datos.Controls.Add(Me.tbx_Servidor)
        Me.gbx_Datos.Controls.Add(Me.tbx_Clave)
        Me.gbx_Datos.Controls.Add(Me.Label3)
        Me.gbx_Datos.Controls.Add(Me.lbl_server)
        Me.gbx_Datos.Controls.Add(Me.tbx_Base)
        Me.gbx_Datos.Controls.Add(Me.lbl_bdd)
        Me.gbx_Datos.Controls.Add(Me.tbx_Usuario)
        Me.gbx_Datos.Controls.Add(Me.Label2)
        Me.gbx_Datos.Location = New System.Drawing.Point(5, 7)
        Me.gbx_Datos.Name = "gbx_Datos"
        Me.gbx_Datos.Size = New System.Drawing.Size(298, 179)
        Me.gbx_Datos.TabIndex = 0
        Me.gbx_Datos.TabStop = False
        '
        'frm_SettingsCentral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(309, 244)
        Me.Controls.Add(Me.gbx_Datos)
        Me.Controls.Add(Me.gbx_Botones)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_SettingsCentral"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Parámetros de Servidor Central"
        Me.gbx_Botones.ResumeLayout(False)
        Me.gbx_Datos.ResumeLayout(False)
        Me.gbx_Datos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents cmd_Guardar As System.Windows.Forms.Button
    Friend WithEvents cmd_Cerrar As System.Windows.Forms.Button
    Friend WithEvents tbx_Usuario As Modulo_MaterialesCentral.cp_Textbox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbx_Servidor As Modulo_MaterialesCentral.cp_Textbox
    Friend WithEvents tbx_Base As Modulo_MaterialesCentral.cp_Textbox
    Friend WithEvents lbl_bdd As System.Windows.Forms.Label
    Friend WithEvents lbl_server As System.Windows.Forms.Label
    Friend WithEvents tbx_Clave As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents gbx_Datos As System.Windows.Forms.GroupBox
End Class
