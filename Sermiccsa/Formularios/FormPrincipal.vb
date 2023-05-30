Imports System.Data.SqlClient
Imports System.Collections
Public Class FormPrincipal
    Inherits Form

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

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

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        FormAjustes.Show()
        Me.Hide()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

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
        Dim dProyecto As New dProyecto()

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

    Private Sub BeneficiarioLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Presupuesto_inicialTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.ProyectoTableAdapter.FillBy(Me.SermiccsaDataSet.proyecto)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillByToolStrip_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick_2(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub FillBy1ToolStripButton_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub DataGridView1_CellContentClick_3(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex Then
            Dim idProyecto As Integer = e.RowIndex + 1
            MessageBox.Show("Botón presionado en la con el id de proyecto: " & idProyecto.ToString())

        End If
    End Sub

    Private Sub FillBy2ToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.ProyectoTableAdapter.FillBy2(Me.SermiccsaDataSet.proyecto)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class

