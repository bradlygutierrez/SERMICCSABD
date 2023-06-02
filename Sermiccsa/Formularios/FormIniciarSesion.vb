Public Class FormIniciarSesion

    Dim dUsuario As New DUsuario
    Dim usuario As New Usuario

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        FormAgregarCuenta.Show()
    End Sub

    Private Sub FormIniciarSesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim p As New Drawing2D.GraphicsPath()
        Dim borderRadius As Integer = 20

        p.StartFigure()
        p.AddArc(New Rectangle(0, 0, borderRadius, borderRadius), 180, 90)
        p.AddLine(borderRadius, 0, btIniciarSesion.Width - borderRadius, 0)
        p.AddArc(New Rectangle(btIniciarSesion.Width - borderRadius, 0, borderRadius, borderRadius), -90, 90)
        p.AddLine(btIniciarSesion.Width, borderRadius, btIniciarSesion.Width, btIniciarSesion.Height - borderRadius)
        p.AddArc(New Rectangle(btIniciarSesion.Width - borderRadius, btIniciarSesion.Height - borderRadius, borderRadius, borderRadius), 0, 90)
        p.AddLine(btIniciarSesion.Width - borderRadius, btIniciarSesion.Height, borderRadius, btIniciarSesion.Height)
        p.AddArc(New Rectangle(0, btIniciarSesion.Height - borderRadius, borderRadius, borderRadius), 90, 90)
        p.CloseFigure()

        btIniciarSesion.Region = New Region(p)
        btIniciarSesion.BackColor = Color.FromArgb(105, 174, 105)
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        Dim p As New Drawing2D.GraphicsPath()
        Dim borderRadius As Integer = 45

        p.StartFigure()
        p.AddArc(New Rectangle(0, 0, borderRadius, borderRadius), 180, 90)
        p.AddLine(borderRadius, 0, Panel1.Width - borderRadius, 0)
        p.AddArc(New Rectangle(Panel1.Width - borderRadius, 0, borderRadius, borderRadius), -90, 90)
        p.AddLine(Panel1.Width, borderRadius, Panel1.Width, Panel1.Height - borderRadius)
        p.AddArc(New Rectangle(Panel1.Width - borderRadius, Panel1.Height - borderRadius, borderRadius, borderRadius), 0, 90)
        p.AddLine(Panel1.Width - borderRadius, Panel1.Height, borderRadius, Panel1.Height)
        p.AddArc(New Rectangle(0, Panel1.Height - borderRadius, borderRadius, borderRadius), 90, 90)
        p.CloseFigure()

        Panel1.Region = New Region(p)
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        FormCambiarContraseña.Show()
    End Sub

    Private Sub lbSalir_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbSalir.LinkClicked
        Me.Close()
    End Sub

    Private Sub btIniciarSesion_Click(sender As Object, e As EventArgs) Handles btIniciarSesion.Click

        ' Valida campos vacios
        If tbUsuario.Text = "" Or tbContrasena.Text = "" Then
            MsgBox("Ingrese todos los datos", MsgBoxStyle.Critical, "Iniciar Session")
            Exit Sub
        End If

        usuario.Nombre = tbUsuario.Text
        usuario.Clave = tbContrasena.Text

        Dim resultado As Boolean = dUsuario.VerificarCredenciales(usuario.Nombre, usuario.Clave)
        If resultado = False Then
            MsgBox("No fue posible validar estas credenciales", MsgBoxStyle.Critical, "Inicar Sesion")
            Exit Sub
        End If
        MsgBox("Crendeciales acceptadas", MsgBoxStyle.Information, "Iniciar Sesion")
        Me.Hide()
        FormPrincipal.Show()
    End Sub

    Function DevolverNombreDeUsuario() As String
        Dim nombre As String = tbUsuario.Text
        Return nombre
    End Function
End Class