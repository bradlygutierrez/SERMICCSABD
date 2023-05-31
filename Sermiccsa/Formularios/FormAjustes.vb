Imports System.Data.SqlClient

Public Class FormAjustes
    Dim dUsuario As New DUsuario
    Dim usuario As New Usuario

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        FormPrincipal.Show()
        Me.Close()
    End Sub

    Private Sub btCambiarContrasena_Click(sender As Object, e As EventArgs) Handles btCambiarContrasena.Click

        Dim claveOp As String = ""
        usuario.IdUsuario = 3 'RECUPERA EL ID BRADLY

        ' Valida campos vacios
        If tbNuevaContrasena.Text = "" Or tbContrasenaActual.Text = "" Or tbConfirmarContrasena.Text = "" Then
            MsgBox("Ingrese todos los datos", MsgBoxStyle.Critical, "Editar Contrasena")
            Exit Sub
        End If


        ' Verifica si las contrasenas coinciden
        If tbNuevaContrasena.Text <> tbConfirmarContrasena.Text Then
            MsgBox("Las contrasenas no coinciden", MsgBoxStyle.Critical, "Editar Contrasena")
            Exit Sub
        End If

        ' Verifica si la contrasena actual es correcta
        usuario.Clave = tbContrasenaActual.Text
        claveOp = dUsuario.obtenerContrasenaActual(usuario.IdUsuario)
        If claveOp <> tbContrasenaActual.Text Then
            MsgBox("La contrasena actual es incorrecta", MsgBoxStyle.Critical, "Editar Contrasena")
            Exit Sub
        End If

        usuario.Clave = tbNuevaContrasena.Text
        If Not dUsuario.ajustesContrasena(usuario) Then
            MsgBox("Error al actualizar la contrasena desde ajustes", MsgBoxStyle.Critical, "Editar Contrasena")
            Exit Sub
        End If
        MsgBox("Contrasena actualizada correctamente", MsgBoxStyle.Information, "Editar contrasena")
    End Sub

    Private Sub btnCambiarUsuario_Click(sender As Object, e As EventArgs) Handles btnCambiarUsuario.Click
        usuario.Nombre = tbNuevoUsuario.Text
        usuario.IdUsuario = 3 'RECUPERA EL ID BRADLY

        ' Valida campos vacios
        If tbNuevoUsuario.Text = "" Then
            MsgBox("Ingrese el usuario nuevo", MsgBoxStyle.Critical, "Editar Contrasena")
            Exit Sub
        End If

        ' Verifica que el nombre de usuario no esta ocupado
        Dim dUsuario As New DUsuario()
        Dim usuarios() As String = dUsuario.recuperarUsuarios()

        For Each usuario As String In usuarios
            If tbNuevoUsuario.Text = usuario Then
                MsgBox("El usuario ya esta ocupado", MsgBoxStyle.Critical, "Editar Contrasena")
                Exit Sub
            End If
        Next

        If Not dUsuario.ajustesUsuario(usuario) Then
            MsgBox("Error al actualizar el nombre de usuario desde ajustes", MsgBoxStyle.Critical, "Editar Usuario")
            Exit Sub
        End If
        MsgBox("Contrasena actualizada correctamente", MsgBoxStyle.Information, "Editar Usuario")
    End Sub
End Class