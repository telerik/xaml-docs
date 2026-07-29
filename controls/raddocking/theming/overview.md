---
title: Overview
page_title: Overview
description: Check our &quot;Overview&quot; documentation article for the RadDocking {{ site.framework_name }} control.
slug: raddocking-theming-overview
tags: overview
published: True
position: 0
---

# Overview

>tip This topic will present you with the simple way of creating a theme. It's suitable for themes which contain less XAML. The advanced approach is more performant, especially when creating themes for the larger controls.

The __RadDocking__ uses controls such as __PaneHeader__, [RadPaneGroup]({%slug raddocking-features-pane-groups%}), [ToolWindow]({%slug raddocking-features-tool-window%}), [RadSplitContainer]({%slug raddocking-features-split-container%}) that are usually created dynamically depending on the user's actions. Such controls cannot be styled declaratively in XAML. In order to style them you have to apply a theme to your __RadDocking__ control that contains the styles for them. 

>By applying a theme, the style for a particular control will be set to all of the controls of this type.

## Creating the Theme

Before theming the controls involved with the __RadDocking__ control, you have to create a Class Library project that will represent your theme. For example create a project with the following name.

![{{ site.framework_name }} RadDocking Custom Theme WPF](images/RadDocking_ThemingOverview_02.png)

In the __Generic.xaml__ you should place the styles and the resources for your theme.

>The __RadDockingTheme__ class should inherit from the Telerik.Windows.Controls.__Theme__ class.

## Applying a Theme

The theme can be easily set to your __RadDocking__ control in the following way.

<snippet id='raddocking-theming-overview-block_1-cs' />

<snippet id='raddocking-theming-overview-block_1-vb' />


<snippet id='raddocking-theming-overview-block_2-xaml' />


<snippet id='raddocking-theming-overview-block_3-cs' />

<snippet id='raddocking-theming-overview-block_3-vb' />


To learn more about theming controls read the common theming topics on this matter. If you are new to the controls they will give you a basic knowledge about it.

## See Also  
* [Theming the Pane Header]({%slug raddocking-theming-pane-header%})
* [Theming the RadPaneGroup]({%slug raddocking-theming-radpane-group%})
* [Theming the ToolWindow]({%slug raddocking-theming-toolwindow%})
* [Theming the RadSplitContainer]({%slug raddocking-theming-radsplitcontainer%})