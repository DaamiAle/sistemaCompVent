﻿Imports Sistema.Entidades
Imports Sistema.Negocio
Public Class FormUser
    Dim business As New UserBusiness

    Private Sub FormUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetList()
        ChargeRoles()
        IndicateRequiredFields()
    End Sub

    Private Sub IndicateRequiredFields()
        nameNeeded.SetError(TextBox2, "Campo requerido")
        documentNeeded.SetError(TextBox4, "Campo requerido")
        emailNeeded.SetError(TextBox8, "Campo requerido")
        passwordNeeded.SetError(TextBox9, "Campo requerido")
        roleNeeded.SetError(ComboBox1, "Campo requerido")
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

    Private Sub ClearModifierFields()
        TextBox1.Text = ""
        ComboBox1.SelectedValue = 0
        TextBox2.Text = ""
        ComboBox2.SelectedItem = 0
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        btnDelete.Visible = False
        btnEnableDisable.Visible = False
        btnModify.Visible = False
        btnInsertNew.Visible = True
        btnInsertNew.Enabled = True
        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = False
        TextBox10.Visible = False
        TextBox11.Visible = False
        TextBox12.Visible = False
        TextBox13.Visible = False
    End Sub

    Private Sub ChargeRoles()
        Try
            ComboBox1.DataSource = New Negocio.RoleBusiness().ActiveRoles()
            ComboBox1.ValueMember = "ID"
            ComboBox1.DisplayMember = "Name"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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
        nameNeeded.SetError(TextBox2, "")
        documentNeeded.SetError(TextBox4, "")
        emailNeeded.SetError(TextBox8, "")
        passwordNeeded.SetError(TextBox9, "")
        roleNeeded.SetError(ComboBox1, "")

        btnInsertNew.Enabled = False

        btnModify.Enabled = True
        btnEnableDisable.Enabled = True
        btnDelete.Enabled = True
        btnModify.Visible = True
        btnEnableDisable.Visible = True
        btnDelete.Visible = True

        TextBox10.Enabled = True
        TextBox11.Enabled = True
        TextBox12.Enabled = True
        TextBox13.Enabled = True

        Button1.Enabled = False
        Button2.Enabled = True
        Button3.Enabled = True
        Button1.Visible = True
        Button2.Visible = True
        Button3.Visible = True
        SwitchPassEmailEdition(True)
        Dim entity As User = business.GetById(Integer.Parse(row.Cells(1).Value))
        ChargeInModifier(entity)
        TabControl1.SelectTab(1)
    End Sub

    Private Sub ChargeInModifier(entity As User)
        TextBox1.Text = entity.IdUser
        ComboBox1.SelectedValue = entity.IdRole
        TextBox2.Text = entity.Name
        ComboBox2.SelectedItem = entity.DocumentType
        TextBox4.Text = entity.DocumentNumber
        TextBox5.Text = entity.Address
        TextBox6.Text = entity.Phone
        TextBox7.Text = IIf(entity.State, "Activo", "Inactivo")
        TextBox8.Text = entity.Email

    End Sub
    Private Sub SwitchPassEmailEdition(value As Boolean)
        Button3.Text = IIf(value, "Cambiar a edicion de e-mail", "Cambiar a edicion de contraseña")
        Label10.Visible = value
        TextBox10.Visible = value
        TextBox11.Visible = value
        Label11.Visible = Not value
        TextBox12.Visible = Not value
        TextBox13.Visible = Not value
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

    Private Sub btnInsertNew_Click(sender As Object, e As EventArgs) Handles btnInsertNew.Click
        Dim validEmail As Boolean = business.IsValidEmail(TextBox8.Text)
        Dim validPassword As Boolean = business.IsValidPassword(TextBox9.Text)
        If (ComboBox1.SelectedValue = 0 Or TextBox2.Text.Length = 0 Or TextBox4.Text.Length = 0 Or TextBox8.Text.Length = 0 Or TextBox9.Text.Length = 0) Then
            MsgBox("Debe completar todos los campos obligatorios", vbOKOnly + vbExclamation, "Campos incompletos")
        ElseIf Not validEmail Then
            MsgBox("El email ingresado no es válido", vbOKOnly + vbExclamation, "Email inválido")
        ElseIf Not validPassword Then
            MsgBox("La contraseña ingresada no es válida", vbOKOnly + vbExclamation, "Contraseña inválida")
        Else
            Dim entity As New User
            entity.IdRole = ComboBox1.SelectedValue
            entity.Name = TextBox2.Text
            entity.DocumentType = ComboBox2.SelectedItem
            entity.DocumentNumber = TextBox4.Text
            entity.Address = TextBox5.Text
            entity.Phone = TextBox6.Text
            entity.Email = TextBox8.Text
            entity.Password = TextBox9.Text
            entity.State = 1
            If (business.Insert(entity)) Then
                MsgBox("Usuario agregado correctamente", vbOKOnly + vbInformation, "Usuario agregado")
                GetList()
                TabControl1.SelectTab(0)
            Else
                MsgBox("No se pudo agregar el usuario", vbOKOnly + vbCritical, "Error al agregar")
            End If
        End If
    End Sub

    Private Sub btnModify_Click(sender As Object, e As EventArgs) Handles btnModify.Click
        If ComboBox1.SelectedValue = 0 Or TextBox2.Text.Length = 0 Or TextBox4.Text.Length = 0 Then 'Or TextBox8.Text.Length = 0 Or TextBox9.Text.Length = 0) Then
            MsgBox("Debe completar todos los campos obligatorios", vbOKOnly + vbExclamation, "Campos incompletos")
            IndicateRequiredFields()
        Else
            Dim entity As New User
            entity.IdUser = Integer.Parse(TextBox1.Text)
            entity.IdRole = ComboBox1.SelectedValue
            entity.Name = TextBox2.Text
            entity.DocumentType = ComboBox2.SelectedItem
            entity.DocumentNumber = TextBox4.Text
            entity.Address = TextBox5.Text
            entity.Phone = TextBox6.Text
            If (business.Update(entity)) Then
                MsgBox("Usuario modificado correctamente", vbOKOnly + vbInformation, "Usuario modificado")
                GetList()
                ClearModifierFields()
                TabControl1.SelectTab(0)
            Else
                MsgBox("No se pudo modificar el usuario", vbOKOnly + vbCritical, "Error al modificar")
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Button1.Enabled = Not Button1.Enabled
        Button2.Enabled = Not Button2.Enabled
        SwitchPassEmailEdition(Button2.Enabled)
    End Sub

    Private Function VerifyEmailAndPasswordExistance() As Boolean
        Return business.IsValidEmail(TextBox8.Text) And TextBox9.Text.Length > 0
    End Function

    Private Sub btnEnableDisable_Click(sender As Object, e As EventArgs) Handles btnEnableDisable.Click
        If TextBox7.Text = "Activo" Then
            If MsgBox("Esta seguro que desea deshabilitar el usuario?", vbYesNo + vbQuestion, "Deshabilitar usuario") = vbYes Then
                If (business.Disable(Integer.Parse(TextBox1.Text))) Then
                    MsgBox("Usuario deshabilitado correctamente", vbOKOnly + vbInformation, "Usuario deshabilitado")
                    GetList()
                    ClearModifierFields()
                    TabControl1.SelectTab(0)
                Else
                    MsgBox("No se pudo deshabilitar el usuario", vbOKOnly + vbCritical, "Error al deshabilitar")
                End If
            End If
        ElseIf TextBox7.Text = "Inactivo" Then
            If MsgBox("Esta seguro que desea habilitar el usuario?", vbYesNo + vbQuestion, "Habilitar usuario") = vbYes Then
                If (business.Enable(Integer.Parse(TextBox1.Text))) Then
                    MsgBox("Usuario habilitado correctamente", vbOKOnly + vbInformation, "Usuario habilitado")
                    GetList()
                    ClearModifierFields()
                    TabControl1.SelectTab(0)
                Else
                    MsgBox("No se pudo habilitar el usuario", vbOKOnly + vbCritical, "Error al habilitar")
                End If
            End If
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MsgBox("Esta seguro que desea eliminar este usuario? Esta acción no se puede deshacer.", vbYesNo + vbQuestion, "Eliminar usuario") = vbYes Then
            If (business.Delete(Integer.Parse(TextBox1.Text))) Then
                MsgBox("Usuario eliminado correctamente", vbOKOnly + vbInformation, "Usuario eliminado")
                GetList()
                ClearModifierFields()
                TabControl1.SelectTab(0)
            Else
                MsgBox("No se pudo eliminar el usuario", vbOKOnly + vbCritical, "Error al eliminar")
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim opResult As Boolean = business.ChangePassword(Integer.Parse(TextBox1.Text), TextBox8.Text, TextBox9.Text, TextBox10.Text, TextBox11.Text)
        If opResult Then
            MsgBox("Contraseña modificada correctamente", vbOKOnly + vbInformation, "Contraseña modificada")
            GetList()
            ClearModifierFields()
            TabControl1.SelectTab(0)
        Else
            MsgBox("No se pudo modificar la contraseña", vbOKOnly + vbCritical, "Error al modificar")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim opResult As Boolean = business.ChangeEmail(Integer.Parse(TextBox1.Text), TextBox8.Text, TextBox9.Text, TextBox12.Text, TextBox13.Text)
        If opResult Then
            MsgBox("Email modificado correctamente", vbOKOnly + vbInformation, "Email modificado")
            GetList()
            ClearModifierFields()
            TabControl1.SelectTab(0)
        Else
            MsgBox("No se pudo modificar el email", vbOKOnly + vbCritical, "Error al modificar")
        End If
    End Sub

End Class