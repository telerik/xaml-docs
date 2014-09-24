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

#region gridview-setting-filters-programmatically_0
public class CustomFD : FilterDescription 
{ 
    private string filterValue;  
    private string rowHeader; 
public CustomFD(string filter, string header) 
{ 
   this.filterValue = filter; 
   this.rowHeader = header; 
} 
public override bool SatisfiesFilter(object dataItem)
{
    DataRow row = (DataRow)dataItem;
    if(row[rowHeader].ToString() == filterValue) return true;
    return false;
  } 
}
#endregion

#region gridview-setting-filters-programmatically_2
CompositeFilterDescriptor compositeFD = new CompositeFilterDescriptor();
compositeFD.FilterDescriptors.Add(new CustomFD("Bulgaria", "Country");
compositeFD.FilterDescriptors.Add(new CustomFD("Sofia", "City"); 
filteringRadGridView.FilterDescriptors.Add(compositeFD);
#endregion
}
