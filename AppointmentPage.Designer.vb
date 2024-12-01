<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AppointmentPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AppointmentPage))
        Panel1 = New Panel()
        Label3 = New Label()
        pic_Menu = New PictureBox()
        pic_Logo = New PictureBox()
        pic_Exit = New PictureBox()
        btn_SchedAppoint = New CustomControls.RJControls.RoundedButton()
        btn_NewAppoint = New CustomControls.RJControls.RoundedButton()
        Panel1.SuspendLayout()
        CType(pic_Menu, ComponentModel.ISupportInitialize).BeginInit()
        CType(pic_Logo, ComponentModel.ISupportInitialize).BeginInit()
        CType(pic_Exit, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Transparent
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(pic_Menu)
        Panel1.Controls.Add(pic_Logo)
        Panel1.Location = New Point(-19, -6)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(422, 68)
        Panel1.TabIndex = 12
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
        ' pic_Exit
        ' 
        pic_Exit.BackColor = Color.Transparent
        pic_Exit.Cursor = Cursors.Hand
        pic_Exit.Image = CType(resources.GetObject("pic_Exit.Image"), Image)
        pic_Exit.Location = New Point(27, 86)
        pic_Exit.Name = "pic_Exit"
        pic_Exit.Size = New Size(38, 36)
        pic_Exit.SizeMode = PictureBoxSizeMode.Zoom
        pic_Exit.TabIndex = 10
        pic_Exit.TabStop = False
        ' 
        ' btn_SchedAppoint
        ' 
        btn_SchedAppoint.BackColor = SystemColors.ButtonHighlight
        btn_SchedAppoint.BackgroundColor = SystemColors.ButtonHighlight
        btn_SchedAppoint.BorderColor = Color.PaleVioletRed
        btn_SchedAppoint.BorderRadius = 9
        btn_SchedAppoint.BorderSize = 0
        btn_SchedAppoint.FlatAppearance.BorderSize = 0
        btn_SchedAppoint.FlatAppearance.MouseOverBackColor = Color.SteelBlue
        btn_SchedAppoint.FlatStyle = FlatStyle.Flat
        btn_SchedAppoint.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_SchedAppoint.ForeColor = Color.Black
        btn_SchedAppoint.Image = CType(resources.GetObject("btn_SchedAppoint.Image"), Image)
        btn_SchedAppoint.Location = New Point(122, 348)
        btn_SchedAppoint.Name = "btn_SchedAppoint"
        btn_SchedAppoint.Size = New Size(136, 118)
        btn_SchedAppoint.TabIndex = 14
        btn_SchedAppoint.Text = "Scheduled Appointment"
        btn_SchedAppoint.TextAlign = ContentAlignment.BottomCenter
        btn_SchedAppoint.TextColor = Color.Black
        btn_SchedAppoint.UseVisualStyleBackColor = False
        ' 
        ' btn_NewAppoint
        ' 
        btn_NewAppoint.BackColor = SystemColors.ButtonHighlight
        btn_NewAppoint.BackgroundColor = SystemColors.ButtonHighlight
        btn_NewAppoint.BorderColor = Color.PaleVioletRed
        btn_NewAppoint.BorderRadius = 9
        btn_NewAppoint.BorderSize = 0
        btn_NewAppoint.FlatAppearance.BorderSize = 0
        btn_NewAppoint.FlatAppearance.MouseOverBackColor = Color.SteelBlue
        btn_NewAppoint.FlatStyle = FlatStyle.Flat
        btn_NewAppoint.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_NewAppoint.ForeColor = Color.Black
        btn_NewAppoint.Image = CType(resources.GetObject("btn_NewAppoint.Image"), Image)
        btn_NewAppoint.Location = New Point(122, 194)
        btn_NewAppoint.Name = "btn_NewAppoint"
        btn_NewAppoint.Size = New Size(136, 118)
        btn_NewAppoint.TabIndex = 21
        btn_NewAppoint.Text = "New Appointment"
        btn_NewAppoint.TextAlign = ContentAlignment.BottomCenter
        btn_NewAppoint.TextColor = Color.Black
        btn_NewAppoint.UseVisualStyleBackColor = False
        ' 
        ' AppointmentPage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(384, 711)
        Controls.Add(btn_NewAppoint)
        Controls.Add(btn_SchedAppoint)
        Controls.Add(Panel1)
        Controls.Add(pic_Exit)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "AppointmentPage"
        StartPosition = FormStartPosition.CenterScreen
        Text = "AppointmentPage"
        Panel1.ResumeLayout(False)
        CType(pic_Menu, ComponentModel.ISupportInitialize).EndInit()
        CType(pic_Logo, ComponentModel.ISupportInitialize).EndInit()
        CType(pic_Exit, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents pic_Menu As PictureBox
    Friend WithEvents pic_Logo As PictureBox
    Friend WithEvents pic_Exit As PictureBox
    Friend WithEvents btn_SchedAppoint As CustomControls.RJControls.RoundedButton
    Friend WithEvents btn_NewAppoint As CustomControls.RJControls.RoundedButton
End Class
