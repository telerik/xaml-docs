---
title: Backward Compatibility
page_title: Backward Compatibility
description: Backward Compatibility
slug: radbutton-backward-compatibility
tags: backward,compatibility
published: True
position: 0
---

# Backward Compatibility



## Telerik RadButtons - Q3 2011

The {% if site.site_name == 'Silverlight' %}__VisualStates__{% endif %}{% if site.site_name == 'WPF' %}__Triggers__{% endif %} in the __ControlTemplates__ of the __RadButtons__ are modified. This may cause exceptions for users who have applied custom __ControlTemplates__ for the __RadButtons__ only in case they also set the __IsBackgroundVisible__ property to __False__.

## Telerik RadButtons - Q2 2011

The __ControlTemplate__ of the __RadButtons__ is changed. The __ButtonChrome__ element is removed to improve the templating mechanism of the controls. As a result, the controls will allow easier customization and maintenance with non-default themes and __ControlTemplates__. However, this  shouldn't cause any backwards incompatibility issues for users who already use custom styles.
