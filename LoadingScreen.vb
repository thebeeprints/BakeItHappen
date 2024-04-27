
Public Class LoadingScreen
    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles LoadingScreenTimer.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = 100 Then
            LoadingScreenTimer.Stop()
            Me.Hide()
        End If
    End Sub

    Private Sub LoadingScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
