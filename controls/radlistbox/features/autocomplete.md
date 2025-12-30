---
title: AutoComplete
page_title: AutoComplete
description: Check our &quot;AutoComplete&quot; documentation article for the RadListBox {{ site.framework_name }} control.
slug: radlistbox-features-autocomplete
tags: autocomplete
published: True
position: 1
---

# AutoComplete

__RadListBox__ has full autocomplete support - while the control is focused, you can type certain keys and the listbox will select the relative match for the currently typed text.

The purpose of this tutorial is to show you how to configure the autocomplete feature.

## Using TextSearchMode property

This enumeration property specifies whether the text search will be StartsWith/Contains and/or case sensitive. It provides the following entries:

* Contains

* ContainsCaseSensitive

* StartsWith

* StartsWithCaseSensitive

## Using TypedText property

The TypedText property of RadListBox contains the currently typed text. It is updated as soon as the user types a new key for autocomplete.    	

## Setting TextPath/TextBinding

In most of the cases you will have a __RadListBox__ [populated with a collection of business objects]({%slug radlistbox-populating-with-data-binding-to-object%}). If your data source is more complex and your data objects are not single values but rather more complicated classes that have multiple properties, you can specify which value you want to use for Autocomplete. To accomplish this you need to configure the __TextPath__/__TextBinding__ property.

Let's have the __RadListBox__ bound to "Customers" collection as explained in [Binding to Object]({%slug radlistbox-populating-with-data-binding-to-object%}) article:

![radlistbox features autocomplete 010](images/radlistbox_features_autocomplete_010.png)

Setting __TextPath__ /__TextBinding__ property will allow to use "Name" property of the Customer object for AutoComplete:

__Setting TextPath__

```XAML
	<telerik:RadListBox  Width="300" x:Name="radListBox1"
	ItemsSource="{Binding Customers}"
	ItemTemplate="{StaticResource ListBoxCustomTemplate}"
	TextPath="Name" />
```

Typing, for example "L" will select the corresponding item:

![radlistbox features autocomplete 020](images/radlistbox_features_autocomplete_020.png)

>Note that if you have set __DisplayMemberPath__ to a certain property and you want to use the same property for __Autocomplete__, you don't need to set __TextPath__/__TextBinding__.

>tip Autocomplete always starts from the beginning, regardless of the selection.

>tip Pressing __Esc__ clears the current text for autocomplete.

## Disable Autocomplete

By default the autocomplete feature of __RadListBox__ is always enabled. In order to disable it, you need to set the __RadListBox__'s __IsTextSearchEnabled__ property to __False__.

__Setting IsTextSearchEnabled__

```XAML
	<telerik:RadListBox x:Name="radListBox" IsTextSearchEnabled="False"/>
```

__Setting IsTextSearchEnabled__

```C#
	radListBox.IsTextSearchEnabled = false;
```

## Using AutocompleteBehavior.AutoCompleteTimeout

The __AutocompleteBehavior__ class exposes a static property named __AutoCompleteTimeout__ which allows you to configure the autocomplete timeout. Use this property when you want to set the timeout after which the typed text for the autocomplete is reset. Its default value is **1 second**.

__Example 4: Setting AutocompleteBehavior.AutoCompleteTimeout__

```C#
	Telerik.Windows.Controls.Primitives.AutocompleteBehavior.AutoCompleteTimeout = TimeSpan.FromSeconds(2);
```
```VB.NET
	Telerik.Windows.Controls.Primitives.AutocompleteBehavior.AutoCompleteTimeout = TimeSpan.FromSeconds(2)
```