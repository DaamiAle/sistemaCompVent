Imports System.Data.SqlClient

Public Class Connection_2
    Public ConnectionString As SqlConnection
    Public Sub New()
        ConnectionString = New SqlConnection("Data Source=DESKTOP-BTDTIQH;Initial Catalog=systemCurse;Integrated Security=True")
    End Sub
End Class
