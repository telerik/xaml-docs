---
title: UI Automation Support (UI Accessibility)
page_title: UI Automation Support (UI Accessibility)
description: UI Automation Support (UI Accessibility)
slug: common-ui-automation
tags: ui,automation,support, accessibility
published: True
position: 7
---

# UI Automation Support

Telerik UI for {{ site.framework_name }} provides built-in support for Microsoft UI Automation – the accessibility framework for Microsoft Windows. UI Automation support is implemented through a tree of peer classes that derive from [FrameworkElementAutomationPeer](http://msdn.microsoft.com/en-us/library/ms615720). We follow the convention about naming the peer classes – they begin with the control class name and end with “AutomationPeer”.
      
>For detailed information on the UI Automation check the [UI Automation Fundamentals](http://msdn.microsoft.com/en-us/library/ms753107%28v=vs.110%29.aspx) section on MSDN.

## AutomationMode

With Q2 2014 SP release of Telerik UI for {{ site.framework_name }} you will have the option to turn off the generating of the automation peers through the new global __AutomationMode__ property of the __AutomationManager__.

>importantCreating the automation peers can be turned off only for the whole application, not for separate controls.

__AutomationMode__ property is of enum type and accepts the following values:

* **Disabled**: This option will disable creating of automation peers of Telerik controls;
* **FrameworkOnly**: This option will include only the base methods of AutomationPeers of MS classes;
{% if site.site_name == 'WPF' %}
* **Basic**: Will create the full AutomationPeer implementation for Telerik UI controls. It supports the most basic Coded UI tests;
* **Advanced**: Required for Coded UI tests with Level 2 and Level 3. This is the default value. 
{% endif %}

{% if site.site_name == 'Silverlight' %}
* **Advanced:** Will create the full AutomationPeer implementation for Telerik UI controls. This is the default value.
{% endif %}

The next code snippet shows how the AutomationMode property can be set:

__Example 1: Setting AutomationMode__

```C#
	using Telerik.Windows.Automation.Peers; 
	
	public partial class App : Application
	{
	    public App()
	    {
	        AutomationManager.AutomationMode = AutomationMode.Disabled;
	        this.InitializeComponent();
	    }
	}
```

## UseDefaultHelpText

By default, most Telerik UI for {{ site.framework_name }} controls will return their **class name** as the **HelpText** when using UI automation.

With **R1 2019 SP1** we introduced a new boolean **UseDefaultHelpText** property of the AutomationManager which determines whether the automation peer of the controls will return a predefined string (the class name) as HelpText.

The default value is **true** - the class name of the control will be returned as the HelpText if the **GetHelpTextCore** method is overridden in the respective automation peer class. When set to **false**, however, the value set as the **AutomationProperties.HelpText** will be returned.

The UseDefaultHelpText can be set similarly to the **AutomationMode** as demonstrated in **Example 2**.

__Example 2: Setting UseDefaultHelpText__

```C#
	using Telerik.Windows.Automation.Peers; 
	
	public partial class App : Application
	{
	    public App()
	    {
	        AutomationManager.UseDefaultHelpText = false;
	        this.InitializeComponent();
	    }
	}
```

{% if site.site_name == 'WPF' %} 

## UI Accessibility 

Since the __R1 2021__ release we improved the accessibility of the UI for WPF controls by testing them with the [Accessibility Insights for Windows](https://accessibilityinsights.io/docs/en/windows/overview/) tool. This application executes tests, which check whether the controls have the right UI Automation properties. We've tested all of the controls from the UI for WPF suite to ensure that there aren't any failed tests.

## See Also
 
* [Coded UI Support]({%slug coded-ui-support%})
{% endif %}
