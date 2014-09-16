Public Class Default_Vb


' #region gridview-how-to-hide-match-case_1
Private Sub gridView_FieldFilterEditorCreated(sender As Object, e As Telerik.Windows.Controls.GridView.EditorCreatedEventArgs)
 'get the StringFilterEditor in your RadGridView
 Dim stringFilterEditor = TryCast(e.Editor, StringFilterEditor)
 If stringFilterEditor IsNot Nothing Then
  stringFilterEditor.Loaded += New RoutedEventHandler(stringFilterEditor_Loaded)
 End If
End Sub
Private Sub stringFilterEditor_Loaded(sender As Object, e As RoutedEventArgs)
 'Hide the Match case toogle button in its Loaded event
		DirectCast(sender, StringFilterEditor).ChildrenOfType(Of ToggleButton)().FirstOrDefault().Visibility = Visibility.Collapsed
End Sub
    ' #endregion
    ' #region gridview-how-to-hide-match-case_3
    Private Sub gridView_FieldFilterEditorCreated(sender As Object, e As Telerik.Windows.Controls.GridView.EditorCreatedEventArgs)
        'get the StringFilterEditor in your RadGridView
        Dim stringFilterEditor = TryCast(e.Editor, StringFilterEditor)
        If stringFilterEditor IsNot Nothing Then
            stringFilterEditor.MatchCaseVisibility = Visibility.Hidden
        End If
    End Sub
    ' #endregion

End Class
