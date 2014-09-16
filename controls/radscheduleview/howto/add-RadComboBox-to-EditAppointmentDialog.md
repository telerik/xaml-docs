---
title: Add RadComboBox to a custom EditAppointmentDialog
page_title: Add RadComboBox to a custom EditAppointmentDialog
description: Add RadComboBox to a custom EditAppointmentDialog
slug: radscheduleview-howto-add-radcombobox-to-editappointmentdialog
tags: add,radcombobox,to,a,custom,editappointmentdialog
publish: True
position: 1
---

# Add RadComboBox to a custom EditAppointmentDialog



This tutorial explains how to bind additional controls in a custom EditAppointmentDialog to properties in the ViewModel of the __RadScheduleView__.
      

Before we proceed, check these topics:

* [Implementing View-ViewModel]({%slug radscheduleview-populating-with-data-implementing-view-model%})

* [Custom Dialogs]({%slug radscheduleview-features-custom-dialogs%})

* [Custom Appointment]({%slug radscheduleview-features-appointments-custom-appointment%})

Let’s have the following __RadScheduleView__ with EditAppointmentDialogStyle set to the generated Style:
      

#### __XAML__

{{region radscheduleview-howto-add-RadComboBox-to-EditAppointmentDialog_0}}
	<telerik:RadScheduleView x:Name="ScheduleView"
	    AppointmentsSource="{Binding Appointments}"
	    EditAppointmentDialogStyle="{StaticResource EditAppointmentDialogStyle}">
	   <telerik:RadScheduleView.ViewDefinitions>
	       <telerik:DayViewDefinition />
	 …
	   </telerik:RadScheduleView.ViewDefinitions>
	</telerik:RadScheduleView>
	{{endregion}}



RadComboBox is added to the ControlTemplate of the EditAppointmentDialog:

#### __XAML__

{{region radscheduleview-howto-add-RadComboBox-to-EditAppointmentDialog_1}}
	<ControlTemplate x:Key="EditAppointmentTemplate" TargetType="local:SchedulerDialog">
	  ... 
	    <telerik:RadComboBox  />
	  ...    
	</ControlTemplate>
	{{endregion}}



The ViewModel of the __ScheduleView__ has an additional property called “ComboBoxItems” which will be used to populate it:
      

#### __C#__

{{region radscheduleview-howto-add-RadComboBox-to-EditAppointmentDialog_2}}
	public class MyViewModel:ViewModelBase
	{
	    public ObservableCollection<Appointment> Appointments
	    {
	        get;
	        private set;
	    }
	    public ObservableCollection<string> ComboBoxItems
	    {
	        get;
	        private set;
	    }
	    public MyViewModel()
	    {
	        Appointments = new ObservableCollection<Appointment>() {
	            new Appointment() {
	                Subject="test app",
	                Start = DateTime.Now,
	                End = DateTime.Now.AddHours(2)
	            }
	        };
	        ComboBoxItems = new ObservableCollection<string>() {
	            "item1", "item2", "item3"
	        };
	    }
	}
	{{endregion}}



#### __VB.NET__

{{region radscheduleview-howto-add-RadComboBox-to-EditAppointmentDialog_3}}
	Public Class MyViewModel
	    Public Property Appointments() As ObservableCollection(Of Appointment)
	        Get
	            Return m_Appointments
	        End Get
	        Private Set(value As ObservableCollection(Of Appointment))
	            m_Appointments = value
	        End Set
	    End Property
	    Private m_Appointments As ObservableCollection(Of Appointment)
	    Public Property ComboBoxItems() As ObservableCollection(Of String)
	        Get
	            Return m_ComboBoxItems
	        End Get
	        Private Set(value As ObservableCollection(Of String))
	            m_ComboBoxItems = value
	        End Set
	    End Property
	    Private m_ComboBoxItems As ObservableCollection(Of String)
	
	    Public Sub New()
	        Appointments = New ObservableCollection(Of Appointment)() From {
	         New Appointment() With {
	          .Subject = "test app",
	          .Start = DateTime.Now,
	         .[End] = DateTime.Now.AddHours(2)
	        }
	        }
	        ComboBoxItems = New ObservableCollection(Of String)() From {
	         "item1",
	         "item2",
	         "item3"
	        }
	    End Sub
	End Class
	{{endregion}}



## 

If the DataContext is set in XAML:

#### __XAML__

{{region radscheduleview-howto-add-RadComboBox-to-EditAppointmentDialog_5}}
	<UserControl.Resources>
	    <my:MyViewModel x:Key="MyViewModel" />
	    ...
	</UserControl.Resources>
	{{endregion}}



The ItemsSource can be bound like this:

#### __XAML__

{{region radscheduleview-howto-add-RadComboBox-to-EditAppointmentDialog_6}}
	<telerik:RadComboBox ItemsSource="{Binding Source={StaticResource MyViewModel}, Path=ComboBoxItems, Mode=TwoWay}" />
	{{endregion}}



Here is the result:




               
            ![RadComboBox in EditAppointmentDialog](images/radscheduleview_addcomboboxtoeditappointmentdialog.png)



>tipIn order to preselect a certain item in the RadComboBox,  bind __SelectedItem__  to a  property in your [custom appointment]({%slug radscheduleview-features-appointments-custom-appointment%}) class:
          

#### __XAML__

{{region radscheduleview-howto-add-RadComboBox-to-EditAppointmentDialog_4}}
	<telerik:RadComboBox SelectedItem="{Binding Occurrence.Appointment.ComboBoxItem, Mode=TwoWay}"
	            ItemsSource="{Binding Source={StaticResource MyViewModel}, Path=ComboBoxItems, Mode=TwoWay}" />
	{{endregion}}


