---
title: Search As You Type
page_title: Search As You Type
description: Search As You Type
slug: radgridview-search-as-you-type
tags: search-as-you-type
published: True
position: 16
---

# Search As You Type

* [Showing the search panel](#enabling-the-search-panel)


* [Deferred searching](#deferred-searching)

* [Commands](#commands)

* [Modifying the Searching Criteria](#modifying-the-searching-criteria)

As of __Q1 2016 RadGridView__ supports searching. Through the new boolean __ShowSearchPanel__ property of the control, the user can show/hide the search panel. Its default value is __False__. If hidden, the search panel can be shown with the __Ctrl+f__ shortcut.


#### __[XAML]Example 1: Enabling the Search Panel__

	<telerik:RadGridView ItemsSource="{Binding Orders}"     
							 ShowSearchPanel="True"
                             Name="orderItemsDataGrid" Margin="5" 
							 AutoGenerateColumns="False" 
							 ColumnWidth="*"/>

__Figure 1__: Showing the search panel

![](images/gridview-textsearch-showsearchpanel.png)

## Deferred Searching

The deferred searching functionality can be controlled through the __IsSearchingDeferred__ property. Its default value is __“False”__ and it determines whether the filtering through the search text box will be performed dynamically. 

When __IsSearchingDeferred__ is set to __“True”__, the filtering will be executed when the value is being committed on __lost focus/enter__ or __tab key__. 

#### __[XAML]Example 2: Setting the IsSearchingDeferred to True__

	<telerik:RadGridView ItemsSource="{Binding Orders}"
					 IsSearchingDeferred="True"
                     Name="orderItemsDataGrid" 
                     Margin="5" 
                     AutoGenerateColumns="False"/>

## Commands

Two new commands have been exposed for the text search functionality. 

- __Search__: Executed in order to show the search panel.

- __CloseSearchPanel__: Executed in order to hide the search panel.

## Modifying the Searching Criteria

The default searching behavior has two ways of setting the operator of the filtering criteria, depending on the value type of the property over which the search is performed:

- For a __string__ type the operator is set to __Contains__.

- For all other types the operator is set to __IsEqualTo__.

In order to modify the search behavior, you can benefit from the following three search operators:

- __+__: The items that will pass the filtering operation will have to __contain__ both the value __before__ the operator and the one __after__ it.

__Figure 2__: Using the __+__ search operator	![](images/gridview-textsearch-plus-operator.png)

- __-__: All items that will pass the filtering operation will have to  __contain__ the value __before__ the operator, but __not__ the one __after__ it.

__Figure 3__: Using the __-__ search operator	![](images/gridview-textsearch-minus-operator.png)

- __""__: When a word or a phrase is put in quotes, the filtered objects will contain only the exact same value.

__Figure 4__: Using the __""__ search operator	![](images/gridview-textsearch-quotes-operator.png)

# See also


* [Basic Filtering]({%slug gridview-filtering-basic%})

* [Programmatic Filtering]({%slug gridview-filtering-programmatic%})



