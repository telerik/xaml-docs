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
#region radmap-features-mini-map_1
private const double MiniMapWidthScaleFactor = 0.15;
private const double MiniMapHeightScaleFactor = 0.2;

private void MapSizeChanged(object sender, SizeChangedEventArgs e)
{
    this.MiniMap1.Width = e.NewSize.Width * MiniMapWidthScaleFactor;
    this.MiniMap1.Height = e.NewSize.Height * MiniMapHeightScaleFactor;
}
#endregion
	}
}
