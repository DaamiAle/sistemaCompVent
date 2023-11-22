Imports Sistema.Entidades
Imports Sistema.Datos

Public Class UserBusiness
    Private data As New UserData

    Public Function List() As DataTable
        Dim table As DataTable = Nothing
        Try
            table = data.List()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return table
    End Function

    Public Function Search(value As String) As DataTable
        Dim table As DataTable = Nothing
        Try
            table = data.Search(value)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return table
    End Function

    Public Function GetById(value As Integer) As User
        Dim entity As New User
        Dim table As DataTable = Nothing
        Try
            table = data.GetById(value)
            entity.IdUser = table.Rows(0)("iduser")
            entity.IdRole = table.Rows(0)("idrole")
            entity.Name = table.Rows(0)("name")
            entity.DocumentType = table.Rows(0)("documenttype")
            entity.DocumentNumber = table.Rows(0)("documentnumber")
            entity.Address = table.Rows(0)("address")
            entity.Phone = table.Rows(0)("phone")
            entity.Email = table.Rows(0)("email")
            entity.Password = table.Rows(0)("password")
            entity.State = table.Rows(0)("state")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return entity
    End Function

    Public Function Insert(entity As User) As Boolean
        Dim result As Boolean = False
        Try
            data.Insert(entity)
            result = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return result
    End Function

    Public Function Update(entity As User) As Boolean
        Dim result As Boolean = False
        Try
            data.Update(entity)
            result = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return result
    End Function

    Public Function Delete(id As Integer) As Boolean
        Dim result As Boolean = False
        Try
            data.Delete(id)
            result = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return result
    End Function

    Public Function Disable(id As Integer) As Boolean
        Dim result As Boolean = False
        Try
            data.Disable(id)
            result = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return result
    End Function

    Public Function Enable(id As Integer) As Boolean
        Dim result As Boolean = False
        Try
            data.Enable(id)
            result = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return result
    End Function

End Class
