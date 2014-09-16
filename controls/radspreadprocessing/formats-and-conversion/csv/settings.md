---
title: Settings
page_title: Settings
description: Settings
slug: radspreadprocessing-formats-and-conversion-csv-settings
tags: settings
publish: True
position: 1
---

# Settings



__CsvFormatProvider__ allows to import and export CSV documents. Additionally, there are a number of settings that allow you to modify the import/export. The current article outlines the available settings.
      

## 

__CsvFormatProvider__ exposes a __Settings__ property of type __CsvSettings__. This allows you to specify the following:
        

* __Delimiter__: Gets or sets the list separator. By default the CsvFormatProvider class imports and exports files using the list separator specified by the current culture of the system.
            

* __Quote__: Gets or sets the quote symbol
            

* __HasHeaderRow__: Specifies whether the document has header row. The default value is __false__.
            

* __Encoding__: Gets or sets the Encoding that is used when exporting the file. The default value is UTF8 BOM.
            

__Example 1__ shows how to create and specify particular setting to a CsvFormatProvider.
        

#### __[C#] Example 1: Use CsvSettings__

{{region radspreadprocessing-formats-and-conversion-csv-settings_0}}
	                CsvFormatProvider provider = new CsvFormatProvider();
	                provider.Settings.Delimiter = ';';
	                provider.Settings.Quote = '^';
	                provider.Settings.HasHeaderRow = true;
	                provider.Settings.Encoding = new ASCIIEncoding(); 
	{{endregion}}


