---
title: Selection
page_title: Selection
description: Selection
slug: radautocompletebox-features-selection
tags: selection
published: True
position: 2
---

# Selection

The purpose of this article is to show you the basic properties exposed by the __RadAutoCompleteBox__ for working with __selection__.

## SelectionMode

The RadAutoCompleteBox control provides two selection modes, which allow you to manipulate the type of selection. This is controlled by the SelectionMode enumeration property which has the following values:

* __Multiple__: Multiple items can be added to the selection. __(default value)__

* __Single__: Only one item can be selected at a time.

## Using the SelectedItem

The purpose of the __SelectedItem__ property is to get or set the currently selected item of the __RadAutoCompleteBox__. Here's how you can get ahold of it.

#### __C#__

{{region cs-radautocompletebox-features-selection_1}}
	Country country = radAutoCompleteBox.SelectedItem as Country;
{{endregion}}

#### __VB.NET__

{{region vb-radautocompletebox-features-selection_1}}
	Dim country As Country = TryCast(radAutoCompleteBox.SelectedItem, Country)
{{endregion}}