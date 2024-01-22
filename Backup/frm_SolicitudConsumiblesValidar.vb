Imports Modulo_MaterialesCentral.Cn_Materiales

Public Class frm_SolicitudConsumiblesValidar
    Dim StatusAgrega As String = ""
    Dim Usuario_Solicita As Integer

    Private Sub frm_SolicitudConsumiblesValidar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0

        lsv_Solicitudes.Columns.Add("Número")
        lsv_Solicitudes.Columns.Add("Fecha")
        lsv_Solicitudes.Columns.Add("Hora")
        lsv_Solicitudes.Columns.Add("UsuarioSolicita")
        lsv_Solicitudes.Columns.Add("Status")

        cmb_UsuarioSolicita.Actualizar()

        cmb_Consumibles.Sucursal = False
        cmb_Consumibles.Pista = False
        cmb_Consumibles.Empresa = False
        cmb_Consumibles.AgregaParametro("@Status", "A", 0)
        cmb_Consumibles.Actualizar()

        chk_Usuarios.Checked = True
        Call LlenarSolicitudes()
    End Sub
    Private Sub chk_Usuarios_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Usuarios.CheckedChanged
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0

        lsv_Solicitudes.Items.Clear()
        dgv_Detalle.Rows.Clear()
        btn_Validar.Enabled = False
        btn_CancelarSolicitud.Enabled = False
        btn_Agregar.Enabled = False
        cmb_Consumibles.Enabled = False
        tbx_Cantidad.Enabled = False
        If chk_Usuarios.Checked Then
            cmb_UsuarioSolicita.Enabled = False
            cmb_UsuarioSolicita.SelectedValue = 0
            cmb_Consumibles.SelectedValue = 0
            tbx_Clave.Enabled = False
            tbx_Clave.Text = 0
            tbx_Cantidad.Clear()
        Else
            cmb_UsuarioSolicita.Enabled = True
            tbx_Clave.Enabled = True
        End If
    End Sub

    Private Sub cmb_UsuarioSolicita_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_UsuarioSolicita.SelectedIndexChanged
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0

        lsv_Solicitudes.Items.Clear()
        dgv_Detalle.Rows.Clear()
        btn_Validar.Enabled = False
        btn_CancelarSolicitud.Enabled = False
    End Sub

    Private Sub btn_Consultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Consultar.Click
        Call LlenarSolicitudes()
    End Sub

    Private Sub lsv_Solicitudes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Solicitudes.SelectedIndexChanged
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0

        If lsv_Solicitudes.SelectedItems.Count = 0 Then
            dgv_Detalle.Rows.Clear()
            btn_Agregar.Enabled = False
            btn_Validar.Enabled = False
            btn_CancelarSolicitud.Enabled = False
            cmb_Consumibles.Enabled = False
            cmb_Consumibles.SelectedValue = 0
            tbx_Cantidad.Enabled = False
            tbx_Cantidad.Clear()
            Exit Sub
        End If

        LlenarDetalle()
    End Sub

    Sub LlenarSolicitudes()
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0

        dgv_Detalle.Rows.Clear()
        If cmb_UsuarioSolicita.Enabled And cmb_UsuarioSolicita.SelectedValue = "0" Then
            MsgBox("Seleccione un Usuario.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_UsuarioSolicita.Focus()
            Exit Sub
        Else
            If cmb_UsuarioSolicita.Enabled Then
                Usuario_Solicita = cmb_UsuarioSolicita.SelectedValue
            Else
                Usuario_Solicita = 0
            End If
        End If

        If Not fn_ValidarSolicitudesConsumibles_LlenarLista(lsv_Solicitudes, Usuario_Solicita) Then
            MsgBox("Ha ocurrido un error al intentar consultar los datos.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        Lbl_Registros.Text = "Registros: " & lsv_Solicitudes.Items.Count
    End Sub

    Sub LlenarDetalle()

        Dim dt_Detalle As DataTable = fn_ValidarSolicitudesConsumibles_LlenarDetalle(lsv_Solicitudes.SelectedItems(0).Tag)
        If dt_Detalle Is Nothing Then
            MsgBox("Ha ocurrido un error al intentar consultar los datos.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        ElseIf dt_Detalle.Rows.Count = 0 Then
            MsgBox("No Existen Registros para esta Consulta.", MsgBoxStyle.Exclamation, frm_MENU.Text)
            Exit Sub
        End If
        'Llenar el Grid de Detalle manualmente
      
        Dim Fila As DataGridViewRow = Nothing
        Dim Celda As DataGridViewTextBoxCell = Nothing

        dgv_Detalle.Rows.Clear() 'borra llas filas del datagridview

        For Each row As DataRow In dt_Detalle.Rows
            Fila = New DataGridViewRow

            Celda = New DataGridViewTextBoxCell
            Celda.Value = row("Descripcion")
            Celda.Tag = row("Id_Consumible")
            Fila.Cells.Add(Celda)
            '--------
            Celda = New DataGridViewTextBoxCell
            Celda.ValueType = GetType(Integer)
            Celda.MaxInputLength = 5
            Celda.Value = row("CantidadSolicitada")
            Fila.Cells.Add(Celda)
            '--------
            Celda = New DataGridViewTextBoxCell
            Celda.ValueType = GetType(Integer)
            Celda.MaxInputLength = 5
            If row("Status") = "PENDIENTE" Then
                Celda.Value = row("CantidadSolicitada")
            Else
                Celda.Value = row("CantidadValidada")
            End If
            Celda.Style.BackColor = Color.LightBlue
            Fila.Cells.Add(Celda)

            '--------
            Celda = New DataGridViewTextBoxCell
            Celda.MaxInputLength = 100
            Celda.Value = row("Observaciones")
            Celda.Value.ToString.ToUpper()
            Celda.Style.BackColor = Color.LightBlue
            Fila.Cells.Add(Celda)
            '---------
            Celda = New DataGridViewTextBoxCell
            Celda.Value = row("Status")
            StatusAgrega = row("Status")
            Fila.Cells.Add(Celda)

            dgv_Detalle.Rows.Add(Fila)
        Next
        Dim habilita As Boolean = dgv_Detalle.Rows.Count > 0
        btn_Validar.Enabled = habilita
        btn_CancelarSolicitud.Enabled = habilita
        btn_Agregar.Enabled = habilita
        cmb_Consumibles.Enabled = habilita
        tbx_Cantidad.Enabled = habilita
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub btn_Validar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Validar.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0

        Dim TotalValidar As Integer = 0

        'Guardar Los Datos
        Dim Dt As New DataTable
        Dt.Columns.Add(New DataColumn("Id_Solicitud", GetType(Integer)))
        Dt.Columns.Add(New DataColumn("Id_Consumible", GetType(Integer)))
        Dt.Columns.Add(New DataColumn("CantidadValidada", GetType(Integer)))
        Dt.Columns.Add(New DataColumn("Observaciones", GetType(String)))
        Dt.Columns.Add(New DataColumn("Status", GetType(String)))

        Dim Dr As DataRow

        For Each row As DataGridViewRow In dgv_Detalle.Rows
            Dr = Dt.NewRow()
            Dr("Id_Solicitud") = lsv_Solicitudes.SelectedItems(0).Tag
            Dr("Id_Consumible") = row.Cells("Descripcion").Tag
            Dr("CantidadValidada") = row.Cells("CantidadValidada").Value
            Dr("Observaciones") = row.Cells("Observaciones").Value

            If row.Cells("CantidadValidada").Value = 0 Then
                row.Cells("CantidadValidada").Value = 0
                Dr("Status") = "C"
            Else
                Dr("Status") = "V"
                TotalValidar = TotalValidar + row.Cells("CantidadValidada").Value
            End If
            Dt.Rows.Add(Dr)
        Next

        Dim StatusSolicitud As Char
        'Se verifica la cantidad total a validar, si todas las cantidades son cero, 
        'la Solicitud se guarda con Status = CANCELADA
        If TotalValidar = 0 Then
            StatusSolicitud = "C"
        Else
            StatusSolicitud = "V"
        End If

        If Dt.Rows.Count > 0 Then

            If MsgBox("Confirma que desea VALIDAR la Solicitud ?", MsgBoxStyle.Question & MsgBoxStyle.YesNo, frm_MENU.Text) = MsgBoxResult.No Then
                Exit Sub
            End If
            '----------
            If Not fn_ValidarSolicitudesConsumibles_Guardar(lsv_Solicitudes.SelectedItems(0).Tag, Dt, StatusSolicitud) Then
                MsgBox("Ha Ocurrido un error al intentar guardar los datos.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
            LlenarSolicitudes()
            dgv_Detalle.Rows.Clear()
            btn_Validar.Enabled = False
            btn_CancelarSolicitud.Enabled = False
            TotalValidar = 0
            StatusSolicitud = ""
        End If
    End Sub

    Private Sub dgv_Detalle_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgv_Detalle.DataError
        If e.ColumnIndex = 2 OrElse e.ColumnIndex = 1 Then
            'MsgBox("Dato no válido. Solo se aceptan números.", MsgBoxStyle.Critical, frm_MENU.Text)
            dgv_Detalle.Rows(e.RowIndex).Cells(2).Selected = True
            dgv_Detalle.CurrentCell = dgv_Detalle.Rows(e.RowIndex).Cells(2)
            dgv_Detalle.BeginEdit(True)
        End If
    End Sub

    Private Sub lsv_Solicitudes_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Solicitudes.MouseHover
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
    End Sub

    Private Sub dgv_Detalle_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgv_Detalle.MouseHover
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
    End Sub

    Private Sub btn_CancelarSolicitud_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_CancelarSolicitud.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0

        'Guardar Los Datos
        Dim Dt As New DataTable
        Dt.Columns.Add(New DataColumn("Id_Solicitud", GetType(Integer)))
        Dt.Columns.Add(New DataColumn("Id_Consumible", GetType(Integer)))

        Dim Dr As DataRow

        For Each row As DataGridViewRow In dgv_Detalle.Rows
            Dr = Dt.NewRow()
            Dr("Id_Solicitud") = lsv_Solicitudes.SelectedItems(0).Tag
            'Dr("Id_Subclase") = row.Cells(0).Tag
            Dr("Id_Consumible") = row.Cells("Descripcion").Tag
            'Dr("CantidadValidada") = row.Cells(2).Value

            Dt.Rows.Add(Dr)
        Next

        If Dt.Rows.Count > 0 Then

            If MsgBox("Confirma que desea CANCELAR la Solicitud ?", MsgBoxStyle.Question & MsgBoxStyle.YesNo, frm_MENU.Text) = MsgBoxResult.No Then
                Exit Sub
            End If
            If Not fn_ValidarSolicitudesConsumibles_Cancelar(lsv_Solicitudes.SelectedItems(0).Tag, Dt) Then
                MsgBox("Ha Ocurrido un error al intentar guardar los datos.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            Else
                MsgBox("La Solicitud ha sido marcada como CANCELADA.", MsgBoxStyle.Information, frm_MENU.Text)
            End If
            LlenarSolicitudes()
            dgv_Detalle.Rows.Clear()
            btn_Validar.Enabled = False
            btn_CancelarSolicitud.Enabled = False

        End If
    End Sub

    Private Sub chk_Usuarios_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles chk_Usuarios.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btn_Consultar.Focus()
        End If
    End Sub

    Private Sub dgv_Detalle_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgv_Detalle.EditingControlShowing
        ' referencia a la celda   
        Dim validar As TextBox = CType(e.Control, TextBox)

        ' agregar el controlador de eventos para el KeyPress   
        AddHandler validar.KeyPress, AddressOf ValidarTexbox_Keypress

    End Sub

    Private Sub ValidarTexbox_Keypress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        ' obtener indice de la columna   
        Dim columna As Integer = dgv_Detalle.CurrentCell.ColumnIndex

        If dgv_Detalle.Columns(columna).Name = "CantidadValidada" OrElse dgv_Detalle.Columns(columna).Name = "Cantidad" Then
            If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
                e.Handled = True 'no escribe nmo avanza el carro '

            End If
        End If
        If dgv_Detalle.Columns(columna).Name = "Observaciones" Then
            If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
                e.KeyChar = Char.ToUpper(e.KeyChar) 'va connviertiendo a MAYUSCULAS
            End If
        End If

    End Sub

    Private Sub btn_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Agregar.Click
        SegundosDesconexion = 0
        If cmb_Consumibles.SelectedValue = 0 Then
            MsgBox("Seleccione Un elemento de la lista.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Consumibles.Focus()
            Exit Sub
        End If
        If tbx_Cantidad.Text = "" Then
            MsgBox("Escriba la cantidad a Solicitar del Accesorio o Consumible.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Cantidad.Focus()
            Exit Sub
        End If
        Dim cuenta As Byte = 0
        For Each filas As DataGridViewRow In dgv_Detalle.Rows
            If filas.Cells("Descripcion").Tag = cmb_Consumibles.SelectedValue Then
                dgv_Detalle.CurrentCell = Me.dgv_Detalle(0, cuenta) ' le pone el foco
                MsgBox("El Accesorio o Consumible que intenta agregar ya esta agregado.. Seleccione otro.", MsgBoxStyle.Exclamation, frm_MENU.Text)
                cmb_Consumibles.Focus()
                Exit Sub
            End If
            cuenta += 1
        Next
        '-----------
        If Not fn_InsertaSolicitudMateriales(lsv_Solicitudes.SelectedItems(0).Tag, _
                    cmb_Consumibles.SelectedValue, CInt(tbx_Cantidad.Text)) Then
            MsgBox("Ocurrio un error al insertar los datos.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        Else
            Call LlenarDetalle()
        End If
    End Sub
End Class