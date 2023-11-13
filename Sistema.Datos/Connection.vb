Imports System.Data.SqlClient

Public Class Connection
    Private _base As String
    Private _server As String
    Private _user As String
    Private _password As String
    Private _security As Boolean = True
    Public sqlConnect As SqlConnection
    Public Property Base As String
        Get
            Return _base
        End Get
        Set(value As String)
            _base = value
        End Set
    End Property
    Public Property Server As String
        Get
            Return _server
        End Get
        Set(value As String)
            _server = value
        End Set
    End Property
    Public Property User As String
        Get
            Return _user
        End Get
        Set(value As String)
            _user = value
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
    Public Property Security As Boolean
        Get
            Return _security
        End Get
        Set(value As Boolean)
            _security = value
        End Set
    End Property

    Public Sub New()
        Base = "systemCurse"
        Server = "DESKTOP-BTDTIQH"
        User = ""
        Password = ""
        sqlConnect = New SqlConnection(CreateConnectionString)
    End Sub

    Public Function CreateConnectionString() As String
        Dim stringCon As String
        stringCon = "Server=" & Server & ";Database=" & Base & ";"
        If Security Then
            stringCon &= "Integrated Security=SSPI;"
        Else
            stringCon &= "User Id=" & User & ";Password=" & Password & ";"
        End If
        Return stringCon
    End Function
End Class
