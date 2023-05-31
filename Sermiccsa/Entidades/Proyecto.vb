Public Class Proyecto

    Private _idProyecto As Integer
    Private _idUsuario As Integer
    Private _nombre As String
    Private _descripcion As String
    Private _fechaInicio As DateTime
    Private _beneficiario As String
    Private _presupuestoInicial As Decimal


    Public Sub New()
    End Sub


    Public Sub New(idProyecto As Integer, idUsuario As Integer, nombre As String, descripcion As String, fechaInicio As DateTime, beneficiario As String, presupuestoInicial As Decimal)
        _idProyecto = idProyecto
        _idUsuario = idUsuario
        _nombre = nombre
        _descripcion = descripcion
        _fechaInicio = fechaInicio
        _beneficiario = beneficiario
        _presupuestoInicial = presupuestoInicial
    End Sub


    Public Property IdProyecto As Integer
        Get
            Return _idProyecto
        End Get
        Set(value As Integer)
            _idProyecto = value
        End Set
    End Property

    Public Property IdUsuario As Integer
        Get
            Return _idUsuario
        End Get
        Set(value As Integer)
            _idUsuario = value
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

    Public Property Descripcion As String
        Get
            Return _descripcion
        End Get
        Set(value As String)
            _descripcion = value
        End Set
    End Property

    Public Property FechaInicio As DateTime
        Get
            Return _fechaInicio
        End Get
        Set(value As DateTime)
            _fechaInicio = value
        End Set
    End Property

    Public Property Beneficiario As String
        Get
            Return _beneficiario
        End Get
        Set(value As String)
            _beneficiario = value
        End Set
    End Property

    Public Property PresupuestoInicial As Decimal
        Get
            Return _presupuestoInicial
        End Get
        Set(value As Decimal)
            _presupuestoInicial = value
        End Set
    End Property
End Class