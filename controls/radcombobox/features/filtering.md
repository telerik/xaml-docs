---
title: Filtering
page_title: Filtering
description: Filtering
slug: radcombobox-features-filtering
tags: filtering
published: True
position: 0
---

# Filtering

The advanced filtering mechanism of the __RadComboBox__ control allows the users to refine their search results as they type in the input area. There are four __TextSearchMode__ types that can work with the __RadComboBox__:

* __Contains__ - only items containing the typed text will be displayed in the drop-down part, case insensitive.

* __ContainsCaseSensitive__ - only items containing the typed text will be displayed in the drop-down part, case sensitive.

* __StartsWith__ - only items, which text starts with the typed text, will be shown in the drop-down part, case insensitive.

* __StartsWithCaseSensitive__ - only items, which text starts with the typed text, will be shown in the drop-down part, case sensitive.

>The __ContainsCaseSensitive__ and __StartsWithCaseSensitive__ are available since Q1 2010 SP1.

The next code snippet shows a regular __RadComboBox__ with static data (defined in XAML).

#### __XAML__

{{region radcombobox-features-filtering_0}}
	<telerik:RadComboBox IsEditable="True" x:Name="radComboBox">
	    <telerik:RadComboBoxItem Content="Alapattah" />
	    <telerik:RadComboBoxItem Content="Brickell Avenue" />
	    <telerik:RadComboBoxItem Content="Downtown Miami" />
	    <telerik:RadComboBoxItem Content="El Portal" />
	    <telerik:RadComboBoxItem Content="Cutler Ridge" />
	    <telerik:RadComboBoxItem Content="Florida City" />
	    <telerik:RadComboBoxItem Content="Homestead" />
	    <telerik:RadComboBoxItem Content="Kendall" />
	    <telerik:RadComboBoxItem Content="Leisure City" />
	    <telerik:RadComboBoxItem Content="Medley" />
	    <telerik:RadComboBoxItem Content="Pinecrest" />
	    <telerik:RadComboBoxItem Content="Virginia Gardens" />
	</telerik:RadComboBox>
{{endregion}}

To control the text filtering you can set the __IsFilteringEnabled__ property. By default the __IsFilteringEnabled__ is set to False. You can see on the snapshot below that in this case the items in the drop-down are not filtered.

![](images/RadComboBox_Features_Filtering_010.png)

Now go back in the initial __RadComboBox__ declaration and set the __TextSearchMode__ property to __Contains__. To enable the text filtering you will also have to set the __IsFilteringEnabled__ property to __True__.

#### __XAML__

{{region radcombobox-features-filtering_1}}
	<telerik:RadComboBox IsEditable="True" x:Name="radComboBox" TextSearchMode="Contains" IsFilteringEnabled="True">
	....
	</telerik:RadComboBox>
{{endregion}}

Start your demo and write "al" in the __input box__. Now only items containing the "al" text will be displayed.

![](images/RadComboBox_Features_Filtering_020.png)

>The text filtering feature of __RadComboBox__ works only while the drop-down is open (it filters the visible items in the drop-down). You can also set the __OpenDropDownOnFocus__ property to __True__ which automatically opens the drop-drop when the controls is focused.

The final scenario is when you have a __TextSearchMode__ set to __TextSearchMode.StartsWith__.
        

#### __XAML__

{{region radcombobox-features-filtering_2}}
	<telerik:RadComboBox IsEditable="True" x:Name="radComboBox" TextSearchMode="StartsWith" IsFilteringEnabled="True">
	....
	</telerik:RadComboBox>
{{endregion}}

Start your demo and write "al" in the __input box__. Now only items, which text starts with the "al" text, will be shown in the drop-down list.

![](images/RadComboBox_Features_Filtering_030.png)

>importantWhen RadComboBox is virtualized the filtering is not supported.

# See Also

 * [Edit Modes]({%slug radcombobox-features-edit-modes%})

 * [AutoComplete]({%slug radcombobox-features-autocomplete%})
