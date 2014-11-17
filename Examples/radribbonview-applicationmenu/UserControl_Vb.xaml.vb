Public Class Default_Vb


' #region radribbonview-applicationmenu_2
Me.radRibbonView.ApplicationMenu = New ApplicationMenu()
' #endregion

' #region radribbonview-applicationmenu_8
ribbonView.ApplicationButtonVisibility = Visibility.Collapsed
' #endregion

' #region radribbonview-applicationmenu_11
Private Sub RadRibbonView_ApplicationButtonDoubleClick(sender As Object, e As RadRoutedEventArgs)
	Dim ribbonView As RadRibbonView = TryCast(sender, RadRibbonView)
	' Do some custom logic here.
End Sub
' #endregion
End Class
