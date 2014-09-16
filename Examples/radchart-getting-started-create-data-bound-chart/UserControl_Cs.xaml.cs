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

#region radchart-getting-started-create-data-bound-chart_1
public class ProductSales
{
    public ProductSales( int quantity, int month, string monthName )
    {
        this.Quantity = quantity;
        this.Month = month;
        this.MonthName = monthName;
    }
    public int Quantity
    {
        get;
        set;
    }
    public int Month
    {
        get;
        set;
    }
    public string MonthName
    {
        get;
        set;
    }
}
#endregion

#region radchart-getting-started-create-data-bound-chart_3
private List<ProductSales> CreateData()
{
    List<ProductSales> persons = new List<ProductSales>();
    persons.Add( new ProductSales( 154, 1, "January" ) );
    persons.Add( new ProductSales( 138, 2, "February" ) );
    persons.Add( new ProductSales( 143, 3, "March" ) );
    persons.Add( new ProductSales( 120, 4, "April" ) );
    persons.Add( new ProductSales( 135, 5, "May" ) );
    persons.Add( new ProductSales( 125, 6, "June" ) );
    persons.Add( new ProductSales( 179, 7, "July" ) );
    persons.Add( new ProductSales( 170, 8, "August" ) );
    persons.Add( new ProductSales( 198, 9, "September" ) );
    persons.Add( new ProductSales( 187, 10, "October" ) );
    persons.Add( new ProductSales( 193, 11, "November" ) );
    persons.Add( new ProductSales( 212, 12, "December" ) );
    return persons;
}
#endregion

#region radchart-getting-started-create-data-bound-chart_6
SeriesMapping seriesMapping = new SeriesMapping();
seriesMapping.LegendLabel = "Product Sales";
seriesMapping.SeriesDefinition = new SplineSeriesDefinition();
seriesMapping.ItemMappings.Add( new ItemMapping( "Month", DataPointMember.XValue ) );
seriesMapping.ItemMappings.Add( new ItemMapping("Quantity", DataPointMember.YValue));
radChart.SeriesMappings.Add( seriesMapping );
this.radChart.ItemsSource = this.CreateData();
#endregion

#region radchart-getting-started-create-data-bound-chart_8
this.radChart.ItemsSource = this.CreateData();
#endregion

#region radchart-getting-started-create-data-bound-chart_11
seriesMapping.ItemMappings.Add( new ItemMapping( "MonthName", DataPointMember.XCategory ) );
#endregion
}
