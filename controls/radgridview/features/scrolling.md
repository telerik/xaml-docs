---
title: Scrolling
page_title: Scrolling
description: Scrolling
slug: gridview-scrolling
tags: scrolling
published: True
position: 1
---

# Scrolling 

__RadGridView__ has inbuilt default scrolling mechanism. There are also options provided to additionally configure it for a better user experience.

## ScrollModes

__RadGridView__ provides two built-in scrolling modes, which allow you to manipulate the type of scrolling. 
This is controlled by the __ScrollMode__ enumeration property which has the following entries:

- __RealTime__ updates the content in view in real time as the user scrolls.
- __Deferred__ keeps the content in view static until scrolling is complete.

By default the __ScrollMode__ property is set to the __RealTime mode__.
There is also an option to implement programmatic scrolling. To learn more read the Scroll to a particular row or column article.

## ScrollingSettingsBehavior

This feature enables customizing the scrolling behavior of __RadGridView__ while dragging items. It uses the __ScrollingSettingsBehavior__ class.

{% if site.site_name == 'Silverlight' %}

>You can refer to the [ScrollingSettingsBehavior API Reference](http://docs.telerik.com/devtools/silverlight/api/html/t_telerik_windows_controls_scrollingsettingsbehavior.htm)
>
{% endif %}

{% if site.site_name == 'WPF' %}

>You can refer to the [ScrollingSettingsBehavior API Reference
](http://docs.telerik.com/devtools/wpf/api/html/t_telerik_windows_controls_scrollingsettingsbehavior.htm)

{% endif %}


The following behavior settings are exposed for customization:

### Enabling and disabling the Scrolling behavior

You can enable and disable the behavior by setting a value to the Boolean property __IsEnabled__.

#### [XAML] Example 1 - Setting the IsEnabled property

	<telerik:RadGridView telerik:ScrollingSettingsBehavior.IsEnabled="False"/>

### ScrollAreaPadding

By setting this property you can customize at which point the scrolling begins. Its default value is 0px. You need to set a value bigger than the default one in order to be able to use the __ScrollStep__ and __ScrollStepTime__ properties.

#### [XAML] Example 2 - Setting the ScrollAreaPadding property

	<telerik:RadGridView telerik:ScrollingSettingsBehavior.ScrollAreaPadding="5 20"/>

### ScrollStep

You can manipulate how many pixels will be skipped while scrolling by setting this property. It expects double values and its default one is 0.0

#### [XAML] Example 3 - Setting the ScrollStep property

	<telerik:RadGridView telerik:ScrollingSettingsBehavior.ScrollStep="1.5"/>

### ScrollStepTime

This property determines the time between each scroll step. It has no default value.

#### [XAML] Example 4 - Setting the ScrollStepTime property
	
	<telerik:RadGridView telerik:ScrollingSettingsBehavior.ScrollStepTime="00:00:00.5"/>