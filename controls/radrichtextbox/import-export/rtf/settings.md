---
title: Settings
page_title: Settings
description: Check our &quot;Settings&quot; documentation article for the RadRichTextBox {{ site.framework_name }} control.
slug: radrichtextbox-import-export-rtf-settings
tags: settings
published: True
position: 0
---

# Settings

__RtfFormatProvider__ allows for import of RTF documents and respectively export of RadRichTextBox to RTF. Additionally, the import/export settings provide modification options. The current article outlines the available settings.

## Export Settings

__RtfFormatProvider__ exposes __ExportSettings__, which allow customization in how fields are exported. The __ExportSetting__s property is of type RtfExportSettings which have the following properties and events:

* __ExportImagesInCompatibilityMode__: A property of type bool that gets or sets whether the images should be exported in compatibility mode. You can use this option when the document will be used in older readers.
* __ImageExporting__: Handling this event allows you to change the bytes and the extension of the image before exporting it.
* __FieldResultMode__: This property defines how the fields are exported in the RTF content. This property is an enumeration and it allows the following values:
	* __Code__: Shows all fields codes in the current document.
	* __DisplayName__: Show all fields names in the current document.
	* __Result__: Replace the merge fields in your document with actual data from your recipient list.
	* **Null**: When the __FieldResultMode__ is set to `null`, fields' display mode is **not changed**. *This can provide a better performance and lower memory usage while exporting.*	

	__Example 1: Setting the ExportSettings of RtfFormatProvider__
	```C#
		RtfExportSettings exportSettings = new RtfExportSettings();
		exportSettings.ExportImagesInCompatibilityMode = true;
		exportSettings.FieldResultMode = FieldDisplayMode.DisplayName;
		
		RtfFormatProvider rtfFormatProvider = new RtfFormatProvider();
		rtfFormatProvider.ExportSettings = exportSettings;
	```


## Import Settings

Through the __ImportSettings__ of __RtfFormatProvider__ you can utilize the __FontSubstituting__ event. This event allows you to handle the cases when the Rtf source specifies a __Font__ that is not available to the __RichTextBox__. This is particularly useful in __Silverlight__ when the __Font__ can be resolved only if it is among the default ones when you do not want to rely on it being installed on the client machine. __Example 4__ shows how you can subscribe to the event and handle it.

__Example 2: Setup Default RtfFormatProvider__
```C#
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
```

## See Also

 * [Getting Started]({%slug radrichtextbox-getting-started%})
 * [Using TxtFormatProvider]({%slug radrichtextbox-import-export-txt-txtformatprovider%})
