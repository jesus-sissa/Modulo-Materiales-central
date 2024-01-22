<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_FoliosAsignados
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
        Me.lbl_Folio = New System.Windows.Forms.Label
        Me.gbx_Folios = New System.Windows.Forms.GroupBox
        Me.tbx_Comprobantes = New Modulo_MaterialesCentral.cp_Textbox
        Me.Label3 = New System.Windows.Forms.Label
        Me.btn_Eliminar = New System.Windows.Forms.Button
        Me.tbx_Total = New Modulo_MaterialesCentral.cp_Textbox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btn_Agregar = New System.Windows.Forms.Button
        Me.tbx_FolioF = New Modulo_MaterialesCentral.cp_Textbox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lsv_Datos = New System.Windows.Forms.ListView
        Me.tbx_FolioI = New Modulo_MaterialesCentral.cp_Textbox
        Me.gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_Aceptar = New System.Windows.Forms.Button
        Me.gbx_Folios.SuspendLayout()
        Me.gbx_Botones.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_Folio
        '
        Me.lbl_Folio.AutoSize = True
        Me.lbl_Folio.Location = New System.Drawing.Point(7, 15)
        Me.lbl_Folio.Name = "lbl_Folio"
        Me.lbl_Folio.Size = New System.Drawing.Size(59, 13)
        Me.lbl_Folio.TabIndex = 0
        Me.lbl_Folio.Text = "Folio Inicial"
        '
        'gbx_Folios
        '
        Me.gbx_Folios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Folios.Controls.Add(Me.tbx_Comprobantes)
        Me.gbx_Folios.Controls.Add(Me.Label3)
        Me.gbx_Folios.Controls.Add(Me.btn_Eliminar)
        Me.gbx_Folios.Controls.Add(Me.tbx_Total)
        Me.gbx_Folios.Controls.Add(Me.Label2)
        Me.gbx_Folios.Controls.Add(Me.btn_Agregar)
        Me.gbx_Folios.Controls.Add(Me.tbx_FolioF)
        Me.gbx_Folios.Controls.Add(Me.Label1)
        Me.gbx_Folios.Controls.Add(Me.lsv_Datos)
        Me.gbx_Folios.Controls.Add(Me.tbx_FolioI)
        Me.gbx_Folios.Controls.Add(Me.lbl_Folio)
        Me.gbx_Folios.Location = New System.Drawing.Point(6, 2)
        Me.gbx_Folios.Name = "gbx_Folios"
        Me.gbx_Folios.Size = New System.Drawing.Size(621, 218)
        Me.gbx_Folios.TabIndex = 0
        Me.gbx_Folios.TabStop = False
        '
        'tbx_Comprobantes
        '
        Me.tbx_Comprobantes.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_Comprobantes.Control_Siguiente = Nothing
        Me.tbx_Comprobantes.Filtrado = True
        Me.tbx_Comprobantes.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_Comprobantes.ForeColor = System.Drawing.SystemColors.ControlText
        Me.tbx_Comprobantes.Location = New System.Drawing.Point(88, 188)
        Me.tbx_Comprobantes.MaxLength = 10
        Me.tbx_Comprobantes.Name = "tbx_Comprobantes"
        Me.tbx_Comprobantes.ReadOnly = True
        Me.tbx_Comprobantes.Size = New System.Drawing.Size(100, 23)
        Me.tbx_Comprobantes.TabIndex = 10
        Me.tbx_Comprobantes.TabStop = False
        Me.tbx_Comprobantes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbx_Comprobantes.TipoDatos = Modulo_MaterialesCentral.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 193)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Comprobantes"
        '
        'btn_Eliminar
        '
        Me.btn_Eliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Eliminar.Enabled = False
        Me.btn_Eliminar.Image = Global.Modulo_MaterialesCentral.My.Resources.Resources.Baja
        Me.btn_Eliminar.Location = New System.Drawing.Point(475, 46)
        Me.btn_Eliminar.Name = "btn_Eliminar"
        Me.btn_Eliminar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Eliminar.TabIndex = 8
        Me.btn_Eliminar.Text = "&Eliminar"
        Me.btn_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Eliminar.UseVisualStyleBackColor = True
        '
        'tbx_Total
        '
        Me.tbx_Total.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_Total.Control_Siguiente = Nothing
        Me.tbx_Total.Filtrado = True
        Me.tbx_Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_Total.ForeColor = System.Drawing.SystemColors.ControlText
        Me.tbx_Total.Location = New System.Drawing.Point(370, 188)
        Me.tbx_Total.MaxLength = 10
        Me.tbx_Total.Name = "tbx_Total"
        Me.tbx_Total.ReadOnly = True
        Me.tbx_Total.Size = New System.Drawing.Size(100, 23)
        Me.tbx_Total.TabIndex = 7
        Me.tbx_Total.TabStop = False
        Me.tbx_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbx_Total.TipoDatos = Modulo_MaterialesCentral.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(303, 193)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Total Folios"
        '
        'btn_Agregar
        '
        Me.btn_Agregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Agregar.Image = Global.Modulo_MaterialesCentral.My.Resources.Resources.Agregar
        Me.btn_Agregar.Location = New System.Drawing.Point(475, 10)
        Me.btn_Agregar.Name = "btn_Agregar"
        Me.btn_Agregar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Agregar.TabIndex = 4
        Me.btn_Agregar.Text = "&Agregar"
        Me.btn_Agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Agregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Agregar.UseVisualStyleBackColor = True
        '
        'tbx_FolioF
        '
        Me.tbx_FolioF.Control_Siguiente = Me.btn_Agregar
        Me.tbx_FolioF.Filtrado = True
        Me.tbx_FolioF.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_FolioF.ForeColor = System.Drawing.SystemColors.ControlText
        Me.tbx_FolioF.Location = New System.Drawing.Point(370, 10)
        Me.tbx_FolioF.MaxLength = 14
        Me.tbx_FolioF.Name = "tbx_FolioF"
        Me.tbx_FolioF.Size = New System.Drawing.Size(100, 23)
        Me.tbx_FolioF.TabIndex = 3
        Me.tbx_FolioF.TipoDatos = Modulo_MaterialesCentral.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(310, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Folio Final"
        '
        'lsv_Datos
        '
        Me.lsv_Datos.FullRowSelect = True
        Me.lsv_Datos.HideSelection = False
        Me.lsv_Datos.Location = New System.Drawing.Point(10, 43)
        Me.lsv_Datos.MultiSelect = False
        Me.lsv_Datos.Name = "lsv_Datos"
        Me.lsv_Datos.Size = New System.Drawing.Size(460, 139)
        Me.lsv_Datos.TabIndex = 5
        Me.lsv_Datos.UseCompatibleStateImageBehavior = False
        Me.lsv_Datos.View = System.Windows.Forms.View.Details
        '
        'tbx_FolioI
        '
        Me.tbx_FolioI.Control_Siguiente = Me.tbx_FolioF
        Me.tbx_FolioI.Filtrado = True
        Me.tbx_FolioI.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_FolioI.ForeColor = System.Drawing.SystemColors.ControlText
        Me.tbx_FolioI.Location = New System.Drawing.Point(72, 11)
        Me.tbx_FolioI.MaxLength = 14
        Me.tbx_FolioI.Name = "tbx_FolioI"
        Me.tbx_FolioI.Size = New System.Drawing.Size(100, 23)
        Me.tbx_FolioI.TabIndex = 1
        Me.tbx_FolioI.TipoDatos = Modulo_MaterialesCentral.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'gbx_Botones
        '
        Me.gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Botones.Controls.Add(Me.btn_Aceptar)
        Me.gbx_Botones.Location = New System.Drawing.Point(6, 226)
        Me.gbx_Botones.Name = "gbx_Botones"
        Me.gbx_Botones.Size = New System.Drawing.Size(621, 50)
        Me.gbx_Botones.TabIndex = 1
        Me.gbx_Botones.TabStop = False
        '
        'btn_Aceptar
        '
        Me.btn_Aceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Aceptar.Image = Global.Modulo_MaterialesCentral.My.Resources.Resources.HoraSi
        Me.btn_Aceptar.Location = New System.Drawing.Point(474, 13)
        Me.btn_Aceptar.Name = "btn_Aceptar"
        Me.btn_Aceptar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Aceptar.TabIndex = 3
        Me.btn_Aceptar.Text = "&Aceptar"
        Me.btn_Aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Aceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Aceptar.UseVisualStyleBackColor = True
        '
        'frm_FoliosAsignados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 281)
        Me.Controls.Add(Me.gbx_Botones)
        Me.Controls.Add(Me.gbx_Folios)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(640, 310)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(640, 310)
        Me.Name = "frm_FoliosAsignados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Folios Asignados"
        Me.gbx_Folios.ResumeLayout(False)
        Me.gbx_Folios.PerformLayout()
        Me.gbx_Botones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tbx_FolioI As Modulo_MaterialesCentral.cp_Textbox
    Friend WithEvents lbl_Folio As System.Windows.Forms.Label
    Friend WithEvents btn_Aceptar As System.Windows.Forms.Button
    Friend WithEvents gbx_Folios As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_Datos As System.Windows.Forms.ListView
    Friend WithEvents btn_Agregar As System.Windows.Forms.Button
    Friend WithEvents tbx_FolioF As Modulo_MaterialesCentral.cp_Textbox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents tbx_Total As Modulo_MaterialesCentral.cp_Textbox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_Eliminar As System.Windows.Forms.Button
    Friend WithEvents tbx_Comprobantes As Modulo_MaterialesCentral.cp_Textbox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
