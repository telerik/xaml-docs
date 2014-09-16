---
title: Masked TextBox Column
page_title: Masked TextBox Column
description: Masked TextBox Column
slug: radgridview-columns-column-types-masked-textbox-column
tags: masked,textbox,column
published: False
position: 9
---

# Masked TextBox Column



## 

The __GridViewMaskedTextBoxColumn__ derives from the __GridViewBoundColumnBase__, which means that it inherits all of the functionality too.  In edit mode every field of the column will be represented by a __MaskedTextBox__ control, unless a __CellEditTemplate__ is defined for the column. This allows you to add masks for the inputed data as IP Address, Specific code etc.

For example add a __GridViewMaskedTextBoxColumn__ that represents the OrderNumber for an Order object. The OrderNumber should not be more than 7 symbols. As it allows both text and digits use the __Standard____MaskType__ and set "SO#####" as __Mask__.

#### __XAML__

{{region radgridview-columns-column-types-masked-textbox-column_0}}
	<telerik:RadGridView x:Name="radGridView"
	                 AutoGenerateColumns="False">
	    <telerik:RadGridView.Columns>
	        <telerik:GridViewMaskedTextBoxColumn DataMemberBinding="{Binding OrderNO, Mode=TwoWay}"
	                                     Header="Order No."
	                                     UniqueName="OrederNo"
	                                     MaskType="Standard"
	                                     Mask="SO#####"/>
	    </telerik:RadGridView.Columns>
	</telerik:RadGridView>
	{{endregion}}



# See Also

 * [Masked Input Column]({%slug radgridview-columns-column-types-masked-input-column%})
