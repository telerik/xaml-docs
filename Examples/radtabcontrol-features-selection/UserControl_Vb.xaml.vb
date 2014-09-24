Public Class Default_Vb


' #region radtabcontrol-features-selection_2
Private Sub radTabControl_SelectionChanged( ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs)
        Dim selectionArgs As RadSelectionChangedEventArgs = DirectCast(e,RadSelectionChangedEventArgs)
        MessageBox.Show("The selected tab item is " + DirectCast(selectionArgs.AddedItems(0), RadTabItem).Header.ToString() )
End Sub
' #endregion
End Class
