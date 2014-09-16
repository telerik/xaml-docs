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

#region common-export-support_0
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
#endregion

#region common-export-support_2
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
#endregion

#region common-export-support_1      
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
#endregion