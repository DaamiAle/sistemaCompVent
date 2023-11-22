Imports Sistema.Entidades
Imports Sistema.Negocio
Public Class FormUser
    Dim business As New UserBusiness

    Private Sub FormUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetList()
        'ChargeCategories()
        'IndicateRequiredFields()
    End Sub

    Private Sub GetList()
        Try
            dgvList.DataSource = business.List()
            totalCount.Text = "Total de registros: " & dgvList.RowCount
            Format()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Format()
        dgvList.Columns(0).Visible = False
        dgvList.Columns(2).Visible = False
        dgvList.Columns(0).Width = 64
        dgvList.Columns(1).Width = 48
        dgvList.Columns(3).Width = 96
        dgvList.Columns(4).Width = 128
        dgvList.Columns(5).Width = 48
        dgvList.Columns(6).Width = 80
        dgvList.Columns(7).Width = 128
        dgvList.Columns(8).Width = 64
        dgvList.Columns(9).Width = 160
        dgvList.Columns(10).Width = 48
        dgvList.Sort(dgvList.Columns(1), ComponentModel.ListSortDirection.Ascending)
        btnDeleteMulti.Visible = False
        btnDisableMulti.Visible = False
        btnEnableMulti.Visible = False
        CheckBox1.CheckState = False
    End Sub

    Private Sub Search()
        Try
            dgvList.DataSource = business.Search(searchValueTxtBox.Text)
            totalCount.Text = $"Registros totales: {dgvList.DataSource.Rows.Count}"
            Format()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles searchValueTxtBox.TextChanged
        If searchValueTxtBox.Text.Length > 0 Then
            Search()
        Else
            GetList()
        End If
    End Sub

    Private Sub btnClearSearchValue_Click(sender As Object, e As EventArgs) Handles btnClearSearchValue.Click
        searchValueTxtBox.Text = ""
        GetList()
    End Sub

    Private Sub searchValueTxtBox_TextChanged(sender As Object, e As EventArgs) Handles searchValueTxtBox.TextChanged
        If (searchValueTxtBox.Text.Length > 0) Then
            btnClearSearchValue.Enabled = True
        Else
            btnClearSearchValue.Enabled = False
        End If
    End Sub

    Private Sub dgvList_DoubleClick(sender As Object, e As EventArgs) Handles dgvList.DoubleClick
        Dim row As DataGridViewRow = dgvList.CurrentRow
        ' ACA LO DE LOS IDENTIFICADORES DE CAMPOS NECESARIOS
        ' TAMBIEN ACTIVAR Y DESACTIVAR TEXTBOX

        Dim entity As User = business.GetById(Integer.Parse(row.Cells(1).Value))
        ChargeInModifier(entity)
        TabControl1.SelectTab(1)
    End Sub

    Private Sub ChargeInModifier(entity As User)
        ' FALTA COMPLETAR
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If (CheckBox1.Checked) Then
            dgvList.Columns(0).Visible = True
            ShowButtons()
        Else
            dgvList.Columns(0).Visible = False
            For Each row As DataGridViewRow In dgvList.Rows
                row.Cells(0).Value = False
            Next
            HideButtons()
        End If
    End Sub

    Private Sub ShowButtons()
        btnDeleteMulti.Visible = True
        btnEnableMulti.Visible = True
        btnDisableMulti.Visible = True
    End Sub

    Private Sub HideButtons()
        btnDeleteMulti.Visible = False
        btnEnableMulti.Visible = False
        btnDisableMulti.Visible = False
    End Sub

    Private Sub dgvList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvList.CellContentClick
        If e.ColumnIndex = dgvList.Columns.Item(0).Index Then
            Dim checkboxCell As DataGridViewCheckBoxCell = dgvList.Rows(e.RowIndex).Cells(0)
            checkboxCell.Value = Not checkboxCell.Value
        End If
        If dgvList.Rows.Cast(Of DataGridViewRow).Any(Function(row) row.Cells(0).Value) Then
            EnableButtons()
        Else
            DisableButtons()
        End If
    End Sub

    Private Sub EnableButtons()
        btnDeleteMulti.Enabled = True
        btnEnableMulti.Enabled = True
        btnDisableMulti.Enabled = True

    End Sub

    Private Sub DisableButtons()
        btnDeleteMulti.Enabled = False
        btnEnableMulti.Enabled = False
        btnDisableMulti.Enabled = False
    End Sub

    Private Sub btnDeleteMulti_Click(sender As Object, e As EventArgs) Handles btnDeleteMulti.Click
        If MsgBox("Esta seguro que desea eliminar las filas seleccionadas? Esta acción no se puede deshacer.", vbYesNo + vbQuestion, "Eliminar filas") = vbYes Then
            Dim business As New Negocio.CategoryBusiness
            Dim rows As DataGridViewRowCollection = dgvList.Rows
            Dim selectedRows As New List(Of DataGridViewRow)
            For Each row As DataGridViewRow In rows
                If row.Cells(0).Value Then
                    selectedRows.Add(row)
                End If
            Next
            Try
                For Each row As DataGridViewRow In selectedRows
                    Dim id As Integer = row.Cells(1).Value
                    business.Delete(id)
                Next
                MsgBox("Filas eliminadas correctamente", vbOKOnly + vbInformation, "Filas eliminadas")
                GetList()
                CheckBox1.Checked = False
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnEnableMulti_Click(sender As Object, e As EventArgs) Handles btnEnableMulti.Click
        If MsgBox("Esta seguro que desea habilitar las filas seleccionadas?", vbYesNo + vbQuestion, "Habilitar filas") = vbYes Then
            Dim business As New Negocio.CategoryBusiness
            Dim rows As DataGridViewRowCollection = dgvList.Rows
            Dim selectedRows As New List(Of DataGridViewRow)
            For Each row As DataGridViewRow In rows
                If row.Cells(0).Value Then
                    selectedRows.Add(row)
                End If
            Next
            Try
                For Each row As DataGridViewRow In selectedRows
                    Dim id As Integer = row.Cells(1).Value
                    business.Enable(id)
                Next
                MsgBox("Filas habilitadas correctamente", vbOKOnly + vbInformation, "Filas habilitadas")
                GetList()
                CheckBox1.Checked = False
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnDisableMulti_Click(sender As Object, e As EventArgs) Handles btnDisableMulti.Click
        If MsgBox("Esta seguro que desea deshabilitar las filas seleccionadas?", vbYesNo + vbQuestion, "Deshabilitar filas") = vbYes Then
            Dim business As New Negocio.CategoryBusiness
            Dim rows As DataGridViewRowCollection = dgvList.Rows
            Dim selectedRows As New List(Of DataGridViewRow)
            For Each row As DataGridViewRow In rows
                If row.Cells(0).Value Then
                    selectedRows.Add(row)
                End If
            Next
            Try
                For Each row As DataGridViewRow In selectedRows
                    Dim id As Integer = row.Cells(1).Value
                    business.Disable(id)
                Next
                MsgBox("Filas deshabilitadas correctamente", vbOKOnly + vbInformation, "Filas deshabilitadas")
                GetList()
                CheckBox1.Checked = False
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
End Class