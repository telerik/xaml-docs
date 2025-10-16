---
title: Dynamic Hyperlink Column
page_title: Dynamic Hyperlink Column
description: Check out the properties of the Dynamic Hyperlink Column in Telerik's {{ site.framework_name }} DataGrid and see how you can specify a URL for the hyperlink that hosts the content.
slug: radgridview-columns-column-types-dynamic-hyperlink-column
tags: dynamic,hyperlink,column
published: True
position: 5
---

# Dynamic Hyperlink Column

__GridViewDynamicHyperlinkColumn__ derives from [GridViewBoundColumnBase]({%slug radgridview-columns-column-types-boundcolumnbase%}) class. Except the binding to the desired property of your business object it allows you to easily build a URL for the hyperlink that hosts the content.

## GridViewDynamicHyperlinkColumn vs GridViewHyperlinkColumn

The advantage of the GridViewDynamicHyperlinkColumn over the [GridViewHyperlinkColumn]({%slug radgridview-columns-column-types-hyperlink-column%}) is that it allows you to build a Uri by combining the values of several properties of your business object. If you have the entire Uri that you want to navigate to in a single property, you can use a GridViewHyperlinkColumn.

## Properties

Here is a list of the most important properties:

* __DataMemberBinding__: Allows you to specify the property of the business object to be displayed as value in the cell. It is automatically displayed as a link.

* __NavigateUrlMemberPaths__: Comma separated property names, the values of which will be inserted at the placeholder positions defined in the __NavigateUrlFormatString__.

* __NavigateUrlFormatString__: Allows you to provide a format string for the value of the URL.  
 
>To learn more about formatting you can check [Data Formatting]({%slug gridview-columns-data-formatting%}) topic. 

* __TargetName__: Specifies the location to open the link.

__Example 1: Define GridViewDynamicHyperlinkColumn in XAML.__
```XAML
	<telerik:RadGridView x:Name="radGridView"
	                 AutoGenerateColumns="False">
	    <telerik:RadGridView.Columns>
			<!-- The value of the MiddleUrlPart property will go to the {0} placeholder and the value of the EndUrlPart will go to the {1} placeholder-->
	        <telerik:GridViewDynamicHyperlinkColumn DataMemberBinding="{Binding Name}"
	                         NavigateUrlMemberPaths="MiddleUrlPart, EndUrlPart"
	                         NavigateUrlFormatString="{} http://oficialleaguesite.com/{0}/{1}"
	                         TargetName="_blank" />
	    </telerik:RadGridView.Columns>
	</telerik:RadGridView>
```

You can also directly configure the navigate url to be a complete one and specify an empty format as demonstrated in __Example 2__, though in such a scenario it would be easier to use a [GridViewHyperlinkColumn]({%slug radgridview-columns-column-types-hyperlink-column%}).

__Example 2: Define navigate url without additional format.__
```XAML
	<telerik:GridViewDynamicHyperlinkColumn 
	 DataMemberBinding="{Binding Name}"
	 NavigateUrlMemberPaths="TeamUrl"
	 NavigateUrlFormatString="{} {0}"
	 TargetName="_blank" />
```  

__Figure 1: GridViewDynamicHyperlinkColumn in RadGridView__ 

![Dynamic Hyperlink Column in RadGridView - Telerik's {{ site.framework_name }} DataGrid](images/RadGridView_ColumnTypes_9.png)

>tip In order to handle the __Click__ event of the hyperlink, you can use the approach demonstrated in the [GridViewHyperlinkColumn Click Event]({%slug gridview-hyperlink-column-click-event%}) article.

## See also
* [Hyperlink Column]({%slug radgridview-columns-column-types-hyperlink-column%})
* [CellTemplate and CellEditTemplate]({%slug radgridview-columns-celltemplate-and-celledittemplate%})