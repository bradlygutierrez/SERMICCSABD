Public Class FormReportes
    Private Sub btnVolver_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub FormReportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SermiccsaDataSet.factura' table. You can move, or remove it, as needed.
        Me.FacturaTableAdapter.Fill(Me.SermiccsaDataSet.factura)
        'TODO: This line of code loads data into the 'SermiccsaDataSet.gasto' table. You can move, or remove it, as needed.
        Me.GastoTableAdapter.Fill(Me.SermiccsaDataSet.gasto)

        Me.ReportViewer1.RefreshReport
    End Sub
End Class