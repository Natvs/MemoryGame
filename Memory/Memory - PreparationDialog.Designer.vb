<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Memory_Preparation
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.StartTableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.PackMultiButtonBox = New MultiChoiceBox()
        Me.ColumnSelectValueBox = New SelectValueBox()
        Me.CardsColorButton = New System.Windows.Forms.Button()
        Me.PicturesColorButton = New System.Windows.Forms.Button()
        Me.ChronoButton = New System.Windows.Forms.Button()
        Me.GameTimeSelectValueBox = New SelectValueBox()
        Me.OkButton = New System.Windows.Forms.Button()
        Me.RowSelectValueBox = New SelectValueBox()
        Me.LevelMultiButtonBox = New MultiChoiceBox()
        Me.StartTableLayoutPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'StartTableLayoutPanel
        '
        Me.StartTableLayoutPanel.AutoSize = True
        Me.StartTableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.StartTableLayoutPanel.ColumnCount = 4
        Me.StartTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.StartTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.StartTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.StartTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.StartTableLayoutPanel.Controls.Add(Me.PackMultiButtonBox, 0, 1)
        Me.StartTableLayoutPanel.Controls.Add(Me.ColumnSelectValueBox, 2, 4)
        Me.StartTableLayoutPanel.Controls.Add(Me.CardsColorButton, 0, 2)
        Me.StartTableLayoutPanel.Controls.Add(Me.PicturesColorButton, 2, 2)
        Me.StartTableLayoutPanel.Controls.Add(Me.ChronoButton, 0, 3)
        Me.StartTableLayoutPanel.Controls.Add(Me.GameTimeSelectValueBox, 2, 3)
        Me.StartTableLayoutPanel.Controls.Add(Me.OkButton, 0, 5)
        Me.StartTableLayoutPanel.Controls.Add(Me.RowSelectValueBox, 0, 4)
        Me.StartTableLayoutPanel.Controls.Add(Me.LevelMultiButtonBox, 0, 0)
        Me.StartTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StartTableLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.StartTableLayoutPanel.Name = "StartTableLayoutPanel"
        Me.StartTableLayoutPanel.RowCount = 6
        Me.StartTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.StartTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.StartTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.StartTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.StartTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.StartTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.StartTableLayoutPanel.Size = New System.Drawing.Size(884, 525)
        Me.StartTableLayoutPanel.TabIndex = 0
        '
        'PackMultiButtonBox
        '
        Me.PackMultiButtonBox.AutoSize = True
        Me.PackMultiButtonBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.StartTableLayoutPanel.SetColumnSpan(Me.PackMultiButtonBox, 4)
        Me.PackMultiButtonBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PackMultiButtonBox.Location = New System.Drawing.Point(3, 56)
        Me.PackMultiButtonBox.Name = "PackMultiButtonBox"
        Me.PackMultiButtonBox.Size = New System.Drawing.Size(878, 47)
        Me.PackMultiButtonBox.TabIndex = 16
        '
        'ColumnSelectValueBox
        '
        Me.ColumnSelectValueBox.AutoSize = True
        Me.ColumnSelectValueBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.StartTableLayoutPanel.SetColumnSpan(Me.ColumnSelectValueBox, 2)
        Me.ColumnSelectValueBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ColumnSelectValueBox.Location = New System.Drawing.Point(445, 343)
        Me.ColumnSelectValueBox.Name = "ColumnSelectValueBox"
        Me.ColumnSelectValueBox.Size = New System.Drawing.Size(436, 62)
        Me.ColumnSelectValueBox.TabIndex = 14
        '
        'CardsColorButton
        '
        Me.StartTableLayoutPanel.SetColumnSpan(Me.CardsColorButton, 2)
        Me.CardsColorButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CardsColorButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CardsColorButton.Location = New System.Drawing.Point(3, 109)
        Me.CardsColorButton.Name = "CardsColorButton"
        Me.CardsColorButton.Size = New System.Drawing.Size(436, 111)
        Me.CardsColorButton.TabIndex = 8
        Me.CardsColorButton.Text = "Couleur des cartes"
        Me.CardsColorButton.UseVisualStyleBackColor = False
        '
        'PicturesColorButton
        '
        Me.StartTableLayoutPanel.SetColumnSpan(Me.PicturesColorButton, 2)
        Me.PicturesColorButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PicturesColorButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PicturesColorButton.Location = New System.Drawing.Point(445, 109)
        Me.PicturesColorButton.Name = "PicturesColorButton"
        Me.PicturesColorButton.Size = New System.Drawing.Size(436, 111)
        Me.PicturesColorButton.TabIndex = 9
        Me.PicturesColorButton.Text = "Couleur des images"
        Me.PicturesColorButton.UseVisualStyleBackColor = False
        '
        'ChronoButton
        '
        Me.StartTableLayoutPanel.SetColumnSpan(Me.ChronoButton, 2)
        Me.ChronoButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChronoButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChronoButton.Location = New System.Drawing.Point(3, 226)
        Me.ChronoButton.Name = "ChronoButton"
        Me.ChronoButton.Size = New System.Drawing.Size(436, 111)
        Me.ChronoButton.TabIndex = 10
        Me.ChronoButton.Text = "Chronomètre"
        Me.ChronoButton.UseVisualStyleBackColor = False
        '
        'GameTimeSelectValueBox
        '
        Me.GameTimeSelectValueBox.AutoSize = True
        Me.GameTimeSelectValueBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.StartTableLayoutPanel.SetColumnSpan(Me.GameTimeSelectValueBox, 2)
        Me.GameTimeSelectValueBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GameTimeSelectValueBox.Location = New System.Drawing.Point(445, 226)
        Me.GameTimeSelectValueBox.Name = "GameTimeSelectValueBox"
        Me.GameTimeSelectValueBox.Size = New System.Drawing.Size(436, 111)
        Me.GameTimeSelectValueBox.TabIndex = 12
        '
        'OkButton
        '
        Me.StartTableLayoutPanel.SetColumnSpan(Me.OkButton, 4)
        Me.OkButton.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.OkButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OkButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OkButton.Location = New System.Drawing.Point(3, 411)
        Me.OkButton.Name = "OkButton"
        Me.OkButton.Size = New System.Drawing.Size(878, 111)
        Me.OkButton.TabIndex = 11
        Me.OkButton.Text = "Valider"
        Me.OkButton.UseVisualStyleBackColor = False
        '
        'RowSelectValueBox
        '
        Me.RowSelectValueBox.AutoSize = True
        Me.RowSelectValueBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.StartTableLayoutPanel.SetColumnSpan(Me.RowSelectValueBox, 2)
        Me.RowSelectValueBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RowSelectValueBox.Location = New System.Drawing.Point(3, 343)
        Me.RowSelectValueBox.Name = "RowSelectValueBox"
        Me.RowSelectValueBox.Size = New System.Drawing.Size(436, 62)
        Me.RowSelectValueBox.TabIndex = 13
        '
        'LevelMultiButtonBox
        '
        Me.LevelMultiButtonBox.AutoSize = True
        Me.LevelMultiButtonBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.StartTableLayoutPanel.SetColumnSpan(Me.LevelMultiButtonBox, 4)
        Me.LevelMultiButtonBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LevelMultiButtonBox.Location = New System.Drawing.Point(3, 3)
        Me.LevelMultiButtonBox.Name = "LevelMultiButtonBox"
        Me.LevelMultiButtonBox.Size = New System.Drawing.Size(878, 47)
        Me.LevelMultiButtonBox.TabIndex = 17
        '
        'Memory_Preparation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(884, 525)
        Me.ControlBox = False
        Me.Controls.Add(Me.StartTableLayoutPanel)
        Me.Name = "Memory_Preparation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Jeu de mémoire"
        Me.StartTableLayoutPanel.ResumeLayout(False)
        Me.StartTableLayoutPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StartTableLayoutPanel As TableLayoutPanel
    Friend WithEvents OkButton As Button
    Friend WithEvents CardsColorButton As Button
    Friend WithEvents PicturesColorButton As Button
    Friend WithEvents ChronoButton As Button
    Friend WithEvents GameTimeSelectValueBox As SelectValueBox
    Friend WithEvents RowSelectValueBox As SelectValueBox
    Friend WithEvents ColumnSelectValueBox As SelectValueBox
    Friend WithEvents PackMultiButtonBox As MultiChoiceBox
    Friend WithEvents LevelMultiButtonBox As MultiChoiceBox
End Class
