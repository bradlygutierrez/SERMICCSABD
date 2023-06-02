Imports System.Data.SqlClient
Imports System.Runtime.InteropServices.WindowsRuntime

Public Class DUsuario

    Dim strConexion = My.Settings.sermiccsaConnectionString1.ToString()

    Public Function insertarUsuario(ByVal usuario As Usuario) As Boolean
        Dim resultado = False
        Try
            Dim conn As New SqlConnection(strConexion)
            Dim tsql As String = "INSERT INTO usuario (nombre, correo, clave, id_pregunta, respuesta) VALUES (@nombre, @correo, @clave, @id_pregunta, @respuesta)"
            Dim cmd As New SqlCommand(tsql, conn)
            cmd.Parameters.AddWithValue("@nombre", usuario.Nombre)
            cmd.Parameters.AddWithValue("@correo", usuario.Correo)
            cmd.Parameters.AddWithValue("@clave", usuario.Clave)
            cmd.Parameters.AddWithValue("@id_pregunta", usuario.IdPregunta)
            cmd.Parameters.AddWithValue("@respuesta", usuario.respuesta)

            conn.Open()
            If (cmd.ExecuteNonQuery() <> 0) Then
                resultado = True
            End If
            conn.Close()

        Catch ex As Exception
            MsgBox("Ocurrio un error al guardar el registro", MsgBoxStyle.Critical, "ERROR")
        End Try
        Return resultado
    End Function

    Public Function listarUsuarios() As DataSet
        Dim ds As New DataSet
        Try
            Dim conn As New SqlConnection(strConexion)
            Dim tsql As String = "SELECT id_usuario, nombre, correo, clave, id_pregunta, respuesta FROM dbo.usuario"
            Dim da As New SqlDataAdapter(tsql, conn)

            da.Fill(ds)
        Catch ex As Exception
            MsgBox(ex.ToString())
            MsgBox("Ocurrio un error al listar los usuarios", MsgBoxStyle.Information, "Listar usuarios")
        End Try
        Return ds
    End Function

    Public Function actualizarContrasena(ByVal usuario As Usuario) As Boolean
        Dim b = False
        Try
            Dim conn As New SqlConnection(strConexion)
            Dim tsql As String = "update usuario set clave = @clave where nombre = @nombre and respuesta = @respuesta"
            Dim cmd As New SqlCommand(tsql, conn)
            cmd.Parameters.AddWithValue("@clave", usuario.Clave)
            cmd.Parameters.AddWithValue("@nombre", usuario.Nombre)
            cmd.Parameters.AddWithValue("@respuesta", usuario.respuesta)

            conn.Open()
            If cmd.ExecuteNonQuery() <> 0 Then
                b = True
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox("Ocurrio un error al actualizar el usuario", MsgBoxStyle.Critical, "Error")
        End Try
        Return b
    End Function

    Public Function ajustesContrasena(ByVal usuario As Usuario) As Boolean
        Dim b = False
        Try
            Dim conn As New SqlConnection(strConexion)
            Dim tsql As String = "update usuario set clave = @clave where id_usuario = @id_usuario"
            Dim cmd As New SqlCommand(tsql, conn)
            cmd.Parameters.AddWithValue("@clave", usuario.Clave)
            cmd.Parameters.AddWithValue("@id_usuario", usuario.IdUsuario)

            conn.Open()
            If cmd.ExecuteNonQuery() <> 0 Then
                b = True
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox("Ocurrio un error al actualizar la contrasena desde ajustes", MsgBoxStyle.Critical, "Error")
        End Try
        Return b
    End Function

    Public Function obtenerContrasenaActual(ByVal id_usuario As String) As String
        Try
            Dim usuario As New Usuario()
            Dim ds As New DataTable
            Dim conn As New SqlConnection(strConexion)
            Dim tsql As String = "select * from usuario where id_usuario = @id_usuario"
            Dim da As New SqlDataAdapter(tsql, conn)
            Dim claveRecuperada As String = ""

            da.SelectCommand.Parameters.AddWithValue("@id_usuario", id_usuario)
            da.Fill(ds)
            usuario.Clave = ds.Rows(0).Item("clave")
            claveRecuperada = usuario.Clave
            Return claveRecuperada

        Catch ex As Exception
            MsgBox("Ocurrio un error la clave actual del usuario", MsgBoxStyle.Information, "Ajustes")
        End Try
    End Function

    Public Function ajustesUsuario(ByVal usuario As Usuario) As Boolean
        Dim b = False
        Try
            Dim conn As New SqlConnection(strConexion)
            Dim tsql As String = "update usuario set nombre = @nombre where id_usuario = @id_usuario"
            Dim cmd As New SqlCommand(tsql, conn)
            cmd.Parameters.AddWithValue("@nombre", usuario.Nombre)
            cmd.Parameters.AddWithValue("@id_usuario", usuario.IdUsuario)

            conn.Open()
            If cmd.ExecuteNonQuery() <> 0 Then
                b = True
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox("Ocurrio un error al actualizar el nombre de usuario desde ajustes", MsgBoxStyle.Critical, "Error")
        End Try
        Return b
    End Function

    Public Function recuperarUsuarios() As String()
        Dim usuarios() As String = Nothing
        Try
            Dim conn As New SqlConnection(strConexion)
            Dim tsql As String = "SELECT nombre FROM usuario"
            Dim da As New SqlDataAdapter(tsql, conn)

            Dim dt As New DataTable()
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                usuarios = New String(dt.Rows.Count - 1) {}
                For i As Integer = 0 To dt.Rows.Count - 1
                    usuarios(i) = dt.Rows(i)("nombre").ToString()
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
            MsgBox("Ocurrió un error al listar los usuarios", MsgBoxStyle.Information, "Listar usuarios")
        End Try
        Return usuarios
    End Function

    Public Function VerificarCredenciales(ByVal nombreUsuario As String, ByVal clave As String) As Boolean
        Dim existeUsuario As Boolean = False
        Try
            Dim conn As New SqlConnection(strConexion)
            Dim tsql As String = "SELECT COUNT(*) FROM usuario WHERE nombre = @nombre AND clave = @clave"
            Dim cmd As New SqlCommand(tsql, conn)
            cmd.Parameters.AddWithValue("@nombre", nombreUsuario)
            cmd.Parameters.AddWithValue("@clave", clave)

            conn.Open()
            Dim resultado As Integer = CInt(cmd.ExecuteScalar())
            If resultado > 0 Then
                existeUsuario = True
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
            MsgBox("Ocurrió un error al verificar las credenciales", MsgBoxStyle.Critical, "Verificar Credenciales")
        End Try

        Return existeUsuario
    End Function

    Function devolverID(Nombre As String)
        Dim strConn As String = My.Settings.sermiccsaConnectionString1.ToString()
        Dim connectionString As String = "Data Source=nombreServidor;Initial Catalog=nombreBaseDeDatos;Integrated Security=True"
        Dim query As String = "SELECT id_usuario FROM usuario WHERE nombre = @Nombre"
        Dim conn As New SqlConnection(strConn)
        Using command As New SqlCommand(query, conn)
            command.Parameters.AddWithValue("@Nombre", Nombre)

            conn.Open()
            Dim id As Object = command.ExecuteScalar()
            conn.Close()

            If id IsNot Nothing AndAlso Not DBNull.Value.Equals(id) Then
                Return CInt(id)
            Else
                Return -1 ' Si no se encuentra el ID, puedes retornar un valor específico indicando que no se encontró.
            End If
        End Using

    End Function
End Class
