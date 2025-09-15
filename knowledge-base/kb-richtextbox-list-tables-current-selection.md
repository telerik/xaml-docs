---
title: Getting a List of All Tables in the Current Selection
description: Learn how to retrieve a list of all tables in the current selection in RadRichTextBox for WPF.
type: how-to
page_title: Retrieve a List of Tables in the Current Selection | RadRichTextBox for WPF
slug: kb-richtextbox-list-tables-current-selection
ticketid: 1633483
tags: radrichtextbox, tables, selection, how-to
res_type: kb
---

## Environment

| Product | Version |
|---------|---------|
| RadRichTextBox for WPF | 2023.3.1010 |

## Description

How to retrieve a list of all tables in the current selection in RadRichTextBox.

## Solution

1. Create a copy of the selection as a new RadDocument using the `CreateDocumentFromSelection` method of the document's selection.

2. Iterate through the document and check for Table objects.

Here's an example implementation:


```C#
     public List<Table> GetTablesInSelection()
     {
          var documentFromSelection = this.richTextBox.Document.Selection.CreateDocumentFromSelection();
          return documentFromSelection.EnumerateChildrenOfType<Table>().ToList();
     }
```
