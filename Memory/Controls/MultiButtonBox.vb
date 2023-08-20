''' <summary>
''' Contrôle permettant d'afficher plusieurs boutons
''' </summary>
Public Class MultiButtonBox

    ''' <summary>
    ''' Obtient la liste contenant les boutons
    ''' </summary>
    Private buttonsList As List(Of Button)

    ''' <summary>
    ''' Obtient la couleur du bouton
    ''' </summary>
    Private buttonColor As Color

    ''' <summary>
    ''' Obtient la couleur du texte du bouton
    ''' </summary>
    Private textColor As Color

    ''' <summary>
    ''' Obtient la taille du texte
    ''' </summary>
    Private textSize As Integer

#Region "Initialisation"

    ''' <summary>
    ''' Initialise le contrôle
    ''' </summary>
    ''' <param name="button"></param>
    Public Sub Initialize(button As Button, buttonColor As Color, textColor As Color, textSize As Integer)
        Me.buttonColor = buttonColor
        Me.textColor = textColor
        Me.textSize = textSize

        buttonsList = New List(Of Button)
        ButtonsTableLayoutPanel.Controls.Clear()

        AddButton(button)
    End Sub

    ''' <summary>
    ''' Ajoute un bouton à cette instance.
    ''' </summary>
    ''' <param name="button">Le nouveau bouton à afficher.</param>
    Public Sub AddButton(button As Button)
        button.Dock = DockStyle.Fill
        button.ForeColor = textColor
        button.BackColor = buttonColor
        button.Font = New Font(FontFamily.GenericSansSerif, textSize)
        AddHandler button.Click, AddressOf WhenButtonClicked
        buttonsList.Add(button)
        InitializePanel()
    End Sub

    ''' <summary>
    ''' Initialise le panneau contenant les boutons
    ''' </summary>
    Private Sub InitializePanel()
        ButtonsTableLayoutPanel.ColumnCount = buttonsList.Count
        For buttonIndex = 1 To buttonsList.Count
            ButtonsTableLayoutPanel.ColumnStyles.Insert(buttonIndex - 1, New ColumnStyle(SizeType.Percent, 100 / buttonsList.Count))
            ButtonsTableLayoutPanel.Controls.Add(buttonsList(buttonIndex - 1), buttonIndex - 1, 0)
        Next
    End Sub

#End Region

    ''' <summary>
    ''' Se produit quand un bouton est cliqué
    ''' </summary>
    ''' <param name="button"></param>
    Public Event ButtonClicked(button As Button, e As EventArgs)

    ''' <summary>
    ''' Quand un bouton est cliqué
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub WhenButtonClicked(sender As Button, e As EventArgs)
        RaiseEvent ButtonClicked(sender, e)
    End Sub

End Class
