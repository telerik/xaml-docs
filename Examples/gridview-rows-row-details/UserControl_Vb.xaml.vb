Public Class Default_Vb


' #region gridview-rows-row-details_2
Private Sub radGridView_LoadingRowDetails(ByVal sender As Object, ByVal e As GridViewRowDetailsEventArgs)
    Dim element As StackPanel = TryCast(e.DetailsElement, StackPanel)
    If e.Row.IsAlternating Then
        element.Background = New SolidColorBrush(Colors.Black)
    Else
        element.Background = New SolidColorBrush(Colors.White)
    End If
End Sub
' #endregion
End Class
