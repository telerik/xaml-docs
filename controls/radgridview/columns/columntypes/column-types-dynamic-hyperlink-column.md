---
title: Dynamic Hyperlink Column
page_title: Dynamic Hyperlink Column
description: Dynamic Hyperlink Column
slug: radgridview-columns-column-types-dynamic-hyperlink-column
tags: dynamic,hyperlink,column
published: True
position: 5
---

# Dynamic Hyperlink Column

__GridViewDynamicHyperlinkColumn__ derives from [GridViewBoundColumnBase]({%slug radgridview-columns-column-types-boundcolumnbase%}) class. Except the binding to the desired property of your business object it allows you to easily specify an URL for the hyperlink that hosts the content.

Here is a list of the most important properties.

* __NavigateUrlMemberPaths__ - name of the property which contains the URL.

* __NavigateUrlFormatString__ - allows you to provide a format string for the value of the URL. That wat you can easily format URLs provided as relative by the business object. To learn more about formating you can check [Data Formatting]({%slug gridview-columns-data-formatting%}) topic. 

* __TargetName__ - specifies the location to open the link.

#### __[XAML] Example 1: Define GridViewDynamicHyperlinkColumn in XAML.__

{{region radgridview-columns-column-types-dynamic-hyperlink-column_0}}

	<telerik:RadGridView x:Name="radGridView"
	                     AutoGenerateColumns="False">
	    <telerik:RadGridView.Columns>
	        <telerik:GridViewDynamicHyperlinkColumn 
				 DataMemberBinding="{Binding Name}"
				 NavigateUrlMemberPaths="TeamUrl"
				 NavigateUrlFormatString="{} http://oficialleaguesite.com/{0}"
				 TargetName="_blank" />
	    </telerik:RadGridView.Columns>
	</telerik:RadGridView>
{{endregion}}

__Figure 1:__ ![](images/RadGridView_ColumnTypes_9.png)
