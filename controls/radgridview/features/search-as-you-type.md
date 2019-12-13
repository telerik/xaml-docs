---
title: Search As You Type
page_title: Search As You Type
description: Learn about searching via search panel, deferred search and searching in hidden columns that are all supported by Telerik's {{ site.framework_name }} DataGrid.
slug: radgridview-search-as-you-type
tags: search-as-you-type
published: True
position: 16
---

# Search as You Type

## Showing the Search Panel

As of __R1 2016__, __RadGridView__ supports searching. Through the new boolean __ShowSearchPanel__ property of the control, the user can show/hide the search panel. Its default value is __False__. If hidden, the search panel can be shown with the __Ctrl+F__ shortcut.

>important The default searching behavior has two ways of setting the operator of the filtering criteria, depending on the value type of the property over which the search is performed. For a __string__ and __Enum__ type the operator is set to __Contains__. For all other types the operator is set to __IsEqualTo__.

#### __[XAML] Example 1: Showing the Search Panel__
{{region xaml-radgridview-search-as-you-type-0}}
	<telerik:RadGridView ItemsSource="{Binding Orders}"     
							 ShowSearchPanel="True"
                             Name="orderItemsDataGrid" Margin="5" 
							 AutoGenerateColumns="False" 
							 ColumnWidth="*"/>
{{endregion}}

__Figure 1: Showing the Search Panel__

![Telerik {{ site.framework_name }} DataGrid-textsearch-showsearchpanel](images/gridview-textsearch-showsearchpanel.png)

> Searching over XML data source is available as of __R2 2018__.

>important In case highlighting in a custom column or CellTemplate is needed, the __HightlightTextBlock__ can be used. As of __R3 2018__ its constructor needs to have the __SearchStateManager__ passed as a parameter. It is exposed through the SearchStateManager property of RadGridView. The usage of the __HighlightTextBlock__ is demonstrated in the [Custom Highlight Column](https://github.com/telerik/xaml-sdk/tree/master/GridView/HighlightCustomColumn).

## Disable showing the Search Panel

You can control whether the users can use the **Search Panel** through the **CanUserSearch** boolean property of  **RadGridView**. Its default value is **true**. Setting it to **false** would permanently disable the functionality, meaning that the **Ctrl + F** combination would not show the panel as well.   

#### __[XAML] Example 2: Disabling the Search Panel__
{{region xaml-radgridview-search-as-you-type-1}}
	<telerik:RadGridView ItemsSource="{Binding Orders}"     
							 CanUserSearch="False"
                             Name="orderItemsDataGrid" Margin="5" 
							 AutoGenerateColumns="False" 
							 ColumnWidth="*"/>
{{endregion}}

## Hiding the Close Button

The visibility of the search panel's close button can be controlled via the **SearchPanelCloseButtonVisibility** property. The default value is **Visible** meaning that the search panel can originally be closed via this button.

#### __[XAML] Example 3: Collapse the close button in XAML__
{{region xaml-radgridview-search-as-you-type-2}}
	<telerik:RadGridView SearchPanelCloseButtonVisibility="Collapsed" />
{{endregion}}

#### __[C#] Example 3: Collapse the close button in code-behind__
{{region cs-radgridview-search-as-you-type-3}}
    this.GridView.SearchPanelCloseButtonVisibility = Visibility.Collapsed;
{{endregion}}

#### __[VB.NET] Example 3: Collapse the close button in code-behind__
{{region vb-radgridview-search-as-you-type-3}}
    Me.GridView.SearchPanelCloseButtonVisibility = Visibility.Collapsed
{{endregion}}

__Figure 2: Hidden Close Button__

![Telerik {{ site.framework_name }} DataGrid hide-close-button](images/hide-close-button.png)

## Deferred Searching

The deferred searching functionality can be controlled through the __IsSearchingDeferred__ property. Its default value is __False__ and it determines whether the filtering through the search text box will be performed dynamically. 

When __IsSearchingDeferred__ is set to __True__, the filtering will be executed when the value is being committed on __lost focus__ or when the __Enter__ or __Tab__ key is pressed. 

#### __[XAML] Example 3: Setting the IsSearchingDeferred to True__
{{region xaml-radgridview-search-as-you-type-2}}
	<telerik:RadGridView ItemsSource="{Binding Orders}"
					 IsSearchingDeferred="True"
                     Name="orderItemsDataGrid" 
                     Margin="5" 
                     AutoGenerateColumns="False"/>
{{endregion}}

## Commands

Three new commands have been exposed for the text search functionality. 

- __Search__: Executed in order to show the search panel.

- __SearchByText__: Executed in order to perform an actual search. It takes a string as a parameter - the text to search by.
- __CloseSearchPanel__: Executed in order to hide the search panel.

## Events

As of **R2 2016**, the **SearchPanelVisibilityChanged** event will be raised on changing  the **ShowSearchPanel** property. Its arguments are of type **VisibilityChangedEventArgs** and contain the value of the new visibility - **NewVisibility**.

A common scenario where you can use this event is when you want to clear the search criteria on collapsing the panel:

#### __[C#] Example 4: Clearing search criteria on SearchPanelVisibilityChanged__
{{region cs-radgridview-search-as-you-type-3}}
    private void RadGridView_SearchPanelVisibilityChanged(object sender, VisibilityChangedEventArgs e)
    {
        if (e.NewVisibility == Visibility.Collapsed)
        {
            var clearSearchValue = GridViewSearchPanelCommands.ClearSearchValue as RoutedUICommand;
            clearSearchValue.Execute(null, this.RadGridView.ChildrenOfType<GridViewSearchPanel>().FirstOrDefault());
        }
    }
{{endregion}}

#### __[VB.NET] Example 4: Clearing search criteria on SearchPanelVisibilityChanged__
{{region vb-radgridview-search-as-you-type-4}}
	Private Sub RadGridView_SearchPanelVisibilityChanged(sender As Object, e As VisibilityChangedEventArgs)
		If e.NewVisibility = Visibility.Collapsed Then
			Dim clearSearchValue = TryCast(GridViewSearchPanelCommands.ClearSearchValue, RoutedUICommand)
			clearSearchValue.Execute(Nothing, Me.RadGridView.ChildrenOfType(Of GridViewSearchPanel)().FirstOrDefault())
		End If
	End Sub
{{endregion}}

In **R1 2019**, the **Searching** and **Searched** events were introduced.

The **Searching** event will be raised when the grid data is about to be searched. It's arguments are of type **GridViewSearchingEventsArgs** and contain the value of the text which was entered in the search panel **TextBox** - **SearchText**. They also contain a boolean property which indicates whether the event should be canceled - **Cancel**.

A common scenario for the use of this event is when you want to cancel the search based on a condition:

#### __[C#] Example 5: Stop the searching based on a condition__
{{region cs-radgridview-search-as-you-type-5}}
    private void RadGridView_Searching(object sender, Telerik.Windows.Controls.GridView.GridViewSearchingEventArgs e)
    {
        if (e.SearchText.ToString() == "SomeText")
        {
            e.Cancel = true;
        }
    }
{{endregion}}

The **Searched** event will be raised when the grid data has been searched. It's arguments are of type **GridViewSearchedEventArgs** and contain the value of the text which was entered in the search panel **TextBox** - **SearchText**.

>tipFor more information, refer to the [Overview]({%slug gridview-events-overview%}) article.

## Modifying the Searching Criteria

In order to modify the search behavior, you can benefit from the following three search operators:

- __+__: The items that will pass the filtering operation will have to __contain__ both the value __before__ the operator and the one __after__ it.

	__Figure 2: Using the `+` search operator__
	
	![Telerik {{ site.framework_name }} DataGrid-textsearch-plus-operator](images/gridview-textsearch-plus-operator.png)

- __-__: All items that will pass the filtering operation will have to  __contain__ the value __before__ the operator, but __not__ the one __after__ it.

	__Figure 3: Using the `-` search operator__
	
	![Telerik {{ site.framework_name }} DataGrid-textsearch-minus-operator](images/gridview-textsearch-minus-operator.png)

- __""__: When a word or a phrase is put in quotes, the filtered objects will contain only the exact same value.
	
	__Figure 4: Using the `""` search operator__
	
	![Telerik {{ site.framework_name }} DataGrid-textsearch-quotes-operator](images/gridview-textsearch-quotes-operator.png)


## SearchMode

With **R2 2019** we introduced a new **SearchMode** property which allows you to control how items are matched when search is executed. It has the following two possible values:

* **MatchAnyTerm**: Items match the search operation when they fulfill any of the search terms. For example, if `John Terry` is inputted in the search panel, items containing **any** of the terms "John" and "Terry" in any of their properties will be matched. This is the **default** value.
* **MatchAllTerms**: Items match the search operation only when they fulfill all of the search terms. Continuing with the previous example, if `John Terry` is entered as the search text, only items which contain **both** terms ("John" and "Terry") in any of their properties will be matched.

## Change the Label Text of the Search Panel

By default, the value of the __TextBlock__ appearing before the __Search TextBox__ in the __SearchPanel__ is "__Full Text Search"__. It can be altered through the __Localization__ mechanism of __RadGridView__. The resource key that needs to be modified is __GridViewSearchPanelTopText__. More information can be found in the [Localization]({%slug gridview-localization2%}) topic.

## Add Search Criteria Programmatically 

__RadGridView's__ search mechanism supports defining a search criteria programmatically. This can be done through the __SearchByText__ Command. More information can be found in the [Commands Overview]({%slug gridview-commands-overview%}) topic. 


## Search Over Dynamic Data

As of __R2 2018 RadGridView__ provides full support for searching over dynamic data. This includes __IDynamicMetaObjectProvider__(DynamicObject and ExpandoObject), __ICustomTypeProvider__ and __ICustomTypeDescriptor__ implementations.

## Search in Hidden Columns

RadGridView's text search mechanism supports searching in hidden columns. This behavior can be enabled by setting the __CanUserSearchInHiddenColumns__ property of the RadGridView control to __True__.

>important This feature was first introduced with the non-official version __2017.3.1127__ of __R3 2017__. Afterwards, it was included in __R1 2018__ official release of the __Telerik UI for WPF__ suite.

#### __[XAML] Example 6: Setting CanUserSearchInHiddenColumns property in XAML__
{{region xaml-radgridview-search-as-you-type-6}}
	<telerik:RadGridView CanUserSearchInHiddenColumns="True"/>
{{endregion}}

## See Also
* [Basic Filtering]({%slug gridview-filtering-basic%})
* [Programmatic Filtering]({%slug gridview-filtering-programmatic%})
* [Commands]({%slug gridview-commands-overview%})
