---
title: Exception Handling 
page_title: Exception Handling 
description: Check our &quot;Exception Handling&quot; documentation article for the RadPdfViewer {{ site.framework_name }} control.
slug: radpdfviewer-document-model-exceptionhandling
tags: exception,handling,
published: True
position: 1
---

# Exception Handling 

{% if site.site_name == 'Silverlight' %}

__RadPdfViewer__ provides an API for handling exceptions caused by documents which cannot be loaded correctly because of unsupported features of the control. More information about the unsupported features in __RadPdfViewer__ is available [here]({%slug radpdfviewer-unsupported-features%}).
      

## How to Handle Exceptions

The DocumentSource property of RadPdfViewer exposes an OnException event. The event handler receives two arguments:

* The sender argument contains the DocumentSource. This argument is of type object, but can be cast to the __Telerik.Windows.Documents.Fixed.PdfDocumentSource__ type.
            

* A __Telerik.Windows.Documents.Fixed.Model.OnDocumentExceptionEventArgs__ object. This argument allows you to access the actual exception thrown by __RadPdfViewer__.
            

This is an example how to subscribe the event and handle the exception if there is an unsupported filter:
        

#### __C#__

```C#
	        private void LoadFromUri(object sender, System.Windows.RoutedEventArgs e)
	        {
	            this.pdfViewer.DocumentSource = new PdfDocumentSource(new System.Uri("PdfViewerDemo;component/SampleData/Sample.pdf", System.UriKind.Relative));
	            this.pdfViewer.DocumentSource.OnException += DocumentSource_OnException;
	        }
	
	        private void DocumentSource_OnException(object sender, OnExceptionEventArgs e)
	        {
	            NotSupportedFilterException filterException = e.Exception as NotSupportedFilterException;
	            if (filterException != null)
	            {
	                // The document contains a filter which is not supported.
	            }
	        }
```



The __Telerik.Windows.Documents.Fixed.OnExceptionEventArgs__ has an Exception property which represents the actual exception thrown by __RadPdfViewer__. All exceptions for features which are not supported by __RadPdfViewer__ inherit from the __Telerik.Windows.Documents.Exceptions.NotSupportedFeatureException__ class:
        

* __NotSupportedFilterException__: represents an exception for a filter which is not supported. This exception has a FilterName property which specifies the name of the filter.
            

* __NotSupportedEncryptionException__ - represents an exception for an encryption which is not supported. This exception has e EncryptionCode property which specifies the code of the encryption.            
            

* __NotSupportedFontException__ – represents an exception for a font which is not supported. This exception has a FontType property which specifies the type of the font.            
            

* __NotSupportedShadingTypeException__ – represents an exception for a shading type which is not supported. This exception has e ShadingType property which specifies the type of the shading.            
            

* __NotSupportedStreamTypeException__ – represents an exception for a stream type which is not supported. A stream is not supported if it does not support read or seek. This exception has a SupportSeek and SupportRead properties which specify whether the stream supports them.            
            

* __NotSupportedPredefinedCMapException__ – represents an exception for a predefined CMap which is not supported by RadPdfViewer. This exception has a CMapName which specifies the name of the predefined CMap.            
            

* __NotSupportedScanDecoderException__ – this exception is thrown if the document contains a scan decoder which is not supported by RadPdfViewer.            
            

* __NotSupportedXObjectTypeException__ – this exception is thrown if the document contains a XObject type which is not supported by RadPdfViewer.  
            
{% else %}

Since R3 2020 __RadPdfViewer__ uses the model of the [RadPdfProcessing] (https://docs.telerik.com/devtools/document-processing/libraries/radpdfprocessing/overview) library. This means that the document loading is handled by the library and RadPdfViewer is no longer responsible for the exception handling. More information about the exception handling in RadPdfProcessing library is available here: [Handling Exceptions in RadPdfProcessing](https://docs.telerik.com/devtools/document-processing/libraries/radpdfprocessing/features/handling-document-exceptions) 

{% endif %}

