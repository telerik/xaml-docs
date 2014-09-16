---
title: Basic Hierarchies
page_title: Basic Hierarchies
description: Basic Hierarchies
slug: gridview-basic-hierarchies
tags: basic,hierarchies
publish: True
position: 1
---

# Basic Hierarchies



## 

![](images/RadGridView_BasicHierarchies_1.png)

The __RadGridView__ allows you to display hierarchical data in the form of nested grid views. To do so you have to define a table definition for each subset of data you want to display. Such a definition can be done by creating a __GridViewTableDefinition__ object and adding it to the __ChildTableDefinitions__ collection of the __RadGridView__.

The __GridViewTableDefinition__ class is to be found in the same assembly and namespace as the __RadGridView__control. To learn how to create a __GridViewTableDefinition__ take a look at the following lines of code.

#### __XAML__

{{region gridview-basic-hierarchies_0}}
	<telerik:GridViewTableDefinition />
	{{endregion}}



#### __C#__

{{region gridview-basic-hierarchies_1}}
	GridViewTableDefinition d = new GridViewTableDefinition();
	{{endregion}}



#### __VB.NET__

{{region gridview-basic-hierarchies_2}}
	Dim d As New GridViewTableDefinition()
	{{endregion}}



After that set its __Relation__ property to the name of the property containing the subset of data. In this way you define the data source for the nested tables. You set the property to an object of type __PropertyRelation__.

The __ParentPropertyName__ of the __PropertyRelation__ object represents the name of the property that will be used as a source for the nested table.

#### __XAML__

{{region gridview-basic-hierarchies_4}}
	<telerik:GridViewTableDefinition>
				<telerik:GridViewTableDefinition.Relation>
					<telerik:PropertyRelation ParentPropertyName="Orders" />
				</telerik:GridViewTableDefinition.Relation>
	</telerik:GridViewTableDefinition>
	{{endregion}}



#### __C#__

{{region gridview-basic-hierarchies_5}}
	GridViewTableDefinition d = new GridViewTableDefinition();
	d.Relation = new Telerik.Windows.Data.PropertyRelation( "Orders" );
	{{endregion}}



#### __VB.NET__

{{region gridview-basic-hierarchies_6}}
	Dim d As New GridViewTableDefinition()
	d.Relation = New Telerik.Windows.Data.PropertyRelation("Orders")
	{{endregion}}



Now you can add the definition to the __ChildTableDefinitions__ collection.

#### __XAML__

{{region gridview-basic-hierarchies_7}}
	<telerik:RadGridView x:Name="radGridView"
	                         AutoGenerateColumns="False">
				<telerik:RadGridView.ChildTableDefinitions>
					<telerik:GridViewTableDefinition>
						<telerik:GridViewTableDefinition.Relation>
							<telerik:PropertyRelation ParentPropertyName="Orders" />
						</telerik:GridViewTableDefinition.Relation>
					</telerik:GridViewTableDefinition>
				</telerik:RadGridView.ChildTableDefinitions>
	    ...
	</telerik:RadGridView>
	{{endregion}}



#### __C#__

{{region gridview-basic-hierarchies_8}}
	this.radGridView.ChildTableDefinitions.Add( d );
	{{endregion}}



#### __VB.NET__

{{region gridview-basic-hierarchies_9}}
	Me.radGridView.ChildTableDefinitions.Add(d)
	{{endregion}}



>tipThe __GridViewTableDefinition__ object also exposes a __ChildTableDefinitions__ property, which means that you can nest grids on more than one level.

# See Also

 * [Custom Hierarchies]({%slug gridview-custom-hierarchies%})

 * [Self-Referencing GridView]({%slug gridview-self-referencing-grid%})
