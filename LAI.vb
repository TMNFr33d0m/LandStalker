Public Class LAI

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        My.Computer.Audio.Play("C:\Landstalker\Button-29.wav")
        ConactReport.Show()
        Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        My.Computer.Audio.Play("C:\Landstalker\Button-29.wav")
        MsgBox("This will take you to a form that will allow you to request paper copy leases from administration and track your request's status")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        My.Computer.Audio.Play("C:\Landstalker\Button-29.wav")
        MsgBox("This is where you will be able check on the status of your lease request in real time")
    End Sub

    Private Sub quitbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles quitbtn.Click
        My.Computer.Audio.Play("C:\Landstalker\Button-29.wav")
        My.Computer.Audio.Play("C:\Landstalker\alarm1.wav")
        Dim intResponse As Integer
        intResponse = MsgBox("Are you sure you want to quit the Acquisition Agent User Interface?", vbYesNo + vbQuestion, "Quit")
        If intResponse = vbYes Then
            TopMenu.Show()
            Close()
        End If
    End Sub
End Class