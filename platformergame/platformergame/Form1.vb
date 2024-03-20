Public Class Form1
    Dim movespeed As Integer = 10
    Dim isjumping As Boolean
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        Select Case e.KeyCode
            Case Keys.Right
                tmrRight.Start()
            Case Keys.Left
                tmrLeft.Start()
            Case Keys.Up
                tmrUp.Start()
                isjumping = True
        End Select
    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyUp
        Select Case e.KeyCode
            Case Keys.Right
                tmrRight.Stop()
            Case Keys.Left
                tmrLeft.Stop()
            Case Keys.Up
                tmrUp.Stop()
                isjumping = False
        End Select
    End Sub
    Private Sub tmrright_Tick(sender As Object, e As EventArgs) Handles tmrRight.Tick
        picplayer.Left += movespeed
    End Sub
    Private Sub tmrLeft_Tick(sender As Object, e As EventArgs) Handles tmrLeft.Tick
        picplayer.Left -= movespeed
    End Sub

    Private Sub tmrUp_Tick(sender As Object, e As EventArgs) Handles tmrUp.Tick
        picplayer.Top -= movespeed
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrGamelogic.Start()
        TextBox1.Select()
    End Sub

    Private Sub tmrGamelogic_Tick(sender As Object, e As EventArgs) Handles tmrGamelogic.Tick
        If picplayer.Bounds.IntersectsWith(picair.Bounds) Then
            If isjumping = False Then
                tmrgravity.Start()
            End If
        ElseIf picplayer.Bounds.IntersectsWith(picground.Bounds) Then
            tmrgravity.Stop()
        End If
        For Each b As Control In Me.Controls
            If TypeOf b Is PictureBox Then
                If b.Tag = "bound" Then
                    If picplayer.Bounds.IntersectsWith(b.Bounds) Then
                        tmrgravity.Stop()
                    End If
                End If
            End If
        Next
    End Sub
    Private Sub tmrGravity_Tick(sender As Object, e As EventArgs) Handles tmrgravity.Tick
        picplayer.Top += movespeed
    End Sub

End Class
