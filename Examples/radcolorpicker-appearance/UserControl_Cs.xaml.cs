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

#region radcolorpicker-appearance_0
RadColorPicker colorPicker = new RadColorPicker();
colorPicker.NoColorVisibility = Visibility.Visible;
// colorPicker.NoColorVisibility= Visibility.Collapsed;
#endregion

#region radcolorpicker-appearance_2
RadColorPicker colorPicker = new RadColorPicker();
colorPicker.StandardPaletteVisibility = Visibility.Visible;
 // colorPicker.StandardPaletteVisibility = Visibility.Collapsed;
#endregion

#region radcolorpicker-appearance_4
RadColorPicker colorPicker = new RadColorPicker();
colorPicker.HeaderPaletteVisibility = Visibility.Visible;
// colorPicker.HeaderPaletteVizibility = Visibility.Collapsed;
#endregion

#region radcolorpicker-appearance_6
RadColorPicker colorPicker = new RadColorPicker();
colorPicker.StandardPaletteHeaderText = "StandardPaletteHeader";
#endregion

#region radcolorpicker-appearance_8
RadColorPicker colorPicker = new RadColorPicker();
colorPicker.MainPaletteHeaderText = "MainPaletteHeader";
#endregion

#region radcolorpicker-appearance_10
RadColorPicker colorPicker = new RadColorPicker();
colorPicker.NoColorText = "No color Text";
#endregion
}
