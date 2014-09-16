---
title: Getting Started
page_title: Getting Started
description: Getting Started
slug: collectionnavigator_getting_started
tags: getting,started
publish: True
position: 2
---

# Getting Started



## How does it work?

RadCollectionNavigator’s main purpose is to expose some of ICollectionView/IEditableCollectionView methods through its UI and public commands. RadCollectionNavigator’s Source property accepts IEnumerable values and manages them as it follows: On the one hand, if the underlying value implement’s ICollectionView, the current implementation of its methods is used. And on the other hand, a new instance of Telerik’s QueryableCollectionView (which implements both interfaces) is initialized, using the Source value as its SourceCollection. In either case the used ICollectionView is exposed through control’s CollectionView property. By binding an ItemsControl’s ItemsSource to this property one can benefit from seamless, MVVM compatible and data-driven collection processing for any ItemsControls and any collections (even for custom ICollectionView implementations).
      

>In order to use it you need to add references to the assemblies Telerik.Windows.Data and Telerik.Windows.Controls.Data.

And here is a simple example with a ListBox:
      



#### __XAML__

{{region collectionnavigator_getting_started_0}}
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
				SelectedItem="{Binding ElementName=collectionNavigator, Path=CurrentItem, Mode=TwoWay}" 				 
				ItemsSource="{Binding ElementName=collectionNavigator, Path=CollectionView}" />
			<telerik:RadCollectionNavigator 
				Source="{Binding Clubs}" 
				Grid.Row="1" 
				x:Name="collectionNavigator"/>
		</Grid>
	
	{{endregion}}



The result:
        

![collectionnavigator 02](images/collectionnavigator_02.png)

# See Also
