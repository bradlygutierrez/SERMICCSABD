Imports System.Data.SqlClient
Imports System.ComponentModel
Public Class DBeneficiario
    Dim strConn As String = My.Settings.sermiccsaConnectionString1.ToString()

    Public Function insertarBeneficiario(ByVal beneficiario As Beneficiario) As Boolean
        Dim resultado = False
        Try
            Dim conn As New SqlConnection(strConn)
            Dim tsql As String = "INSERT INTO beneficiario (nombre, identificacion) VALUES (@nombre, @identificacion)"
            Dim cmd As New SqlCommand(tsql, conn)
            cmd.Parameters.AddWithValue("@nombre", beneficiario.Nombre)
            cmd.Parameters.AddWithValue("@identificacion", beneficiario.Identificacion)

            conn.Open()
            If (cmd.ExecuteNonQuery() <> 0) Then
                resultado = True
            End If
            conn.Close()

        Catch ex As Exception
            MsgBox("Ocurrio un error al guardar el beneficiario", MsgBoxStyle.Critical, "ERROR")
        End Try
        Return resultado
    End Function

    Public Function actualizarBeneficiario(ByVal beneficiario As Beneficiario) As Boolean
        Dim b = False
        Try
            Dim conn As New SqlConnection(strConn)
            Dim tsql As String = "update beneficiario set nombre = @nombre, identificacion = @identificacion where id_beneficiario = @id_beneficiario"
            Dim cmd As New SqlCommand(tsql, conn)
            cmd.Parameters.AddWithValue("@nombre", beneficiario.Nombre)
            cmd.Parameters.AddWithValue("@identificacion", beneficiario.Identificacion)
            cmd.Parameters.AddWithValue("@id_beneficiario", beneficiario.Id_beneficiario)

            conn.Open()
            If cmd.ExecuteNonQuery() <> 0 Then
                b = True
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox("Ocurrio un error al actualizar el beneficiario", MsgBoxStyle.Critical, "Error")
        End Try
        Return b
    End Function

    Public Function listarBeneficiarios() As DataSet
        Dim ds As New DataSet
        Try
            Dim conn As New SqlConnection(strConn)
            Dim tsql As String = "SELECT id_beneficiario, nombre FROM dbo.beneficiario"
            Dim da As New SqlDataAdapter(tsql, conn)

            da.Fill(ds)
        Catch ex As Exception
            MsgBox(ex.ToString())
            MsgBox("Ocurrio un error al listar los beneficiarios", MsgBoxStyle.Information, "Listar beneficiarios")
        End Try
        Return ds
    End Function

End Class
