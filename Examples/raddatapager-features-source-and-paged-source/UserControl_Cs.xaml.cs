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

#region raddatapager-features-source-and-paged-source_0
IEnumerable itemsSource = Enumerable.Range(0, 1000);
var pagedSource = new PagedCollectionView(itemsSource);
this.radDataPager.Source = pagedSource;
this.itemsControl.ItemsSource = pagedSource;
#endregion

#region raddatapager-features-source-and-paged-source_2
IEnumerable itemsSource = Enumerable.Range(0, 1000);
var pagedSource = new QueryableCollectionView(itemsSource);
this.radDataPager.Source = pagedSource;
this.itemsControl.ItemsSource = pagedSource;
#endregion
}
