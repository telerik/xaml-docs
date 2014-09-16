---
title: Implementing View-ViewModel 
page_title: Implementing View-ViewModel 
description: Implementing View-ViewModel 
slug: radscheduleview-populating-with-data-implementing-view-model
tags: implementing,view-viewmodel,
publish: True
position: 1
---

# Implementing View-ViewModel 



## 

The purpose of this tutorial is to show you how to bind a __RadScheduleView__ with a ViewModel.
        

>Before reading this tutorial you should get familiar with the [Data Binding]({%slug radscheduleview-populating-with-data-data-binding-support-overview%}) support of the __RadScheduleView__ control.
          

* 
            Add a new __RadScheduleView__ declaration in your XAML
            

#### __XAML__

{{region radscheduleview-populating-with-data-implementing-view-model_0}}
	<telerik:RadScheduleView />
	{{endregion}}



* 
            Create a new class named __MyViewModel__.
            

#### __C#__

{{region radscheduleview-populating-with-data-implementing-view-model_1}}
	public class MyViewModel
	{
	}
	{{endregion}}



#### __VB.NET__

{{region radscheduleview-populating-with-data-implementing-view-model_2}}
	Public Class MyViewModel
	End Class
	{{endregion}}



* 
            In the __MyViewModel__class add two properties:
            

1. __Appointments__ - we will bind the __AppointmentsSource__ property of the __RadScheduleView__ to this property.
              

1. __ResourcesTypes__- we will bind the __ResourceTypesSource__property of the __RadScheduleView__ to this property.
              

#### __C#__

{{region radscheduleview-populating-with-data-implementing-view-model_3}}
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
	{{endregion}}



#### __VB.NET__

{{region radscheduleview-populating-with-data-implementing-view-model_4}}
	Private m_Appointments As ObservableCollection(Of Appointment)
	Private m_ResourceTypes As ObservableCollection(Of ResourceType)
	
	Public Property Appointments() As ObservableCollection(Of Appointment)
		Get
			Return Me.m_Appointments
		End Get
		Private Set(value As ObservableCollection(Of Appointment))
			Me.m_Appointments = value
		End Set
	End Property
	
	Public Property ResourceTypes() As ObservableCollection(Of ResourceType)
		Get
			Return Me.m_ResourceTypes
		End Get
		Private Set(value As ObservableCollection(Of ResourceType))
			Me.m_ResourceTypes = value
		End Set
	End Property
	{{endregion}}



* 
            Let's create a method in the ViewModel that generates some Resources:
            

#### __C#__

{{region radscheduleview-populating-with-data-implementing-view-model_5}}
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
	{{endregion}}



#### __VB.NET__

{{region radscheduleview-populating-with-data-implementing-view-model_6}}
	Private Function GenerateResourceTypes() As ObservableCollection(Of ResourceType)
	 Dim result As New ObservableCollection(Of ResourceType)()
	 Dim roomType As New ResourceType("Room")
	 Dim room102 As New Resource("Room 102")
	 Dim room203 As New Resource("Room 203")
	 Dim room406 As New Resource("Room 406")
	 roomType.Resources.Add(room102)
	 roomType.Resources.Add(room203)
	 roomType.Resources.Add(room406)
	 Dim speakerType As New ResourceType("Speaker")
	 Dim tomSpeaker As New Resource("Tom")
	 Dim peterSpeaker As New Resource("Peter")
	 speakerType.Resources.Add(tomSpeaker)
	 speakerType.Resources.Add(peterSpeaker)
	 result.Add(roomType)
	 result.Add(speakerType)
	 Return result
	End Function
	{{endregion}}



* 
            All we have to do is to initialize the __resourceTypes__ and __appointments__ fields:
            

#### __C#__

{{region radscheduleview-populating-with-data-implementing-view-model_7}}
	public MyViewModel()
	{
	    this.resourceTypes = this.GenerateResourceTypes();
	    this.appointments = new ObservableCollection<Appointment>();
	}
	{{endregion}}



#### __VB.NET__

{{region radscheduleview-populating-with-data-implementing-view-model_8}}
	Public Sub New()
	 Me.resourceTypes = Me.GenerateResourceTypes()
	 Me.appointments = New ObservableCollection(Of Appointment)()
	End Sub
	{{endregion}}



* 
            The ViewModel is complete. Now, let's return to the View. Add some __ViewDefinitions__, __GroupDescriptionsSource__ and bind the __AppointmentsSource__ and __ResourceTypes__

#### __XAML__

{{region radscheduleview-populating-with-data-implementing-view-model_9}}
	<telerik:RadScheduleView AppointmentsSource="{Binding Appointments}" 
	                         ResourceTypesSource="{Binding ResourcesTypes}" >
	    <telerik:RadScheduleView.ViewDefinitions>
	        <telerik:DayViewDefinition />
	        <telerik:WeekViewDefinition />
	        <telerik:TimelineViewDefinition />
	    </telerik:RadScheduleView.ViewDefinitions>
	    <telerik:RadScheduleView.GroupDescriptionsSource>
	        <telerik:GroupDescriptionCollection>
	            <telerik:DateGroupDescription />
	            <telerik:ResourceGroupDescription ResourceType="Speaker" />
	            <telerik:ResourceGroupDescription ResourceType="Room" />
	        </telerik:GroupDescriptionCollection>
	    </telerik:RadScheduleView.GroupDescriptionsSource>
	</telerik:RadScheduleView>
	{{endregion}}



* 
            Finally, set the DataContext:
            

#### __C#__

{{region radscheduleview-populating-with-data-implementing-view-model_10}}
	this.DataContext = new MyViewModel();
	{{endregion}}



#### __VB.NET__

{{region radscheduleview-populating-with-data-implementing-view-model_11}}
	Me.DataContext = New MyViewModel()
	{{endregion}}



# See Also

 * [Implementing View-ViewModel ]({%slug radscheduleview-populating-with-data-implementing-view-model%})
