Public Class FormGasto
    Dim DEtapa As New DEtapa
    Dim DBeneficiario As New DBeneficiario
    Dim DRubro As New DRubro
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SermiccsaDataSet.etapa' table. You can move, or remove it, as needed.
        Me.EtapaTableAdapter.Fill(Me.SermiccsaDataSet.etapa)
        'TODO: This line of code loads data into the 'SermiccsaDataSet.rubro' table. You can move, or remove it, as needed.
        Me.RubroTableAdapter.Fill(Me.SermiccsaDataSet.rubro)
        'TODO: This line of code loads data into the 'SermiccsaDataSet.beneficiario' table. You can move, or remove it, as needed.
        Me.BeneficiarioTableAdapter.Fill(Me.SermiccsaDataSet.beneficiario)
        Me.GastoTableAdapter.Fill(Me.SermiccsaDataSet.gasto)
        Me.FacturaTableAdapter.Fill(Me.SermiccsaDataSet.factura)

        ' Cargando datos
        GastoBindingSource.Position = 0
        FacturaBindingSource1.Position = 0
        MostrarPosicion()
        llenarComboEtapas()
        llenarComboRubro()
        llenarComboBeneficiario()

    End Sub
    Public Sub MostrarPosicion()
        Dim iTotal As Integer = GastoBindingSource.Count
        Dim iTotalFactura As Integer = FacturaBindingSource1.Count
        Dim iPosFactura As Integer
        Dim iPos As Integer = 1

        If iTotal = 0 And iTotalFactura = 0 Then
            Label12.Text = "No. de registros"

        Else
            iPos = iPos + GastoBindingSource.Position
            iPosFactura = FacturaBindingSource1.Position
            Label12.Text = iPos.ToString & " de " & iTotal.ToString()
            cbBeneficiario.SelectedValue = GastoBindingSource.Position
            cbEtapa.SelectedValue = GastoBindingSource.Position
            cbRubro.SelectedValue = GastoBindingSource.Position
        End If

        If FacturaBindingSource1.Position = 0 And FacturaBindingSource1.Position = 0 Then
            cbBeneficiario.SelectedValue = GastoBindingSource.Position + 1
            cbEtapa.SelectedValue = GastoBindingSource.Position + 1
            cbRubro.SelectedValue = GastoBindingSource.Position + 1
        End If

    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        FormProyectoX.Show()
        Me.Close()
    End Sub

    Private Sub MonthCalendar1_DateChanged_1(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        Dim selectedDate As DateTime = MonthCalendar1.SelectionRange.Start
        Label6.Text = "Fecha seleccionada: " & selectedDate.ToString("dd/MM/yyyy")

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        GastoBindingSource.Position = GastoBindingSource.Position - 1
        FacturaBindingSource1.Position = GastoBindingSource.Position - 1
        MostrarPosicion()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        GastoBindingSource.Position = GastoBindingSource.Position + 1
        FacturaBindingSource1.Position = FacturaBindingSource1.Position + 1
        MostrarPosicion()
    End Sub

    Private Sub llenarComboEtapas()
        Dim ds = DEtapa.listarEtapas()
        cbEtapa.Items.Clear()
        cbEtapa.DataSource = ds.Tables(0)
        cbEtapa.DisplayMember = "nombre"
        cbEtapa.ValueMember = "id_etapa"
        cbEtapa.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub llenarComboRubro()
        Dim ds = DRubro.listarRubros()
        cbRubro.Items.Clear()
        cbRubro.DataSource = ds.Tables(0)
        cbRubro.DisplayMember = "nombre"
        cbRubro.ValueMember = "id_rubro"
        cbRubro.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub llenarComboBeneficiario()
        Dim ds = DBeneficiario.listarBeneficiarios()
        cbBeneficiario.Items.Clear()
        cbBeneficiario.DataSource = ds.Tables(0)
        cbBeneficiario.DisplayMember = "nombre"
        cbBeneficiario.ValueMember = "id_beneficiario"
        cbBeneficiario.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub btAgregar_Click(sender As Object, e As EventArgs) Handles btAgregar.Click

        ' Primero se registra la factura
        Dim factura As New Factura()
        Dim dfactura As New DFactura
        Dim selectedDate As DateTime = MonthCalendar1.SelectionRange.Start

        factura.FechaPago = selectedDate.ToString("dd/MM/yyyy")
        factura.Referencia = tbReferencia.Text
        factura.Subtotal = tbSubtotal.Text

        If Decimal.Parse(tbSubtotal.Text) > 1000 Then
            factura.CantidadIR = Decimal.Parse(tbSubtotal.Text) * 0.02
        Else
            factura.CantidadIR = 0
        End If

        factura.Iva = Decimal.Parse(tbSubtotal.Text) * 0.15

        dfactura.insertarFactura(factura)

        ' Recuperando el idFactura registrado
        Dim ds = dfactura.listarFacturas()
        Dim facturas As Integer = ds.Tables(0).Rows.Count
        Dim ultimoElemento As String = ds.Tables(0).Rows(facturas - 1)(ds.Tables(0).Columns.Count - 1).ToString()
        Dim facturaRegistradaString As String = ultimoElemento

        ' Luego se registra el gasto
        Dim gasto As New Gasto()
        Dim dgasto As New DGasto

        gasto.Nombre = tbNombreGasto.Text
        gasto.Descripcion = tbDescripcion.Text
        gasto.IdEtapa = cbEtapa.SelectedValue
        gasto.IdRubro = cbRubro.SelectedValue
        gasto.IdBeneficiario = cbBeneficiario.SelectedValue
        gasto.IdFactura = facturaRegistradaString

        If Not dgasto.insertarGasto(gasto) Then
            MsgBox("Error al guardar el gasto", MsgBoxStyle.Critical, "Nuevo gasto")
            Exit Sub
        End If
        MsgBox("Gasto guardada correctamente", MsgBoxStyle.Information, "Nuevo gasto")

    End Sub

    Private Sub btEditar_Click(sender As Object, e As EventArgs) Handles btEditar.Click
        Dim factura As New Factura()
        Dim dfactura As New DFactura
        Dim selectedDate As DateTime = MonthCalendar1.SelectionRange.Start

        ' Recupera el idFactura
        Dim idFactura = dfactura.obtenerIdFactura(tbReferencia.Text)

        ' Edita la factura
        factura.IdFactura = idFactura
        factura.FechaPago = selectedDate.ToString("dd/MM/yyyy")
        factura.Referencia = tbReferencia.Text
        factura.Subtotal = tbSubtotal.Text
        If Decimal.Parse(tbSubtotal.Text) > 1000 Then
            factura.CantidadIR = Decimal.Parse(tbSubtotal.Text) * 0.02
        Else
            factura.CantidadIR = 0
        End If
        factura.Iva = Decimal.Parse(tbSubtotal.Text) * 0.15

        dfactura.editarFactura(factura)

        ' Recupera el idGasto
        Dim dgasto As New DGasto
        Dim idGasto = dgasto.obtenerIdGasto(tbNombreGasto.Text)

        ' Encuentra el gasto a editar
        Dim gasto As New Gasto()

        gasto.IdGasto = idGasto
        gasto.Nombre = tbNombreGasto.Text
        gasto.Descripcion = tbDescripcion.Text
        gasto.IdEtapa = cbEtapa.SelectedValue
        gasto.IdRubro = cbRubro.SelectedValue
        gasto.IdBeneficiario = cbBeneficiario.SelectedValue
        gasto.IdFactura = idFactura

        If Not dgasto.editarGasto(gasto) Then
            MsgBox("Error al editar el gasto", MsgBoxStyle.Critical, "Editar gasto")
            Exit Sub
        End If
        MsgBox("Gasto editado correctamente", MsgBoxStyle.Information, "Editar gasto")

    End Sub

    Private Sub btEliminar_Click(sender As Object, e As EventArgs) Handles btEliminar.Click
        Dim factura As New Factura()
        Dim dfactura As New DFactura
        Dim selectedDate As DateTime = MonthCalendar1.SelectionRange.Start

        ' Recupera el idGasto
        Dim dgasto As New DGasto
        Dim idGasto = dgasto.obtenerIdGasto(tbNombreGasto.Text)

        ' Recupera el idFactura
        Dim idFactura = dfactura.obtenerIdFactura(tbReferencia.Text)

        ' Se elimina el gasto
        dgasto.eliminarGasto(idGasto)

        ' Elimina la factura
        If Not dfactura.eliminarFactura(idFactura) Then
            MsgBox("Error al eliminar el gasto", MsgBoxStyle.Critical, "Eliminar gasto")
            Exit Sub
        End If
        MsgBox("Gasto eliminado correctamente", MsgBoxStyle.Information, "Eliminar gasto")
    End Sub
End Class