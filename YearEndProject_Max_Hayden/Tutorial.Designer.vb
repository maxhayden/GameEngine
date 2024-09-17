<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tutorial
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
        Me.btnDrawing = New System.Windows.Forms.Button()
        Me.btnGame = New System.Windows.Forms.Button()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnDrawing
        '
        Me.btnDrawing.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDrawing.Location = New System.Drawing.Point(12, 12)
        Me.btnDrawing.Name = "btnDrawing"
        Me.btnDrawing.Size = New System.Drawing.Size(120, 50)
        Me.btnDrawing.TabIndex = 0
        Me.btnDrawing.Text = "Map Design Instructions"
        Me.btnDrawing.UseVisualStyleBackColor = True
        '
        'btnGame
        '
        Me.btnGame.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGame.Location = New System.Drawing.Point(138, 12)
        Me.btnGame.Name = "btnGame"
        Me.btnGame.Size = New System.Drawing.Size(120, 50)
        Me.btnGame.TabIndex = 1
        Me.btnGame.Text = "Game Instructions"
        Me.btnGame.UseVisualStyleBackColor = True
        '
        'lblInstructions
        '
        Me.lblInstructions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblInstructions.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions.Location = New System.Drawing.Point(13, 69)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(245, 228)
        Me.lblInstructions.TabIndex = 2
        Me.lblInstructions.Text = " Map Design Instructions"
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(98, 300)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(76, 25)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Menu"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Tutorial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(276, 337)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.btnGame)
        Me.Controls.Add(Me.btnDrawing)
        Me.Name = "Tutorial"
        Me.Text = "Tutorial"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnDrawing As System.Windows.Forms.Button
    Friend WithEvents btnGame As System.Windows.Forms.Button
    Friend WithEvents lblInstructions As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
End Class
