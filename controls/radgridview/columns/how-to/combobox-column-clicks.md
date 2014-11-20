---
title: Number of clicks in the ComboBox column
page_title: Number of clicks in the ComboBox column
description: Number of clicks in the ComboBox column
slug: gridview-combobox-column-clicks
tags: number,of,clicks,in,the,combobox,column
published: True
position: 7
---

# Number of clicks in the ComboBox column

__PROBLEM__

If you have a __GridViewComboBoxColumn__ in your gridview, then by default, you need to click three times in order to show the dropdown - the first two clicks will enter the edit mode and the last one will open the list.

The following solution will give you options to control the number of clicks needed to change the value of the combobox column.

__SOLUTION__

__2 clicks solution__

By setting the __EditTriggers="CellClick"__ property of the GridViewComboBoxColumn the cells will enter edit mode with a single click only. Now you will need one more click to show the drop down and select a value.

__1 clicks solution__

In addition to the __EditTriggers="CellClick"__ property, you can set __OpenDropDownOnFocus__ property of the editor (RadComboBox). 

This could be done in __XAML__ like so:

#### __XAML__

{{region gridview-combobox-column-clicks_0}}

	<telerik:GridViewComboBoxColumn DataMemberBinding="{Binding ClubID}"
	                                SelectedValueMemberPath="ID"
	                                EditTriggers="CellClick"
	                                DisplayMemberPath="Name"
	                                ItemsSource="{Binding Clubs, Source={StaticResource MyViewModel}}">
        <telerik:GridViewComboBoxColumn.EditorStyle>
            <Style TargetType="telerik:RadComboBox">
                <Setter Property="OpenDropDownOnFocus" Value="True"/>
            </Style>
        </telerik:GridViewComboBoxColumn.EditorStyle>
    </telerik:GridViewComboBoxColumn>
{{endregion}}




