<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PatientRecord
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PatientRecord))
        pnl_Header = New Panel()
        Label3 = New Label()
        pic_Menu = New PictureBox()
        pic_LogoHeader = New PictureBox()
        pic_Exit = New PictureBox()
        pnl_Record = New RoundedPanel()
        lbl_Label21 = New Label()
        lbl_Diagnoses = New Label()
        lbl_Label19 = New Label()
        lbl_Label18 = New Label()
        lbl_Label17 = New Label()
        lbl_Label16 = New Label()
        lbl_Label15 = New Label()
        lbl_Label14 = New Label()
        pic_PhoneNumber = New CirclePictureBox()
        pic_Email = New CirclePictureBox()
        pic_Address = New CirclePictureBox()
        lbl_Address = New Label()
        lbl_Email = New Label()
        lbl_PhoneNumber = New Label()
        lbl_Contact = New Label()
        lbl_Guardian = New Label()
        lbl_BloodType = New Label()
        lbl_DateOfBirth = New Label()
        lbl_Sex = New Label()
        lbl_Age = New Label()
        lbl_MiddleName = New Label()
        lbl_FirstName = New Label()
        lbl_LastName = New Label()
        pnl_Header.SuspendLayout()
        CType(pic_Menu, ComponentModel.ISupportInitialize).BeginInit()
        CType(pic_LogoHeader, ComponentModel.ISupportInitialize).BeginInit()
        CType(pic_Exit, ComponentModel.ISupportInitialize).BeginInit()
        pnl_Record.SuspendLayout()
        CType(pic_PhoneNumber, ComponentModel.ISupportInitialize).BeginInit()
        CType(pic_Email, ComponentModel.ISupportInitialize).BeginInit()
        CType(pic_Address, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnl_Header
        ' 
        pnl_Header.BackColor = Color.Transparent
        pnl_Header.BorderStyle = BorderStyle.FixedSingle
        pnl_Header.Controls.Add(Label3)
        pnl_Header.Controls.Add(pic_Menu)
        pnl_Header.Controls.Add(pic_LogoHeader)
        pnl_Header.Location = New Point(-19, -5)
        pnl_Header.Name = "pnl_Header"
        pnl_Header.Size = New Size(422, 68)
        pnl_Header.TabIndex = 59
        ' 
        ' Label3
        ' 
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(22, 42)
        Label3.Name = "Label3"
        Label3.Size = New Size(47, 16)
        Label3.TabIndex = 5
        Label3.Text = "MENU"
        Label3.TextAlign = ContentAlignment.TopCenter
        ' 
        ' pic_Menu
        ' 
        pic_Menu.BackColor = Color.Transparent
        pic_Menu.Cursor = Cursors.Hand
        pic_Menu.Image = CType(resources.GetObject("pic_Menu.Image"), Image)
        pic_Menu.Location = New Point(24, 14)
        pic_Menu.Name = "pic_Menu"
        pic_Menu.Size = New Size(40, 25)
        pic_Menu.SizeMode = PictureBoxSizeMode.Zoom
        pic_Menu.TabIndex = 3
        pic_Menu.TabStop = False
        ' 
        ' pic_LogoHeader
        ' 
        pic_LogoHeader.BackColor = Color.Transparent
        pic_LogoHeader.Image = CType(resources.GetObject("pic_LogoHeader.Image"), Image)
        pic_LogoHeader.Location = New Point(48, -11)
        pic_LogoHeader.Name = "pic_LogoHeader"
        pic_LogoHeader.Size = New Size(142, 90)
        pic_LogoHeader.SizeMode = PictureBoxSizeMode.Zoom
        pic_LogoHeader.TabIndex = 2
        pic_LogoHeader.TabStop = False
        ' 
        ' pic_Exit
        ' 
        pic_Exit.BackColor = Color.Transparent
        pic_Exit.Cursor = Cursors.Hand
        pic_Exit.Image = CType(resources.GetObject("pic_Exit.Image"), Image)
        pic_Exit.Location = New Point(27, 87)
        pic_Exit.Name = "pic_Exit"
        pic_Exit.Size = New Size(38, 36)
        pic_Exit.SizeMode = PictureBoxSizeMode.Zoom
        pic_Exit.TabIndex = 58
        pic_Exit.TabStop = False
        ' 
        ' pnl_Record
        ' 
        pnl_Record.BackColor = SystemColors.ButtonHighlight
        pnl_Record.Controls.Add(lbl_Label21)
        pnl_Record.Controls.Add(lbl_Diagnoses)
        pnl_Record.Controls.Add(lbl_Label19)
        pnl_Record.Controls.Add(lbl_Label18)
        pnl_Record.Controls.Add(lbl_Label17)
        pnl_Record.Controls.Add(lbl_Label16)
        pnl_Record.Controls.Add(lbl_Label15)
        pnl_Record.Controls.Add(lbl_Label14)
        pnl_Record.Controls.Add(pic_PhoneNumber)
        pnl_Record.Controls.Add(pic_Email)
        pnl_Record.Controls.Add(pic_Address)
        pnl_Record.Controls.Add(lbl_Address)
        pnl_Record.Controls.Add(lbl_Email)
        pnl_Record.Controls.Add(lbl_PhoneNumber)
        pnl_Record.Controls.Add(lbl_Contact)
        pnl_Record.Controls.Add(lbl_Guardian)
        pnl_Record.Controls.Add(lbl_BloodType)
        pnl_Record.Controls.Add(lbl_DateOfBirth)
        pnl_Record.Controls.Add(lbl_Sex)
        pnl_Record.Controls.Add(lbl_Age)
        pnl_Record.Controls.Add(lbl_MiddleName)
        pnl_Record.Controls.Add(lbl_FirstName)
        pnl_Record.Controls.Add(lbl_LastName)
        pnl_Record.CornerRadius = 20
        pnl_Record.Location = New Point(12, 142)
        pnl_Record.Name = "pnl_Record"
        pnl_Record.Size = New Size(360, 543)
        pnl_Record.TabIndex = 60
        ' 
        ' lbl_Label21
        ' 
        lbl_Label21.AutoSize = True
        lbl_Label21.Location = New Point(74, 507)
        lbl_Label21.Name = "lbl_Label21"
        lbl_Label21.Size = New Size(47, 15)
        lbl_Label21.TabIndex = 80
        lbl_Label21.Text = "Label21"
        ' 
        ' lbl_Diagnoses
        ' 
        lbl_Diagnoses.AutoSize = True
        lbl_Diagnoses.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        lbl_Diagnoses.Location = New Point(41, 209)
        lbl_Diagnoses.Name = "lbl_Diagnoses"
        lbl_Diagnoses.Size = New Size(125, 17)
        lbl_Diagnoses.TabIndex = 79
        lbl_Diagnoses.Text = "Primary Diagnoses"
        ' 
        ' lbl_Label19
        ' 
        lbl_Label19.AutoSize = True
        lbl_Label19.Location = New Point(74, 438)
        lbl_Label19.Name = "lbl_Label19"
        lbl_Label19.Size = New Size(47, 15)
        lbl_Label19.TabIndex = 78
        lbl_Label19.Text = "Label19"
        ' 
        ' lbl_Label18
        ' 
        lbl_Label18.AutoSize = True
        lbl_Label18.Location = New Point(74, 373)
        lbl_Label18.Name = "lbl_Label18"
        lbl_Label18.Size = New Size(47, 15)
        lbl_Label18.TabIndex = 77
        lbl_Label18.Text = "Label18"
        ' 
        ' lbl_Label17
        ' 
        lbl_Label17.AutoSize = True
        lbl_Label17.Location = New Point(51, 240)
        lbl_Label17.Name = "lbl_Label17"
        lbl_Label17.Size = New Size(47, 15)
        lbl_Label17.TabIndex = 76
        lbl_Label17.Text = "Label17"
        ' 
        ' lbl_Label16
        ' 
        lbl_Label16.AutoSize = True
        lbl_Label16.Location = New Point(51, 178)
        lbl_Label16.Name = "lbl_Label16"
        lbl_Label16.Size = New Size(47, 15)
        lbl_Label16.TabIndex = 75
        lbl_Label16.Text = "Label16"
        ' 
        ' lbl_Label15
        ' 
        lbl_Label15.AutoSize = True
        lbl_Label15.Location = New Point(222, 120)
        lbl_Label15.Name = "lbl_Label15"
        lbl_Label15.Size = New Size(47, 15)
        lbl_Label15.TabIndex = 74
        lbl_Label15.Text = "Label15"
        ' 
        ' lbl_Label14
        ' 
        lbl_Label14.AutoSize = True
        lbl_Label14.Location = New Point(51, 120)
        lbl_Label14.Name = "lbl_Label14"
        lbl_Label14.Size = New Size(47, 15)
        lbl_Label14.TabIndex = 73
        lbl_Label14.Text = "Label14"
        ' 
        ' pic_PhoneNumber
        ' 
        pic_PhoneNumber.BorderRadius = 20
        pic_PhoneNumber.Image = CType(resources.GetObject("pic_PhoneNumber.Image"), Image)
        pic_PhoneNumber.Location = New Point(41, 340)
        pic_PhoneNumber.Name = "pic_PhoneNumber"
        pic_PhoneNumber.Size = New Size(39, 23)
        pic_PhoneNumber.SizeMode = PictureBoxSizeMode.Zoom
        pic_PhoneNumber.TabIndex = 72
        pic_PhoneNumber.TabStop = False
        ' 
        ' pic_Email
        ' 
        pic_Email.BorderRadius = 20
        pic_Email.Image = CType(resources.GetObject("pic_Email.Image"), Image)
        pic_Email.Location = New Point(41, 403)
        pic_Email.Name = "pic_Email"
        pic_Email.Size = New Size(39, 23)
        pic_Email.SizeMode = PictureBoxSizeMode.Zoom
        pic_Email.TabIndex = 71
        pic_Email.TabStop = False
        ' 
        ' pic_Address
        ' 
        pic_Address.BorderRadius = 20
        pic_Address.Image = CType(resources.GetObject("pic_Address.Image"), Image)
        pic_Address.Location = New Point(42, 472)
        pic_Address.Name = "pic_Address"
        pic_Address.Size = New Size(39, 23)
        pic_Address.SizeMode = PictureBoxSizeMode.Zoom
        pic_Address.TabIndex = 70
        pic_Address.TabStop = False
        ' 
        ' lbl_Address
        ' 
        lbl_Address.AutoSize = True
        lbl_Address.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        lbl_Address.Location = New Point(81, 475)
        lbl_Address.Name = "lbl_Address"
        lbl_Address.Size = New Size(57, 17)
        lbl_Address.TabIndex = 69
        lbl_Address.Text = "Address"
        ' 
        ' lbl_Email
        ' 
        lbl_Email.AutoSize = True
        lbl_Email.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        lbl_Email.Location = New Point(79, 407)
        lbl_Email.Name = "lbl_Email"
        lbl_Email.Size = New Size(42, 17)
        lbl_Email.TabIndex = 68
        lbl_Email.Text = "Email"
        ' 
        ' lbl_PhoneNumber
        ' 
        lbl_PhoneNumber.AutoSize = True
        lbl_PhoneNumber.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        lbl_PhoneNumber.Location = New Point(75, 344)
        lbl_PhoneNumber.Name = "lbl_PhoneNumber"
        lbl_PhoneNumber.Size = New Size(101, 17)
        lbl_PhoneNumber.TabIndex = 67
        lbl_PhoneNumber.Text = "Phone Number"
        ' 
        ' lbl_Contact
        ' 
        lbl_Contact.AutoSize = True
        lbl_Contact.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        lbl_Contact.Location = New Point(40, 299)
        lbl_Contact.Name = "lbl_Contact"
        lbl_Contact.Size = New Size(152, 20)
        lbl_Contact.TabIndex = 66
        lbl_Contact.Text = "Contact Information"
        ' 
        ' lbl_Guardian
        ' 
        lbl_Guardian.AutoSize = True
        lbl_Guardian.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        lbl_Guardian.Location = New Point(40, 150)
        lbl_Guardian.Name = "lbl_Guardian"
        lbl_Guardian.Size = New Size(110, 17)
        lbl_Guardian.TabIndex = 65
        lbl_Guardian.Text = "Parent/Guardian"
        ' 
        ' lbl_BloodType
        ' 
        lbl_BloodType.AutoSize = True
        lbl_BloodType.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        lbl_BloodType.Location = New Point(201, 93)
        lbl_BloodType.Name = "lbl_BloodType"
        lbl_BloodType.Size = New Size(77, 17)
        lbl_BloodType.TabIndex = 64
        lbl_BloodType.Text = "Blood Type"
        ' 
        ' lbl_DateOfBirth
        ' 
        lbl_DateOfBirth.AutoSize = True
        lbl_DateOfBirth.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        lbl_DateOfBirth.Location = New Point(40, 93)
        lbl_DateOfBirth.Name = "lbl_DateOfBirth"
        lbl_DateOfBirth.Size = New Size(88, 17)
        lbl_DateOfBirth.TabIndex = 63
        lbl_DateOfBirth.Text = "Date of Birth"
        ' 
        ' lbl_Sex
        ' 
        lbl_Sex.AutoSize = True
        lbl_Sex.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        lbl_Sex.Location = New Point(102, 58)
        lbl_Sex.Name = "lbl_Sex"
        lbl_Sex.Size = New Size(33, 20)
        lbl_Sex.TabIndex = 62
        lbl_Sex.Text = "Sex"
        ' 
        ' lbl_Age
        ' 
        lbl_Age.AutoSize = True
        lbl_Age.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        lbl_Age.Location = New Point(42, 58)
        lbl_Age.Name = "lbl_Age"
        lbl_Age.Size = New Size(37, 20)
        lbl_Age.TabIndex = 61
        lbl_Age.Text = "Age"
        ' 
        ' lbl_MiddleName
        ' 
        lbl_MiddleName.AutoSize = True
        lbl_MiddleName.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        lbl_MiddleName.Location = New Point(130, 22)
        lbl_MiddleName.Name = "lbl_MiddleName"
        lbl_MiddleName.Size = New Size(99, 20)
        lbl_MiddleName.TabIndex = 60
        lbl_MiddleName.Text = "MiddleName"
        ' 
        ' lbl_FirstName
        ' 
        lbl_FirstName.AutoSize = True
        lbl_FirstName.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        lbl_FirstName.Location = New Point(42, 22)
        lbl_FirstName.Name = "lbl_FirstName"
        lbl_FirstName.Size = New Size(82, 20)
        lbl_FirstName.TabIndex = 59
        lbl_FirstName.Text = "FirstName"
        ' 
        ' lbl_LastName
        ' 
        lbl_LastName.AutoSize = True
        lbl_LastName.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        lbl_LastName.Location = New Point(235, 22)
        lbl_LastName.Name = "lbl_LastName"
        lbl_LastName.Size = New Size(80, 20)
        lbl_LastName.TabIndex = 58
        lbl_LastName.Text = "LastName"
        ' 
        ' PatientRecord
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(384, 711)
        Controls.Add(pnl_Record)
        Controls.Add(pnl_Header)
        Controls.Add(pic_Exit)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "PatientRecord"
        StartPosition = FormStartPosition.CenterScreen
        Text = "PatientRecord"
        pnl_Header.ResumeLayout(False)
        CType(pic_Menu, ComponentModel.ISupportInitialize).EndInit()
        CType(pic_LogoHeader, ComponentModel.ISupportInitialize).EndInit()
        CType(pic_Exit, ComponentModel.ISupportInitialize).EndInit()
        pnl_Record.ResumeLayout(False)
        pnl_Record.PerformLayout()
        CType(pic_PhoneNumber, ComponentModel.ISupportInitialize).EndInit()
        CType(pic_Email, ComponentModel.ISupportInitialize).EndInit()
        CType(pic_Address, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnl_Header As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents pic_Menu As PictureBox
    Friend WithEvents pic_LogoHeader As PictureBox
    Friend WithEvents pic_Exit As PictureBox
    Friend WithEvents pnl_Record As RoundedPanel
    Friend WithEvents lbl_Label21 As Label
    Friend WithEvents lbl_Diagnoses As Label
    Friend WithEvents lbl_Label19 As Label
    Friend WithEvents lbl_Label18 As Label
    Friend WithEvents lbl_Label17 As Label
    Friend WithEvents lbl_Label16 As Label
    Friend WithEvents lbl_Label15 As Label
    Friend WithEvents lbl_Label14 As Label
    Friend WithEvents pic_PhoneNumber As CirclePictureBox
    Friend WithEvents pic_Email As CirclePictureBox
    Friend WithEvents pic_Address As CirclePictureBox
    Friend WithEvents lbl_Address As Label
    Friend WithEvents lbl_Email As Label
    Friend WithEvents lbl_PhoneNumber As Label
    Friend WithEvents lbl_Contact As Label
    Friend WithEvents lbl_Guardian As Label
    Friend WithEvents lbl_BloodType As Label
    Friend WithEvents lbl_DateOfBirth As Label
    Friend WithEvents lbl_Sex As Label
    Friend WithEvents lbl_Age As Label
    Friend WithEvents lbl_MiddleName As Label
    Friend WithEvents lbl_FirstName As Label
    Friend WithEvents lbl_LastName As Label
End Class
