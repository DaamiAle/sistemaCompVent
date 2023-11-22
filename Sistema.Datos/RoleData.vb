Imports System.Data.SqlClient

Public Class RoleData
    Inherits Connection_v2
    'Stored Procedures y nombre de los parametro que pide:
    'role_list
    'role_search (name)
    'role_insert (name, description)
    'role_update (idrole, name, description)
    'role_delete (idrole)
    'role_disable (idrole)
    'role_enable (idrole)
    Public Function List() As DataTable
        Try
            Dim result As SqlDataReader
            Dim table As New DataTable
            Dim command As New SqlCommand("role_list", ConnectionString)
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

    Public Function ActiveRoles() As DataTable
        Try
            Dim result As SqlDataReader
            Dim table As New DataTable
            Dim command As New SqlCommand("active_role_list", ConnectionString)
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
