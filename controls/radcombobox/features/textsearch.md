---
title: Text Search
page_title: Text Search
description: Check our &quot;Text Search&quot; documentation article for the RadComboBox {{ site.framework_name }} control.
slug: radcombobox-features-textsearch
tags: textsearch
published: True
position: 2
---

# Text Search Functionality

The __RadComboBox__ control supports rich text search functionality. The __TextSearch__ class and the __TextSearchMode__ property of the RadComboBox can be used in order to regulate how the control behaves when it receives user input.

The purpose of this article is to show the properties of the TextSearch class and the TextSearchMode property.

## TextSearchMode

There are four __TextSearchMode__ types that can work with the RadComboBox:

* __Contains__ - only items containing the typed text will be displayed in the drop-down part, case insensitive.

* __ContainsCaseSensitive__ - only items containing the typed text will be displayed in the drop-down part, case sensitive.

* __StartsWith__ - only items, which text starts with the typed text, will be shown in the drop-down part, case insensitive.

* __StartsWithCaseSensitive__ - only items, which text starts with the typed text, will be shown in the drop-down part, case sensitive.

## Using TextSearch.TextPath

>The __TextSearch__ class is located in the __Telerik.Windows.Controls.dll__ assembly.

You can set the __TextSearch.TextPath__ in order to control which property of each of the RadComboBox's Items will be targetted by the AutoHighlight feature. This is useful when the RadComboBox is [bound to a collection]({%slug radcombobox-populating-with-data-binding-to-object%}) of complex bussiness objects. The AutoHighlight feature highlights the first item which fits the user input based on the TextSearchMode and TextSearch.TextPath properties. This property is also useful for the [AutoComplete]({%slug radcombobox-features-autocomplete%}#using-textsearchtextpath) feature.

>When the __IsEditable__ property of the RadComboBox is set to __False__, pressing the same letter more than once results in the next item which fits the TextSearchMode criteria being highlighted.

## Using TextSearch.AutoCompleteTimeout

The __TextSearch__ class exposes a static property named __AutoCompleteTimeout__ which allows you to configure the autocomplete timeout. Use this property when you want to set the timeout after which the typed text for the autocomplete is reset. Its default value is 800ms.

__Example 1: Setting TextSearch.AutoCompleteTimeout__

```C#
	Telerik.Windows.Controls.TextSearch.AutoCompleteTimeout = TimeSpan.FromSeconds(2);
```
```VB.NET
	Telerik.Windows.Controls.TextSearch.AutoCompleteTimeout = TimeSpan.FromSeconds(2)
```

## See Also
 * [Edit Modes]({%slug radcombobox-features-edit-modes%})
