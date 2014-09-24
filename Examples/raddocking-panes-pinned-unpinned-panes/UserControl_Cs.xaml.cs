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

#region raddocking-panes-pinned-unpinned-panes_1
radPane.IsPinned = true;
#endregion

#region raddocking-panes-pinned-unpinned-panes_4
radPane.CanUserPin = false;
#endregion
}
