<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectValueBox
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
        Me.MainTableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.NextButton = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.ValueLabel = New System.Windows.Forms.Label()
        Me.MainTableLayoutPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainTableLayoutPanel
        '
        Me.MainTableLayoutPanel.AutoSize = True
        Me.MainTableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MainTableLayoutPanel.ColumnCount = 3
        Me.MainTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.MainTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.MainTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.MainTableLayoutPanel.Controls.Add(Me.NextButton, 2, 0)
        Me.MainTableLayoutPanel.Controls.Add(Me.BackButton, 0, 0)
        Me.MainTableLayoutPanel.Controls.Add(Me.ValueLabel, 1, 0)
        Me.MainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainTableLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.MainTableLayoutPanel.Name = "MainTableLayoutPanel"
        Me.MainTableLayoutPanel.RowCount = 1
        Me.MainTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.MainTableLayoutPanel.Size = New System.Drawing.Size(236, 62)
        Me.MainTableLayoutPanel.TabIndex = 13
        '
        'NextButton
        '
        Me.NextButton.AutoSize = True
        Me.NextButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.NextButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NextButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NextButton.Location = New System.Drawing.Point(180, 3)
        Me.NextButton.Name = "NextButton"
        Me.NextButton.Size = New System.Drawing.Size(53, 56)
        Me.NextButton.TabIndex = 2
        Me.NextButton.Text = ">"
        Me.NextButton.UseVisualStyleBackColor = False
        '
        'BackButton
        '
        Me.BackButton.AutoSize = True
        Me.BackButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BackButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackButton.Location = New System.Drawing.Point(3, 3)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(53, 56)
        Me.BackButton.TabIndex = 0
        Me.BackButton.Text = "<"
        Me.BackButton.UseVisualStyleBackColor = False
        '
        'ValueLabel
        '
        Me.ValueLabel.AutoSize = True
        Me.ValueLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ValueLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ValueLabel.Location = New System.Drawing.Point(62, 0)
        Me.ValueLabel.Name = "ValueLabel"
        Me.ValueLabel.Size = New System.Drawing.Size(112, 62)
        Me.ValueLabel.TabIndex = 3
        Me.ValueLabel.Text = "Valeur"
        Me.ValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SelectValueBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Controls.Add(Me.MainTableLayoutPanel)
        Me.Name = "SelectValueBox"
        Me.Size = New System.Drawing.Size(236, 62)
        Me.MainTableLayoutPanel.ResumeLayout(False)
        Me.MainTableLayoutPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MainTableLayoutPanel As TableLayoutPanel
    Friend WithEvents NextButton As Button
    Friend WithEvents BackButton As Button
    Friend WithEvents ValueLabel As Label
End Class
