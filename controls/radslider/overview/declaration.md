---
title: Getting Started
page_title: Getting Started
description: Getting Started
slug: radslider-declaration
tags: getting,started
publish: True
position: 1
---

# Getting Started



## 

>


							In order to use __RadSlider__ control in your projects you have to add reference to the __Telerik.Windows.Controls__ assembly.
						{% if site.site_name == 'WPF' %}


								You can find more info [here](http://www.telerik.com/help/wpf/installation-installing-controls-dependencies-wpf.html).
							{% endif %}{% if site.site_name == 'Silverlight' %}


								You can find more info [here](http://www.telerik.com/help/silverlight/installation-installing-controls-dependencies.html).
							{% endif %}


					If you are new to e {% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %} check the article {% if site.site_name == 'Silverlight' %}{% endif %}[ Namespace Declaration](http://www.telerik.com/help/silverlight/installation-adding-application-namespace-declaration.html){% if site.site_name == 'WPF' %}[ Namespace Declaration](http://www.telerik.com/help/wpf/installation-adding-application-namespace-declaration-wpf.html){% endif %} to see namespaces in XAML. After you have referenced the assembly and you have named it for example "telerik" your XAML declaration should look similar to this:
				

#### __XAML__

{{region radslider-declaration_0}}
	<telerik:RadSlider Value="5" Minimum="0" SmallChange="1" Maximum="100"/>
	{{endregion}}



Code-behind declaration:

#### __C#__

{{region radslider-declaration_1}}
	RadSlider slider = new RadSlider();
	slider.Maximum = 100;
	slider.Minimum = 0;
	slider.Value = 5;
	slider.SmallChange = 1;
	{{endregion}}



#### __VB.NET__

{{region radslider-declaration_1}}
		Dim slider As New RadSlider()
		slider.Maximum = 100
		slider.Minimum = 0
		slider.Value = 5
		slider.SmallChange = 1
	#End Region
	End Class



![](images/radslider_gettingstarted.png)
