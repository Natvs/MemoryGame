<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Memory_Game
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
        Me.components = New System.ComponentModel.Container()
        Me.MemoryTableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.CardTableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.InfoGameTableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.LeftPairsTableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.LeftPairsNumberLabel = New System.Windows.Forms.Label()
        Me.LeftPairsTextLabel = New System.Windows.Forms.Label()
        Me.FoundPairsTableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.FoundPairsNumberLabel = New System.Windows.Forms.Label()
        Me.FoundPairsTextLabel = New System.Windows.Forms.Label()
        Me.TimeTableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.TimeLeftTextLabel = New System.Windows.Forms.Label()
        Me.TimeLeftLabel = New System.Windows.Forms.Label()
        Me.ShowCardTimer = New System.Windows.Forms.Timer(Me.components)
        Me.GameTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ShowCrossCardTimer = New System.Windows.Forms.Timer(Me.components)
        Me.MemoryTableLayoutPanel.SuspendLayout()
        Me.InfoGameTableLayoutPanel.SuspendLayout()
        Me.LeftPairsTableLayoutPanel.SuspendLayout()
        Me.FoundPairsTableLayoutPanel.SuspendLayout()
        Me.TimeTableLayoutPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'MemoryTableLayoutPanel
        '
        Me.MemoryTableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.MemoryTableLayoutPanel.ColumnCount = 2
        Me.MemoryTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 222.0!))
        Me.MemoryTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.MemoryTableLayoutPanel.Controls.Add(Me.CardTableLayoutPanel, 1, 0)
        Me.MemoryTableLayoutPanel.Controls.Add(Me.InfoGameTableLayoutPanel, 0, 0)
        Me.MemoryTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MemoryTableLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.MemoryTableLayoutPanel.Name = "MemoryTableLayoutPanel"
        Me.MemoryTableLayoutPanel.RowCount = 1
        Me.MemoryTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.MemoryTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.MemoryTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.MemoryTableLayoutPanel.Size = New System.Drawing.Size(819, 612)
        Me.MemoryTableLayoutPanel.TabIndex = 0
        '
        'CardTableLayoutPanel
        '
        Me.CardTableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.CardTableLayoutPanel.ColumnCount = 1
        Me.CardTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.CardTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.CardTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.CardTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.CardTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.CardTableLayoutPanel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CardTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CardTableLayoutPanel.Location = New System.Drawing.Point(227, 4)
        Me.CardTableLayoutPanel.Name = "CardTableLayoutPanel"
        Me.CardTableLayoutPanel.RowCount = 1
        Me.CardTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.CardTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 603.0!))
        Me.CardTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 603.0!))
        Me.CardTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 603.0!))
        Me.CardTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 603.0!))
        Me.CardTableLayoutPanel.Size = New System.Drawing.Size(588, 604)
        Me.CardTableLayoutPanel.TabIndex = 4
        '
        'InfoGameTableLayoutPanel
        '
        Me.InfoGameTableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.InfoGameTableLayoutPanel.ColumnCount = 1
        Me.InfoGameTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.InfoGameTableLayoutPanel.Controls.Add(Me.LeftPairsTableLayoutPanel, 0, 1)
        Me.InfoGameTableLayoutPanel.Controls.Add(Me.FoundPairsTableLayoutPanel, 0, 0)
        Me.InfoGameTableLayoutPanel.Controls.Add(Me.TimeTableLayoutPanel, 0, 2)
        Me.InfoGameTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.InfoGameTableLayoutPanel.Location = New System.Drawing.Point(4, 4)
        Me.InfoGameTableLayoutPanel.Name = "InfoGameTableLayoutPanel"
        Me.InfoGameTableLayoutPanel.RowCount = 3
        Me.InfoGameTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.InfoGameTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.InfoGameTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.InfoGameTableLayoutPanel.Size = New System.Drawing.Size(216, 604)
        Me.InfoGameTableLayoutPanel.TabIndex = 5
        '
        'LeftPairsTableLayoutPanel
        '
        Me.LeftPairsTableLayoutPanel.ColumnCount = 1
        Me.LeftPairsTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.LeftPairsTableLayoutPanel.Controls.Add(Me.LeftPairsNumberLabel, 0, 1)
        Me.LeftPairsTableLayoutPanel.Controls.Add(Me.LeftPairsTextLabel, 0, 0)
        Me.LeftPairsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LeftPairsTableLayoutPanel.Location = New System.Drawing.Point(4, 205)
        Me.LeftPairsTableLayoutPanel.Name = "LeftPairsTableLayoutPanel"
        Me.LeftPairsTableLayoutPanel.RowCount = 2
        Me.LeftPairsTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.LeftPairsTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.LeftPairsTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.LeftPairsTableLayoutPanel.Size = New System.Drawing.Size(208, 194)
        Me.LeftPairsTableLayoutPanel.TabIndex = 9
        '
        'LeftPairsNumberLabel
        '
        Me.LeftPairsNumberLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LeftPairsNumberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LeftPairsNumberLabel.Location = New System.Drawing.Point(3, 58)
        Me.LeftPairsNumberLabel.Name = "LeftPairsNumberLabel"
        Me.LeftPairsNumberLabel.Size = New System.Drawing.Size(202, 136)
        Me.LeftPairsNumberLabel.TabIndex = 2
        Me.LeftPairsNumberLabel.Text = "0"
        Me.LeftPairsNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LeftPairsTextLabel
        '
        Me.LeftPairsTextLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LeftPairsTextLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LeftPairsTextLabel.Location = New System.Drawing.Point(3, 0)
        Me.LeftPairsTextLabel.Name = "LeftPairsTextLabel"
        Me.LeftPairsTextLabel.Size = New System.Drawing.Size(202, 58)
        Me.LeftPairsTextLabel.TabIndex = 1
        Me.LeftPairsTextLabel.Text = "Paires restantes :"
        Me.LeftPairsTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FoundPairsTableLayoutPanel
        '
        Me.FoundPairsTableLayoutPanel.ColumnCount = 1
        Me.FoundPairsTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.FoundPairsTableLayoutPanel.Controls.Add(Me.FoundPairsNumberLabel, 0, 1)
        Me.FoundPairsTableLayoutPanel.Controls.Add(Me.FoundPairsTextLabel, 0, 0)
        Me.FoundPairsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FoundPairsTableLayoutPanel.Location = New System.Drawing.Point(4, 4)
        Me.FoundPairsTableLayoutPanel.Name = "FoundPairsTableLayoutPanel"
        Me.FoundPairsTableLayoutPanel.RowCount = 2
        Me.FoundPairsTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.FoundPairsTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.FoundPairsTableLayoutPanel.Size = New System.Drawing.Size(208, 194)
        Me.FoundPairsTableLayoutPanel.TabIndex = 8
        '
        'FoundPairsNumberLabel
        '
        Me.FoundPairsNumberLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FoundPairsNumberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FoundPairsNumberLabel.Location = New System.Drawing.Point(3, 58)
        Me.FoundPairsNumberLabel.Name = "FoundPairsNumberLabel"
        Me.FoundPairsNumberLabel.Size = New System.Drawing.Size(202, 136)
        Me.FoundPairsNumberLabel.TabIndex = 1
        Me.FoundPairsNumberLabel.Text = "0"
        Me.FoundPairsNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FoundPairsTextLabel
        '
        Me.FoundPairsTextLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FoundPairsTextLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FoundPairsTextLabel.Location = New System.Drawing.Point(3, 0)
        Me.FoundPairsTextLabel.Name = "FoundPairsTextLabel"
        Me.FoundPairsTextLabel.Size = New System.Drawing.Size(202, 58)
        Me.FoundPairsTextLabel.TabIndex = 0
        Me.FoundPairsTextLabel.Text = "Paires trouvées :"
        Me.FoundPairsTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TimeTableLayoutPanel
        '
        Me.TimeTableLayoutPanel.ColumnCount = 1
        Me.TimeTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TimeTableLayoutPanel.Controls.Add(Me.TimeLeftTextLabel, 0, 0)
        Me.TimeTableLayoutPanel.Controls.Add(Me.TimeLeftLabel, 0, 1)
        Me.TimeTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TimeTableLayoutPanel.Location = New System.Drawing.Point(4, 406)
        Me.TimeTableLayoutPanel.Name = "TimeTableLayoutPanel"
        Me.TimeTableLayoutPanel.RowCount = 2
        Me.TimeTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TimeTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.TimeTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TimeTableLayoutPanel.Size = New System.Drawing.Size(208, 194)
        Me.TimeTableLayoutPanel.TabIndex = 10
        '
        'TimeLeftTextLabel
        '
        Me.TimeLeftTextLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TimeLeftTextLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeLeftTextLabel.Location = New System.Drawing.Point(3, 0)
        Me.TimeLeftTextLabel.Name = "TimeLeftTextLabel"
        Me.TimeLeftTextLabel.Size = New System.Drawing.Size(202, 58)
        Me.TimeLeftTextLabel.TabIndex = 8
        Me.TimeLeftTextLabel.Text = "Temps restant :"
        Me.TimeLeftTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TimeLeftLabel
        '
        Me.TimeLeftLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TimeLeftLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeLeftLabel.Location = New System.Drawing.Point(3, 58)
        Me.TimeLeftLabel.Name = "TimeLeftLabel"
        Me.TimeLeftLabel.Size = New System.Drawing.Size(202, 136)
        Me.TimeLeftLabel.TabIndex = 7
        Me.TimeLeftLabel.Text = "0"
        Me.TimeLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ShowCardTimer
        '
        Me.ShowCardTimer.Interval = 1000
        '
        'GameTimer
        '
        Me.GameTimer.Interval = 1000
        '
        'ShowCrossCardTimer
        '
        Me.ShowCrossCardTimer.Interval = 1000
        '
        'Memory_Game
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(819, 612)
        Me.Controls.Add(Me.MemoryTableLayoutPanel)
        Me.Name = "Memory_Game"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Jeu de mémoire"
        Me.MemoryTableLayoutPanel.ResumeLayout(False)
        Me.InfoGameTableLayoutPanel.ResumeLayout(False)
        Me.LeftPairsTableLayoutPanel.ResumeLayout(False)
        Me.FoundPairsTableLayoutPanel.ResumeLayout(False)
        Me.TimeTableLayoutPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MemoryTableLayoutPanel As TableLayoutPanel
    Friend WithEvents ShowCardTimer As Timer
    Friend WithEvents CardTableLayoutPanel As TableLayoutPanel
    Friend WithEvents GameTimer As Timer
    Friend WithEvents ShowCrossCardTimer As Timer
    Friend WithEvents InfoGameTableLayoutPanel As TableLayoutPanel
    Friend WithEvents LeftPairsTableLayoutPanel As TableLayoutPanel
    Friend WithEvents LeftPairsNumberLabel As Label
    Friend WithEvents LeftPairsTextLabel As Label
    Friend WithEvents FoundPairsTableLayoutPanel As TableLayoutPanel
    Friend WithEvents FoundPairsNumberLabel As Label
    Friend WithEvents FoundPairsTextLabel As Label
    Friend WithEvents TimeLeftLabel As Label
    Friend WithEvents TimeTableLayoutPanel As TableLayoutPanel
    Friend WithEvents TimeLeftTextLabel As Label
End Class
