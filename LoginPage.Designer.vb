<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginPage))
        Panel1 = New Panel()
        pic_HealthGuard = New PictureBox()
        lbl_LoginAcc = New Label()
        RoundedTextBox1 = New RoundedTextBox()
        lbl_ForgotPass = New Label()
        lbl_UserRole = New LinkLabel()
        lbl_DontHaveAcc = New Label()
        btn_LoginBtn = New CustomControls.RJControls.RoundedButton()
        PictureBox2 = New PictureBox()
        pnl_Username = New RoundedPanel()
        pnl_Password = New RoundedPanel()
        RoundedTextBox3 = New RoundedTextBox()
        Panel1.SuspendLayout()
        CType(pic_HealthGuard, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        pnl_Username.SuspendLayout()
        pnl_Password.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Transparent
        Panel1.Controls.Add(pic_HealthGuard)
        Panel1.Location = New Point(45, 172)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(289, 176)
        Panel1.TabIndex = 1
        ' 
        ' pic_HealthGuard
        ' 
        pic_HealthGuard.BackColor = Color.Transparent
        pic_HealthGuard.Dock = DockStyle.Fill
        pic_HealthGuard.Image = CType(resources.GetObject("pic_HealthGuard.Image"), Image)
        pic_HealthGuard.Location = New Point(0, 0)
        pic_HealthGuard.Name = "pic_HealthGuard"
        pic_HealthGuard.Size = New Size(289, 176)
        pic_HealthGuard.SizeMode = PictureBoxSizeMode.Zoom
        pic_HealthGuard.TabIndex = 0
        pic_HealthGuard.TabStop = False
        ' 
        ' lbl_LoginAcc
        ' 
        lbl_LoginAcc.AutoSize = True
        lbl_LoginAcc.BackColor = Color.Transparent
        lbl_LoginAcc.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_LoginAcc.ForeColor = Color.SteelBlue
        lbl_LoginAcc.Location = New Point(123, 351)
        lbl_LoginAcc.Name = "lbl_LoginAcc"
        lbl_LoginAcc.Size = New Size(170, 21)
        lbl_LoginAcc.TabIndex = 2
        lbl_LoginAcc.Text = "Login to your account"
        ' 
        ' RoundedTextBox1
        ' 
        RoundedTextBox1.Location = New Point(9, 13)
        RoundedTextBox1.Multiline = True
        RoundedTextBox1.Name = "RoundedTextBox1"
        RoundedTextBox1.PlaceholderText = "Phone Number, Username or Email"
        RoundedTextBox1.Size = New Size(289, 22)
        RoundedTextBox1.TabIndex = 3
        ' 
        ' lbl_ForgotPass
        ' 
        lbl_ForgotPass.AutoSize = True
        lbl_ForgotPass.BackColor = Color.Transparent
        lbl_ForgotPass.Cursor = Cursors.Hand
        lbl_ForgotPass.ForeColor = Color.SteelBlue
        lbl_ForgotPass.Location = New Point(155, 510)
        lbl_ForgotPass.Name = "lbl_ForgotPass"
        lbl_ForgotPass.Size = New Size(100, 15)
        lbl_ForgotPass.TabIndex = 5
        lbl_ForgotPass.Text = "Forgot Password?"
        ' 
        ' lbl_UserRole
        ' 
        lbl_UserRole.ActiveLinkColor = Color.White
        lbl_UserRole.AutoSize = True
        lbl_UserRole.BackColor = Color.Transparent
        lbl_UserRole.Cursor = Cursors.Hand
        lbl_UserRole.Location = New Point(251, 604)
        lbl_UserRole.Name = "lbl_UserRole"
        lbl_UserRole.Size = New Size(53, 15)
        lbl_UserRole.TabIndex = 11
        lbl_UserRole.TabStop = True
        lbl_UserRole.Text = "User role"
        ' 
        ' lbl_DontHaveAcc
        ' 
        lbl_DontHaveAcc.AutoSize = True
        lbl_DontHaveAcc.BackColor = Color.Transparent
        lbl_DontHaveAcc.Location = New Point(112, 604)
        lbl_DontHaveAcc.Name = "lbl_DontHaveAcc"
        lbl_DontHaveAcc.Size = New Size(142, 15)
        lbl_DontHaveAcc.TabIndex = 10
        lbl_DontHaveAcc.Text = "Doesn't have an account?"
        ' 
        ' btn_LoginBtn
        ' 
        btn_LoginBtn.BackColor = SystemColors.ButtonHighlight
        btn_LoginBtn.BackgroundColor = SystemColors.ButtonHighlight
        btn_LoginBtn.BorderColor = Color.PaleVioletRed
        btn_LoginBtn.BorderRadius = 9
        btn_LoginBtn.BorderSize = 0
        btn_LoginBtn.Cursor = Cursors.Hand
        btn_LoginBtn.FlatAppearance.BorderColor = SystemColors.ButtonHighlight
        btn_LoginBtn.FlatAppearance.MouseDownBackColor = Color.White
        btn_LoginBtn.FlatAppearance.MouseOverBackColor = Color.SteelBlue
        btn_LoginBtn.FlatStyle = FlatStyle.Flat
        btn_LoginBtn.Font = New Font("Segoe UI", 10F)
        btn_LoginBtn.ForeColor = Color.Black
        btn_LoginBtn.Location = New Point(36, 643)
        btn_LoginBtn.Name = "btn_LoginBtn"
        btn_LoginBtn.Size = New Size(331, 52)
        btn_LoginBtn.TabIndex = 12
        btn_LoginBtn.Text = "Login"
        btn_LoginBtn.TextColor = Color.Black
        btn_LoginBtn.UseVisualStyleBackColor = False
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
        ' pnl_Username
        ' 
        pnl_Username.BackColor = SystemColors.Window
        pnl_Username.Controls.Add(RoundedTextBox1)
        pnl_Username.CornerRadius = 20
        pnl_Username.Location = New Point(36, 398)
        pnl_Username.Name = "pnl_Username"
        pnl_Username.Size = New Size(331, 48)
        pnl_Username.TabIndex = 17
        ' 
        ' pnl_Password
        ' 
        pnl_Password.BackColor = SystemColors.Window
        pnl_Password.Controls.Add(RoundedTextBox3)
        pnl_Password.Controls.Add(PictureBox2)
        pnl_Password.CornerRadius = 20
        pnl_Password.Location = New Point(36, 452)
        pnl_Password.Name = "pnl_Password"
        pnl_Password.Size = New Size(331, 48)
        pnl_Password.TabIndex = 18
        ' 
        ' RoundedTextBox3
        ' 
        RoundedTextBox3.Location = New Point(9, 14)
        RoundedTextBox3.Multiline = True
        RoundedTextBox3.Name = "RoundedTextBox3"
        RoundedTextBox3.PasswordChar = "*"c
        RoundedTextBox3.PlaceholderText = "Password"
        RoundedTextBox3.Size = New Size(276, 22)
        RoundedTextBox3.TabIndex = 3
        ' 
        ' LoginPage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(400, 750)
        Controls.Add(pnl_Password)
        Controls.Add(pnl_Username)
        Controls.Add(btn_LoginBtn)
        Controls.Add(lbl_UserRole)
        Controls.Add(lbl_DontHaveAcc)
        Controls.Add(lbl_ForgotPass)
        Controls.Add(lbl_LoginAcc)
        Controls.Add(Panel1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "LoginPage"
        StartPosition = FormStartPosition.CenterScreen
        Text = "LoginPage"
        Panel1.ResumeLayout(False)
        CType(pic_HealthGuard, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        pnl_Username.ResumeLayout(False)
        pnl_Username.PerformLayout()
        pnl_Password.ResumeLayout(False)
        pnl_Password.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents pic_HealthGuard As PictureBox
    Friend WithEvents lbl_LoginAcc As Label
    Friend WithEvents RoundedTextBox1 As RoundedTextBox
    Friend WithEvents lbl_ForgotPass As Label
    Friend WithEvents lbl_UserRole As LinkLabel
    Friend WithEvents lbl_DontHaveAcc As Label
    Friend WithEvents btn_LoginBtn As CustomControls.RJControls.RoundedButton
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents pnl_Username As RoundedPanel
    Friend WithEvents pnl_Password As RoundedPanel
    Friend WithEvents RoundedTextBox3 As RoundedTextBox
End Class
