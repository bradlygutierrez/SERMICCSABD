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

    Public Function recuperarEtapas() As String()
        Dim etapas() As String = Nothing
        Try
            Dim conn As New SqlConnection(strConn)
            Dim tsql As String = "SELECT nombre FROM etapa"
            Dim da As New SqlDataAdapter(tsql, conn)

            Dim dt As New DataTable()
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                etapas = New String(dt.Rows.Count - 1) {}
                For i As Integer = 0 To dt.Rows.Count - 1
                    etapas(i) = dt.Rows(i)("nombre").ToString()
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
            MsgBox("Ocurrió un error al listar los etapas", MsgBoxStyle.Information, "Listar etapas")
        End Try
        Return etapas
    End Function

End Class
