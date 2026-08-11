---
title: Styling Search Panel
page_title: Styling Search Panel
description: Get started with Telerik's {{ site.framework_name }} DataGrid and learn how to create an appropriate style targeting the SearchPanel element.
slug: gridview-styling-search-panel
tags: styling,search,panel
published: True
position: 24
---

# Styling Search Panel

>Before reading this topic, you might find it useful to get familiar with RadGridView's [Search As You Type]({%slug radgridview-search-as-you-type%}) functionality.

You can style the SearchPanel within the `RadGridView` control by creating an appropriate Style that targets the `GridViewSearchPanel` element.
 
You have two options:

* To create an empty style and set it up on your own.

* To copy the default style of the control and modify it.

>tip If you choose to define the style in the resources of the application, it would be available for the entire application. This allows you to define a style only once and then reuse it where needed.

You can apply a style to the Search Panel, similar to Example 1:

__Applying a style to the search panel of RadGridView__
<snippet id='radgridview-styles-and-templates-styling-search-panel-applying_a_style_to_the_search_panel_of_radgridview-xaml' />


__Appearance of the control after the style is applied__

![Telerik UI for {{ site.framework_name }} RadGridView with a styled search panel](images/search-panel-styled.PNG)

## Change the Color of the Highlighted Text 

By default, the symbols matching the searching criteria are colored in red. You can easily change the highlighted text value to green by changing the value of the `HightlightBrush` in the `HighlightTextBlock`, as shown in the following example:

__Change the HighlightBrush of the HighlightTextBlock__
<snippet id='radgridview-styles-and-templates-styling-search-panel-change_the_highlightbrush_of_the_highlighttextblock-xaml' />


__Appearance of the highlighted text after the style is applied__

![Telerik UI for {{ site.framework_name }} RadGridView search panel with a custom highlight color for matched text](images/search-panel-highlight-color.png)

## Change the Background Color of the Highlighted Cell

Through the `HighlightedBackground` property you can modify the background color of the matched `GridViewCell` element when a search as you type is performed. This property is exposed by the GridViewCell class and it is of type `Brush`.

__Set the HighlightedBackground property of the GridViewCell__
<snippet id='radgridview-styles-and-templates-styling-search-panel-set_the_highlightedbackground_property_of_the_gridviewcell-xaml' />


__Appearance of the background color of the highlighted GridViewCell elements__

![Telerik UI for {{ site.framework_name }} RadGridView with a custom highlighted background for search-matched cells](images/search-panel-highlight-cell-background-color.png)

## See Also
 * [Styling the GridViewEditorPresenter]({%slug gridview-styling-editorpresenter%})
 * [Styling the Column Footers]({%slug gridview-styling-column-footers%})
 * [Styling the Column Headers]({%slug gridview-styling-column-headers%})
 * [Change Background for Disabled Grid Elements]({%slug gridview-how-to-set-background-disabled-cell%})
