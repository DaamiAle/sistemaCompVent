Imports Sistema.Entidades
Imports System.Data.SqlClient

Public Class UserData
    Inherits Connection_v2
    'Stored Procedures y nombre de los parametro que pide:
    'user_list
    'user_search (name)
    'user_get_by_id(iduser)
    'user_insert (idrole, name, documenttype, documentnumber, address, phone, email, password)
    'user_update (iduser, idrole, name, documenttype, documentnumber, address, phone, password)
    'user_delete (iduser)
    'user_disable (iduser)
    'user_enable (iduser)

    Public Function List() As DataTable
        Try
            Dim result As SqlDataReader
            Dim table As New DataTable
            Dim command As New SqlCommand("user_list", ConnectionString)
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
            Dim command As New SqlCommand("user_search", ConnectionString)
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

    Public Function GetById(value As Integer) As DataTable
        Try
            Dim result As SqlDataReader
            Dim table As New DataTable
            Dim command As New SqlCommand("user_get_by_id", ConnectionString)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@iduser", value)
            ConnectionString.Open()
            result = command.ExecuteReader()
            table.Load(result)
            ConnectionString.Close()
            Return table
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Insert(entity As User) As Boolean
        Try
            Dim command As New SqlCommand("user_insert", ConnectionString)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@idrole", entity.IdRole)
            command.Parameters.AddWithValue("@name", entity.Name)
            command.Parameters.AddWithValue("@documenttype", entity.DocumentType)
            command.Parameters.AddWithValue("@documentnumber", entity.DocumentNumber)
            command.Parameters.AddWithValue("@address", entity.Address)
            command.Parameters.AddWithValue("@phone", entity.Phone)
            command.Parameters.AddWithValue("@email", entity.Email)
            command.Parameters.AddWithValue("@password", entity.Password)
            ConnectionString.Open()
            command.ExecuteNonQuery()
            ConnectionString.Close()
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Update(entity As User) As Boolean
        Try
            Dim command As New SqlCommand("user_update", ConnectionString)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@iduser", entity.IdUser)
            command.Parameters.AddWithValue("@idrole", entity.IdRole)
            command.Parameters.AddWithValue("@name", entity.Name)
            command.Parameters.AddWithValue("@documenttype", entity.DocumentType)
            command.Parameters.AddWithValue("@documentnumber", entity.DocumentNumber)
            command.Parameters.AddWithValue("@address", entity.Address)
            command.Parameters.AddWithValue("@phone", entity.Phone)
            ConnectionString.Open()
            command.ExecuteNonQuery()
            ConnectionString.Close()
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Delete(value As Integer) As Boolean
        Try
            Dim command As New SqlCommand("user_delete", ConnectionString)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@iduser", value)
            ConnectionString.Open()
            command.ExecuteNonQuery()
            ConnectionString.Close()
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Disable(value As Integer) As Boolean
        Try
            Dim command As New SqlCommand("user_disable", ConnectionString)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@iduser", value)
            ConnectionString.Open()
            command.ExecuteNonQuery()
            ConnectionString.Close()
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Enable(value As Integer) As Boolean
        Try
            Dim command As New SqlCommand("user_enable", ConnectionString)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@iduser", value)
            ConnectionString.Open()
            command.ExecuteNonQuery()
            ConnectionString.Close()
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Login(email As String, password As String) As DataTable
        Try
            Dim result As SqlDataReader
            Dim table As New DataTable
            Dim command As New SqlCommand("user_login", ConnectionString)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@email", email)
            command.Parameters.AddWithValue("@password", password)
            ConnectionString.Open()
            result = command.ExecuteReader()
            table.Load(result)
            ConnectionString.Close()
            Return table
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function UpdatePassword(iduser As Integer, password As String) As Boolean
        Try
            Dim command As New SqlCommand("user_update_password", ConnectionString)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@iduser", iduser)
            command.Parameters.AddWithValue("@password", password)
            ConnectionString.Open()
            command.ExecuteNonQuery()
            ConnectionString.Close()
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function UpdateEmail(iduser As Integer, email As String) As Boolean
        Try
            Dim command As New SqlCommand("user_update_email", ConnectionString)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@iduser", iduser)
            command.Parameters.AddWithValue("@email", email)
            ConnectionString.Open()
            command.ExecuteNonQuery()
            ConnectionString.Close()
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function


End Class
