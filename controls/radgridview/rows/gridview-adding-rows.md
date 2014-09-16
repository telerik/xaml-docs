---
title: Adding Rows
page_title: Adding Rows
description: Adding Rows
slug: gridview-rows-adding-rows
tags: adding,rows
publish: True
position: 1
---

# Adding Rows



## 

Adding new items in the __RadGridView__ is done via __GridViewNewRow__ control. It appears in the form of an empty row and allows you to enter a value for the field of each column.
        

![](images/RadGridView_AddingNewRows_1.png)

__RadGridView__ gives you the ability to make the newly inserted row visible. Also you can control its position. In order to enable this feature, you should set __RadGridView__'s __NewRowPosition__ property. It has three options:
        

* 
            None -  Do not display the new row.
          

* 
            Top - Display the new row on top.
          

* 
            Bottom - Display the new row at the bottom after the last standard row. Please note that this mode is supported only when __GroupRenderMode__ is __Flat__.
          

![Rad Grid View addingnewrows 03](images/RadGridView_addingnewrows_03.png)

>
          As of Q3 2013 the __ShowInsertRow__ property is marked __Obsolete__. Instead of it, you can use __NewRowPosition__ property.
        

>tip
          You can have an always visible new row by setting __NewRowPosition__ property of __RadGridView__. Note it will be visible even when the __CanUserInsertRows__ is set to __False__ or the __IsReadOnly__ property is set to __True__, however the user will still not be able to use it.
        

To learn more about how to use __GridViewNewRow__ take a look at the [Adding New Entries]({%slug gridview-managing-data-add-new-entries%}) topic.
        

# See Also

 * [Customizing Rows]({%slug gridview-customizing-rows%})

 * [Grid Rows - Overview]({%slug gridview-rows-overview%})

 * [Cannot Insert New Row]({%slug gridview-troubleshooting-cannot-insert-new-row%})
