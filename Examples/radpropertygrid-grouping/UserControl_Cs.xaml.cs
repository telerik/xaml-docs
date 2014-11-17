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
#region radpropertygrid-grouping_0
Employee Employee = new Employee()
{
    FirstName = "Nancy",
    LastName = "Davolio",
    Title = "Sales Representative",
    HomePhone = "(206) 555-9857"
};
this.PropertyGrid1.Item = Employee;

#endregion
#region radpropertygrid-grouping_1
this.PropertyGrid1.ExpandGroup("Group Name");
#endregion

#region radpropertygrid-grouping_2
this.PropertyGrid1.CollapseGroup("Group Name");
#endregion

#region radpropertygrid-grouping_3
this.PropertyGrid1.ExpandAllGroups();
#endregion

#region radpropertygrid-grouping_4
this.PropertyGrid1.CollapseAllGroups();
#endregion

#region radpropertygrid-grouping_5
this.PropertyGrid1.GroupDefinitions.SuspendNotifications();

// Execute additional logic

this.PropertyGrid1.GroupDefinitions.ResumeNotifications();
#endregion

}
