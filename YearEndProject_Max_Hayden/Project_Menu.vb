Public Class Project_Menu

    'OPEN MAP DESIGNER
    Private Sub btnDesign_Click(sender As System.Object, e As System.EventArgs) Handles btnDesign.Click

        'Run Designer 
        btnDesign.Enabled = False
        btnPlay.Enabled = True

        Me.Hide()
        frmMap_Maker.Show()

    End Sub

    'OPEN GAME
    Private Sub btnPlay_Click(sender As System.Object, e As System.EventArgs) Handles btnPlay.Click

        'run Game
        Me.Hide()
        Game_Screen.Show()

    End Sub

    'OPEN TUTORIAL
    Private Sub btnTutorial_Click(sender As System.Object, e As System.EventArgs) Handles btnTutorial.Click

        'Open tutorial
        Hide()
        Tutorial.Show()

    End Sub

    'EXIT GAME
    Private Sub btnEnd_Click(sender As System.Object, e As System.EventArgs) Handles btnEnd.Click

        'end game
        End

    End Sub

End Class
'**************************************'
'                                      '
' Project: Map Designer                '
' Name: Max Hayden                     '
'                                      '
' Start Date: 07/01/2019               '
' End Date:                            '
'                                      '
' Purpose: This is a program where     '
'          the user is able to design  '
'          a map and is able to play   '
'          that map                    '
'                                      '
'**************************************'