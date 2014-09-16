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

#region radtreeview-how-to-enable-horizontal-vertical-scrollbar_2
private void EnableScrollBars()
{
    ScrollViewer.SetHorizontalScrollBarVisibility( radTreeView, ScrollBarVisibility.Visible );
    ScrollViewer.SetVerticalScrollBarVisibility( radTreeView, ScrollBarVisibility.Visible );
}
#endregion
}
