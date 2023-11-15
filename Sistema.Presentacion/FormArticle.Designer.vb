<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormArticle
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
        Me.nameNeeded = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.cboxCategories = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
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
        Me.rowSelector = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.searchValueTxtBox = New System.Windows.Forms.TextBox()
        Me.totalCount = New System.Windows.Forms.Label()
        Me.dgvListado = New System.Windows.Forms.DataGridView()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnDeleteMulti = New System.Windows.Forms.Button()
        Me.btnDisableMulti = New System.Windows.Forms.Button()
        Me.btnEnableMulti = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.btnClearSearchValue = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pathImage = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnChargeImage = New System.Windows.Forms.Button()
        Me.imageBox = New System.Windows.Forms.PictureBox()
        Me.stockNeeded = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.priceNeeded = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.nameNeeded, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.imageBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.stockNeeded, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.priceNeeded, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'nameNeeded
        '
        Me.nameNeeded.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.nameNeeded.ContainerControl = Me
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.imageBox)
        Me.TabPage2.Controls.Add(Me.btnChargeImage)
        Me.TabPage2.Controls.Add(Me.pathImage)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.TextBox2)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.TextBox3)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.TextBox1)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.cboxCategories)
        Me.TabPage2.Controls.Add(Me.Label2)
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
        'cboxCategories
        '
        Me.cboxCategories.FormattingEnabled = True
        Me.cboxCategories.Location = New System.Drawing.Point(96, 34)
        Me.cboxCategories.Name = "cboxCategories"
        Me.cboxCategories.Size = New System.Drawing.Size(128, 21)
        Me.cboxCategories.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 16)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Categoría:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.btnDelete.Location = New System.Drawing.Point(320, 295)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(96, 64)
        Me.btnDelete.TabIndex = 11
        Me.btnDelete.Text = "Eliminar"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnEnableDisable
        '
        Me.btnEnableDisable.Enabled = False
        Me.btnEnableDisable.Location = New System.Drawing.Point(216, 295)
        Me.btnEnableDisable.Name = "btnEnableDisable"
        Me.btnEnableDisable.Size = New System.Drawing.Size(96, 64)
        Me.btnEnableDisable.TabIndex = 10
        Me.btnEnableDisable.Text = "Habilitar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "/" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Deshabilitar"
        Me.btnEnableDisable.UseVisualStyleBackColor = True
        '
        'btnModify
        '
        Me.btnModify.Enabled = False
        Me.btnModify.Location = New System.Drawing.Point(112, 295)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(96, 64)
        Me.btnModify.TabIndex = 9
        Me.btnModify.Text = "Aplicar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Modificaciones"
        Me.btnModify.UseVisualStyleBackColor = True
        '
        'btnInsertNew
        '
        Me.btnInsertNew.Location = New System.Drawing.Point(8, 295)
        Me.btnInsertNew.Name = "btnInsertNew"
        Me.btnInsertNew.Size = New System.Drawing.Size(96, 64)
        Me.btnInsertNew.TabIndex = 8
        Me.btnInsertNew.Text = "Registrar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Nueva" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Categoría"
        Me.btnInsertNew.UseVisualStyleBackColor = True
        '
        'descriptionTextBox
        '
        Me.descriptionTextBox.Location = New System.Drawing.Point(96, 215)
        Me.descriptionTextBox.Multiline = True
        Me.descriptionTextBox.Name = "descriptionTextBox"
        Me.descriptionTextBox.Size = New System.Drawing.Size(256, 64)
        Me.descriptionTextBox.TabIndex = 7
        '
        'stateBox
        '
        Me.stateBox.Enabled = False
        Me.stateBox.Location = New System.Drawing.Point(96, 191)
        Me.stateBox.Name = "stateBox"
        Me.stateBox.Size = New System.Drawing.Size(128, 20)
        Me.stateBox.TabIndex = 6
        '
        'nameTextBox
        '
        Me.nameTextBox.Location = New System.Drawing.Point(96, 61)
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
        Me.Label3.Location = New System.Drawing.Point(8, 215)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Descripción:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'stateLabelMant
        '
        Me.stateLabelMant.Location = New System.Drawing.Point(8, 191)
        Me.stateLabelMant.Name = "stateLabelMant"
        Me.stateLabelMant.Size = New System.Drawing.Size(80, 16)
        Me.stateLabelMant.TabIndex = 2
        Me.stateLabelMant.Text = "Estado:"
        Me.stateLabelMant.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Código:"
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
        'rowSelector
        '
        Me.rowSelector.HeaderText = "Seleccionar"
        Me.rowSelector.Name = "rowSelector"
        Me.rowSelector.ReadOnly = True
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
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(800, 450)
        Me.TabControl1.TabIndex = 1
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
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(96, 87)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(128, 20)
        Me.TextBox1.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 16)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Nombre:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(96, 139)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(128, 20)
        Me.TextBox2.TabIndex = 20
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 16)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Stock:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(96, 113)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(128, 20)
        Me.TextBox3.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(8, 113)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 16)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Precio ($):"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pathImage
        '
        Me.pathImage.Enabled = False
        Me.pathImage.Location = New System.Drawing.Point(96, 165)
        Me.pathImage.Name = "pathImage"
        Me.pathImage.Size = New System.Drawing.Size(128, 20)
        Me.pathImage.TabIndex = 22
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(8, 165)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 16)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Imagen:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnChargeImage
        '
        Me.btnChargeImage.Location = New System.Drawing.Point(256, 162)
        Me.btnChargeImage.Name = "btnChargeImage"
        Me.btnChargeImage.Size = New System.Drawing.Size(96, 23)
        Me.btnChargeImage.TabIndex = 23
        Me.btnChargeImage.Text = "Seleccionar"
        Me.btnChargeImage.UseVisualStyleBackColor = True
        '
        'imageBox
        '
        Me.imageBox.BackColor = System.Drawing.Color.Gainsboro
        Me.imageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.imageBox.Location = New System.Drawing.Point(358, 8)
        Me.imageBox.Name = "imageBox"
        Me.imageBox.Size = New System.Drawing.Size(302, 271)
        Me.imageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imageBox.TabIndex = 24
        Me.imageBox.TabStop = False
        '
        'stockNeeded
        '
        Me.stockNeeded.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.stockNeeded.ContainerControl = Me
        '
        'priceNeeded
        '
        Me.priceNeeded.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.priceNeeded.ContainerControl = Me
        '
        'FormArticle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "FormArticle"
        Me.Text = "FormArticle"
        CType(Me.nameNeeded, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dgvListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.imageBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.stockNeeded, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.priceNeeded, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents nameNeeded As ErrorProvider
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents btnDeleteMulti As Button
    Friend WithEvents btnDisableMulti As Button
    Friend WithEvents btnEnableMulti As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents btnClearSearchValue As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents searchValueTxtBox As TextBox
    Friend WithEvents totalCount As Label
    Friend WithEvents dgvListado As DataGridView
    Friend WithEvents rowSelector As DataGridViewCheckBoxColumn
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents btnClearFields As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEnableDisable As Button
    Friend WithEvents btnModify As Button
    Friend WithEvents btnInsertNew As Button
    Friend WithEvents descriptionTextBox As TextBox
    Friend WithEvents stateBox As TextBox
    Friend WithEvents nameTextBox As TextBox
    Friend WithEvents idTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents stateLabelMant As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents idLabelMant As Label
    Friend WithEvents cboxCategories As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents imageBox As PictureBox
    Friend WithEvents btnChargeImage As Button
    Friend WithEvents pathImage As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents stockNeeded As ErrorProvider
    Friend WithEvents priceNeeded As ErrorProvider
End Class
