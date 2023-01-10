---
title: Image Export
page_title: Image Export
description: Check our &quot;Image Export&quot; documentation article for the RadDiagram {{ site.framework_name }} control.
slug: raddiagram-features-image-export
tags: image,export
published: True
position: 11
---

# {{ site.framework_name }} RadDiagram Image Export

This article describes the __RadDiagram ExportToImage__ feature.

The __RadDiagram__ framework provides a method and a command for exporting its current state to an image file. You can control the type and size of the created image along with the area of the diagram that should be exported.	  

## ExportToImage() method

The __RadDiagram.ExportToImage()__ method allows you to export the diagram to an image. It takes the following arguments:		

* __Stream__ *stream* - this is a __required__ attribute that represents the stream of the file where the diagram should be exported to.			

{% if site.site_name == 'Silverlight' %}

__Telerik.Windows.Media.Imaging.BitmapEncoderhttp://www.telerik.com/help/silverlight/t_telerik_windows_media_imaging_bitmapencoder.html *encoder* - this attribute defines the image format. You can use any of the following encoders to create the file:			  

* [BmpBitmapEncoder](http://www.telerik.com/help/silverlight/t_telerik_windows_media_imaging_bmpbitmapencoder.html)

* [PngBitmapEncoder](http://www.telerik.com/help/silverlight/t_telerik_windows_media_imaging_pngbitmapencoder.html) - this is the default encoder used by the __ExportToImage()__ method.				  
{% endif %}
{% if site.site_name == 'WPF' %}
* [BitmapEncoder](http://msdn.microsoft.com/en-us/library/system.windows.media.imaging.bitmapencoder.aspx) *encoder* - this attribute defines the image format. You can use any of the following encoders to create the file:
	* [BmpBitmapEncoder](http://msdn.microsoft.com/en-us/library/system.windows.media.imaging.bmpbitmapencoder.aspx)
	* [GifBitmapEncoder](http://msdn.microsoft.com/en-us/library/system.windows.media.imaging.gifbitmapencoder.aspx)
	* [JpegBitmapEncoder](http://msdn.microsoft.com/en-us/library/system.windows.media.imaging.jpegbitmapencoder.aspx)
	* [PngBitmapEncoder](http://msdn.microsoft.com/en-us/library/system.windows.media.imaging.pngbitmapencoder.aspx)
	* [TiffBitmapEncoder](http://msdn.microsoft.com/en-us/library/system.windows.media.imaging.tiffbitmapencoder.aspx)
	* [WmpBitmapEncoder](http://msdn.microsoft.com/en-us/library/system.windows.media.imaging.wmpbitmapencoder.aspx)
{% endif %}
* __Nullable<Rect>__ *enclosingBounds* - this attribute determines the portion of the diagram surface which should be exported

* __Size__ *returnImageSize* - this attribute determines the size of the created image file			

* __Brush__ *backgroundBrush* - this attribute determines the brush that should be applied as a background of the created image			

* __Thickness__ *margin* - this attribute allows you to specify a __Margin__ around the __RadDiagram__ when exporting it to an image file.		
	
* __Double__ *dpi* - this attribute allows you to specify the DPI that determines the quality of the exported image. This is an optional parameter and its default value is 96.

Below you can find a few examples demonstrating how to use the __ExportToImage()__ method to customize the export. For the purpose of these examples we will use the following __RadDiagram__ definition:
		
#### __XAML__
{{region raddiagram-features-image-export-0}}
    <telerik:RadDiagram x:Name="xDiagram">
        <telerik:RadDiagramShape x:Name="Shape1"
                                    Content="Shape1"
                                    Geometry="{telerik:FlowChartShape ShapeType=Database1Shape}"
                                    Position="100,80" />
        <telerik:RadDiagramShape x:Name="Shape2"
                                    Content="Shape2"
                                    Geometry="{telerik:FlowChartShape ShapeType=Database2Shape}"
                                    Position="200,180" />
        <telerik:RadDiagramConnection Source="{Binding ElementName=Shape1}" Target="{Binding ElementName=Shape2}" />
    </telerik:RadDiagram>		  		  
{{endregion}}

![Rad Diagram Features Export Sample Diagram](images/RadDiagram_Features_Export_SampleDiagram.png)

>Please note that the examples in this tutorial are showcasing Telerik Windows8 theme. In the {% if site.site_name == 'Silverlight' %}[Setting a Theme](http://www.telerik.com/help/silverlight/common-styling-apperance-setting-theme.html#Setting_Application-Wide_Built-In_Theme_in_the_Code-Behind){% endif %}{% if site.site_name == 'WPF' %}[Setting a Theme](http://www.telerik.com/help/wpf/common-styling-apperance-setting-theme-wpf.html#Setting_Application-Wide_Built-In_Theme_in_the_Code-Behind){% endif %} article you can find more information on how to set an application-wide theme.		  

We will also create a __RadButton__ control and we will handle its __Click__ event handler to invoke the __RadDiagram.ExportToImage()__ method.
		
#### __XAML__	
{{region raddiagram-features-image-export-1}}
    <telerik:RadButton Content="Export to Image" Click="ExportToImage" />		  
{{endregion}}

* Define only the stream of the file:
	{% if site.site_name == 'WPF' %}
	#### __C#__
	{{region raddiagram-features-image-export-2}}
		private void ExportToImage(object sender, RoutedEventArgs e)
		{
			using (var stream = File.Open(@"c:\temp\xDiagram.png", FileMode.Create))
			{
				xDiagram.ExportToImage(stream);
			}
		}
	{{endregion}}
	
	#### __VB.NET__	
	{{region raddiagram-features-image-export-3}}
		Private Sub ExportToImage(sender As Object, e As RoutedEventArgs)
			Using stream = File.Open("c:\temp\xDiagram.png", FileMode.Create)
				xDiagram.ExportToImage(stream)
			End Using
		End Sub			  			  
	{{endregion}}	
	{% endif %}
	{% if site.site_name == 'Silverlight' %}
	#### __C#__
	{{region raddiagram-features-image-export-4}}
		private void ExportToImage(object sender, RoutedEventArgs e)
		{
			SaveFileDialog dialog = new SaveFileDialog() { DefaultFileName = "xDiagram.png"};
			bool? result = dialog.ShowDialog();
			if (result == true)
			{
				using (var stream = dialog.OpenFile())
				{
					xDiagram.ExportToImage(stream);
				}
			}
		}			 
	{{endregion}}
	
	#### __VB.NET__ 	
	{{region raddiagram-features-image-export-5}}	
		Private Sub ExportToImage(sender As Object, e As RoutedEventArgs)
			Dim dialog As New SaveFileDialog() With { .DefaultFileName = "xDiagram.png"}
			Dim result As System.Nullable(Of Boolean) = dialog.ShowDialog()
			If result = True Then
				Using stream = dialog.OpenFile()
					xDiagram.ExportToImage(stream)
				End Using
			End If
		End Sub
	{{endregion}}
	{% endif %}
	
	This operation will result in the creating of a file named xDiagram.png and it will have the following content:

	![Rad Diagram Features Export Stream](images/RadDiagram_Features_Export_Stream.png)

* Define the portion of the diagram to be exported and the size of the image file:
	{% if site.site_name == 'WPF' %}
	#### __C#__ 
	{{region raddiagram-features-image-export-6}}
		private void ExportToImage(object sender, RoutedEventArgs e)
		{
			using (var stream = File.Open(@"c:\temp\xDiagram.png", FileMode.Create))
			{
				xDiagram.ExportToImage(stream,null,new Rect(10,10,150,150),new Size(200,600));
			}
		}			 
	{{endregion}}
	
	#### __VB.NET__	
	{{region raddiagram-features-image-export-7}}
		Private Sub ExportToImage(sender As Object, e As RoutedEventArgs)
			Using stream = File.Open("c:\temp\xDiagram.png", FileMode.Create)
				xDiagram.ExportToImage(stream, Nothing, New Rect(10, 10, 150, 150), New Size(200, 600))
			End Using
		End Sub			  			  
	{{endregion}}
	{% endif %}
	{% if site.site_name == 'Silverlight' %}
	
	#### __C#__
	{{region raddiagram-features-image-export-8}}
		private void ExportToImage(object sender, RoutedEventArgs e)
		{
			SaveFileDialog dialog = new SaveFileDialog() { DefaultFileName = "xDiagram.png"};
			bool? result = dialog.ShowDialog();
			if (result == true)
			{
				using (var stream = dialog.OpenFile())
				{
					xDiagram.ExportToImage(stream,null,new Rect(10,10,150,150),new Size(200,600));
				}
			}
		}		
	{{endregion}}
	
	#### __VB.NET__
	{{region raddiagram-features-image-export-9}}
		Private Sub ExportToImage(sender As Object, e As RoutedEventArgs)
			Dim dialog As New SaveFileDialog() With { .DefaultFileName = "xDiagram.png"}
			Dim result As System.Nullable(Of Boolean) = dialog.ShowDialog()
			If result = True Then
				Using stream = dialog.OpenFile()
					xDiagram.ExportToImage(stream, Nothing, New Rect(10, 10, 150, 150), New Size(200, 600))
				End Using
			End If
		End Sub		
	{{endregion}}
	{% endif %}
	
	This operation will result in the creating of a file named xDiagram.png with a size of 200x200 and it will contain the portion of the __RadDiagram__ defined by the rectangle *(10, 10, 150, 150)*. This is why the image file will contain only a part of the diagram and it will stretch it to fit the required size: 

	![Rad Diagram Features Export Size Bounds](images/RadDiagram_Features_Export_SizeBounds.png)

* Define only the stream and the portion of the diagram to be exported:
	
	{% if site.site_name == 'WPF' %}
	#### __C#__
	{{region raddiagram-features-image-export-9}}
		private void ExportToImage(object sender, RoutedEventArgs e)
		{
			using (var stream = File.Open(@"c:\temp\xDiagram.png", FileMode.Create))
			{
				xDiagram.ExportToImage(stream,null,new Rect(10,10,150,150));
			}
    }			 
	{{endregion}}
	
	#### __VB.NET__
	{{region raddiagram-features-image-export-10}}
		Private Sub ExportToImage(sender As Object, e As RoutedEventArgs)
			Using stream = File.Open("c:\temp\xDiagram.png", FileMode.Create)
				xDiagram.ExportToImage(stream, Nothing, New Rect(10, 10, 150, 150))
			End Using
		End Sub	
	{{endregion}}	
	{% endif %}
	{% if site.site_name == 'Silverlight' %}

	#### __C#__
	{{region raddiagram-features-image-export-11}}
		private void ExportToImage(object sender, RoutedEventArgs e)
		{
			SaveFileDialog dialog = new SaveFileDialog() { DefaultFileName = "xDiagram.png"};
			bool? result = dialog.ShowDialog();
			if (result == true)
			{
				using (var stream = dialog.OpenFile())
				{
					xDiagram.ExportToImage(stream,null,new Rect(10,10,150,150));
				}
			}
		}			 			 
	{{endregion}}
	
	#### __VB.NET__
	{{region raddiagram-features-image-export-12}}
		Private Sub ExportToImage(sender As Object, e As RoutedEventArgs)
			Dim dialog As New SaveFileDialog() With { .DefaultFileName = "xDiagram.png"}
			Dim result As System.Nullable(Of Boolean) = dialog.ShowDialog()
			If result = True Then
				Using stream = dialog.OpenFile()
					xDiagram.ExportToImage(stream, Nothing, New Rect(10, 10, 150, 150))
				End Using
			End If
		End Sub	
	{{endregion}}
	{% endif %}
	
	This operation will result in the creating of a file named xDiagram.png that contains only the portion of the __RadDiagram__ defined by the rectangle *(10, 10, 150, 150)*:
	![Rad Diagram Features Export Bounds](images/RadDiagram_Features_Export_Bounds.png)

* Define the stream and the margin of the diagram to be exported:

	{% if site.site_name == 'WPF' %}
	#### __C#__
	{{region raddiagram-features-image-export-13}}
		private void ExportToImage(object sender, RoutedEventArgs e)
		{
			using (var stream = File.Open(@"c:\temp\xDiagram.png", FileMode.Create))
			{
				xDiagram.ExportToImage(stream, backgroundBrush: new SolidColorBrush(Colors.BlanchedAlmond));
			}
		}			 
	{{endregion}}
	
	#### __VB.NET__
	{{region raddiagram-features-image-export-14}}
		Private Sub ExportToImage(sender As Object, e As RoutedEventArgs)
			Using stream = File.Open("c:\temp\xDiagram.png", FileMode.Create)
				xDiagram.ExportToImage(stream, backgroundBrush := New SolidColorBrush(Colors.BlanchedAlmond))
			End Using
		End Sub		
	{{endregion}}
	{% endif %}	
	{% if site.site_name == 'Silverlight' %}	
	#### __C#__
	{{region raddiagram-features-image-export-15}}
		private void ExportToImage(object sender, RoutedEventArgs e)
		{
			SaveFileDialog dialog = new SaveFileDialog() { DefaultFileName = "xDiagram.png"};
			bool? result = dialog.ShowDialog();
			if (result == true)
			{
				using (var stream = dialog.OpenFile())
				{
				   xDiagram.ExportToImage(stream, backgroundBrush: new SolidColorBrush(Colors.BlanchedAlmond));
				}
			}
		}	
	{{endregion}}		

	#### __VB.NET__
	{{region raddiagram-features-image-export-16}}
		Private Sub ExportToImage(sender As Object, e As RoutedEventArgs)
			Dim dialog As New SaveFileDialog() With { .DefaultFileName = "xDiagram.png"}
			Dim result As System.Nullable(Of Boolean) = dialog.ShowDialog()
			If result = True Then
				Using stream = dialog.OpenFile()
					xDiagram.ExportToImage(stream, backgroundBrush := New SolidColorBrush(Colors.BlanchedAlmond))
				End Using
			End If
		End Sub			  
	{{endregion}}
	{% endif %}
	
	This operation will result in the creating of a file named xDiagram.png that contains the __RadDiagram__ displayed on a BlanchedAlmond background:
	![Rad Diagram Features Export Background](images/RadDiagram_Features_Export_Background.png)
	
Now if we set the *margin* attribute of the method to *20*

#### __C#__	
{{region raddiagram-features-image-export-17}}
    xDiagram.ExportToImage(stream, backgroundBrush: new SolidColorBrush(Colors.BlanchedAlmond), margin: new Thickness(20));		 
{{endregion}}

#### __VB.NET__
{{region raddiagram-features-image-export-18}}
    xDiagram.ExportToImage(stream, backgroundBrush := New SolidColorBrush(Colors.BlanchedAlmond), margin := New Thickness(20))
{{endregion}}

The xDiagram.png image will display the same diagram but its background area will be larger as the method added a Margin of 20px around the diagram:
![Rad Diagram Features Export Background Margin](images/RadDiagram_Features_Export_BackgroundMargin.png)

## Export() Method

__RadDiagram__ also exposes an __Export(string exportFormat)__ method that takes a __string__ argument. The method can export the content of your diagram in an __.png__ or __.bmp__ image file. In order to specify the type of the output image file, you need to set the argument of the method to either "png" or "bmp":

#### __XAML__
{{region raddiagram-features-image-export-19}}
    <telerik:RadDiagram x:Name="xDiagram">
        <telerik:RadDiagramShape x:Name="Shape1"
                                    Content="Shape1"
                                    Geometry="{telerik:FlowChartShape ShapeType=Database1Shape}"
                                    Position="100,80" />
        <telerik:RadDiagramShape x:Name="Shape2"
                                    Content="Shape2"
                                    Geometry="{telerik:FlowChartShape ShapeType=Database2Shape}"
                                    Position="200,180" />
        <telerik:RadDiagramConnection Source="{Binding ElementName=Shape1}" Target="{Binding ElementName=Shape2}" />
    </telerik:RadDiagram>			  
{{endregion}}

#### __C#__
{{region raddiagram-features-image-export-20}}
      //export to BMP
      xDiagram.Export("bmp");
      //export to PNG
      //xDiagram.Export("png");
{{endregion}}

#### __VB.NET__
{{region raddiagram-features-image-export-21}}
      'export to BMP'
      xDiagram.Export("bmp")
      'export to PNG'
      'xDiagram.Export("png")'
{{endregion}}

The result of the above implementation will be a __.bmp__ file with the following content:
![Rad Diagram Features Export CommandBMP](images/RadDiagram_Features_Export_CommandBMP.png)

## DiagramCommands.Export command

You can also use the __DiagramCommands.Export__ command to export the diagram to an image file. It takes as a parameter the type of the image file. However, please keep in mind that the __Export__ command supports only export to __.bmp__ or __.png__ image files. If you don't define a __CommandParameter__, the command will create a __.png__ file:		

#### __XAML__
{{region raddiagram-features-image-export-22}}
    <telerik:RadButton Command="telerik:DiagramCommands.Export" CommandTarget="{Binding ElementName=xDiagram}" CommandParameter="bmp" Content="Export" />		 		  
{{endregion}}

Using the above __RadButton__ definition, we can export the __RadDiagram__ to the following __.bmp__ file:
![Rad Diagram Features Export CommandBMP](images/RadDiagram_Features_Export_CommandBMP.png)

You can also invoke the execution method of the command from code-behind:

#### __C#__	
{{region raddiagram-features-image-export-23}}
    Telerik.Windows.Controls.Diagrams.DiagramCommands.Export.Execute("bmp", null);		  
{{endregion}}
		
#### __VB.NET__
{{region raddiagram-features-image-export-24}}
	Telerik.Windows.Controls.Diagrams.DiagramCommands.Export.Execute("bmp", Nothing)		  
{{endregion}}

## See Also
* [Export to High Quality Image Example](https://github.com/telerik/xaml-sdk/tree/master/Diagram/ExportToHighQualityImage)
