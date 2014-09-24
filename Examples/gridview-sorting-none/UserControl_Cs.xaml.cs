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

#region gridview-sorting-none_0
private void clubsGrid_Sorting(object sender, GridViewSortingEventArgs e)
{
 if (e.NewSortingState == SortingState.None)
 {
  e.NewSortingState = SortingState.Ascending; 
 }
}
#endregion
}
