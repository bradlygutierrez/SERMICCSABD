Imports System.Data.SqlClient

Public Class FormNuevoProyecto
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        Dim selectedDate As DateTime = MonthCalendar1.SelectionRange.Start
        Label7.Text = "Fecha seleccionada: " & selectedDate.ToString("dd/MM/yyyy")

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub FormNuevoProyecto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SermiccsaDataSet.proyecto' table. You can move, or remove it, as needed.
        Me.ProyectoTableAdapter.Fill(Me.SermiccsaDataSet.proyecto)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FormPrincipal.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim selectedDate As DateTime = MonthCalendar1.SelectionRange.Start
        Dim miTabla As DataTable = SermiccsaDataSet.proyecto
        Dim cfilas As DataRowCollection = miTabla.Rows
        Dim nuevaFila As DataRow
        Try

            nuevaFila = miTabla.NewRow()
            nuevaFila(1) = 1
            nuevaFila(2) = TextBox1.Text
            nuevaFila(3) = TextBox4.Text
            nuevaFila(4) = selectedDate.ToString("yyyy-MM-dd")
            nuevaFila(5) = TextBox3.Text
            nuevaFila(6) = Single.Parse(TextBox2.Text)
            cfilas.Add(nuevaFila)

        Catch ex As System.Data.ConstraintException
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cmd As New SqlCommand()
        If Me.Validate Then
            Try
                If (SermiccsaDataSet.HasChanges()) Then
                    Me.ProyectoBindingSource.EndEdit()
                    Me.ProyectoTableAdapter.Update(Me.SermiccsaDataSet.proyecto)
                    MessageBox.Show("Base de datos actualizada")
                End If
            Catch ex As Exception
                MessageBox.Show("Error: " + ex.Message)
            End Try

        Else
            MessageBox.Show(Me, "Errores de validacion.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class