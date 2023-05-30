Public Class FormCambiarContraseña
    Private Sub TbRespuesta_TextChanged(sender As Object, e As EventArgs) Handles TbRespuesta.TextChanged

    End Sub

    Private Sub BtCambiarPw_Click(sender As Object, e As EventArgs) Handles BtCambiarPw.Click
        Me.Close()
    End Sub

    Private Sub FormCambiarContraseña_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim p As New Drawing2D.GraphicsPath()
        Dim borderRadius As Integer = 20

        p.StartFigure()
        p.AddArc(New Rectangle(0, 0, borderRadius, borderRadius), 180, 90)
        p.AddLine(borderRadius, 0, BtCambiarPw.Width - borderRadius, 0)
        p.AddArc(New Rectangle(BtCambiarPw.Width - borderRadius, 0, borderRadius, borderRadius), -90, 90)
        p.AddLine(BtCambiarPw.Width, borderRadius, BtCambiarPw.Width, BtCambiarPw.Height - borderRadius)
        p.AddArc(New Rectangle(BtCambiarPw.Width - borderRadius, BtCambiarPw.Height - borderRadius, borderRadius, borderRadius), 0, 90)
        p.AddLine(BtCambiarPw.Width - borderRadius, BtCambiarPw.Height, borderRadius, BtCambiarPw.Height)
        p.AddArc(New Rectangle(0, BtCambiarPw.Height - borderRadius, borderRadius, borderRadius), 90, 90)
        p.CloseFigure()

        BtCambiarPw.Region = New Region(p)
        BtCambiarPw.BackColor = Color.FromArgb(105, 174, 105)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        FormIniciarSesion.Show()
        Me.Close()
    End Sub
End Class