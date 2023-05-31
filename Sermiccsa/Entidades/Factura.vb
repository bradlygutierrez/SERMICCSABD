Public Class Factura
    Private _idFactura As Integer
    Private _fechaPago As Date
    Private _referencia As String
    Private _subtotal As Decimal
    Private _cantidadIR As Decimal
    Private _iva As Integer

    Public Sub New()

    End Sub

    Public Sub New(idFactura As Integer, fechaPago As Date, referencia As String, subtotal As Decimal, cantidadIR As Decimal, iva As Integer)
        _idFactura = idFactura
        _fechaPago = fechaPago
        _referencia = referencia
        _subtotal = subtotal
        _cantidadIR = cantidadIR
        _iva = iva
    End Sub

    Public Property IdFactura As Integer
        Get
            Return _idFactura
        End Get
        Set(value As Integer)
            _idFactura = value
        End Set
    End Property

    Public Property FechaPago As Date
        Get
            Return _fechaPago
        End Get
        Set(value As Date)
            _fechaPago = value
        End Set
    End Property

    Public Property Referencia As String
        Get
            Return _referencia
        End Get
        Set(value As String)
            _referencia = value
        End Set
    End Property

    Public Property Subtotal As Decimal
        Get
            Return _subtotal
        End Get
        Set(value As Decimal)
            _subtotal = value
        End Set
    End Property

    Public Property CantidadIR As Decimal
        Get
            Return _cantidadIR
        End Get
        Set(value As Decimal)
            _cantidadIR = value
        End Set
    End Property

    Public Property Iva As Integer
        Get
            Return _iva
        End Get
        Set(value As Integer)
            _iva = value
        End Set
    End Property

End Class