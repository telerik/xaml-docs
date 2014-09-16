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

#region radgridview-paging-using-telerik-raddatapager_1
IEnumerable data = new List<int>() { 1, 2, 3 };
RadDataPager radDataPager = new RadDataPager();
radDataPager.Source = data;
#endregion


}
