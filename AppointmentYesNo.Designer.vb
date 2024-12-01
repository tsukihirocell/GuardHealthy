<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Accept
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Accept))
        RoundedButton1 = New CustomControls.RJControls.RoundedButton()
        Label1 = New Label()
        RoundedPanel1 = New RoundedPanel()
        LinkLabel1 = New LinkLabel()
        RoundedButton4 = New CustomControls.RJControls.RoundedButton()
        RoundedButton2 = New CustomControls.RJControls.RoundedButton()
        Label4 = New Label()
        Label2 = New Label()
        Label10 = New Label()
        RoundedButton3 = New CustomControls.RJControls.RoundedButton()
        Label3 = New Label()
        Label17 = New Label()
        CirclePictureBox1 = New CirclePictureBox()
        Panel5 = New Panel()
        Button1 = New Button()
        Label20 = New Label()
        Panel1 = New Panel()
        RoundedPanel1.SuspendLayout()
        CType(CirclePictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' RoundedButton1
        ' 
        RoundedButton1.BackColor = SystemColors.ButtonHighlight
        RoundedButton1.BackgroundColor = SystemColors.ButtonHighlight
        RoundedButton1.BorderColor = Color.PaleVioletRed
        RoundedButton1.BorderRadius = 9
        RoundedButton1.BorderSize = 0
        RoundedButton1.FlatAppearance.BorderSize = 0
        RoundedButton1.FlatAppearance.MouseOverBackColor = Color.SteelBlue
        RoundedButton1.FlatStyle = FlatStyle.Flat
        RoundedButton1.ForeColor = Color.Black
        RoundedButton1.Image = CType(resources.GetObject("RoundedButton1.Image"), Image)
        RoundedButton1.Location = New Point(17, 99)
        RoundedButton1.Name = "RoundedButton1"
        RoundedButton1.Size = New Size(42, 41)
        RoundedButton1.TabIndex = 81
        RoundedButton1.TextColor = Color.Black
        RoundedButton1.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(110, 110)
        Label1.Name = "Label1"
        Label1.Size = New Size(145, 30)
        Label1.TabIndex = 95
        Label1.Text = "Appointment"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' RoundedPanel1
        ' 
        RoundedPanel1.BackColor = SystemColors.ControlLight
        RoundedPanel1.Controls.Add(LinkLabel1)
        RoundedPanel1.Controls.Add(RoundedButton4)
        RoundedPanel1.Controls.Add(RoundedButton2)
        RoundedPanel1.Controls.Add(Label4)
        RoundedPanel1.Controls.Add(Label2)
        RoundedPanel1.Controls.Add(Label10)
        RoundedPanel1.Controls.Add(RoundedButton3)
        RoundedPanel1.Controls.Add(Label3)
        RoundedPanel1.Controls.Add(Label17)
        RoundedPanel1.Controls.Add(CirclePictureBox1)
        RoundedPanel1.CornerRadius = 20
        RoundedPanel1.Location = New Point(17, 170)
        RoundedPanel1.Name = "RoundedPanel1"
        RoundedPanel1.Size = New Size(335, 158)
        RoundedPanel1.TabIndex = 96
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.ActiveLinkColor = Color.SteelBlue
        LinkLabel1.AutoSize = True
        LinkLabel1.BackColor = Color.Transparent
        LinkLabel1.DisabledLinkColor = Color.Transparent
        LinkLabel1.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LinkLabel1.ForeColor = SystemColors.Highlight
        LinkLabel1.LinkColor = SystemColors.Desktop
        LinkLabel1.Location = New Point(278, 95)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(35, 17)
        LinkLabel1.TabIndex = 100
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "View"
        ' 
        ' RoundedButton4
        ' 
        RoundedButton4.BackColor = SystemColors.ButtonHighlight
        RoundedButton4.BackgroundColor = SystemColors.ButtonHighlight
        RoundedButton4.BorderColor = Color.Black
        RoundedButton4.BorderRadius = 9
        RoundedButton4.BorderSize = 1
        RoundedButton4.FlatAppearance.BorderSize = 0
        RoundedButton4.FlatAppearance.MouseOverBackColor = Color.SteelBlue
        RoundedButton4.FlatStyle = FlatStyle.Flat
        RoundedButton4.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        RoundedButton4.ForeColor = Color.Black
        RoundedButton4.Image = CType(resources.GetObject("RoundedButton4.Image"), Image)
        RoundedButton4.ImageAlign = ContentAlignment.MiddleLeft
        RoundedButton4.Location = New Point(219, 4)
        RoundedButton4.Name = "RoundedButton4"
        RoundedButton4.Size = New Size(113, 23)
        RoundedButton4.TabIndex = 79
        RoundedButton4.Text = "In Patient"
        RoundedButton4.TextColor = Color.Black
        RoundedButton4.UseVisualStyleBackColor = False
        ' 
        ' RoundedButton2
        ' 
        RoundedButton2.BackColor = Color.White
        RoundedButton2.BackgroundColor = Color.White
        RoundedButton2.BackgroundImageLayout = ImageLayout.None
        RoundedButton2.BorderColor = Color.PaleVioletRed
        RoundedButton2.BorderRadius = 9
        RoundedButton2.BorderSize = 0
        RoundedButton2.FlatAppearance.BorderSize = 0
        RoundedButton2.FlatAppearance.MouseOverBackColor = Color.Red
        RoundedButton2.FlatStyle = FlatStyle.Flat
        RoundedButton2.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        RoundedButton2.ForeColor = Color.Black
        RoundedButton2.Location = New Point(168, 124)
        RoundedButton2.Name = "RoundedButton2"
        RoundedButton2.Size = New Size(87, 23)
        RoundedButton2.TabIndex = 75
        RoundedButton2.Text = "Decline"
        RoundedButton2.TextColor = Color.Black
        RoundedButton2.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(16, 96)
        Label4.Name = "Label4"
        Label4.Size = New Size(122, 15)
        Label4.TabIndex = 74
        Label4.Text = "Healthcare Provider:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(16, 79)
        Label2.Name = "Label2"
        Label2.Size = New Size(38, 15)
        Label2.TabIndex = 73
        Label2.Text = "Time:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(16, 61)
        Label10.Name = "Label10"
        Label10.Size = New Size(37, 15)
        Label10.TabIndex = 72
        Label10.Text = "Date:"
        ' 
        ' RoundedButton3
        ' 
        RoundedButton3.BackColor = Color.White
        RoundedButton3.BackgroundColor = Color.White
        RoundedButton3.BackgroundImageLayout = ImageLayout.None
        RoundedButton3.BorderColor = Color.PaleVioletRed
        RoundedButton3.BorderRadius = 9
        RoundedButton3.BorderSize = 0
        RoundedButton3.FlatAppearance.BorderSize = 0
        RoundedButton3.FlatAppearance.MouseOverBackColor = Color.SteelBlue
        RoundedButton3.FlatStyle = FlatStyle.Flat
        RoundedButton3.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        RoundedButton3.ForeColor = Color.Black
        RoundedButton3.Location = New Point(74, 123)
        RoundedButton3.Name = "RoundedButton3"
        RoundedButton3.Size = New Size(87, 23)
        RoundedButton3.TabIndex = 24
        RoundedButton3.Text = "Accept"
        RoundedButton3.TextColor = Color.Black
        RoundedButton3.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(74, 27)
        Label3.Name = "Label3"
        Label3.Size = New Size(55, 17)
        Label3.TabIndex = 71
        Label3.Text = "23-1998"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.BackColor = Color.Transparent
        Label17.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label17.Location = New Point(73, 7)
        Label17.Name = "Label17"
        Label17.Size = New Size(79, 20)
        Label17.TabIndex = 70
        Label17.Text = "Reyes, Jm"
        ' 
        ' CirclePictureBox1
        ' 
        CirclePictureBox1.BackColor = SystemColors.ButtonHighlight
        CirclePictureBox1.Image = My.Resources.Resources.Profile
        CirclePictureBox1.Location = New Point(7, 5)
        CirclePictureBox1.Name = "CirclePictureBox1"
        CirclePictureBox1.Size = New Size(57, 40)
        CirclePictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        CirclePictureBox1.TabIndex = 18
        CirclePictureBox1.TabStop = False
        ' 
        ' Panel5
        ' 
        Panel5.BackgroundImage = CType(resources.GetObject("Panel5.BackgroundImage"), Image)
        Panel5.BackgroundImageLayout = ImageLayout.Stretch
        Panel5.Location = New Point(31, -13)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(142, 90)
        Panel5.TabIndex = 12
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.BackgroundImage = My.Resources.Resources.menu
        Button1.BackgroundImageLayout = ImageLayout.Zoom
        Button1.Location = New Point(3, 3)
        Button1.Name = "Button1"
        Button1.Size = New Size(45, 38)
        Button1.TabIndex = 106
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.BackColor = Color.Transparent
        Label20.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label20.ForeColor = Color.Black
        Label20.Location = New Point(6, 44)
        Label20.Name = "Label20"
        Label20.Size = New Size(42, 15)
        Label20.TabIndex = 104
        Label20.Text = "MENU"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Transparent
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Label20)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Panel5)
        Panel1.ForeColor = Color.Transparent
        Panel1.Location = New Point(-1, 1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(422, 68)
        Panel1.TabIndex = 112
        ' 
        ' Accept
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.bg_shits
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(384, 711)
        Controls.Add(Panel1)
        Controls.Add(RoundedPanel1)
        Controls.Add(Label1)
        Controls.Add(RoundedButton1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Accept"
        Text = "Accept"
        RoundedPanel1.ResumeLayout(False)
        RoundedPanel1.PerformLayout()
        CType(CirclePictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents RoundedButton1 As CustomControls.RJControls.RoundedButton
    Friend WithEvents Label1 As Label
    Friend WithEvents RoundedPanel1 As RoundedPanel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents RoundedButton3 As CustomControls.RJControls.RoundedButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents CirclePictureBox1 As CirclePictureBox
    Friend WithEvents RoundedButton2 As CustomControls.RJControls.RoundedButton
    Friend WithEvents RoundedButton4 As CustomControls.RJControls.RoundedButton
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label20 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
