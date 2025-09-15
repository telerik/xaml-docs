---
title: ImageInline
page_title: ImageInline
description: Check our &quot;ImageInline&quot; documentation article for the RadRichTextBox {{ site.framework_name }} control.
slug: radrichtextbox-features-document-elements-inlineimage
tags: Image,Inline
published: True
position: 5
---

# ImageInline

The __ImageInline__ class allows images to be displayed inside the document. The __ImageInline__ can only be used in the context of a __Paragraph__ class. As it is an inline element, it gets placed after the previous inline element until the end of the line. If there is no space left, the element will be wrapped on the next line.

This topic will explain you how to use the __ImageInline__ element.

>tip To modify the document content at runtime we recommend using the [RadDocumentEditor]({%slug radrichtextbox-features-raddocumenteditor%}) class when possible, instead of working with `RadDocument` directly. The document editor ensures that the document will be measured and arranged properly on each change.

## Supported Image Extensions

With **RadRichTextBox**, you can work with images from the following file formats:

* `JPG`
* `JPEG`
* `PNG`
* `BMP`
* `TIFF`
* `TIF`
* `GIF`
* `ICO`
* `ICON`
* `WMF`
* `EMF`

## Add in XAML

Here is an example of an __ImageInline__ element used in XAML at design time.

#### __XAML__

```XAML
	<telerik:RadRichTextBox x:Name="radRichTextBox" Height="500">
	    <telerik:RadDocument>
	        <telerik:Section>
	            <telerik:Paragraph>
	                <telerik:ImageInline UriSource="/Help.RadRichTextBoxSamples;component/Demos/Images/RadRichTextBox.png" Width="236" Height="50" />
	             </telerik:Paragraph>
	        </telerik:Section>
	    </telerik:RadDocument>
	</telerik:RadRichTextBox>
```

## Add in Code Behind

Here is an example of how to add an __ImageInline__ element in the code behind.

#### __C#__

```C#	
	Section section = new Section();
	Paragraph paragraph = new Paragraph();
	Stream stream = Application.GetResourceStream(new Uri(@"/Help.RadRichTextBoxSamples;component/Demos/Images/RadRichTextBox.png", UriKind.RelativeOrAbsolute)).Stream;
	Size size = new Size(236, 50);
	ImageInline image = new ImageInline(stream, size, "png");
	paragraph.Inlines.Add(image);
	section.Children.Add(paragraph);
	this.radRichTextBox.Document.Sections.Add(section);
```

#### __VB.NET__

```VB.NET

	Dim section As New Section()
	Dim paragraph As New Paragraph()
	Dim stream As Stream = Application.GetResourceStream(New Uri("/Help.RadRichTextBoxSamples;component/Demos/Images/RadRichTextBox.png", UriKind.RelativeOrAbsolute)).Stream
	Dim size As New Size(236, 50)
	Dim image As New ImageInline(stream, size, "png")
	paragraph.Inlines.Add(image)
	section.Children.Add(paragraph)
	Me.radRichTextBox.Document.Sections.Add(section)
```

## Add via UI

Here is an example of how to allow the user to select an image and add it to the document. For that purpose a __RadButton__ and an __OpenFileDialog__ are used. When the file stream from the __OpenFileDialog__ gets obtained, it's passed to the __InsertImage()__ API method of the __RadRichTextBox__. This method takes as an argument the extension of the image, which can be again obtained from the __FileInfo__ object. After calling the __InsertImage()__ method, the image will appear in the document with its default width and height.

#### __XAML__

```XAML
    <telerik:RadButton Content="Add Image" x:Name="ImageButton" Click="ImageButton_Click" />
    <telerik:RadRichTextBox x:Name="radRichTextBox" Height="500" LayoutMode="Paged" />
```

#### __C#__

```C#

    private void ImageButton_Click(object sender, RoutedEventArgs e)
    {
        OpenFileDialog openDialog = new OpenFileDialog();
        openDialog.Filter = "Images|*.jpg;*.png";
        openDialog.Multiselect = false;
        bool? dialogResult = openDialog.ShowDialog();
        if (dialogResult == true)
        {
            Stream stream = openDialog.OpenFile();
            string extension = Path.GetExtension(openDialog.FileName);
            this.radRichTextBox.InsertImage(stream, extension);
        }
    }
```

#### __VB.NET__

```VB.NET
	Private Sub ImageButton_Click(sender As Object, e As RoutedEventArgs)
	 Dim openDialog As New OpenFileDialog()
	 openDialog.Filter = "Images|*.jpg;*.png"
	 openDialog.Multiselect = False
	 Dim dialogResult As System.Nullable(Of Boolean) = openDialog.ShowDialog()
	 If dialogResult = True Then
	  Dim stream As Stream = openDialog.OpenFile()
	  Dim extension As String = Path.GetExtension(openDialog.FileName)
	  Me.radRichTextBox.InsertImage(stream, extension)
	 End If
	End Sub
```

## See Also  
 * [Editing Images]({%slug radrichtextbox-features-editing-images%}) 
 * [Floating Images]({%slug radrichtextbox-features-document-elements-floatingimage%})
 * [Elements Hierarchy]({%slug radrichtextbox-features-document-elements-hierarchy%})
 * [RadDocument]({%slug radrichtextbox-features-document-elements-raddocument%})
 * [Section]({%slug radrichtextbox-features-document-elements-section%})
 * [Paragraph]({%slug radrichtextbox-features-document-elements-paragraph%})
 * [Span]({%slug radrichtextbox-features-document-elements-span%})
 * [Hyperlink]({%slug radrichtextbox-features-document-elements-hyperlink%})