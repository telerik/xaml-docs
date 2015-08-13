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

In the .NET Platform, strings are not compared like numbers. For example, the string "100" is less than the string "2" because it compares strings in alphabetic order. A possible solution would be the use of [IComparable](http://msdn.microsoft.com/en-us/library/system.icomparable.aspx) as illustrated on the {% if site.site_name == 'WPF' %}[Custom Sorting with IComparable demo.](http://demos.telerik.com/silverlight/#GridView/IComparable){% endif %}{% if site.site_name == 'Silverlight' %}[Custom Sorting with IComparable demo.](http://demos.telerik.com/wpf){% endif %}
        
For more detailed information on the sorting mechanism, you can check the [Sorting section]({%slug gridview-sorting-basics%}).
        
# See Also

 * [Custom Sorting]({%slug gridview-sorting-custom%})

 * [Use expression descriptors]({%slug gridview-howto-use-expression-descriptors%})
