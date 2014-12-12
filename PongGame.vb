Public Class PongGame
    Dim windowX = Me.Location.X
    Dim windowY = Me.Location.Y
    Dim xChange = 1
    Dim yChange = 1
    
    Dim p1Score = 0
    DIm p2Score = 0

    Dim speed As Single = 10 ' Ball Speed
    Dim rndInst As New Random() ' Random instance
    Dim xVel As Single = Math.Cos(rndInst.Next(5, 10)) * speed
    Dim yVel As Single = Math.Sin(rndInst.Next(5, 10)) * speed

    Private Sub updateTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles updateTimer.Tick
        player1()
        player2()
        ball()
    End Sub

    Private Sub PongGame_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cursor.Hide()
        Dim rnd As Random = New Random
        Dim startDirection = rnd.Next
        If startDirection > 50 Then
            xChange *= -1
            yChange *= -1
        End If
    End Sub

    Public Function player2()

    End Function

    Public Function player1()
        If Cursor.Position.Y - (Me.Location.Y + 80) > 0 And Cursor.Position.Y - (Me.Location.Y + 80) < 612 Then
            greenPaddle.Height = 100
            greenPaddle.Location = New Point(952, Cursor.Position.Y - (Me.Location.Y + 80))
        ElseIf Cursor.Position.Y - (Me.Location.Y + 80) < 0 Then
            greenPaddle.Location = New Point(952, 0)
        ElseIf Cursor.Position.Y - Me.Location.Y > 612 Then
            greenPaddle.Location = New Point(952, 611)
        End If
    End Function

    Public Function ball()
        Dim xPos = ballP.Location.X
        Dim yPos = ballP.Location.Y
        If ballP.Location.X > 1000 Then
            xPos = 449
            yPos = 352
            xChange = -1
        End If
        If ballP.Location.X < -20 Then
            xPos = 449
            yPos = 352
            xChange = -1
        End If
        If ballP.Location.Y > 691 Then
            yChange *= -1
        End If
        If ballP.Location.Y < 0 Then
            yChange *= -1
        End If
        If ballP.Bounds.IntersectsWith(redPaddle.Bounds) Or ballP.Bounds.IntersectsWith(greenPaddle.Bounds) Then
            xChange *= -2
        End If
        
        If ballP.Location.X <= 0 Then
        p2Score += 1
        ballP.Location = New Point( Me.Size.Width/2, Me.Size.Height/2)
        End If
        
         If ballP.Location.X >= 730 Then
        p1Score += 1
        ballP.Location = New Point( Me.Size.Width/2, Me.Size.Height/2)
        End If
        
        ballP.Location = New Point(xPos + xChange, yPos + yChange)
    End Function
End Class
