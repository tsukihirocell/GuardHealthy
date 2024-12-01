<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NurseMenuPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NurseMenuPage))
        pic_HeaderLogo = New PictureBox()
        pic_Menu = New PictureBox()
        pnl_Header = New Panel()
        Label1 = New Label()
        pic_Logo = New PictureBox()
        lbl_Services = New Label()
        pic_Header = New PictureBox()
        Panel2 = New Panel()
        btn_Records = New CustomControls.RJControls.RoundedButton()
        btn_Prescription = New CustomControls.RJControls.RoundedButton()
        CType(pic_HeaderLogo, ComponentModel.ISupportInitialize).BeginInit()
        CType(pic_Menu, ComponentModel.ISupportInitialize).BeginInit()
        pnl_Header.SuspendLayout()
        CType(pic_Logo, ComponentModel.ISupportInitialize).BeginInit()
        CType(pic_Header, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
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
        ' pnl_Header
        ' 
        pnl_Header.BackColor = Color.Transparent
        pnl_Header.BorderStyle = BorderStyle.FixedSingle
        pnl_Header.Controls.Add(Label1)
        pnl_Header.Controls.Add(pic_Menu)
        pnl_Header.Controls.Add(pic_HeaderLogo)
        pnl_Header.Location = New Point(-11, -5)
        pnl_Header.Name = "pnl_Header"
        pnl_Header.Size = New Size(401, 68)
        pnl_Header.TabIndex = 4
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
        ' pic_Logo
        ' 
        pic_Logo.BackColor = Color.Transparent
        pic_Logo.Image = CType(resources.GetObject("pic_Logo.Image"), Image)
        pic_Logo.Location = New Point(29, 108)
        pic_Logo.Name = "pic_Logo"
        pic_Logo.Size = New Size(336, 192)
        pic_Logo.SizeMode = PictureBoxSizeMode.Zoom
        pic_Logo.TabIndex = 6
        pic_Logo.TabStop = False
        ' 
        ' lbl_Services
        ' 
        lbl_Services.AutoSize = True
        lbl_Services.BackColor = Color.Transparent
        lbl_Services.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_Services.Location = New Point(94, 275)
        lbl_Services.Name = "lbl_Services"
        lbl_Services.Size = New Size(213, 42)
        lbl_Services.TabIndex = 7
        lbl_Services.Text = "PLEASE CHOOSE FROM " & vbCrLf & "THE FOLLOWING SERVICES"
        lbl_Services.TextAlign = ContentAlignment.TopCenter
        ' 
        ' pic_Header
        ' 
        pic_Header.BackColor = Color.Transparent
        pic_Header.Image = CType(resources.GetObject("pic_Header.Image"), Image)
        pic_Header.Location = New Point(2, -35)
        pic_Header.Name = "pic_Header"
        pic_Header.Size = New Size(387, 300)
        pic_Header.SizeMode = PictureBoxSizeMode.Zoom
        pic_Header.TabIndex = 5
        pic_Header.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Transparent
        Panel2.Controls.Add(btn_Records)
        Panel2.Controls.Add(btn_Prescription)
        Panel2.Controls.Add(lbl_Services)
        Panel2.Controls.Add(pic_Logo)
        Panel2.Controls.Add(pic_Header)
        Panel2.Location = New Point(-7, 57)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(397, 654)
        Panel2.TabIndex = 10
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
        btn_Records.Location = New Point(45, 373)
        btn_Records.Name = "btn_Records"
        btn_Records.Size = New Size(136, 118)
        btn_Records.TabIndex = 13
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
        btn_Prescription.Location = New Point(214, 373)
        btn_Prescription.Name = "btn_Prescription"
        btn_Prescription.Size = New Size(136, 118)
        btn_Prescription.TabIndex = 12
        btn_Prescription.Text = "Prescription"
        btn_Prescription.TextAlign = ContentAlignment.BottomCenter
        btn_Prescription.TextColor = Color.Black
        btn_Prescription.UseVisualStyleBackColor = False
        ' 
        ' NurseMenuPage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(384, 711)
        Controls.Add(pnl_Header)
        Controls.Add(Panel2)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "NurseMenuPage"
        StartPosition = FormStartPosition.CenterScreen
        Text = "MenuPage"
        CType(pic_HeaderLogo, ComponentModel.ISupportInitialize).EndInit()
        CType(pic_Menu, ComponentModel.ISupportInitialize).EndInit()
        pnl_Header.ResumeLayout(False)
        CType(pic_Logo, ComponentModel.ISupportInitialize).EndInit()
        CType(pic_Header, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents pic_HeaderLogo As PictureBox
    Friend WithEvents pic_Menu As PictureBox
    Friend WithEvents pnl_Header As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents pic_Logo As PictureBox
    Friend WithEvents lbl_Services As Label
    Friend WithEvents pic_Header As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn_Prescription As CustomControls.RJControls.RoundedButton
    Friend WithEvents btn_Records As CustomControls.RJControls.RoundedButton
End Class
