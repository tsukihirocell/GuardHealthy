<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class appointment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(appointment))
        Panel2 = New Panel()
        Label1 = New Label()
        pic_ = New PictureBox()
        PictureBox5 = New PictureBox()
        pic_Exit = New PictureBox()
        lbl_Appointment = New Label()
        btn_appoint1 = New CustomControls.RJControls.RoundedButton()
        DateTimePicker1 = New DateTimePicker()
        btn_appoint2 = New CustomControls.RJControls.RoundedButton()
        btn_appoint3 = New CustomControls.RJControls.RoundedButton()
        btn_appoint6 = New CustomControls.RJControls.RoundedButton()
        btn_appoint5 = New CustomControls.RJControls.RoundedButton()
        btn_appoint4 = New CustomControls.RJControls.RoundedButton()
        btn_appoint9 = New CustomControls.RJControls.RoundedButton()
        btn_appoint8 = New CustomControls.RJControls.RoundedButton()
        btn_appoint7 = New CustomControls.RJControls.RoundedButton()
        btn_appoint12 = New CustomControls.RJControls.RoundedButton()
        btn_appoint11 = New CustomControls.RJControls.RoundedButton()
        btn_appoint10 = New CustomControls.RJControls.RoundedButton()
        btn_appoint15 = New CustomControls.RJControls.RoundedButton()
        btn_appoint14 = New CustomControls.RJControls.RoundedButton()
        btn_appoint13 = New CustomControls.RJControls.RoundedButton()
        lbl_NoteBox = New Label()
        txt_NoteBox = New RoundedTextBox()
        btn_ConfirmApp = New CustomControls.RJControls.RoundedButton()
        Panel2.SuspendLayout()
        CType(pic_, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(pic_Exit, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Transparent
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(pic_)
        Panel2.Controls.Add(PictureBox5)
        Panel2.Location = New Point(0, 3)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(422, 68)
        Panel2.TabIndex = 19
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
        ' pic_
        ' 
        pic_.BackColor = Color.Transparent
        pic_.Cursor = Cursors.Hand
        pic_.Image = CType(resources.GetObject("pic_.Image"), Image)
        pic_.Location = New Point(24, 14)
        pic_.Name = "pic_"
        pic_.Size = New Size(40, 25)
        pic_.SizeMode = PictureBoxSizeMode.Zoom
        pic_.TabIndex = 3
        pic_.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackColor = Color.Transparent
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(48, -11)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(142, 90)
        PictureBox5.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox5.TabIndex = 2
        PictureBox5.TabStop = False
        ' 
        ' pic_Exit
        ' 
        pic_Exit.BackColor = Color.Transparent
        pic_Exit.Cursor = Cursors.Hand
        pic_Exit.Image = CType(resources.GetObject("pic_Exit.Image"), Image)
        pic_Exit.Location = New Point(28, 104)
        pic_Exit.Name = "pic_Exit"
        pic_Exit.Size = New Size(38, 36)
        pic_Exit.SizeMode = PictureBoxSizeMode.Zoom
        pic_Exit.TabIndex = 13
        pic_Exit.TabStop = False
        ' 
        ' lbl_Appointment
        ' 
        lbl_Appointment.AutoSize = True
        lbl_Appointment.BackColor = Color.Transparent
        lbl_Appointment.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_Appointment.Location = New Point(104, 158)
        lbl_Appointment.Name = "lbl_Appointment"
        lbl_Appointment.Size = New Size(166, 32)
        lbl_Appointment.TabIndex = 20
        lbl_Appointment.Text = "Appointment"
        ' 
        ' btn_appoint1
        ' 
        btn_appoint1.BackColor = SystemColors.ButtonHighlight
        btn_appoint1.BackgroundColor = SystemColors.ButtonHighlight
        btn_appoint1.BorderColor = Color.PaleVioletRed
        btn_appoint1.BorderRadius = 9
        btn_appoint1.BorderSize = 0
        btn_appoint1.Cursor = Cursors.Hand
        btn_appoint1.FlatAppearance.BorderColor = SystemColors.ButtonHighlight
        btn_appoint1.FlatAppearance.MouseDownBackColor = Color.White
        btn_appoint1.FlatAppearance.MouseOverBackColor = Color.SteelBlue
        btn_appoint1.FlatStyle = FlatStyle.Flat
        btn_appoint1.Font = New Font("Segoe UI", 10F)
        btn_appoint1.ForeColor = Color.Black
        btn_appoint1.Location = New Point(48, 253)
        btn_appoint1.Name = "btn_appoint1"
        btn_appoint1.Size = New Size(92, 35)
        btn_appoint1.TabIndex = 52
        btn_appoint1.Text = "9:00"
        btn_appoint1.TextColor = Color.Black
        btn_appoint1.UseVisualStyleBackColor = False
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(35, 209)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(313, 23)
        DateTimePicker1.TabIndex = 53
        ' 
        ' btn_appoint2
        ' 
        btn_appoint2.BackColor = SystemColors.ButtonHighlight
        btn_appoint2.BackgroundColor = SystemColors.ButtonHighlight
        btn_appoint2.BorderColor = Color.PaleVioletRed
        btn_appoint2.BorderRadius = 9
        btn_appoint2.BorderSize = 0
        btn_appoint2.Cursor = Cursors.Hand
        btn_appoint2.FlatAppearance.BorderColor = SystemColors.ButtonHighlight
        btn_appoint2.FlatAppearance.MouseDownBackColor = Color.White
        btn_appoint2.FlatAppearance.MouseOverBackColor = Color.SteelBlue
        btn_appoint2.FlatStyle = FlatStyle.Flat
        btn_appoint2.Font = New Font("Segoe UI", 10F)
        btn_appoint2.ForeColor = Color.Black
        btn_appoint2.Location = New Point(146, 253)
        btn_appoint2.Name = "btn_appoint2"
        btn_appoint2.Size = New Size(92, 35)
        btn_appoint2.TabIndex = 54
        btn_appoint2.Text = "9:30"
        btn_appoint2.TextColor = Color.Black
        btn_appoint2.UseVisualStyleBackColor = False
        ' 
        ' btn_appoint3
        ' 
        btn_appoint3.BackColor = SystemColors.ButtonHighlight
        btn_appoint3.BackgroundColor = SystemColors.ButtonHighlight
        btn_appoint3.BorderColor = Color.PaleVioletRed
        btn_appoint3.BorderRadius = 9
        btn_appoint3.BorderSize = 0
        btn_appoint3.Cursor = Cursors.Hand
        btn_appoint3.FlatAppearance.BorderColor = SystemColors.ButtonHighlight
        btn_appoint3.FlatAppearance.MouseDownBackColor = Color.White
        btn_appoint3.FlatAppearance.MouseOverBackColor = Color.SteelBlue
        btn_appoint3.FlatStyle = FlatStyle.Flat
        btn_appoint3.Font = New Font("Segoe UI", 10F)
        btn_appoint3.ForeColor = Color.Black
        btn_appoint3.Location = New Point(246, 253)
        btn_appoint3.Name = "btn_appoint3"
        btn_appoint3.Size = New Size(92, 35)
        btn_appoint3.TabIndex = 56
        btn_appoint3.Text = "10:00"
        btn_appoint3.TextColor = Color.Black
        btn_appoint3.UseVisualStyleBackColor = False
        ' 
        ' btn_appoint6
        ' 
        btn_appoint6.BackColor = SystemColors.ButtonHighlight
        btn_appoint6.BackgroundColor = SystemColors.ButtonHighlight
        btn_appoint6.BorderColor = Color.PaleVioletRed
        btn_appoint6.BorderRadius = 9
        btn_appoint6.BorderSize = 0
        btn_appoint6.Cursor = Cursors.Hand
        btn_appoint6.FlatAppearance.BorderColor = SystemColors.ButtonHighlight
        btn_appoint6.FlatAppearance.MouseDownBackColor = Color.White
        btn_appoint6.FlatAppearance.MouseOverBackColor = Color.SteelBlue
        btn_appoint6.FlatStyle = FlatStyle.Flat
        btn_appoint6.Font = New Font("Segoe UI", 10F)
        btn_appoint6.ForeColor = Color.Black
        btn_appoint6.Location = New Point(246, 294)
        btn_appoint6.Name = "btn_appoint6"
        btn_appoint6.Size = New Size(92, 35)
        btn_appoint6.TabIndex = 59
        btn_appoint6.Text = "13:30"
        btn_appoint6.TextColor = Color.Black
        btn_appoint6.UseVisualStyleBackColor = False
        ' 
        ' btn_appoint5
        ' 
        btn_appoint5.BackColor = SystemColors.ButtonHighlight
        btn_appoint5.BackgroundColor = SystemColors.ButtonHighlight
        btn_appoint5.BorderColor = Color.PaleVioletRed
        btn_appoint5.BorderRadius = 9
        btn_appoint5.BorderSize = 0
        btn_appoint5.Cursor = Cursors.Hand
        btn_appoint5.FlatAppearance.BorderColor = SystemColors.ButtonHighlight
        btn_appoint5.FlatAppearance.MouseDownBackColor = Color.White
        btn_appoint5.FlatAppearance.MouseOverBackColor = Color.SteelBlue
        btn_appoint5.FlatStyle = FlatStyle.Flat
        btn_appoint5.Font = New Font("Segoe UI", 10F)
        btn_appoint5.ForeColor = Color.Black
        btn_appoint5.Location = New Point(146, 294)
        btn_appoint5.Name = "btn_appoint5"
        btn_appoint5.Size = New Size(92, 35)
        btn_appoint5.TabIndex = 58
        btn_appoint5.Text = "13:00"
        btn_appoint5.TextColor = Color.Black
        btn_appoint5.UseVisualStyleBackColor = False
        ' 
        ' btn_appoint4
        ' 
        btn_appoint4.BackColor = SystemColors.ButtonHighlight
        btn_appoint4.BackgroundColor = SystemColors.ButtonHighlight
        btn_appoint4.BorderColor = Color.PaleVioletRed
        btn_appoint4.BorderRadius = 9
        btn_appoint4.BorderSize = 0
        btn_appoint4.Cursor = Cursors.Hand
        btn_appoint4.FlatAppearance.BorderColor = SystemColors.ButtonHighlight
        btn_appoint4.FlatAppearance.MouseDownBackColor = Color.White
        btn_appoint4.FlatAppearance.MouseOverBackColor = Color.SteelBlue
        btn_appoint4.FlatStyle = FlatStyle.Flat
        btn_appoint4.Font = New Font("Segoe UI", 10F)
        btn_appoint4.ForeColor = Color.Black
        btn_appoint4.Location = New Point(48, 294)
        btn_appoint4.Name = "btn_appoint4"
        btn_appoint4.Size = New Size(92, 35)
        btn_appoint4.TabIndex = 57
        btn_appoint4.Text = "10:30"
        btn_appoint4.TextColor = Color.Black
        btn_appoint4.UseVisualStyleBackColor = False
        ' 
        ' btn_appoint9
        ' 
        btn_appoint9.BackColor = SystemColors.ButtonHighlight
        btn_appoint9.BackgroundColor = SystemColors.ButtonHighlight
        btn_appoint9.BorderColor = Color.PaleVioletRed
        btn_appoint9.BorderRadius = 9
        btn_appoint9.BorderSize = 0
        btn_appoint9.Cursor = Cursors.Hand
        btn_appoint9.FlatAppearance.BorderColor = SystemColors.ButtonHighlight
        btn_appoint9.FlatAppearance.MouseDownBackColor = Color.White
        btn_appoint9.FlatAppearance.MouseOverBackColor = Color.SteelBlue
        btn_appoint9.FlatStyle = FlatStyle.Flat
        btn_appoint9.Font = New Font("Segoe UI", 10F)
        btn_appoint9.ForeColor = Color.Black
        btn_appoint9.Location = New Point(246, 335)
        btn_appoint9.Name = "btn_appoint9"
        btn_appoint9.Size = New Size(92, 35)
        btn_appoint9.TabIndex = 62
        btn_appoint9.Text = "15:00"
        btn_appoint9.TextColor = Color.Black
        btn_appoint9.UseVisualStyleBackColor = False
        ' 
        ' btn_appoint8
        ' 
        btn_appoint8.BackColor = SystemColors.ButtonHighlight
        btn_appoint8.BackgroundColor = SystemColors.ButtonHighlight
        btn_appoint8.BorderColor = Color.PaleVioletRed
        btn_appoint8.BorderRadius = 9
        btn_appoint8.BorderSize = 0
        btn_appoint8.Cursor = Cursors.Hand
        btn_appoint8.FlatAppearance.BorderColor = SystemColors.ButtonHighlight
        btn_appoint8.FlatAppearance.MouseDownBackColor = Color.White
        btn_appoint8.FlatAppearance.MouseOverBackColor = Color.SteelBlue
        btn_appoint8.FlatStyle = FlatStyle.Flat
        btn_appoint8.Font = New Font("Segoe UI", 10F)
        btn_appoint8.ForeColor = Color.Black
        btn_appoint8.Location = New Point(146, 335)
        btn_appoint8.Name = "btn_appoint8"
        btn_appoint8.Size = New Size(92, 35)
        btn_appoint8.TabIndex = 61
        btn_appoint8.Text = "14:30"
        btn_appoint8.TextColor = Color.Black
        btn_appoint8.UseVisualStyleBackColor = False
        ' 
        ' btn_appoint7
        ' 
        btn_appoint7.BackColor = SystemColors.ButtonHighlight
        btn_appoint7.BackgroundColor = SystemColors.ButtonHighlight
        btn_appoint7.BorderColor = Color.PaleVioletRed
        btn_appoint7.BorderRadius = 9
        btn_appoint7.BorderSize = 0
        btn_appoint7.Cursor = Cursors.Hand
        btn_appoint7.FlatAppearance.BorderColor = SystemColors.ButtonHighlight
        btn_appoint7.FlatAppearance.MouseDownBackColor = Color.White
        btn_appoint7.FlatAppearance.MouseOverBackColor = Color.SteelBlue
        btn_appoint7.FlatStyle = FlatStyle.Flat
        btn_appoint7.Font = New Font("Segoe UI", 10F)
        btn_appoint7.ForeColor = Color.Black
        btn_appoint7.Location = New Point(48, 335)
        btn_appoint7.Name = "btn_appoint7"
        btn_appoint7.Size = New Size(92, 35)
        btn_appoint7.TabIndex = 60
        btn_appoint7.Text = "14:00"
        btn_appoint7.TextColor = Color.Black
        btn_appoint7.UseVisualStyleBackColor = False
        ' 
        ' btn_appoint12
        ' 
        btn_appoint12.BackColor = SystemColors.ButtonHighlight
        btn_appoint12.BackgroundColor = SystemColors.ButtonHighlight
        btn_appoint12.BorderColor = Color.PaleVioletRed
        btn_appoint12.BorderRadius = 9
        btn_appoint12.BorderSize = 0
        btn_appoint12.Cursor = Cursors.Hand
        btn_appoint12.FlatAppearance.BorderColor = SystemColors.ButtonHighlight
        btn_appoint12.FlatAppearance.MouseDownBackColor = Color.White
        btn_appoint12.FlatAppearance.MouseOverBackColor = Color.SteelBlue
        btn_appoint12.FlatStyle = FlatStyle.Flat
        btn_appoint12.Font = New Font("Segoe UI", 10F)
        btn_appoint12.ForeColor = Color.Black
        btn_appoint12.Location = New Point(246, 376)
        btn_appoint12.Name = "btn_appoint12"
        btn_appoint12.Size = New Size(92, 35)
        btn_appoint12.TabIndex = 65
        btn_appoint12.Text = "16:30"
        btn_appoint12.TextColor = Color.Black
        btn_appoint12.UseVisualStyleBackColor = False
        ' 
        ' btn_appoint11
        ' 
        btn_appoint11.BackColor = SystemColors.ButtonHighlight
        btn_appoint11.BackgroundColor = SystemColors.ButtonHighlight
        btn_appoint11.BorderColor = Color.PaleVioletRed
        btn_appoint11.BorderRadius = 9
        btn_appoint11.BorderSize = 0
        btn_appoint11.Cursor = Cursors.Hand
        btn_appoint11.FlatAppearance.BorderColor = SystemColors.ButtonHighlight
        btn_appoint11.FlatAppearance.MouseDownBackColor = Color.White
        btn_appoint11.FlatAppearance.MouseOverBackColor = Color.SteelBlue
        btn_appoint11.FlatStyle = FlatStyle.Flat
        btn_appoint11.Font = New Font("Segoe UI", 10F)
        btn_appoint11.ForeColor = Color.Black
        btn_appoint11.Location = New Point(146, 376)
        btn_appoint11.Name = "btn_appoint11"
        btn_appoint11.Size = New Size(92, 35)
        btn_appoint11.TabIndex = 64
        btn_appoint11.Text = "16:00"
        btn_appoint11.TextColor = Color.Black
        btn_appoint11.UseVisualStyleBackColor = False
        ' 
        ' btn_appoint10
        ' 
        btn_appoint10.BackColor = SystemColors.ButtonHighlight
        btn_appoint10.BackgroundColor = SystemColors.ButtonHighlight
        btn_appoint10.BorderColor = Color.PaleVioletRed
        btn_appoint10.BorderRadius = 9
        btn_appoint10.BorderSize = 0
        btn_appoint10.Cursor = Cursors.Hand
        btn_appoint10.FlatAppearance.BorderColor = SystemColors.ButtonHighlight
        btn_appoint10.FlatAppearance.MouseDownBackColor = Color.White
        btn_appoint10.FlatAppearance.MouseOverBackColor = Color.SteelBlue
        btn_appoint10.FlatStyle = FlatStyle.Flat
        btn_appoint10.Font = New Font("Segoe UI", 10F)
        btn_appoint10.ForeColor = Color.Black
        btn_appoint10.Location = New Point(48, 376)
        btn_appoint10.Name = "btn_appoint10"
        btn_appoint10.Size = New Size(92, 35)
        btn_appoint10.TabIndex = 63
        btn_appoint10.Text = "15:30"
        btn_appoint10.TextColor = Color.Black
        btn_appoint10.UseVisualStyleBackColor = False
        ' 
        ' btn_appoint15
        ' 
        btn_appoint15.BackColor = SystemColors.ButtonHighlight
        btn_appoint15.BackgroundColor = SystemColors.ButtonHighlight
        btn_appoint15.BorderColor = Color.PaleVioletRed
        btn_appoint15.BorderRadius = 9
        btn_appoint15.BorderSize = 0
        btn_appoint15.Cursor = Cursors.Hand
        btn_appoint15.FlatAppearance.BorderColor = SystemColors.ButtonHighlight
        btn_appoint15.FlatAppearance.MouseDownBackColor = Color.White
        btn_appoint15.FlatAppearance.MouseOverBackColor = Color.SteelBlue
        btn_appoint15.FlatStyle = FlatStyle.Flat
        btn_appoint15.Font = New Font("Segoe UI", 10F)
        btn_appoint15.ForeColor = Color.Black
        btn_appoint15.Location = New Point(246, 417)
        btn_appoint15.Name = "btn_appoint15"
        btn_appoint15.Size = New Size(92, 35)
        btn_appoint15.TabIndex = 68
        btn_appoint15.Text = "18:00"
        btn_appoint15.TextColor = Color.Black
        btn_appoint15.UseVisualStyleBackColor = False
        ' 
        ' btn_appoint14
        ' 
        btn_appoint14.BackColor = SystemColors.ButtonHighlight
        btn_appoint14.BackgroundColor = SystemColors.ButtonHighlight
        btn_appoint14.BorderColor = Color.PaleVioletRed
        btn_appoint14.BorderRadius = 9
        btn_appoint14.BorderSize = 0
        btn_appoint14.Cursor = Cursors.Hand
        btn_appoint14.FlatAppearance.BorderColor = SystemColors.ButtonHighlight
        btn_appoint14.FlatAppearance.MouseDownBackColor = Color.White
        btn_appoint14.FlatAppearance.MouseOverBackColor = Color.SteelBlue
        btn_appoint14.FlatStyle = FlatStyle.Flat
        btn_appoint14.Font = New Font("Segoe UI", 10F)
        btn_appoint14.ForeColor = Color.Black
        btn_appoint14.Location = New Point(146, 417)
        btn_appoint14.Name = "btn_appoint14"
        btn_appoint14.Size = New Size(92, 35)
        btn_appoint14.TabIndex = 67
        btn_appoint14.Text = "17:30"
        btn_appoint14.TextColor = Color.Black
        btn_appoint14.UseVisualStyleBackColor = False
        ' 
        ' btn_appoint13
        ' 
        btn_appoint13.BackColor = SystemColors.ButtonHighlight
        btn_appoint13.BackgroundColor = SystemColors.ButtonHighlight
        btn_appoint13.BorderColor = Color.PaleVioletRed
        btn_appoint13.BorderRadius = 9
        btn_appoint13.BorderSize = 0
        btn_appoint13.Cursor = Cursors.Hand
        btn_appoint13.FlatAppearance.BorderColor = SystemColors.ButtonHighlight
        btn_appoint13.FlatAppearance.MouseDownBackColor = Color.White
        btn_appoint13.FlatAppearance.MouseOverBackColor = Color.SteelBlue
        btn_appoint13.FlatStyle = FlatStyle.Flat
        btn_appoint13.Font = New Font("Segoe UI", 10F)
        btn_appoint13.ForeColor = Color.Black
        btn_appoint13.Location = New Point(48, 417)
        btn_appoint13.Name = "btn_appoint13"
        btn_appoint13.Size = New Size(92, 35)
        btn_appoint13.TabIndex = 66
        btn_appoint13.Text = "17:00"
        btn_appoint13.TextColor = Color.Black
        btn_appoint13.UseVisualStyleBackColor = False
        ' 
        ' lbl_NoteBox
        ' 
        lbl_NoteBox.AutoSize = True
        lbl_NoteBox.BackColor = Color.Transparent
        lbl_NoteBox.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_NoteBox.Location = New Point(30, 472)
        lbl_NoteBox.Name = "lbl_NoteBox"
        lbl_NoteBox.Size = New Size(51, 21)
        lbl_NoteBox.TabIndex = 69
        lbl_NoteBox.Text = "Note:"
        ' 
        ' txt_NoteBox
        ' 
        txt_NoteBox.Location = New Point(30, 496)
        txt_NoteBox.Multiline = True
        txt_NoteBox.Name = "txt_NoteBox"
        txt_NoteBox.Size = New Size(315, 85)
        txt_NoteBox.TabIndex = 70
        ' 
        ' btn_ConfirmApp
        ' 
        btn_ConfirmApp.BackColor = SystemColors.ButtonHighlight
        btn_ConfirmApp.BackgroundColor = SystemColors.ButtonHighlight
        btn_ConfirmApp.BorderColor = Color.PaleVioletRed
        btn_ConfirmApp.BorderRadius = 9
        btn_ConfirmApp.BorderSize = 0
        btn_ConfirmApp.Cursor = Cursors.Hand
        btn_ConfirmApp.FlatAppearance.BorderColor = SystemColors.ButtonHighlight
        btn_ConfirmApp.FlatAppearance.MouseDownBackColor = Color.White
        btn_ConfirmApp.FlatAppearance.MouseOverBackColor = Color.SteelBlue
        btn_ConfirmApp.FlatStyle = FlatStyle.Flat
        btn_ConfirmApp.Font = New Font("Segoe UI", 10F)
        btn_ConfirmApp.ForeColor = Color.Black
        btn_ConfirmApp.Location = New Point(18, 629)
        btn_ConfirmApp.Name = "btn_ConfirmApp"
        btn_ConfirmApp.Size = New Size(345, 52)
        btn_ConfirmApp.TabIndex = 71
        btn_ConfirmApp.Text = "Confirm Appointment"
        btn_ConfirmApp.TextColor = Color.Black
        btn_ConfirmApp.UseVisualStyleBackColor = False
        ' 
        ' appointment
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(384, 711)
        Controls.Add(btn_ConfirmApp)
        Controls.Add(txt_NoteBox)
        Controls.Add(lbl_NoteBox)
        Controls.Add(btn_appoint15)
        Controls.Add(btn_appoint14)
        Controls.Add(btn_appoint13)
        Controls.Add(btn_appoint12)
        Controls.Add(btn_appoint11)
        Controls.Add(btn_appoint10)
        Controls.Add(btn_appoint9)
        Controls.Add(btn_appoint8)
        Controls.Add(btn_appoint7)
        Controls.Add(btn_appoint6)
        Controls.Add(btn_appoint5)
        Controls.Add(btn_appoint4)
        Controls.Add(btn_appoint3)
        Controls.Add(btn_appoint2)
        Controls.Add(DateTimePicker1)
        Controls.Add(btn_appoint1)
        Controls.Add(lbl_Appointment)
        Controls.Add(Panel2)
        Controls.Add(pic_Exit)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "appointment"
        StartPosition = FormStartPosition.CenterScreen
        Text = " "
        Panel2.ResumeLayout(False)
        CType(pic_, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(pic_Exit, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents pic_ As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents pic_Exit As PictureBox
    Friend WithEvents lbl_Appointment As Label
    Friend WithEvents btn_appoint1 As CustomControls.RJControls.RoundedButton
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents btn_appoint2 As CustomControls.RJControls.RoundedButton
    Friend WithEvents btn_appoint3 As CustomControls.RJControls.RoundedButton
    Friend WithEvents btn_appoint6 As CustomControls.RJControls.RoundedButton
    Friend WithEvents btn_appoint5 As CustomControls.RJControls.RoundedButton
    Friend WithEvents btn_appoint4 As CustomControls.RJControls.RoundedButton
    Friend WithEvents btn_appoint9 As CustomControls.RJControls.RoundedButton
    Friend WithEvents btn_appoint8 As CustomControls.RJControls.RoundedButton
    Friend WithEvents btn_appoint7 As CustomControls.RJControls.RoundedButton
    Friend WithEvents btn_appoint12 As CustomControls.RJControls.RoundedButton
    Friend WithEvents btn_appoint11 As CustomControls.RJControls.RoundedButton
    Friend WithEvents btn_appoint10 As CustomControls.RJControls.RoundedButton
    Friend WithEvents btn_appoint15 As CustomControls.RJControls.RoundedButton
    Friend WithEvents btn_appoint14 As CustomControls.RJControls.RoundedButton
    Friend WithEvents btn_appoint13 As CustomControls.RJControls.RoundedButton
    Friend WithEvents lbl_NoteBox As Label
    Friend WithEvents txt_NoteBox As RoundedTextBox
    Friend WithEvents btn_ConfirmApp As CustomControls.RJControls.RoundedButton
End Class
