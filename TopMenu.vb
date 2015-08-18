Public Class TopMenu
    'Top Menu GUI. O.M.E.G.A. NadaNet Systems! FTW!!
    'Firstly, we'll load the date and time greeeting box that appears above the big cat
    Private Sub TopMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DateTime.Text = (" Welcome, " & My.Computer.Name & "! The Current Date / Time is " & My.Computer.Clock.LocalTime)
    End Sub
    'This is the big green submit button and its logic
    Private Sub DestSumbit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DestSumbit.Click
        My.Computer.Audio.Play("C:\Landstalker\button-29.wav")
        Dim agent As String
        agent = FormSelectorPRI.Text
        If agent = "Please Select A Destination" Then
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Exclamation)
            MsgBox("Please Select A Destination! You failed to choose one from the box that says 'Please Select a Destination'")
        End If
        If agent = "Leasing Agent Interface" Then
            LAI.Show()
        End If
        If agent = "Title Agent Interface" Then
            TAI.Show()
        End If
        If agent = "Administrative Interface" Then
            ADMININT.Show()
        End If
        If agent = "Reporting Interface" Then
            RI.Show()
        End If
        If agent = "Financial Interface" Then
            FI.Show()
        End If
    End Sub
    'This little line of code plays sound for every time the menu choice is changed
    Private Sub FormSelectorPRI_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FormSelectorPRI.SelectedIndexChanged
        My.Computer.Audio.Play("C:\Landstalker\Button-21.wav")
    End Sub
    'this is the quit button
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        My.Computer.Audio.Play("C:\Landstalker\alarm1.wav")
        Dim intResponse As Integer
        intResponse = MsgBox("Are you sure you want to quit LandStalker?", vbYesNo + vbQuestion, "Quit")
        If intResponse = vbYes Then
            End
        End If
    End Sub
End Class
