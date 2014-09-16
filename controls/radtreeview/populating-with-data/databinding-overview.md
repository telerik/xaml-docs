---
title: DataBinding - Overview
page_title: DataBinding - Overview
description: DataBinding - Overview
slug: radtreeview-populating-with-data-databinding-overview
tags: databinding,-,overview
publish: True
position: 1
---

# DataBinding - Overview



__Data binding__ is a process of connecting the application User Interface and business logic.

## DataContext 

One very important aspect of the data binding is the __DataContext__. It is the data object, which is assigned to the specific framework element. You can assign __DataContext__ both through code-behind and XAML: 

#### __XAML__

{{region radtreeview-populating-with-data-databinding-overview_0}}
	<telerik:RadTreeView DataContext="{StaticResource Categories}" />
	{{endregion}}



#### __C#__

{{region radtreeview-populating-with-data-databinding-overview_1}}
	radTreeView.DataContext = new CategoryList();
	{{endregion}}



#### __VB.NET__

{{region radtreeview-populating-with-data-databinding-overview_2}}
	radTreeView.DataContext = New CategoryList()
	{{endregion}}



The __DataContext__ property is inherited, e.g. if you assign a __DataContext__ to an element, all of its children will automatically have the same data context, unless you assign them a different data context. For example, if you have the following control structure: 

#### __XAML__

{{region radtreeview-populating-with-data-databinding-overview_3}}
	<Grid x:Name="LayoutRoot">
	    <telerik:RadTreeView x:Name="radTreeView1"/>
	    <telerik:RadTreeView x:Name="radTreeView2"/>      
	</Grid>
	{{endregion}}



You can simply assign the __DataContext__ to the __Grid__ control and both tree views will inherit it.

#### __XAML__

{{region radtreeview-populating-with-data-databinding-overview_4}}
	<Grid x:Name="LayoutRoot"DataContext="{StaticResource categories}">
	{{endregion}}



Where the static resource __categories__ is defined in XAML as follows: 

#### __XAML__

{{region radtreeview-populating-with-data-databinding-overview_5}}
	<UserControl.Resources>
	  <local:CategoryList x:Key="categories" />
	</UserControl.Resources>
	{{endregion}}



Or in code-behind: 

#### __C#__

{{region radtreeview-populating-with-data-databinding-overview_6}}
	LayoutRoot.DataContext = new CategoryList();
	{{endregion}}



#### __VB.NET__

{{region radtreeview-populating-with-data-databinding-overview_7}}
	LayoutRoot.DataContext = New CategoryList()
	{{endregion}}



# See Also

 * [Populating with Data - Declaratively]({%slug radtreeview-populating-with-data-declaratively%})

 * [Populating with Data - In Code-Behind]({%slug radtreeview-populating-with-data-in-code-behind%})

 * [Binding to XML]({%slug radtreeview-populating-with-data-data-binding-to-xml%})

 * [Binding to Object]({%slug radtreeview-populating-with-data-data-binding-to-object%})

 * [Binding to WCF Service]({%slug radtreeview-populating-with-data-databinding-to-wcf-service%})

 * [Binding to ADO.NET Data Service]({%slug radtreeview-populating-with-data-databinding-to-adonet-service%})

 * [Hierarchical Data Templates]({%slug radtreeview-populating-with-data-hierarchical-data-templates%})
