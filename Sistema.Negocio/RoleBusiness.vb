﻿Imports Sistema.Datos
Public Class RoleBusiness

    Public Function List() As DataTable
        Try
            Dim roleData As New RoleData
            Return roleData.List()
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
