---
title: Filter the Items in GridViewComboBoxColumn
page_title: Filter the Items in GridViewComboBoxColumn
description: Filter the Items in GridViewComboBoxColumn
slug: gridview-columns-how-to-filter-the-items-in-comboboxcolumn
tags: filter,the,items,in,gridviewcomboboxcolumn
publish: True
position: 12
---

# Filter the Items in GridViewComboBoxColumn



Since, RadComboBox is the editor of the __GridViewComboBoxColumn__, you can benefit from its [advanced filtering mechanism]({%slug radcombobox-features-filtering%}).
      

__PROBLEM__

By default __ItemsPanelTemplate__ of the combo box inside __GridViewComboBoxColumn__ is __VirtualizingStackPanel__. This means that the ComboBox is virtualized and only the items in the visible area are loaded. So the filtering will work only for these items.
      



__SOLUTION__

To resolve the problem you just have to change the __RadComboBox__'s __ItemsPanel__ with __StackPanel__:
      

#### __XAML__

{{region gridview-columns-how-to-filter-the-items-in-comboboxcolumn_0}}
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
	{{endregion}}


