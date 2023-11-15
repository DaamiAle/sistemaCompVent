
Imports Sistema.Entidades

Public Class FormArticle
    Private business As New Negocio.ArticleBusiness

    Private Sub FormArticle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        totalCount.Location = New Point(Width - totalCount.Width, totalCount.Location.Y)
        GetArticleList()
        ChargeCategories()
        'nameNeeded.SetError(nameTextBox, "Este campo es obligatorio")
    End Sub

    Private Sub Format()
        dgvListado.Columns(0).Visible = False
        dgvListado.Columns(2).Visible = False
        dgvListado.Columns(0).Width = 100
        dgvListado.Columns(1).Width = 50
        dgvListado.Columns(3).Width = 100
        dgvListado.Columns(4).Width = 100
        dgvListado.Columns(5).Width = 150
        dgvListado.Columns(6).Width = 100
        dgvListado.Columns(7).Width = 100
        dgvListado.Columns(8).Width = 200
        dgvListado.Columns(9).Width = 100
        dgvListado.Columns(10).Width = 100

        btnDeleteMulti.Visible = False
        btnDisableMulti.Visible = False
        btnEnableMulti.Visible = False
        CheckBox1.CheckState = False
    End Sub

#Region "Tab 1"

    Private Sub GetArticleList()
        Try
            dgvListado.DataSource = business.List()
            totalCount.Text = $"Registros totales: {dgvListado.DataSource.Rows.Count}"
            Format()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Search()
        Try
            dgvListado.DataSource = business.Search(searchValueTxtBox.Text)
            totalCount.Text = $"Registros totales: {dgvListado.DataSource.Rows.Count}"
            Format()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Search()
    End Sub

    Private Sub btnClearSearchValue_Click(sender As Object, e As EventArgs) Handles btnClearSearchValue.Click
        searchValueTxtBox.Text = ""
        GetArticleList()
    End Sub

    Private Sub searchValueTxtBox_TextChanged(sender As Object, e As EventArgs) Handles searchValueTxtBox.TextChanged
        If (searchValueTxtBox.Text.Length > 0) Then
            btnClearSearchValue.Enabled = True
        Else
            btnClearSearchValue.Enabled = False
        End If
    End Sub

    Private Sub dgvListado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListado.CellClick

        Dim row As DataGridViewRow = dgvListado.CurrentRow
        Dim id As Integer = row.Cells(1).Value
        Dim name As String = row.Cells(2).Value
        Dim description As String = row.Cells(3).Value
        Dim status As Boolean = row.Cells(4).Value

    End Sub

    Private Sub dgvListado_DoubleClick(sender As Object, e As EventArgs) Handles dgvListado.DoubleClick
        'Dim row As DataGridViewRow = dgvListado.CurrentRow
        'idTextBox.Enabled = False
        'btnInsertNew.Enabled = False
        'btnModify.Enabled = True
        'btnDelete.Enabled = True
        'btnEnableDisable.Enabled = True
        'stateBox.Enabled = False
        'Dim category As New Category
        'Category.IdCategory = row.Cells(1).Value
        'Category.Name = row.Cells(2).Value
        'Category.Description = row.Cells(3).Value
        'Category.State = row.Cells(4).Value
        'nameNeeded.SetError(nameTextBox, "")
        'ChargeCategoryInModifier(category)
        TabControl1.SelectTab(1)
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If (CheckBox1.Checked) Then
            dgvListado.Columns(0).Visible = True
            ShowButtons()
        Else
            dgvListado.Columns(0).Visible = False
            For Each row As DataGridViewRow In dgvListado.Rows
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

    Private Sub dgvListado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListado.CellContentClick
        If e.ColumnIndex = dgvListado.Columns.Item(0).Index Then
            Dim checkboxCell As DataGridViewCheckBoxCell = dgvListado.Rows(e.RowIndex).Cells(0)
            checkboxCell.Value = Not checkboxCell.Value
        End If
    End Sub

    Private Sub btnDeleteMulti_Click(sender As Object, e As EventArgs) Handles btnDeleteMulti.Click
        If MsgBox("Esta seguro que desea eliminar las filas seleccionadas? Esta acción no se puede deshacer.", vbYesNo + vbQuestion, "Eliminar filas") = vbYes Then
            Dim business As New Negocio.CategoryBusiness
            Dim rows As DataGridViewRowCollection = dgvListado.Rows
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
                GetArticleList()
                CheckBox1.Checked = False
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnEnableMulti_Click(sender As Object, e As EventArgs) Handles btnEnableMulti.Click
        If MsgBox("Esta seguro que desea habilitar las filas seleccionadas?", vbYesNo + vbQuestion, "Habilitar filas") = vbYes Then
            Dim business As New Negocio.CategoryBusiness
            Dim rows As DataGridViewRowCollection = dgvListado.Rows
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
                GetArticleList()
                CheckBox1.Checked = False
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnDisableMulti_Click(sender As Object, e As EventArgs) Handles btnDisableMulti.Click
        If MsgBox("Esta seguro que desea deshabilitar las filas seleccionadas?", vbYesNo + vbQuestion, "Deshabilitar filas") = vbYes Then
            Dim business As New Negocio.CategoryBusiness
            Dim rows As DataGridViewRowCollection = dgvListado.Rows
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
                GetArticleList()
                CheckBox1.Checked = False
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
#End Region

#Region "Tab 2"

    Private Sub ChargeCategories()
        Try
            cboxCategories.DataSource = New Negocio.CategoryBusiness().ActiveCategories()
            cboxCategories.ValueMember = "IdCategory"
            cboxCategories.DisplayMember = "Name"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


#End Region


End Class