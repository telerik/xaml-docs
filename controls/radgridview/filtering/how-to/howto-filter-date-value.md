---
title: Filter on Date value only
page_title: Filter on Date value only
description: Filter on Date value only
slug: gridview-filtering-howto-filter-date-value
tags: filter,on,date,value,only
published: True
position: 13
---

# Filter on Date value only

Most probably your __DateTime data contains a time part which is different from 00:00:00__. When you filter and select a DateTime value, this selected DateTime will have its time part equal to zero if you forget to enter the time part.
        
>Since DateTime’s with different time parts are not equal for the .NET Framework, you will have no match.
          
A possible solution would be to __trim the time part__ of your DateTimes. __Alternatively, you may instruct the user to enter both the date and time parts__ of the date when filtering.
        

An even better approach would be to __bind your column directly to the Date (or Year) property__ of the DateTime object.
        

>tipFor example: DataMemberBinding="{Binding BirthDate.Date}"

As alternative solution, you can benefit from a property called __FilterMemberPath__. You can use it to tell the column to __filter on a property different from the one it displays__ in its cells.
        

>tipFor example: FilterMemberPath="BirthDate.Date". You can also check the [FilterMemberPath documentation]({%slug gridview-filtering-basic%}).
          

# See Also

 * [Basic Filtering]({%slug gridview-filtering-basic%})
