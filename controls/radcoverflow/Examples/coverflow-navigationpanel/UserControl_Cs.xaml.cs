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

#region coverflow-navigationpanel_3
this.coverFlow.NavigationLargeChange = this.coverFlow.Items.Count;
#endregion
}
