Imports System.Data.SqlClient
Imports System.Runtime.InteropServices.WindowsRuntime
Public Class DGasto

    Dim strConexion = My.Settings.sermiccsaConnectionString.ToString()

    Public Function insertarGasto(ByVal gasto As Gasto) As Boolean
        Dim resultado = False
        Try
            Dim conn As New SqlConnection(strConexion)
            Dim tsql As String = "INSERT INTO gasto (nombre, descripcion, id_etapa, id_rubro, id_beneficiario, id_factura) VALUES (@nombre, @descripcion, @id_etapa, @id_rubro, @id_beneficiario, @id_factura)"
            Dim cmd As New SqlCommand(tsql, conn)
            cmd.Parameters.AddWithValue("@nombre", gasto.Nombre)
            cmd.Parameters.AddWithValue("@descripcion", gasto.Descripcion)
            cmd.Parameters.AddWithValue("@id_etapa", gasto.IdEtapa)
            cmd.Parameters.AddWithValue("@id_rubro", gasto.IdRubro)
            cmd.Parameters.AddWithValue("@id_beneficiario", gasto.IdBeneficiario)
            cmd.Parameters.AddWithValue("@id_factura", gasto.IdFactura)

            conn.Open()
            If (cmd.ExecuteNonQuery() <> 0) Then
                resultado = True
            End If
            conn.Close()

        Catch ex As Exception
            MsgBox("Ocurrio un error al guardar el gasto", MsgBoxStyle.Critical, "ERROR")
        End Try
        Return resultado
    End Function

End Class
