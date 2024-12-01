<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RecordsPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RecordsPage))
        txt_Search = New RoundedTextBox()
        pic_Search = New PictureBox()
        pic_Exit = New PictureBox()
        pnl_ProfileBackground = New RoundedPanel()
        lbl_Sex = New Label()
        pic_Profile = New CirclePictureBox()
        lbl_LastName = New Label()
        lbl_Age = New Label()
        lbl_FirstName = New Label()
        Label9 = New Label()
        pnl_Header = New Panel()
        Label3 = New Label()
        pic_Menu = New PictureBox()
        pic_LogoHeader = New PictureBox()
        pnl_Search = New RoundedPanel()
        CType(pic_Search, ComponentModel.ISupportInitialize).BeginInit()
        CType(pic_Exit, ComponentModel.ISupportInitialize).BeginInit()
        pnl_ProfileBackground.SuspendLayout()
        CType(pic_Profile, ComponentModel.ISupportInitialize).BeginInit()
        pnl_Header.SuspendLayout()
        CType(pic_Menu, ComponentModel.ISupportInitialize).BeginInit()
        CType(pic_LogoHeader, ComponentModel.ISupportInitialize).BeginInit()
        pnl_Search.SuspendLayout()
        SuspendLayout()
        ' 
        ' txt_Search
        ' 
        txt_Search.BackColor = SystemColors.ButtonFace
        txt_Search.Location = New Point(11, 6)
        txt_Search.Name = "txt_Search"
        txt_Search.PlaceholderText = "Search"
        txt_Search.Size = New Size(245, 23)
        txt_Search.TabIndex = 0
        ' 
        ' pic_Search
        ' 
        pic_Search.BackColor = SystemColors.ButtonFace
        pic_Search.Image = CType(resources.GetObject("pic_Search.Image"), Image)
        pic_Search.Location = New Point(315, 8)
        pic_Search.Name = "pic_Search"
        pic_Search.Size = New Size(20, 18)
        pic_Search.SizeMode = PictureBoxSizeMode.Zoom
        pic_Search.TabIndex = 1
        pic_Search.TabStop = False
        ' 
        ' pic_Exit
        ' 
        pic_Exit.BackColor = Color.Transparent
        pic_Exit.Cursor = Cursors.Hand
        pic_Exit.Image = CType(resources.GetObject("pic_Exit.Image"), Image)
        pic_Exit.Location = New Point(35, 88)
        pic_Exit.Name = "pic_Exit"
        pic_Exit.Size = New Size(38, 36)
        pic_Exit.SizeMode = PictureBoxSizeMode.Zoom
        pic_Exit.TabIndex = 6
        pic_Exit.TabStop = False
        ' 
        ' pnl_ProfileBackground
        ' 
        pnl_ProfileBackground.Controls.Add(lbl_Sex)
        pnl_ProfileBackground.Controls.Add(pic_Profile)
        pnl_ProfileBackground.Controls.Add(lbl_LastName)
        pnl_ProfileBackground.Controls.Add(lbl_Age)
        pnl_ProfileBackground.Controls.Add(lbl_FirstName)
        pnl_ProfileBackground.Controls.Add(Label9)
        pnl_ProfileBackground.CornerRadius = 20
        pnl_ProfileBackground.Location = New Point(35, 197)
        pnl_ProfileBackground.Name = "pnl_ProfileBackground"
        pnl_ProfileBackground.Size = New Size(324, 102)
        pnl_ProfileBackground.TabIndex = 7
        ' 
        ' lbl_Sex
        ' 
        lbl_Sex.AutoSize = True
        lbl_Sex.Font = New Font("Segoe UI", 9F)
        lbl_Sex.Location = New Point(130, 54)
        lbl_Sex.Name = "lbl_Sex"
        lbl_Sex.Size = New Size(25, 15)
        lbl_Sex.TabIndex = 19
        lbl_Sex.Text = "Sex"
        ' 
        ' pic_Profile
        ' 
        pic_Profile.BackColor = SystemColors.Control
        pic_Profile.BorderRadius = 20
        pic_Profile.Image = CType(resources.GetObject("pic_Profile.Image"), Image)
        pic_Profile.Location = New Point(13, 14)
        pic_Profile.Name = "pic_Profile"
        pic_Profile.Size = New Size(84, 72)
        pic_Profile.SizeMode = PictureBoxSizeMode.Zoom
        pic_Profile.TabIndex = 8
        pic_Profile.TabStop = False
        ' 
        ' lbl_LastName
        ' 
        lbl_LastName.AutoSize = True
        lbl_LastName.Font = New Font("Segoe UI", 9F)
        lbl_LastName.Location = New Point(159, 31)
        lbl_LastName.Name = "lbl_LastName"
        lbl_LastName.Size = New Size(60, 15)
        lbl_LastName.TabIndex = 15
        lbl_LastName.Text = "LastName"
        ' 
        ' lbl_Age
        ' 
        lbl_Age.AutoSize = True
        lbl_Age.Font = New Font("Segoe UI", 9F)
        lbl_Age.Location = New Point(104, 54)
        lbl_Age.Name = "lbl_Age"
        lbl_Age.Size = New Size(28, 15)
        lbl_Age.TabIndex = 18
        lbl_Age.Text = "Age"
        ' 
        ' lbl_FirstName
        ' 
        lbl_FirstName.AutoSize = True
        lbl_FirstName.Font = New Font("Segoe UI", 9F)
        lbl_FirstName.Location = New Point(101, 31)
        lbl_FirstName.Name = "lbl_FirstName"
        lbl_FirstName.Size = New Size(61, 15)
        lbl_FirstName.TabIndex = 16
        lbl_FirstName.Text = "FirstName"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 9F)
        Label9.Location = New Point(134, 31)
        Label9.Name = "Label9"
        Label9.Size = New Size(76, 15)
        Label9.TabIndex = 17
        Label9.Text = "MiddleName"
        ' 
        ' pnl_Header
        ' 
        pnl_Header.BackColor = Color.Transparent
        pnl_Header.BorderStyle = BorderStyle.FixedSingle
        pnl_Header.Controls.Add(Label3)
        pnl_Header.Controls.Add(pic_Menu)
        pnl_Header.Controls.Add(pic_LogoHeader)
        pnl_Header.Location = New Point(-11, -4)
        pnl_Header.Name = "pnl_Header"
        pnl_Header.Size = New Size(422, 68)
        pnl_Header.TabIndex = 8
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
        ' pnl_Search
        ' 
        pnl_Search.Controls.Add(txt_Search)
        pnl_Search.Controls.Add(pic_Search)
        pnl_Search.CornerRadius = 20
        pnl_Search.Location = New Point(24, 142)
        pnl_Search.Name = "pnl_Search"
        pnl_Search.Size = New Size(348, 34)
        pnl_Search.TabIndex = 9
        ' 
        ' RecordsPage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(400, 750)
        Controls.Add(pnl_Search)
        Controls.Add(pnl_Header)
        Controls.Add(pnl_ProfileBackground)
        Controls.Add(pic_Exit)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "RecordsPage"
        StartPosition = FormStartPosition.CenterScreen
        Text = "RecordsPage"
        CType(pic_Search, ComponentModel.ISupportInitialize).EndInit()
        CType(pic_Exit, ComponentModel.ISupportInitialize).EndInit()
        pnl_ProfileBackground.ResumeLayout(False)
        pnl_ProfileBackground.PerformLayout()
        CType(pic_Profile, ComponentModel.ISupportInitialize).EndInit()
        pnl_Header.ResumeLayout(False)
        CType(pic_Menu, ComponentModel.ISupportInitialize).EndInit()
        CType(pic_LogoHeader, ComponentModel.ISupportInitialize).EndInit()
        pnl_Search.ResumeLayout(False)
        pnl_Search.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents txt_Search As RoundedTextBox
    Friend WithEvents pic_Search As PictureBox
    Friend WithEvents pic_Exit As PictureBox
    Friend WithEvents pnl_ProfileBackground As RoundedPanel
    Friend WithEvents CirclePictureBox1 As CirclePictureBox
    Friend WithEvents pic_Profile As CirclePictureBox
    Friend WithEvents pnl_Header As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents pic_Menu As PictureBox
    Friend WithEvents pic_LogoHeader As PictureBox
    Friend WithEvents lbl_Sex As Label
    Friend WithEvents lbl_Age As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lbl_FirstName As Label
    Friend WithEvents lbl_LastName As Label
    Friend WithEvents pnl_Search As RoundedPanel
End Class
