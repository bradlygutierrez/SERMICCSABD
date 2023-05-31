Public Class FormGasto
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles lblFecha.Click

    End Sub

    Private Sub labelContador_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblNombreGasto.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SermiccsaDataSet.etapa' table. You can move, or remove it, as needed.
        Me.EtapaTableAdapter.Fill(Me.SermiccsaDataSet.etapa)
        'TODO: This line of code loads data into the 'SermiccsaDataSet.rubro' table. You can move, or remove it, as needed.
        Me.RubroTableAdapter.Fill(Me.SermiccsaDataSet.rubro)
        'TODO: This line of code loads data into the 'SermiccsaDataSet.beneficiario' table. You can move, or remove it, as needed.
        Me.BeneficiarioTableAdapter.Fill(Me.SermiccsaDataSet.beneficiario)
        Me.GastoTableAdapter.Fill(Me.SermiccsaDataSet.gasto)
        Me.FacturaTableAdapter.Fill(Me.SermiccsaDataSet.factura)
        Dim iva As Boolean = Boolean.Parse(tbIVA.Text)
        Dim subtotal As Single = Single.Parse(tbSubtotal.Text)
        MostrarPosicion()
        mostarTotal(iva, subtotal)

    End Sub
    Public Sub MostrarPosicion()
        Dim iTotal As Integer = GastoBindingSource.Count
        Dim iTotalFactura As Integer = FacturaBindingSource1.Count
        Dim iPosFactura As Integer
        Dim iPos As Integer
        If iTotal = 0 And iTotalFactura = 0 Then
            Label12.Text = "No. de registros"
        Else
            iPos = GastoBindingSource.Position + 1
            iPosFactura = FacturaBindingSource1.Position + 1
            Label12.Text = iPos.ToString & "de" & iTotal.ToString()
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        FormProyectoX.Show()
        Me.Close()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs)

    End Sub

    Private Sub MonthCalendar1_DateChanged_1(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        Dim selectedDate As DateTime = MonthCalendar1.SelectionRange.Start
        Label6.Text = "Fecha seleccionada: " & selectedDate.ToString("dd/MM/yyyy")

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        GastoBindingSource.Position = -1
        FacturaBindingSource1.Position = -1
        Dim iva As Boolean = Boolean.Parse(tbIVA.Text)
        Dim subtotal As Single = Single.Parse(tbSubtotal.Text)
        MostrarPosicion()
        mostarTotal(iva, subtotal)
    End Sub

    Private Sub mostarTotal(ByVal iva As Boolean, ByVal subtotal As Single)
        Dim total As Integer
        If iva = True Then
            total = subtotal
            total = total * 1.15
            tbTotal.Text = total.ToString
        Else
            total = Integer.Parse(tbSubtotal.Text)
            tbTotal.Text = subtotal.ToString

        End If
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        GastoBindingSource.Position = +1
        FacturaBindingSource1.Position = +1
        MostrarPosicion()
        Dim iva As Boolean = Boolean.Parse(tbIVA.Text)
        Dim subtotal As Single = Single.Parse(tbSubtotal.Text)
        MostrarPosicion()
        mostarTotal(iva, subtotal)
    End Sub


End Class