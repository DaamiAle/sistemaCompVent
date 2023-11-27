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
            entity.IdUser = table.Rows(0)("id")
            entity.IdRole = table.Rows(0)("idrole")
            entity.Name = table.Rows(0)("name")
            entity.DocumentType = table.Rows(0)("documenttype")
            entity.DocumentNumber = table.Rows(0)("documentnumber")
            entity.Address = table.Rows(0)("address")
            entity.Phone = table.Rows(0)("phone")
            entity.Email = table.Rows(0)("email")
            'entity.Password = table.Rows(0)("password")
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

    Public Function IsValidEmail(email As String) As Boolean
        Dim re As New Text.RegularExpressions.Regex("^[\w._%-]+@[\w.-]+\.[a-zA-Z]{2,4}$")
        Return re.IsMatch(email)
    End Function

    Public Function IsValidPassword(password As String) As Boolean
        'la contraseña debera contener al menos 8 caracteres, una letra mayuscula, una letra minuscula y un caracter especial
        Dim re As New Text.RegularExpressions.Regex("^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}$")
        Return re.IsMatch(password)
    End Function

    Public Function Login(email As String, password As String) As User
        Dim entity As New User
        Dim table As DataTable = Nothing
        Try
            table = data.Login(email, password)
            entity.IdUser = table.Rows(0)("id")
            entity.IdRole = table.Rows(0)("idrole")
            entity.Name = table.Rows(0)("name")
            'entity.DocumentType = table.Rows(0)("documenttype")
            'entity.DocumentNumber = table.Rows(0)("documentnumber")
            'entity.Address = table.Rows(0)("address")
            'entity.Phone = table.Rows(0)("phone")
            'entity.Email = table.Rows(0)("email")
            'entity.Password = table.Rows(0)("password")
            entity.State = table.Rows(0)("state")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return entity
    End Function

    Public Function ChangePassword(id As Integer, email As String, password As String, newPassword As String, newPasswordConfirm As String) As Boolean
        Dim result As Boolean = False
        Dim validEmail As Boolean = IsValidEmail(email)
        Dim validPassword As Boolean = IsValidPassword(password)
        Dim validNewPassword As Boolean = IsValidPassword(newPassword)
        Dim validConfirmation As Boolean = newPassword = newPasswordConfirm
        If Not validEmail Then
            MsgBox("El email ingresado no es válido", vbOKOnly + vbExclamation, "Email inválido")
        ElseIf Not validPassword Then
            MsgBox("La contraseña actual ingresada no es válida. Una contraseña válida contiene al menos 8 caracteres, una letra mayuscula, una letra minuscula y un caracter especial.", vbOKOnly + vbExclamation, "Contraseña inválida")
        ElseIf Not validNewPassword Then
            MsgBox("La contraseña nueva ingresada no es válida. La contraseña deberá contener al menos 8 caracteres, una letra mayuscula, una letra minuscula y un caracter especial.", vbOKOnly + vbExclamation, "Contraseña inválida")
        ElseIf Not validConfirmation Then
            MsgBox("La contraseña y su confirmación no coinciden", vbOKOnly + vbExclamation, "Contraseña inválida")
        Else
            If Login(email, password).IdUser = 0 Then
                MsgBox("El email o la contraseña son incorrectos", vbOKOnly + vbExclamation, "Datos incorrectos")
            Else
                result = UpdatePassward(id, newPassword)
            End If
        End If
        Return result
    End Function

    Public Function ChangeEmail(id As Integer, email As String, password As String, newEmail As String, newEmailConfirm As String) As Boolean
        Dim result As Boolean = False
        Dim validEmail As Boolean = IsValidEmail(email)
        Dim validPassword As Boolean = IsValidPassword(password)
        Dim validNewEmail As Boolean = IsValidEmail(newEmail)
        Dim validConfirmation As Boolean = newEmail = newEmailConfirm
        If Not validEmail Then
            MsgBox("El email ingresado no es válido", vbOKOnly + vbExclamation, "Email inválido")
        ElseIf Not validPassword Then
            MsgBox("La contraseña actual ingresada no es válida. Una contraseña válida contiene al menos 8 caracteres, una letra mayuscula, una letra minuscula y un caracter especial.", vbOKOnly + vbExclamation, "Contraseña inválida")
        ElseIf Not validNewEmail Then
            MsgBox("El nuevo email ingresado no es válido", vbOKOnly + vbExclamation, "Email inválido")
        ElseIf Not validConfirmation Then
            MsgBox("El nuevo email y su confirmación no coinciden", vbOKOnly + vbExclamation, "Email inválido")
        Else
            If Login(email, password).IdUser = 0 Then
                MsgBox("El email o la contraseña son incorrectos", vbOKOnly + vbExclamation, "Datos incorrectos")
            Else
                result = UpdateEmail(id, newEmail)
            End If
        End If
        Return result
    End Function

    Private Function UpdatePassward(id As Integer, password As String) As Boolean
        Dim result As Boolean = False
        Try
            data.UpdatePassword(id, password)
            result = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return result
    End Function

    Private Function UpdateEmail(id As Integer, email As String) As Boolean
        Dim result As Boolean = False
        Try
            data.UpdateEmail(id, email)
            result = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return result
    End Function
End Class
