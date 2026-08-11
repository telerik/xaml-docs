---
title: Enable touch events for custom elements
page_title:  Enable Touch Events for Custom Elements
description: Check out our example of enabling touch event for a button within a column cell template within RadGridView - Telerik's {{ site.framework_name }} DataGrid.
slug: gridview-how-to-enable-touch-events-celltemplate
tags: touch, event, cell-templates
published: True
position: 18
---

# How To Enable Touch Events for Custom Elements

In a scenario where you have explicitly set the cell template of a column within **RadGridView** and you would like that element to handle a touch event separately, you should set the **TouchManager.TouchMode** attached property to **None**. Otherwise, all touch events would be handled by the **RadGridView** control. 

**Example 1** shows how to achieve the requirement for a Button element within a column's CellTemplate.

#### **[XAML] Example 1: Enable touch event for a button within a column cell template**
<snippet id='radgridview-how-to-touch-event-celltemplate-block_1-xaml' />


The attached property should be set in case of explicitly defining the element through a **custom column** as well. **Example 2** shows how to set the attached property programmatically:
	
#### **[C#] Example 2: Programmatically set TouchManager.TouchMode attached property**
<snippet id='radgridview-how-to-touch-event-celltemplate-block_2-cs' />


## See Also
* [RadGridView - CellTemplate and CellEditTemplate]({%slug radgridview-columns-celltemplate-and-celledittemplate%})
* [TouchManager - Overview]({%slug touchmanager-overview%})
* [TouchManager - Touch Modes]({%slug touchmanager-touch-modes%})
