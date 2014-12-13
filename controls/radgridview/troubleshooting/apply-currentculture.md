---
title: CurrentCulture Format Settings are not respected
page_title: CurrentCulture Format Settings are not respected
description: CurrentCulture Format Settings are not respected
slug: gridview-troubleshooting-apply-currentculture
tags: currentculture,format,settings,are,not,respected
published: True
position: 16
---

# CurrentCulture Format Settings are not respected

__PROBLEM__

__RadGridView__ does not respect the __CurrentCulture Format__ settings when formatting its data.

>Please note that __GridViewCells__ respect the __Language__ property and the result of the aggregate function, displayed for the __GridViewFooterCells__, respects the __CurrentCulture__ settings.
          

__CAUSE__{% if site.site_name == 'WPF' %}

It is due to the fact that the culture used for __formatting the data__ is now the one specified as a __Language for the GridView__ (or the containing Window).{% endif %}{% if site.site_name == 'Silverlight' %}

It is due to the fact that the culture used for __formatting the data__ is now the one specified as a __Language for the GridView__ (or the containing Page).{% endif %}

We have changed this behavior with the version __Q2 2012 SP2__, so now it is compatible with the behavior of the __MS DataGrid__.
        

__SOLUTION__

With __Q1 2013__ we have introduced the __IsLocalizationLanguageRespected__ property of __RadGridView__, which will enable you to control whether the __CurrentCulture__ or the __Language__ will be respected. It can be configured with the following values: 
	
* ___"True"___ - the __Language__ will be respected ___(default)___.
* ___"False"___ - the __CurrentCulture__ format settings will be respected.


         

Another approach would be to set the __Language__ based on the __CurrentCulture__  as follows:
{% if site.site_name == 'WPF' %}

#### __C#__

{{region gridview-troubleshooting-apply-currentculture_0}}

	public MainWindow()
	{
	  InitializeComponent();
	  this.Language = XmlLanguage.GetLanguage(CultureInfo.CurrentCulture.IetfLanguageTag);
	}
	
{{endregion}}

{% endif %}{% if site.site_name == 'Silverlight' %}



#### __C#__

{{region gridview-troubleshooting-apply-currentculture_1}}

	public MainPage()
	{
	  InitializeComponent();
	  
	  Dispatcher.BeginInvoke(new Action(() => this.Language = XmlLanguage.GetLanguage(CultureInfo.CurrentCulture.Name)));
	}	
{{endregion}}

{% endif %}
