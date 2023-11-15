Imports Sistema.Entidades

Public Class FormCategory

    Private Sub FormCategorias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        totalCount.Location = New Point(Width - totalCount.Width, totalCount.Location.Y)
        GetCategoryList()
        nameNeeded.SetError(nameTextBox, "Este campo es obligatorio")
    End Sub
    Private Sub Format()
        dgvListado.Columns(0).Visible = False
        dgvListado.Columns(0).Width = 100
        dgvListado.Columns(1).Width = 100
        dgvListado.Columns(2).Width = 150
        dgvListado.Columns(3).Width = 400
        dgvListado.Columns(4).Width = 100

        btnDeleteMulti.Visible = False
        btnDisableMulti.Visible = False
        btnEnableMulti.Visible = False
        CheckBox1.CheckState = False
    End Sub


#Region "Tab1"

    Private Sub GetCategoryList()
        Try
            Dim business As New Negocio.CategoryBusiness
            dgvListado.DataSource = business.List()
            totalCount.Text = $"Registros totales: {dgvListado.DataSource.Rows.Count}"
            Format()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Search()
        Try
            Dim business As New Negocio.CategoryBusiness
            Dim value As String
            value = searchValueTxtBox.Text
            dgvListado.DataSource = business.Search(value)
            totalCount.Text = "Registros totales: " & dgvListado.DataSource.Rows.Count
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
        GetCategoryList()
    End Sub

    Private Sub dgvListado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListado.CellClick

        Dim row As DataGridViewRow = dgvListado.CurrentRow
        Dim id As Integer = row.Cells(1).Value
        Dim name As String = row.Cells(2).Value
        Dim description As String = row.Cells(3).Value
        Dim status As Boolean = row.Cells(4).Value

    End Sub

    Private Sub searchValueTxtBox_TextChanged(sender As Object, e As EventArgs) Handles searchValueTxtBox.TextChanged
        If (searchValueTxtBox.Text.Length > 0) Then
            btnClearSearchValue.Enabled = True
        Else
            btnClearSearchValue.Enabled = False
        End If
    End Sub

    Private Sub dgvListado_DoubleClick(sender As Object, e As EventArgs) Handles dgvListado.DoubleClick
        Dim row As DataGridViewRow = dgvListado.CurrentRow
        idTextBox.Enabled = False
        btnInsertNew.Enabled = False
        btnModify.Enabled = True
        btnDelete.Enabled = True
        btnEnableDisable.Enabled = True
        stateBox.Enabled = False
        Dim category As New Category
        category.IdCategory = row.Cells(1).Value
        category.Name = row.Cells(2).Value
        category.Description = row.Cells(3).Value
        category.State = row.Cells(4).Value
        nameNeeded.SetError(nameTextBox, "")
        ChargeCategoryInModifier(category)
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
                GetCategoryList()
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
                GetCategoryList()
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
                GetCategoryList()
                CheckBox1.Checked = False
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

#End Region

#Region "Tab 2"

    Private Sub btnInsertNew_Click(sender As Object, e As EventArgs) Handles btnInsertNew.Click
        ' validamos que el campo de nombre este lleno
        If (nameTextBox.Text.Length = 0) Then
            MsgBox("Los campos con indicador '!' son campos obligatorios")
        Else
            Dim category As New Category
            Dim business As New Negocio.CategoryBusiness
            category.Name = nameTextBox.Text
            category.Description = descriptionTextBox.Text
            category.State = True
            Try
                Dim result As Boolean = business.Insert(category)
                If (result) Then
                    MsgBox("Categoria agregada correctamente", vbOKOnly + vbInformation, "Categoria agregada")
                    GetCategoryList()
                    ClearFields()
                    TabControl1.SelectTab(0)
                Else
                    MsgBox("Error al agregar la categoria", vbOKOnly + vbCritical, "Error al agregar categoria")
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            btnInsertNew.Enabled = False
            btnModify.Enabled = True
        End If
    End Sub

    Private Sub ChargeCategoryInModifier(category As Category)
        idTextBox.Text = category.IdCategory
        nameTextBox.Text = category.Name
        descriptionTextBox.Text = category.Description
        stateBox.Text = IIf(category.State = True, "Activo", "Inactivo")
    End Sub

    Private Sub btnClearFields_Click(sender As Object, e As EventArgs) Handles btnClearFields.Click
        ClearFields()
    End Sub

    Private Sub ClearFields()
        idTextBox.Text = ""
        nameTextBox.Text = ""
        descriptionTextBox.Text = ""
        stateBox.Text = ""
        btnClearFields.Enabled = False
        btnInsertNew.Enabled = True
        btnModify.Enabled = False
        btnDelete.Enabled = False
        btnEnableDisable.Enabled = False
    End Sub

    Private Sub TextBoxModified(sender As Object, e As EventArgs) Handles nameTextBox.TextChanged, descriptionTextBox.TextChanged
        btnClearFields.Enabled = nameTextBox.Text.Length > 0 Or descriptionTextBox.Text.Length > 0
    End Sub

    Private Sub nameTextBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles nameTextBox.Validating
        nameNeeded.SetError(sender, "Este campo es obligatorio")
    End Sub

    Private Sub btnModify_Click(sender As Object, e As EventArgs) Handles btnModify.Click
        If (nameTextBox.Text.Length = 0) Then
            nameNeeded.SetError(nameTextBox, "Este campo es obligatorio")
            MsgBox("Los campos con indicador '!' son campos obligatorios")
        Else
            Dim category As New Category
            Dim business As New Negocio.CategoryBusiness
            category.IdCategory = idTextBox.Text
            category.Name = nameTextBox.Text
            category.Description = descriptionTextBox.Text
            Try
                Dim result As Boolean = business.Update(category)
                If (result) Then
                    MsgBox("Categoria modificada correctamente", vbOKOnly + vbInformation, "Categoria modificada")
                    GetCategoryList()
                    ClearFields()
                    TabControl1.SelectTab(0)
                Else
                    MsgBox("Error al modificar la categoria", vbOKOnly + vbCritical, "Error al modificar categoria")
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnEnableDisable_Click(sender As Object, e As EventArgs) Handles btnEnableDisable.Click
        Dim business As New Negocio.CategoryBusiness
        Dim id As Integer = idTextBox.Text
        Dim state As Boolean = stateBox.Text = "Activo"
        Try
            If (state) Then
                business.Disable(id)
                MsgBox("Categoria deshabilitada correctamente", vbOKOnly + vbInformation, "Categoria deshabilitada")
            Else
                business.Enable(id)
                MsgBox("Categoria habilitada correctamente", vbOKOnly + vbInformation, "Categoria habilitada")
            End If
            GetCategoryList()
            ClearFields()
            TabControl1.SelectTab(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MsgBox("Esta seguro que desea eliminar la categoria? Esta acción no se puede deshacer.", vbYesNo + vbQuestion, "Eliminar categoria") = vbYes Then
            Dim business As New Negocio.CategoryBusiness
            Dim id As Integer = idTextBox.Text
            Try
                business.Delete(id)
                MsgBox("Categoria eliminada correctamente", vbOKOnly + vbInformation, "Categoria eliminada")
                GetCategoryList()
                ClearFields()
                TabControl1.SelectTab(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

#End Region

End Class