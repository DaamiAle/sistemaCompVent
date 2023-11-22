Public Class User
#Region "Attributes"

    Private _idUser As Integer
    Private _idRole As Integer
    Private _name As String
    Private _documentType As String
    Private _documentNumber As String
    Private _address As String
    Private _phone As String
    Private _email As String
    Private _password As String
    Private _state As Boolean


#End Region
#Region "Properties"

    Public Property IdUser As Integer
        Get
            Return _idUser
        End Get
        Set(value As Integer)
            _idUser = value
        End Set
    End Property

    Public Property IdRole As Integer
        Get
            Return _idRole
        End Get
        Set(value As Integer)
            _idRole = value
        End Set
    End Property

    Public Property Name As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property

    Public Property DocumentType As String
        Get
            Return _documentType
        End Get
        Set(value As String)
            _documentType = value
        End Set
    End Property

    Public Property DocumentNumber As String
        Get
            Return _documentNumber
        End Get
        Set(value As String)
            _documentNumber = value
        End Set
    End Property

    Public Property Address As String
        Get
            Return _address
        End Get
        Set(value As String)
            _address = value
        End Set
    End Property

    Public Property Phone As String
        Get
            Return _phone
        End Get
        Set(value As String)
            _phone = value
        End Set
    End Property

    Public Property Email As String
        Get
            Return _email
        End Get
        Set(value As String)
            _email = value
        End Set
    End Property

    Public Property Password As String
        Get
            Return _password
        End Get
        Set(value As String)
            _password = value
        End Set
    End Property

    Public Property State As Boolean
        Get
            Return _state
        End Get
        Set(value As Boolean)
            _state = value
        End Set
    End Property


#End Region
End Class
