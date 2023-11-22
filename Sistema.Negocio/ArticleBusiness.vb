Imports Sistema.Datos
Imports Sistema.Entidades

Public Class ArticleBusiness
    Private data As ArticleData
    Public Sub New()
        data = New ArticleData
    End Sub
    Public Function List() As DataTable
        Try
            Return data.List()
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GetById(value As Integer) As Article
        Try
            Dim result As DataTable
            result = data.GetById(value)
            Dim entity As New Article
            entity.IdArticle = result.Rows(0)("id")
            entity.IdCategory = result.Rows(0)("idcategory")
            entity.Code = result.Rows(0)("code")
            entity.Name = result.Rows(0)("name")
            entity.Price = result.Rows(0)("price")
            entity.Stock = result.Rows(0)("stock")
            entity.Description = result.Rows(0)("description")
            entity.Image = result.Rows(0)("image")
            entity.State = result.Rows(0)("state")
            Return entity
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function Search(value As String) As DataTable
        Try
            Return data.Search(value)
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function Insert(entity As Article) As Boolean
        Try
            data.Insert(entity)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    Public Function Update(entity As Article) As Boolean
        Try
            data.Update(entity)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    Public Function Delete(id As Integer) As Boolean
        Try
            data.Delete(id)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    Public Function Disable(id As Integer) As Boolean
        Try
            data.Disable(id)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function Enable(id As Integer) As Boolean
        Try
            data.Enable(id)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

End Class
