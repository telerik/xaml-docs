---
title: Image Column
page_title: Image Column
description: Image Column
slug: radgridview-columns-columntypes-image-column
tags: image,column
published: True
position: 8
---

# Image Column

The __GridViewImageColumn__ derives from [GridViewBoundColumnBase]({%slug radgridview-columns-column-types-boundcolumnbase%}), which means that it inherits all of the functionality too. In addition, it allows you to easily configure the image's height, width and stretch.

Here is a list of the most important properties.

* __ImageStretch__ - determines the stretch mode for the images displayed in the column.

* __ImageHeight__ - height of the images displayed in the column.

* __ImageWidth__ - width of the images displayed in the column.

>tipYou can bind GridViewImageColumn to a __string or a byte[] data__ via DataMemberBinding property.

#### __[XAML] Example 1: Define GridViewImageColumn in XAML.__

{{region xaml-radgridview-columns-columntypes-image-column_0}}

	<telerik:RadGridView x:Name="radGridView"
	                     AutoGenerateColumns="False">
	    <telerik:RadGridView.Columns>
	        <telerik:GridViewDataColumn DataMemberBinding="{Binding Name}" />
	        <telerik:GridViewImageColumn DataMemberBinding="{Binding ImageUrl}" ImageStretch="None" />
	    </telerik:RadGridView.Columns>
	</telerik:RadGridView>
{{endregion}}

__Figure 1:__ ![](images/RadGridView_ColumnTypes_6.png)
