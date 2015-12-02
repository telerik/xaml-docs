---
title: Styling RadSpellChecker
page_title: Styling RadSpellChecker
description: Styling RadSpellChecker
slug: radspellchecker-styling-radspellchecker
tags: styling,radspellchecker
published: True
position: 0
---

# Styling RadSpellChecker



## 

__RadSpellChecker__ uses pop-up windows to spellcheck the controls it supports. If you want to change some of the settings for these windows like __StartUp__ location, __LeftOffset__, __RightOffset__ or anything else you can use the __WindowSettings__ property of the static __RadSpellChecker__ class. 

The windows in __RadSpellChecker__ derive from __RadWindow__, so if you want to check its properties, do it          {% if site.site_name == 'Silverlight' %}[here](http://docs.telerik.com/devtools/silverlight/api/html/T_Telerik_Windows_Controls_RadWindow.htm){% endif %}{% if site.site_name == 'WPF' %}[here](http://docs.telerik.com/devtools/wpf/api/html/T_Telerik_Windows_Controls_RadWindow.htm){% endif %}.
          

Not all properties are exposed, so you can control only the ones that you have access to through __RadSpellChecker__.__WindowSettings__. 

In addition to the properties inherited from RadWindow, there is a property called __Theme__ of type __Telerik.Windows.Controls.Theme__. By setting it you apply a Telerik theme to the windows used by __RadSpellChecker__. 

#### __[C#] Example 1: Apply a Theme to RadSpellChecker's Windows__

{{region radspellchecker-styling-radspellchecker_0}}
	RadSpellChecker.WindowSettings.Theme = new SummerTheme();
{{endregion}}



{% if site.site_name == 'Silverlight' %}

>You need to add references to __Telerik.Windows.Controls__ and the Theme you want to use (in this case __Telerik.Windows.Themes.Summer__) in order to use it.{% endif %}

# See Also

* [Localization]({%slug radspellchecker-localization%})
