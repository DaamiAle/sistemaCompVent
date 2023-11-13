Public Class Category
#Region "Fields"
    Private _idCategory As Integer
    Private _name As String
    Private _description As String
    Private _state As Boolean

#End Region
#Region "Properties"
    Public Property IdCategory As Integer
        Get
            Return _idCategory
        End Get
        Set(value As Integer)
            _idCategory = value
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
