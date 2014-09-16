---
title: Export To PDF
page_title: Export To PDF
description: Export To PDF
slug: radchart-features-export-to-pdf
tags: export,to,pdf
publish: True
position: 32
---

# Export To PDF



This help topic will demonstrate how to export RadChart and RadGridView controls to PDF document simultaneously. For the purpose you should build the export-to-image functionality and export the image to PDF using our [Documents Format Providers](http://www.telerik.com/help/silverlight/radrichtextbox-features-import-export.html) (also part of the RadControls for Silverlight suite).

>tipA sample project demonstrating Exporting RadChart to PDF can be found in the end of this [blogpost](http://blogs.telerik.com/blogs/posts/11-06-16/pdf-export-with-radchart-for-silverlight.aspx).

Basically, all you need to do is construct a document model based on the contents you want to export, and then pass the document to the __PdfFormatProvider__. This way you can combine the output of several controls into a single document export. To export the chart part of the document:

1. Create new __RadDocument__ instance. 

1. As per the elements hierarchy described in the documentation [here](http://www.telerik.com/help/silverlight/radrichtextbox-features-document-elements-hierarchy.html), first you need to add a single __Section__ to the document, and in the Section - a single __Paragraph__. 

1. Now using the built-in export-to-image functionality in RadChart, export the chart contents into a memory stream and use it to create an __ImageInline__ element that will hold the chart image in the resulting document. 

1. Add the ImageInline element to the Paragraph created earlier.

The following code creates the Chart part of the PDF document:

#### __C#__

{{region radchart-features-export-to-pdf_0}}
	Section section = new Section();
	Paragraph paragraph = new Paragraph();
	BitmapImage bi = new BitmapImage();
	
	 using (MemoryStream ms = new MemoryStream())
	   {
	    RadChart1.ExportToImage(ms, new PngBitmapEncoder());
	    bi.SetSource(ms);
	    }
	
	  ImageInline image = new ImageInline(new WriteableBitmap(bi)) { Width = 700, Height = 500 };
	   paragraph.Inlines.Add(image);
	   section.Blocks.Add(paragraph);
	   document.Sections.Add(section);
	{{endregion}}



#### __VB.NET__

{{region radchart-features-export-to-pdf_1}}
	    Dim section As New Section()
	    Dim paragraph As New Paragraph()
	    Dim bi As New BitmapImage()
	
	Using ms As New MemoryStream()
	RadChart1.ExportToImage(ms, New PngBitmapEncoder())
	bi.SetSource(ms)
	      End Using
	
	    Dim image As New ImageInline(New WriteableBitmap(bi))
	      700, Height = 500
	      Width = 700, Height
	paragraph.Inlines.Add(image)
	section.Blocks.Add(paragraph)
	document.Sections.Add(section)
	{{endregion}}



#### __C#__

{{region radchart-features-export-to-pdf_2}}
	Section section = new Section();
	Paragraph paragraph = new Paragraph();
	
	MemoryStream ms = new MemoryStream();
	RadChart1.ExportToImage(ms, new PngBitmapEncoder());
	ImageInline image = new ImageInline(ms, new Size(700, 500), "png");
	
	paragraph.Inlines.Add(image);
	section.Blocks.Add(paragraph);
	document.Sections.Add(section);
	
	ms.Close();
	{{endregion}}



#### __VB.NET__

{{region radchart-features-export-to-pdf_3}}
	    Dim section As New Section()
	    Dim paragraph As New Paragraph()
	
	    Dim ms As New MemoryStream()
	RadChart1.ExportToImage(ms, New PngBitmapEncoder())
	    Dim image As New ImageInline(ms, New Size(700, 500), "png")
	
	paragraph.Inlines.Add(image)
	section.Blocks.Add(paragraph)
	document.Sections.Add(section)
	
	ms.Close()
	{{endregion}}



As for the grid part of the constructed document – all you need to do is create a second __Section__ element and construct __Table__ with the respective __TableRow__/ __TableCell__ elements. We will not go into details as you may find them as well as the source listing in this [online example](http://demos.telerik.com/silverlight/#GridView/PrintAndExportWithRadDocument) and this blog post [here](http://blogs.telerik.com/vladimirenchev/posts/10-11-11/pdf_export_with_radgridview_for_silverlight_q3_2010.aspx).

Now that the document model is ready, you can add a Button that will function as exporter and call the __PdfFormatProvider.Export(...)__ method from the *Click* event's body like this:

#### __C#__

{{region radchart-features-export-to-pdf_4}}
	private void Export_Click(object sender, System.Windows.RoutedEventArgs e)
	        {
	            SaveFileDialog dialog = new SaveFileDialog();
	            dialog.DefaultExt = "*.pdf";
	            dialog.Filter = "Adobe PDF Document (*.pdf)|*.pdf";
	
	            if (dialog.ShowDialog() == true)
	            {
	                {
	                    RadDocument document = this.CreateDocument();
	                    document.LayoutMode = DocumentLayoutMode.Paged;
	                    document.Measure(RadDocument.MAX_DOCUMENT_SIZE);
	                    document.Arrange(new RectangleF(PointF.Empty, document.DesiredSize));
	
	                    PdfFormatProvider provider = new PdfFormatProvider();
	
	                    using (Stream output = dialog.OpenFile())
	                    {
	                        provider.Export(document, output);
	                    }
	                }
	            }
	        }
	{{endregion}}



#### __VB.NET__

{{region radchart-features-export-to-pdf_5}}
	    Private Sub Export_Click(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs)
	        Dim dialog As New SaveFileDialog()
	        dialog.DefaultExt = "*.pdf"
	        dialog.Filter = "Adobe PDF Document (*.pdf)|*.pdf"
	        If dialog.ShowDialog() = True Then
	            Dim document As RadDocument = Me.CreateDocument()
	            document.LayoutMode = DocumentLayoutMode.Paged
	            document.Measure(RadDocument.MAX_DOCUMENT_SIZE)
	            document.Arrange(New RectangleF(PointF.Empty, document.DesiredSize))
	            Dim provider As New PdfFormatProvider()
	            Using output As Stream = dialog.OpenFile()
	                provider.Export(document, output)
	            End Using
	        End If
	    End Sub
	{{endregion}}



## 
