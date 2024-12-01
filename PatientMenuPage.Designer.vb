<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PatientMenuPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PatientMenuPage))
        btn_Records = New CustomControls.RJControls.RoundedButton()
        btn_Prescription = New CustomControls.RJControls.RoundedButton()
        lbl_Services = New Label()
        pic_Logo = New PictureBox()
        pic_Header = New PictureBox()
        pnl_Header = New Panel()
        Label1 = New Label()
        pic_Menu = New PictureBox()
        pic_HeaderLogo = New PictureBox()
        btn_Appointment = New CustomControls.RJControls.RoundedButton()
        CType(pic_Logo, ComponentModel.ISupportInitialize).BeginInit()
        CType(pic_Header, ComponentModel.ISupportInitialize).BeginInit()
        pnl_Header.SuspendLayout()
        CType(pic_Menu, ComponentModel.ISupportInitialize).BeginInit()
        CType(pic_HeaderLogo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btn_Records
        ' 
        btn_Records.BackColor = SystemColors.ButtonHighlight
        btn_Records.BackgroundColor = SystemColors.ButtonHighlight
        btn_Records.BorderColor = Color.PaleVioletRed
        btn_Records.BorderRadius = 9
        btn_Records.BorderSize = 0
        btn_Records.FlatAppearance.BorderSize = 0
        btn_Records.FlatAppearance.MouseOverBackColor = Color.SteelBlue
        btn_Records.FlatStyle = FlatStyle.Flat
        btn_Records.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_Records.ForeColor = Color.Black
        btn_Records.Image = CType(resources.GetObject("btn_Records.Image"), Image)
        btn_Records.Location = New Point(42, 395)
        btn_Records.Name = "btn_Records"
        btn_Records.Size = New Size(136, 118)
        btn_Records.TabIndex = 18
        btn_Records.Text = "Records"
        btn_Records.TextAlign = ContentAlignment.BottomCenter
        btn_Records.TextColor = Color.Black
        btn_Records.UseVisualStyleBackColor = False
        ' 
        ' btn_Prescription
        ' 
        btn_Prescription.BackColor = SystemColors.ButtonHighlight
        btn_Prescription.BackgroundColor = SystemColors.ButtonHighlight
        btn_Prescription.BorderColor = Color.PaleVioletRed
        btn_Prescription.BorderRadius = 9
        btn_Prescription.BorderSize = 0
        btn_Prescription.FlatAppearance.BorderSize = 0
        btn_Prescription.FlatAppearance.MouseOverBackColor = Color.SteelBlue
        btn_Prescription.FlatStyle = FlatStyle.Flat
        btn_Prescription.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_Prescription.ForeColor = Color.Black
        btn_Prescription.Image = CType(resources.GetObject("btn_Prescription.Image"), Image)
        btn_Prescription.Location = New Point(211, 395)
        btn_Prescription.Name = "btn_Prescription"
        btn_Prescription.Size = New Size(136, 118)
        btn_Prescription.TabIndex = 17
        btn_Prescription.Text = "Prescription"
        btn_Prescription.TextAlign = ContentAlignment.BottomCenter
        btn_Prescription.TextColor = Color.Black
        btn_Prescription.UseVisualStyleBackColor = False
        ' 
        ' lbl_Services
        ' 
        lbl_Services.AutoSize = True
        lbl_Services.BackColor = Color.Transparent
        lbl_Services.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_Services.Location = New Point(91, 332)
        lbl_Services.Name = "lbl_Services"
        lbl_Services.Size = New Size(213, 42)
        lbl_Services.TabIndex = 16
        lbl_Services.Text = "PLEASE CHOOSE FROM " & vbCrLf & "THE FOLLOWING SERVICES"
        lbl_Services.TextAlign = ContentAlignment.TopCenter
        ' 
        ' pic_Logo
        ' 
        pic_Logo.BackColor = Color.Transparent
        pic_Logo.Image = CType(resources.GetObject("pic_Logo.Image"), Image)
        pic_Logo.Location = New Point(26, 165)
        pic_Logo.Name = "pic_Logo"
        pic_Logo.Size = New Size(336, 192)
        pic_Logo.SizeMode = PictureBoxSizeMode.Zoom
        pic_Logo.TabIndex = 15
        pic_Logo.TabStop = False
        ' 
        ' pic_Header
        ' 
        pic_Header.BackColor = Color.Transparent
        pic_Header.Image = CType(resources.GetObject("pic_Header.Image"), Image)
        pic_Header.Location = New Point(-1, 22)
        pic_Header.Name = "pic_Header"
        pic_Header.Size = New Size(387, 300)
        pic_Header.SizeMode = PictureBoxSizeMode.Zoom
        pic_Header.TabIndex = 14
        pic_Header.TabStop = False
        ' 
        ' pnl_Header
        ' 
        pnl_Header.BackColor = Color.Transparent
        pnl_Header.BorderStyle = BorderStyle.FixedSingle
        pnl_Header.Controls.Add(Label1)
        pnl_Header.Controls.Add(pic_Menu)
        pnl_Header.Controls.Add(pic_HeaderLogo)
        pnl_Header.Location = New Point(-8, -4)
        pnl_Header.Name = "pnl_Header"
        pnl_Header.Size = New Size(401, 68)
        pnl_Header.TabIndex = 19
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(22, 42)
        Label1.Name = "Label1"
        Label1.Size = New Size(47, 16)
        Label1.TabIndex = 5
        Label1.Text = "MENU"
        Label1.TextAlign = ContentAlignment.TopCenter
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
        ' pic_HeaderLogo
        ' 
        pic_HeaderLogo.BackColor = Color.Transparent
        pic_HeaderLogo.Image = CType(resources.GetObject("pic_HeaderLogo.Image"), Image)
        pic_HeaderLogo.Location = New Point(48, -11)
        pic_HeaderLogo.Name = "pic_HeaderLogo"
        pic_HeaderLogo.Size = New Size(142, 90)
        pic_HeaderLogo.SizeMode = PictureBoxSizeMode.Zoom
        pic_HeaderLogo.TabIndex = 2
        pic_HeaderLogo.TabStop = False
        ' 
        ' btn_Appointment
        ' 
        btn_Appointment.BackColor = SystemColors.ButtonHighlight
        btn_Appointment.BackgroundColor = SystemColors.ButtonHighlight
        btn_Appointment.BorderColor = Color.PaleVioletRed
        btn_Appointment.BorderRadius = 9
        btn_Appointment.BorderSize = 0
        btn_Appointment.FlatAppearance.BorderSize = 0
        btn_Appointment.FlatAppearance.MouseOverBackColor = Color.SteelBlue
        btn_Appointment.FlatStyle = FlatStyle.Flat
        btn_Appointment.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_Appointment.ForeColor = Color.Black
        btn_Appointment.Image = CType(resources.GetObject("btn_Appointment.Image"), Image)
        btn_Appointment.Location = New Point(127, 533)
        btn_Appointment.Name = "btn_Appointment"
        btn_Appointment.Size = New Size(136, 118)
        btn_Appointment.TabIndex = 20
        btn_Appointment.Text = "Appointment"
        btn_Appointment.TextAlign = ContentAlignment.BottomCenter
        btn_Appointment.TextColor = Color.Black
        btn_Appointment.UseVisualStyleBackColor = False
        ' 
        ' PatientMenuPage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(384, 711)
        Controls.Add(btn_Appointment)
        Controls.Add(pnl_Header)
        Controls.Add(btn_Records)
        Controls.Add(btn_Prescription)
        Controls.Add(lbl_Services)
        Controls.Add(pic_Logo)
        Controls.Add(pic_Header)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "PatientMenuPage"
        StartPosition = FormStartPosition.CenterScreen
        Text = "."
        CType(pic_Logo, ComponentModel.ISupportInitialize).EndInit()
        CType(pic_Header, ComponentModel.ISupportInitialize).EndInit()
        pnl_Header.ResumeLayout(False)
        CType(pic_Menu, ComponentModel.ISupportInitialize).EndInit()
        CType(pic_HeaderLogo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btn_Records As CustomControls.RJControls.RoundedButton
    Friend WithEvents btn_Prescription As CustomControls.RJControls.RoundedButton
    Friend WithEvents lbl_Services As Label
    Friend WithEvents pic_Logo As PictureBox
    Friend WithEvents pic_Header As PictureBox
    Friend WithEvents pnl_Header As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents pic_Menu As PictureBox
    Friend WithEvents pic_HeaderLogo As PictureBox
    Friend WithEvents btn_Appointment As CustomControls.RJControls.RoundedButton
End Class
