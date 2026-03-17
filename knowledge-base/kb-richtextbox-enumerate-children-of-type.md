---
title: Getting All RadDocument child Elements of the Same Type in RadRichTextBox
description: Learn how to use the EnumerateChildrenOfType method to get all children of a specific type from RadRichTextBox RadDocument.
type: how-to
page_title: Enumerating Elements of the Same Type in RadDocument
meta_title: Enumerating Elements of the Same Type in RadDocument
slug: kb-richtextbox-enumerate-children-of-type
tags: radrichtextbox, richtextbox, ui for wpf, image formatting, html, export, import
res_type: kb
ticketid: 1710278
---

## Environment
<table>
<tbody>
<tr>
<td> Product </td>
<td> UI for WPF RichTextBox </td>
</tr>
<tr>
<td> Version </td>
<td> Current </td>
</tr>
</tbody>
</table>

## Description

How to enumerate all document elements of the same type from a RadRichTextBox' RadDocument.

## Solution

To get all elements use the EnumareteChildrenOfType<T> method of RadDocument.

```C#
var allFloatingImages =  this.radDocument.EnumerateChildrenOfType<FloatingImageBlock>();
```
