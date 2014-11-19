#Region "radhtmlplaceholder-howto-radwindowintegration_1"
Imports System.Windows
Imports System.Windows.Controls
Namespace SilverlightApplication18
	Partial Public Class MainPage
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
		End Sub
		Private Sub LoadHtmlPlaceholder(sender As Object, e As System.Windows.RoutedEventArgs)
			Me.window = New RadWindow()
			Dim htmlPlaceholder As New RadHtmlPlaceholder()
			Dim uri As New Uri("http://www.bing.com", UriKind.RelativeOrAbsolute)
			htmlPlaceholder.SourceUrl = uri
			Me.window.Content = htmlPlaceholder
			Me.window.Width = 800
			Me.window.Height = 600
			Me.window.Top = 210
			Me.window.Left = 330
			Me.window.Show()
		End Sub
	End Class
End Namespace
#End Region