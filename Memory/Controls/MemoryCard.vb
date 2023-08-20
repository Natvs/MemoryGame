''' <summary>
''' Instance représentant une carte pour le jeu de mémoire
''' </summary>
Public Class MemoryCard

    ''' <summary>
    ''' Obtient la couleur de la carte
    ''' </summary>
    Private cardColor As Color

    ''' <summary>
    ''' Obtient la couleur de l'image de la carte
    ''' </summary>
    Private pictureColor As Color

    ''' <summary>
    ''' Obtient le caractère qui représente l'image de la carte
    ''' </summary>
    Private pictureChar As Char

    ''' <summary>
    ''' Initilalise une nouvelle carte. Par défaut, la carte est retournée face cachée.
    ''' </summary>
    ''' <param name="police">La police de la carte.</param>
    ''' <param name="cardColor">La couleur de la carte.</param>
    ''' <param name="pictureColor">La couleur de l'image de la carte.</param>
    Sub New(pictureChar As Char, police As Font, cardColor As Color, pictureColor As Color)
        InitializeComponent()

        Me.pictureChar = pictureChar
        Me.cardColor = cardColor
        Me.pictureColor = pictureColor

        PictureLabel.Text = pictureChar
        PictureLabel.BackColor = cardColor
        PictureLabel.ForeColor = cardColor

        PictureLabel.Font = police
    End Sub

    ''' <summary>
    ''' Retourne la carte face visible
    ''' </summary>
    Public Sub ShowCard()
        PictureLabel.ForeColor = pictureColor
    End Sub

    ''' <summary>
    ''' Retourne la carte face cachée
    ''' </summary>
    Public Sub HideCard()
        PictureLabel.ForeColor = cardColor
    End Sub

    ''' <summary>
    ''' Compare cette carte avec une autre
    ''' </summary>
    ''' <param name="reference">La carte avec laquelle comparer la carte acutelle.</param>
    ''' <returns></returns>
    Public Function IsEqual(reference As MemoryCard) As Boolean
        If Me.pictureChar = reference.pictureChar Then
            Return True
        End If
        Return False
    End Function

    ''' <summary>
    ''' Obtient la valeur qui indique si cette carte est actuellement visivble
    ''' </summary>
    ''' <returns></returns>
    Public Function IsShown() As Boolean
        If PictureLabel.ForeColor = PictureLabel.BackColor Then
            Return False
        End If
        Return True
    End Function

#Region "Evenements internes"

    Private Sub MemoryCard_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        ResizeCard(PictureLabel)
    End Sub
    Private Sub ResizeCard(control As Control)
        Dim methods As New Methods
        control.Font = New Font(control.Font.FontFamily, methods.GetMin(New List(Of Integer) From {control.Width, control.Height}) / 2)
    End Sub

#End Region

#Region "Evenement Click"

    ''' <summary>
    ''' Se produit lorsque la carte est cliquée
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Public Shadows Event CardClicked(sender As Object, e As EventArgs)

    ''' <summary>
    ''' Quand la carte est cliquée
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub PictureClicked(sender As Object, e As EventArgs) Handles PictureLabel.Click
        RaiseEvent CardClicked(Me, e)
    End Sub

#End Region

End Class
