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

#region radtoolbartray-overview_1
using Telerik.Windows.Controls;

RadToolBarTray toolBarTray = new RadToolBarTray();
RadToolBar toolBar1 = new RadToolBar();
RadToolBar toolBar2 = new RadToolBar();
RadToolBar toolBar3 = new RadToolBar();
toolBar1.Band = 0;
toolBar1.BandIndex = 0;
toolBar2.Band = 0;
toolBar2.BandIndex = 1;
toolBar3.Band = 1;
toolBar3.BandIndex = 0;
this.LayoutRoot.Children.Add(toolBarTray);
toolBarTray.Items.Add(toolBar1);
toolBarTray.Items.Add(toolBar2);
toolBarTray.Items.Add(toolBar3);
#endregion
}
