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

#region common-styling-appearance-visualstudio2013-theme_0

//default color variation
VisualStudio2013Palette.LoadPreset(VisualStudio2013Palette.ColorVariation.Light);

//blue color variation
VisualStudio2013Palette.LoadPreset(VisualStudio2013Palette.ColorVariation.Blue);

//dark color variation
VisualStudio2013Palette.LoadPreset(VisualStudio2013Palette.ColorVariation.Dark); 
#endregion

}
