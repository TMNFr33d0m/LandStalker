<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConactReport
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
        Me.components = New System.ComponentModel.Container()
        Me.Title = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AgentNameBox = New System.Windows.Forms.ComboBox()
        Me.AgentbankBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        'Me.DatacoreDataSet = New LandStalker.datacoreDataSet()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Georeferencebox = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SubjectName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Subdivision = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Lot = New System.Windows.Forms.NumericUpDown()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Block = New System.Windows.Forms.NumericUpDown()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Tract = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.City = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.State = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.County = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Abstract = New System.Windows.Forms.TextBox()
        Me.Survey = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Prospectbox = New System.Windows.Forms.ListBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.phonenobox = New System.Windows.Forms.TextBox()
        Me.phonenolabel = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.cntcrptlbl = New System.Windows.Forms.Label()
        Me.convorecorded = New System.Windows.Forms.CheckBox()
        Me.emailaddybox = New System.Windows.Forms.TextBox()
        Me.emailaddylabel = New System.Windows.Forms.Label()
        Me.corresdate = New System.Windows.Forms.DateTimePicker()
        Me.corresdatelabel = New System.Windows.Forms.Label()
        Me.phonecallrecorded = New System.Windows.Forms.CheckBox()
        Me.meetinglocbox = New System.Windows.Forms.TextBox()
        Me.meetinglocationlabel = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.quit = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.AgentbankBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatacoreDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.MaindataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocaldatastorageDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Block, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.Font = New System.Drawing.Font("Viner Hand ITC", 19.0!, System.Drawing.FontStyle.Underline)
        Me.Title.Location = New System.Drawing.Point(6, 9)
        Me.Title.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(199, 42)
        Me.Title.TabIndex = 0
        Me.Title.Text = "Contact Report"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poor Richard", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 23)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Agent's Name:"
        '
        'AgentNameBox
        '
        Me.AgentNameBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.AgentNameBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.AgentNameBox.DataSource = Me.AgentbankBindingSource
        Me.AgentNameBox.DisplayMember = "UserName"
        Me.AgentNameBox.FormattingEnabled = True
        Me.AgentNameBox.Location = New System.Drawing.Point(97, 21)
        Me.AgentNameBox.Name = "AgentNameBox"
        Me.AgentNameBox.Size = New System.Drawing.Size(180, 24)
        Me.AgentNameBox.TabIndex = 2
        '
        'AgentbankBindingSource
        '
        Me.AgentbankBindingSource.DataMember = "agentbank"
        Me.AgentbankBindingSource.DataSource = Me.DatacoreDataSet
        '
        'DatacoreDataSet
        '
        Me.DatacoreDataSet.DataSetName = "datacoreDataSet"
        Me.DatacoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GroupBox1.Controls.Add(Me.Georeferencebox)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.SubjectName)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.AgentNameBox)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GroupBox1.Font = New System.Drawing.Font("Poor Richard", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(13, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(715, 110)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "General Information:"
        '
        'Georeferencebox
        '
        Me.Georeferencebox.DataSource = Me.MaindataBindingSource
        Me.Georeferencebox.FormattingEnabled = True
        Me.Georeferencebox.Location = New System.Drawing.Point(310, 74)
        Me.Georeferencebox.Name = "Georeferencebox"
        Me.Georeferencebox.Size = New System.Drawing.Size(183, 24)
        Me.Georeferencebox.TabIndex = 10
        '
        'MaindataBindingSource
        '
        Me.MaindataBindingSource.DataMember = "maindata"
        Me.MaindataBindingSource.DataSource = Me.LocaldatastorageDataSet
        '
        'LocaldatastorageDataSet
        '
        Me.LocaldatastorageDataSet.DataSetName = "localdatastorageDataSet"
        Me.LocaldatastorageDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(221, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Georeference:"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(499, 47)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 23)
        Me.DateTimePicker2.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(397, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Date Of Contact:"
        '
        'SubjectName
        '
        Me.SubjectName.Location = New System.Drawing.Point(99, 50)
        Me.SubjectName.Name = "SubjectName"
        Me.SubjectName.Size = New System.Drawing.Size(177, 23)
        Me.SubjectName.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(2, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Subject's Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(418, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Today's Date:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(499, 18)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 23)
        Me.DateTimePicker1.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(2, 10)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(107, 14)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Prospect / Project Name:"
        '
        'Subdivision
        '
        Me.Subdivision.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Subdivision.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Subdivision.CausesValidation = False
        Me.Subdivision.FormattingEnabled = True
        Me.Subdivision.Location = New System.Drawing.Point(64, 30)
        Me.Subdivision.Name = "Subdivision"
        Me.Subdivision.Size = New System.Drawing.Size(291, 22)
        Me.Subdivision.TabIndex = 28
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(2, 30)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 14)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Subdivision:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(366, 10)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(23, 14)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "Lot:"
        '
        'Lot
        '
        Me.Lot.Location = New System.Drawing.Point(397, 10)
        Me.Lot.Name = "Lot"
        Me.Lot.Size = New System.Drawing.Size(44, 20)
        Me.Lot.TabIndex = 30
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(460, 10)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(33, 14)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "Block:"
        '
        'Block
        '
        Me.Block.Location = New System.Drawing.Point(503, 10)
        Me.Block.Name = "Block"
        Me.Block.Size = New System.Drawing.Size(46, 20)
        Me.Block.TabIndex = 31
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(574, 10)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(29, 14)
        Me.Label15.TabIndex = 29
        Me.Label15.Text = "Tract:"
        '
        'Tract
        '
        Me.Tract.Location = New System.Drawing.Point(615, 10)
        Me.Tract.Name = "Tract"
        Me.Tract.Size = New System.Drawing.Size(93, 20)
        Me.Tract.TabIndex = 33
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(365, 30)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(27, 14)
        Me.Label16.TabIndex = 32
        Me.Label16.Text = "City:"
        '
        'City
        '
        Me.City.FormattingEnabled = True
        Me.City.Location = New System.Drawing.Point(397, 30)
        Me.City.Name = "City"
        Me.City.Size = New System.Drawing.Size(162, 22)
        Me.City.TabIndex = 34
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(574, 31)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(30, 14)
        Me.Label17.TabIndex = 36
        Me.Label17.Text = "State:"
        '
        'State
        '
        Me.State.FormattingEnabled = True
        Me.State.Location = New System.Drawing.Point(615, 30)
        Me.State.Name = "State"
        Me.State.Size = New System.Drawing.Size(93, 22)
        Me.State.TabIndex = 35
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(19, 55)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(39, 14)
        Me.Label18.TabIndex = 39
        Me.Label18.Text = "County:"
        '
        'County
        '
        Me.County.FormattingEnabled = True
        Me.County.Location = New System.Drawing.Point(64, 55)
        Me.County.Name = "County"
        Me.County.Size = New System.Drawing.Size(147, 22)
        Me.County.TabIndex = 37
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(227, 58)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(43, 14)
        Me.Label19.TabIndex = 41
        Me.Label19.Text = "Abstract:"
        '
        'Abstract
        '
        Me.Abstract.Location = New System.Drawing.Point(277, 58)
        Me.Abstract.Name = "Abstract"
        Me.Abstract.Size = New System.Drawing.Size(115, 20)
        Me.Abstract.TabIndex = 38
        '
        'Survey
        '
        Me.Survey.Location = New System.Drawing.Point(447, 58)
        Me.Survey.Name = "Survey"
        Me.Survey.Size = New System.Drawing.Size(261, 20)
        Me.Survey.TabIndex = 40
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(404, 61)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(37, 14)
        Me.Label20.TabIndex = 42
        Me.Label20.Text = "Survey:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Prospectbox)
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Controls.Add(Me.Survey)
        Me.Panel1.Controls.Add(Me.Tract)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Abstract)
        Me.Panel1.Controls.Add(Me.Block)
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.County)
        Me.Panel1.Controls.Add(Me.Lot)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.State)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.City)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Subdivision)
        Me.Panel1.Location = New System.Drawing.Point(13, 167)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(715, 85)
        Me.Panel1.TabIndex = 43
        '
        'Prospectbox
        '
        Me.Prospectbox.FormattingEnabled = True
        Me.Prospectbox.ItemHeight = 14
        Me.Prospectbox.Location = New System.Drawing.Point(112, 10)
        Me.Prospectbox.Name = "Prospectbox"
        Me.Prospectbox.Size = New System.Drawing.Size(243, 18)
        Me.Prospectbox.TabIndex = 43
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.phonenobox)
        Me.Panel2.Controls.Add(Me.phonenolabel)
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Controls.Add(Me.cntcrptlbl)
        Me.Panel2.Controls.Add(Me.convorecorded)
        Me.Panel2.Controls.Add(Me.emailaddybox)
        Me.Panel2.Controls.Add(Me.emailaddylabel)
        Me.Panel2.Controls.Add(Me.corresdate)
        Me.Panel2.Controls.Add(Me.corresdatelabel)
        Me.Panel2.Controls.Add(Me.phonecallrecorded)
        Me.Panel2.Controls.Add(Me.meetinglocbox)
        Me.Panel2.Controls.Add(Me.meetinglocationlabel)
        Me.Panel2.Controls.Add(Me.ComboBox2)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Location = New System.Drawing.Point(12, 256)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(715, 156)
        Me.Panel2.TabIndex = 44
        '
        'phonenobox
        '
        Me.phonenobox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.phonenobox.Location = New System.Drawing.Point(437, 7)
        Me.phonenobox.Name = "phonenobox"
        Me.phonenobox.Size = New System.Drawing.Size(111, 20)
        Me.phonenobox.TabIndex = 5
        Me.phonenobox.Visible = False
        '
        'phonenolabel
        '
        Me.phonenolabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.phonenolabel.AutoSize = True
        Me.phonenolabel.Location = New System.Drawing.Point(308, 10)
        Me.phonenolabel.Name = "phonenolabel"
        Me.phonenolabel.Size = New System.Drawing.Size(123, 14)
        Me.phonenolabel.TabIndex = 4
        Me.phonenolabel.Text = "From What Phone Number?:"
        Me.phonenolabel.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(82, 56)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(614, 93)
        Me.TextBox1.TabIndex = 13
        '
        'cntcrptlbl
        '
        Me.cntcrptlbl.AutoSize = True
        Me.cntcrptlbl.Location = New System.Drawing.Point(3, 49)
        Me.cntcrptlbl.Name = "cntcrptlbl"
        Me.cntcrptlbl.Size = New System.Drawing.Size(70, 14)
        Me.cntcrptlbl.TabIndex = 12
        Me.cntcrptlbl.Text = "Contact Report:"
        '
        'convorecorded
        '
        Me.convorecorded.AutoSize = True
        Me.convorecorded.Location = New System.Drawing.Point(543, 32)
        Me.convorecorded.Name = "convorecorded"
        Me.convorecorded.Size = New System.Drawing.Size(155, 18)
        Me.convorecorded.TabIndex = 11
        Me.convorecorded.Text = "This Conversation was Recorded"
        Me.convorecorded.UseVisualStyleBackColor = True
        Me.convorecorded.Visible = False
        '
        'emailaddybox
        '
        Me.emailaddybox.Location = New System.Drawing.Point(122, 29)
        Me.emailaddybox.Name = "emailaddybox"
        Me.emailaddybox.Size = New System.Drawing.Size(271, 20)
        Me.emailaddybox.TabIndex = 10
        Me.emailaddybox.Visible = False
        '
        'emailaddylabel
        '
        Me.emailaddylabel.AutoSize = True
        Me.emailaddylabel.Location = New System.Drawing.Point(1, 32)
        Me.emailaddylabel.Name = "emailaddylabel"
        Me.emailaddylabel.Size = New System.Drawing.Size(122, 14)
        Me.emailaddylabel.TabIndex = 9
        Me.emailaddylabel.Text = "From What Email Address?:"
        Me.emailaddylabel.Visible = False
        '
        'corresdate
        '
        Me.corresdate.Location = New System.Drawing.Point(129, 29)
        Me.corresdate.Name = "corresdate"
        Me.corresdate.Size = New System.Drawing.Size(175, 20)
        Me.corresdate.TabIndex = 8
        Me.corresdate.Visible = False
        '
        'corresdatelabel
        '
        Me.corresdatelabel.AutoSize = True
        Me.corresdatelabel.Location = New System.Drawing.Point(1, 33)
        Me.corresdatelabel.Name = "corresdatelabel"
        Me.corresdatelabel.Size = New System.Drawing.Size(200, 14)
        Me.corresdatelabel.TabIndex = 7
        Me.corresdatelabel.Text = "What Date Was The Correspondence Written?:"
        Me.corresdatelabel.Visible = False
        '
        'phonecallrecorded
        '
        Me.phonecallrecorded.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.phonecallrecorded.AutoSize = True
        Me.phonecallrecorded.Location = New System.Drawing.Point(588, 7)
        Me.phonecallrecorded.Name = "phonecallrecorded"
        Me.phonecallrecorded.Size = New System.Drawing.Size(108, 18)
        Me.phonecallrecorded.TabIndex = 6
        Me.phonecallrecorded.Text = "Phonecall Recorded:"
        Me.phonecallrecorded.UseVisualStyleBackColor = True
        Me.phonecallrecorded.Visible = False
        '
        'meetinglocbox
        '
        Me.meetinglocbox.Location = New System.Drawing.Point(426, 5)
        Me.meetinglocbox.Name = "meetinglocbox"
        Me.meetinglocbox.Size = New System.Drawing.Size(270, 20)
        Me.meetinglocbox.TabIndex = 3
        Me.meetinglocbox.Visible = False
        '
        'meetinglocationlabel
        '
        Me.meetinglocationlabel.AutoSize = True
        Me.meetinglocationlabel.Location = New System.Drawing.Point(308, 7)
        Me.meetinglocationlabel.Name = "meetinglocationlabel"
        Me.meetinglocationlabel.Size = New System.Drawing.Size(106, 14)
        Me.meetinglocationlabel.TabIndex = 2
        Me.meetinglocationlabel.Text = "Location of the meeting:"
        Me.meetinglocationlabel.Visible = False
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Humanus Placitum (Meeting in Person)", "Via Telephone", "Via Fax", "Via Email", "Via Written Correspondence", "Via Text (SMS) or Multimedia Messaging (MMS)"})
        Me.ComboBox2.Location = New System.Drawing.Point(84, 4)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(205, 22)
        Me.ComboBox2.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 14)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Method of Contact:"
        '
        'quit
        '
        Me.quit.Font = New System.Drawing.Font("Wide Latin", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quit.ForeColor = System.Drawing.Color.Red
        Me.quit.Location = New System.Drawing.Point(637, 416)
        Me.quit.Name = "quit"
        Me.quit.Size = New System.Drawing.Size(91, 37)
        Me.quit.TabIndex = 45
        Me.quit.Text = "QUIT"
        Me.quit.UseVisualStyleBackColor = True
        '
        'AgentbankTableAdapter
        '
        Me.AgentbankTableAdapter.ClearBeforeFill = True
        '
        'MaindataTableAdapter
        '
        Me.MaindataTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Poor Richard", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(10, 416)
        Me.Button1.Margin = New System.Windows.Forms.Padding(1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(155, 41)
        Me.Button1.TabIndex = 46
        Me.Button1.Text = "Submit Contact Report"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ConactReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(752, 466)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.quit)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Title)
        Me.Font = New System.Drawing.Font("Poor Richard", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "ConactReport"
        Me.Text = "Contact Report"
        CType(Me.AgentbankBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatacoreDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.MaindataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocaldatastorageDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Block, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Title As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents AgentNameBox As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents SubjectName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Subdivision As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Lot As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Block As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Tract As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents City As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents State As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents County As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Abstract As System.Windows.Forms.TextBox
    Friend WithEvents Survey As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents meetinglocbox As System.Windows.Forms.TextBox
    Friend WithEvents meetinglocationlabel As System.Windows.Forms.Label
    Friend WithEvents phonecallrecorded As System.Windows.Forms.CheckBox
    Friend WithEvents phonenobox As System.Windows.Forms.TextBox
    Friend WithEvents phonenolabel As System.Windows.Forms.Label
    Friend WithEvents corresdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents corresdatelabel As System.Windows.Forms.Label
    Friend WithEvents emailaddybox As System.Windows.Forms.TextBox
    Friend WithEvents emailaddylabel As System.Windows.Forms.Label
    Friend WithEvents convorecorded As System.Windows.Forms.CheckBox
    Friend WithEvents quit As System.Windows.Forms.Button
    Friend WithEvents DatacoreDataSet As LandStalker.datacoreDataSet
    Friend WithEvents AgentbankBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AgentbankTableAdapter As LandStalker.datacoreDataSetTableAdapters.agentbankTableAdapter
    Friend WithEvents Georeferencebox As System.Windows.Forms.ComboBox
    Friend WithEvents LocaldatastorageDataSet As LandStalker.localdatastorageDataSet
    Friend WithEvents MaindataBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MaindataTableAdapter As LandStalker.localdatastorageDataSetTableAdapters.maindataTableAdapter
    Friend WithEvents Prospectbox As System.Windows.Forms.ListBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents cntcrptlbl As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
