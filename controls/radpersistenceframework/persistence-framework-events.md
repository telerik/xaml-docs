---
title: Events
page_title: Events
description: Events
slug: persistence-framework-events
tags: events
published: True
position: 4
---

# Events



This topic covers the specific events exposed by the __PersistenceManager__.
	  

## PersistenceError

The __PersistenceError__ event is raised when an error occurs during the process of persisting or restoring. The __PersistenceError__ event handler receives two arguments:
		

* The __sender__ argument contains the __PersistenceManager__ object. This argument is of type __object__, but can be cast to the __PersistenceManager__ type.
			

* A __PersistenceErrorEventArgs__ object. Using this object you can find the raised __Exception__, the __Name__ of the property that caused the error and the __Path__ to the property that caused the exception.
			

## PropertyPersisting

The __PropertyPersisting__ event is raised before a property starts persisting. The __PropertyPersisting__ event handler receives two arguments:
		

* The __sender__ argument contains the __PersistenceManager__ object. This argument is of type __object__, but can be cast to the __PersistenceManager__ type.
			  

* A __PersistingPropertyEventArgs__ object. Using this object you can find the __Name__ and the__Path__ of the property that is about to be persisted. You can cancel the persisting of the property by setting the __Cancel__ property to __True__.
			  

## PropertyPersisted

The __PropertyPersisted__ event is raised when a property has been persisted. The __PropertyPersisted__ event handler receives two arguments:
		

* The __sender__ argument contains the __PersistenceManager__ object. This argument is of type __object__, but can be cast to the __PersistenceManager__ type.
			  

* A __PersistenceEventArgs__ object. Using this object you can find the the __Name__ of the persisted property and its __Path__.
			  

## PropertyPersistenceCompleted

The __PropertyPersistenceCompleted__ event is raised when all properties have been persisted. The __PropertyPersistenceCompleted__ event handler receives two arguments:
		

* The __sender__ argument contains the __PersistenceManager__ object. This argument is of type __object__, but can be cast to the __PersistenceManager__ type.
			

* An __EventArgs__ object.
			

## PropertyRestoring

The __PropertyRestoring__ event is raised before a property is restored. The __PropertyRestoring__ event handler receives two arguments:
		

* The __sender__ argument contains the __PersistenceManager__ object. This argument is of type __object__, but can be cast to the __PersistenceManager__ type.
			  

* A __RestoringPropertyEventArgs__ object. Using this object you can find the the __Name__ and the __Path__ of the property that is about to be restored. You can cancel the restoring of the property by setting the __Cancel__ property to __True__.
			  

## PropertyRestored

The __PropertyRestored__ event is raised when a property has been restored. The __PropertyRestored__ event handler receives two arguments:
		

* The __sender__ argument contains the __PersistenceManager__ object. This argument is of type __object__, but can be cast to the __PersistenceManager__ type.
			  

* A __PersistenceEventArgs__ object. Using this object you can find the the __Name__ of the persisted property and its __Path.__

## PropertyRestoringCompleted

The __PropertyRestoringCompleted__ event is raised when all properties have been restored. The __PropertyRestoringCompleted__ event handler receives two arguments:
		

* The __sender__ argument contains the __PersistenceManager__ object. This argument is of type __object__, but can be cast to the __PersistenceManager__ type.
			  

* A __EventArgs__ object.
			  

>The __PropertyPersisted/PropertyRestored__ events of collection properties will be raised only after all their items' properties are persisted/restored.
		  
