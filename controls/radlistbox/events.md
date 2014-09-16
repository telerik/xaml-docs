---
title: Events
page_title: Events
description: Events
slug: radlistbox-events
tags: events
publish: True
position: 7
---

# Events



The __RadListBox__ is an __ItemsControl__. Almost all of the exposed events are inherited from the __ItemsControl__ class. __RadListBox__ adds an additional event:

* __SelectionChanged__ - occurs when the selected item is changed. The __SelectionChanged__ event handler receives two arguments:
      		

* The sender argument contains the __RadListBox__. This argument is of type object, but can be cast to the __RadListBox__ type.

* A __SelectionChangedEventArgs__ object which has the following properties:
       			 

1. AddedItems - gets a list that contains the items that were selected.

1. RemovedItems - gets a list that contains the items that were unselected.
