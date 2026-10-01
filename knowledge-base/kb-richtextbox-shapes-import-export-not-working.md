---
title: Import and Export of Shapes Does Not Work in Older Versions of Telerik UI for WPF
description: Learn why shapes are lost when RadRichTextBox imports or exports DOCX documents in older versions of Telerik UI for WPF and how to resolve the issue.
components: ["richtextbox"]
type: troubleshooting
page_title: Shapes Are Lost when Importing or Exporting DOCX Documents in RadRichTextBox
slug: kb-richtextbox-shapes-import-export-not-working
tags: radrichtextbox, shapes, import, export, docx, docxformatprovider
res_type: kb
---

## Environment

<table>
	<tbody>
		<tr>
			<td>Product Version</td>
			<td>Prior to 2026.4.1007</td>
		</tr>
		<tr>
			<td>Product</td>
			<td>RadRichTextBox for WPF</td>
		</tr>
	</tbody>
</table>

## Description

In versions of Telerik UI for WPF prior to __2026.4.1007__, RadRichTextBox does not correctly import and export shapes when working with Office Open XML (DOCX) documents through the `DocxFormatProvider`. Shapes that are inserted in a document are lost or fail to persist after the document is exported and imported back.

## Solution

Upgrade to Telerik UI for WPF __2026.4.1007__ or a later version, where the import and export of shapes through `DocxFormatProvider` is fixed.

## See Also

* [Shapes]({%slug radrichtextbox-features-shapes%})
* [Using DocxFormatProvider]({%slug radrichtextbox-import-export-using-docxformatprovider%})
