---
title: UI Automation Support
page_title: UI Automation Support
description: UI Automation Support
slug: common-ui-automation
tags: ui,automation,support
published: True
position: 12
---

# UI Automation Support

Telerik UI for {% if site.site_name == 'WPF' %}WPF{% endif %}{% if site.site_name == 'Silverlight' %}Silverlight{% endif %} provides built-in support for Microsoft UI Automation – the accessibility framework for Microsoft Windows. UI Automation support is implemented through a tree of peer classes that derive from [FrameworkElementAutomationPeer](http://msdn.microsoft.com/en-us/library/ms615720). We follow the convention about naming the peer classes – they begin with the control class name and end with “AutomationPeer”.
      
>For detailed information on the UI Automation check the [UI Automation Fundamentals](http://msdn.microsoft.com/en-us/library/ms753107%28v=vs.110%29.aspx) section on MSDN.

## AutomationMode property

With Q2 2014 SP release of UI for {% if site.site_name == 'WPF' %}WPF{% endif %}{% if site.site_name == 'Silverlight' %}Silverlight{% endif %} you will have the option to turn off the generating of the automation peers through the new global __AutomationMode__ property of the __AutomationManager__.

>importantCreating the automation peers can be turned off only for the whole application, not for separate controls.

__AutomationMode__ property is of enum type and accepts the following values:

* Disabled – this option will disable creating of automation peers of Telerik controls;
* FrameworkOnly – this option will include only the base methods of AutomationPeers of MS classes;
{% if site.site_name == 'WPF' %}
* Basic – will create the full AutomationPeer implementation for Telerik UI controls;
* Advanced - required for any Coded UI tests. This is the default value. 
{% endif %}

{% if site.site_name == 'Silverlight' %}
* Advanced - will create the full AutomationPeer implementation for Telerik UI controls. This is the default value.
{% endif %}

The next code snippet shows how the AutomationMode property can be set:

#### __C#__

{{region common-ui-automation_0}}
	using Telerik.Windows.Automation.Peers; 
	
	public partial class App : Application
	{
	    public App()
	    {
	        AutomationManager.AutomationMode = AutomationMode.Disabled;
	        this.InitializeComponent();
	    }
	}
{{endregion}}
{% if site.site_name == 'WPF' %} 
# See Also
 
* [Coded UI Support]({%slug coded-ui-support%})
{% endif %}