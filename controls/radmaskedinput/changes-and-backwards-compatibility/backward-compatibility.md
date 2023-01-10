---
title: Backward Compatibility
page_title: Backward Compatibility
description: Check our &quot;Backward Compatibility&quot; documentation article for the RadMaskedInput {{ site.framework_name }} control.
slug: radmaskedinput-backward-compatibility
tags: backward,compatibility
published: True
position: 0
---

# {{ site.framework_name }} RadMaskedInput Backward Compatibility

## Telerik RadMaskedInput suite of controls - Q3 2011

The value of the {% if site.site_name == 'Silverlight' %} __TabNavigation__ {% endif %}{% if site.site_name == 'WPF' %} __KeyboardNavigation.TabNavigation__ {% endif %} property isn't used in the __RadMaskedInput__ controls tab navigation implementation. From now on you need to set the __SectionsNavigationMode__ property in order to configure the tab navigation in the __RadMaskedInput__ controls. You can find more information about the __SectionsNavigationMode__ property in the [Keyboard and Mouse Support]({%slug radmaskedinput-features-keyboard-mouse%}) article.