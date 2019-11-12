---
title: Number of Clicks to Open ComboBox in GridViewComboBoxColumn
page_title: Number of Clicks to Open ComboBox in GridViewComboBoxColumn
description: Check out how you can control the number of clicks needed to change the value of the ComboBox Column within RadGridView - Telerik's {{ site.framework_name }} DataGrid.
slug: gridview-combobox-column-clicks
tags: number,of,clicks,in,combobox,column
published: True
position: 3
---

# Number of Clicks to Open ComboBox in GridViewComboBoxColumn

## PROBLEM

If you have a __GridViewComboBoxColumn__ in your gridview, then by default, you need to click three times in order to show the combobox dropdown. The first click selects the current cell, the second enters edit mode and the last one will open the list.

The following solutions show how to open the dropdown in less steps.

## SOLUTION 1

__2 clicks solution__

By configuring __EditTriggers="CellClick"__ property of GridViewComboBoxColumn the cells will enter edit mode with a single click only. Now you will need one more click to show the drop down and select a value.

## SOLUTION 2

__1 clicks solution__

In addition to configuring __EditTriggers="CellClick"__ property, you can set __OpenDropDownOnFocus__ property of the editor (RadComboBox). To do this, use the __EditorStyle__ property of the column. 

#### __XAML__  
{{region xaml-gridview-combobox-column-clicks_0}}
	<telerik:GridViewComboBoxColumn DataMemberBinding="{Binding ClubID}"
					SelectedValueMemberPath="ID"
					EditTriggers="CellClick"
					DisplayMemberPath="Name"
					ItemsSource="{Binding Clubs}">
	    <telerik:GridViewComboBoxColumn.EditorStyle>
		<Style TargetType="telerik:RadComboBox">
		    <Setter Property="OpenDropDownOnFocus" Value="True"/>
		</Style>
	    </telerik:GridViewComboBoxColumn.EditorStyle>
	</telerik:GridViewComboBoxColumn>
{{endregion}}

>If you're using [Implicit Styles]({%slug styling-apperance-implicit-styles-overview%}), you should base your style on the __RadComboBoxStyle__.

## See Also  
 * [ComboBox Column]({%slug radgridview-columns-column-types-combobox-column%}) 


