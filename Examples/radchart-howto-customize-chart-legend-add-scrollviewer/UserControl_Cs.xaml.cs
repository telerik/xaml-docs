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

#region radchart-howto-customize-chart-legend-add-scrollviewer_1
public MainPage()
        {
            InitializeComponent();
            Random r = new Random();
            int[] myArray = new int[100];
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = r.Next(0, 100);
            }
            RadChart1.ItemsSource = myArray;
            RadChart1.DefaultView.ChartArea.EnableAnimations = false;
            RadChart1.DefaultView.ChartLegend.Width = 200;
            RadChart1.DefaultSeriesDefinition.LegendDisplayMode = LegendDisplayMode.DataPointLabel;
            RadChart1.DefaultView.ChartLegend.Style = (Style)this.Resources["ChartLegendStyle"];
        }
#endregion
}
