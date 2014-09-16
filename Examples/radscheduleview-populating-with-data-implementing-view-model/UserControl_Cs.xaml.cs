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

#region radscheduleview-populating-with-data-implementing-view-model_1
public class MyViewModel
{
}
#endregion

#region radscheduleview-populating-with-data-implementing-view-model_3
private ObservableCollection<Appointment> appointments;
private ObservableCollection<ResourceType> resourceTypes;
public ObservableCollection<Appointment> Appointments
{
    get
    {
        return this.appointments;
    }
    set
    {
        this.appointments = value;
    }
}
public ObservableCollection<ResourceType> ResourcesTypes
{
    get
    {
        return this.resourceTypes;
    }
    set
    {
        this.resourceTypes= value;
    }
}
#endregion

#region radscheduleview-populating-with-data-implementing-view-model_5
private ObservableCollection<ResourceType> GenerateResourceTypes()
{
    ObservableCollection<ResourceType> result = new ObservableCollection<ResourceType>();
    ResourceType roomType = new ResourceType("Room");
    Resource room102 = new Resource("Room 102");
    Resource room203 = new Resource("Room 203");
    Resource room406 = new Resource("Room 406");
    roomType.Resources.Add(room102);
    roomType.Resources.Add(room203);
    roomType.Resources.Add(room406);
    ResourceType speakerType = new ResourceType("Speaker");
    Resource tomSpeaker = new Resource("Tom");
    Resource peterSpeaker = new Resource("Peter");
    speakerType.Resources.Add(tomSpeaker);
    speakerType.Resources.Add(peterSpeaker);
    result.Add(roomType);
    result.Add(speakerType);
    return result;
}
#endregion

#region radscheduleview-populating-with-data-implementing-view-model_7
public MyViewModel()
{
    this.resourceTypes = this.GenerateResourceTypes();
    this.appointments = new ObservableCollection<Appointment>();
}
#endregion

#region radscheduleview-populating-with-data-implementing-view-model_10
this.DataContext = new MyViewModel();
#endregion
}
