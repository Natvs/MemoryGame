<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MessageDialog
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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
        Me.MessageLabel = New System.Windows.Forms.Label()
        Me.OkButton = New System.Windows.Forms.Button()
        Me.MessageTableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.MessageTableLayoutPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'MessageLabel
        '
        Me.MessageLabel.AutoSize = True
        Me.MessageLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MessageLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MessageLabel.Location = New System.Drawing.Point(4, 0)
        Me.MessageLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MessageLabel.Name = "MessageLabel"
        Me.MessageLabel.Size = New System.Drawing.Size(700, 46)
        Me.MessageLabel.TabIndex = 0
        Me.MessageLabel.Text = "Message"
        Me.MessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'OkButton
        '
        Me.OkButton.AutoSize = True
        Me.OkButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.OkButton.BackColor = System.Drawing.Color.White
        Me.OkButton.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.OkButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OkButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OkButton.Location = New System.Drawing.Point(4, 51)
        Me.OkButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.OkButton.Name = "OkButton"
        Me.OkButton.Size = New System.Drawing.Size(700, 75)
        Me.OkButton.TabIndex = 1
        Me.OkButton.Text = "OK"
        Me.OkButton.UseVisualStyleBackColor = False
        '
        'MessageTableLayoutPanel
        '
        Me.MessageTableLayoutPanel.AutoSize = True
        Me.MessageTableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MessageTableLayoutPanel.ColumnCount = 1
        Me.MessageTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.MessageTableLayoutPanel.Controls.Add(Me.MessageLabel, 0, 0)
        Me.MessageTableLayoutPanel.Controls.Add(Me.OkButton, 0, 1)
        Me.MessageTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MessageTableLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.MessageTableLayoutPanel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MessageTableLayoutPanel.Name = "MessageTableLayoutPanel"
        Me.MessageTableLayoutPanel.RowCount = 2
        Me.MessageTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.MessageTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.MessageTableLayoutPanel.Size = New System.Drawing.Size(708, 131)
        Me.MessageTableLayoutPanel.TabIndex = 1
        '
        'MessageDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.CancelButton = Me.OkButton
        Me.ClientSize = New System.Drawing.Size(708, 131)
        Me.ControlBox = False
        Me.Controls.Add(Me.MessageTableLayoutPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MessageDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Message"
        Me.MessageTableLayoutPanel.ResumeLayout(False)
        Me.MessageTableLayoutPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MessageLabel As Label
    Friend WithEvents OkButton As Button
    Friend WithEvents MessageTableLayoutPanel As TableLayoutPanel
End Class
