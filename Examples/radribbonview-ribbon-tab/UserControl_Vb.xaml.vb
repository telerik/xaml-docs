Public Class Default_Vb


' #region radribbonview-ribbon-tab_3
Dim currentlySelectedTab As RadRibbonTab = radRibbonView.SelectedTab
' #endregion

' #region radribbonview-ribbon-tab_6
Private Sub radRibbonView_PreviewSelectionChanged(sender As Object, e As RadSelectionChangedEventArgs)
	' Get the ribbonView
	Dim ribbonView As RadRibbonView = TryCast(sender, RadRibbonView)
	'Get the selected items
	Dim selectedItems As IList = e.AddedItems
	'Get the unselected items
	Dim unselectedItems As IList = e.RemovedItems
	' Cancel the selection
	e.Handled = True
End Sub
' #endregion

' #region radribbonview-ribbon-tab_9
Private Sub radRibbonView_SelectionChanged(sender As Object, e As RadSelectionChangedEventArgs)
	' Get the ribbonView
	Dim ribbonView As RadRibbonView = TryCast(sender, RadRibbonView)
	'Get the selected items
	Dim selectedItems As IList = e.AddedItems
	'Get the unselected items
	Dim unselectedItems As IList = e.RemovedItems
End Sub
' #endregion
End Class
