---
title: Getting Started
page_title: Getting Started
description: Getting Started
slug: radcalendar-getting-started
tags: getting,started
published: True
position: 1
---

# Getting Started

This article will show you how to create a simple calendar.

>In order to use __RadCalendar__ control in your projects you have to add references to the following assemblies:
>	1. __Telerik.Windows.Controls__
>	2. __Telerik.Windows.Controls.Input__

>You can find more info {% if site.site_name == 'Silverlight' %}[here]({%slug installation-installing-controls-dependencies%}){% endif %}{% if site.site_name == 'WPF' %}[here]({%slug installation-installing-controls-dependencies-wpf%}){% endif %}.

1. Drag and Drop the Calendar control from the toolbox.

	{% if site.site_name == 'Silverlight' %}
	![](images/CalendarTB.gif)
	{% endif %}

	{% if site.site_name == 'WPF' %}
	![](images/CalendarTBWPF.gif)
	{% endif %}

2. After you have dropped the control onto the XAML you can manage the control by setting various properties to operate the control's behavior:

	#### __XAML__

	{{region radcalendar-getting-started_0}}
		<telerik:RadCalendar HorizontalAlignment="Left" VerticalAlignment="Center" 
			 x:Name="calendar" Columns="2" ViewsHeaderVisibility="Visible"/>
	{{endregion}}