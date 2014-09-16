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
        Setting the DocumentSource in XAML

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



In the example above, a file named "Sample.pdf" embedded in a "Sample Data" folder in the
                {% if site.site_name == 'Silverlight' %}
                  Silverlight
                {% endif %}{% if site.site_name == 'WPF' %}
                  WPF
                {% endif %}
                project will be shown when the page is loaded.
                PdfViewerDemo is the name of the        {% if site.site_name == 'Silverlight' %}
                  Silverlight
                {% endif %}{% if site.site_name == 'WPF' %}
                  WPF
                {% endif %} project.
              {% if site.site_name == 'Silverlight' %}

You can just as well load files that are not on the client machine. For example, if you embed a Sample.pdf file in the Web project, you can load it like this: 

#### __XAML__

{{region radpdfviewer-showing-a-file_2}}
	<telerik:RadPdfViewer x:Name="pdfViewer" DocumentSource="/Sample.pdf"/>
	{{endregion}}



>PDF files can be opened as long as you can obtain a stream with their content that supports Read and Seek operations. Note that due to Silverlight's security policy, only files from a domain with permissive cross-domain policy can be loaded.
                    Furthermore, if the stream supports only Read, its content should be copied to a MemoryStream, which will enable the Seek operation as well and will facilitate RadPdfViewer to show the document.
                  {% endif %}{% if site.site_name == 'WPF' %}

>PDF files can be opened as long as you can obtain a stream with their content that supports Read and Seek operations.
                    If the stream supports only Read, its content should be copied to a MemoryStream, which will enable the Seek operation as well and will facilitate RadPdfViewer to show the document.
                  {% endif %}Setting the DocumentSource in Code-Behind

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

In 2012 Q1 SP1 we have introduced a new class – __PdfFormatProvider__. __PdfDocumentSource__ internally uses this class to create a document for __RadPdfViewer__.
                Now you can easily import your documents using directly __PdfFormatProvider__ instead of __PdfDocumentSource__.
              

#### __C#__

{{region radpdfviewer-showing-a-file_3}}
	PdfFormatProvider provider = new PdfFormatProvider(stream, settings);
	this.viewer.Document = provider.Import();
	{{endregion}}



The settings specify if the whole document must be loaded at once, or page by page, the values being
                __FormatProviderSettings.ReadAllAtOnce__ and __FormatProviderSettings.ReadOnDemand__ respectively.
              

## Binding the DocumentSource of RadPdfViewer

The __DocumentSource__ of __RadPdfViewer__ is implemented as a dependency property and can be bound to a __Uri__, __string__ representing a Uri, or a __Stream__.
          This is done with the help of __PdfDocumentSourceValueConverter__, which caters to creating a PdfDocumentSource and presenting it to the viewer.
        

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



## Specifying a Loading Mode

Starting from 2012.1. 326 (2012 Q1 SP1) the way the documents are loaded can be controlled.
          One can choose between loading the whole document in one go (as done up to now) and loading it page by page.
          The second option means that it is no longer needed to parse the entire document in order to show it.
        

For example if you want to use  RadPdfViewer to print documents, you should load all pages first and then try to print the document (it is recommended, not required).
          If you want to show big documents or books, then on demand loading will produce better results.
        

You can control how the document is loaded in the following ways:
        

* You can set __PdfViewer.DefaultFormatProviderSettings__ – this property is used when the OpenPdfDocumentCommand is used to open a PDF file.
              The default value is __FormatProviderSettings.ReadOnDemand__.
              If you want to change this behavior when a PDF document is loaded through the command, you can set it to __FormatProviderSettings.ReadAllAtOnce__ in the code behind or to __“ReadAllAtOnce”__ in XAML.
            

#### __C#__

{{region radpdfviewer-showing-a-file_5}}
	this.viewer.DefaultFormatProviderSettings = FormatProviderSettings.ReadAllAtOnce;
	this.viewer.DefaultFormatProviderSettings = FormatProviderSettings.ReadOnDemand;
	{{endregion}}



#### __XAML__

{{region radpdfviewer-showing-a-file_6}}
	DefaultFormatProviderSettings="ReadAllAtOnce"
	DefaultFormatProviderSettings="ReadOnDemand"
	{{endregion}}



* When you set the __PdfDocumentSource__ –
              we have added two new constructors that accept __FormatProviderSettings__
              when creating a new instance of PdfDocumentSource class.
              The __FormatProviderSettings.ReadOnDemand__ predefined settings are used by default.
              If you want to change this behavior to read all pages in the document at once, you can create a new __PdfDocumentSource__ instance
              with __FormatProviderSettings.ReadAllAtOnce__ predefined settings.
            

#### __C#__

{{region radpdfviewer-showing-a-file_4}}
	PdfDocumentSource source = new PdfDocumentSource(stream/uri, FormatProviderSettings.ReadAllAtOnce);      
	{{endregion}}



* When you bind the __DocumentSource__ property of __RadPdfViewer__ and you want to control the way bounded documents are loaded you may pass desired __FormatProviderSettings__ as a ConverterParameter.
            

#### __XAML__

{{region radpdfviewer-showing-a-file_7}}
	<telerik:RadPdfViewer x:Name="viewer" DocumentSource="{Binding Uri, Converter={StaticResource PdfDocumentSourceValueConverter}, ConverterParameter=ReadAllAtOnce}" />
	{{endregion}}

“ReadAllAtOnce” and “ReadOnDemand” are the valid values you can specify.

# See Also

 * [Viewer Modes]({%slug radpdfviewer-viewer-modes%})
