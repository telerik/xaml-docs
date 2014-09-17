---
title: Implementation
page_title: Implementation
description: Implementation
slug: gridview-commands-implementation
tags: implementation
published: True
position: 1
---

# Implementation



## 

Fast and quite easy approach for implementing the built-in commands in __RadGridView__ is to set them directly to a particular __RadButton__. Thus, once you click a single button, the predefined command will be executed. 

Basically, there are two main scenarios to define a button - inside and outside the __RadGridView__. In the first case, you may define it as a __CellTemplate__ of a particular column for example. It will result in a separate __RadButton__ in each row and the command to be executed will be applied to the corresponding item. The definition will be as follows:

#### __XAML__

{{region GridView-Commands-Implementation_3}}
	xmlns:telerikGrid="clr-namespace:Telerik.Windows.Controls;assembly=Telerik.Windows.Controls.GridView"
	{{endregion}}



#### __XAML__

{{region GridView-Commands-Implementation_0}}
	<telerik:GridViewColumn>
	  <telerik:GridViewColumn.CellTemplate>
	     <DataTemplate>
	         <telerik:RadButton Content="Delete" Command="telerikGrid:RadGridViewCommands.Delete" CommandParameter="{Binding}" />
	     </DataTemplate>
	  </telerik:GridViewColumn.CellTemplate>
	</telerik:GridViewColumn>
	{{endregion}}



Once the source object is defined up in the tree as a __DataContext__, you may set the source for the __CommandParameter__ Property's Binding to be the entire object.

The other approach will be to define the __RadButton__ beyond the boundaries of the ____RadGridView:

#### __XAML__

{{region GridView-Commands-Implementation_1}}
	<telerik:RadButton Width="150" Content="Save insert/edit" 
	                   Command="telerikGrid:RadGridViewCommands.CommitEdit" 
	                   CommandTarget="{Binding ElementName=RadGridView1}"  />
	{{endregion}}



In this case the target object needs to be explicitly set in the definition of the __CommandTarget__ Property, specifying the __RadGridView__ towards which the command has to be applied. This specific command will be automatically disabled untill a change in any of the items in the grid is made. {% if site.site_name == 'Silverlight' %}

However, in both cases you will need to initialize the commands beforehand:{% endif %}

#### __XAML__

{{region GridView-Commands-Implementation_2}}
	public MainPage()
	{
	           ICommand deleteCommand = RadGridViewCommands.Delete;
	           ICommand beginInsertCommand = RadGridViewCommands.BeginInsert;
	           ICommand cancelRowEditCommand = RadGridViewCommands.CancelRowEdit;
	           ICommand commitEditCommand = RadGridViewCommands.CommitEdit;
	           InitializeComponent();
	}
	{{endregion}}




