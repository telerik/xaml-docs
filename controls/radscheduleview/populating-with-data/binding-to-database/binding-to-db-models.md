---
title: Models
page_title: Models
description: Check our &quot;Models&quot; documentation article for the RadScheduleView {{ site.framework_name }} control.
slug: radscheduleview-populating-with-data-binding-to-db-models
tags: models
published: True
position: 6
---

# Models

Here we will explain the tricky moments when defining the models.

## Appointment

The tricky part here is how we implement the BeginEdit, CancelEdit and EndEdit methods in SqlAppointment:

* On BeginEdit we call the Entity.BeginEdit() method and refresh the ExceptionOccurence and ExceptionAppointment Collection.

* On CancelEdit we call the Entity.CancelEdit() method so we revert all changes on the SqlAppointment entity, remove all newly created but not saved Exception Occurences, Exception Appointments and Exception Resources.

* On EndEdit we call the Entity.EndEdit to commit the edits on this entity. On this point we have to manually refresh our SqlAppointmentResources and SqlExceptionResources Many-To-Many tables.

## SqlRecurrenceRule

In the SqlRecurrenceRule.CreateNew() method we create a new instance of SqlExeptionOccurence and add it to the SqlExceptionOccurrences collection in the domain context.

## Categories and TimeMarkers

We need to generate a brush value from the string stored in the database. What we suggest is to use the SolidColorBrushHelper.FromNameString method that returns a SolidColorBrush if the string in hex format, and Brush if the string is Color Name like "Red". But you could change this logic as well. Here is the __SolidColorBrushHelper__ class:



<snippet id='radscheduleview-populating-with-data-binding-to-database-binding-to-db-models-block_1-cs' />