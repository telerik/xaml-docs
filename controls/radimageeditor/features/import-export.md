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

__RadImageEditor__ can load and save images in different file formats. This functionality is implemented through format providers. The format providers shipped with the control are:        

* __PngFormatProvider__: allows import and export from/to PNG;          

* __BmpFormatProvider__: allows import and export from/to BMP;          

* __JpegFormatProvider__: allows import only from JPEG/JPG.          

As __RadImageEditor__ is highly extensible, you can create your own format providers by implementing the __IImageFormatProvider__ interface. This approach is illustrated in a demo attached to [this blog post](http://blogs.telerik.com/blogs/posts/11-07-20/under-the-hood-of-radimageeditor-for-silverlight-and-wpf.aspx), showing how a format provider that supports both import and export from JPEG can be developed and plugged in RadImageEditor’s architecture.        

The format providers can load images from streams and bytes just like shown in **Example 1**.

__Example 1: Load an image__  
```C#
	this.imageEditor.Image = formatProvider.Import(stream);
```

The code from **Example 2** loads an image from a file using the open file dialog.{% if site.site_name == 'Silverlight' %}

__Example 2: Load an image through the OpenFileDialog__  
```C#
	private void AddImageInEditor()
	{
	   OpenFileDialog ofd = new OpenFileDialog();
	   ofd.Filter = "PNG Images (*.png)|*.png|JPEG Images (*.jpg,*.jpeg)|*.jpg;*.jpeg|All images|*.*";
	   ofd.FilterIndex = 3;
	   if (ofd.ShowDialog() == true)
	   {
	      string extension = ofd.File.Extension.ToLower();
	      Stream stream = ofd.File.OpenRead();
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

{% endif %}
{% if site.site_name == 'WPF' %}

__Example 2: Load an image through the OpenFileDialog__

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
{% endif %}

You can use the available format providers to export the images as well.  **Example 3** shows how you can get the image of the editor, encode it in a specific format – BMP or PNG, and save it using the SaveFileDialog.

__Example 3: Save an image through the SaveFileDialog__  
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

>One thing to note is that the last applied change may not be committed (which normally happens when you press Enter or change the current tool).

To commit this last change, use the method from **Example 4**

__Example 4: Commit a change__  
```C#
	this.imageEditorUI.ImageEditor.CommitTool();
```


## See Also  
* [Commands and Tools]({%slug radimageeditor-features-commands-and-tools%})
* [History]({%slug radimageeditor-features-history%})
