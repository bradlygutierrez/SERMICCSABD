Public Class FormBeneficiario
    Dim beneficiario As New Beneficiario()
    Dim dbeneficiario As New DBeneficiario()

    Private Sub FormBeneficiario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BeneficiarioTableAdapter.Fill(Me.SermiccsaDataSet.beneficiario)
        MostrarPosicion()
    End Sub

    Public Sub MostrarPosicion()
        Dim iTotal As Integer = BeneficiarioBindingSource.Count
        Dim iPos As Integer
        If iTotal = 0 Then
            labelContador.Text = "No. de Registros"
        Else
            iPos = BeneficiarioBindingSource.Position + 1
            labelContador.Text = iPos.ToString & " de " & iTotal.ToString
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        beneficiario.Nombre = tbNombre.Text
        beneficiario.Identificacion = tbIdentificacion.Text

        Dim dBeneficiario As New DBeneficiario
        If Not dBeneficiario.insertarBeneficiario(beneficiario) Then
            MsgBox("Error al guardar el beneficiario", MsgBoxStyle.Critical, "Nuevo Beneficiario")
            Exit Sub
        End If
        MsgBox("Beneficiario guardado correctamente", MsgBoxStyle.Information, "Nuevo Beneficiario")
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        BeneficiarioBindingSource.Position += 1
        MostrarPosicion()
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        BeneficiarioBindingSource.Position -= 1
        MostrarPosicion()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click

        ' Valida campos vacios
        If tbIdBeneficiario.Text = "" Or tbIdentificacion.Text = "" Or tbNombre.Text = "" Then
            MsgBox("Ingrese todos los datos", MsgBoxStyle.Critical, "Form Beneficiario")
            Exit Sub
        End If



        beneficiario.Id_beneficiario = tbIdBeneficiario.Text
        beneficiario.Nombre = tbNombre.Text
        beneficiario.Identificacion = tbIdentificacion.Text

        If Not dbeneficiario.actualizarBeneficiario(beneficiario) Then
            MsgBox("Error al actualizar el beneficiario", MsgBoxStyle.Critical, "Editar Beneficiario")
            Exit Sub
        End If
        MsgBox("Beneficiario actualizado correctamente", MsgBoxStyle.Information, "Editar Beneficiario")
    End Sub

End Class