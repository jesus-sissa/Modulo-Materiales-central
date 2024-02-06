Imports System.Collections
Imports System.Windows.Forms
Imports Modulo_MaterialesCentral.FuncionesGlobales
Imports Modulo_MaterialesCentral.Cn_Datos
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine

Public Class Cn_Materiales

#Region "Funciones Compartidas"

    Public Shared Function fn_ValidarClave(ByVal clave As String, ByVal Parametro As String, ByVal Procedure As String) As Boolean
        'Aqui se actualiza un elemento 
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD

        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando(Procedure, CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, Parametro, SqlDbType.VarChar, clave)

        Try

            Dim Tbl As DataTable = Cn_Datos.EjecutaConsulta(Cmd)
            If Tbl.Rows.Count = 0 Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_LlenarLista(ByVal Procedure As String, ByVal Indice As String, ByVal Lista As cp_Listview,
                                          ByVal Sucursal As Boolean, Optional ByVal Tipo As Integer = 0,
                                          Optional ByVal Status As String = "") As Boolean
        Try
            'Aqui se llena el listview
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando(Procedure, CommandType.StoredProcedure, Cnn)

            If Sucursal Then
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            End If

            If Tipo <> 0 Then
                Cn_Datos.Crea_Parametro(Cmd, "@Tipo", SqlDbType.Int, Tipo)
                Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Status)
            Else
                Cn_Datos.Crea_Parametro(Cmd, "@Pista", SqlDbType.VarChar, "")
            End If


            'Aqui se Actualiza la lista
            Lista.Actualizar(Cmd, Indice)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_LlenarListaD(ByVal Procedure As String, ByVal Indice As String, ByVal Lista As cp_Listview, ByVal Id_VentMat As Integer) As Boolean
        Try
            'Aqui se llena el listview
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando(Procedure, CommandType.StoredProcedure, Cnn)

            Cn_Datos.Crea_Parametro(Cmd, Indice, SqlDbType.Int, Id_VentMat)

            'Aqui se Actualiza la lista
            Lista.Actualizar(Cmd, Indice)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Status(ByVal Id As Integer, ByVal status As Char, ByVal Procedimiento As String, ByVal Campo As String, ByVal Sucursal As Boolean) As Boolean
        'Aqui se actualiza un pais
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD

        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando(Procedimiento, CommandType.StoredProcedure, Cnn)
        If Sucursal Then
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        End If
        Cn_Datos.Crea_Parametro(Cmd, Campo, SqlDbType.Int, Id)
        Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, status)

        Try
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True
        Catch Ex As Exception
            TrataEx(Ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Cancela(ByVal Id As Integer, ByVal Procedimiento As String, ByVal Campo As String, ByVal Sucursal As Boolean, ByVal Usuario As Boolean) As Boolean
        'Aqui se actualiza un pais
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD

        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando(Procedimiento, CommandType.StoredProcedure, Cnn)
        If Sucursal Then
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        End If
        If Usuario = True Then
            Cn_Datos.Crea_Parametro(Cmd, "@Usuario", SqlDbType.Int, UsuarioId)
        End If
        Cn_Datos.Crea_Parametro(Cmd, Campo, SqlDbType.Int, Id)

        Try
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True
        Catch Ex As Exception
            TrataEx(Ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_StatusD(ByVal Id As Integer, ByVal status As Char, ByVal Procedimiento As String, ByVal Campo As String, ByVal Usuario As Boolean) As Boolean
        'Aqui se actualiza un pais
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando(Procedimiento, CommandType.StoredProcedure, Cnn)
        Dim resulset As Integer = 0

        Cn_Datos.Crea_Parametro(Cmd, Campo, SqlDbType.Int, Id)

        If Usuario = True Then
            Cn_Datos.Crea_Parametro(Cmd, "@Usuario", SqlDbType.Int, UsuarioId)
        End If

        Try
            resulset = Cn_Datos.EjecutarScalar(Cmd)

            If resulset > 0 Then
                Return True
            Else
                Return False
            End If

        Catch Ex As Exception
            TrataEx(Ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_ValidarDependencias(ByVal Id As Integer, ByVal Procedimiento As String, ByVal Parametro As String) As Boolean

        'Aqui se valida una dependencia
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD

        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando(Procedimiento, CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, Parametro, SqlDbType.VarChar, Id)
        Try

            Dim Tbl As DataTable = Cn_Datos.EjecutaConsulta(Cmd)
            If Tbl.Rows.Count = 0 Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_ObtenValores(ByVal Id As Integer, ByVal Procedimiento As String, ByVal Parametro As String, ByVal Sucursal As Boolean) As Array
        'Aqui se obtienen todos los valores de un registro en particular
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD

        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando(Procedimiento, CommandType.StoredProcedure, Cnn)

        If Not Parametro = "" Then
            Cn_Datos.Crea_Parametro(Cmd, Parametro, SqlDbType.Int, Id)
        End If

        If Sucursal Then
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        End If

        Try

            Dim Tbl As DataTable = Cn_Datos.EjecutaConsulta(Cmd)

            If Tbl.Rows.Count = 0 Then
                MsgBox("No existe el registro solicitado", MsgBoxStyle.Critical, frm_MENU.Text)
                Return Nothing
            Else
                Return Tbl.Rows(0).ItemArray
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

#End Region

#Region "Menu"

    Public Shared Function fn_Menu_Progreso(ByVal Progreso As Byte) As Boolean
        Try
            frm_MENU.prg_Barra.Value = Progreso
            Return True
        Catch
            Return False
        End Try
    End Function

    Public Shared Function fn_AlertasDestinos_Consultar(ByVal Clave_Alerta As String) As DataTable

        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_AlertasDestinos_Get", CommandType.StoredProcedure, Cnn)
            Crea_Parametro(Cmd, "@Clave_AlertaTipo", SqlDbType.VarChar, Clave_Alerta)

            Dim dt As DataTable = Cn_Datos.EjecutaConsulta(Cmd)
            If dt.Rows.Count > 0 Then
                Return dt
            Else
                Return Nothing
            End If

        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try

    End Function

    Public Shared Function fn_AlertasGeneradas_Guardar(ByVal Clave_AlertaTipo As String, ByVal Detalles As String, ByVal AlertasD As DataTable, ByVal EnviarMail As Boolean, ByVal Asunto As String, ByVal Adjunto As String, ByVal DetallesHTML As String) As Boolean
        Dim Id_Alerta As Integer = 0
        Dim cmd As SqlCommand
        Dim Dt_Destinos As DataTable
        Dim Encabezado As String = ""
        Dim Pie As String = ""

        Try
            'Obtener los Destinos
            Dt_Destinos = fn_AlertasDestinos_Consultar(Clave_AlertaTipo)
            If Dt_Destinos IsNot Nothing Then
                If Dt_Destinos.Rows.Count = 0 Then
                    MsgBox("No se encotnraron destinatarios para enviar la Alerta.", MsgBoxStyle.Critical, frm_MENU.Text)
                    Return False
                End If
                If Adjunto <> "" Then
                    Detalles = Detalles & Chr(13) & Chr(13) & "(Ver archivo adjunto)"
                End If

                'Guardar la alerta para cada destino
                For Each Destino As DataRow In Dt_Destinos.Rows
                    cmd = Crea_Comando("Cat_AlertasGeneradas_CreateUna", CommandType.StoredProcedure, Crea_ConexionSTD())
                    Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
                    Crea_Parametro(cmd, "@Clave_AlertaTipo", SqlDbType.VarChar, Clave_AlertaTipo)
                    Crea_Parametro(cmd, "@Detalles", SqlDbType.VarChar, Detalles)
                    Crea_Parametro(cmd, "@Id_EmpleadoDestino", SqlDbType.Int, Destino("Id_Empleado"))
                    Crea_Parametro(cmd, "@Id_EmpleadoGenera", SqlDbType.Int, UsuarioId)
                    Crea_Parametro(cmd, "@Estacion_Genera", SqlDbType.VarChar, EstacioN)
                    Crea_Parametro(cmd, "@Tipo_Alerta", SqlDbType.Int, 1)
                    Id_Alerta = CInt(EjecutarScalar(cmd))
                    'Guardar el Detalle para cada alerta generada
                    If AlertasD IsNot Nothing Then
                        For Each dr As DataRow In AlertasD.Rows
                            cmd.Parameters.Clear()
                            cmd = Crea_Comando("Cat_AlertasGeneradasD_Create", CommandType.StoredProcedure, Crea_ConexionSTD())
                            Crea_Parametro(cmd, "@Id_Alerta", SqlDbType.Int, Id_Alerta)
                            Crea_Parametro(cmd, "@Id_Entidad", SqlDbType.Int, dr("Id"))
                            Crea_Parametro(cmd, "@Clave_Entidad", SqlDbType.VarChar, dr("Clave"))
                            Crea_Parametro(cmd, "@Descripcion", SqlDbType.VarChar, dr("Nombre"))
                            EjecutarNonQuery(cmd)
                        Next
                    End If
                    If EnviarMail Then
                        Select Case Clave_AlertaTipo
                            Case "39"
                                Encabezado = "DIFERENCIA EN AUDITORIA DE CAJEROS"

                        End Select

                        Pie = "Agente de Servicios SIAC " & Now.Year.ToString

                        If DetallesHTML = "" Then
                            Cn_Mail.fn_Enviar_Mail(Destino("Mail"), Asunto, Detalles, Adjunto)
                        Else
                            DetallesHTML = Replace(DetallesHTML, "Encabezado", Encabezado)
                            DetallesHTML = Replace(DetallesHTML, "Pie", Pie)
                            Cn_Mail.fn_Enviar_MailHTML(Destino("Mail"), Asunto, DetallesHTML, Adjunto)
                        End If
                    End If
                Next
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

#End Region

#Region "Materiales"

    Public Shared Function fn_Materiales_Nuevo(ByVal Clave As String, ByVal Descripcion As String, ByVal Cantidad_Unidad As String, ByVal Precio_Compra As Decimal, ByVal Control_Folios As String) As Boolean
        Dim Cnn As SqlConnection = Crea_ConexionSTD()

        Dim Cmd As SqlCommand = Crea_Comando("Mat_Materiales_Create", CommandType.StoredProcedure, Cnn)
        Crea_Parametro(Cmd, "@Clave_Material", SqlDbType.VarChar, Clave)
        Crea_Parametro(Cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)
        Crea_Parametro(Cmd, "@Cantidad_Unidad", SqlDbType.VarChar, Cantidad_Unidad)
        Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
        Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "A")
        Crea_Parametro(Cmd, "@Precio_Compra", SqlDbType.Money, Precio_Compra)
        Crea_Parametro(Cmd, "@Control_Folios", SqlDbType.VarChar, Control_Folios)

        Try
            EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Materiales_Actualizar(ByVal Id_material As Integer, ByVal Clave As String, ByVal Descripcion As String, ByVal Cantidad_Unidad As String, ByVal Precio_Compra As Decimal, ByVal Control_Folios As String) As Boolean
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD

        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Mat_Materiales_Update", CommandType.StoredProcedure, Cnn)
        Crea_Parametro(Cmd, "@Id_Material", SqlDbType.Int, Id_material)
        Crea_Parametro(Cmd, "@Clave_Material", SqlDbType.VarChar, Clave)
        Crea_Parametro(Cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)
        Crea_Parametro(Cmd, "@Cantidad_Unidad", SqlDbType.VarChar, Cantidad_Unidad)
        Crea_Parametro(Cmd, "@Precio_Compra", SqlDbType.Money, Precio_Compra)
        Crea_Parametro(Cmd, "@Control_Folios", SqlDbType.VarChar, Control_Folios)

        Try
            EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Materiales_Baja(ByVal Id As Integer) As Boolean

        Return fn_Status(Id, "B", "Mat_Materiales_Status", "@Id_Material", False)

    End Function

    Public Shared Function fn_Materiales_Alta(ByVal Id As Integer) As Boolean

        Return fn_Status(Id, "A", "Mat_Materiales_Status", "@Id_Material", False)

    End Function

    Public Shared Function fn_Materiales_ValidarClave(ByVal Clave As String, ByVal ClaveAnt As String) As Boolean
        If ClaveAnt = "" Then GoTo Validar
        If Not Clave = ClaveAnt Then GoTo Validar
        Return True
        Exit Function
Validar:
        Return fn_ValidarClave(Clave, "@Clave_Material", "Mat_MaterialesClave_Read")

    End Function

    Public Shared Function fn_Materiales_LlenarLista(ByRef lsv_Catalogo As cp_Listview, ByRef CS As ListViewColumnSorter) As Boolean
        'Return fn_LlenarLista("Mat_Materiales_Get", "Id_Material", lsv_Catalogo, False)
        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Mat_Materiales_Get", CommandType.StoredProcedure, Cnn)
            lsv_Catalogo.Actualizar(Cmd, "Id_Material")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_Materiales_Read(ByVal Id_Material As Integer) As DataRow
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Mat_Materiales_Read", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Material", SqlDbType.Int, Id_Material)
        Try
            Dim Tbl As DataTable = Cn_Datos.EjecutaConsulta(Cmd)
            If Tbl Is Nothing Then Return Nothing
            If Tbl.Rows.Count = 0 Then
                MsgBox("No existe el registro solicitado", MsgBoxStyle.Critical, frm_MENU.Text)
                Return Nothing
            Else
                Return Tbl.Rows(0)
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try

    End Function

#End Region

#Region "Inventario Materiales"

    Public Shared Function fn_InventarioMateriales_Nuevo(ByVal Id_Material As Integer, ByVal Stock_Minimo As Integer, ByVal Existencia As Integer) As Boolean
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Transaccion As SqlClient.SqlTransaction
        Dim Cmd As SqlClient.SqlCommand
        Transaccion = Cn_Datos.crear_Trans(Cnn)
        Try
            For I As Integer = 0 To 7
                Cmd = Cn_Datos.Crea_ComandoT(Cnn, Transaccion, CommandType.StoredProcedure, "Mat_Inventario_Create")
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Material", SqlDbType.Int, Id_Material)
                Cn_Datos.Crea_Parametro(Cmd, "@Stock_Minimo", SqlDbType.Int, Stock_Minimo)
                If I = 0 Then
                    Cn_Datos.Crea_Parametro(Cmd, "@Existencia", SqlDbType.Int, Existencia)
                Else
                    Cn_Datos.Crea_Parametro(Cmd, "@Existencia", SqlDbType.Int, 0)
                End If
                Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "A")
                Cn_Datos.Crea_Parametro(Cmd, "@Tipo", SqlDbType.Int, I)
                Cn_Datos.EjecutarNonQueryT(Cmd)
            Next
            Transaccion.Commit()
            Cnn.Close()
            Return True

        Catch ex As Exception
            TrataEx(ex)
            Transaccion.Rollback()
            Cnn.Close()
            Return False
        End Try

    End Function

    Public Shared Function fn_InventarioMateriales_Actualizar(ByVal ID_Inventario As Integer, ByVal Stock_Minimo As Integer, ByVal Existencia As Integer) As Boolean
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Mat_Inventario_Update", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Inventario", SqlDbType.Int, ID_Inventario)
        Cn_Datos.Crea_Parametro(Cmd, "@Stock_Minimo", SqlDbType.Int, Stock_Minimo)
        Cn_Datos.Crea_Parametro(Cmd, "@Existencia", SqlDbType.Int, Existencia)
        Try
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_InventarioMateriales_Baja(ByVal Id As Integer) As Boolean

        Return fn_Status(Id, "B", "Mat_Inventario_Status", "@Id_Inventario", False)

    End Function

    Public Shared Function fn_InventarioMateriales_Alta(ByVal Id As Integer) As Boolean

        Return fn_Status(Id, "A", "Mat_Inventario_Status", "@Id_Inventario", False)

    End Function

    Public Shared Function fn_InventarioMateriales_ValidarClave(ByVal Clave As String, ByVal ClaveAnt As String) As Boolean
        If ClaveAnt = "" Then GoTo Validar
        If Not Clave = ClaveAnt Then GoTo Validar
        Return True
        Exit Function
Validar:
        Return fn_ValidarClave(Clave, "@Clave_Material", "Mat_InventarioClave_Read")

    End Function

    Public Shared Function fn_InventarioMateriales_LlenarLista(ByRef lsv_Catalogo As cp_Listview, ByVal Departamento As Dpto) As Boolean
        Dim cmd As SqlClient.SqlCommand = Crea_Comando("Mat_Inventario_Get", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Crea_Parametro(cmd, "@Pista", SqlDbType.VarChar, "")
        Crea_Parametro(cmd, "@Tipo", SqlDbType.Int, CInt(Departamento))

        Try
            lsv_Catalogo.Actualizar(cmd, "Id_Inventario")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_InventarioMateriales_Read(ByVal Id_Inventario As Integer) As DataRow
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Mat_Inventario_Read", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Inventario", SqlDbType.Int, Id_Inventario)
        Try
            Dim Tbl As DataTable = Cn_Datos.EjecutaConsulta(Cmd)
            If Tbl.Rows.Count = 0 Then
                MsgBox("No existe el registro solicitado", MsgBoxStyle.Critical, frm_MENU.Text)
                Return Nothing
            Else
                Return Tbl.Rows(0)
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_InventarioMateriales_ReadMaterial(ByVal Id_Material As Integer) As DataRow
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Mat_Materiales_Read", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Material", SqlDbType.Int, Id_Material)
        Try
            Dim Tbl As DataTable = Cn_Datos.EjecutaConsulta(Cmd)
            If Tbl.Rows.Count = 0 Then
                Return Nothing
            Else
                Return Tbl.Rows(0)
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_InventarioMateriales_ExisteMaterial(ByVal Id_Material As Integer) As Boolean
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Mat_Inventario_ReadMaterial", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Material", SqlDbType.Int, Id_Material)
        Cn_Datos.Crea_Parametro(Cmd, "@Tipo", SqlDbType.Int, -1)
        Try
            Dim Tbl As DataTable = Cn_Datos.EjecutaConsulta(Cmd)
            If Tbl Is Nothing Then Return True
            If Tbl.Rows.Count = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return True
        End Try
    End Function

#End Region

#Region "Ventas de Materiales"

    Public Shared Function fn_FoliosAsignados_ValidarFoliosClientes(ByVal Folio As Long) As DataTable
        Dim Dt As DataTable
        Try
            Dim Cnn As SqlConnection = Crea_ConexionSTD()
            Dim Cmd As SqlCommand = Crea_Comando("Mat_RemisionesClientes_Existe", CommandType.StoredProcedure, Cnn)

            Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Crea_Parametro(Cmd, "@Folio", SqlDbType.BigInt, Folio)

            Dt = EjecutaConsulta(Cmd)
            Return Dt
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_FoliosAsignados_ValidarFoliosDeptos(ByVal Folio As Long) As DataTable
        Dim Dt As DataTable
        Try
            Dim Cnn As SqlConnection = Crea_ConexionSTD()
            Dim Cmd As SqlCommand = Crea_Comando("Mat_RemisionesDeptos_Existe", CommandType.StoredProcedure, Cnn)

            Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Crea_Parametro(Cmd, "@Folio", SqlDbType.BigInt, Folio)

            Dt = EjecutaConsulta(Cmd)
            Return Dt
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_FoliosAsignados_ValidarFolios(ByVal Id_Inventario As Integer, ByVal Tipo As Byte, ByVal Folio As Long) As DataTable
        Dim Dt As DataTable
        Try
            Dim Cnn As SqlConnection = Crea_ConexionSTD()
            Dim Cmd As SqlCommand = Crea_Comando("Mat_RemisionesClientes_Existe", CommandType.StoredProcedure, Cnn)
            Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Crea_Parametro(Cmd, "@Id_Inventario", SqlDbType.Int, Id_Inventario)
            Crea_Parametro(Cmd, "@Folio", SqlDbType.Int, Folio)
            Crea_Parametro(Cmd, "@Tipo", SqlDbType.TinyInt, Tipo)

            Dt = EjecutaConsulta(Cmd)
            Return Dt
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_VentasMateriales_Guardar(ByVal Id_Cliente As Integer, ByVal Id_Departamento As Integer,
    ByVal Fecha_Entrega As Date, ByVal Interno As String, ByVal dt As DataTable, ByVal Control_Folios As String) As Integer

        'Aqui se inserta un nuevo registro
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim lc_Transaccion As SqlClient.SqlTransaction
        Dim Cmd As SqlClient.SqlCommand
        Dim lc_identity As Integer

        lc_Transaccion = Cn_Datos.crear_Trans(Cnn)

        Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Mat_Ventas_Create")

        Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Departamento", SqlDbType.Int, Id_Departamento)
        Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
        Cn_Datos.Crea_Parametro(Cmd, "@Fecha_Entrega", SqlDbType.DateTime, Fecha_Entrega)
        Cn_Datos.Crea_Parametro(Cmd, "@Modo_Captura", SqlDbType.Int, 1)
        Cn_Datos.Crea_Parametro(Cmd, "@Interno", SqlDbType.VarChar, Interno)
        Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "SO")
        Cn_Datos.Crea_Parametro(Cmd, "@Control_Folios", SqlDbType.VarChar, Control_Folios)


        Try
            lc_identity = Cn_Datos.EjecutarScalarT(Cmd)

        Catch ex As Exception
            lc_Transaccion.Rollback()
            Cnn.Close()
            TrataEx(ex)
            Return False
        End Try

        Try

            For Each lc_dr As DataRow In dt.Rows

                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Mat_VentasD_Create")

                Cn_Datos.Crea_Parametro(Cmd, "@Id_MatVenta", SqlDbType.Int, lc_identity)
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Inventario", SqlDbType.Int, CInt(lc_dr("Id_Inventario")))
                Cn_Datos.Crea_Parametro(Cmd, "@Cantidad", SqlDbType.Int, CInt(lc_dr("CantidadSurtida")))
                Cn_Datos.Crea_Parametro(Cmd, "@Control_Folios", SqlDbType.VarChar, lc_dr("Control_Folios"))
                Cn_Datos.EjecutarNonQueryT(Cmd)

                'If Control_Folios = "SI" Then
                If (lc_dr("Control_Folios").ToString() = "SI") Then


                    ' Si se han agregado Comprobantes de Traslado
                    Dim arrFolios() As String = Split(lc_dr("Folios"), "/")
                    For c As Integer = 0 To arrFolios.Length - 1
                        Dim Cant As Integer = 0
                        Dim arrNumeros() As String = Split(arrFolios(c), "-")
                        Dim FolioIni As Integer = CInt(arrNumeros(0).Trim)
                        Dim FolioFin As Integer = CInt(arrNumeros(1).Trim)
                        Cant = FolioFin - FolioIni + 1

                        Cmd = Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Mat_RemisionesClientes_CreateRotulo")

                        Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
                        Crea_Parametro(Cmd, "@Tipo", SqlDbType.TinyInt, 2)
                        Crea_Parametro(Cmd, "@Id_Entidad", SqlDbType.Int, Id_Departamento)
                        Crea_Parametro(Cmd, "@Id_MatVenta", SqlDbType.Int, lc_identity)
                        Crea_Parametro(Cmd, "@Id_Inventario", SqlDbType.Int, CInt(lc_dr("Id_Inventario")))
                        Crea_Parametro(Cmd, "@Cantidad", SqlDbType.Int, Cant)
                        Crea_Parametro(Cmd, "@Folio_Inicial", SqlDbType.Int, FolioIni)
                        Crea_Parametro(Cmd, "@Folio_Final", SqlDbType.Int, FolioFin)
                        Crea_Parametro(Cmd, "@Rotulado", SqlDbType.VarChar, "S")
                        Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
                        Crea_Parametro(Cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)
                        EjecutarNonQueryT(Cmd)
                    Next
                End If
                'End If


            Next


        Catch ex2 As Exception
            lc_Transaccion.Rollback()
            Cnn.Close()
            TrataEx(ex2)
            Return 0
        End Try
        lc_Transaccion.Commit()
        Cnn.Close()
        Return lc_identity

    End Function


    Public Shared Function fn_VentasMaterialeslocal_Guardar(ByVal Id_Cliente As Integer, ByVal Id_Departamento As Integer,
    ByVal Fecha_Entrega As Date, ByVal Interno As String, ByVal dt As DataTable, ByVal Control_Folios As String, ByVal Id_Solicitud As Integer) As Integer

        'Aqui se inserta un nuevo registro
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim lc_Transaccion As SqlClient.SqlTransaction
        Dim Cmd As SqlClient.SqlCommand
        Dim lc_identity As Integer

        lc_Transaccion = Cn_Datos.crear_Trans(Cnn)

        Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Mat_Ventas_Create")

        Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Departamento", SqlDbType.Int, Id_Departamento)
        Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
        Cn_Datos.Crea_Parametro(Cmd, "@Fecha_Entrega", SqlDbType.DateTime, Fecha_Entrega)
        Cn_Datos.Crea_Parametro(Cmd, "@Modo_Captura", SqlDbType.Int, 1)
        Cn_Datos.Crea_Parametro(Cmd, "@Interno", SqlDbType.VarChar, Interno)
        Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "SO")
        Cn_Datos.Crea_Parametro(Cmd, "@Control_Folios", SqlDbType.VarChar, Control_Folios)


        Try
            lc_identity = Cn_Datos.EjecutarScalarT(Cmd)

        Catch ex As Exception
            lc_Transaccion.Rollback()
            Cnn.Close()
            TrataEx(ex)
            Return False
        End Try


        Try
            For Each lc_dr As DataRow In dt.Rows

                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Mat_VentasD_Create")

                Cn_Datos.Crea_Parametro(Cmd, "@Id_MatVenta", SqlDbType.Int, lc_identity)
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Solicitud", SqlDbType.VarChar, Id_Solicitud)

                Cn_Datos.Crea_Parametro(Cmd, "@Id_Inventario", SqlDbType.Int, CInt(lc_dr("Id_Inventario")))
                Cn_Datos.Crea_Parametro(Cmd, "@Cantidad", SqlDbType.Int, CInt(lc_dr("CantidadSurtida")))
                Cn_Datos.Crea_Parametro(Cmd, "@Control_Folios", SqlDbType.VarChar, lc_dr("Control_Folios"))


                Cn_Datos.EjecutarNonQueryT(Cmd)

                If lc_dr("Control_Folios") = "SI" Then

                    Dim arrFolios() As String = Split(lc_dr("Folios"), "/")
                    For c As Integer = 0 To arrFolios.Length - 1
                        Dim Cant As Integer = 0
                        Dim arrNumeros() As String = Split(arrFolios(c), "-")
                        Dim FolioIni As Integer = CInt(arrNumeros(0).Trim)
                        Dim FolioFin As Integer = CInt(arrNumeros(1).Trim)
                        Cant = FolioFin - FolioIni + 1

                        Cmd = Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Folios_SurtidoLocal_Get")

                        Crea_Parametro(Cmd, "@Id_Solicitud", SqlDbType.Int, Id_Solicitud)


                        Crea_Parametro(Cmd, "@Folio_Inicial", SqlDbType.Int, FolioIni)
                        Crea_Parametro(Cmd, "@Folio_Final", SqlDbType.Int, FolioFin)
                        EjecutarNonQueryT(Cmd)
                    Next


                End If


            Next


        Catch ex2 As Exception
            lc_Transaccion.Rollback()
            Cnn.Close()
            TrataEx(ex2)
            Return 0
        End Try
        lc_Transaccion.Commit()
        Cnn.Close()
        Return lc_identity

    End Function

    Public Shared Function fn_AceptaMateriales_Validar(ByVal Id As Long, ByVal Tipo As Integer) As Boolean
        'Return fn_StatusD(Id, "VA", "mat_ventasd_ValidaVentaMat", "@Id_MatVenta", True)
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Mat_Ventasd_ValidaVentaMat", CommandType.StoredProcedure, Cnn)
        Dim resulset As Integer = 0

        Cn_Datos.Crea_Parametro(Cmd, "@Id_MatVenta", SqlDbType.BigInt, Id)
        Cn_Datos.Crea_Parametro(Cmd, "@Tipo", SqlDbType.Int, Tipo)

        Try
            resulset = Cn_Datos.EjecutarScalar(Cmd)

            If resulset > 0 Then 'si hay existencias
                Return True
            Else                'no hay existencias
                Return False
            End If

        Catch Ex As Exception
            TrataEx(Ex)
            Return False
        End Try
    End Function
    Public Shared Function fn_AceptaMateriales_Aceptar(ByVal Id_MatVentas As Integer, ByVal Tipo As Dpto) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Mat_Ventas_Aceptar", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_MatVentas", SqlDbType.Int, Id_MatVentas)
        Crea_Parametro(cmd, "@Usuario_Entrega", SqlDbType.Int, UsuarioId)
        Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Crea_Parametro(cmd, "@Tipo", SqlDbType.Int, CInt(Tipo))

        Try
            EjecutarNonQuery(cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function


    Public Shared Function fn_AceptaMateriales_Resta(ByVal Id_MatVentas As Integer, ByVal Tipo As Dpto) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Mat_Ventas_Restar", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_MatVentas", SqlDbType.Int, Id_MatVentas)
        Crea_Parametro(cmd, "@Usuario_Entrega", SqlDbType.Int, UsuarioId)
        Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Crea_Parametro(cmd, "@Tipo", SqlDbType.Int, CInt(Tipo))

        Try
            EjecutarNonQuery(cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function


    Public Shared Function fn_AceptaMateriales_Aceptar_local(ByVal Id_MatVentas As Integer) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Mat_Ventas_Aceptar_local", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_MatVentas", SqlDbType.Int, Id_MatVentas)
        Crea_Parametro(cmd, "@Usuario_Entrega", SqlDbType.Int, UsuarioId)
        Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Crea_Parametro(cmd, "@Tipo", SqlDbType.Int, 0)

        Try
            Return EjecutarNonQuery(cmd) > 0
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function
    Public Shared Function fn_VentasMateriales_Nuevo(ByVal Id_Cliente As Integer, ByVal Id_Departamento As Integer,
         ByVal Fecha_Entrega As Date, ByVal Interno As String, ByVal dt As DataTable, ByVal Folios As String) As Boolean
        'Aqui se inserta un nuevo registro
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim lc_Transaccion As SqlClient.SqlTransaction
        Dim Cmd As SqlClient.SqlCommand
        Dim lc_identity As Integer

        lc_Transaccion = Cn_Datos.crear_Trans(Cnn)

        Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Mat_Ventas_Create")

        Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Departamento", SqlDbType.Int, Id_Departamento)
        Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
        Cn_Datos.Crea_Parametro(Cmd, "@Fecha_Entrega", SqlDbType.DateTime, Fecha_Entrega)
        Cn_Datos.Crea_Parametro(Cmd, "@Modo_Captura", SqlDbType.Int, 1)
        Cn_Datos.Crea_Parametro(Cmd, "@Interno", SqlDbType.VarChar, Interno)
        Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "SO")
        Cn_Datos.Crea_Parametro(Cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)

        Try

            lc_identity = Cn_Datos.EjecutarScalarT(Cmd)

        Catch ex As Exception
            lc_Transaccion.Rollback()
            Cnn.Close()
            TrataEx(ex)
            Return False
        End Try

        Try

            For Each lc_dr As DataRow In dt.Rows

                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Mat_VentasD_Create")

                Cn_Datos.Crea_Parametro(Cmd, "@Id_MatVenta", SqlDbType.Int, lc_identity)
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Inventario", SqlDbType.Int, CInt(lc_dr("Id_Material")))
                Cn_Datos.Crea_Parametro(Cmd, "@Cantidad", SqlDbType.Int, CInt(lc_dr("Cantidad")))
                Cn_Datos.EjecutarNonQueryT(Cmd)

            Next

            If Folios <> "" Then
                ' Si se han agregado Comprobantes de Traslado
                Dim arrFolios() As String = Split(Folios, "/")
                For c As Integer = 0 To arrFolios.Length - 1
                    Dim Cant As Integer = 0
                    Dim arrNumeros() As String = Split(arrFolios(c), "-")
                    Dim N1 As Integer = CInt(arrNumeros(0).Trim)
                    Dim N2 As Integer = CInt(arrNumeros(1).Trim)
                    Cant = N2 - N1 + 1

                    Cmd = Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Mat_RemisionesDeptos_Create")

                    Crea_Parametro(Cmd, "@Id_VentaOlote", SqlDbType.Int, lc_identity)
                    Crea_Parametro(Cmd, "@Cantidad", SqlDbType.Int, Cant)
                    Crea_Parametro(Cmd, "@Folio_Inicial", SqlDbType.Int, N1)
                    Crea_Parametro(Cmd, "@Folio_Final", SqlDbType.Int, N2)
                    Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "V")
                    EjecutarNonQueryT(Cmd)
                Next
            End If

        Catch ex2 As Exception
            lc_Transaccion.Rollback()
            Cnn.Close()
            TrataEx(ex2)
            Return False
        End Try

        lc_Transaccion.Commit()
        Cnn.Close()

        Return True

    End Function

    Public Shared Function fn_VentasMateriales_ObtenValores(ByVal Id As Integer) As Array

        Return fn_ObtenValores(Id, "Mat_Inventario_Read", "@Id_Inventario", False)

    End Function


#End Region

#Region "Valida Ventas de Materiales"

    Public Shared Function fn_ValidaMateriales_LlenarLista(ByRef lsv_Catalogo As cp_Listview, ByRef CS As ListViewColumnSorter, ByVal Tipo As Integer) As Boolean

        Return fn_LlenarLista("Mat_VentAS_Reporte", "Id_MatVenta", lsv_Catalogo, True, Tipo, "SO")

    End Function

    Public Shared Function fn_ValidaMaterialesD_LlenarLista(ByRef lsv_Catalogo As cp_Listview, ByRef CS As ListViewColumnSorter, ByVal Id_VentMat As Integer) As Boolean

        Return fn_LlenarListaD("Mat_ValidaVentasMaterialesD_Get", "Id_MatVenta", lsv_Catalogo, Id_VentMat)

    End Function

    Public Shared Function fn_ValidaMateriales_Create(ByVal Id As Integer, ByVal Envases As Integer, ByVal EnvasesSN As Integer _
                                                    , ByVal NumRemision As Integer, ByVal Tipo As Integer) As Boolean

        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand
        Dim resulset As Integer = 0
        Dim CantidadEnvases As Integer
        Dim lc_Transaccion As SqlClient.SqlTransaction
        Dim lc_identity As Integer

        CantidadEnvases = Envases + EnvasesSN

        lc_Transaccion = Cn_Datos.crear_Trans(Cnn)

        Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "CAT_Remisiones_CreateMat")


        Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Cn_Datos.Crea_Parametro(Cmd, "@Numero_Remision", SqlDbType.Int, NumRemision)
        Cn_Datos.Crea_Parametro(Cmd, "@Envases", SqlDbType.Int, Envases)
        Cn_Datos.Crea_Parametro(Cmd, "@EnvasesSN", SqlDbType.Int, EnvasesSN)
        Cn_Datos.Crea_Parametro(Cmd, "@Moneda_Local", SqlDbType.Int, MonedaId)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Cia", SqlDbType.Int, Ciaid)
        Cn_Datos.Crea_Parametro(Cmd, "@Usuario", SqlDbType.Int, UsuarioId)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_MatVenta", SqlDbType.Int, Id)

        Try

            lc_identity = Cn_Datos.EjecutarScalarT(Cmd)

            If lc_identity < 1 Then
                lc_Transaccion.Rollback()
                Cnn.Close()
                Return False
            End If

        Catch ex As Exception
            lc_Transaccion.Rollback()
            Cnn.Close()
            TrataEx(ex)
            Return False
        End Try

        Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "mat_inventario_CreateVenta")
        Cn_Datos.Crea_Parametro(Cmd, "@Id_MatVenta", SqlDbType.Int, Id)
        Cn_Datos.Crea_Parametro(Cmd, "@Usuario", SqlDbType.Int, UsuarioId)
        Cn_Datos.Crea_Parametro(Cmd, "@Cantidad_Envases", SqlDbType.Int, CantidadEnvases)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, lc_identity)
        Cn_Datos.Crea_Parametro(Cmd, "@Tipo", SqlDbType.Int, Tipo)

        Try
            lc_identity = Cn_Datos.EjecutarScalarT(Cmd)

            If lc_identity < 1 Then
                lc_Transaccion.Rollback()
                Cnn.Close()
                Return False

            End If

        Catch ex As Exception
            lc_Transaccion.Rollback()
            Cnn.Close()
            TrataEx(ex)
            Return False
        End Try

        lc_Transaccion.Commit()
        Cnn.Close()
        Return True

    End Function

    Public Shared Function fn_ValidaMateriales_Validar(ByVal Id As Integer, ByVal Tipo As Integer) As Boolean
        'Return fn_StatusD(Id, "VA", "mat_ventasd_ValidaVentaMat", "@Id_MatVenta", True)
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("mat_ventasd_ValidaVentaMat", CommandType.StoredProcedure, Cnn)
        Dim ResulSet As Integer = 0

        Cn_Datos.Crea_Parametro(Cmd, "@Id_MatVenta", SqlDbType.Int, Id)
        Cn_Datos.Crea_Parametro(Cmd, "@Tipo", SqlDbType.Int, Tipo)

        Try
            ResulSet = Cn_Datos.EjecutarScalar(Cmd)
            If ResulSet > 0 Then
                Return True
            Else
                Return False
            End If

        Catch Ex As Exception
            TrataEx(Ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_ValidaMateriales_Cia(ByVal Id As Integer) As String
        Dim Valores() As Object

        Valores = fn_ObtenValores(Id, "Cat_Cias_Read", "@Id_Cia", False)

        Return Valores(2).ToString

    End Function

    Public Shared Function fn_ValidaMateriales_ValidaRemision(ByVal Clave As String)
        Return fn_ValidarClave(Clave, "@Id_Remision", "CAT_Remisiones_StatusValida")
    End Function

    Public Shared Function fn_Materiales_Depto(ByVal Clave_Depto As String) As String()
        'Aqui se inserta un nuevo registro
        Dim dt As New DataTable
        Dim Valores(3) As String

        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD

        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_DepartamentosClave_Read", CommandType.StoredProcedure, Cnn)

        Cn_Datos.Crea_Parametro(Cmd, "@Clave_Departamento", SqlDbType.VarChar, Clave_Depto)

        Try
            dt = Cn_Datos.EjecutaConsulta(Cmd)

            If dt.Rows.Count > 0 Then

                Valores(0) = dt(0)(1).ToString
                Valores(1) = dt(0)(2).ToString

                Return Valores
            Else
                Return Nothing

            End If

        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try

    End Function

    Public Shared Function fn_Materiales_Cliente(ByVal Id_Cliente As Integer) As String()
        'Aqui se inserta un nuevo registro
        Dim dt As New DataTable
        Dim Valores(3) As String

        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD

        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_Clientes_Read", CommandType.StoredProcedure, Cnn)

        Cn_Datos.Crea_Parametro(Cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)

        Try
            dt = Cn_Datos.EjecutaConsulta(Cmd)

            If dt.Rows.Count > 0 Then

                Valores(0) = dt(0)(2).ToString
                Valores(1) = dt(0)(7).ToString
                Valores(2) = dt(0)(8).ToString

                Return Valores
            Else
                Return Nothing

            End If

        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try

    End Function

#End Region

#Region "Cancela Asignación de Materiales"

    Public Shared Function fn_fn_CancelaMateriales_LlenarLista(ByVal Lista As cp_Listview, ByVal Status As String) As Boolean
        Try
            'Aqui se llena el listview
            Dim Cnn As SqlConnection = Crea_ConexionSTD()
            Dim Cmd As SqlCommand = Crea_Comando("Mat_VentasCentral_GetCancelar", CommandType.StoredProcedure, Cnn)
            Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Status)

            'Aqui se Actualiza la lista
            Lista.Actualizar(Cmd, "Id_MatVenta")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_LlenarListaD(ByVal Lista As cp_Listview, ByVal Id_MatVenta As Integer) As Boolean
        Try
            'Aqui se llena el listview
            Dim Cnn As SqlConnection = Crea_ConexionSTD()
            Dim Cmd As SqlCommand = Crea_Comando("", CommandType.StoredProcedure, Cnn)

            Crea_Parametro(Cmd, "", SqlDbType.Int, Id_MatVenta)

            'Aqui se Actualiza la lista
            Lista.Actualizar(Cmd, "")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_CancelaMateriales(ByVal Id_MatVenta As Integer, ByVal Tipo As Integer, ByVal ObservacionesCancela As String) As Boolean

        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Cmd As SqlCommand = Crea_Comando("Mat_Inventario_CancelaVentaMat", CommandType.StoredProcedure, Cnn)
        Dim resulset As Integer = 0

        Crea_Parametro(Cmd, "Id_Matventa", SqlDbType.BigInt, Id_MatVenta)
        Crea_Parametro(Cmd, "@Usuario", SqlDbType.BigInt, UsuarioId)
        Crea_Parametro(Cmd, "@Estacion_Cancela", SqlDbType.VarChar, EstacioN)
        Crea_Parametro(Cmd, "@Observaciones_Cancela", SqlDbType.VarChar, ObservacionesCancela)

        Try
            resulset = EjecutarScalar(Cmd)

            If resulset > 0 Then
                Return True
            Else
                Return False
            End If

        Catch Ex As Exception
            TrataEx(Ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_AceptaMateriales_ValidaStatus(ByVal Id_MatVenta As Integer, ByVal Status As String) As Boolean
        Dim dt As DataTable
        'Si no lo encuentra regresa Falso y no se podrá validar el lote.
        Try
            Dim cmd As SqlCommand = Crea_Comando("Mat_Ventas_StatusValidar", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@Id_MatVenta", SqlDbType.Int, Id_MatVenta)
            Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, Status)
            dt = EjecutaConsulta(cmd)
            If dt.Rows.Count = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

#End Region

#Region "Reporte de Asignaciones de Materiales"

    Public Shared Function fn_ReporteAsignaciones_LlenarLista(ByVal Lista As cp_Listview, ByVal Id_Departamento As Integer, ByVal Desde As Date, ByVal Hasta As Date, ByVal Status As String) As Boolean
        Try
            'Aqui se llena el listview
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Mat_VentasCentral_GetReporte", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Departamento", SqlDbType.Int, Id_Departamento)
            Cn_Datos.Crea_Parametro(Cmd, "@Desde", SqlDbType.Date, Desde)
            Cn_Datos.Crea_Parametro(Cmd, "@Hasta", SqlDbType.Date, Hasta)
            Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Status)

            'Aqui se Actualiza la lista
            Lista.Actualizar(Cmd, "Id_MatVenta")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_ReporteAsignaciones_DetalleFolios(ByVal lsv As cp_Listview, ByVal Id_MatVenta As Integer) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Mat_RemisionesClientes_Get", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_MatVenta", SqlDbType.Int, Id_MatVenta)

        Try
            lsv.Actualizar(cmd, "Id_VentaoLote")
            lsv.Columns(1).TextAlign = HorizontalAlignment.Right
            lsv.Columns(2).TextAlign = HorizontalAlignment.Right
            lsv.Columns(3).TextAlign = HorizontalAlignment.Right
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_ReporteAsignaciones_LlenarRpt(ByVal Id_Departamento As Integer, ByVal Desde As Date, ByVal Hasta As Date, ByVal Status As String) As DataTable
        Dim Dt As DataTable
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Cmd As SqlCommand = Crea_Comando("Mat_VentasD_GetReporte2", CommandType.StoredProcedure, Cnn)
        Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Crea_Parametro(Cmd, "@Id_Departamento", SqlDbType.Int, Id_Departamento)
        Crea_Parametro(Cmd, "@Desde", SqlDbType.Date, Desde)
        Crea_Parametro(Cmd, "@Hasta", SqlDbType.Date, Hasta)
        Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Status)
        Try
            Dt = EjecutaConsulta(Cmd)
            Return Dt
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

#End Region

#Region "Enviar Materiales a Boveda"

    Public Shared Function fn_Boveda_LlenarLista(ByRef lsv_Catalogo As cp_Listview, ByRef CS As ListViewColumnSorter, ByVal Tipo As Integer) As Boolean

        Return fn_LlenarLista("Mat_VentAS_Reporte", "Id_MatVenta", lsv_Catalogo, True, Tipo, "VA")

    End Function

    Public Shared Function fn_ValidaBoveda(ByVal Id As Integer) As Boolean

        Return fn_ValidarDependencias(Id, "Mat_Ventas_StatusValidar", "@Id_MatVenta")

    End Function

    Public Shared Function fn_Boveda_Nuevo(ByVal Cantidad_Remisiones As Integer, ByVal Cantidad_Envases As Integer, ByVal dt As DataTable) As Boolean
        'Aqui se inserta un nuevo registro

        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim lc_Transaccion As SqlClient.SqlTransaction
        Dim Cmd As SqlClient.SqlCommand
        Dim lc_identity As Integer
        Dim lc_dr As DataRow


        lc_Transaccion = Cn_Datos.crear_Trans(Cnn)

        Try
            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "CAT_LotesRemisiones_Create")

            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo_Lote", SqlDbType.Int, 29)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Turno", SqlDbType.Int, TurnoId)
            Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Envia", SqlDbType.Int, UsuarioId)
            Cn_Datos.Crea_Parametro(Cmd, "@Cantidad_Remisiones", SqlDbType.Int, Cantidad_Remisiones)
            Cn_Datos.Crea_Parametro(Cmd, "@Cantidad_Envases", SqlDbType.Int, Cantidad_Envases)
            Cn_Datos.Crea_Parametro(Cmd, "@Estacion", SqlDbType.VarChar, EstacioN)


            lc_identity = Cn_Datos.EjecutarScalarT(Cmd)



            For Each lc_dr In dt.Rows

                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "CAT_LotesRemisionesD_Create")
                Cn_Datos.Crea_Parametro(Cmd, "@Id_lote", SqlDbType.Int, lc_identity)
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, CInt(lc_dr("Id_Remision")))
                Cn_Datos.EjecutarNonQueryT(Cmd)

                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Mat_Ventas_Status")
                Cn_Datos.Crea_Parametro(Cmd, "@Id_MatVenta", SqlDbType.Int, CInt(lc_dr("Id_MatVenta")))
                Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "EB")
                Cn_Datos.EjecutarNonQueryT(Cmd)

            Next

        Catch ex As Exception
            lc_Transaccion.Rollback()
            Cnn.Close()
            TrataEx(ex)
        End Try

        lc_Transaccion.Commit()
        Cnn.Close()
        Return True

    End Function

    'Mat_Ventas_GetImporte
    Public Shared Function fn_MatVentas_Importe(ByVal MatVenta As Integer) As String
        'Aqui se inserta un nuevo registro
        Dim dt As New DataTable
        Dim Valores As String

        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD

        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Mat_Ventas_GetImporte", CommandType.StoredProcedure, Cnn)

        Cn_Datos.Crea_Parametro(Cmd, "@Id_MatVenta", SqlDbType.Int, MatVenta)

        Try
            dt = Cn_Datos.EjecutaConsulta(Cmd)

            If dt.Rows.Count > 0 Then

                Valores = dt(0)(0).ToString

                Return Valores
            Else
                Return Nothing

            End If

        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try

    End Function

#End Region

#Region "Cancela Envio a Boveda"

    Public Shared Function fn_EnvioaBoveda_LlenarLista(ByRef lsv_Catalogo As cp_Listview, ByRef CS As ListViewColumnSorter) As Boolean

        Return fn_LlenarLista("CAT_LotesRemisiones_MaterialesGET", "Id_Lote", lsv_Catalogo, True)

    End Function

    Public Shared Function fn_EnvioaBovedaD_LlenarLista(ByRef lsv_Catalogo As cp_Listview, ByRef CS As ListViewColumnSorter, ByVal ID_lote As Integer) As Boolean

        Return fn_LlenarListaD("CAT_LotesRemisionesD_MaterialesGet", "Id_Lote", lsv_Catalogo, ID_lote)

    End Function

    Public Shared Function fn_CancelaBoveda_Cancelar(ByVal Id As Integer) As Boolean

        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim lc_Transaccion As SqlClient.SqlTransaction
        Dim Cmd As SqlClient.SqlCommand
        Dim lc_identity As Integer

        lc_Transaccion = Cn_Datos.crear_Trans(Cnn)

        Try

            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "CAT_LotesRemisiones_statusCancela")
            Cn_Datos.Crea_Parametro(Cmd, "@ID_lote", SqlDbType.Int, Id)
            Cn_Datos.Crea_Parametro(Cmd, "@usuario", SqlDbType.Int, UsuarioId)
            Cn_Datos.Crea_Parametro(Cmd, "@Estacion", SqlDbType.VarChar, EstacioN)
            lc_identity = Cn_Datos.EjecutarScalarT(Cmd)

            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Mat_Ventas_StatusValidaRemision")
            Cn_Datos.Crea_Parametro(Cmd, "@ID_lote", SqlDbType.Int, Id)
            Cn_Datos.EjecutarNonQueryT(Cmd)

        Catch ex As Exception
            lc_Transaccion.Rollback()
            Cnn.Close()
            TrataEx(ex)
            Return False
        End Try

        lc_Transaccion.Commit()

    End Function

    Public Shared Function fn_CancelaBoveda_Validar(ByVal Id As Integer) As Boolean

        Return fn_ValidarDependencias(Id, "CAT_LotesRemisiones_StatusValidar", "@ID_lote")

    End Function

#End Region

#Region "Recibo a Boveda"

    Public Shared Function fn_RecibirLotesBoveda_LlenarLista(ByRef lsv_Catalogo As cp_Listview, ByRef CS As ListViewColumnSorter) As Boolean

        Try
            'Aqui se llena el listview
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("CAT_LotesRemisiones_EnvioBoveda", CommandType.StoredProcedure, Cnn)

            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo_Lote", SqlDbType.Int, 30)

            'Aqui se Actualiza la lista
            lsv_Catalogo.Actualizar(Cmd, "Id_Lote")
            Return True

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_ReciboLotesBoveda_Guardar(ByVal lsvH As ListView) As Boolean
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim lc_Transaccion As SqlClient.SqlTransaction
        Dim Cmd As SqlClient.SqlCommand
        Dim ElementoH As ListViewItem


        lc_Transaccion = Cn_Datos.crear_Trans(Cnn)

        Try


            For Each ElementoH In lsvH.CheckedItems


                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "CAT_LotesRemisiones_StatusValida")
                Cn_Datos.Crea_Parametro(Cmd, "@ID_lote", SqlDbType.Int, ElementoH.Tag)
                Cn_Datos.Crea_Parametro(Cmd, "@Usuario", SqlDbType.Int, UsuarioId)

                Cn_Datos.EjecutarNonQueryT(Cmd)

                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Mat_Ventas_StatusValidaRemision")
                Cn_Datos.Crea_Parametro(Cmd, "@ID_lote", SqlDbType.Int, ElementoH.Tag)

                Cn_Datos.EjecutarNonQueryT(Cmd)


            Next  'Encabezado


        Catch ex As Exception
            lc_Transaccion.Rollback()
            Cnn.Close()
            TrataEx(ex)
            Return False

        End Try

        lc_Transaccion.Commit()
        Cnn.Close()

        Return True


    End Function

    Public Shared Function fn_RecLotesBoveda_Validar(ByVal Id As Integer) As Boolean

        Return fn_ValidarDependencias(Id, "CAT_LotesRemisiones_Statusvalidar", "@ID_lote")

    End Function

#End Region

#Region "Envio Materiales a Mensajero"

    Public Shared Function fn_Mensajero_Validar(ByVal Id As Integer) As Boolean

        Return fn_ValidarDependencias(Id, "Mat_Ventas_Statusvalidar", "@Id_MatVenta")

    End Function

    Public Shared Function fn_Mensajero_Nuevo(ByVal Cantidad_Remisiones As Integer, ByVal Cantidad_Envases As Integer, ByVal UsuarioRecibe As Integer, ByVal dt As DataTable) As Boolean
        'Aqui se inserta un nuevo registro

        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim lc_Transaccion As SqlClient.SqlTransaction
        Dim Cmd As SqlClient.SqlCommand
        Dim lc_identity As Integer
        Dim lc_dr As DataRow

        lc_Transaccion = Cn_Datos.crear_Trans(Cnn)

        Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Mat_Mensajero_Create")

        Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Cn_Datos.Crea_Parametro(Cmd, "@Cantidad_Remisiones", SqlDbType.Int, Cantidad_Remisiones)
        Cn_Datos.Crea_Parametro(Cmd, "@Cantidad_Envases", SqlDbType.Int, Cantidad_Envases)
        Cn_Datos.Crea_Parametro(Cmd, "@Usuario", SqlDbType.Int, UsuarioId)
        Cn_Datos.Crea_Parametro(Cmd, "@UsuarioRecibe", SqlDbType.Int, UsuarioRecibe)

        Try

            lc_identity = Cn_Datos.EjecutarScalarT(Cmd)

            For Each lc_dr In dt.Rows

                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Mat_MensajeroD_Create")
                Cn_Datos.Crea_Parametro(Cmd, "@Id_MatMensajero", SqlDbType.Int, lc_identity)
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, CInt(lc_dr("Id_Remision")))
                Cn_Datos.EjecutarNonQueryT(Cmd)

                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Mat_Ventas_Status")
                Cn_Datos.Crea_Parametro(Cmd, "@Id_MatVenta", SqlDbType.Int, CInt(lc_dr("Id_MatVenta")))
                Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "AM")
                Cn_Datos.EjecutarNonQueryT(Cmd)



            Next

        Catch ex As Exception
            lc_Transaccion.Rollback()
            Cnn.Close()
            TrataEx(ex)
        End Try

        lc_Transaccion.Commit()
        Cnn.Close()
        Return True

    End Function

#End Region

#Region "Cancela Envio a Mensajero"
    Public Shared Function fn_EnvioaMensajero_LlenarLista(ByRef lsv_Catalogo As cp_Listview, ByRef CS As ListViewColumnSorter) As Boolean

        Return fn_LlenarLista("Mat_Mensajero_Get", "Id_MatMensajero", lsv_Catalogo, True)

    End Function

    Public Shared Function fn_EnvioaMensajeroD_LlenarLista(ByRef lsv_Catalogo As cp_Listview, ByRef CS As ListViewColumnSorter, ByVal ID_lote As Integer) As Boolean

        Return fn_LlenarListaD("Mat_mensajeroD_GETCEnvioMensajero", "Id_MatMensajero", lsv_Catalogo, ID_lote)

    End Function

    Public Shared Function fn_CancelaMensajero_Cancelar(ByVal Id As Integer) As Boolean

        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim lc_Transaccion As SqlClient.SqlTransaction
        Dim Cmd As SqlClient.SqlCommand

        lc_Transaccion = Cn_Datos.crear_Trans(Cnn)

        Try

            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Mat_mensajero_StatusCancela")
            Cn_Datos.Crea_Parametro(Cmd, "@Id_MatMensajero", SqlDbType.Int, Id)
            Cn_Datos.Crea_Parametro(Cmd, "@Usuario", SqlDbType.Int, UsuarioId)

            Cn_Datos.EjecutarNonQueryT(Cmd)


            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "MAT_Ventas_StatusValidaMensajero")
            Cn_Datos.Crea_Parametro(Cmd, "@Id_MatMensajero", SqlDbType.Int, Id)

            Cn_Datos.EjecutarNonQueryT(Cmd)


        Catch ex As Exception
            lc_Transaccion.Rollback()
            Cnn.Close()
            TrataEx(ex)
        End Try

        lc_Transaccion.Commit()
        Cnn.Close()
        Return True

    End Function

    Public Shared Function fn_ValidaCanceloEnvioMensajero(ByVal Id As Integer) As Boolean

        Return fn_ValidarDependencias(Id, "Mat_Mensajero_StatusValidaCancela", "@Id_MatMensajero")

    End Function

#End Region

#Region "Valida Envio a Mensajero"

    Public Shared Function fn_ValidaEnvioaMensajero_LlenarLista(ByRef lsv_Catalogo As cp_Listview, ByRef CS As ListViewColumnSorter, ByVal ID As Integer) As Boolean


        Try
            'Aqui se llena el listview
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Mat_Mensajero_Get", CommandType.StoredProcedure, Cnn)

            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Userid", SqlDbType.Int, ID)
            Cn_Datos.Crea_Parametro(Cmd, "@Pista", SqlDbType.VarChar, "")

            'Aqui se Actualiza la lista
            lsv_Catalogo.Actualizar(Cmd, "Id_MatMensajero")

            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_ValidaMensajero_Validar(ByVal Id As Integer) As Boolean

        Return fn_ValidarDependencias(Id, "Mat_Mensajero_StatusValida", "@Id_MatMensajero")

    End Function

    Public Shared Function fn_ValidarEnvioMensajero(ByVal Id As Integer) As Boolean

        Return fn_Cancela(Id, "Mat_Mensajero_StatusVal", "Id_MatMensajero", False, True)

    End Function

#End Region

#Region "Rotular Remisiones"

    Public Shared Function fn_RotularRemisiones_LlenarLista(ByRef lsv_Catalogo As cp_Listview, ByRef CS As ListViewColumnSorter) As Boolean

        Return fn_LlenarLista("Mat_Ventas_GetRotulos", "Id_MatVenta", lsv_Catalogo, True)

    End Function

    Public Shared Function fn_RotularRemisiones_Nuevo(ByVal Id_MatVenta As Integer, ByVal FolioInicial As Integer, ByVal FolioFinal As Integer) As Boolean
        'Aqui se inserta un nuevo registro
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD

        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Mat_RemisionesClientes_CreateRotulo", CommandType.StoredProcedure, Cnn)

        Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_MatVenta", SqlDbType.Int, Id_MatVenta)
        Cn_Datos.Crea_Parametro(Cmd, "@Folio_Inicial", SqlDbType.Int, FolioInicial)
        Cn_Datos.Crea_Parametro(Cmd, "@Folio_Final", SqlDbType.Int, FolioFinal)

        Try
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

#End Region

#Region "Comprar Materiales"

    Public Shared Function fn_ComprasMateriales_GetPrecio(ByVal Id_Inventario As Integer, ByVal Id_Proveedor As Integer) As Decimal
        Dim cmd As SqlClient.SqlCommand = Crea_Comando("Mat_Inventario_GetPrecio", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Inventario", SqlDbType.Int, Id_Inventario)
        Crea_Parametro(cmd, "@Id_Proveedor", SqlDbType.Int, Id_Proveedor)

        Try
            Return EjecutarScalar(cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return 0
        End Try
    End Function

    Public Shared Function fn_ComprasMateriales_GetUnidades() As DataTable
        Dim cmd As SqlClient.SqlCommand = Crea_Comando("Cat_Unidades_ComboGet", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Crea_Parametro(cmd, "@Id_Cia", SqlDbType.Int, Ciaid)
        Crea_Parametro(cmd, "@Id_Departamento", SqlDbType.Int, 0)
        Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "A")

        Try
            Return EjecutaConsulta(cmd)
        Catch ex As Exception
            TrataEx(ex, False)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_ComprasMateriales_GetDepartamentos() As DataTable
        Dim cmd As SqlClient.SqlCommand = Crea_Comando("Cat_DepartamentosCombo_Get", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "A")
        Try
            Return EjecutaConsulta(cmd)
        Catch ex As Exception
            TrataEx(ex, False)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_ComprasMateriales_GetDomicilio() As DataTable
        Dim cmd As SqlClient.SqlCommand = Crea_Comando("Cat_Sucursales_GetDatos", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Try
            Return EjecutaConsulta(cmd)
        Catch ex As Exception
            TrataEx(ex, False)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_ComprasMateriales_Guardar(ByVal lsv As cp_Listview, ByVal Tipo_Orden As Byte, ByVal Id_Proveedor As Integer, ByVal AtencionA As String, ByVal Importe As Decimal, ByVal IVA As Decimal, ByVal Total As Decimal, ByVal Observaciones As String, ByVal Id_Moneda As Integer, ByVal Domicilio_Entrega As String, ByVal Condiciones_Pago As String, ByVal Porcentaje As Decimal, ByVal Retencion As Decimal) As Long
        Dim Id_MatCompra As Integer
        Dim Tr As SqlClient.SqlTransaction
        Dim cmd As SqlClient.SqlCommand
        Tr = crear_Trans(Crea_ConexionSTD)
        Try
            cmd = Crea_ComandoT(Tr.Connection, Tr, CommandType.StoredProcedure, "Mat_Compras_Create")
            Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Crea_Parametro(cmd, "@Id_Proveedor", SqlDbType.Int, Id_Proveedor)
            Crea_Parametro(cmd, "@Tipo_Orden", SqlDbType.TinyInt, Tipo_Orden)
            Crea_Parametro(cmd, "@Importe", SqlDbType.Money, Importe)
            Crea_Parametro(cmd, "@IVA", SqlDbType.Money, IVA)
            Crea_Parametro(cmd, "@Total", SqlDbType.Money, Total)
            Crea_Parametro(cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
            Crea_Parametro(cmd, "@Modo_Captura", SqlDbType.Int, 1)
            Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "A")
            Crea_Parametro(cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)
            Crea_Parametro(cmd, "@AtencionA", SqlDbType.VarChar, AtencionA)
            Crea_Parametro(cmd, "@Observaciones", SqlDbType.VarChar, Observaciones)
            Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
            Crea_Parametro(cmd, "@Domicilio_Entrega", SqlDbType.VarChar, Domicilio_Entrega)
            Crea_Parametro(cmd, "@Condiciones_Pago", SqlDbType.VarChar, Condiciones_Pago)
            Crea_Parametro(cmd, "@Porcentaje", SqlDbType.Money, Porcentaje)
            Crea_Parametro(cmd, "@Retencion", SqlDbType.Money, Retencion)

            Id_MatCompra = EjecutarScalarT(cmd)

            For Each item As ListViewItem In lsv.Items
                cmd = Crea_ComandoT(Tr.Connection, Tr, CommandType.StoredProcedure, "Mat_ComprasD_Create")
                Crea_Parametro(cmd, "@Id_MatCompra", SqlDbType.Int, Id_MatCompra)
                Crea_Parametro(cmd, "@Id_Inventario", SqlDbType.Int, item.Tag)
                Crea_Parametro(cmd, "@Precio", SqlDbType.Money, CDec(item.SubItems(4).Text))
                Crea_Parametro(cmd, "@Cantidad_Solicitada", SqlDbType.Decimal, CDec(item.SubItems(2).Text))
                Crea_Parametro(cmd, "@Cantidad_Surtida", SqlDbType.Decimal, CDec(0))
                Crea_Parametro(cmd, "@Observaciones", SqlDbType.VarChar, "")
                Crea_Parametro(cmd, "@Descripcion", SqlDbType.VarChar, item.SubItems(1).Text)
                Crea_Parametro(cmd, "@Tipo_Entidad", SqlDbType.Int, CInt(item.SubItems(8).Text))
                Crea_Parametro(cmd, "@Id_Entidad", SqlDbType.Int, CInt(item.SubItems(9).Text))
                Select Case item.SubItems(3).Text.Trim
                    Case "PIEZA"
                        Crea_Parametro(cmd, "@Unidad_Medida", SqlDbType.VarChar, "PZ")
                    Case "KILO"
                        Crea_Parametro(cmd, "@Unidad_Medida", SqlDbType.VarChar, "KG")
                    Case "LITRO"
                        Crea_Parametro(cmd, "@Unidad_Medida", SqlDbType.VarChar, "LT")
                    Case "MILLAR"
                        Crea_Parametro(cmd, "@Unidad_Medida", SqlDbType.VarChar, "MI")
                    Case "SERVICIO"
                        Crea_Parametro(cmd, "@Unidad_Medida", SqlDbType.VarChar, "SV")
                End Select

                EjecutarNonQueryT(cmd)
            Next
        Catch ex As Exception
            Tr.Rollback()
            TrataEx(ex, True)
            Return 0
        End Try
        Tr.Commit()

        Return Id_MatCompra
    End Function

    Public Shared Function fn_Compras_GenerarReporte(ByVal Id_MatCompra As Integer) As rpt_SolicitudCompra
        Dim rpt As New rpt_SolicitudCompra
        Dim Ds As New Ds_Compra

        Call fn_Compras_LlenarDataSet(Ds, Id_MatCompra)
        '--------------pruebas de imagen en reportes {
        If Not IsDBNull(Ds.Tbl_DatosEmpresa.Rows(0)("logo")) Then

            Dim imagenNueva As Image = Nothing
            Dim imagenBytes As Byte() = Ds.Tbl_DatosEmpresa.Rows(0)("logo")
            Dim ms_ByteToImagen As New IO.MemoryStream(imagenBytes)
            imagenNueva = Image.FromStream(ms_ByteToImagen, True)

            Dim Ancho As Integer = imagenNueva.Width
            Dim Alto As Integer = imagenNueva.Height
            Dim valordiv As Decimal = 0.0

            With rpt.ReportDefinition.Sections("Section1").ReportObjects("Logo")

                Dim Top_Obj As Integer = .Top
                Dim Left_Obj As Integer = .Left '+- 342default
                Dim Width_Obj As Integer = .Width '1440Default

                If Ancho > Alto Then valordiv = Width_Obj / Ancho Else valordiv = Width_Obj / Alto
                Dim nuevoAncho As Integer = Ancho * valordiv
                Dim NuevoAlto As Integer = Alto * valordiv

                If Ancho > Alto Then
                    'horizontal
                    Top_Obj = Top_Obj + ((Width_Obj - NuevoAlto) / 2)
                    .Top = Top_Obj
                Else
                    'vertical,cuadrado
                    Left_Obj = Left_Obj + ((Width_Obj - nuevoAncho) / 2)
                    .Left = Left_Obj
                End If
                .Width = nuevoAncho
                .Height = NuevoAlto
            End With

            '-------liberar objetos
            ms_ByteToImagen.Dispose()
            imagenNueva.Dispose()
        End If
        '--------------}

        rpt.SetDataSource(Ds)
        Return rpt
    End Function

    Public Shared Function fn_Compras_ObtenerReporte(ByVal Id_MatCompra As Long) As DataRow
        Dim cmd As SqlCommand = Crea_Comando("Mat_Compras_GetRpt", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_MatCompra", SqlDbType.BigInt, Id_MatCompra)

        Try
            Dim Tbl As DataTable = EjecutaConsulta(cmd)

            If Tbl.Rows.Count > 0 Then
                Return Tbl.Rows(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Sub fn_Compras_LlenarDataSet(ByRef Ds As Ds_Compra, ByVal Id_MatCompra As Long)
        Dim cmd As SqlCommand = Crea_Comando("Mat_Compras_GetRpt", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_MatCompra", SqlDbType.BigInt, Id_MatCompra)

        Try
            cmd.Connection.Open()
            Ds.Mat_Compras_GetRpt.Load(cmd.ExecuteReader)
            cmd.Connection.Close()
        Catch ex As Exception
            If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
            TrataEx(ex)
        End Try

        cmd = Crea_Comando("Cat_Sucursales_GetDatos", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)

        Try
            cmd.Connection.Open()
            Ds.Tbl_DatosEmpresa.Load(cmd.ExecuteReader)
            cmd.Connection.Close()
        Catch ex As Exception
            If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
            TrataEx(ex)
        End Try

    End Sub

    Public Shared Function fn_Proveedores_Read(ByVal Id_Proveedor As Integer) As DataTable
        Dim Tbl As DataTable = Nothing
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Try
            Dim Cmd As SqlCommand = Crea_Comando("Cat_Proveedores_Read", CommandType.StoredProcedure, Cnn)
            Crea_Parametro(Cmd, "@Id_Proveedor", SqlDbType.Int, Id_Proveedor)

            Tbl = EjecutaConsulta(Cmd)
            If Tbl.Rows.Count = 0 Then
                Return Nothing
            Else
                Return Tbl
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

#End Region

#Region "Validar Compras"

    Public Shared Function fn_ValidarCompras_LlenarEncabezado(ByVal lsv As cp_Listview, ByVal Desde As Date, ByVal Hasta As Date, ByVal Id_Proveedor As Integer) As Boolean
        Dim cmd As SqlClient.SqlCommand = Crea_Comando("Mat_Compras_Get", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Crea_Parametro(cmd, "@Desde", SqlDbType.Date, Desde)
        Crea_Parametro(cmd, "@Hasta", SqlDbType.Date, Hasta)
        Crea_Parametro(cmd, "@Id_Proveedor", SqlDbType.Int, Id_Proveedor)
        Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "A")

        Try
            lsv.Actualizar(cmd, "Id_MatCompra")
            lsv.Columns(5).TextAlign = HorizontalAlignment.Right
            lsv.Columns(6).TextAlign = HorizontalAlignment.Right
            lsv.Columns(7).TextAlign = HorizontalAlignment.Right
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_ValidarCompras_LlenarDetalle(ByRef Tbl As ds.Mat_ComprasD_GetDataTable, ByVal Id As Integer) As Boolean
        Dim cmd As SqlClient.SqlCommand = Crea_Comando("Mat_ComprasD_Get", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_MatCompra", SqlDbType.Int, Id)

        Try
            cmd.Connection.Open()
            Dim rdr As SqlClient.SqlDataReader = cmd.ExecuteReader
            Tbl.Load(rdr)
            cmd.Connection.Close()
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_ValidarCompras_Validar(ByVal Id_MatCompra As Integer, ByVal Tipo_Orden As Integer, ByVal Folio_Factura As String, ByVal Importe_Factura As Decimal, ByVal Fecha_Factura As Date, ByVal tbl As ds.Mat_ComprasD_GetDataTable, ByVal Id_Usuario As Integer) As Boolean

        Dim cmd As SqlClient.SqlCommand
        Dim Tr As SqlClient.SqlTransaction
        Tr = crear_Trans(Crea_ConexionSTD)
        Try
            cmd = Crea_ComandoT(Tr.Connection, Tr, CommandType.StoredProcedure, "Mat_Compras_Validar")
            Crea_Parametro(cmd, "@Id_MatCompra", SqlDbType.Int, Id_MatCompra)
            Crea_Parametro(cmd, "@Estacion_Valida", SqlDbType.VarChar, EstacioN)
            Crea_Parametro(cmd, "@Usuario_Valida", SqlDbType.Int, Id_Usuario)
            Crea_Parametro(cmd, "@Folio_Factura", SqlDbType.VarChar, Folio_Factura)
            Crea_Parametro(cmd, "@Importe_Factura", SqlDbType.Money, Importe_Factura)
            Crea_Parametro(cmd, "@Fecha_Factura", SqlDbType.Date, Fecha_Factura)
            EjecutarNonQueryT(cmd)
            'Detalle
            For Each row As ds.Mat_ComprasD_GetRow In tbl.Rows
                cmd = Crea_ComandoT(Tr.Connection, Tr, CommandType.StoredProcedure, "Mat_ComprasD_Validar")
                Crea_Parametro(cmd, "@Id_MatCompra", SqlDbType.Int, Id_MatCompra)
                Crea_Parametro(cmd, "@Id_Inventario", SqlDbType.Int, row.Id_Inventario)
                Crea_Parametro(cmd, "@Precio_Surtido", SqlDbType.Money, row.Precio_Surtido)
                Crea_Parametro(cmd, "@Cantidad_Surtida", SqlDbType.Decimal, row.Cantidad_Surtida)
                Crea_Parametro(cmd, "@Observaciones", SqlDbType.VarChar, row.Observaciones)
                If EjecutarNonQueryT(cmd) = 0 Then
                    Tr.Rollback()
                    Return False
                End If
                If Tipo_Orden = 1 Then
                    'Incrementar el inventario ****EL INCREMENTO SE HACE CUANDO ALMACEN RECIBE EL MATERIAL
                    'cmd = Crea_ComandoT(Tr.Connection, Tr, CommandType.StoredProcedure, "Mat_Inventario_Abonar")
                    'Crea_Parametro(cmd, "@Id_Inventario", SqlDbType.Int, row.Id_Inventario)
                    'If row.Unidad = "MILLAR" Then
                    '    Crea_Parametro(cmd, "@Cantidad", SqlDbType.Decimal, row.Cantidad_Surtida * 1000)
                    'Else
                    '    Crea_Parametro(cmd, "@Cantidad", SqlDbType.Int, row.Cantidad_Surtida)
                    'End If
                    'EjecutarNonQueryT(cmd)

                    'Actualziar el Precio por Proveedor
                    cmd = Crea_ComandoT(Tr.Connection, Tr, CommandType.StoredProcedure, "Mat_PreciosProveedor_Update")
                    Crea_Parametro(cmd, "@Id_Proveedor", SqlDbType.Int, row.IDP)
                    Crea_Parametro(cmd, "@Id_Material", SqlDbType.Int, row.IDM)
                    Crea_Parametro(cmd, "@Precio", SqlDbType.Money, row.Precio_Surtido)
                    EjecutarNonQueryT(cmd)
                End If
            Next
        Catch ex As Exception
            Tr.Rollback()
            TrataEx(ex, False)
            Return False
        End Try
        Tr.Commit()
        Return True
    End Function

#End Region

#Region "Cancelar Compras"

    Public Shared Function fn_CancelarCompras_LlenarEncabezado(ByVal lsv As cp_Listview, ByVal Desde As Date, ByVal Hasta As Date, ByVal Id_Proveedor As Integer, ByVal Status As String) As Boolean
        Dim cmd As SqlClient.SqlCommand = Crea_Comando("Mat_Compras_Get2", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Crea_Parametro(cmd, "@Desde", SqlDbType.Date, Desde)
        Crea_Parametro(cmd, "@Hasta", SqlDbType.Date, Hasta)
        Crea_Parametro(cmd, "@Id_Proveedor", SqlDbType.Int, Id_Proveedor)
        Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, Status)

        Try
            lsv.Actualizar(cmd, "Id_MatCompra")
            lsv.Columns(5).TextAlign = HorizontalAlignment.Right
            lsv.Columns(6).TextAlign = HorizontalAlignment.Right
            lsv.Columns(7).TextAlign = HorizontalAlignment.Right
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_CancelarCompras_LlenarDetalle(ByRef lsv As cp_Listview, ByVal Id As Integer) As Boolean
        Dim cmd As SqlClient.SqlCommand = Crea_Comando("Mat_ComprasD_Get", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_MatCompra", SqlDbType.Int, Id)

        Try
            lsv.Actualizar(cmd, "Id_Inventario")
            lsv.Columns(2).TextAlign = HorizontalAlignment.Right
            lsv.Columns(3).TextAlign = HorizontalAlignment.Right
            lsv.Columns(5).TextAlign = HorizontalAlignment.Right
            lsv.Columns(10).Width = 0

            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_CancelarCompras_Cancelar(ByVal Id_MatCompra As Integer, ByVal Id_Usuario As Integer) As Boolean

        Dim cmd As SqlClient.SqlCommand = Crea_Comando("Mat_Compras_Cancelar", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_MatCompra", SqlDbType.Int, Id_MatCompra)
        Crea_Parametro(cmd, "@Estacion_Cancela ", SqlDbType.VarChar, EstacioN)
        Crea_Parametro(cmd, "@Usuario_Cancela", SqlDbType.Int, Id_Usuario)

        Try

            Return EjecutarNonQuery(cmd) > 0

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

#End Region

#Region "Reimprimir Compras"

    Public Shared Function fn_ReimprimirCompras_LlenarLista(ByVal lsv As cp_Listview, ByVal Desde As Date, ByVal Hasta As Date, ByVal Id_Proveedor As Integer) As Boolean
        Dim cmd As SqlClient.SqlCommand = Crea_Comando("Mat_Compras_GetReimp", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Crea_Parametro(cmd, "@Desde", SqlDbType.Date, Desde)
        Crea_Parametro(cmd, "@Hasta", SqlDbType.Date, Hasta)
        Crea_Parametro(cmd, "@Id_Proveedor", SqlDbType.Int, Id_Proveedor)

        Try
            lsv.Actualizar(cmd, "Id_MatCompra")
            lsv.Columns(5).TextAlign = HorizontalAlignment.Right
            lsv.Columns(6).TextAlign = HorizontalAlignment.Right
            lsv.Columns(7).TextAlign = HorizontalAlignment.Right
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

#End Region

#Region "Consulta de Solicitudes de Insumos"
    Public Shared Function fn_ConsultaSolicitudesInsumos_LlenarLista(ByVal lsv As cp_Listview, ByVal Fecha_Desde As Date, ByVal Fecha_Hasta As Date, ByVal Status As Char, ByVal UsuarioSolicita As Integer) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Inv_Solicitudes_Get", CommandType.StoredProcedure, Crea_ConexionSTD)
        Try
            Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Crea_Parametro(cmd, "@Fecha_Desde", SqlDbType.VarChar, Fecha_Desde)
            Crea_Parametro(cmd, "@Fecha_Hasta", SqlDbType.VarChar, Fecha_Hasta)
            Crea_Parametro(cmd, "@Usuario_Solicita", SqlDbType.Int, UsuarioSolicita)
            Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, Status)

            lsv.Actualizar(cmd, "Id_Solicitud")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_ConsultaSolicitudesInsumos_LlenarDetalle(ByVal lsv As cp_Listview, ByVal Id_Solicitud As Integer) As Boolean

        Dim cmd As SqlCommand = Crea_Comando("Inv_SolicitudesD_Get", CommandType.StoredProcedure, Crea_ConexionSTD)
        Try
            Crea_Parametro(cmd, "@Id_Solicitud", SqlDbType.Int, Id_Solicitud)

            lsv.Actualizar(cmd, "Id_Subclase")
            lsv.Columns("CantidadSolicitada").TextAlign = HorizontalAlignment.Right
            lsv.Columns("CantidadValidada").TextAlign = HorizontalAlignment.Right
            lsv.Columns("CantidadSurtida").TextAlign = HorizontalAlignment.Right
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

#End Region

#Region "Validar Solicitudes de Insumos"

    Public Shared Function fn_ValidarSolicitudesInsumos_LlenarLista(ByVal lsv As cp_Listview, ByVal UsuarioSolicita As Integer) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Inv_Solicitudes_GetAV", CommandType.StoredProcedure, Crea_ConexionSTD)
        Try
            Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Crea_Parametro(cmd, "@Usuario_Solicita", SqlDbType.Int, UsuarioSolicita)

            lsv.Actualizar(cmd, "Id_Solicitud")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_ValidarSolicitudesInsumos_LlenarDetalle(ByVal Id_Solicitud As Integer) As DataTable

        Dim con As SqlConnection = Crea_ConexionSTD()
        Try
            Dim cmd As SqlCommand = Crea_Comando("Inv_SolicitudesD_Get", CommandType.StoredProcedure, con)
            Crea_Parametro(cmd, "@Id_Solicitud", SqlDbType.Int, Id_Solicitud)
            'Leer de SQL
            Dim dt As DataTable = EjecutaConsulta(cmd)

            If dt.Rows.Count > 0 Then
                Return dt
            Else
                Return Nothing
            End If

        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try

    End Function

    Public Shared Function fn_ValidarSolicitudesInsumos_Guardar(ByVal Id_Solicitud As Integer, ByVal Dt As DataTable, ByVal Status As Char) As Boolean
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Tr As SqlTransaction = crear_Trans(Cnn)

        Dim Cmd As SqlCommand
        Try
            'Cambiar el Status de Inv_Solicitudes
            Cmd = Crea_ComandoT(Cnn, Tr, CommandType.StoredProcedure, "Inv_Solicitudes_UpdateValidar")
            Crea_Parametro(Cmd, "@Id_Solicitud", SqlDbType.Int, Id_Solicitud)
            Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Crea_Parametro(Cmd, "@Usuario_Valida", SqlDbType.Int, UsuarioId)
            Crea_Parametro(Cmd, "@Estacion_Valida", SqlDbType.VarChar, EstacioN)
            Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Status)
            EjecutarNonQueryT(Cmd)

            'Actualizar Inv_SolicitudesD
            For Each Fila As DataRow In Dt.Rows
                Cmd = Crea_ComandoT(Cnn, Tr, CommandType.StoredProcedure, "Inv_SolicitudesD_UpdateValidar")
                Crea_Parametro(Cmd, "@Id_Solicitud", SqlDbType.Int, Fila("Id_Solicitud"))
                Crea_Parametro(Cmd, "@Id_Subclase", SqlDbType.Int, Fila("Id_Subclase"))
                Crea_Parametro(Cmd, "@Cantidad_Validada", SqlDbType.Int, Fila("CantidadValidada"))
                Crea_Parametro(Cmd, "@Observaciones", SqlDbType.VarChar, Fila("Observaciones"))
                Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Fila("Status"))
                EjecutarNonQueryT(Cmd)
            Next

            Tr.Commit()
            Cmd.Dispose()
            Return True
        Catch ex As Exception
            Tr.Rollback()
            Cmd.Dispose()
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_ValidarSolicitudesInsumos_Cancelar(ByVal Id_Solicitud As Integer, ByVal Dt As DataTable) As Boolean
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Tr As SqlTransaction = crear_Trans(Cnn)
        Dim Cmd As SqlCommand
        Try
            'Cambiar el Status de Inv_Solicitudes
            Cmd = Crea_ComandoT(Cnn, Tr, CommandType.StoredProcedure, "Inv_Solicitudes_UpdateCancelar")
            Crea_Parametro(Cmd, "@Id_Solicitud", SqlDbType.Int, Id_Solicitud)
            Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Crea_Parametro(Cmd, "@Usuario_Cancela", SqlDbType.Int, UsuarioId)
            Crea_Parametro(Cmd, "@Estacion_Cancela", SqlDbType.VarChar, EstacioN)
            Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "C")
            EjecutarNonQueryT(Cmd)

            'Actualizar Inv_SolicitudesD
            For Each Fila As DataRow In Dt.Rows
                Cmd = Crea_ComandoT(Cnn, Tr, CommandType.StoredProcedure, "Inv_SolicitudesD_UpdateCancelar")
                Crea_Parametro(Cmd, "@Id_Solicitud", SqlDbType.Int, Fila("Id_Solicitud"))
                Crea_Parametro(Cmd, "@Id_Subclase", SqlDbType.Int, Fila("Id_Subclase"))
                Crea_Parametro(Cmd, "@Cantidad_Surtida", SqlDbType.Int, 0)
                Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "C")
                EjecutarNonQueryT(Cmd)
            Next

            Tr.Commit()
            Cmd.Dispose()
            Return True
        Catch ex As Exception
            Tr.Rollback()
            Cmd.Dispose()
            TrataEx(ex)
            Return False
        End Try
    End Function

#End Region

#Region "Surtir Solicitudes de Insumos"

    Public Shared Function fn_SurtirSolicitudesInsumos_Guardar(ByVal Id_Solicitud As Integer, ByVal Dt As DataTable) As Boolean
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Tr As SqlTransaction = crear_Trans(Cnn)
        Dim Cmd As SqlCommand
        Try
            'Cambiar el Status de Inv_Solicitudes
            Cmd = Crea_ComandoT(Cnn, Tr, CommandType.StoredProcedure, "Inv_Solicitudes_UpdateSurtir")
            Crea_Parametro(Cmd, "@Id_Solicitud", SqlDbType.Int, Id_Solicitud)
            Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Crea_Parametro(Cmd, "@Usuario_Surte", SqlDbType.Int, UsuarioId)
            Crea_Parametro(Cmd, "@Estacion_Surte", SqlDbType.VarChar, EstacioN)
            Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "S")
            EjecutarNonQueryT(Cmd)

            'Actualizar Inv_SolicitudesD
            For Each Fila As DataRow In Dt.Rows
                Cmd = Crea_ComandoT(Cnn, Tr, CommandType.StoredProcedure, "Inv_SolicitudesD_UpdateSurtir")
                Crea_Parametro(Cmd, "@Id_Solicitud", SqlDbType.Int, Fila("Id_Solicitud"))
                Crea_Parametro(Cmd, "@Id_Subclase", SqlDbType.Int, Fila("Id_Subclase"))
                Crea_Parametro(Cmd, "@Cantidad_Surtida", SqlDbType.Int, Fila("CantidadSurtida"))
                Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Fila("Status"))
                EjecutarNonQueryT(Cmd)
            Next

            Tr.Commit()
            Cmd.Dispose()
            Return True
        Catch ex As Exception
            Tr.Rollback()
            Cmd.Dispose()
            TrataEx(ex)
            Return False
        End Try
    End Function

#End Region

#Region "Rastreo de Remisiones"

    Public Shared Function fn_RastreoRemisiones_BuscarFolios(ByVal lsv As cp_Listview, ByVal Folio As Integer) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Mat_RemisionesDeptos_GetByFolio", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Folio", SqlDbType.Int, Folio)

        Try
            lsv.Actualizar(cmd, "Id_VentaoLote")
            lsv.Columns(2).TextAlign = HorizontalAlignment.Right
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_RastreoRemisiones_LlenarLista(ByVal Id_MatVenta As Integer) As DataTable
        Dim dt As DataTable
        Try
            Dim Cnn As SqlConnection = Crea_ConexionSTD()
            Dim Cmd As SqlCommand = Crea_Comando("Mat_VentasCentral_GetByID", CommandType.StoredProcedure, Cnn)
            Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Crea_Parametro(Cmd, "@Id_MatVenta", SqlDbType.Int, Id_MatVenta)

            dt = EjecutaConsulta(Cmd)
            Return dt
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

#End Region

#Region "CONSUMIBLES"
    Public Shared Function fn_Departamentos_LlenarLista(ByRef lsv As cp_Listview) As Boolean
        'Aqui se llena el listview
        Dim Cnn As SqlClient.SqlConnection = Crea_ConexionSTD()
        Dim Cmd As SqlClient.SqlCommand = Crea_Comando("Cat_Departamentos_Get", CommandType.StoredProcedure, Cnn)
        Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "A")
        Try
            lsv.Actualizar(Cmd, "Id_Departamento")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Consumibles_Nuevo(ByVal Clave As String, ByVal Descripcion As String, ByVal tipo As Byte) As Boolean
        'Aqui se inserta un nuevo registro
        Dim Cnn As SqlConnection = Crea_ConexionSTD()

        Dim Cmd As SqlCommand = Crea_Comando("Mat_Consumibles_Create", CommandType.StoredProcedure, Cnn)
        Crea_Parametro(Cmd, "@Clave_Consumible", SqlDbType.VarChar, Clave)
        Crea_Parametro(Cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)
        Crea_Parametro(Cmd, "@Tipo", SqlDbType.TinyInt, tipo)
        Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "A")
        Try
            EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Consumibles_ExisteClave(ByVal Clave_Consumible As String) As DataTable
        Dim cn As SqlConnection = Crea_ConexionSTD()
        Try
            Dim cmd As SqlCommand = Crea_Comando("Mat_Consumibles_ExisteClave", CommandType.StoredProcedure, cn)
            Crea_Parametro(cmd, "@Clave_Consumible", SqlDbType.VarChar, Clave_Consumible)
            Return EjecutaConsulta(cmd)

        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_CargaConsumibles(ByVal lsv As cp_Listview)
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Cmd As SqlCommand = Crea_Comando("Mat_Consumibles_Get", CommandType.StoredProcedure, Cnn)
        Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "A")

        Try
            lsv.Actualizar(Cmd, "Id_Consumible")
            'lsv.Columns(2).TextAlign = HorizontalAlignment.Center
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_ActualizaConsumibles(ByVal Id_Consumible As Integer, ByVal Clave_Consumible As String, ByVal Descripcion As String, ByVal Tipo As Byte) As Boolean
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Cmd As SqlCommand = Crea_Comando("Mat_Consumibles_Update", CommandType.StoredProcedure, Cnn)
        Crea_Parametro(Cmd, "@Id_Consumible", SqlDbType.Int, Id_Consumible)
        Crea_Parametro(Cmd, "@Clave_Consumible", SqlDbType.VarChar, Clave_Consumible)
        Crea_Parametro(Cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)
        Crea_Parametro(Cmd, "@Tipo", SqlDbType.TinyInt, Tipo)
        Try
            EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Baja_Consumibles(ByVal Id_Consumible As Integer) As Boolean
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Cmd As SqlCommand = Crea_Comando("Mat_Consumibles_Status", CommandType.StoredProcedure, Cnn)
        Crea_Parametro(Cmd, "@Id_Consumible", SqlDbType.Int, Id_Consumible)
        Try
            EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_DepartamentosConsumibles_Guardar(ByVal Id_Departamento As Integer, ByVal Lsv_Consumibles As cp_Listview) As Boolean
        Try
            Dim Cnn As SqlConnection = Crea_ConexionSTD()
            Dim Cmd As SqlCommand = Crea_Comando("Mat_ConsumiblesXDepartamento_Create", CommandType.StoredProcedure, Cnn)

            For Each Elemento As ListViewItem In Lsv_Consumibles.CheckedItems
                Cmd.Parameters.Clear()

                Crea_Parametro(Cmd, "@Id_Departamento", SqlDbType.Int, Id_Departamento)
                Crea_Parametro(Cmd, "@Id_Consumible", SqlDbType.Int, Elemento.Tag)
                EjecutarNonQuery(Cmd)
            Next
            Return True

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_DepartamentosConsumibles_LlenarLista(ByRef lsv As cp_Listview, ByVal Id_Departamento As Integer) As Boolean
        'Aqui se llena el listview
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Cmd As SqlCommand = Crea_Comando("Mat_ConsumiblesXDepartamento_Get", CommandType.StoredProcedure, Cnn)

        Try
            Crea_Parametro(Cmd, "@Id_Departamento", SqlDbType.Int, Id_Departamento)
            lsv.Actualizar(Cmd, "Id_ConsumibleDepto")

            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_DepartamentosConsumibles_Borrar(ByVal lsv As cp_Listview) As Boolean
        Try
            Dim Cnn As SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlCommand = Cn_Datos.Crea_Comando("Mat_ConsumiblesXDepartamento_Delete", CommandType.StoredProcedure, Cnn)

            For Each Elemento As ListViewItem In lsv.CheckedItems
                Cmd.Parameters.Clear()
                Crea_Parametro(Cmd, "@Id_ConsumibleXDepartamento", SqlDbType.Int, Elemento.Tag)
                EjecutarNonQuery(Cmd)
            Next

            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function
    'Es un Comentario Mat_Solicitudes_Get
    Public Shared Function fn_ConsultaSolicitudesConsumibles_LlenarLista(ByVal lsv As cp_Listview, ByVal Fecha_Desde As Date, ByVal Fecha_Hasta As Date, ByVal Status As Char, ByVal UsuarioSolicita As Integer) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Mat_Solicitudes_Get", CommandType.StoredProcedure, Crea_ConexionSTD)
        Try
            Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId) '--
            Crea_Parametro(cmd, "@Fecha_Desde", SqlDbType.Date, Fecha_Desde)
            Crea_Parametro(cmd, "@Fecha_Hasta", SqlDbType.Date, Fecha_Hasta)
            Crea_Parametro(cmd, "@Usuario_Solicita", SqlDbType.Int, UsuarioSolicita)
            Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, Status)
            Crea_Parametro(cmd, "@Tipo", SqlDbType.Int, 1)

            lsv.Actualizar(cmd, "Id_Solicitud")
            Return True
        Catch ex As Exception
            TrataEx(ex)

            Return False

        End Try
    End Function


    Public Shared Function fn_ConsultaSolicitudesMaterial_LlenarLista(ByVal lsv As cp_Listview, ByVal Fecha_Desde As Date, ByVal Fecha_Hasta As Date, ByVal Status As Char, ByVal UsuarioSolicita As Integer, ByRef Tipo As Integer) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Mat_Solicitudes_Get", CommandType.StoredProcedure, Crea_ConexionSTD)
        Try
            Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId) '--
            Crea_Parametro(cmd, "@Fecha_Desde", SqlDbType.Date, Fecha_Desde)
            Crea_Parametro(cmd, "@Fecha_Hasta", SqlDbType.Date, Fecha_Hasta)
            Crea_Parametro(cmd, "@Usuario_Solicita", SqlDbType.Int, UsuarioSolicita)
            Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, Status)
            Crea_Parametro(cmd, "@Tipo", SqlDbType.Int, Tipo)

            lsv.Actualizar(cmd, "Id_Solicitud")
            Return True
        Catch ex As Exception
            TrataEx(ex)

            Return False

        End Try
    End Function

    Public Shared Function fn_ConsultaSolicitudesConsumibles_LlenarReporte(ByVal Fecha_Desde As Date, ByVal Fecha_Hasta As Date, ByVal Status As Char, ByVal UsuarioSolicita As Integer) As DataTable
        Dim Dt As DataTable
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Cmd As SqlCommand = Crea_Comando("Mat_SolicitudesD_GetReporte", CommandType.StoredProcedure, Cnn)
        Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId) '--
        Crea_Parametro(Cmd, "@Fecha_Desde", SqlDbType.Date, Fecha_Desde)
        Crea_Parametro(Cmd, "@Fecha_Hasta", SqlDbType.Date, Fecha_Hasta)
        Crea_Parametro(Cmd, "@Usuario_Solicita", SqlDbType.Int, UsuarioSolicita)
        Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Status)
        Try
            Dt = EjecutaConsulta(Cmd)
            Return Dt
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function



    Public Shared Function fn_ConsultaSolicitudesMaterial_LlenarReporte(ByVal Fecha_Desde As Date, ByVal Fecha_Hasta As Date, ByVal Status As Char, ByVal Tipo As Integer) As DataTable
        Dim Dt As DataTable
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Cmd As SqlCommand = Crea_Comando("Mat_Solicitudes_Materieal_Get", CommandType.StoredProcedure, Cnn)
        Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId) '--
        Crea_Parametro(Cmd, "@Fecha_Desde", SqlDbType.Date, Fecha_Desde)
        Crea_Parametro(Cmd, "@Fecha_Hasta", SqlDbType.Date, Fecha_Hasta)
        Crea_Parametro(Cmd, "@Usuario_Solicita", SqlDbType.Int, 0)
        Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Status)
        Crea_Parametro(Cmd, "@Tipo", SqlDbType.Int, Tipo)

        Try
            Dt = EjecutaConsulta(Cmd)
            Return Dt
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function


    Public Shared Function fn_ConsultaSolicitudesConsumibles_LlenarDetalle(ByVal lsv As cp_Listview, ByVal Id_Solicitud As Integer) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Mat_SolicitudesD_Get", CommandType.StoredProcedure, Crea_ConexionSTD)
        Try
            Crea_Parametro(cmd, "@Id_Solicitud", SqlDbType.Int, Id_Solicitud)
            lsv.Actualizar(cmd, "Id_Consumible")

            lsv.Columns("CantidadSolicitada").TextAlign = HorizontalAlignment.Right
            lsv.Columns("CantidadValidada").TextAlign = HorizontalAlignment.Right
            lsv.Columns("CantidadSurtida").TextAlign = HorizontalAlignment.Right
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function
    '-----------------------------------------------------
    Public Shared Function fn_ValidarSolicitudesConsumibles_LlenarDetalle(ByVal Id_Solicitud As Integer) As DataTable

        Dim con As SqlConnection = Crea_ConexionSTD()
        Try
            Dim cmd As SqlCommand = Crea_Comando("Mat_SolicitudesD_Get", CommandType.StoredProcedure, con)
            Crea_Parametro(cmd, "@Id_Solicitud", SqlDbType.Int, Id_Solicitud)
            'Leer de SQL
            Return EjecutaConsulta(cmd)

        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try

    End Function


    Public Shared Function fn_ValidarSolicitudesMaterial_LlenarDetalle(ByVal Id_Solicitud As Integer) As DataTable

        Dim con As SqlConnection = Crea_ConexionSTD()
        Try
            Dim cmd As SqlCommand = Crea_Comando("Mat_SolicitudesD_Material_Get", CommandType.StoredProcedure, con)
            Crea_Parametro(cmd, "@Id_Solicitud", SqlDbType.Int, Id_Solicitud)
            'Leer de SQL
            Return EjecutaConsulta(cmd)

        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function


    Public Shared Function fn_ValidarSolicitudesMaterial_LlenarDetalle_Pendiente(ByVal Id_Solicitud As Integer) As DataTable

        Dim con As SqlConnection = Crea_ConexionSTD()
        Try
            Dim cmd As SqlCommand = Crea_Comando("Mat_SolicitudesD_Material_Get_Pendientes", CommandType.StoredProcedure, con)
            Crea_Parametro(cmd, "@Id_Solicitud", SqlDbType.Int, Id_Solicitud)
            'Leer de SQL
            Return EjecutaConsulta(cmd)

        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    '--------------------------------------------------------
    Public Shared Function fn_SurtirSolicitudConsumibles_Guardar(ByVal Id_Solicitud As Integer, ByVal Status As String, ByVal Dt As DataTable) As Boolean
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Tr As SqlTransaction = crear_Trans(Cnn)
        Dim Cmd As SqlCommand
        Try
            'Cambiar el Status de Mat_Solicitudes
            Cmd = Crea_ComandoT(Cnn, Tr, CommandType.StoredProcedure, "Mat_Solicitudes_Update")
            Crea_Parametro(Cmd, "@Id_Solicitud", SqlDbType.Int, Id_Solicitud)
            Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Crea_Parametro(Cmd, "@Usuario_Surte", SqlDbType.Int, UsuarioId)
            Crea_Parametro(Cmd, "@Estacion_Surte", SqlDbType.VarChar, EstacioN)
            Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Status)
            EjecutarNonQueryT(Cmd)

            'Actualizar Mat_SolicitudesD
            If Status = "V" Then
            Else
                For Each Fila As DataRow In Dt.Rows
                    Cmd = Crea_ComandoT(Cnn, Tr, CommandType.StoredProcedure, "Mat_SolicitudesD_Update")
                    Crea_Parametro(Cmd, "@Id_Solicitud", SqlDbType.Int, Id_Solicitud)
                    Crea_Parametro(Cmd, "@Id_Consumible", SqlDbType.Int, Fila("Id_Consumible"))
                    Dim Faltantes = Fila("Faltantes")
                    Dim CantidadSurtidaParcial = Fila("CantidadSurtida")
                    Dim CS = (Val(Fila("CantidadSurtida")) + Val(Fila("Acumulador")))
                    Dim CV As Integer = Fila("CantidadValidada")
                    Dim Resultado = Faltantes - CantidadSurtidaParcial



                    Crea_Parametro(Cmd, "@Cantidad_Surtida", SqlDbType.Int, CS)
                    If CV = CS Then

                        Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "S")
                    Else

                        If Resultado = 0 Then
                            Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "S")

                        Else
                            Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "P")

                        End If


                    End If


                    EjecutarNonQueryT(Cmd)
                Next

                Tr.Commit()
                Cmd.Dispose()
                Return True
            End If
            Tr.Commit()
            Cmd.Dispose()
            Return True

        Catch ex As Exception
            Tr.Rollback()
            Cmd.Dispose()
            TrataEx(ex)
            Return False
        End Try
    End Function



    Public Shared Function fn_SurtirSolicitudMaterial_Guardar(ByVal Id_Solicitud As Integer, ByVal Status As String, ByVal Dt As DataTable) As Boolean
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Tr As SqlTransaction = crear_Trans(Cnn)
        Dim Cmd As SqlCommand
        Try
            'Cambiar el Status de Mat_Solicitudes
            Cmd = Crea_ComandoT(Cnn, Tr, CommandType.StoredProcedure, "Mat_Solicitudes_Update")
            Crea_Parametro(Cmd, "@Id_Solicitud", SqlDbType.Int, Id_Solicitud)
            Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Crea_Parametro(Cmd, "@Usuario_Surte", SqlDbType.Int, UsuarioId)
            Crea_Parametro(Cmd, "@Estacion_Surte", SqlDbType.VarChar, EstacioN)
            Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Status)
            EjecutarNonQueryT(Cmd)

            'Actualizar Mat_SolicitudesD
            If Status = "V" Then
            Else
                For Each Fila As DataRow In Dt.Rows
                    Cmd = Crea_ComandoT(Cnn, Tr, CommandType.StoredProcedure, "Mat_SolicitudesD_Update")
                    Crea_Parametro(Cmd, "@Id_Solicitud", SqlDbType.Int, Id_Solicitud)
                    Crea_Parametro(Cmd, "@Id_Consumible", SqlDbType.Int, Fila("Id_Consumible"))
                    Dim Faltantes = Fila("Faltantes")
                    Dim CantidadSurtidaParcial = Fila("CantidadSurtida")
                    Dim CS = (Val(Fila("CantidadSurtida")) + Val(Fila("Acumulador")))
                    Dim CV As Integer = Fila("CantidadValidada")
                    Dim Resultado = Faltantes - CantidadSurtidaParcial



                    Crea_Parametro(Cmd, "@Cantidad_Surtida", SqlDbType.Int, CS)
                    If CV = CS Then

                        Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "S")
                    Else

                        If Resultado = 0 Then
                            Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "S")

                        Else
                            Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "S")

                        End If


                    End If


                    EjecutarNonQueryT(Cmd)
                Next

                Tr.Commit()
                Cmd.Dispose()
                Return True
            End If
            Tr.Commit()
            Cmd.Dispose()
            Return True

        Catch ex As Exception
            Tr.Rollback()
            Cmd.Dispose()
            TrataEx(ex)
            Return False
        End Try
    End Function


    Public Shared Function fn_SurtirSolicitudMaterial_Local(ByVal Id_Solicitud As Integer, ByVal Status As String, ByVal Dt As DataTable) As Boolean
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Tr As SqlTransaction = crear_Trans(Cnn)
        Dim Cmd As SqlCommand

        'Cambiar el Status de Mat_Solicitudes
        Cmd = Crea_ComandoT(Cnn, Tr, CommandType.StoredProcedure, "Mat_Solicitudes_Update")
            Crea_Parametro(Cmd, "@Id_Solicitud", SqlDbType.Int, Id_Solicitud)
            Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Crea_Parametro(Cmd, "@Usuario_Surte", SqlDbType.Int, UsuarioId)
            Crea_Parametro(Cmd, "@Estacion_Surte", SqlDbType.VarChar, EstacioN)
            Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Status)
            EjecutarNonQueryT(Cmd)

        'Actualizar Mat_SolicitudesD
        Try
            If Status = "V" Then
            Else
                For Each Fila As DataRow In Dt.Rows
                    Cmd = Crea_ComandoT(Cnn, Tr, CommandType.StoredProcedure, "Mat_SolicitudesD_Update")
                    Crea_Parametro(Cmd, "@Id_Solicitud", SqlDbType.Int, Id_Solicitud)
                    Crea_Parametro(Cmd, "@Id_Consumible", SqlDbType.Int, Fila("Id_Consumible"))
                    Crea_Parametro(Cmd, "@Cantidad_Surtida", SqlDbType.Int, Fila("CantidadSurtida"))
                    If Fila("CantidadSurtida") = 0 Then
                        Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "C")
                    Else

                        Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "S")


                    End If



                    EjecutarNonQueryT(Cmd)
                Next


            End If

            Tr.Commit()
            Cmd.Dispose()
            Return True

        Catch ex As Exception
            Tr.Rollback()
            Cmd.Dispose()
            TrataEx(ex)
            Return False
        End Try
    End Function
    Public Shared Function fn_Material_Status(ByVal Id_Solicitud As Integer, ByVal Status As String, ByVal Tipo As Integer) As Boolean
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Tr As SqlTransaction = crear_Trans(Cnn)
        Dim Cmd As SqlCommand
        Try
            'Cambiar el Status de Mat_Solicitudes
            Cmd = Crea_ComandoT(Cnn, Tr, CommandType.StoredProcedure, "Mat_Solicitudes_Update_Parcial")
            Crea_Parametro(Cmd, "@Id_Solicitud", SqlDbType.Int, Id_Solicitud)
            Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Status)
            Crea_Parametro(Cmd, "@Tipo", SqlDbType.Int, Tipo)
            EjecutarNonQueryT(Cmd)


            Tr.Commit()
            Cmd.Dispose()
            Return True

        Catch ex As Exception
            Tr.Rollback()
            Cmd.Dispose()
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Parcialidad_Guardar(ByVal Id_Solicitudes As Integer, ByVal Num_Parcialidaes As Integer, ByVal Id_Consumible As Integer) As Integer
        Dim cnn As SqlConnection = Crea_ConexionSTD()
        Dim tr As SqlTransaction = crear_Trans(cnn)

        Try
            Dim cmd As SqlCommand = Crea_ComandoT(cnn, tr, CommandType.StoredProcedure, "Mat_Parcialidades_Create")
            Crea_Parametro(cmd, "@Id_SolicitudesD", SqlDbType.Int, Id_Solicitudes)
            Crea_Parametro(cmd, "@Id_Consumible", SqlDbType.Int, Id_Consumible)
            Crea_Parametro(cmd, "@NumeroParcialidad", SqlDbType.Int, Num_Parcialidaes)

            Dim SolicitudID = EjecutarScalarT(cmd)

            If SolicitudID = 0 Then
                tr.Rollback()
                Return 0
            Else
                tr.Commit()
                Return 1
            End If
        Catch ex As Exception
            tr.Rollback()

        End Try


    End Function


    '---------------------------------------------
    Public Shared Function fn_ValidarSolicitudesConsumibles_LlenarLista(ByVal lsv As cp_Listview, ByVal UsuarioSolicita As Integer, ByVal Tipo As Integer) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Mat_Solicitudes_GetAV", CommandType.StoredProcedure, Crea_ConexionSTD)
        Try
            Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Crea_Parametro(cmd, "@Usuario_Solicita", SqlDbType.Int, UsuarioSolicita)
            Crea_Parametro(cmd, "@Tipo", SqlDbType.Int, Tipo)

            lsv.Actualizar(cmd, "Id_Solicitud")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function
    '------------------------------------------
    Public Shared Function fn_ValidarSolicitudesConsumibles_Cancelar(ByVal Id_Solicitud As Integer, ByVal Dt As DataTable) As Boolean
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Tr As SqlTransaction = crear_Trans(Cnn)
        Dim Cmd As SqlCommand
        Try
            'Cambiar el Status de Mat_Solicitudes
            Cmd = Crea_ComandoT(Cnn, Tr, CommandType.StoredProcedure, "Mat_Solicitudes_Cancelar")
            Crea_Parametro(Cmd, "@Id_Solicitud", SqlDbType.Int, Id_Solicitud)
            Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Crea_Parametro(Cmd, "@Usuario_Cancela", SqlDbType.Int, UsuarioId)
            Crea_Parametro(Cmd, "@Estacion_Cancela", SqlDbType.VarChar, EstacioN)
            Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "C")
            EjecutarNonQueryT(Cmd)

            'Actualizar Mat_SolicitudesD    
            For Each Fila As DataRow In Dt.Rows
                Cmd = Crea_ComandoT(Cnn, Tr, CommandType.StoredProcedure, "Mat_SolicitudesD_cancelar")
                Crea_Parametro(Cmd, "@Id_Solicitud", SqlDbType.Int, Fila("Id_Solicitud"))
                Crea_Parametro(Cmd, "@Id_Consumible", SqlDbType.Int, Fila("Id_Consumible"))
                Crea_Parametro(Cmd, "@Cantidad_Surtida", SqlDbType.Int, 0)
                Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "C")
                EjecutarNonQueryT(Cmd)
            Next

            Tr.Commit()
            Cmd.Dispose()
            Return True
        Catch ex As Exception
            Tr.Rollback()
            Cmd.Dispose()
            TrataEx(ex)
            Return False
        End Try
    End Function
    Public Shared Function fn_ArchivosPath(ByVal Remplazar As String) As String
        'Regresa el Path de la ubicación donde estará el archivo, esto debido a que cuando se ejecuta en debug,
        'release o una aplicación publicada la ubicación de la aplicación (.exe) cambia.
        Try
            Dim Exe As String = Application.StartupPath
            If InStr(Exe, "bin\Debug") > 0 Then
                Return Replace(Exe, "bin\Debug", Remplazar) 'Ejecutando en Debug
            ElseIf InStr(Exe, "bin\Release") > 0 Then
                Return Replace(Exe, "bin\Release", Remplazar) 'Ejecutando en Release
            Else
                Exe &= "\" & Remplazar 'Ejecutando Directamente
                Return Exe
            End If
        Catch
            Return ""
        End Try
    End Function
    '------------------------------------
    Public Shared Function fn_ValidarSolicitudesConsumibles_Guardar(ByVal Id_Solicitud As Integer, ByVal Dt As DataTable, ByVal Status As Char) As Boolean
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Tr As SqlTransaction = crear_Trans(Cnn)

        Dim Cmd As SqlCommand
        Try
            'Cambiar el Status de Mat_Solicitudes
            Cmd = Crea_ComandoT(Cnn, Tr, CommandType.StoredProcedure, "Mat_Solicitudes_Validar")
            Crea_Parametro(Cmd, "@Id_Solicitud", SqlDbType.Int, Id_Solicitud)
            Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Crea_Parametro(Cmd, "@Usuario_Valida", SqlDbType.Int, UsuarioId)
            Crea_Parametro(Cmd, "@Estacion_Valida", SqlDbType.VarChar, EstacioN)
            Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Status)
            EjecutarNonQueryT(Cmd)

            'Actualizar Mat_SolicitudesD
            For Each Fila As DataRow In Dt.Rows
                Cmd = Crea_ComandoT(Cnn, Tr, CommandType.StoredProcedure, "Mat_SolicitudesD_Validar")
                Crea_Parametro(Cmd, "@Id_Solicitud", SqlDbType.Int, Fila("Id_Solicitud"))
                Crea_Parametro(Cmd, "@Id_Consumible", SqlDbType.Int, Fila("Id_Consumible"))
                Crea_Parametro(Cmd, "@Cantidad_Validada", SqlDbType.Int, Fila("CantidadValidada"))
                Crea_Parametro(Cmd, "@Observaciones", SqlDbType.VarChar, Fila("Observaciones"))
                Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Fila("Status"))
                EjecutarNonQueryT(Cmd)
            Next

            Tr.Commit()
            Cmd.Dispose()
            Return True
        Catch ex As Exception
            Tr.Rollback()
            Cmd.Dispose()
            TrataEx(ex)
            Return False
        End Try
    End Function


    Public Shared Function fn_ValidarSolicitudesConsumibles_resgresarStatus(ByVal Id_Solicitud As Integer, ByVal Dt As DataTable, ByVal Status As Char) As Boolean
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Tr As SqlTransaction = crear_Trans(Cnn)

        Dim Cmd As SqlCommand
        Try
            'Cambiar el Status de Mat_Solicitudes
            Cmd = Crea_ComandoT(Cnn, Tr, CommandType.StoredProcedure, "Mat_Solicitudes_Regresar")
            Crea_Parametro(Cmd, "@Id_Solicitud", SqlDbType.Int, Id_Solicitud)
            Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Status)
            EjecutarNonQueryT(Cmd)

            'Actualizar Mat_SolicitudesD
            For Each Fila As DataRow In Dt.Rows
                Cmd = Crea_ComandoT(Cnn, Tr, CommandType.StoredProcedure, "Mat_SolicitudesD_Regresar")
                Crea_Parametro(Cmd, "@Id_Solicitud", SqlDbType.Int, Fila("Id_Solicitud"))
                Crea_Parametro(Cmd, "@Id_Consumible", SqlDbType.Int, Fila("Id_Consumible"))
                Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Status)
                EjecutarNonQueryT(Cmd)
            Next

            Tr.Commit()
            Cmd.Dispose()
            Return True
        Catch ex As Exception
            Tr.Rollback()
            Cmd.Dispose()
            TrataEx(ex)
            Return False
        End Try
    End Function


    Public Shared Function fn_CuentaTotalesXConsumibles(ByVal lsv As cp_Listview, ByVal Ids_Solicitudes As String) As Boolean
        Dim cnn As SqlConnection = Crea_ConexionSTD()
        Try
            Dim cmd As SqlCommand = Crea_Comando("Mat_SolicitudesD_GetSumaTotal", CommandType.StoredProcedure, cnn)
            Crea_Parametro(cmd, "@Ids_Solicitudes", SqlDbType.VarChar, Ids_Solicitudes)
            lsv.Actualizar(cmd, "Id_Consumible")
            lsv.Columns(1).TextAlign = HorizontalAlignment.Right
            lsv.Columns(2).TextAlign = HorizontalAlignment.Right
            lsv.Columns(3).TextAlign = HorizontalAlignment.Right
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function
    Public Shared Function fn_AlertasGeneradas_Guardar(ByVal Clave_AlertaTipo As String, ByVal Detalles As String) As Boolean
        Try
            Dim cmd As SqlCommand = Crea_Comando("Cat_AlertasGeneradas_Create", CommandType.StoredProcedure, Crea_ConexionSTD())
            Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Crea_Parametro(cmd, "@Clave_AlertaTipo", SqlDbType.VarChar, Clave_AlertaTipo)
            Crea_Parametro(cmd, "@Detalles", SqlDbType.Text, Detalles)
            Crea_Parametro(cmd, "@Id_EmpleadoGenera", SqlDbType.Int, UsuarioId)
            Crea_Parametro(cmd, "@Estacion_Genera", SqlDbType.VarChar, EstacioN)

            Return True
            EjecutarScalar(cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function




    Public Shared Function fn_AlertasGeneradas_ObtenerMails(ByVal Clave_AlertaTipo As String) As DataTable
        Try
            Dim cnn As SqlConnection = Crea_ConexionSTD()
            Dim cmd As SqlCommand = Crea_Comando("Cat_AlertasDestinos_GetMail", CommandType.StoredProcedure, cnn)
            Crea_Parametro(cmd, "@Clave_AlertaTipo", SqlDbType.VarChar, Clave_AlertaTipo)
            Return EjecutaConsulta(cmd)
        Catch ex As Exception
            'TrataEx(ex, SucursalId, UsuarioID)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_Material_LeerDatosSolicitud(ByVal Id_Solicitud As Integer) As DataRow
        Try
            Dim cnn As SqlConnection = Crea_ConexionSTD()
            Dim cmd As SqlCommand = Crea_Comando("Mat_Solicitudes_Read", CommandType.StoredProcedure, cnn)
            Crea_Parametro(cmd, "@Id_Solicitud", SqlDbType.Int, Id_Solicitud)
            Dim dt As DataTable = EjecutaConsulta(cmd)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
                Return dt.Rows(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function
    Public Shared Function fn_Material_LeerDetalleSolicitud(ByVal Id_Solicitud As Integer) As DataTable
        Try
            Dim cnn As SqlConnection = Crea_ConexionSTD()
            Dim cmd As SqlCommand = Crea_Comando("Mat_SolicitudesD_Read", CommandType.StoredProcedure, cnn)
            Crea_Parametro(cmd, "@Id_Solicitud", SqlDbType.Int, Id_Solicitud)
            Return EjecutaConsulta(cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function


    Public Shared Function fn_InsertaSolicitudMateriales(ByVal Id_Solicitud As Integer, ByVal Id_Consumible As Integer, ByVal Cantidad_Solicitada As Integer) As Boolean
        Dim cnn As SqlConnection = Crea_ConexionSTD() '23/10/2012
        Try
            Dim cmd As SqlCommand = Crea_Comando("Mat_SolicitudesD_Create", CommandType.StoredProcedure, cnn)
            Crea_Parametro(cmd, "@Id_Solicitud", SqlDbType.Int, Id_Solicitud)
            Crea_Parametro(cmd, "@Id_Consumible", SqlDbType.Int, Id_Consumible)
            Crea_Parametro(cmd, "@Cantidad_Solicitada", SqlDbType.Int, Cantidad_Solicitada)
            Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "A")
            EjecutarNonQuery(cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

#End Region

#Region "DESCARGA MANUAL DE USUARIO"

    Public Shared Function fn_Archivos_Descargar(ByVal Id_Doc As Integer) As Byte()
        Dim dt As DataTable
        'Aqui se llena el listview
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Usr_Documentos_Read", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Doc", SqlDbType.Int, Id_Doc)

        Try
            dt = Cn_Datos.EjecutaConsulta(Cmd)
            If dt IsNot Nothing Then
                If dt.Rows.Count > 0 Then
                    Return dt.Rows(0)("Archivo")
                Else
                    Return Nothing
                End If
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
        End Try

    End Function


    Public Shared Function fn_ModulosArchivos_LlenarLista(ByRef lsv As cp_Listview, ByVal Clave_Modulo As String) As Boolean

        'Aqui se llena el listview
        Dim Cnn As SqlConnection = Cn_Datos.Crea_ConexionSTD()
        Dim Cmd As SqlCommand = Cn_Datos.Crea_Comando("Usr_Documentos_Get", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Clave_Modulo", SqlDbType.VarChar, Clave_Modulo)
        Try
            lsv.Actualizar(Cmd, "Id_Doc")
            Return True
        Catch ex As Exception
            FuncionesGlobales.TrataEx(ex, True)
            Return False
        End Try
    End Function

#End Region

#Region "FUNCION CUENTA SETTINGS"

    Public Shared Function fn_CuentaSettings() As Integer
        Dim CuentaSettings As Integer = 0
        For Each setting As System.Configuration.SettingsProperty In My.Settings.Properties
            If Microsoft.VisualBasic.Left(setting.Name.ToString.ToUpper, 9) = "SERVDATOS" AndAlso (My.Settings(setting.Name)).ToString.Split(",")(0) = "VACIO" Then
                CuentaSettings += 1
            End If
        Next
        Return CuentaSettings
    End Function

#End Region

#Region "Proveedores"

    Public Shared Function fn_Proveedores_LlenarCombo(ByRef Cmb As ComboBox) As Boolean

        'Aqui se llena el listview
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_CiudadesPais_Get", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Pais", SqlDbType.VarChar, ObtenPais)
        Dim Dt As DataTable = Cn_Datos.EjecutaConsulta(Cmd)

        Return FuncionesGlobales.fn_CargaCombo(Cmb, Dt, "Id_Ciudad", "Nombre")

    End Function

    Public Shared Function fn_Proveedores_LlenarLista(ByRef lsv As cp_Listview, ByVal Status As String) As Boolean

        'Aqui se llena el listview de los Proveedores
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_Proveedores_Get", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Pista", SqlDbType.VarChar, "")
        Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Status)

        Try
            lsv.Actualizar(Cmd, "Id_Proveedor")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_ProveedoresContactos_LlenarLista(ByVal Id_Proveedor As Integer, ByRef lsv As cp_Listview) As Boolean

        'Aqui se llena el listview de los Proveedores
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_ProveedoresContactos_Get", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Proveedor", SqlDbType.Int, Id_Proveedor)

        Try
            lsv.Actualizar(Cmd, "Id_ProveedorC")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Proveedores_Nuevo(ByVal Clave As String, ByVal NombreF As String, ByVal DireccionF As String, ByVal Numero_Fiscal As Integer, ByVal NumeroInt_Fiscal As String, ByVal Colonia_Fiscal As String, ByVal CiudadF As Integer,
        ByVal RFC As String, ByVal NombreC As String, ByVal DireccionC As String, ByVal Numero_Comercial As Integer, ByVal NumeroInt_Comercial As String, ByVal Colonia_Comercial As String, ByVal CiudadC As Integer, ByVal Contacto As String, ByVal Telefono As String,
        ByVal Fax As String, ByVal Mail As String, ByVal IVA As Integer, ByVal Retencion As Integer, ByVal Observaciones As String, ByVal Dias_Credito As Integer, ByVal Lsv_Contactos As cp_Listview) As Boolean

        Dim Id_Proveedor As Integer = 0
        'Aqui se inserta un nuevo proveedor
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Tr As SqlTransaction = Cn_Datos.crear_Trans(Cnn)
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_ComandoT(Cnn, Tr, CommandType.StoredProcedure, "Cat_Proveedores_Create")
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Empresa", SqlDbType.Int, EmpresaId)
        Cn_Datos.Crea_Parametro(Cmd, "@Clave_Proveedor", SqlDbType.VarChar, Clave)
        Cn_Datos.Crea_Parametro(Cmd, "@Nombre_Fiscal", SqlDbType.VarChar, NombreF)
        Cn_Datos.Crea_Parametro(Cmd, "@Direccion_Fiscal", SqlDbType.VarChar, DireccionF)
        Cn_Datos.Crea_Parametro(Cmd, "@Ciudad_Fiscal", SqlDbType.Int, CiudadF)
        Cn_Datos.Crea_Parametro(Cmd, "@RFC", SqlDbType.VarChar, RFC)
        Cn_Datos.Crea_Parametro(Cmd, "@Nombre_Comercial", SqlDbType.VarChar, NombreC)
        Cn_Datos.Crea_Parametro(Cmd, "@Direccion_Comercial", SqlDbType.VarChar, DireccionC)
        Cn_Datos.Crea_Parametro(Cmd, "@Ciudad_Comercial", SqlDbType.Int, CiudadC)
        Cn_Datos.Crea_Parametro(Cmd, "@Contacto", SqlDbType.VarChar, Contacto)
        Cn_Datos.Crea_Parametro(Cmd, "@Telefono", SqlDbType.VarChar, Telefono)
        Cn_Datos.Crea_Parametro(Cmd, "@Fax", SqlDbType.VarChar, Fax)
        Cn_Datos.Crea_Parametro(Cmd, "@Mail", SqlDbType.VarChar, Mail)
        Cn_Datos.Crea_Parametro(Cmd, "@IVA", SqlDbType.Int, IVA)
        Cn_Datos.Crea_Parametro(Cmd, "@Retencion", SqlDbType.Int, Retencion)
        Cn_Datos.Crea_Parametro(Cmd, "@Observaciones", SqlDbType.VarChar, Observaciones)
        Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
        Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "A")
        Cn_Datos.Crea_Parametro(Cmd, "@Numero_Fiscal", SqlDbType.Int, Numero_Fiscal)
        Cn_Datos.Crea_Parametro(Cmd, "@NumeroInt_Fiscal", SqlDbType.VarChar, NumeroInt_Fiscal)
        Cn_Datos.Crea_Parametro(Cmd, "@Colonia_Fiscal", SqlDbType.VarChar, Colonia_Fiscal)
        Cn_Datos.Crea_Parametro(Cmd, "@Numero_Comercial", SqlDbType.Int, Numero_Comercial)
        Cn_Datos.Crea_Parametro(Cmd, "@NumeroInt_Comercial", SqlDbType.VarChar, NumeroInt_Comercial)
        Cn_Datos.Crea_Parametro(Cmd, "@Colonia_Comercial", SqlDbType.VarChar, Colonia_Comercial)
        Cn_Datos.Crea_Parametro(Cmd, "@Dias_Credito", SqlDbType.Int, Dias_Credito)

        Try
            Id_Proveedor = Cn_Datos.EjecutarScalarT(Cmd)
            For Each Elemento As ListViewItem In Lsv_Contactos.Items
                Cmd = Cn_Datos.Crea_ComandoT(Cnn, Tr, CommandType.StoredProcedure, "Cat_ProveedoresContactos_Create")
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Proveedor", SqlDbType.Int, Id_Proveedor)
                Cn_Datos.Crea_Parametro(Cmd, "@Nombre", SqlDbType.VarChar, Elemento.Text)
                Cn_Datos.Crea_Parametro(Cmd, "@Puesto", SqlDbType.VarChar, Elemento.SubItems(1).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@TelFijo", SqlDbType.VarChar, Elemento.SubItems(2).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@TelMovil", SqlDbType.VarChar, Elemento.SubItems(3).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@Mail", SqlDbType.VarChar, Elemento.SubItems(4).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.VarChar, UsuarioId)
                Cn_Datos.Crea_Parametro(Cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)
                Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "A")
                Cn_Datos.EjecutarScalarT(Cmd)
            Next
            Tr.Commit()
            Return True
        Catch ex As Exception
            Tr.Rollback()
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Proveedores_Actualizar(ByVal Id_Proveedor As Integer, ByVal Clave As String, ByVal NombreF As String, ByVal DireccionF As String, ByVal Numero_Fiscal As Integer, ByVal NumeroInt_Fiscal As String, ByVal Colonia_Fiscal As String, ByVal CiudadF As Integer,
        ByVal RFC As String, ByVal NombreC As String, ByVal DireccionC As String, ByVal Numero_Comercial As Integer, ByVal NumeroInt_Comercial As String, ByVal Colonia_Comercial As String, ByVal CiudadC As Integer, ByVal Contacto As String, ByVal Telefono As String,
        ByVal Fax As String, ByVal Mail As String, ByVal IVA As Integer, ByVal Retencion As Integer, ByVal Observaciones As String, ByVal Dias_Credito As Integer) As Boolean

        'Aqui se actualiza un proveedor
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Tr As SqlTransaction = Cn_Datos.crear_Trans(Cnn)
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_ComandoT(Cnn, Tr, CommandType.StoredProcedure, "Cat_Proveedores_Update")
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Proveedor", SqlDbType.Int, Id_Proveedor)
        Cn_Datos.Crea_Parametro(Cmd, "@Clave_Proveedor", SqlDbType.VarChar, Clave)
        Cn_Datos.Crea_Parametro(Cmd, "@Nombre_Fiscal", SqlDbType.VarChar, NombreF)
        Cn_Datos.Crea_Parametro(Cmd, "@Direccion_Fiscal", SqlDbType.VarChar, DireccionF)
        Cn_Datos.Crea_Parametro(Cmd, "@Ciudad_Fiscal", SqlDbType.Int, CiudadF)
        Cn_Datos.Crea_Parametro(Cmd, "@RFC", SqlDbType.VarChar, RFC)
        Cn_Datos.Crea_Parametro(Cmd, "@Nombre_Comercial", SqlDbType.VarChar, NombreC)
        Cn_Datos.Crea_Parametro(Cmd, "@Direccion_Comercial", SqlDbType.VarChar, DireccionC)
        Cn_Datos.Crea_Parametro(Cmd, "@Ciudad_Comercial", SqlDbType.Int, CiudadC)
        Cn_Datos.Crea_Parametro(Cmd, "@Contacto", SqlDbType.VarChar, Contacto)
        Cn_Datos.Crea_Parametro(Cmd, "@Telefono", SqlDbType.VarChar, Telefono)
        Cn_Datos.Crea_Parametro(Cmd, "@Fax", SqlDbType.VarChar, Fax)
        Cn_Datos.Crea_Parametro(Cmd, "@Mail", SqlDbType.VarChar, Mail)
        Cn_Datos.Crea_Parametro(Cmd, "@IVA", SqlDbType.Int, IVA)
        Cn_Datos.Crea_Parametro(Cmd, "@Retencion", SqlDbType.Int, Retencion)
        Cn_Datos.Crea_Parametro(Cmd, "@Observaciones", SqlDbType.VarChar, Observaciones)
        Cn_Datos.Crea_Parametro(Cmd, "@Numero_Fiscal", SqlDbType.Int, Numero_Fiscal)
        Cn_Datos.Crea_Parametro(Cmd, "@NumeroInt_Fiscal", SqlDbType.VarChar, NumeroInt_Fiscal)
        Cn_Datos.Crea_Parametro(Cmd, "@Colonia_Fiscal", SqlDbType.VarChar, Colonia_Fiscal)
        Cn_Datos.Crea_Parametro(Cmd, "@Numero_Comercial", SqlDbType.Int, Numero_Comercial)
        Cn_Datos.Crea_Parametro(Cmd, "@NumeroInt_Comercial", SqlDbType.VarChar, NumeroInt_Comercial)
        Cn_Datos.Crea_Parametro(Cmd, "@Colonia_Comercial", SqlDbType.VarChar, Colonia_Comercial)
        Cn_Datos.Crea_Parametro(Cmd, "@Dias_Credito", SqlDbType.Int, Dias_Credito)
        Try
            Cn_Datos.EjecutarNonQueryT(Cmd)
            Tr.Commit()
            Return True
        Catch ex As Exception
            Tr.Rollback()
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_ProveedoresContactos_Nuevo(ByVal Id_Proveedor As Integer, ByVal Nombre As String, ByVal Puesto As String, ByVal TelFijo As String, ByVal TelMovil As String, ByVal Mail As String) As Boolean

        Dim Id_ProveedorC As Integer = 0
        'Aqui se inserta un nuevo proveedor
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim cmd As SqlCommand
        Try
            cmd = Cn_Datos.Crea_Comando("Cat_ProveedoresContactos_Create", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(cmd, "@Id_Proveedor", SqlDbType.Int, Id_Proveedor)
            Cn_Datos.Crea_Parametro(cmd, "@Nombre", SqlDbType.VarChar, Nombre)
            Cn_Datos.Crea_Parametro(cmd, "@Puesto", SqlDbType.VarChar, Puesto)

            Cn_Datos.Crea_Parametro(cmd, "@TelFijo", SqlDbType.VarChar, TelFijo)
            Cn_Datos.Crea_Parametro(cmd, "@TelMovil", SqlDbType.VarChar, TelMovil)
            Cn_Datos.Crea_Parametro(cmd, "@Mail", SqlDbType.VarChar, Mail)

            Cn_Datos.Crea_Parametro(cmd, "@Usuario_Registro", SqlDbType.VarChar, UsuarioId)
            Cn_Datos.Crea_Parametro(cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)
            Cn_Datos.Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "A")
            Id_ProveedorC = Cn_Datos.EjecutarScalar(cmd)

            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_ProveedoresContactos_Delete(ByVal Id_ProveedorC As Integer) As Boolean
        'Aqui se llena el listview de los Proveedores
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_ProveedoresContactos_Delete", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_ProveedorC", SqlDbType.Int, Id_ProveedorC)

        Try
            Cn_Datos.EjecutarNonQuery(Cmd)
            Cmd.Dispose()
            Return True
        Catch ex As Exception
            Cmd.Dispose()
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_ProveedoresContactos_Baja(ByVal Id_ProveedorC As Integer) As Boolean
        'Aqui se llena el listview de los Proveedores
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_ProveedoresContactos_Baja", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_ProveedorC", SqlDbType.Int, Id_ProveedorC)
        Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Baja", SqlDbType.Int, UsuarioId)
        Cn_Datos.Crea_Parametro(Cmd, "@Estacion_Baja", SqlDbType.VarChar, EstacioN)

        Try
            Cn_Datos.EjecutarNonQuery(Cmd)
            Cmd.Dispose()
            Return True
        Catch ex As Exception
            Cmd.Dispose()
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Proveedores_Baja(ByVal Id As Integer) As Boolean
        'Aqui se actualiza un pais
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD

        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_Proveedores_Status", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Proveedor", SqlDbType.Int, Id)
        Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "B")

        Try
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_Proveedores_Alta(ByVal Id As Integer) As Boolean
        'Aqui se actualiza un pais
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD

        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_Proveedores_Status", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Proveedor", SqlDbType.Int, Id)
        Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "A")

        Try
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_Proveedores_ValidarClave(ByVal Clave As String, ByVal ClaveAnt As ListView.SelectedListViewItemCollection) As Boolean
        If ClaveAnt.Count = 0 Then GoTo Validar
        If Not Clave = ClaveAnt(0).SubItems(0).Text Then GoTo Validar
        Return True
        Exit Function
Validar:

        'Aqui se actualiza un pais
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD

        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("cat_proveedores_validarclave", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Clave", SqlDbType.VarChar, Clave)

        Try

            Dim Tbl As DataTable = Cn_Datos.EjecutaConsulta(Cmd)
            If Tbl.Rows.Count = 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try


    End Function

    Public Shared Function fn_Proveedores_ValidarDependencias(ByVal Id As Integer) As Boolean
        'Aqui se valida una dependencia
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD

        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_Proveedores_Dependencias", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Proveedor", SqlDbType.VarChar, Id)

        Try

            Dim Tbl As DataTable = Cn_Datos.EjecutaConsulta(Cmd)
            If Tbl.Rows.Count = 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_Proveedores_ObtenerValores(ByVal Id As Integer) As DataRow
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_Proveedores_Read", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Proveedor", SqlDbType.Int, Id)
        Try
            Dim Tbl As DataTable = Cn_Datos.EjecutaConsulta(Cmd)
            If Tbl.Rows.Count = 0 Then
                Return Nothing
            Else
                Return Tbl.Rows(0)
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_Proveedores_LlenarRpt() As DataTable
        Dim Dt As DataTable
        Dim cnn As SqlConnection = Crea_ConexionSTD()
        Dim Cmd As SqlCommand = Crea_Comando("Cat_ProveedoresContactos_GetReporte", CommandType.StoredProcedure, cnn)
        Try
            Dt = EjecutaConsulta(Cmd)
            Return Dt
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

#End Region

#Region "ConsultaOrdenServicio"

    Public Shared Function fn_ReporteOrdenServicio(ByVal tbl As ds_OrdenServicio.dt_SI_Ordenes_GetDataTable, ByVal Id_OrdenServicio As Integer) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("SI_Ordenes_GetReporte", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Orden", SqlDbType.Int, Id_OrdenServicio)
        Try
            cmd.Connection.Open()
            tbl.Load(cmd.ExecuteReader) 'lee el contenido de la Tabla en el Dataset
            cmd.Connection.Close()
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Consulta_OrdenServicio(ByVal lsv As cp_Listview, ByVal Desde As Date, ByVal Hasta As Date, ByVal Id_Proveedor As Integer) As Boolean
        Dim cnn As SqlConnection = Crea_ConexionSTD()
        Try
            Dim cmd As SqlCommand = Crea_Comando("SI_Ordenes_Get2", CommandType.StoredProcedure, cnn)
            Crea_Parametro(cmd, "@Fecha_Desde", SqlDbType.Date, Desde)
            Crea_Parametro(cmd, "@Fecha_Hasta", SqlDbType.Date, Hasta)
            Crea_Parametro(cmd, "@Id_Proveedor", SqlDbType.Int, Id_Proveedor)
            lsv.Actualizar(cmd, "Id_Orden")
            If lsv.Items.Count > 0 Then
                For J As Integer = 0 To lsv.Items.Count - 1
                    If lsv.Items(J).SubItems(11).Text = "CANCELADA" Then
                        lsv.Items(J).ForeColor = Color.Red
                    End If
                Next
            End If
            Return True

        Catch ex As Exception
            TrataEx(ex, False)
            Return False
        End Try
    End Function
#End Region

    Public Shared Function fn_Reportes_Encabezado(ByRef Tbl As DataTable) As Boolean
        Using cmd As SqlCommand = Crea_Comando("Cat_Sucursales_GetDatos", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Try
                Tbl.Rows.Clear()
                cmd.Connection.Open()
                Tbl.Load(cmd.ExecuteReader)
                cmd.Connection.Close()
                Return True
            Catch ex As Exception
                If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
                TrataEx(ex)
                Return False
            End Try
        End Using
    End Function

#Region "Traspasos Intersucursales"

    Public Shared Function Fn_SuscursalesPropias_Combo() As DataTable
        'consulta las Sucursales Propias de la Base de Datos Central
        Dim Dt As DataTable
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_Conexion(Cnx_Central)
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("SucursalesPropias_Get", CommandType.StoredProcedure, Cnn)
        Try
            Dt = EjecutaConsulta(Cmd)
            Return Dt
        Catch ex As Exception
            TrataEx(ex, True)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_ConsultaSucursales(ByVal Clave_Sucursal As String) As DataTable
        'consulta el catalogo de Sucursales
        Dim Dt_Datos As DataTable
        Dim cmd As SqlClient.SqlCommand = Crea_Comando("Cat_Sucursales_Get2", CommandType.StoredProcedure, Crea_Conexion(Cnx_Sucursal))
        'Dim cmd As SqlClient.SqlCommand = Crea_Comando("Cat_Sucursales_Get2", CommandType.StoredProcedure, Crea_Conexion(Cnx_Central))
        Crea_Parametro(cmd, "@Clave_Sucursal", SqlDbType.VarChar, Clave_Sucursal)

        Try
            Dt_Datos = Cn_Datos.EjecutaConsulta(cmd)
            Return Dt_Datos
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try

    End Function

    Public Shared Function fn_ConsultaInventarioMateriales(ByVal Departamento As Dpto, ByVal Id_Sucursal As Integer) As DataTable
        'consulta el Inventario de Materiales de la Sucurswal Destino
        Dim Dt_Datos As DataTable
        Dim cmd As SqlClient.SqlCommand = Crea_Comando("Mat_Inventario_Get", CommandType.StoredProcedure, Crea_Conexion(Cnx_Sucursal))
        Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, Id_Sucursal)
        Crea_Parametro(cmd, "@Tipo", SqlDbType.Int, 4)

        Try
            Dt_Datos = Cn_Datos.EjecutaConsulta(cmd)
            Return Dt_Datos
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try

    End Function

    Public Shared Function fn_TraspasosMateriales_Guardar(ByVal Clave_SucursalO As String, ByVal Nombre_SucursalO As String, ByVal Clave_SucursalD As String,
                                                          ByVal Nombre_SucursalD As String, ByVal Comentarios As String, ByVal Dt_Detalle As DataTable, ByVal Control_Folios As String)
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_Conexion(Cnx_Central)
        Dim lc_Transaccion As SqlClient.SqlTransaction
        Dim Cmd As SqlClient.SqlCommand
        Dim Identity_Local As Integer

        lc_Transaccion = Cn_Datos.crear_Trans(Cnn)


        Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Mat_Traspasos_Create")
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Cn_Datos.Crea_Parametro(Cmd, "@Clave_SucursalO", SqlDbType.VarChar, Clave_SucursalO)
        Cn_Datos.Crea_Parametro(Cmd, "@Nombre_SucursalO", SqlDbType.VarChar, Nombre_SucursalO)
        Cn_Datos.Crea_Parametro(Cmd, "@Clave_SucursalD", SqlDbType.VarChar, Clave_SucursalD)
        Cn_Datos.Crea_Parametro(Cmd, "@Nombre_SucursalD", SqlDbType.VarChar, Nombre_SucursalD)
        Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
        Cn_Datos.Crea_Parametro(Cmd, "@Usuario_RegistroN", SqlDbType.VarChar, UsuarioN)
        Cn_Datos.Crea_Parametro(Cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)
        Cn_Datos.Crea_Parametro(Cmd, "@Comentarios", SqlDbType.VarChar, Comentarios)
        Cn_Datos.Crea_Parametro(Cmd, "@Control_Folios", SqlDbType.VarChar, Control_Folios)
        Try
            Identity_Local = Cn_Datos.EjecutarScalarT(Cmd)
        Catch ex As Exception
            lc_Transaccion.Rollback()
            Cnn.Close()
            TrataEx(ex)
            Return False
        End Try

        Try
            For Each Dr_Local As DataRow In Dt_Detalle.Rows
                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Mat_TraspasosD_Create")
                Cn_Datos.Crea_Parametro(Cmd, "@Id_MatTraspaso", SqlDbType.Int, Identity_Local)
                Cn_Datos.Crea_Parametro(Cmd, "@Id_InventarioO", SqlDbType.Int, CInt(Dr_Local("Id_InventarioO")))
                Cn_Datos.Crea_Parametro(Cmd, "@DescripcionO", SqlDbType.VarChar, Dr_Local("DescripcionO"))
                Cn_Datos.Crea_Parametro(Cmd, "@Id_InventarioD", SqlDbType.Int, CInt(Dr_Local("Id_InventarioD")))
                Cn_Datos.Crea_Parametro(Cmd, "@DescripcionD", SqlDbType.VarChar, Dr_Local("DescripcionD"))
                Cn_Datos.Crea_Parametro(Cmd, "@Cantidad", SqlDbType.Int, CInt(Dr_Local("Cantidad")))
                Cn_Datos.Crea_Parametro(Cmd, "@Control_Folios", SqlDbType.VarChar, Dr_Local("Control_Folios"))
                Cn_Datos.Crea_Parametro(Cmd, "@Folios", SqlDbType.VarChar, Dr_Local("Folios"))
                Cn_Datos.EjecutarNonQueryT(Cmd)
            Next

        Catch ex2 As Exception
            lc_Transaccion.Rollback()
            Cnn.Close()
            TrataEx(ex2)
            Return False
        End Try
        lc_Transaccion.Commit()
        Cnn.Close()
        Return True
    End Function

    Public Shared Function fn_TraspasosRecibir_Consultar(ByVal Lsv_Datos As cp_Listview, ByVal Clave_SucursalD As String, ByVal Clave_SucursalO As String) As Boolean
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_Conexion(Cnx_Central)
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Mat_Traspasos_GetPendientes", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Clave_SucursalD", SqlDbType.VarChar, Clave_SucursalD)
        Cn_Datos.Crea_Parametro(Cmd, "@Clave_SucursalO", SqlDbType.VarChar, Clave_SucursalO)
        Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "A")

        Try
            Lsv_Datos.Actualizar(Cmd, "Id_MatTraspaso")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_TraspasosRecibir_ConsultarD(ByVal Lsv_Datos As cp_Listview, ByVal Id_MatTraspaso As Integer) As Boolean
        'Mat_TraspasosD_Get
        'Columnas en la Lista: Id_InventarioD, DescripcionD as Material, Cantidad, Id_InventarioO as IDIO
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_Conexion(Cnx_Central)
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Mat_TraspasosD_Get", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_MatTraspaso", SqlDbType.Int, Id_MatTraspaso)

        Try
            Lsv_Datos.Actualizar(Cmd, "Id_InventarioD")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_TraspasosRecibir_Validar(ByVal Id_MatTraspaso As Integer, ByVal Clave_SucursalO As String, ByVal Id_SucursalO As Integer, ByVal Lsv_Datos As cp_Listview, ByRef MensajeRetorno As String) As Boolean
        'Validar las existencias en la Sucursal Origen
        'Columnas en la Lista: Id_InventarioD, DescripcionD as Material, Cantidad, Id_InventarioO as IDIO
        '1.- Traer el Inventario del Tipo=0 de la Sucursal Origen para hacer un ciclo y validar existencias
        Dim Dt_Inventario As DataTable
        Dim Dr_Inventario As DataRow
        Dim cmd As SqlClient.SqlCommand = Crea_Comando("Mat_Inventario_Get", CommandType.StoredProcedure, Crea_Conexion(Cnx_Sucursal))
        Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, Id_SucursalO)
        Crea_Parametro(cmd, "@Tipo", SqlDbType.Int, 4)
        Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "A")
        Dt_Inventario = Cn_Datos.EjecutaConsulta(cmd)
        For Each Elemento As ListViewItem In Lsv_Datos.Items
            For Each Dr_Inventario In Dt_Inventario.Rows
                If Elemento.SubItems(2).Text = Dr_Inventario("Id_Inventario") Then
                    If CDec(Elemento.SubItems(1).Text) > CDec(Dr_Inventario("Existencia")) Then
                        Dt_Inventario.Dispose()
                        MensajeRetorno = "El Inventario General en la Sucursal Origen no cuenta con suficientes existencias."
                        Return False
                    End If
                    Exit For
                End If
            Next
        Next

        '2-.Validamos si en en Inventario destino ya existe los Folio

        Try
            Dim Cnn_Loca As SqlConnection
            Dim Tr_Loca As SqlTransaction
            Cnn_Loca = Crea_ConexionSTD()
            Tr_Loca = crear_Trans(Cnn_Loca)
            Dim Control_Folios As String = "N"
            Dim Interno As String = "S"
            Dim fechaActual As Date = Date.Now

            Dim Cant As Integer = 0

            For Each Elemento As ListViewItem In Lsv_Datos.Items
                If Elemento.SubItems(3).Text = "S" Then
                    'Consultar si los folios capturados no se han vendido ya antes 
                    Dim Dt As DataTable
                    Dim Cantidad As Integer = CDec(Elemento.SubItems(1).Text)
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

                    Dim Folios = Elemento.SubItems(4).Text
                    Dim arrNumeros() As String = Split(Folios, "-")
                    Dim FolioIni As Integer = CInt(arrNumeros(0).Trim)
                    Dim FolioFin As Integer = CInt(arrNumeros(1).Trim)
                    Cant = FolioFin - FolioIni + 1


                    For I As Long = (FolioIni) To FolioFin Step Incremento
                        If I >= FolioIni And I <= FolioFin Then
                            'Validar que los Folios capturados no se hayan asignado ya 
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
                                    Return False
                                    Exit For

                                End If
                            End If

                        End If
                    Next
                End If
            Next
        Catch Err1 As Exception

            MensajeRetorno = "Ocurrió un error al intentar restar el inventario de la Sucursal Origen. " & Err1.Message
            Return False
        End Try

        '2.- Si hay suficientes existencias, debo validarla entrada: Cambiar el Status, Restar en el origen y Sumar en el destino
        '2.1. Restar en el Origen
        Dim Filas_Afectadas As Integer = 0
        Dim Cnn_Local As SqlConnection
        Dim Tr_Local As SqlTransaction
        Cnn_Local = Crea_Conexion(Cnx_Sucursal)
        Tr_Local = crear_Trans(Cnn_Local)
        Try
            For Each Elemento As ListViewItem In Lsv_Datos.Items
                cmd = Crea_ComandoT(Cnn_Local, Tr_Local, CommandType.StoredProcedure, "Mat_Inventario_Restar")
                Crea_Parametro(cmd, "@Id_Inventario", SqlDbType.Int, CDec(Elemento.SubItems(2).Text)) 'Id_InventarioO
                Crea_Parametro(cmd, "@Cantidad", SqlDbType.Int, CDec(Elemento.SubItems(1).Text))
                Filas_Afectadas = EjecutarNonQueryT(cmd)
            Next
            Tr_Local.Commit()
        Catch Err1 As Exception
            Tr_Local.Rollback()
            MensajeRetorno = "Ocurrió un error al intentar restar el inventario de la Sucursal Origen. " & Err1.Message
            Return False
        End Try

        '2.2. Sumar existencias en el Destino

        Try
            Cnn_Local = Crea_ConexionSTD()
            Tr_Local = crear_Trans(Cnn_Local)

            Dim lc_dt As New DataTable
            Dim lc_dr As DataRow
            Dim Cant As Integer = 0
            Dim fechaActual As Date = Date.Now
            Dim Interno As String = "S"
            lc_dt.TableName = "detalle"
            lc_dt.Columns.Add("Id_Inventario")
            lc_dt.Columns.Add("CantidadSurtida")
            lc_dt.Columns.Add("Control_Folios")
            lc_dt.Columns.Add("Folios")

            For Each Elemento As ListViewItem In Lsv_Datos.Items
                cmd = Crea_ComandoT(Cnn_Local, Tr_Local, CommandType.StoredProcedure, "Mat_Inventario_Sumar")
                Crea_Parametro(cmd, "@Id_Inventario", SqlDbType.Int, CDec(Elemento.Tag)) 'Id_InventarioD
                Crea_Parametro(cmd, "@Cantidad", SqlDbType.Int, CDec(Elemento.SubItems(1).Text))

                lc_dr = lc_dt.NewRow
                If Elemento.SubItems(3).Text = "S" Then
                    Dim Folios = Elemento.SubItems(4).Text

                    lc_dr("Id_Inventario") = CDec(Elemento.Tag)
                    lc_dr("CantidadSurtida") = CDec(Elemento.SubItems(1).Text)
                    lc_dr("Control_Folios") = Elemento.SubItems(3).Text
                    lc_dr("Folios") = Elemento.SubItems(4).Text

                    lc_dt.Rows.Add(lc_dr)
                    fn_TraspasoMateriales_Guardar(0, 4, fn_Fecha102(fechaActual.ToString), Interno, lc_dt)
                    Filas_Afectadas = EjecutarNonQueryT(cmd)
                Else
                    Filas_Afectadas = EjecutarNonQueryT(cmd)
                End If
            Next
            'If Elemento.SubItems(3).Text = "S" Then
            'Else
            'fn_TraspasoMateriales_Guardar(0, 4, fn_Fecha102(fechaActual.ToString), Interno, lc_dt, Elemento.SubItems(3).Text)
            'End If
            'Filas_Afectadas = EjecutarNonQueryT(cmd)
            Tr_Local.Commit()
        Catch Err2 As Exception
            Tr_Local.Rollback()
            MensajeRetorno = "Ocurrió un error al intentar restar el inventario de la Sucursal Origen. " & Err2.Message
            Return False
        End Try
        '2.4 Agremos el Folio en tabla remisionesClientes
        '2.3. Actualziar Status
        Cnn_Local = Crea_Conexion(Cnx_Central)
        Try
            cmd = Crea_Comando("Mat_Traspasos_Validar", CommandType.StoredProcedure, Cnn_Local)
            Crea_Parametro(cmd, "@Id_MatTraspaso", SqlDbType.Int, Id_MatTraspaso)
            Crea_Parametro(cmd, "@Usuario_Valida", SqlDbType.Int, UsuarioId)
            Crea_Parametro(cmd, "@Usuario_ValidaN", SqlDbType.VarChar, UsuarioN)
            Crea_Parametro(cmd, "@Estacion_Valida", SqlDbType.VarChar, EstacioN)
            Filas_Afectadas = EjecutarNonQuery(cmd)
        Catch Err2 As Exception
            MensajeRetorno = "Ocurrió un error al validar los folios. " & Err2.Message
            Return False
        End Try
        Cnn_Local.Dispose()
        MensajeRetorno = ""
        Return True
    End Function

    Public Shared Function fn_TraspasosRecibir_Aceptar(ByVal Id_Traspado As Integer) As Boolean

    End Function


#End Region

#Region "Nuevo Juan"

    Public Shared Function fn_UpdateSolicitud_IdMatVenta(Id_Solicitud As Integer, Id_MatVenta As Integer) As Boolean
        Dim cnn As SqlConnection = Crea_ConexionSTD() '23/10/2012
        Try
            Dim cmd As SqlCommand = Crea_Comando("Update_Mat_VentasID", CommandType.StoredProcedure, cnn)
            Crea_Parametro(cmd, "@Id_Solicitud", SqlDbType.Int, Id_Solicitud)
            Crea_Parametro(cmd, "@Id_MatVenta", SqlDbType.Int, Id_MatVenta)
            EjecutarNonQuery(cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_ObtenerFolioCompra(ByVal Id_MatVenta As Integer) As DataTable

        Dim con As SqlConnection = Crea_ConexionSTD()
        Try
            Dim cmd As SqlCommand = Crea_Comando("Get_FoliosCompra", CommandType.StoredProcedure, con)
            Crea_Parametro(cmd, "@Id_MatVenta", SqlDbType.Int, Id_MatVenta)
            'Leer de SQL
            Return EjecutaConsulta(cmd)

        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_ValidarSolicitudesMaterial_LlenarCompra(ByVal Id_Solicitud As Integer) As DataTable

        Dim con As SqlConnection = Crea_ConexionSTD()
        Try
            Dim cmd As SqlCommand = Crea_Comando("Mat_SolicitudesD_Compra", CommandType.StoredProcedure, con)
            Crea_Parametro(cmd, "@Id_Solicitud", SqlDbType.Int, Id_Solicitud)
            'Leer de SQL
            Return EjecutaConsulta(cmd)

        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function
#End Region
#Region "Traspasos"
    Public Shared Function fn_TraspasoMateriales_Guardar(ByVal Id_Cliente As Integer, ByVal Id_Departamento As Integer,
    ByVal Fecha_Entrega As Date, ByVal Interno As String, ByVal dt As DataTable) As Integer

        'Aqui se inserta un nuevo registro
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim lc_Transaccion As SqlClient.SqlTransaction
        Dim Cmd As SqlClient.SqlCommand
        Dim lc_identity As Integer

        lc_Transaccion = Cn_Datos.crear_Trans(Cnn)

        Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Mat_Ventas_Create")

        Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Departamento", SqlDbType.Int, Id_Departamento)
        Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
        Cn_Datos.Crea_Parametro(Cmd, "@Fecha_Entrega", SqlDbType.DateTime, Fecha_Entrega)
        Cn_Datos.Crea_Parametro(Cmd, "@Modo_Captura", SqlDbType.Int, 1)
        Cn_Datos.Crea_Parametro(Cmd, "@Interno", SqlDbType.VarChar, Interno)
        Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "SO")
        Cn_Datos.Crea_Parametro(Cmd, "@Control_Folios", SqlDbType.VarChar, "S")


        Try
            lc_identity = Cn_Datos.EjecutarScalarT(Cmd)

        Catch ex As Exception
            lc_Transaccion.Rollback()
            Cnn.Close()
            TrataEx(ex)
            Return False
        End Try

        Try

            For Each lc_dr As DataRow In dt.Rows

                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Mat_VentasD_Create")

                Cn_Datos.Crea_Parametro(Cmd, "@Id_MatVenta", SqlDbType.Int, lc_identity)
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Inventario", SqlDbType.Int, CInt(lc_dr("Id_Inventario")))
                Cn_Datos.Crea_Parametro(Cmd, "@Cantidad", SqlDbType.Int, CInt(lc_dr("CantidadSurtida")))
                Cn_Datos.Crea_Parametro(Cmd, "@Control_Folios", SqlDbType.VarChar, lc_dr("Control_Folios"))
                Cn_Datos.EjecutarNonQueryT(Cmd)

                'If Control_Folios = "SI" Then
                If (lc_dr("Control_Folios").ToString() = "S") Then


                    ' Si se han agregado Comprobantes de Traslado

                    Dim arrFolios() As String = Split(lc_dr("Folios"), "/")
                    For c As Integer = 0 To arrFolios.Length - 1
                        Dim Cant As Integer = 0
                        Dim arrNumeros() As String = Split(arrFolios(c), "-")
                        Dim FolioIni As Integer = CInt(arrNumeros(0).Trim)
                        Dim FolioFin As Integer = CInt(arrNumeros(1).Trim)
                        Cant = FolioFin - FolioIni + 1

                        Cmd = Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Mat_RemisionesClientes_CreateRotulo")

                        Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
                        Crea_Parametro(Cmd, "@Tipo", SqlDbType.TinyInt, 2)
                        Crea_Parametro(Cmd, "@Id_Entidad", SqlDbType.Int, Id_Departamento)
                        Crea_Parametro(Cmd, "@Id_MatVenta", SqlDbType.Int, lc_identity)
                        Crea_Parametro(Cmd, "@Id_Inventario", SqlDbType.Int, CInt(lc_dr("Id_Inventario")))
                        Crea_Parametro(Cmd, "@Cantidad", SqlDbType.Int, Cant)
                        Crea_Parametro(Cmd, "@Folio_Inicial", SqlDbType.Int, FolioIni)
                        Crea_Parametro(Cmd, "@Folio_Final", SqlDbType.Int, FolioFin)
                        Crea_Parametro(Cmd, "@Rotulado", SqlDbType.VarChar, "S")
                        Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
                        Crea_Parametro(Cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)
                        EjecutarNonQueryT(Cmd)
                    Next

                End If
                'End If


            Next


        Catch ex2 As Exception
            lc_Transaccion.Rollback()
            Cnn.Close()
            TrataEx(ex2)
            Return 0
        End Try
        lc_Transaccion.Commit()
        Cnn.Close()
        Return lc_identity

    End Function



    Public Shared Function fn_ConsultaSolicitudesMaterial_Trasp(ByVal lsv As cp_Listview, ByVal Fecha_Desde As Date, ByVal Fecha_Hasta As Date, ByVal Status As String) As Boolean


        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Mat_Solicitudes_Traspaso_Get", CommandType.StoredProcedure, Crea_Conexion(Cnx_Central))

        Crea_Parametro(Cmd, "@Id_Socursal", SqlDbType.Int, SucursalClave)
        Crea_Parametro(Cmd, "@Fecha_Desde", SqlDbType.Date, Fecha_Desde)
            Crea_Parametro(Cmd, "@Fecha_Hasta", SqlDbType.Date, Fecha_Hasta)
        'Crea_Parametro(cmd, "@Usuario_Solicita", SqlDbType.Int, UsuarioSolicita)
        Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Status)
        'Crea_Parametro(cmd, "@Tipo", SqlDbType.Int, Tipo)

        lsv.Actualizar(Cmd, "Id_Solicitud")
        Cn_Datos.EjecutarNonQuery(Cmd)
        Return True

        Try

        Catch ex As Exception
            TrataEx(ex)

            Return False

        End Try
    End Function
#End Region


End Class
