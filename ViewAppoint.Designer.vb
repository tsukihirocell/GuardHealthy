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
        RoundedButton2 = New CustomControls.RJControls.RoundedButton()
        Label1 = New Label()
        RoundedPanel1 = New RoundedPanel()
        Label2 = New Label()
        PictureBox1 = New PictureBox()
        Label4 = New Label()
        Label10 = New Label()
        RoundedButton3 = New CustomControls.RJControls.RoundedButton()
        Label3 = New Label()
        Label17 = New Label()
        CirclePictureBox1 = New CirclePictureBox()
        Panel3 = New Panel()
        Label19 = New Label()
        Button1 = New Button()
        Panel4 = New Panel()
        RoundedPanel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(CirclePictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' RoundedButton2
        ' 
        RoundedButton2.BackColor = SystemColors.ButtonHighlight
        RoundedButton2.BackgroundColor = SystemColors.ButtonHighlight
        RoundedButton2.BorderColor = Color.PaleVioletRed
        RoundedButton2.BorderRadius = 9
        RoundedButton2.BorderSize = 0
        RoundedButton2.FlatAppearance.BorderSize = 0
        RoundedButton2.FlatAppearance.MouseOverBackColor = Color.SteelBlue
        RoundedButton2.FlatStyle = FlatStyle.Flat
        RoundedButton2.ForeColor = Color.Black
        RoundedButton2.Image = CType(resources.GetObject("RoundedButton2.Image"), Image)
        RoundedButton2.Location = New Point(20, 92)
        RoundedButton2.Name = "RoundedButton2"
        RoundedButton2.Size = New Size(42, 41)
        RoundedButton2.TabIndex = 92
        RoundedButton2.TextColor = Color.Black
        RoundedButton2.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(112, 123)
        Label1.Name = "Label1"
        Label1.Size = New Size(145, 30)
        Label1.TabIndex = 94
        Label1.Text = "Appointment"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' RoundedPanel1
        ' 
        RoundedPanel1.BackColor = SystemColors.ControlLight
        RoundedPanel1.Controls.Add(Label2)
        RoundedPanel1.Controls.Add(PictureBox1)
        RoundedPanel1.Controls.Add(Label4)
        RoundedPanel1.Controls.Add(Label10)
        RoundedPanel1.Controls.Add(RoundedButton3)
        RoundedPanel1.Controls.Add(Label3)
        RoundedPanel1.Controls.Add(Label17)
        RoundedPanel1.Controls.Add(CirclePictureBox1)
        RoundedPanel1.CornerRadius = 20
        RoundedPanel1.Location = New Point(20, 188)
        RoundedPanel1.Name = "RoundedPanel1"
        RoundedPanel1.Size = New Size(335, 132)
        RoundedPanel1.TabIndex = 95
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(41, 103)
        Label2.Name = "Label2"
        Label2.Size = New Size(105, 15)
        Label2.TabIndex = 100
        Label2.Text = "Dr. Ronald Dycoco"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(16, 100)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(21, 24)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 99
        PictureBox1.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(16, 76)
        Label4.Name = "Label4"
        Label4.Size = New Size(28, 15)
        Label4.TabIndex = 101
        Label4.Text = "9:00"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(16, 61)
        Label10.Name = "Label10"
        Label10.Size = New Size(126, 15)
        Label10.TabIndex = 72
        Label10.Text = "December 1, Monday"
        ' 
        ' RoundedButton3
        ' 
        RoundedButton3.BackColor = SystemColors.ControlDark
        RoundedButton3.BackgroundColor = SystemColors.ControlDark
        RoundedButton3.BorderColor = Color.PaleVioletRed
        RoundedButton3.BorderRadius = 9
        RoundedButton3.BorderSize = 0
        RoundedButton3.FlatAppearance.BorderSize = 0
        RoundedButton3.FlatAppearance.MouseOverBackColor = Color.SteelBlue
        RoundedButton3.FlatStyle = FlatStyle.Flat
        RoundedButton3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        RoundedButton3.ForeColor = Color.Black
        RoundedButton3.Location = New Point(228, 57)
        RoundedButton3.Name = "RoundedButton3"
        RoundedButton3.Size = New Size(62, 23)
        RoundedButton3.TabIndex = 24
        RoundedButton3.Text = "VIEW"
        RoundedButton3.TextColor = Color.Black
        RoundedButton3.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 9.75F)
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
        Label17.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label17.Location = New Point(73, 7)
        Label17.Name = "Label17"
        Label17.Size = New Size(75, 20)
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
        ' Panel3
        ' 
        Panel3.BackColor = Color.Transparent
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(Label19)
        Panel3.Controls.Add(Button1)
        Panel3.Controls.Add(Panel4)
        Panel3.ForeColor = Color.Transparent
        Panel3.Location = New Point(1, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(422, 68)
        Panel3.TabIndex = 111
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.BackColor = Color.Transparent
        Label19.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label19.ForeColor = Color.Black
        Label19.Location = New Point(6, 44)
        Label19.Name = "Label19"
        Label19.Size = New Size(42, 15)
        Label19.TabIndex = 104
        Label19.Text = "MENU"
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
        ' Panel4
        ' 
        Panel4.BackgroundImage = CType(resources.GetObject("Panel4.BackgroundImage"), Image)
        Panel4.BackgroundImageLayout = ImageLayout.Stretch
        Panel4.Location = New Point(31, -13)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(142, 90)
        Panel4.TabIndex = 12
        ' 
        ' appointment
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.bg_shits
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(384, 711)
        Controls.Add(Panel3)
        Controls.Add(RoundedPanel1)
        Controls.Add(Label1)
        Controls.Add(RoundedButton2)
        FormBorderStyle = FormBorderStyle.None
        Name = "appointment"
        Text = "appointment"
        RoundedPanel1.ResumeLayout(False)
        RoundedPanel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(CirclePictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents RoundedButton2 As CustomControls.RJControls.RoundedButton
    Friend WithEvents Label1 As Label
    Friend WithEvents RoundedPanel1 As RoundedPanel
    Friend WithEvents RoundedButton3 As CustomControls.RJControls.RoundedButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents CirclePictureBox1 As CirclePictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label19 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel4 As Panel
End Class
