Public Class Default_Vb


    ' #region gridview-events-grouping_2

Private Sub clubsGrid_Grouping(sender As Object, e As GridViewGroupingEventArgs)
 If e.Action = GroupingEventAction.Place AndAlso e.Index > 0 Then
  e.Cancel = True
 End If
End Sub
    ' #endregion
    ' #region gridview-events-grouping_4

    Private Sub clubsGrid_Grouped(sender As Object, e As GridViewGroupedEventArgs)
        Dim column As GridViewDataColumn = TryCast(DirectCast(e.GroupDescriptor, Telerik.Windows.Controls.GridView.ColumnGroupDescriptor).Column, GridViewDataColumn)
        MessageBox.Show("The GridView was grouped by column: " + column.Header.ToString())
    End Sub
    ' #endregion

    ' #region gridview-events-grouping_6
clubsGrid.Grouping += New EventHandler(Of GridViewGroupingEventArgs)(clubsGrid_Grouping)
clubsGrid.Grouped += New EventHandler(Of GridViewGroupedEventArgs)(clubsGrid_Grouped)
clubsGrid.GroupRowIsExpandedChanged += New EventHandler(Of GroupRowEventArgs)(radGridView_GroupRowIsExpandedChanged)
clubsGrid.GroupRowIsExpandedChanging += New EventHandler(Of GroupRowCancelEventArgs)(rgv2_GroupRowIsExpandedChanging)
    ' #endregion

    '#region "gridview-events-grouping_8"
    Private Sub clubsGrid_GroupRowIsExpandedChanging(sender As Object, e As Telerik.Windows.Controls.GridView.GroupRowCancelEventArgs)
        e.Cancel = True
    End Sub
    '#endregion

    '#region "gridview-events-grouping_10"
    Private Sub clubsGrid_GroupRowIsExpandedChanged(sender As Object, e As Telerik.Windows.Controls.GridView.GroupRowEventArgs)
        Dim expandedGroup As GridViewGroupRow = TryCast(e.Row, GridViewGroupRow)
        If expandedGroup.IsExpanded Then
            expandedGroup.Background = New SolidColorBrush(Colors.Red)
        Else
            expandedGroup.Background = New SolidColorBrush(Colors.Green)
        End If
    End Sub
    '#endregion
End Class
