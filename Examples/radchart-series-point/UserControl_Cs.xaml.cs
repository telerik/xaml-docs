using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace WpfApplication1
{
	
	public partial class MainWindow: Window
	{
		public MainWindow()
        	{
            	InitializeComponent();
				
#region radchartview_series_point_0
public class ChartViewModel
{
    public ObservableCollection<PlotInfo> SalesData { get; set; }

    private static readonly Random rnd = new Random(123);

    public ChartViewModel()
    {
        DateTime startDate = new DateTime(2013, 6, 1);

        var sampleData = new ObservableCollection<PlotInfo>();	
		
		//Generate test data
        for (int i = 0; i < 1000; i++)
        {
            var item = new PlotInfo
            {
                Date = startDate.AddDays(i),
                Sales = rnd.Next(-10000, (int)(10000 * Math.Sin(i / 100)))
            };

            sampleData.Add(item);
        }

        this.SalesData = sampleData;
    }
}

public class PlotInfo
{
    public DateTime Date { get; set; }
    public double Sales { get; set; }
}
#endregion

		}
	}
}
