<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Game_Screen
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
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.lblX = New System.Windows.Forms.Label()
        Me.lblY = New System.Windows.Forms.Label()
        Me.lblF = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnMenu
        '
        Me.btnMenu.Location = New System.Drawing.Point(897, 12)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(75, 23)
        Me.btnMenu.TabIndex = 0
        Me.btnMenu.Text = "Menu"
        Me.btnMenu.UseVisualStyleBackColor = True
        '
        'btnEnd
        '
        Me.btnEnd.Location = New System.Drawing.Point(897, 41)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(75, 23)
        Me.btnEnd.TabIndex = 2
        Me.btnEnd.Text = "Exit Game"
        Me.btnEnd.UseVisualStyleBackColor = True
        '
        'lblX
        '
        Me.lblX.AutoSize = True
        Me.lblX.Location = New System.Drawing.Point(12, 9)
        Me.lblX.Name = "lblX"
        Me.lblX.Size = New System.Drawing.Size(39, 13)
        Me.lblX.TabIndex = 3
        Me.lblX.Text = "Label1"
        '
        'lblY
        '
        Me.lblY.AutoSize = True
        Me.lblY.Location = New System.Drawing.Point(12, 22)
        Me.lblY.Name = "lblY"
        Me.lblY.Size = New System.Drawing.Size(39, 13)
        Me.lblY.TabIndex = 4
        Me.lblY.Text = "Label2"
        '
        'lblF
        '
        Me.lblF.AutoSize = True
        Me.lblF.Location = New System.Drawing.Point(12, 35)
        Me.lblF.Name = "lblF"
        Me.lblF.Size = New System.Drawing.Size(39, 13)
        Me.lblF.TabIndex = 5
        Me.lblF.Text = "Label2"
        '
        'Game_Screen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(980, 260)
        Me.Controls.Add(Me.lblF)
        Me.Controls.Add(Me.lblY)
        Me.Controls.Add(Me.lblX)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.btnMenu)
        Me.KeyPreview = True
        Me.Name = "Game_Screen"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnMenu As System.Windows.Forms.Button
    Friend WithEvents btnEnd As System.Windows.Forms.Button
    Friend WithEvents lblX As System.Windows.Forms.Label
    Friend WithEvents lblY As System.Windows.Forms.Label
    Friend WithEvents lblF As System.Windows.Forms.Label

End Class
