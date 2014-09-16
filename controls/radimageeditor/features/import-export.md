---
title: Import/Export
page_title: Import/Export
description: Import/Export
slug: radimageeditor-features-import-export
tags: import/export
publish: True
position: 2
---

# Import/Export



## 

__RadImageEditor__can load and save images in different file formats. This functionality is implemented through format providers. The format providers shipped with the control are:
        

* __PngFormatProvider__– allows import and export from/to PNG;
          

* __BmpFormatProvider__– allows import and export from/to BMP;
          

* __JpegFormatProvider__– allows import only from JPEG/JPG.
          

As __RadImageEditor__is highly extensible, you can create your own format providers by implementing the __IImageFormatProvider__interface. This approach is illustrated in a demo attached to [this blog post](http://blogs.telerik.com/blogs/posts/11-07-20/under-the-hood-of-radimageeditor-for-silverlight-and-wpf.aspx), showing how a format provider that supports both import and export from JPEG can be developed and plugged in RadImageEditor’s architecture.
        

The format providers can load images from streams and bytes just like this:

#### __C#__

{{region radimageeditor-features-import-export_0}}
	this.ImageEditor.Image = formatProvider.Import(stream);
	{{endregion}}



Here is a sample function that loads an image from a file using the open file dialog:{% if site.site_name == 'Silverlight' %}

#### __C#__

{{region radimageeditor-features-import-export_1}}
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
	         this.ImageEditor.Image = formatProvider.Import(stream);
	      }
	   }
	}
	{{endregion}}

{% endif %}{% if site.site_name == 'WPF' %}

#### __C#__

{{region radimageeditor-features-import-export_2}}
	private void AddImageInEditor()
	{
	   OpenFileDialog ofd = new OpenFileDialog();
	   ofd.Filter = "PNG Images (*.png)|*.png|JPEG Images (*.jpg,*.jpeg)|*.jpg;*.jpeg|All images|*.*";
	   ofd.FilterIndex = 3;
	   if (ofd.ShowDialog() == true)
	   {
	      string extension  = Path.GetExtension(ofd.SafeFileName).ToLower();
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
	         this.ImageEditor.Image = formatProvider.Import(stream);
	      }
	   }
	}
	{{endregion}}

{% endif %}

You can use the available format providers to export the images as well.  Here is an example how you can get the image of the editor, encode it in a specific format – BMP or PNG, and save it using the SaveFileDialog:

#### __C#__

{{region radimageeditor-features-import-export_3}}
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
	                formatProvider.Export(this.imageEditorUI.Image, stream);
	            }
	        }
	    }
	}
	{{endregion}}



One thing to note here is that the last applied change may not be commited (which normally happens when you press Enter or change the current tool).

To commit this last change, use the following method:

#### __C#__

{{region radimageeditor-features-import-export_4}}
	this.imageEditorUI.ImageEditor.CommitTool();
	{{endregion}}


