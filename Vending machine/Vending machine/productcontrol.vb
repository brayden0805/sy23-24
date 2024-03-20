Public Class productcontrol
    Public Property productID As String
    Public Property price As Decimal
    Public Property count As Integer
    Public Property picture As Image
    Public Property ProductCount As Integer

    Private Sub productcontrol_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Image = picture
        IDlabel.Text = productID
        pricelabel.Text = price.ToString("c2")
    End Sub
    Public Sub buy()
        If count > 0 Then
            count = count - 1
        End If
        If count = 0 Then
            PictureBox1.Image = Nothing
        End If
    End Sub
End Class
