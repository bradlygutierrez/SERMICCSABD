Public Class Etapa
    Private _idEtapa As Integer
    Private _idProyecto As Integer
    Private _nombre As String
    Private _numeroEtapa As Integer
    Private _descripcion As String
    Private _presupuesto As Decimal

    Public Sub New()

    End Sub

    Public Sub New(idEtapa As Integer, idProyecto As Integer, nombre As String, numeroEtapa As Integer, descripcion As String, presupuesto As Decimal)
        _idEtapa = idEtapa
        _idProyecto = idProyecto
        _nombre = nombre
        _numeroEtapa = numeroEtapa
        _descripcion = descripcion
        _presupuesto = presupuesto
    End Sub

    Public Property IdEtapa As Integer
        Get
            Return _idEtapa
        End Get
        Set(value As Integer)
            _idEtapa = value
        End Set
    End Property

    Public Property IdProyecto As Integer
        Get
            Return _idProyecto
        End Get
        Set(value As Integer)
            _idProyecto = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property NumeroEtapa As Integer
        Get
            Return _numeroEtapa
        End Get
        Set(value As Integer)
            _numeroEtapa = value
        End Set
    End Property

    Public Property Descripcion As String
        Get
            Return _descripcion
        End Get
        Set(value As String)
            _descripcion = value
        End Set
    End Property

    Public Property Presupuesto As Decimal
        Get
            Return _presupuesto
        End Get
        Set(value As Decimal)
            _presupuesto = value
        End Set
    End Property
End Class
