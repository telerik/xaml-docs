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

#region carousel-data-binding_0
this.RadCarousel1.ItemsSource = GetDataTable();
#endregion

#region carousel-data-binding_2
radCarousel1.DataMember = "Orders";
radCarousel1.ItemsSource = dataSet;
#endregion
}
