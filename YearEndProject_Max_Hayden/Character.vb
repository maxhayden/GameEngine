Public Class Character

    'X and Y location
    Public X As Integer = 40
    Public Y As Double = 180

    'Physics
    Public intGrav As Double = 0.3
    Public intVel As Double = 0
    Public intSpeed As Integer = 0

    'DRAW
    Public Sub drawCharacter(G As Graphics, BB As Bitmap, XLocation As Integer, YLocation As Double)

        'draw image
        G.DrawImage(My.Resources.Character, New RectangleF(New Point(XLocation, YLocation), New Size(20, 60)))

    End Sub

    'UPDATE
    Public Sub Update()

        Y += intVel
        intVel += intGrav

    End Sub

    'MOVE
    Public Function Move(intSpeed As Integer) As Integer

        'update x pos
        X += intSpeed

        Return X

    End Function

    'JUMP
    Public Function Jump(blnJump As Boolean) As Integer

        If blnJump Then

            'update y pos
            intVel = -6

        End If

        Return Y

    End Function

End Class
