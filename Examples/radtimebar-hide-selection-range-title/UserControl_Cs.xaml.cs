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
	
#region radtimebar-styling-the-items-and-groups_1
	Random r = new Random();
	List<int> data = new List<int>();
	for (DateTime currentDate = DateTime.Today; currentDate < DateTime.Today.AddDays(100);
	  currentDate = currentDate.AddDays(1))
	{
		data.Add(r.Next(0, 60));
	}
	sparkline.ItemsSource = data;   
#endregion

}
