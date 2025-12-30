---
title: Applied DataFormatString on a Column
page_title: Applied DataFormatString on a Column
description: Get started with the filtering functionality of Telerik's {{ site.framework_name }} DataGrid and learn why DataFormatString is used for presentation purposes only.
slug: gridview-filtering-faq-dataformatstring-and-filtering
tags: applied,dataformatstring,on,a,column
published: True
position: 2
---

# Applied DataFormatString on a Column



## Why isn’t this format used when performing filtering?
          

The __DataFormatString is only used for presentation purposes__. It plays absolutely no part in the data engine and all __filtering, sorting and grouping operations are always performed on raw data values__ in the data engine.

Each GridViewColumn has a property called __FilterMemberPath__. You can use this property to tell the column to __filter on a property different from the one it displays__ in its cells. 
        

>tip For example: FilterMemberPath="PropertyToFilterOn". You can also check the [FilterMemberPath documentation]({%slug gridview-filtering-basic%}).
            

## See Also

 * [Basic Filtering]({%slug gridview-filtering-basic%})
