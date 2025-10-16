---
title: Settings
page_title: Settings
description: Check our &quot;Settings&quot; documentation article for the RadRichTextBox {{ site.framework_name }} control.
slug: radrichtextbox-import-export-docx-settings
tags: settings
published: True
position: 0
---

# Settings

__DocxFormatProvider__ allows for import of DOCX documents and respectively export of RadDocument to DOCX. Additionally, the export settings provide modification options. The current article outlines the available settings.

## Export Settings

__DocxFormatProvider__ exposes __ExportSettings__, which allow customization in how fields are exported. By default, all fields are exported using their result value in the docx document. If you would like to save the document of the editor as a mail merge template and not include the value of the current item of the __MailMergeDataSource__, a new instance of __DocxExportSettings__ should be created and assigned to the format provider. The value of the __FieldResultMode__ of these settings must be set to __FieldDisplayMode.DisplayName__.

__Example 1__ shows you how you can get a reference to the format provider used by the OpenDocumentCommand and the SaveCommand and adjust the export, so that the document is saved as a template:

__Example 1: Setup default DocxFormatProvider__
```C#
	public void SetupDefaultDocxFormatProvider()
	{
		//Obtain a reference to the format provider used by the default UI - RadRichTextBoxRibbonUI
		DocxFormatProvider docxFormatProvider = DocumentFormatProvidersManager.GetProviderByExtension("docx") as DocxFormatProvider;

		DocxExportSettings docxExportSettings = new DocxExportSettings();
		docxExportSettings.FieldResultMode = FieldDisplayMode.DisplayName;

		docxFormatProvider.ExportSettings = docxExportSettings;
	}
```

The __FieldResultMode__ property of the __DocxExportSettings__ is an enumeration and it allows the following values:

* __Code__: Shows all fields codes in the current document.
* __DisplayName__: Shows all fields names in the current document.
* __Result__: Replaces the merge fields in your document with actual data from your recipient list.
* **Null**: When the __FieldResultMode__ is set to `null`, fields' display mode is **not changed**. *This can provide a better performance and lower memory usage while exporting.*


## See Also

 * [Getting Started]({%slug radrichtextbox-getting-started%})
 * [Using DocxFormatProvider]({%slug radrichtextbox-import-export-using-docxformatprovider%})
