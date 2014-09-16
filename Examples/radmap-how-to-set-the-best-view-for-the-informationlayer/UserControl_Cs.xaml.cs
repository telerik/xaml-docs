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

#region radmap-how-to-set-the-best-view-for-the-informationlayer_0
private void SetBestView()
{
    LocationRect rect = this.informationLayer.GetBestView(this.informationLayer.Items.Cast<object>());
    rect.MapControl = this.radMap;
    this.radMap.Center = rect.Center;
    this.radMap.ZoomLevel = rect.ZoomLevel;
}
#endregion

}
