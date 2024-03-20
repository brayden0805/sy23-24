Public Class Form1
    Dim cs As New coin
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If cs.total >= 1 Then
            Reelcontrol1.spin()
            Reelcontrol2.spin()
            Reelcontrol3.spin()
            cs.spin()
            Label4.Text = cs.total.ToString("c2")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label1.Text = Reelcontrol1.itemvalue
        Label2.Text = Reelcontrol2.itemvalue
        Label3.Text = Reelcontrol3.itemvalue
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        cs.insertdollar()
        Label4.Text = cs.total.ToString("c2")
    End Sub
End Class