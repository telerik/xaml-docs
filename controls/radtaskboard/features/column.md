---
title: Column
page_title: Column
description: Check our &quot;Column&quot; documentation article for the RadTaskBoard {{ site.framework_name }} control.
slug: radtaskboard-features-column
tags: Column
published: True
position: 1
---

# Column

The __TaskBoardCardModels__ are added to the respective Column depending on the __GroupMemberPath__ property of the __RadTaskBoard__ control. 

> The __GroupMemberPath__ property of the __RadTaskBoard__ is required in order for the columns to be created.

The control provides two mechanisms for defining its columns:
* [Automatic columns definition](#automatic-columns-generation) based on the underlying data source. 
* [Manual columns definition](#manual-columns-definition) in XAML or code-behind. 
* [Cancel Auto Generation of a Specific Column](#cancel-auto-generation-of-a-specific-column)

## Key Features and Properties

* __GroupName__: A property of type __object__ that gets or sets the group name used to categorize the items in columns.
* __Header__: A property of type __object__ that gets or sets the content inside the header of the columns.
* __HeaderTemplate__: A property of type __DataTemplate__ that gets or sets the content template inside the header of the columns. This property can be used to further customize the column header.
* __IsExpanded__: A __Boolean__ property that gets or sets if a given column is expanded or not.
* __Width__: A property of type __double__ that gets or sets the column width.
* __CollapsedWidth__: A property of type __double__ that gets or sets the width of a collapsed column.
* __Items__: A collection property that holds the items inside the column.

## Automatic Columns Generation

By default, __RadTaskBoard__ will generate its columns automatically based on the underlying data source. When, for example, you set the __ItemsSource__ of __RadTaskBoard__ to a collection of TaskBoardCardModel (see code in __Example 1__ and the result in __Figure 1__), the control will create a separate column for each value of the property set to the __GroupMemberPath__ of the RadTaskBoard.

__Defining the data__
<snippet id='radtaskboard-features-column-block_1-cs' />

__Defining RadTaskBoard in XAML__

<snippet id='radtaskboard-features-column-block_2-xaml' />

#### Figure 1: RadTaskBoard with automatically generated columns
![Telerik TaskBoard Column 0](images/taskboard_column_0.png)

## Cancel Auto Generation of a Specific Column

To prevent the automatic generation of a specific column you can handle the __AutoGeneratingColumn__ event of the RadTaskBoard. Inside the event handler you can get the current generated column and you can cancel its generation by setting the __Cancel__ property to true.

__Cancel Auto Generation of a Specific Column__

<snippet id='radtaskboard-features-column-block_3-cs' />

## Manual Columns Definition

When the built-in order of the auto generation of columns does not fit in your case you can declare them manually. You can first disable the autogenerating of the columns by setting the __AutoGenerateColumns__ property of the RadTaskBoard to False. Then you can populate the __Columns__ collection property of the control.

> If the __Header__ property of the TaskBoardColumn is not set, the GroupName property will be used as a Header.

__Define RadTaskBoard with custom columns__

<snippet id='radtaskboard-features-column-block_4-xaml' />

__Define TaskBoardColumns in code__

<snippet id='radtaskboard-features-column-block_5-cs' />

#### Figure 2: RadTaskBoard with manually generated columns
![Telerik TaskBoard Column 1](images/taskboard_column_1.png)
	
## See Also
 * [Getting Started]({%slug radtaskboard-getting-started%})
 * [Binding to TaskBoardCardModel]({%slug radtaskboard-populating-with-data-binding-taskboardcardmodel%})
 * [Binding to CollectionViewSource]({%slug radtaskboard-populating-with-data-data-binding-to-collectionviewsource%})