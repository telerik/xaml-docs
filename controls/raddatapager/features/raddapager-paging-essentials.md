---
title: Paging Essentials
page_title: Paging Essentials
description: Paging Essentials
slug: raddapager-features-paging-essentials
tags: paging,essentials
published: True
position: 0
---

# Paging Essentials



## RELATED VIDEOS
In this video, learn how you can quickly and easily get started using __RadDataPager__ in your Silverlight and WPF applications.(Runtime:02:39)

![](images/datapager_getting_started_video.png)(http://tv.telerik.com/watch/silverlight/getting-started-with-raddatapager)

{% if site.site_name == 'Silverlight' %}
The one most important piece of software concerning paging in Silverlight is the [System.ComponentModel.IPagedCollectionView](http://msdn.microsoft.com/en-us/library/system.componentmodel.ipagedcollectionview%28VS.95%29.aspx) interface.          

The [IPagedCollectionView](http://msdn.microsoft.com/en-us/library/system.componentmodel.ipagedcollectionview%28VS.95%29.aspx) interface contains several important [members](http://msdn.microsoft.com/en-us/library/system.componentmodel.ipagedcollectionview_members%28VS.95%29.aspx) which are used by [RadGridView](http://www.telerik.com/products/silverlight/controls/gridview.aspx) to perform the actual paging. Silverlight provides a default implementation of this interface which, naturally, is called [PagedCollectionView](http://msdn.microsoft.com/en-us/library/system.windows.data.pagedcollectionview%28VS.95%29.aspx).
   {% endif %}{% if site.site_name == 'WPF' %}
Those of you who are on the WPF front don't need to worry though. As you might already know, Telerik’s Silverlight and WPF controls share the same code-base. Since WPF does not contain a similar interface, Telerik has provided its own [Telerik.Windows.Data.IPagedCollectionView](http://www.telerik.com/help/wpf/telerik.windows.data-telerik.windows.data.ipagedcollectionview.html).
          

>caution The WPF default implementation of the interface is Telerik’s [QueryableCollectionView](http://www.telerik.com/help/wpf/t_telerik_windows_data_queryablecollectionview.html) which, among many other interfaces, implements [IPagedCollectionView](http://www.telerik.com/help/wpf/t_telerik_windows_data_ipagedcollectionview.html).
   {% endif %}

## See Also

 * [Getting Started]({%slug raddatapager-getting-started%})

 * [Source and Paged Source]({%slug raddatapager-features-source-and-paged-source%})

 * [Unbound Mode]({%slug raddatapager-features-unbound-mode%})
