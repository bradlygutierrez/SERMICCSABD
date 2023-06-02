
Public Class FormAgregarEtapa
    Private Sub FormAgregarEtapa_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btAgregarEtapa_Click(sender As Object, e As EventArgs) Handles btAgregarEtapa.Click

        ' Valida campos vacios
        If tbDescripcion.Text = "" Or tbNombreEtapa.Text = "" Or tbNumeroEtapa.Text = "" Or tbPresupuesto.Text = "" Then
            MsgBox("Ingrese todos los datos", MsgBoxStyle.Critical, "Agregar Etapa")
            Exit Sub
        End If

        ' Validan campos numericos
        If Integer.Parse(tbNumeroEtapa.Text) <= 0 Or Integer.Parse(tbPresupuesto.Text) <= 0 Then
            MsgBox("Los campos numericos no son validos", MsgBoxStyle.Critical, "Agregar Etapa")
            Exit Sub
        End If

        ' Valida si la etapa ya existe
        Dim dEtapa2 As New DEtapa()
        Dim etapas() As String = dEtapa2.recuperarEtapas()

        For Each etapaT As String In etapas
            If tbNombreEtapa.Text = etapaT Then
                MsgBox("La etapa ya esta registrada", MsgBoxStyle.Critical, "Agregar Etapa")
                Exit Sub
            End If
        Next

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