<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MemoryCard
    Inherits System.Windows.Forms.UserControl

    'UserControl remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PictureLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'PictureLabel
        '
        Me.PictureLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureLabel.Font = New System.Drawing.Font("Wingdings", 50.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PictureLabel.Location = New System.Drawing.Point(0, 0)
        Me.PictureLabel.Name = "PictureLabel"
        Me.PictureLabel.Size = New System.Drawing.Size(100, 100)
        Me.PictureLabel.TabIndex = 0
        Me.PictureLabel.Text = "a"
        Me.PictureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MemoryCard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PictureLabel)
        Me.Name = "MemoryCard"
        Me.Size = New System.Drawing.Size(100, 100)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureLabel As Label
End Class
