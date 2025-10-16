---
title: GridView ItemsSourceProvider
page_title: GridView ItemsSourceProvider
description: Check our &quot;GridView ItemsSourceProvider&quot; documentation article for the RadMultiColumnComboBox {{ site.framework_name }} control.
slug: multicolumncombobox-gridview-itemssourceprovider
tags: gridview, itemssource, provider
published: True
position: 5
---

# GridView ItemsSourceProvider

By default, __RadMultiColumnComboBox__ will have the RadGridView component integrated as its DropDown. For this purpose, the control utilizes the __GridViewItemsSourceProvider__.  This article will go through the different functionalities of RadGridView supported by the __GridViewItemsSourceProvider__.

## Alternation

In case when readability needs to be improved, the alternation support comes in handy. The following set of properties are provided for manipulating it.

> More information can be found in the [Alternating Rows]({%slug radgridview-rows-alternating-rows%}) and [RowStyleSelector]({%slug gridview-rowstyleselector%}) topics.

* __AlternationCount__: The interval for each alternated row. For example, if each second row needs to be alternated the value can be set to 2.
* __AlternateRowStyle__: The alternated __GridViewRow__ can be styled through it.
* __AlternateRowStyleSelector__: Conditional styling support for the alternated rows.

## Columns

> The topic is discussed in details in the [Defining Columns]({%slug gridview-columns-defining-columns%}) article.

>important These properties affect only the Columns manually defined through the GridViewItemsSourceProvider. All Columns can be accessed through the __GridViewDropDownContentManager.Columns__ after the grid is loaded.

Both manual and automatic column definitions are supported. Also, the width of the columns of RadGridView can be set. The following two properties are exposed by __GridViewItemsSourceProvider__ for this purpose.

* __AutoGenerateColumns__: A boolean property determining whether the columns will be automatically or manually generated. Its default value is __True__.
* __ColumnWidth__: The value set to it will be applied to all columns of RadGridView.

## Rows Styling

> More info can be found in the [Styling Rows]({%slug gridview-styling-a-row%}) and [RowStyleSelector]({%slug gridview-rowstyleselector%}) topics.

In order to style the rows of __RadGridView__ the __GridViewItemsSourceProvider__ provides the following two mechanisms.

* __RowStyle__: Through it a __Style__ targeting all __GridViewRow__ elements can be defined.
* __RowStyleSelector__: Used in case styling the rows needs to be applied conditionally based on the bound data.

## Keyboard support

> This functionality is covered in details in the [Keyboard Command Provider]({%slug gridview-commands-keyboardcommandprovider%}) topic.

By default, __RadGridView__ will execute a certain command corresponding to a given keyboard scenario. __GridViewItemsSourceProvider__ supports implementing a custom Keyboard Command Provider through the __CustomCommandProvider__ property. Thus, the whole user interaction with the control through the keyboard can be customized.

## Column Headers and Footers

The visibility of the column headers and footers can be controlled through the following boolean properties of __GridViewItemsSourceProvider__. 

* __ShowColumnHeaders__: The default value is __True__ meaning that the column headers will be visible. Setting it to __False__ will hide them.
* __ShowColumnFooters__: The default value is __False__ meaning that the column footers will be hidden. Setting it to __True__ will make them visible.

## IsReadOnly

Since __R1 2019 SP1__, the GridViewItemsSourceProvider exposes the __IsReadOnly__ property through which you can control the __IsReadOnly__ property of the RadGridView control in the dropdown.

## RowIndicatorVisibility

> More information can be found in the [Hiding the Row Indicator]({%slug gridview-customizing-rows%}) topic.

By default the first cell of a row represents row indicator, which appears when the row is set as current. Since __R2 2019__, the __GridViewItemsSourceProvider__ exposes the __RowIndicatorVisibility__ property which controls the visibility of the row indicator.

## ContextMenu

The __ContextMenu__ property of the __GridViewItemsSourceProvider__ allows you to set a custom context menu.

>This feature was introduced in __R2 2019__.

The example below shows how to set the **ContextMenu** property of **GridVIewItemsSourceProvider**:

__Example 1: Set custom context menu__
```XAML
	<Window.Resources>
        <local:MyModel x:Key="MyModel"/>
        <ContextMenu x:Key="contextMenu">
            <MenuItem Header="Menu item 1" />
            <MenuItem Header="Menu item 2" />
            <Separator />
            <MenuItem Header="Menu item 3" />
        </ContextMenu>
    </Window.Resources>
    <Grid DataContext="{StaticResource MyModel}">
        <telerik:RadMultiColumnComboBox VerticalAlignment="Top" OpenDropDownOnFocus="True">
            <telerik:RadMultiColumnComboBox.ItemsSourceProvider>
                <telerik:GridViewItemsSourceProvider ContextMenu="{StaticResource contextMenu}" ItemsSource="{Binding MyObjects}"/>
            </telerik:RadMultiColumnComboBox.ItemsSourceProvider>
        </telerik:RadMultiColumnComboBox>
    </Grid>
```

#### __Figure 1: Result of Example 1__
![RadMultiColumnComboBox with custom context menu](images/MultiColumnComboBox_GridViewItemsSourceProvider_01.png)

## Can User Search In Hidden Columns

Since __R3 2020__, the GridViewItemsSourceProvider exposes the __CanUserSearchInHiddenColumns__ property through which you can control whether the search engine should search in hidden columns.

## Exclude Columns From Search

With the __R3 2020__ version of our controls, you can exclude columns from the built-in search functionality. To exclude a column, you can set the IsSearchable property of the column to false.

__Example 2: Exclude second column from search__
```XAML
	<telerik:RadMultiColumnComboBox>
		<telerik:RadMultiColumnComboBox.ItemsSourceProvider>
			<telerik:GridViewItemsSourceProvider ItemsSource="{Binding MyObjects}" AutoGenerateColumns="false">
				<telerik:GridViewItemsSourceProvider.Columns>
					<telerik:GridViewDataColumn DataMemberBinding="{Binding ID}" />
					<telerik:GridViewDataColumn DataMemberBinding="{Binding FirstName}" IsSearchable="False"  /> 
					<telerik:GridViewDataColumn DataMemberBinding="{Binding LastName}" />                       
				</telerik:GridViewItemsSourceProvider.Columns>
			</telerik:GridViewItemsSourceProvider>
		</telerik:RadMultiColumnComboBox.ItemsSourceProvider>
	</telerik:RadMultiColumnComboBox>
```


## See Also  
* [Getting Started]({%slug multicolumncombobox-getting-started%})
* [DropDown Properties]({%slug multicolumncombobox-dropdown-properties%})
* [Key Properties and Methods]({%slug multicolumncombobox-dropdown-key-properties-and-methods%})
