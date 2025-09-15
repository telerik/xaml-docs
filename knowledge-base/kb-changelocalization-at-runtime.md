---
title: Change Localization of the FindDialog of PdfViewer During Runtime
description: "How to change the language of the find dialog of RadPdfViewer at runtime."
type: how-to
page_title: Dynamically Update the Culture of the FindDialog of RadPdfViewer
slug: kb-pdfviewer-change-localization-at-runtime
position: 0
tags: PdfViewer, FindDialog, localization, runtime
ticketid: 1619188
res_type: kb
---

## Environment

<table>
    <tbody>
        <tr>
            <td>Product Version</td>
            <td>2023.2.718</td>
        </tr>
        <tr>
            <td>Product</td>
            <td>RadPdfViewer for WPF</td>
        </tr>
    </tbody>
</table>

## Description

How to change the culture of the [find dialog]({%slug radpdfviewer-find-dialog%}) of RadPdfViewer at runtime, thus changing the language.

## Solution

To change the localization settings of the find dialog, you will need to unregiser it in order to unload it. Then set the application culture and, register the dialog again.


```C#
	private void Button_Click(object sender, RoutedEventArgs e)
	{
	    	RadPdfViewerAttachedComponents.SetRegisterFindDialog(pdfViewer, false);
	    	Thread.CurrentThread.CurrentCulture = new CultureInfo("de");
	    	Thread.CurrentThread.CurrentUICulture = new CultureInfo("de");
	    	RadPdfViewerAttachedComponents.SetRegisterFindDialog(pdfViewer, true);
	}
```
