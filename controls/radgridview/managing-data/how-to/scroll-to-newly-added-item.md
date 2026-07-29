---
title: Scroll to Newly Added Item
page_title: Scroll to Newly Added Item
description: Get started with Telerik's {{ site.framework_name }} DataGrid and learn how to scroll to a newly added item by using the ScrollIntoViewAsync method and the CollectionChanged event.
slug: gridview-how-to-scroll-to-newly-added-item
tags: scroll,to,newly,added,item
published: True
position: 5
---

# Scroll to Newly Added Item

This article shows how to scroll RadGridView to the newly added item.

You can achieve this by using the [ScrollIntoViewAsync]({%slug gridview-scroll-item%}) method and the **CollectionChanged** event of the control's **Items** collection. For the purpose, you can create a [custom behavior](https://github.com/microsoft/XamlBehaviorsWpf) and attach it to your RadGridView control.

__Example 1: The custom behavior__

<snippet id='radgridview-managing-data-how-to-scroll-to-newly-added-item-example_1_the_custom_behavior-cs' />

<snippet id='radgridview-managing-data-how-to-scroll-to-newly-added-item-example_1_the_custom_behavior-vb' />


**Example 2** and **Example 3** demonstrate how you can apply the new behavior to all RadGridView instances in your application by creating an attached property which you can then use in an implicit style.

__Example 2: Defining the attached property__

<snippet id='radgridview-managing-data-how-to-scroll-to-newly-added-item-example_2_defining_the_attached_property-cs' />

<snippet id='radgridview-managing-data-how-to-scroll-to-newly-added-item-example_2_defining_the_attached_property-vb' />


__Example 3: Set the attached property in an implicit style__

<snippet id='radgridview-managing-data-how-to-scroll-to-newly-added-item-example_3_set_the_attached_property_in_an_implicit_style-xaml' />


>If you're using [implicit styles]({%slug styling-apperance-implicit-styles-overview%}), you should base your style on the __RadGridViewStyle__ as explained in [this article]({%slug implicit-styles-styling-the-controls%}).

## See Also

* [Scroll to a Particular Row or Column]({%slug gridview-scroll-item%})
* [Attached Behavior]({%slug common-mvvm-attached-behavior%})