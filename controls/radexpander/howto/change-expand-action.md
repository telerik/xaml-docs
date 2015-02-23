---
title: How To Change the Action Trigering an Expand
page_title: How To Change the Action Trigering an Expand
description: How To Change the Action Trigering an Expand
slug: radexpander-howto-change-expand-action
tags: how,to,change,the,action,trigering,an,expand
published: True
position: 2
---

# How To Change the Action Trigering an Expand

This article describes how to control the mouse action that triggers an expand.

The __RadExpander__ control exposes a __ClickMode__ property to allow you to determine when the content of the control should be expanded. The property is an enumeration of type __ClickMode__ that exposes the following members:	  

* __Release__ - specifies that the content should be expanded when the left mouse button is pressed and released on top of the __RadExpander.Header__. If you are using the keyboard, this setting specifies that the content should be expanded when the __RadExpander.Header__ is focused and the __SPACEBAR__ or __ENTER__ key is pressed and released.

* __Press__ - specifies that the content should be expanded when the left mouse button is pressed on top of the __RadExpander.Header__. If you are using the keyboard, this setting specifies that the content should be expanded when the __RadExpander.Header__ is focused and the __SPACEBAR__ or __ENTER__ key is pressed.

* __Hover__ - specifies that the content should be expanded when the mouse pointer hovers over the __RadExpander.Header__. 

The default value of the __ClickMode__ property is __Release__ which means that by  default the __RadExpander__ control is expanded when the left mouse button is released after a click on the header or when  the __Enter__ or __Space__ keys are released while focusing the header.