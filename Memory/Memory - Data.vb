Public Structure Memory

    ''' <summary>
    ''' Obtient l'ID du jeu de mémoire
    ''' </summary>
    Shared ReadOnly ID As String = "memory"

    ''' <summary>
    ''' Définit si l'utilisateur peut accéder au jeu de mémoire
    ''' </summary>
    Shared access As Boolean

    ''' <summary>
    ''' Fournit l'accès aux données sur les niveaux
    ''' </summary>
    Structure Levels

        ''' <summary>
        ''' Représente le nombre total de niveaux
        ''' </summary>
        Shared ReadOnly totalLevels As Integer

        ''' <summary>
        ''' Obtient le niveau par défaut
        ''' </summary>
        Shared ReadOnly defaultLevel As Integer = 1

        ''' <summary>
        ''' Obtient la descritpion du niveau 1
        ''' </summary>
        Shared ReadOnly level1Description As String = "Vous pouvez retourner toutes les cartes autant de fois que vous voulez."

        ''' <summary>
        ''' Obtient la descritpion du niveau 2
        ''' </summary>
        Shared ReadOnly level2Description As String = "La deuxième fois que vous retournez la croix, vous perdez."

    End Structure

    ''' <summary>
    ''' Fournit l'accès aux données sur les packs
    ''' </summary>
    Structure Packs

        ''' <summary>
        ''' Représente le nombre total de packs
        ''' </summary>
        Shared ReadOnly totalNumber As Integer = 2

        ''' <summary>
        ''' Obtient le pack par défaut
        ''' </summary>
        Shared ReadOnly defaultPack As Integer = 1

        ''' <summary>
        ''' Obtient la liste contenant tout les caractères possibles pour le pack 1
        ''' </summary>
        Shared ReadOnly pack1CharList As New List(Of Char) From {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "?", "!", ",", ".", ";", ":", "/", "§", "#", "'", "(", ")", "{", "}"}

        ''' <summary>
        ''' Obtient le font du pack 1
        ''' </summary>
        Shared ReadOnly pack1Font As New Font("Wingdings", 50)

        ''' <summary>
        ''' Obtient la descritpion du pack 1
        ''' </summary>
        Shared ReadOnly pack1Description As String = "Le meilleur pack d'images pour le jeu de mémoire !"

        ''' <summary>
        ''' Obtient le font du pack 2
        ''' </summary>
        Shared ReadOnly pack2Font As New Font("Wingdings 2", 50)

        ''' <summary>
        ''' Obtient la liste contenant tout les caractères possibles pour le pack 2
        ''' </summary>
        Shared ReadOnly pack2CharList As New List(Of Char) From {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "?", "!", ",", ".", ";", ":", "/", "§", "#", "'", "(", ")", "{", "}"}

        ''' <summary>
        ''' Obtient la descritpion du pack 2
        ''' </summary>
        Shared ReadOnly pack2Description As String = "Un pack qui mettra votre oeil de lynx à l'épreuve !"

    End Structure

    ''' <summary>
    ''' Fournit l'accès aux données sur les cartes
    ''' </summary>
    Structure Cards

        ''' <summary>
        ''' Obtient le nombre maximum de fois où la croix peut être retournée
        ''' </summary>
        Shared ReadOnly crossMaxReturnedNumber As Integer = 2

        Structure Size

            ''' <summary>
            ''' Obtient le nombre de lignes par défaut
            ''' </summary>
            Shared ReadOnly defaultRowCount As Integer = 5

            ''' <summary>
            ''' Obtient le nombre de colonnes par défaut
            ''' </summary>
            Shared ReadOnly defaultColumCount As Integer = 5

            Shared ReadOnly minRowCount As Integer = 4
            Shared ReadOnly maxRowCount As Integer = 10

            Shared ReadOnly minColumnCount As Integer = 4
            Shared ReadOnly maxColumnCount As Integer = 10

        End Structure

        Structure Colors

            ''' <summary>
            ''' Obtient la couleur par défaut pour les cartes
            ''' </summary>
            Shared ReadOnly defaultCardsColor As Color = Color.White

            ''' <summary>
            ''' Obtient la couleur par défaut pour les images
            ''' </summary>
            Shared ReadOnly defaultPicturesColor As Color = Color.Black

            ''' <summary>
            ''' Obtient la couleur par défaut des cartes retournées
            ''' </summary>
            Shared ReadOnly defaultHighlightColor As Color = Color.Blue

        End Structure

    End Structure

    ''' <summary>
    ''' Fournit l'accès aux données sur le temps du jeu
    ''' </summary>
    Public Structure GameTime

        ''' <summary>
        ''' Obtient les états du timer de temps de jeu
        ''' </summary>
        Public Enum GameTimeState
            None
            Start
            Pause
        End Enum

        ''' <summary>
        ''' Définit si le chronomètre est activé par défaut
        ''' </summary>
        Shared ReadOnly defaultState As GameTimeState = GameTimeState.Pause

        ''' <summary>
        ''' Obtient le tecte du bouton qui affiche l'état du chronomètre lorsqu'il est activé
        ''' </summary>
        Shared ReadOnly activeText As String = "Chronomètre activé"

        ''' <summary>
        ''' Obtient le tecte du bouton qui affiche l'état du chronomètre lorsqu'il est désactivé
        ''' </summary>
        Shared ReadOnly inactiveText As String = "Chronomètre désactivé"

        ''' <summary>
        ''' Obtient le temps maximum en secondes pour le jeu
        ''' </summary>
        Shared ReadOnly maxTime As Integer = 1000

        ''' <summary>
        ''' Obtient le temps minimum en secondes pour le jeu
        ''' </summary>
        Shared ReadOnly minTime As Integer = 50

        ''' <summary>
        ''' Obtient le temps par défaut du chronomètre du jeu
        ''' </summary>
        Shared ReadOnly defaultTime As Integer = 120

        ''' <summary>
        ''' Obtient le nombre de secondes à incrémenter à chaque incrémentation
        ''' </summary>
        Shared ReadOnly defaultIncrement As Integer = 10

        ''' <summary>
        ''' Donne l'état du timer opposé à l'état entré
        ''' </summary>
        ''' <returns></returns>
        Shared Function ChangeState(value As GameTimeState) As GameTimeState

            If value = GameTimeState.Start Then
                Return GameTimeState.Pause
            ElseIf value = GameTimeState.Pause Then
                Return GameTimeState.Start
            Else
                Return Nothing
            End If
        End Function

    End Structure

    Structure Preparation

        ''' <summary>
        ''' Obtient le nombre de seconde à ajouter ou à soustraire quand un bouton pour modifier le temps dans le formulaire de préparation est cliqué.
        ''' </summary>
        Shared ReadOnly addOrRemoveTimeStep As Integer = 10

        ''' <summary>
        ''' Représente le fichier de préparation du jeu de mémoire
        ''' </summary>
        Shared file As String

    End Structure

End Structure

Class Methods

    Public Function InverseColor(value As Color) As Color
        Dim newColor As Color = Color.FromArgb(255 - value.R, 255 - value.G, 255 - value.B)
        Return newColor
    End Function
    Public Function GetIntegerFromString(value As String, Optional defaultValue As Integer = 0)
        If value = "" Then
            Return defaultValue
        End If
        Return value
    End Function
    Public Function FromARGBString(value As String) As Color
        Return Color.FromArgb(value)
    End Function
    Public Function GetARGBString(value As Color) As String
        Return value.ToArgb().ToString()
    End Function

    Public Function GetMin(numericsList As List(Of Integer)) As Integer
        Dim currentValue As Integer = numericsList(0)
        For i = 1 To numericsList.Count
            If numericsList(i - 1) < currentValue Then
                currentValue = numericsList(i - 1)
            End If
        Next
        Return currentValue
    End Function
End Class