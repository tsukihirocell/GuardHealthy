<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DoctorPage
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
        pic_Profile = New PictureBox()
        Panel1 = New Panel()
        rtb_Details = New RichTextBox()
        lbl_DrName = New Label()
        lbl_DrRole = New Label()
        CType(pic_Profile, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' pic_Profile
        ' 
        pic_Profile.Location = New Point(43, 64)
        pic_Profile.Name = "pic_Profile"
        pic_Profile.Size = New Size(202, 219)
        pic_Profile.TabIndex = 0
        pic_Profile.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(rtb_Details)
        Panel1.Location = New Point(12, 298)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(264, 100)
        Panel1.TabIndex = 1
        ' 
        ' rtb_Details
        ' 
        rtb_Details.Dock = DockStyle.Fill
        rtb_Details.Location = New Point(0, 0)
        rtb_Details.Name = "rtb_Details"
        rtb_Details.Size = New Size(264, 100)
        rtb_Details.TabIndex = 0
        rtb_Details.Text = ""
        ' 
        ' lbl_DrName
        ' 
        lbl_DrName.AutoSize = True
        lbl_DrName.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_DrName.Location = New Point(80, 19)
        lbl_DrName.Name = "lbl_DrName"
        lbl_DrName.Size = New Size(132, 21)
        lbl_DrName.TabIndex = 2
        lbl_DrName.Text = "Dr. Ronald Duck"
        ' 
        ' lbl_DrRole
        ' 
        lbl_DrRole.AutoSize = True
        lbl_DrRole.Location = New Point(111, 40)
        lbl_DrRole.Name = "lbl_DrRole"
        lbl_DrRole.Size = New Size(69, 15)
        lbl_DrRole.TabIndex = 3
        lbl_DrRole.Text = "Pediatrician"
        ' 
        ' DoctorPage
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(288, 416)
        Controls.Add(lbl_DrRole)
        Controls.Add(lbl_DrName)
        Controls.Add(Panel1)
        Controls.Add(pic_Profile)
        FormBorderStyle = FormBorderStyle.None
        Name = "DoctorPage"
        StartPosition = FormStartPosition.CenterScreen
        Text = "DoctorPage"
        CType(pic_Profile, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pic_Profile As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_DrName As Label
    Friend WithEvents rtb_Details As RichTextBox
    Friend WithEvents lbl_DrRole As Label
End Class
