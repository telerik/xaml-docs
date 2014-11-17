#Region "radhtmlplaceholder-howto-displayhtml_1"
Imports System.Windows
Imports System.Windows.Controls
Namespace RadHtmlPlaceholderDemo
	Partial Public Class Page
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
			Loaded += New RoutedEventHandler(AddressOf Page_Loaded)
		End Sub
		Private Sub Page_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
			RadHtmlPlaceholder1.HtmlSource = "You can display <b>any</b> <span style=""color:#FF0000;"">valid</span> "
<i>html</i> content.<br/>It will be displayed as part of the <a href=""http://silverlight.net"" target=""_blank"">
	Silverlight</a> page<br/> and will be rendered by the browser."
		End Sub
	End Class
End Namespace
#End Region
