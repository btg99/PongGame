<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PongGame
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PongGame))
        Me.greenPaddle = New System.Windows.Forms.PictureBox
        Me.updateTimer = New System.Windows.Forms.Timer(Me.components)
        Me.redPaddle = New System.Windows.Forms.PictureBox
        Me.ballP = New System.Windows.Forms.PictureBox
        CType(Me.greenPaddle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.redPaddle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ballP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'greenPaddle
        '
        Me.greenPaddle.BackColor = System.Drawing.Color.Transparent
        Me.greenPaddle.Image = CType(resources.GetObject("greenPaddle.Image"), System.Drawing.Image)
        Me.greenPaddle.Location = New System.Drawing.Point(952, 0)
        Me.greenPaddle.Name = "greenPaddle"
        Me.greenPaddle.Size = New System.Drawing.Size(20, 100)
        Me.greenPaddle.TabIndex = 1
        Me.greenPaddle.TabStop = False
        '
        'updateTimer
        '
        Me.updateTimer.Enabled = True
        Me.updateTimer.Interval = 1
        '
        'redPaddle
        '
        Me.redPaddle.BackColor = System.Drawing.Color.Transparent
        Me.redPaddle.Image = Global.PongGame.My.Resources.Resources.r2
        Me.redPaddle.Location = New System.Drawing.Point(12, 248)
        Me.redPaddle.Name = "redPaddle"
        Me.redPaddle.Size = New System.Drawing.Size(20, 200)
        Me.redPaddle.TabIndex = 3
        Me.redPaddle.TabStop = False
        '
        'ballP
        '
        Me.ballP.BackColor = System.Drawing.Color.Transparent
        Me.ballP.Image = Global.PongGame.My.Resources.Resources.ball
        Me.ballP.Location = New System.Drawing.Point(449, 352)
        Me.ballP.Name = "ballP"
        Me.ballP.Size = New System.Drawing.Size(20, 20)
        Me.ballP.TabIndex = 4
        Me.ballP.TabStop = False
        '
        'PongGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(984, 711)
        Me.Controls.Add(Me.ballP)
        Me.Controls.Add(Me.redPaddle)
        Me.Controls.Add(Me.greenPaddle)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MaximumSize = New System.Drawing.Size(1000, 750)
        Me.MinimumSize = New System.Drawing.Size(1000, 726)
        Me.Name = "PongGame"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pong Game"
        CType(Me.greenPaddle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.redPaddle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ballP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents greenPaddle As System.Windows.Forms.PictureBox
    Friend WithEvents updateTimer As System.Windows.Forms.Timer
    Friend WithEvents redPaddle As System.Windows.Forms.PictureBox
    Friend WithEvents ballP As System.Windows.Forms.PictureBox

End Class
