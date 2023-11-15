Imports Sistema.Entidades
Imports System.Data.SqlClient
Public Class CategoryData
    Inherits Connection_v2
    Public Function List() As DataTable
        Try
            Dim result As SqlDataReader
            Dim table As New DataTable
            Dim command As New SqlCommand("category_list", ConnectionString)
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
            Dim command As New SqlCommand("category_search", ConnectionString)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@name", value)
            'command.Parameters.Add("@value", SqlDbType.VarChar).Value = value
            ConnectionString.Open()
            result = command.ExecuteReader()
            table.Load(result)
            ConnectionString.Close()
            Return table
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Sub Insert(entity As Category)
        Try
            Dim command As New SqlCommand("category_insert", ConnectionString)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@name", entity.Name)
            command.Parameters.AddWithValue("@description", entity.Description)
            ConnectionString.Open()
            command.ExecuteNonQuery()
            ConnectionString.Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub Update(entity As Category)
        Try
            Dim command As New SqlCommand("category_update", ConnectionString)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@idcategory", entity.IdCategory)
            command.Parameters.AddWithValue("@name", entity.Name)
            command.Parameters.AddWithValue("@description", entity.Description)
            ConnectionString.Open()
            command.ExecuteNonQuery()
            ConnectionString.Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub Delete(id As Integer)
        Try
            Dim command As New SqlCommand("category_delete", ConnectionString)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@idcategory", id)
            ConnectionString.Open()
            command.ExecuteNonQuery()
            ConnectionString.Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub Disable(id As Integer)
        Try
            Dim command As New SqlCommand("category_disable", ConnectionString)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@idcategory", id)
            ConnectionString.Open()
            command.ExecuteNonQuery()
            ConnectionString.Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub Enable(id As Integer)
        Try
            Dim command As New SqlCommand("category_enable", ConnectionString)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@idcategory", id)
            ConnectionString.Open()
            command.ExecuteNonQuery()
            ConnectionString.Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function ActiveCategories() As DataTable
        Try
            Dim result As SqlDataReader
            Dim table As New DataTable
            Dim command As New SqlCommand("active_category_list", ConnectionString)
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

End Class
