---
title: CurrentCulture Format Settings are not respected
page_title: CurrentCulture Format Settings are not respected
description: CurrentCulture Format Settings are not respected
slug: gridview-troubleshooting-apply-currentculture
tags: currentculture,format,settings,are,not,respected
published: True
position: 15
---

# CurrentCulture Format Settings are not respected



## 

__PROBLEM__

RadGridView does not respect the CurrentCulture Format settings when formatting its data.

>Please note that GridViewCells respect the Language property and the result of the aggregate function, displayed for the GridViewFooterCells, respects the CurrentCulture settings.
          

__CAUSE__{% if site.site_name == 'WPF' %}

It is due to the fact that the culture used for __formatting the data__ is now the one specified as a __Language for the GridView__ (or the containing Window).{% endif %}{% if site.site_name == 'Silverlight' %}

It is due to the fact that the culture used for __formatting the data__ is now the one specified as a __Language for the GridView__ (or the containing Page).{% endif %}

We have changed this behavior with the version __Q2 2012 SP2__, so now it is compatible with the behavior of the MS DataGrid.
        

__SOLUTION__

With __Q1 2013__ we have introduced a new property of the RadGridView - __IsLocalizationLanguageRespected__. You can use it to control whether the CurrentCulture or the Language to be respected. By default the Language will be respected.
        

Another approach would be to set the Language based on the CurrentCulture. It can be set like so:
        {% if site.site_name == 'WPF' %}



#### __XAML__

{{region gridview-troubleshooting-apply-currentculture_0}}
	public MainWindow()
	{
	  InitializeComponent();
	  this.Language = XmlLanguage.GetLanguage(CultureInfo.CurrentCulture.IetfLanguageTag);
	}
	
	{{endregion}}

{% endif %}{% if site.site_name == 'Silverlight' %}



#### __XAML__

{{region gridview-troubleshooting-apply-currentculture_1}}
	public MainPage()
	{
	  InitializeComponent();
	  
	  Dispatcher.BeginInvoke(new Action(() => this.Language = XmlLanguage.GetLanguage(CultureInfo.CurrentCulture.Name)));
	}
	
	{{endregion}}

{% endif %}
