#Region "radhtmlplaceholder-howto-events_1"
Imports System.Windows
Imports System.Windows.Controls
Namespace RadHtmlPlaceholderDemo
	Partial Public Class Page
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
		End Sub
		Private Sub RadHtmlPlaceholder_UrlLoaded(ByVal sender As Object, ByVal e As EventArgs)
			Dim message As String = String.Format("{0} has been loaded!", RadHtmlPlaceholder1.SourceUrl)
			MessageBox.Show(message)
		End Sub
	End Class
End Namespace
#End Region
