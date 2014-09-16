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
#region radpropertygrid-scrolling_0
this.PropertyGrid1.Item = new Employee()
{
    FirstName = "Sarah",
    LastName = "Blake",
    Ocupation = "Supplied Manager",
    IsMarried = true,
    Salary = 3500
};

#endregion

#region radpropertygrid-scrolling_1
private void Button1_Click(object sender, RoutedEventArgs e)
{
    var propertyDefinition = this.PropertyGrid1.PropertyDefinitions.Where(x=>x.DisplayName == "IsMarried").FirstOrDefault();
    if (propertyDefinition != null)
    {
        PropertyGrid1.ScrollIntoViewAsync(propertyDefinition, new Action<PropertyGridField>(f => f.IsSelected = true));
    }
}
#endregion
}
