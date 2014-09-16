#Region "radoutlookbar-events_0"
Imports System.Collections.Generic
Imports System.Linq
Imports System.Net
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Shapes
Imports Telerik.Windows.Controls
Namespace RadOutlookBarHelpExamples
	Partial Public Class MainPage
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
		End Sub
		Private Sub RadOutlookBar1_SelectionChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Dim newSelectedItem As RadOutlookBarItem = TryCast(TryCast(sender, RadOutlookBar).SelectedItem, RadOutlookBarItem)
		End Sub
		Private Sub RadOutlookBar1_DropDownClosed(ByVal sender As Object, ByVal e As DropDownEventArgs)
			' handle the closing of the dropdown
		End Sub
		Private Sub RadOutlookBar1_DropDownOpened(ByVal sender As Object, ByVal e As DropDownEventArgs)
			' handle the openning of the dropdown
		End Sub
		Private Sub RadOutlookBar1_ItemPositionChanged(ByVal sender As Object, ByVal e As PositionChangedEventArgs)
			Dim itemChangedItsPosition As RadOutlookBarItem = TryCast(e.OriginalSource, RadOutlookBarItem)
			Dim oldPosition As OutlookBarItemPosition = e.OldPosition
			Dim newPosition As OutlookBarItemPosition = e.NewPosition
		End Sub
		Private Sub RadOutlookBar1_PreviewSelectionChanged(ByVal sender As Object, ByVal e As Telerik.Windows.Controls.SelectionChangedEventArgs)
			' use the Handled property to prevent the selection           
		End Sub
	End Class
End Namespace
#End Region

