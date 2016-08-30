---
title: Multiple Selection
page_title: Multiple Selection
description: Multiple Selection
slug: radcombobox-features-multiple-selection
tags: multiple, selection
published: True
position: 4
---

# Multiple Selection

With the R3 2016 release version of UI for WPF the ability to select multiple items from __RadComboBox__ is now available. 

In order to enable it the __AllowMultipleSelection__  property needs to be set to __True__.

This article will provide some detailed information about the available properties, commands and other features that are available when multiple selection is allowed:

* [Properties](#properties)

* [Commands](#commands)

* [MultipleSelectionBoxTemplate](#multipleselectionboxtemplate)

* [Keyboard support](#keyboard-support)

## Properties

This section will provide information about the following properties connected with the multiple selection functionality of __RadComboBox__:

* [AllowMultipleSelection](#properties-AllowMultipleSelection)

* [MultipleSelectionSeparator](#properties-MultipleSelectionSeparator)

* [MultipleSelectionSeparatorStringFormat](#properties-MultipleSelectionSeparatorStringFormat)

* [SelectedItems](#properties-SelectedItems)

### AllowMultipleSelection

Using the __AllowMultipleSelection__ property the multiple selection functionality of __RadComboBox__ could be enabled or disabled. It is of type bool and could be set either to __True__ or __False__. The default value is __False__ and in order to enable the multiple selection the __AllowMultipleSelection__ should be set to __True__ as shown in __Example 1__:

#### __[XAML] Example 1: Allowing multiple selection__

{{region radcombobox-features-multiple-selection_0}}
	<telerik:RadComboBox x:Name="radComboBox" AllowMultipleSelection="True"/>
{{endregion}}

### MultipleSelectionSeparator

When multiple items are selected in __RadComboBox__ they are separated from each other with a specific separator. In order to change that separator the __MultipleSelectionSeparator__ property could be used. This property is of type char, so any character could be set as a separator between the selected items.  

__Example 2__ demonstrates how to change the default separator.

#### __[XAML] Example 2: Changing multiple selection separator__

{{region radcombobox-features-multiple-selection_1}}
	<telerik:RadComboBox AllowMultipleSelection="True" MultipleSelectionSeparator="-">
		<telerik:RadComboBoxItem Content="Alapattah" />
		<telerik:RadComboBoxItem Content="Brickell Avenue" />
		<telerik:RadComboBoxItem Content="Downtown Miami" />
		<telerik:RadComboBoxItem Content="El Portal" />
	</telerik:RadComboBox>
{{endregion}}

#### __Figure 1: Selected items separated by dash set in Example 2__

![](images/RadComboBox_Features_MultipleSelection_01.png)

>If __RadComboBox__ is __Editable__ and the __IsTextSearchEnabled__ is __True__ pressing the separator while typing inside the input area of the control will autocomplete the item to its end.

### MultipleSelectionSeparatorStringFormat

You can use the __MultipleSelectionSeparatorStringFormat__ string property for formatting the representation of the char that separates the selected items. By using it the current format of the char separator could easily be changed.

>important If the provided __MultipleSelectionSeparatorStringFormat__ is not a valid format a __FormatException__ will be thrown.

__Example 3__ demonstrates how to set the __MultipleSelectionSeparatorStringFormat__ property.

#### __[XAML] Example 3: Changing multiple selection separator StringFormat__

{{region radcombobox-features-multiple-selection_2}}
	<telerik:RadComboBox AllowMultipleSelection="True" MultipleSelectionSeparator="-"
						 MultipleSelectionSeparatorStringFormat="{}*{0}*">
		<telerik:RadComboBoxItem Content="Alapattah" />
		<telerik:RadComboBoxItem Content="Brickell Avenue" />
		<telerik:RadComboBoxItem Content="Downtown Miami" />
		<telerik:RadComboBoxItem Content="El Portal" />
	</telerik:RadComboBox>
{{endregion}}

#### __Figure 2: Selected items separated by the MultipleSelectionSeparatorStringFormat set in Example 3__

![](images/RadComboBox_Features_MultipleSelection_02.png)

>If __RadComboBox__ is __Editable__ the __MultipleSelectionSeparatorStringFormat__ will be applied only when the focus is not inside the input area of the control. If the input area is focused only the __MultipleSelectionSeparator__ will be applied and visualized.

### SelectedItems

Using the __SelectedItems__ property you could get a collection of all the items that are currently selected - the property is read-only. This property is provided by the [__MultiSelector__](https://msdn.microsoft.com/en-us/library/system.windows.controls.primitives.multiselector.selecteditems(v=vs.110).aspx) class that is inherited by __RadComboBox__. 

When multiple selection is allowed the __SelectedItem__, __SelectedValue__ and __SelectedIndex__ properties are being set as explained below:

* __SelectedItem__ - The first item in the current selection that you could get or set. If there is no selection the returned value is null.

* __SelectedValue__ - It gets or sets the value of the __SelectedItem__ that is obtained using the __SelectedValuePath__.

* __SelectedIndex__ - This is the index of the first item of the current selection. If the selection is empty negative one (-1) is returned.

## Commands

With multiple selection the following commands could be executed:

* [SelectAll](#selectall)

* [UnselectAll](#unselectall)

* [ToggleSelectAll](#toggleselectall)

### SelectAll

The __SelectAll__ command is part of the static class __RadComboBoxCommands__. After executing it all items in __RadComboBox__ will be selected. 

In __Example 4__ a __Button__ is linked to the __RadComboBoxCommands.SelectAll__ command - after execution all items in __RadComboBox__ get selected:

#### __[XAML] Example 4: SelectAll command__

{{region radcombobox-features-multiple-selection_3}}
	<telerik:RadButton Content="SelectAll" Command="{x:Static telerik:RadComboBoxCommands.SelectAll}"
                    CommandTarget="{Binding ElementName=radComboBox}"/>
	<telerik:RadComboBox x:Name="radComboBox" AllowMultipleSelection="True">
		<telerik:RadComboBoxItem Content="Alapattah" />
		<telerik:RadComboBoxItem Content="Brickell Avenue" />
		<telerik:RadComboBoxItem Content="Downtown Miami" />
		<telerik:RadComboBoxItem Content="El Portal" />
	</telerik:RadComboBox>
{{endregion}}

#### __Figure 3: RadCombobBox after executing SelectAll command__

![](images/RadComboBox_Features_MultipleSelection_03.png)

### UnselectAll

The __UnselectAll__ command deselects all currently selected items - the command is part of the __RadComboBoxCommands__ static class.

__Example 5__ demonstrates how __UnselectAll__ command could be attached to the __Command__ property of a __Button__.

#### __[XAML] Example 5: UnselectAll command__

{{region radcombobox-features-multiple-selection_4}}
	<telerik:RadButton Content="UnselectAll" Command="{x:Static telerik:RadComboBoxCommands.UnselectAll}"
					   CommandTarget="{Binding ElementName=radComboBox}"/>
	<telerik:RadComboBox x:Name="radComboBox" AllowMultipleSelection="True">
		<telerik:RadComboBoxItem Content="Alapattah" />
		<telerik:RadComboBoxItem Content="Brickell Avenue" />
		<telerik:RadComboBoxItem Content="Downtown Miami" />
		<telerik:RadComboBoxItem Content="El Portal" />
	</telerik:RadComboBox>
{{endregion}}

#### __Figure 4: Before executing UnselectAll command__

![](images/RadComboBox_Features_MultipleSelection_04.png)

#### __Figure 5: After executing UnselectAll command__

![](images/RadComboBox_Features_MultipleSelection_05.png)

### ToggleSelectAll

Using the __ToggleSelectAll__ command you could switch between selection and deselection of the items - it selects/deselects all of the items in the multiple selection __RadComboBox__ depending on the command parameter.

__Example 6__ demonstrates how __ToggleSelectAll__ command could be attached and executed through __CheckBox__.

#### __[XAML] Example 6: ToggleSelectAll command__

{{region radcombobox-features-multiple-selection_5}}
	<CheckBox Content="ToggleSelectAll" Command="{x:Static telerik:RadComboBoxCommands.ToggleSelectAll}"
              CommandParameter="{Binding RelativeSource={RelativeSource Self}, Path=IsChecked}"
              CommandTarget="{Binding ElementName=radComboBox}"/>
	<telerik:RadComboBox x:Name="radComboBox" AllowMultipleSelection="True">
		<telerik:RadComboBoxItem Content="Alapattah" />
		<telerik:RadComboBoxItem Content="Brickell Avenue" />
		<telerik:RadComboBoxItem Content="Downtown Miami" />
		<telerik:RadComboBoxItem Content="El Portal" />
	</telerik:RadComboBox>
{{endregion}}

#### __Figure 5: After checking the CheckBox with ToggleSelectAll command__

![](images/RadComboBox_Features_MultipleSelection_06.png)

#### __Figure 6: After unchecking the CheckBox with ToggleSelectAll command__

![](images/RadComboBox_Features_MultipleSelection_07.png)

## MultipleSelectionBoxTemplate

The __MultipleSelectionBoxTemplate__ gives you the ability to define a separate template for the selected items of __Non-Editable RadComboBox__ when multiple selection is allowed.

>important The __MultipleSelectionBoxTemplate__ is used only in __Non-Editable RadComboBox__.

The following steps demonstrate how to apply the __MultipleSelectionBoxTemplate__ to __RadComboBox__.

You need to create a custom __DataTemplate__ as shown in __Example 7__:

#### __[XAML] Example 7: Custom DataTemplate__

{{region radcombobox-features-multiple-selection_6}}
	<UserControl.Resources>
		<DataTemplate x:Key="MultipleSelectionBoxTemplate">
			<TextBlock Text="{Binding ElementName=radComboBox, Path=SelectedItems.Count, StringFormat='Selected Items Count: {0}'}" Foreground="Red" FontWeight="Bold" />
		</DataTemplate>
	</UserControl.Resources>
{{endregion}}

The created __DataTemplate__ should be set to the __MultipleSelectionBoxTemplate__ property of __RadComboBox__ as demonstrated in __Example 8__:

#### __[XAML] Example 8: Set the MultipleSelectionBoxTemplate__

{{region radcombobox-features-multiple-selection_7}}
	<telerik:RadComboBox x:Name="radComboBox" AllowMultipleSelection="True"
                     MultipleSelectionBoxTemplate="{StaticResource MultipleSelectionBoxTemplate}">
		<telerik:RadComboBoxItem Content="Alapattah" />
		<telerik:RadComboBoxItem Content="Brickell Avenue" />
		<telerik:RadComboBoxItem Content="Downtown Miami" />
		<telerik:RadComboBoxItem Content="El Portal" />
	</telerik:RadComboBox>
{{endregion}}

#### __Figure 7: RadComboBox after applying MultipleSelectionBoxTemplate__

![](images/RadComboBox_Features_MultipleSelection_08.png)

## Keyboard support

>important __CanKeyboardNavigationSelectItems__ has no affect when multiple selection is used.

This section describes the specific keyboard shortcuts used by __RadComboBox__ when multiple selection is allowed.

* Space - Selects the current highlighted item when __RadComboBox__ is __Non-Editable__.

* Enter - Selects the current highlighted item both when __RadComboBox__ is __Editable__ or __Non-Editable__.

* Back - Deselects the current highlighted item when __RadComboBox__ is __Non-Editable__.

# See Also

 * [Selection]({%slug radcombobox-features-selection%})

 * [Edit Modes]({%slug radcombobox-features-edit-modes%})

 * [Clear Selection Button]({%slug radcombobox-features-clearselectionbutton%})
