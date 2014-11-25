---
title: Paging before Grouping
page_title: Paging before Grouping
description: Paging before Grouping
slug: raddatapager-features-grouping
tags: paging,before,grouping
published: True
position: 8
---

# Paging before Grouping


There are two ways to do grouping with paging. One is to __group before paging__ and other is to __page before grouping__. The first one is the default behaviour.
        

The idea behind the second approach is to do the paging before the grouping so that RadGridView will never know that someone is paging its data. It will simply think that its ItemsSource is a collection with several items (i.e. __PageSize__) and will group these items.
        

If you would like to implement the second approach, then I would suggest you to check the {% if site.site_name == 'Silverlight' %}[Paging before Grouping Demo](http://demos.telerik.com/silverlight/#GridView/PagingBeforeGrouping){% endif %}{% if site.site_name == 'WPF' %}[Paging before Grouping Demo](http://demos.telerik.com/wpf){% endif %}

# See Also

 * [Getting Started]({%slug raddatapager-getting-started%})

 * [Paging Unbound Mode]({%slug raddatapager-features-unbound-mode%})

 * [Paging Essentials]({%slug raddapager-features-paging-essentials%})
