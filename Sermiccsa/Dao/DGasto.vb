Imports System.Data.SqlClient
Imports System.Runtime.InteropServices.WindowsRuntime
Public Class DGasto

    Dim strConexion = My.Settings.sermiccsaConnectionString1.ToString()

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

    Public Function listarGastos() As DataSet
        Dim ds As New DataSet
        Try
            Dim conn As New SqlConnection(strConexion)
            Dim tsql As String = "SELECT id_gasto, nombre FROM dbo.gasto"
            Dim da As New SqlDataAdapter(tsql, conn)

            da.Fill(ds)
        Catch ex As Exception
            MsgBox(ex.ToString())
            MsgBox("Ocurrio un error al listar los gastos", MsgBoxStyle.Information, "Listar gastos")
        End Try
        Return ds
    End Function

    Public Function editarGasto(ByVal gasto As Gasto) As Boolean
        Dim b = False
        Try
            Dim conn As New SqlConnection(strConexion)
            Dim tsql As String = "update gasto set nombre = @nombre, descripcion = @descripcion, id_etapa = @id_etapa, id_rubro = @id_rubro, id_beneficiario = @id_beneficiario, id_factura = @id_factura where id_gasto = @id_gasto"
            Dim cmd As New SqlCommand(tsql, conn)
            cmd.Parameters.AddWithValue("@nombre", gasto.Nombre)
            cmd.Parameters.AddWithValue("@descripcion", gasto.Descripcion)
            cmd.Parameters.AddWithValue("@id_etapa", gasto.IdEtapa)
            cmd.Parameters.AddWithValue("@id_rubro", gasto.IdRubro)
            cmd.Parameters.AddWithValue("@id_beneficiario", gasto.IdBeneficiario)
            cmd.Parameters.AddWithValue("@id_factura", gasto.IdFactura)
            cmd.Parameters.AddWithValue("@id_gasto", gasto.IdGasto)

            conn.Open()
            If cmd.ExecuteNonQuery() <> 0 Then
                b = True
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox("Ocurrio un error al actualizar el gasto", MsgBoxStyle.Critical, "Error")
        End Try
        Return b
    End Function

End Class
