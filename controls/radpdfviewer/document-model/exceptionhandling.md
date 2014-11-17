---
title: Exception Handling 
page_title: Exception Handling 
description: Exception Handling 
slug: radpdfviewer-document-model-exceptionhandling
tags: exception,handling,
published: True
position: 1
---

# Exception Handling 



__RadPdfViewer__ provides an API for handling exceptions caused by documents which cannot be loaded correctly because of unsupported features of the control. More information about the unsupported features in __RadPdfViewer__ is available [here]({%slug radpdfviewer-unsupported-features%}).
      

## How to Handle Exceptions

The DocumentSource property of RadPdfViewer exposes an OnException event. The event handler receives two arguments:

* The sender argument contains the DocumentSource. This argument is of type object, but can be cast to the __Telerik.Windows.Documents.Fixed.PdfDocumentSource__ type.
            

* A __Telerik.Windows.Documents.Fixed.Model.OnDocumentExceptionEventArgs__ object. This argument allows you to access the actual exception thrown by __RadPdfViewer__.
            

This is an example how to subscribe the event and handle the exception if there is an unsupported filter:
        

#### __C#__

{{region radpdfviewer-document-model-exceptionhandling_0}}
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
{{endregion}}



The __Telerik.Windows.Documents.Fixed.OnExceptionEventArgs__ has an Exception property which represents the actual exception thrown by __RadPdfViewer__. All exceptions for features which are not supported by __RadPdfViewer__ inherit from the __Telerik.Windows.Documents.Exceptions.NotSupportedFeatureException__ class:
        

* __NotSupportedFilterException__: represents an exception for a filter which is not supported. This exception has a FilterName property which specifies the name of the filter.
            

* __NotSupportedEncryptionException__ - represents an exception for an encryption which is not supported. This exception has e EncryptionCode property which specifies the code of the encryption.            
            

* __NotSupportedFontException__ – represents an exception for a font which is not supported. This exception has a FontType property which specifies the type of the font.            
            

* __NotSupportedShadingTypeException__ – represents an exception for a shading type which is not supported. This exception has e ShadingType property which specifies the type of the shading.            
            

* __NotSupportedStreamTypeException__ – represents an exception for a stream type which is not supported. A stream is not supported if it does not support read or seek. This exception has a SupportSeek and SupportRead properties which specify whether the stream supports them.            
            

* __NotSupportedPredefinedCMapException__ – represents an exception for a predefined CMap which is not supported by RadPdfViewer. This exception has a CMapName which specifies the name of the predefined CMap.            
            

* __NotSupportedScanDecoderException__ – this exception is thrown if the document contains a scan decoder which is not supported by RadPdfViewer.            
            

* __NotSupportedXObjectTypeException__ – this exception is thrown if the document contains a XObject type which is not supported by RadPdfViewer.  
            

