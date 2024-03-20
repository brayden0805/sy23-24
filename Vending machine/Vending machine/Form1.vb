Public Class Form1
    Dim WithEvents cs As New Coinslot
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cs.insertquarter()
        Label1.Text = cs.total.ToString("c2")
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cs.inseertnickle()
        Label1.Text = cs.total.ToString("c2")
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button3.Click
        cs.insertdime()
        Label1.Text = cs.total.ToString("c2")
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button4.Click
        cs.insertdollar()
        Label1.Text = cs.total.ToString("c2")
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button5.Click
        cs.coinreturn()
        Label1.Text = cs.total.ToString("c2")
    End Sub

    Private Sub cs_coinreturnevent(d As Integer, q As Integer, dm As Integer, n As Integer) Handles cs.coinreturnevent
        If d > 0 Then
            dollarpicturebox.Visible = True
        Else
            dollarpicturebox.Visible = False
        End If
        If n > 0 Then
            PictureBox2.Visible = True
        Else
            PictureBox2.Visible = False
        End If
        If q > 0 Then
            quarterpcturebox.Visible = True
        Else
            quarterpcturebox.Visible = False
        End If
        If dm > 0 Then
            dimepicturebox.Visible = True
        Else
            dimepicturebox.Visible = False
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Select Case IDtextbox.Text
            Case Productcontrol26.productID
                Productcontrol26.buy()
            Case 2

            Case Else

        End Select
        totallabel.Text = cs.total.ToString("c2")
    End Sub

    Private Sub cs_dispence(p As Image) Handles cs.dispence
        productPictureBox.Image = p
    End Sub
End Class
