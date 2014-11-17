Public Class Default_Vb
#Region "radbook-events_1"
	Partial Public Class MainPage
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
		End Sub
		Private Sub RadBook_FoldActivated(ByVal sender As Object, ByVal e As Telerik.Windows.Controls.FoldEventArgs)
			Dim position As FoldPosition = e.Position
		End Sub
		Private Sub RadBook1_FoldDeactivated(ByVal sender As Object, ByVal e As Telerik.Windows.Controls.FoldEventArgs)

		End Sub
		Private Sub RadBook1_PageChanged(ByVal sender As Object, ByVal e As Telerik.Windows.RadRoutedEventArgs)
			Dim currentPage As Integer = RadBook1.RightPageIndex
		End Sub
		Private Sub RadBook1_PageFlipEnded(ByVal sender As Object, ByVal e As Telerik.Windows.Controls.PageFlipEventArgs)
			Dim flippedPage As RadBookItem = e.Page
		End Sub
		Private Sub RadBook1_PageFlipStarted(ByVal sender As Object, ByVal e As Telerik.Windows.Controls.PageFlipEventArgs)
			Dim flippedPage As RadBookItem = e.Page
		End Sub
		Private Sub RadBook1_PreviewPageFlipStarted(ByVal sender As Object, ByVal e As Telerik.Windows.Controls.PageFlipEventArgs)
			Dim flippedPage As RadBookItem = e.Page
			e.Handled = True 'if the page flip should stop
		End Sub
	End Class
#End Region
End Class
