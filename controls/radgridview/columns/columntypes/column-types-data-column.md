---
title: Data Column
page_title: Data Column
description: Data Column
slug: radgridview-columns-column-types-data-column
tags: data,column
published: True
position: 2
---

# Data Column

__GridViewDataColumn__ derives from [GridViewBoundColumnBase]({%slug radgridview-columns-column-types-boundcolumnbase%}), which means that it inherits all of the functionality too. In addition it allows you to easily bind data, format it and edit it using editors. 

>RadGridView's auto generated columns are of this type.

#### __[XAML] Example 1: Define GridViewDataColumn in XAML.__

{{region xaml-radgridview-columns-column-types-data-column_0}}

	<telerik:RadGridView x:Name="radGridView"
	                     AutoGenerateColumns="False">
	    <telerik:RadGridView.Columns>
	        <telerik:GridViewDataColumn DataMemberBinding={Binding Id} />
	    </telerik:RadGridView.Columns>
	</telerik:RadGridView>
{{endregion}}

#### __[C#] Example 2: Define GridViewDataColumn in code.__

{{region cs-radgridview-columns-column-types-data-column_1}}

	GridViewDataColumn column = new GridViewDataColumn();
    column.DataMemberBinding = new Binding("Id");
    this.radGridView.Columns.Add(column);
{{endregion}}

>importantFor performance reasons, you should work with __UniqueName__ of GridViewBoundColumnBase only when you have also configured __DataMemberBinding__ for it. Otherwise, please define __GridViewColumn__ and use __Header__ property instead. 

Via the __DataFormatString__ property you are able to format the bound data and display it the way you want. For example take a look at the following snapshot:

__Figure 1__: ![](images/RadGridView_ColumnTypes_0.png)

To learn more about formatting please check [Data Formatting]({%slug gridview-columns-data-formatting%}) topic. 

# See also

* [CellTemplate and CellEditTemplate]({%slug radgridview-columns-celltemplate-and-celledittemplate%})