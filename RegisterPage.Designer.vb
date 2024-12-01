<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegisterPage))
        btn_Register = New CustomControls.RJControls.RoundedButton()
        txt_Login = New LinkLabel()
        txt_AlreadyHaveAcc = New Label()
        Label1 = New Label()
        Panel1 = New Panel()
        pic_Logo = New PictureBox()
        pnl_MiddleName = New RoundedPanel()
        txt_MiddleName = New RoundedTextBox()
        pnl_FirstName = New RoundedPanel()
        txt_FirstName = New RoundedTextBox()
        pnl_LastName = New RoundedPanel()
        txt_LastName = New RoundedTextBox()
        pnl_Email = New RoundedPanel()
        txt_Email = New RoundedTextBox()
        pnl_PhoneNumber = New RoundedPanel()
        txt_PhoneNumber = New RoundedTextBox()
        pnl_Password = New RoundedPanel()
        txt_Password = New RoundedTextBox()
        PictureBox6 = New PictureBox()
        pnl_ConfPassword = New RoundedPanel()
        txt_ConfPassword = New RoundedTextBox()
        PictureBox2 = New PictureBox()
        Panel1.SuspendLayout()
        CType(pic_Logo, ComponentModel.ISupportInitialize).BeginInit()
        pnl_MiddleName.SuspendLayout()
        pnl_FirstName.SuspendLayout()
        pnl_LastName.SuspendLayout()
        pnl_Email.SuspendLayout()
        pnl_PhoneNumber.SuspendLayout()
        pnl_Password.SuspendLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        pnl_ConfPassword.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btn_Register
        ' 
        btn_Register.BackColor = SystemColors.ButtonHighlight
        btn_Register.BackgroundColor = SystemColors.ButtonHighlight
        btn_Register.BorderColor = Color.PaleVioletRed
        btn_Register.BorderRadius = 9
        btn_Register.BorderSize = 0
        btn_Register.Cursor = Cursors.Hand
        btn_Register.FlatAppearance.BorderColor = SystemColors.ButtonHighlight
        btn_Register.FlatAppearance.MouseDownBackColor = Color.White
        btn_Register.FlatAppearance.MouseOverBackColor = Color.SteelBlue
        btn_Register.FlatStyle = FlatStyle.Flat
        btn_Register.Font = New Font("Segoe UI", 10F)
        btn_Register.ForeColor = Color.Black
        btn_Register.Location = New Point(27, 644)
        btn_Register.Name = "btn_Register"
        btn_Register.Size = New Size(331, 52)
        btn_Register.TabIndex = 23
        btn_Register.Text = "Register"
        btn_Register.TextColor = Color.Black
        btn_Register.UseVisualStyleBackColor = False
        ' 
        ' txt_Login
        ' 
        txt_Login.ActiveLinkColor = Color.White
        txt_Login.AutoSize = True
        txt_Login.BackColor = Color.Transparent
        txt_Login.Cursor = Cursors.Hand
        txt_Login.Location = New Point(242, 616)
        txt_Login.Name = "txt_Login"
        txt_Login.Size = New Size(37, 15)
        txt_Login.TabIndex = 22
        txt_Login.TabStop = True
        txt_Login.Text = "Login"
        ' 
        ' txt_AlreadyHaveAcc
        ' 
        txt_AlreadyHaveAcc.AutoSize = True
        txt_AlreadyHaveAcc.BackColor = Color.Transparent
        txt_AlreadyHaveAcc.Location = New Point(103, 616)
        txt_AlreadyHaveAcc.Name = "txt_AlreadyHaveAcc"
        txt_AlreadyHaveAcc.Size = New Size(142, 15)
        txt_AlreadyHaveAcc.TabIndex = 21
        txt_AlreadyHaveAcc.Text = "Already have an account?"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.SteelBlue
        Label1.Location = New Point(121, 158)
        Label1.Name = "Label1"
        Label1.Size = New Size(141, 21)
        Label1.TabIndex = 18
        Label1.Text = "Create an account"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Transparent
        Panel1.Controls.Add(pic_Logo)
        Panel1.Location = New Point(36, 11)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(289, 176)
        Panel1.TabIndex = 17
        ' 
        ' pic_Logo
        ' 
        pic_Logo.BackColor = Color.Transparent
        pic_Logo.Dock = DockStyle.Fill
        pic_Logo.Image = CType(resources.GetObject("pic_Logo.Image"), Image)
        pic_Logo.Location = New Point(0, 0)
        pic_Logo.Name = "pic_Logo"
        pic_Logo.Size = New Size(289, 176)
        pic_Logo.SizeMode = PictureBoxSizeMode.Zoom
        pic_Logo.TabIndex = 0
        pic_Logo.TabStop = False
        ' 
        ' pnl_MiddleName
        ' 
        pnl_MiddleName.BackColor = SystemColors.Window
        pnl_MiddleName.Controls.Add(txt_MiddleName)
        pnl_MiddleName.CornerRadius = 20
        pnl_MiddleName.Location = New Point(27, 249)
        pnl_MiddleName.Name = "pnl_MiddleName"
        pnl_MiddleName.Size = New Size(331, 48)
        pnl_MiddleName.TabIndex = 25
        ' 
        ' txt_MiddleName
        ' 
        txt_MiddleName.Location = New Point(9, 14)
        txt_MiddleName.Multiline = True
        txt_MiddleName.Name = "txt_MiddleName"
        txt_MiddleName.PlaceholderText = "Middle Name"
        txt_MiddleName.Size = New Size(276, 22)
        txt_MiddleName.TabIndex = 3
        ' 
        ' pnl_FirstName
        ' 
        pnl_FirstName.BackColor = SystemColors.Window
        pnl_FirstName.Controls.Add(txt_FirstName)
        pnl_FirstName.CornerRadius = 20
        pnl_FirstName.Location = New Point(27, 195)
        pnl_FirstName.Name = "pnl_FirstName"
        pnl_FirstName.Size = New Size(331, 48)
        pnl_FirstName.TabIndex = 24
        ' 
        ' txt_FirstName
        ' 
        txt_FirstName.Location = New Point(9, 13)
        txt_FirstName.Multiline = True
        txt_FirstName.Name = "txt_FirstName"
        txt_FirstName.PlaceholderText = "First Name"
        txt_FirstName.Size = New Size(289, 22)
        txt_FirstName.TabIndex = 3
        ' 
        ' pnl_LastName
        ' 
        pnl_LastName.BackColor = SystemColors.Window
        pnl_LastName.Controls.Add(txt_LastName)
        pnl_LastName.CornerRadius = 20
        pnl_LastName.Location = New Point(27, 303)
        pnl_LastName.Name = "pnl_LastName"
        pnl_LastName.Size = New Size(331, 48)
        pnl_LastName.TabIndex = 26
        ' 
        ' txt_LastName
        ' 
        txt_LastName.Location = New Point(9, 14)
        txt_LastName.Multiline = True
        txt_LastName.Name = "txt_LastName"
        txt_LastName.PlaceholderText = "Last Name"
        txt_LastName.Size = New Size(276, 22)
        txt_LastName.TabIndex = 3
        ' 
        ' pnl_Email
        ' 
        pnl_Email.BackColor = SystemColors.Window
        pnl_Email.Controls.Add(txt_Email)
        pnl_Email.CornerRadius = 20
        pnl_Email.Location = New Point(27, 411)
        pnl_Email.Name = "pnl_Email"
        pnl_Email.Size = New Size(331, 48)
        pnl_Email.TabIndex = 28
        ' 
        ' txt_Email
        ' 
        txt_Email.Location = New Point(9, 14)
        txt_Email.Multiline = True
        txt_Email.Name = "txt_Email"
        txt_Email.PlaceholderText = "Username or Email"
        txt_Email.Size = New Size(276, 22)
        txt_Email.TabIndex = 3
        ' 
        ' pnl_PhoneNumber
        ' 
        pnl_PhoneNumber.BackColor = SystemColors.Window
        pnl_PhoneNumber.Controls.Add(txt_PhoneNumber)
        pnl_PhoneNumber.CornerRadius = 20
        pnl_PhoneNumber.Location = New Point(27, 357)
        pnl_PhoneNumber.Name = "pnl_PhoneNumber"
        pnl_PhoneNumber.Size = New Size(331, 48)
        pnl_PhoneNumber.TabIndex = 27
        ' 
        ' txt_PhoneNumber
        ' 
        txt_PhoneNumber.Location = New Point(9, 14)
        txt_PhoneNumber.Multiline = True
        txt_PhoneNumber.Name = "txt_PhoneNumber"
        txt_PhoneNumber.PlaceholderText = "Phone Number"
        txt_PhoneNumber.Size = New Size(276, 22)
        txt_PhoneNumber.TabIndex = 3
        ' 
        ' pnl_Password
        ' 
        pnl_Password.BackColor = SystemColors.Window
        pnl_Password.Controls.Add(txt_Password)
        pnl_Password.Controls.Add(PictureBox6)
        pnl_Password.CornerRadius = 20
        pnl_Password.Location = New Point(27, 465)
        pnl_Password.Name = "pnl_Password"
        pnl_Password.Size = New Size(331, 48)
        pnl_Password.TabIndex = 29
        ' 
        ' txt_Password
        ' 
        txt_Password.Location = New Point(9, 14)
        txt_Password.Multiline = True
        txt_Password.Name = "txt_Password"
        txt_Password.PlaceholderText = "Password"
        txt_Password.Size = New Size(276, 22)
        txt_Password.TabIndex = 3
        ' 
        ' PictureBox6
        ' 
        PictureBox6.BackColor = SystemColors.Window
        PictureBox6.Cursor = Cursors.Hand
        PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), Image)
        PictureBox6.Location = New Point(292, 17)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(19, 16)
        PictureBox6.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox6.TabIndex = 16
        PictureBox6.TabStop = False
        ' 
        ' pnl_ConfPassword
        ' 
        pnl_ConfPassword.BackColor = SystemColors.Window
        pnl_ConfPassword.Controls.Add(txt_ConfPassword)
        pnl_ConfPassword.Controls.Add(PictureBox2)
        pnl_ConfPassword.CornerRadius = 20
        pnl_ConfPassword.Location = New Point(27, 519)
        pnl_ConfPassword.Name = "pnl_ConfPassword"
        pnl_ConfPassword.Size = New Size(331, 48)
        pnl_ConfPassword.TabIndex = 30
        ' 
        ' txt_ConfPassword
        ' 
        txt_ConfPassword.Location = New Point(9, 14)
        txt_ConfPassword.Multiline = True
        txt_ConfPassword.Name = "txt_ConfPassword"
        txt_ConfPassword.PlaceholderText = "Confirm Password"
        txt_ConfPassword.Size = New Size(276, 22)
        txt_ConfPassword.TabIndex = 3
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = SystemColors.Window
        PictureBox2.Cursor = Cursors.Hand
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(292, 17)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(19, 16)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 16
        PictureBox2.TabStop = False
        ' 
        ' RegisterPage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(384, 711)
        Controls.Add(pnl_ConfPassword)
        Controls.Add(pnl_Password)
        Controls.Add(pnl_Email)
        Controls.Add(pnl_LastName)
        Controls.Add(pnl_PhoneNumber)
        Controls.Add(pnl_MiddleName)
        Controls.Add(pnl_FirstName)
        Controls.Add(btn_Register)
        Controls.Add(txt_Login)
        Controls.Add(txt_AlreadyHaveAcc)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "RegisterPage"
        StartPosition = FormStartPosition.CenterScreen
        Text = "RegisterPage"
        Panel1.ResumeLayout(False)
        CType(pic_Logo, ComponentModel.ISupportInitialize).EndInit()
        pnl_MiddleName.ResumeLayout(False)
        pnl_MiddleName.PerformLayout()
        pnl_FirstName.ResumeLayout(False)
        pnl_FirstName.PerformLayout()
        pnl_LastName.ResumeLayout(False)
        pnl_LastName.PerformLayout()
        pnl_Email.ResumeLayout(False)
        pnl_Email.PerformLayout()
        pnl_PhoneNumber.ResumeLayout(False)
        pnl_PhoneNumber.PerformLayout()
        pnl_Password.ResumeLayout(False)
        pnl_Password.PerformLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        pnl_ConfPassword.ResumeLayout(False)
        pnl_ConfPassword.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btn_Register As CustomControls.RJControls.RoundedButton
    Friend WithEvents txt_Login As LinkLabel
    Friend WithEvents txt_AlreadyHaveAcc As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pic_Logo As PictureBox
    Friend WithEvents pnl_MiddleName As RoundedPanel
    Friend WithEvents txt_MiddleName As RoundedTextBox
    Friend WithEvents pnl_FirstName As RoundedPanel
    Friend WithEvents txt_FirstName As RoundedTextBox
    Friend WithEvents pnl_LastName As RoundedPanel
    Friend WithEvents txt_LastName As RoundedTextBox
    Friend WithEvents pnl_Email As RoundedPanel
    Friend WithEvents txt_Email As RoundedTextBox
    Friend WithEvents pnl_PhoneNumber As RoundedPanel
    Friend WithEvents txt_PhoneNumber As RoundedTextBox
    Friend WithEvents pnl_Password As RoundedPanel
    Friend WithEvents txt_Password As RoundedTextBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents pnl_ConfPassword As RoundedPanel
    Friend WithEvents txt_ConfPassword As RoundedTextBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
