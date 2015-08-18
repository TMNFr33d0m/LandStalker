Public Class ConactReport

    Private Sub LAI_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LocaldatastorageDataSet.maindata' table. You can move, or remove it, as needed.
        Me.MaindataTableAdapter.Fill(Me.LocaldatastorageDataSet.maindata)
        'TODO: This line of code loads data into the 'DatacoreDataSet.agentbank' table. You can move, or remove it, as needed.
        Me.AgentbankTableAdapter.Fill(Me.DatacoreDataSet.agentbank)
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        Dim method As String
        method = ComboBox2.Text

        If method = "Humanus Placitum (Meeting in Person)" Then
            Me.meetinglocationlabel.Visible = True
            Me.meetinglocbox.Visible = True
            Me.convorecorded.Visible = True
        Else
            Me.meetinglocationlabel.Visible = False
            Me.meetinglocbox.Visible = False
            Me.convorecorded.Visible = False
        End If
        If method = "Via Fax" Then
            MsgBox("You may upload an image of the fax later")
            Me.phonenolabel.Visible = True
            Me.phonenobox.Visible = True

        Else
            Me.phonenolabel.Visible = False
            Me.phonenobox.Visible = False
        End If
        If method = "Via Telephone" Then
            Me.phonenolabel.Visible = True
            Me.phonenobox.Visible = True
            Me.phonecallrecorded.Visible = True
        Else
            Me.phonenolabel.Visible = False
            Me.phonenobox.Visible = False
            Me.phonecallrecorded.Visible = False
        End If
        If method = "Via Written Correspondence" Then
            MsgBox("You may upload an image of written correspondence later")
            Me.corresdate.Visible = True
            Me.corresdatelabel.Visible = True

        Else
            Me.corresdate.Visible = False
            Me.corresdatelabel.Visible = False
        End If
        If method = "Via Email" Then
            Me.emailaddybox.Visible = True
            Me.emailaddylabel.Visible = True
        Else
            Me.emailaddybox.Visible = False
            Me.emailaddylabel.Visible = False
        End If
        If method = "Via Text (SMS) or Multimedia Messaging (MMS)" Then
            Me.phonenobox.Visible = True
            Me.phonenolabel.Visible = True
        Else
            Me.phonenobox.Visible = False
            Me.phonenolabel.Visible = False
        End If
    End Sub

    Private Sub quit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles quit.Click
        My.Computer.Audio.Play("C:\Landstalker\Button-29.wav")
        Dim intResponse As Integer
        intResponse = MsgBox("Are you sure you want to quit the LandStalker Land Acquisition Interface? If you have not saved, your work will be lost!", vbYesNo + vbQuestion, "Quit")
        If intResponse = vbYes Then
            TopMenu.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        My.Computer.Audio.Play("C:\Landstalker\Button-29.wav")
    End Sub
End Class