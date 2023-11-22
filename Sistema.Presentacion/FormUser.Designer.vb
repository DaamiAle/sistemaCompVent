<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUser
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
        Me.btnEnableMulti = New System.Windows.Forms.Button()
        Me.btnClearSearchValue = New System.Windows.Forms.Button()
        Me.btnDeleteMulti = New System.Windows.Forms.Button()
        Me.btnDisableMulti = New System.Windows.Forms.Button()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.searchValueTxtBox = New System.Windows.Forms.TextBox()
        Me.totalCount = New System.Windows.Forms.Label()
        Me.dgvList = New System.Windows.Forms.DataGridView()
        Me.rowSelector = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEnableDisable = New System.Windows.Forms.Button()
        Me.btnModify = New System.Windows.Forms.Button()
        Me.btnInsertNew = New System.Windows.Forms.Button()
        Me.stockNeeded = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.categoryNeeded = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.priceNeeded = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.nameNeeded = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TabPage1.SuspendLayout()
        CType(Me.dgvList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.stockNeeded, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.categoryNeeded, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.priceNeeded, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nameNeeded, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEnableMulti
        '
        Me.btnEnableMulti.Enabled = False
        Me.btnEnableMulti.Location = New System.Drawing.Point(126, 395)
        Me.btnEnableMulti.Name = "btnEnableMulti"
        Me.btnEnableMulti.Size = New System.Drawing.Size(96, 24)
        Me.btnEnableMulti.TabIndex = 12
        Me.btnEnableMulti.Text = "Habilitar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnEnableMulti.UseVisualStyleBackColor = True
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
        'btnDeleteMulti
        '
        Me.btnDeleteMulti.Enabled = False
        Me.btnDeleteMulti.Location = New System.Drawing.Point(334, 395)
        Me.btnDeleteMulti.Name = "btnDeleteMulti"
        Me.btnDeleteMulti.Size = New System.Drawing.Size(96, 24)
        Me.btnDeleteMulti.TabIndex = 14
        Me.btnDeleteMulti.Text = "Eliminar"
        Me.btnDeleteMulti.UseVisualStyleBackColor = True
        '
        'btnDisableMulti
        '
        Me.btnDisableMulti.Enabled = False
        Me.btnDisableMulti.Location = New System.Drawing.Point(230, 395)
        Me.btnDisableMulti.Name = "btnDisableMulti"
        Me.btnDisableMulti.Size = New System.Drawing.Size(96, 24)
        Me.btnDisableMulti.TabIndex = 13
        Me.btnDisableMulti.Text = "Deshabilitar"
        Me.btnDisableMulti.UseVisualStyleBackColor = True
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnDeleteMulti)
        Me.TabPage1.Controls.Add(Me.btnDisableMulti)
        Me.TabPage1.Controls.Add(Me.btnEnableMulti)
        Me.TabPage1.Controls.Add(Me.CheckBox1)
        Me.TabPage1.Controls.Add(Me.btnClearSearchValue)
        Me.TabPage1.Controls.Add(Me.searchValueTxtBox)
        Me.TabPage1.Controls.Add(Me.totalCount)
        Me.TabPage1.Controls.Add(Me.dgvList)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(792, 424)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Listado"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(8, 399)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(112, 17)
        Me.CheckBox1.TabIndex = 5
        Me.CheckBox1.Text = "Seleccion Multiple"
        Me.CheckBox1.UseVisualStyleBackColor = True
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
        'dgvList
        '
        Me.dgvList.AllowUserToAddRows = False
        Me.dgvList.AllowUserToDeleteRows = False
        Me.dgvList.AllowUserToOrderColumns = True
        Me.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.rowSelector})
        Me.dgvList.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgvList.Location = New System.Drawing.Point(3, 3)
        Me.dgvList.Name = "dgvList"
        Me.dgvList.ReadOnly = True
        Me.dgvList.Size = New System.Drawing.Size(786, 360)
        Me.dgvList.TabIndex = 0
        '
        'rowSelector
        '
        Me.rowSelector.HeaderText = "Seleccionar"
        Me.rowSelector.Name = "rowSelector"
        Me.rowSelector.ReadOnly = True
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
        Me.TabControl1.TabIndex = 2
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnDelete)
        Me.TabPage2.Controls.Add(Me.btnEnableDisable)
        Me.TabPage2.Controls.Add(Me.btnModify)
        Me.TabPage2.Controls.Add(Me.btnInsertNew)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(792, 424)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Mantenimiento"
        Me.TabPage2.UseVisualStyleBackColor = True
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
        Me.btnInsertNew.Text = "Registrar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Nuevo"
        Me.btnInsertNew.UseVisualStyleBackColor = True
        '
        'stockNeeded
        '
        Me.stockNeeded.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.stockNeeded.ContainerControl = Me
        '
        'categoryNeeded
        '
        Me.categoryNeeded.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.categoryNeeded.ContainerControl = Me
        '
        'priceNeeded
        '
        Me.priceNeeded.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.priceNeeded.ContainerControl = Me
        '
        'nameNeeded
        '
        Me.nameNeeded.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.nameNeeded.ContainerControl = Me
        '
        'FormUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "FormUser"
        Me.Text = "FormUser"
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.dgvList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.stockNeeded, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.categoryNeeded, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.priceNeeded, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nameNeeded, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnEnableMulti As Button
    Friend WithEvents btnClearSearchValue As Button
    Friend WithEvents btnDeleteMulti As Button
    Friend WithEvents btnDisableMulti As Button
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents searchValueTxtBox As TextBox
    Friend WithEvents totalCount As Label
    Friend WithEvents dgvList As DataGridView
    Friend WithEvents rowSelector As DataGridViewCheckBoxColumn
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEnableDisable As Button
    Friend WithEvents btnModify As Button
    Friend WithEvents btnInsertNew As Button
    Friend WithEvents stockNeeded As ErrorProvider
    Friend WithEvents categoryNeeded As ErrorProvider
    Friend WithEvents priceNeeded As ErrorProvider
    Friend WithEvents nameNeeded As ErrorProvider
End Class
