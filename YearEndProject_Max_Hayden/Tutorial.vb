Public Class Tutorial

    'OPEN MENU
    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click

        'exit form
        Hide()
        Project_Menu.Show()

    End Sub

    'DRAWING INSTRUCTIONS
    Private Sub btnDrawing_Click(sender As System.Object, e As System.EventArgs) Handles btnDrawing.Click

        'text for instructions
        Dim strInstructions As String = "Map Design Instructions" & vbCrLf & vbCrLf &
                                        "General:" & vbCrLf &
                                        "-all blocks must be touching" & vbCrLf &
                                        "-only one end point is allowed to be placed onto the map" & vbCrLf & vbCrLf &
                                        "Tools:" & vbCrLf &
                                        "-pencil: Draws Terrain" & vbCrLf &
                                        "-Eraser: Removes Terrain" & vbCrLf &
                                        "-Flag: Adds End Point (once flag is placed pencil will be equiped)"

        'display 
        lblInstructions.Text = strInstructions

    End Sub

    'GAME INSTRUCTIONS
    Private Sub btnGame_Click(sender As System.Object, e As System.EventArgs) Handles btnGame.Click

        'text for instructions
        Dim strInstructions As String = "Game Instructions" & vbCrLf & vbCrLf &
                                     "Controls:" & vbCrLf &
                                     "*CAPS LOCK MUST BE ON*" & vbCrLf &
                                     "W = Jump" & vbCrLf &
                                     "A = BackWards" & vbCrLf &
                                     "D = Forward" & vbCrLf & vbCrLf &
                                     "Rules:" & vbCrLf &
                                     "-Traverse your designed map and make it to the end" & vbCrLf &
                                     "-Have Fun" & vbCrLf

        'display 
        lblInstructions.Text = strInstructions

    End Sub
End Class