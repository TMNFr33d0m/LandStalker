
Public NotInheritable Class SplashScreen1

    Private Sub SplashScreen1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Control.CheckForIllegalCrossThreadCalls = False
    End Sub
    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Static Ticks As Integer = 0
        Ticks += 1
        Dim Mins As Integer = Ticks \ 60
        Dim Secs As Integer = Ticks Mod 60

        If Ticks = 0 Then
            Me.ProgressBar.Value = 0
        End If
        If Ticks = 1 Then
            Me.ProgressBar.Value = 25
        End If
        If Ticks = 5 Then
            Me.ProgressBar.Value = 30
        End If
        If Ticks = 8 Then
            Me.ProgressBar.Value = 36
        End If
        If Ticks = 10 Then
            Me.ProgressBar.Value = 100
        End If
    End Sub

    Private Sub ProgressBar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgressBar.Click

    End Sub
End Class
