---
title: Breaking Changes
page_title: Breaking Changes
description: This article lists the breaking changes introduced in the RadTreeView for WPF component through the releases.
slug: treeview-breaking-changes
tags: breaking, changes, backward,compadibility
published: True
position: 4
---

# Breaking Changes

This article lists and describes the breaking changes introduced in the RadTreeView component. For a full list of changes, see the [Release History](https://www.telerik.com/support/whats-new/wpf/release-history) pages of the Telerik UI for WPF product.

## Q1 2013

With the Q1 2013 release, the RadioButtons logic implemented in the `RadTreeView` is removed. This means that the __following list of properties are removed__:

* __RadTreeView properties:__
	* __ItemsOptionListType__
* __RadTreeViewItem properties:__
	* __ItemsOptionListType__
	* __OptionType__
	* __IsRadioButtonEnabled__
	
Instead, use the [IsOptionElementsEnabled]({%slug check-box-support%}) property of `RadTreeView` or the custom CheckBox implementation shown in the [Implement a Tri-State CheckBox logic using MVVM]({%slug radtreeview-howto-tri-state-mvvm%}) article.
