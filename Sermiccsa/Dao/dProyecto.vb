Imports System.Data.SqlClient
Imports System.ComponentModel
Public Class dProyecto
    Dim strConn As String = My.Settings.sermiccsaConnectionString1.ToString()

    Public Function AgregarProyecto() As Boolean

    End Function
    Public Function eliminarProyecto(Nombre As String) As Boolean
        Dim resp As Boolean = False
        Try
            Dim tSql As String = "delete from dbo.proyecto where nombre = @nombre"
            Dim conn As New SqlConnection(strConn)
            conn.Open()
            Dim cmd As New SqlCommand(tSql, conn)
            cmd.CommandType = CommandType.Text
            cmd.Parameters.AddWithValue("@nombre", Nombre)
            If (cmd.ExecuteNonQuery <> 0) Then
                resp = True
            End If
            conn.Close()
        Catch ex As Exception
            resp = False
        End Try
        Return resp
    End Function
End Class
