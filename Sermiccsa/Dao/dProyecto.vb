Imports System.Data.SqlClient
Imports System.ComponentModel
Public Class DProyecto
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

    Public Function BuscarProyecto(ByVal nombre As String) As DataSet
        Dim proyecto As New Proyecto
        Dim ds As New DataSet

        nombre = nombre + "%"
        Try
            Dim conn As New SqlConnection(strConn)
            Dim tSql As String = "select *  from proyecto  where nombre like @nombre"
            Dim da As New SqlDataAdapter(tSql, conn)
            da.SelectCommand.Parameters.AddWithValue("@nombre", nombre)
            da.Fill(ds)
        Catch ex As Exception
            MsgBox("Ha ocurrido un error al obtener los registros " & ex.Message,
                      MsgBoxStyle.Critical, "ERROR")
        End Try
        Return ds

    End Function

    Public Function MostrarRegistros() As DataSet
        Dim ds As New DataSet
        Try
            Dim conn As New SqlConnection(strConn)
            Dim tSql As String = "Select * from proyecto"
            Dim da As New SqlDataAdapter(tSql, conn)
            da.Fill(ds)
        Catch ex As Exception
            MsgBox("Ha ocurrido un error al obtener los registros " & ex.Message,
                   MsgBoxStyle.Critical, "ERROR")
        End Try
        Return ds
    End Function
End Class
