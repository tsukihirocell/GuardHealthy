<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SymptomsPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SymptomsPage))
        pnl_Header = New Panel()
        Label3 = New Label()
        pic_Menu = New PictureBox()
        pic_LogoHeader = New PictureBox()
        pic_Exit = New PictureBox()
        pnl_Search = New RoundedPanel()
        txt_Search = New RoundedTextBox()
        pic_Search = New PictureBox()
        lbl_Specialist = New Label()
        lbl_Covid = New Label()
        RoundedPanel1 = New RoundedPanel()
        pic_SoreThroat = New PictureBox()
        lbl_SoreThroat = New Label()
        RoundedPanel3 = New RoundedPanel()
        pic_Fatigue = New PictureBox()
        lbl_Fatigue = New Label()
        RoundedPanel4 = New RoundedPanel()
        pic_Congestion = New PictureBox()
        lbl_Congestion = New Label()
        RoundedPanel5 = New RoundedPanel()
        pic_Cough = New PictureBox()
        lbl_Cough = New Label()
        RoundedPanel6 = New RoundedPanel()
        pic_Wheezing = New PictureBox()
        lbl_Wheezing = New Label()
        RoundedPanel7 = New RoundedPanel()
        pic_Sneezing = New PictureBox()
        lbl_Sneezing = New Label()
        RoundedPanel8 = New RoundedPanel()
        pic_Nausea = New PictureBox()
        lbl_Nausea = New Label()
        RoundedPanel9 = New RoundedPanel()
        pic_Swelling = New PictureBox()
        lbl_Swelling = New Label()
        lbl_Allergy = New Label()
        RoundedPanel10 = New RoundedPanel()
        pic_Headache = New PictureBox()
        lbl_Headache = New Label()
        RoundedPanel11 = New RoundedPanel()
        pic_Vomiting = New PictureBox()
        lbl_Vomiting = New Label()
        RoundedPanel12 = New RoundedPanel()
        pic_Bloating = New PictureBox()
        lbl_Bloating = New Label()
        RoundedPanel13 = New RoundedPanel()
        pic_Diarrhea = New PictureBox()
        lbl_Diarrhea = New Label()
        lbl_FoodPoisoning = New Label()
        btn_FindSpecialist = New CustomControls.RJControls.RoundedButton()
        pnl_Header.SuspendLayout()
        CType(pic_Menu, ComponentModel.ISupportInitialize).BeginInit()
        CType(pic_LogoHeader, ComponentModel.ISupportInitialize).BeginInit()
        CType(pic_Exit, ComponentModel.ISupportInitialize).BeginInit()
        pnl_Search.SuspendLayout()
        CType(pic_Search, ComponentModel.ISupportInitialize).BeginInit()
        RoundedPanel1.SuspendLayout()
        CType(pic_SoreThroat, ComponentModel.ISupportInitialize).BeginInit()
        RoundedPanel3.SuspendLayout()
        CType(pic_Fatigue, ComponentModel.ISupportInitialize).BeginInit()
        RoundedPanel4.SuspendLayout()
        CType(pic_Congestion, ComponentModel.ISupportInitialize).BeginInit()
        RoundedPanel5.SuspendLayout()
        CType(pic_Cough, ComponentModel.ISupportInitialize).BeginInit()
        RoundedPanel6.SuspendLayout()
        CType(pic_Wheezing, ComponentModel.ISupportInitialize).BeginInit()
        RoundedPanel7.SuspendLayout()
        CType(pic_Sneezing, ComponentModel.ISupportInitialize).BeginInit()
        RoundedPanel8.SuspendLayout()
        CType(pic_Nausea, ComponentModel.ISupportInitialize).BeginInit()
        RoundedPanel9.SuspendLayout()
        CType(pic_Swelling, ComponentModel.ISupportInitialize).BeginInit()
        RoundedPanel10.SuspendLayout()
        CType(pic_Headache, ComponentModel.ISupportInitialize).BeginInit()
        RoundedPanel11.SuspendLayout()
        CType(pic_Vomiting, ComponentModel.ISupportInitialize).BeginInit()
        RoundedPanel12.SuspendLayout()
        CType(pic_Bloating, ComponentModel.ISupportInitialize).BeginInit()
        RoundedPanel13.SuspendLayout()
        CType(pic_Diarrhea, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnl_Header
        ' 
        pnl_Header.BackColor = Color.Transparent
        pnl_Header.BorderStyle = BorderStyle.FixedSingle
        pnl_Header.Controls.Add(Label3)
        pnl_Header.Controls.Add(pic_Menu)
        pnl_Header.Controls.Add(pic_LogoHeader)
        pnl_Header.Location = New Point(-19, -6)
        pnl_Header.Name = "pnl_Header"
        pnl_Header.Size = New Size(422, 68)
        pnl_Header.TabIndex = 14
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
        pic_Exit.Location = New Point(27, 86)
        pic_Exit.Name = "pic_Exit"
        pic_Exit.Size = New Size(38, 36)
        pic_Exit.SizeMode = PictureBoxSizeMode.Zoom
        pic_Exit.TabIndex = 13
        pic_Exit.TabStop = False
        ' 
        ' pnl_Search
        ' 
        pnl_Search.Controls.Add(txt_Search)
        pnl_Search.Controls.Add(pic_Search)
        pnl_Search.CornerRadius = 20
        pnl_Search.Location = New Point(17, 170)
        pnl_Search.Name = "pnl_Search"
        pnl_Search.Size = New Size(348, 107)
        pnl_Search.TabIndex = 15
        ' 
        ' txt_Search
        ' 
        txt_Search.BackColor = SystemColors.ButtonFace
        txt_Search.Location = New Point(11, 6)
        txt_Search.Name = "txt_Search"
        txt_Search.PlaceholderText = "Search"
        txt_Search.Size = New Size(245, 23)
        txt_Search.TabIndex = 0
        ' 
        ' pic_Search
        ' 
        pic_Search.BackColor = SystemColors.ButtonFace
        pic_Search.Image = CType(resources.GetObject("pic_Search.Image"), Image)
        pic_Search.Location = New Point(315, 8)
        pic_Search.Name = "pic_Search"
        pic_Search.Size = New Size(20, 18)
        pic_Search.SizeMode = PictureBoxSizeMode.Zoom
        pic_Search.TabIndex = 1
        pic_Search.TabStop = False
        ' 
        ' lbl_Specialist
        ' 
        lbl_Specialist.AutoSize = True
        lbl_Specialist.BackColor = Color.Transparent
        lbl_Specialist.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_Specialist.Location = New Point(17, 146)
        lbl_Specialist.Name = "lbl_Specialist"
        lbl_Specialist.Size = New Size(159, 21)
        lbl_Specialist.TabIndex = 16
        lbl_Specialist.Text = "Find your Specialist"
        ' 
        ' lbl_Covid
        ' 
        lbl_Covid.AutoSize = True
        lbl_Covid.BackColor = Color.Transparent
        lbl_Covid.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_Covid.Location = New Point(20, 292)
        lbl_Covid.Name = "lbl_Covid"
        lbl_Covid.Size = New Size(147, 17)
        lbl_Covid.TabIndex = 17
        lbl_Covid.Text = "Symptoms of Covid 19"
        ' 
        ' RoundedPanel1
        ' 
        RoundedPanel1.Controls.Add(pic_SoreThroat)
        RoundedPanel1.Controls.Add(lbl_SoreThroat)
        RoundedPanel1.CornerRadius = 20
        RoundedPanel1.Location = New Point(20, 312)
        RoundedPanel1.Name = "RoundedPanel1"
        RoundedPanel1.Size = New Size(165, 29)
        RoundedPanel1.TabIndex = 18
        ' 
        ' pic_SoreThroat
        ' 
        pic_SoreThroat.Image = CType(resources.GetObject("pic_SoreThroat.Image"), Image)
        pic_SoreThroat.Location = New Point(123, 5)
        pic_SoreThroat.Name = "pic_SoreThroat"
        pic_SoreThroat.Size = New Size(28, 18)
        pic_SoreThroat.SizeMode = PictureBoxSizeMode.Zoom
        pic_SoreThroat.TabIndex = 19
        pic_SoreThroat.TabStop = False
        ' 
        ' lbl_SoreThroat
        ' 
        lbl_SoreThroat.AutoSize = True
        lbl_SoreThroat.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_SoreThroat.Location = New Point(18, 6)
        lbl_SoreThroat.Name = "lbl_SoreThroat"
        lbl_SoreThroat.Size = New Size(69, 15)
        lbl_SoreThroat.TabIndex = 0
        lbl_SoreThroat.Text = " Sore throat"
        ' 
        ' RoundedPanel3
        ' 
        RoundedPanel3.Controls.Add(pic_Fatigue)
        RoundedPanel3.Controls.Add(lbl_Fatigue)
        RoundedPanel3.CornerRadius = 20
        RoundedPanel3.Location = New Point(200, 312)
        RoundedPanel3.Name = "RoundedPanel3"
        RoundedPanel3.Size = New Size(165, 29)
        RoundedPanel3.TabIndex = 20
        ' 
        ' pic_Fatigue
        ' 
        pic_Fatigue.Image = CType(resources.GetObject("pic_Fatigue.Image"), Image)
        pic_Fatigue.Location = New Point(123, 5)
        pic_Fatigue.Name = "pic_Fatigue"
        pic_Fatigue.Size = New Size(28, 18)
        pic_Fatigue.SizeMode = PictureBoxSizeMode.Zoom
        pic_Fatigue.TabIndex = 19
        pic_Fatigue.TabStop = False
        ' 
        ' lbl_Fatigue
        ' 
        lbl_Fatigue.AutoSize = True
        lbl_Fatigue.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_Fatigue.Location = New Point(18, 6)
        lbl_Fatigue.Name = "lbl_Fatigue"
        lbl_Fatigue.Size = New Size(46, 15)
        lbl_Fatigue.TabIndex = 0
        lbl_Fatigue.Text = "Fatigue"
        ' 
        ' RoundedPanel4
        ' 
        RoundedPanel4.Controls.Add(pic_Congestion)
        RoundedPanel4.Controls.Add(lbl_Congestion)
        RoundedPanel4.CornerRadius = 20
        RoundedPanel4.Location = New Point(200, 347)
        RoundedPanel4.Name = "RoundedPanel4"
        RoundedPanel4.Size = New Size(165, 29)
        RoundedPanel4.TabIndex = 22
        ' 
        ' pic_Congestion
        ' 
        pic_Congestion.Image = CType(resources.GetObject("pic_Congestion.Image"), Image)
        pic_Congestion.Location = New Point(123, 5)
        pic_Congestion.Name = "pic_Congestion"
        pic_Congestion.Size = New Size(28, 18)
        pic_Congestion.SizeMode = PictureBoxSizeMode.Zoom
        pic_Congestion.TabIndex = 19
        pic_Congestion.TabStop = False
        ' 
        ' lbl_Congestion
        ' 
        lbl_Congestion.AutoSize = True
        lbl_Congestion.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_Congestion.Location = New Point(18, 6)
        lbl_Congestion.Name = "lbl_Congestion"
        lbl_Congestion.Size = New Size(67, 15)
        lbl_Congestion.TabIndex = 0
        lbl_Congestion.Text = "Congestion"
        ' 
        ' RoundedPanel5
        ' 
        RoundedPanel5.Controls.Add(pic_Cough)
        RoundedPanel5.Controls.Add(lbl_Cough)
        RoundedPanel5.CornerRadius = 20
        RoundedPanel5.Location = New Point(20, 347)
        RoundedPanel5.Name = "RoundedPanel5"
        RoundedPanel5.Size = New Size(165, 29)
        RoundedPanel5.TabIndex = 21
        ' 
        ' pic_Cough
        ' 
        pic_Cough.Image = CType(resources.GetObject("pic_Cough.Image"), Image)
        pic_Cough.Location = New Point(123, 5)
        pic_Cough.Name = "pic_Cough"
        pic_Cough.Size = New Size(28, 18)
        pic_Cough.SizeMode = PictureBoxSizeMode.Zoom
        pic_Cough.TabIndex = 19
        pic_Cough.TabStop = False
        ' 
        ' lbl_Cough
        ' 
        lbl_Cough.AutoSize = True
        lbl_Cough.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_Cough.Location = New Point(18, 6)
        lbl_Cough.Name = "lbl_Cough"
        lbl_Cough.Size = New Size(42, 15)
        lbl_Cough.TabIndex = 0
        lbl_Cough.Text = "Cough"
        ' 
        ' RoundedPanel6
        ' 
        RoundedPanel6.Controls.Add(pic_Wheezing)
        RoundedPanel6.Controls.Add(lbl_Wheezing)
        RoundedPanel6.CornerRadius = 20
        RoundedPanel6.Location = New Point(200, 447)
        RoundedPanel6.Name = "RoundedPanel6"
        RoundedPanel6.Size = New Size(165, 29)
        RoundedPanel6.TabIndex = 27
        ' 
        ' pic_Wheezing
        ' 
        pic_Wheezing.Image = CType(resources.GetObject("pic_Wheezing.Image"), Image)
        pic_Wheezing.Location = New Point(124, 5)
        pic_Wheezing.Name = "pic_Wheezing"
        pic_Wheezing.Size = New Size(28, 18)
        pic_Wheezing.SizeMode = PictureBoxSizeMode.Zoom
        pic_Wheezing.TabIndex = 19
        pic_Wheezing.TabStop = False
        ' 
        ' lbl_Wheezing
        ' 
        lbl_Wheezing.AutoSize = True
        lbl_Wheezing.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_Wheezing.Location = New Point(18, 6)
        lbl_Wheezing.Name = "lbl_Wheezing"
        lbl_Wheezing.Size = New Size(61, 15)
        lbl_Wheezing.TabIndex = 0
        lbl_Wheezing.Text = "Wheezing"
        ' 
        ' RoundedPanel7
        ' 
        RoundedPanel7.Controls.Add(pic_Sneezing)
        RoundedPanel7.Controls.Add(lbl_Sneezing)
        RoundedPanel7.CornerRadius = 20
        RoundedPanel7.Location = New Point(200, 412)
        RoundedPanel7.Name = "RoundedPanel7"
        RoundedPanel7.Size = New Size(165, 29)
        RoundedPanel7.TabIndex = 25
        ' 
        ' pic_Sneezing
        ' 
        pic_Sneezing.Image = CType(resources.GetObject("pic_Sneezing.Image"), Image)
        pic_Sneezing.Location = New Point(123, 5)
        pic_Sneezing.Name = "pic_Sneezing"
        pic_Sneezing.Size = New Size(28, 18)
        pic_Sneezing.SizeMode = PictureBoxSizeMode.Zoom
        pic_Sneezing.TabIndex = 19
        pic_Sneezing.TabStop = False
        ' 
        ' lbl_Sneezing
        ' 
        lbl_Sneezing.AutoSize = True
        lbl_Sneezing.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_Sneezing.Location = New Point(18, 6)
        lbl_Sneezing.Name = "lbl_Sneezing"
        lbl_Sneezing.Size = New Size(56, 15)
        lbl_Sneezing.TabIndex = 0
        lbl_Sneezing.Text = "Sneezing"
        ' 
        ' RoundedPanel8
        ' 
        RoundedPanel8.Controls.Add(pic_Nausea)
        RoundedPanel8.Controls.Add(lbl_Nausea)
        RoundedPanel8.CornerRadius = 20
        RoundedPanel8.Location = New Point(20, 447)
        RoundedPanel8.Name = "RoundedPanel8"
        RoundedPanel8.Size = New Size(165, 29)
        RoundedPanel8.TabIndex = 26
        ' 
        ' pic_Nausea
        ' 
        pic_Nausea.Image = CType(resources.GetObject("pic_Nausea.Image"), Image)
        pic_Nausea.Location = New Point(123, 5)
        pic_Nausea.Name = "pic_Nausea"
        pic_Nausea.Size = New Size(28, 18)
        pic_Nausea.SizeMode = PictureBoxSizeMode.Zoom
        pic_Nausea.TabIndex = 19
        pic_Nausea.TabStop = False
        ' 
        ' lbl_Nausea
        ' 
        lbl_Nausea.AutoSize = True
        lbl_Nausea.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_Nausea.Location = New Point(18, 6)
        lbl_Nausea.Name = "lbl_Nausea"
        lbl_Nausea.Size = New Size(46, 15)
        lbl_Nausea.TabIndex = 0
        lbl_Nausea.Text = "Nausea"
        ' 
        ' RoundedPanel9
        ' 
        RoundedPanel9.Controls.Add(pic_Swelling)
        RoundedPanel9.Controls.Add(lbl_Swelling)
        RoundedPanel9.CornerRadius = 20
        RoundedPanel9.Location = New Point(20, 412)
        RoundedPanel9.Name = "RoundedPanel9"
        RoundedPanel9.Size = New Size(165, 29)
        RoundedPanel9.TabIndex = 24
        ' 
        ' pic_Swelling
        ' 
        pic_Swelling.Image = CType(resources.GetObject("pic_Swelling.Image"), Image)
        pic_Swelling.Location = New Point(123, 5)
        pic_Swelling.Name = "pic_Swelling"
        pic_Swelling.Size = New Size(28, 18)
        pic_Swelling.SizeMode = PictureBoxSizeMode.Zoom
        pic_Swelling.TabIndex = 19
        pic_Swelling.TabStop = False
        ' 
        ' lbl_Swelling
        ' 
        lbl_Swelling.AutoSize = True
        lbl_Swelling.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_Swelling.Location = New Point(18, 6)
        lbl_Swelling.Name = "lbl_Swelling"
        lbl_Swelling.Size = New Size(52, 15)
        lbl_Swelling.TabIndex = 0
        lbl_Swelling.Text = "Swelling"
        ' 
        ' lbl_Allergy
        ' 
        lbl_Allergy.AutoSize = True
        lbl_Allergy.BackColor = Color.Transparent
        lbl_Allergy.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_Allergy.Location = New Point(20, 392)
        lbl_Allergy.Name = "lbl_Allergy"
        lbl_Allergy.Size = New Size(138, 17)
        lbl_Allergy.TabIndex = 23
        lbl_Allergy.Text = "Symptoms of Allergy"
        ' 
        ' RoundedPanel10
        ' 
        RoundedPanel10.Controls.Add(pic_Headache)
        RoundedPanel10.Controls.Add(lbl_Headache)
        RoundedPanel10.CornerRadius = 20
        RoundedPanel10.Location = New Point(200, 550)
        RoundedPanel10.Name = "RoundedPanel10"
        RoundedPanel10.Size = New Size(165, 29)
        RoundedPanel10.TabIndex = 32
        ' 
        ' pic_Headache
        ' 
        pic_Headache.Image = CType(resources.GetObject("pic_Headache.Image"), Image)
        pic_Headache.Location = New Point(123, 5)
        pic_Headache.Name = "pic_Headache"
        pic_Headache.Size = New Size(28, 18)
        pic_Headache.SizeMode = PictureBoxSizeMode.Zoom
        pic_Headache.TabIndex = 19
        pic_Headache.TabStop = False
        ' 
        ' lbl_Headache
        ' 
        lbl_Headache.AutoSize = True
        lbl_Headache.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_Headache.Location = New Point(18, 6)
        lbl_Headache.Name = "lbl_Headache"
        lbl_Headache.Size = New Size(60, 15)
        lbl_Headache.TabIndex = 0
        lbl_Headache.Text = "Headache"
        ' 
        ' RoundedPanel11
        ' 
        RoundedPanel11.Controls.Add(pic_Vomiting)
        RoundedPanel11.Controls.Add(lbl_Vomiting)
        RoundedPanel11.CornerRadius = 20
        RoundedPanel11.Location = New Point(200, 515)
        RoundedPanel11.Name = "RoundedPanel11"
        RoundedPanel11.Size = New Size(165, 29)
        RoundedPanel11.TabIndex = 30
        ' 
        ' pic_Vomiting
        ' 
        pic_Vomiting.Image = CType(resources.GetObject("pic_Vomiting.Image"), Image)
        pic_Vomiting.Location = New Point(123, 5)
        pic_Vomiting.Name = "pic_Vomiting"
        pic_Vomiting.Size = New Size(28, 18)
        pic_Vomiting.SizeMode = PictureBoxSizeMode.Zoom
        pic_Vomiting.TabIndex = 19
        pic_Vomiting.TabStop = False
        ' 
        ' lbl_Vomiting
        ' 
        lbl_Vomiting.AutoSize = True
        lbl_Vomiting.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_Vomiting.Location = New Point(18, 6)
        lbl_Vomiting.Name = "lbl_Vomiting"
        lbl_Vomiting.Size = New Size(56, 15)
        lbl_Vomiting.TabIndex = 0
        lbl_Vomiting.Text = "Vomiting"
        ' 
        ' RoundedPanel12
        ' 
        RoundedPanel12.Controls.Add(pic_Bloating)
        RoundedPanel12.Controls.Add(lbl_Bloating)
        RoundedPanel12.CornerRadius = 20
        RoundedPanel12.Location = New Point(20, 550)
        RoundedPanel12.Name = "RoundedPanel12"
        RoundedPanel12.Size = New Size(165, 29)
        RoundedPanel12.TabIndex = 31
        ' 
        ' pic_Bloating
        ' 
        pic_Bloating.Image = CType(resources.GetObject("pic_Bloating.Image"), Image)
        pic_Bloating.Location = New Point(123, 5)
        pic_Bloating.Name = "pic_Bloating"
        pic_Bloating.Size = New Size(28, 18)
        pic_Bloating.SizeMode = PictureBoxSizeMode.Zoom
        pic_Bloating.TabIndex = 19
        pic_Bloating.TabStop = False
        ' 
        ' lbl_Bloating
        ' 
        lbl_Bloating.AutoSize = True
        lbl_Bloating.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_Bloating.Location = New Point(18, 6)
        lbl_Bloating.Name = "lbl_Bloating"
        lbl_Bloating.Size = New Size(51, 15)
        lbl_Bloating.TabIndex = 0
        lbl_Bloating.Text = "Bloating"
        ' 
        ' RoundedPanel13
        ' 
        RoundedPanel13.Controls.Add(pic_Diarrhea)
        RoundedPanel13.Controls.Add(lbl_Diarrhea)
        RoundedPanel13.CornerRadius = 20
        RoundedPanel13.Location = New Point(20, 515)
        RoundedPanel13.Name = "RoundedPanel13"
        RoundedPanel13.Size = New Size(165, 29)
        RoundedPanel13.TabIndex = 29
        ' 
        ' pic_Diarrhea
        ' 
        pic_Diarrhea.Image = CType(resources.GetObject("pic_Diarrhea.Image"), Image)
        pic_Diarrhea.Location = New Point(123, 5)
        pic_Diarrhea.Name = "pic_Diarrhea"
        pic_Diarrhea.Size = New Size(28, 18)
        pic_Diarrhea.SizeMode = PictureBoxSizeMode.Zoom
        pic_Diarrhea.TabIndex = 19
        pic_Diarrhea.TabStop = False
        ' 
        ' lbl_Diarrhea
        ' 
        lbl_Diarrhea.AutoSize = True
        lbl_Diarrhea.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_Diarrhea.Location = New Point(18, 6)
        lbl_Diarrhea.Name = "lbl_Diarrhea"
        lbl_Diarrhea.Size = New Size(52, 15)
        lbl_Diarrhea.TabIndex = 0
        lbl_Diarrhea.Text = "Diarrhea"
        ' 
        ' lbl_FoodPoisoning
        ' 
        lbl_FoodPoisoning.AutoSize = True
        lbl_FoodPoisoning.BackColor = Color.Transparent
        lbl_FoodPoisoning.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_FoodPoisoning.Location = New Point(20, 495)
        lbl_FoodPoisoning.Name = "lbl_FoodPoisoning"
        lbl_FoodPoisoning.Size = New Size(191, 17)
        lbl_FoodPoisoning.TabIndex = 28
        lbl_FoodPoisoning.Text = "Symptoms of Food Poisoning"
        ' 
        ' btn_FindSpecialist
        ' 
        btn_FindSpecialist.BackColor = SystemColors.ButtonHighlight
        btn_FindSpecialist.BackgroundColor = SystemColors.ButtonHighlight
        btn_FindSpecialist.BorderColor = Color.PaleVioletRed
        btn_FindSpecialist.BorderRadius = 9
        btn_FindSpecialist.BorderSize = 0
        btn_FindSpecialist.Cursor = Cursors.Hand
        btn_FindSpecialist.FlatAppearance.BorderColor = SystemColors.ButtonHighlight
        btn_FindSpecialist.FlatAppearance.MouseDownBackColor = Color.White
        btn_FindSpecialist.FlatAppearance.MouseOverBackColor = Color.SteelBlue
        btn_FindSpecialist.FlatStyle = FlatStyle.Flat
        btn_FindSpecialist.Font = New Font("Segoe UI", 10F)
        btn_FindSpecialist.ForeColor = Color.Black
        btn_FindSpecialist.Location = New Point(17, 632)
        btn_FindSpecialist.Name = "btn_FindSpecialist"
        btn_FindSpecialist.Size = New Size(348, 52)
        btn_FindSpecialist.TabIndex = 33
        btn_FindSpecialist.Text = "Find Specialist"
        btn_FindSpecialist.TextColor = Color.Black
        btn_FindSpecialist.UseVisualStyleBackColor = False
        ' 
        ' SymptomsPage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(384, 711)
        Controls.Add(btn_FindSpecialist)
        Controls.Add(RoundedPanel10)
        Controls.Add(RoundedPanel11)
        Controls.Add(RoundedPanel12)
        Controls.Add(RoundedPanel13)
        Controls.Add(lbl_FoodPoisoning)
        Controls.Add(RoundedPanel6)
        Controls.Add(RoundedPanel4)
        Controls.Add(RoundedPanel7)
        Controls.Add(RoundedPanel3)
        Controls.Add(RoundedPanel8)
        Controls.Add(RoundedPanel5)
        Controls.Add(RoundedPanel9)
        Controls.Add(lbl_Allergy)
        Controls.Add(RoundedPanel1)
        Controls.Add(lbl_Covid)
        Controls.Add(lbl_Specialist)
        Controls.Add(pnl_Search)
        Controls.Add(pnl_Header)
        Controls.Add(pic_Exit)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "SymptomsPage"
        StartPosition = FormStartPosition.CenterScreen
        Text = "SymptomsPage"
        pnl_Header.ResumeLayout(False)
        CType(pic_Menu, ComponentModel.ISupportInitialize).EndInit()
        CType(pic_LogoHeader, ComponentModel.ISupportInitialize).EndInit()
        CType(pic_Exit, ComponentModel.ISupportInitialize).EndInit()
        pnl_Search.ResumeLayout(False)
        pnl_Search.PerformLayout()
        CType(pic_Search, ComponentModel.ISupportInitialize).EndInit()
        RoundedPanel1.ResumeLayout(False)
        RoundedPanel1.PerformLayout()
        CType(pic_SoreThroat, ComponentModel.ISupportInitialize).EndInit()
        RoundedPanel3.ResumeLayout(False)
        RoundedPanel3.PerformLayout()
        CType(pic_Fatigue, ComponentModel.ISupportInitialize).EndInit()
        RoundedPanel4.ResumeLayout(False)
        RoundedPanel4.PerformLayout()
        CType(pic_Congestion, ComponentModel.ISupportInitialize).EndInit()
        RoundedPanel5.ResumeLayout(False)
        RoundedPanel5.PerformLayout()
        CType(pic_Cough, ComponentModel.ISupportInitialize).EndInit()
        RoundedPanel6.ResumeLayout(False)
        RoundedPanel6.PerformLayout()
        CType(pic_Wheezing, ComponentModel.ISupportInitialize).EndInit()
        RoundedPanel7.ResumeLayout(False)
        RoundedPanel7.PerformLayout()
        CType(pic_Sneezing, ComponentModel.ISupportInitialize).EndInit()
        RoundedPanel8.ResumeLayout(False)
        RoundedPanel8.PerformLayout()
        CType(pic_Nausea, ComponentModel.ISupportInitialize).EndInit()
        RoundedPanel9.ResumeLayout(False)
        RoundedPanel9.PerformLayout()
        CType(pic_Swelling, ComponentModel.ISupportInitialize).EndInit()
        RoundedPanel10.ResumeLayout(False)
        RoundedPanel10.PerformLayout()
        CType(pic_Headache, ComponentModel.ISupportInitialize).EndInit()
        RoundedPanel11.ResumeLayout(False)
        RoundedPanel11.PerformLayout()
        CType(pic_Vomiting, ComponentModel.ISupportInitialize).EndInit()
        RoundedPanel12.ResumeLayout(False)
        RoundedPanel12.PerformLayout()
        CType(pic_Bloating, ComponentModel.ISupportInitialize).EndInit()
        RoundedPanel13.ResumeLayout(False)
        RoundedPanel13.PerformLayout()
        CType(pic_Diarrhea, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pnl_Header As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents pic_Menu As PictureBox
    Friend WithEvents pic_LogoHeader As PictureBox
    Friend WithEvents pic_Exit As PictureBox
    Friend WithEvents pnl_Search As RoundedPanel
    Friend WithEvents txt_Search As RoundedTextBox
    Friend WithEvents pic_Search As PictureBox
    Friend WithEvents lbl_Specialist As Label
    Friend WithEvents lbl_Covid As Label
    Friend WithEvents RoundedPanel1 As RoundedPanel
    Friend WithEvents pic_SoreThroat As PictureBox
    Friend WithEvents lbl_SoreThroat As Label
    Friend WithEvents RoundedPanel3 As RoundedPanel
    Friend WithEvents pic_Fatigue As PictureBox
    Friend WithEvents lbl_Fatigue As Label
    Friend WithEvents RoundedPanel4 As RoundedPanel
    Friend WithEvents pic_Congestion As PictureBox
    Friend WithEvents lbl_Congestion As Label
    Friend WithEvents RoundedPanel5 As RoundedPanel
    Friend WithEvents pic_Cough As PictureBox
    Friend WithEvents lbl_Cough As Label
    Friend WithEvents RoundedPanel6 As RoundedPanel
    Friend WithEvents pic_Wheezing As PictureBox
    Friend WithEvents lbl_Wheezing As Label
    Friend WithEvents RoundedPanel7 As RoundedPanel
    Friend WithEvents pic_Sneezing As PictureBox
    Friend WithEvents lbl_Sneezing As Label
    Friend WithEvents RoundedPanel8 As RoundedPanel
    Friend WithEvents pic_Nausea As PictureBox
    Friend WithEvents lbl_Nausea As Label
    Friend WithEvents RoundedPanel9 As RoundedPanel
    Friend WithEvents pic_Swelling As PictureBox
    Friend WithEvents lbl_Swelling As Label
    Friend WithEvents lbl_Allergy As Label
    Friend WithEvents RoundedPanel10 As RoundedPanel
    Friend WithEvents pic_Headache As PictureBox
    Friend WithEvents lbl_Headache As Label
    Friend WithEvents RoundedPanel11 As RoundedPanel
    Friend WithEvents pic_Vomiting As PictureBox
    Friend WithEvents lbl_Vomiting As Label
    Friend WithEvents RoundedPanel12 As RoundedPanel
    Friend WithEvents pic_Bloating As PictureBox
    Friend WithEvents lbl_Bloating As Label
    Friend WithEvents RoundedPanel13 As RoundedPanel
    Friend WithEvents pic_Diarrhea As PictureBox
    Friend WithEvents lbl_Diarrhea As Label
    Friend WithEvents lbl_FoodPoisoning As Label
    Friend WithEvents btn_FindSpecialist As CustomControls.RJControls.RoundedButton
End Class
