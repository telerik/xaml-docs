Public Class Default_Vb
#Region "paletteview-populating_3"
	Dim colorPaletteView As New RadColorPaletteView()
	colorPaletteView.Palette = ColorPreset.Office
#End Region

#Region "paletteview-populating_5"
	Dim colorPaletteView As New RadColorPaletteView()
	Dim colors1 As New Collection(Of Color)()
	colors1.Add(Colors.Red)
	colors1.Add(Colors.Green)
	colors1.Add(Colors.Blue)
	colorPaletteView.ItemsSource = colors1
#End Region
#Region "paletteview-populating_1"
	Dim colorPaletteView As New RadColorPaletteView()
#End Region


End Class
