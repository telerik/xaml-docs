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

#region radchart-how-to-use-custom-3d-models_1
private void FillSampleChartData()
{
 DataSeries barSeries = new DataSeries();
 barSeries.Definition = new Bar3DSeriesDefinition();
 barSeries.Definition.ItemStyle = (Style) this.FindResource("MyStyle");
 barSeries.FillWithSampleData();
 this.RadChart1.DefaultView.ChartArea.DataSeries.Add(barSeries);
}
#endregion
}
