---
title: Printing
page_title: Printing
description: Check our &quot;Printing&quot; documentation article for the RadPdfViewer {{ site.framework_name }} control.
slug: radpdfviewer-printing
tags: printing
published: True
position: 5
---

# {{ site.framework_name }} RadPdfViewer Printing


__RadPdfViewer__ allows printing of the document shown in it. The following article describes the available printing methods, as well as how to use the respective for the feature API.
      

## Using UI

__RadPdfViewer__'s sample UI allows you to print the currently shown PDF document with a simple button click.
![Rad Pdf Viewer Printing 03](images/RadPdfViewer_Printing_03.png)

The button shown in the above picture is actually bound to the __PrintPdfDocumentCommand__ with the help of the __PrintCommandDescriptor__, so you can modify the UI to fit your needs.
        

#### __XAML__

{{region radpdfviewer-printing_0}}
	      <telerik:RadButton Command="{Binding PrintCommandDescriptor.Command}" Visibility="{Binding PrintCommandDescriptor.IsEnabled, Converter={StaticResource BoolToVisibilityConverter}}" HorizontalAlignment="Left" VerticalAlignment="Stretch" Margin="2" Padding="0" HorizontalContentAlignment="Center" VerticalContentAlignment="Center" IsBackgroundVisible="False">
	        <ToolTipService.ToolTip>
	          <TextBlock Text="Print" />
	        </ToolTipService.ToolTip>
	        <Image Source="/Telerik.Windows.Controls.FixedDocumentViewers;component/Images/printer.png" Stretch="None" />
	      </telerik:RadButton>
{{endregion}}


>tipMore about command descriptors you can find [here]({%slug radpdfviewer-command-descriptors%}).
          

## Printing Programmatically

Additionally, to using the UI, you can print by taking advantage of the __Print()__ and __Print(PrintSettings printSettings)__ methods of __RadPdfViewer__. 

The __PrintSettings__ class holds all possible customization options when invoking printing:
{% if site.site_name == 'Silverlight' %}
* __DocumentName__: Specifies the name of the document.
              

* __PageMargins__: Specifies the page margin of the document.
              

* __UseDefaultPrinter__: Forces silent printing to the default printer. Can only be used in OOB application with elevated trust.
              

* __ForceVector__: Forces vector printing in Silverlight 5. Its default value is true. If set to false, tries to execute vector printing and in case it fails the "old" bitmap printing is executed.
    
* __OpacityThreshold__: Gets or sets the opacity value of visual elements at which Silverlight 5 will round the opacity to 1.0 to support vector printing on PostScript printers or drivers.
          

#### __C#__

{{region radpdfviewer-printing_0}}
	    PrintSettings settings = new PrintSettings()
	    {
	        DocumentName = "My document",
	        PageMargins = new Thickness(50),
	        ForceVector = true,
            OpacityThreshold = 0.5
	    };

	    this.pdfViewer.Print(settings);
{{endregion}}
{% endif %}
{% if site.site_name == 'WPF' %}

* __DocumentName__: Specifies the name of the document.
              

* __PageMargins__: Specifies the page margin of the document.
              

* __UseDefaultPrinter__: Forces silent printing to the default printer. 

#### __C#__

{{region radpdfviewer-printing_1}}
	    PrintSettings settings = new PrintSettings()
	    {
	        DocumentName = "My document",
	        PageMargins = new Thickness(50),
	        UseDefaultPrinter = true
	    };

	    this.pdfViewer.Print(settings);
{{endregion}}

RadPdfViewer also provides a __Print(PrintDialog printDialog, PrintSettings settings)__ method. It allows you to pass an already initialized PrintDialog instance to the method and print the PDF document shown in the viewer. This means that you have control over the way the document is printed and can, for example, print it silently to a printer other than the default one.

>tipYou can download a runnable project showing how you can customize the printing functionality from our online [SDK repository on GitHub](https://github.com/telerik/xaml-sdk/tree/master/PdfViewer/CustomPrinting).
{% endif %}


## See Also

 * [Wiring UI]({%slug radpdfviewer-wiring-ui%})
