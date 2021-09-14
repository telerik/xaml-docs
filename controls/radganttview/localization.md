---
title: Localization
page_title: Localization
description: Check our &qout;Localization&quot; documentation article for the RadGanttView {{site.framework_name}} control.
slug: radganttview-localization
tag: localization
published: True
position: 6
---

# Localization

The built-in localization mechanism in Silverlight and WPF allows you to localize any string resource used by the RadGanttView control. Once translated, you might use your resources in both Silverlight and WPF projects without changing anything.

>tipTo learn more about the ways to localize the controls from the UI for {% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %} suite please read the common topic about {% if site.site_name == 'Silverlight' %}[Localization](http://www.telerik.com/help/silverlight/common-localization.html){% endif %}{% if site.site_name == 'WPF' %}[Localization](http://www.telerik.com/help/wpf/common-localization.html){% endif %}.

In __RadGanttView__ you can localize the Start and End text in task tooltips:

![ganttview localization 1](images/ganttView_localization_1.png)

The next image shows the tooltip localized in French:

![ganttview localization 2](images/ganttView_localization_2.png)

>tipYou can also localize the __RadDateTimePicker__  which is present when choosing a date. More information on how to achieve this can be found in the [DateTimePicker Localization]({%slug raddatetimepicker-localization%}) article. 

## Supported Languages

__RadGanttView__ can be translated in one of the following supported languages using the framework's localization mechanism:

* English
* German
* Spanish
* French
* Italian
* Dutch
* Turkish

More information on how to achieve this can be found the [Localization Using Built-In Resources]({%slug common-localization%}) article.

## Resource Keys

The resources of the control can be localized by using an unique identifier called resource key that is assigned to each localizable string. Below you may find a list of the Resources available and their default values:
		
Key | Value
---|---
DraggingItem | Dragging item:
DrawRelationFrom | Draw relation from:
DrawRelationTo | To:
End | End:
Gantt_Week | Week
RelationToolTip | Drag to create relation
Start | Start: