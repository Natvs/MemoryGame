Public Class Memory_Game

    Public Sub StartGame()
        CreateFilesAndFolders(GetPseudo())
        BackColor = Color.Black
        Using memoryGamePrepation As New Memory_Preparation() With {.TopMost = True}
            If memoryGamePrepation.ShowPreparation() = Memory_Preparation.PreparationResults.CorrectlySetUp Then
                currentLevel = memoryGamePrepation.SelectedLevel
                currentPack = memoryGamePrepation.SelectedPack
                currentCardsColor = memoryGamePrepation.SelectedCardsColor
                currentCardsPicturesColor = memoryGamePrepation.SelectedCardsPicturesColor
                currentGameTimerState = memoryGamePrepation.SelectedGameTimerState
                currentGameTime = memoryGamePrepation.SelectedGameTime
                currentRowCount = memoryGamePrepation.SelectedRowCount
                currentColumnCount = memoryGamePrepation.SelectedColumnCount
                currentPairsTotal = Int((currentRowCount * currentColumnCount) / 2)
            End If
        End Using
        ReenitializePairs()
        InitializeCards()
        HideAllCards()
        SetTextColor(currentCardsPicturesColor)
        ShowTimer()
    End Sub
    Private Function GetPseudo() As String
        Dim pseudo As String = ""
        If IO.File.Exists("files/userfile") Then
            Using userfile = FileIO.FileSystem.OpenTextFileReader("files/userfile")
                pseudo = userfile.ReadLine
            End Using
        End If
        Return pseudo
    End Function
    Private Sub CreateFilesAndFolders(pseudo As String)
        If IO.Directory.Exists("files/" + pseudo + "/memory") And Not IO.Directory.Exists("files/" + pseudo + "/Memory") Then
            FileIO.FileSystem.RenameDirectory("files/" + pseudo + "/memory", "Memory")
        End If
        If Not IO.Directory.Exists("files/" + pseudo + "/Memory") Then
            IO.Directory.CreateDirectory("files/" + pseudo + "/Memory")
        End If
        Memory.Preparation.file = "files/" + pseudo + "/Memory/preparationFile.txt"
    End Sub
    Private Sub EndGame()
        crossCard = Nothing
        crossReturnedNumber = 0
        Close()
    End Sub
    Private Sub SetTextColor(newColor)
        FoundPairsTextLabel.ForeColor = newColor
        FoundPairsNumberLabel.ForeColor = newColor
        LeftPairsTextLabel.ForeColor = newColor
        LeftPairsNumberLabel.ForeColor = newColor
        TimeLeftTextLabel.ForeColor = newColor
        TimeLeftLabel.ForeColor = newColor
    End Sub

#Region "Données"

    ''' <summary>
    ''' Obtient le nombre actuel de lignes
    ''' </summary>
    Private currentRowCount As Integer

    ''' <summary>
    ''' Obtient le nombre actuel de colonnes
    ''' </summary>
    Private currentColumnCount As Integer

    ''' <summary>
    ''' Obtient le niveau actuel
    ''' </summary>
    Private currentLevel As Integer

    ''' <summary>
    ''' Obtient le pack actuel
    ''' </summary>
    Private currentPack As Integer

    ''' <summary>
    ''' Obtient le nombre total de paires actuel
    ''' </summary>
    Private currentPairsTotal As Integer

    ''' <summary>
    ''' Obtient la couleur actuelle des images des cartes
    ''' </summary>
    Private currentCardsPicturesColor As Color

    ''' <summary>
    ''' Obtient la couleur actuelle des cartes
    ''' </summary>
    Private currentCardsColor As Color

    ''' <summary>
    ''' Obtient l'état actuel du timer du jeu
    ''' </summary>
    Private currentGameTimerState As Memory.GameTime.GameTimeState

    ''' <summary>
    ''' Obtient le temps de jeu actuel
    ''' </summary>
    Private currentGameTime As Integer

#End Region

#Region "Cartes"

    ''' <summary>
    ''' Représente la liste avec les caractères des cartes, basée sur letterList().
    ''' </summary>
    Private iconsList As New List(Of String)

    ''' <summary>
    ''' Obtient le tableau contenant les caractères correspondants aux images des cartes
    ''' </summary>
    Private picturesList As New List(Of Char)

    ''' <summary>
    ''' Obtient le tableau contenant les cartes
    ''' </summary>
    Private cardsArray(10, 10) As MemoryCard

    ''' <summary>
    ''' Représente le label de la première carte retournée
    ''' </summary>
    Private firstCard As MemoryCard

    ''' <summary>
    ''' Représente le label de la seconde carte retournée
    ''' </summary>
    Private secondCard As MemoryCard

    ''' <summary>
    ''' Valeur qui définit si l'utilisateur peut cliquer sur les cartes
    ''' </summary>
    Private canClickCard As Boolean = True

    ''' <summary>
    ''' Retourne une carte face visible
    ''' </summary>
    ''' <param name="card">La carte à retourner</param>
    Private Sub ReturnCard(card As MemoryCard)
        If canClickCard And card.IsShown() = False Then
            If currentLevel = 1 Then
                If firstCard Is Nothing Then
                    firstCard = card
                ElseIf firstCard IsNot Nothing And card IsNot firstCard Then
                    secondCard = card
                    canClickCard = False
                    ShowCardTimer.Start()
                End If
                card.ShowCard()
            End If
            If currentLevel = 2 Then
                If firstCard Is Nothing Then
                    firstCard = card
                ElseIf firstCard IsNot Nothing And card IsNot firstCard Then
                    secondCard = card
                    canClickCard = False
                    ShowCardTimer.Start()
                End If
                card.ShowCard()
            End If
        End If
    End Sub

    ''' <summary>
    ''' Méthode appelée quand deux cartes ont été tournées
    ''' </summary>
    Private Sub CheckReturned(card1 As MemoryCard, card2 As MemoryCard)
        ShowCardTimer.Stop()
        If card1.IsEqual(card2) Then
            FoundNewPair()
            If pairsFound = currentPairsTotal Then
                FoundAll()
            End If
        Else
            card1.HideCard()
            card2.HideCard()
        End If

        InitializeReturnedCards(False)
        canClickCard = True
    End Sub

    ''' <summary>
    ''' Assigne une image à chaque carte
    ''' </summary>
    Private Sub InitializeCards()
        Dim packFont As New Font(FontFamily.GenericSansSerif, 20)

        If currentPack = 1 Then
            packFont = Memory.Packs.pack1Font

            Dim toNumber As Integer = Int((currentRowCount * currentColumnCount) / 2)

            If (currentRowCount * currentColumnCount) Mod 2 > 0 Then
                picturesList.Add(Memory.Packs.pack1CharList(0))
            End If

            For i = 1 To toNumber
                picturesList.Add(Memory.Packs.pack1CharList(i - 1))
                picturesList.Add(Memory.Packs.pack1CharList(i - 1))
            Next
        ElseIf currentPack = 2 Then
            packFont = Memory.Packs.pack2Font

            Dim toNumber As Integer = Int((currentRowCount * currentColumnCount) / 2)

            If (currentRowCount * currentColumnCount) Mod 2 > 0 Then
                picturesList.Add(Memory.Packs.pack1CharList(0))
            End If

            For i = 1 To toNumber
                picturesList.Add(Memory.Packs.pack2CharList(i - 1))
                picturesList.Add(Memory.Packs.pack2CharList(i - 1))
            Next
        End If

        GrowCardsPanel(currentRowCount, currentColumnCount)

        Dim index As Integer = 0
        Dim indexRandom As New Random
        For row = 1 To currentRowCount
            For column = 1 To currentColumnCount
                index = indexRandom.Next(picturesList.Count)
                cardsArray(row, column) = New MemoryCard(picturesList(index), packFont, currentCardsColor, currentCardsPicturesColor)
                cardsArray(row, column).Dock = DockStyle.Fill
                AddHandler cardsArray(row, column).CardClicked, AddressOf CardClicked
                picturesList.RemoveAt(index)
                CardTableLayoutPanel.Controls.Add(cardsArray(row, column), column - 1, row - 1)
            Next
        Next

        firstCard = Nothing
        secondCard = Nothing
    End Sub

    ''' <summary>
    ''' Initialise les cases présentes dans le tableau qui contiendra les cartes.
    ''' </summary>
    ''' <param name="rowNumber">Le nombre de lignes</param>
    ''' <param name="columnNumber">Le nombre de colonnes</param>
    Private Sub GrowCardsPanel(rowNumber, columnNumber)
        CardTableLayoutPanel.RowCount = rowNumber
        For row = 1 To rowNumber
            CardTableLayoutPanel.RowStyles.Insert(row - 1, New RowStyle(SizeType.Percent, 100 / rowNumber))
        Next

        CardTableLayoutPanel.ColumnCount = columnNumber
        For column = 1 To columnNumber
            CardTableLayoutPanel.ColumnStyles.Insert(column - 1, New ColumnStyle(SizeType.Percent, 100 / columnNumber))
        Next
    End Sub

    ''' <summary>
    ''' Retourne les cartes actuellement retournées face cachée
    ''' </summary>
    Private Sub HideActiveCards()
        If firstCard IsNot Nothing Then
            firstCard.HideCard()
        End If
        If secondCard IsNot Nothing Then
            secondCard.HideCard()
        End If
    End Sub

    ''' <summary>
    ''' Retourne toutes les cartes face cachée et réinitialise le compteur de paires
    ''' </summary>
    Private Sub HideAllCards()
        For row = 1 To currentRowCount
            For column = 1 To currentColumnCount
                cardsArray(row, column).HideCard()
            Next
        Next
        ReenitializePairs()
    End Sub

    ''' <summary>
    ''' Réenitialise les cartes retournées en mémoires
    ''' </summary>
    ''' <param name="foundPairs">Indique si le nombre de paires trouvées doit être réenitialisé</param>
    Private Sub InitializeReturnedCards(foundPairs As Boolean)
        firstCard = Nothing
        secondCard = Nothing

        If foundPairs = True Then
            ReenitializePairs()
        End If
    End Sub

    ''' <summary>
    ''' Méthode appelée quand toutes les cartes ont été trouvées
    ''' </summary>
    Private Sub FoundAll()
        PauseGame()
        Using messageDialog As New MessageDialog() With {.BackColor = currentCardsColor, .ForeColor = currentCardsPicturesColor}
            messageDialog.ShowMessage("Félicitations !", "Vous avez trouvé toutes les paires !", "Super !")
        End Using
        EndGame()
    End Sub

#Region "Paires"

    ''' <summary>
    ''' Obtient le nombre de paires trouvées
    ''' </summary>
    Private pairsFound As Integer

    ''' <summary>
    ''' Obtient le nombre de paires restantes
    ''' </summary>
    Private pairsLeft As Integer

    ''' <summary>
    ''' Ajoute une nouvelle paire au compteur
    ''' </summary>
    Private Sub FoundNewPair()
        pairsFound = pairsFound + 1
        pairsLeft = pairsLeft - 1
        ShowPairs(pairsFound, pairsLeft)
    End Sub

    ''' <summary>
    ''' Réinitialise le compteur de paires
    ''' </summary>
    Private Sub ReenitializePairs()
        pairsFound = 0
        pairsLeft = currentPairsTotal
        ShowPairs(pairsFound, pairsLeft)
    End Sub

    ''' <summary>
    ''' Affiche le nombre de paires actuels au compteurs
    ''' </summary>
    ''' <param name="pairsFound"></param>
    ''' <param name="pairsLeft"></param>
    Private Sub ShowPairs(pairsFound As Integer, pairsLeft As Integer)
        FoundPairsNumberLabel.Text = pairsFound.ToString
        LeftPairsNumberLabel.Text = pairsLeft.ToString
    End Sub

#End Region

#Region "Croix"

    ''' <summary>
    ''' Représente la carte perdante dans le niveau actuel avec le pack actuel.
    ''' </summary>
    Private crossCard As MemoryCard

    ''' <summary>
    ''' Représente le nombre de fois où la carte perdante a été retournée
    ''' </summary>
    Private crossReturnedNumber As Integer

    ''' <summary>
    ''' Obtient la carte perdante actuellement retournée.
    ''' </summary>
    Private currentCrossCardCoords As MemoryCard()

    ''' <summary>
    ''' Représente la liste contenant les cartes perdantes
    ''' </summary>
    Private currentCrossCardsList As New List(Of MemoryCard)

    ''' <summary>
    ''' Méthode appelée quand la croix a été tournée
    ''' </summary>
    Private Sub FoundCross(crossCard As MemoryCard)
        ShowCardTimer.Stop()

        crossReturnedNumber = crossReturnedNumber + 1
        HideActiveCards()
        crossCard.ForeColor = currentCardsPicturesColor
        InitializeReturnedCards(False)
        canClickCard = False

        If crossReturnedNumber < Memory.Cards.crossMaxReturnedNumber Then
            ShowCrossCardTimer.Start()
        ElseIf crossReturnedNumber = Memory.Cards.crossMaxReturnedNumber Then
            PauseGame()
            Using messageDialog As New MessageDialog() With {.BackColor = currentCardsColor, .ForeColor = currentCardsPicturesColor}
                messageDialog.ShowMessage("Mince...", "Vous avez soulevé la croix " + Memory.Cards.crossMaxReturnedNumber.ToString + " fois...", "Mince...")
            End Using
            EndGame()
        End If
    End Sub

    ''' <summary>
    ''' Cache la croix
    ''' </summary>
    Private Sub HideCross(crossCard As MemoryCard)
        ShowCrossCardTimer.Stop()
        canClickCard = True
        crossCard.HideCard()
    End Sub

#End Region

#End Region

#Region "Temps de jeu"

    ''' <summary>
    ''' Obtient le temps restant en seconde du timer
    ''' </summary>
    Private gameTimeLeft As Integer

    ''' <summary>
    ''' Montre ou cache le timer du jeu
    ''' </summary>
    Private Sub ShowTimer()
        gameTimeLeft = currentGameTime
        If currentGameTimerState = Memory.GameTime.GameTimeState.Start Then
            TimeTableLayoutPanel.Visible = True
            GameTimer.Start()
        ElseIf currentGameTimerState = Memory.GameTime.GameTimeState.Pause Then
            TimeTableLayoutPanel.Visible = False
            GameTimer.Stop()
        End If
    End Sub

    ''' <summary>
    ''' Met le jeu en pause
    ''' </summary>
    Private Sub PauseGame()
        canClickCard = False
        GameTimer.Stop()
    End Sub

    ''' <summary>
    ''' Continue le jeu
    ''' </summary>
    Private Sub ResumeGame()
        If currentGameTimerState = Memory.GameTime.GameTimeState.Start Then
            GameTimer.Start()
        End If
    End Sub

    ''' <summary>
    ''' Stope le jeu quand le temps est écoulé
    ''' </summary>
    Private Sub NoTimeLeft()
        GameTimer.Stop()
        currentGameTimerState = Memory.GameTime.GameTimeState.Pause
        Using messageDialog As New MessageDialog() With {.BackColor = currentCardsColor, .ForeColor = currentCardsPicturesColor}
            messageDialog.ShowMessage("Temps écoulé", "Vous n'avez pas fini dans les temps...", "Mince")
        End Using
        EndGame()
    End Sub

    ''' <summary>
    ''' Méthode appelée à chaque seconde pendant le temps de jeu
    ''' </summary>
    Private Sub CheckEverySecond()
        gameTimeLeft = gameTimeLeft - 1
        TimeLeftLabel.Text = gameTimeLeft.ToString
        If gameTimeLeft = 0 Then
            NoTimeLeft()
        End If
    End Sub

#End Region

#Region "Evenements internes"

    Private Sub GameLoad() Handles MyBase.Load
        StartGame()
    End Sub

    Private Sub CardClicked(sender As MemoryCard, e As EventArgs)
        ReturnCard(sender)
    End Sub

    Private Sub gameTimer_Tick(sender As Timer, e As EventArgs) Handles GameTimer.Tick
        CheckEverySecond()
    End Sub

    Private Sub cardTimer_Tick(sender As Timer, e As EventArgs) Handles ShowCardTimer.Tick
        CheckReturned(firstCard, secondCard)
    End Sub

    Private Sub showCrossCardTimer_Tick(sender As Timer, e As EventArgs) Handles ShowCrossCardTimer.Tick
        HideCross(Nothing)
    End Sub

    Private Sub CardTableLayoutPanel_SizeChanged(sender As Object, e As EventArgs) Handles CardTableLayoutPanel.SizeChanged

    End Sub

#End Region

End Class