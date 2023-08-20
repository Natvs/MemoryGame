Public Class Memory_Preparation

    Private WithEvents Level1Button As New Button() With {.Text = "Niveau 1", .Font = New Font(FontFamily.GenericSansSerif, 20), .ForeColor = Color.Black, .BackColor = Color.Black, .UseVisualStyleBackColor = False, .AutoSize = True, .Dock = DockStyle.Fill}
    Private WithEvents Level2Button As New Button() With {.Text = "Niveau 2", .Font = New Font(FontFamily.GenericSansSerif, 20), .ForeColor = Color.Black, .BackColor = Color.Black, .UseVisualStyleBackColor = False, .AutoSize = True, .Dock = DockStyle.Fill}
    Private WithEvents Pack1Button As New Button() With {.Text = "Pack 1", .Font = New Font(FontFamily.GenericSansSerif, 20), .ForeColor = Color.Black, .BackColor = Color.Black, .UseVisualStyleBackColor = False, .AutoSize = True, .Dock = DockStyle.Fill}
    Private WithEvents Pack2Button As New Button() With {.Text = "Pack 2", .Font = New Font(FontFamily.GenericSansSerif, 20), .ForeColor = Color.Black, .BackColor = Color.Black, .UseVisualStyleBackColor = False, .AutoSize = True, .Dock = DockStyle.Fill}

    ''' <summary>
    ''' Obtient les résultats du dialogue de préparation.
    ''' </summary>
    Enum PreparationResults
        ''' <summary>
        ''' Spécifie que les données ont correctement été initialisées par l'utilisateur.
        ''' </summary>
        CorrectlySetUp
        ''' <summary>
        ''' Spécifie que le formulaire a été fermé avant la saisie de toutes les données.
        ''' </summary>
        None
    End Enum

    ''' <summary>
    ''' Affiche le formulaire de préparation. Les données sont chargées depuis le fichier de prépation de jeu de mémoire.
    ''' </summary>
    ''' <returns></returns>
    Public Function ShowPreparation() As PreparationResults
        LevelMultiButtonBox.Message = "Choisissez votre niveau"
        LevelMultiButtonBox.Font = New Font(FontFamily.GenericSansSerif, 15)
        LevelMultiButtonBox.AddButton(Level1Button, Memory.Levels.level1Description)
        LevelMultiButtonBox.AddButton(Level2Button, Memory.Levels.level2Description)

        PackMultiButtonBox.Message = "Choisissez votre pack"
        PackMultiButtonBox.Font = New Font(FontFamily.GenericSansSerif, 15)
        PackMultiButtonBox.AddButton(Pack1Button, Memory.Packs.pack1Description)
        PackMultiButtonBox.AddButton(Pack2Button, Memory.Packs.pack2Description)

        GameTimeSelectValueBox.ValueMin = Memory.GameTime.minTime
        GameTimeSelectValueBox.ValueMax = Memory.GameTime.maxTime
        GameTimeSelectValueBox.ValueUnit = "secondes"
        GameTimeSelectValueBox.ValueStep = 10

        RowSelectValueBox.ValueMin = Memory.Cards.Size.minRowCount
        RowSelectValueBox.ValueMax = Memory.Cards.Size.maxRowCount
        RowSelectValueBox.ValueUnit = "lignes"
        RowSelectValueBox.ValueStep = 1

        ColumnSelectValueBox.ValueMin = Memory.Cards.Size.minColumnCount
        ColumnSelectValueBox.ValueMax = Memory.Cards.Size.maxColumnCount
        ColumnSelectValueBox.ValueUnit = "colonnes"
        ColumnSelectValueBox.ValueStep = 1

        BackColor = Color.White
        OkButton.Enabled = False
        LoadPreparation()

        LevelMultiButtonBox.TextColor = SelectedCardsPicturesColor
        LevelMultiButtonBox.SelectedButtonColor = SelectedCardsColor

        PackMultiButtonBox.TextColor = SelectedCardsPicturesColor
        PackMultiButtonBox.SelectedButtonColor = SelectedCardsColor

        GameTimeSelectValueBox.CurrentValue = SelectedGameTime
        RowSelectValueBox.CurrentValue = SelectedRowCount
        ColumnSelectValueBox.CurrentValue = SelectedColumnCount

        Refresh()

        If ShowDialog() = DialogResult.OK Then
            Return PreparationResults.CorrectlySetUp
        End If
        Return PreparationResults.None
    End Function

#Region "Preparation"

    Sub New()
        InitializeComponent()
    End Sub

    Private _selectedLevel As Integer
    Property SelectedLevel As Integer
        Get
            Return _selectedLevel
        End Get
        Set(value As Integer)
            _selectedLevel = value
            If value = 1 Then
                LevelMultiButtonBox.SelectButton(Level1Button)
            ElseIf value = 2 Then
                LevelMultiButtonBox.SelectButton(Level2Button)
            End If
            CheckAll()
        End Set
    End Property

    Private _selectedPack As Integer
    Property SelectedPack As Integer
        Get
            Return _selectedPack
        End Get
        Set(value As Integer)
            _selectedPack = value
            If value = 1 Then
                PackMultiButtonBox.SelectButton(Pack1Button)
            ElseIf value = 2 Then
                PackMultiButtonBox.SelectButton(Pack2Button)
            End If
            CheckAll()
        End Set
    End Property

    Private _selectedGameTimerState As Memory.GameTime.GameTimeState
    Property SelectedGameTimerState As Memory.GameTime.GameTimeState
        Get
            Return _selectedGameTimerState
        End Get
        Set(value As Memory.GameTime.GameTimeState)
            If value = Memory.GameTime.GameTimeState.Start Then
                _selectedGameTimerState = Memory.GameTime.GameTimeState.Start
                ChronoButton.Text = Memory.GameTime.activeText
            ElseIf value = Memory.GameTime.GameTimeState.Pause Then
                _selectedGameTimerState = Memory.GameTime.GameTimeState.Pause
                ChronoButton.Text = Memory.GameTime.inactiveText
            End If
            CheckAll()
        End Set
    End Property

    Private _selectedGameTime As Integer
    Property SelectedGameTime As Integer
        Get
            Return _selectedGameTime
        End Get
        Set(value As Integer)
            _selectedGameTime = value
        End Set
    End Property

    Private _selectedCardsColor As Color
    Property SelectedCardsColor() As Color
        Get
            Return _selectedCardsColor
        End Get
        Set(value As Color)
            _selectedCardsColor = value
            CardsColorButton.BackColor = _selectedCardsColor
            PicturesColorButton.BackColor = _selectedCardsColor
            LevelMultiButtonBox.SelectedButtonColor = _selectedCardsColor
            PackMultiButtonBox.SelectedButtonColor = _selectedCardsColor
            ChronoButton.BackColor = _selectedCardsColor
            GameTimeSelectValueBox.MyBackColor = _selectedCardsColor
            RowSelectValueBox.MyBackColor = _selectedCardsColor
            ColumnSelectValueBox.MyBackColor = _selectedCardsColor
            OkButton.BackColor = _selectedCardsColor
            CheckAll()
        End Set
    End Property

    Private _selectedCardsPicturesColor As Color
    Property SelectedCardsPicturesColor As Color
        Get
            Return _selectedCardsPicturesColor
        End Get
        Set(value As Color)
            _selectedCardsPicturesColor = value
            CardsColorButton.ForeColor = _selectedCardsPicturesColor
            PicturesColorButton.ForeColor = _selectedCardsPicturesColor
            LevelMultiButtonBox.TextColor = _selectedCardsPicturesColor
            PackMultiButtonBox.TextColor = _selectedCardsPicturesColor
            ChronoButton.ForeColor = _selectedCardsPicturesColor
            GameTimeSelectValueBox.MyTextColor = _selectedCardsPicturesColor
            RowSelectValueBox.MyTextColor = _selectedCardsPicturesColor
            ColumnSelectValueBox.MyTextColor = _selectedCardsPicturesColor
            OkButton.ForeColor = _selectedCardsPicturesColor
            CheckAll()
        End Set
    End Property

    Property SelectedRowCount As Integer
    Property SelectedColumnCount As Integer

    ''' <summary>
    ''' Charge les données de préparation
    ''' </summary>
    Private Sub LoadPreparation()
        Dim methods = New Methods
        If FileIO.FileSystem.FileExists(Memory.Preparation.file) = True Then
            Using file = FileIO.FileSystem.OpenTextFileReader(Memory.Preparation.file)
                SelectedLevel = methods.GetIntegerFromString(file.ReadLine, Memory.Levels.defaultLevel)
                SelectedPack = methods.GetIntegerFromString(file.ReadLine, Memory.Packs.defaultPack)
                SelectedCardsColor = methods.FromARGBString(file.ReadLine)
                SelectedCardsPicturesColor = methods.FromARGBString(file.ReadLine)
                SelectedGameTimerState = ReadGameTimerState(file.ReadLine)
                SelectedGameTime = methods.GetIntegerFromString(file.ReadLine, Memory.GameTime.defaultTime)
                SelectedRowCount = methods.GetIntegerFromString(file.ReadLine, Memory.Cards.Size.defaultRowCount)
                SelectedColumnCount = methods.GetIntegerFromString(file.ReadLine, Memory.Cards.Size.defaultColumCount)
            End Using
        Else
            SelectedLevel = Memory.Levels.defaultLevel
            SelectedPack = Memory.Packs.defaultPack
            SelectedCardsColor = Memory.Cards.Colors.defaultCardsColor
            SelectedCardsPicturesColor = Memory.Cards.Colors.defaultPicturesColor
            SelectedGameTimerState = Memory.GameTime.defaultState
            SelectedGameTime = Memory.GameTime.defaultTime
            SelectedRowCount = Memory.Cards.Size.defaultRowCount
            SelectedColumnCount = Memory.Cards.Size.defaultColumCount
        End If
    End Sub

    ''' <summary>
    ''' Sauvegarde les données de préparation
    ''' </summary>
    Private Sub SavePreparation()
        Dim methods = New Methods
        Using file = FileIO.FileSystem.OpenTextFileWriter(Memory.Preparation.file, False)
            file.WriteLine(SelectedLevel.ToString)
            file.WriteLine(SelectedPack.ToString)
            file.WriteLine(methods.GetARGBString(SelectedCardsColor))
            file.WriteLine(methods.GetARGBString(SelectedCardsPicturesColor))
            file.WriteLine(SelectedGameTimerState.ToString)
            file.WriteLine(SelectedGameTime.ToString)
            file.WriteLine(SelectedRowCount.ToString)
            file.WriteLine(SelectedColumnCount.ToString)
        End Using
    End Sub

    ''' <summary>
    ''' Vérifie si l'utilisateur a séléctionné toutes les données pour passer à la suite
    ''' </summary>
    Private Sub CheckAll()
        If SelectedLevel <> Nothing And SelectedPack <> Nothing And SelectedCardsColor <> Nothing And SelectedCardsPicturesColor <> Nothing And SelectedGameTimerState <> Memory.GameTime.GameTimeState.None Then
            OkButton.Enabled = True
        Else
            OkButton.Enabled = False
        End If
    End Sub

#Region "Couleurs"

    ''' <summary>
    ''' Demande à l'utilisateur une couleur pour les cartes
    ''' </summary>
    Private Sub SelectCardsColor()
        Using cardsColorDialog As New ColorDialog
            If cardsColorDialog.ShowDialog = DialogResult.OK Then
                SelectedCardsColor = cardsColorDialog.Color
            End If
        End Using
    End Sub

    ''' <summary>
    ''' Demande à l'utilisateur une couleur pour les images des cartes
    ''' </summary>
    Private Sub SelectPicturesColor()
        Using picturesColorDialog As New ColorDialog
            If picturesColorDialog.ShowDialog = DialogResult.OK Then
                SelectedCardsPicturesColor = picturesColorDialog.Color
            End If
        End Using
    End Sub

#End Region

#Region "Temps de jeu"

    Private Sub GameTimeChanged(sender As SelectValueBox, newValue As Integer) Handles GameTimeSelectValueBox.ValueChanged
        SelectedGameTime = newValue
    End Sub

    Private Function ReadGameTimerState(text As String) As Memory.GameTime.GameTimeState
        If text = "Pause" Then
            Return Memory.GameTime.GameTimeState.Pause
        ElseIf text = "Start" Then
            Return Memory.GameTime.GameTimeState.Start
        End If
        Return Memory.GameTime.GameTimeState.None
    End Function

#End Region

#Region "Taille du jeu"

    ''' <summary>
    ''' Quand la taille du jeu a été modifiée
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="newValue"></param>
    Private Sub GameSizeChanged(sender As SelectValueBox, newValue As Integer) Handles RowSelectValueBox.ValueChanged, ColumnSelectValueBox.ValueChanged
        If sender Is RowSelectValueBox Then
            SelectedRowCount = newValue
        ElseIf sender Is ColumnSelectValueBox Then
            SelectedColumnCount = newValue
        End If
    End Sub

#End Region

#End Region

#Region "Evenements internes"

    Private Sub chronoButtonClicked(sender As Button, e As EventArgs) Handles ChronoButton.Click

        SelectedGameTimerState = Memory.GameTime.ChangeState(SelectedGameTimerState)

    End Sub

    Private Sub chooseColors(sender As Button, e As EventArgs) Handles CardsColorButton.Click, PicturesColorButton.Click
        If sender Is CardsColorButton Then
            SelectCardsColor()
        ElseIf sender Is PicturesColorButton Then
            SelectPicturesColor()
        End If
    End Sub

    Private Sub okButtonClicked(sender As Button, e As EventArgs) Handles OkButton.Click
        SavePreparation()
    End Sub

    Private Sub packButtonClicked(button As Button) Handles PackMultiButtonBox.ButtonClicked
        If button Is Pack1Button Then
            SelectedPack = 1
        ElseIf button Is Pack2Button Then
            SelectedPack = 2
        End If
    End Sub

    Private Sub levelButtonClicked(button As Button) Handles LevelMultiButtonBox.ButtonClicked
        If button Is Level1Button Then
            SelectedLevel = 1
        ElseIf button Is Level2Button Then
            SelectedLevel = 2
        End If
    End Sub

#End Region

End Class