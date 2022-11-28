---
title: Grip Visibility
page_title: Grip Visibility
description: Check our &quot;Grip Visibility&quot; documentation article for the RadToolBar {{ site.framework_name }} control.
slug: radtoolbar-features-grip-visibility
tags: gripvisibility,visibility,collapsed
published: True
position: 2
---

# Grip Visibility

By default a small grip visual is shown in the `RadToolBar` control. 

![WPF RadToolBar ](images/radtoolbar-features-grip-visibility-0.png)

To hide it, set the `GripVisibility` property to `Collapsed`.

#### __[XAML] Example 3: Hiding the grip__
{{region radtoolbar-features-grip-visibility-0}}	
	<telerik:RadToolBar>
		<telerik:RadButton Content="B1" />
		<telerik:RadButton Content="B2 " />
		<telerik:RadButton Content="B3" />
	</telerik:RadToolBar>           
{{endregion}}

![WPF RadToolBar ](images/radtoolbar-features-grip-visibility-1.png)

## See Also
* [Getting Started]({%slug radtoolbar-getting-started%})
* [Overflow Items]({%slug radtoolbar-features-overflow-items%})
* [RadToolBarTray]({%slug radtoolbartray-overview%})