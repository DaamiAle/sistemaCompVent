<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCategorias
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnDeleteMulti = New System.Windows.Forms.Button()
        Me.btnDisableMulti = New System.Windows.Forms.Button()
        Me.btnEnableMulti = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.btnClearSearchValue = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.searchValueTxtBox = New System.Windows.Forms.TextBox()
        Me.totalCount = New System.Windows.Forms.Label()
        Me.dgvListado = New System.Windows.Forms.DataGridView()
        Me.rowSelector = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnClearFields = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEnableDisable = New System.Windows.Forms.Button()
        Me.btnModify = New System.Windows.Forms.Button()
        Me.btnInsertNew = New System.Windows.Forms.Button()
        Me.descriptionTextBox = New System.Windows.Forms.TextBox()
        Me.stateBox = New System.Windows.Forms.TextBox()
        Me.nameTextBox = New System.Windows.Forms.TextBox()
        Me.idTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.stateLabelMant = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.idLabelMant = New System.Windows.Forms.Label()
        Me.nameNeeded = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgvListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.nameNeeded, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(800, 450)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnDeleteMulti)
        Me.TabPage1.Controls.Add(Me.btnDisableMulti)
        Me.TabPage1.Controls.Add(Me.btnEnableMulti)
        Me.TabPage1.Controls.Add(Me.CheckBox1)
        Me.TabPage1.Controls.Add(Me.btnClearSearchValue)
        Me.TabPage1.Controls.Add(Me.btnSearch)
        Me.TabPage1.Controls.Add(Me.searchValueTxtBox)
        Me.TabPage1.Controls.Add(Me.totalCount)
        Me.TabPage1.Controls.Add(Me.dgvListado)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(792, 424)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Listado"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnDeleteMulti
        '
        Me.btnDeleteMulti.Enabled = False
        Me.btnDeleteMulti.Location = New System.Drawing.Point(438, 395)
        Me.btnDeleteMulti.Name = "btnDeleteMulti"
        Me.btnDeleteMulti.Size = New System.Drawing.Size(96, 24)
        Me.btnDeleteMulti.TabIndex = 14
        Me.btnDeleteMulti.Text = "Eliminar"
        Me.btnDeleteMulti.UseVisualStyleBackColor = True
        '
        'btnDisableMulti
        '
        Me.btnDisableMulti.Enabled = False
        Me.btnDisableMulti.Location = New System.Drawing.Point(334, 395)
        Me.btnDisableMulti.Name = "btnDisableMulti"
        Me.btnDisableMulti.Size = New System.Drawing.Size(96, 24)
        Me.btnDisableMulti.TabIndex = 13
        Me.btnDisableMulti.Text = "Deshabilitar"
        Me.btnDisableMulti.UseVisualStyleBackColor = True
        '
        'btnEnableMulti
        '
        Me.btnEnableMulti.Enabled = False
        Me.btnEnableMulti.Location = New System.Drawing.Point(230, 395)
        Me.btnEnableMulti.Name = "btnEnableMulti"
        Me.btnEnableMulti.Size = New System.Drawing.Size(96, 24)
        Me.btnEnableMulti.TabIndex = 12
        Me.btnEnableMulti.Text = "Habilitar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnEnableMulti.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(112, 399)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(112, 17)
        Me.CheckBox1.TabIndex = 5
        Me.CheckBox1.Text = "Seleccion Multiple"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'btnClearSearchValue
        '
        Me.btnClearSearchValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 5.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearSearchValue.Location = New System.Drawing.Point(329, 367)
        Me.btnClearSearchValue.Name = "btnClearSearchValue"
        Me.btnClearSearchValue.Size = New System.Drawing.Size(23, 23)
        Me.btnClearSearchValue.TabIndex = 4
        Me.btnClearSearchValue.Text = "Clr"
        Me.btnClearSearchValue.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(8, 395)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(96, 23)
        Me.btnSearch.TabIndex = 3
        Me.btnSearch.Text = "Buscar"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'searchValueTxtBox
        '
        Me.searchValueTxtBox.Location = New System.Drawing.Point(8, 369)
        Me.searchValueTxtBox.Name = "searchValueTxtBox"
        Me.searchValueTxtBox.Size = New System.Drawing.Size(320, 20)
        Me.searchValueTxtBox.TabIndex = 2
        '
        'totalCount
        '
        Me.totalCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalCount.Location = New System.Drawing.Point(597, 366)
        Me.totalCount.Name = "totalCount"
        Me.totalCount.Size = New System.Drawing.Size(192, 55)
        Me.totalCount.TabIndex = 1
        Me.totalCount.Text = "Registros Totales: 000"
        Me.totalCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgvListado
        '
        Me.dgvListado.AllowUserToAddRows = False
        Me.dgvListado.AllowUserToDeleteRows = False
        Me.dgvListado.AllowUserToOrderColumns = True
        Me.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.rowSelector})
        Me.dgvListado.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgvListado.Location = New System.Drawing.Point(3, 3)
        Me.dgvListado.Name = "dgvListado"
        Me.dgvListado.ReadOnly = True
        Me.dgvListado.Size = New System.Drawing.Size(786, 360)
        Me.dgvListado.TabIndex = 0
        '
        'rowSelector
        '
        Me.rowSelector.HeaderText = "Seleccionar"
        Me.rowSelector.Name = "rowSelector"
        Me.rowSelector.ReadOnly = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnClearFields)
        Me.TabPage2.Controls.Add(Me.btnDelete)
        Me.TabPage2.Controls.Add(Me.btnEnableDisable)
        Me.TabPage2.Controls.Add(Me.btnModify)
        Me.TabPage2.Controls.Add(Me.btnInsertNew)
        Me.TabPage2.Controls.Add(Me.descriptionTextBox)
        Me.TabPage2.Controls.Add(Me.stateBox)
        Me.TabPage2.Controls.Add(Me.nameTextBox)
        Me.TabPage2.Controls.Add(Me.idTextBox)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.stateLabelMant)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.idLabelMant)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(792, 424)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Mantenimiento"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnClearFields
        '
        Me.btnClearFields.Enabled = False
        Me.btnClearFields.Location = New System.Drawing.Point(256, 8)
        Me.btnClearFields.Name = "btnClearFields"
        Me.btnClearFields.Size = New System.Drawing.Size(96, 64)
        Me.btnClearFields.TabIndex = 12
        Me.btnClearFields.Text = "Limpiar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Campos"
        Me.btnClearFields.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Enabled = False
        Me.btnDelete.Location = New System.Drawing.Point(320, 160)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(96, 64)
        Me.btnDelete.TabIndex = 11
        Me.btnDelete.Text = "Eliminar"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnEnableDisable
        '
        Me.btnEnableDisable.Enabled = False
        Me.btnEnableDisable.Location = New System.Drawing.Point(216, 160)
        Me.btnEnableDisable.Name = "btnEnableDisable"
        Me.btnEnableDisable.Size = New System.Drawing.Size(96, 64)
        Me.btnEnableDisable.TabIndex = 10
        Me.btnEnableDisable.Text = "Habilitar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "/" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Deshabilitar"
        Me.btnEnableDisable.UseVisualStyleBackColor = True
        '
        'btnModify
        '
        Me.btnModify.Enabled = False
        Me.btnModify.Location = New System.Drawing.Point(112, 160)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(96, 64)
        Me.btnModify.TabIndex = 9
        Me.btnModify.Text = "Aplicar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Modificaciones"
        Me.btnModify.UseVisualStyleBackColor = True
        '
        'btnInsertNew
        '
        Me.btnInsertNew.Location = New System.Drawing.Point(8, 160)
        Me.btnInsertNew.Name = "btnInsertNew"
        Me.btnInsertNew.Size = New System.Drawing.Size(96, 64)
        Me.btnInsertNew.TabIndex = 8
        Me.btnInsertNew.Text = "Registrar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Nueva" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Categoría"
        Me.btnInsertNew.UseVisualStyleBackColor = True
        '
        'descriptionTextBox
        '
        Me.descriptionTextBox.Location = New System.Drawing.Point(96, 80)
        Me.descriptionTextBox.Multiline = True
        Me.descriptionTextBox.Name = "descriptionTextBox"
        Me.descriptionTextBox.Size = New System.Drawing.Size(256, 64)
        Me.descriptionTextBox.TabIndex = 7
        '
        'stateBox
        '
        Me.stateBox.Enabled = False
        Me.stateBox.Location = New System.Drawing.Point(96, 56)
        Me.stateBox.Name = "stateBox"
        Me.stateBox.Size = New System.Drawing.Size(128, 20)
        Me.stateBox.TabIndex = 6
        '
        'nameTextBox
        '
        Me.nameTextBox.Location = New System.Drawing.Point(96, 32)
        Me.nameTextBox.Name = "nameTextBox"
        Me.nameTextBox.Size = New System.Drawing.Size(128, 20)
        Me.nameTextBox.TabIndex = 5
        '
        'idTextBox
        '
        Me.idTextBox.Enabled = False
        Me.idTextBox.Location = New System.Drawing.Point(96, 8)
        Me.idTextBox.Name = "idTextBox"
        Me.idTextBox.Size = New System.Drawing.Size(128, 20)
        Me.idTextBox.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Descripción:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'stateLabelMant
        '
        Me.stateLabelMant.Location = New System.Drawing.Point(8, 56)
        Me.stateLabelMant.Name = "stateLabelMant"
        Me.stateLabelMant.Size = New System.Drawing.Size(80, 16)
        Me.stateLabelMant.TabIndex = 2
        Me.stateLabelMant.Text = "Estado:"
        Me.stateLabelMant.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'idLabelMant
        '
        Me.idLabelMant.Location = New System.Drawing.Point(8, 8)
        Me.idLabelMant.Name = "idLabelMant"
        Me.idLabelMant.Size = New System.Drawing.Size(80, 16)
        Me.idLabelMant.TabIndex = 0
        Me.idLabelMant.Text = "Id:"
        Me.idLabelMant.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'nameNeeded
        '
        Me.nameNeeded.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.nameNeeded.ContainerControl = Me
        '
        'FormCategorias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "FormCategorias"
        Me.Text = "Categorias"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.dgvListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.nameNeeded, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents dgvListado As DataGridView
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents totalCount As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents searchValueTxtBox As TextBox
    Friend WithEvents btnClearSearchValue As Button
    Friend WithEvents idLabelMant As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents stateLabelMant As Label
    Friend WithEvents stateBox As TextBox
    Friend WithEvents nameTextBox As TextBox
    Friend WithEvents idTextBox As TextBox
    Friend WithEvents btnModify As Button
    Friend WithEvents btnInsertNew As Button
    Friend WithEvents descriptionTextBox As TextBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEnableDisable As Button
    Friend WithEvents btnClearFields As Button
    Friend WithEvents nameNeeded As ErrorProvider
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents rowSelector As DataGridViewCheckBoxColumn
    Friend WithEvents btnDisableMulti As Button
    Friend WithEvents btnEnableMulti As Button
    Friend WithEvents btnDeleteMulti As Button
End Class
