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



## 

You will have to exclude the time part of your DateTime property as you do not want to include it into the filter. To do so you can create a new property on your business object that will return the trimmed DateTime value and then set __the column's FilterMemberPath__ to this new "date-only" property.
        

An even better approach would be to bind your column directly to the Date (or Year) property of the DateTime object: __DataMemberBinding="{Binding BirthDate.Date}"__

# See Also

 * [Basic Filtering]({%slug gridview-filtering-basic%})
