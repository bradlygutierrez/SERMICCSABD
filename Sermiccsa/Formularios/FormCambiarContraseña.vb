Public Class FormCambiarContraseña

    Dim dUsuario As New DUsuario
    Dim usuario As New Usuario

    Private Sub BtCambiarPw_Click(sender As Object, e As EventArgs) Handles btCambiarContrasena.Click

        If tbNuevaContraseña.Text <> tbConfirmarContraseña.Text Then
            MsgBox("Las contrasenas no coinciden", MsgBoxStyle.Critical, "Editar Contrasena")
            Exit Sub
        End If

        usuario.respuesta = tbRespuesta.Text
        usuario.Nombre = tbUsuario.Text
        usuario.Clave = tbNuevaContraseña.Text

        If Not dUsuario.actualizarContrasena(usuario) Then
            MsgBox("Error al actualizar la contrasena", MsgBoxStyle.Critical, "Editar Contrasena")
            Exit Sub
        End If
        MsgBox("Contrasena actualizada correctamente", MsgBoxStyle.Information, "Editar contrasena")
    End Sub

    Private Sub FormCambiarContraseña_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim p As New Drawing2D.GraphicsPath()
        Dim borderRadius As Integer = 20

        p.StartFigure()
        p.AddArc(New Rectangle(0, 0, borderRadius, borderRadius), 180, 90)
        p.AddLine(borderRadius, 0, btCambiarContrasena.Width - borderRadius, 0)
        p.AddArc(New Rectangle(btCambiarContrasena.Width - borderRadius, 0, borderRadius, borderRadius), -90, 90)
        p.AddLine(btCambiarContrasena.Width, borderRadius, btCambiarContrasena.Width, btCambiarContrasena.Height - borderRadius)
        p.AddArc(New Rectangle(btCambiarContrasena.Width - borderRadius, btCambiarContrasena.Height - borderRadius, borderRadius, borderRadius), 0, 90)
        p.AddLine(btCambiarContrasena.Width - borderRadius, btCambiarContrasena.Height, borderRadius, btCambiarContrasena.Height)
        p.AddArc(New Rectangle(0, btCambiarContrasena.Height - borderRadius, borderRadius, borderRadius), 90, 90)
        p.CloseFigure()

        btCambiarContrasena.Region = New Region(p)
        btCambiarContrasena.BackColor = Color.FromArgb(105, 174, 105)
    End Sub

End Class