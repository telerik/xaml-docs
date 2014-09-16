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

#region colorselector-appearance_0
RadColorSelector selector = new RadColorSelector();
selector.NoColorVisibility = Visibility.Visible;
// selector.NoColorVisibility= Visibility.Collapsed;
#endregion

#region colorselector-appearance_2
RadColorSelector selector = new RadColorSelector();
selector.StandardPaletteVisibility = Visibility.Visible;
// selector.StandardPaletteVisibility = Visibility.Collapsed;
#endregion

#region colorselector-appearance_4
RadColorSelector selector = new RadColorSelector();
selector.HeaderPaletteVisibility = Visibility.Visible;
// selector.HeaderPaletteVisibility = Visibility.Collapsed;
#endregion

#region colorselector-appearance_6
RadColorSelector selector = new RadColorSelector();
selector.StandardPaletteHeaderText = "header";
#endregion

#region colorselector-appearance_8
RadColorSelector selector = new RadColorSelector();
selector.MainPaletteHeaderText = "header";
#endregion

#region colorselector-appearance_10
RadColorSelector selector = new RadColorSelector();
selector.NoColorText = "No Color Text";
#endregion
}
