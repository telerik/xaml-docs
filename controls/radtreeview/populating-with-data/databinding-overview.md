---
title: DataBinding - Overview
page_title: DataBinding - Overview
description: Check our &quot;DataBinding - Overview&quot; documentation article for the RadTreeView {{ site.framework_name }} control.
slug: radtreeview-populating-with-data-databinding-overview
tags: databinding,-,overview
published: True
position: 1
---

# DataBinding - Overview

__Data binding__ is a process of connecting the application User Interface and business logic.

## DataContext 

One very important aspect of the data binding is the __DataContext__. It is the data object, which is assigned to the specific framework element. You can assign __DataContext__ both through code-behind and XAML: 

<snippet id='radtreeview-populating-with-data-databinding-overview-block_1-xaml' />

<snippet id='radtreeview-populating-with-data-databinding-overview-block_2-cs' />
<snippet id='radtreeview-populating-with-data-databinding-overview-block_3-vb' />

The __DataContext__ property is inherited, e.g. if you assign a __DataContext__ to an element, all of its children will automatically have the same data context, unless you assign them a different data context. For example, if you have the following control structure: 

<snippet id='radtreeview-populating-with-data-databinding-overview-block_4-xaml' />
	
You can simply assign the __DataContext__ to the __Grid__ control and both tree views will inherit it.

<snippet id='radtreeview-populating-with-data-databinding-overview-block_5-xaml' />
	
Where the static resource __categories__ is defined in XAML as follows: 

<snippet id='radtreeview-populating-with-data-databinding-overview-block_6-xaml' />
	
Or in code-behind: 

<snippet id='radtreeview-populating-with-data-databinding-overview-block_7-cs' />
<snippet id='radtreeview-populating-with-data-databinding-overview-block_8-vb' />

## See Also
 * [Populating with Data - Declaratively]({%slug radtreeview-populating-with-data-declaratively%})
 * [Populating with Data - In Code-Behind]({%slug radtreeview-populating-with-data-in-code-behind%})
 * [Binding to XML]({%slug radtreeview-populating-with-data-data-binding-to-xml%})
 * [Binding to Object]({%slug radtreeview-populating-with-data-data-binding-to-object%})
 * [Binding to WCF Service]({%slug radtreeview-populating-with-data-databinding-to-wcf-service%})
 * [Binding to ADO.NET Data Service]({%slug radtreeview-populating-with-data-databinding-to-adonet-service%})
 * [Hierarchical Data Templates]({%slug radtreeview-populating-with-data-hierarchical-data-templates%})