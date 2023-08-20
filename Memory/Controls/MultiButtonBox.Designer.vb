<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MultiButtonBox
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
        Me.ButtonsTableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.ExempleButton = New System.Windows.Forms.Button()
        Me.ButtonsTableLayoutPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonsTableLayoutPanel
        '
        Me.ButtonsTableLayoutPanel.AutoSize = True
        Me.ButtonsTableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ButtonsTableLayoutPanel.ColumnCount = 1
        Me.ButtonsTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.ButtonsTableLayoutPanel.Controls.Add(Me.ExempleButton, 0, 0)
        Me.ButtonsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonsTableLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.ButtonsTableLayoutPanel.Name = "ButtonsTableLayoutPanel"
        Me.ButtonsTableLayoutPanel.RowCount = 1
        Me.ButtonsTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.ButtonsTableLayoutPanel.Size = New System.Drawing.Size(280, 77)
        Me.ButtonsTableLayoutPanel.TabIndex = 0
        '
        'ExempleButton
        '
        Me.ExempleButton.AutoSize = True
        Me.ExempleButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ExempleButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ExempleButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExempleButton.Location = New System.Drawing.Point(3, 3)
        Me.ExempleButton.Name = "ExempleButton"
        Me.ExempleButton.Size = New System.Drawing.Size(274, 71)
        Me.ExempleButton.TabIndex = 0
        Me.ExempleButton.Text = "Bouton d'exemple"
        Me.ExempleButton.UseVisualStyleBackColor = False
        '
        'MultiButtonBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Controls.Add(Me.ButtonsTableLayoutPanel)
        Me.Name = "MultiButtonBox"
        Me.Size = New System.Drawing.Size(280, 77)
        Me.ButtonsTableLayoutPanel.ResumeLayout(False)
        Me.ButtonsTableLayoutPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonsTableLayoutPanel As TableLayoutPanel
    Friend WithEvents ExempleButton As Button
End Class
