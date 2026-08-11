---
title: Row Details Template
page_title: Row Details Template
description: Get started with Telerik's {{ site.framework_name }} DataGrid and learn how you can apply the Row Details template defined through the RowDetailsTemplate property. 
slug: radgridview-row-details-template
tags: row,details,template
published: True
position: 1
---

# Row Details Template

The __Row Details__ template is defined through the __RowDetailsTemplate__ property of the __RadGridView__.

>tip To learn how to manage the displaying of the __Row Details__, read [this topic]({%slug radgridview-row-details-visibility%}).
	
## Basic RowDetails Template

__Example 1__ shows a basic row details template. You can observe the result in __Figure 1__.
		
> The next examples use the __Team__, __Division__ and __DivisionService__ classes defined in Examples 1, 2 and 3 in the following [article]({%slug gridview-building-hierarchical-grid-view%}). The setting of the ItemsSource in Examples 1 and 2 is shown in __Example 3__.

__Example 1: Basic RowDetails Template__

<snippet id='radgridview-row-details-template-example_1_basic_rowdetails_template-xaml' />


__Figure 1:__ Displays the result of the applied __Basic RowDetails Template__.

![Telerik UI for {{ site.framework_name }} RadGridView with a basic Row Details template showing the selected item's ID](images/gridview-row-details-template-basic.png)

## Complex RowDetails Template

__Example 2__ shows a complex row details template, which contains another RadGridView. You can observe the result in __Figure 2__.

__Example 2: Definition of Complex RowDetails Template__

<snippet id='radgridview-row-details-template-example_2_definition_of_complex_rowdetails_template-xaml' />


>important You should specify fixed dimensions for the RadGridView in the RowDetailsTemplate (Height/MaxHeight and Width/MaxWidth). Otherwise the [UI Virtualization]({%slug radgridview-features-ui-virtualization%}) mechanism will be disabled. 

__Figure 2:__ Displays the result of the applied __Complex RowDetails Template__.  
![Telerik UI for {{ site.framework_name }} RadGridView with a complex Row Details template that contains a nested grid](images/gridview-row-details-template-complex.png)

__Example 3: Setting the ItemsSource for Examples 1 and 2__

<snippet id='radgridview-row-details-template-example_3_setting_the_itemssource_for_examples_1_and_2-cs' />

<snippet id='radgridview-row-details-template-example_3_setting_the_itemssource_for_examples_1_and_2-vb' />


## See Also  
 * [RowDetails Overview]({%slug radgridview-row-details-overview%})  
 * [Toggle RowDetails Column]({%slug radgridview-columns-column-types-toggle-rowdetails-column%})
 * [Row Details Visibility]({%slug radgridview-row-details-visibility%})
 * [External Row Details]({%slug radgridview-row-details-external-row-details%})
 * [Customizing the Row Details]({%slug radgridview-row-details-customizing-the-row-details%})