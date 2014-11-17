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

#region radgridview-how-to-enable-horiz-vertic-scrollbar_1
private void EnableScrollBars()
{
    ScrollViewer.SetHorizontalScrollBarVisibility( this.radGridView, ScrollBarVisibility.Visible );
    ScrollViewer.SetVerticalScrollBarVisibility( this.radGridView, ScrollBarVisibility.Visible );
}
#endregion
}
