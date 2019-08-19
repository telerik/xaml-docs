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

* [Set the HideMinimizeButton and HideMaximizeButton properties](#set-the-hideminimizebutton-and-hidemaximizebutton-properties)

* [Use the ResizeMode property](#use-the-resizemode-property)

## Set the HideMinimizeButton and HideMaximizeButton properties

The easiest way to hide the minimize or maximize buttons is to set the __HideMinimizeButton__ and __HideMaximizeButton__ properties respectively. This is demonstrated in __Example 1__. 

#### __[XAML] Example 1: Hiding the Minimize and Maximize Buttons__

{{region xaml-radwindow-how-to-hide-minimize-maximize-buttons-0}}
	<telerik:RadWindow 
		xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"
        HideMaximizeButton="True" 
        HideMinimizeButton="True"
		Header="MainWindow" />
{{endregion}}

#### __Figure 1: Result from Example 1 in the Office2016 theme__
![RadWindow without Maximize and Minimize buttons](images/RadWindow_Hide_Maximize_And_Minimize.png)

## Use the ResizeMode property

By setting the __ResizeMode__ property to __CanMinimize__ only the __Minimize__ button will be visible. The resize button will get hidden and the resizing will get disabled. This is demonstrated in __Example 2__.

#### __[XAML] Example 2: Showing only the Minimize Button__

{{region xaml-radwindow-how-to-hide-minimize-maximize-buttons-0}}
	<telerik:RadWindow 
		xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"
    	ResizeMode="CanMinimize"
		Header="MainWindow" />
{{endregion}}

#### __Figure 2: Result from Example 2 in the Office2016 theme__
![RadWindow with just Minimize button](images/RadWindow_Show_Only_Minimize.png)

 By setting the __ResizeMode__ property to __NoResize__ both the Minimize and the Maximize buttons will get hidden, the resizing will also get disabled. This is demonstrated in __Example 3__.

#### __[XAML] Example 3: Showing only the Close button__

{{region xaml-radwindow-how-to-hide-minimize-maximize-buttons-0}}
	<telerik:RadWindow 
		xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"
        ResizeMode="NoResize"
		Header="MainWindow" />
{{endregion}}

#### __Figure 3: Result from Example 3 in the Office2016 theme__
![RadWindow with just the Close button](images/RadWindow_Disable_Minimize_And_Maximize.png)

To learn more about resizing the __RadWindow__ read [here]({%slug radwindow-features-resizing%}).

## See Also

 * [Minimizing/Maximizing]({%slug radwindow-features-minimizingmaximazing%})

 * [Prevent Dragging Off the Screen]({%slug radwindow-how-to-prevent-dragging-off-the-screen%})

 * [Center the Header of the RadWindow]({%slug radwindow-how-to-center-the-header-of-the-content%})