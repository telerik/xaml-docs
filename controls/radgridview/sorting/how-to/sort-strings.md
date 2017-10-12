---
title: Sort Strings
page_title: Sort Strings
description: Sort Strings
slug: gridview-sort-strings
tags: sort, string ,sortdescriptor
published: True
position: 3
---

# Sorting Strings as Numbers

In the .NET Platform, strings are not compared like numbers. For example, the string "100" is less than the string "2" because it compares strings in alphabetic order. 

One possible solution would be the use of [IComparable](http://msdn.microsoft.com/en-us/library/system.icomparable.aspx) as illustrated in the {% if site.site_name == 'Silverlight' %}[Custom Sorting with IComparable demo.](https://demos.telerik.com/silverlight/#GridView/IComparable){% endif %}{% if site.site_name == 'WPF' %}[Custom Sorting with IComparable demo.](https://demos.telerik.com/wpf){% endif %}

As another option, you can expose a property of the business object to hold the numeric value and set it as __SortMemberPath__ of the column. That way the column will be sorted by this numeric property and not by the string property specified as DataMemberBinding (applies to __ColumnSortDescriptor__ only).        

For more detailed information on the sorting mechanism, you can check the [Sorting section]({%slug gridview-sorting-basics%}).
        
## See Also

 * [Custom Sorting]({%slug gridview-sorting-custom%})

 * [Use expression descriptors]({%slug gridview-howto-use-expression-descriptors%})
