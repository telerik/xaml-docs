Public Class Default_Vb
#Region "radcolorpicker-howto-use-isrecentcolorsactive_3"
	Dim timer As DispatcherTime
	Private Sub RadButton_Click(sender As Object, e As RoutedEventArgs)
		Me.xColorPicker.IsDropDownOpen = False
		Me.xExpander.Visibility = System.Windows.Visibility.Visible
		timer = New DispatcherTimer()
		timer.Interval = New TimeSpan(0, 0, 0, 0, 20)
		timer.Tick += New EventHandler(timer_Tick)
		timer.Start()
	End Sub

	Private Sub timer_Tick(sender As Object, e As EventArgs)
		Me.xExpander.IsExpanded = Not (Me.xExpander.IsExpanded)
		timer.[Stop]()
	End Sub
#End Region

#Region "radcolorpicker-howto-use-isrecentcolorsactive_5"
	Private Sub OK_RadButton_Click(sender As Object, e As RoutedEventArgs)
		Me.xColorPicker.SelectedColor = Me.xColorEditor.SelectedColor
		timer.Start()
		Me.xColorPicker.IsDropDownOpen = True
		Me.xExpander.Visibility = System.Windows.Visibility.Collapsed
	End Sub
#End Region

#Region "radcolorpicker-appearance_4"
	Dim colorPicker As New RadColorPicker()
colorPicker.HeaderPaletteVisibility = Visibility.Visible
	' colorPicker.HeaderPaletteVizibility = Visibility.Collapsed;
#End Region

#Region "radcolorpicker-appearance_6"
	Dim colorPicker As New RadColorPicker()
colorPicker.StandardPaletteHeaderText = "StandardPaletteHeader"
#End Region

#Region "radcolorpicker-appearance_8"
	Dim colorPicker As New RadColorPicker()
colorPicker.MainPaletteHeaderText = "MainPaletteHeader"
#End Region

#Region "radcolorpicker-appearance_10"
	Dim colorPicker As New RadColorPicker()
colorPicker.NoColorText = "No color Text"
#End Region

End Class
