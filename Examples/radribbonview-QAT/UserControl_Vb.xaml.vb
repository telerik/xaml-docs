Public Class Default_Vb


' #region radribbonview-QAT_2
Me.radRibbonView.QuickAccessToolBar = New QuickAccessToolBar()
' #endregion

' #region radribbonview-QAT_6
radRibbonView.QuickAccessToolBarPosition = QuickAccessToolBarPosition.BelowRibbon
' #endregion

' #region radribbonview-QAT_9
radRibbonView.QuickAccessToolBarPosition = QuickAccessToolBarPosition.NotHosted
' #endregion

' #region radribbonview-QAT_12
Private Sub radRibbonView_ToolBarPositionChanged(ByVal sender As Object, ByVal e As RadRoutedEventArgs)
Dim ribbonView As RadRibbonView = TryCast(sender, RadRibbonView)
' Do some logic here.
Dim newPosition As QuickAccessToolBarPosition = ribbonView.QuickAccessToolBarPosition
End Sub
' #endregion
End Class
