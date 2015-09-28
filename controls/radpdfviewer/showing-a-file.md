---
title: Showing a File
page_title: Showing a File
description: Showing a File
slug: radpdfviewer-showing-a-file
tags: showing,a,file
published: True
position: 4
---

# Showing a File



This topic discusses different ways of loading a document in __RadPdfViewer__ and their customization options.
      

* [Showing a PDF file](#showing-a-pdf-file)

* [Binding the Document Source](#binding-the-documentsource-of-radpdfviewer)

## Showing a PDF file

__RadPdfViewer__ exposes a __DocumentSource__ property of type [FixedDocumentStreamSource](http://docs.telerik.com/devtools/wpf/api/html/T_Telerik_Windows_Documents_Fixed_FixedDocumentStreamSource.htm) that can be used to pass a PDF file to the control. There are several ways to set the property.

###  Setting the DocumentSource in XAML

The first thing you need to do is declare the Telerik namespace as shown in __Example 1__.

#### __[XAML] Example 1: Define Telerik Namespace__

{{region radpdfviewer-showing-a-file_0}}
	    xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"
{{endregion}}



After that, you can proceed to add the **PdfViewer** control to the user control:

#### __[XAML] Example 2: Create RadPdfViewer__

{{region radpdfviewer-showing-a-file_1}}
	<Grid>
	    <telerik:RadPdfViewer x:Name="pdfViewer" DocumentSource="PdfViewerDemo;component/SampleData/Sample.pdf"/>
	</Grid>
{{endregion}}


In the example above, a file named "Sample.pdf" embedded in a "Sample Data" folder in the {% if site.site_name == 'Silverlight' %} Silverlight {% endif %}{% if site.site_name == 'WPF' %} WPF {% endif %} project will be shown when the page is loaded. PdfViewerDemo is the name of the {% if site.site_name == 'Silverlight' %} Silverlight {% endif %}{% if site.site_name == 'WPF' %} WPF {% endif %} project. 


{% if site.site_name == 'Silverlight' %}You can just as well load files that are not on the client machine. For example, if you embed a Sample.pdf file in the Web project, you can load it like this: 

#### __XAML__

{{region radpdfviewer-showing-a-file_2}}
	<telerik:RadPdfViewer x:Name="pdfViewer" DocumentSource="/Sample.pdf"/>
{{endregion}}


>PDF files can be opened as long as you can obtain a stream with their content that supports *Read and Seek operations*. Note that due to Silverlight's security policy, only files from a domain with permissive cross-domain policy can be loaded. Furthermore, if the stream supports only Read, its content should be copied to a MemoryStream, which will enable the Seek operation as well and will facilitate **RadPdfViewer** to show the document. Notice that the document is loaded **asynchronously** and the stream **shouldn't be closed**.{% endif %}


{% if site.site_name == 'WPF' %}
>PDF files can be opened as long as you can obtain a stream with their content that supports *Read and Seek operations*. If the stream supports only Read, its content should be copied to a MemoryStream, which will enable the Seek operation as well and will facilitate **RadPdfViewer** to show the document. Notice that the document is loaded **asynchronously** and the stream **shouldn't be closed**.{% endif %}


### Setting DocumentSource in Code-Behind

In code-behind, you can set the DocumentSource to either a URI or a Stream.

__Example 3__ shows how a PDF file can be loaded from a file embedded as a resource through a _Stream_:

#### __[C#] Example 3: Load PDF from Stream__

{{region radpdfviewer-showing-a-file_3}}
	private void LoadFromStream(object sender, System.Windows.RoutedEventArgs e)
	{
	    Stream str = App.GetResourceStream(new System.Uri("PdfViewerDemo;component/SampleData/Sample.pdf", System.UriKind.Relative)).Stream;
	    this.pdfViewer.DocumentSource = new PdfDocumentSource(str);
	}        
{{endregion}}



And this is how this can be done by passing its URI:

#### __[C#] Example 4: Load PDF from URI__

{{region radpdfviewer-showing-a-file_4}}
	private void LoadFromUri(object sender, System.Windows.RoutedEventArgs e)
	{
	    this.pdfViewer.DocumentSource = new PdfDocumentSource(new System.Uri("PdfViewerDemo;component/SampleData/Sample.pdf", System.UriKind.Relative)); 
	}
{{endregion}}



>In __Example 3 and 4__ PdfViewerDemo is the name of the project and the PDF file is embedded as a Resource in a folder called SampleData.


### Setting Document in Code-Behind

__PdfDocumentSource__ internally uses the __PdfFormatProvider__ class to create a document for __RadPdfViewer__. This allows you to easily import your documents using directly __PdfFormatProvider__ instead of __PdfDocumentSource__.
              

#### __[C#] Example 5: Set RadFixedDocument through PdfFormatProvider__

{{region radpdfviewer-showing-a-file_5}}
	string pdfFilePath = "Sample.pdf";
	MemoryStream stream = new MemoryStream();
	
	using (Stream input = File.OpenRead(pdfFilePath))
	{
	    input.CopyTo(stream);
	}
	
	FormatProviderSettings settings = new FormatProviderSettings(ReadingMode.OnDemand);
	PdfFormatProvider provider = new PdfFormatProvider(stream, settings);
	RadFixedDocument doc = provider.Import();
	this.pdfViewer.Document = doc;
{{endregion}}
              

## Binding the DocumentSource of RadPdfViewer

The __DocumentSource__ of __RadPdfViewer__ is implemented as a dependency property and can be bound to a __Uri__, __string__ representing a Uri, or a __Stream__. This is done with the help of __PdfDocumentSourceValueConverter__, which caters to creating a PdfDocumentSource and presenting it to the viewer.
        

This is how the converter can be declared:

#### __[XAML] Example 6: Define Fixed Namespace__

{{region radpdfviewer-showing-a-file_6}}
	xmlns:fixed="clr-namespace:Telerik.Windows.Documents.Fixed;assembly=Telerik.Windows.Controls.FixedDocumentViewers"
{{endregion}}



#### __[XAML] Example 7: Define PdfDocumentSourceValueConverter__

{{region radpdfviewer-showing-a-file_7}}
	<Grid.Resources>
	    <fixed:PdfDocumentSourceValueConverter x:Key="PdfDocumentSourceValueConverter" />
	</Grid.Resources>
{{endregion}}



The bound property can be implemented as follows:


#### __[C#] Example 8: Create Property__

{{region radpdfviewer-showing-a-file_8}}
	public class Context
	{
	    public [string/Uri/Stream] Source { get; set; }
	}
{{endregion}}

Notice that regardless of the type of the property you choose to bind the DocumentSource of the **PdfViewer** to, the XAML is identical.

#### __[XAML] Example 9: Bind DocumentSource Property of RadPdfViewer__

{{region radpdfviewer-showing-a-file_9}}
	<telerik:RadPdfViewer x:Name="viewer" DocumentSource="{Binding Source, Converter={StaticResource PdfDocumentSourceValueConverter}}" />
{{endregion}}


# See Also

* [Getting Started]({%slug radpdfviewer-getting-started%})

* [Viewer Modes]({%slug radpdfviewer-viewer-modes%})
