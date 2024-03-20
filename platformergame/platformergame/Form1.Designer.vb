<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.tmrRight = New System.Windows.Forms.Timer(Me.components)
        Me.tmrLeft = New System.Windows.Forms.Timer(Me.components)
        Me.tmrUp = New System.Windows.Forms.Timer(Me.components)
        Me.tmrGamelogic = New System.Windows.Forms.Timer(Me.components)
        Me.tmrgravity = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.picground = New System.Windows.Forms.PictureBox()
        Me.picplayer = New System.Windows.Forms.PictureBox()
        Me.picair = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Mover3 = New platformergame.mover()
        Me.Mover2 = New platformergame.mover()
        Me.Mover1 = New platformergame.mover()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picground, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picplayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picair, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrRight
        '
        Me.tmrRight.Interval = 20
        '
        'tmrLeft
        '
        Me.tmrLeft.Interval = 20
        '
        'tmrUp
        '
        Me.tmrUp.Interval = 20
        '
        'tmrGamelogic
        '
        Me.tmrGamelogic.Interval = 20
        '
        'tmrgravity
        '
        Me.tmrgravity.Interval = 20
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.platformergame.My.Resources.Resources.download__2_
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(132, 64)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(47, 48)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'picground
        '
        Me.picground.BackColor = System.Drawing.Color.Lime
        Me.picground.Location = New System.Drawing.Point(3, 426)
        Me.picground.Name = "picground"
        Me.picground.Size = New System.Drawing.Size(794, 24)
        Me.picground.TabIndex = 2
        Me.picground.TabStop = False
        '
        'picplayer
        '
        Me.picplayer.BackColor = System.Drawing.Color.Red
        Me.picplayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picplayer.Location = New System.Drawing.Point(25, 373)
        Me.picplayer.Name = "picplayer"
        Me.picplayer.Size = New System.Drawing.Size(46, 47)
        Me.picplayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picplayer.TabIndex = 0
        Me.picplayer.TabStop = False
        Me.picplayer.Tag = ""
        '
        'picair
        '
        Me.picair.Location = New System.Drawing.Point(12, 12)
        Me.picair.Name = "picair"
        Me.picair.Size = New System.Drawing.Size(776, 408)
        Me.picair.TabIndex = 1
        Me.picair.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(688, 398)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 4
        '
        'Mover3
        '
        Me.Mover3.BackColor = System.Drawing.Color.DimGray
        Me.Mover3.interval = 500
        Me.Mover3.Location = New System.Drawing.Point(531, 196)
        Me.Mover3.Name = "Mover3"
        Me.Mover3.Size = New System.Drawing.Size(168, 18)
        Me.Mover3.speed = 0
        Me.Mover3.sprite = Nothing
        Me.Mover3.TabIndex = 7
        Me.Mover3.Tag = "bound"
        '
        'Mover2
        '
        Me.Mover2.BackColor = System.Drawing.Color.DimGray
        Me.Mover2.interval = 500
        Me.Mover2.Location = New System.Drawing.Point(212, 300)
        Me.Mover2.Name = "Mover2"
        Me.Mover2.Size = New System.Drawing.Size(154, 15)
        Me.Mover2.speed = 0
        Me.Mover2.sprite = Nothing
        Me.Mover2.TabIndex = 6
        Me.Mover2.Tag = "bound"
        '
        'Mover1
        '
        Me.Mover1.BackColor = System.Drawing.Color.DimGray
        Me.Mover1.interval = 500
        Me.Mover1.Location = New System.Drawing.Point(117, 118)
        Me.Mover1.Name = "Mover1"
        Me.Mover1.Size = New System.Drawing.Size(195, 21)
        Me.Mover1.speed = 0
        Me.Mover1.sprite = Nothing
        Me.Mover1.TabIndex = 5
        Me.Mover1.Tag = "bound"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Mover3)
        Me.Controls.Add(Me.Mover2)
        Me.Controls.Add(Me.Mover1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.picground)
        Me.Controls.Add(Me.picplayer)
        Me.Controls.Add(Me.picair)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picground, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picplayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picair, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picplayer As PictureBox
    Friend WithEvents picair As PictureBox
    Friend WithEvents picground As PictureBox
    Friend WithEvents tmrRight As Timer
    Friend WithEvents tmrLeft As Timer
    Friend WithEvents tmrUp As Timer
    Friend WithEvents tmrGamelogic As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents tmrgravity As Timer
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Mover1 As mover
    Friend WithEvents Mover2 As mover
    Friend WithEvents Mover3 As mover
End Class
