---
title: Filter the Items in GridViewComboBoxColumn
page_title: Filter Items in ComboBox Column
description: Learn how you can benefit from the advanced filtering mechanisms of the ComboBox Column in RadGridView - Telerik's {{ site.framework_name }} DataGrid.
slug: gridview-columns-how-to-filter-the-items-in-comboboxcolumn
tags: filter,the,items,in,gridviewcomboboxcolumn
published: True
position: 6
---

# Filter the Items in GridViewComboBoxColumn

Since, the editor of __GridViewComboBoxColumn__ is RadComboBox, you can benefit from its [advanced filtering mechanism]({%slug radcombobox-features-filtering%}).

__PROBLEM__

The default __ItemsPanel__ of RadComboBox inside __GridViewComboBoxColumn__ is __VirtualizingStackPanel__. This means that RadComboBox is virtualized and only the items in the visible area are loaded. So the filtering will work for these items only.

__SOLUTION__

To resolve the problem you just have to change __RadComboBox's ItemsPanel with StackPanel__:
      
#### __XAML__

```XAML
	<telerik:GridViewComboBoxColumn DataMemberBinding="{Binding CountryId}"
	                    UniqueName="Country"
	                    SelectedValueMemberPath="Id"
	                    DisplayMemberPath="Name" 
	                    IsComboBoxEditable="True"
	                    EditTriggers="CellClick">
	    <telerik:GridViewComboBoxColumn.EditorStyle>
	        <Style TargetType="telerik:RadComboBox">
	            <Setter Property="IsFilteringEnabled" Value="True"/>
	            <Setter Property="StaysOpenOnEdit" Value="True"/>
		    <Setter Property="OpenDropDownOnFocus" Value="True"/>
	            <Setter Property="ItemsPanel">
	                <Setter.Value>
	                    <ItemsPanelTemplate>
	                        <StackPanel/>
	                    </ItemsPanelTemplate>
	                </Setter.Value>
	            </Setter>
	        </Style>
	    </telerik:GridViewComboBoxColumn.EditorStyle>
	</telerik:GridViewComboBoxColumn>
```

## See Also

 * [RadComboBox Filtering]({%slug radcombobox-features-filtering%})
 * [ComboBox Column]({%slug radgridview-columns-column-types-combobox-column%}) 
 * [Number of clicks in ComboBoxColumn]({%slug gridview-combobox-column-clicks%}) 
