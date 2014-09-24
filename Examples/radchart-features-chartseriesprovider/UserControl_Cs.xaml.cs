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
	
#region radchartview-features-chartseriesprovider_0
public class SalesInfo 
{
    public string MonthName { get; set; }
    public double Sales { get; set; }
}

public class VendorYearlyData
{
    public string VendorName { get; set; }
    public ObservableCollection<SalesInfo> Data { get; set; }
}

public class MainViewModel
{
    public ObservableCollection<VendorYearlyData> Data { get; set; }

    public MainViewModel()
    {
        this.Data = GetSampleData();
    }

    private ObservableCollection<VendorYearlyData> GetSampleData()
    {
        var result = new ObservableCollection<VendorYearlyData>();

        result.Add(new VendorYearlyData()
        {
            VendorName = "Vendor A",
            Data = new ObservableCollection<SalesInfo>()
            {
                new SalesInfo() { MonthName = "Jan", Sales = 5 },
                new SalesInfo() { MonthName = "Feb", Sales = 7 },
                new SalesInfo() { MonthName = "Mar", Sales = 6 },
                new SalesInfo() { MonthName = "Apr", Sales = 8 }
            }
        });

        result.Add(new VendorYearlyData()
        {
            VendorName = "Vendor B",
            Data = new ObservableCollection<SalesInfo>()
            {
                new SalesInfo() { MonthName = "Jan", Sales = 15 },
                new SalesInfo() { MonthName = "Feb", Sales = 18 },
                new SalesInfo() { MonthName = "Mar", Sales = 19 },
                new SalesInfo() { MonthName = "Apr", Sales = 23 }
            }
        });


        result.Add(new VendorYearlyData()
        {
            VendorName = "Vendor C",
            Data = new ObservableCollection<SalesInfo>()
            {
                new SalesInfo() { MonthName = "Jan", Sales = 21 },
                new SalesInfo() { MonthName = "Feb", Sales = 25 },
                new SalesInfo() { MonthName = "Mar", Sales = 26 },
                new SalesInfo() { MonthName = "Apr", Sales = 25 }
            }
        });

        return result;
    }
}
#endregion


	}
}
