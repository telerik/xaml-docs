Public Class Default_Vb


    ' #region gridview-grouping-how-to-get-aggregates_1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs)
        For Each item As QueryableCollectionViewGroup In Me.OrgInfo.Items.Groups
            If (item.Key.Equals("24")) Then
                MessageBox.Show(item.AggregateResults(0).FormattedValue.ToString())
            End If
        Next
    End Sub
' #endregion

End Class
