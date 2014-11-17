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

#region paletteview-color-preset_1
RadColorPaletteView colorPaletteView = new RadColorPaletteView();
colorPaletteView.Palette = ColorPreset.Office;
RadColorSelector colorSelector = new RadColorSelector();
colorSelector.MainPalette = ColorPreset.Office;
#endregion
}
