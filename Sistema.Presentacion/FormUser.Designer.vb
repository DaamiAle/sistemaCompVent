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
        Me.emailNeeded = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.roleNeeded = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.documentNeeded = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.nameNeeded = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.idLabelMant = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.AccessBox = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.passwordNeeded = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.newPassword1Needed = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.newPassword2Needed = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgvList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.emailNeeded, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.roleNeeded, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.documentNeeded, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nameNeeded, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AccessBox.SuspendLayout()
        CType(Me.passwordNeeded, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.newPassword1Needed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.newPassword2Needed, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TabPage2.Controls.Add(Me.Button2)
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.AccessBox)
        Me.TabPage2.Controls.Add(Me.ComboBox2)
        Me.TabPage2.Controls.Add(Me.TextBox7)
        Me.TabPage2.Controls.Add(Me.TextBox6)
        Me.TabPage2.Controls.Add(Me.TextBox5)
        Me.TabPage2.Controls.Add(Me.TextBox4)
        Me.TabPage2.Controls.Add(Me.TextBox2)
        Me.TabPage2.Controls.Add(Me.ComboBox1)
        Me.TabPage2.Controls.Add(Me.TextBox1)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.idLabelMant)
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
        Me.btnDelete.Visible = False
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
        Me.btnEnableDisable.Visible = False
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
        Me.btnModify.Visible = False
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
        'emailNeeded
        '
        Me.emailNeeded.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.emailNeeded.ContainerControl = Me
        '
        'roleNeeded
        '
        Me.roleNeeded.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.roleNeeded.ContainerControl = Me
        '
        'documentNeeded
        '
        Me.documentNeeded.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.documentNeeded.ContainerControl = Me
        '
        'nameNeeded
        '
        Me.nameNeeded.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.nameNeeded.ContainerControl = Me
        '
        'idLabelMant
        '
        Me.idLabelMant.Location = New System.Drawing.Point(8, 17)
        Me.idLabelMant.Name = "idLabelMant"
        Me.idLabelMant.Size = New System.Drawing.Size(128, 16)
        Me.idLabelMant.TabIndex = 12
        Me.idLabelMant.Text = "Id:"
        Me.idLabelMant.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 16)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Rol:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 16)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Nombre:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 16)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Tipo de documento:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 16)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Documento:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 152)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 16)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Domicilio:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(8, 179)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(128, 16)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Teléfono:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(8, 201)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(128, 16)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Estado:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(142, 16)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(128, 20)
        Me.TextBox1.TabIndex = 20
        '
        'ComboBox1
        '
        Me.roleNeeded.SetError(Me.ComboBox1, "Rol es un campo obligatorio.")
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(142, 42)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(128, 21)
        Me.ComboBox1.TabIndex = 21
        '
        'TextBox2
        '
        Me.nameNeeded.SetError(Me.TextBox2, "Nombre es un campo obligatorio.")
        Me.TextBox2.Location = New System.Drawing.Point(142, 69)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(128, 20)
        Me.TextBox2.TabIndex = 22
        '
        'TextBox4
        '
        Me.documentNeeded.SetError(Me.TextBox4, "Documento es un campo obligatorio.")
        Me.TextBox4.Location = New System.Drawing.Point(142, 122)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(128, 20)
        Me.TextBox4.TabIndex = 24
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(142, 148)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(128, 20)
        Me.TextBox5.TabIndex = 25
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(142, 174)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(128, 20)
        Me.TextBox6.TabIndex = 26
        '
        'TextBox7
        '
        Me.TextBox7.Enabled = False
        Me.TextBox7.Location = New System.Drawing.Point(142, 200)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(128, 20)
        Me.TextBox7.TabIndex = 27
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"DNI", "Pasaporte", "Cedula", "Carnet"})
        Me.ComboBox2.Location = New System.Drawing.Point(142, 95)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(128, 21)
        Me.ComboBox2.TabIndex = 23
        Me.ComboBox2.Text = "DNI"
        '
        'AccessBox
        '
        Me.AccessBox.Controls.Add(Me.Button3)
        Me.AccessBox.Controls.Add(Me.Label11)
        Me.AccessBox.Controls.Add(Me.TextBox3)
        Me.AccessBox.Controls.Add(Me.TextBox12)
        Me.AccessBox.Controls.Add(Me.Label10)
        Me.AccessBox.Controls.Add(Me.TextBox11)
        Me.AccessBox.Controls.Add(Me.TextBox10)
        Me.AccessBox.Controls.Add(Me.TextBox9)
        Me.AccessBox.Controls.Add(Me.TextBox8)
        Me.AccessBox.Controls.Add(Me.Label9)
        Me.AccessBox.Controls.Add(Me.Label8)
        Me.AccessBox.Location = New System.Drawing.Point(320, 16)
        Me.AccessBox.Name = "AccessBox"
        Me.AccessBox.Size = New System.Drawing.Size(304, 273)
        Me.AccessBox.TabIndex = 28
        Me.AccessBox.TabStop = False
        Me.AccessBox.Text = "Acceso"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(6, 26)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 16)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "e-mail:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(6, 80)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 16)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "Contraseña:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox8
        '
        Me.emailNeeded.SetError(Me.TextBox8, "E-mail es un campo obligatorio.")
        Me.TextBox8.Location = New System.Drawing.Point(9, 53)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(256, 20)
        Me.TextBox8.TabIndex = 29
        '
        'TextBox9
        '
        Me.passwordNeeded.SetError(Me.TextBox9, "Contraseña es un campo obligatorio")
        Me.TextBox9.Location = New System.Drawing.Point(9, 105)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(256, 20)
        Me.TextBox9.TabIndex = 31
        '
        'TextBox10
        '
        Me.TextBox10.Enabled = False
        Me.TextBox10.Location = New System.Drawing.Point(9, 157)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(256, 20)
        Me.TextBox10.TabIndex = 33
        Me.TextBox10.Text = "Ingresar contraseña"
        Me.TextBox10.Visible = False
        '
        'TextBox11
        '
        Me.TextBox11.Enabled = False
        Me.TextBox11.Location = New System.Drawing.Point(9, 183)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(256, 20)
        Me.TextBox11.TabIndex = 34
        Me.TextBox11.Text = "Repetir contraseña"
        Me.TextBox11.Visible = False
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(424, 295)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 64)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "Cambiar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "E-mail"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(6, 132)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(128, 16)
        Me.Label10.TabIndex = 35
        Me.Label10.Text = "Nueva Contraseña:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label10.Visible = False
        '
        'passwordNeeded
        '
        Me.passwordNeeded.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.passwordNeeded.ContainerControl = Me
        '
        'newPassword1Needed
        '
        Me.newPassword1Needed.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.newPassword1Needed.ContainerControl = Me
        '
        'newPassword2Needed
        '
        Me.newPassword2Needed.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.newPassword2Needed.ContainerControl = Me
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Location = New System.Drawing.Point(528, 295)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 64)
        Me.Button2.TabIndex = 30
        Me.Button2.Text = "Cambiar Contraseña"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(6, 148)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(128, 16)
        Me.Label11.TabIndex = 38
        Me.Label11.Text = "Nueva Contraseña:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label11.Visible = False
        '
        'TextBox3
        '
        Me.TextBox3.Enabled = False
        Me.TextBox3.Location = New System.Drawing.Point(9, 199)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(256, 20)
        Me.TextBox3.TabIndex = 37
        Me.TextBox3.Text = "Repetir contraseña"
        Me.TextBox3.Visible = False
        '
        'TextBox12
        '
        Me.TextBox12.Enabled = False
        Me.TextBox12.Location = New System.Drawing.Point(9, 173)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(256, 20)
        Me.TextBox12.TabIndex = 36
        Me.TextBox12.Text = "Ingresar contraseña"
        Me.TextBox12.Visible = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(9, 244)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(256, 23)
        Me.Button3.TabIndex = 39
        Me.Button3.Text = "Habilitar edicion de e-mail"
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.Visible = False
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
        Me.TabPage2.PerformLayout()
        CType(Me.emailNeeded, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.roleNeeded, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.documentNeeded, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nameNeeded, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AccessBox.ResumeLayout(False)
        Me.AccessBox.PerformLayout()
        CType(Me.passwordNeeded, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.newPassword1Needed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.newPassword2Needed, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents emailNeeded As ErrorProvider
    Friend WithEvents roleNeeded As ErrorProvider
    Friend WithEvents documentNeeded As ErrorProvider
    Friend WithEvents nameNeeded As ErrorProvider
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents idLabelMant As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents AccessBox As GroupBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents passwordNeeded As ErrorProvider
    Friend WithEvents newPassword1Needed As ErrorProvider
    Friend WithEvents newPassword2Needed As ErrorProvider
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox12 As TextBox
End Class
