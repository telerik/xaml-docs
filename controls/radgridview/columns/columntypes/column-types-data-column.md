---
title: Data Column
page_title: Data Column
description: Data Column
slug: radgridview-columns-column-types-data-column
tags: data,column
publish: True
position: 2
---

# Data Column



## 

The __GridViewDataColumn__ derives from the __GridViewBoundColumnBase__, which means that it inherits all of the functionality too. In addition it allows you to easily bind data, format it and edit it using editors. When the columns of the __RadGridView__ are auto generated they are of this type.

Here it is shown how to define a column of this type.

#### __XAML__

{{region radgridview-columns-column-types-data-column_0}}
	<telerik:RadGridView x:Name="radGridView"
	                         AutoGenerateColumns="False">
	    <telerik:RadGridView.Columns>
	        <telerik:GridViewDataColumn />
	    </telerik:RadGridView.Columns>
	</telerik:RadGridView>
	{{endregion}}



>The columns are to be found in the same namespace as the __RadGridView__ control.

#### __C#__

{{region radgridview-columns-column-types-data-column_1}}
	GridViewDataColumn column = new GridViewDataColumn();
	this.radGridView.Columns.Add( column );
	{{endregion}}



#### __VB.NET__

{{region radgridview-columns-column-types-data-column_2}}
	Dim column As New GridViewDataColumn()
	Me.radGridView.Columns.Add( column )
	{{endregion}}



Via the __DataFormatString__ property you are able to format the bound data and display it the way you want. For example take a look at the following snapshot:

__![](images/RadGridView_ColumnTypes_0.png)__

If you want to learn more about how to format the data via the __DataFormatString__ property visit the [Data Formatting]({%slug gridview-columns-data-formatting%}) topic. 
