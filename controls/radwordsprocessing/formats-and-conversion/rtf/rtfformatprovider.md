---
title: Using RtfFormatProvider
page_title: Using RtfFormatProvider
description: Using RtfFormatProvider
slug: radwordsprocessing-formats-and-conversion-rtf-rtfformatprovider
tags: using,rtfformatprovider
published: True
position: 2
---

# Using RtfFormatProvider



__RtfFormatProvider__ makes it easy to import and export __RadFlowDocument__ to/from RTF format, preserving the entire document structure and formatting.
      

All you have to do in order to use __RtfFormatProvider__ is add references to the assemblies listed below:
      

* Telerik.Windows.Documents.Core.dll
          

* Telerik.Windows.Documents.Flow.dll
          

## Import

In order to import an RTF document you need to use the __Import()__ method of __RtfFormatProvider__.
        

The following code snippet shows how to use __RtfFormatProvider__ to import an RTF document from a file:
        

#### __C#__

{{region radwordsprocessing-formats-and-conversion-rtf-rtfformatprovider_0}}
    RtfFormatProvider provider = new RtfFormatProvider();
    using (Stream input = File.OpenRead("Sample.rtf"))
    {
        RadFlowDocument document = provider.Import(input);
    }
{{endregion}}



And here is how you can import a document from string containing the RTF document:
        

#### __C#__

{{region radwordsprocessing-formats-and-conversion-rtf-rtfformatprovider_1}}
    RtfFormatProvider provider = new RtfFormatProvider();
    RadFlowDocument document = provider.Import(input);
{{endregion}}



The resulting __RadFlowDocument__ can be used like any code-generated document.
        

## Export

In order to export a document to RTF you need to use the __Export()__ method of __RtfFormatProvider__.
        

The following snippet shows how to use __RtfFormatProvider__ to export __RadFlowDocument__ to a file.
        

#### __C#__

{{region radwordsprocessing-formats-and-conversion-rtf-rtfformatprovider_2}}
    RtfFormatProvider provider = new RtfFormatProvider();
    using (Stream output = File.Create("sample.rtf"))
    {
        RadFlowDocument document = CreateRadFlowDocument();
        provider.Export(document, output);
    }
{{endregion}}



You can also export the document to a string and preserve it in a database.
        

#### __C#__

{{region radwordsprocessing-formats-and-conversion-rtf-rtfformatprovider_3}}
    RtfFormatProvider provider = new RtfFormatProvider();
    RadFlowDocument document = CreateRadFlowDocument();
    string output = provider.Export(document);
{{endregion}}



The resulting documents can be opened in any application that supports RTF documents.
        
