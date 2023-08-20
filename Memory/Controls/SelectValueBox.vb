Public Class SelectValueBox

    Private _valueStep As Decimal
    Property ValueStep As Decimal
        Get
            Return _valueStep
        End Get
        Set(value As Decimal)
            _valueStep = value
        End Set
    End Property

    Private _valueMin As Decimal
    Property ValueMin As Decimal
        Get
            Return _valueMin
        End Get
        Set(value As Decimal)
            _valueMin = value
        End Set
    End Property

    Private _valueMax As Decimal
    Property ValueMax As Decimal
        Get
            Return _valueMax
        End Get
        Set(value As Decimal)
            _valueMax = value
        End Set
    End Property

    Private _valueUnit As String
    Property ValueUnit As String
        Get
            Return _valueUnit
        End Get
        Set(value As String)
            _valueUnit = value
        End Set
    End Property

    Private _currentValue As Decimal
    Property CurrentValue As Decimal
        Get
            Return _currentValue
        End Get
        Set(value As Decimal)
            _currentValue = value
            If value > ValueMax Then
                _currentValue = ValueMax
            ElseIf value < ValueMin Then
                _currentValue = ValueMin
            End If
            If ValueUnit = "" Then
                ValueLabel.Text = _currentValue
            Else
                ValueLabel.Text = _currentValue.ToString + " " + ValueUnit
            End If
            RaiseEvent ValueChanged(Me, CurrentValue)
        End Set
    End Property

    Private _myTextColor As Color
    Property MyTextColor As Color
        Get
            Return _myTextColor
        End Get
        Set(value As Color)
            _myTextColor = value
            NextButton.ForeColor = value
            BackButton.ForeColor = value
            ValueLabel.ForeColor = value
        End Set
    End Property

    Private _myBackColor As Color
    Property MyBackColor As Color
        Get
            Return _myBackColor
        End Get
        Set(value As Color)
            _myBackColor = value
            NextButton.BackColor = value
            BackButton.BackColor = value
        End Set
    End Property

    ''' <summary>
    ''' Obtient les différents types de modifications de la valeur
    ''' </summary>
    Enum ValueEditionType
        Grow
        Shrink
    End Enum

    ''' <summary>
    ''' Modifie la valeur
    ''' </summary>
    ''' <param name="type"></param>
    Private Sub SetValue(type As ValueEditionType)
        If type = ValueEditionType.Grow Then
            CurrentValue += ValueStep
        ElseIf type = ValueEditionType.Shrink Then
            CurrentValue -= ValueStep
        End If
    End Sub

#Region "Evenements internes"

    Private Sub SetValue(sender As Button, e As EventArgs) Handles BackButton.Click, NextButton.Click
        If sender Is BackButton Then
            SetValue(ValueEditionType.Shrink)
        ElseIf sender Is NextButton Then
            SetValue(ValueEditionType.Grow)
        End If
    End Sub

#End Region

#Region "Evenement ValueChanged"

    ''' <summary>
    ''' Se produit après que la valeur ait été modifiée
    ''' </summary>
    ''' <param name="newValue"></param>
    Public Event ValueChanged(sender As SelectValueBox, newValue As Integer)

#End Region

End Class
