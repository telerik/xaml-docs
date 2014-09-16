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

#region gridview-programmatic-grouping-definition_0
public Example()
{      
  InitializeComponent();                                 
  GroupDescriptor shipCountry = new GroupDescriptor();
  shipCountry.Member = "ShipCountry";
  shipCountry.SortDirection = ListSortDirection.Ascending;
  this.GridView.GroupDescriptors.Add(shipCountry);
}
#endregion

#region gridview-programmatic-grouping-definition_3
GroupDescriptor shipCountry = new GroupDescriptor();
shipCountry.Member = "ShipCountry";
shipCountry.SortDirection = ListSortDirection.Ascending;
CountFunction countFunction = new CountFunction();
countFunction.Caption = "Invoices count: ";
shipCountry.AggregateFunctions.Add(countFunction);
FirstFunction firstFunction = new FirstFunction();
firstFunction.Caption = "First City: ";
shipCountry.AggregateFunctions.Add(firstFunction);
this.GridView.GroupDescriptors.Add(shipCountry);
#endregion
}
