
Imports Sistema.Entidades

Public Class FormArticle
    Private business As New Negocio.ArticleBusiness
    Private originPath As String
    Private destinationPath As String
    Private directory As String = "D:\sistema\"

    Private Sub FormArticle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        totalCount.Location = New Point(Width - totalCount.Width, totalCount.Location.Y)
        GetArticleList()
        ChargeCategories()
        IndicateRequiredFields()
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
        dgvListado.Sort(dgvListado.Columns(1), ComponentModel.ListSortDirection.Ascending)
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



    Private Sub dgvListado_DoubleClick(sender As Object, e As EventArgs) Handles dgvListado.DoubleClick
        Dim row As DataGridViewRow = dgvListado.CurrentRow
        idBox.Enabled = False
        btnInsertNew.Enabled = False
        btnModify.Enabled = True
        btnDelete.Enabled = True
        btnEnableDisable.Enabled = True
        stateBox.Enabled = False
        nameNeeded.SetError(nameBox, "")
        stockNeeded.SetError(stockBox, "")
        priceNeeded.SetError(priceBox, "")
        categoryNeeded.SetError(cboxCategories, "")
        Dim article As Article
        article = business.GetById(Integer.Parse(row.Cells(1).Value))
        ChargeArticleInModifier(article)
        TabControl1.SelectTab(1)
    End Sub

    Private Sub ChargeArticleInModifier(article As Article)
        idBox.Text = article.IdArticle
        cboxCategories.SelectedValue = article.IdCategory
        codeBox.Text = article.Code
        nameBox.Text = article.Name
        priceBox.Text = article.Price
        stockBox.Text = article.Stock
        pathImage.Text = article.Image
        If (article.Image.Length > 0) Then
            imageBox.Image = Image.FromFile(article.Image)
        End If
        stateBox.Text = IIf(article.State, "Activo", "Inactivo")
        descriptionBox.Text = article.Description
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
        If dgvListado.Rows.Cast(Of DataGridViewRow).Any(Function(row) row.Cells(0).Value) Then
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
            cboxCategories.ValueMember = "ID"
            cboxCategories.DisplayMember = "Name"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TextBoxModified(sender As Object, e As EventArgs) Handles codeBox.TextChanged, nameBox.TextChanged, descriptionBox.TextChanged, imageBox.TextChanged, priceBox.TextChanged, stockBox.TextChanged, cboxCategories.SelectedIndexChanged
        Dim fields As List(Of TextBox) = New List(Of TextBox) From {idBox, codeBox, nameBox, descriptionBox, pathImage, priceBox, stockBox}
        btnClearFields.Enabled = fields.Any(Function(field) field.Text.Length > 0) Or cboxCategories.SelectedIndex > 0
    End Sub

    Private Sub btnChargeImage_Click(sender As Object, e As EventArgs) Handles btnChargeImage.Click
        Dim fileDialog As New OpenFileDialog()
        fileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp"
        If fileDialog.ShowDialog() = DialogResult.OK Then
            originPath = fileDialog.FileName
            imageBox.Image = Image.FromFile(originPath)
            pathImage.Text = originPath
        End If
    End Sub

    Private Sub btnClearFields_Click(sender As Object, e As EventArgs) Handles btnClearFields.Click
        ClearFields()
    End Sub

    Private Sub ClearFields()
        idBox.Text = ""
        cboxCategories.SelectedIndex = 0
        codeBox.Text = ""
        nameBox.Text = ""
        priceBox.Text = ""
        stockBox.Text = ""
        pathImage.Text = ""
        imageBox.Image = Nothing
        stateBox.Text = ""
        descriptionBox.Text = ""
        btnClearFields.Enabled = False
        btnInsertNew.Enabled = True
        btnModify.Enabled = False
        btnDelete.Enabled = False
        btnEnableDisable.Enabled = False
    End Sub

    Private Sub IndicateRequiredFields()
        nameNeeded.SetError(nameBox, "Este campo es obligatorio")
        categoryNeeded.SetError(cboxCategories, "Este campo es obligatorio")
        priceNeeded.SetError(priceBox, "Este campo es obligatorio")
        stockNeeded.SetError(stockBox, "Este campo es obligatorio")
    End Sub

#Region "Insert"
    Private Sub btnInsertNew_Click(sender As Object, e As EventArgs) Handles btnInsertNew.Click

        If (codeBox.Text.Length = 0) Then
            MsgBox("Los campos con indicador '!' son campos obligatorios")
        Else
            Dim article As New Article
            article.IdCategory = cboxCategories.SelectedValue
            article.Code = codeBox.Text
            article.Name = nameBox.Text
            article.Price = priceBox.Text
            article.Stock = stockBox.Text
            article.Image = pathImage.Text
            Console.WriteLine(article.Image)
            article.Description = descriptionBox.Text
            Try
                business.Insert(article)
                MsgBox("Articulo insertado correctamente", vbOKOnly + vbInformation, "Articulo insertado")
                GetArticleList()
                ClearFields()
                TabControl1.SelectTab(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub


#End Region


#Region "Update"
    Private Sub btnModify_Click(sender As Object, e As EventArgs) Handles btnModify.Click
        Dim article As New Article
        article.IdArticle = idBox.Text
        article.IdCategory = cboxCategories.SelectedValue
        article.Code = codeBox.Text
        article.Name = nameBox.Text
        article.Price = Decimal.Parse(priceBox.Text)
        article.Stock = Integer.Parse(stockBox.Text)
        article.Image = pathImage.Text
        article.Description = descriptionBox.Text
        Try
            business.Update(article)
            MsgBox("Articulo modificado correctamente", vbOKOnly + vbInformation, "Articulo modificado")
            GetArticleList()
            ClearFields()
            TabControl1.SelectTab(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



#End Region
#End Region


End Class