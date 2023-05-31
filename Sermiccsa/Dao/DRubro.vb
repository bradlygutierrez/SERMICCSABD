Imports System.Data.SqlClient
Imports System.ComponentModel
Public Class DRubro
    Dim strConn As String = My.Settings.sermiccsaConnectionString1.ToString()

    Public Function listarRubros() As DataSet
        Dim ds As New DataSet
        Try
            Dim conn As New SqlConnection(strConn)
            Dim tsql As String = "SELECT id_rubro, nombre FROM dbo.rubro"
            Dim da As New SqlDataAdapter(tsql, conn)

            da.Fill(ds)
        Catch ex As Exception
            MsgBox(ex.ToString())
            MsgBox("Ocurrio un error al listar los rubros", MsgBoxStyle.Information, "Listar rubros")
        End Try
        Return ds
    End Function

End Class
