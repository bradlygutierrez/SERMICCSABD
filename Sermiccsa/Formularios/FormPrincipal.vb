Imports System.Data.SqlClient
Imports System.Collections
Public Class FormPrincipal
    Inherits Form

    Private Sub FormPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.ProyectoTableAdapter.FillBy1(Me.SermiccsaDataSet.proyecto)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
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

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        FormAjustes.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        FormReportes.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormNuevoProyecto.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Dim nombre As String = DataGridView1.SelectedCells(1).Value
        Dim dProyecto As New DProyecto()

        Dim resp As VariantType
        resp = MessageBox.Show("¿Estás seguro de que deseas eliminar este objeto?", "Confirmación de eliminación", MessageBoxButtons.YesNo)
        If (resp = vbYes) Then
            Dim Eliminado = dProyecto.eliminarProyecto(nombre)
            If (Eliminado) Then
                MsgBox("Registro eliminado exitosamente",
                       MsgBoxStyle.Information, "Proyectos")
            Else
                MsgBox("No se pudo eliminar el registro",
                   MsgBoxStyle.Critical, "ERROR")
            End If
        Else
            MsgBox("Operacion cancelada",
            MsgBoxStyle.Information, "Proyecto")
        End If

        Me.ProyectoTableAdapter.FillBy1(Me.SermiccsaDataSet.proyecto)

    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.ProyectoTableAdapter.FillBy(Me.SermiccsaDataSet.proyecto)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub DataGridView1_CellContentClick_3(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex Then
            Dim idProyecto As Integer = DataGridView1.SelectedCells(0).Value
            MessageBox.Show("Botón presionado en la con el id de proyecto: " & idProyecto.ToString())
            FormProyectoX.Show()
            Me.Hide()
        End If
    End Sub

    Function devolverID() As Integer
        Dim idProyecto As Integer
        idProyecto = DataGridView1.SelectedCells(0).Value
        Return idProyecto
    End Function

    Function devolverPresupuestoInicial() As Single
        Dim presupuestoInicial As Object
        presupuestoInicial = DataGridView1.SelectedCells(6).Value
        Return Single.Parse(presupuestoInicial)
    End Function

    Private Sub FillBy2ToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.ProyectoTableAdapter.FillBy2(Me.SermiccsaDataSet.proyecto)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim dao As New DProyecto
        DataGridView1.DataSource = dao.BuscarProyecto(TextBox1.Text.Trim).Tables(0)
        DataGridView1.Refresh()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim dao As New DProyecto
        DataGridView1.DataSource = dao.MostrarRegistros().Tables(0)
        DataGridView1.Refresh()
    End Sub
End Class

