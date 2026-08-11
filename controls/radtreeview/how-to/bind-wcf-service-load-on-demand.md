---
title: Bind RadTreeView to Hierarchical Data from WCF Service and Use Load on Demand
page_title: Bind RadTreeView to Hierarchical Data from WCF Service and Use Load on Demand
description: Check our &quot;Bind RadTreeView to Hierarchical Data from WCF Service and Use Load on Demand&quot; documentation article for the RadTreeView {{ site.framework_name }} control.
slug: radtreeview-how-to-bind-wcf-service-load-on-demand
tags: bind,radtreeview,to,hierarchical,data,from,wcf,service,and,use,load,on,demand
published: True
position: 15
---

# Bind RadTreeView to Hierarchical Data from WCF Service and Use Load on Demand

The purpose of this tutorial is to show you how to populate __RadTreeView__ with hierarchical data loaded from WCF service.

Here is a simple treeview declaration: 

{% if site.site_name == 'Silverlight' %}



<snippet id='radtreeview-how-to-bind-wcf-service-load-on-demand-block_1-xaml' />

{% endif %}
{% if site.site_name == 'WPF' %}



<snippet id='radtreeview-how-to-bind-wcf-service-load-on-demand-block_2-xaml' />

{% endif %}

The web service will return an observable collection with objects of type __TableItem__. Here is the __TableItem__ structure: 



<snippet id='radtreeview-how-to-bind-wcf-service-load-on-demand-block_3-cs' />
<snippet id='radtreeview-how-to-bind-wcf-service-load-on-demand-block_4-vb' />

Now that you have the basis set up, it's time to go on. First you should create your data source object. Add a new class named __HierarchicalDataSource__ which derives from __ObservableCollection__ of __TableItem__. 



<snippet id='radtreeview-how-to-bind-wcf-service-load-on-demand-block_5-cs' />
<snippet id='radtreeview-how-to-bind-wcf-service-load-on-demand-block_6-vb' />

Next, you need to add a reference to the WCF service and load the data{% if site.site_name == 'Silverlight' %} asynchronously{% endif %}. You also need a list that holds all items that come from the web service result. 



<snippet id='radtreeview-how-to-bind-wcf-service-load-on-demand-block_7-cs' />
<snippet id='radtreeview-how-to-bind-wcf-service-load-on-demand-block_8-vb' />

Add the __FindChildren()__ method to the __HierarchicalDataSource__ file. It will find all child nodes by a given item. 



<snippet id='radtreeview-how-to-bind-wcf-service-load-on-demand-block_9-cs' />
<snippet id='radtreeview-how-to-bind-wcf-service-load-on-demand-block_10-vb' />

Add a public method named __LoadItemChildren()__. This method visits all current items and adds their direct children to the data source, if there are any. 



<snippet id='radtreeview-how-to-bind-wcf-service-load-on-demand-block_11-cs' />
<snippet id='radtreeview-how-to-bind-wcf-service-load-on-demand-block_12-vb' />

Finally add an event handler in your treeview declaration for the __Expanded__ event. 



<snippet id='radtreeview-how-to-bind-wcf-service-load-on-demand-block_13-xaml' />

Switch to the code-behind and the following code to handle the event. 



<snippet id='radtreeview-how-to-bind-wcf-service-load-on-demand-block_14-cs' />
<snippet id='radtreeview-how-to-bind-wcf-service-load-on-demand-block_15-vb' />

Here, you first get references to the treeview and the item that was expanded. Then, you get a reference to the hierarchical data source and call its __LoadItemChildren()__ method and pass the value of the expanded item. What the method does is fetching the children of that data item via the web service and adding them as children of the treeview.

## See Also
 * [Get Item by Path]({%slug radtreeview-how-to-get-item-by-path%})
 * [Binding to WCF Service]({%slug radtreeview-populating-with-data-databinding-to-wcf-service%})
 * [Binding to XML]({%slug radtreeview-populating-with-data-data-binding-to-xml%})