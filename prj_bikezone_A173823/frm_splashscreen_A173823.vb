Public Class frm_splashscreen_A173823
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Panel2.Width += 10
        If (Panel2.Width >= 700) Then
            Timer1.Stop()
        End If
    End Sub

    Private Sub frm_splashscreen_A173823_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
End Class