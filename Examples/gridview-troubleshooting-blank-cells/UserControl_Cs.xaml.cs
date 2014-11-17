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

#region gridview-troubleshooting-blank-cells_2
private void gridView_DataLoaded(object sender, EventArgs e)
{
     (gridView.Columns["Category"] as GridViewComboBoxColumn).ItemsSource = GetCategories();
}
#endregion
}
