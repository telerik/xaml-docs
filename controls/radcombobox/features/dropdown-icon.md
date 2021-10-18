---
title: Drop-Down Button Icon
page_title: Drop-Down Button Icon
description: Modifying the drop-down button icon of the RadComboBox control.
slug: radcombobox-features-dropdown-icon
tags: dropdown button icon, combobox button icon
published: True
position: 10
---

# Drop-Down Button Icon

The __DropDownButtonIconContent__ and the __DropDownButtonIconContentTemplate__ properties allows you to customize the drop-down button icon of the __RadComboBox__ control.

* __DropDownButtonIconContent__: gets or sets the content of the show dialog button.
	
* __DropDownButtonIconContentTemplate__: gets or sets the content template of the show dialog button.

## Using RadGlyphs
	
The __DropDownButtonIconContent__ and __DropDownButtonIconContentTemplate__ properties are fully compatible with our [RadGlyph]({%slug common-styling-appearance-radglyph%}) control. The following example shows how to set a RadGlyph as a drop-down button icon. 

#### __[XAML] Example 1: Setting a RadGlyph as Drop-Down Button Icon
{{region radcombobox-features-dropdown-icon-0}}
	<telerik:RadComboBox Width="100" Height="30">
		<telerik:RadComboBox.DropDownButtonIconContent>
			<telerik:RadGlyph Glyph="{StaticResource GlyphArrowsKpi}"/>
		</telerik:RadComboBox.DropDownButtonIconContent>
		<telerik:RadComboBox.DropDownButtonIconTemplate>
			<DataTemplate>
					<telerik:RadGlyph Glyph="{Binding}" HorizontalAlignment="Center" VerticalAlignment="Center"/>
			</DataTemplate>
		</telerik:RadComboBox.DropDownButtonIconTemplate>
		<telerik:RadComboBoxItem Content="Item 1" />
		<telerik:RadComboBoxItem Content="Item 2" />
	</telerik:RadComboBox>	
{{endregion}}

#### Figure 1: Result of Example 1
![](images/radcombobox-features-dropdown-button-icon-0.png)

## See Also
 * [Selection Box Template]({%slug radcombobox-populating-with-data-selectionbox%})