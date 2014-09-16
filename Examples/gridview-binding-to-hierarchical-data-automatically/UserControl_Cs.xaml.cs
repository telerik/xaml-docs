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

#region gridview-binding-to-hierarchical-data-automatically_0
public partial class Example : ExampleControl
        {
             private TableDefinition tableDefinition;
             public Example()
        {
        InitializeComponent();
        NWindDataSet dataSet = new
        NWindDataSet();
        OrdersTableAdapter ordersAdapter =
        new OrdersTableAdapter();
        ordersAdapter.Fill(dataSet.Orders);
        Order_DetailsTableAdapter detailAdapter
        = new Order_DetailsTableAdapter();
        detailAdapter.Fill(dataSet.Order_Details);
        radGridView1.AutoGenerateHierarchyFromDataSet = true;
        radGridView1.DataMember = dataSet.Tables["Orders"].TableName;
        radGridView1.ItemsSource = dataSet;
        }
        }
#endregion
}
