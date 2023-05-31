Public Class FormAnadirRubro
    Private Sub FormAniadirRubro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SermiccsaDataSet.rubro' Puede moverla o quitarla según sea necesario.
        Me.RubroTableAdapter.Fill(Me.SermiccsaDataSet.rubro)
        MostrarPosicion()
    End Sub

    Public Sub MostrarPosicion()
        Dim iTotal As Integer = RubroBindingSource.Count
        Dim iPos As Integer
        If iTotal = 0 Then
            labelContador.Text = "No. de Registros"
        Else
            iPos = RubroBindingSource.Position + 1
            labelContador.Text = iPos.ToString & " de " & iTotal.ToString
        End If
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        RubroBindingSource.Position += 1
        MostrarPosicion()
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        RubroBindingSource.Position -= 1
        MostrarPosicion()
    End Sub
End Class