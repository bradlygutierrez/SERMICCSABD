Imports System.Data.SqlClient

Public Class DPregunta

    Dim strConexion = My.Settings.sermiccsaConnectionString1.ToString()

    Public Function listarPreguntas() As DataSet
        Dim ds As New DataSet
        Try
            Dim conn As New SqlConnection(strConexion)
            Dim tsql As String = "SELECT id_pregunta, pregunta FROM dbo.pregunta"
            Dim da As New SqlDataAdapter(tsql, conn)

            da.Fill(ds)
        Catch ex As Exception
            MsgBox(ex.ToString())
            MsgBox("Ocurrio un error al listar las preguntas", MsgBoxStyle.Information, "Listar preguntas")
        End Try
        Return ds
    End Function

End Class
