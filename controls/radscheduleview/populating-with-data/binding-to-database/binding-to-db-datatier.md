---
title: Table Definitions and Relationships
page_title: Table Definitions and Relationships
description: Table Definitions and Relationships
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


<table><tr><td>

IAppointment & IExtendedAppointment![radscheduleview populating with data IAppointment](images/radscheduleview_populating_with_data_IAppointment.png)![radscheduleview populating with data IExtended Appointment](images/radscheduleview_populating_with_data_IExtendedAppointment.png)</td><td>

SqlAppointments![radscheduleview populating with data Sql Appointments](images/radscheduleview_populating_with_data_SqlAppointments.png)</td></tr><tr><td>

IResource![radscheduleview populating with data IResource](images/radscheduleview_populating_with_data_IResource.png)</td><td>

SqlResources![radscheduleview populating with data Sql Resources](images/radscheduleview_populating_with_data_SqlResources.png)</td></tr><tr><td>

IExceptionOccurrence![radscheduleview populating with data IException Occurence](images/radscheduleview_populating_with_data_IExceptionOccurence.png)</td><td>

SqlExceptionOccurrences![radscheduleview populating with data Sql Exception Occurrences](images/radscheduleview_populating_with_data_SqlExceptionOccurrences.png)</td></tr><tr><td>

IResourceType![radscheduleview populating with data IResource Type](images/radscheduleview_populating_with_data_IResourceType.png)</td><td>

SqlResourceTypes![radscheduleview populating with data Sql Resource Types](images/radscheduleview_populating_with_data_SqlResourceTypes.png)</td></tr><tr><td>

ICategory![radscheduleview populating with data ICategory](images/radscheduleview_populating_with_data_ICategory.png)</td><td>

Categories![radscheduleview populating with data Categories](images/radscheduleview_populating_with_data_Categories.png)</td></tr><tr><td>

ITimeMarker![radscheduleview populating with data ITime Marker](images/radscheduleview_populating_with_data_ITimeMarker.png)</td><td>

TimeMarkers![radscheduleview populating with data Time Markers](images/radscheduleview_populating_with_data_TimeMarkers.png)</td></tr></table>

## Relationships

Here are some explanations about the keys and the relationships in the data tables:
<table><th><tr><td>Name</td><td>Between</td><td>Type</td><td>Update/delete rule</td></tr></th><tr><td>FK_SqlResources_SqlResourceTypes</td><td>SqlResourceTypes  - SqlResources</td><td>One-to-many</td><td>No Action</td></tr><tr><td>FK_SqlAppointmentResources_SqlResource</td><td>SqlResources - SqlAppointmentResources</td><td>One-to-many</td><td>Cascade</td></tr><tr><td>FK_SqlExceptionResources_SqlResource</td><td>SqlResources -  SqlExceptionResources</td><td>One-to-many</td><td>Cascade</td></tr><tr><td>FK_SqlExceptionOccurrences_SqlAppointments</td><td>SqlAppointments -  SqlExceptionOccurrences</td><td>One-to-many</td><td>Cascade</td></tr><tr><td>FK_SqlExceptionAppointments_SqlExceptionOccurrences</td><td>SqlExceptionOccurrences -  SqlExceptionAppointments</td><td>One-to-many</td><td>Cascade</td></tr><tr><td>FK_SqlAppointments_TimeMarkers</td><td>TimeMarkers -  SqlAppointments</td><td>One-to-many</td><td>No Action</td></tr><tr><td>FK_SqlExceptionAppointments_TimeMarkers</td><td>TimeMarkers -  SqlExceptionAppointments</td><td>One-to-many</td><td>No Action</td></tr><tr><td>FK_SqlAppointments_Categories</td><td>Categories -   SqlAppointments</td><td>One-to-many</td><td>No Action</td></tr><tr><td>FK_SqlExceptionAppointments_Categories</td><td>Categories -  SqlExceptionAppointments</td><td>One-to-many</td><td>No Action</td></tr><tr><td>FK_SqlExceptionResources_SqlExceptionAppointment</td><td>Categories -  SqlExceptionAppointments</td><td>One-to-many</td><td>Cascade</td></tr><tr><td>FK_SqlAppointmentResources_SqlAppointment</td><td>SqlAppointment -  SqlAppointmentResources</td><td>One-to-many</td><td>Cascade</td></tr></table>

>

* 
							There is no table definition for the __IRecurrenceRule__ type because we don’t need it. Storing the __RecurrencePattern__ is enough to generate the recurrence rules at run-time.
						

* 
							We cannot save the Brush type into the database directly, that’s why we can save a string that represents the color and convert the string to __SolidColerBrush__ object when the TimeMarkers & Categories are loaded.
						

* 
							The __SqlAppointmentResource__ and __SqlExceptionResources__ are cross-tables between:
							

* SqlAppointments & SqlResources

* SqlExceptionAppointments & SqlResources
