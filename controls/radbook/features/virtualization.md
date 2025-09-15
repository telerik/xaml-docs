---
title: UI Virtualization
page_title: UI Virtualization
description: Check our &quot;UI Virtualization&quot; documentation article for the RadBook {{ site.framework_name }} control.
slug: virtualization
tags: ui,virtualization
published: True
position: 5
---

# UI Virtualization

The __RadBook__ API supports __UI Virtualization__, which means that __RadBook__ will generate the minimal number of __RadBookItem__ containers for a successful page flip. This significantly reduces the memory footprint of the application and speeds up the loading time thus enhancing additionally the UI performance.

>The standard layout system creates item containers and computes layout for each item associated with a list control. The word "virtualize" refers to a technique by which a subset of user interface (UI) elements are generated from a larger number of data items based on which items are visible on-screen. Generating many UI elements when only a few elements might be on the screen can adversely affect the performance of your application.

The default __ItemsPanel__ for the __RadBook__ is __BookPanel__. The __BookPanel__ derives from __VirtualizingPanel__. It calculates the number of visible items and works with the __ItemContainerGenerator__ from an __ItemsControl__ (such as Book) to create UI elements only for the necessary (visible) items.

The following tutorial shows how to bind to a collection of business objects and virtualize the items displayed in a __RadBook__ element using the __IsVirtualizing__ property.

__Example 1: Defining a RadBook__  
```XAML
	<Grid.Resources>
		<sampleData:RadBookSampleData x:Key="DataSource" />
		<DataTemplate x:Key="PageTemplate">
			<Border Background="LightGoldenrodYellow" 
					BorderBrush="Black"
					BorderThickness="1">
				<TextBlock HorizontalAlignment="Center" 
						   VerticalAlignment="Center"
						   FontSize="36"
						   Text="{Binding}" />
			</Border>
		</DataTemplate>
	</Grid.Resources>
	<Grid x:Name="LayoutRoot" Background="White">
		<telerik:RadBook x:Name="book1" 
						 Width="500"
						 Height="500"
						 IsVirtualizing="False"
						 ItemsSource="{Binding Source={StaticResource DataSource}, Path=VeryLargeDataSource}"
						 LeftPageTemplate="{StaticResource PageTemplate}"
						 RightPageTemplate="{StaticResource PageTemplate}" />
	</Grid>
```

The __RadBook__ with __Name__ "book1" is bound to a collection with 10000 __Team__ objects. In the above example, the __IsVirtualizing__ property is set to __False__ (by default it is __True__, but for the sake of the example is __False__) which means that it will take few minutes in order the containers to be generated. That will freeze your application.

In this case you need to use the __UI Virtualization__ behavior of the __RadBook__. 

## Enable UI Virtualization

In order to enable the __UI Virtualization__ behavior, you should set the __IsVirtualizing__  property of the __RadBook__ to __True__. See the example below:

__Example 2: Enabling the UI virtualization__  
```XAML
	<telerik:RadBook x:Name="book2" IsVirtualizing="True"/>
```

Now it will take just a second for the necessary containers to be generated.