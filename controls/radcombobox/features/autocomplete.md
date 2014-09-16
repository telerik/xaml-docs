---
title: AutoComplete
page_title: AutoComplete
description: AutoComplete
slug: radcombobox-features-autocomplete
tags: autocomplete
publish: True
position: 2
---

# AutoComplete



__AutoComplete__ is a feature provided by many browsers, programs and controls. It involves the program predicting a word or phrase that the user wants to type without the user actually typing it in completely. __RadComboBox__ has full autocomplete support - while you type into the input area, the combobox returns the relative match for the currently typed text.

The purpose of this tutorial is to show you how to configure the autocomplete feature. The following sections are included:

* [RadComboBox populated with a list of strings](#radcombobox-populated-with-a-list-of-strings)

* [Using DisplayMemberPath](#using-displaymemberpath)

* [Using custom ItemTemplate](#using-custom-itemtemplate)

* [Using TextSearch.TextPath property](#using-textsearch.textpath)

* [Using TextSearch.AutoCompleteTimeout property](#using-textsearch.autocompletetimeout-property)

* [Disable autocomplete](#disable-autocomplete)

## RadComboBox Populated with a List of Strings

In the simplest scenario your data source will be a list of strings. In this case you don't need to perform any additional work to enable or configure the autocomplete.

#### __XAML__

{{region radcombobox-features-autocomplete_0}}
	<telerik:RadComboBox x:Name="radComboBox" Width="200" IsEditable="True">
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
	</telerik:RadComboBox>
	{{endregion}}



Now, if you type only "down", the combo will complete your result with the first matching item.



Note that in the previous example the __IsEditable__ property is set to __True__. If your __RadComboBox__ is non-editable, you could still benefit from the autocomplete feature, but instead of autocomplete your items will be auto-selected.

## Using DisplayMemberPath

Having __RadComboBox__ populated with a list of strings is the simplest scenario. However, in most of the cases you will have a __RadComboBox__[populated with a collection of business objects]({%slug radcombobox-populating-with-data-binding-to-object%}). If your data source is more complex and your data objects are not single values but rather more complicated classes that have multiple properties, you can specify which value you want to see in the Selection Box of the control. To accomplish this you are required to configure the __DisplayMemberPath__ to point out to the property you want to make use of __AutoComplete__.

For example, if you set the __DisplayMemberPath__ to __Name__ as you suppose that your data object has such property, __RadComboBox__ will try to auto complete your entry with some of the matching name values. Here is an example of how to set __DisplayMemberPath__ and use __AutoComplete__ in case your data context associated with this control has a property called __Name__.

#### __XAML__

{{region radcombobox-features-autocomplete_1}}
	<telerik:RadComboBox x:Name="radComboBox" ItemsSource="{Binding Source={StaticResource DataSource}, Path=Agency}" DisplayMemberPath="Name" IsEditable="True"/>
	{{endregion}}



Note that you have also set the __IsEditable__ property to __True__ in order to better distinguish the benefit of __AutoComplete__. If you are not using __IsEditable__property you can still benefit from this feature, but instead of __AutoComplete__ your items will be __AutoSelected__.
        

Now, if you type only "New", the combo will complete your result with the first matching item.
        



In the previous example, the actual data source declaration and initialization are omitted for better clarity. For more information, take a look at the [Binding to Object]({%slug radcombobox-populating-with-data-binding-to-object%}) topic.

## Using Custom ItemTemplate

Things are getting more complicated in the cases when you are using __ItemTemplate__ that defines your item layout. For example, if you have an __ItemTemplate__ like the one shown below, there is no straight-forward logic what __DisplayMemberPath__ should match as there are multiple members that are displayed.

![](images/RadComboBox_Features_AutoComplete_030.png)

### Using TextSearch.TextPath

To overcome this issue the __RadComboBox__'s API supports an attached property __TextSearch.TextPath__ in which you have to specify which value you want to use for __AutoComplete__ and __AutoSelect__. 

>The __TextSearch__ class is located in the __Telerik.Windows.Controls.dll__assembly.

The following example shows you how to use the __TextSearch.TextPath__ property.

#### __XAML__

{{region radcombobox-features-autocomplete_2}}
	<telerik:RadComboBox x:Name="radComboBox" 
	                     ItemsSource="{Binding Source={StaticResource DataSource}, Path=Agency}" 
	                     ItemTemplate="{StaticResource ComboBoxCustomTemplate}" IsEditable="True" 
	                     telerik:TextSearch.TextPath="Name" />
	{{endregion}}



### Using TextSearch.AutoCompleteTimeout Property

The __TextSearch__ class exposes a static property named __AutoCompleteTimeout__, which allows you to configure the autocomplete timeout. Use this property when you want to set the timeout after the autocomplete buffer is reset.

## Disable Autocomplete

By default the autocomplete feature of __RadComboBox__ is always enabled. In order to disable it, you need to set the __RadComboBox__'s __IsTextSearchEnabled__ property to __False__.

#### __XAML__

{{region radcombobox-features-autocomplete_3}}
	<telerik:RadComboBox x:Name="radComboBox" IsTextSearchEnabled="False"/>
	{{endregion}}



#### __C#__

{{region radcombobox-features-autocomplete_4}}
	radComboBox.IsTextSearchEnabled = false;
	{{endregion}}



#### __VB.NET__

{{region radcombobox-features-autocomplete_5}}
	radComboBox.IsTextSearchEnabled = False
	{{endregion}}



# See Also

 * [Selection]({%slug radcombobox-features-selection%})

 * [DataBinding]({%slug radcombobox-features-databinding%})

 * [Edit Modes]({%slug radcombobox-features-edit-modes%})
