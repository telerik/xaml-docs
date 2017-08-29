---
title: Applied IValueConverter on the DataMemberBinding
page_title: Applied IValueConverter on the DataMemberBinding
description: Applied IValueConverter on the DataMemberBinding
slug: gridview-filtering-faq-ivalueconverter-and-filtering
tags: applied,ivalueconverter,on,the,datamemberbinding
published: True
position: 1
---

# Applied IValueConverter on the DataMemberBinding



## Why isn’t this converter used when performing filtering?
        
When performing filtering operations over the RadGridView, __IValueConverters__ are used for __presentation purposes__ only. They play no part in the filtering mechanism and __filtering would always be performed on the raw data values__. You should be careful when using converters in order to avoid duplication of the content in the list of distinct values to filter on.

The GridViewColumn has a property called __FilterMemberPath__. You can use this property to tell the column to __filter on a property different from the one it displays__ in its cells. In case the Type of the bound property cannot be automatically discovered by the data engine, you can “help” the column by setting the __FilterMemberType__ property.

You can also check the [FilterMemberPath documentation]({%slug gridview-filtering-basic%}).

>important Grouping, on the other hand, would respect the converted values and duplicated groups would not be created. 

## See Also

 * [Basic Filtering]({%slug gridview-filtering-basic%})
