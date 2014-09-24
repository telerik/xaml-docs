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

#region radmap-how-to-bring-a-location-into-view_1
private void BringLocationIntoView( Location desiredLocation )
{
    this.radMap.Center = desiredLocation;
}
#endregion
}
