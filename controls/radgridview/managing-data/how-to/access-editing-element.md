---
title: Access the default editing element
page_title: Access the default editing element
description: Get started with Telerik's {{ site.framework_name }} DataGrid and learn how to access the default editing element of the cells and set its properties.
slug: gridview-access-editing-element
tags: access,the,default,editing,element
published: True
position: 1
---

# Access the default editing element

This article will show how to access the default editing element of RadGridView's cells and set its properties. In addition, it will show how to alter the default behavior of selecting the whole text upon editing. 

First, let's start with a real world scenario - you have a cell which shows a long text. You wrap the text by setting the __TextWrapping="Wrap"__ property of the column. The text looks good in view mode, but when you enter edit mode - the full text is shown on one line:

![Telerik UI for {{ site.framework_name }} RadGridView editing cell showing unwrapped text in the default editing element](images/how_to_access_editing_element_gridview.png)

To make the editing textbox wraps the text as well you need to subscribe to the PreparingCellForEdit event, find the editing element and set its property:



<snippet id='radgridview-managing-data-how-to-access-editing-element-block_1-cs' />

<snippet id='radgridview-managing-data-how-to-access-editing-element-block_1-vb' />


Now it is better:

![Telerik UI for {{ site.framework_name }} RadGridView editing cell with text wrapping applied to the default editing element](images/how_to_access_editing_element_gridview2.png)

Ok, what if I do not want have this text selected, but want to have the cursor positioned at the end of it? Here comes the other useful event - PreparedCellForEdit which fires when the cell is already prepared for editing:



<snippet id='radgridview-managing-data-how-to-access-editing-element-block_2-cs' />

<snippet id='radgridview-managing-data-how-to-access-editing-element-block_2-vb' />





