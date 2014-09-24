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

#region radmap-howto-custom-zoom-levels_1
private const string ImagePathFormat = "/Map;component/Silverlight/CustomCommands/Images/{0}.png";
private string VEKey;
private BingMapProvider provider;
public MainPage()
{
    this.provider = new BingMapProvider(MapMode.Aerial, true, this.VEKey);
    this.RadMap1.Provider = provider;
    this.RadMap1.InitializeCompleted += new EventHandler(RadMap1_InitializeCompleted);
}
private void RadMap1_InitializeCompleted(object sender, EventArgs e)
{
    // remove the default zoom levels
    RadMap1.MapZoomBar.Commands.Clear();
    this.AddCustomZoomAction(15, "Downtown");
    this.AddCustomZoomAction(18, "Neighborhood");
    this.AddCustomZoomAction(20, "Block");
}
private void AddCustomZoomAction(int zoomLevel, string label)
{
    string imagePath = string.Format(ImagePathFormat, label);
    this.RadMap1.MapZoomBar.RegisterSetZoomLevelCommand(zoomLevel,
        label,
        this.LayoutRoot.Resources["CustomCommandDataTemplate"] as DataTemplate,
        new Uri(imagePath, UriKind.RelativeOrAbsolute));
}
#endregion
}
