---
title: Disable Filtering for a Specific Column
page_title: Disable Filtering for a Specific Column
description: Disable Filtering for a Specific Column
slug: gridview-filtering-disable-filtering-for-a-specific-column
tags: disable,filtering,for,a,specific,column
published: True
position: 1
---

# Disable Filtering for a Specific Column

You can disable filtering for a specific column by setting its **IsFilterable** property to **False**. This will hide the filtering UI of the respective column and the end user will not be able to perform filtering. The property's default value is **True**.

If the data displayed in the column is not filterable in the first place, setting the IsFilterable property will not have any effect. To learn what your properties need to implement to become filterable, please have a look at the [Filter a Custom Type]({%slug gridview-filtering-howto-filter-a-custom-type%}) article.

## See Also

* [Basic Filtering]({%slug gridview-filtering-basic%})
* [Filter a Custom Type]({%slug gridview-filtering-howto-filter-a-custom-type%})
