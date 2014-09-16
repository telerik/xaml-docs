Public Class Default_Vb
#Region "colorselector-populating_0"
	Dim colorSelector As New RadColorSelector()
	colorSelector.SelectedColor = Colors.Red
#End Region
#Region "colorselector-populating_2"
	colorSelector.SelectedColorChanged += New EventHandler(colorSelector_SelectedColorChanged)

	Private Sub colorSelector_SelectedColorChanged(ByVal sender As Object, ByVal e As EventArgs)
		Dim selector As RadColorSelector = TryCast(sender, RadColorSelector)
		Dim selectedColor As Color = selector.SelectedColor
	End Sub
#End Region
#Region "colorselector-populating_3"
	Dim colorSelector As New RadColorSelector()
	colorSelector.MainPalette = ColorPreset.Grayscale
#End Region
#Region "colorselector-populating_5"
	Dim colorSelector As New RadColorSelector()
	colorSelector.HeaderPalette = ColorPreset.Office
#End Region
#Region "colorselector-populating_7"
	Dim colorSelector As New RadColorSelector()
	colorSelector.StandardPalette = ColorPreset.Standard
#End Region
#Region "colorselector-populating_9"
	Dim colorSelector As New RadColorSelector()
	colorSelector.StandardPaletteVisibility = Visibility.Visible
	Dim colors As New Collection(Of Color)()
	_colors.Add(Colors.Red)
	_colors.Add(Colors.Green)
	_colors.Add(Colors.Blue)
	_colorSelector.StandardPaletteItemsSource = _colors
#End Region
#Region "colorselector-populating_11"
	Dim colorSelector As New RadColorSelector()
	colorSelector.HeaderPaletteVisibility = Visibility.Visible
	Dim _colors As New Collection(Of Color)()
	_colors.Add(Colors.Red)
	_colors.Add(Colors.Green)
	_colors.Add(Colors.Blue)
	colorSelector.HeaderPaletteItemsSource = _colors
#End Region
#Region "colorselector-populating_13"
	Dim colorSelector As New RadColorSelector()
	Dim _colors As New Collection(Of Color)()
	_colors.Add(Colors.Red)
	_colors.Add(Colors.Green)
	_colors.Add(Colors.Blue)
	colorSelector.MainPaletteItemsSource = _colors
#End Region


End Class
