---
title: Focus Input Controls In Header
page_title: Focus Input Controls In Header
description: Focus Input Controls In Header
slug: radwindow-how-to-focus-input-controls-in-header
tags: focus,input,controls,in,header
published: True
position: 0
---

# Focus Input Controls In Header

An interesting use case when working with the **RadWindow** control is when you want to add an input control, let's say **TextBox**, for example, to the window's header. When trying to do so, however, you will notice that the RadWindow itself handles various mouse events. In such way it prevents the input control from gaining focus, making it almost unusable.

To prevent the RadWindow from handling the mouse events, you have to set the attached **WindowHost.HitTestable** of the input control to **True**.

#### __[XAML] Example 1: Set WindowHost.HitTestable property__

{{region xaml-radwindow-how-to-focus-input-controls-in-header_0}}
	<TextBox Text="{Binding SearchText}" telerik:WindowHost.HitTestable="False" />
{{endregion}}

## See Also

 * [Center the Header of the RadWindow]({%slug radwindow-how-to-center-the-header-of-the-content%})
 * [Working with RadWindow]({%slug radwindow-features-working-with-radwindow%})
 * [Hide the Maximize and Minimize Buttons]({%slug radwindow-how-to-hide-minimize-maximize-buttons%})
