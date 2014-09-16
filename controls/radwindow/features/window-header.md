---
title: Window Header
page_title: Window Header
description: Window Header
slug: radwindow-features-window-header
tags: window,header
publish: True
position: 5
---

# Window Header



## 

The __RadWindow__ allows you to display a header in the top part of it. To specify the header you can use either the __Header__or the __HeaderTemplate__properties.

If you have a window-specific header, use the __Header__property.

>tipAs the __Header__property is of type object you can set it to any control that you like. If you want to have a more complex icon content that consists of more than one control, be sure to wrap them inside a layout control and pass the layout control as content.

>It's not a good practice do declare your __RadWindow__as visual element in XAML. The only scenario, when it is meaningful to use the __RadWindow__ in XAML, is when it represents the entire user control. To learn more about that read [here]({%slug radwindow-how-to-use-radwindow-as-user-control%}).

#### __C#__

{{region radwindow-features-window-header_0}}
	RadWindow radWindow = new RadWindow();
	radWindow.Header = "My RadWindow";
	{{endregion}}



#### __VB.NET__

{{region radwindow-features-window-header_1}}
	Dim radWindow As New RadWindow()
	radWindow.Header = "My RadWindow"
	{{endregion}}



If you want to share a common icon layout structure for the content of multiple windows, define an appropriate __DataTemplate__ and set it to the __IconTemplate__ property of the __RadWindow__.

#### __XAML__

{{region radwindow-features-window-header_2}}
	<UserControl.Resources>
	    <DataTemplate x:Key="WindowHeaderTemplate">
	        <TextBlock Text="My RadWindow" />
	    </DataTemplate>
	</UserControl.Resources>
	{{endregion}}



#### __C#__

{{region radwindow-features-window-header_3}}
	RadWindow radWindow = new RadWindow();
	radWindow.HeaderTemplate = this.Resources[ "WindowHeaderTemplate" ] as DataTemplate;
	{{endregion}}



#### __VB.NET__

{{region radwindow-features-window-header_4}}
	Dim radWindow As New RadWindow()
	radWindow.HeaderTemplate = TryCast(Me.Resources("WindowHeaderTemplate"), DataTemplate)
	{{endregion}}






         
      ![](images/RadWindow_Features_Window_Header_01.png)

# See Also

 * [Window Icon]({%slug radwindow-features-window-icon%})

 * [Minimizing/Maximizing]({%slug radwindow-features-minimizingmaximazing%})

 * [Resizing]({%slug radwindow-features-resizing%})
