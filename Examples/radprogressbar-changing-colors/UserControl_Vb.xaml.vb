Partial Public Class App
	Inherits Application
	Public Sub Colors()
		'#Region "radprogressbar-changing-colors_1"
		Dim myProgressBar As New RadProgressBar()
		' Set Background directly 
		myProgressBar.Background = New SolidColorBrush(Colors.Yellow)
		' Set Background using a Style
		Dim myStyle As New Style(GetType(RadProgressBar))
		myStyle.Setters.Add(New Setter(RadProgressBar.BackgroundProperty, New SolidColorBrush(Colors.Yellow)))
		myProgressBar.Style = myStyle
		'#End Region

		'#Region "radprogressbar-changing-colors_3"
		' Set Foreground directly
		myProgressBar.Foreground = New SolidColorBrush(Colors.Yellow)
		' Set Foreground using a Style
		Dim myStyle2 As New Style(GetType(RadProgressBar))
		myStyle2.Setters.Add(New Setter(RadProgressBar.ForegroundProperty, New SolidColorBrush(Colors.Yellow)))
		myProgressBar.Style = myStyle2
		'#End Region

		'#Region "radprogressbar-changing-colors_5"
		' Set BorderBrush  directly
		myProgressBar.BorderBrush = New SolidColorBrush(Colors.Red)
		' Set BorderBrush using a Style
		Dim myStyle3 As New Style(GetType(RadProgressBar))
		myStyle3.Setters.Add(New Setter(RadProgressBar.BorderBrushProperty, New SolidColorBrush(Colors.Red)))
		myProgressBar.Style = myStyle3
		'#End Region
	End Sub
End Class
