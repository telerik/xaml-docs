---
title: PDFViewer Localization of The FindDialog During Runtime
description: "How to change the localization at runtime."
type: how-to
page_title: How to change the localization of the FindDialog during runtime for WPF.
slug: kb-changelocalization-at-runtime
position: 0
tags: PDFViewer, FindDialog, localization, runtime
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
            <td>RadPDFViewer for WPF</td>
        </tr>
    </tbody>
</table>


## Description

How to change the `RadPDFViewer` localization during runtime.

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
