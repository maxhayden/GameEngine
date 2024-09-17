<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Project_Menu
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnDesign = New System.Windows.Forms.Button()
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.btnTutorial = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(15, 8)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(182, 31)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Map Designer"
        '
        'btnDesign
        '
        Me.btnDesign.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDesign.Location = New System.Drawing.Point(30, 49)
        Me.btnDesign.Name = "btnDesign"
        Me.btnDesign.Size = New System.Drawing.Size(132, 37)
        Me.btnDesign.TabIndex = 1
        Me.btnDesign.Text = "Design a Map"
        Me.btnDesign.UseVisualStyleBackColor = True
        '
        'btnPlay
        '
        Me.btnPlay.Enabled = False
        Me.btnPlay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlay.Location = New System.Drawing.Point(30, 92)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(132, 37)
        Me.btnPlay.TabIndex = 2
        Me.btnPlay.Text = "Play Game"
        Me.btnPlay.UseVisualStyleBackColor = True
        '
        'btnEnd
        '
        Me.btnEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnEnd.Location = New System.Drawing.Point(30, 178)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(132, 37)
        Me.btnEnd.TabIndex = 3
        Me.btnEnd.Text = "Exit Game"
        Me.btnEnd.UseVisualStyleBackColor = True
        '
        'btnTutorial
        '
        Me.btnTutorial.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnTutorial.Location = New System.Drawing.Point(30, 135)
        Me.btnTutorial.Name = "btnTutorial"
        Me.btnTutorial.Size = New System.Drawing.Size(132, 37)
        Me.btnTutorial.TabIndex = 4
        Me.btnTutorial.Text = "Tutorial"
        Me.btnTutorial.UseVisualStyleBackColor = True
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(39, 220)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(123, 26)
        Me.lblName.TabIndex = 5
        Me.lblName.Text = "Max Hayden" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Computer Programing 12"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Project_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(196, 255)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnTutorial)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.btnPlay)
        Me.Controls.Add(Me.btnDesign)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "Project_Menu"
        Me.Text = "Project_Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents btnDesign As System.Windows.Forms.Button
    Friend WithEvents btnPlay As System.Windows.Forms.Button
    Friend WithEvents btnEnd As System.Windows.Forms.Button
    Friend WithEvents btnTutorial As System.Windows.Forms.Button
    Friend WithEvents lblName As System.Windows.Forms.Label
End Class
