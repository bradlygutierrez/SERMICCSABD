Imports System.Data.SqlClient

Public Class DUsuario

    Dim strConexion = My.Settings.sermiccsaConnectionString.ToString()

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
            Dim tsql As String = "update usuario set nombre = @nombre, correo = @correo, clave = @clave, id_pregunta = @id_pregunta, respuesta = @respuesta where id_usuario = @id_usuario"
            Dim cmd As New SqlCommand(tsql, conn)
            cmd.Parameters.AddWithValue("@nombre", usuario.IdUsuario)
            cmd.Parameters.AddWithValue("@correo", usuario.Correo)
            cmd.Parameters.AddWithValue("@clave", usuario.Clave)
            cmd.Parameters.AddWithValue("@id_pregunta", usuario.IdPregunta)
            cmd.Parameters.AddWithValue("@respuesta", usuario.respuesta)

            If cmd.ExecuteNonQuery() <> 0 Then
                b = True
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox("Ocurrio un error al actualizar el usuario", MsgBoxStyle.Critical, "Error")
        End Try
        Return b
    End Function

End Class
