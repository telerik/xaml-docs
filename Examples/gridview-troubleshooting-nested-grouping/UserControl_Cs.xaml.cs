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

#region gridview-troubleshooting-nested-grouping_0
void RadGridView1_Grouping(object sender, GridViewGroupingEventArgs e)
{
    Dispatcher.BeginInvoke(() =>
    {
        this.RadGridView1.CurrentItem = null;
    });
}
#endregion
}
