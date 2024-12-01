<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InformationPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InformationPage))
        pic_Exit = New PictureBox()
        Panel1 = New Panel()
        Label3 = New Label()
        pic_Menu = New PictureBox()
        pic_Logo = New PictureBox()
        RoundedPanel1 = New RoundedPanel()
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
        lbl_Contacts = New Label()
        lbl_Guardian = New Label()
        lbl_BloodType = New Label()
        lbl_DateOfBirth = New Label()
        pic_Profile = New CirclePictureBox()
        lbl_Sex = New Label()
        lbl_Age = New Label()
        lbl_MiddleName = New Label()
        lbl_FirstName = New Label()
        lbl_LastName = New Label()
        CType(pic_Exit, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(pic_Menu, ComponentModel.ISupportInitialize).BeginInit()
        CType(pic_Logo, ComponentModel.ISupportInitialize).BeginInit()
        RoundedPanel1.SuspendLayout()
        CType(pic_PhoneNumber, ComponentModel.ISupportInitialize).BeginInit()
        CType(pic_Email, ComponentModel.ISupportInitialize).BeginInit()
        CType(pic_Address, ComponentModel.ISupportInitialize).BeginInit()
        CType(pic_Profile, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pic_Exit
        ' 
        pic_Exit.BackColor = Color.Transparent
        pic_Exit.Cursor = Cursors.Hand
        pic_Exit.Image = CType(resources.GetObject("pic_Exit.Image"), Image)
        pic_Exit.Location = New Point(17, 83)
        pic_Exit.Name = "pic_Exit"
        pic_Exit.Size = New Size(38, 36)
        pic_Exit.SizeMode = PictureBoxSizeMode.Zoom
        pic_Exit.TabIndex = 7
        pic_Exit.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Transparent
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(pic_Menu)
        Panel1.Controls.Add(pic_Logo)
        Panel1.Location = New Point(-10, -3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(422, 68)
        Panel1.TabIndex = 9
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
        ' pic_Logo
        ' 
        pic_Logo.BackColor = Color.Transparent
        pic_Logo.Image = CType(resources.GetObject("pic_Logo.Image"), Image)
        pic_Logo.Location = New Point(48, -11)
        pic_Logo.Name = "pic_Logo"
        pic_Logo.Size = New Size(142, 90)
        pic_Logo.SizeMode = PictureBoxSizeMode.Zoom
        pic_Logo.TabIndex = 2
        pic_Logo.TabStop = False
        ' 
        ' RoundedPanel1
        ' 
        RoundedPanel1.Controls.Add(lbl_Label21)
        RoundedPanel1.Controls.Add(lbl_Diagnoses)
        RoundedPanel1.Controls.Add(lbl_Label19)
        RoundedPanel1.Controls.Add(lbl_Label18)
        RoundedPanel1.Controls.Add(lbl_Label17)
        RoundedPanel1.Controls.Add(lbl_Label16)
        RoundedPanel1.Controls.Add(lbl_Label15)
        RoundedPanel1.Controls.Add(lbl_Label14)
        RoundedPanel1.Controls.Add(pic_PhoneNumber)
        RoundedPanel1.Controls.Add(pic_Email)
        RoundedPanel1.Controls.Add(pic_Address)
        RoundedPanel1.Controls.Add(lbl_Address)
        RoundedPanel1.Controls.Add(lbl_Email)
        RoundedPanel1.Controls.Add(lbl_PhoneNumber)
        RoundedPanel1.Controls.Add(lbl_Contacts)
        RoundedPanel1.Controls.Add(lbl_Guardian)
        RoundedPanel1.Controls.Add(lbl_BloodType)
        RoundedPanel1.Controls.Add(lbl_DateOfBirth)
        RoundedPanel1.Controls.Add(pic_Profile)
        RoundedPanel1.Controls.Add(lbl_Sex)
        RoundedPanel1.Controls.Add(lbl_Age)
        RoundedPanel1.Controls.Add(lbl_MiddleName)
        RoundedPanel1.Controls.Add(lbl_FirstName)
        RoundedPanel1.Controls.Add(lbl_LastName)
        RoundedPanel1.CornerRadius = 20
        RoundedPanel1.Location = New Point(28, 152)
        RoundedPanel1.Name = "RoundedPanel1"
        RoundedPanel1.Size = New Size(343, 564)
        RoundedPanel1.TabIndex = 10
        ' 
        ' lbl_Label21
        ' 
        lbl_Label21.AutoSize = True
        lbl_Label21.Location = New Point(45, 523)
        lbl_Label21.Name = "lbl_Label21"
        lbl_Label21.Size = New Size(47, 15)
        lbl_Label21.TabIndex = 33
        lbl_Label21.Text = "Label21"
        ' 
        ' lbl_Diagnoses
        ' 
        lbl_Diagnoses.AutoSize = True
        lbl_Diagnoses.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        lbl_Diagnoses.Location = New Point(12, 225)
        lbl_Diagnoses.Name = "lbl_Diagnoses"
        lbl_Diagnoses.Size = New Size(125, 17)
        lbl_Diagnoses.TabIndex = 32
        lbl_Diagnoses.Text = "Primary Diagnoses"
        ' 
        ' lbl_Label19
        ' 
        lbl_Label19.AutoSize = True
        lbl_Label19.Location = New Point(45, 454)
        lbl_Label19.Name = "lbl_Label19"
        lbl_Label19.Size = New Size(47, 15)
        lbl_Label19.TabIndex = 31
        lbl_Label19.Text = "Label19"
        ' 
        ' lbl_Label18
        ' 
        lbl_Label18.AutoSize = True
        lbl_Label18.Location = New Point(45, 389)
        lbl_Label18.Name = "lbl_Label18"
        lbl_Label18.Size = New Size(47, 15)
        lbl_Label18.TabIndex = 30
        lbl_Label18.Text = "Label18"
        ' 
        ' lbl_Label17
        ' 
        lbl_Label17.AutoSize = True
        lbl_Label17.Location = New Point(22, 256)
        lbl_Label17.Name = "lbl_Label17"
        lbl_Label17.Size = New Size(47, 15)
        lbl_Label17.TabIndex = 29
        lbl_Label17.Text = "Label17"
        ' 
        ' lbl_Label16
        ' 
        lbl_Label16.AutoSize = True
        lbl_Label16.Location = New Point(22, 194)
        lbl_Label16.Name = "lbl_Label16"
        lbl_Label16.Size = New Size(47, 15)
        lbl_Label16.TabIndex = 28
        lbl_Label16.Text = "Label16"
        ' 
        ' lbl_Label15
        ' 
        lbl_Label15.AutoSize = True
        lbl_Label15.Location = New Point(193, 136)
        lbl_Label15.Name = "lbl_Label15"
        lbl_Label15.Size = New Size(47, 15)
        lbl_Label15.TabIndex = 27
        lbl_Label15.Text = "Label15"
        ' 
        ' lbl_Label14
        ' 
        lbl_Label14.AutoSize = True
        lbl_Label14.Location = New Point(22, 136)
        lbl_Label14.Name = "lbl_Label14"
        lbl_Label14.Size = New Size(47, 15)
        lbl_Label14.TabIndex = 26
        lbl_Label14.Text = "Label14"
        ' 
        ' pic_PhoneNumber
        ' 
        pic_PhoneNumber.BorderRadius = 20
        pic_PhoneNumber.Image = CType(resources.GetObject("pic_PhoneNumber.Image"), Image)
        pic_PhoneNumber.Location = New Point(12, 356)
        pic_PhoneNumber.Name = "pic_PhoneNumber"
        pic_PhoneNumber.Size = New Size(39, 23)
        pic_PhoneNumber.SizeMode = PictureBoxSizeMode.Zoom
        pic_PhoneNumber.TabIndex = 25
        pic_PhoneNumber.TabStop = False
        ' 
        ' pic_Email
        ' 
        pic_Email.BorderRadius = 20
        pic_Email.Image = CType(resources.GetObject("pic_Email.Image"), Image)
        pic_Email.Location = New Point(12, 419)
        pic_Email.Name = "pic_Email"
        pic_Email.Size = New Size(39, 23)
        pic_Email.SizeMode = PictureBoxSizeMode.Zoom
        pic_Email.TabIndex = 24
        pic_Email.TabStop = False
        ' 
        ' pic_Address
        ' 
        pic_Address.BorderRadius = 20
        pic_Address.Image = CType(resources.GetObject("pic_Address.Image"), Image)
        pic_Address.Location = New Point(13, 488)
        pic_Address.Name = "pic_Address"
        pic_Address.Size = New Size(39, 23)
        pic_Address.SizeMode = PictureBoxSizeMode.Zoom
        pic_Address.TabIndex = 23
        pic_Address.TabStop = False
        ' 
        ' lbl_Address
        ' 
        lbl_Address.AutoSize = True
        lbl_Address.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        lbl_Address.Location = New Point(52, 491)
        lbl_Address.Name = "lbl_Address"
        lbl_Address.Size = New Size(57, 17)
        lbl_Address.TabIndex = 22
        lbl_Address.Text = "Address"
        ' 
        ' lbl_Email
        ' 
        lbl_Email.AutoSize = True
        lbl_Email.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        lbl_Email.Location = New Point(50, 423)
        lbl_Email.Name = "lbl_Email"
        lbl_Email.Size = New Size(42, 17)
        lbl_Email.TabIndex = 21
        lbl_Email.Text = "Email"
        ' 
        ' lbl_PhoneNumber
        ' 
        lbl_PhoneNumber.AutoSize = True
        lbl_PhoneNumber.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        lbl_PhoneNumber.Location = New Point(46, 360)
        lbl_PhoneNumber.Name = "lbl_PhoneNumber"
        lbl_PhoneNumber.Size = New Size(101, 17)
        lbl_PhoneNumber.TabIndex = 20
        lbl_PhoneNumber.Text = "Phone Number"
        ' 
        ' lbl_Contacts
        ' 
        lbl_Contacts.AutoSize = True
        lbl_Contacts.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        lbl_Contacts.Location = New Point(11, 315)
        lbl_Contacts.Name = "lbl_Contacts"
        lbl_Contacts.Size = New Size(152, 20)
        lbl_Contacts.TabIndex = 19
        lbl_Contacts.Text = "Contact Information"
        ' 
        ' lbl_Guardian
        ' 
        lbl_Guardian.AutoSize = True
        lbl_Guardian.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        lbl_Guardian.Location = New Point(11, 166)
        lbl_Guardian.Name = "lbl_Guardian"
        lbl_Guardian.Size = New Size(110, 17)
        lbl_Guardian.TabIndex = 18
        lbl_Guardian.Text = "Parent/Guardian"
        ' 
        ' lbl_BloodType
        ' 
        lbl_BloodType.AutoSize = True
        lbl_BloodType.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        lbl_BloodType.Location = New Point(172, 109)
        lbl_BloodType.Name = "lbl_BloodType"
        lbl_BloodType.Size = New Size(77, 17)
        lbl_BloodType.TabIndex = 17
        lbl_BloodType.Text = "Blood Type"
        ' 
        ' lbl_DateOfBirth
        ' 
        lbl_DateOfBirth.AutoSize = True
        lbl_DateOfBirth.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        lbl_DateOfBirth.Location = New Point(11, 109)
        lbl_DateOfBirth.Name = "lbl_DateOfBirth"
        lbl_DateOfBirth.Size = New Size(88, 17)
        lbl_DateOfBirth.TabIndex = 16
        lbl_DateOfBirth.Text = "Date of Birth"
        ' 
        ' pic_Profile
        ' 
        pic_Profile.BackColor = SystemColors.Control
        pic_Profile.BorderRadius = 20
        pic_Profile.Image = CType(resources.GetObject("pic_Profile.Image"), Image)
        pic_Profile.Location = New Point(11, 20)
        pic_Profile.Name = "pic_Profile"
        pic_Profile.Size = New Size(84, 72)
        pic_Profile.SizeMode = PictureBoxSizeMode.Zoom
        pic_Profile.TabIndex = 15
        pic_Profile.TabStop = False
        ' 
        ' lbl_Sex
        ' 
        lbl_Sex.AutoSize = True
        lbl_Sex.Font = New Font("Segoe UI", 10F)
        lbl_Sex.Location = New Point(145, 59)
        lbl_Sex.Name = "lbl_Sex"
        lbl_Sex.Size = New Size(29, 19)
        lbl_Sex.TabIndex = 14
        lbl_Sex.Text = "Sex"
        ' 
        ' lbl_Age
        ' 
        lbl_Age.AutoSize = True
        lbl_Age.Font = New Font("Segoe UI", 10F)
        lbl_Age.Location = New Point(106, 59)
        lbl_Age.Name = "lbl_Age"
        lbl_Age.Size = New Size(33, 19)
        lbl_Age.TabIndex = 13
        lbl_Age.Text = "Age"
        ' 
        ' lbl_MiddleName
        ' 
        lbl_MiddleName.AutoSize = True
        lbl_MiddleName.Font = New Font("Segoe UI", 10F)
        lbl_MiddleName.Location = New Point(172, 36)
        lbl_MiddleName.Name = "lbl_MiddleName"
        lbl_MiddleName.Size = New Size(87, 19)
        lbl_MiddleName.TabIndex = 12
        lbl_MiddleName.Text = "MiddleName"
        ' 
        ' lbl_FirstName
        ' 
        lbl_FirstName.AutoSize = True
        lbl_FirstName.Font = New Font("Segoe UI", 10F)
        lbl_FirstName.Location = New Point(103, 36)
        lbl_FirstName.Name = "lbl_FirstName"
        lbl_FirstName.Size = New Size(71, 19)
        lbl_FirstName.TabIndex = 11
        lbl_FirstName.Text = "FirstName"
        ' 
        ' lbl_LastName
        ' 
        lbl_LastName.AutoSize = True
        lbl_LastName.Font = New Font("Segoe UI", 10F)
        lbl_LastName.Location = New Point(256, 36)
        lbl_LastName.Name = "lbl_LastName"
        lbl_LastName.Size = New Size(70, 19)
        lbl_LastName.TabIndex = 10
        lbl_LastName.Text = "LastName"
        ' 
        ' InformationPage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(400, 750)
        Controls.Add(RoundedPanel1)
        Controls.Add(Panel1)
        Controls.Add(pic_Exit)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "InformationPage"
        StartPosition = FormStartPosition.CenterScreen
        Text = "z"
        CType(pic_Exit, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        CType(pic_Menu, ComponentModel.ISupportInitialize).EndInit()
        CType(pic_Logo, ComponentModel.ISupportInitialize).EndInit()
        RoundedPanel1.ResumeLayout(False)
        RoundedPanel1.PerformLayout()
        CType(pic_PhoneNumber, ComponentModel.ISupportInitialize).EndInit()
        CType(pic_Email, ComponentModel.ISupportInitialize).EndInit()
        CType(pic_Address, ComponentModel.ISupportInitialize).EndInit()
        CType(pic_Profile, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pic_Exit As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents pic_Menu As PictureBox
    Friend WithEvents pic_Logo As PictureBox
    Friend WithEvents RoundedPanel1 As RoundedPanel
    Friend WithEvents lbl_MiddleName As Label
    Friend WithEvents lbl_FirstName As Label
    Friend WithEvents lbl_LastName As Label
    Friend WithEvents lbl_Sex As Label
    Friend WithEvents lbl_Age As Label
    Friend WithEvents pic_Profile As CirclePictureBox
    Friend WithEvents lbl_Address As Label
    Friend WithEvents lbl_Email As Label
    Friend WithEvents lbl_PhoneNumber As Label
    Friend WithEvents lbl_Contacts As Label
    Friend WithEvents lbl_Guardian As Label
    Friend WithEvents lbl_BloodType As Label
    Friend WithEvents lbl_DateOfBirth As Label
    Friend WithEvents pic_Email As CirclePictureBox
    Friend WithEvents pic_Address As CirclePictureBox
    Friend WithEvents lbl_Label19 As Label
    Friend WithEvents lbl_Label18 As Label
    Friend WithEvents lbl_Label17 As Label
    Friend WithEvents lbl_Label16 As Label
    Friend WithEvents lbl_Label15 As Label
    Friend WithEvents lbl_Label14 As Label
    Friend WithEvents pic_PhoneNumber As CirclePictureBox
    Friend WithEvents lbl_Label21 As Label
    Friend WithEvents lbl_Diagnoses As Label
End Class
