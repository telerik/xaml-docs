---
title: Customize the UI programmatically
page_title: Customize the UI programmatically
description: Find out more about the two powerful extension methods which you can use to easily customize RadGridView - Telerik's {{ site.framework_name }} DataGrid.
slug: gridview-how-to-customize-ui-programmatically
tags: customize,the,ui,programmatically
published: True
position: 4
---

# Customize the UI programmatically

You can manipulate the controls easily with two powerful extension methods: 

* __ParentOfType<>__ 
* __ChildrenOfType<>__.

>tip You can access all items currently available in RadGridView through __RadGridView.Items__ collection.

>Generally we do not recommend working with the visual elements as RadGridView is a virtualized control and its elements are reused as they go in and out the visual area. You can check the topic on [UI virtualization]({%slug radgridview-features-ui-virtualization%}) for further information. 

Here are several small demos for __RadGridView__:

* Get all grid rows:

<snippet id='radgridview-how-to-customize-ui-programmatically-block_1-cs' />


* Get all grid cells:

<snippet id='radgridview-how-to-customize-ui-programmatically-block_2-cs' />


* Get all grid header cells:

<snippet id='radgridview-how-to-customize-ui-programmatically-block_3-cs' />



* Get (and show) new row:

<snippet id='radgridview-how-to-customize-ui-programmatically-block_4-cs' />



* Find the grid vertical scrollbar and scroll the grid to bottom:

<snippet id='radgridview-how-to-customize-ui-programmatically-block_5-cs' />


* Select specific row(s):

<snippet id='radgridview-how-to-customize-ui-programmatically-block_6-cs' />


* Change specific cell(s) content:


<snippet id='radgridview-how-to-customize-ui-programmatically-block_7-cs' />


* Put specific cell in edit mode:


<snippet id='radgridview-how-to-customize-ui-programmatically-block_8-cs' />


* Get visible rows count on scroll or size change:
    

<snippet id='radgridview-how-to-customize-ui-programmatically-block_9-cs' />


* Perform conditional row(s) formatting:
    

<snippet id='radgridview-how-to-customize-ui-programmatically-block_10-cs' />


* Expand first row in case of hierarchy:


<snippet id='radgridview-how-to-customize-ui-programmatically-block_11-cs' />



* Collapse first group header row:


<snippet id='radgridview-how-to-customize-ui-programmatically-block_12-cs' />


* Modify background for all cells in specific column:   


<snippet id='radgridview-how-to-customize-ui-programmatically-block_13-cs' />


* Increase header row Height:   


<snippet id='radgridview-how-to-customize-ui-programmatically-block_14-cs' />


* Check all CheckBox controls in specific column:


<snippet id='radgridview-how-to-customize-ui-programmatically-block_15-cs' />


## See Also

 * [UI Virtualization]({%slug radgridview-features-ui-virtualization%})



