---
title: Getting Started
page_title: Getting Started
description: Getting Started
slug: radtreeview-getting-started
tags: getting,started
published: True
position: 0
---

# Getting Started

This tutorial will walk you through the creation of a sample application that contains __RadTreeView__.

* [Assembly References](#assembly-references)
* [Defining a RadTreeView](#defining-a-radtreeview)
* [Adding Items to RadTreeView](#adding-items-to-radtreeview)
* [Data Binding RadTreeView](#data-binding-radtreeview)
* [Enable Drag and Drop](#enable-drag-and-drop)
* [Setting a Theme](#setting-a-theme)

## Assembly References

In order to use the __RadTreeView__ control, you will need to add references to the following assemblies:
* __Telerik.Windows.Controls__
* __Telerik.Windows.Controls.Navigation__
* __Telerik.Windows.Controls.Data__

You can find the required assemblies for each control from the UI for WPF suite in the {% if site.site_name == 'Silverlight' %}[Controls Dependencies]({%slug installation-installing-controls-dependencies%}){% endif %}{% if site.site_name == 'WPF' %}[Controls Dependencies]({%slug installation-installing-controls-dependencies-wpf%}){% endif %} help article.

## Defining a RadTreeView

You can add __RadTreeView__ manually in XAML as demonstrated in __Example 1__. 

#### __[XAML] Example 1: Adding RadTreeView in XAML__
{{region radtreeview-getting-started_01}}
	<telerik:RadTreeView />
{{endregion}}
	
__RadTreeView__ doesn't display any content when it is not populated with items, so at this point there should be nothing displayed on the screen.

## Adding Items to RadTreeView

__RadTreeView__ works with __RadTreeViewItem__ elements, which should be added in the __Items__ collection of the control.

#### __[XAML] Example 2: Adding RadTreeViewItems in XAML__
{{region radtreeview-getting-started_02}}
	<telerik:RadTreeView>
		<telerik:RadTreeView.Items>
			<telerik:RadTreeViewItem Header="Football" />
			<telerik:RadTreeViewItem Header="Tennis" />
			<telerik:RadTreeViewItem Header="Cycling" />
			<telerik:RadTreeViewItem Header="Basketball" />
		</telerik:RadTreeView.Items>
	</telerik:RadTreeView>
{{endregion}}
	
#### __[C#] Example 3: Adding RadTreeViewItems in code__
{{region radtreeview-getting-started_03}}
	RadTreeView treeView = new RadTreeView();
	treeView.Items.Add(new RadTreeViewItem() { Header = "Football" });
	treeView.Items.Add(new RadTreeViewItem() { Header = "Tennis" });
	treeView.Items.Add(new RadTreeViewItem() { Header = "Cycling" });
	treeView.Items.Add(new RadTreeViewItem() { Header = "Basketball" });
{{endregion}}
	
#### __[VB.NET] Example 3: Adding RadTreeViewItems in code__
{{region radtreeview-getting-started_4}}
	Dim treeView As New RadTreeView()
	treeView.Items.Add(New RadTreeViewItem() With { _
		.Header = "Football" _
	})
	treeView.Items.Add(New RadTreeViewItem() With { _
		.Header = "Tennis" _
	})
	treeView.Items.Add(New RadTreeViewItem() With { _
		.Header = "Cycling" _
	})
	treeView.Items.Add(New RadTreeViewItem() With { _
		.Header = "Basketball" _
	})
{{endregion}}

#### __Figure 1: RadTreeView flat data example__
![](images/radtreeview-getting-started-01.png)
	
> The __Items__ property of the treeview component is also its content property, so adding the children through the Items collection is not necessary in XAML. You can do it without wrapping the items into the RadTreeView.Items tag. The same applies for the __Items__ property of RadTreeViewItem.

__RadTreeViewItem__ is hierarchical items control, which means that it can contain children containers that hold children on their own. In other words, you can nest items into another item. 

> The __RadTreeViewItem__ class expose a __Header__ property that is used to define the content of its header.

#### __[XAML] Example 4: Nesting RadTreeViewItems__
{{region radtreeview-getting-started_05}}
	<telerik:RadTreeView>
		<telerik:RadTreeViewItem Header="Sport Categories" IsExpanded="True">
			<telerik:RadTreeViewItem Header="Football" IsExpanded="True">
				<telerik:RadTreeViewItem Header="Futsal"/>
				<telerik:RadTreeViewItem Header="Soccer"/>
			</telerik:RadTreeViewItem>
			<telerik:RadTreeViewItem Header="Tennis"/>
			<telerik:RadTreeViewItem Header="Cycling"/>
		</telerik:RadTreeViewItem>
	</telerik:RadTreeView>
{{endregion}}
		
#### __Figure 2: RadTreeView nested items example__
![](images/radtreeview-getting-started-02.png)	

## Data Binding RadTreeView

The __RadTreeView__ control allows you to data bind it to a collection of business objects and define their visual appearance. You can read more on how to bind __RadTreeView__ in the [Binding to Object]({%slug radtreeview-populating-with-data-data-binding-to-object%}) help article. You can also take a look at the other articles from the [Populating with Data]({%slug radtreeview-populating-with-data-overview%}) section of the help where you can find information about binding to an XML file and different services. There you can also find information about __HierarchicalDataTemplate__, which is used to define the look and feel of the __RadTreeViewItems__ in a data binding scenario.

## Enable Drag and Drop

__RadTreeView__ supports drag and drop functionality. To enable this feature, you only need to set the __IsDragDropEnabled__ property to __True__.

#### __[XAML] Example 5: IsDragDropEnabled setting__
{{region radtreeview-getting-started_05}}
	<telerik:RadTreeView IsDragDropEnabled="True">
{{endregion}} 

__Example 6__ demonstrates a runnable code snippet using __RadTreeView__ with its drag and drop enabled.
  
#### __[XAML] Example 6: Drag and drop set up__
{{region radtreeview-getting-started_07}}
	<telerik:RadTreeView IsDragDropEnabled="True">
		<telerik:RadTreeViewItem Header="Sport Categories" IsExpanded="True">
			<telerik:RadTreeViewItem Header="Football" IsExpanded="True">
				<telerik:RadTreeViewItem Header="Futsal"/>
				<telerik:RadTreeViewItem Header="Soccer"/>
			</telerik:RadTreeViewItem>
			<telerik:RadTreeViewItem Header="Tennis"/>
			<telerik:RadTreeViewItem Header="Cycling"/>
		</telerik:RadTreeViewItem>
	</telerik:RadTreeView>
{{endregion}}

#### __Figure 3: Drag and drop visual example__
![](images/radtreeview-getting-started-03.png)	

>tip You can find out more about the drag and drop support in the [Drag and Drop]({%slug radtreeview-features-drag-and-drop%}) help article.

## Setting a Theme

The controls from our suite support different themes. You can see how to apply a theme different than the default one in the [Setting a Theme (Using Implicit Styles)]({%slug styling-apperance-implicit-styles-overview%}) help article.

>important Changing the theme using implicit styles will affect all controls that have styles defined in the merged resource dictionaries. This is applicable only for the controls in the scope in which the resources are merged. 

To change the theme, you can follow the steps below:
* Choose between the themes and add reference to the corresponding theme assembly (ex: Telerik.Windows.Themes.Windows8.dll). You see the different themes applied in the Theming examples from our demos application.

* Merge the ResourceDictionaries with the namespace required for the controls that you are using from the theme assembly. For __RadTreeView__, you will need to merge the following resources:
	* __Telerik.Windows.Controls.xaml__
	* __Telerik.Windows.Controls.Navigation.xaml__

	__Example 8__ demonstrates where you can merge the ResourceDictionaries so they are applied globally for the entire application.
	
	#### __[XAML] Example 8: Merge the ResourceDictionaries__  
	{{region radtreeview-getting-started_08}}
		<Application x:Class="MyTestApplication.App"
				 xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
				 xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
				 StartupUri="MainWindow.xaml">
			<Application.Resources>
				<ResourceDictionary>
					<ResourceDictionary.MergedDictionaries>
						<ResourceDictionary Source="/Telerik.Windows.Themes.Windows8;component/Themes/Telerik.Windows.Controls.xaml" />
						<ResourceDictionary Source="/Telerik.Windows.Themes.Windows8;component/Themes/Telerik.Windows.Controls.Navigation.xaml" />
					</ResourceDictionary.MergedDictionaries>
				</ResourceDictionary>
			</Application.Resources>
		</Application>
	{{endregion}}

__Figure 4__ shows __RadTreeView__ with Windows8 theme applied.
	
#### __Figure 4: RadTreeView with Windows8 theme__
![](images/radtreeview-getting-started-04.png)
	
# See Also
 * [Overview]({%slug radtreeview-overview2%})
 * [Visual Structure]({%slug radtreeview-visual-structure%})
 * [Expanding and Collapsing Items]({%slug radtreeview-feautres-treeviewitem-expanding-and-collapsing-items%})
 * [Selection]({%slug radtreeview-feautres-treeviewitem-selection%})
 * [Setting a Theme (Using Implicit Styles)]({%slug styling-apperance-implicit-styles-overview%})
 * [Populating with Data - Overview]({%slug radtreeview-populating-with-data-overview%})
 * [Styles and Templates - Overview]({%slug radtreeview-styling-and-appearance-overview2%}) 
 * [Events - Overview]({%slug radtreeview-events-overview%})
