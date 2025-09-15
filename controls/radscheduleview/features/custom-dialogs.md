---
title: Custom Dialogs
page_title: Custom Dialogs
description: Check our &quot;Custom Dialogs&quot; documentation article for the RadScheduleView {{ site.framework_name }} control.
slug: radscheduleview-features-custom-dialogs
tags: custom,dialogs
published: True
position: 13
---

# Custom Dialogs


__RadScheduleView__ makes it easy to customize its dialogs. Each RadWindow dialog contains an instance of the SchedulerDialog control as Content. The ViewModel in the DataContext of the SchedulerDialog control is automatically provided and contains all needed properties for the corresponding dialog. __RadScheduleView__ exposes a Style property for each dialog which allows you to apply a Style on the SchedulerDialog control and modify its Template.      

* [General information about RadScheduleView dialogs](#general-information-about-radscheduleview-dialogs)

* [How to extract the default styles of the dialogs](#how-to-extract-the-default-styles-of-the-dialogs)

## General information about RadScheduleView dialogs

__RadScheduleView__ provides the following dialogs:        

* EditAppointmentDialog - shown when an appointment is about to be created or edited: 

![RadScheduleView EditAppointmentDialog](images/radscheduleview_editappointmentdialog.png)

In order to create a custom EditAppointmentDialog, use __EditAppointmentDialogStyle__ property of the __RadScheduleView__ control.  The DataContext of this Style target is an AppointmentDialogViewModel object. This class contains all the needed data for editing an appointment including the appointment itself. It can be reached by using the Occurrence property of the ViewModel and its Appointment property:        

#### __XAML__

```XAML
	<TextBox Grid.Row="0" Grid.Column="1" Grid.ColumnSpan="2" Margin="3"
	   IsReadOnly="{Binding IsReadOnly}"
	   Text="{Binding Occurrence.Appointment.Subject, Mode=TwoWay}"
	   telerik:StyleManager.Theme="{StaticResource Theme}" />
```

Other important properties of the AppointmentDialogViewModel class include:

-  Categories /TimeMarkers – lists of ICategory/ ITimeMarker objects which can be set to the appointment.  In the default EditAppointmentDialog these are used as a DataSource of two RadComboBoxes.

-  ResourceTypes - a list of ResourceTypeViewModel objects.  Each object holds a list of the available resources for the given ResourceType. This collection is used as a DataSource of an ItemsControl with an ItemTemplate where a RadComboBox for each resource type is placed.

-  IsReadOnly – a boolean property bound to the IsEnabled property of all the controls in the dialog. This allows to make the dialog read-only by cancelling the AppointmentEditing event of the ScheduleView – in this case the EditAppointmetDialog will be shown but all the fields will be disabled.

>tipCheck [here]({%slug radscheduleview-features-appointments-custom-appointment%}) for more details about customizing EditAppointmentDialog.        

* EditRecurrenceDialog – shown when a recurrence is created or edited: 

![RadScheduleView EditRecurrenceDialog](images/radscheduleview_recurrenceeditdialog.png)

__EditRecurrenceDialogStyle__ property is used to customize this dialog.  The DataContext of the dialog is a RecurrenceDialogViewModel object. It provides information about the RecurrencePattern which is set to the RecurrenceRule of the appointment.
        

>tipMore information about the recurring patterns can be found [here]({%slug radscheduleview-features-recurrences-overview%}).        

* DeleteAppointmentConfirmDialog - shown when the selected appointments are going to be deleted: 

![RadScheduleView DeleteAppointmentConfirmDialog](images/radscheduleview_deleteappointmentconfirmdialog.png)

__DeleteAppointmentConfirmDialogStyle__ property should be set to modify this dialog.  The DataContext of this Style target is of type ConfirmDialogViewModel.  It contains  a reference to the marked for deletion appointments through its Appointments property.        

* RecurrenceChoiceDialog/RecurrenceChoiceDeleteDialog – shown when a recurrent appointment is about to be edited/deleted: 

![RadScheduleView RecurrenceChoiceDialogs](images/radscheduleview_recurrencechoicedialogs_1.png)

__RecurrenceChoiceDialogStyle__/__RecurrenceChoiceDeleteDialogStyle__ properties are used to edit these dialogs.        

* RecurrenceChoiceDragDropDialog / RecurrenceChoiceResizeDialog – shown when a recurrent appointment is dragged/resized: 

![RadScheduleView RecurrenceChoiceDialogs](images/radscheduleview_recurrencechoicedialogs.png)

__RecurrenceChoiceDragDropDialogStyle / RecurrenceChoiceResizeDialogStyle__ properties should be used to customize the corresponding dialogs.        

The ViewModel of all the RecurrenceChoice dialogs is a __RecurrenceChoiceDialogViewModel__ object. Its boolean properties __IsOccurrenceModeSelected__/__IsSeriesModeSelected__ show which option is selected in the dialog. The __RecurrenceChoiceDialogMode__ property indicates which dialog is executed, its value is enumeration of type RecurrenceChoiceDialogMode representing each of the RecurrenceChoice dialogs. Also the class contains a reference to the appointment through its Occurrence property.        

>The ViewModels of all the __ScheduleView__ dialogs inherit from __SchedulerDialogViewModel__ class. It provides the commands for confirming and cancelling the dialog.          

## How to extract the default styles of the dialogs

Choose one of the following approaches to obtain the source code of the needed dialogs:

* __Generate the style from installation folder__ - In the UI for {% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %} installation folder on your computer, go to Themes folder (Themes.Implicit in case you're using [Implicit Styles]({%slug styling-apperance-implicit-styles-overview%})) and select the theme that you use in your application. Drill down to find Telerik.Windows.Controls.ScheduleView.xaml file in that directory. From this resource dictionary you can extract the needed Style and any resources that it uses.

>If you are using [Implicit Styles]({%slug styling-apperance-implicit-styles-overview%}) and merge the ResourceDictionaries, you will be able to reference the needed resources directly (there is no need to copy them together with the used Style). 

* __Generate the style from RadScheduleView template__ - Generate first the __RadScheduleView__ template from Expression Blend ( Edit Template > Edit a Copy). Search for the needed Style and copy it together with all needed resources that it uses.

