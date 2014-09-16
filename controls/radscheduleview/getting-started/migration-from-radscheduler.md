---
title: Migration from RadScheduler
page_title: Migration from RadScheduler
description: Migration from RadScheduler
slug: radscheduleview-migration-from-radscheduler
tags: migration,from,radscheduler
publish: True
position: 3
---

# Migration from RadScheduler



The following article describes the migration process from the RadScheduler to the RadScheduleView control.

## 
<table><th><tr><td>

RadScheduler properties</td><td>

Corresponding way for ScheduleView</td></tr></th><tr><td><b>IsReadOnly</b></td><td>IsReadOnly property – you have to set it to SpecialSlotsSource collection. If you want to set ReadOnly for the whole ScheduleView (not specific days) just make the special slot covers all days.</td></tr><tr><td><b>Appointments</b></td><td><b>AppointmentsSource</b></td></tr><tr><td>

<b>AppointmentTemplate</b>/
              

<b>AppointmentTemplateSelector</b></td><td>

<b>AppointmentItemContentTemplate</b>/<b>AppointmentItemContentTemplateSelector</b>

<b>AppointmentStyleSelector</b> -> [http://demos.telerik.com/wpf?ScheduleView/CustomStyles/AppointmentStyle](http://demos.telerik.com/wpf?ScheduleView/CustomStyles/AppointmentStyle)</td></tr><tr><td><b>AllDayAreaHeight</b></td><td>
              Not supported with the current version. All-day appointments are now displayed as regular appointments and they are stretched across the timeruler for the whole day.
            </td></tr><tr><td><b>DisplayEmptyGroup</b></td><td>

You could use the <b>ResourceGroupDescription.ShowNullGroup</b> property. For example:
              

#### __XAML__

{{region radscheduleview-migration-from-radscheduler_0}}
	<telerik:RadScheduleView.GroupDescriptionsSource>
	    <telerik:GroupDescriptionCollection>
	     <telerik:ResourceGroupDescription ResourceType="Room" ShowNullGroup="True" />
	     <telerik:ResourceGroupDescription ResourceType="User"  />
	    </telerik:GroupDescriptionCollection>
	</telerik:RadScheduleView.GroupDescriptionsSource>
	{{endregion}}

</td></tr><tr><td><b>TimeRulerStyle</b></td><td><b>TimeRulerItemStyleSelector</b>, <b>TimeRulerItemTemplateSelector</b> (to make it work the <b>TimeRulerItemTemplateSelector</b> and <b>TimeRulerItemTemplate</b> must be set to <b>{x:Null}</b>)
              

{% if site.site_name == 'WPF' %}[http://demos.telerik.com/wpf/?ScheduleView/CustomStyles/TimeRulerStyle](http://demos.telerik.com/wpf/?ScheduleView/CustomStyles/TimeRulerStyle){% endif %}{% if site.site_name == 'Silverlight' %}[http://demos.telerik.com/silverlight/#ScheduleView/CustomStyles/TimeRulerStyle](http://demos.telerik.com/silverlight/#ScheduleView/CustomStyles/TimeRulerStyle){% endif %}</td></tr><tr><td><b>EditAppointmentStyle</b></td><td><b>EditAppointmentDialogStyle</b></td></tr><tr><td><b>IsBackAndForwardNavigationEnabled</b><b>IsViewModeNavigationEnabled</b></td><td><b>NavigationHeaderVisibility</b></td></tr><tr><td><b>ViewMode</b></td><td><b>ActiveViewDefinition</b>, <b>ActiveViewDefinitionIndex</b></td></tr><tr><td><b>GroupBy</b></td><td>

Add <b>GroupDescription</b> and to the <b>GroupDescriptionSource</b>. For example:
              

#### __XAML__

{{region radscheduleview-migration-from-radscheduler_1}}
	<telerik:RadScheduleView.GroupDescriptionsSource>
	<telerik:GroupDescriptionCollection>     <telerik:ResourceGroupDescription ResourceType="Category" />
	<telerik:ResourceGroupDescription ResourceType="Level" />
	</telerik:GroupDescriptionCollection>
	</telerik:RadScheduleView.GroupDescriptionsSource>
	{{endregion}}



[http://demos.telerik.com/wpf/?ScheduleView/Grouping/Basics](http://demos.telerik.com/wpf/?ScheduleView/Grouping/Basics)</td></tr><tr><td><b>View definitions</b> and properties
            </td><td>

#### __XAML__

{{region radscheduleview-migration-from-radscheduler_2}}
	<telerik:RadScheduleView.ViewDefinitions>
	 <telerik:DayViewDefinition VisibleDays="" FirstDayOfWeek=" " LargeChangeInterval="" MinorTickLength="" MinTimeRulerExtent="" Orientation=" " />
	 <telerik:WeekViewDefinition/>
	 <telerik:MonthViewDefinition/>
	 <telerik:TimelineViewDefinition/>
	</telerik:RadScheduleView.ViewDefinitions>
	{{endregion}}

</td></tr><tr><td><b>TimeSlotTemplateSelector</b></td><td><b>SpecialSlotStyleSelector</b>, <b>SpecialSlotsSource</b>

Please refer to [this article]({%slug radscheduleview-features-speacialslots%}).
              </td></tr><tr><td><b>AppointmentAdded</b>, <b>AppointmentAdding</b> events
            </td><td>
              Not supported. There is new event mechanism for the RadScheduleView control. Please, refer to [this]({%slug radscheduleview-events-overview%}) article.
            </td></tr><tr><td><b>ActiveViewDefinitionChanged</b>, <b>SelectedViewStartDateChanged</b> events
            </td><td><b>VisibleRangeChanged</b> event, <b>VisibleRangeChangedCommand</b> and <b>VisibleRangeChangedCommandParameter</b></td></tr><tr><td><b>AvailableViewModes</b></td><td>

Depends on which <b>ViewDefinitions</b> are defined:
              

#### __XAML__

{{region radscheduleview-migration-from-radscheduler_3}}
	<telerik:RadScheduleView.ViewDefinitions>
	 <telerik:DayViewDefinition  />
	 <telerik:WeekViewDefinition />
	 …
	 <telerik:TimelineViewDefinition />
	</telerik:RadScheduleView.ViewDefinitions>
	{{endregion}}

</td></tr><tr><td><b>Culture</b></td><td>There is no such property. Use LocalizationManager.DefaultCulture instead.</td></tr><tr><td><b>TimeFormatString</b>, <b>DayHeaderFormat</b>, <b>MonthViewDayHeaderDayFormat</b>, <b>MonthViewDayHeaderMonthFormat</b>, <b>TimelineHeaderFormat</b></td><td><b>TimerulerMajorTickStringFormat</b>, <b>GroupHeaderDateStringFormat</b>, <b>TimerulerMinorTickStringFormat</b> properties on the view definitions
            </td></tr><tr><td><b>ResourceStyleMapping</b></td><td><b>GroupHeaderStyleSelector</b> and <b>GroupHeaderContentTemplateSelector</b></td></tr><tr><td><b>Edit</b><b>Appointment</b> using code
              

</td><td>

Using the <b>BeginEdit()</b> method of the <b>RadScheduleView</b>, which returns whether or not the appointment or the occurrence can be edited. If <b>BeginEdit()</b> is True the appointment or occurrence can be edited. Call <b>Commit()</b> to commit the changes:
              

#### __C#__

{{region radscheduleview-migration-from-radscheduler_4}}
	if (this.radScheduleView.BeginEdit(appointment))
	{   
	    appointment.Subject = "New Subject";
	    this.radScheduleView.Commit();
	}
	{{endregion}}



#### __VB.NET__

{{region radscheduleview-migration-from-radscheduler_5}}
	If Me.radScheduleView.BeginEdit(appointment) Then
	 appointment.Subject = "New Subject"
	 Me.radScheduleView.Commit()
	End If
	{{endregion}}

</td></tr><tr><td><b>Delete Appointment</b> using code:
            </td><td>

Using the Remove() method of the RadScheduleView(), which returns whether or not the appointment or occurrence can be removed.

#### __C#__

{{region radscheduleview-migration-from-radscheduler_6}}
	this.radScheduleView.Remove(appointment);
	{{endregion}}



#### __VB.NET__

{{region radscheduleview-migration-from-radscheduler_7}}
	Me.radScheduleView.Remove(appointment)
	{{endregion}}



</td></tr><tr><td></td><td>

<b>TimeRuler</b> configuration:
              

- MaxTimeRulerExtent/ MinTimeRulerExtent - gets or sets the extend (the size) of the TimeRuler – width/height depending on the orientation of the view in pxl.
                - MinorTickLength – gets or sets the minimum time between the TimeSlots
                - MajorTickLength – sets the maximum time between the TimeSlots (usually the hours)
              </td></tr><tr><td><b>TimeSlotItemTemplateSelector</b></td><td>

<b>SpecialSlotStyleSelector:</b><b>-</b> Create NonWorkingSlots and WorkingSlots classes, which inherit the Slot. To be used in the ViewModel, which will be set as a source of the SpecialSlotSource and  in which will be defined the conditions for the special slots.
              - Create StyleSelector class which inherits ScheduleViewStyleSelector
              - Define the XAML for the styles

              

</td></tr><tr><td></td><td><b>Horizontal grouping</b>:
              - Set the Orientation property to Horizontal of the ViewDefinition in order to achieve horizontal grouping.
            </td></tr><tr><td></td><td><b>Change size of Appointment</b>:
              - MinAppointmentHeight – gets or sets the minimum heights of the Appointments in RadScheduleView when the orientation of the active ViewDefinition is set to Horizontal.
              - MinAppointmentWidth - gets or sets the minimum width of the Appointments in RadScheduleView when the orientation of the active ViewDefinition is set to Vertical.
            </td></tr><tr><td></td><td><b>SelectedAppointment</b> property – Gets or sets the selected appointment. This is the first appointment from <b>SelectedAppointments</b>. When set it removes all other selected appointments.
            </td></tr><tr><td><b>SelectedTimeSlot</b></td><td><b>SelectedSlot</b>. There is a difference between RadScheduler.SelectedTimeSlot and RadScheduleView.SelectedSlot properties. Please, note that the second one cannot be null. Also, the SelectedSlot is not responsible for the navigation throughout the ScheduleView's views, but the SelectedTimeSLot is.
            </td></tr></table>


<table> <th><tr><td>

RadScheduler events</td><td>

RadScheduleView events</td></tr></th><tr><td>

<b>AppointmentCreating</b> – occurs when an appointment is going to be created. Via the <b>AppointmentCreatingEventArgs</b> the following properties can be accessed:
              

* <b>NewAppointment</b> - gets or sets the appointment that is going to be added. By default this property is null. When you create a custom appointment here is the moment to pass it.
                

* <b>Cancel</b> - set this boolean property to True, when you want to cancel the event.
                </td><td>

<b>AppointmentCreating</b> – occurs when an appointment is going to be created. Via the AppointmentCreatingEventArgs you can access the following properties:
              

* <b>Appointment</b> - gets the newly created appointment. This property is read-only and you can use it to initialize the appointment.
                

* <b>Cancel</b> - set this boolean property to True, when you want to cancel the event
                </td></tr><tr><td>

<b>AppointmentCreated</b> - occurs when the new appointment is created and the edit appointment dialog window is about to be shown.
              

Via the <b>AppointmentCreatedEventArgs</b> you can access the following properties:
              

* <b>CreatedAppointment</b> - this is the newly created appointment, initialized with its default values. The property is read-only.
                </td><td>

<b>AppointmentCreated</b> - occurs when the new appointment is created and the edit appointment dialog window is about to be shown.
              

Via the <b>AppointmentCreatedEventArgs</b> you can access the following properties:
              

* <b>CreatedAppointment</b> - this is the newly created appointment, initialized with its default values. The property is read-only.
                </td></tr><tr><td><b>AppointmentAdding</b>, <b>AppointmentAdded</b></td><td>Not supported.</td></tr><tr><td>

<b>AppointmentEditing</b> - occurs when the appointment edit command is initialized and the edit appointment dialog window is about to be shown.
              

Via the <b>AppointmentEditingEventArgs</b> you can access the following properties:
              

* <b>Appointment</b> - the appointment that is going to be edited. The property is read-only.
                

* <b>AppointmentEditAction</b> - gets the appointment edit action. The property is read-only. The values for this property are predefined in the AppointmentEditAction enumeration, which exposes the following fields: Drag, Edit, Resize
                

* <b>ExceptionAction</b> - gets the exception action. The property is read-only. The values for this property are predefined in the ExceptionAction enumeration, which exposes the following fields: Add, Delete, Edit, None
                

* <b>ExceptionOccurrence</b> - gets the edited exception occurrence. The property is read-only. When you edit a regular appointment, this property is null.
                

* <b>Cancel</b> - set this boolean property to True, when you want to cancel the event.
                </td><td>

<b>AppointmentEditing</b> - occurs when the appointment edit command is initialized and the edit appointment dialog window is about to be shown.
              

Via the <b>AppointmentEditingEventArgs</b> you can access the following properties:
              

* <b>Appointment</b> - gets the appointment that is going to be edited. This property is read-only.
                

* <b>Occurrence</b> - gets the occurrence that is going to be edited. If the appointment is not recurrent, the value is null. This property is read-only.
                

* <b>Cancel</b> - set this boolean property to True, when you want to cancel the event.
                </td></tr><tr><td>

<b>AppointmentDeleting</b> - occurs when the appointment is going to be removed from the data source.
              

Via the <b>AppointmentDeletingEventArgs</b> you can access the following properties:
              

* <b>Appointment</b> - the appointment that is going to be deleted from the data source. The property is read-only.
                

* <b>Cancel</b> - set this boolean property to True, when you want to cancel the event.
                </td><td>

<b>AppointmentDeleting</b> - occurs when the appointment is going to be removed from the data source.
              

Via the AppointmentDeletedEventArgs you can access the following properties:

* 
                  Appointment - gets the appointment that is deleted. This property is read-only.
                </td></tr><tr><td>

<b>AppointmentSaving</b> - occurs before the appointment is saved.
              

Via the <b>AppointmentSavingEventArgs</b> you can access the following property:
                • <b>Appointment</b> - the appointment that is going to be saved. The property is read-only.
              </td><td>

<b>AppointmentSaving</b> - occurs before the appointment is saved.
              

Via the <b>AppointmentSavingEventArgs</b> you can access the following property:
              

* 
                  Appointment - gets the appointment that is going to be saved. This property is read-only.
                

* 
                  Cancel - set this boolean property to True, when you want to cancel the event.
                </td></tr><tr><td>

* <b>ActiveViewDefinitionChanged</b> - fired whenever the <b>ViewMode</b> of a RadScheduler is changed. Via the sender argument of the <b>ActiveViewDefinitionChanged</b> event handler, you can get access to the RadScheduler. This argument is of type object, but can be cast to the RadScheduler type.
                

* <b>SchedulerPerformedGrouping</b>

* <b>SelectedViewStartDateChanged</b> - occurs when the <b>DayStartTime</b> of a MultidayViewDefinition is changed. Via the sender argument of the SelectedViewStartDateChanged event handler, you can get access to the RadScheduler. This argument is of type object, but can be cast to the RadScheduler type.
                </td><td>

* <b>AppointmentSelectionChanged</b> - occurs when an appointments is selected or deselected.
                

* <b>VisibleRangeChanged</b> – occurs when the view or the Start/End date is changed.
                

* <b>ShowDialog</b> -  occurs before scheduleView dialog is shown. You can use it to cancel the showing of the dialog. ( e.Cancel = true;)
                </td></tr></table>


<table> <th><tr><td>

Lifecycle of appointment in RadScheduler</td><td>

Lifecycle of appointment in RadScheduleView</td></tr></th><tr><td>

<b>New Appointment:</b>



1. AppointmentCreating 

1. 
                    AppointmentCreated
                  

1. 
                    AppointmentSaving
                  

1. 
                    AppointmentAdding
                  

1. 
                    AppointmentAdded
                  </td><td>

<b>New Appointment:</b>



1. AppointmentCreating

1. AppointmentSaving

1. AppointmentCreated</td></tr><tr><td>

<b>Editing Appointment:</b>



1. AppointmentEditing

1. AppointmentSaving

1. AppointmentEdited</td><td>

<b>Editing Appointment:</b>

1. AppointmentEditing

1. AppointmentSaving

1. AppointmentEdited</td></tr><tr><td>

<b>Deleting Appointment:</b>



1. AppointmentDeleting

1. AppointmentDeleted</td><td>

<b>Deleting Appointment:</b>



1. AppointmentDeleting

1. AppointmentDeleted</td></tr><tr><td></td><td><b>
                Deleting an occurrence:
              </b>



1. AppointmentEditing

1. AppointmentSaving

1. AppointmentEdited</td></tr></table>


