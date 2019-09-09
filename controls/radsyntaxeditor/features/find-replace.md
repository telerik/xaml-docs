---
title: Find and Replace
page_title: Find and Replace
description: This article explains the find and replace functionality provided by the RadSyntaxEditor control.
slug: radsyntaxeditor-features-find-replace
tags: find,replace,radsyntaxeditor
position: 2
---

# Find and Replace

The RadSyntax editor provides an easy and intuitive way to search for a given text in the document as well as replace occurrences of this text.

## Find and Replace Dialog

By pressing the **Ctrl + F** key combination you can open the find dialog which consist of UI to find a particular string and replace it with another. By using the arrow buttons, you can navigate to the previous or next occurrence of the search text. You can also highlight all occurrences of the text by clicking the `Find All` button. Finally, you can replace the next occurrence of the string or all occurrences via the `Replace` and `Replace All` buttons respectively.

#### Figure 1: The Find Dialog

![The Find Dialog](images/syntaxeditor-find-dialog.png)

## Programmatic Search

You can also search in the document programmatically by using the following methods exposed by the RadSyntaxEditor control.

### Find

The **Find** method takes as arguments the search string and the index from which to start the search. Optionally, you can also pass a parameter to control whether the casing of the letters should be matched and to specify whether the search string is a regular expression. The different overloads of the method are listed below.

* **Span? Find(string searchText, int startIndex)**
* **Span? Find(string searchText, int startIndex, bool useRegularExpression)**
* **Span? Find(string searchText, int startIndex, bool matchCase, bool useRegularExpression)**

### FindAll

The **FindAll** method is identical to the Find method, with the difference being that it does not take a starting index as an argument and returns **all occurrences** of the searched string in the document.

* **IEnumerable<Span> FindAll(string searchText)**
* **IEnumerable<Span> FindAll(string searchText, bool useRegularExpression)**
* **IEnumerable<Span> FindAll(string searchText, bool matchCase, bool useRegularExpression)**

### FindPrevious

The **FindPrevious** method works similarly to the Find method, with the difference that the search is performed from the starting index towards the beginning of the document. It has a single overload with the following definition:

**Span? FindPrevious(string searchText, int startIndex, bool matchCase)**

### NavigateNextMatch and NavigatePreviousMatch

The **NavigateNextMatch** and **NavigatePreviousMatch** methods can be used to find the next and previous occurrence of the searched text with regards to the current position of the control's **caret**. The search performed by these methods is case insensitive. All folded regions which contain the matched span are unfolded when this method is invoked.

* **void NavigateNextMatch(string searchText)**
* **void NavigatePreviousMatch(string searchText)**

### HighlightAllMatches

The **HighlightAllMatches** finds all occurrences of the searched text in the document and, if there is a registered **TextSearchHighlightTagger**, highlights them by using the specified **TextFormatDefinitions**. The performed search is case insensitive.

* **void HighlightAllMatches(string searchText)**

### OpenFindDialog and CloseFindDialog

Invoking the **OpenFileDialog** method opens the dialog from **Figure 1** with the specified search text in the search textbox. The **CloseFindDialog** in turn sets the dialog's **Visibility** to **Collapsed**.

* **void OpenFindDialog(string searchText)**
* **void CloseFindDialog()**

## See Also

* [Selection]({%slug radsyntaxeditor-features-selection%})
* [IntelliSense]({%slug radsyntaxeditor-visual-structure%})