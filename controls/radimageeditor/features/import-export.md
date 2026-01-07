---
title: Import/Export
page_title: Import/Export
description: Check our &quot;Import/Export&quot; documentation article for the RadImageEditor {{ site.framework_name }} control.
slug: radimageeditor-features-import-export
tags: import/export
published: True
position: 2
---

# Import/Export

`RadImageEditor` can load and save images in different file formats. This functionality is implemented through format providers. The format providers shipped with the control are:        

* `PngFormatProvider`&mdash;allows import and export from/to PNG;          
* `BmpFormatProvider`&mdash;allows import and export from/to BMP;          
* `JpegFormatProvider`&mdash;allows import only from JPEG/JPG.

As RadImageEditor is highly extensible, you can create your own format providers by implementing the `IImageFormatProvider` interface. This approach is illustrated in a demo attached to [this blog post](http://blogs.telerik.com/blogs/posts/11-07-20/under-the-hood-of-radimageeditor-for-silverlight-and-wpf.aspx), showing how a format provider that supports both import and export from JPEG can be developed and plugged in RadImageEditor’s architecture.        

The format providers can load images from streams and bytes just like shown in the following.

__Load an image__  
```C#
	this.imageEditor.Image = formatProvider.Import(stream);
```

The below code shows how to load an image from a file using the open file dialog.

__Load an image through the OpenFileDialog__
```C#
	private void AddImageInEditor()
	{
	    OpenFileDialog ofd = new OpenFileDialog();
	    ofd.Filter = "PNG Images (*.png)|*.png|JPEG Images (*.jpg,*.jpeg)|*.jpg;*.jpeg|All images|*.*";
	    ofd.FilterIndex = 3;
	    if (ofd.ShowDialog() == true)
	    {
	        string extension = Path.GetExtension(ofd.SafeFileName).ToLower();
	        Stream stream = ofd.OpenFile();
	        IImageFormatProvider formatProvider = ImageFormatProviderManager.GetFormatProviderByExtension(extension);
	        if (formatProvider == null)
	        {
	            StringBuilder sb = new StringBuilder();
	            sb.Append("Unable to find format provider for extension: ")
	              .Append(extension).Append(" .");
	            return;
	        }
	        else
	        {
	            this.imageEditor.Image = formatProvider.Import(stream);
	        }
	    }
	}
```

You can use the available format providers to export the images as well.  The following example shows how you can get the image of the editor, encode it in a specific format – BMP or PNG, and save it using the SaveFileDialog.

__Save an image through the SaveFileDialog__  
```C#
	private void ExportImageInEditor()
	{
	    SaveFileDialog sfd = new SaveFileDialog();
	    sfd.Filter = "PNG Images (*.png)|*.png|BMP Images (*.bmp)|*.bmp;*|All images|*.*";
	    sfd.FilterIndex = 3;
	    if (sfd.ShowDialog() == true)
	    {
	        string extension = System.IO.Path.GetExtension(sfd.SafeFileName).ToLower();
	        Stream stream = sfd.OpenFile();
	        IImageFormatProvider formatProvider = ImageFormatProviderManager.GetFormatProviderByExtension(extension);
	        if (formatProvider == null)
	        {
	            StringBuilder sb = new StringBuilder();
	            sb.Append("Unable to find format provider for extension: ")
	                .Append(extension).Append(" .");
	            return;
	        }
	        else
	        {
	            using (stream)
	            {
	                formatProvider.Export(this.imageEditorUI.ImageEditor.Image, stream);
	            }
	        }
	    }
	}
```

>important One thing to note is that the last applied change may not be committed (which normally happens when you press Enter or change the current tool).

To commit this last change, use the `CommitTool` method of the RadImageEditor class as shown in the example below.

__Commit a change__  
```C#
	this.imageEditorUI.ImageEditor.CommitTool();
```

## ImageFormatProviderManager

The `ImageFormatProviderManager` class is a static class that manages the format providers available for RadImageEditor. It exposes methods to register format providers as well as to get a format provider by file extension.

* `RegisteredFormatProviders`&mdash;gets a collection of all registered format providers.  
* `RegisterFormatProvider`&mdash;this method allows you to register a format provider of the type `IImageFormatProvider`.  
* `GetFormatProviderByExtension`&mdash;this method returns a registered format provider by passing a string parameter that represents the file extension. For example, __".png"__.

__Registering a format provider__  
```C#
	ImageFormatProviderManager.RegisterFormatProvider(new Jpeg2000FormatProvider());
```

>tip To download a runnable project with the example from this article, visit [our SDK repository](https://github.com/telerik/xaml-sdk/). You can find the example in the __ImageEditor/CustomImageFormatProvider__ folder.


## See Also  
* [Commands and Tools]({%slug radimageeditor-features-commands-and-tools%})
* [History]({%slug radimageeditor-features-history%})
