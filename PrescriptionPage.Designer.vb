<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrescriptionPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PrescriptionPage))
        pnl_Header = New Panel()
        Label3 = New Label()
        pic_Menu = New PictureBox()
        pic_LogoHeader = New PictureBox()
        pnl_Tab = New RoundedPanel()
        lbl_HighPrio = New Label()
        RoundedPanel2 = New RoundedPanel()
        lbl_Timer = New Label()
        pic_Clock = New PictureBox()
        lbl_DrName = New Label()
        lbl_Medicine = New Label()
        lbl_Clock = New Label()
        btn_Edit = New CustomControls.RJControls.RoundedButton()
        pic_Exit = New PictureBox()
        pnl_Header.SuspendLayout()
        CType(pic_Menu, ComponentModel.ISupportInitialize).BeginInit()
        CType(pic_LogoHeader, ComponentModel.ISupportInitialize).BeginInit()
        pnl_Tab.SuspendLayout()
        CType(pic_Clock, ComponentModel.ISupportInitialize).BeginInit()
        CType(pic_Exit, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnl_Header
        ' 
        pnl_Header.BackColor = Color.Transparent
        pnl_Header.BorderStyle = BorderStyle.FixedSingle
        pnl_Header.Controls.Add(Label3)
        pnl_Header.Controls.Add(pic_Menu)
        pnl_Header.Controls.Add(pic_LogoHeader)
        pnl_Header.Location = New Point(-11, -3)
        pnl_Header.Name = "pnl_Header"
        pnl_Header.Size = New Size(422, 68)
        pnl_Header.TabIndex = 9
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
        ' pnl_Tab
        ' 
        pnl_Tab.Controls.Add(lbl_HighPrio)
        pnl_Tab.Controls.Add(RoundedPanel2)
        pnl_Tab.Controls.Add(lbl_Timer)
        pnl_Tab.Controls.Add(pic_Clock)
        pnl_Tab.Controls.Add(lbl_DrName)
        pnl_Tab.Controls.Add(lbl_Medicine)
        pnl_Tab.Controls.Add(lbl_Clock)
        pnl_Tab.Controls.Add(btn_Edit)
        pnl_Tab.CornerRadius = 20
        pnl_Tab.Location = New Point(18, 169)
        pnl_Tab.Name = "pnl_Tab"
        pnl_Tab.Size = New Size(364, 166)
        pnl_Tab.TabIndex = 10
        ' 
        ' lbl_HighPrio
        ' 
        lbl_HighPrio.AutoSize = True
        lbl_HighPrio.BackColor = Color.MediumSlateBlue
        lbl_HighPrio.ForeColor = SystemColors.ButtonHighlight
        lbl_HighPrio.Location = New Point(260, 18)
        lbl_HighPrio.Name = "lbl_HighPrio"
        lbl_HighPrio.Size = New Size(74, 15)
        lbl_HighPrio.TabIndex = 13
        lbl_HighPrio.Text = "High Priority"
        ' 
        ' RoundedPanel2
        ' 
        RoundedPanel2.BackColor = Color.MediumSlateBlue
        RoundedPanel2.CornerRadius = 20
        RoundedPanel2.Location = New Point(241, 15)
        RoundedPanel2.Name = "RoundedPanel2"
        RoundedPanel2.Size = New Size(112, 22)
        RoundedPanel2.TabIndex = 12
        ' 
        ' lbl_Timer
        ' 
        lbl_Timer.AutoSize = True
        lbl_Timer.Location = New Point(196, 83)
        lbl_Timer.Name = "lbl_Timer"
        lbl_Timer.Size = New Size(79, 15)
        lbl_Timer.TabIndex = 12
        lbl_Timer.Text = "Every 8 Hours"
        ' 
        ' pic_Clock
        ' 
        pic_Clock.Image = CType(resources.GetObject("pic_Clock.Image"), Image)
        pic_Clock.Location = New Point(133, 81)
        pic_Clock.Name = "pic_Clock"
        pic_Clock.Size = New Size(16, 17)
        pic_Clock.SizeMode = PictureBoxSizeMode.Zoom
        pic_Clock.TabIndex = 13
        pic_Clock.TabStop = False
        ' 
        ' lbl_DrName
        ' 
        lbl_DrName.AutoSize = True
        lbl_DrName.Location = New Point(16, 81)
        lbl_DrName.Name = "lbl_DrName"
        lbl_DrName.Size = New Size(105, 15)
        lbl_DrName.TabIndex = 2
        lbl_DrName.Text = "Dr. Ronald Dycoco"
        ' 
        ' lbl_Medicine
        ' 
        lbl_Medicine.AutoSize = True
        lbl_Medicine.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_Medicine.Location = New Point(13, 45)
        lbl_Medicine.Name = "lbl_Medicine"
        lbl_Medicine.Size = New Size(111, 25)
        lbl_Medicine.TabIndex = 1
        lbl_Medicine.Text = "Amoxicillin"
        ' 
        ' lbl_Clock
        ' 
        lbl_Clock.AutoSize = True
        lbl_Clock.Location = New Point(153, 82)
        lbl_Clock.Name = "lbl_Clock"
        lbl_Clock.Size = New Size(41, 15)
        lbl_Clock.TabIndex = 3
        lbl_Clock.Text = "7 Days"
        ' 
        ' btn_Edit
        ' 
        btn_Edit.BackColor = SystemColors.ButtonHighlight
        btn_Edit.BackgroundColor = SystemColors.ButtonHighlight
        btn_Edit.BorderColor = Color.PaleVioletRed
        btn_Edit.BorderRadius = 9
        btn_Edit.BorderSize = 0
        btn_Edit.FlatAppearance.BorderSize = 0
        btn_Edit.FlatAppearance.MouseOverBackColor = Color.SteelBlue
        btn_Edit.FlatStyle = FlatStyle.Flat
        btn_Edit.ForeColor = Color.Black
        btn_Edit.Location = New Point(9, 119)
        btn_Edit.Name = "btn_Edit"
        btn_Edit.Size = New Size(345, 40)
        btn_Edit.TabIndex = 0
        btn_Edit.Text = "EDIT"
        btn_Edit.TextColor = Color.Black
        btn_Edit.UseVisualStyleBackColor = False
        ' 
        ' pic_Exit
        ' 
        pic_Exit.BackColor = Color.Transparent
        pic_Exit.Cursor = Cursors.Hand
        pic_Exit.Image = CType(resources.GetObject("pic_Exit.Image"), Image)
        pic_Exit.Location = New Point(16, 96)
        pic_Exit.Name = "pic_Exit"
        pic_Exit.Size = New Size(38, 36)
        pic_Exit.SizeMode = PictureBoxSizeMode.Zoom
        pic_Exit.TabIndex = 11
        pic_Exit.TabStop = False
        ' 
        ' PrescriptionPage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(400, 750)
        Controls.Add(pic_Exit)
        Controls.Add(pnl_Tab)
        Controls.Add(pnl_Header)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "PrescriptionPage"
        StartPosition = FormStartPosition.CenterScreen
        Text = "PrescriptionPage"
        pnl_Header.ResumeLayout(False)
        CType(pic_Menu, ComponentModel.ISupportInitialize).EndInit()
        CType(pic_LogoHeader, ComponentModel.ISupportInitialize).EndInit()
        pnl_Tab.ResumeLayout(False)
        pnl_Tab.PerformLayout()
        CType(pic_Clock, ComponentModel.ISupportInitialize).EndInit()
        CType(pic_Exit, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnl_Header As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents pic_Menu As PictureBox
    Friend WithEvents pic_LogoHeader As PictureBox
    Friend WithEvents pnl_Tab As RoundedPanel
    Friend WithEvents btn_Edit As CustomControls.RJControls.RoundedButton
    Friend WithEvents pic_Exit As PictureBox
    Friend WithEvents lbl_Medicine As Label
    Friend WithEvents lbl_DrName As Label
    Friend WithEvents lbl_Clock As Label
    Friend WithEvents lbl_Timer As Label
    Friend WithEvents pic_Clock As PictureBox
    Friend WithEvents lbl_HighPrio As Label
    Friend WithEvents RoundedPanel2 As RoundedPanel
End Class
