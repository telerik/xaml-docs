---
title: InlineImage
page_title: InlineImage
description: InlineImage
slug: radrichtextbox-features-document-elements-inlineimage
tags: inlineimage
published: True
position: 5
---

# InlineImage



The __InlineImage__ class allows images to be displayed inside the document. The __InlineImage__ can only be used in the context of a __Paragraph__ class. As it is an inline element, it gets placed after the previous inline element untill the end of the line. If there is no space left, the element will be wrapped on the next line.

This topic will explain you how to use the __InlineImage__ element.

## Add in XAML

Here is an example of an __InlineImage__ element used in XAML at design time.

#### __XAML__

{{region radrichtextbox-features-document-elements-inlineimage_0}}
	<telerik:RadRichTextBox x:Name="radRichTextBox" Height="500">
	    <telerik:RadDocument>
	        <telerik:Section>
	            <telerik:Paragraph>
	                <telerik:ImageInline UriSource="/Silverlight.Help.RadRichTextBoxSamples;component/Demos/Images/RadRichTextBox.png" Width="236" Height="50" />
	             </telerik:Paragraph>
	        </telerik:Section>
	    </telerik:RadDocument>
	</telerik:RadRichTextBox>
	{{endregion}}



## Add in Code Behind

Here is an example of how to add an __InlineImage__ element in the code behind.

#### __C#__

{{region radrichtextbox-features-document-elements-inlineimage_1}}
	Section section = new Section();
	Paragraph paragraph = new Paragraph();
	Stream stream = Application.GetResourceStream(new Uri(@"/Silverlight.Help.RadRichTextBoxSamples;component/Demos/Images/RadRichTextBox.png", UriKind.RelativeOrAbsolute)).Stream;
	Size size = new Size(236, 50);
	ImageInline image = new ImageInline(stream, size, "png");
	paragraph.Inlines.Add(image);
	section.Children.Add(paragraph);
	this.radRichTextBox.Document.Sections.Add(section);
	{{endregion}}



#### __VB.NET__

{{region radrichtextbox-features-document-elements-inlineimage_2}}
	Dim section As New Section()
	Dim paragraph As New Paragraph()
	Dim stream As Stream = Application.GetResourceStream(New Uri("/Silverlight.Help.RadRichTextBoxSamples;component/Demos/Images/RadRichTextBox.png", UriKind.RelativeOrAbsolute)).Stream
	Dim size As New Size(236, 50)
	Dim image As New ImageInline(stream, size, "png")
	paragraph.Inlines.Add(image)
	section.Children.Add(paragraph)
	Me.radRichTextBox.Document.Sections.Add(section)
	{{endregion}}



## Add via UI

Here is an example of how to allow the user to select an image and add it to the document. For that purpose a __RadButton__ and an __OpenFileDialog__ are used. When the file stream from the __OpenFileDialog__ gets obtained, it's passed to the __InsertImage()__ API method of the __RadRichTextBox__. This method takes as an argument the extension of the image, which can be again obtained from the __FileInfo__ object. After calling the __InsertImage()__ method, the image will appear in the document with its default width and height.

#### __XAML__

{{region radrichtextbox-features-document-elements-inlineimage_3}}
	<StackPanel>
	    <telerik:RadButton Content="Add Image" x:Name="ImageButton" Click="ImageButton_Click" />
	    <telerik:RadRichTextBox x:Name="radRichTextBox" Height="500" LayoutMode="Paged" />
	</StackPanel>
	{{endregion}}



#### __C#__

{{region radrichtextbox-features-document-elements-inlineimage_4}}
	private void ImageButton_Click(object sender, RoutedEventArgs e)
	{
	    OpenFileDialog openDialog = new OpenFileDialog();
	    openDialog.Filter = "Images|*.jpg;*.png";
	    openDialog.Multiselect = false;
	    bool? dialogResult = openDialog.ShowDialog();
	    if (dialogResult == true)
	    {
	        Stream stream = openDialog.File.OpenRead();
	        string extension = openDialog.File.Extension;
	        this.radRichTextBox.InsertImage(stream, extension);
	    }
	}
	{{endregion}}



#### __VB.NET__

{{region radrichtextbox-features-document-elements-inlineimage_5}}
	Private Sub ImageButton_Click(sender As Object, e As RoutedEventArgs)
	 Dim openDialog As New OpenFileDialog()
	 openDialog.Filter = "Images|*.jpg;*.png"
	 openDialog.Multiselect = False
	 Dim dialogResult As System.Nullable(Of Boolean) = openDialog.ShowDialog()
	 If dialogResult = True Then
	  Dim stream As Stream = openDialog.File.OpenRead()
	  Dim extension As String = openDialog.File.Extension
	  Me.radRichTextBox.InsertImage(stream, extension)
	 End If
	End Sub
	{{endregion}}



# See Also

 * [Editing Images]({%slug radrichtextbox-features-editing-images%})

 * [Elements Hierarchy]({%slug radrichtextbox-features-document-elements-hierarchy%})

 * [RadDocument]({%slug radrichtextbox-features-document-elements-raddocument%})

 * [Section]({%slug radrichtextbox-features-document-elements-section%})

 * [Paragraph]({%slug radrichtextbox-features-document-elements-paragraph%})

 * [Span]({%slug radrichtextbox-features-document-elements-span%})

 * [Hyperlink]({%slug radrichtextbox-features-document-elements-hyperlink%})
