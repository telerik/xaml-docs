Public Class Default_Vb
#Region "How_to_set_the_content_from_code_behind_1"
	Private Sub Button_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
		RadHtmlPlaceholder1.SourceUrl = New Uri("http://www.bing.com")
	End Sub
#End Region

#Region "How_to_set_the_content_from_code_behind_2"
	Private Sub Button_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
		RadHtmlPlaceholder1.HtmlSource = "<b>Hello World.</b>"
	End Sub
#End Region
End Class
