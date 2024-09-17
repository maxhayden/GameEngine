Public Class frmMap_Maker

    'GRAPHICS SETUP
    Dim G As Graphics
    Dim BB As New Bitmap(980, 260)

    'MAP MAKING VARIABLES
    Public intMapPointValues(48, 12) As Integer
    Dim blnRunning As Boolean = False
    Dim intBrush As Integer = 1

    'MAP MAKER LOAD
    Private Sub MapMaker_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        'Create floor
        For i = 0 To 48
            intMapPointValues(i, 12) = 1
        Next

        'GRAPHICS SET UP
        Show()
        G = Graphics.FromImage(BB)
        G.Clear(Color.LightBlue)
        CreateGraphics.DrawImage(BB, New Point(0, 0))

        'RUN DESIGNER LOOP
        blnRunning = True
        DrawingLoop()

    End Sub

    'DESIGN LOOP
    Private Sub DrawingLoop()

        Dim f As Integer

        'DESIGN LOOP
        Do While blnRunning

            f = f + 1

            'DRAW 
            Label1.Text = f

            'clear bitmap
            G.Clear(Color.LightBlue)

            CheckEnd()

            'draw map
            DrawMap()

            'draw graphics
            CreateGraphics.DrawImage(BB, New Point(0, 0))

            'RUN OTHER CODE
            Application.DoEvents()

        Loop

    End Sub

    'CHECK FOR PRESENT ENDTILE
    Private Sub checkEnd()

        Static intTick As Integer = 0
        Dim blnEndEnabled As Boolean = True

        For i = 0 To 48
            For ii = 0 To 12
                If intMapPointValues(i, ii) = 2 Then
                    blnEndEnabled = False
                End If
            Next
        Next

        If blnEndEnabled = False And intTick = 0 Then
            intTick = 1
            btnEndFlag.Enabled = False
            intBrush = 1
        ElseIf blnEndEnabled = True Then
            intTick = 0
            btnEndFlag.Enabled = True
        End If

    End Sub

    'DRAWING MAP 
    Private Sub drawMap()

        'DRAW FROM ARRAY
        For i = 0 To 48
            For ii = 0 To 12

                If intMapPointValues(i, ii) = 1 Then
                    G.FillRectangle(Brushes.Black, New RectangleF(New Point(i * 20, ii * 20), New Size(20, 20)))
                ElseIf intMapPointValues(i, ii) = 2 Then
                    G.FillRectangle(Brushes.Yellow, New RectangleF(New Point(i * 20, ii * 20), New Size(20, 20)))
                End If

            Next
        Next


    End Sub

    'DRAWING TILES
    Private Sub frmMap_Maker_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick

        'GET MOUSE X AND Y LOCATIONS
        Dim intCursorX As Integer = e.X \ 20
        Dim intCursorY As Integer = e.Y \ 20

        'IMPUT VALUES INTO MAP ARRAY

        If intBrush = 2 Then
            intMapPointValues(intCursorX, intCursorY) = intBrush
        Else
            intMapPointValues(intCursorX, intCursorY) = intBrush
        End If

    End Sub

    'SET BRUSHES 
    'pencil
    Private Sub btnDraw_Click(sender As System.Object, e As System.EventArgs) Handles btnDraw.Click
        intBrush = 1
    End Sub
    'eraser
    Private Sub btnErase_Click(sender As System.Object, e As System.EventArgs) Handles btnErase.Click
        intBrush = 0
    End Sub
    'flag
    Private Sub btnEndFlag_Click(sender As System.Object, e As System.EventArgs) Handles btnEndFlag.Click
        intBrush = 2
    End Sub

    'GUI
    'open menu
    Private Sub btnMenu_Click(sender As System.Object, e As System.EventArgs) Handles btnMenu.Click

        'go to menu
        Hide()
        Project_Menu.Show()


    End Sub
    'exit game
    Private Sub btnEnd_Click(sender As System.Object, e As System.EventArgs) Handles btnEnd.Click

        'End game
        End

    End Sub

End Class