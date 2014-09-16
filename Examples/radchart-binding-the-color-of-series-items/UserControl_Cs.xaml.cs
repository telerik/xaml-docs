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
				
#region radchartview-populating-with-data-binding-the-color-of-series-items_0
public class ChartData : INotifyPropertyChanged
{
    private int _category;
    public int Category
    {
        get { return this._category; }
        set { this._category = value; this.OnPropertyChanged("Category"); }
    }

    private double _value;
    public double Value
    {
        get { return this._value; }
        set { this._value = value; this.OnPropertyChanged("Value"); }
    }

    private Brush _color;
    public Brush Color
    {
        get { return this._color; }
        set { this._color = value; this.OnPropertyChanged("Color"); }
    }

    public event PropertyChangedEventHandler PropertyChanged;
    private void OnPropertyChanged(string propertyName)
    {
        if (this.PropertyChanged != null)
        {
            this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
#endregion

#region radchartview-populating-with-data-binding-the-color-of-series-items_1
public MainWindow()
{
	InitializeComponent();
	DataContext = GetData(12);
}

public static List<ChartData> GetData(int dataSize)
{
    Random rnd = new Random();
    var result = new List<ChartData>();
         
    for (int i = 0; i < dataSize; i++)
    {
        result.Add(new ChartData()
        {
            Category = i,
            Value = rnd.Next(1, 100),
            Color = new SolidColorBrush(
                Color.FromArgb(255, (byte)rnd.Next(0, 256), (byte)rnd.Next(0, 256), (byte)rnd.Next(0, 256)))
        });
    }

    return result;
}
#endregion

#region radchartview-populating-with-data-binding-the-color-of-series-items_2
public class CustomSelector : StyleSelector
{
    public override Style SelectStyle(object item, DependencyObject container)
    {
        var dataPoint = item as PieDataPoint;
        var dataItem = dataPoint.DataItem as ChartData;

        Style style = new Style(typeof(Path));
        style.Setters.Add(new Setter(Path.FillProperty, dataItem.Color));
        style.Setters.Add(new Setter(Path.StrokeProperty, new SolidColorBrush(Colors.White)));

        return style;
    }
}
#endregion


		}
	}
}
