---
title: Clearing Navigation History in RadFileDialogs Explorer Control
description: Learn how to manipulate or clear the navigation history of the Explorer Control in RadFileDialogs for WPF.
type: how-to
page_title: How to Clear the Navigation History in RadFileDialogs Explorer Control
slug: kb-filedialogs-clear-navigation-history
tags: radfiledialogs, wpf, explorer control, navigation history, clear history
res_type: kb
ticketid: 1632150
---

## Environment

| Product | Version |
| --- | --- |
| RadFileDialogs for WPF | 2024.3.806 |

## Description

How to clear the navigation history of the RadFileDialogs' ExplorerControl.

## Solution

To clear the navigation history, you can subscribe to the `Loaded` event of the RadFileDialog or the ExplorerControl in order to access the `HistoryNavigationPaneControl`. Then, you can get the `DirectoryHistory` object and call its `Clear` method.


```C#
	 private HistoryNavigationPaneControl historyNavigationPane;

	 private void ExplorerControl_Loaded(object sender, RoutedEventArgs e)
	 {
		 this.historyNavigationPane = this.explorerControl.FindChildByType<HistoryNavigationPaneControl>();
	 }

	 public void ClearDirectoryHistory()
	 {
		 this.historyNavigationPane.DirectoryHistory.Clear();
	 }
```
