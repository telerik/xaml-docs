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
				
#region radchartview-populating-with-data-binding-to-data-table_0
DataTable dt = new DataTable();
dt.Columns.Add("Expected", typeof(double));
dt.Columns.Add("Actual", typeof(double));
dt.Columns.Add("Month", typeof(DateTime));

dt.Rows.Add(30, 28, new DateTime(2013, 1, 1));
dt.Rows.Add(45, 32, new DateTime(2013, 3, 1));
dt.Rows.Add(5, 23, new DateTime(2013, 5, 1));
dt.Rows.Add(10, 7, new DateTime(2013, 7, 1));
dt.Rows.Add(3, 2, new DateTime(2013, 11, 1));
dt.Rows.Add(7, 10, new DateTime(2013, 12, 1));

this.DataContext = dt.Rows;
#endregion
				
#region radchartview-populating-with-data-binding-to-data-table_2
this.barSeries1.ValueBinding = 
    new Telerik.Windows.Controls.ChartView.GenericDataPointBinding<DataRow, double>() 
    {
        ValueSelector = row => (double)row["Actual"]
    };

this.barSeries1.CategoryBinding = 
    new Telerik.Windows.Controls.ChartView.GenericDataPointBinding<DataRow, DateTime>()
    {
        ValueSelector = row => (DateTime)row["Month"]
    };

this.barSeries2.ValueBinding = 
    new Telerik.Windows.Controls.ChartView.GenericDataPointBinding<DataRow, double>()
    {
        ValueSelector = row => (double)row["Expected"]
    };

this.barSeries2.CategoryBinding = 
    new Telerik.Windows.Controls.ChartView.GenericDataPointBinding<DataRow, DateTime>()
    {
        ValueSelector = row => (DateTime)row["Month"]
    };
#endregion
		}
	}
}
