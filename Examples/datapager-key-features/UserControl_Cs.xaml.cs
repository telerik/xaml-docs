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

#region datapager-key-features_1
IEnumerable data = Enumerable.Range(0, 1000);
RadDataPager radDataPager = new RadDataPager();
radDataPager.PageSize = 10;
radDataPager.Source = data;
itemsControl.ItemsSource = radDataPager.PagedSource;
#endregion
}
