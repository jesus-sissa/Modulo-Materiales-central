<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Materiales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Materiales))
        Me.Tab_Catalogo = New System.Windows.Forms.TabControl
        Me.tab_Listado = New System.Windows.Forms.TabPage
        Me.Lbl_Registros = New System.Windows.Forms.Label
        Me.BTN_Modificar = New System.Windows.Forms.Button
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.BTN_Exportar = New System.Windows.Forms.Button
        Me.Btn_Baja = New System.Windows.Forms.Button
        Me.BTN_Buscar = New System.Windows.Forms.Button
        Me.Lbl_Buscar = New System.Windows.Forms.Label
        Me.Tab_Nuevo = New System.Windows.Forms.TabPage
        Me.Label5 = New System.Windows.Forms.Label
        Me.lbl_ControlFolios = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Lbl_PrecioCompra = New System.Windows.Forms.Label
        Me.lbl_Cantidad_Unidad = New System.Windows.Forms.Label
        Me.lbl_Clave = New System.Windows.Forms.Label
        Me.btn_Cancelar = New System.Windows.Forms.Button
        Me.btn_Guardar = New System.Windows.Forms.Button
        Me.lbl_Descripcion = New System.Windows.Forms.Label
        Me.tbx_Buscar = New Modulo_MaterialesCentral.cp_Textbox
        Me.lsv_Catalogo = New Modulo_MaterialesCentral.cp_Listview
        Me.cmb_ControlFolios = New Modulo_MaterialesCentral.cp_cmb_Manual
        Me.tbx_PrecioCompra = New Modulo_MaterialesCentral.cp_Textbox
        Me.tbx_Cantidad_Unidad = New Modulo_MaterialesCentral.cp_Textbox
        Me.tbx_Clave = New Modulo_MaterialesCentral.cp_Textbox
        Me.tbx_Descripcion = New Modulo_MaterialesCentral.cp_Textbox
        Me.Tab_Catalogo.SuspendLayout()
        Me.tab_Listado.SuspendLayout()
        Me.Tab_Nuevo.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tab_Catalogo
        '
        Me.Tab_Catalogo.Controls.Add(Me.tab_Listado)
        Me.Tab_Catalogo.Controls.Add(Me.Tab_Nuevo)
        Me.Tab_Catalogo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tab_Catalogo.Location = New System.Drawing.Point(0, 0)
        Me.Tab_Catalogo.Name = "Tab_Catalogo"
        Me.Tab_Catalogo.SelectedIndex = 0
        Me.Tab_Catalogo.Size = New System.Drawing.Size(784, 561)
        Me.Tab_Catalogo.TabIndex = 0
        '
        'tab_Listado
        '
        Me.tab_Listado.Controls.Add(Me.Lbl_Registros)
        Me.tab_Listado.Controls.Add(Me.BTN_Modificar)
        Me.tab_Listado.Controls.Add(Me.btn_Cerrar)
        Me.tab_Listado.Controls.Add(Me.BTN_Exportar)
        Me.tab_Listado.Controls.Add(Me.Btn_Baja)
        Me.tab_Listado.Controls.Add(Me.BTN_Buscar)
        Me.tab_Listado.Controls.Add(Me.tbx_Buscar)
        Me.tab_Listado.Controls.Add(Me.Lbl_Buscar)
        Me.tab_Listado.Controls.Add(Me.lsv_Catalogo)
        Me.tab_Listado.Location = New System.Drawing.Point(4, 22)
        Me.tab_Listado.Name = "tab_Listado"
        Me.tab_Listado.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_Listado.Size = New System.Drawing.Size(776, 535)
        Me.tab_Listado.TabIndex = 0
        Me.tab_Listado.Text = "Listado"
        Me.tab_Listado.UseVisualStyleBackColor = True
        '
        'Lbl_Registros
        '
        Me.Lbl_Registros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Registros.Location = New System.Drawing.Point(631, 30)
        Me.Lbl_Registros.Name = "Lbl_Registros"
        Me.Lbl_Registros.Size = New System.Drawing.Size(140, 19)
        Me.Lbl_Registros.TabIndex = 9
        Me.Lbl_Registros.Text = "Registros: 0"
        Me.Lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTN_Modificar
        '
        Me.BTN_Modificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BTN_Modificar.Enabled = False
        Me.BTN_Modificar.Image = Global.Modulo_MaterialesCentral.My.Resources.Resources.Editar
        Me.BTN_Modificar.Location = New System.Drawing.Point(153, 497)
        Me.BTN_Modificar.Name = "BTN_Modificar"
        Me.BTN_Modificar.Size = New System.Drawing.Size(140, 30)
        Me.BTN_Modificar.TabIndex = 5
        Me.BTN_Modificar.Text = "&Modificar"
        Me.BTN_Modificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_Modificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_Modificar.UseVisualStyleBackColor = True
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_MaterialesCentral.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(631, 497)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 8
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'BTN_Exportar
        '
        Me.BTN_Exportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BTN_Exportar.Image = Global.Modulo_MaterialesCentral.My.Resources.Resources.Exportar
        Me.BTN_Exportar.Location = New System.Drawing.Point(299, 497)
        Me.BTN_Exportar.Name = "BTN_Exportar"
        Me.BTN_Exportar.Size = New System.Drawing.Size(140, 30)
        Me.BTN_Exportar.TabIndex = 6
        Me.BTN_Exportar.Text = "&Exportar"
        Me.BTN_Exportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_Exportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_Exportar.UseVisualStyleBackColor = True
        '
        'Btn_Baja
        '
        Me.Btn_Baja.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn_Baja.Enabled = False
        Me.Btn_Baja.Image = Global.Modulo_MaterialesCentral.My.Resources.Resources.BajaReing
        Me.Btn_Baja.Location = New System.Drawing.Point(4, 497)
        Me.Btn_Baja.Name = "Btn_Baja"
        Me.Btn_Baja.Size = New System.Drawing.Size(142, 30)
        Me.Btn_Baja.TabIndex = 4
        Me.Btn_Baja.Text = "&Baja / Reing."
        Me.Btn_Baja.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Baja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Baja.UseVisualStyleBackColor = True
        '
        'BTN_Buscar
        '
        Me.BTN_Buscar.Image = Global.Modulo_MaterialesCentral.My.Resources.Resources.Buscar
        Me.BTN_Buscar.Location = New System.Drawing.Point(631, 4)
        Me.BTN_Buscar.Name = "BTN_Buscar"
        Me.BTN_Buscar.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Buscar.TabIndex = 2
        Me.BTN_Buscar.Text = "B&uscar"
        Me.BTN_Buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_Buscar.UseVisualStyleBackColor = True
        '
        'Lbl_Buscar
        '
        Me.Lbl_Buscar.AutoSize = True
        Me.Lbl_Buscar.Location = New System.Drawing.Point(3, 9)
        Me.Lbl_Buscar.Name = "Lbl_Buscar"
        Me.Lbl_Buscar.Size = New System.Drawing.Size(43, 13)
        Me.Lbl_Buscar.TabIndex = 1
        Me.Lbl_Buscar.Text = "Buscar:"
        '
        'Tab_Nuevo
        '
        Me.Tab_Nuevo.Controls.Add(Me.cmb_ControlFolios)
        Me.Tab_Nuevo.Controls.Add(Me.Label5)
        Me.Tab_Nuevo.Controls.Add(Me.lbl_ControlFolios)
        Me.Tab_Nuevo.Controls.Add(Me.Label4)
        Me.Tab_Nuevo.Controls.Add(Me.Label3)
        Me.Tab_Nuevo.Controls.Add(Me.Label2)
        Me.Tab_Nuevo.Controls.Add(Me.Label1)
        Me.Tab_Nuevo.Controls.Add(Me.Lbl_PrecioCompra)
        Me.Tab_Nuevo.Controls.Add(Me.lbl_Cantidad_Unidad)
        Me.Tab_Nuevo.Controls.Add(Me.lbl_Clave)
        Me.Tab_Nuevo.Controls.Add(Me.btn_Cancelar)
        Me.Tab_Nuevo.Controls.Add(Me.btn_Guardar)
        Me.Tab_Nuevo.Controls.Add(Me.lbl_Descripcion)
        Me.Tab_Nuevo.Controls.Add(Me.tbx_PrecioCompra)
        Me.Tab_Nuevo.Controls.Add(Me.tbx_Cantidad_Unidad)
        Me.Tab_Nuevo.Controls.Add(Me.tbx_Clave)
        Me.Tab_Nuevo.Controls.Add(Me.tbx_Descripcion)
        Me.Tab_Nuevo.Location = New System.Drawing.Point(4, 22)
        Me.Tab_Nuevo.Name = "Tab_Nuevo"
        Me.Tab_Nuevo.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_Nuevo.Size = New System.Drawing.Size(776, 535)
        Me.Tab_Nuevo.TabIndex = 1
        Me.Tab_Nuevo.Text = "Nuevo"
        Me.Tab_Nuevo.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(235, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(11, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "*"
        '
        'lbl_ControlFolios
        '
        Me.lbl_ControlFolios.AutoSize = True
        Me.lbl_ControlFolios.Location = New System.Drawing.Point(49, 119)
        Me.lbl_ControlFolios.Name = "lbl_ControlFolios"
        Me.lbl_ControlFolios.Size = New System.Drawing.Size(64, 13)
        Me.lbl_ControlFolios.TabIndex = 12
        Me.lbl_ControlFolios.Text = "Tiene Folios"
        Me.lbl_ControlFolios.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(175, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(11, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(541, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(11, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(235, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(11, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "*"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(235, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(11, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "*"
        '
        'Lbl_PrecioCompra
        '
        Me.Lbl_PrecioCompra.AutoSize = True
        Me.Lbl_PrecioCompra.Location = New System.Drawing.Point(22, 93)
        Me.Lbl_PrecioCompra.Name = "Lbl_PrecioCompra"
        Me.Lbl_PrecioCompra.Size = New System.Drawing.Size(91, 13)
        Me.Lbl_PrecioCompra.TabIndex = 9
        Me.Lbl_PrecioCompra.Text = "Precio de Compra"
        Me.Lbl_PrecioCompra.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_Cantidad_Unidad
        '
        Me.lbl_Cantidad_Unidad.AutoSize = True
        Me.lbl_Cantidad_Unidad.Location = New System.Drawing.Point(27, 67)
        Me.lbl_Cantidad_Unidad.Name = "lbl_Cantidad_Unidad"
        Me.lbl_Cantidad_Unidad.Size = New System.Drawing.Size(86, 13)
        Me.lbl_Cantidad_Unidad.TabIndex = 6
        Me.lbl_Cantidad_Unidad.Text = "Cantidad Unidad"
        Me.lbl_Cantidad_Unidad.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_Clave
        '
        Me.lbl_Clave.AutoSize = True
        Me.lbl_Clave.Location = New System.Drawing.Point(79, 15)
        Me.lbl_Clave.Name = "lbl_Clave"
        Me.lbl_Clave.Size = New System.Drawing.Size(34, 13)
        Me.lbl_Clave.TabIndex = 0
        Me.lbl_Clave.Text = "Clave"
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Image = Global.Modulo_MaterialesCentral.My.Resources.Resources.Cancelar
        Me.btn_Cancelar.Location = New System.Drawing.Point(265, 141)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cancelar.TabIndex = 16
        Me.btn_Cancelar.Text = "&Cancelar"
        Me.btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Image = Global.Modulo_MaterialesCentral.My.Resources.Resources.Guardar
        Me.btn_Guardar.Location = New System.Drawing.Point(119, 141)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Guardar.TabIndex = 15
        Me.btn_Guardar.Text = "&Guardar"
        Me.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'lbl_Descripcion
        '
        Me.lbl_Descripcion.AutoSize = True
        Me.lbl_Descripcion.Location = New System.Drawing.Point(50, 41)
        Me.lbl_Descripcion.Name = "lbl_Descripcion"
        Me.lbl_Descripcion.Size = New System.Drawing.Size(63, 13)
        Me.lbl_Descripcion.TabIndex = 3
        Me.lbl_Descripcion.Text = "Descripcion"
        Me.lbl_Descripcion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbx_Buscar
        '
        Me.tbx_Buscar.Control_Siguiente = Me.BTN_Buscar
        Me.tbx_Buscar.Filtrado = False
        Me.tbx_Buscar.Location = New System.Drawing.Point(57, 6)
        Me.tbx_Buscar.Name = "tbx_Buscar"
        Me.tbx_Buscar.Size = New System.Drawing.Size(568, 20)
        Me.tbx_Buscar.TabIndex = 1
        Me.tbx_Buscar.TipoDatos = Modulo_MaterialesCentral.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'lsv_Catalogo
        '
        Me.lsv_Catalogo.AllowColumnReorder = True
        Me.lsv_Catalogo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Catalogo.FullRowSelect = True
        Me.lsv_Catalogo.HideSelection = False
        Me.lsv_Catalogo.Location = New System.Drawing.Point(4, 52)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Catalogo.Lvs = ListViewColumnSorter1
        Me.lsv_Catalogo.MultiSelect = False
        Me.lsv_Catalogo.Name = "lsv_Catalogo"
        Me.lsv_Catalogo.Ocultar = ""
        Me.lsv_Catalogo.Row1 = 10
        Me.lsv_Catalogo.Row10 = 0
        Me.lsv_Catalogo.Row2 = 30
        Me.lsv_Catalogo.Row3 = 15
        Me.lsv_Catalogo.Row4 = 15
        Me.lsv_Catalogo.Row5 = 10
        Me.lsv_Catalogo.Row6 = 10
        Me.lsv_Catalogo.Row7 = 0
        Me.lsv_Catalogo.Row8 = 0
        Me.lsv_Catalogo.Row9 = 0
        Me.lsv_Catalogo.Size = New System.Drawing.Size(768, 440)
        Me.lsv_Catalogo.TabIndex = 3
        Me.lsv_Catalogo.UseCompatibleStateImageBehavior = False
        Me.lsv_Catalogo.View = System.Windows.Forms.View.Details
        '
        'cmb_ControlFolios
        '
        Me.cmb_ControlFolios.Control_Siguiente = Nothing
        Me.cmb_ControlFolios.DisplayMember = "display"
        Me.cmb_ControlFolios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ControlFolios.FormattingEnabled = True
        Me.cmb_ControlFolios.Location = New System.Drawing.Point(119, 116)
        Me.cmb_ControlFolios.MaxDropDownItems = 20
        Me.cmb_ControlFolios.Name = "cmb_ControlFolios"
        Me.cmb_ControlFolios.Size = New System.Drawing.Size(110, 21)
        Me.cmb_ControlFolios.TabIndex = 13
        Me.cmb_ControlFolios.ValueMember = "value"
        '
        'tbx_PrecioCompra
        '
        Me.tbx_PrecioCompra.Control_Siguiente = Me.btn_Guardar
        Me.tbx_PrecioCompra.Filtrado = True
        Me.tbx_PrecioCompra.Location = New System.Drawing.Point(119, 90)
        Me.tbx_PrecioCompra.MaxLength = 10
        Me.tbx_PrecioCompra.Name = "tbx_PrecioCompra"
        Me.tbx_PrecioCompra.Size = New System.Drawing.Size(110, 20)
        Me.tbx_PrecioCompra.TabIndex = 10
        Me.tbx_PrecioCompra.TipoDatos = Modulo_MaterialesCentral.FuncionesGlobales.Validar_Cadena.Numeros_Decimales
        '
        'tbx_Cantidad_Unidad
        '
        Me.tbx_Cantidad_Unidad.Control_Siguiente = Me.btn_Guardar
        Me.tbx_Cantidad_Unidad.Filtrado = True
        Me.tbx_Cantidad_Unidad.Location = New System.Drawing.Point(119, 64)
        Me.tbx_Cantidad_Unidad.MaxLength = 10
        Me.tbx_Cantidad_Unidad.Name = "tbx_Cantidad_Unidad"
        Me.tbx_Cantidad_Unidad.Size = New System.Drawing.Size(110, 20)
        Me.tbx_Cantidad_Unidad.TabIndex = 7
        Me.tbx_Cantidad_Unidad.TipoDatos = Modulo_MaterialesCentral.FuncionesGlobales.Validar_Cadena.Numeros_Decimales
        '
        'tbx_Clave
        '
        Me.tbx_Clave.Control_Siguiente = Me.tbx_Descripcion
        Me.tbx_Clave.Filtrado = True
        Me.tbx_Clave.Location = New System.Drawing.Point(119, 12)
        Me.tbx_Clave.MaxLength = 4
        Me.tbx_Clave.Name = "tbx_Clave"
        Me.tbx_Clave.Size = New System.Drawing.Size(50, 20)
        Me.tbx_Clave.TabIndex = 1
        Me.tbx_Clave.TipoDatos = Modulo_MaterialesCentral.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'tbx_Descripcion
        '
        Me.tbx_Descripcion.Control_Siguiente = Me.tbx_Cantidad_Unidad
        Me.tbx_Descripcion.Filtrado = True
        Me.tbx_Descripcion.Location = New System.Drawing.Point(119, 38)
        Me.tbx_Descripcion.MaxLength = 50
        Me.tbx_Descripcion.Name = "tbx_Descripcion"
        Me.tbx_Descripcion.Size = New System.Drawing.Size(416, 20)
        Me.tbx_Descripcion.TabIndex = 4
        Me.tbx_Descripcion.TipoDatos = Modulo_MaterialesCentral.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'frm_Materiales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.Tab_Catalogo)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_Materiales"
        Me.Text = "Catalogo de Materiales"
        Me.Tab_Catalogo.ResumeLayout(False)
        Me.tab_Listado.ResumeLayout(False)
        Me.tab_Listado.PerformLayout()
        Me.Tab_Nuevo.ResumeLayout(False)
        Me.Tab_Nuevo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Tab_Catalogo As System.Windows.Forms.TabControl
    Friend WithEvents tab_Listado As System.Windows.Forms.TabPage
    Friend WithEvents Tab_Nuevo As System.Windows.Forms.TabPage
    Friend WithEvents Lbl_Buscar As System.Windows.Forms.Label
    Friend WithEvents BTN_Buscar As System.Windows.Forms.Button
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents BTN_Exportar As System.Windows.Forms.Button
    Friend WithEvents Btn_Baja As System.Windows.Forms.Button
    Friend WithEvents BTN_Modificar As System.Windows.Forms.Button
    Friend WithEvents lbl_Descripcion As System.Windows.Forms.Label
    Friend WithEvents btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents tbx_Descripcion As Modulo_MaterialesCentral.cp_textbox
    Friend WithEvents tbx_Buscar As Modulo_MaterialesCentral.cp_textbox
    Friend WithEvents lsv_Catalogo As Modulo_MaterialesCentral.cp_Listview
    Friend WithEvents lbl_Clave As System.Windows.Forms.Label
    Friend WithEvents tbx_Clave As Modulo_MaterialesCentral.cp_textbox
    Friend WithEvents lbl_Cantidad_Unidad As System.Windows.Forms.Label
    Friend WithEvents tbx_Cantidad_Unidad As Modulo_MaterialesCentral.cp_textbox
    Friend WithEvents Lbl_PrecioCompra As System.Windows.Forms.Label
    Friend WithEvents tbx_PrecioCompra As Modulo_MaterialesCentral.cp_Textbox
    Friend WithEvents Lbl_Registros As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_ControlFolios As Modulo_MaterialesCentral.cp_cmb_Manual
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lbl_ControlFolios As System.Windows.Forms.Label
End Class
