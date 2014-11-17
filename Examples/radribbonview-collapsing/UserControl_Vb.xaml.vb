Public Class Default_Vb


' #region radribbonview-collapsing_3
Private Sub radRibbonView_CollapsedChanged(sender As Object, e As Telerik.Windows.RadRoutedEventArgs)
	Dim ribbonView As RadRibbonView = TryCast(sender, RadRibbonView)
	Dim isCollapsed As Boolean = ribbonView.IsCollapsed
End Sub
' #endregion
End Class
