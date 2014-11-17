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


If a column is filterable you can disable filtering by setting its IsFilterable property to false. This will hide the filtering UI of the respective column and the end user will not be able to perform filtering.

The IsFilterable property is true by default. If data displayed in the column is not filterable in the first place, setting IsFilterable to true will not do anything, since true is the default value anyway. To learn what your property needs to implement in order to become filterable, please read this [article.]({%slug gridview-filtering-howto-filter-a-custom-type%})


