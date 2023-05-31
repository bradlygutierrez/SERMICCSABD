Imports System.Data.SqlClient
Imports System.ComponentModel
Public Class DEtapa
    Dim strConn As String = My.Settings.sermiccsaConnectionString1.ToString()

    Public Function insertarEtapa(ByVal etapa As Etapa) As Boolean
        Dim resultado = False
        Try
            Dim conn As New SqlConnection(strConn)
            Dim tsql As String = "INSERT INTO etapa (id_proyecto, nombre, numero_etapa, descripcion, presupuesto) VALUES (@id_proyecto, @nombre, @numero_etapa, @descripcion, @presupuesto)"
            Dim cmd As New SqlCommand(tsql, conn)
            cmd.Parameters.AddWithValue("@id_proyecto", etapa.IdProyecto)
            cmd.Parameters.AddWithValue("@nombre", etapa.Nombre)
            cmd.Parameters.AddWithValue("@numero_etapa", etapa.NumeroEtapa)
            cmd.Parameters.AddWithValue("@descripcion", etapa.Descripcion)
            cmd.Parameters.AddWithValue("@presupuesto", etapa.Presupuesto)

            conn.Open()
            If (cmd.ExecuteNonQuery() <> 0) Then
                resultado = True
            End If
            conn.Close()

        Catch ex As Exception
            MsgBox("Ocurrio un error al guardar la etapa", MsgBoxStyle.Critical, "ERROR")
        End Try
        Return resultado
    End Function

    Public Function listarEtapas() As DataSet
        Dim ds As New DataSet
        Try
            Dim conn As New SqlConnection(strConn)
            Dim tsql As String = "SELECT id_etapa, nombre FROM dbo.etapa"
            Dim da As New SqlDataAdapter(tsql, conn)

            da.Fill(ds)
        Catch ex As Exception
            MsgBox(ex.ToString())
            MsgBox("Ocurrio un error al listar las etapas", MsgBoxStyle.Information, "Listar etapas")
        End Try
        Return ds
    End Function

End Class
