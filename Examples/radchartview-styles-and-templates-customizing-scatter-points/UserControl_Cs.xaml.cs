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

#region radchartview-styles-and-templates-customizing-scatter-points_1
public class ChartData
{
	private readonly Brush Red = new SolidColorBrush(Colors.Red);
	private readonly Brush Orange = new SolidColorBrush(Colors.Orange);
	private readonly Brush Green = new SolidColorBrush(Colors.Green);

	public ChartData(double x, double y)
	{
		this.XValue = x;
		this.YValue = y;
	}

	public double XValue { get; set; }
	public double YValue { get; set; }

	public Brush Brush
	{
		get
		{
			if (this.YValue < 102)
			{
				return Red;
			}
			else if (this.YValue < 105)
			{
				return Orange;
			}
			else
			{
				return Green;
			}
		}
	}
}
#endregion

#region radchartview-styles-and-templates-customizing-scatter-points_3
public class ViewModel : ViewModelBase
{
	private List<ChartData> data;

	public ViewModel()
	{
		this.Data = this.GetData();
	}

	public List<ChartData> Data
	{
		get
		{
			return this.data;
		}
		set
		{
			if (this.data != value)
			{
				this.data = value;
				this.OnPropertyChanged("Data");
			}
		}
	}

	private List<ChartData> GetData()
	{
		List<ChartData> data = new List<ChartData>();
		data.Add(new ChartData(0.1, 100));
		data.Add(new ChartData(0.1, 101));
		data.Add(new ChartData(11, 106));
		data.Add(new ChartData(101, 104));
		data.Add(new ChartData(101, 108));

		return data;
	}
}
#endregion

#region radchartview-styles-and-templates-customizing-scatter-points_5
  public class ScatterPointTemplateSelector : DataTemplateSelector
    {
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            var scatterPoint = (ScatterDataPoint)item;
            var itemIndex = scatterPoint.Index;
            var series = container as ScatterPointSeries;
            var dataPoint = series.DataPoints[itemIndex];
            var chart = series.GetVisualParent<RadCartesianChart>();
            if (dataPoint.YValue > 105)
            {
                return chart.Resources["ellipseTemplate"] as DataTemplate;
            }
            else
            {
                return chart.Resources["rectangleTemplate"] as DataTemplate;
            }
        }
    }
#endregion
}
