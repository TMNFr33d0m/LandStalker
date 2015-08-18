Public Class RI

    Private Sub RI_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MsgBox(" Sorry! The Reporting User Interface feature is not ready to be released yet! It's Under Development Now!")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        My.Computer.Audio.Play("C:\Landstalker\Button-29.wav")
    End Sub
End Class