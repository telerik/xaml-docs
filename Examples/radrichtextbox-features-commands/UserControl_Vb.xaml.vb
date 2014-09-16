Public Class Default_Vb


    ' #region radrichtextbox-features-commands_2
    Public Sub New()
        InitializeComponent()
        Me.radRichTextBox.Commands.ToggleBoldCommand.ToggleStateChanged += Me.ToggleBoldCommand_ToggleStateChanged
    End Sub
    Public Sub ToggleBoldCommand_ToggleStateChanged(sender As Object, e As StylePropertyChangedEventArgs(Of Boolean))
        Me.BoldButton.IsChecked = e.NewValue
    End Sub
    ' #endregion

    ' #region radrichtextbox-features-commands_7
Me.radRichTextBox.PreviewEditorKeyDown += Function(sender, e) Do
	If Keyboard.IsKeyDown(Key.LeftCtrl) AndAlso e.Key = Key.S Then
		e.SuppressDefaultAction = True
	End If
End Function
    ' #endregion
End Class
