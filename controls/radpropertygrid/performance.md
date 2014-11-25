---
title: Performance
page_title: Performance
description: Performance
slug: radpropertygrid-performance
tags: performance
published: True
position: 3
---

# Performance



## 

__RadPropertyGrid’s__ API allows you to tweak your application for optimal performance. If you are a developer who wants to use __RadPropertyGrid__, you should familiarize yourself with the following features:
		

* __RadPropertyGrid__ supports __UI Virtualization__, which processes only information loaded in the viewable area, which will reduce the memory footprint of the application and speed up its loading time, thus enhancing the UI performance. [Read more]({%slug radpropertygrid-virtualization%}).
			

* Avoid using converters. Calling a converter is a time-consuming operation and this will slow down the performance.
			

* Try not to place __RadPropertyGrid__ in controls/panels which will measure it with infinity. For example, __ScrollViewer__, __StackPanel__ and __Grid__ with __Row.Height=Auto__ or __Column.Width=Auto__ will measure with infinity. If __RadPropertyGrid__ is measured with infinity it will have an infinite amount of space to arrange the fields, so it will try to arrange all of them.
			

* If applicable, try to stick to the default templates and avoid overriding templates of fields.
			

* As of __Q1 2012 SP1__ we have introduced a new way to style the controls by using __Implicit Styles__. There are a number of benefits of using implicit styles over the __Telerik StyleManager__. For more information, please refer to the [XAML Theming – Implicit Styles versus StyleManager](http://blogs.telerik.com/xamlteam/posts/13-11-05/xaml-theming-implicit-styles-versus-stylemanager) blog post.
			

* __RadPropertyGrid__with applied __Windows8__,__Windows8Touch__ or __Office2013 Theme__ - Telerik controls in these themes use resources, which are dynamically loaded. Thus this approach slows down the performance of virtualized components, such as __RadPropertyGrid__.
			

* As of __Q2 2014 SP__ release we introduced the option to turn off the generating of the automation peers through the new global __AutomationMode__ property of the __AutomationManager__. You can check the [UI Automation Support]({%slug common-ui-automation%}) article on how to set the __AutomationMode__ property to __Disabled__.
			

* __TouchManager__ – another optimization would be to __disable the Touch Support__. You can refer to the [Touch Support]({%slug touch-support%}) article.
			

* As of __Q1 2012__ release we have introduced the option to enable / disable searching in nested properties through the __SearchInNestedProperties__ property of __RadPropertyGrid__ (the default value is __False__). Setting it to __True__, can lead to degraded performance, when you have a lot of visible nested properties.
			

* As of __Q1 2014__ release we have introduced the option to enable / disable editor caching through the __EnableEditorCaching__ property of __RadPropertyGrid__ (the default value is __True__). Setting it to __False__, can lead to degraded performance, since a new instance of the editor for each field will be created when the same __PropertyDefinition__ serves as data context (i.e. search, grouping).
			

* When adding / removing a lot of __PropertyDefinitions__ (for example more than 100) at runtime, you should consider invoking the respective __SuspendNotifications()__ and __ResumeNotifications()__ methods and raise notifications only once for all the operations.
			

# See Also

 * [UI Virtualization]({%slug radpropertygrid-virtualization%})
 * [Touch Support]({%slug touch-support%})
 * [Setting a Theme(Using Implicit Styles)]({%slug styling-apperance-implicit-styles-overview%})
