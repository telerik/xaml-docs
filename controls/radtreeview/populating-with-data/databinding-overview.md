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

```XAML
	<telerik:RadTreeView DataContext="{StaticResource Categories}" />
```

```C#
	radTreeView.DataContext = new CategoryList();
```
```VB.NET
	radTreeView.DataContext = New CategoryList()
```

The __DataContext__ property is inherited, e.g. if you assign a __DataContext__ to an element, all of its children will automatically have the same data context, unless you assign them a different data context. For example, if you have the following control structure: 

```XAML
	<Grid x:Name="LayoutRoot">
	    <telerik:RadTreeView x:Name="radTreeView1"/>
	    <telerik:RadTreeView x:Name="radTreeView2"/>      
	</Grid>
```
	
You can simply assign the __DataContext__ to the __Grid__ control and both tree views will inherit it.

```XAML
	<Grid x:Name="LayoutRoot"DataContext="{StaticResource categories}">
```
	
Where the static resource __categories__ is defined in XAML as follows: 

```XAML
	<UserControl.Resources>
	  <local:CategoryList x:Key="categories" />
	</UserControl.Resources>
```
	
Or in code-behind: 

```C#
	LayoutRoot.DataContext = new CategoryList();
```
```VB.NET
	LayoutRoot.DataContext = New CategoryList()
```

## See Also
 * [Populating with Data - Declaratively]({%slug radtreeview-populating-with-data-declaratively%})
 * [Populating with Data - In Code-Behind]({%slug radtreeview-populating-with-data-in-code-behind%})
 * [Binding to XML]({%slug radtreeview-populating-with-data-data-binding-to-xml%})
 * [Binding to Object]({%slug radtreeview-populating-with-data-data-binding-to-object%})
 * [Binding to WCF Service]({%slug radtreeview-populating-with-data-databinding-to-wcf-service%})
 * [Binding to ADO.NET Data Service]({%slug radtreeview-populating-with-data-databinding-to-adonet-service%})
 * [Hierarchical Data Templates]({%slug radtreeview-populating-with-data-hierarchical-data-templates%})