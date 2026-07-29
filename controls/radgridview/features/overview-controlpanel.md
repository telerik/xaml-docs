---
title: Control Panel
page_title: Control Panel
description: Learn more about the Control Panel feature of Telerik's {{ site.framework_name }} DataGrid that allows changing different configurations through additional grid elements.
slug: gridview-overview-controlpanel
tags: control,panel
published: True
position: 14
---

# Control Panel

The Control Panel is a feature of the RadGridView that provides the end user with the option to change different configurations related to RadGridView's settings through additional elements positioned on the top right of the control.

#### __Figure 1: Control Panel within RadGridView__

![Telerik UI for {{ site.framework_name }} RadGridView control panel displayed in the top-right corner of the grid](images/gridview_controlpanel_01.png)


In order to add items in the Control Panel, you need to set the __ControlPanelItems__ property of the RadGridView. You can define different content for as many ControlPanelItems as you need. Each ControlPanelItem can allow the end user to configure different options. Each item should have a __ControlPanelItem.Content__.


__Example 1: Adding items in the Control Panel__

<snippet id='radgridview-features-overview-controlpanel-example_1_adding_items_in_the_control_panel-xaml' />


You can also set a custom display for the items. For the purpose please set __ControlPanelItem.ButtonContent__ as shown in Example 2.

__Example 2: Setting a custom display for the items__


<snippet id='radgridview-features-overview-controlpanel-example_2_setting_a_custom_display_for_the_items-xaml' />


>tip You can review a __runnable solution__ showing how to define ControlPanelItems from our SDK Samples Browser, which you can download from [here](https://demos.telerik.com/xaml-sdkbrowser/). The example is listed under __GridView/ControlPanel__
   

## Reusing Control Panel Items

 You can add a common Style targeting the ControlPanel that all the RadGridView controls in the application will inherit.

The __ControlPanelItemsCollection__ property of the RadGridView, added in Q1 2016, represents a collection of the different Control Panel items.

{% if site.site_name == 'WPF' %}
You can set the __ControlPanelItemsCollection__ either implicitly or explicitly. We advise on using the first approach. 
{% endif %}

### Implicitly Set the Control Panel Items

It is possible to declare a style that targets the RadGridView control. In this case, the style will be applied to all RadGridView controls in the application, as shown in Example 3. 


__Example 3: Declare a common style for the Control Panel__

<snippet id='radgridview-features-overview-controlpanel-example_3_declare_a_common_style_for_the_control_panel-xaml' />


>If you're using [implicit styles]({%slug styling-apperance-implicit-styles-overview%}), you should base your style on the __RadGridViewStyle__.

{% if site.site_name == 'WPF' %}
### Explicitly Set the Control Panel Items

You can change the control panel items explicitly for a specific RadGridView. First, the __ControlPanelItemCollection__ should be created as a static resource: 

__Example 4: Explicitly change the item collection of the RadGridView's Control Panel__

<snippet id='radgridview-features-overview-controlpanel-example_4_explicitly_change_the_item_collection_of_the_radgridview_s_control_panel-xaml' />


Then set the __ControlPanelItems__ property of the specific RadGridView:

__Example 5: Set RadGridView's ControlPanelItems property__

<snippet id='radgridview-features-overview-controlpanel-example_5_set_radgridview_s_controlpanelitems_property-xaml' />


{% endif %}

## See Also
 
 * [Filtering]({%slug gridview-overview-filtering%})
 * [Sorting]({%slug gridview-overview-sorting%})
 * [Validating]({%slug gridview-managing-data-validation%})
