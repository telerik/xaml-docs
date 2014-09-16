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

#region radscheduleview-features-resources_0
ResourceType locationResource = new ResourceType("Location");
locationResource.Resources.Add(new Resource("Room 1"));
locationResource.Resources.Add(new Resource("Room 2"));
locationResource.Resources.Add(new Resource("Room 3"));

this.scheduleView.ResourceTypesSource = new ResourceTypeCollection
{
    locationResource
};

GroupDescriptionCollection groupDescription = new GroupDescriptionCollection
{
    new DateGroupDescription(),
    new ResourceGroupDescription{ ResourceType = "Location" }                
};

this.scheduleView.GroupDescriptionsSource = groupDescription;
#endregion
}
