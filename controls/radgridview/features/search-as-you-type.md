---
title: Search As You Type
page_title: Search As You Type
description: Search As You Type
slug: radgridview-search-as-you-type
tags: search-as-you-type
published: True
position: 16
---

# Search as You Type

* [Showing the Search Panel](#showing-the-search-panel)

* [Disabling the 'Search as You Type' functionality](#disable-showing-the-search-panel)

* [Deferred Searching](#deferred-searching)

* [Commands](#commands)

* [Events](#events)

* [Modifying the Searching Criteria](#modifying-the-searching-criteria)

* [Change the Label Text of the Search Panel](#change-the-label-text-of-the-search-panel)

* [Add Search Criteria Programmatically](#add-search-criteria-programmatically)

## Showing the Search Panel

As of __R1 2016__, __RadGridView__ supports searching. Through the new boolean __ShowSearchPanel__ property of the control, the user can show/hide the search panel. Its default value is __False__. If hidden, the search panel can be shown with the __Ctrl+F__ shortcut.

>important The default searching behavior has two ways of setting the operator of the filtering criteria, depending on the value type of the property over which the search is performed. For a __string__ type the operator is set to __Contains__. For all other types the operator is set to __IsEqualTo__.

#### __[XAML] Example 1: Showing the Search Panel__
{{region radgridview-search-as-you-type-0}}
	<telerik:RadGridView ItemsSource="{Binding Orders}"     
							 ShowSearchPanel="True"
                             Name="orderItemsDataGrid" Margin="5" 
							 AutoGenerateColumns="False" 
							 ColumnWidth="*"/>
{{endregion}}

__Figure 1: Showing the Search Panel__

![Showing the Search Panel](images/gridview-textsearch-showsearchpanel.png)

## Disable showing the Search Panel

You can control whether the users can use the **Search Panel** through the **CanUserSearch** boolean property of  **RadGridView**. Its default value is **true**. Setting it to **false** would permanently disable the functionality, meaning that the **Ctrl + F** combination would not show the panel as well.   

#### __[XAML] Example 2: Disabling the Search Panel__
{{region radgridview-search-as-you-type-1}}
	<telerik:RadGridView ItemsSource="{Binding Orders}"     
							 CanUserSearch="False"
                             Name="orderItemsDataGrid" Margin="5" 
							 AutoGenerateColumns="False" 
							 ColumnWidth="*"/>
{{endregion}}

## Deferred Searching

The deferred searching functionality can be controlled through the __IsSearchingDeferred__ property. Its default value is __False__ and it determines whether the filtering through the search text box will be performed dynamically. 

When __IsSearchingDeferred__ is set to __True__, the filtering will be executed when the value is being committed on __lost focus__ or when the __Enter__ or __Tab__ key is pressed. 

#### __[XAML] Example 3: Setting the IsSearchingDeferred to True__
{{region radgridview-search-as-you-type-2}}
	<telerik:RadGridView ItemsSource="{Binding Orders}"
					 IsSearchingDeferred="True"
                     Name="orderItemsDataGrid" 
                     Margin="5" 
                     AutoGenerateColumns="False"/>
{{endregion}}

## Commands

Two new commands have been exposed for the text search functionality. 

- __Search__: Executed in order to show the search panel.

- __CloseSearchPanel__: Executed in order to hide the search panel.

## Events

As of **R2 2016**, the **SearchPanelVisibilityChanged** event will be raised on changing  the **ShowSearchPanel** property. Its arguments are of type **VisibilityChangedEventArgs** and contain the value of the new visibility - **NewVisibility**.

A common scenario where you can use this event is when you want to clear the search criteria on collapsing the panel:

#### __[C#] Example 4: Clearing search criteria on SearchPanelVisibilityChanged__
{{region radgridview-search-as-you-type-3}}
	public MainWindow()
    {
        InitializeComponent();
        this.RadGridView.SearchPanelVisibilityChanged += RadGridView_SearchPanelVisibilityChanged;
    }

    void RadGridView_SearchPanelVisibilityChanged(object sender, VisibilityChangedEventArgs e)
    {
        if (e.NewVisibility == Visibility.Collapsed)
        {
            var clearSearchValue = GridViewSearchPanelCommands.ClearSearchValue as RoutedUICommand;
            clearSearchValue.Execute(null, this.RadGridView.ChildrenOfType<GridViewSearchPanel>().FirstOrDefault());
        }
    }
{{endregion}}

#### __[VB.NET] Example 4: Clearing search criteria on SearchPanelVisibilityChanged__
{{region radgridview-search-as-you-type-4}}
	Public Sub New()
		InitializeComponent()
		AddHandler Me.RadGridView.SearchPanelVisibilityChanged, AddressOf RadGridView_SearchPanelVisibilityChanged
	End Sub
	
	Private Sub RadGridView_SearchPanelVisibilityChanged(sender As Object, e As VisibilityChangedEventArgs)
		If e.NewVisibility = Visibility.Collapsed Then
			Dim clearSearchValue = TryCast(GridViewSearchPanelCommands.ClearSearchValue, RoutedUICommand)
			clearSearchValue.Execute(Nothing, Me.RadGridView.ChildrenOfType(Of GridViewSearchPanel)().FirstOrDefault())
		End If
	End Sub
{{endregion}}

## Modifying the Searching Criteria

In order to modify the search behavior, you can benefit from the following three search operators:

- __+__: The items that will pass the filtering operation will have to __contain__ both the value __before__ the operator and the one __after__ it.

	__Figure 2: Using the __+__ search operator__
	
	![Using the + search operator](images/gridview-textsearch-plus-operator.png)

- __-__: All items that will pass the filtering operation will have to  __contain__ the value __before__ the operator, but __not__ the one __after__ it.

	__Figure 3: Using the __-__ search operator__
	
	![Using the - search operator](images/gridview-textsearch-minus-operator.png)

- __""__: When a word or a phrase is put in quotes, the filtered objects will contain only the exact same value.
	
	__Figure 4: Using the *""* search operator__
	
	![Using the "" search operator](images/gridview-textsearch-quotes-operator.png)

## Change the Label Text of the Search Panel

By default, the value of the __TextBlock__ appearing before the __Search TextBox__ in the __SearchPanel__ is "__Full Text Search"__. It can be altered through the __Localization__ mechanism of __RadGridView__. The resource key that needs to be modified is __GridViewSearchPanelTopText__. More information can be found in the [Localization]({%slug gridview-localization2%}) topic.

## Add Search Criteria Programmatically 

__RadGridView's__ search mechanism supports defining a search criteria programmatically. This can be done through the __SearchByText__ Command. More information can be found in the [Commands Overview]({%slug gridview-commands-overview%}) topic. 

## See Also
* [Basic Filtering]({%slug gridview-filtering-basic%})
* [Programmatic Filtering]({%slug gridview-filtering-programmatic%})
* [Commands]({%slug gridview-commands-overview%})