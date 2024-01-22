Imports Modulo_MaterialesCentral.Cn_Materiales
Imports Modulo_MaterialesCentral.FuncionesGlobales
Imports System.Linq
Imports Modulo_MaterialesCentral.Cn_Excel

Public Class frm_SolicitudMaterialSurtir


    Public Id_Inventario As Integer
    Public StatusFolioado As String
    Dim Tipo As Integer
    Dim Stp As String
    Dim fecha As DateTime
    Private Sub frm_SolicitudMaterialSurtir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SegundosDesconexion = 0
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        cbx_TipoSurtido.AgregarItem("2", "AGREGAR PEDIDO COMPRA")
        cbx_TipoSurtido.AgregarItem("3", "SURTIR SOLICITUD LOCAL")
        cbx_TipoSurtido.AgregarItem("4", "AGREGAR SOLICITUD PARCIAL")

        lsv_Solicitudes.Columns.Add("Número")
        lsv_Solicitudes.Columns.Add("Fecha")
        lsv_Solicitudes.Columns.Add("Hora")
        lsv_Solicitudes.Columns.Add("UsuarioSolicita")
        lsv_Solicitudes.Columns.Add("Status")

        'dgv_Detalle.Columns("Folio_Inicio").Visible = False
        'dgv_Detalle.Columns("Folio_Fin").Visible = False
        dgv_Detalle.Columns("Faltantes").Visible = False

    End Sub
    Sub LlenarSolicitudes(Tipo As Integer, Status As String)
        SegundosDesconexion = 0
        Dim Usuario_Solicita As Integer = 0
        Dim FechaDesde As Date = #1/1/2010#
        Dim FechaHasta As Date = Now.Date


        If Not fn_ConsultaSolicitudesMaterial_LlenarLista(lsv_Solicitudes, FechaDesde, FechaHasta, Status, Usuario_Solicita, Tipo) Then
            MsgBox("Ha ocurrido un error al intentar consultar los datos.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        Lbl_Registros.Text = "Registros: " & lsv_Solicitudes.Items.Count
    End Sub


    'BOTON DE AGREGAR COMPRA AL INCETARIO
    Private Sub btn_Surtir_Click(sender As Object, e As EventArgs) Handles btn_Surtir.Click
        SegundosDesconexion = 0
        Dim FolioFin As Integer
        Dim FolioIni As Integer
        Dim Validacion As Boolean
        Validacion = False
        ''Crea las columnas de nuestra DataTable
        Dim Dt_Guardar As New DataTable

        Dt_Guardar.Columns.Add(New DataColumn("Id_Solicitud", GetType(Integer)))
        Dt_Guardar.Columns.Add(New DataColumn("Id_Consumible", GetType(Integer)))
        Dt_Guardar.Columns.Add(New DataColumn("Descripcion", GetType(String)))
        Dt_Guardar.Columns.Add(New DataColumn("CantidadValidada", GetType(Integer)))
        Dt_Guardar.Columns.Add(New DataColumn("CantidadSurtida", GetType(Integer)))
        Dt_Guardar.Columns.Add(New DataColumn("Observaciones", GetType(String)))
        Dt_Guardar.Columns.Add(New DataColumn("Faltantes", GetType(Integer)))
        Dt_Guardar.Columns.Add(New DataColumn("Status", GetType(String)))
        Dt_Guardar.Columns.Add(New DataColumn("Foliado", GetType(String)))
        Dt_Guardar.Columns.Add(New DataColumn("Folio_Inicio", GetType(Integer)))
        Dt_Guardar.Columns.Add(New DataColumn("Folio_Final", GetType(Integer)))
        Dt_Guardar.Columns.Add(New DataColumn("Acumulador", GetType(Integer)))


        Dim Dr As DataRow
        Dim row As DataGridViewRow
        ''Asignamos el valor correspondiente a nuestro DataTable, obteniendolos de dgv_Detalle
        For Each row In dgv_Detalle.Rows
            Dr = Dt_Guardar.NewRow()
            Dr("Id_Solicitud") = lsv_Solicitudes.SelectedItems(0).Tag
            Dr("Id_Consumible") = row.Cells("Descripcion").Tag
            Dr("Descripcion") = row.Cells("Descripcion").Value.ToString
            Dr("CantidadValidada") = row.Cells("CantidadValidada").Value
            If row.Cells("CantidadSurtida").Value = 0 Then

                MsgBox("La contidad  a Surtir no puede ser (0)." & Chr(13) & Chr(13) &
                                        "Material: " & row.Cells("Descripcion").Value.ToString & Chr(13), MsgBoxStyle.Critical, frm_MENU.Text)

                Exit For
            End If
            Dr("CantidadSurtida") = row.Cells("CantidadSurtida").Value
            Dr("Observaciones") = row.Cells("Observaciones").Value
            Dr("Faltantes") = 0
            Dr("Acumulador") = 0
            If row.Cells("CantidadSurtida").Value = 0 Then
                Dr("Status") = "C"

            Else
                Dr("Status") = "S"
            End If
            Dr("Foliado") = row.Cells("Foliado").Value
            StatusFolioado = row.Cells("Foliado").Value
            ''Validamos si el material tiene folio
            If row.Cells("Foliado").Value = "NO" Then

                row.Cells("Folio_Inicio").ReadOnly = True
                row.Cells("Folio_Fin").ReadOnly = True

                Dt_Guardar.Rows.Add(Dr)
            Else

                If row.Cells("Folio_Inicio").Value = "" Or row.Cells("Folio_Fin").Value = "0" Then
                    MsgBox("Capture el Folio Inicial.", MsgBoxStyle.Critical, frm_MENU.Text)


                    Exit Sub
                End If
                If row.Cells("Folio_Fin").Value = "" Or row.Cells("Folio_Inicio").Value = "0" Then
                    MsgBox("Capture el Folio Final.", MsgBoxStyle.Critical, frm_MENU.Text)


                    Exit Sub

                End If


                If Val(row.Cells("Folio_Inicio").Value) > Val(row.Cells("Folio_Fin").Value) Then
                    MsgBox("Los folios parecen ser incorrectos.", MsgBoxStyle.Critical, frm_MENU.Text)

                    Exit Sub
                End If
                FolioIni = row.Cells("Folio_Inicio").Value
                FolioFin = row.Cells("Folio_Fin").Value

                Dr("Folio_Inicio") = row.Cells("Folio_Inicio").Value
                Dr("Folio_Final") = row.Cells("Folio_Fin").Value
                Dim Cantidad As Integer

                Cantidad = (row.Cells("Folio_Fin").Value) - (row.Cells("Folio_Inicio").Value) + 1

                If Cantidad = row.Cells("CantidadSurtida").Value Then


                Else
                    MsgBox("La cantidad de Folios agregados debe ser igual a la cantidad de Folios solicitados.", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                End If

                'Consultar si los folios capturados no se han vendido ya antes a otro cliente
                Dim Dt As DataTable

                Dim Incremento As Integer
                If Cantidad >= 500 Then
                    Incremento = 60
                ElseIf Cantidad >= 200 Then
                    Incremento = 40
                ElseIf Cantidad >= 100 Then
                    Incremento = 30
                Else
                    Incremento = 10
                End If


                For I As Long = (row.Cells("Folio_Inicio").Value) To (row.Cells("Folio_Fin").Value).Trim Step Incremento
                    If I >= (row.Cells("Folio_Inicio").Value).Trim And I <= (row.Cells("Folio_Fin").Value).Trim Then
                        'Validar que los Folios capturados no se hayan asignado ya a un Departamento
                        'Dt = Cn_Materiales.fn_FoliosAsignados_ValidarFoliosDeptos(I)

                        'Dim Dt_Invetario As DataTable = fn_ConsultaInventarioMateriales(Dpto.GENERAL, 1)
                        Dt = Cn_Materiales.fn_FoliosAsignados_ValidarFolios(67, 2, I)
                        If Dt IsNot Nothing Then
                            If Dt.Rows.Count > 0 Then
                                SegundosDesconexion = 0
                                MsgBox("Al parecer uno o mas de los Folios indicados ya han sido asignados." & Chr(13) & Chr(13) &
                                "General: " & "----------------------" & Chr(13) &
                                "Fecha de Captura: " & Dt.Rows(0)("FechaCaptura") & Chr(13) &
                                "Folio Inicial: " & Dt.Rows(0)("Folio_Inicial") & Chr(13) &
                                "Folio Final: " & Dt.Rows(0)("Folio_Final") & Chr(13) &
                                "Cantidad: " & Dt.Rows(0)("Cantidad") & " Remisiones.", MsgBoxStyle.Critical, frm_MENU.Text)
                                SegundosDesconexion = 0
                                Exit Sub
                            End If
                        End If
                        'Validar que los Folios capturados no se hayan asignado ya a otros Clientes
                        'Dt = Cn_Materiales.fn_FoliosAsignados_ValidarFoliosClientes(I)
                        Dt = Cn_Materiales.fn_FoliosAsignados_ValidarFolios(67, 2, I)
                        If Dt IsNot Nothing Then
                            If Dt.Rows.Count > 0 Then
                                SegundosDesconexion = 0
                                MsgBox("Al parecer uno o mas de los Folios indicados ya han sido asignados a otro Cliente." & Chr(13) & Chr(13) &
                                "Cliente: " & Dt.Rows(0)("Clave") & " " & Dt.Rows(0)("Cliente") & Chr(13) &
                                "Fecha de Captura: " & Dt.Rows(0)("FechaCaptura") & Chr(13) &
                                "Folio Inicial: " & Dt.Rows(0)("FolioInicial") & Chr(13) &
                                "Folio Final: " & Dt.Rows(0)("FolioFinal") & Chr(13) &
                                "Cantidad: " & Dt.Rows(0)("Cantidad") & " Remisiones.", MsgBoxStyle.Critical, frm_MENU.Text)
                                SegundosDesconexion = 0
                                Exit Sub
                            End If
                        End If
                    End If
                Next
                Dt_Guardar.Rows.Add(Dr)
            End If
        Next

        Dim n As Integer = 0
        Dim Status As String = "V"
        Dim DT_invetario As DataTable = fn_ValidarSolicitudesMaterial_LlenarDetalle(lsv_Solicitudes.SelectedItems(0).Tag)



        Dim lc_dt As New DataTable
        Dim lc_dr As DataRow

        Dim Control_Folios As String = "N"
        Dim Interno As String = "S"
        Dim fechaActual As Date = Date.Now

        lc_dt.TableName = "detalle"
        lc_dt.Columns.Add("Id_Consumible")
        lc_dt.Columns.Add("Id_Inventario")

        lc_dt.Columns.Add("CantidadValidada")
        lc_dt.Columns.Add("CantidadSurtida")
        lc_dt.Columns.Add("Faltantes")
        lc_dt.Columns.Add("Folios")
        lc_dt.Columns.Add("Control_Folios")
        lc_dt.Columns.Add("Acumulador")

        For Each Dr In Dt_Guardar.Rows
            lc_dr = lc_dt.NewRow
            lc_dr("Id_Consumible") = Dt_Guardar.Rows(n)("Id_Consumible")
            lc_dr("Id_Inventario") = Dt_Guardar.Rows(n)("Id_Consumible")
            lc_dr("CantidadValidada") = Dt_Guardar.Rows(n)("CantidadValidada")
            lc_dr("CantidadSurtida") = Dt_Guardar.Rows(n)("CantidadSurtida")
            ''Validamos que la cantida a surtir no sea mayor que la validada
            If Dt_Guardar.Rows(n)("CantidadSurtida") = 0 Then
                MsgBox("La cantida a surtit no puede ser Cero.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If


            lc_dr("Faltantes") = 0
            lc_dr("Acumulador") = 0
            lc_dr("Control_Folios") = DT_invetario.Rows(n)("Foliado")
            If DT_invetario.Rows(n)("Foliado") = "SI" Then

                lc_dr("Folios") = FolioIni & "-" & FolioFin
            End If
            If DT_invetario.Rows(n)("Foliado") = "SI" Then

                Control_Folios = DT_invetario.Rows(n)("Foliado")
            End If
            'lc_dr("Folios") = ""
            lc_dt.Rows.Add(lc_dr)
            n = n + 1
        Next

        If Dt_Guardar.Rows.Count > 0 Then

            If lsv_Solicitudes.SelectedItems.Count > 0 Then
                Dim frm As New frm_FirmaElectronica
                frm.Bloquear = True
                frm.Empleado = UsuarioId
                If MsgBox("Antes de continuar descarge el archivo, si guarda y no descarga el Archivo no lo podra imprimir despues. Desea continuar", MsgBoxStyle.Question & MsgBoxStyle.YesNo, frm_MENU.Text) = MsgBoxResult.No Then
                    Exit Sub
                End If
                frm.ShowDialog()
                If frm.Firma Then

                    Dim Id_MatVenta = fn_VentasMateriales_Guardar(0, 4, fn_Fecha102(fechaActual.ToString), Interno, lc_dt, Control_Folios)
                    If Id_MatVenta > 0 Then
                        If Cn_Materiales.fn_UpdateSolicitud_IdMatVenta(lsv_Solicitudes.SelectedItems(0).Tag, Id_MatVenta) = False Then
                            MsgBox("Ocurrió un error al intentar Contactar al Administrador.", MsgBoxStyle.Critical, frm_MENU.Text)
                            Exit Sub

                        End If
                        'If Cn_Materiales.fn_AceptaMateriales_Validar(Id_MatVenta, 0) = True Then
                        'Suma el invetario al recibir lo materiales 
                        If Cn_Materiales.fn_AceptaMateriales_Aceptar(Id_MatVenta, 4) Then

                            Dim Dr1 As DataRow
                            Dim row1 As DataGridViewRow
                            For Each row1 In dgv_Detalle.Rows


                                Dim CV As Integer = 0
                                Dim CS As Integer = 0
                                Dim Id_Solicitud As Integer = 0
                                Dim Id_Consumible As Integer = 0


                                Id_Solicitud = lsv_Solicitudes.SelectedItems(0).Tag
                                Id_Consumible = row1.Cells("Descripcion").Tag
                                CV = row1.Cells("CantidadValidada").Value
                                CS = row1.Cells("CantidadSurtida").Value


                                '' Si una dgv_detalle solo tiene una fila 
                                If dgv_Detalle.Rows.Count = 1 Then

                                    If CS = 0 Then
                                        MsgBox("No puede ser 0 ", MsgBoxStyle.Critical, frm_MENU.Text)
                                        Exit Sub
                                    End If
                                    If (CS > CV) Then
                                        MsgBox("La cantidad a surtir no puede ser mayor que la contidad Validada", MsgBoxStyle.Critical, frm_MENU.Text)
                                        Exit Sub
                                    End If
                                    ''Si la ldgv_Detalle solo tiene una Fila Lo guardamos solo en la tabla Solicitudes con el estatus Surtida
                                    If Not fn_SurtirSolicitudConsumibles_Guardar(lsv_Solicitudes.SelectedItems(0).Tag, "S", Dt_Guardar) Then
                                        MsgBox("Ha Ocurrido un error al intentar guardar los datos.", MsgBoxStyle.Critical, frm_MENU.Text)
                                        Exit Sub
                                    Else
                                        If fn_Parcialidad_Guardar(Id_Solicitud, CS, Id_Consumible) = 0 Then
                                            MsgBox("Ha Ocurrido un error contactar al Administracion.", MsgBoxStyle.Critical, frm_MENU.Text)
                                            Exit Sub
                                        End If

                                    End If

                                Else
                                    '' si la contaida a surtir es igual a Cero imprimimos un MSJ
                                    If CS = 0 Then
                                        MsgBox("No puede ser 0 ", MsgBoxStyle.Critical, frm_MENU.Text)
                                        Exit Sub
                                    End If
                                    If (CS > CV) Then
                                        MsgBox("La cantidad a surtir no puede ser mayor que la contidad Validada", MsgBoxStyle.Critical, frm_MENU.Text)
                                        Exit Sub
                                    End If

                                    If CV = CS Then
                                        If Not fn_SurtirSolicitudConsumibles_Guardar(lsv_Solicitudes.SelectedItems(0).Tag, "S", lc_dt) Then
                                            MsgBox("Ha Ocurrido un error al intentar guardar los datos.", MsgBoxStyle.Critical, frm_MENU.Text)
                                            Exit Sub

                                        End If

                                        If fn_Parcialidad_Guardar(Id_Solicitud, CS, Id_Consumible) = 0 Then
                                            MsgBox("Ha Ocurrido un error contactar al Administracion.", MsgBoxStyle.Critical, frm_MENU.Text)
                                            Exit Sub
                                        End If
                                    Else
                                        If fn_Parcialidad_Guardar(Id_Solicitud, CS, Id_Consumible) = 0 Then
                                            MsgBox("Ha Ocurrido un error contactar al Administracion.", MsgBoxStyle.Critical, frm_MENU.Text)
                                            Exit Sub
                                        End If
                                    End If

                                End If



                            Next
                            '' obtenos la lista de solicitudes detalle para recirre su Status  
                            Dim dt_Status As DataTable = fn_ValidarSolicitudesMaterial_LlenarDetalle(lsv_Solicitudes.SelectedItems(0).Tag)

                            For Each r As DataRow In dt_Status.Rows
                                ''Si el Status si uno de los detalles de la solicitud tiene el Status en "Parcialidad" 
                                If r("Status") = "PARCIAL" Then
                                    ''Le cambiamos el Status a la solicitud a Parcialidades y la columan tipo  a Cuatro
                                    fn_Material_Status(lsv_Solicitudes.SelectedItems(0).Tag, "P", 4)
                                    Exit For
                                End If

                            Next


                            ''Cambia el estatus de materia la susrtido
                            'If Not fn_SurtirSolicitudConsumibles_Guardar(lsv_Solicitudes.SelectedItems(0).Tag, "S", Dt_Guardar) Then
                            '    MsgBox("Ha Ocurrido un error al intentar guardar los datos.", MsgBoxStyle.Critical, frm_MENU.Text)
                            '    Exit Sub

                            'End If


                        Else
                            MsgBox("Ha ocurrido un error al intentar recibir los Materiales.", MsgBoxStyle.Critical, frm_MENU.Text)
                            Exit Sub
                        End If
                        'Else
                        'MsgBox("El Inventario General no cuenta con suficientes existencias.", MsgBoxStyle.Critical, frm_MENU.Text)
                        'End If
                        MsgBox("Registro guardado con éxito.", MsgBoxStyle.Information, frm_MENU.Text)

                    Else
                        MsgBox("Ocurrió un error al intentar guardar la Asignación.", MsgBoxStyle.Critical, frm_MENU.Text)
                        Exit Sub
                    End If
                End If
            End If

            Call LlenarSolicitudes(Tipo, "V")


            If Tipo = 3 Then
                dgv_Detalle.Rows.Clear()
                btn_Surtir_local.Enabled = False
                BTN_Exportar.Enabled = False
            Else
                dgv_Detalle.Rows.Clear()
                btn_Surtir.Enabled = False
                BTN_Exportar.Enabled = False

            End If

            '    End If 
        End If
        frm_MENU.prg_Barra.Value = frm_MENU.prg_Barra.Maximum
        frm_MENU.prg_Barra.Value = frm_MENU.prg_Barra.Minimum
    End Sub

    Sub Correo(ByVal Dt_Datos As DataTable)

        SegundosDesconexion = 0

        Dim DetalleHTML As String = "<html><style> b{color: #D68910;} body{font-family:'Lucida Console';}</style><body><table width='100%'><tr><td colspan='4' align='center'><b style='color: #D68910;'>Boletín Informativo</b></td></tr>" _
                                    & "<tr><td colspan='4' align='center'><b style='color: #D68910;'>NOTIFICACION DE MATERIAL SURTIDO</b></td></tr>" _
                                    & "<tr><td colspan='4' align='center'><label>Sucursal:</label> " & SucursalN & " </td></tr>" _
                                    & "<tr><td colspan='4' align='center'><label>Fecha Surtido:</label> " & Now.Date.ToShortDateString & " </td></tr>" _
                                    & "<tr><td colspan='4' align='center'><label>Usuario Solicita:</label> " & lsv_Solicitudes.SelectedItems(0).SubItems(3).Text & " </td></tr>" _
                                    & "<tr><td colspan='4'><br><hr/></td></tr></table>" _
                                    & FuncionesGlobales.fn_DatatableToHTML(Dt_Datos, "DETALLE MATERIAL SURTIDO", 2, 0, 14) _
                                    & "<table style='border: solid 1px' width='100%'><tr><td align='right'><label><b>Fecha de Notificación:</b></label></td><td>" & Now.ToShortDateString & " - " & Now.ToShortTimeString & "</td></tr>" _
                                    & "<tr><td colspan='2'><hr/></td></tr><tr><td colspan='2'  align='center'><b style='color: #D68910;'>Agente de Servicios SIAC 2012</b></td></tr></table><br/></body></html>"
        'Si hay una Mail en la fila se manda, si no no.
        If lsv_Solicitudes.SelectedItems(0).SubItems(6).Text <> "" Then
            'If Not Cn_Mail.fn_Enviar_MailHTML("RAUL.COSS@SISSASEGURIDAD.COM", "MATERIAL SURTIDO", DetalleHTML, "") Then         <b style='color: #D68910;'>Agente de Servicios SIAC 2012</b>
            '    MsgBox("Ha ocurrido un error al intentar Enviar el Correo.", MsgBoxStyle.Critical, Me.Text)
            'End If
            If Not Cn_Mail.fn_Enviar_MailHTML(lsv_Solicitudes.SelectedItems(0).SubItems(6).Text, "MATERIAL SURTIDO", DetalleHTML, "") Then
                MsgBox("Ha ocurrido un error al intentar Enviar el Correo.", MsgBoxStyle.Critical, Me.Text)
            End If
        End If

    End Sub


    Private Sub lsv_Solicitudes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Solicitudes.SelectedIndexChanged


        'Inicializar la variable de desconexion

        SegundosDesconexion = 0

        If lsv_Solicitudes.SelectedItems.Count = 0 Then

            If Tipo = 4 Then
                btn_Surtir_local.Enabled = False
                BTN_Exportar.Enabled = False
                dgv_Detalle.Rows.Clear()
                dgv_Detalle.Columns("Faltantes").Visible = True
                dgv_Detalle.Columns("Folio_Inicio").Visible = True
                dgv_Detalle.Columns("Folio_Fin").Visible = True
                dgv_Detalle.Columns("foliado").Visible = True


            End If

            If Tipo = 3 Then
                btn_Surtir.Enabled = False
                BTN_Exportar.Enabled = False
                dgv_Detalle.Rows.Clear()
                'dgv_Detalle.Columns("Folio_Inicio").Visible = False
                'dgv_Detalle.Columns("Folio_Fin").Visible = False
                'dgv_Detalle.Columns("Foliado").Visible = False


            Else

                btn_Surtir_local.Enabled = False
                BTN_Exportar.Enabled = False
                dgv_Detalle.Rows.Clear()
                dgv_Detalle.Columns("Folio_Inicio").Visible = True
                dgv_Detalle.Columns("Folio_Fin").Visible = True
                dgv_Detalle.Columns("foliado").Visible = True
            End If
            Exit Sub
        End If

        If Tipo = 4 Then

            Call LlenarDetallePendientes()
        Else

            Call LlenarDetalle()
        End If



    End Sub
    Sub LlenarDetalle()
        SegundosDesconexion = 0
        Dim dt_Detalle As DataTable = fn_ValidarSolicitudesMaterial_LlenarDetalle(lsv_Solicitudes.SelectedItems(0).Tag)
        'Llenar el Grid de Detalle manualmente
        Dim a, b As Integer

        If dt_Detalle Is Nothing Then Exit Sub

        Dim Fila As DataGridViewRow
        Dim Celda As DataGridViewTextBoxCell


        For Each row As DataRow In dt_Detalle.Rows
            Fila = New DataGridViewRow

            Celda = New DataGridViewTextBoxCell
            Celda.Value = row("Descripcion")
            Celda.Tag = row("Id_Consumible")
            Fila.Cells.Add(Celda)

            Celda = New DataGridViewTextBoxCell
            Celda.ValueType = GetType(Integer)
            Celda.MaxInputLength = 5
            Celda.Value = row("CantidadSolicitada")
            Celda.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            Fila.Cells.Add(Celda)

            Celda = New DataGridViewTextBoxCell
            Celda.ValueType = GetType(Integer)
            Celda.MaxInputLength = 5
            Celda.Value = row("CantidadValidada")
            Celda.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            Fila.Cells.Add(Celda)


            Celda = New DataGridViewTextBoxCell
            Celda.ValueType = GetType(Integer)
            Celda.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            Celda.MaxInputLength = 5
            If row("Status") = "VALIDADA" Then
                Celda.Value = 0
            Else

                Celda.Value = 0
                a = row("CantidadValidada")
                b = row("CantidadSurtida")
            End If
            Celda.Style.BackColor = Color.LightBlue
            Fila.Cells.Add(Celda)

            Celda = New DataGridViewTextBoxCell
            Celda.MaxInputLength = 10
            Celda.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            Celda.Value = a - b
            Fila.Cells.Add(Celda)


            Celda = New DataGridViewTextBoxCell
            Celda.MaxInputLength = 150
            Celda.Value = ""
            Celda.Value.ToString.ToUpper()
            Fila.Cells.Add(Celda)


            Celda = New DataGridViewTextBoxCell
            Celda.Value = row("Status")
            Celda.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            Fila.Cells.Add(Celda)


            Celda = New DataGridViewTextBoxCell
            Celda.Value = row("Foliado")
            Celda.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            Fila.Cells.Add(Celda)

            If row("Foliado") = "SI" Then



                Celda = New DataGridViewTextBoxCell
                Celda.MaxInputLength = 150
                Celda.Style.BackColor = Color.LightGreen
                Celda.Value = ""
                Celda.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                Fila.Cells.Add(Celda)


                Celda = New DataGridViewTextBoxCell
                Celda.MaxInputLength = 150

                Celda.Style.BackColor = Color.LightGreen
                Celda.Value = ""
                Celda.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                Fila.Cells.Add(Celda)



            Else
                Celda = New DataGridViewTextBoxCell
                Celda.MaxInputLength = 150


                Celda.Value = ""
                Fila.Cells.Add(Celda)
                Celda.ReadOnly = True

                Celda = New DataGridViewTextBoxCell
                Celda.MaxInputLength = 150

                Celda.Value = ""
                Fila.Cells.Add(Celda)
                Celda.ReadOnly = True

            End If

            Celda = New DataGridViewTextBoxCell
            Celda.ValueType = GetType(Integer)
            Celda.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            Celda.MaxInputLength = 5
            If row("Status") = "VALIDADA" Then
                Celda.Value = row("CantidadValidada")
            Else

                Celda.Value = row("CantidadSurtida")
                a = row("CantidadValidada")
                b = row("CantidadSurtida")
            End If
            Celda.Style.BackColor = Color.LightBlue
            Fila.Cells.Add(Celda)


            dgv_Detalle.Rows.Add(Fila)
        Next

        If Tipo = 3 Then
            btn_Surtir_local.Enabled = dgv_Detalle.Rows.Count > 0

        Else

            btn_Surtir.Enabled = dgv_Detalle.Rows.Count > 0
            BTN_Exportar.Enabled = dgv_Detalle.Rows.Count > 0
        End If
    End Sub

    Sub LlenarDetallePendientes()
        SegundosDesconexion = 0
        Dim dt_Detalle As DataTable = fn_ValidarSolicitudesMaterial_LlenarDetalle_Pendiente(lsv_Solicitudes.SelectedItems(0).Tag)
        'Llenar el Grid de Detalle manualmente
        Dim a, b As Integer
        If dt_Detalle Is Nothing Then Exit Sub

        Dim Fila As DataGridViewRow
        Dim Celda As DataGridViewTextBoxCell
        For Each row As DataRow In dt_Detalle.Rows
            Fila = New DataGridViewRow

            Celda = New DataGridViewTextBoxCell
            Celda.Value = row("Descripcion")
            Celda.Tag = row("Id_Consumible")
            Fila.Cells.Add(Celda)

            Celda = New DataGridViewTextBoxCell
            Celda.ValueType = GetType(Integer)
            Celda.MaxInputLength = 5
            Celda.Value = row("CantidadSolicitada")
            Celda.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            Fila.Cells.Add(Celda)

            Celda = New DataGridViewTextBoxCell
            Celda.ValueType = GetType(Integer)
            Celda.MaxInputLength = 5
            Celda.Value = row("CantidadValidada")
            Celda.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            Fila.Cells.Add(Celda)

            Celda = New DataGridViewTextBoxCell
            Celda.ValueType = GetType(Integer)
            Celda.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            Celda.MaxInputLength = 5
            If row("Status") = "VALIDADA" Then
                Celda.Value = 0
            Else

                Celda.Value = 0
                a = row("CantidadValidada")
                b = row("CantidadSurtida")
            End If
            Celda.Style.BackColor = Color.LightBlue
            Fila.Cells.Add(Celda)

            Celda = New DataGridViewTextBoxCell
            Celda.MaxInputLength = 10
            Celda.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            Celda.Style.BackColor = Color.Aqua
            Celda.Value = a - b
            Fila.Cells.Add(Celda)
            Celda.ReadOnly = True




            Celda = New DataGridViewTextBoxCell
            Celda.MaxInputLength = 150
            Celda.Value = ""
            Celda.Value.ToString.ToUpper()
            Fila.Cells.Add(Celda)

            Celda = New DataGridViewTextBoxCell
            Celda.Style.BackColor = Color.LightGreen
            Celda.Value = row("Status")
            Celda.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            Fila.Cells.Add(Celda)




            Celda = New DataGridViewTextBoxCell
            Celda.Value = row("Foliado")
            Celda.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            Fila.Cells.Add(Celda)

            If row("Foliado") = "SI" Then



                Celda = New DataGridViewTextBoxCell
                Celda.MaxInputLength = 150
                Celda.Style.BackColor = Color.LightGreen
                Celda.Value = ""
                Celda.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                Fila.Cells.Add(Celda)


                Celda = New DataGridViewTextBoxCell
                Celda.MaxInputLength = 150

                Celda.Style.BackColor = Color.LightGreen
                Celda.Value = ""
                Celda.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                Fila.Cells.Add(Celda)



            Else
                Celda = New DataGridViewTextBoxCell
                Celda.MaxInputLength = 150


                Celda.Value = ""
                Fila.Cells.Add(Celda)
                Celda.ReadOnly = True

                Celda = New DataGridViewTextBoxCell
                Celda.MaxInputLength = 150

                Celda.Value = ""
                Fila.Cells.Add(Celda)
                Celda.ReadOnly = True

            End If

            Celda = New DataGridViewTextBoxCell
            Celda.ValueType = GetType(Integer)
            Celda.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            Celda.MaxInputLength = 5
            If row("Status") = "VALIDADA" Then
                Celda.Value = row("CantidadValidada")
            Else

                Celda.Value = row("CantidadSurtida")
                a = row("CantidadValidada")
                b = row("CantidadSurtida")
            End If
            'Celda.Style.BackColor = Color.LightBlue
            Fila.Cells.Add(Celda)


            dgv_Detalle.Rows.Add(Fila)
        Next



        If Tipo = 4 Then
                Btn_Parcial.Enabled = dgv_Detalle.Rows.Count > 0
            Else


            btn_Surtir_local.Enabled = dgv_Detalle.Rows.Count > 0
            btn_Surtir.Enabled = dgv_Detalle.Rows.Count > 0
            BTN_Exportar.Enabled = dgv_Detalle.Rows.Count > 0
        End If
    End Sub

    Private Sub btn_Cerrar_Click(sender As Object, e As EventArgs) Handles btn_Cerrar.Click
        Me.Close()
    End Sub
    Private Sub dgv_Detalle_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgv_Detalle.EditingControlShowing
        SegundosDesconexion = 0
        ' referencia a la celda   
        Dim validar As TextBox = CType(e.Control, TextBox)

        ' agregar el controlador de eventos para el KeyPress   
        AddHandler validar.KeyPress, AddressOf ValidarTexbox_Keypress

    End Sub

    Private Sub ValidarTexbox_Keypress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        SegundosDesconexion = 0
        ' obtener indice de la columna   
        Dim columna As Integer = dgv_Detalle.CurrentCell.ColumnIndex

        If dgv_Detalle.Columns(columna).Name = "CantidadSurtida" OrElse dgv_Detalle.Columns(columna).Name = "Cantidad" Then
            If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
                e.Handled = True 'no escribe nmo avanza el carro '

            End If
        End If
        If dgv_Detalle.Columns(columna).Name = "Folio Inicio" OrElse dgv_Detalle.Columns(columna).Name = "Folio_Inicio" Then
            If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
                e.Handled = True 'no escribe nmo avanza el carro '

            End If
        End If
        If dgv_Detalle.Columns(columna).Name = "Folio Fin" OrElse dgv_Detalle.Columns(columna).Name = "Folio_Fin" Then
            If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
                e.Handled = True 'no escribe nmo avanza el carro '

            End If
        End If
        If dgv_Detalle.Columns(columna).Name = "" OrElse dgv_Detalle.Columns(columna).Name = "Faltantes" Then
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


    Private Sub dgv_Detalle_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgv_Detalle.DataError
        If e.ColumnIndex = 3 Then
            MsgBox("Dato no válido. Solo se aceptan números.", MsgBoxStyle.Critical, frm_MENU.Text)
            dgv_Detalle.Rows(e.RowIndex).Cells(3).Selected = True
            dgv_Detalle.CurrentCell = dgv_Detalle.Rows(e.RowIndex).Cells(3)
            dgv_Detalle.BeginEdit(True)
        End If
    End Sub

    Private Sub dgv_Detalle_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Detalle.CellContentClick
        SegundosDesconexion = 0
    End Sub

    Private Sub BTN_Exportar_Click(sender As Object, e As EventArgs) Handles BTN_Exportar.Click
        SegundosDesconexion = 0
        'Cn_Login.fn_Log_Create("EXPORTAR REPORTE DE INVENTARIO DE MATERIALES ")
        If Tipo = 2 Or Tipo = 4 Then

            Call ExportarGrid__Compra(dgv_Detalle, "Proveedor")
        End If

    End Sub

    Sub ExportarGrid__Compra(EGrid As DataGridView, Nombre As String)
        Dim exApp As New Microsoft.Office.Interop.Excel.Application
        Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
        Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet

        exLibro = exApp.Workbooks.Add
        exHoja = exLibro.Worksheets.Add()

        'exHoja.Range("C1", "C5").HorizontalAlignment = HorizontalAlignment.Center
        exHoja.Range("B1:B5").HorizontalAlignment = 4
        exHoja.Range("B1:B5").Font.Bold = 14


        ''Nombre de las columnas del excel
        exHoja.Cells.Item(1, 2) = "Número de Solicitud:"
        exHoja.Cells.Item(2, 2) = "Usuario Solicita:"
        exHoja.Cells.Item(3, 2) = "Sucursal:"
        exHoja.Cells.Item(4, 2) = "Departamento:"
        exHoja.Cells.Item(5, 2) = "Fecha Solicitud:"
        exHoja.Cells.Item(43, 1) = "________________"
        exHoja.Cells.Item(44, 1) = "FIRMA"
        exHoja.Cells.Item(45, 1) = UsuarioN
        exHoja.Range("A43:A45").HorizontalAlignment = 3
        exHoja.Range("D44:D45").HorizontalAlignment = 3

        exHoja.Cells.Item(43, 4) = "________________"
        exHoja.Cells.Item(44, 4) = "FIRMA"
        exHoja.Cells.Item(45, 4) = Nombre

        exHoja.Range("C1", "C5").HorizontalAlignment = 2

        exHoja.Cells.Item(1, 3) = lsv_Solicitudes.SelectedItems(0).SubItems(0).Text
        exHoja.Cells.Item(2, 3) = lsv_Solicitudes.SelectedItems(0).SubItems(3).Text
        exHoja.Cells.Item(3, 3) = SucursalN
        exHoja.Cells.Item(4, 3) = "TRASLADO"
        exHoja.Cells.Item(5, 3) = lsv_Solicitudes.SelectedItems(0).SubItems(1).Text & "-" & lsv_Solicitudes.SelectedItems(0).SubItems(2).Text

        'exHoja.Range("a1").VerticalAlignment.

        Dim NCol As Integer = EGrid.ColumnCount
        Dim NRow As Integer = EGrid.RowCount
        For i As Integer = 1 To (NCol - 2)
            exHoja.Cells.Item(6, i) = EGrid.Columns(i - 1).Name.ToString

        Next
        Dim Rango As Integer = 0
        For Fila As Integer = 0 To NRow - 1
            For Col As Integer = 0 To NCol - 1
                exHoja.Cells.Item(Fila + 7, Col + 1) = EGrid.Rows(Fila).Cells(Col).Value
                Rango = Fila
                exHoja.Cells.Item(Fila + 7, 4) = ""
            Next

        Next

        exHoja.Range("B7", "G" & NRow + 7).HorizontalAlignment = 3
        exHoja.Range("A6", "G" & NRow + 6).Borders.LineStyle = 7
        exHoja.Range("A7", "A" & NRow + 7).VerticalAlignment = 2
        exHoja.Cells.Item(9, 4) = ""
        'exHoja.Range("A10", "G13").Borders.Weight = BorderStyle.FixedSingle

        exHoja.Cells.Item(38, 1) = "Observaciones"
        exHoja.Cells.Item(39, 1) = "_________________________________________________________________________________________"
        exHoja.Cells.Item(40, 1) = "_________________________________________________________________________________________"


        'exHoja.Shapes.AddConnector(10, 10, 250, 250).Line

        exHoja.Range("A6", "G10").Font.Size = 10

        exHoja.Cells.Item(6, 2) = "Cantidad Solicitada"
        exHoja.Cells.Item(6, 3) = "Cantidad Valida"
        exHoja.Cells.Item(6, 4) = "Check-in"

        'Dim Ruta As String = fn_ArchivosPath("C:\Users\juan.mora\Documents\RespaldoMora\Nueva carpeta\Modulo_Materiales_Central\Resources\sisssa.jpg")

        'exHoja.Pictures.Insert(Ruta)
        exHoja.Pictures.Insert("C:\Users\juan.mora\Documents\sisssa.jpg")




        exHoja.Columns.AutoFit()
        exHoja.Columns("E").Hidden = True
        exHoja.Columns("G").Hidden = True
        exHoja.Columns("F").Hidden = True
        exHoja.Columns("H").Hidden = True
        exHoja.Columns("I").Hidden = True
        exHoja.Columns("J").Hidden = True
        exHoja.Columns("K").Hidden = True


        exHoja.Columns("A").ColumnWidth = 37
        exHoja.Columns("B").ColumnWidth = 15
        exHoja.Columns("d").ColumnWidth = 15
        exHoja.Columns("C").ColumnWidth = 18
        'exHoja.Cells("B43").

        exApp.Application.Visible = True

        exHoja = Nothing
        exLibro = Nothing
        exApp = Nothing

    End Sub
    Private Sub btn_Consultar_Click(sender As Object, e As EventArgs) Handles btn_Consultar.Click
        SegundosDesconexion = 0


        dgv_Detalle.Rows.Clear()
        If cbx_TipoSurtido.SelectedValue = 0 Then
            MsgBox("Seleccione un Tipo de Solicitud.", MsgBoxStyle.Critical, frm_MENU.Text)
            cbx_TipoSurtido.Focus()
            Exit Sub
        End If
        Tipo = cbx_TipoSurtido.SelectedValue

        Call LlenarSolicitudes(Tipo, "V")
        If Tipo = 4 Then
            dgv_Detalle.Columns("Folio_Inicio").Visible = True
            dgv_Detalle.Columns("Folio_Fin").Visible = True
            dgv_Detalle.Columns("Foliado").Visible = True
            dgv_Detalle.Columns("Faltantes").Visible = True

        End If
        If Tipo = 2 Then

            dgv_Detalle.Columns("Folio_Inicio").Visible = True
            dgv_Detalle.Columns("Folio_Fin").Visible = True
            dgv_Detalle.Columns("Foliado").Visible = True
            dgv_Detalle.Columns("Faltantes").Visible = True

        Else
            If Tipo = 3 Then
                '        dgv_Detalle.Columns("Folio_Inicio").Visible = False
                '        dgv_Detalle.Columns("Folio_Fin").Visible = False
                '        dgv_Detalle.Columns("Foliado").Visible = False
                dgv_Detalle.Columns("Faltantes").Visible = False
            End If
        End If

        dgv_Detalle.Rows.Clear()
            btn_Surtir_local.Enabled = False
        BTN_Exportar.Enabled = False
        BTN_Exportar.Enabled = False

        dgv_Detalle.Rows.Clear()
            btn_Surtir.Enabled = False
        BTN_Exportar.Enabled = False
        Btn_Parcial.Enabled = False


        frm_MENU.prg_Barra.Value = frm_MENU.prg_Barra.Maximum
        frm_MENU.prg_Barra.Value = frm_MENU.prg_Barra.Minimum
    End Sub


    ''BOTON DE VENTAS LOCALES 
    Private Sub btn_Surtir_local_Click(sender As Object, e As EventArgs) Handles btn_Surtir_local.Click
        SegundosDesconexion = 0
        Dim FolioFin As Integer
        Dim FolioIni As Integer
        Dim Validacion As Boolean
        Validacion = False
        ''Crea las columnas de nuestra DataTable
        Dim Dt_Guardar As New DataTable

        Dt_Guardar.Columns.Add(New DataColumn("Id_Solicitud", GetType(Integer)))
        Dt_Guardar.Columns.Add(New DataColumn("Id_Consumible", GetType(Integer)))
        Dt_Guardar.Columns.Add(New DataColumn("Descripcion", GetType(String)))
        Dt_Guardar.Columns.Add(New DataColumn("CantidadValidada", GetType(Integer)))
        Dt_Guardar.Columns.Add(New DataColumn("CantidadSurtida", GetType(Integer)))
        Dt_Guardar.Columns.Add(New DataColumn("Observaciones", GetType(String)))
        Dt_Guardar.Columns.Add(New DataColumn("Faltantes", GetType(Integer)))
        Dt_Guardar.Columns.Add(New DataColumn("Status", GetType(String)))
        Dt_Guardar.Columns.Add(New DataColumn("Foliado", GetType(String)))
        Dt_Guardar.Columns.Add(New DataColumn("Folio_Inicio", GetType(Integer)))
        Dt_Guardar.Columns.Add(New DataColumn("Folio_Final", GetType(Integer)))
        Dt_Guardar.Columns.Add(New DataColumn("Acumulador", GetType(Integer)))


        Dim Dr As DataRow
        Dim row As DataGridViewRow
        ''Asignamos el valor correspondiente a nuestro DataTable, obteniendolos de dgv_Detalle
        For Each row In dgv_Detalle.Rows
            Dr = Dt_Guardar.NewRow()
            Dr("Id_Solicitud") = lsv_Solicitudes.SelectedItems(0).Tag
            Dr("Id_Consumible") = row.Cells("Descripcion").Tag
            Dr("Descripcion") = row.Cells("Descripcion").Value.ToString
            Dr("CantidadValidada") = row.Cells("CantidadValidada").Value

            Dr("CantidadSurtida") = row.Cells("CantidadSurtida").Value
            Dr("Observaciones") = row.Cells("Observaciones").Value
            Dr("Faltantes") = 0
            Dr("Acumulador") = 0
            If row.Cells("CantidadSurtida").Value = 0 Then
                Dr("Status") = "C"

            Else
                Dr("Status") = "S"
            End If
            Dr("Foliado") = row.Cells("Foliado").Value
            StatusFolioado = row.Cells("Foliado").Value
            ''Validamos si el material tiene folio
            If row.Cells("Foliado").Value = "NO" Then

                row.Cells("Folio_Inicio").ReadOnly = True
                row.Cells("Folio_Fin").ReadOnly = True

                Dt_Guardar.Rows.Add(Dr)
            Else
                If Dr("Status") = "C" Then
                Else
                    '--------------------------------------
                    If row.Cells("Folio_Inicio").Value = "" Or row.Cells("Folio_Fin").Value = "0" Then
                        MsgBox("Capture el Folio Inicial.", MsgBoxStyle.Critical, frm_MENU.Text)


                        Exit Sub
                    End If
                    If row.Cells("Folio_Fin").Value = "" Or row.Cells("Folio_Inicio").Value = "0" Then
                        MsgBox("Capture el Folio Final.", MsgBoxStyle.Critical, frm_MENU.Text)


                        Exit Sub

                    End If


                    If Val(row.Cells("Folio_Inicio").Value) > Val(row.Cells("Folio_Fin").Value) Then
                        MsgBox("Los folios parecen ser incorrectos.", MsgBoxStyle.Critical, frm_MENU.Text)

                        Exit Sub
                    End If
                    FolioIni = row.Cells("Folio_Inicio").Value
                    FolioFin = row.Cells("Folio_Fin").Value

                    Dr("Folio_Inicio") = row.Cells("Folio_Inicio").Value
                    Dr("Folio_Final") = row.Cells("Folio_Fin").Value
                    Dim Cantidad As Integer

                    Cantidad = (row.Cells("Folio_Fin").Value) - (row.Cells("Folio_Inicio").Value) + 1

                    If Cantidad = row.Cells("CantidadSurtida").Value Then


                    Else
                        MsgBox("La cantidad de Folios agregados debe ser igual a la cantidad de Folios solicitados.", MsgBoxStyle.Critical, frm_MENU.Text)
                        Exit Sub
                    End If
                    '--------------------------------------

                End If

                Dt_Guardar.Rows.Add(Dr)
            End If
        Next

        Dim n As Integer = 0
        Dim Status As String = "V"
        Dim DT_invetario As DataTable = fn_ValidarSolicitudesMaterial_LlenarDetalle(lsv_Solicitudes.SelectedItems(0).Tag)



        Dim lc_dt As New DataTable
        Dim lc_dr As DataRow

        Dim Control_Folios As String = "N"
        Dim Interno As String = "S"
        Dim fechaActual As Date = Date.Now

        lc_dt.TableName = "detalle"
        lc_dt.Columns.Add("Id_Consumible")
        lc_dt.Columns.Add("Id_Inventario")

        lc_dt.Columns.Add("CantidadValidada")
        lc_dt.Columns.Add("CantidadSurtida")
        lc_dt.Columns.Add("Faltantes")
        lc_dt.Columns.Add("Folios")
        lc_dt.Columns.Add("Control_Folios")
        lc_dt.Columns.Add("Acumulador")
        lc_dt.Columns.Add("Folio_Inicial")
        lc_dt.Columns.Add("Folio_Final")

        For Each Dr In Dt_Guardar.Rows
            lc_dr = lc_dt.NewRow
            lc_dr("Id_Consumible") = Dt_Guardar.Rows(n)("Id_Consumible")
            lc_dr("Id_Inventario") = Dt_Guardar.Rows(n)("Id_Consumible")
            lc_dr("CantidadValidada") = Dt_Guardar.Rows(n)("CantidadValidada")
            lc_dr("CantidadSurtida") = Dt_Guardar.Rows(n)("CantidadSurtida")
            lc_dr("Faltantes") = 0
            lc_dr("Acumulador") = 0
            lc_dr("Control_Folios") = DT_invetario.Rows(n)("Foliado")
            If DT_invetario.Rows(n)("Foliado") = "SI" Then

                lc_dr("Folios") = FolioIni & "-" & FolioFin
            End If
            If DT_invetario.Rows(n)("Foliado") = "SI" Then

                Control_Folios = DT_invetario.Rows(n)("Foliado")
                lc_dr("Folio_Inicial") = FolioIni
                lc_dr("Folio_Final") = FolioFin
            End If
            'lc_dr("Folios") = ""
            lc_dt.Rows.Add(lc_dr)
            n = n + 1
        Next

        If Dt_Guardar.Rows.Count > 0 Then

            If lsv_Solicitudes.SelectedItems.Count > 0 Then
                Dim frm As New frm_FirmaElectronica
                frm.Bloquear = True
                frm.Empleado = UsuarioId

                frm.ShowDialog()
                If frm.Firma Then

                    Dim Id_MatVenta = fn_VentasMaterialeslocal_Guardar(0, 4, fn_Fecha102(fechaActual.ToString), Interno, lc_dt, Control_Folios, lsv_Solicitudes.SelectedItems(0).Tag)
                    If Id_MatVenta > 0 Then
                        '''' Validamos que si hay existencias en el invetario
                        If Cn_Materiales.fn_AceptaMateriales_Validar(Id_MatVenta, 4) = True Then

                            'Suma el invetario al recibir lo materiales 
                            If Cn_Materiales.fn_AceptaMateriales_Resta(Id_MatVenta, 4) Then

                                'Cambia el estatus de materia la susrtido
                                If Not fn_SurtirSolicitudMaterial_Local(lsv_Solicitudes.SelectedItems(0).Tag, "S", Dt_Guardar) Then
                                    MsgBox("Ha Ocurrido un error al intentar guardar los datos.", MsgBoxStyle.Critical, frm_MENU.Text)
                                    Exit Sub
                                Else
                                    'Envia ALerta al Usuario Solicitante    
                                    Call Correo(Dt_Guardar)

                                    'If Tipo = 3 Then
                                    '    Call ExportarGrid__Compra(dgv_Detalle, "NOMBRE DE RECIBIDO")
                                    'End If
                                End If

                            Else
                                MsgBox("Ha ocurrido un error al intentar recibir los Materiales.", MsgBoxStyle.Critical, frm_MENU.Text)
                                Exit Sub
                            End If
                        Else
                            MsgBox("El Inventario General no cuenta con suficientes existencias.", MsgBoxStyle.Critical, frm_MENU.Text)
                            Exit Sub
                        End If

                    Else
                        MsgBox("Ocurrió un error al intentar guardar la Asignación.", MsgBoxStyle.Critical, frm_MENU.Text)
                        Exit Sub
                    End If
                    MsgBox("Registro guardado con éxito.", MsgBoxStyle.Information, frm_MENU.Text)
                End If
            End If

            Call LlenarSolicitudes(Tipo, "V")


            If Tipo = 3 Then
                dgv_Detalle.Rows.Clear()
                btn_Surtir_local.Enabled = False
                BTN_Exportar.Enabled = False
            Else
                dgv_Detalle.Rows.Clear()
                btn_Surtir.Enabled = False
                BTN_Exportar.Enabled = False

            End If

            '    End If 
        End If

        frm_MENU.prg_Barra.Value = frm_MENU.prg_Barra.Maximum
        frm_MENU.prg_Barra.Value = frm_MENU.prg_Barra.Minimum
    End Sub

    Private Sub btn_Buscar_Click(sender As Object, e As EventArgs)
        'Tipo = Cp_cmb_formato.SelectedValue
        cbx_TipoSurtido.Text = "Seleccione..."
        Call LlenarSolicitudes(Tipo, "S")
    End Sub

    Private Sub Gbx_Botones_Enter(sender As Object, e As EventArgs) Handles Gbx_Botones.Enter

    End Sub

    Private Sub dgv_Detalle_DoubleClick(sender As Object, e As EventArgs) Handles dgv_Detalle.DoubleClick
        'MsgBox("Ha Ocurrido un error al intentar guardar los datos.", MsgBoxStyle.Critical, frm_MENU.Text)

    End Sub

    Private Sub Gbx_Solicitudes_Enter(sender As Object, e As EventArgs) Handles Gbx_Solicitudes.Enter

    End Sub
    ''BOTON DE PARCIALIDA DE SOLICITUDES
    Private Sub Btn_Parcial_Click(sender As Object, e As EventArgs) Handles Btn_Parcial.Click
        SegundosDesconexion = 0
        Dim FolioFin As Integer
        Dim FolioIni As Integer
        Dim Validacion As Boolean
        Validacion = False

        Dim Dt_Guardar As New DataTable
        ''Agregamos el nombre de la columnas de la tabblas 
        Dt_Guardar.Columns.Add(New DataColumn("Id_Solicitud", GetType(Integer)))
        Dt_Guardar.Columns.Add(New DataColumn("Id_Consumible", GetType(Integer)))
        Dt_Guardar.Columns.Add(New DataColumn("Descripcion", GetType(String)))
        Dt_Guardar.Columns.Add(New DataColumn("CantidadValidada", GetType(Integer)))
        Dt_Guardar.Columns.Add(New DataColumn("CantidadSurtida", GetType(Integer)))
        Dt_Guardar.Columns.Add(New DataColumn("Faltantes", GetType(Integer)))
        Dt_Guardar.Columns.Add(New DataColumn("Status", GetType(String)))
        Dt_Guardar.Columns.Add(New DataColumn("Foliado", GetType(String)))
        Dt_Guardar.Columns.Add(New DataColumn("Folio_Inicio", GetType(Integer)))
        Dt_Guardar.Columns.Add(New DataColumn("Folio_Final", GetType(Integer)))
        Dt_Guardar.Columns.Add(New DataColumn("Acumulador", GetType(Integer)))


        Dim Dr As DataRow
        Dim row As DataGridViewRow
        For Each row In dgv_Detalle.Rows    ''Asignamos los valores al DataTable del la  dgv_Detalle 
            Dr = Dt_Guardar.NewRow()
            Dr("Id_Solicitud") = lsv_Solicitudes.SelectedItems(0).Tag
            Dr("Id_Consumible") = row.Cells("Descripcion").Tag
            Dr("Descripcion") = row.Cells("Descripcion").Value.ToString
            Dr("CantidadValidada") = row.Cells("CantidadValidada").Value
            Dr("CantidadSurtida") = row.Cells("CantidadSurtida").Value
            Dr("Acumulador") = row.Cells("Acumulador").Value
            Dr("Faltantes") = row.Cells("Faltantes").Value
            Dr("Foliado") = row.Cells("Foliado").Value
            StatusFolioado = row.Cells("Foliado").Value

            If row.Cells("Foliado").Value = "NO" Then
                ''Si el folio es igual a "NO" entonces, Las celdas foliaod Inicion  y Final las colocamos de solo lectura
                row.Cells("Folio_Inicio").ReadOnly = True
                row.Cells("Folio_Fin").ReadOnly = True

                Dt_Guardar.Rows.Add(Dr)
            Else
                ''Si el Folio incial no tiene valor o su valor es igual cero indicamos al usuario  un mensaje
                If row.Cells("Folio_Inicio").Value = "" Or row.Cells("Folio_Fin").Value = "0" Then
                    MsgBox("Capture el Folio Inicial.", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                End If
                ''Si el Folio Final no tiene valor o su valor es igual cero indicamos al usuario  un mensaje
                If row.Cells("Folio_Fin").Value = "" Or row.Cells("Folio_Inicio").Value = "0" Then
                    MsgBox("Capture el Folio Final.", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                End If

                ''El folio inicial no puede ser mayor que folio final.
                If Val(row.Cells("Folio_Inicio").Value) > Val(row.Cells("Folio_Fin").Value) Then
                    MsgBox("Los folios parecen ser incorrectos.", MsgBoxStyle.Critical, frm_MENU.Text)

                    Exit Sub
                End If
                FolioIni = row.Cells("Folio_Inicio").Value
                FolioFin = row.Cells("Folio_Fin").Value

                Dr("Folio_Inicio") = row.Cells("Folio_Inicio").Value
                Dr("Folio_Final") = row.Cells("Folio_Fin").Value
                Dim Cantidad As Integer

                Cantidad = (row.Cells("Folio_Fin").Value) - (row.Cells("Folio_Inicio").Value) + 1
                '' El Folio Final menos el folino Inicial debe ser igual a la cantidadSurtida
                If Cantidad = row.Cells("CantidadSurtida").Value Then


                Else
                    MsgBox("La cantidad de Folios agregados debe ser igual a la cantidad de Folios solicitados.", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                End If

                'Consultar si los folios capturados no se han vendido ya antes a otro cliente
                Dim Dt As DataTable

                Dim Incremento As Integer
                If Cantidad >= 500 Then
                    Incremento = 60
                ElseIf Cantidad >= 200 Then
                    Incremento = 40
                ElseIf Cantidad >= 100 Then
                    Incremento = 30
                Else
                    Incremento = 10
                End If


                For I As Long = (row.Cells("Folio_Inicio").Value) To (row.Cells("Folio_Fin").Value).Trim Step Incremento
                    If I >= (row.Cells("Folio_Inicio").Value).Trim And I <= (row.Cells("Folio_Fin").Value).Trim Then
                        'Validar que los Folios capturados no se hayan asignado ya a un Departamento
                        'Dt = Cn_Materiales.fn_FoliosAsignados_ValidarFoliosDeptos(I)

                        'Dim Dt_Invetario As DataTable = fn_ConsultaInventarioMateriales(Dpto.GENERAL, 1)
                        Dt = Cn_Materiales.fn_FoliosAsignados_ValidarFolios(67, 1, I)
                        If Dt IsNot Nothing Then
                            If Dt.Rows.Count > 0 Then
                                SegundosDesconexion = 0
                                MsgBox("Al parecer uno o mas de los Folios indicados ya han sido asignados anteriormente a otro Departamento." & Chr(13) & Chr(13) &
                                "Departamento: " & Dt.Rows(0)("Descripcion") & Chr(13) &
                                "Fecha de Captura: " & Dt.Rows(0)("FechaCaptura") & Chr(13) &
                                "Folio Inicial: " & Dt.Rows(0)("Folio_Inicial") & Chr(13) &
                                "Folio Final: " & Dt.Rows(0)("Folio_Final") & Chr(13) &
                                "Cantidad: " & Dt.Rows(0)("Cantidad") & " Remisiones.", MsgBoxStyle.Critical, frm_MENU.Text)
                                SegundosDesconexion = 0
                                Exit Sub
                            End If
                        End If
                        'Validar que los Folios capturados no se hayan asignado ya a otros Clientes
                        'Dt = Cn_Materiales.fn_FoliosAsignados_ValidarFoliosClientes(I)
                        Dt = Cn_Materiales.fn_FoliosAsignados_ValidarFolios(67, 1, I)
                        If Dt IsNot Nothing Then
                            If Dt.Rows.Count > 0 Then
                                SegundosDesconexion = 0
                                MsgBox("Al parecer uno o mas de los Folios indicados ya han sido asignados a otro Cliente." & Chr(13) & Chr(13) &
                                "Cliente: " & Dt.Rows(0)("Clave") & " " & Dt.Rows(0)("Cliente") & Chr(13) &
                                "Fecha de Captura: " & Dt.Rows(0)("FechaCaptura") & Chr(13) &
                                "Folio Inicial: " & Dt.Rows(0)("FolioInicial") & Chr(13) &
                                "Folio Final: " & Dt.Rows(0)("FolioFinal") & Chr(13) &
                                "Cantidad: " & Dt.Rows(0)("Cantidad") & " Remisiones.", MsgBoxStyle.Critical, frm_MENU.Text)
                                SegundosDesconexion = 0
                                Exit Sub
                            End If
                        End If
                    End If
                Next
                Dt_Guardar.Rows.Add(Dr)
            End If
        Next

        Dim n As Integer = 0
        Dim Status As String = "V"
        Dim DT_invetario As DataTable = fn_ValidarSolicitudesMaterial_LlenarDetalle(lsv_Solicitudes.SelectedItems(0).Tag)

        Dim lc_dt As New DataTable
        Dim lc_dr As DataRow

        Dim Control_Folios As String = "N"
        Dim Interno As String = "S"
        Dim fechaActual As Date = Date.Now
        ''Creamos una DataTAble de nombre detalle ya asignamos el nombre de las colunmas.
        lc_dt.TableName = "detalle"
        lc_dt.Columns.Add("Id_Inventario")
        lc_dt.Columns.Add("CantidadValidada")
        lc_dt.Columns.Add("CantidadSurtida")
        lc_dt.Columns.Add("Folios")
        lc_dt.Columns.Add("Control_Folios")
        lc_dt.Columns.Add("Faltantes")

        For Each Dr In Dt_Guardar.Rows
            lc_dr = lc_dt.NewRow
            lc_dr("Id_Inventario") = Dt_Guardar.Rows(n)("Id_Consumible")
            lc_dr("CantidadValidada") = Dt_Guardar.Rows(n)("CantidadValidada")
            lc_dr("CantidadSurtida") = Dt_Guardar.Rows(n)("CantidadSurtida")
            lc_dr("Faltantes") = Dt_Guardar.Rows(n)("Faltantes")
            ''Validamos que la cantida a surtir no sea mayor que la validada
            If Dt_Guardar.Rows(n)("CantidadSurtida") = 0 Then
                MsgBox("La cantida a surtit no puede ser Cero.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If


            lc_dr("Control_Folios") = DT_invetario.Rows(n)("Foliado")
            If DT_invetario.Rows(n)("Foliado") = "S" Then
                Control_Folios = "S"
                lc_dr("Folios") = FolioIni & "-" & FolioFin
            End If
            lc_dr("Folios") = ""
            lc_dt.Rows.Add(lc_dr)
            n = n + 1
        Next

        If Dt_Guardar.Rows.Count > 0 Then

            If lsv_Solicitudes.SelectedItems.Count > 0 Then
                Dim frm As New frm_FirmaElectronica
                frm.Bloquear = True
                frm.Empleado = UsuarioId
                '' Indicamos al Usuario que tiene que descargar primero el archivo 
                If MsgBox("Antes de continuar descarge el archivo, si guarda y no descarga el Archivo no lo podra imprimir despues. Desea continuar", MsgBoxStyle.Question & MsgBoxStyle.YesNo, frm_MENU.Text) = MsgBoxResult.No Then
                    Exit Sub
                End If
                frm.ShowDialog()
                If frm.Firma Then

                    Dim Id_MatVenta = fn_VentasMateriales_Guardar(0, 4, fn_Fecha102(fechaActual.ToString), Interno, lc_dt, Control_Folios)
                    If Id_MatVenta > 0 Then
                        'If Cn_Materiales.fn_AceptaMateriales_Validar(Id_MatVenta, 0) = True Then
                        'Suma el invetario al recibir lo materiales 
                        If Cn_Materiales.fn_AceptaMateriales_Aceptar(Id_MatVenta, 4) Then

                            Dim Dr1 As DataRow
                            Dim row1 As DataGridViewRow
                            For Each row1 In dgv_Detalle.Rows


                                Dim CV As Integer = 0
                                Dim CS As Integer = 0
                                Dim Id_Solicitud As Integer = 0
                                Dim Id_Consumible As Integer = 0


                                Id_Solicitud = lsv_Solicitudes.SelectedItems(0).Tag
                                Id_Consumible = row1.Cells("Descripcion").Tag
                                CV = row1.Cells("CantidadValidada").Value
                                CS = row1.Cells("CantidadSurtida").Value
                                Dim CAcumulada = row1.Cells("Acumulador").Value

                                If dgv_Detalle.Rows.Count = 1 Then

                                    If CS = 0 Then
                                        MsgBox("No puede ser 0 ", MsgBoxStyle.Critical, frm_MENU.Text)
                                        Exit Sub
                                    End If
                                    If (CS + CAcumulada) > CV Then
                                        MsgBox("La cantidad a surtir no puede ser mayor que la contidad Faltente", MsgBoxStyle.Critical, frm_MENU.Text)
                                        Exit Sub
                                    End If
                                    ''Si la ldgv_Detalle solo tiene una Fila Lo guardamos solo en la tabla Solicitudes con el estatus Surtida
                                    If Not fn_SurtirSolicitudConsumibles_Guardar(lsv_Solicitudes.SelectedItems(0).Tag, "S", Dt_Guardar) Then
                                        MsgBox("Ha Ocurrido un error al intentar guardar los datos.", MsgBoxStyle.Critical, frm_MENU.Text)
                                        Exit Sub
                                    Else
                                        If fn_Parcialidad_Guardar(Id_Solicitud, CS, Id_Consumible) = 0 Then
                                            MsgBox("Ha Ocurrido un error contactar al Administracion.", MsgBoxStyle.Critical, frm_MENU.Text)
                                            Exit Sub
                                        End If

                                    End If

                                Else
                                    ''Si la cantidadSurtida es  gual al cero indicamos el siguente mensaje.
                                    If CS = 0 Then
                                        MsgBox("No puede ser 0 ", MsgBoxStyle.Critical, frm_MENU.Text)
                                        Exit Sub
                                    End If
                                    If (CS + CAcumulada) > CV Then
                                        MsgBox("La cantidad a surtir no puede ser mayor que la contidad Faltante", MsgBoxStyle.Critical, frm_MENU.Text)
                                        Exit Sub
                                    End If
                                    '' Si la cantida valida  es igual a la contidaSurtida volvemos a actualizar la solicitud
                                    If CV = CS Then
                                        If Not fn_SurtirSolicitudConsumibles_Guardar(lsv_Solicitudes.SelectedItems(0).Tag, "S", Dt_Guardar) Then
                                            MsgBox("Ha Ocurrido un error al intentar guardar los datos.", MsgBoxStyle.Critical, frm_MENU.Text)
                                            Exit Sub

                                        End If
                                    Else
                                        ''Y si una de la dgv_Detalles es diferente al la CantidaSolicitada entonces la guardamos en la tabla parcialidades.
                                        If fn_Parcialidad_Guardar(Id_Solicitud, CS, Id_Consumible) = 0 Then
                                            MsgBox("Ha Ocurrido un error contactar al Administracion.", MsgBoxStyle.Critical, frm_MENU.Text)
                                            Exit Sub
                                        End If

                                        If Not fn_SurtirSolicitudConsumibles_Guardar(lsv_Solicitudes.SelectedItems(0).Tag, "S", Dt_Guardar) Then
                                            MsgBox("Ha Ocurrido un error al intentar guardar los datos.", MsgBoxStyle.Critical, frm_MENU.Text)
                                            Exit Sub

                                        End If
                                    End If
                                End If
                            Next
                            ''Volvemos a recorre la tabla Solicitud detallas par ver cuales de las ya guardaa estan en esta status paarcial. 
                            ''Si hay un Material en la tabla SolitudDetalle por ende la Solictuud le actualizamos el staus a Parcial.

                            Dim dt_Status As DataTable = fn_ValidarSolicitudesMaterial_LlenarDetalle(lsv_Solicitudes.SelectedItems(0).Tag)

                            For Each r As DataRow In dt_Status.Rows
                                ''Si la solicitudDetalle es paracial Modificamos su Status a parcial en la tabla de Mat_solicitudes con tipo cuatro.
                                If r("Status") = "PARCIAL" Then

                                    fn_Material_Status(lsv_Solicitudes.SelectedItems(0).Tag, "P", 4)
                                    Exit For
                                End If

                            Next


                            ''Cambia el estatus de materia la susrtido
                            'If Not fn_SurtirSolicitudConsumibles_Guardar(lsv_Solicitudes.SelectedItems(0).Tag, "S", Dt_Guardar) Then
                            '    MsgBox("Ha Ocurrido un error al intentar guardar los datos.", MsgBoxStyle.Critical, frm_MENU.Text)
                            '    Exit Sub

                            'End If


                        Else
                            MsgBox("Ha ocurrido un error al intentar recibir los Materiales.", MsgBoxStyle.Critical, frm_MENU.Text)
                            Exit Sub
                        End If
                        'Else
                        'MsgBox("El Inventario General no cuenta con suficientes existencias.", MsgBoxStyle.Critical, frm_MENU.Text)
                        'End If
                        MsgBox("Registro guardado con éxito.", MsgBoxStyle.Information, frm_MENU.Text)

                    Else
                        MsgBox("Ocurrió un error al intentar guardar la Asignación.", MsgBoxStyle.Critical, frm_MENU.Text)
                        Exit Sub
                    End If
                End If
            End If

            Call LlenarSolicitudes(Tipo, "V")


            If Tipo = 3 Then
                dgv_Detalle.Rows.Clear()
                btn_Surtir_local.Enabled = False
                BTN_Exportar.Enabled = False
            Else
                dgv_Detalle.Rows.Clear()
                btn_Surtir.Enabled = False
                BTN_Exportar.Enabled = False

            End If

            '    End If 
        End If

        frm_MENU.prg_Barra.Value = frm_MENU.prg_Barra.Maximum
        frm_MENU.prg_Barra.Value = frm_MENU.prg_Barra.Minimum
    End Sub

    Private Sub Btn_Parcial_MouseHover(sender As Object, e As EventArgs) Handles Btn_Parcial.MouseHover

    End Sub

    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    Dim Exe As String = Application.StartupPath
    '    MsgBox(Exe)
    'End Sub
End Class