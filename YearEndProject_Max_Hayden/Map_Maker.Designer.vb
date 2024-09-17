<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMap_Maker
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
        Me.btnDraw = New System.Windows.Forms.Button()
        Me.btnErase = New System.Windows.Forms.Button()
        Me.btnEndFlag = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.btnEnd.TabIndex = 1
        Me.btnEnd.Text = "Exit Game"
        Me.btnEnd.UseVisualStyleBackColor = True
        '
        'btnDraw
        '
        Me.btnDraw.BackgroundImage = Global.YearEndProject_Max_Hayden.My.Resources.Resources.download
        Me.btnDraw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDraw.Location = New System.Drawing.Point(779, 12)
        Me.btnDraw.Name = "btnDraw"
        Me.btnDraw.Size = New System.Drawing.Size(30, 30)
        Me.btnDraw.TabIndex = 2
        Me.btnDraw.UseVisualStyleBackColor = True
        '
        'btnErase
        '
        Me.btnErase.BackgroundImage = Global.YearEndProject_Max_Hayden.My.Resources.Resources.Eraser
        Me.btnErase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnErase.Location = New System.Drawing.Point(815, 12)
        Me.btnErase.Name = "btnErase"
        Me.btnErase.Size = New System.Drawing.Size(30, 30)
        Me.btnErase.TabIndex = 3
        Me.btnErase.UseVisualStyleBackColor = True
        '
        'btnEndFlag
        '
        Me.btnEndFlag.BackgroundImage = Global.YearEndProject_Max_Hayden.My.Resources.Resources.flag
        Me.btnEndFlag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEndFlag.Location = New System.Drawing.Point(851, 12)
        Me.btnEndFlag.Name = "btnEndFlag"
        Me.btnEndFlag.Size = New System.Drawing.Size(30, 30)
        Me.btnEndFlag.TabIndex = 4
        Me.btnEndFlag.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Label1"
        '
        'frmMap_Maker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(980, 260)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnEndFlag)
        Me.Controls.Add(Me.btnErase)
        Me.Controls.Add(Me.btnDraw)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.btnMenu)
        Me.Name = "frmMap_Maker"
        Me.Text = "MapMaker"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnMenu As System.Windows.Forms.Button
    Friend WithEvents btnEnd As System.Windows.Forms.Button
    Friend WithEvents btnDraw As System.Windows.Forms.Button
    Friend WithEvents btnErase As System.Windows.Forms.Button
    Friend WithEvents btnEndFlag As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
