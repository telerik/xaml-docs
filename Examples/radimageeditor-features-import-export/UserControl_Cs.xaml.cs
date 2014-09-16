using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace WpfApplication1
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
	}

#region radimageeditor-features-import-export_0
this.ImageEditor.Image = formatProvider.Import(stream);
#endregion

#region radimageeditor-features-import-export_1
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
#endregion

#region radimageeditor-features-import-export_2
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
#endregion

#region radimageeditor-features-import-export_3
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
#endregion

#region radimageeditor-features-import-export_4
this.imageEditorUI.ImageEditor.CommitTool();
#endregion
}
