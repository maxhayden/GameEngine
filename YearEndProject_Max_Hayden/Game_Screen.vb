Public Class Game_Screen

    'GRAPHICS VARIABLES
    Dim BB As New Bitmap(980, 260)
    Dim G As Graphics

    'GAME VARIABLES
    Dim blnRunning As Boolean = False
    Dim intMapArray(,) As Integer

    'MOVEMENT VARIABLES
    Dim blnJump As Boolean
    Dim blnForward As Boolean
    Dim blnBackwards As Boolean


    'GAME LOAD
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        'show form
        Show()

        'GET MAP ARRAY
        intMapArray = frmMap_Maker.intMapPointValues

        'SETUP GRAPHICS ENGINE
        G = Graphics.FromImage(BB)
        G.Clear(Color.LightBlue)
        CreateGraphics.DrawImage(BB, New Point(0, 0))

        blnRunning = True
        GameLoop()

    End Sub

    'GAME LOOP
    Private Sub gameLoop()

        'CHARARCTER VARIABLE
        Dim MyCharacter As New Character
        Dim X As Integer
        Dim Y As Double

        'WINLINE VARIABLE
        Dim intWinline As Integer

        'GAME MAP PICTURE
        Dim BBBackground As New Bitmap(980, 260)
        drawMap(BBBackground, intWinline)


        'GAME LOOP
        Do While blnRunning = True


            lblX.Text = "x: " & X
            lblY.Text = "Y: " & Y
            lblF.Text = "Y Velocity: " & MyCharacter.intVel

            'CLEAR BITMAP
            G.Clear(Color.Black)

            'GET X AND Y
            Y = MyCharacter.Jump(False)
            X = MyCharacter.Move(0)


            'CHECK COLISSION
            If Y > 180 Then
                Y = 180
                MyCharacter.intVel = 0
            End If

            'UPDATE LOCATION
            MoveCharacter(MyCharacter, X, Y)

            MyCharacter.Update()


            'DRAW

            'draw map
            G.DrawImage(BBBackground, New RectangleF(New Point(0, 0), New Size(980, 260)))
            'draw character
            MyCharacter.DrawCharacter(G, BB, X, Y)
            'draw image
            CreateGraphics.DrawImage(BB, New Point(0, 0))

            'CHECK WIN


            'RUN OTHER COMPONANTS
            Application.DoEvents()

        Loop

    End Sub

    'DRAWING MAP 
    Private Sub drawMap(ByRef BBBackground As Bitmap, intwinline As Integer)

        'SET GRAPHICS
        G = Graphics.FromImage(BBBackground)

        'DRAW BACKDROP
        G.DrawImage(My.Resources.BackDrop, New RectangleF(New Point(0, 0), New Size(980, 260)))

        'DRAW FROM ARRAY
        For i = 0 To 48
            For ii = 0 To 12

                If intMapArray(i, ii) = 1 Then
                    G.DrawImage(My.Resources.Ground, New RectangleF(New Point(i * 20, ii * 20), New Size(20, 20)))
                ElseIf intMapArray(i, ii) = 2 Then
                    G.DrawImage(My.Resources.EndPoint, New RectangleF(New Point(i * 20, ii * 20), New Size(20, 40)))
                    intwinline = i * 20
                End If

            Next
        Next

        'RESET GRAPHICS
        G = Graphics.FromImage(BB)

    End Sub

    'MOVEMENT SUBS
    'movement of character
    Private Sub MoveCharacter(Character As Character, ByRef X As Integer, ByRef Y As Double)

        'CHECK FOR INPUT
        If blnJump Then

            'jump
            Y = Character.Jump(True)
            blnJump = False

        ElseIf blnForward Then

            'forward
            X = Character.Move(1)

        ElseIf blnBackwards Then

            'backwards
            X = Character.Move(-1)

        End If

    End Sub
    'keypress
    Private Sub Game_Screen_keyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress

        'MOVEMENT
        If e.KeyChar = ChrW(Keys.W) Then

            'jump
            blnJump = True

        End If

    End Sub
    'key down
    Private Sub Game_Screen_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        'CHECK FOR KEY DOWN
        If e.KeyCode = Keys.A Then

            'backwards
            blnBackwards = True

        ElseIf e.KeyCode = Keys.D Then

            'forward
            blnForward = True

        End If

    End Sub
    'key up
    Private Sub Game_Screen_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp

        'CHECK FOR KEY UP
        If e.KeyCode = Keys.A Then

            'backwards
            blnBackwards = False

        ElseIf e.KeyCode = Keys.D Then

            'forward
            blnForward = False

        End If

    End Sub

    'GUI
    'open menu
    Private Sub btnMenu_Click(sender As System.Object, e As System.EventArgs) Handles btnMenu.Click

        'open menu 
        Me.Hide()
        Project_Menu.Show()

    End Sub
    'exit game
    Private Sub btnEnd_Click(sender As System.Object, e As System.EventArgs) Handles btnEnd.Click

        'end game
        End

    End Sub

    'CHECK COLLISION
    Private Sub checkCollision(Character As Character, ByRef X As Integer, ByRef Y As Double)



    End Sub

End Class
