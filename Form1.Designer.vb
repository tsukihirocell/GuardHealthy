<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Panel1 = New Panel()
        pic_Logo = New PictureBox()
        lbl_Welcome = New Label()
        lbl_Managing = New Label()
        lbl_Label = New Label()
        btn_Patient = New CustomControls.RJControls.RoundedButton()
        btn_Nurse = New CustomControls.RJControls.RoundedButton()
        btn_Doctor = New CustomControls.RJControls.RoundedButton()
        lbl_UserRole = New Label()
        lbl_DontHaveAcc = New Label()
        lbl_Register = New LinkLabel()
        Panel1.SuspendLayout()
        CType(pic_Logo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Transparent
        Panel1.Controls.Add(pic_Logo)
        Panel1.Location = New Point(52, 124)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(289, 176)
        Panel1.TabIndex = 0
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
        ' lbl_Welcome
        ' 
        lbl_Welcome.AutoSize = True
        lbl_Welcome.BackColor = Color.Transparent
        lbl_Welcome.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_Welcome.Location = New Point(117, 308)
        lbl_Welcome.Name = "lbl_Welcome"
        lbl_Welcome.Size = New Size(170, 17)
        lbl_Welcome.TabIndex = 1
        lbl_Welcome.Text = "Welcome to HealthGuard! "
        ' 
        ' lbl_Managing
        ' 
        lbl_Managing.AutoSize = True
        lbl_Managing.BackColor = Color.Transparent
        lbl_Managing.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        lbl_Managing.Location = New Point(39, 325)
        lbl_Managing.Name = "lbl_Managing"
        lbl_Managing.Size = New Size(320, 17)
        lbl_Managing.TabIndex = 2
        lbl_Managing.Text = "Let’s make managing your prescriptions and health"
        ' 
        ' lbl_Label
        ' 
        lbl_Label.AutoSize = True
        lbl_Label.BackColor = Color.Transparent
        lbl_Label.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        lbl_Label.Location = New Point(117, 342)
        lbl_Label.Name = "lbl_Label"
        lbl_Label.Size = New Size(164, 17)
        lbl_Label.TabIndex = 3
        lbl_Label.Text = "updates easier, every day."
        ' 
        ' btn_Patient
        ' 
        btn_Patient.BackColor = SystemColors.ButtonHighlight
        btn_Patient.BackgroundColor = SystemColors.ButtonHighlight
        btn_Patient.BorderColor = Color.PaleVioletRed
        btn_Patient.BorderRadius = 9
        btn_Patient.BorderSize = 0
        btn_Patient.Cursor = Cursors.Hand
        btn_Patient.FlatAppearance.BorderColor = SystemColors.ButtonHighlight
        btn_Patient.FlatAppearance.MouseDownBackColor = Color.White
        btn_Patient.FlatAppearance.MouseOverBackColor = Color.SteelBlue
        btn_Patient.FlatStyle = FlatStyle.Flat
        btn_Patient.Font = New Font("Segoe UI", 10F)
        btn_Patient.ForeColor = Color.Black
        btn_Patient.Location = New Point(94, 413)
        btn_Patient.Name = "btn_Patient"
        btn_Patient.Size = New Size(209, 40)
        btn_Patient.TabIndex = 4
        btn_Patient.Text = "PATIENT"
        btn_Patient.TextColor = Color.Black
        btn_Patient.UseVisualStyleBackColor = False
        ' 
        ' btn_Nurse
        ' 
        btn_Nurse.BackColor = SystemColors.ButtonHighlight
        btn_Nurse.BackgroundColor = SystemColors.ButtonHighlight
        btn_Nurse.BorderColor = Color.PaleVioletRed
        btn_Nurse.BorderRadius = 9
        btn_Nurse.BorderSize = 0
        btn_Nurse.Cursor = Cursors.Hand
        btn_Nurse.FlatAppearance.BorderColor = SystemColors.ButtonHighlight
        btn_Nurse.FlatAppearance.MouseDownBackColor = Color.White
        btn_Nurse.FlatAppearance.MouseOverBackColor = Color.SteelBlue
        btn_Nurse.FlatStyle = FlatStyle.Flat
        btn_Nurse.Font = New Font("Segoe UI", 10F)
        btn_Nurse.ForeColor = Color.Black
        btn_Nurse.Location = New Point(94, 469)
        btn_Nurse.Name = "btn_Nurse"
        btn_Nurse.Size = New Size(209, 40)
        btn_Nurse.TabIndex = 5
        btn_Nurse.Text = "NURSE"
        btn_Nurse.TextColor = Color.Black
        btn_Nurse.UseVisualStyleBackColor = False
        ' 
        ' btn_Doctor
        ' 
        btn_Doctor.BackColor = SystemColors.ButtonHighlight
        btn_Doctor.BackgroundColor = SystemColors.ButtonHighlight
        btn_Doctor.BorderColor = Color.PaleVioletRed
        btn_Doctor.BorderRadius = 9
        btn_Doctor.BorderSize = 0
        btn_Doctor.Cursor = Cursors.Hand
        btn_Doctor.FlatAppearance.BorderColor = SystemColors.ButtonHighlight
        btn_Doctor.FlatAppearance.MouseDownBackColor = Color.White
        btn_Doctor.FlatAppearance.MouseOverBackColor = Color.SteelBlue
        btn_Doctor.FlatStyle = FlatStyle.Flat
        btn_Doctor.Font = New Font("Segoe UI", 10F)
        btn_Doctor.ForeColor = Color.Black
        btn_Doctor.Location = New Point(94, 526)
        btn_Doctor.Name = "btn_Doctor"
        btn_Doctor.Size = New Size(209, 40)
        btn_Doctor.TabIndex = 6
        btn_Doctor.Text = "DOCTOR"
        btn_Doctor.TextColor = Color.Black
        btn_Doctor.UseVisualStyleBackColor = False
        ' 
        ' lbl_UserRole
        ' 
        lbl_UserRole.AutoSize = True
        lbl_UserRole.BackColor = Color.Transparent
        lbl_UserRole.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_UserRole.Location = New Point(125, 586)
        lbl_UserRole.Name = "lbl_UserRole"
        lbl_UserRole.Size = New Size(148, 15)
        lbl_UserRole.TabIndex = 7
        lbl_UserRole.Text = "Please select your user role"
        ' 
        ' lbl_DontHaveAcc
        ' 
        lbl_DontHaveAcc.AutoSize = True
        lbl_DontHaveAcc.BackColor = Color.Transparent
        lbl_DontHaveAcc.Location = New Point(106, 643)
        lbl_DontHaveAcc.Name = "lbl_DontHaveAcc"
        lbl_DontHaveAcc.Size = New Size(142, 15)
        lbl_DontHaveAcc.TabIndex = 8
        lbl_DontHaveAcc.Text = "Doesn't have an account?"
        ' 
        ' lbl_Register
        ' 
        lbl_Register.ActiveLinkColor = Color.White
        lbl_Register.AutoSize = True
        lbl_Register.BackColor = Color.Transparent
        lbl_Register.Cursor = Cursors.Hand
        lbl_Register.Location = New Point(245, 643)
        lbl_Register.Name = "lbl_Register"
        lbl_Register.Size = New Size(49, 15)
        lbl_Register.TabIndex = 9
        lbl_Register.TabStop = True
        lbl_Register.Text = "Register"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(400, 750)
        Controls.Add(lbl_Register)
        Controls.Add(lbl_DontHaveAcc)
        Controls.Add(lbl_UserRole)
        Controls.Add(btn_Doctor)
        Controls.Add(btn_Nurse)
        Controls.Add(btn_Patient)
        Controls.Add(lbl_Label)
        Controls.Add(lbl_Managing)
        Controls.Add(lbl_Welcome)
        Controls.Add(Panel1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        Panel1.ResumeLayout(False)
        CType(pic_Logo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents pic_Logo As PictureBox
    Friend WithEvents lbl_Welcome As Label
    Friend WithEvents lbl_Managing As Label
    Friend WithEvents lbl_Label As Label
    Friend WithEvents btn_Patient As CustomControls.RJControls.RoundedButton
    Friend WithEvents btn_Nurse As CustomControls.RJControls.RoundedButton
    Friend WithEvents btn_Doctor As CustomControls.RJControls.RoundedButton
    Friend WithEvents lbl_UserRole As Label
    Friend WithEvents lbl_DontHaveAcc As Label
    Friend WithEvents lbl_Register As LinkLabel

End Class
