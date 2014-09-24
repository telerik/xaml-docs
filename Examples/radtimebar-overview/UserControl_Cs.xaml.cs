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
		
#region radtimebar-overview_2
Random r = new Random();
List<int> LinearData = new List<int>();
for (DateTime currentDate = DateTime.Today; currentDate < DateTime.Today.AddDays(365);
    currentDate = currentDate.AddDays(1))
{
    LinearData.Add(r.Next(0, 60));
}
this.DataContext = LinearData;
#endregion
	}
}
