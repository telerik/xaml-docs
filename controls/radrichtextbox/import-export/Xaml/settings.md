---
title: Settings
page_title: Settings
description: Settings
slug: radrichtextbox-import-export-xaml-settings
tags: settings
published: True
position: 1
---

# Settings

__XamlFormatProvider__ allows for import of XAML documents and respectively export of RadRichTextBox to XAML file. Additionally, the import/export settings provide modification options. The current article outlines the available settings.


### Export Settings

__XamlFormatProvider__ exposes __ExportSettings__, which allow you to control the export of the RadRichTextBox document.

## Export Settings Properties
* __ImageExportMode__: A property of type __ImageExportMode__ that gets or sets how the image should be exported. This property is an enumeration and it allows the following values:
	* __None__: Images are not exported.
	* __RawData__: Images are exported using their RawData.
	* __ImageExportingEvent__:  Event is fired on exporting.
	* __UriSource__: The UriSource property is used instead of RawData. Bare in mind that this property may not be set on all images.
	
### Export Settings Events
* __ImageExporting__: This event is fired every time before exporting an Image.
* __InlineUIContainerExporting__: This event is fired every time before exporting an __InlineUIContainer__.

#### __[C#] Example 1: Setting the ExportSettings of the XamlFormatProvider__
{{region c#-radrichtextbox-import-export-xaml-settings_0}}
	XamlFormatProvider xamlFormatProvider = new XamlFormatProvider();
	XamlExportSettings settings = new XamlExportSettings();
	settings.ImageExportMode = Telerik.Windows.Documents.FormatProviders.Xaml.ImageExportMode.UriSource;
	xamlFormatProvider.ExportSettings = settings;
{{endregion}}

### Import Settings

__XamlFormatProvider__ exposes __ImportSettings__, which allow you to control the import of the XAML file.

### Import Settings Events 
* __ImageImported__: This event is fired every time when the __Image__ is imported.
* __InlineUIContainerImported__: This event is fired every time when the __InlineUIContainer__ is imported.

#### __[C#] Example 2: Setting the ExportSettings of the XamlFormatProvider__
{{region c#-radrichtextbox-import-export-xaml-settings_1}}
	XamlFormatProvider xamlFormatProvider = new XamlFormatProvider();
	XamlImportSettings settings = new XamlImportSettings();
	xamlFormatProvider.ImportSettings = settings;
	settings.ImageImported += XamlImportSettings_ImageImported;
	
	private void XamlImportSettings_ImageImported(object sender, ImageImportedEventArgs e)
	{
		var img = e.Image;
	}
{{endregion}}

## See Also

 * [Getting Started]({%slug radrichtextbox-getting-started%})
 * [Using XamlFormatProvider]({%slug radrichtextbox-import-export-txt-txtformatprovider%})
