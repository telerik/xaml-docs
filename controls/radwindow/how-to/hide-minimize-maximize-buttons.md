---
title: Hide the Maximize and Minimize buttons
page_title: Hide the Maximize and Minimize buttons
description: Hide the Maximize and Minimize buttons
slug: radwindow-how-to-hide-minimize-maximize-buttons
tags: hide,the,maximize,and,minimize,buttons
published: True
position: 3
---

# Hide the Maximize and Minimize buttons



If you want to hide the Minimize and Maximize buttons you have two options:

* [Use the ResizeMode property](#Use_the_ResizeMode_property)

* [Hide the buttons in the RadWindow's ControlTemplate](#Hide_the_buttons_in_the_RadWindows_ControlTemplate)

## Use the ResizeMode property

By setting the __ResizeMode__ property to __CanMinimize__ only the __Minimize__ button will be visible. The resize button will get hidden and the resizing will get disabled. By setting the __ResizeMode__ property to __NoResize__ both the Minimize and the Maximize buttons will get hidden, the resizing will also get disabled. 

>If you want to hide these buttons without affecting the resizing functionality, consider using the approach explained below.

To learn more about resizing the __RadWindow__ read [here]({%slug radwindow-features-resizing%}).

## Hide the buttons in the RadWindow's ControlTemplate

Before continuing you have to get familiar with the [RadWindow's template structure]({%slug radwindow-styles-and-templates-template-structure%}) and [how to edit the default template](http://www.telerik.com/help/silverlight/common-styling-appearance-edit-control-templates-blend.html) for the __RadWindow__.

After getting familiar with the template and preparing it for editing via Expression Blend, the only thing left is to locate the __Button__ controls that represent the __Minimize__ and the __Maximize__ buttons and to set their __Visibility__ to __Collapsed__. These buttons have their __Name__ properties set to __PART_MinimizeButton__ and __PART_MaximizeButton__.

# See Also

 * [Minimizing/Maximizing]({%slug radwindow-features-minimizingmaximazing%})

 * [Prevent Dragging Off the Screen]({%slug radwindow-how-to-prevent-dragging-off-the-screen%})

 * [Center the Header of the RadWindow]({%slug radwindow-how-to-center-the-header-of-the-content%})
