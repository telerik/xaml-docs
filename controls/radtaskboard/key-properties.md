---
title: Key Properties
page_title: Key Properties
description: This article lists and explains the events exposed by the RadTaskBoard control.
slug: radtaskboard-key-properties
tags: radtaskboard, key, property, properties
published: True
position: 3
---

# Key Properties

This article will list the key properties provided by the RadTaskBoard control.

## AutoGenerateColumns

This is a boolean property which determines whether the control will auto generate its columns or not. By default this property is true. You can disable the auto generation of the columns by setting the __AutoGenerateColumns__ property to false. Then you will need to define them manually.

__Example 1: Manually defined columns__	
	```XAML		
	   <telerik:RadTaskBoard x:Name="taskBoard" GroupMemberPath="State" AutoGenerateColumns="False">
			<telerik:RadTaskBoard.Columns>
				<telerik:TaskBoardColumn GroupName="Not Done" />
				<telerik:TaskBoardColumn GroupName="In Progress" />
				<telerik:TaskBoardColumn GroupName="Done" />
			</telerik:RadTaskBoard.Columns>
		</telerik:RadTaskBoard>		
	```

## GroupMemberPath

It allows you to specify the property, whose value will be used to group the task items. 

__Example 2: Set GroupMemberPath__
	```XAML
	   <telerik:RadTaskBoard x:Name="taskBoard" GroupMemberPath="State" />
	```

## ColumnWidth and CollapsedColumnWidth 

Through the __ColumnWidth and CollapsedColumnWidth__, you can control the default Width of the TaskBoardColumn in expanded and collapsed state. __Example 3__ shows how to set these properties and their default values.

__Example 3: Set ColumnWidth and CollapsedColumnWidth__
	```C#
		this.taskBoard.ColumnWidth = 300; 
		this.taskBoard.CollapsedColumnWidth = 42; 
	```

## ColumnHeaderHeight

To change the default height of the headers inside the columns you can use the __ColumnHeaderHeight__ property of the RadTaskBoard. __Example 4__ shows how to set this property and its default value.

__Example 4: Set ColumnHeaderHeight__
	```C#
	   this.taskBoard.ColumnHeaderHeight = 40; 
	```

## ColumnHeaderTemplate

To further customize the headers of all columns, you can create your own DataTemplate and apply it to the __ColumnHeaderTemplate__ property of the RadTaskBoard.

__Example 5: Set ColumnHeaderTemplate__
	```XAML
	   <telerik:RadTaskBoard x:Name="taskBoard" GroupMemberPath="State" ItemsSource="{Binding Data}">
			<telerik:RadTaskBoard.ColumnHeaderTemplate>
				<DataTemplate>
					<TextBlock Text="{Binding }" FontSize="25" Foreground="Red"/>
				</DataTemplate>
			</telerik:RadTaskBoard.ColumnHeaderTemplate>
		</telerik:RadTaskBoard>
	```

## ColumnOffset

To increase the space between the columns, you can set the __ColumnOffset__ property. __Example 5__ shows how to set this property and its default value.

__Example 6: Set ColumnOffset__
	```C#
	   this.taskBoard.ColumnOffset = 10; 
	```

## CanUserSelect, IsDragDropEnabled, and CanUserCollapseColumns

To restrict the user from selecting / reordering the tasks, or collapsing the column you can use the corresponding properties: __CanUserSelect, IsDragDropEnabled, and CanUserCollapseColumns__
	
__Example 7: Set CanUserSelect, IsDragDropEnabled, and CanUserCollapseColumns__
	```XAML
	   <telerik:RadTaskBoard x:Name="taskBoard" GroupMemberPath="State" CanUserCollapseColumns="False" CanUserSelect="False" IsDragDropEnabled="False" />
	```

## Categories
	
The control exposes a __Categories__ property of type __IEnumerable__. You can use it to specify different category indicator color for your task. More information can be found in the  [Category Indicator]({%slug radtaskboard-features-category-indicator%}) help article.

## ItemHeight

The control allows you to change the height of all tasks by setting the __ItemHeight__ property.  The default height of all items is __140__.
	
## See Also

* [Getting Started]({%slug radtaskboard-getting-started%})
