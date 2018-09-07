---
title: Basic Hierarchies
page_title: Basic Hierarchies
description: Basic Hierarchies
slug: gridview-basic-hierarchies
tags: basic,hierarchies
published: True
position: 1
---

# Basic Hierarchies

* [Defining the GridViewTableDefinition](#defining-the-gridviewtabledefinition)
* [Check if a hierarchy item is expanded](#check-if-a-hierarchy-item-is-expanded)

#### __Figure 1: Hierarhical RadGridView__
![Hierarhical RadGridView](images/RadGridView_BasicHierarchies_1.png)

__RadGridView__ allows you to display hierarchical data in the form of nested grid views. To do so you have to define a table definition for each subset of data you want to display. Such a definition can be done by creating a __GridViewTableDefinition__ object and adding it to the __ChildTableDefinitions__ collection of the __RadGridView__.

## Defining the GridViewTableDefinition

Specific for the __GridViewTableDefinition__ is that it needs to have its __Relation__ property to the name of the property containing the subset of data. In this way you define the data source for the nested tables. You set the property to an object of type __PropertyRelation__.

The __ParentPropertyName__ of the __PropertyRelation__ object represents the name of the property that will be used as a source for the nested table.

#### __[XAML] Example 1: Defining the GridViewTableDefinition__

{{region xaml-gridview-basic-hierarchies_4}}
	<telerik:GridViewTableDefinition>
	    <telerik:GridViewTableDefinition.Relation>
	        <telerik:PropertyRelation ParentPropertyName="Orders" />
	    </telerik:GridViewTableDefinition.Relation>
	</telerik:GridViewTableDefinition>
{{endregion}}

#### __[C#] Example 2: Defining the GridViewTableDefinition programmatically__
{{region cs-gridview-basic-hierarchies_5}}
	GridViewTableDefinition td = new GridViewTableDefinition();
	td.Relation = new PropertyRelation("Orders");
{{endregion}}


#### __[VB.NET] Example 2: Defining the GridViewTableDefinition programmatically__

{{region vb-gridview-basic-hierarchies_6}}
	Dim td As New GridViewTableDefinition()
	td.Relation = New Telerik.Windows.Data.PropertyRelation("Orders")
{{endregion}}

Now you can add the definition to the __ChildTableDefinitions__ collection.

#### __[XAML] Example 3: Adding the GridViewTableDefinition to the ChildTableDefinitions__

{{region xaml-gridview-basic-hierarchies_7}}
	<telerik:RadGridView x:Name="radGridView"
	                 AutoGenerateColumns="False">
	    <telerik:RadGridView.ChildTableDefinitions>
	        <telerik:GridViewTableDefinition>
	            <telerik:GridViewTableDefinition.Relation>
	                <telerik:PropertyRelation ParentPropertyName="Orders" />
	            </telerik:GridViewTableDefinition.Relation>
	        </telerik:GridViewTableDefinition>
	    </telerik:RadGridView.ChildTableDefinitions>
	</telerik:RadGridView>
{{endregion}}


#### __[C#] Example 4: Adding the GridViewTableDefinition to the ChildTableDefinitions programmatically__

{{region cs-gridview-basic-hierarchies_8}}
	this.radGridView.ChildTableDefinitions.Add(td);
{{endregion}}

#### __[VB.NET] Example 4: Adding the GridViewTableDefinition to the ChildTableDefinitions programmatically__

{{region vb-gridview-basic-hierarchies_9}}
	Me.radGridView.ChildTableDefinitions.Add(d)
{{endregion}}

>tipThe __GridViewTableDefinition__ object also exposes a __ChildTableDefinitions__ property, which means that you can nest grids on more than one level.

## Check if a hierarchy item is expanded

>The __IsExpanded__ method can also be used to check whether a group is expanded. More information can be found in the [Programmatic Grouping]({%slug gridview-programmatic-grouping%}) topic.

In case when checking whether a given hierarchical item is expanded the __IsExpanded__ method of __RadGridView__ comes in handy. When an item is passed as a parameter to it, it will return a boolean value determining whether its hierarchy is expanded or not.

#### __[C#] Example 5: Call the IsExpanded method of RadGridView__

{{region vb-gridview-basic-hierarchies_10}}
	bool isExpanded = this.clubsGrid.IsExpanded(this.clubsGrid.Items[0]);
{{endregion}}

#### __[VB.NET] Example 5: Call the IsExpanded method of RadGridView__
{{region vb-gridview-basic-hierarchies_10}}
	Dim isExpanded As Boolean = Me.clubsGrid.IsExpanded(Me.clubsGrid.Items(0))
{{endregion}}

## See Also

 * [Custom Hierarchies]({%slug gridview-custom-hierarchies%})
 * [Self-Referencing GridView]({%slug gridview-self-referencing-grid%})
 * [How-to Set Properties of the Child RadGridView]({%slug gridview-how-to-access-child-gridview%})
