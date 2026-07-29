---
title: Search As You Type
page_title: Search As You Type
description: Learn about searching via search panel, deferred search and searching in hidden columns that are all supported by Telerik's WPF DataGrid.
slug: radgridview-search-as-you-type
tags: search-as-you-type
published: True
position: 16
---

# Search as You Type

`RadGridView` control allows you to perform search operations on the displayed data.

## Show the Search Panel

Through the new boolean `ShowSearchPanel` property of the control, the user can show/hide the search panel. Its default value is `false`. If hidden, the search panel can be shown with the __Ctrl__+__F__ shortcut.

>important The default searching behavior has two ways of setting the operator of the filtering criteria, depending on the value type of the property over which the search is performed. For a `string` and `Enum` type the operator is set to `Contains`. For all other types the operator is set to `IsEqualTo`.

__Showing the Search Panel__
<snippet id='radgridview-features-search-as-you-type-showing_the_search_panel-xaml' />


__Showing the Search Panel__

![Telerik UI for WPF RadGridView search panel displayed above the grid for text search](images/gridview-textsearch-showsearchpanel.png)

>important In case highlighting in a custom column or CellTemplate is needed, the `HightlightTextBlock` can be used. Its constructor needs to have the `SearchStateManager` passed as a parameter. It is exposed through the SearchStateManager property of RadGridView. The usage of the HighlightTextBlock is demonstrated in the [Custom Highlight Column](https://github.com/telerik/xaml-sdk/tree/master/GridView/HighlightCustomColumn).

## Disable Showing the Search Panel

You can control whether the users can use the search panel through the `CanUserSearch` boolean property of RadGridView. Its default value is `true`. Setting it to `false` would permanently disable the functionality, meaning that the __Ctrl__+__F__ combination would not show the panel as well.   

__Disabling the Search Panel__
<snippet id='radgridview-features-search-as-you-type-disabling_the_search_panel-xaml' />


## Search Panel's Close Button's Visibility

The visibility of the search panel's close button can be controlled via the `SearchPanelCloseButtonVisibility` property. The default value is `Visible` meaning that the search panel can originally be closed via this button.

__Collapse the close button in XAML__
<snippet id='radgridview-features-search-as-you-type-collapse_the_close_button_in_xaml-xaml' />


__Collapse the close button in code-behind__
<snippet id='radgridview-features-search-as-you-type-collapse_the_close_button_in_code_behind-cs' />

<snippet id='radgridview-features-search-as-you-type-collapse_the_close_button_in_code_behind-vb' />


__Collapsed Close Button__

![Telerik UI for WPF RadGridView search panel with the close button collapsed](images/hide-close-button.png)

## Deferred Searching

The deferred searching functionality can be controlled through the `IsSearchingDeferred` property. Its default value is `false` and it determines whether the filtering through the search text box will be performed dynamically. 

When `IsSearchingDeferred` is set to `true`, the filtering will be executed when the value is being committed on __lost focus__ or when the __Enter__ or __Tab__ key is pressed. 

__Setting the IsSearchingDeferred to True__
<snippet id='radgridview-features-search-as-you-type-setting_the_issearchingdeferred_to_true-xaml' />


## Commands

Three new commands have been exposed for the text search functionality, via the `RadGridViewCommands` class. 

- `Search`&mdash;Executed in order to show the search panel.
- `SearchByText`&mdash;Executed in order to perform an actual search. It takes a `string` as a parameter - the text to search by.
- `CloseSearchPanel`&mdash;Executed in order to hide the search panel.

__Executing the search commands in code__
<snippet id='radgridview-features-search-as-you-type-executing_the_search_commands_in_code-cs' />


## Events

RadGridView provides several events related to the search-as-you-type functionality:

The `SearchPanelVisibilityChanged` event will be raised on changing  the `ShowSearchPanel` property. Its arguments are of type `VisibilityChangedEventArgs` and contain the value of the new visibility - `NewVisibility`.

A common scenario where you can use this event is when you want to clear the search criteria on collapsing the panel:

__Clearing search criteria on SearchPanelVisibilityChanged__
<snippet id='radgridview-features-search-as-you-type-clearing_search_criteria_on_searchpanelvisibilitychanged-cs' />

<snippet id='radgridview-features-search-as-you-type-clearing_search_criteria_on_searchpanelvisibilitychanged-vb' />


The `Searching` event will be raised when the grid data is about to be searched. It's arguments are of type `GridViewSearchingEventsArgs` and contain the value of the text which was entered in the search panel `TextBox` - `SearchText`. They also contain a boolean property which indicates whether the event should be canceled - `Cancel`.

A common scenario for the use of this event is when you want to cancel the search based on a condition:

__Stop the searching based on a condition__
<snippet id='radgridview-features-search-as-you-type-stop_the_searching_based_on_a_condition-cs' />


The `Searched` event will be raised when the grid data has been searched. It's arguments are of type `GridViewSearchedEventArgs` and contain the value of the text which was entered in the search panel `TextBox` - `SearchText`.

>tip For more information, refer to the [Overview]({%slug gridview-events-overview%}) article.

## Modify the Searching Criteria

In order to modify the search behavior, you can benefit from the following three search operators:

- __+__&mdash;The items that will pass the filtering operation will have to __contain__ both the value __before__ the operator and the one __after__ it.

	__Using the `+` search operator__
	
	![Telerik UI for WPF RadGridView search results using the plus operator to require both terms](images/gridview-textsearch-plus-operator.png)

- __-__&mdash;All items that will pass the filtering operation will have to  __contain__ the value __before__ the operator, but __not__ the one __after__ it.

	__Using the `-` search operator__
	
	![Telerik UI for WPF RadGridView search results using the minus operator to exclude a term](images/gridview-textsearch-minus-operator.png)

- __""__&mdash;When a word or a phrase is put in quotes, the filtered objects will contain only the exact same value.
	
	__Using the `""` search operator__
	
	![Telerik UI for WPF RadGridView search results using quotation marks for an exact phrase match](images/gridview-textsearch-quotes-operator.png)

## SearchMode

The RadGridView control exposes the `SearchMode` property which allows you to control how items are matched when search is executed. It has the following two possible values:

* `MatchAnyTerm`: Items match the search operation when they fulfill any of the search terms. For example, if `John Terry` is inputted in the search panel, items containing __any__ of the terms "John" and "Terry" in any of their properties will be matched. This is the default value.

* `MatchAllTerms`: Items match the search operation only when they fulfill all of the search terms. Continuing with the previous example, if `John Terry` is entered as the search text, only items which contain __both__ terms ("John" and "Terry") in any of their properties will be matched.

* `MatchExact`: Items match the search operation only when they exactly match the search text.

## Change the Label Text of the Search Panel

By default, the value of the `TextBlock` appearing before the search `TextBox` in the search panel is __"Full Text Search"__. It can be altered through the localization mechanism of `RadGridView`. The resource key that needs to be modified is __GridViewSearchPanelTopText__. More information can be found in the [Localization]({%slug gridview-localization2%}) topic.

## Add Search Criteria Programmatically 

RadGridView's search mechanism supports defining a search criteria programmatically. This can be done through the `SearchByText` command. More information can be found in the [Commands Overview]({%slug gridview-commands-overview%}) topic. 

## Search Over Dynamic Data

RadGridView provides full support for searching over dynamic data. This includes `IDynamicMetaObjectProvider`(`DynamicObject` and `ExpandoObject`), `ICustomTypeProvider`, and `ICustomTypeDescriptor` implementations.

## Search in Hidden Columns

RadGridView's text search mechanism supports searching in hidden columns. This behavior can be enabled by setting the `CanUserSearchInHiddenColumns` property of the RadGridView control to `true`.

__Setting CanUserSearchInHiddenColumns property in XAML__
<snippet id='radgridview-features-search-as-you-type-setting_canusersearchinhiddencolumns_property_in_xaml-xaml' />


## Search With Accent Insensitive

The `SearchStateManager` property of RadGridView exposes the `IsSearchWithAccentEnabled` property, which allows you to search with accent insensitive. This behavior is turned off by default. To enable this functionality you can subscribe to the Loaded event of the RadGridView. In the event handler, you can set this property to `true`. 

__Setting IsSearchWithAccentEnabled property__
<snippet id='radgridview-features-search-as-you-type-setting_issearchwithaccentenabled_property-cs' />


__Using Search With Accent Insensitive__

![Telerik UI for WPF RadGridView search-as-you-type with accent-insensitive matching enabled](images/radgridview-search-asyoutype-accent.PNG)

## Exclude Column from Search

The `GridViewBoundColumnBase` provides an option to exclude it from the search mechanism. To achieve this, you can use its `IsSearchable` property. The default value of this property is __True__, which means that the column will be included in the search operation. To exclude a column from this operation, set the IsSearchable property to __False__.

__Excluding a column from the search mechanism__
<snippet id='radgridview-features-search-as-you-type-excluding_a_column_from_the_search_mechanism-xaml' />


__RadGridView with an excluded column from the search mechanism__

![Telerik UI for WPF RadGridView search-as-you-type with one column excluded from the search mechanism](images/radgridview-search-as-you-type-exclude-column.png)

## Disable the Data Filtering when Searching

The RadGridView control exposes the `IsSearchFilteringEnabled` option. It will allow you to control whether the data will be filtered when a search operation is performed. The default value of the IsSeachFilteringEnabled property is set to __True__, which will filter the data. When the data filtering is disabled, search operations will only highlight the cells that match the search criteria.	

__Disabling the data filtering when performing search__
<snippet id='radgridview-features-search-as-you-type-disabling_the_data_filtering_when_performing_search-cs' />


## See Also
* [Basic Filtering]({%slug gridview-filtering-basic%})
* [Programmatic Filtering]({%slug gridview-filtering-programmatic%})
* [Commands]({%slug gridview-commands-overview%})
