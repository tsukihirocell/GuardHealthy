<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InputInfoPage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        lbl_AboutYourself = New Label()
        lbl_ProvideInfo = New Label()
        lbl_FirstName = New Label()
        lbl_MiddleName = New Label()
        lbl_LastName = New Label()
        txt_FirstName = New RoundedTextBox()
        pnl_FirstName = New RoundedPanel()
        RoundedPanel2 = New RoundedPanel()
        txt_MiddleName = New RoundedTextBox()
        RoundedPanel3 = New RoundedPanel()
        txt_LastName = New RoundedTextBox()
        lbl_BirthDate = New Label()
        dtp_BirthDate = New DateTimePicker()
        lbl_Sex = New Label()
        cmb_Sex = New ComboBox()
        pnl_PhoneNumber = New RoundedPanel()
        txt_PhoneNumber = New RoundedTextBox()
        pnl_Guardian = New RoundedPanel()
        txt_Guardian = New RoundedTextBox()
        pnl_Address = New RoundedPanel()
        txt_Address = New RoundedTextBox()
        lbl_PhoneNumber = New Label()
        lbl_Guardian = New Label()
        lbl_Address = New Label()
        pnl_Email = New RoundedPanel()
        RoundedTextBox7 = New RoundedTextBox()
        lbl_Email = New Label()
        btn_Save = New Button()
        pnl_FirstName.SuspendLayout()
        RoundedPanel2.SuspendLayout()
        RoundedPanel3.SuspendLayout()
        pnl_PhoneNumber.SuspendLayout()
        pnl_Guardian.SuspendLayout()
        pnl_Address.SuspendLayout()
        pnl_Email.SuspendLayout()
        SuspendLayout()
        ' 
        ' lbl_AboutYourself
        ' 
        lbl_AboutYourself.AutoSize = True
        lbl_AboutYourself.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_AboutYourself.Location = New Point(37, 22)
        lbl_AboutYourself.Name = "lbl_AboutYourself"
        lbl_AboutYourself.Size = New Size(259, 21)
        lbl_AboutYourself.TabIndex = 0
        lbl_AboutYourself.Text = "Tell us something about yourself"
        ' 
        ' lbl_ProvideInfo
        ' 
        lbl_ProvideInfo.AutoSize = True
        lbl_ProvideInfo.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_ProvideInfo.Location = New Point(38, 43)
        lbl_ProvideInfo.Name = "lbl_ProvideInfo"
        lbl_ProvideInfo.Size = New Size(308, 17)
        lbl_ProvideInfo.TabIndex = 1
        lbl_ProvideInfo.Text = "Only provide information that is true and correct."
        ' 
        ' lbl_FirstName
        ' 
        lbl_FirstName.AutoSize = True
        lbl_FirstName.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbl_FirstName.Location = New Point(37, 101)
        lbl_FirstName.Name = "lbl_FirstName"
        lbl_FirstName.Size = New Size(71, 17)
        lbl_FirstName.TabIndex = 2
        lbl_FirstName.Text = "First Name"
        ' 
        ' lbl_MiddleName
        ' 
        lbl_MiddleName.AutoSize = True
        lbl_MiddleName.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbl_MiddleName.Location = New Point(37, 171)
        lbl_MiddleName.Name = "lbl_MiddleName"
        lbl_MiddleName.Size = New Size(88, 17)
        lbl_MiddleName.TabIndex = 3
        lbl_MiddleName.Text = "Middle Name"
        ' 
        ' lbl_LastName
        ' 
        lbl_LastName.AutoSize = True
        lbl_LastName.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbl_LastName.Location = New Point(37, 242)
        lbl_LastName.Name = "lbl_LastName"
        lbl_LastName.Size = New Size(70, 17)
        lbl_LastName.TabIndex = 4
        lbl_LastName.Text = "Last Name"
        ' 
        ' txt_FirstName
        ' 
        txt_FirstName.BackColor = SystemColors.ControlLight
        txt_FirstName.Location = New Point(3, 5)
        txt_FirstName.Name = "txt_FirstName"
        txt_FirstName.Size = New Size(284, 23)
        txt_FirstName.TabIndex = 5
        ' 
        ' pnl_FirstName
        ' 
        pnl_FirstName.BackColor = SystemColors.ControlLight
        pnl_FirstName.Controls.Add(txt_FirstName)
        pnl_FirstName.CornerRadius = 20
        pnl_FirstName.Location = New Point(37, 121)
        pnl_FirstName.Name = "pnl_FirstName"
        pnl_FirstName.Size = New Size(299, 34)
        pnl_FirstName.TabIndex = 6
        ' 
        ' RoundedPanel2
        ' 
        RoundedPanel2.BackColor = SystemColors.ControlLight
        RoundedPanel2.Controls.Add(txt_MiddleName)
        RoundedPanel2.CornerRadius = 20
        RoundedPanel2.Location = New Point(37, 191)
        RoundedPanel2.Name = "RoundedPanel2"
        RoundedPanel2.Size = New Size(299, 34)
        RoundedPanel2.TabIndex = 7
        ' 
        ' txt_MiddleName
        ' 
        txt_MiddleName.BackColor = SystemColors.ControlLight
        txt_MiddleName.Location = New Point(3, 5)
        txt_MiddleName.Name = "txt_MiddleName"
        txt_MiddleName.Size = New Size(284, 23)
        txt_MiddleName.TabIndex = 5
        ' 
        ' RoundedPanel3
        ' 
        RoundedPanel3.BackColor = SystemColors.ControlLight
        RoundedPanel3.Controls.Add(txt_LastName)
        RoundedPanel3.CornerRadius = 20
        RoundedPanel3.Location = New Point(37, 262)
        RoundedPanel3.Name = "RoundedPanel3"
        RoundedPanel3.Size = New Size(299, 34)
        RoundedPanel3.TabIndex = 8
        ' 
        ' txt_LastName
        ' 
        txt_LastName.BackColor = SystemColors.ControlLight
        txt_LastName.Location = New Point(3, 5)
        txt_LastName.Name = "txt_LastName"
        txt_LastName.Size = New Size(284, 23)
        txt_LastName.TabIndex = 5
        ' 
        ' lbl_BirthDate
        ' 
        lbl_BirthDate.AutoSize = True
        lbl_BirthDate.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbl_BirthDate.Location = New Point(38, 313)
        lbl_BirthDate.Name = "lbl_BirthDate"
        lbl_BirthDate.Size = New Size(65, 17)
        lbl_BirthDate.TabIndex = 9
        lbl_BirthDate.Text = "Birth Date"
        ' 
        ' dtp_BirthDate
        ' 
        dtp_BirthDate.Location = New Point(38, 340)
        dtp_BirthDate.Name = "dtp_BirthDate"
        dtp_BirthDate.Size = New Size(200, 23)
        dtp_BirthDate.TabIndex = 10
        ' 
        ' lbl_Sex
        ' 
        lbl_Sex.AutoSize = True
        lbl_Sex.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbl_Sex.Location = New Point(250, 313)
        lbl_Sex.Name = "lbl_Sex"
        lbl_Sex.Size = New Size(28, 17)
        lbl_Sex.TabIndex = 11
        lbl_Sex.Text = "Sex"
        ' 
        ' cmb_Sex
        ' 
        cmb_Sex.FormattingEnabled = True
        cmb_Sex.Location = New Point(250, 340)
        cmb_Sex.Name = "cmb_Sex"
        cmb_Sex.Size = New Size(86, 23)
        cmb_Sex.TabIndex = 12
        ' 
        ' pnl_PhoneNumber
        ' 
        pnl_PhoneNumber.BackColor = SystemColors.ControlLight
        pnl_PhoneNumber.Controls.Add(txt_PhoneNumber)
        pnl_PhoneNumber.CornerRadius = 20
        pnl_PhoneNumber.Location = New Point(37, 532)
        pnl_PhoneNumber.Name = "pnl_PhoneNumber"
        pnl_PhoneNumber.Size = New Size(299, 34)
        pnl_PhoneNumber.TabIndex = 14
        ' 
        ' txt_PhoneNumber
        ' 
        txt_PhoneNumber.BackColor = SystemColors.ControlLight
        txt_PhoneNumber.Location = New Point(3, 5)
        txt_PhoneNumber.Name = "txt_PhoneNumber"
        txt_PhoneNumber.Size = New Size(284, 23)
        txt_PhoneNumber.TabIndex = 5
        ' 
        ' pnl_Guardian
        ' 
        pnl_Guardian.BackColor = SystemColors.ControlLight
        pnl_Guardian.Controls.Add(txt_Guardian)
        pnl_Guardian.CornerRadius = 20
        pnl_Guardian.Location = New Point(37, 465)
        pnl_Guardian.Name = "pnl_Guardian"
        pnl_Guardian.Size = New Size(299, 34)
        pnl_Guardian.TabIndex = 13
        ' 
        ' txt_Guardian
        ' 
        txt_Guardian.BackColor = SystemColors.ControlLight
        txt_Guardian.Location = New Point(3, 5)
        txt_Guardian.Name = "txt_Guardian"
        txt_Guardian.Size = New Size(284, 23)
        txt_Guardian.TabIndex = 5
        ' 
        ' pnl_Address
        ' 
        pnl_Address.BackColor = SystemColors.ControlLight
        pnl_Address.Controls.Add(txt_Address)
        pnl_Address.CornerRadius = 20
        pnl_Address.Location = New Point(37, 404)
        pnl_Address.Name = "pnl_Address"
        pnl_Address.Size = New Size(299, 34)
        pnl_Address.TabIndex = 12
        ' 
        ' txt_Address
        ' 
        txt_Address.BackColor = SystemColors.ControlLight
        txt_Address.Location = New Point(3, 5)
        txt_Address.Name = "txt_Address"
        txt_Address.Size = New Size(284, 23)
        txt_Address.TabIndex = 5
        ' 
        ' lbl_PhoneNumber
        ' 
        lbl_PhoneNumber.AutoSize = True
        lbl_PhoneNumber.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbl_PhoneNumber.Location = New Point(37, 512)
        lbl_PhoneNumber.Name = "lbl_PhoneNumber"
        lbl_PhoneNumber.Size = New Size(96, 17)
        lbl_PhoneNumber.TabIndex = 11
        lbl_PhoneNumber.Text = "Phone Number"
        ' 
        ' lbl_Guardian
        ' 
        lbl_Guardian.AutoSize = True
        lbl_Guardian.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbl_Guardian.Location = New Point(37, 445)
        lbl_Guardian.Name = "lbl_Guardian"
        lbl_Guardian.Size = New Size(103, 17)
        lbl_Guardian.TabIndex = 10
        lbl_Guardian.Text = "Parent/Guardian"
        ' 
        ' lbl_Address
        ' 
        lbl_Address.AutoSize = True
        lbl_Address.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbl_Address.Location = New Point(37, 384)
        lbl_Address.Name = "lbl_Address"
        lbl_Address.Size = New Size(56, 17)
        lbl_Address.TabIndex = 9
        lbl_Address.Text = "Address"
        ' 
        ' pnl_Email
        ' 
        pnl_Email.BackColor = SystemColors.ControlLight
        pnl_Email.Controls.Add(RoundedTextBox7)
        pnl_Email.CornerRadius = 20
        pnl_Email.Location = New Point(37, 594)
        pnl_Email.Name = "pnl_Email"
        pnl_Email.Size = New Size(299, 34)
        pnl_Email.TabIndex = 16
        ' 
        ' RoundedTextBox7
        ' 
        RoundedTextBox7.BackColor = SystemColors.ControlLight
        RoundedTextBox7.Location = New Point(3, 5)
        RoundedTextBox7.Name = "RoundedTextBox7"
        RoundedTextBox7.Size = New Size(284, 23)
        RoundedTextBox7.TabIndex = 5
        ' 
        ' lbl_Email
        ' 
        lbl_Email.AutoSize = True
        lbl_Email.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbl_Email.Location = New Point(37, 574)
        lbl_Email.Name = "lbl_Email"
        lbl_Email.Size = New Size(39, 17)
        lbl_Email.TabIndex = 15
        lbl_Email.Text = "Email"
        ' 
        ' btn_Save
        ' 
        btn_Save.Location = New Point(37, 647)
        btn_Save.Name = "btn_Save"
        btn_Save.Size = New Size(299, 36)
        btn_Save.TabIndex = 17
        btn_Save.Text = "Save"
        btn_Save.UseVisualStyleBackColor = True
        ' 
        ' InputInfoPage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(384, 711)
        Controls.Add(btn_Save)
        Controls.Add(pnl_Email)
        Controls.Add(lbl_Email)
        Controls.Add(pnl_PhoneNumber)
        Controls.Add(cmb_Sex)
        Controls.Add(pnl_Guardian)
        Controls.Add(lbl_Sex)
        Controls.Add(pnl_Address)
        Controls.Add(lbl_PhoneNumber)
        Controls.Add(dtp_BirthDate)
        Controls.Add(lbl_Guardian)
        Controls.Add(lbl_BirthDate)
        Controls.Add(lbl_Address)
        Controls.Add(RoundedPanel3)
        Controls.Add(RoundedPanel2)
        Controls.Add(pnl_FirstName)
        Controls.Add(lbl_LastName)
        Controls.Add(lbl_MiddleName)
        Controls.Add(lbl_FirstName)
        Controls.Add(lbl_ProvideInfo)
        Controls.Add(lbl_AboutYourself)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "InputInfoPage"
        StartPosition = FormStartPosition.CenterScreen
        Text = "InputInfoPage"
        pnl_FirstName.ResumeLayout(False)
        pnl_FirstName.PerformLayout()
        RoundedPanel2.ResumeLayout(False)
        RoundedPanel2.PerformLayout()
        RoundedPanel3.ResumeLayout(False)
        RoundedPanel3.PerformLayout()
        pnl_PhoneNumber.ResumeLayout(False)
        pnl_PhoneNumber.PerformLayout()
        pnl_Guardian.ResumeLayout(False)
        pnl_Guardian.PerformLayout()
        pnl_Address.ResumeLayout(False)
        pnl_Address.PerformLayout()
        pnl_Email.ResumeLayout(False)
        pnl_Email.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lbl_AboutYourself As Label
    Friend WithEvents lbl_ProvideInfo As Label
    Friend WithEvents lbl_FirstName As Label
    Friend WithEvents lbl_MiddleName As Label
    Friend WithEvents lbl_LastName As Label
    Friend WithEvents txt_FirstName As RoundedTextBox
    Friend WithEvents pnl_FirstName As RoundedPanel
    Friend WithEvents RoundedPanel2 As RoundedPanel
    Friend WithEvents txt_MiddleName As RoundedTextBox
    Friend WithEvents RoundedPanel3 As RoundedPanel
    Friend WithEvents txt_LastName As RoundedTextBox
    Friend WithEvents lbl_BirthDate As Label
    Friend WithEvents dtp_BirthDate As DateTimePicker
    Friend WithEvents lbl_Sex As Label
    Friend WithEvents cmb_Sex As ComboBox
    Friend WithEvents pnl_PhoneNumber As RoundedPanel
    Friend WithEvents txt_PhoneNumber As RoundedTextBox
    Friend WithEvents pnl_Guardian As RoundedPanel
    Friend WithEvents txt_Guardian As RoundedTextBox
    Friend WithEvents pnl_Address As RoundedPanel
    Friend WithEvents txt_Address As RoundedTextBox
    Friend WithEvents lbl_PhoneNumber As Label
    Friend WithEvents lbl_Guardian As Label
    Friend WithEvents lbl_Address As Label
    Friend WithEvents pnl_Email As RoundedPanel
    Friend WithEvents RoundedTextBox7 As RoundedTextBox
    Friend WithEvents lbl_Email As Label
    Friend WithEvents btn_Save As Button
End Class
