Public Class MessageDialog

    Enum MessageResults
        ''' <summary>
        ''' Spécifie que le message à été bien lu et fermé par l'utilisateur.
        ''' </summary>
        CorrectlyRead
        ''' <summary>
        ''' Spécifie que le message à été fermée de manière inprévue.
        ''' </summary>
        None
    End Enum
    Public Overloads Function ShowMessage(title As String, message As String, okButtonText As String, Optional topWindow As Boolean = False) As MessageResults
        Text = title
        TopMost = topWindow
        MessageLabel.Text = message
        OkButton.Text = okButtonText
        OkButton.BackColor = BackColor
        OkButton.ForeColor = ForeColor
        Dim okDialogResult As DialogResult
        okDialogResult = ShowDialog()
        If okDialogResult = DialogResult.OK Then
            Return MessageResults.CorrectlyRead
        End If
        Return MessageResults.None
    End Function

#Region "Evènements internes"
    Private Sub OkButtonMouseEnter(sender As Object, e As EventArgs) Handles OkButton.MouseEnter
        Dim methods = New Methods
        OkButton.BackColor = methods.InverseColor(BackColor)
        OkButton.ForeColor = methods.InverseColor(ForeColor)
    End Sub
    Private Sub OkButtonMouseLeave(sender As Object, e As EventArgs) Handles OkButton.MouseLeave
        OkButton.BackColor = BackColor
        OkButton.ForeColor = ForeColor
    End Sub
#End Region

End Class