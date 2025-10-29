---
title: Showing a File
page_title: Showing a File
description: Check our &quot;Showing a File&quot; documentation article for the RadPdfViewer WPF control.
slug: radpdfviewer-showing-a-file
tags: showing,a,file
published: True
position: 4
---

# Showing a File

This help article discusses different ways of loading a document in `RadPdfViewer` and their customization options.

## Showing a PDF file

RadPdfViewer exposes a `DocumentSource` property of type [FixedDocumentStreamSource](https://docs.telerik.com/devtools/wpf/api/telerik.windows.documents.fixed.fixeddocumentstreamsource) that can be used to pass a PDF file to the control. There are several ways to set the property.

###  Setting the DocumentSource in XAML

First, you need to declare the Telerik namespace as shown in the following example.

__Define Telerik namespace__

```XAML

	xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation" 
```

After that, you can proceed to add the PdfViewer control to the user control as shown below.

>Make sure to set the __Build Action__ of the file to __Resource__ so it can be accessed through URI.

__Create RadPdfViewer__

```XAML
	<Grid>
	    <telerik:RadPdfViewer x:Name="pdfViewer" DocumentSource="PdfViewerDemo;component/SampleData/Sample.pdf"/>
	</Grid>
```

In __Example 2__, a file named "Sample.pdf" embedded in a "Sample Data" folder in the WPF project will be shown when the page is loaded. PdfViewerDemo is the name of the project. 

>PDF files can be opened as long as you can obtain a stream with their content that supports *Read and Seek operations*. If the stream supports only Read, its content should be copied to a MemoryStream, which will enable the Seek operation as well and will facilitate RadPdfViewer to show the document. Notice that the document is loaded __asynchronously__ and the stream __shouldn't be closed__.

### Setting DocumentSource in Code-Behind

In code-behind, you can set the DocumentSource to either a URI or a stream.

The following example shows how a PDF file can be loaded from a file embedded as a resource through a _stream_:

__Load PDF from a stream__

```C#

	private void LoadFromStream(object sender, System.Windows.RoutedEventArgs e)
	{
	    Stream str = App.GetResourceStream(new System.Uri("PdfViewerDemo;component/SampleData/Sample.pdf", System.UriKind.Relative)).Stream;
	    this.pdfViewer.DocumentSource = new PdfDocumentSource(str);
	}        
```

The next shows how a PDF can be loaded from a file embedded as a resource by passing its URI:

__Load PDF from a URI__

```C#

	private void LoadFromUri(object sender, System.Windows.RoutedEventArgs e)
	{
	    this.pdfViewer.DocumentSource = new PdfDocumentSource(new System.Uri("PdfViewerDemo;component/SampleData/Sample.pdf", System.UriKind.Relative)); 
	}
```

In the above two examples, PdfViewerDemo is the name of the project and the PDF file is embedded as a resource in a folder called SampleData.

>note The `PdfDocumentSource` class exposes the `Loaded` event. This event is not related to the parsing of the content but is fired just after the document is being imported.

### Setting the Document in Code-Behind

PdfDocumentSource internally uses the `PdfFormatProvider` class to create a document for RadPdfViewer. This allows you to easily import your documents directly using PdfFormatProvider instead of PdfDocumentSource.
              
__Set RadFixedDocument through PdfFormatProvider__

```C#

    string pdfFilePath = "Sample.pdf";
    MemoryStream stream = new MemoryStream();
    
    using (Stream input = File.OpenRead(pdfFilePath))
    {
        input.CopyTo(stream);
    }
    
    PdfFormatProvider provider = new PdfFormatProvider();
    provider.ImportSettings = PdfImportSettings.ReadOnDemand;
    RadFixedDocument doc = provider.Import(stream, null);
    this.pdfViewer.Document = doc;
```

>It is important to set the `Document` property to __null__ prior to removing it from the visual tree as it is necessary for the RadPdfViewer control instance to be garbage collected.

## Binding the DocumentSource of RadPdfViewer

The DocumentSource of RadPdfViewer is implemented as a dependency property and can be bound to a `URI`, __string__ representing a URI, or a __stream__. This is done with the help of `PdfDocumentSourceValueConverter`, which caters to creating a PdfDocumentSource and presenting it to the viewer.
        
The next two examples show how to declare the converter:

__Define a Fixed namespace__

```XAML
	xmlns:fixed="clr-namespace:Telerik.Windows.Documents.Fixed;assembly=Telerik.Windows.Controls.FixedDocumentViewers"
```

__Define a PdfDocumentSourceValueConverter__

```XAML
	<Grid.Resources>
	    <fixed:PdfDocumentSourceValueConverter x:Key="PdfDocumentSourceValueConverter" />
	</Grid.Resources>
```

The bound property can be implemented as shown in the below two examples:

__Create the property__

```C#
	public class Context
	{
	    public [string/Uri/Stream] Source { get; set; }
	}
```
Notice that regardless of the type of the property you choose to bind the DocumentSource of the PdfViewer to, the XAML is identical.

__Bind the DocumentSource property of RadPdfViewer__

```XAML
	<telerik:RadPdfViewer x:Name="viewer" DocumentSource="{Binding Source, Converter={StaticResource PdfDocumentSourceValueConverter}}" />
```

## Specifying Reading Mode

You can control the way the documents are loaded in RadPdfViewer. You can choose between loading the whole document at one time or loading it page by page. The second option means that you no longer needed to parse the entire document in order to show it. However, you will need to keep the stream to the document file open.
        

You can control how the document is loaded by setting the `PdfViewer.DefaultImportSettings` property.  This property is used when the `OpenPdfDocumentCommand` is triggered to open a PDF file and could be set to one of the settings exposed by the [PdfImportSettings class](https://docs.telerik.com/devtools/document-processing/libraries/radpdfprocessing/formats-and-conversion/pdf/pdfformatprovider/settings). 

__Setting DefaultImportSettings__

```C#
	this.pdfViewer.DefaultImportSettings = PdfImportSettings.ReadOnDemand;
```

Another option to set the reading mode is through the constructors that accept `PdfImportSettings` when creating a new instance of the PdfDocumentSource class. 

The default settings used by PdfViewer are `ReadingMode: OnDemand` and `CopyStream: true` to allow you parse only the needed content while you are not obligated to keep the stream to the document open.

If you want to change this behavior to read all the document pages at the beginning of the import, you can create a new PdfDocumentSource instance with `FormatProviderSettings.ReadAllAtOnce` predefined settings.            

__Setting PdfImportSettings__

```C#

	PdfDocumentSource source = new PdfDocumentSource(stream/uri, PdfImportSettings.ReadOnDemand);      
``` 

When you bind the DocumentSource property of RadPdfViewer and want to control the way bound documents are loaded, you can pass the desired settings as a ConverterParameter.

__Applying settings in binding scenario__

```XAML
	<telerik:RadPdfViewer x:Name="viewer" DocumentSource="{Binding Uri, Converter={StaticResource PdfDocumentSourceValueConverter}, ConverterParameter=ReadOnDemand}" />
```

`ReadAllAtOnce` and `ReadOnDemand` are the valid values you can specify.

## Handling Errors

Sometimes, the loading of the document might not success due to different reasons and an exception might be thrown. You can handle the errors in a way suitable for your application using the [Exception Handling](https://docs.telerik.com/devtools/document-processing/libraries/radpdfprocessing/features/handling-document-exceptions) mechanism of the model of PdfViewer - **PdfProcessing**. 

## See Also

* [Getting Started]({%slug radpdfviewer-getting-started%})

* [Viewer Modes]({%slug radpdfviewer-viewer-modes%})

* [Exception Handling](https://docs.telerik.com/devtools/document-processing/libraries/radpdfprocessing/features/handling-document-exceptions)