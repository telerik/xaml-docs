---
title: Settings
page_title: Settings
description: Settings
slug: radwordsprocessing-formats-and-conversion-rtf-settings
tags: settings
published: True
position: 2
---

# Settings



__RtfFormatProvider__ allows for import of RTF documents and respectively export of RadFlowDocument to RTF. Additionally, the import/export settings provide modification options. The current article outlines the available settings.
      

## Export Settings

The export settings which you can specify are as follows:
        ExportImagesInCompatibilityMode 

Specifies if the images should be exported in compatibility mode. This option is convenient when the exported document is going to be consumed by older RTF readers.
              

The default value for this setting is __false__.
              

The following code snippet shows how you can create and specify particular export settings to RtfFormatProvider.
        

#### __C#__

{{region radwordsprocessing-formats-and-conversion-rtf-settings_0}}
	            RtfFormatProvider provider = new RtfFormatProvider();
	            RtfExportSettings exportSettings = new RtfExportSettings();
	            exportSettings.ExportImagesInCompatibilityMode = true;
	            provider.ExportSettings = exportSettings;
	{{endregion}}


