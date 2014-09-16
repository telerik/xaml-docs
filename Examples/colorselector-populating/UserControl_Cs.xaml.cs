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

#region colorselector-populating_0
RadColorSelector colorSelector = new RadColorSelector();
colorSelector.SelectedColor = Colors.Red;
#endregion

#region colorselector-populating_2
colorSelector.SelectedColorChanged += new EventHandler(colorSelector_SelectedColorChanged);

 void colorSelector_SelectedColorChanged(object sender, EventArgs e)
{
   RadColorSelector selector = sender as RadColorSelector;
   Color selectedColor = selector.SelectedColor;
}
#endregion

#region colorselector-populating_3
RadColorSelector colorSelector = new RadColorSelector();
colorSelector.MainPalette = ColorPreset.Grayscale;
#endregion

#region colorselector-populating_5
RadColorSelector colorSelector = new RadColorSelector();
colorSelector.HeaderPalette = ColorPreset.Office;
#endregion

#region colorselector-populating_7
RadColorSelector colorSelector = new RadColorSelector();
colorSelector.StandardPalette = ColorPreset.Standard;
#endregion

#region colorselector-populating_9
RadColorSelector colorSelector = new RadColorSelector();
colorSelector.StandardPaletteVisibility = Visibility.Visible;
Collection<Color> colors = new Collection<Color>();
colors.Add(Colors.Red);
colors.Add(Colors.Green);
colors.Add(Colors.Blue);
colorSelector.StandardPaletteItemsSource = colors;
#endregion

#region colorselector-populating_11
RadColorSelector colorSelector = new RadColorSelector();
colorSelector.HeaderPaletteVisibility = Visibility.Visible;
Collection<Color> colors = new Collection<Color>();
colors.Add(Colors.Red);
colors.Add(Colors.Green);
colors.Add(Colors.Blue);
colorSelector.HeaderPaletteItemsSource = colors;
#endregion

#region colorselector-populating_13
RadColorSelector colorSelector = new RadColorSelector();
Collection<Color> colors = new Collection<Color>();
colors.Add(Colors.Red);
colors.Add(Colors.Green);
colors.Add(Colors.Blue);
colorSelector.MainPaletteItemsSource = colors;
#endregion
}
