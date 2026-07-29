---
title: Customizing Dialog Windows
page_title: Customizing Dialog Windows
description: Check our &quot;Customizing Dialog Windows&quot; documentation article for the RadScheduleView {{ site.framework_name }} control.
slug: radscheduleview-features-customizing-dialog-windows
tags: customizing,dialog,windows
published: True
position: 17
---

# Customizing Dialog Windows

>To customize the RadScheduleView dialogs, e.g. the window content, please read the [Custom Dialogs]({%slug radscheduleview-features-custom-dialogs%}) article

The dialogs in RadScheduleView are displayed in RadWindow instances by default. You can either [customize the RadWindow](#custom-radwindow) or entirely [replace it with any other ContentControl](#replace-radwindow-with-custom-control).

RadScheduleView uses the __IScheduleViewDialogHostFactory__ and __IScheduleViewDialogHost__ interfaces to abstract the dialog hosts and their generation. The default implementation of the IScheduleViewDialogHostFactory interface that creates RadWindow instances is named __ScheduleViewDialogHostFactory__.

## Custom RadWindow

Create a new class, deriving from ScheduleViewDialogHostFactory and override the __CreateNew__ method:

__Example 1: Custom ScheduleViewDialogHostFactory with customized RadWindow__

<snippet id='radscheduleview-features-customizing-dialog-windows-block_1-cs' />

Configure RadScheduleView to use the new class:

__Example 2: Set SchedulerDialogHostFactory__

<snippet id='radscheduleview-features-customizing-dialog-windows-block_2-xaml' />

## Replace RadWindow with Custom Control

Create a new class, deriving from {% if site.site_name == 'WPF' %}Window{% endif %}{% if site.site_name == 'Silverlight' %}ChildWindow{% endif %} and implement the __IScheduleViewDialogHost__ interface:

{% if site.site_name == 'WPF' %}
__Example 3: Custom IScheduleViewDialogHost__
<snippet id='radscheduleview-features-customizing-dialog-windows-block_3-cs' />
{% endif %}

{% if site.site_name == 'Silverlight' %}
__Example 3: Custom IScheduleViewDialogHost__
<snippet id='radscheduleview-features-customizing-dialog-windows-block_4-cs' />
{% endif %}

Create a new class and implement the __IScheduleViewDialogHostFactory__:
    
{% if site.site_name == 'WPF' %}
__Example 4: Custom ScheduleViewDialogHostFactory with Custom IScheduleViewDialogHost__
<snippet id='radscheduleview-features-customizing-dialog-windows-block_5-cs' />
{% endif %}

{% if site.site_name == 'Silverlight' %}
__Example 4: Custom ScheduleViewDialogHostFactory with Custom IScheduleViewDialogHost__
<snippet id='radscheduleview-features-customizing-dialog-windows-block_6-cs' />
{% endif %}

Configure RadScheduleView to use the new factory:    

__Example 5: Set SchedulerDialogHostFactory__

<snippet id='radscheduleview-features-customizing-dialog-windows-block_7-xaml' />

#### Figure 1: Custom appointment dialog
{% if site.site_name == 'WPF' %}
![radscheduleview customizingdialogs wpf](images/radscheduleview_customizingdialogs_wpf.png)
{% endif %}
{% if site.site_name == 'Silverlight' %}
![radscheduleview customizingdialogs](images/radscheduleview_customizingdialogs.png)
{% endif %}