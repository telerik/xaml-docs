---
title: Data Binding Support Overview
page_title: Data Binding Support Overview
description: Data Binding Support Overview
slug: radganttview-populating-with-data-overview
tags: data,binding,support,overview
publish: True
position: 0
---

# Data Binding Support Overview



Data binding allows you to establish a link between the UI and the underlying business logic and keep them synchronized. It means that when a value is changed in the business layer, that change is automatically populated to the UI and vice versa. Of course, in order to work, you have to implement the proper notification or to use objects that have already implemented it.
	

Binding to __RadGanttView__ involves the following property: 

* __TasksSource__ - gets or sets the data source (__IEnumerable__) used to generate the Tasks in the __RadGanttView__ control. It can be bound to data from a variety of data sources in the form of common language runtime (CLR) objects and XML.
		

>Note that the data source passed to the property __TasksSource__ should contain only objects that implement the __IGanttTask__ interface. 
		
