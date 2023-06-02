Imports System.Data.SqlClient
Imports System.Runtime.InteropServices.WindowsRuntime
Public Class DFactura
    Dim strConexion = My.Settings.sermiccsaConnectionString1.ToString()

    Public Function insertarFactura(ByVal factura As Factura) As Boolean
        Dim resultado = False
        Try
            Dim conn As New SqlConnection(strConexion)
            Dim tsql As String = "INSERT INTO factura (fecha_pago, referencia, subtotal, cantidad_ir, iva) VALUES (@fecha_pago, @referencia, @subtotal, @cantidad_ir, @iva)"
            Dim cmd As New SqlCommand(tsql, conn)
            cmd.Parameters.AddWithValue("@fecha_pago", factura.FechaPago)
            cmd.Parameters.AddWithValue("@referencia", factura.Referencia)
            cmd.Parameters.AddWithValue("@subtotal", factura.Subtotal)
            cmd.Parameters.AddWithValue("@cantidad_ir", factura.CantidadIR)
            cmd.Parameters.AddWithValue("@iva", factura.Iva)

            conn.Open()
            If (cmd.ExecuteNonQuery() <> 0) Then
                resultado = True
            End If
            conn.Close()

        Catch ex As Exception
            MsgBox("Ocurrio un error al guardar la factura", MsgBoxStyle.Critical, "ERROR")
        End Try
        Return resultado
    End Function

    Public Function listarFacturas() As DataSet
        Dim ds As New DataSet
        Try
            Dim conn As New SqlConnection(strConexion)
            Dim tsql As String = "SELECT id_factura, referencia FROM dbo.factura"
            Dim da As New SqlDataAdapter(tsql, conn)

            da.Fill(ds)
        Catch ex As Exception
            MsgBox(ex.ToString())
            MsgBox("Ocurrio un error al listar las facturas", MsgBoxStyle.Information, "Listar facturas")
        End Try
        Return ds
    End Function

    Public Function editarFactura(ByVal factura As Factura) As Boolean
        Dim b = False
        Try
            Dim conn As New SqlConnection(strConexion)
            Dim tsql As String = "update factura set fecha_pago = @fecha_pago, referencia = @referencia, subtotal = @subtotal, cantidad_ir = @cantidad_ir, iva =@iva where id_factura = @id_factura"
            Dim cmd As New SqlCommand(tsql, conn)
            cmd.Parameters.AddWithValue("@fecha_pago", factura.FechaPago)
            cmd.Parameters.AddWithValue("@referencia", factura.Referencia)
            cmd.Parameters.AddWithValue("@subtotal", factura.Subtotal)
            cmd.Parameters.AddWithValue("@cantidad_ir", factura.CantidadIR)
            cmd.Parameters.AddWithValue("@iva", factura.Iva)
            cmd.Parameters.AddWithValue("@id_factura", factura.IdFactura)

            conn.Open()
            If cmd.ExecuteNonQuery() <> 0 Then
                b = True
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox("Ocurrio un error al actualizar la factura", MsgBoxStyle.Critical, "Error")
        End Try
        Return b
    End Function

End Class
