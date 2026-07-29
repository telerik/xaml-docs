---
title: Scroll Item into View
page_title: Scroll Item into View
description: Check our &quot;Scroll Item into View&quot; documentation article for the RadTreeListView {{ site.framework_name }} control.
slug: radtreelistview-how-to-scrollintoview
tags: scroll,item,into,view
published: True
position: 3
---

# Scroll Item into View



The __RadTreeListView API__ offers __ScrollIntoView__ support through the following methods:
	  

* [ScrollIntoViewAsync()](#scrollintoviewasync)

* [ScrollIntoView()](#scrollintoview)

The goal of this tutorial is to demonstrate how you can bring a particular, deeply nested __TreeListViewRow__ into view. This might be helpful if you need a fast hierarchy control with many nested levels and __RadTreeView__ is slow in your particular scenario with bring into view. This example is configured in such way that __RadTreeListView__ behaves and feels much like __RadTreeView__.
	  

## Initial setting up of the project

For the purpose of this example, you will need to create an empty application project and open it in Visual Studio.	The first step is to add references to the following assemblies:
		

* __Telerik.Windows.Controls__

* __Telerik.Windows.Controls.GridView__

* __Telerik.Windows.Controls.Input__

* __Telerik.Windows.Data__

Then you can define the controls in your view. As the purpose of this tutorial is to demonstrate how to implement the __ScrollIntoView__ methods, we won't focus on the definitions of the controls in xaml.
		



<snippet id='radtreelistview-how-to-scrollintoview-block_1-xaml' />



The next step is to define the business object.
		



<snippet id='radtreelistview-how-to-scrollintoview-block_2-cs' />
<snippet id='radtreelistview-how-to-scrollintoview-block_3-vb' />



What comes next, is to populate with data.
		



<snippet id='radtreelistview-how-to-scrollintoview-block_4-cs' />
<snippet id='radtreelistview-how-to-scrollintoview-block_5-vb' />



## ScrollIntoViewAsync()

Clicking the first button will bring an item which is 20 levels deep with updating the UI on every level expansion. For this purpose we will use the {% if site.site_name == 'Silverlight' %}[ScrollIntoViewAsync (Object dataItem, Action(FrameworkElement) scrollFinishedCallback, bool expandItem)](http://www.telerik.com/help/silverlight/m_telerik_windows_controls_radtreelistview_scrollintoviewasync_1.html){% endif %}{% if site.site_name == 'WPF' %}[ScrollIntoViewAsync (Object dataItem, Action(FrameworkElement) scrollFinishedCallback, bool expandItem)](http://www.telerik.com/help/wpf/m_telerik_windows_controls_radtreelistview_scrollintoviewasync_1.html){% endif %} method, which scrolls the row containing the data item into view in an asynchronous manner.
		



<snippet id='radtreelistview-how-to-scrollintoview-block_6-cs' />
<snippet id='radtreelistview-how-to-scrollintoview-block_7-vb' />



## ScrollIntoView()

Clicking the second button will update the UI only when the bring operation is finished. Here we are using the {% if site.site_name == 'Silverlight' %}[ScrollIntoView(Object dataItem, bool expandItem)](http://www.telerik.com/help/silverlight/m_telerik_windows_controls_radtreelistview_scrollintoview.html){% endif %}{% if site.site_name == 'WPF' %}[ScrollIntoView(Object dataItem, bool expandItem)](http://www.telerik.com/help/wpf/m_telerik_windows_controls_radtreelistview_scrollintoview.html){% endif %} method, which scrolls the row containing the data item into view.
		



<snippet id='radtreelistview-how-to-scrollintoview-block_8-cs' />
<snippet id='radtreelistview-how-to-scrollintoview-block_9-vb' />

>tip Please have in mind that running the application without debugger (__Ctrl + F5__ when in VS) will result in faster user experience.		  

>tip Find a runnable project of the previous example in the [WPF Samples GitHub repository](https://github.com/telerik/xaml-sdk/tree/master/TreeView/TreeListViewBringItemIntoView).		  

## See Also  
 * [RadGridView: Scroll to a particular row or column]({%slug gridview-scroll-item%})
 * [RadTreeView: How to Use BringPathIntoView Method]({%slug radtreeview-how-to-bring-path-into-view%})