<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class record
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(record))
        RoundedPanel1 = New RoundedPanel()
        RoundedButton3 = New CustomControls.RJControls.RoundedButton()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label17 = New Label()
        CirclePictureBox1 = New CirclePictureBox()
        RoundedButton8 = New CustomControls.RJControls.RoundedButton()
        RoundedPanel6 = New RoundedPanel()
        RoundedTextBox1 = New RoundedTextBox()
        Panel3 = New Panel()
        Label16 = New Label()
        Button1 = New Button()
        Panel1 = New Panel()
        RoundedPanel1.SuspendLayout()
        CType(CirclePictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        RoundedPanel6.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' RoundedPanel1
        ' 
        RoundedPanel1.BackColor = SystemColors.ControlLight
        RoundedPanel1.Controls.Add(RoundedButton3)
        RoundedPanel1.Controls.Add(Label5)
        RoundedPanel1.Controls.Add(Label4)
        RoundedPanel1.Controls.Add(Label3)
        RoundedPanel1.Controls.Add(Label17)
        RoundedPanel1.Controls.Add(CirclePictureBox1)
        RoundedPanel1.CornerRadius = 20
        RoundedPanel1.Location = New Point(35, 141)
        RoundedPanel1.Name = "RoundedPanel1"
        RoundedPanel1.Size = New Size(312, 91)
        RoundedPanel1.TabIndex = 17
        ' 
        ' RoundedButton3
        ' 
        RoundedButton3.BackColor = SystemColors.ControlDark
        RoundedButton3.BackgroundColor = SystemColors.ControlDark
        RoundedButton3.BorderColor = Color.PaleVioletRed
        RoundedButton3.BorderRadius = 9
        RoundedButton3.BorderSize = 0
        RoundedButton3.FlatAppearance.BorderSize = 0
        RoundedButton3.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
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
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI", 9.75F)
        Label5.Location = New Point(144, 59)
        Label5.Name = "Label5"
        Label5.Size = New Size(58, 17)
        Label5.TabIndex = 73
        Label5.Text = "Inpatient"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI", 9.75F)
        Label4.Location = New Point(93, 59)
        Label4.Name = "Label4"
        Label4.Size = New Size(46, 17)
        Label4.TabIndex = 72
        Label4.Text = "Status:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 9.75F)
        Label3.Location = New Point(93, 42)
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
        Label17.Location = New Point(92, 19)
        Label17.Name = "Label17"
        Label17.Size = New Size(75, 20)
        Label17.TabIndex = 70
        Label17.Text = "Reyes, Jm"
        ' 
        ' CirclePictureBox1
        ' 
        CirclePictureBox1.BackColor = SystemColors.ButtonHighlight
        CirclePictureBox1.Image = My.Resources.Resources.Profile
        CirclePictureBox1.Location = New Point(11, 19)
        CirclePictureBox1.Name = "CirclePictureBox1"
        CirclePictureBox1.Size = New Size(70, 55)
        CirclePictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        CirclePictureBox1.TabIndex = 18
        CirclePictureBox1.TabStop = False
        ' 
        ' RoundedButton8
        ' 
        RoundedButton8.BackColor = Color.Transparent
        RoundedButton8.BackgroundColor = Color.Transparent
        RoundedButton8.BackgroundImageLayout = ImageLayout.None
        RoundedButton8.BorderColor = Color.Transparent
        RoundedButton8.BorderRadius = 9
        RoundedButton8.BorderSize = 1
        RoundedButton8.FlatAppearance.BorderSize = 0
        RoundedButton8.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(0), CByte(0), CByte(0), CByte(0))
        RoundedButton8.FlatStyle = FlatStyle.Flat
        RoundedButton8.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        RoundedButton8.ForeColor = Color.Black
        RoundedButton8.Image = CType(resources.GetObject("RoundedButton8.Image"), Image)
        RoundedButton8.Location = New Point(275, 11)
        RoundedButton8.Name = "RoundedButton8"
        RoundedButton8.Size = New Size(42, 23)
        RoundedButton8.TabIndex = 79
        RoundedButton8.TextColor = Color.Black
        RoundedButton8.UseVisualStyleBackColor = False
        ' 
        ' RoundedPanel6
        ' 
        RoundedPanel6.BackColor = SystemColors.ControlLight
        RoundedPanel6.Controls.Add(RoundedButton8)
        RoundedPanel6.Controls.Add(RoundedTextBox1)
        RoundedPanel6.CornerRadius = 20
        RoundedPanel6.Location = New Point(27, 84)
        RoundedPanel6.Name = "RoundedPanel6"
        RoundedPanel6.Size = New Size(331, 48)
        RoundedPanel6.TabIndex = 97
        ' 
        ' RoundedTextBox1
        ' 
        RoundedTextBox1.BackColor = SystemColors.ControlLight
        RoundedTextBox1.BorderStyle = BorderStyle.None
        RoundedTextBox1.Location = New Point(6, 15)
        RoundedTextBox1.Name = "RoundedTextBox1"
        RoundedTextBox1.PlaceholderText = "     Search"
        RoundedTextBox1.Size = New Size(317, 16)
        RoundedTextBox1.TabIndex = 93
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Transparent
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(Label16)
        Panel3.Controls.Add(Button1)
        Panel3.Controls.Add(Panel1)
        Panel3.ForeColor = Color.Transparent
        Panel3.Location = New Point(1, 2)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(422, 68)
        Panel3.TabIndex = 110
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.BackColor = Color.Transparent
        Label16.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label16.ForeColor = Color.Black
        Label16.Location = New Point(6, 44)
        Label16.Name = "Label16"
        Label16.Size = New Size(42, 15)
        Label16.TabIndex = 104
        Label16.Text = "MENU"
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
        ' Panel1
        ' 
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Location = New Point(31, -13)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(142, 90)
        Panel1.TabIndex = 12
        ' 
        ' record
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(400, 750)
        Controls.Add(Panel3)
        Controls.Add(RoundedPanel6)
        Controls.Add(RoundedPanel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "record"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form2"
        RoundedPanel1.ResumeLayout(False)
        RoundedPanel1.PerformLayout()
        CType(CirclePictureBox1, ComponentModel.ISupportInitialize).EndInit()
        RoundedPanel6.ResumeLayout(False)
        RoundedPanel6.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents RoundedPanel1 As RoundedPanel
    Friend WithEvents CirclePictureBox1 As CirclePictureBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents RoundedButton3 As CustomControls.RJControls.RoundedButton
    Friend WithEvents RoundedButton8 As CustomControls.RJControls.RoundedButton
    Friend WithEvents RoundedPanel6 As RoundedPanel
    Friend WithEvents RoundedTextBox1 As RoundedTextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label16 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
End Class
