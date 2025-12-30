---
title: Filtering column showing DateTime values
page_title: Filtering column showing DateTime values
description: Get started with the filtering functionality of Telerik's {{ site.framework_name }} DataGrid and learn how to avoid filtering out items with DateTime values with different time parts.
slug: gridview-filtering-faq-datetime-filtering
tags: filtering,column,showing,datetime,values
published: True
position: 3
---

# Filtering column showing DateTime values

## Items disappear when a column is filtered over a DateTime property

When a column is filtered over a __DateTime__ property and its __Time__ part is not explicitly set, the default __00:00:00 value__ is used. Thus, if the bound items have different values for the __Time__ portion of the __DateTime__ property, they will be filtered out.
 
>Since DateTime values with different time parts are __not equal__, you will have no match.

### Solution 1

Trim the time part of your DateTimes. 

### Solution 2

The user can be instructed to enter both the date and time parts of the date when filtering.

### Solution 3
        
Bind the column __directly to the Date (or Year)__ property of the __DateTime__ object.         

>tip For example: DataMemberBinding="{Binding BirthDate.Date}"

>Columns bound to the __Date__ part of a __Nullable DateTime__ does not support filtering, as a __Nullable DateTime__ does not expose a __Date__ property.

As alternative solution, you can benefit from a property called __FilterMemberPath__. You can use it to tell the column to __filter on a property different from the one it displays__ in its cells.      
        

>tip For example: **FilterMemberPath="BirthDate.Date"**. You can also check the [FilterMemberPath documentation]({%slug gridview-filtering-basic%}).
          

## See Also

 * [Basic Filtering]({%slug gridview-filtering-basic%})
