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

#region radtabcontrol-how-to-change-the-position-of-the-tab-strip-of-RadTabControl_1
private void SetTabStripPlacement()
{
    radTabControl.TabStripPlacement = Telerik.Windows.Controls.Dock.Bottom;
}
#endregion
}
