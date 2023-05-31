
Public Class FormAgregarEtapa
    Private Sub FormAgregarEtapa_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btAgregarEtapa_Click(sender As Object, e As EventArgs) Handles btAgregarEtapa.Click
        Dim etapa As New Etapa()
        etapa.IdProyecto = 1
        etapa.Nombre = tbNombreEtapa.Text
        etapa.NumeroEtapa = tbNumeroEtapa.Text
        etapa.Descripcion = tbDescripcion.Text
        etapa.Presupuesto = tbPresupuesto.Text

        Dim dEtapa As New DEtapa
        If Not dEtapa.insertarEtapa(etapa) Then
            MsgBox("Error al guardar la etapa", MsgBoxStyle.Critical, "Nuevo etapa")
            Exit Sub
        End If
        MsgBox("Estudio guardado correctamente", MsgBoxStyle.Information, "Nuevo etapa")
    End Sub
End Class