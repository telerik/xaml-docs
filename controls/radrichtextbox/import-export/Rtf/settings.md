---
title: Settings
page_title: Settings
description: Settings
slug: radrichtextbox-import-export-rtf-settings
tags: settings
published: True
position: 0
---

# Settings

__RtfFormatProvider__ allows for import of RTF documents and respectively export of RadRichTextBox to RTF. Additionally, the import/export settings provide modification options. The current article outlines the available settings.

## Export Settings

__RtfFormatProvider__ exposes __ExportSettings__, which allow customization in how fields are exported.  The __ExportSettings__ property is of type __RtfExportSettings__ which have the following properties and events which you can use to customize the export.

* __ExportImagesInCompatibilityMode__: A property of type __bool__ that gets or sets the export images in compatibility mode. You can use this options if the document will be used in older readers.
* __ImageExporting__: This event can be handle in order to change the bytes and the extension of the image that will be exported.
* __FieldResultMode__: A property of the __RtfExportSettings__. This property is an enumeration and it allows the following values:
	* __Code__: Shows all fields codes in the current document
	* __DisplayName__: Show all fields names in the current document
	* __Result__: Replace the merge fields in your document with actual data from your recipient list
	
#### __[C#] Example 1: Setting the ExportSettings of the PdfFormatProvider__
{{region c#-radrichtextbox-import-export-rtf-settings_0}}
	RtfExportSettings exportSettings = new RtfExportSettings();
	exportSettings.ExportImagesInCompatibilityMode = true;
	exportSettings.FieldResultMode = FieldDisplayMode.DisplayName;
	
	RtfFormatProvider rtfFormatProvider = new RtfFormatProvider();
	rtfFormatProvider.ExportSettings = exportSettings;
{{endregion}}

## Import Settings

__RtfFormatProvider__ has __ImportSettings__, which provide an event - __FontSubstituting__, which allows you to handle the cases when the Rtf source specifies a __Font__ that is not available to the __RichTextBox__. This is particularly useful in __Silverlight__ when the __Font__ can be resolved only if it is among the default ones when you do not want to rely on it being installed on the client machine. __Example 4__ shows how you can subscribe to the event and handle it.

#### __[C#] Example 2: Setup Default DocxFormatProvider__
{{region c#-radrichtextbox-import-export-rtf-settings_1}}
	RtfFormatProvider rtfFormatProvider = DocumentFormatProvidersManager.GetProviderByExtension("rtf") as RtfFormatProvider;
	RtfImportSettings rtfImportSettings = new RtfImportSettings();
	rtfImportSettings.FontSubstituting += rtfImportSettings_FontSubstituting;
	rtfFormatProvider.ImportSettings = rtfImportSettings;

	void rtfImportSettings_FontSubstituting(object sender, FontSubstitutingEventArgs e) 
	{ 
		if(e.OriginalFontName.Equals("Cambria"))
		{
			e.SubstitutionFontFamily = new FontFamily("Calibri");
		}
	}
{{endregion}}

## See Also

 * [Getting Started]({%slug radrichtextbox-getting-started%})
 * [Using RtfFormatProvider]({%slug radrichtextbox-import-export-txt-txtformatprovider%})