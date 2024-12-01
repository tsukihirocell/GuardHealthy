<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SpecialistPage
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SpecialistPage))
        pnl_Header = New Panel()
        Label3 = New Label()
        pic_Menu = New PictureBox()
        pic_LogoHeader = New PictureBox()
        pic_Exit = New PictureBox()
        pnl_Specialist = New RoundedPanel()
        btn_BookAppointment = New CustomControls.RJControls.RoundedButton()
        pic_RightArrow = New PictureBox()
        pic_LeftArrow = New PictureBox()
        Timer1 = New Timer(components)
        pnl_Header.SuspendLayout()
        CType(pic_Menu, ComponentModel.ISupportInitialize).BeginInit()
        CType(pic_LogoHeader, ComponentModel.ISupportInitialize).BeginInit()
        CType(pic_Exit, ComponentModel.ISupportInitialize).BeginInit()
        CType(pic_RightArrow, ComponentModel.ISupportInitialize).BeginInit()
        CType(pic_LeftArrow, ComponentModel.ISupportInitialize).BeginInit()
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
        pnl_Header.TabIndex = 16
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
        pic_Exit.TabIndex = 15
        pic_Exit.TabStop = False
        ' 
        ' pnl_Specialist
        ' 
        pnl_Specialist.CornerRadius = 20
        pnl_Specialist.Location = New Point(39, 152)
        pnl_Specialist.Name = "pnl_Specialist"
        pnl_Specialist.Size = New Size(304, 455)
        pnl_Specialist.TabIndex = 17
        ' 
        ' btn_BookAppointment
        ' 
        btn_BookAppointment.BackColor = SystemColors.ButtonHighlight
        btn_BookAppointment.BackgroundColor = SystemColors.ButtonHighlight
        btn_BookAppointment.BorderColor = Color.PaleVioletRed
        btn_BookAppointment.BorderRadius = 9
        btn_BookAppointment.BorderSize = 0
        btn_BookAppointment.Cursor = Cursors.Hand
        btn_BookAppointment.FlatAppearance.BorderColor = SystemColors.ButtonHighlight
        btn_BookAppointment.FlatAppearance.MouseDownBackColor = Color.White
        btn_BookAppointment.FlatAppearance.MouseOverBackColor = Color.SteelBlue
        btn_BookAppointment.FlatStyle = FlatStyle.Flat
        btn_BookAppointment.Font = New Font("Segoe UI", 10F)
        btn_BookAppointment.ForeColor = Color.Black
        btn_BookAppointment.Location = New Point(17, 635)
        btn_BookAppointment.Name = "btn_BookAppointment"
        btn_BookAppointment.Size = New Size(348, 52)
        btn_BookAppointment.TabIndex = 34
        btn_BookAppointment.Text = "Book Appointment"
        btn_BookAppointment.TextColor = Color.Black
        btn_BookAppointment.UseVisualStyleBackColor = False
        ' 
        ' pic_RightArrow
        ' 
        pic_RightArrow.BackColor = Color.Transparent
        pic_RightArrow.Image = CType(resources.GetObject("pic_RightArrow.Image"), Image)
        pic_RightArrow.Location = New Point(349, 362)
        pic_RightArrow.Name = "pic_RightArrow"
        pic_RightArrow.Size = New Size(29, 50)
        pic_RightArrow.SizeMode = PictureBoxSizeMode.Zoom
        pic_RightArrow.TabIndex = 35
        pic_RightArrow.TabStop = False
        ' 
        ' pic_LeftArrow
        ' 
        pic_LeftArrow.BackColor = Color.Transparent
        pic_LeftArrow.Image = CType(resources.GetObject("pic_LeftArrow.Image"), Image)
        pic_LeftArrow.Location = New Point(5, 362)
        pic_LeftArrow.Name = "pic_LeftArrow"
        pic_LeftArrow.Size = New Size(29, 50)
        pic_LeftArrow.SizeMode = PictureBoxSizeMode.Zoom
        pic_LeftArrow.TabIndex = 36
        pic_LeftArrow.TabStop = False
        ' 
        ' Timer1
        ' 
        ' 
        ' SpecialistPage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(384, 711)
        Controls.Add(pic_LeftArrow)
        Controls.Add(pic_RightArrow)
        Controls.Add(btn_BookAppointment)
        Controls.Add(pnl_Specialist)
        Controls.Add(pnl_Header)
        Controls.Add(pic_Exit)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "SpecialistPage"
        StartPosition = FormStartPosition.CenterScreen
        Text = "SpecialistPage"
        pnl_Header.ResumeLayout(False)
        CType(pic_Menu, ComponentModel.ISupportInitialize).EndInit()
        CType(pic_LogoHeader, ComponentModel.ISupportInitialize).EndInit()
        CType(pic_Exit, ComponentModel.ISupportInitialize).EndInit()
        CType(pic_RightArrow, ComponentModel.ISupportInitialize).EndInit()
        CType(pic_LeftArrow, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnl_Header As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents pic_Menu As PictureBox
    Friend WithEvents pic_LogoHeader As PictureBox
    Friend WithEvents pic_Exit As PictureBox
    Friend WithEvents pnl_Specialist As RoundedPanel
    Friend WithEvents btn_BookAppointment As CustomControls.RJControls.RoundedButton
    Friend WithEvents pic_RightArrow As PictureBox
    Friend WithEvents pic_LeftArrow As PictureBox
    Friend WithEvents Timer1 As Timer
End Class
