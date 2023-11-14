Imports Sistema.Entidades
Imports System.Data.SqlClient

Public Class ArticleData
    Inherits Connection_v2
    'Stored Procedures y nombre de los parametro que pide:
    'article_list
    'article_search (name)
    'article_insert (idcategory, code, name, price, stock, description, image)
    'article_update (idarticle, idcategory, code, name, price, stock, description, image)
    'article_delete (idarticle)
    'article_disable (idarticle)
    'article_enable (idarticle)

    Public Function List() As DataTable
        Try
            Dim result As SqlDataReader
            Dim table As New DataTable
            Dim command As New SqlCommand("article_list", ConnectionString)
            command.CommandType = CommandType.StoredProcedure
            ConnectionString.Open()
            result = command.ExecuteReader()
            table.Load(result)
            ConnectionString.Close()
            Return table
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Search(value As String) As DataTable
        Try
            Dim result As SqlDataReader
            Dim table As New DataTable
            Dim command As New SqlCommand("article_search", ConnectionString)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@name", value)
            ConnectionString.Open()
            result = command.ExecuteReader()
            table.Load(result)
            ConnectionString.Close()
            Return table
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub Insert(entity As Article)
        Try
            Dim command As New SqlCommand("article_insert", ConnectionString)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@idcategory", entity.IdCategory)
            command.Parameters.AddWithValue("@code", entity.Code)
            command.Parameters.AddWithValue("@name", entity.Name)
            command.Parameters.AddWithValue("@price", entity.Price)
            command.Parameters.AddWithValue("@stock", entity.Stock)
            command.Parameters.AddWithValue("@description", entity.Description)
            command.Parameters.AddWithValue("@image", entity.Image)
            ConnectionString.Open()
            command.ExecuteNonQuery()
            ConnectionString.Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Update(entity As Article)
        Try
            Dim command As New SqlCommand("article_update", ConnectionString)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@idarticle", entity.IdArticle)
            command.Parameters.AddWithValue("@idcategory", entity.IdCategory)
            command.Parameters.AddWithValue("@code", entity.Code)
            command.Parameters.AddWithValue("@name", entity.Name)
            command.Parameters.AddWithValue("@price", entity.Price)
            command.Parameters.AddWithValue("@stock", entity.Stock)
            command.Parameters.AddWithValue("@description", entity.Description)
            command.Parameters.AddWithValue("@image", entity.Image)
            ConnectionString.Open()
            command.ExecuteNonQuery()
            ConnectionString.Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Delete(id As Integer)
        Try
            Dim command As New SqlCommand("article_delete", ConnectionString)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@idarticle", id)
            ConnectionString.Open()
            command.ExecuteNonQuery()
            ConnectionString.Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Disable(id As Integer)
        Try
            Dim command As New SqlCommand("article_disable", ConnectionString)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@idarticle", id)
            ConnectionString.Open()
            command.ExecuteNonQuery()
            ConnectionString.Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Enable(id As Integer)
        Try
            Dim command As New SqlCommand("article_enable", ConnectionString)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@idarticle", id)
            ConnectionString.Open()
            command.ExecuteNonQuery()
            ConnectionString.Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

End Class
