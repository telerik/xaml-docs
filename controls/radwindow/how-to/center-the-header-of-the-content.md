---
title: Center the Header of the RadWindow
page_title: Center the Header of the RadWindow
description: Check our "Center the Header of the RadWindow" documentation article for the RadWindow WPF control.
slug: radwindow-how-to-center-the-header-of-the-content
tags: center,the,header,of,the,radwindow
published: True
position: 4
---

# Center the Header of the RadWindow

In order to allow the content in the header to be centered, you can set a UIElement (for example TextBlock) with HorizontalAlignment="Center" as the __Header__ of the RadWindow. This is demonstrated in __Example 1__.

#### __[XAML] Example 1: Centering the Header of the RadWindow__

{{region xaml-radwindow-how-to-center-the-header-of-the-content-0}}
	<telerik:RadWindow 
		xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"
		Width="380">
    <telerik:RadWindow.Header>
        <TextBlock Text="My Header" HorizontalAlignment="Center" />
    </telerik:RadWindow.Header>
</telerik:RadWindow>
{{endregion}}

#### __Figure 1: Result from Example 1 in the Office2016 theme__
![RadWindow with Centered Header](images/RadWindow_How_To_Center_the_Header_01.png)

>tip Alternatively, you can also place the centered UIElement in the __HeaderTemplate__ of the RadWindow.

## See Also

 * [Window Header]({%slug radwindow-features-window-header%})

 * [Close the RadWindow Through its Content]({%slug radwindow-how-to-close-the-radwidnow-through-its-content%})

 * [Hide the Maximize and Minimize buttons]({%slug radwindow-how-to-hide-minimize-maximize-buttons%})
