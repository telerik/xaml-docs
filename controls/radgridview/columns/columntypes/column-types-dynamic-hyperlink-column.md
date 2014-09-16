---
title: Dynamic Hyperlink Column
page_title: Dynamic Hyperlink Column
description: Dynamic Hyperlink Column
slug: radgridview-columns-column-types-dynamic-hyperlink-column
tags: dynamic,hyperlink,column
publish: True
position: 8
---

# Dynamic Hyperlink Column



## 

The __GridViewDynamicHyperlinkColumn__ derives from the __GridViewBoundColumnBase__class. Except the binding to the desired property of your business object it allows you to easily specify an URL for the hyperlink that hosts the content.

Here is a list of the most important properties.

* __NavigateUrlMemberPaths__ - sets the name of the property which contains the URL.

* __NavigateUrlFormatString__ - allows you to provide a format string for the value of the URL. This allows you to easily format URLs that are provided as relative by the business object. More about Data Formatting can be found [here]({%slug gridview-columns-data-formatting%}).

* __TargetName__ - specifies in which location the link to be opened.

Here is how to define a column of such type.

#### __XAML__

{{region radgridview-columns-column-types-dynamic-hyperlink-column_0}}
	<telerik:RadGridView x:Name="radGridView"
	                         AutoGenerateColumns="False">
	    <telerik:RadGridView.Columns>
	        <telerik:GridViewDynamicHyperlinkColumn DataMemberBinding="{Binding Name}"
	                                 NavigateUrlMemberPaths="TeamUrl"
	                                 NavigateUrlFormatString="{} http://oficialleaguesite.com/{0}"
	                                 TargetName="_blank" />
	    </telerik:RadGridView.Columns>
	</telerik:RadGridView>
	{{endregion}}






         
      ![](images/RadGridView_ColumnTypes_9.png)
