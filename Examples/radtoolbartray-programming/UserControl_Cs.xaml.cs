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

#region radtoolbartray-programming_0
using Telerik.Windows.Controls;

RadToolBarTray toolBarTray = new RadToolBarTray();
#endregion

#region radtoolbartray-programming_2
using Telerik.Windows.Controls;

RadToolBarTray toolBarTray = new RadToolBarTray();
RadToolBar toolBar = new RadToolBar();
this.LayoutRoot.Children.Add(toolBarTray);
toolBarTray.Items.Add(toolBar);
#endregion

#region radtoolbartray-programming_4
using Telerik.Windows.Controls;

RadToolBarTray toolBarTray = new RadToolBarTray();
RadToolBar toolBar1 = new RadToolBar();
this.LayoutRoot.Children.Add(toolBarTray);
toolBarTray.Items.Add(toolBar1);
toolBarTray.IsLocked = false;
RadToolBarTray.SetIsLocked(toolBarTray, true);
if (RadToolBarTray.GetIsLocked(toolBar1))
{
}
#endregion
}
