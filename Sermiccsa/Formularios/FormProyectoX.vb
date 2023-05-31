Public Class FormProyectoX

    Private Sub FormProyectoX_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cambiarLabelSaldo()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormAgregarEtapa.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FormGasto.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FormReportes.Show()
    End Sub

    Private Sub btEditarBeneficiario_Click(sender As Object, e As EventArgs) Handles btEditarBeneficiario.Click
        FormBeneficiario.Show()
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        FormPrincipal.Show()
        Me.Hide()
    End Sub

    Private Sub cambiarLabelSaldo()
        Dim saldoRestante As Single = FormPrincipal.devolverPresupuestoInicial() - 2
        Label1.Text = ("$" & saldoRestante.ToString())
    End Sub

    Private Sub cambiarLabelGastos()
        Dim gastosTotales As Single
    End Sub

End Class