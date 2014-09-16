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

#region radchart-features-axes-logarithmic-scale_1
this.radChart.ItemsSource = new int[] { 10, 100, 1000, 10000, 100000, 1000000 };
#endregion

#region radchart-features-axes-logarithmic-scale_4
this.radChart.DefaultView.ChartArea.AxisY.IsLogarithmic = true;
#endregion
}
