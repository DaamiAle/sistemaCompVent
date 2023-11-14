Public Class Article
#Region "Fields"
    Private _idArticle As Integer
    Private _idCategory As Integer
    Private _code As String
    Private _name As String
    Private _price As Decimal
    Private _stock As Integer
    Private _image As String
    Private _description As String
    Private _state As Boolean
#End Region

#Region "Properties"
    Public Property IdArticle As Integer
        Get
            Return _idArticle
        End Get
        Set(value As Integer)
            _idArticle = value
        End Set
    End Property

    Public Property IdCategory As Integer
        Get
            Return _idCategory
        End Get
        Set(value As Integer)
            _idCategory = value
        End Set
    End Property

    Public Property Code As String
        Get
            Return _code
        End Get
        Set(value As String)
            _code = value
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

    Public Property Price As Decimal
        Get
            Return _price
        End Get
        Set(value As Decimal)
            _price = value
        End Set
    End Property

    Public Property Stock As Integer
        Get
            Return _stock
        End Get
        Set(value As Integer)
            _stock = value
        End Set
    End Property

    Public Property Image As String
        Get
            Return _image
        End Get
        Set(value As String)
            _image = value
        End Set
    End Property

    Public Property Description As String
        Get
            Return _description
        End Get
        Set(value As String)
            _description = value
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
