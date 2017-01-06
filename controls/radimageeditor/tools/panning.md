---
title: Panning
page_title: Panning
description: Panning
slug: radimageeditor-tools-panning
tags: panning,tool,pan
published: True
position: 2
---

# Panning

The __PanTool__ is one of the tools that come out-of-the-box with the __RadImageEditor__ and enables you to pan the image using the mouse. 

Similarly to the other __RadImageEditor__ tools, the __PanTool__ is located in the __Telerik.Windows.Media.Imaging.Tools__ namespace and inherits the [DrawToolBase]({%slug radimageeditor-howto-implement-drawtoolbase%}) class. The tool can be defined in XAML as demonstrated in __Example 1__.

#### __[XAML] Example 1: Define PanTool__  
{{region xaml-radimageeditor-tools-panning_0}}
	<tools:PanTool />
{{endregion}}

> The image editor tools are used along with the __RadImageEditorUI__ control. See the [related article]({%slug radimageeditor-features-radimageeditorui%}) to see where to define the tool.

## Enable panning manually

The panning feature can be enabled also by setting the __IsPanningEnabled__ property of the __RadImageEditor__ control to __True__. The default value of the property is False and the panning is disabled.

#### __[XAML] Example 2: Enable PanTool__  
{{region xaml-radimageeditor-tools-panning_0}}
	<telerik:RadImageEditor IsPanningEnabled="True"/>
{{endregion}}

The following image demonstrates the panning feature.  
![](images/radimageeditor-tool-panning-0.gif)

## See Also  
* [Commands and Tools]({%slug radimageeditor-features-commands-and-tools%})
* [Cropping]({%slug radimageeditor-tools-crop%})
* [Shape Tool]({%slug radimageeditor-tools-shape-tool%})
