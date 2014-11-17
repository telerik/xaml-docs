Public Class Default_Vb


    ' #region radrichtextbox-getting-started_5
    Private Sub BoldButton_Click(sender As Object, e As RoutedEventArgs)
        Me.radRichTextBox.ToggleBold()
        Me.radRichTextBox.Focus()
    End Sub
    Private Sub ItalicButton_Click(sender As Object, e As RoutedEventArgs)
        Me.radRichTextBox.ToggleItalic()
        Me.radRichTextBox.Focus()
    End Sub
    Private Sub UnderlineButton_Click(sender As Object, e As RoutedEventArgs)
        Me.radRichTextBox.ToggleUnderline()
        Me.radRichTextBox.Focus()
    End Sub
    ' #endregion

    ' #region radrichtextbox-getting-started_8
    Public Sub New()
        InitializeComponent()

        Me.radRichTextBox.Commands.ToggleBoldCommand.ToggleStateChanged += New EventHandler(Of Telerik.Windows.Documents.RichTextBoxCommands.StylePropertyChangedEventArgs(Of Boolean))(ToggleBoldCommand_ToggleStateChanged)
        Me.radRichTextBox.Commands.ToggleItalicCommand.ToggleStateChanged += New EventHandler(Of Telerik.Windows.Documents.RichTextBoxCommands.StylePropertyChangedEventArgs(Of Boolean))(ToggleItalicCommand_ToggleStateChanged)
        Me.radRichTextBox.Commands.ToggleUnderlineCommand.ToggleStateChanged += New EventHandler(Of Telerik.Windows.Documents.RichTextBoxCommands.StylePropertyChangedEventArgs(Of Boolean))(ToggleUnderlineCommand_ToggleStateChanged)
    End Sub

    Private Sub ToggleBoldCommand_ToggleStateChanged(sender As Object, e As Telerik.Windows.Documents.RichTextBoxCommands.StylePropertyChangedEventArgs(Of Boolean))
        BoldButton.IsChecked = e.NewValue
    End Sub
    ' #endregion
End Class
