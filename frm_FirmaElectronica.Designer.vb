<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_FirmaElectronica
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
        Me.lbl_Empleado = New System.Windows.Forms.Label
        Me.lbl_Contraseña = New System.Windows.Forms.Label
        Me.btn_Validar = New System.Windows.Forms.Button
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.tbx_Contraseña = New System.Windows.Forms.TextBox
        Me.lbl_ley = New System.Windows.Forms.Label
        Me.gbx_Observaciones = New System.Windows.Forms.GroupBox
        Me.lbl_Longitud = New System.Windows.Forms.Label
        Me.Gbx_Login = New System.Windows.Forms.GroupBox
        Me.Gbx_Botones = New System.Windows.Forms.GroupBox
        Me.tbx_Empleado = New Modulo_MaterialesCentral.cp_Textbox
        Me.Tbx_Observaciones = New Modulo_MaterialesCentral.cp_Textbox
        Me.gbx_Observaciones.SuspendLayout()
        Me.Gbx_Login.SuspendLayout()
        Me.Gbx_Botones.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_Empleado
        '
        Me.lbl_Empleado.AutoSize = True
        Me.lbl_Empleado.Location = New System.Drawing.Point(35, 16)
        Me.lbl_Empleado.Name = "lbl_Empleado"
        Me.lbl_Empleado.Size = New System.Drawing.Size(55, 13)
        Me.lbl_Empleado.TabIndex = 0
        Me.lbl_Empleado.Text = "Id Usuario"
        '
        'lbl_Contraseña
        '
        Me.lbl_Contraseña.AutoSize = True
        Me.lbl_Contraseña.Location = New System.Drawing.Point(29, 42)
        Me.lbl_Contraseña.Name = "lbl_Contraseña"
        Me.lbl_Contraseña.Size = New System.Drawing.Size(61, 13)
        Me.lbl_Contraseña.TabIndex = 2
        Me.lbl_Contraseña.Text = "Contraseña"
        '
        'btn_Validar
        '
        Me.btn_Validar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Validar.Image = Global.Modulo_MaterialesCentral.My.Resources.Resources.HoraSi
        Me.btn_Validar.Location = New System.Drawing.Point(6, 14)
        Me.btn_Validar.Name = "btn_Validar"
        Me.btn_Validar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Validar.TabIndex = 0
        Me.btn_Validar.Text = "&Validar"
        Me.btn_Validar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Validar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Validar.UseVisualStyleBackColor = True
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_MaterialesCentral.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(192, 14)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 1
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'tbx_Contraseña
        '
        Me.tbx_Contraseña.Location = New System.Drawing.Point(96, 39)
        Me.tbx_Contraseña.MaxLength = 14
        Me.tbx_Contraseña.Name = "tbx_Contraseña"
        Me.tbx_Contraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbx_Contraseña.Size = New System.Drawing.Size(170, 20)
        Me.tbx_Contraseña.TabIndex = 3
        Me.tbx_Contraseña.UseSystemPasswordChar = True
        '
        'lbl_ley
        '
        Me.lbl_ley.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_ley.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ley.Location = New System.Drawing.Point(14, 69)
        Me.lbl_ley.Name = "lbl_ley"
        Me.lbl_ley.Size = New System.Drawing.Size(313, 54)
        Me.lbl_ley.TabIndex = 4
        Me.lbl_ley.Text = "Con base en el Contrato celebrado entre usted y la Empresa, al realizar este tran" & _
            "sacción Usted está ACEPTANDO las Responsabilidades que resulten de esta acción."
        Me.lbl_ley.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gbx_Observaciones
        '
        Me.gbx_Observaciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Observaciones.Controls.Add(Me.Tbx_Observaciones)
        Me.gbx_Observaciones.Controls.Add(Me.lbl_Longitud)
        Me.gbx_Observaciones.Location = New System.Drawing.Point(4, 136)
        Me.gbx_Observaciones.Name = "gbx_Observaciones"
        Me.gbx_Observaciones.Size = New System.Drawing.Size(336, 107)
        Me.gbx_Observaciones.TabIndex = 1
        Me.gbx_Observaciones.TabStop = False
        Me.gbx_Observaciones.Text = "Observaciones"
        '
        'lbl_Longitud
        '
        Me.lbl_Longitud.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_Longitud.AutoSize = True
        Me.lbl_Longitud.Location = New System.Drawing.Point(6, 91)
        Me.lbl_Longitud.Name = "lbl_Longitud"
        Me.lbl_Longitud.Size = New System.Drawing.Size(120, 13)
        Me.lbl_Longitud.TabIndex = 1
        Me.lbl_Longitud.Text = "Máximo 150 caracteres."
        '
        'Gbx_Login
        '
        Me.Gbx_Login.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Login.Controls.Add(Me.lbl_Empleado)
        Me.Gbx_Login.Controls.Add(Me.tbx_Empleado)
        Me.Gbx_Login.Controls.Add(Me.lbl_Contraseña)
        Me.Gbx_Login.Controls.Add(Me.lbl_ley)
        Me.Gbx_Login.Controls.Add(Me.tbx_Contraseña)
        Me.Gbx_Login.Location = New System.Drawing.Point(3, 4)
        Me.Gbx_Login.Name = "Gbx_Login"
        Me.Gbx_Login.Size = New System.Drawing.Size(338, 126)
        Me.Gbx_Login.TabIndex = 0
        Me.Gbx_Login.TabStop = False
        '
        'Gbx_Botones
        '
        Me.Gbx_Botones.Controls.Add(Me.btn_Validar)
        Me.Gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.Gbx_Botones.Location = New System.Drawing.Point(3, 249)
        Me.Gbx_Botones.Name = "Gbx_Botones"
        Me.Gbx_Botones.Size = New System.Drawing.Size(338, 50)
        Me.Gbx_Botones.TabIndex = 2
        Me.Gbx_Botones.TabStop = False
        '
        'tbx_Empleado
        '
        Me.tbx_Empleado.Control_Siguiente = Me.tbx_Contraseña
        Me.tbx_Empleado.Filtrado = False
        Me.tbx_Empleado.Location = New System.Drawing.Point(96, 13)
        Me.tbx_Empleado.MaxLength = 10
        Me.tbx_Empleado.Name = "tbx_Empleado"
        Me.tbx_Empleado.Size = New System.Drawing.Size(170, 20)
        Me.tbx_Empleado.TabIndex = 1
        Me.tbx_Empleado.TipoDatos = Modulo_MaterialesCentral.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'Tbx_Observaciones
        '
        Me.Tbx_Observaciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tbx_Observaciones.Control_Siguiente = Nothing
        Me.Tbx_Observaciones.Filtrado = False
        Me.Tbx_Observaciones.Location = New System.Drawing.Point(6, 19)
        Me.Tbx_Observaciones.Multiline = True
        Me.Tbx_Observaciones.Name = "Tbx_Observaciones"
        Me.Tbx_Observaciones.Size = New System.Drawing.Size(324, 69)
        Me.Tbx_Observaciones.TabIndex = 0
        Me.Tbx_Observaciones.TipoDatos = Modulo_MaterialesCentral.FuncionesGlobales.Validar_Cadena.Ninguno
        '
        'frm_FirmaElectronica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(344, 311)
        Me.ControlBox = False
        Me.Controls.Add(Me.Gbx_Botones)
        Me.Controls.Add(Me.Gbx_Login)
        Me.Controls.Add(Me.gbx_Observaciones)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(350, 340)
        Me.MinimizeBox = False
        Me.Name = "frm_FirmaElectronica"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Condiciones de Validacion"
        Me.gbx_Observaciones.ResumeLayout(False)
        Me.gbx_Observaciones.PerformLayout()
        Me.Gbx_Login.ResumeLayout(False)
        Me.Gbx_Login.PerformLayout()
        Me.Gbx_Botones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tbx_Empleado As Modulo_MaterialesCentral.cp_textbox
    Friend WithEvents lbl_Empleado As System.Windows.Forms.Label
    Friend WithEvents lbl_Contraseña As System.Windows.Forms.Label
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_Validar As System.Windows.Forms.Button
    Friend WithEvents tbx_Contraseña As System.Windows.Forms.TextBox
    Friend WithEvents lbl_ley As System.Windows.Forms.Label
    Friend WithEvents gbx_Observaciones As System.Windows.Forms.GroupBox
    Friend WithEvents Tbx_Observaciones As Modulo_MaterialesCentral.cp_Textbox
    Friend WithEvents lbl_Longitud As System.Windows.Forms.Label
    Friend WithEvents Gbx_Login As System.Windows.Forms.GroupBox
    Friend WithEvents Gbx_Botones As System.Windows.Forms.GroupBox
End Class
