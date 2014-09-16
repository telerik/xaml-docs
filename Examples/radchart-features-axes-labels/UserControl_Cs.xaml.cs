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

#region radchart-features-axes-labels_0
DataSeries lineSeries = new DataSeries();
            lineSeries.LegendLabel = "Monthly Sales";
            lineSeries.Definition = new LineSeriesDefinition();
            Random r = new Random();
            for (int i = 0; i < 12; i++)
            {
                lineSeries.Add(new DataPoint() { YValue = i + r.Next(0,20) });
            }
            radChart.DefaultView.ChartArea.DataSeries.Add(lineSeries);
            string[] months = new string[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun" ,"Jul", "Aug", "Sep", "Oct", "Nov", "Dec", };
            for (int i = 0; i < months.Length; i++)
            {
               radChart.DefaultView.ChartArea.AxisX.TickPoints[i].Label = months[i];
            }
#endregion
}
