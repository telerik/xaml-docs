---
title: Customizing Drag Visual
page_title: Customizing Drag Visual
description: Customizing Drag Visual
slug: radfiledialogs-features-dragdrop-customize-drag-visual
tags: features,dragdrop
published: True
position: 2
---

# Customizing the Drag Visual

The visual element shown when you drag an item is presented by the __FileBrowserDragVisual__ control. To customize the appearance you can set several properties of the control or extract its template and modify it.

#### __Figure 1: Default drag visual__
![](images/filedialogs-drag-drop-overview-0.png)

## Setting the Drag Visual Appearance

To customize the FileBrowserDragVisual you will need to define an implicit Style targeting the control and place it in the App.xaml Resources.

#### __[XAML] Example 1: Setting the drag visual properties__ 
{{regiond radfiledialogs-features-dragdrop-customize-drag-visual-0}}
	<Application.Resources>
        <Style TargetType="telerik:FileBrowserDragVisual">
            <Setter Property="" Value="" />
        </Style>
    </Application.Resources>
{{endregiond}}

> It is important to define the style in the application's Resources. Otherwise, it won't be applied.

<!-- TODO: ADD INFO ABOUT THE DIFFERENT PROPERTIES BELOW-->

## Setting the Drag Visual Offset

## Setting Icon Template

## Setting Content Template

## See Also  
* [Getting Started]({%slug radfiledialogs-getting-started%})
* [Drag Drop Overview]({%slug radfiledialogs-features-dragdrop-overview%})
