---
title: Select Column
page_title: Select Column
description: Select Column
slug: radgridview-columns-column-types-select-column
tags: select,column
published: True
position: 11
---

# Select Column

__GridViewSelectColumn__ derives from [GridViewColumn]({%slug radgridview-columns-column-types-basic-column%}) class and its content is represented by a CheckBox for each row. The difference between it and __GridViewCheckBoxColumn__ is that this one is not meant to bind to data. Instead, it allows you to select the row via the CheckBox in it, i.e. each CheckBox's IsChecked property is bound to the IsSelected property of the corresponding row.

#### __[XAML] Example 1: Define GridViewSelectColumn in XAML.__

{{region radgridview-columns-column-types-select-column_0}}

	<telerik:RadGridView x:Name="radGridView"
	                     AutoGenerateColumns="False">
	    <telerik:RadGridView.Columns>
	        <telerik:GridViewSelectColumn />
	        <telerik:GridViewDataColumn DataMemberBinding="{Binding Name}" />
	    </telerik:RadGridView.Columns>
	</telerik:RadGridView>
{{endregion}}

![](images/RadGridView_ColumnTypes_7.png)

If you set __RadGridView.SelectionMode__ property to either __Extended__ or __Multiple__, you will be able to select more than one row by clicking on the desired check box or to select all the rows by clicking on the check box in the header.

#### __[XAML] Example 2: Define GridViewDataColumn with Extended SelectedMode.__

{{region radgridview-columns-column-types-select-column_1}}

	<telerik:RadGridView x:Name="radGridView"
	                     AutoGenerateColumns="False"
	                     SelectionMode="Extended">
	    <telerik:RadGridView.Columns>
	        <telerik:GridViewSelectColumn />
	        <telerik:GridViewDataColumn DataMemberBinding="{Binding Name}" />
	    </telerik:RadGridView.Columns>
	</telerik:RadGridView>
{{endregion}}

![](images/RadGridView_ColumnTypes_8.png)

>You may directly work with the SelectedItems collection of RadGridView.

# See Also

 * [CheckBox Column]({%slug gridview-checkbox-column-clicks%}) 

