---
title: Selection via CheckBox
page_title: Selection via CheckBox
description: Selection via CheckBox
slug: gridview-selection-via-checkbox
tags: selection,via,checkbox
published: True
position: 0
---

# Selection via CheckBox

The __RadGridView__'s API offers you a __GridViewSelectColumn__, with the help of which you can perform a selection via __CheckBox__. The purpose of this tutorial is to show you how to achieve this behavior.

Here is a __RadGridView__ declaration, which is populated with some sample data.

#### __XAML__

{{region xaml-gridview-selection-via-checkbox_0}}
	<telerik:RadGridView x:Name="radGridView"
	                         IsReadOnly="False"
	                         AutoGenerateColumns="False">
	    <telerik:RadGridView.Columns>
	        <telerik:GridViewSelectColumn />
	        <telerik:GridViewDataColumn DataMemberBinding="{Binding Id}"
	                                        Header="ID"/>
	        <telerik:GridViewDataColumn DataMemberBinding="{Binding OrderNO, Mode=TwoWay}"
	                                        Header="Order No">
	        </telerik:GridViewDataColumn>
	        <telerik:GridViewDataColumn DataMemberBinding="{Binding OrderDate, Mode=TwoWay}"
	                                        Header="Order Date">
	        </telerik:GridViewDataColumn>
	        <telerik:GridViewDataColumn DataMemberBinding="{Binding Country, Mode=TwoWay}"
	                                        Header="Country">
	        </telerik:GridViewDataColumn>
	        <telerik:GridViewDataColumn DataMemberBinding="{Binding Shipped, Mode=TwoWay}"
	                                        Header="Shipped?">
	        </telerik:GridViewDataColumn>
	    </telerik:RadGridView.Columns>
	</telerik:RadGridView>
{{endregion}}

The grid is shown on the next figure.

![](images/RadGridView_HowTo_SelectionViaCheckbox_010.png)

In order to enable the selection via checkbox behavior, you need to perform the following instructions:

1. Enable __multiple selection__ for the __RadGridView__.

#### __XAML__

{{region xaml-gridview-selection-via-checkbox_1}}

	<telerik:RadGridView SelectionMode="Extended">
{{endregion}}

2. Add an additional __GridViewColumn__ of type __GridViewSelectColumn__.

#### __XAML__

{{region xaml-gridview-selection-via-checkbox_2}}

	<telerik:RadGridView.Columns>
	    <telerik:GridViewSelectColumn/>
	    .....
	</telerik:RadGridView.Columns>
{{endregion}}

Here is the final result. When you select the CheckBox Header, then all rows will be automatically selected.

![](images/RadGridView_HowTo_SelectionViaCheckbox_020.png)

>tipWhen you want to use selection via checkbox, then:1. Set the __SelectionMode__ property to __Extended__ or __Multiple__. Leaving it to __Single__ you won't be able to select all of the entries in the __RadGridView__.2. Add a __GridViewSelectColumn__.

>tipIf you need further information for the __GridViewSelectColumn__ and all other provided columns take a look at the [this topic]({%slug radgridview-columns-column-types-select-column%}).
