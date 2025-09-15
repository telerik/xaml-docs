---
title: Using TextBoxBehavior
page_title: Using TextBoxBehavior
description: Check out which behavior pattern you can use in order to change the default behavior of a TextBox within RadGridView - Telerik's {{ site.framework_name }} DataGrid.
slug: gridview-how-to-update-on-every-text-changed
tags: using,textboxbehavior
published: True
position: 10
---

# Using TextBoxBehavior

## TextBoxBehavior

You can use attached behavior pattern in order to change the default behavior of a TextBox.

The TextBoxBehavior is available within Telerik.Windows.Controls assembly and you can use it out of the box. A list of its members could be bound {% if site.site_name == 'Silverlight' %}[here](http://www.telerik.com/help/silverlight/methods_t_telerik_windows_controls_textboxbehavior.html){% endif %}{% if site.site_name == 'WPF' %}[here](http://www.telerik.com/help/wpf/methods_t_telerik_windows_controls_textboxbehavior.html){% endif %}.

For example you can update the source of the binding on every text change. You could apply the behaviour like so:
        
#### __XAML__

```XAML
	<TextBox Text="{Binding Name}" telerik:TextBoxBehavior.UpdateTextOnTextChanged="True" />
```


