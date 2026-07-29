---
title: Styles and Templates
page_title: Styles and Templates
description: This article explains how to modify the apperance of the RadTabbedWindow control.
slug: radtabbedwindow-styles-and-templates
tags: getting,started
published: True
position: 4
---

# Styles and Templates

RadTabbedWindow allows you to easily modify its appearance by providing some useful properties.

## AddButtonStyle

Via the **AddButtonStyle** property, you can control the appearance of the button which is used to add new tabs to the window.

#### [XAML] Example 1: Specify AddButtonStyle

<snippet id='radtabbedwindow-styles-and-templates-block_1-xaml' />

>important If you are using the default Office_Black theme (you have not merged a theme assembly) or you've set a different theme with the [StyleManager]({%slug styling-apperance-implicit-styles-overview%}), you should copy the **AddItemsButtonStyle** and all the referenced resources from the **Telerik.Windows.Controls.Navigation.xaml** file into your project.

## ItemContainerStyle

You can use the **ItemContainerStyle** property to style the individual RadTabItem elements.

#### [XAML] Example 2: Specify ItemContainerStyle

<snippet id='radtabbedwindow-styles-and-templates-block_2-xaml' />

>important If you are using the default Office_Black theme (you have not merged a theme assembly) or you've set a different theme with the [StyleManager]({%slug styling-apperance-implicit-styles-overview%}), you should copy the **RadTabbedWindowTabItemStyle** and all the referenced resources from the **Telerik.Windows.Controls.Navigation.xaml** file into your project.

## ItemContainerStyleSelector

You can also define a **StyleSelector** and conditionally style the tab items via the **ItemContainerStyleSelector** property.

#### [C#] Example 3: Create a custom StyleSelector

<snippet id='radtabbedwindow-styles-and-templates-block_3-cs' />

#### [VB.NET] Example 3: Create a custom StyleSelector

<snippet id='radtabbedwindow-styles-and-templates-block_4-vb' />

#### [XAML] Example 4: Specify ItemContainerStyleSelector property

<snippet id='radtabbedwindow-styles-and-templates-block_5-xaml' />

>important Please note that to use the ItemContainerStyleSelector property, you need to clear the ItemContainerStyle by setting it to **null**.

## ItemTemplate and ItemTemplateSelector

When binding your **RadTabbedWindow** to a collection, you are able to configure the visualization of the data and the appearance of the tab items via the **ItemTemplate** and the **ItemTemplateSelector** properties.

#### [XAML] Example 5: Define a custom ItemTemplate

<snippet id='radtabbedwindow-styles-and-templates-block_6-xaml' />

If you wish to return different templates for the tab items, you can use the **ItemTemplateSelector** property and pass a custom **DataTemplateSelector** to it.

## ContentTemplate and ContentTemplateSelector

Similarly, in a data-binding scenario you can control the appearance of the tabs' content via the **ContentTemplate** and the **ContentTemplateSelector** properties.

#### [XAML] Example 6: Define a custom ContentTemplate

<snippet id='radtabbedwindow-styles-and-templates-block_7-xaml' />

If you wish to return different templates for the tab items' content, you can use the **ContentTemplateSelector** property and pass a custom **DataTemplateSelector** to it.

## See Also

* [Key Properties]({%slug radtabbedwindow-key-properties%})
* [Events]({%slug radtabbedwindow-events%})