Imports Sistema.Datos
Imports Sistema.Entidades

Public Class CategoryBusiness
    Private data As CategoryData
    Public Sub New()
        data = New CategoryData
    End Sub
    Public Function List() As DataTable
        Try
            'Dim data As New CategoryData
            Return data.List()
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function Search(value As String) As DataTable
        Try
            'Dim data As New CategoryData
            Return data.Search(value)
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function Insert(entity As Category) As Boolean
        Try
            'Dim data As New CategoryData
            data.Insert(entity)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    Public Function Update(entity As Category) As Boolean
        Try
            'Dim data As New CategoryData
            data.Update(entity)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    Public Function Delete(id As Integer) As Boolean
        Try
            'Dim data As New CategoryData
            data.Delete(id)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    Public Function Disable(id As Integer) As Boolean
        Try
            'Dim data As New CategoryData
            data.Disable(id)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    Public Function Enable(id As Integer) As Boolean
        Try
            'Dim data As New CategoryData
            data.Enable(id)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
End Class
