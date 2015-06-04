---
title: Export Support
page_title: Export Support
description: Export Support
slug: common-export-support
tags: export,support
published: True
position: 11
---

# Export Support

More often than not, it is a good idea to be able to persist the data that the different controls show and edit during the life cycle of the application even after the application is closed. There are different ways to save this information and various approaches can be adopted depending on the type of the content.
	  
## Export using ExportExtensions

Some of our controls can be exported directly using the *ExportExtensions* class which is part of the __Telerik.Windows.Controls__ assembly. It allows you to export in several file formats listed below:
		
1. __Image formats__

	* __Png__ - Portable Netwok Graphic. Use ExportToImage(FrameworkElement, Stream) method.

	* __Bmp__ - Bitmap file. Use ExportToImage(FrameworkElement, Stream, BitmapEncoder) where the encoder is of type BmpBitmapEncoder().
	
	* __Xps__ - XML Paper Specification file. Use ExportToXpsImage(FrameworkElement, Stream) method to export some content as an XPS image.

	This is particularly convenient for controls which have a size that allows direct export on one page, such as a __RadGauge__ or a __RadChart__ for example.
	
1. __ExcelML__ - ExcelML file, supported by Office 2003 and above. Use ExportToExcelML(FrameworkElement, Stream) method.

	For instance, controls that support export to ExcelML are __RadChart__ and __RadGridView__.

{% if site.site_name == 'WPF' %}
>In WPF there are overloads for the methods listed above, which take as parameter the name of the file you want to export to, instead of a stream. This allows you to easily export your control directly to a file.
{% endif %}

The following example demonstrates how to export RadGauge to Png file format. The physical path to the image is provided run-time via *SaveFileDialog*:

{% if site.site_name == 'Silverlight' %}
#### __C#__

{{region common-export-support_0}}
	 private void Button_Click(object sender, RoutedEventArgs e)
	  {
		string extension = "png";
		SaveFileDialog dialog = new SaveFileDialog()
		{
			DefaultExt = extension,
			Filter = "Png (*.png)|*.png"
		};
	
		if (dialog.ShowDialog() == true)
		{
			using (Stream stream = dialog.OpenFile())
			{
				Telerik.Windows.Media.Imaging.ExportExtensions.ExportToImage(
					 this.radGauge, stream, new Telerik.Windows.Media.Imaging.PngBitmapEncoder());
			}
		}
	}
{{endregion}}

#### __VB.NET__

{{region common-export-support_1}}
	 Private Sub Button_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
		Dim extension As String = "png"
		Dim dialog As New SaveFileDialog() With {.DefaultExt = extension, .Filter = "Png (*.png)|*.png"}
	
		If dialog.ShowDialog() = True Then
			Using stream As Stream = dialog.OpenFile()
				Telerik.Windows.Media.Imaging.ExportExtensions.ExportToImage(Me.radGauge, stream, New Telerik.Windows.Media.Imaging.PngBitmapEncoder())
			End Using
		End If
	 End Sub
{{endregion}}
{% endif %}

{% if site.site_name == 'WPF' %}
#### __C#__

{{region common-export-support_2}}
	 private void Button_Click(object sender, RoutedEventArgs e)
	  {
		string extension = "png";
		SaveFileDialog dialog = new SaveFileDialog()
		{
			DefaultExt = extension,
			Filter = "Png (*.png)|*.png"
		};
	
		if (dialog.ShowDialog() == true)
		{
			using (Stream stream = dialog.OpenFile())
			{
				Telerik.Windows.Media.Imaging.ExportExtensions.ExportToImage(
					 this.radGauge, stream, new System.Windows.Media.Imaging.PngBitmapEncoder());
			}
		}
	}
{{endregion}}

#### __VB.NET__

{{region common-export-support_0}}
	 Private Sub Button_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
		Dim extension As String = "png"
		Dim dialog As New SaveFileDialog() With {.DefaultExt = extension, .Filter = "Png (*.png)|*.png"}
	
		If dialog.ShowDialog() = True Then
			Using stream As Stream = dialog.OpenFile()
				Telerik.Windows.Media.Imaging.ExportExtensions.ExportToImage(Me.radGauge, stream, New System.Windows.Media.Imaging.PngBitmapEncoder())
			End Using
		End If
	 End Sub
{{endregion}}
{% endif %}

## Export through RadDocument

__RadDocument__ is the document used in __RadRichTextBox__, but you can also create a document programmatically, insert different content and then proceed to save the document.
The formats that RadDocument can be exported to are:
		
* DOCX;

* RTF;

* HTML;

* PDF;

* plain text.

This approach should be utilized when the content is more complex – text and images, tables, etc. and spans several pages. What should be kept in mind is to create the document in accordance with the structure outlined here:{% if site.site_name == 'WPF' %}[Elements Hierarchy]({%slug radrichtextbox-features-document-elements-hierarchy%}){% endif %}{% if site.site_name == 'Silverlight' %}[Elements Hierarchy]({%slug radrichtextbox-features-document-elements-hierarchy%}){% endif %}.
		
Examples for creating a RadDocument with different content can be found in RadRichTextBox's documentation: {% if site.site_name == 'WPF' %}[Printing guidelines]({%slug radrichtextbox-guidelines-for-printing-with-raddocument%}){% endif %}{% if site.site_name == 'Silverlight' %}[Printing guidelines]({%slug radrichtextbox-guidelines-for-printing-with-raddocument%}){% endif %}.
		
The export of RadDocument is carried out through format providers - there is a different format provider for each of the formats. Detailed information on the assembly references that must be added and the customization options can be found in the Import/Export article: {% if site.site_name == 'WPF' %}[Export using format providers]({%slug radrichtextbox-features-import-export%}){% endif %}{% if site.site_name == 'Silverlight' %}[Export using format providers]({%slug radrichtextbox-features-import-export%}){% endif %}.
		
Here is a simple example how a document with a RadChart, a RadGauge and some text can be created and exported to docx:		

#### __C#__

{{region common-export-support_1}}
	private void export_Click(object sender, System.Windows.RoutedEventArgs e)
	    {
	        SaveFileDialog sfd = new SaveFileDialog();
	        sfd.DefaultExt = "docx";
	        sfd.Filter = "docx File (*.docx) | *.docx";
	        if (sfd.ShowDialog() == true)
	        {
	            using (Stream saveFileStream = sfd.OpenFile())
	            {
	                RadDocument document = new RadDocument();
	                Section section = new Section();
	                document.Sections.Add(section);
	                Paragraph paragraph = new Paragraph();
	                section.Blocks.Add(paragraph);
	                Span span = new Span("Here comes a RadChart:");
	                paragraph.Inlines.Add(span);
	
	                using (var stream = new MemoryStream())
	                {
	                    Telerik.Windows.Media.Imaging.ExportExtensions.ExportToImage(this.radChart, stream, new PngBitmapEncoder());
	                    stream.Flush();
	                    stream.Seek(0, SeekOrigin.Begin);
	                    paragraph.Inlines.Add(new ImageInline(stream));
	                }
	
	                Paragraph paragraph2 = new Paragraph();
	                section.Blocks.Add(paragraph2);
	                Span span2 = new Span("And this is a RadGauge in the same document:");
	                paragraph2.Inlines.Add(span2);
	                using (var stream2 = new MemoryStream())
	                {
	                    Telerik.Windows.Media.Imaging.ExportExtensions.ExportToImage(this.radGauge, stream2, new PngBitmapEncoder());
	                    stream2.Flush();
	                    stream2.Seek(0, SeekOrigin.Begin);
	                    paragraph2.Inlines.Add(new ImageInline(stream2));
	                }
	                DocxFormatProvider docx = new DocxFormatProvider();
	                document.EnsureDocumentMeasuredAndArranged();
	                docx.Export(document, saveFileStream);
	            }
	        }
	    }
	}
{{endregion}}

#### __VB__

{{region common-export-support_2}}
	    Public Sub export_click(ByVal sender As Object, ByVal e As RoutedEventArgs)
	        Dim sfd As New SaveFileDialog()
	        sfd.DefaultExt = "docx"
	        sfd.Filter = "docx File (*.docx) | *.docx"
	        If sfd.ShowDialog() = True Then
	            Using saveFileStream As Stream = sfd.OpenFile()
	                Dim document As New RadDocument()
	                Dim section As New Section()
	                document.Sections.Add(section)
	                Dim paragraph As New Paragraph()
	                section.Blocks.Add(paragraph)
	                Dim span As New Span("Here comes a RadChart:")
	                paragraph.Inlines.Add(span)
	
	                Using stream = New MemoryStream()
	                    Telerik.Windows.Media.Imaging.ExportExtensions.ExportToImage(Me.radChart, stream, New PngBitmapEncoder())
	                    stream.Flush()
	                    stream.Seek(0, SeekOrigin.Begin)
	                    paragraph.Inlines.Add(New ImageInline(stream))
	                End Using
	
	                Dim paragraph2 As New Paragraph()
	                section.Blocks.Add(paragraph2)
	                Dim span2 As New Span("And this is a RadGauge in the same document:")
	                paragraph2.Inlines.Add(span2)
	                Using stream2 = New MemoryStream()
	                    Telerik.Windows.Media.Imaging.ExportExtensions.ExportToImage(Me.radGauge, stream2, New PngBitmapEncoder())
	                    stream2.Flush()
	                    stream2.Seek(0, SeekOrigin.Begin)
	                    paragraph2.Inlines.Add(New ImageInline(stream2))
	                End Using
	                Dim docx As New DocxFormatProvider()
	                document.EnsureDocumentMeasuredAndArranged()
	                docx.Export(document, saveFileStream)
	            End Using
	        End If
	
	    End Sub
{{endregion}}
