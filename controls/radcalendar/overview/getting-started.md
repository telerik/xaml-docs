---
title: Getting Started
page_title: Getting Started
description: Getting Started
slug: radcalendar-getting-started
tags: getting,started
published: True
position: 2
---

# Getting Started



## 

This article will show you how to create a simple calendar.



>

In order to use __RadCalendar__control in your projects you have to add references to the following assemblies:

1. __Telerik.Windows.Controls__

1. __Telerik.Windows.Controls.Input__

You can find more info 
            {% if site.site_name == 'Silverlight' %}[here](http://www.telerik.com/help/silverlight/installation-installing-controls-dependencies.html){% endif %}{% if site.site_name == 'WPF' %}[here](http://www.telerik.com/help/wpf/installation-installing-controls-dependencies-wpf.html){% endif %}.
            



1. Drag and Drop the Calendar control from the toolbox.
{% if site.site_name == 'Silverlight' %}


				 
			![](images/CalendarTB.gif){% endif %}{% if site.site_name == 'WPF' %}


				 
			![](images/CalendarTBWPF.gif){% endif %}

1. After you have dropped the control onto the XAML you can manage the control by setting various properties to operate the control's behavior:



#### __XAML__

{{region radcalendar-getting-started_0}}
	<telerik:RadCalendar HorizontalAlignment="Left" VerticalAlignment="Center" 
	     x:Name="calendar" Columns="2" ViewsHeaderVisibility="Visible"/>
	{{endregion}}


