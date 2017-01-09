---
title: Basic Column
page_title: Basic Column
description: Basic Column
slug: radgridview-columns-column-types-basic-column
tags: basic,column
published: True
position: 0
---

# Basic Column

__GridViewColumn__ is the base column type on top of which the other columns are built. It provides the common functionality typical for __RadGridView's__ columns. 

>{% if site.site_name == 'WPF' %}GridViewColumn inherits from [FrameworkContentElement](https://msdn.microsoft.com/en-us/library/system.windows.frameworkcontentelement%28v=vs.110%29.aspx){% endif %}.{% if site.site_name == 'Silverlight' %}GridViewColumn inherits from [DependencyObject](https://msdn.microsoft.com/fr-fr/library/system.windows.dependencyobject%28v=vs.95%29.aspx). {% endif %}

You can add aggregate functions to display their result in the column footers, manage the headers and cells, apply different styling for the its header and cells, reorder it, etc.  
The most common usage of this type of column is when you want to define a column that doesn't bind to any data. 

>tipSuch a column is frequently referred as “[unbound]({%slug gridview-columns-bound-unbound-columns%})” column. 

A typical usage of such column involves setting the __CellStyle__/__CellTemplate__ properties in order to place custom content within the cells such as buttons, checkboxes or even composite user controls rather than displaying data from the items source. You can check the [Setting CellTemplate and CellEditTemplate]({%slug radgridview-columns-celltemplate-and-celledittemplate%}) article for more information on how to define your own CellTemplate or CellEditTemplate.
        
Here is a list of the most important properties and how they can be used.

* __AggregateFunctions__ - this property allows defining aggregate functions, which results will appear in the column footer. Read more [here]({%slug gridview-columns-aggregate-functions%}).
            
* __CellEditTemplate, CellStyle, CellTemplate__ - by setting these properties you are able to modify the default look of the cells in the columns e.g. to place custom elements in the cell. Read more [here]({%slug gridview-columns-customizing-columns%}).
            
* __Footer, FooterCellStyle, GroupFooterStyle__ - by setting these properties you are able to modify the content and the appearance of the column footers. To learn how read the [Column Footers]({%slug gridview-columns-column-footers%}) topic.
            
* __Header, HeaderCellStyle__ - by setting these properties you can modify the content and the appearance of the column headers. More about the headers can be found in the [Column Headers]({%slug gridview-columns-column-headers%}) topic.
            
* __ToolTipTemplate__ - set to a DataTemplate to be shown when the mouse is over the column. Read more at [Add ToolTip for columns and headers]({%slug gridview-how-to-create-tooltip%}) topic.
            
* __ToolTipTemplateSelector__ - gets or sets the data template selector for the cell tooltip.
            
* __IsFrozen__ - indicates whether the column is frozen or not. To learn more read the [Frozen Columns]({%slug gridview-columns-frozen-columns%}) topic.
          
* __IsGroupable__ - indicates whether the data in the RadGridView can be grouped by this column. More about grouping is to be found [here]({%slug gridview-grouping-basics%}).
            
* __IsReadOnly__ - indicates whether the cells in the column can be edited. More about editing the data in the RadGridView can be found [here]({%slug gridview-managing-data-overview%}).
           
* __IsReordable__ - indicates whether the column can change its place in relation to the other columns in the collection. To learn more read the [Reordering Columns]({%slug gridview-columns-reordering-columns%}) topic.
            
* __IsResizable -__ indicates whether the user is allowed to resize the column. To learn more read the [Resizing Columns]({%slug gridview-columns-resizing-columns%}) topic.
            
* __IsSortable -__ indicates whether the user is allowed to sort by this column. More about sorting the data in the RadGridView can be found [here]({%slug gridview-sorting-basics%}).
            
* __IsFilterable__ - indicates whether the column can be filtered or not and whether the filtering UI (e.g. the funnel) is displayed in the respective header. More about filtering can be found [here]({%slug gridview-filtering-basic%}).
            
* __ShowDistinctFilters__ - indicates whether the user will see the distinct values in the filtering dialog. To learn more read the [Filtering]({%slug gridview-overview-filtering%}) topics.
            
* __ShowFieldFilters__ - indicates whether the user will see the field filters (for manual entering the filter text) in the filtering dialog. To learn more read the [Filtering]({%slug gridview-overview-filtering%}) topics.
            
* __FilterMemberPath__ - Gets or sets the FilterMemberPath for this column. More about Filter Member Path can be found [here]({%slug gridview-filtering-basic%}).
            
* __FilterMemberType__ Gets or sets the filter member type of the column. Set this property when the type cannot be automatically discovered from the FilterMemberPath.
            
* __SortingState__ - provides information about how the data is sorted - ascending, descending or not sorted. More about sorting the data in the __RadGridView__ can be found [here]({%slug gridview-sorting-basics%}).
            
* __GroupMemberPath__ - defines the name of the property the data in the column will be grouped by.
            
* __SortMemberPath__- defines the name of the property the data in the column will be sorted by.
            
* __GroupHeaderFormatString__ - defines the format of the group header.
            
* __ShowColumnWhenGrouped__ - indicates whether the column should be visible when grid is grouped by this column.
            
* __TabStopMode__ - Gets or sets the tab stop mode which denotes if cell could gain focus via TAB key.
            
* __TextDecorations__ - Gets or sets the text decoration. Affects all the cells in the column. This is a dependency property.
            
* __TextTrimming__ - Gets or sets TextTrimming that will be used to trim the text in this column cells. This is a dependency property.
           
* __TextWrapping__ - Gets or sets TextWrapping that will be used to wrap the text in this column cells. This is a dependency property.
            
Here is how to define a column of this type.

#### __[XAML] Example 1: Define GridViewColumn in XAML:__
{{region xaml-radgridview-columns-column-types-basic-column_0}}
	<telerik:RadGridView x:Name="radGridView"
	                 AutoGenerateColumns="False">
	    <telerik:RadGridView.Columns>
	        <telerik:GridViewColumn />
	    </telerik:RadGridView.Columns>
	</telerik:RadGridView>
{{endregion}}
         
#### __[C#] Example 2: Define GridViewColumn in code:__

{{region cs-radgridview-columns-column-types-basic-column_1}}
	GridViewColumn column = new GridViewColumn();
	this.radGridView.Columns.Add(column);
{{endregion}}

#### __[VB.NET] Example 2: Define GridViewColumn in code:__

{{region vb-radgridview-columns-column-types-basic-column_2}}
	Dim column As New GridViewColumn()
	Me.radGridView.Columns.Add(column)
{{endregion}}

>The columns are to be found in the same namespace as __RadGridView__ control.


