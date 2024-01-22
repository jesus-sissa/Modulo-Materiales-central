Imports Modulo_MaterialesCentral.Cn_Materiales


Public Class frm_Consumibles

    Private Sub frm_Consumibles_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lsv_Consumibles.Columns.Add("Clave")
        lsv_Consumibles.Columns.Add("Descripcion")
        lsv_Consumibles.Columns.Add("Status")
        Call LlenarLista()

    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        SegundosDesconexion = 0
        If tbx_Clave.Text = "" Then
            MsgBox("Debe indicar una Clave.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Clave.Focus()
            Exit Sub
        End If

        If tbx_Descripcion.Text = "" Then
            MsgBox("Debe indicar una Descripcion.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Descripcion.Focus()
            Exit Sub
        End If

        If rdb_Accesorio.Checked = False And rdb_Consumible.Checked = False Then
            MsgBox("Debe indicar un Tipo.", MsgBoxStyle.Critical, frm_MENU.Text)
            rdb_Accesorio.Focus()
            Exit Sub
        End If

        Dim Tipo As Byte = 1
        If rdb_Consumible.Checked Then
            Tipo = 2
        End If
        If btn_Guardar.Text = "Guardar Cambios" Then

            If tbx_Clave.Text.Trim <> tbx_Descripcion.Tag.ToString.Trim Then
                Dim dt As DataTable = fn_Consumibles_ExisteClave(tbx_Clave.Text)
                'si la clave cambió se debe validar que no exista
                If dt Is Nothing Then
                    MsgBox("Ocurrió un Error al verificar si existe la Clave.", MsgBoxStyle.Critical, frm_MENU.Text)
                    tbx_Clave.Focus()
                    tbx_Clave.SelectAll()
                    Exit Sub
                ElseIf dt.Rows.Count > 0 Then
                    MsgBox("La Clave que esta modificando ya existe en la Base de Datos.", MsgBoxStyle.Critical, frm_MENU.Text)
                    tbx_Clave.Focus()
                    tbx_Clave.SelectAll()
                    Exit Sub
                End If
            End If
            If Not fn_ActualizaConsumibles(tbx_Clave.Tag, tbx_Clave.Text, tbx_Descripcion.Text, Tipo) Then
                MsgBox("Ha ocurrido un error al intentar guardar los datos.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
            tbx_Clave.Tag = 0
            tbx_Descripcion.Tag = ""
            btn_Guardar.Text = "Guardar"

        Else
            Dim dt As DataTable = fn_Consumibles_ExisteClave(tbx_Clave.Text)
            If dt Is Nothing Then
                MsgBox("Ocurrió un Error al verificar si existe la Clave.", MsgBoxStyle.Critical, frm_MENU.Text)
                tbx_Clave.Focus()
                tbx_Clave.SelectAll()
                Exit Sub
            ElseIf dt.Rows.Count > 0 Then
                MsgBox("La Clave que esta introduciendo ya existe en la Base de Datos", MsgBoxStyle.Critical, frm_MENU.Text)
                tbx_Clave.Focus()
                tbx_Clave.SelectAll()
                Exit Sub
            End If

            If Not fn_Consumibles_Nuevo(tbx_Clave.Text, tbx_Descripcion.Text, Tipo) Then
                MsgBox("Ha ocurrido un error al intentar guardar los datos.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
        End If
        ' MsgBox("Los datos  se han guardado correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
        Call LlenarLista()
        tbx_Clave.Focus()

    End Sub

    Sub LlenarLista()
        SegundosDesconexion = 0
        tbx_Clave.Clear()
        tbx_Clave.Tag = 0
        tbx_Descripcion.Tag = ""
        tbx_Descripcion.Clear()
        lsv_Consumibles.Items.Clear()
        fn_CargaConsumibles(lsv_Consumibles)

        BTN_Exportar.Enabled = lsv_Consumibles.Items.Count > 0
        Btn_Baja.Enabled = lsv_Consumibles.SelectedItems.Count > 0
        BTN_Modificar.Enabled = lsv_Consumibles.SelectedItems.Count > 0
        Lbl_Registros.Text = "Registros: " & lsv_Consumibles.Items.Count
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0
        Me.Close()
    End Sub

    Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click
        SegundosDesconexion = 0
        tbx_Clave.Clear()
        tbx_Clave.Tag = 0
        tbx_Descripcion.Tag = ""
        tbx_Clave.Focus()
        rdb_Accesorio.Checked = False
        rdb_Consumible.Checked = False
        tbx_Descripcion.Clear()
        lsv_Consumibles.SelectedItems.Clear()
        BTN_Exportar.Enabled = lsv_Consumibles.Items.Count > 0
        btn_Guardar.Text = "Guardar"
    End Sub

    Private Sub lsv_Consumibles_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Consumibles.SelectedIndexChanged
        SegundosDesconexion = 0
        Btn_Baja.Enabled = lsv_Consumibles.SelectedItems.Count > 0
        BTN_Modificar.Enabled = lsv_Consumibles.SelectedItems.Count > 0
    End Sub

    Private Sub BTN_Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Exportar.Click
        SegundosDesconexion = 0
        FuncionesGlobales.fn_Exportar_Excel(lsv_Consumibles, 2, Me.Text, 0, 0, frm_MENU.prg_Barra)
        Cn_Login.fn_Log_Create("EXPORTAR REPORTE CONSULTA DE CATALOGO DE CONSUMIBLES")

    End Sub

    Private Sub BTN_Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Modificar.Click, lsv_Consumibles.DoubleClick
        SegundosDesconexion = 0
        If lsv_Consumibles.SelectedItems.Count > 0 Then
            tbx_Clave.Tag = lsv_Consumibles.SelectedItems(0).Tag 'almacena el Id_Consumible que trae en el Tag
            tbx_Clave.Text = lsv_Consumibles.SelectedItems(0).Text
            tbx_Descripcion.Tag = lsv_Consumibles.SelectedItems(0).Text 'almacena la Clave en este tag
            tbx_Descripcion.Text = lsv_Consumibles.SelectedItems(0).SubItems(1).Text

            If lsv_Consumibles.SelectedItems(0).SubItems(3).Text = "1" Then
                rdb_Accesorio.Checked = True
            Else
                rdb_Consumible.Checked = True
            End If
            btn_Guardar.Text = "Guardar Cambios"
            BTN_Exportar.Enabled = False
            BTN_Modificar.Enabled = False
            Btn_Baja.Enabled = False
        End If
    End Sub

    Private Sub Btn_Baja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Baja.Click
        SegundosDesconexion = 0
        If lsv_Consumibles.SelectedItems.Count > 0 Then
            If Not fn_Baja_Consumibles(lsv_Consumibles.SelectedItems(0).Tag) Then
                MsgBox("Ha ocurrido un error al intentar  dar de Baja.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            Else
                Call LlenarLista()
            End If
        End If
    End Sub

    Private Sub rdb_Accesorio_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles rdb_Accesorio.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            btn_Guardar.Focus()
        End If
    End Sub

    Private Sub rdb_Consumible_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles rdb_Consumible.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            btn_Guardar.Focus()
        End If
    End Sub

    Private Sub tbx_Descripcion_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbx_Descripcion.KeyPress
        SegundosDesconexion = 0
        If Asc(e.KeyChar) = Keys.Enter Then
            If rdb_Accesorio.Checked Then
                rdb_Accesorio.Focus()
            ElseIf rdb_Consumible.Checked Then
                rdb_Consumible.Focus()
            Else
                rdb_Accesorio.Focus()
            End If
            btn_Guardar.Focus()
        End If
    End Sub
End Class