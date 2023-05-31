Imports System.Data.SqlClient

Public Class FormAjustes

    Private Sub FormAjustes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        FormPrincipal.Show()
        Me.Close()
    End Sub

    Private Sub btCambiarContrasena_Click(sender As Object, e As EventArgs) Handles btCambiarContrasena.Click
        Dim miTabla As DataTable = SermiccsaDataSet.usuario
        Dim cfilas As DataRowCollection = miTabla.Rows
        Dim filaUsuarioActual As DataRow = miTabla.Rows(0)
        Console.WriteLine(filaUsuarioActual)
        Try
            filaUsuarioActual(4) = tbNuevaContrasena.Text
        Catch ex As System.Data.ConstraintException
            MessageBox.Show(ex.Message)
        End Try

        Dim cmd As New SqlCommand()
        If Me.Validate Then
            Try
                If (SermiccsaDataSet.HasChanges()) Then
                    Me.UsuarioBindingSource.EndEdit()
                    Me.UsuarioTableAdapter.Update(Me.SermiccsaDataSet.usuario)
                    MessageBox.Show("Etapa Agregada!!!")
                End If
            Catch ex As Exception
                MessageBox.Show("Error: " + ex.Message)
            End Try

        Else
            MessageBox.Show(Me, "Errores de validacion.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        FormProyectoX.Show()
        Me.Hide()
    End Sub
End Class