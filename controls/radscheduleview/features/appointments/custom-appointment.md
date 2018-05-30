---
title: Custom Appointment
page_title: Custom Appointment
description: Custom Appointment
slug: radscheduleview-features-appointments-custom-appointment
tags: custom,appointment
published: True
position: 0
---

# Custom Appointment

A very common scenario when using RadScheduleView is the usage of custom appointments. When you create a __Custom Appointment__ class you gain the ability to append additional properties to the base Appointment class, to add them to your custom AppointmentItem and optionally to its ToolTip, display them in the EditAppointment dialog while supporting the cancelation of editing.      

In this article we will explore the process of using custom appointments in RadScheduleView. We will go through the following steps:

* [Create a custom appointment class and populate the RadScheduleView control with custom appointments](#creating-a-custom-appointment-class)

* [Modify the EditAppointment dialog to display the custom data of the newly created custom appointment class](#creating-a-custom-appointment-dialog)

* [Customize the AppointmentItem and its ToolTip to display the new data ](#changing-the-style-of-the-appointmentitem)

## Creating a Custom Appointment class

To create a custom appointment class you can start off with either of the following approaches : you can implement the __IAppointment__ interface or  you can inherit from one of the classes that already implement this interface – __AppointmentBase__ (the base implementation of the interface) or __Appointment__ (an extended implementation). It is very important to provide your own implementations for the __Copy__ and __CopyFrom__ methods as they are used intensively in the editing process of the ScheduleView control. If you choose to implement the interface, the Copy and CopyFrom methods will be automatically implemented for you, but if you take the second approach and inherit from one of the base classes, you should keep this in mind.        

Let's create a simple task tracking system. For our Custom Appointment class we will inherit from __Appointment__. Out tracking system will need  to show an additional field for the task progress – an indication of whether the task has finished or not. In order to enable editing in transactions of the new property we need to use the __Storage__ method of the __AppointmentBase__ class to access the instance which owns the fields. We will name our custom appointment class __Task.__ Here is the creation of the Custom Appointment class:        

>importantWhen inheriting the AppointmentBase class it is required to create a parameter-less constructor for the the custom class.

#### __C#__

{{region radscheduleview-features-appointments-custom-appointment_0}}
	public class Task:Appointment
	{
	    private bool isDone;
	    public bool IsDone
	    {
	        get
	        {
	             return this.Storage<Task>().isDone;
	        }
	        set
	        {
	             var storage = this.Storage<Task>();
	             if (storage.isDone != value)
	             {
	                  storage.isDone = value;
	                  this.OnPropertyChanged(() => this.IsDone);
	             }
	        }
	    }
	    public override IAppointment Copy()
	    {
	        var newAppointment = new Task();
	        newAppointment.CopyFrom(this);
	        return newAppointment;
	    }
	    public override void CopyFrom(IAppointment other)
	    {
	        var task = other as Task;
	        if (task != null)
	        {
	                this.IsDone = task.IsDone;
	        }
	        base.CopyFrom(other);
	    }
	}
{{endregion}}

#### __VB.NET__

{{region radscheduleview-features-appointments-custom-appointment_1}}
	Public Class Task
	 Inherits Appointment
	 Private m_isDone As Boolean
	 Public Property IsDone() As Boolean
	  Get
	   Return Me.Storage(Of Task)().m_isDone
	  End Get
	  Set
	   Dim storage = Me.Storage(Of Task)()
	   If storage.m_isDone <> value Then
	    storage.m_isDone = value
	    Me.OnPropertyChanged("IsDone")
	   End If
	  End Set
	 End Property
	 Public Overrides Function Copy() As IAppointment
	  Dim newAppointment = New Task()
	  newAppointment.CopyFrom(Me)
	  Return newAppointment
	 End Function
	 Public Overrides Sub CopyFrom(other As IAppointment)
	  Dim task = TryCast(other, Task)
	  If task IsNot Nothing Then
	   Me.IsDone = task.IsDone
	  End If
	  MyBase.CopyFrom(other)
	 End Sub
	End Class
{{endregion}}

For the next step, it is important to set the __AppointmentsSource__ of RadScheduleView to be of type __IList<Task>__, because this way the ScheduleView knows that our custom appointments should be of type __Task__. Let's create an __ObservableCollection<Task>__ using the following approach:        

#### __C#__

{{region radscheduleview-features-appointments-custom-appointment_2}}
	public class TasksCollection : ObservableCollection<Task>
	{
	    public TasksCollection()
	    {
	         DateTime today = DateTime.Today;
	         foreach (Task t in Enumerable.Range(9, 14).Select(i =>
	            new Task
	            {
	                 Start = today.AddMinutes(i * 60 + 15),
	                 End = today.AddMinutes((i + 1) * 60),
	                 Subject = string.Format("Task num. {0}",i),
	                 IsDone = today.AddMinutes((i + 1) * 60) < DateTime.Now
	             }))
	         {
	          this.Add(t);
	         }
	    }
	}
{{endregion}}

#### __VB.NET__

{{region radscheduleview-features-appointments-custom-appointment_3}}
	Dim today = DateTime.Today
	Dim data = New ObservableCollection(Of Task)(Enumerable.Range(9, 14).Select(Function(i) New Task() With { _
	 .Start = today.AddMinutes(i * 60 + 15), _
	 .[End] = today.AddMinutes((i + 1) * 60), _
	 .Subject = String.Format("Task num. {0}", i), _
	 .IsDone = today.AddMinutes((i + 1) * 60) < DateTime.Now _
	}))
	Me.DataContext = data
{{endregion}}

And here is the result so far:

![](images/custom_appointment1.png)

## Creating a custom Appointment Dialog

In order to create a custom appointment dialog we are going to modify the __EditAppointmentDialogStyle__ property of __RadScheduleView__ control. The DataContext of the __TargetType__ of this style is an __AppointmentDialogViewModel__ object. This class contains all needed data for editing an appointment including the Appointment itself. It can be reached by using the __Occurrence__ property of the ViewModel and subsequently the __Appointment__ property of __Occurrence.__ Now that we have our custom IsDone property, let's add a CheckBox for it and bind to it. First, you need to generate the code for the EditAppointment dialog from Expression Blend. Then, add the following snippet in the ControlTemplate of the dialog:

#### __XAML__

{{region radscheduleview-features-appointments-custom-appointment_4}}
	<CheckBox Grid.Row="4" Grid.Column="1" Margin="3" Content="Is done?" IsChecked="{Binding Occurrence.Appointment.IsDone, Mode=TwoWay}"/>
{{endregion}}

Here is our customized EditAppointment dialog:

![](images/custom_appointment2.PNG)

>tipThe important thing to note here is that we can bind to our new properties using __Occurrence.Appointment__.

##  Changing the Style of the AppointmentItem

Next, we are going to change the ControlTemplate of the AppointmentItem to reflect which tasks are done and which are not. We will do that by using the __AppointmentItemStyleSelector__ property of the __RadScheduleView__:

![](images/custom_appointment3.png)

The __DataContext__ in the AppointmentItem ContentTemplate represents an __AppointmentProxy__, which holds the most important properties of the Appointment and the Appointment itself. We want to display a green dot for all tasks that are done. We will achieve this by adding a green dot in the __ContentTemplate__ and then binding its __Visibility__ to the __IsDone__ property of the __Task__ through a converter. Here is the code for this:

#### __XAML__

{{region radscheduleview-features-appointments-custom-appointment_5}}
	<Ellipse Fill="Green" Width="12" Height="12" VerticalAlignment="Top" Margin="10 5 5 5" HorizontalAlignment="Left" Visibility="{Binding Appointment.IsDone, Converter={StaticResource BooleanToVisibilityConverter}}" />
{{endregion}}

## Customizing the Appointment ToolTip

This step is, of course, optional. The customization of the Appointment ToolTip is achieved by the __ToolTipTemplate__ property of __RadScheduleView__.The DataContext in this template is once again of type __AppointmentProxy__ so we can use the same approach we used in the AppointmentItem ContentTemplate. Generate the ToolTipTemplate:

![](images/custom_appointment6.png)

Now we will add in the Appointment ToolTip the text (Done) only for the tasks which are already done:

#### __XAML__

{{region radscheduleview-features-appointments-custom-appointment_6}}
	<DataTemplate x:Key="ToolTipTemplate">
	   <StackPanel Orientation="Horizontal" MinWidth="140" Margin="0 5">
	      <TextBlock MaxWidth="200" TextWrapping="Wrap" Text="{Binding Subject}"/>
	      <TextBlock Text="(Done)" Grid.Row="1" Margin="5 0 5 0" Foreground="#FF191D1A" Visibility="{Binding Appointment.IsDone, Converter={StaticResource BooleanToVisibilityConverter}}" FontStyle="Italic" />
	   </StackPanel> 
	</DataTemplate>
{{endregion}}

This is what the Appointment ToolTip should look like now:

![](images/custom_appointment7.png)

By completing this last modification, we have reached the end of the process needed to create a custom appointment in RadScheduleView control.

## See Also

 * [Understanding Appointments]({%slug radscheduleview-getting-started-add-edit-delete-appointment%})
