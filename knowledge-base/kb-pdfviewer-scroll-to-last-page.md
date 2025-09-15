---
title: How to determine when the user has scrolled to the last page of a document in PdfViewer for WPF
description: Learn how to detect when the last page of a PDF document has been reached while the users scroll a document.
type: how-to
page_title: Determine when the user reached the last page of a PDF document when scrolling
slug: kb-pdfviewer-scroll-to-last-page
position: 
tags: pdf, scroll, page, UI, pdfviewer, scrollbar
ticketid: 1565728
res_type: kb
---

## Environment
<table>
	<tbody>
		<tr>
			<td>Product Version</td>
			<td>2021.3.914</td>
		</tr>
		<tr>
			<td>Product</td>
			<td>RadPDFViewer for WPF</td>
		</tr>
		<tr>
			<td>.Net Framework</td>
			<td>.NET Core 3.1</td>
		</tr>
	</tbody>
</table>

## Description

In specific scenarios, you might need to detect when the user reached the last page of a document while scrolling through it. This can be tracked with the ValueChanged event of PdfViewer's VerticalScrollBar.

## Solution

Attach to the scroll bar's ValueChanged event once the PdfViewer control is loaded and check the new value:

#### 
```C#
	private void PdfViewer_Loaded(object sender, RoutedEventArgs e)
	{
		this.pdfViewer.VerticalScrollBar.ValueChanged += this.VerticalScrollBar_ValueChanged;
	}

	private void VerticalScrollBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
	{
		if (e.NewValue >= this.pdfViewer.VerticalScrollBar.Maximum)
		{
			// The user scrolled to the end of the document. 
		}
	}
```

## See Also  
* [Scrolling]({%slug radpdfviewer-scrolling%})
