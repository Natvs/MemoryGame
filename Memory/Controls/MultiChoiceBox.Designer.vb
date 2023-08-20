<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MultiChoiceBox
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
        Me.MessageLabel = New System.Windows.Forms.Label()
        Me.DescriptionLabel = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ButtonsTableLayoutPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonsTableLayoutPanel
        '
        Me.ButtonsTableLayoutPanel.AutoSize = True
        Me.ButtonsTableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ButtonsTableLayoutPanel.ColumnCount = 3
        Me.ButtonsTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.ButtonsTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.ButtonsTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.ButtonsTableLayoutPanel.Controls.Add(Me.MessageLabel, 0, 0)
        Me.ButtonsTableLayoutPanel.Controls.Add(Me.DescriptionLabel, 2, 0)
        Me.ButtonsTableLayoutPanel.Controls.Add(Me.Button1, 1, 0)
        Me.ButtonsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonsTableLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.ButtonsTableLayoutPanel.Name = "ButtonsTableLayoutPanel"
        Me.ButtonsTableLayoutPanel.RowCount = 1
        Me.ButtonsTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.ButtonsTableLayoutPanel.Size = New System.Drawing.Size(458, 47)
        Me.ButtonsTableLayoutPanel.TabIndex = 1
        '
        'MessageLabel
        '
        Me.MessageLabel.AutoSize = True
        Me.MessageLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MessageLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MessageLabel.Location = New System.Drawing.Point(3, 0)
        Me.MessageLabel.Name = "MessageLabel"
        Me.MessageLabel.Size = New System.Drawing.Size(93, 47)
        Me.MessageLabel.TabIndex = 0
        Me.MessageLabel.Text = "Message"
        Me.MessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DescriptionLabel
        '
        Me.DescriptionLabel.AutoSize = True
        Me.DescriptionLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DescriptionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescriptionLabel.Location = New System.Drawing.Point(346, 0)
        Me.DescriptionLabel.Name = "DescriptionLabel"
        Me.DescriptionLabel.Size = New System.Drawing.Size(109, 47)
        Me.DescriptionLabel.TabIndex = 1
        Me.DescriptionLabel.Text = "Description"
        Me.DescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(102, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(238, 41)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Bouton d'exemple"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'MultiButtonBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Controls.Add(Me.ButtonsTableLayoutPanel)
        Me.Name = "MultiButtonBox"
        Me.Size = New System.Drawing.Size(458, 47)
        Me.ButtonsTableLayoutPanel.ResumeLayout(False)
        Me.ButtonsTableLayoutPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonsTableLayoutPanel As TableLayoutPanel
    Friend WithEvents MessageLabel As Label
    Friend WithEvents DescriptionLabel As Label
    Friend WithEvents Button1 As Button
End Class
