<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsentPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConsentPage))
        pic_Logo = New PictureBox()
        rtb_ToS = New RichTextBox()
        btn_Understand = New CustomControls.RJControls.RoundedButton()
        lbl_Permission = New Label()
        CType(pic_Logo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pic_Logo
        ' 
        pic_Logo.BackColor = Color.Transparent
        pic_Logo.Image = CType(resources.GetObject("pic_Logo.Image"), Image)
        pic_Logo.Location = New Point(43, 127)
        pic_Logo.Name = "pic_Logo"
        pic_Logo.Size = New Size(289, 176)
        pic_Logo.SizeMode = PictureBoxSizeMode.Zoom
        pic_Logo.TabIndex = 1
        pic_Logo.TabStop = False
        ' 
        ' rtb_ToS
        ' 
        rtb_ToS.Location = New Point(27, 289)
        rtb_ToS.Name = "rtb_ToS"
        rtb_ToS.Size = New Size(329, 185)
        rtb_ToS.TabIndex = 2
        rtb_ToS.Text = resources.GetString("rtb_ToS.Text")
        ' 
        ' btn_Understand
        ' 
        btn_Understand.BackColor = SystemColors.ButtonHighlight
        btn_Understand.BackgroundColor = SystemColors.ButtonHighlight
        btn_Understand.BorderColor = Color.PaleVioletRed
        btn_Understand.BorderRadius = 9
        btn_Understand.BorderSize = 0
        btn_Understand.Cursor = Cursors.Hand
        btn_Understand.FlatAppearance.BorderColor = SystemColors.ButtonHighlight
        btn_Understand.FlatAppearance.MouseDownBackColor = Color.White
        btn_Understand.FlatAppearance.MouseOverBackColor = Color.SteelBlue
        btn_Understand.FlatStyle = FlatStyle.Flat
        btn_Understand.Font = New Font("Segoe UI", 10F)
        btn_Understand.ForeColor = Color.Black
        btn_Understand.Location = New Point(27, 516)
        btn_Understand.Name = "btn_Understand"
        btn_Understand.Size = New Size(331, 52)
        btn_Understand.TabIndex = 24
        btn_Understand.Text = "I understand"
        btn_Understand.TextColor = Color.Black
        btn_Understand.UseVisualStyleBackColor = False
        ' 
        ' lbl_Permission
        ' 
        lbl_Permission.AutoSize = True
        lbl_Permission.BackColor = Color.Transparent
        lbl_Permission.Location = New Point(71, 667)
        lbl_Permission.Name = "lbl_Permission"
        lbl_Permission.Size = New Size(240, 15)
        lbl_Permission.TabIndex = 25
        lbl_Permission.Text = "We need permission for the services you use"
        ' 
        ' ConsentPage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(384, 711)
        Controls.Add(lbl_Permission)
        Controls.Add(btn_Understand)
        Controls.Add(rtb_ToS)
        Controls.Add(pic_Logo)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "ConsentPage"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ConsentPage"
        CType(pic_Logo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pic_Logo As PictureBox
    Friend WithEvents rtb_ToS As RichTextBox
    Friend WithEvents btn_Understand As CustomControls.RJControls.RoundedButton
    Friend WithEvents lbl_Permission As Label
End Class
