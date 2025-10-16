---
title: Table Definitions and Relationships
page_title: Table Definitions and Relationships
description: Check our &quot;Table Definitions and Relationships&quot; documentation article for the RadScheduleView {{ site.framework_name }} control.
slug: radscheduleview-populating-with-data-binding-to-db-datatier
tags: table,definitions,and,relationships
published: True
position: 2
---

# Table Definitions and Relationships

The database diagram is very common to the class diagram of the RadScheduleView interfaces:

![radscheduleview populating with data schedule View Data Base Diagram](images/radscheduleview_populating_with_data_scheduleViewDataBaseDiagram.png)

## Table Definitions

We have table definitions in the database according for the following types in the RadScheduleView:

| Class Diagram | Table Definition |
|	---	|	---	|
|	IAppointment & IExtendedAppointment<br/>![radscheduleview populating with data IAppointment](images/radscheduleview_populating_with_data_IAppointment.png)<br/>![radscheduleview populating with data IExtended Appointment](images/radscheduleview_populating_with_data_IExtendedAppointment.png)	|	SqlAppointments<br/>![radscheduleview populating with data Sql Appointments](images/radscheduleview_populating_with_data_SqlAppointments.png)	|
|	IResource<br/>![radscheduleview populating with data IResource](images/radscheduleview_populating_with_data_IResource.png)	|	SqlResources<br/>![radscheduleview populating with data Sql Resources](images/radscheduleview_populating_with_data_SqlResources.png)	|
|	IExceptionOccurrence<br/>![radscheduleview populating with data IException Occurence](images/radscheduleview_populating_with_data_IExceptionOccurence.png)	|	SqlExceptionOccurrences<br/>![radscheduleview populating with data Sql Exception Occurrences](images/radscheduleview_populating_with_data_SqlExceptionOccurrences.png)	|
|	IResourceType<br/>![radscheduleview populating with data IResource Type](images/radscheduleview_populating_with_data_IResourceType.png)	|	SqlResourceTypes<br/>![radscheduleview populating with data Sql Resource Types](images/radscheduleview_populating_with_data_SqlResourceTypes.png)	|
|	ICategory<br/>![radscheduleview populating with data ICategory](images/radscheduleview_populating_with_data_ICategory.png)	|	Categories<br/>![radscheduleview populating with data Categories](images/radscheduleview_populating_with_data_Categories.png)	|
|	ITimeMarker<br/>![radscheduleview populating with data ITime Marker](images/radscheduleview_populating_with_data_ITimeMarker.png)	|	TimeMarkers<br/>![radscheduleview populating with data Time Markers](images/radscheduleview_populating_with_data_TimeMarkers.png)	|


## Relationships

Here are some explanations about the keys and the relationships in the data tables:

Name	|	Between	|	Type	|	Update/delete rule
---	|	---	|	---	|	---
FK_SqlResources_SqlResourceTypes	|	SqlResourceTypes - SqlResources	|	One-to-many	|	No Action
FK_SqlAppointmentResources_SqlResource	|	SqlResources - SqlAppointmentResources	|	One-to-many	|	Cascade
FK_SqlExceptionResources_SqlResource	|	SqlResources - SqlExceptionResources	|	One-to-many	|	Cascade
FK_SqlExceptionOccurrences_SqlAppointments	|	SqlAppointments - SqlExceptionOccurrences	|	One-to-many	|	Cascade
FK_SqlExceptionAppointments_SqlExceptionOccurrences	|	SqlExceptionOccurrences - SqlExceptionAppointments	|	One-to-many	|	Cascade


* There is no table definition for the __IRecurrenceRule__ type because we don’t need it. Storing the __RecurrencePattern__ is enough to generate the recurrence rules at run-time.
* We cannot save the Brush type into the database directly, that’s why we can save a string that represents the color and convert the string to __SolidColerBrush__ object when the TimeMarkers & Categories are loaded.
* The __SqlAppointmentResource__ and __SqlExceptionResources__ are cross-tables between:
	* SqlAppointments & SqlResources
	* SqlExceptionAppointments & SqlResources