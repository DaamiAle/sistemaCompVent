Imports Sistema.Negocio

Public Class FormRole

    Dim roleBusiness As New RoleBusiness
    Private Sub Format()
        dgvList.Columns(0).Width = 32
        dgvList.Columns(1).Width = 128
        dgvList.Columns(2).Width = 256
        dgvList.Columns(0).HeaderText = "ID"
        dgvList.Columns(1).HeaderText = "Nombre"
        dgvList.Columns(2).HeaderText = "Descripción"
        dgvList.Sort(dgvList.Columns(0), ComponentModel.ListSortDirection.Ascending)
    End Sub

    Private Sub List()
        Try
            dgvList.DataSource = roleBusiness.List()
            totalCount.Text = $"Registros totales: {dgvList.DataSource.Rows.Count}"
            Format()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub FormRole_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        List()
    End Sub
End Class