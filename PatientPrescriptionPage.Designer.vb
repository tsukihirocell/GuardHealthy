<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PatientPrescriptionPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PatientPrescriptionPage))
        pnl_Prescription = New RoundedPanel()
        RoundedPanel2 = New RoundedPanel()
        btn_MarkAsDone = New Button()
        pic_Dosage = New PictureBox()
        lbl_Timer = New Label()
        RoundedPanel4 = New RoundedPanel()
        lbl_HighPrio = New Label()
        Label1 = New Label()
        pic_Clock = New PictureBox()
        lbl_DrName = New Label()
        RoundedPanel3 = New RoundedPanel()
        lbl_ClockTimer = New Label()
        lbl_Dosage = New Label()
        pnl_Header = New Panel()
        Label3 = New Label()
        pic_Menu = New PictureBox()
        pic_LogoHeader = New PictureBox()
        pic_Exit = New PictureBox()
        pnl_Prescription.SuspendLayout()
        RoundedPanel2.SuspendLayout()
        CType(pic_Dosage, ComponentModel.ISupportInitialize).BeginInit()
        CType(pic_Clock, ComponentModel.ISupportInitialize).BeginInit()
        pnl_Header.SuspendLayout()
        CType(pic_Menu, ComponentModel.ISupportInitialize).BeginInit()
        CType(pic_LogoHeader, ComponentModel.ISupportInitialize).BeginInit()
        CType(pic_Exit, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnl_Prescription
        ' 
        pnl_Prescription.BackColor = SystemColors.ButtonFace
        pnl_Prescription.Controls.Add(RoundedPanel2)
        pnl_Prescription.CornerRadius = 20
        pnl_Prescription.Location = New Point(12, 157)
        pnl_Prescription.Name = "pnl_Prescription"
        pnl_Prescription.Size = New Size(360, 543)
        pnl_Prescription.TabIndex = 63
        ' 
        ' RoundedPanel2
        ' 
        RoundedPanel2.BackColor = SystemColors.ButtonHighlight
        RoundedPanel2.Controls.Add(btn_MarkAsDone)
        RoundedPanel2.Controls.Add(pic_Dosage)
        RoundedPanel2.Controls.Add(lbl_Timer)
        RoundedPanel2.Controls.Add(RoundedPanel4)
        RoundedPanel2.Controls.Add(lbl_HighPrio)
        RoundedPanel2.Controls.Add(Label1)
        RoundedPanel2.Controls.Add(pic_Clock)
        RoundedPanel2.Controls.Add(lbl_DrName)
        RoundedPanel2.Controls.Add(RoundedPanel3)
        RoundedPanel2.Controls.Add(lbl_ClockTimer)
        RoundedPanel2.Controls.Add(lbl_Dosage)
        RoundedPanel2.CornerRadius = 20
        RoundedPanel2.Location = New Point(10, 49)
        RoundedPanel2.Name = "RoundedPanel2"
        RoundedPanel2.Size = New Size(337, 128)
        RoundedPanel2.TabIndex = 11
        ' 
        ' btn_MarkAsDone
        ' 
        btn_MarkAsDone.Location = New Point(205, 10)
        btn_MarkAsDone.Name = "btn_MarkAsDone"
        btn_MarkAsDone.Size = New Size(117, 21)
        btn_MarkAsDone.TabIndex = 17
        btn_MarkAsDone.Text = "Mark as done"
        btn_MarkAsDone.UseVisualStyleBackColor = True
        ' 
        ' pic_Dosage
        ' 
        pic_Dosage.Image = CType(resources.GetObject("pic_Dosage.Image"), Image)
        pic_Dosage.Location = New Point(204, 95)
        pic_Dosage.Name = "pic_Dosage"
        pic_Dosage.Size = New Size(16, 17)
        pic_Dosage.SizeMode = PictureBoxSizeMode.Zoom
        pic_Dosage.TabIndex = 16
        pic_Dosage.TabStop = False
        ' 
        ' lbl_Timer
        ' 
        lbl_Timer.AutoSize = True
        lbl_Timer.BackColor = Color.MediumSlateBlue
        lbl_Timer.ForeColor = SystemColors.ButtonHighlight
        lbl_Timer.Location = New Point(148, 64)
        lbl_Timer.Name = "lbl_Timer"
        lbl_Timer.Size = New Size(79, 15)
        lbl_Timer.TabIndex = 15
        lbl_Timer.Text = "Every 8 Hours"
        ' 
        ' RoundedPanel4
        ' 
        RoundedPanel4.BackColor = Color.MediumSlateBlue
        RoundedPanel4.CornerRadius = 20
        RoundedPanel4.Location = New Point(132, 61)
        RoundedPanel4.Name = "RoundedPanel4"
        RoundedPanel4.Size = New Size(112, 22)
        RoundedPanel4.TabIndex = 14
        ' 
        ' lbl_HighPrio
        ' 
        lbl_HighPrio.AutoSize = True
        lbl_HighPrio.BackColor = Color.MediumSlateBlue
        lbl_HighPrio.ForeColor = SystemColors.ButtonHighlight
        lbl_HighPrio.Location = New Point(28, 64)
        lbl_HighPrio.Name = "lbl_HighPrio"
        lbl_HighPrio.Size = New Size(74, 15)
        lbl_HighPrio.TabIndex = 13
        lbl_HighPrio.Text = "High Priority"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(5, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(111, 25)
        Label1.TabIndex = 1
        Label1.Text = "Amoxicillin"
        ' 
        ' pic_Clock
        ' 
        pic_Clock.Image = CType(resources.GetObject("pic_Clock.Image"), Image)
        pic_Clock.Location = New Point(134, 95)
        pic_Clock.Name = "pic_Clock"
        pic_Clock.Size = New Size(16, 17)
        pic_Clock.SizeMode = PictureBoxSizeMode.Zoom
        pic_Clock.TabIndex = 13
        pic_Clock.TabStop = False
        ' 
        ' lbl_DrName
        ' 
        lbl_DrName.AutoSize = True
        lbl_DrName.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbl_DrName.Location = New Point(11, 94)
        lbl_DrName.Name = "lbl_DrName"
        lbl_DrName.Size = New Size(117, 17)
        lbl_DrName.TabIndex = 2
        lbl_DrName.Text = "Dr. Ronald Dycoco"
        ' 
        ' RoundedPanel3
        ' 
        RoundedPanel3.BackColor = Color.MediumSlateBlue
        RoundedPanel3.CornerRadius = 20
        RoundedPanel3.Location = New Point(9, 61)
        RoundedPanel3.Name = "RoundedPanel3"
        RoundedPanel3.Size = New Size(112, 22)
        RoundedPanel3.TabIndex = 12
        ' 
        ' lbl_ClockTimer
        ' 
        lbl_ClockTimer.AutoSize = True
        lbl_ClockTimer.Font = New Font("Segoe UI", 9.75F)
        lbl_ClockTimer.Location = New Point(151, 94)
        lbl_ClockTimer.Name = "lbl_ClockTimer"
        lbl_ClockTimer.Size = New Size(47, 17)
        lbl_ClockTimer.TabIndex = 3
        lbl_ClockTimer.Text = "7 Days"
        ' 
        ' lbl_Dosage
        ' 
        lbl_Dosage.AutoSize = True
        lbl_Dosage.Font = New Font("Segoe UI", 9.75F)
        lbl_Dosage.Location = New Point(223, 95)
        lbl_Dosage.Name = "lbl_Dosage"
        lbl_Dosage.Size = New Size(52, 17)
        lbl_Dosage.TabIndex = 12
        lbl_Dosage.Text = "500 mg"
        ' 
        ' pnl_Header
        ' 
        pnl_Header.BackColor = Color.Transparent
        pnl_Header.BorderStyle = BorderStyle.FixedSingle
        pnl_Header.Controls.Add(Label3)
        pnl_Header.Controls.Add(pic_Menu)
        pnl_Header.Controls.Add(pic_LogoHeader)
        pnl_Header.Location = New Point(-19, 10)
        pnl_Header.Name = "pnl_Header"
        pnl_Header.Size = New Size(422, 68)
        pnl_Header.TabIndex = 62
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
        pic_Exit.Location = New Point(27, 102)
        pic_Exit.Name = "pic_Exit"
        pic_Exit.Size = New Size(38, 36)
        pic_Exit.SizeMode = PictureBoxSizeMode.Zoom
        pic_Exit.TabIndex = 61
        pic_Exit.TabStop = False
        ' 
        ' PatientPrescriptionPage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(384, 711)
        Controls.Add(pnl_Prescription)
        Controls.Add(pnl_Header)
        Controls.Add(pic_Exit)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "PatientPrescriptionPage"
        StartPosition = FormStartPosition.CenterScreen
        Text = "PatientPrescriptionPage"
        pnl_Prescription.ResumeLayout(False)
        RoundedPanel2.ResumeLayout(False)
        RoundedPanel2.PerformLayout()
        CType(pic_Dosage, ComponentModel.ISupportInitialize).EndInit()
        CType(pic_Clock, ComponentModel.ISupportInitialize).EndInit()
        pnl_Header.ResumeLayout(False)
        CType(pic_Menu, ComponentModel.ISupportInitialize).EndInit()
        CType(pic_LogoHeader, ComponentModel.ISupportInitialize).EndInit()
        CType(pic_Exit, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnl_Prescription As RoundedPanel
    Friend WithEvents pnl_Header As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents pic_Menu As PictureBox
    Friend WithEvents pic_LogoHeader As PictureBox
    Friend WithEvents pic_Exit As PictureBox
    Friend WithEvents RoundedPanel2 As RoundedPanel
    Friend WithEvents lbl_HighPrio As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_DrName As Label
    Friend WithEvents RoundedPanel3 As RoundedPanel
    Friend WithEvents lbl_ClockTimer As Label
    Friend WithEvents lbl_Dosage As Label
    Friend WithEvents pic_Clock As PictureBox
    Friend WithEvents lbl_Timer As Label
    Friend WithEvents RoundedPanel4 As RoundedPanel
    Friend WithEvents btn_MarkAsDone As Button
    Friend WithEvents pic_Dosage As PictureBox
End Class
