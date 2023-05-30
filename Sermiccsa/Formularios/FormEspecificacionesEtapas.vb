Public Class FormEspecificacionesEtapas
    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FormEtapas_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) 

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
End Class