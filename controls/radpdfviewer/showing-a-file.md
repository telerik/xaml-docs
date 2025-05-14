---
title: Showing a File
page_title: Showing a File
description: Check our &quot;Showing a File&quot; documentation article for the RadPdfViewer {{ site.framework_name }} control.
slug: radpdfviewer-showing-a-file
tags: showing,a,file
published: True
position: 4
---

# Showing a File



This help article discusses different ways of loading a document in __RadPdfViewer__ and their customization options.


## Showing a PDF file

__RadPdfViewer__ exposes a __DocumentSource__ property of type {% if site.site_name == 'WPF' %}[FixedDocumentStreamSource](https://docs.telerik.com/devtools/wpf/api/telerik.windows.documents.fixed.fixeddocumentstreamsource){% endif %}{% if site.site_name == 'Silverlight' %}[FixedDocumentStreamSource](https://docs.telerik.com/devtools/silverlight/api/telerik.windows.documents.fixed.fixeddocumentstreamsource){% endif %} that can be used to pass a PDF file to the control. There are several ways to set the property.

###  Setting the DocumentSource in XAML

First, you need to declare the Telerik namespace as shown in __Example 1__.

#### __[XAML] Example 1: Define Telerik namespace__

{{region radpdfviewer-showing-a-file_0}}

	xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation" 
{{endregion}}



After that, you can proceed to add the **PdfViewer** control to the user control as shown in __Example 2__.

>Make sure to set the Build Action of the file to Resource so it can be accessed through URI.

#### __[XAML] Example 2: Create RadPdfViewer__

{{region radpdfviewer-showing-a-file_1}}
	<Grid>
	    <telerik:RadPdfViewer x:Name="pdfViewer" DocumentSource="PdfViewerDemo;component/SampleData/Sample.pdf"/>
	</Grid>
{{endregion}}


In __Example 2__, a file named "Sample.pdf" embedded in a "Sample Data" folder in the {{ site.framework_name }} project will be shown when the page is loaded. PdfViewerDemo is the name of the project. 

{% if site.site_name == 'Silverlight' %}
You can also load files that are not on the client machine. For example, if you embed a Sample.pdf file in the Web project, you can load it like this: 

#### __XAML__

{{region radpdfviewer-showing-a-file_2}}
	<telerik:RadPdfViewer x:Name="pdfViewer" DocumentSource="/Sample.pdf"/>
{{endregion}}


>PDF files can be opened as long as you can obtain a stream with their content that supports *Read and Seek operations*. Note that due to Silverlight's security policy, only files from a domain with permissive cross-domain policy can be loaded. Furthermore, if the stream supports only Read, its content should be copied to a MemoryStream, which will enable the Seek operation as well and will facilitate **RadPdfViewer** to show the document. Notice that the document is loaded **asynchronously** and the stream **shouldn't be closed**.
{% endif %}


{% if site.site_name == 'WPF' %}
>PDF files can be opened as long as you can obtain a stream with their content that supports *Read and Seek operations*. If the stream supports only Read, its content should be copied to a MemoryStream, which will enable the Seek operation as well and will facilitate **RadPdfViewer** to show the document. Notice that the document is loaded **asynchronously** and the stream **shouldn't be closed**.
{% endif %}


### Setting DocumentSource in Code-Behind

In code-behind, you can set the DocumentSource to either a URI or a stream.

__Example 3__ shows how a PDF file can be loaded from a file embedded as a resource through a _stream_:

#### __[C#] Example 3: Load PDF from a stream__

{{region radpdfviewer-showing-a-file_3}}

	private void LoadFromStream(object sender, System.Windows.RoutedEventArgs e)
	{
	    Stream str = App.GetResourceStream(new System.Uri("PdfViewerDemo;component/SampleData/Sample.pdf", System.UriKind.Relative)).Stream;
	    this.pdfViewer.DocumentSource = new PdfDocumentSource(str);
	}        
{{endregion}}



__Example 4__ shows how a PDF can be loaded from a file embedded as a resource by passing its URI:

#### __[C#] Example 4: Load PDF from a URI__

{{region radpdfviewer-showing-a-file_4}}

	private void LoadFromUri(object sender, System.Windows.RoutedEventArgs e)
	{
	    this.pdfViewer.DocumentSource = new PdfDocumentSource(new System.Uri("PdfViewerDemo;component/SampleData/Sample.pdf", System.UriKind.Relative)); 
	}
{{endregion}}



In __Example 3__ and __Example 4__, PdfViewerDemo is the name of the project and the PDF file is embedded as a resource in a folder called SampleData.


>note The **PdfDocumentSource** class exposes the **Loaded** event. This event is not related to the parsing of the content but is fired just after the document is being imported.


### Setting the Document in Code-Behind

__PdfDocumentSource__ internally uses the __PdfFormatProvider__ class to create a document for __RadPdfViewer__. This allows you to easily import your documents directly using __PdfFormatProvider__ instead of __PdfDocumentSource__.
              
#### __[C#] Example 5: Set RadFixedDocument through PdfFormatProvider__

{{region radpdfviewer-showing-a-file_5}}

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
{{endregion}}
              

## Binding the DocumentSource of RadPdfViewer

The __DocumentSource__ of __RadPdfViewer__ is implemented as a dependency property and can be bound to a __URI__, __string__ representing a URI, or a __stream__. This is done with the help of __PdfDocumentSourceValueConverter__, which caters to creating a PdfDocumentSource and presenting it to the viewer.
        

__Example 6__ and __Example 7__ show how to declare the converter:

#### __[XAML] Example 6: Define a Fixed namespace__

{{region radpdfviewer-showing-a-file_6}}
	xmlns:fixed="clr-namespace:Telerik.Windows.Documents.Fixed;assembly=Telerik.Windows.Controls.FixedDocumentViewers"
{{endregion}}



#### __[XAML] Example 7: Define a PdfDocumentSourceValueConverter__

{{region radpdfviewer-showing-a-file_7}}
	<Grid.Resources>
	    <fixed:PdfDocumentSourceValueConverter x:Key="PdfDocumentSourceValueConverter" />
	</Grid.Resources>
{{endregion}}



The bound property can be implemented as shown in __Example 8__ and __Example 9__.:


#### __[C#] Example 8: Create the property__

{{region radpdfviewer-showing-a-file_8}}
	public class Context
	{
	    public [string/Uri/Stream] Source { get; set; }
	}
{{endregion}}

Notice that regardless of the type of the property you choose to bind the DocumentSource of the **PdfViewer** to, the XAML is identical.

#### __[XAML] Example 9: Bind the DocumentSource property of RadPdfViewer__

{{region radpdfviewer-showing-a-file_9}}
	<telerik:RadPdfViewer x:Name="viewer" DocumentSource="{Binding Source, Converter={StaticResource PdfDocumentSourceValueConverter}}" />
{{endregion}}

## Specifying Reading Mode

You can control the way the documents are loaded in RadPdfViewer. You can choose between loading the whole document at one time or loading it page by page. The second option means that you no longer needed to parse the entire document in order to show it. However, you will need to keep the stream to the document file open.
        

You can control how the document is loaded by setting the {% if site.site_name == 'WPF' %} **PdfViewer.DefaultImportSettings** {% else %}  **PdfViewer.DefaultFormatProviderSettings** {% endif %} property.  {% if site.site_name == 'WPF' %}This property is used when the OpenPdfDocumentCommand is triggered to open a PDF file and could be set to one of the settings exposed by the [PdfImportSettings class](https://docs.telerik.com/devtools/document-processing/libraries/radpdfprocessing/formats-and-conversion/pdf/pdfformatprovider/settings). {% endif %} 
{% if site.site_name == 'Silverlight' %}

* __ReadAllAtOnce__: This value is used by default. When ReadAllAtOnce is applied, the document stream will be copied into a memory stream, which is used by PdfViewer. When you are loading a document through an URI in combination with ReadAllAtOnce, the stream to the resource will be closed as soon as it is copied to memory. 

* __ReadOnDemand__: Each page of the document is loaded dynamically when necessary (to be shown in the PdfViewer, printed, etc.) and it is unloaded once it becomes invisible. The stream that holds the document stays opened while the document is used in PdfViewer.
            

#### __[C#] Example 10: Setting DefaultFormatProviderSettings__

{{region radpdfviewer-showing-a-file_10}}
	this.pdfViewer.DefaultFormatProviderSettings = FormatProviderSettings.ReadOnDemand;
{{endregion}}

{% else %}

#### __[C#] Example 10: Setting DefaultImportSettings__

{{region radpdfviewer-showing-a-file_10}}
	this.pdfViewer.DefaultImportSettings = PdfImportSettings.ReadOnDemand;
{{endregion}}

{% endif %}

Another option to set the reading mode is through the constructors that accept {% if site.site_name == 'WPF' %} **PdfImportSettings** {% else %}__FormatProviderSettings__{% endif %} when creating a new instance of the **PdfDocumentSource** class. 

{% if site.site_name == 'Silverlight' %}The __ReadOnDemand__ predefined settings are used by default.{% else %}The default settings used by PdfViewer are `ReadingMode: OnDemand` and `CopyStream: true` to allow you parse only the needed content while you are not obligated to keep the stream to the document open.{% endif %} 

If you want to change this behavior to read all the document pages at the beginning of the import, you can create a new __PdfDocumentSource__ instance with __FormatProviderSettings.ReadAllAtOnce__ predefined settings.            

{% if site.site_name == 'WPF' %}
#### __[C#] Example 11: Setting PdfImportSettings__

{{region radpdfviewer-showing-a-file_11}}

	PdfDocumentSource source = new PdfDocumentSource(stream/uri, PdfImportSettings.ReadOnDemand);      
{{endregion}} 

{% else %}

#### __[C#] Example 11: Setting FormatProviderSettings__

{{region radpdfviewer-showing-a-file_11}}

	PdfDocumentSource source = new PdfDocumentSource(stream/uri, FormatProviderSettings.ReadOnDemand);      
{{endregion}} 

{% endif %}


When you bind the __DocumentSource__ property of __RadPdfViewer__ and want to control the way bound documents are loaded, you can pass the desired settings as a ConverterParameter.
            

#### __[XAML] Example 12: Applying settings in binding scenario__

{{region radpdfviewer-showing-a-file_12}}
	<telerik:RadPdfViewer x:Name="viewer" DocumentSource="{Binding Uri, Converter={StaticResource PdfDocumentSourceValueConverter}, ConverterParameter=ReadOnDemand}" />
{{endregion}}

`ReadAllAtOnce` and `ReadOnDemand` are the valid values you can specify.

{% if site.site_name == 'WPF' %}
## Handling Errors

Sometimes, the loading of the document might not success due to different reasons and an exception might be thrown. You can handle the errors in a way suitable for your application using the [Exception Handling](https://docs.telerik.com/devtools/document-processing/libraries/radpdfprocessing/features/handling-document-exceptions) mechanism of the model of PdfViewer - **PdfProcessing**. 
{% endif %}

## See Also

* [Getting Started]({%slug radpdfviewer-getting-started%})

* [Viewer Modes]({%slug radpdfviewer-viewer-modes%})

{% if site.site_name == 'WPF' %}
* [Exception Handling](https://docs.telerik.com/devtools/document-processing/libraries/radpdfprocessing/features/handling-document-exceptions)
{% endif %}
