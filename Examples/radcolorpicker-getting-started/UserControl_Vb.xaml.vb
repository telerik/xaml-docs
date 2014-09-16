Public Class Default_Vb
#Region "radcolorpicker-getting-started_0"
	Dim colorPicker As New RadColorPicker()
	colorPicker.SelectedColor = Colors.Red
#End Region
#Region "radcolorpicker-getting-started_2"
	colorPicker.SelectedColorChanged += New EventHandler(RadColorPicker_SelectedColorChanged)

	Private Sub RadColorPicker_SelectedColorChanged(ByVal sender As Object, ByVal e As EventArgs)
		Dim colorPicker As RadColorPicker = TryCast(sender, RadColorPicker)
		Dim selectedColor As Color = colorPicker.SelectedColor
	End Sub
#End Region
#Region "radcolorpicker-getting-started_3"
	Dim colorPicker As New RadColorPicker()
	colorPicker.MainPalette = ColorPreset.Grayscale
#End Region

#Region "radcolorpicker-getting-started_5"
	Dim colorPicker As New RadColorPicker()
	colorPicker.HeaderPalette = ColorPreset.Office
#End Region

#Region "radcolorpicker-getting-started_7"
	Dim colorPicker As New RadColorPicker()
	colorPicker.StandardPalette = ColorPreset.Standard
#End Region

#Region "radcolorpicker-getting-started_9"
	Dim colorPicker As New RadColorPicker()
	colorPicker.StandardPaletteVisibility = Visibility.Visible
	Dim colors1 As New Collection(Of Color)()
	colors1.Add(Colors.Red)
	colors1.Add(Colors.Green)
	colors1.Add(Colors.Blue)
	colorPicker.StandardPaletteItemsSource = colors1
#End Region

#Region "radcolorpicker-getting-started_11"
	Dim colorPicker As New RadColorPicker()
	colorPicker.HeaderPaletteVisibility = Visibility.Visible
	Dim colors1 As New Collection(Of Color)()
	colors1.Add(Colors.Red)
	colors1.Add(Colors.Green)
	colors1.Add(Colors.Blue)
	colorPicker.HeaderPaletteItemsSource = colors1
#End Region

#Region "radcolorpicker-getting-started_13"
	Dim colorPicker As New RadColorPicker()
	Dim colors1 As New Collection(Of Color)()
	colors1.Add(Colors.Red)
	colors1.Add(Colors.Green)
	colors1.Add(Colors.Blue)
	colorPicker.MainPaletteItemsSource = colors1
#End Region

#Region "radcolorpicker-getting-started_15"
	Dim colorPicker As New RadColorPicker()
	colorPicker.SelectedColorChanged += New EventHandler(RadColorPicker_SelectedColorChanged)

	Private Sub RadColorPicker_SelectedColorChanged(ByVal sender As Object, ByVal e As EventArgs)
		Dim colorPicker As RadColorPicker = TryCast(sender, RadColorPicker)
		Dim selectedColor As Color = colorPicker.SelectedColor
	End Sub
#End Region

#Region "radcolorpicker-getting-started_17"
	Dim colorPicker As New RadColorPicker()
	colorPicker.DropDownClosed += New EventHandler(colorPicker_DropDownClosed)

	Private Sub colorPicker_DropDownClosed(ByVal sender As Object, ByVal e As EventArgs)
		' handle the DropDownClosed event
	End Sub
#End Region

#Region "radcolorpicker-getting-started_19"
	Dim colorPicker As New RadColorPicker()
	colorPicker.DropDownOpened += New EventHandler(colorPicker_DropDownOpened)

	Private Sub colorPicker_DropDownOpened(ByVal sender As Object, ByVal e As EventArgs)
		' handle the DropDownOpened event
	End Sub
#End Region

#Region "radcolorpicker-getting-started_21"
	Dim colorPicker As New RadColorPicker()
	colorPicker.Click += New EventHandler(colorPicker_Click)

	Private Sub colorPicker_Click(ByVal sender As Object, ByVal e As EventArgs)
		' handle the Click event
	End Sub
#End Region


End Class
