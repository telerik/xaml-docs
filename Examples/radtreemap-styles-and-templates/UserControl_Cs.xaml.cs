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
	   #region radtreemap-styles-and-templates_1
	   public MainPage()
{
    InitializeComponent();
    pivotMap.ItemsSource = this.GetData();
}

public class GdpInfo
{
    public string Continent { get; set; }
    public string Country { get; set; }
    public string City { get; set; }
    public double Gdp { get; set; }
}

public List<GdpInfo> GetData()
{
    List<GdpInfo> data = new List<GdpInfo>()
    {
        new GdpInfo() { Country = "Australia", Gdp = 1146 },
        new GdpInfo() { Country = "Austria", Gdp = 385.1 },
        new GdpInfo() { Country = "Belgium", Gdp = 468.6 },
        new GdpInfo() { Country = "Brazil", Gdp = 1749 },
        new GdpInfo() { Country = "Canada", Gdp = 1565 },
        new GdpInfo() { Country = "China", Gdp = 1700 },
        new GdpInfo() { Country = "Denmark", Gdp = 318.1 },
        new GdpInfo() { Country = "France", Gdp = 2669 },
        new GdpInfo() { Country = "Germany", Gdp = 3402 },
        new GdpInfo() { Country = "Greece", Gdp = 329 },
        new GdpInfo() { Country = "India", Gdp = 1290 },
        new GdpInfo() { Country = "USA", City = "NY which is in the NY state ", Gdp = 3000 },
        new GdpInfo() { Country = "USA", City = "Columbus which is in the Ohio state", Gdp = 2000 },
        new GdpInfo() { Country = "USA", City = "Los Angeles which is in the California state", Gdp = 5000 },
        new GdpInfo() { Country = "USA", City = "Austin which is in the Texas state", Gdp = 4600 },
    };
    return data;
}
	   #endregion
	}
}
