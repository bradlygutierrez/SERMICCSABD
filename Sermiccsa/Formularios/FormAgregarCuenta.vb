Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class FormAgregarCuenta

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim miTabla As DataTable = SermiccsaDataSet.usuario
        Dim cfilas As DataRowCollection = miTabla.Rows
        Dim nuevaFila As DataRow
        Try

            nuevaFila = miTabla.NewRow()
            nuevaFila(1) = tbUsuario.Text
            nuevaFila(2) = tbCorreo.Text
            nuevaFila(3) = tbContrasena.Text
            nuevaFila(4) = 1
            nuevaFila(5) = tbRespuesta.Text
            cfilas.Add(nuevaFila)

        Catch ex As System.Data.ConstraintException
            MessageBox.Show(ex.Message)
        End Try

        Dim cmd As New SqlCommand()
        If Me.Validate Then
            Try
                If (SermiccsaDataSet.HasChanges()) Then
                    Me.UsuarioBindingSource.EndEdit()
                    Me.UsuarioTableAdapter.Update(Me.SermiccsaDataSet.usuario)
                    MessageBox.Show("Base de datos actualizada")
                End If
            Catch ex As Exception
                MessageBox.Show("Error: " + ex.Message)
            End Try

        Else
            MessageBox.Show(Me, "Errores de validacion.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        FormIniciarSesion.Show()
        Me.Hide()
    End Sub

    Private Sub FormAgregarCuenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SermiccsaDataSet.pregunta' Puede moverla o quitarla según sea necesario.
        Me.PreguntaTableAdapter.Fill(Me.SermiccsaDataSet.pregunta)
        'TODO: esta línea de código carga datos en la tabla 'SermiccsaDataSet.usuario' Puede moverla o quitarla según sea necesario.
        Me.UsuarioTableAdapter.Fill(Me.SermiccsaDataSet.usuario)
        Dim p As New Drawing2D.GraphicsPath()
        Dim borderRadius As Integer = 20

        p.StartFigure()
        p.AddArc(New Rectangle(0, 0, borderRadius, borderRadius), 180, 90)
        p.AddLine(borderRadius, 0, Button1.Width - borderRadius, 0)
        p.AddArc(New Rectangle(Button1.Width - borderRadius, 0, borderRadius, borderRadius), -90, 90)
        p.AddLine(Button1.Width, borderRadius, Button1.Width, Button1.Height - borderRadius)
        p.AddArc(New Rectangle(Button1.Width - borderRadius, Button1.Height - borderRadius, borderRadius, borderRadius), 0, 90)
        p.AddLine(Button1.Width - borderRadius, Button1.Height, borderRadius, Button1.Height)
        p.AddArc(New Rectangle(0, Button1.Height - borderRadius, borderRadius, borderRadius), 90, 90)
        p.CloseFigure()

        Button1.Region = New Region(p)
        Button1.BackColor = Color.FromArgb(105, 174, 105)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FormIniciarSesion.Show()
        Me.Close()
    End Sub
End Class