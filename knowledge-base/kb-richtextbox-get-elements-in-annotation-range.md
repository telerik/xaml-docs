---
title: Get RadDocument Elements Between Annotation Range in RadRichTextBox
description: Learn how to get the elements between AnnotationRangeStart and AnnotationRangeEnd in RadRichTextBox
type: how-to
page_title: Getting the Inlines In Annotation Range in RichTextBox
meta_title: Iterating the DocumentElement Objects In Annotation Range of RichTextBox
slug: kb-richtextbox-get-elements-in-annotation-range
tags: radrichtextbox, ui for wpf, content controls, range,annotations
res_type: kb
ticketid: 1711196
---

## Environment

<table>
<tbody>
<tr>
<td>Product</td>
<td>UI for WPF RichTextBox</td>
</tr>
<tr>
<td>Version</td>
<td>2025.1.211</td>
</tr>
</tbody>
</table>

## Description

How to get the RadDocument elements between AnnotationRangeStart and AnnotationRangeEnd.

## Solution

To get the elements in the annotation range, you can use the `NextSibling` of the `AnnotationRangeStart` object, until you get to the `AnnotationRangeEnd`.

```C#
 private static IList<T> GetElementsInAnnotationRange<T>(AnnotationRangeStart start, AnnotationRangeEnd end) where T : DocumentElement
 {
     var result = new List<T>();
     var currentElement = start.NextSibling;
     while (currentElement != null && !(currentElement is AnnotationRangeEnd))
     {
         if (currentElement.GetType() == typeof(T))
         {
             result.Add((T)currentElement);
         }
         currentElement = currentElement.NextSibling;
     }
     return result;
 }
```

```C#
 var spansInHyperlink = GetElementsInAnnotationRange<Span>(hyperlinkAnnotationStart, hyperlinkAnnotationStart.End);
```

