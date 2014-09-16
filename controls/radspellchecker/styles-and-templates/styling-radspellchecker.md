---
title: Styling RadSpellChecker
page_title: Styling RadSpellChecker
description: Styling RadSpellChecker
slug: radspellchecker-styling-radspellchecker
tags: styling,radspellchecker
publish: True
position: 0
---

# Styling RadSpellChecker



## 

__RadSpellChecker__uses pop-up windows to spellcheck the controls it supports. If you want to change some of the settings for these windows like __StartUp__location, __LeftOffset__, __RightOffset__or anything else you can use the __WindowSettings__property of the static __RadSpellChecker__class. The windows in __RadSpellChecker__derive from __RadWindow__, so if you want to check its properties, do it here: 
          {% if site.site_name == 'Silverlight' %}[http://www.telerik.com/help/silverlight/telerik.windows.controls.navigation-telerik.windows.controls.radwindow_properties.html](http://www.telerik.com/help/silverlight/telerik.windows.controls.navigation-telerik.windows.controls.radwindow_properties.html){% endif %}{% if site.site_name == 'WPF' %}[http://www.telerik.com/help/wpf/telerik.windows.controls.navigation-telerik.windows.controls.radwindow_properties.html](http://www.telerik.com/help/wpf/telerik.windows.controls.navigation-telerik.windows.controls.radwindow_properties.html){% endif %}.
          

Not all properties are exposed, so you can control only the ones that you have access to through __RadSpellChecker__.__WindowSettings__. 

In addition to the properties inherited from RadWindow, there is one additional property called __Theme__of type __Telerik.Windows.Controls.Theme__. By setting it you apply a Telerik theme to the windows used by RadSpellChecker. Here is the code to do so:

#### __C#__

{{region radspellchecker-styling-radspellchecker_0}}
	RadSpellChecker.WindowSettings.Theme = new SummerTheme();
	{{endregion}}



{% if site.site_name == 'Silverlight' %}

>You need to add references to __Telerik.Windows.Controls__and the Theme you want to use in this case __Telerik.Windows.Themes.Summer__in order to use it.{% endif %}

In next versions of RadSpellChecker the number of properties exposed will most probably grow. 
