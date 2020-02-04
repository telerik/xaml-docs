---
title: Performance
page_title: Performance
description: Check our "Performance" documentation article for the RadPropertyGrid WPF control.
slug: radpropertygrid-performance
tags: performance
published: True
position: 3
---

# Performance

RadPropertyGrid’s API allows you to tweak your application for optimal performance. If you are a developer who wants to use RadPropertyGrid, you should familiarize yourself with the following details:

* RadPropertyGrid supports __UI Virtualization__, which processes only information loaded in the viewable area, which will reduce the memory footprint of the application and speed up its loading time, thus enhancing the UI performance. [Read more]({%slug radpropertygrid-virtualization%}).

* Avoid using converters. Calling a converter is a time-consuming operation and this will slow down the performance.

* Try not to place RadPropertyGrid in controls/panels which will measure it with infinity. For example, __ScrollViewer__, __StackPanel__ and __Grid__ with __Row.Height=Auto__ or __Column.Width=Auto__ will measure with infinity. If RadPropertyGrid is measured with infinity it will have an infinite amount of space to arrange the fields, so it will try to arrange all of them.

* If applicable, try to stick to the default templates and avoid overriding the templates of fields.

* As of __Q2 2014 SP__ release we introduced the option to turn off the generating of the automation peers through the new global __AutomationMode__ property of the __AutomationManager__. You can check the [UI Automation Support]({%slug common-ui-automation%}) article for more information.

    #### __[C#] Example 1: Setting AutomationMode__

    {{region cs-radpropertygrid-performance_0}}
        public App()
        {
            AutomationManager.AutomationMode = AutomationMode.Disabled;
            this.InitializeComponent();
        }
    {{endregion}}

    #### __[VB.NET] Example 2: Setting AutomationMode__

    {{region vb-radpropertygrid-performance_1}}
		Public Sub New()
			AutomationManager.AutomationMode = AutomationMode.Disabled
			Me.InitializeComponent()
		End Sub
    {{endregion}}

* Another optimization would be to __disable the Touch Support__ via the __TouchManager__. You can refer to the [Touch Support]({%slug touch-support%}) article for more information.

    #### __[C#] Example 2: Disabling touch support__

    {{region cs-radpropertygrid-performance_1}}
        public App()
        {
            TouchManager.IsEnabled = false;
            this.InitializeComponent();
        }
    {{endregion}}

    #### __[VB.NET] Example 2: Disabling touch support__

    {{region vb-radpropertygrid-performance_1}}
		Public Sub New()
			TouchManager.IsEnabled = False
			Me.InitializeComponent()
		End Sub
    {{endregion}}

* As of __Q1 2012__ release we have introduced the option to enable/disable searching in nested properties through the __SearchInNestedProperties__ property of RadPropertyGrid (the default value is __False__). Setting it to __True__, can lead to degraded performance, when you have a lot of visible nested properties.

* As of __Q1 2014__ release we have introduced the option to enable/disable editor caching through the __EnableEditorCaching__ property of RadPropertyGrid (the default value is __True__). Setting it to __False__, can lead to degraded performance, since a new instance of the editor for each field will be created when the same __PropertyDefinition__ serves as data context (i.e. search, grouping).

* When adding/removing a lot of __PropertyDefinitions__ (for example more than 100) at runtime, you should consider invoking the respective __SuspendNotifications()__ and __ResumeNotifications()__ methods and raise notifications only once for all the operations.

    #### __[C#] Example 3: Suspending notifications while adding property definitions__

    {{region cs-radpropertygrid-performance_2}}
        this.propertyGrid.PropertyDefinitions.SuspendNotifications();
        foreach (PropertyDefinition propertyDefinition in largeCollectionOfPropertyDefinitions)
        {
            this.propertyGrid.PropertyDefinitions.Add(propertyDefinition);
        }
        this.propertyGrid.PropertyDefinitions.ResumeNotifications();
    {{endregion}}

    #### __[VB.NET] Example 3: Suspending notifications while adding property definitions__

    {{region vb-radpropertygrid-performance_2}}
		Me.propertyGrid.PropertyDefinitions.SuspendNotifications()
		For Each propertyDefinition As PropertyDefinition In largeCollectionOfPropertyDefinitions
			Me.propertyGrid.PropertyDefinitions.Add(propertyDefinition)
		Next propertyDefinition
		Me.propertyGrid.PropertyDefinitions.ResumeNotifications()
    {{endregion}}

## See Also

 * [UI Virtualization]({%slug radpropertygrid-virtualization%})
 * [Touch Support]({%slug touch-support%})
 * [Setting a Theme(Using Implicit Styles)]({%slug styling-apperance-implicit-styles-overview%})