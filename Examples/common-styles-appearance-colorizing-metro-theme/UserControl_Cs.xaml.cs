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

#region common-styles-appearance-colorizing-metro-theme_0
Windows8Palette.Palette.MainColor = Colors.Black;
Windows8Palette.Palette.AccentColor = Colors.Orange;
Windows8Palette.Palette.BasicColor = Colors.DarkGray;
Windows8Palette.Palette.StrongColor = Colors.Gray;
Windows8Palette.Palette.MarkerColor = Colors.LightGray;
Windows8Palette.Palette.ValidationColor = Colors.Red;
...

Windows8TouchPalette.Palette.MainColor = Colors.Black;
Windows8TouchPalette.Palette.AccentColor = Colors.Orange;
Windows8TouchPalette.Palette.ValidationColor = Colors.Red;
Windows8TouchPalette.Palette.EffectHighColor = Colors.Yellow;
Windows8TouchPalette.Palette.EffectLowColor = Colors.Orange;
...
#endregion

#region common-styles-appearance-colorizing-metro-theme_1
//Windows8 Resources
Windows8Palette.Palette.FontSizeXS = 10;
Windows8Palette.Palette.FontSizeS = 11;
Windows8Palette.Palette.FontSize = 12;
Windows8Palette.Palette.FontSizeL = 14;
Windows8Palette.Palette.FontSizeXL = 16;
Windows8Palette.Palette.FontSizeXXL = 19;
Windows8Palette.Palette.FontSizeXXXL = 24;
Windows8Palette.Palette.FontFamily = new FontFamily("Segoe UI");
Windows8Palette.Palette.FontFamilyLight = new FontFamily("Segoe UI Light");
Windows8Palette.Palette.FontFamilyStrong = new FontFamily("Segoe UI Semibold");

//Windows8Touch resources
Windows8TouchPalette.Palette.FontSizeS = 10;
Windows8TouchPalette.Palette.FontSize = 12;
Windows8TouchPalette.Palette.FontSizeL = 15;
Windows8TouchPalette.Palette.FontSizeXL = 20;
Windows8TouchPalette.Palette.FontSizeXXL = 24;
Windows8TouchPalette.Palette.FontFamily = new FontFamily("Segoe UI");
Windows8TouchPalette.Palette.FontFamilyLight = new FontFamily("Segoe UI Light");
Windows8TouchPalette.Palette.FontFamilyStrong = new FontFamily("Segoe UI Semibold");
#endregion

#region common-styles-appearance-colorizing-metro-theme_2
public MainPage()
{
    StyleManager.ApplicationTheme = new Windows8Theme();
    InitializeComponent();
}

private void BtnChangeFontSize_Click_1(object sender, RoutedEventArgs e)
{
    Windows8Palette.Palette.FontSize = 22;
    Windows8Palette.Palette.FontFamily = new FontFamily("Calibri");
}
#endregion
}
