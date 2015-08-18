'Drop your cock and grab your socks! It's Title Agent Interface time!
'This interface is based off of my old program the I.C.E. M.O.R. Generator V 2.0!

Public Class TAI
    'We'll set the dataset as an object now, get that outta the way.
    Dim MORGENTBLTableAdapter As Object

    'This subroutine controls the "Volume page / Document Number" checkbox and corresponding entry fields.
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then 'The checkbox is checked
            Me.SDNL1.Visible = False
            Me.SourceDocNumber.Visible = False
            Me.SDDL1.Visible = False
            Me.SourceDocDate.Visible = False
            Me.VOL1.Visible = True
            Me.Volume.Visible = True
            Me.Page1.Visible = True
            Me.Page.Visible = True
            Me.volpagedate.Visible = True
            Me.VPDL1.Visible = True

        End If
        If CheckBox1.Checked = False Then ' The checkbox is unchecked
            Me.SDNL1.Visible = True
            Me.SourceDocNumber.Visible = True
            Me.SDDL1.Visible = True
            Me.SourceDocDate.Visible = True
            Me.VOL1.Visible = False
            Me.Volume.Visible = False
            Me.Page1.Visible = False
            Me.Page.Visible = False
            Me.volpagedate.Visible = False
            Me.VPDL1.Visible = False
        End If
    End Sub
    'This is the quit button and corresponding dialog box at the bottom
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        My.Computer.Audio.Play("C:\Landstalker\Button-29.wav")
        Dim intResponse As Integer
        intResponse = MsgBox("Are you sure you want to quit the LandStalker Title Agent Interface? If you have not saved, your work will be lost!", vbYesNo + vbQuestion, "Quit")
        If intResponse = vbYes Then
            TopMenu.Show()
            Me.Close()
        End If
    End Sub
    'This is the quit button and corresponding dialog box at the top
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        My.Computer.Audio.Play("C:\Landstalker\Button-29.wav")
        Dim intResponse As Integer
        intResponse = MsgBox("Are you sure you want to quit the LandStalker Title Agent Interface? If you have not saved, your work will be lost!", vbYesNo + vbQuestion, "Quit")
        If intResponse = vbYes Then
            TopMenu.Show()
            Me.Close()
        End If
    End Sub
    'this opens the word document that the MOR goes into, It's a mail merge template
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        My.Computer.Audio.Play("C:\Landstalker\button-29.wav")
        Dim wdApp As Object
        On Error Resume Next
        wdApp = GetObject(, "Word.Application")
        If Err.Number <> 0 Then 'Word isn't already running
            wdApp = CreateObject("Word.Application")
        End If
        On Error GoTo 0
        wdApp.Documents.Open("c:\Landstalker\MORTEMP2.doc")
        wdApp.Visible = True
        wdApp = Nothing
    End Sub
    'This loads all the SQL database information into the form
    Private Sub TAI_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatacoreDataSet.working_counties' table. You can move, or remove it, as needed.
        Me.Working_countiesTableAdapter.Fill(Me.DatacoreDataSet.working_counties)
        'TODO: This line of code loads data into the 'DatacoreDataSet.working_state' table. You can move, or remove it, as needed.
        Me.Working_stateTableAdapter.Fill(Me.DatacoreDataSet.working_state)
        'TODO: This line of code loads data into the 'DatacoreDataSet.working_city' table. You can move, or remove it, as needed.
        Me.Working_cityTableAdapter.Fill(Me.DatacoreDataSet.working_city)
        'TODO: This line of code loads data into the 'DatacoreDataSet.sourcedocrecin' table. You can move, or remove it, as needed.
        Me.SourcedocrecinTableAdapter.Fill(Me.DatacoreDataSet.sourcedocrecin)
        'TODO: This line of code loads data into the 'DatacoreDataSet.acresource' table. You can move, or remove it, as needed.
        Me.AcresourceTableAdapter.Fill(Me.DatacoreDataSet.acresource)
        'TODO: This line of code loads data into the 'DatacoreDataSet.sourcedoctype' table. You can move, or remove it, as needed.
        Me.SourcedoctypeTableAdapter.Fill(Me.DatacoreDataSet.sourcedoctype)
        'TODO: This line of code loads data into the 'DatacoreDataSet.subdivision' table. You can move, or remove it, as needed.
        Me.SubdivisionTableAdapter.Fill(Me.DatacoreDataSet.subdivision)
        'TODO: This line of code loads data into the 'DatacoreDataSet.agentbank' table. You can move, or remove it, as needed.
        Me.AgentbankTableAdapter.Fill(Me.DatacoreDataSet.agentbank)
    End Sub
    'Unused for now
    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter


    End Sub
End Class