Public Class MultiChoiceBox

    ''' <summary>
    ''' Obtient la liste avec les boutons.
    ''' </summary>
    Private ButtonsList As New List(Of Button)

    ''' <summary>
    ''' Obtient la liste avec les descriptions des boutons.
    ''' </summary>
    Private DescriptionsList As New List(Of String)

    ''' <summary>
    ''' Obtient le bouton actuellement sélectionné
    ''' </summary>
    Private CurrentButton As New Button

    Private _message As String
    Property Message() As String
        Get
            Return _message
        End Get
        Set(ByVal Value As String)
            _message = Value
            MessageLabel.Text = _message
        End Set
    End Property

    Private _textColor As Color
    Property TextColor() As Color
        Get
            Return _textColor
        End Get
        Set(value As Color)
            _textColor = value
            MessageLabel.ForeColor = _textColor
            DescriptionLabel.ForeColor = _textColor
            If ButtonsList.Count > 0 Then
                For i = 0 To ButtonsList.Count - 1
                    ButtonsList(i).ForeColor = _textColor
                Next
            End If
        End Set
    End Property

    Private _mybackcolor As Color
    Overloads Property MyBackColor() As Color
        Get
            Return _mybackcolor
        End Get
        Set(value As Color)
            _mybackcolor = value
            BackColor = _mybackcolor
        End Set
    End Property

    Private _selectedButtonColor As Color
    Public Property SelectedButtonColor() As Color
        Get
            Return _selectedButtonColor
        End Get
        Set(ByVal value As Color)
            _selectedButtonColor = value
            CurrentButton.BackColor = _selectedButtonColor
        End Set
    End Property

#Region "Initialisation"

    Sub New()
        InitializeComponent()
        ButtonsList = New List(Of Button)
        DescriptionsList = New List(Of String)
        InitializePanel()
    End Sub

    ''' <summary>
    ''' Ajoute un bouton à cette instance.
    ''' </summary>
    ''' <param name="button">Le nouveau couton à afficher.</param>
    ''' <param name="description">Optionnel : La description à afficher lorsque l'utilisateur clique sur ce bouton.</param>
    Public Sub AddButton(button As Button, Optional description As String = "")
        button.Dock = DockStyle.Fill
        button.ForeColor = TextColor
        button.BackColor = BackColor
        button.Font = Font
        ButtonsList.Add(button)
        DescriptionsList.Add(description)
        AddHandler button.Click, AddressOf MyButtonClicked
        InitializePanel()
    End Sub

    ''' <summary>
    ''' Rafraichit cette instance pour afficher les boutons en mémoires
    ''' </summary>
    Private Sub InitializePanel()
        ButtonsTableLayoutPanel.Controls.Clear()
        ButtonsTableLayoutPanel.ColumnCount = buttonsList.Count + 2
        ButtonsTableLayoutPanel.Controls.Add(MessageLabel, 0, 0)
        ButtonsTableLayoutPanel.ColumnStyles.Insert(0, New ColumnStyle(SizeType.Absolute, 200))
        For i = 1 To buttonsList.Count
            ButtonsTableLayoutPanel.Controls.Add(buttonsList(i - 1), i, 0)
            ButtonsTableLayoutPanel.ColumnStyles.Insert(i, New ColumnStyle(SizeType.Percent, 360 / buttonsList.Count))
        Next
        ButtonsTableLayoutPanel.Controls.Add(DescriptionLabel, buttonsList.Count + 1, 0)
        ButtonsTableLayoutPanel.ColumnStyles.Insert(buttonsList.Count + 1, New ColumnStyle(SizeType.Absolute, 200))
    End Sub

#End Region

    ''' <summary>
    ''' Sélectionne un bouton
    ''' </summary>
    ''' <param name="button">Le bouton à sélectionner</param>
    Public Sub SelectButton(button As Button)
        Dim methods = New Methods
        CurrentButton.BackColor = BackColor
        CurrentButton = button
        CurrentButton.BackColor = SelectedButtonColor
        DescriptionLabel.Text = DescriptionsList(ButtonsList.IndexOf(button))
    End Sub

#Region "Evènements internes"

    ''' <summary>
    ''' Se produit après qu'un bouton ait été sélectionné
    ''' </summary>
    ''' <param name="button"></param>
    Public Event ButtonClicked(button As Button)

    Private Sub MyButtonClicked(sender As Button, e As EventArgs)
        RaiseEvent ButtonClicked(sender)
    End Sub

#End Region

End Class

