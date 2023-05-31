Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports Sermiccsa.sermiccsaDataSetTableAdapters

Public Class FormAgregarCuenta

    Dim usuario As New Usuario
    Dim dPregunta As New DPregunta

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

    Private Sub FormAgregarCuenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SermiccsaDataSet.pregunta' Puede moverla o quitarla según sea necesario.
        Me.PreguntaTableAdapter.Fill(Me.SermiccsaDataSet.pregunta)
        'TODO: esta línea de código carga datos en la tabla 'SermiccsaDataSet.usuario' Puede moverla o quitarla según sea necesario.
        Me.UsuarioTableAdapter.Fill(Me.SermiccsaDataSet.usuario)
        Dim p As New Drawing2D.GraphicsPath()
        Dim borderRadius As Integer = 20

        p.StartFigure()
        p.AddArc(New Rectangle(0, 0, borderRadius, borderRadius), 180, 90)
        p.AddLine(borderRadius, 0, btRegistrarUsuario.Width - borderRadius, 0)
        p.AddArc(New Rectangle(btRegistrarUsuario.Width - borderRadius, 0, borderRadius, borderRadius), -90, 90)
        p.AddLine(btRegistrarUsuario.Width, borderRadius, btRegistrarUsuario.Width, btRegistrarUsuario.Height - borderRadius)
        p.AddArc(New Rectangle(btRegistrarUsuario.Width - borderRadius, btRegistrarUsuario.Height - borderRadius, borderRadius, borderRadius), 0, 90)
        p.AddLine(btRegistrarUsuario.Width - borderRadius, btRegistrarUsuario.Height, borderRadius, btRegistrarUsuario.Height)
        p.AddArc(New Rectangle(0, btRegistrarUsuario.Height - borderRadius, borderRadius, borderRadius), 90, 90)
        p.CloseFigure()

        btRegistrarUsuario.Region = New Region(p)
        btRegistrarUsuario.BackColor = Color.FromArgb(105, 174, 105)
        llenarComboPreguntas()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FormIniciarSesion.Show()
        Me.Close()
    End Sub

    Private Sub llenarComboPreguntas()

        Dim ds = dPregunta.listarPreguntas()
        cbPregunta.Items.Clear()

        cbPregunta.DataSource = ds.Tables(0)
        cbPregunta.DisplayMember = "Pregunta"
        cbPregunta.ValueMember = "id_pregunta"

        cbPregunta.DropDownStyle = ComboBoxStyle.DropDownList

    End Sub

    Private Sub btRegistrarUsuario_Click(sender As Object, e As EventArgs) Handles btRegistrarUsuario.Click

        Dim usuario As New Usuario()
        usuario.Nombre = tbUsuario.Text
        usuario.Correo = tbCorreo.Text
        usuario.Clave = tbContrasena.Text
        usuario.IdPregunta = cbPregunta.SelectedValue
        usuario.respuesta = tbRespuesta.Text

        Dim dUsuario As New DUsuario
        If Not dUsuario.insertarUsuario(usuario) Then
            MsgBox("Error al guardar el usuario", MsgBoxStyle.Critical, "Nuevo Usuario")
            Exit Sub
        End If
        MsgBox("Estudio guardado correctamente", MsgBoxStyle.Information, "Nuevo Usuario")
        FormIniciarSesion.Show()
        Me.Close()
    End Sub
End Class