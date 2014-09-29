---
title: Why doesn’t my column show the filtering funnel icon?
page_title: Why doesn’t my column show the filtering funnel icon?
description: Why doesn’t my column show the filtering funnel icon?
slug: gridview-filtering-faq-no-funnel-icon
tags: why,doesn’t,my,column,show,the,filtering,funnel,icon?
published: True
position: 0
---

# Why doesn’t my column show the filtering funnel icon?



## 

Most probably the type of the property that you have bound the column to is either System.Object or some custom type which does not implement the generic IEquatable interface. In case the type of the property is System.Object for some reason, but you know that it always returns a “normal” filterable type, you can “help” the column by setting its DataType property to the correct type. In case your property is of a custom type, it has to meet certain criteria in order to be filterable. [Here]({%slug gridview-filtering-howto-filter-a-custom-type%}) you can learn how to make your custom type filterable.

# See Also
