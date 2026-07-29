---
title: Lightweight Templates
page_title: Lightweight Templates
description: Learn more about the lightweight templates of Telerik's {{ site.framework_name }} DataGrid that are represented by several additional simplified styles.
slug: gridview-overview-lightweight-template
tags: lightweight,templates
published: True
position: 8
---

# Lightweight Templates


With __2013 Q2 SP__ we have introduced lightweight templates for __RadGridView and RadTreeListView__. This article will walk you through the following sections:

* [Core Styles](#core-styles)
* [Core Styles Including Validation](#core-styles-with-validation) 
* [Remove the Border of the Current Cell](#remove-the-border-of-the-current-cell)
* [Remove the Border of the Current Cell With Validation](#remove-the-border-of-the-current-cell-with-validation)

They are represented by several additional __simplified styles, which you can merge in your project__. The main idea of simplifying templates of different parts of RadGridView is to limit the number of visual elements within the templates in order to __speed up the performance__ of __RadGridView/RadTreeListView__.   

>important The Lightweight Templates can only be applied with NoXaml binaries and Implicit Themes. You can find more information on them [here]({%slug styling-apperance-implicit-styles-overview%}).
     
{% if site.site_name == 'WPF' %}   
>tip The performance on loading the visual elements will be increased __up to 50%__ when the lightweight templates are applied.{% endif %}
{% if site.site_name == 'Silverlight' %}
>The performance on loading the visual elements will be increased __up to 25%__ when the lightweight templates are applied.
{% endif %}

>Please note that the **row details** and **hierarchy** features are not supported for rows which use lightweight templates as the **PART_HierarchyChildPresenter** and **PART_DetailsPresenter** elements which are responsible for displaying the hierarchcal data are not defined in these templates. They can, however, still be used for the bottom-level RadGridView instances of the hierarchy (those which do not have any children).

## Core Styles

The CoreStyles are a basic alternative of the standard __GridViewCell, GridViewRow, TreeListViewRow__ including basic еffects and funcionalities such as __hover, selection, currency, grouping__ for these elements. These core styles are included within the themes of RadGridView and you may reference them in your project as shown below:        

__Example 1: Applying the Lightweight Templates__
<snippet id='radgridview-features-overview-lightweight-template-example_1_applying_the_lightweight_templates-xaml' />


#### __Figure 1: RadGridView with Lightweight templates applied__

![Telerik UI for {{ site.framework_name }} RadGridView with lightweight templates applied](images/gridview_overview_lightweight_0.png)

>tip For __RadGridView__ you need to merge only the CoreStyles for __GridViewCell and GridViewRow__. For __RadTreeListView__ you need to merge the styles for __GridViewCell and TreeListViewRow__.

>__GridViewRowCoreStyle__ does not contain a row indicator. Please set the __RowIndicatorVisibility__ property of the RadGridView to __Collapsed__ to avoid any visual differences between the row's headers and cells.          

## Core Styles with Validation

The CoreValidationStyles are an alternative of the standard __GridViewCell, GridViewRow, TreeListViewRow__. They include basic еffects and funcionalities such as __hover, selection, currency, grouping, validation__ for these elements. These core styles are included within the themes of RadGridView and you may reference it in your project as shown below.        

__Example 2: Applying Lightweight Templates with Validation__
<snippet id='radgridview-features-overview-lightweight-template-example_2_applying_lightweight_templates_with_validation-xaml' />


#### __Figure 2: RadGridView with Lightweight templates with validation applied__

![Telerik UI for {{ site.framework_name }} RadGridView with lightweight templates and validation applied](images/gridview_overview_lightweight_1.png)

>__GridViewRowCoreValidationStyle__ contains a row indicator, which you can use to perform validation.
          

>tip For __RadGridView__ you need to merge only the CoreStyles for __GridViewCell and GridViewRow__. For __RadTreeListView__ you need to merge the styles for __GridViewCell and TreeListViewRow__.

## Remove the Border of the Current Cell

For such requirement, you need to predefine the __ControlTemplate__ applied to __GridViewCell__ when __Lightweight templates__ are used. Within the __ControlTemplate__ you need to search for the __IsCurrent Property Trigger__ and delete it.

__Example 3: Deleting the IsCurrent Property Trigger__
<snippet id='radgridview-features-overview-lightweight-template-example_3_deleting_the_iscurrent_property_trigger-xaml' />


#### __Figure 3: RadGridView with Lightweight templates and removed Current Cell Border__

![Telerik UI for {{ site.framework_name }} RadGridView lightweight templates with the current cell border removed](images/RadGridViewLightweightTemplatesCurrentCellBorder.png)

## Remove the Border of the Current Cell With Validation

A similar approach as from the previous section needs to be used. The difference is that the same __Property Trigger__ has to be __deleted__ from the __ControlTemplate__ applied to __GridViewCell__ when __Lightweight templates with validation__ are used.

__Example 4: Deleting the IsCurrent Property Trigger when Lightweight Templates with Validation are applied__
<snippet id='radgridview-features-overview-lightweight-template-example_4_deleting_the_iscurrent_property_trigger_when_lightweight_templates_with_validation_are_applied-xaml' />


#### __Figure 4: RadGridView with Lightweight templates including validation and removed Current Cell Border__

![Telerik UI for {{ site.framework_name }} RadGridView lightweight templates with validation and the current cell border removed](images/RadGridViewLightweightTemplatesCurrentCellBorderWithValidation.png)

>You can download a __runnable solution__ from our online SDK repository [here](https://github.com/telerik/xaml-sdk/tree/master/GridView/LightweightTemplates).       
>You can also find the blog post on [How To Boost RadGridView Performance for WPF and Silverlight Using Lightweight templates](http://www.telerik.com/blogs/how-to-boost-radgridview-performance-for-wpf-and-silverlight-using-lightweight-templates).
