---
title: Getting Started
page_title: Getting Started
description: Getting Started
slug: raddatapager-getting-started
tags: getting,started
published: True
position: 3
---

# Getting Started

>To learn more about the concepts behind the __RadDataPager__ you can read the [Paging Essentials]({%slug raddapager-features-paging-essentials%}) topic first.

The __RadDataPager__ is a control that allows you to split your data into pages and display it in a user friendly way. This topic will help you to quickly get started using the control. It will focus on the following:

* [Adding RadDataPager](#adding-raddatapager)

* [Configuring the RadDataPager](#configuring-the-raddatapager)

* [Paging RadGridView](#paging-radgridview)

* [Paging a Collection](#paging-a-collection)

* [Exposing the Paged Collection](#exposing-the-paged-collection)

## Adding RadDataPager

In order to use __RadDataPager__ in your project, you need to add references to the following assemblies:

* __Telerik.Windows.Controls.dll__

* __Telerik.Windows.Controls.Data.dll__

* __Telerik.Windows.Data.dll__

After adding references to the aforementioned dlls, you can declare a new __RadDataPager__ as any normal __Silverlight/WPF__ control.

>To use the __RadDataPager__ in the XAML you have to add the following namespace declaration: __xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"__ 

#### __[XAML]Example 1: RadDataPager Definition__

{{region xaml-raddatapager-getting-started_0}}

	<telerik:RadDataPager x:Name="radDataPager" />
{{endregion}}

## Configuring the RadDataPager

__RadDataPager__ allows to be configured via the properties it exposes. You can do the following:

* Manage the size of the pages via the __PageSize__ property. [Read more]({%slug raddatapager-features-page-size%})

* Show and hide visual elements of a pager via the __DisplayMode__ property. [Read more]({%slug raddatapager-features-display-modes%})

* Implement infinite paging. [Read more]({%slug raddatapager-features-infinite-paging%})

## Paging RadGridView

__RadGridView__ can be paged through its __RadGridView.Items__ collection which implements the __IPagedCollectionView__ interface.
          

The collection in this example holds business objects of type __Employee__. You should pass it to the __ItemsSource__ property of __RadGridView__.
         

After that, you create your __RadDataPager__ and bind its __RadDataPager.Source__ property to the __RadGridView.Items__ collection using __ElementName Binding__.
        

#### __[XAML]Example 2: RadGridView and RadDataPager integration__

{{region xaml-raddatapager-getting-started_7}}

	<Grid x:Name="LayoutRoot1"
	        Background="White">    
	    <Grid.RowDefinitions>
	        <RowDefinition />
	        <RowDefinition Height="Auto" />
	    </Grid.RowDefinitions>
	    <telerik:RadGridView x:Name="radGridView"
	                         ItemsSource="{Binding Employees}"
	                         AutoGenerateColumns="False">
	        <telerik:RadGridView.Columns>
	            <telerik:GridViewDataColumn DataMemberBinding="{Binding Name}" />
	            <telerik:GridViewDataColumn DataMemberBinding="{Binding CompanyName}" />
	            <telerik:GridViewDataColumn DataMemberBinding="{Binding Title}" />
	        </telerik:RadGridView.Columns>
	    </telerik:RadGridView>
	    <telerik:RadDataPager x:Name="radDataPager3"
	                          Source="{Binding Items, ElementName=radGridView}"
	                          PageSize="5" />
	</Grid>
{{endregion}}

#### __Figure 1: RadGridView and RadDataPager integration__
 ![](images/RadDataPager_GettingStarted_01.png)

## Paging a Collection

>To learn more about the use of the __Source__ and the __PagedSource__ properties, please read [this topic]({%slug raddatapager-features-source-and-paged-source%}).
          

__RadDataPager__ can page any collection that implements the __IEnumerable__ interface. The only thing that you have to do is to pass the collection to its __Source__ property.
        

The collection in this example will hold business objects of type Club. You can prepare a simple collection of clubs and pass it to the __Source__ property of the __RadDataPager__.
        

Create your __RadDataPager__ and make some basic configurations to it.
        

#### __[XAML]Example 3: Paging a collection__

	{{region xaml-raddatapager-getting-started_3}}
	<telerik:RadDataPager x:Name="radDataPager1"
	                      PageSize="5" 
	                      Source="{Binding Clubs}"/>
	{{endregion}}



After the collection is passed to the __Source__ property, it will get split into pages. In order to learn how to access the paged collection, please read the next section.
        

## Exposing the Paged Collection

>tip Instead of using the __PagedSource__ property you can also wrap your collection in an __IPagedCollectionView__ before passing it to the __Source__ property. To learn more read [this topic]({%slug raddatapager-features-source-and-paged-source%}).

The paged collection inside the __RadDataPager__ can be accessed via the __PagedSource__ property. It exposes the set of data belonging to the current page. Here is an example of a __ListBox__ that displays the data paged by the __RadDataPager__.

#### __[XAML]Example 4: Expose collection through RadDataPager__

{{region xaml-raddatapager-getting-started_6}}

	<Grid x:Name="LayoutRoot"
	        Background="White">
	    <Grid.RowDefinitions>
	        <RowDefinition />
	        <RowDefinition Height="Auto" />
	    </Grid.RowDefinitions>
	      <ListBox Name="itemsControl"
	               ItemsSource="{Binding PagedSource, ElementName=radDataPager2}"/>
	    <telerik:RadDataPager x:Name="radDataPager2"
	                            Grid.Row="1"
	                            DisplayMode="All"
	                            PageSize="5"                          
	                            Margin="0,10,0,0" 
	                            Source="{Binding Clubs}"/>
	</Grid>
{{endregion}}

#### __Figure 2: Exposed collection through RadDataPager__
 ![Rad Data Pager Getting Started 02](images/RadDataPager_GettingStarted_02.PNG)

# See Also

 * [Paging Essentials]({%slug raddapager-features-paging-essentials%})

 * [Visual Structure]({%slug raddatapager-visual-structure%})

 * [Events]({%slug raddatapager-events-overview%})

 * [Source and Paged Source]({%slug raddatapager-features-source-and-paged-source%})
