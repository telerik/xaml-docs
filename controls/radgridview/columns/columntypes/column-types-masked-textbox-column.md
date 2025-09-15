---
title: Masked TextBox Column
page_title: Masked TextBox Column
description: Learn about the properties of the Masked TextBox Column in Telerik's {{ site.framework_name }} DataGrid and how to define it in XAML.
slug: radgridview-columns-column-types-masked-textbox-column
tags: masked,textbox,column
published: False
position: 9
---

# Masked TextBox Column

__GridViewMaskedTextBoxColumn__ derives from [GridViewBoundColumnBase]({%slug radgridview-columns-column-types-boundcolumnbase%}), which means that it inherits all of the functionality too.  In edit mode every field of the column will be represented by a __MaskedTextBox__ control, unless a __CellEditTemplate__ is defined for the column. This allows you to add masks for the inputed data as IP Address, Specific code etc.

For example add a __GridViewMaskedTextBoxColumn__ that represents the OrderNumber for an Order object. The OrderNumber should not be more than 7 symbols. As it allows both text and digits use the __Standard MaskType__ and set "SO#####" as __Mask__.

__Example 1: Define GridViewMaskedTextBoxColumn in XAML:__

```XAML
	!--
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
	        -->
```

## See Also

 * [Masked Input Column]({%slug radgridview-columns-column-types-masked-input-column%})
