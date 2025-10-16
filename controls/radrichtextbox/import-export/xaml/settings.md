---
title: Settings
page_title: Settings
description: Check our &quot;Settings&quot; documentation article for the RadRichTextBox {{ site.framework_name }} control.
slug: radrichtextbox-import-export-xaml-settings
tags: settings
published: True
position: 1
---

# Settings

__XamlFormatProvider__ allows for import of XAML documents and respectively export of RadRichTextBox to XAML file. Additionally, the import/export settings provide modification options. The current article outlines the available settings.

 >note Since R2 2023 SP1 the XamlFormatProvider automatically verifies the imported XAML. More information is available in the [Xaml Verification]({%slug radrichtextbox-import-export-xaml-verification%}) article.

## Export Settings

__XamlFormatProvider__ exposes __ExportSettings__, which allow you to control the export of the RadRichTextBox document.

### Export Settings Properties
* __ImageExportMode__: A property of type __ImageExportMode__ that gets or sets how the image should be exported. This property is an enumeration and it allows the following values:
	* __None__: Images are not exported.
	* __RawData__: Images are exported using their RawData.
	* __ImageExportingEvent__:  Event is fired on exporting.
	* __UriSource__: The UriSource property is used instead of RawData. Bare in mind that this property may not be set on all images.
	
### Export Settings Events
* __ImageExporting__: This event is fired every time before exporting an Image.
* __InlineUIContainerExporting__: This event is fired every time before exporting an __InlineUIContainer__.

>These events will be called when the __ImageExportMode__ enumeration property is set to __ImageExportingEvent__.

__Example 1: Setting the ExportSettings of the XamlFormatProvider__
```C#
	XamlFormatProvider xamlFormatProvider = new XamlFormatProvider();
	XamlExportSettings settings = new XamlExportSettings();
	settings.ImageExportMode = Telerik.Windows.Documents.FormatProviders.Xaml.ImageExportMode.UriSource;
	xamlFormatProvider.ExportSettings = settings;
```

## Import Settings

__XamlFormatProvider__ exposes __ImportSettings__, which allow you to control the import of the XAML file.

### Import Settings Events 
* __ImageImported__: This event is fired every time when the __Image__ is imported.
* __InlineUIContainerImported__: This event is fired every time when the __InlineUIContainer__ is imported.
* __PreProcessingXaml__: This event is fired right before the XAML is parsed and allows you to check it for undesired content. The event arguments expose the following options:
	- __Xaml__: The XAML string that is being imported. You can changed it and then pass it again to the property so the changed XAML is imported. 
	- __SkipXamlValidation__: Allows you to skip the default XAML types validation. 

__Example 2: Disable the default XAML validation__
```C#

	XamlFormatProvider provider = new XamlFormatProvider();
    provider.ImportSettings.PreProcessingXaml += (s, args) => { 
    
        args.SkipXamlValidation = true;
    };

```

__Example 3: Setting the ExportSettings of the XamlFormatProvider__
```C#

	XamlFormatProvider xamlFormatProvider = new XamlFormatProvider();
	XamlImportSettings settings = new XamlImportSettings();
	xamlFormatProvider.ImportSettings = settings;
	settings.ImageImported += XamlImportSettings_ImageImported;
	
	private void XamlImportSettings_ImageImported(object sender, ImageImportedEventArgs e)
	{
		var img = e.Image;
	}
	
```

### Properties

* __AllowedAssemblies__: This collection contains the assemblies that contains the allowed types for the XAML import.  

## See Also

 * [Getting Started]({%slug radrichtextbox-getting-started%})
 * [Using XamlFormatProvider]({%slug radrichtextbox-import-export-txt-txtformatprovider%})
