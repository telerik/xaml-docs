---
title: Styling FilteringControl and FilteringDropDown
page_title: Styling FilteringControl and FilteringDropDown
description: Get started with Telerik's {{ site.framework_name }} DataGrid and learn how to style the FilteringControl and FilteringDropDown elements.
slug: gridview-styling-filteringcontrol
tags: styling,filteringcontrol
published: True
position: 19
---

# Styling FilteringControl and FilteringDropDown

In this topic we will discuss:

* [Styling FilteringDropDown](#styling-filteringdropdown)

* [Styling FilteringControl](#styling-filteringcontrol)

>Both controls are located in the **Telerik.Windows.Controls.GridView** namespace of the **Telerik.Windows.Controls.GridView** assembly. When working in **Expression Blend**, the namespaces that are needed will be added automatically.

#### __Figure 1: The FilteringControl & FilteringDropDown template structure__

![Telerik {{ site.framework_name }} DataGrid Styles and Templates FilteringControl Template Structure](images/RadGridView_Styles_and_Templates_FilteringControl_Template_Structure.png)

>tipThe Template Structure of the controls is also available [here]({%slug radgridview-styles-and-templates-templates-structure%}).

## Styling FilteringDropDown

The filtering dropdown icon can be styled by creating an appropriate style targeting the **FilteringDropDown** element.

#### __Figure 2: The default FilteringDropDown element__

![Telerik {{ site.framework_name }} DataGrid Styles and Templates FilteringDropDown](images/RadGridView_Styles_and_Templates_FilteringDropDown.png)

To learn how to modify the default FilteringDropDown style, please refer to the [Modifying Default Styles]({%slug gridview-modifying-default-styles%}) article.

## Styling FilteringControl

__GridViewColumn__ exposes the __FilteringControlStyle__ property of type __Style__. It is applied to the __FilteringControl__ of the column.

#### __Figure 3: The default FilteringControl element__

![Telerik {{ site.framework_name }} DataGrid Styles and Templates FilteringControl](images/RadGridView_Styles_and_Templates_FilteringControl.png)

You can modify it similarly to the FilteringDropDown style and set it as follows:

#### __XAML__

```XAML
	<telerik:GridViewDataColumn FilteringControlStyle="{StaticResource FilteringControlStyle}" />
```

>You can find the Template Structure of the FilteringControl [here]({%slug radgridview-styles-and-templates-templates-structure%}).

You are also free to create your own [Custom Filtering Control]({%slug gridview-filtering-custom-filtering-controls%}) and craft it as you like.

## See Also

 * [Modifying Default Styles]({%slug gridview-modifying-default-styles%})

 * [Editing Control Templates]({%slug styling-apperance-editing-control-templates%})

 * [Filter goes outside the window]({%slug gridview-troubleshooting-filtering-control%})

 * [Styling the FilterRow]({%slug gridview-styling-filterrow%})
