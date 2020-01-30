---
title: Getting Started
page_title: Getting Started
description: This article will walk you through creating a sample application using the RadCollectionNavigator.
slug: collectionnavigator_getting_started
tags: getting,started
published: True
position: 2
---

# Getting Started

__RadCollectionNavigator__’s main purpose is to expose some of the methods of [ICollectionView](https://docs.microsoft.com/en-us/dotnet/api/system.componentmodel.icollectionview?view=netframework-4.8)/[IEditableCollectionView](https://docs.microsoft.com/en-us/dotnet/api/system.componentmodel.ieditablecollectionview?view=netframework-4.8) through its UI and public commands.

RadCollectionNavigator’s __Source__ property accepts __IEnumerable__ values and manages them as follows: If the underlying value implements __ICollectionView__, the current implementation of its methods is used. If it does __not__, a new instance of Telerik’s [QueryableCollectionView](https://docs.telerik.com/devtools/wpf/api/telerik.windows.data.queryablecollectionview) (which implements both interfaces) is initialized, using the Source value as its __SourceCollection__.

In either case, the used ICollectionView is exposed through the control’s __CollectionView__ property. By binding an ItemsControl’s __ItemsSource__ to this property one can benefit from seamless, MVVM-compatible and data-driven collection processing for any ItemsControls and any collection (even for custom ICollectionView implementations).

## Assembly References

In order to use __RadCollectionNavigator__, you will need to add references to the following assemblies:
* __Telerik.Windows.Controls__
* __Telerik.Windows.Controls.Data__
* __Telerik.Windows.Data__

You can find the required assemblies for each control from the suite in the {% if site.site_name == 'Silverlight' %}[Controls Dependencies]({%slug installation-installing-controls-dependencies%}){% endif %}{% if site.site_name == 'WPF' %}[Controls Dependencies]({%slug installation-installing-controls-dependencies-wpf%}){% endif %} help article.

## Defining RadCollectionNavigator

__Examples 1 and 2__ demonstrate how to utilize the CollectionView exposed by the RadCollectionNavigator.

> The __MyViewModel__ class used in __Example 1__ is defined in __Example 4__ in the following [article]({%slug gridview-getting-started2%}).

#### __[XAML] Example 1: RadCollectionNavigator bound to a ListBox__

{{region xaml-collectionnavigator-getting-started_0}}
	<Grid x:Name="LayoutRoot"
		  Background="White">
		<Grid.DataContext>
			<my:MyViewModel />
		</Grid.DataContext>
		<Grid.RowDefinitions>
			<RowDefinition Height="*"/>
			<RowDefinition Height="Auto" />
		</Grid.RowDefinitions>
		<ListBox
			DisplayMemberPath="Name"
			SelectedItem="{Binding ElementName=collectionNavigator, Path=CurrentItem, Mode=TwoWay}"
			ItemsSource="{Binding ElementName=collectionNavigator, Path=CollectionView}" />
		<telerik:RadCollectionNavigator
			Source="{Binding Clubs}"
			Grid.Row="1"
			x:Name="collectionNavigator"/>
	</Grid>
{{endregion}}

#### __Figure 1: RadCollectionNavigator in the Fluent theme__

![RadCollectionNavigator bound to a ListBox](images/collectionnavigator-getting-started.png)

## See Also

* [Overview]({%slug collectionnavigator_overview%})

* [Visual Structure]({%slug collectionnavigator_visual_struture%})