Imports Modulo_MaterialesCentral.Cn_Materiales

Public Class frm_ConsumiblesDeptos

    Private Sub frm_ConsumiblesDeptos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lsv_Consumibles.Columns.Add("Clave")
        lsv_Consumibles.Columns.Add("Descripcion")
        lsv_Consumibles.Columns.Add("Status")

        lsv_departamentos.Columns.Add("Clave")
        lsv_departamentos.Columns.Add("Departamento")

        lsv_Asignados.Columns.Add("Clave")
        lsv_Asignados.Columns.Add("Departamento")

        Call LlenarConsumibles()

        Call LlenarDepartamentos()
    End Sub

    Sub LlenarDepartamentos()
        SegundosDesconexion = 0
        If Not fn_Departamentos_LlenarLista(lsv_departamentos) Then
            MsgBox("Ha ocurrido un error al intentar llenar el Listado de Departamentos.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
    End Sub

    Sub LlenarConsumibles()
        SegundosDesconexion = 0
        If Not fn_CargaConsumibles(lsv_Consumibles) Then
            MsgBox("Ha ocurrido un error al intentar llenar el Listado de Consumibles.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
    End Sub

    Private Sub btn_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Agregar.Click
        SegundosDesconexion = 0
        If lsv_departamentos.SelectedItems.Count = 0 Then
            MsgBox("Debe seleccionar un Departamento.", MsgBoxStyle.Critical, frm_MENU.Text)
            lsv_departamentos.Focus()
            Exit Sub
        End If

        If lsv_Consumibles.CheckedItems.Count = 0 Then
            MsgBox("Debe marcar como Minimo un Consumible.", MsgBoxStyle.Critical, frm_MENU.Text)
            lsv_Consumibles.Focus()
            Exit Sub
        End If

        For Each Dpto As ListViewItem In lsv_Consumibles.CheckedItems
            For Each elemento As ListViewItem In lsv_Asignados.Items
                If Dpto.Text = elemento.Text Then Dpto.Checked = False
            Next
        Next

        If lsv_Consumibles.CheckedItems.Count = 0 Then Exit Sub

        Dim IdDepto As Integer = lsv_departamentos.SelectedItems(0).Tag
        If Not fn_DepartamentosConsumibles_Guardar(IdDepto, lsv_Consumibles) Then
            MsgBox("No se pudo asociar el consumible al departamento", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        Call LlenarConsumiblesIncluidos()

        For Each elemento As ListViewItem In lsv_Consumibles.CheckedItems
            elemento.Checked = False
        Next

    End Sub

    Sub LlenarConsumiblesIncluidos()
        SegundosDesconexion = 0
        If Not fn_DepartamentosConsumibles_LlenarLista(lsv_Asignados, lsv_departamentos.SelectedItems(0).Tag) Then
            MsgBox("No se pudieron consultar los consumibles asociados a los departamentos.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
    End Sub

    Private Sub lsv_departamentos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_departamentos.SelectedIndexChanged
        SegundosDesconexion = 0
        If lsv_departamentos.SelectedItems.Count = 0 Then
            lsv_Asignados.Items.Clear()
            Exit Sub
        End If
        Call LlenarConsumiblesIncluidos()
    End Sub

    Private Sub btn_Quitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Quitar.Click
        SegundosDesconexion = 0
        If lsv_Asignados.CheckedItems.Count = 0 Then
            MsgBox("Debe marcar como Minimo un Consumible a Eliminar.", MsgBoxStyle.Critical, frm_MENU.Text)
            lsv_Asignados.Focus()
            Exit Sub
        End If

        If Not fn_DepartamentosConsumibles_Borrar(lsv_Asignados) Then
            MsgBox("No se pudo Eliminar el Consumible.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        Call LlenarConsumiblesIncluidos()

        For Each elemento As ListViewItem In lsv_Consumibles.CheckedItems
            elemento.Checked = False
        Next

    End Sub
End Class