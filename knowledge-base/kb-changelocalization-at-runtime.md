---
title: Change Localization of The FindDialog of PdfViewer During Runtime
description: "How to change the localization at runtime."
type: how-to
page_title: How to Change The Localization of The FindDialog of PdfViewer During Runtime for WPF.
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

How to change the `RadPdfViewer` localization during runtime.

#### __[C#]__
{{region kb-changelocalization-at-runtime}}
	private void Button_Click(object sender, RoutedEventArgs e)
	{
    	RadPdfViewerAttachedComponents.SetRegisterFindDialog(pdfViewer, false);
    	Thread.CurrentThread.CurrentCulture = new CultureInfo("de");
    	Thread.CurrentThread.CurrentUICulture = new CultureInfo("de");
    	RadPdfViewerAttachedComponents.SetRegisterFindDialog(pdfViewer, true);
	}
{{endregion}}
