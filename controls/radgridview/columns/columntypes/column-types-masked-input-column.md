---
title: Masked Input Column
page_title: Masked Input Column
description: Masked Input Column
slug: radgridview-columns-column-types-masked-input-column
tags: masked,input,column
published: True
position: 9
---

# Masked Input Column

__GridViewMaskedInputColumn__ derives from [GridViewBoundColumnBase]({%slug radgridview-columns-column-types-boundcolumnbase%}), which means that it inherits all of the functionality too. In edit mode every field of the column will be represented by a [RadMaskedInput]({%slug radmaskedinput-overview%}) control depending on what __MaskType__ is set, unless a __CellEditTemplate__ is defined for the column.
       
This is a list with short descriptions of the editors which will be created based on MaskType property setting:
        
* __MaskType="Standard"__ - __RadMaskedTextInput__ control, it supports restriction of the user input to customized text formats. [Read more ]({%slug radmaskedinput-features-controls-text%})

* __MaskType="DateTime"__ - __RadMaskedDateTimeInput__ control, it ensures that the date entered by the user is verified and accurate. [Read more ]({%slug radmaskedinput-features-controls-datetime%})

* __MaskType="Numeric"__ - __RadMaskedNumericInput__ control, it supports restricting the user input to decimal, fixed-point, percent and currency values, where currency values are also culture sensitive. [Read more ]({%slug radmaskedinput-features-controls-numeric%})

* __MaskType="Currency"__ -__RadMaskedCurrencyInput__ control, it allows broad customization of culture-aware currency values. [Read more]({%slug radmaskedinput-features-controls-currency%})

For example add a __GridViewMaskedInputColumn__ that represents the OrderNumber for an Order object. The OrderNumber should not be more than 7 symbols. As it allows both text and digits use __Standard MaskType__ and set "SO#####" as __Mask__.
        

#### __[XAML]Example 1: Define GridViewMaskedInputColumn in XAML:__

{{region radgridview-columns-column-types-masked-input-column_0}}

	<telerik:RadGridView x:Name="radGridView"
	         AutoGenerateColumns="False">
	    <telerik:RadGridView.Columns>
	        <telerik:GridViewMaskedInputColumn 
				DataMemberBinding="{Binding OrderNO}" 
				Header="Order No."
				UniqueName="OrederNo"
				MaskType="Standard"
				Mask="SO#####"/>
	    </telerik:RadGridView.Columns>
	</telerik:RadGridView>
{{endregion}}

# See Also
* [RadMaskedInput Overview]({%slug radmaskedinput-overview%})
* [How to migrate from RadMaskedTextBox to RadMaskedInput]({%slug radmaskedinput-migrating%})
