---
title: Import/Export
page_title: Import/Export
description: Import/Export
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

#### __[C#] Example 1: Load an image__  
{{region cs-radimageeditor-features-import-export_0}}
	this.imageEditor.Image = formatProvider.Import(stream);
{{endregion}}

The code from **Example 2** loads an image from a file using the open file dialog.{% if site.site_name == 'Silverlight' %}

#### __[C#] Example 2: Load an image through the OpenFileDialog__  
{{region cs-radimageeditor-features-import-export_1}}
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
{{endregion}}

{% endif %}
{% if site.site_name == 'WPF' %}

#### __[C#] Example 2: Load an image through the OpenFileDialog__

{{region cs-radimageeditor-features-import-export_2}}
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
{{endregion}}
{% endif %}

You can use the available format providers to export the images as well.  **Example 3** shows how you can get the image of the editor, encode it in a specific format – BMP or PNG, and save it using the SaveFileDialog.

#### __[C#] Example 3: Save an image through the SaveFileDialog__  
{{region cs-radimageeditor-features-import-export_3}}
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
{{endregion}}

>One thing to note is that the last applied change may not be committed (which normally happens when you press Enter or change the current tool).

To commit this last change, use the method from **Example 4**

#### __[C#] Example 4: Commit a change__  
{{region cs-radimageeditor-features-import-export_4}}
	this.imageEditorUI.ImageEditor.CommitTool();
{{endregion}}


## See Also  
* [Commands and Tools]({%slug radimageeditor-features-commands-and-tools%})
* [History]({%slug radimageeditor-features-history%})
