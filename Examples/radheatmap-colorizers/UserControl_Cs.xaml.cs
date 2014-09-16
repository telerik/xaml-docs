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
	
#region radheatmap-colorizers_1
public partial class MainPage : UserControl
{
	public MainPage()
	{
		InitializeComponent();
		radHeatMap.Definition.ItemsSource = CreateData();
	}

	public List<Car> CreateData()
	{
		var temp = new List<Car>()
		{
			new Car() {Name = "Car 1", Price = 20590, HorsePower = 70,  MilesPerGallon = 37, TopSpeed = 60 },
			new Car() {Name = "Car 2", Price = 21990, HorsePower = 70,  MilesPerGallon = 37, TopSpeed = 60 },
			new Car() {Name = "Car 3", Price = 23200, HorsePower = 140, MilesPerGallon = 28, TopSpeed = 110 },
			new Car() {Name = "Car 4", Price = 27500, HorsePower = 140, MilesPerGallon = 28, TopSpeed = 110 },
			new Car() {Name = "Car 5", Price = 28200, HorsePower = 160, MilesPerGallon = 31, TopSpeed = 120 },
			new Car() {Name = "Car 6", Price = 29500, HorsePower = 90,  MilesPerGallon = 35, TopSpeed = 80 },
			new Car() {Name = "Car 7", Price = 31200, HorsePower = 160, MilesPerGallon = 31, TopSpeed = 120 },
			new Car() {Name = "Car 8", Price = 32200, HorsePower = 90,  MilesPerGallon = 35, TopSpeed = 80 },
            new Car() {Name = "Car 9", Price = 35200, HorsePower = 115, MilesPerGallon = 29, TopSpeed = 90 },
            new Car() {Name = "Car 10", Price = 36700, HorsePower = 115, MilesPerGallon = 29, TopSpeed = 90 },
            new Car() {Name = "Car 11", Price = 38200, HorsePower = 130, MilesPerGallon = 24, TopSpeed = 140 },
            new Car() {Name = "Car 12", Price = 39700, HorsePower = 130, MilesPerGallon = 24, TopSpeed = 140 },
            new Car() {Name = "Car 13", Price = 41500, HorsePower = 326, MilesPerGallon = 16, TopSpeed = 150 },
            new Car() {Name = "Car 14", Price = 42200, HorsePower = 326, MilesPerGallon = 16, TopSpeed = 150 },
            new Car() {Name = "Car 15", Price = 43500, HorsePower = 276, MilesPerGallon = 25, TopSpeed = 162 },
            new Car() {Name = "Car 16", Price = 43500, HorsePower = 276, MilesPerGallon = 25, TopSpeed = 162 },
		};

		return temp;
	}
}
public class Car
{
	public string Name { get; set; }
	public int MilesPerGallon { get; set; }
	public int TopSpeed { get; set; }
	public int Price { get; set; }
	public int HorsePower { get; set; }
}
#endregion

#region radheatmap-colorizers_2
HeatMapValueGradientColorizer ValueGradientColorizer1 = new HeatMapValueGradientColorizer();
ValueGradientColorizer1.GradientStops.Add(new GradientStop() { Color = new Color() {R = 217, G = 231, B = 241}, Offset = 0 });
ValueGradientColorizer1.GradientStops.Add(new GradientStop() { Color = new Color() { R = 1, G = 81, B = 140 }, Offset = 1 });
memberMapping1.Colorizer = ValueGradientColorizer1;
#endregion

#region radheatmap-colorizers_3
HeatMapRangeColorizer RangeColorizer1 = new HeatMapRangeColorizer() { IsAbsolute = true };
RangeColorizer1.Colors.Add(new HeatMapRangeColor() { Color = new Color() { R = 217, G = 231, B = 241 }, From = 19, To = 2224 });
RangeColorizer1.Colors.Add(new HeatMapRangeColor() { Color = new Color() { R = 164, G = 194, B = 216 }, From = 23, To = 26 });
RangeColorizer1.Colors.Add(new HeatMapRangeColor() { Color = new Color() { R = 110, G = 156, B = 191 }, From = 27, To = 30 });
RangeColorizer1.Colors.Add(new HeatMapRangeColor() { Color = new Color() { R = 55, G = 118, B = 165 }, From = 31, To = 34 });
RangeColorizer1.Colors.Add(new HeatMapRangeColor() { Color = new Color() { R = 1, G = 81, B = 140 }, From = 35, To = 40 });
memberMapping2.Colorizer = RangeColorizer1;
#endregion

#region radheatmap-colorizers_4
HeatMapDesaturationColorizer DesaturationColorizer1 = new HeatMapDesaturationColorizer()
{
    StartColor = new Color() { R = 1, G = 81, B = 140 },
    To = 0.1,
};
memberMapping3.Colorizer = DesaturationColorizer1;
#endregion

#region radheatmap-colorizers_5
public partial class MainPage : UserControl
{
    public MainPage()
    {
        InitializeComponent();            
        radHeatMap.Definition.ItemsSource = CreateData();
    }

    public List<Car> CreateData()
    {
        var result = new List<Car>()
        {
            new Car() {Name = "Car 1", Price = 20590, HorsePower = 70,  MilesPerGallon = 37, TopSpeed = 60 },
            new Car() {Name = "Car 2", Price = 21990, HorsePower = 70,  MilesPerGallon = 37, TopSpeed = 60 },
            new Car() {Name = "Car 3", Price = 23200, HorsePower = 140, MilesPerGallon = 28, TopSpeed = 110 },
            new Car() {Name = "Car 4", Price = 27500, HorsePower = 140, MilesPerGallon = 28, TopSpeed = 110 },
            new Car() {Name = "Car 5", Price = 28200, HorsePower = 160, MilesPerGallon = 31, TopSpeed = 120 },
            new Car() {Name = "Car 6", Price = 29500, HorsePower = 90,  MilesPerGallon = 35, TopSpeed = 80 },
            new Car() {Name = "Car 7", Price = 31200, HorsePower = 160, MilesPerGallon = 31, TopSpeed = 120 },
            new Car() {Name = "Car 8", Price = 32200, HorsePower = 90,  MilesPerGallon = 35, TopSpeed = 80 },
            new Car() {Name = "Car 9", Price = 35200, HorsePower = 115, MilesPerGallon = 29, TopSpeed = 90 },
            new Car() {Name = "Car 10", Price = 36700, HorsePower = 115, MilesPerGallon = 29, TopSpeed = 90 },                
            new Car() {Name = "Car 11", Price = 38200, HorsePower = 130, MilesPerGallon = 24, TopSpeed = 140 },
            new Car() {Name = "Car 12", Price = 39700, HorsePower = 130, MilesPerGallon = 24, TopSpeed = 140 },
            new Car() {Name = "Car 13", Price = 41500, HorsePower = 326, MilesPerGallon = 16, TopSpeed = 150 },
            new Car() {Name = "Car 14", Price = 42200, HorsePower = 326, MilesPerGallon = 16, TopSpeed = 150 },
            new Car() {Name = "Car 15", Price = 43500, HorsePower = 276, MilesPerGallon = 25, TopSpeed = 162 },
            new Car() {Name = "Car 16", Price = 43500, HorsePower = 276, MilesPerGallon = 25, TopSpeed = 162 },
        };

        return result;
    }
}

public class Car
{
    public string Name { get; set; }
    public int MilesPerGallon { get; set; }
    public int TopSpeed { get; set; }
    public int Price { get; set; }
    public int HorsePower { get; set; }
}
#endregion

#region radheatmap-colorizers_6
public MainPage()
{
    InitializeComponent();            
    radHeatMap.Definition.ItemsSource = CreateWeatherData();
}

public List<MonthlyTemp> CreateWeatherData()
{
    var time = new DateTime(2004, 1, 1);
    var result = new List<MonthlyTemp>();
    Random r = new Random();

    for (int i = 0; i < 5; i++)
    {
        for (int a = 0; a < 3; a++)
        {
            result.Add(new MonthlyTemp(time, r.Next(0, 10)));
            time = time.AddMonths(1);
        }
        for (int a = 0; a < 3; a++)
        {
            result.Add(new MonthlyTemp(time, r.Next(10, 20)));
            time = time.AddMonths(1);
        }
        for (int a = 0; a < 3; a++)
        {
            result.Add(new MonthlyTemp(time, r.Next(20, 30)));
            time = time.AddMonths(1);
        }
        for (int a = 0; a < 3; a++)
        {
            result.Add(new MonthlyTemp(time, r.Next(10, 20)));
            time = time.AddMonths(1);
        }
    }            
    return result;
}

public class MonthlyTemp
{
    public DateTime Time { get; set; }
    public double Temp { get; set; }
    public MonthlyTemp(DateTime time, double temp)
    {
        this.Time = time;
        this.Temp = temp;
    }
}
#endregion

	}
	
}
