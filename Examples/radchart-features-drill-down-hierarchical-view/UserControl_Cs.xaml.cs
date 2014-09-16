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

#region radchart-features-drill-down-hierarchical-view_0
public class Company
{
    public string Name
    {
        get;
        set;
    }
    public ModelSalesCollection Sales
    {
        get;
        set;
    }
}
#endregion

#region radchart-features-drill-down-hierarchical-view_2
public class ModelSalesCollection : List<ModelSales>
{
    public double TotalAmount
    {
        get
        {
            return this.Sum( modelSales => modelSales.Amount );
        }
    }
}
#endregion

#region radchart-features-drill-down-hierarchical-view_4
public class ModelSales
{
    public string Model
    {
        get;
        set;
    }
    public double Amount
    {
        get;
        set;
    }
    public ModelSales( string model, double amount )
    {
        this.Model = model;
        this.Amount = amount;
    }
}
#endregion

#region radchart-features-drill-down-hierarchical-view_6
private List<Company> GetChartData()
{
    return new List<Company>() { 
        new Company() { 
            Name="ToyYoda",
            Sales = new ModelSalesCollection() { 
                new ModelSales("Coolla", 120000),
                new ModelSales("Coolla", 115000),
                new ModelSales("Veso", 89000),
                new ModelSales("Veso", 79000)
            }
        },
        new Company() { 
            Name="Marda",
            Sales =new ModelSalesCollection() {
                new ModelSales("Tree", 145000),
                new ModelSales("Tree", 132000),
                new ModelSales("Six", 121000),
                new ModelSales("Six", 111000)
            }
        }
    };
}
#endregion
}
