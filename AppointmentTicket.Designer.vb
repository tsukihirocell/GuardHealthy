<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AppointmentTicket
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AppointmentTicket))
        pnl_Header = New Panel()
        Label3 = New Label()
        pic_Menu = New PictureBox()
        pic_Logo = New PictureBox()
        PictureBox2 = New PictureBox()
        pnl_DoctorPage = New RoundedPanel()
        lbl_Note = New Label()
        lbl_Healthcare = New Label()
        lbl_Time = New Label()
        lbl_Date = New Label()
        btn_Edit = New CustomControls.RJControls.RoundedButton()
        btn_Cancel = New CustomControls.RJControls.RoundedButton()
        btn_Home = New CustomControls.RJControls.RoundedButton()
        pnl_Header.SuspendLayout()
        CType(pic_Menu, ComponentModel.ISupportInitialize).BeginInit()
        CType(pic_Logo, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        pnl_DoctorPage.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnl_Header
        ' 
        pnl_Header.BackColor = Color.Transparent
        pnl_Header.BorderStyle = BorderStyle.FixedSingle
        pnl_Header.Controls.Add(Label3)
        pnl_Header.Controls.Add(pic_Menu)
        pnl_Header.Controls.Add(pic_Logo)
        pnl_Header.Location = New Point(-19, -5)
        pnl_Header.Name = "pnl_Header"
        pnl_Header.Size = New Size(422, 68)
        pnl_Header.TabIndex = 18
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
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Cursor = Cursors.Hand
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(27, 87)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(38, 36)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 17
        PictureBox2.TabStop = False
        ' 
        ' pnl_DoctorPage
        ' 
        pnl_DoctorPage.Controls.Add(lbl_Note)
        pnl_DoctorPage.Controls.Add(lbl_Healthcare)
        pnl_DoctorPage.Controls.Add(lbl_Time)
        pnl_DoctorPage.Controls.Add(lbl_Date)
        pnl_DoctorPage.CornerRadius = 20
        pnl_DoctorPage.Location = New Point(18, 165)
        pnl_DoctorPage.Name = "pnl_DoctorPage"
        pnl_DoctorPage.Size = New Size(345, 170)
        pnl_DoctorPage.TabIndex = 19
        ' 
        ' lbl_Note
        ' 
        lbl_Note.AutoSize = True
        lbl_Note.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_Note.Location = New Point(13, 97)
        lbl_Note.Name = "lbl_Note"
        lbl_Note.Size = New Size(42, 17)
        lbl_Note.TabIndex = 3
        lbl_Note.Text = "Note:"
        ' 
        ' lbl_Healthcare
        ' 
        lbl_Healthcare.AutoSize = True
        lbl_Healthcare.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_Healthcare.Location = New Point(12, 68)
        lbl_Healthcare.Name = "lbl_Healthcare"
        lbl_Healthcare.Size = New Size(130, 17)
        lbl_Healthcare.TabIndex = 2
        lbl_Healthcare.Text = "Healthcare Provider"
        ' 
        ' lbl_Time
        ' 
        lbl_Time.AutoSize = True
        lbl_Time.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_Time.Location = New Point(12, 41)
        lbl_Time.Name = "lbl_Time"
        lbl_Time.Size = New Size(39, 17)
        lbl_Time.TabIndex = 1
        lbl_Time.Text = "Time"
        ' 
        ' lbl_Date
        ' 
        lbl_Date.AutoSize = True
        lbl_Date.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_Date.Location = New Point(12, 15)
        lbl_Date.Name = "lbl_Date"
        lbl_Date.Size = New Size(37, 17)
        lbl_Date.TabIndex = 0
        lbl_Date.Text = "Date"
        ' 
        ' btn_Edit
        ' 
        btn_Edit.BackColor = SystemColors.ButtonHighlight
        btn_Edit.BackgroundColor = SystemColors.ButtonHighlight
        btn_Edit.BorderColor = Color.PaleVioletRed
        btn_Edit.BorderRadius = 9
        btn_Edit.BorderSize = 0
        btn_Edit.Cursor = Cursors.Hand
        btn_Edit.FlatAppearance.BorderColor = SystemColors.ButtonHighlight
        btn_Edit.FlatAppearance.MouseDownBackColor = Color.White
        btn_Edit.FlatAppearance.MouseOverBackColor = Color.SteelBlue
        btn_Edit.FlatStyle = FlatStyle.Flat
        btn_Edit.Font = New Font("Segoe UI", 10F)
        btn_Edit.ForeColor = Color.Black
        btn_Edit.Location = New Point(18, 341)
        btn_Edit.Name = "btn_Edit"
        btn_Edit.Size = New Size(345, 52)
        btn_Edit.TabIndex = 35
        btn_Edit.Text = "Edit"
        btn_Edit.TextColor = Color.Black
        btn_Edit.UseVisualStyleBackColor = False
        ' 
        ' btn_Cancel
        ' 
        btn_Cancel.BackColor = SystemColors.ButtonHighlight
        btn_Cancel.BackgroundColor = SystemColors.ButtonHighlight
        btn_Cancel.BorderColor = Color.PaleVioletRed
        btn_Cancel.BorderRadius = 9
        btn_Cancel.BorderSize = 0
        btn_Cancel.Cursor = Cursors.Hand
        btn_Cancel.FlatAppearance.BorderColor = SystemColors.ButtonHighlight
        btn_Cancel.FlatAppearance.MouseDownBackColor = Color.White
        btn_Cancel.FlatAppearance.MouseOverBackColor = Color.SteelBlue
        btn_Cancel.FlatStyle = FlatStyle.Flat
        btn_Cancel.Font = New Font("Segoe UI", 10F)
        btn_Cancel.ForeColor = Color.Black
        btn_Cancel.Location = New Point(18, 399)
        btn_Cancel.Name = "btn_Cancel"
        btn_Cancel.Size = New Size(345, 52)
        btn_Cancel.TabIndex = 36
        btn_Cancel.Text = "Cancel"
        btn_Cancel.TextColor = Color.Black
        btn_Cancel.UseVisualStyleBackColor = False
        ' 
        ' btn_Home
        ' 
        btn_Home.BackColor = SystemColors.ButtonHighlight
        btn_Home.BackgroundColor = SystemColors.ButtonHighlight
        btn_Home.BorderColor = Color.PaleVioletRed
        btn_Home.BorderRadius = 9
        btn_Home.BorderSize = 0
        btn_Home.Cursor = Cursors.Hand
        btn_Home.FlatAppearance.BorderColor = SystemColors.ButtonHighlight
        btn_Home.FlatAppearance.MouseDownBackColor = Color.White
        btn_Home.FlatAppearance.MouseOverBackColor = Color.SteelBlue
        btn_Home.FlatStyle = FlatStyle.Flat
        btn_Home.Font = New Font("Segoe UI", 10F)
        btn_Home.ForeColor = Color.Black
        btn_Home.Location = New Point(18, 457)
        btn_Home.Name = "btn_Home"
        btn_Home.Size = New Size(345, 52)
        btn_Home.TabIndex = 37
        btn_Home.Text = "Home"
        btn_Home.TextColor = Color.Black
        btn_Home.UseVisualStyleBackColor = False
        ' 
        ' AppointmentTicket
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(384, 711)
        Controls.Add(btn_Home)
        Controls.Add(btn_Cancel)
        Controls.Add(btn_Edit)
        Controls.Add(pnl_DoctorPage)
        Controls.Add(pnl_Header)
        Controls.Add(PictureBox2)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "AppointmentTicket"
        StartPosition = FormStartPosition.CenterScreen
        Text = "AppointmentTicket"
        pnl_Header.ResumeLayout(False)
        CType(pic_Menu, ComponentModel.ISupportInitialize).EndInit()
        CType(pic_Logo, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        pnl_DoctorPage.ResumeLayout(False)
        pnl_DoctorPage.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnl_Header As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents pic_Menu As PictureBox
    Friend WithEvents pic_Logo As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents pnl_DoctorPage As RoundedPanel
    Friend WithEvents btn_Edit As CustomControls.RJControls.RoundedButton
    Friend WithEvents btn_Cancel As CustomControls.RJControls.RoundedButton
    Friend WithEvents btn_Home As CustomControls.RJControls.RoundedButton
    Friend WithEvents lbl_Note As Label
    Friend WithEvents lbl_Healthcare As Label
    Friend WithEvents lbl_Time As Label
    Friend WithEvents lbl_Date As Label
End Class
