---
title: XML Binding
page_title: XML Binding
description: Check our &quot;XML Binding&quot; documentation article for the RadCalendar {{ site.framework_name }} control.
slug: radcalendar-xml-binding
tags: xml,binding
published: True
position: 3
---

# XML Binding

The current version of Silverlight does not support direct XML binding but __LINQ to XML__ can be used to retrieve the necessary data. The following example loads a collection of dates from an xml file and assigns them as the selected dates of a calendar.

The __DataSource.xml__ file has the following content:



<snippet id='radcalendar-howto-xml-binding-block_1-xaml' />

The following code snippet loads the file and extracts the Date nodes out of it, then assigns the respective dates as selection:



<snippet id='radcalendar-howto-xml-binding-block_2-cs' />