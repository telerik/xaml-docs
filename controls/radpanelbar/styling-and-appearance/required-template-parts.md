---
title: Required Parts
page_title: Required Parts
description: Check our &quot;Required Parts&quot; documentation article for the RadPanelBar {{ site.framework_name }} control.
slug: radpanelbar-required-template-parts
tags: required,parts
published: True
position: 1
---

# Required Parts

The __RadPanelBar__ control needs a set of two control templates - one for the overall look of the control and another one for the individual items.

Below you can see the default template:

{% if site.site_name == 'Silverlight' %}

<snippet id='radpanelbar-styling-and-appearance-required-template-parts-block_1-xaml' />
{% endif %}

{% if site.site_name == 'WPF' %}

<snippet id='radpanelbar-styling-and-appearance-required-template-parts-block_2-xaml' />
{% endif %}

We will now briefly describe the purpose of the main elements:

* __TransformationRoot__ - this element is needed for changing the orientation of the control.					

* __ScrollViewer__ - this element take care of the cases when there is not enough available space to render the panelbar items.					

The other control template required by the __RadPanelBar__ control is the one for the panelbar items. Below you can see the default template:

{% if site.site_name == 'Silverlight' %}

<snippet id='radpanelbar-styling-and-appearance-required-template-parts-block_3-xaml' />
{% endif %}

{% if site.site_name == 'WPF' %}

<snippet id='radpanelbar-styling-and-appearance-required-template-parts-block_4-xaml' />
{% endif %}

Following is a short description of the major elements in the template:

* __RootElement__ - as the name suggests, this is the root element wrapping all other parts of the template.					  

* __HeaderRow__ - this Grid element contains all elements that comprise the header of a panelbar item i.e. what is visible when the item is collapsed.					  

* __MouseOverVisual__ - this element is displayed when the mouse cursor moves over an item.					  

* __SelectVisual__ - this element is displayed whenever an item gets selected.					  

* __Arrow__ and __ArrowSelect__  - the expander arrow displayed in the right-hand corner of the item header.					  

* __ExpandedVisual__ - this element is displayed when an item is expanded.					  

* __Header__ - this element is responsible for rendering the value of the Header property.					  

* __DisabledVisual__ - this element is displayed when an item's IsEnabled property is set to false.					  

* __FocusVisual__ - this element is displayed when an item is focused.					  

* __ItemsContainer__ - this Grid element contains an item's child items.					  

* __TransformationRoot__ - this element is used when the Orientation property of the parent panelbar is changed.					  

And the default ControlTemplate of the RadPanelBarItem.Items is:

{% if site.site_name == 'Silverlight' %}

<snippet id='radpanelbar-styling-and-appearance-required-template-parts-block_5-xaml' />
{% endif %}

{% if site.site_name == 'WPF' %}

<snippet id='radpanelbar-styling-and-appearance-required-template-parts-block_6-xaml' />
{% endif %}