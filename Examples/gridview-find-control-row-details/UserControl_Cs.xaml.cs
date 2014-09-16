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

#region gridview-find-control-row-details_2
private void gridView_LoadingRowDetails(object sender, GridViewRowDetailsEventArgs e)
{
   RadComboBox countries = e.DetailsElement.FindName("rcbCountries") as RadComboBox;
   countries.ItemsSource = GetCountries();
}
#endregion
}
