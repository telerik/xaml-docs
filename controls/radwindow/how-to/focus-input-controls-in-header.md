---
title: Allow Hit Test on Controls in the Header
page_title: Allow Hit Test on Controls in the Header
description: Check our &quot;Focus Input Controls In Header&quot; documentation article for the RadWindow {{ site.framework_name }} control.
slug: radwindow-how-to-focus-input-controls-in-header
tags: focus,input,controls,in,header
published: True
position: 0
---

# Allow Hit Test on Controls in the Header

By default `RadWindow` handles the mouse events for the elements defined in its header, which excludes them from the hit testing.

This means that placing input controls like `TextBox` or `Button` won't react to the mouse events. To change this behavior, set the `WindowHost.HitTestable` attached property on the corresponding element to `true`.

__Set the WindowHost.HitTestable property__  
```XAML
	<telerik:RadWindow.Header>
		<TextBox Text="{Binding Text}" telerik:WindowHost.HitTestable="True" />
 	<telerik:RadWindow.Header>
```

## See Also  
 * [Center the Header of the RadWindow]({%slug radwindow-how-to-center-the-header-of-the-content%})
 * [Working with RadWindow]({%slug radwindow-features-working-with-radwindow%})
 * [Hide the Maximize and Minimize Buttons]({%slug radwindow-how-to-hide-minimize-maximize-buttons%})
