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



```XAML
	<ChosenDates>
	    <Date>08/21/2010</Date>
	    <Date>08/04/2010</Date>
	    <Date>08/01/2010</Date>
	    <Date>08/26/2010</Date>
	    <Date>08/02/2010</Date>
	    <Date>08/03/2010</Date>
	    <Date>08/19/2010</Date>
	    <Date>08/10/2010</Date>
	</ChosenDates>
```

The following code snippet loads the file and extracts the Date nodes out of it, then assigns the respective dates as selection:



```C#
	// Make sure that more than one date can be selected:
	calendar.SelectionMode = SelectionMode.Extended;
	// Load the xml document and get the culture with wich the dates were serialized:
	XDocument xmlSource = XDocument.Load("DataSource.xml");
	CultureInfo usCulture = new CultureInfo("En-US");
	// Add Get all the dates in the xml document and add them as selected dates:
	foreach (var dateNode in xmlSource.Descendants("Date"))
	{
	    calendar.SelectedDates.Add(DateTime.Parse(dateNode.Value, usCulture.DateTimeFormat));
	}
	// Set the display date to the forst selected date, so that the selection is visible.
	calendar.DisplayDate = (DateTime)calendar.SelectedDates[0];
```