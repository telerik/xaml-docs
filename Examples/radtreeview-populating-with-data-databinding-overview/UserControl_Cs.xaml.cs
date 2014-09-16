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

#region radtreeview-populating-with-data-databinding-overview_1
radTreeView.DataContext = new CategoryList();
#endregion

#region radtreeview-populating-with-data-databinding-overview_6
LayoutRoot.DataContext = new CategoryList();
#endregion
}
