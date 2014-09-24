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

#region radchart-axes-datetimeaxes_1
public MainPage()
{
    InitializeComponent();
    DateTime lastDate = DateTime.Now;
    double lastVal = 20;
    List<ChartDataObject> dataSouce = new List<ChartDataObject>();
    for (int i = 0; i < 5; ++i)
    {
        ChartDataObject obj = new ChartDataObject { Date = lastDate.AddMonths(1), Value = lastVal++ };
        dataSouce.Add(obj);
        lastDate = obj.Date;
    }
    LineSeries series = (LineSeries)this.chart.Series[0];
    series.CategoryBinding = new PropertyNameDataPointBinding() { PropertyName = "Date" };
    series.ValueBinding = new PropertyNameDataPointBinding() { PropertyName = "Value" };
    series.ItemsSource = dataSouce;
}
#endregion

#region radchart-axes-datetimeaxes_3
public class ChartDataObject
{
    public DateTime Date
    {
        get;
        set;
    }
    public double Value
    {
        get;
        set;
    }
}
#endregion
}
