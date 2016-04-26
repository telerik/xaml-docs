---
title: Selection Mini Tool Bar
page_title: Selection Mini Tool Bar
description: Selection Mini Tool Bar
slug: radrichtextbox-features-selection-mini-toolbar
tags: selection,mini,tool,bar
published: True
position: 4
---

# Selection Mini Tool Bar



## 

__SelectionMiniToolBar__ is a floating toolbar that appears next to the current position after making a selection with the mouse in the document. It contains some useful commands for formatting text.
  

{% if site.site_name == 'Silverlight' %}
![](images/RadRichTextBox_Features_SelectionMiniToolbar_01.png){% endif %}

{% if site.site_name == 'WPF' %}
![](images/RadRichTextBox_Features_SelectionMiniToolbar_01_WPF.png){% endif %}

As __RadRichTextBox__ loads the default __SelectionMiniToolBar__ using [MEF](http://mef.codeplex.com/), it can be completely replaced with a custom one. This can be done as easy as with the other __RadRichTextBox__ dialogs by implementing the interface __ISelectionMiniToolBar__ and marking the class that implements it with the __CustomSelectionMiniToolBarAttribute__  attribute.  The technique was also described in greater details in [this blog post](http://blogs.telerik.com/xamlteam/posts/10-09-28/some-tricks-with-mef-up-the-sleeve-of-radrichtextbox-for-silverlight.aspx).
        

And of course, for those of you who don't need additional UI pop-ups, these can be disabled by setting the __IsSelectionMiniToolBarEnabled__ property of __RadRichTextBox__ to __False__.
        
