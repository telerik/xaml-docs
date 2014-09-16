using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace WpfApplication1
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
	}


#region paletteview-populating_3
RadColorPaletteView colorPaletteView = new RadColorPaletteView();
colorPaletteView.Palette = ColorPreset.Office;
#endregion

#region paletteview-populating_5
RadColorPaletteView colorPaletteView = new RadColorPaletteView();
Collection<Color> colors = new Collection<Color>();
colors.Add(Colors.Red);
colors.Add(Colors.Green);
colors.Add(Colors.Blue);
colorPaletteView.ItemsSource = colors;
#endregion

#region paletteview-populating_1
RadColorPaletteView colorPaletteView = new RadColorPaletteView();
#endregion
}
