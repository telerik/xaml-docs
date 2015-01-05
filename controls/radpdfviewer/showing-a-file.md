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



This topic will discuss different ways of loading a document in __RadPdfViewer__ and some customization options.
      

* [Showing a PDF file](#showing-a-pdf-file)

* [Binding the Document Source](#binding-the-documentsource-of-radpdfviewer)

* [Specifying a Loading Mode](#specifying-a-loading-mode)

## Showing a PDF file

__RadPdfViewer__ uses a DocumentSource in order to be able to show files that are passed to it as streams, as well as URIs without any code behind.

###  Setting the DocumentSource in XAML

The first thing you need to do is declare the Telerik namespace.

#### __XAML__

{{region radpdfviewer-showing-a-file_0}}
	    xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"
{{endregion}}



After that, you can proceed to add the PdfViewer control to the user control:

#### __XAML__

{{region radpdfviewer-showing-a-file_1}}
	<Grid>
	    <telerik:RadPdfViewer x:Name="pdfViewer" DocumentSource="PdfViewerDemo;component/SampleData/Sample.pdf"/>
	</Grid>
{{endregion}}



In the example above, a file named "Sample.pdf" embedded in a "Sample Data" folder in the {% if site.site_name == 'Silverlight' %} Silverlight {% endif %}{% if site.site_name == 'WPF' %} WPF {% endif %} project will be shown when the page is loaded. PdfViewerDemo is the name of the        {% if site.site_name == 'Silverlight' %} Silverlight {% endif %}{% if site.site_name == 'WPF' %} WPF {% endif %} project. 


{% if site.site_name == 'Silverlight' %}You can just as well load files that are not on the client machine. For example, if you embed a Sample.pdf file in the Web project, you can load it like this: 

#### __XAML__

{{region radpdfviewer-showing-a-file_2}}
	<telerik:RadPdfViewer x:Name="pdfViewer" DocumentSource="/Sample.pdf"/>
{{endregion}}



>PDF files can be opened as long as you can obtain a stream with their content that supports Read and Seek operations. Note that due to Silverlight's security policy, only files from a domain with permissive cross-domain policy can be loaded. Furthermore, if the stream supports only Read, its content should be copied to a MemoryStream, which will enable the Seek operation as well and will facilitate RadPdfViewer to show the document.{% endif %}


{% if site.site_name == 'WPF' %}
>PDF files can be opened as long as you can obtain a stream with their content that supports Read and Seek operations. If the stream supports only Read, its content should be copied to a MemoryStream, which will enable the Seek operation as well and will facilitate RadPdfViewer to show the document. {% endif %}


### Setting the DocumentSource in Code-Behind

In code-behind, you can set the DocumentSource to either a URI or a Stream.

This is how a PDF file can be loaded from a file embedded as a resource through a Stream:

#### __C#__

{{region radpdfviewer-showing-a-file_0}}
	private void LoadFromStream(object sender, System.Windows.RoutedEventArgs e)
	{
	    Stream str = App.GetResourceStream(new System.Uri("PdfViewerDemo;component/SampleData/Sample.pdf", System.UriKind.Relative)).Stream;
	    this.pdfViewer.DocumentSource = new PdfDocumentSource(str);
	}        
{{endregion}}



And this is how this can be done by passing its URI:

#### __C#__

{{region radpdfviewer-showing-a-file_1}}
	private void LoadFromUri(object sender, System.Windows.RoutedEventArgs e)
	{
	    this.pdfViewer.DocumentSource = new PdfDocumentSource(new System.Uri("PdfViewerDemo;component/SampleData/Sample.pdf", System.UriKind.Relative)); 
	}
{{endregion}}



>In the samples above PdfViewerDemo is the name of the project and the PDF file is embedded as a Resource in a folder called SampleData.Setting the Document in Code-Behind

__PdfDocumentSource__ internally uses the _PdfFormatProvider__ class to create a document for __RadPdfViewer__. This allows you to easily import your documents using directly __PdfFormatProvider__ instead of __PdfDocumentSource__.
              

#### __C#__

{{region radpdfviewer-showing-a-file_3}}
	PdfFormatProvider provider = new PdfFormatProvider(stream, settings);
	this.viewer.Document = provider.Import();
{{endregion}}



The settings specify if the whole document must be loaded at once, or page by page, the values being __FormatProviderSettings.ReadAllAtOnce__ and __FormatProviderSettings.ReadOnDemand__ respectively.
              

## Binding the DocumentSource of RadPdfViewer

The __DocumentSource__ of __RadPdfViewer__ is implemented as a dependency property and can be bound to a __Uri__, __string__ representing a Uri, or a __Stream__. This is done with the help of __PdfDocumentSourceValueConverter__, which caters to creating a PdfDocumentSource and presenting it to the viewer.
        

This is how the converter can be declared:

#### __XAML__

{{region radpdfviewer-showing-a-file_3}}
	xmlns:fixed="clr-namespace:Telerik.Windows.Documents.Fixed;assembly=Telerik.Windows.Controls.FixedDocumentViewers"
{{endregion}}



#### __XAML__

{{region radpdfviewer-showing-a-file_4}}
	<Grid.Resources>
	    <fixed:PdfDocumentSourceValueConverter x:Key="PdfDocumentSourceValueConverter" />
	</Grid.Resources>
{{endregion}}



The DataContext can be implemented as follows:

#### __C#__

{{region radpdfviewer-showing-a-file_2}}
	public class Context
	{
	    public [string/Uri/Stream] Source { get; set; }
	}
{{endregion}}



Notice that regardless of the type of the property you choose to bind the DocumentSource of the PdfViewer to, the XAML is identical.

#### __XAML__

{{region radpdfviewer-showing-a-file_5}}
	<telerik:RadPdfViewer x:Name="viewer" DocumentSource="{Binding Source, Converter={StaticResource PdfDocumentSourceValueConverter}}" />
{{endregion}}


# See Also

 * [Viewer Modes]({%slug radpdfviewer-viewer-modes%})
