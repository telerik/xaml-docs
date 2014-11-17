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

#region gridview-in-memory-date_1
public class Car
{
    public Car()
    {
    }
    public Car( string name, string description )
    {
        this.Name = name;
        this.Description = description;
    }
    public string Name
    {
        get;
        set;
    }
    public string Description
    {
        get;
        set;
    }
}
#endregion

#region gridview-in-memory-date_3
public class RadGridViewSampleData
{
}
#endregion

#region gridview-in-memory-date_5
public class RadGridViewSampleData
{
    public RadGridViewSampleData()
    {
        Cars = new ObservableCollection<Car>();
    }
    public ObservableCollection<Car> Cars
    {
        get;
        set;
    }
}
#endregion

#region gridview-in-memory-date_7
Cars.Add( new Car( "BMW", "A german luxury car." ) );
Cars.Add( new Car( "Porsche", "A german sports car." ) );
Cars.Add( new Car( "Citroen", "A french luxury car." ) );
Cars.Add( new Car( "Reno", "A french family car." ) );
#endregion
}
