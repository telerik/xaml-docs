---
title: Changes
page_title: Changes
description: Changes
slug: radwindow-changes
tags: changes
published: True
position: 0
---

# Changes

This article describes the release history of the control.

For the complete Release History of UI for {% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %} go to {% if site.site_name == 'Silverlight' %}[What's New Section](http://www.telerik.com/products/silverlight/whats-new.aspx){% endif %}{% if site.site_name == 'WPF' %}[What's New Section](http://www.telerik.com/products/wpf/whats-new.aspx){% endif %}.

## Q1 2013

### What's Fixed

{% if site.site_name == 'WPF' %}
* The minimized RadWindow buttons are wider than they should be

* Coded UI can't locate RadWindow at playback

* Exception is thrown when you call Show() of RadWindow that is already opened
{% endif %}

{% if site.site_name == 'Silverlight' %}
* The minimized RadWindow buttons are wider than they should be

* Exception is thrown when you call Show() of RadWindow that is already opened

* If the height of the browser is smaller then the RestrictedAreaMargin an ArgumentException is thrown

* If in a RadWindow the first elements are two consecutive DateTimePicker controls and that Window is focused the application hangs
{% endif %}

## Q1 2013

### What's New

* Add Name="HeaderContent" to a Title ContentControl in the Windows7 theme

* Make it possible to get the full position of a window and then be able to restore it (minimized, maximized, normal states)

* Delete obsoleted RenderActive property from RadWindow

### What's Fixed

{% if site.site_name == 'WPF' %}
* Performance issue when DropShadowEffect is applied to the outer border of RadWindow in Windows8Touch theme

* Validation tooltip is misplaced on start up

* Focusing RadWindows in OOB applications throws exception

* FocusVisual border does not disappear from buttons when window is closed

* An IndexOutOfRangeException is thrown in a certain scenario when a RadWindow with WindowState set to Maximized is open through another RadWindow
{% endif %}

{% if site.site_name == 'Silverlight' %}
* Validation tooltip is misplaced on start up

* Focusing RadWindows in OOB applications throws exception

* FocusVisual border does not disappear from buttons when window is closed

* An IndexOutOfRangeException is thrown in a certain scenario when a RadWindow with WindowState set to Maximized is open through another RadWindow
{% endif %}