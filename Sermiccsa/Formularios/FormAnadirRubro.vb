Public Class FormAnadirRubro
    Private Sub FormAniadirRubro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SermiccsaDataSet.rubro' Puede moverla o quitarla según sea necesario.
        Me.RubroTableAdapter.Fill(Me.SermiccsaDataSet.rubro)

    End Sub
End Class