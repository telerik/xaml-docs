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

#region radchart-features-export-to-pdf_0
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
#endregion

#region radchart-features-export-to-pdf_2
Section section = new Section();
Paragraph paragraph = new Paragraph();

MemoryStream ms = new MemoryStream();
RadChart1.ExportToImage(ms, new PngBitmapEncoder());
ImageInline image = new ImageInline(ms, new Size(700, 500), "png");

paragraph.Inlines.Add(image);
section.Blocks.Add(paragraph);
document.Sections.Add(section);

ms.Close();
#endregion

#region radchart-features-export-to-pdf_4
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
#endregion

#region radchart-features-export-to-pdf_6
RadChart chart = new RadChart();
chart.BeginInit();
chart.DefaultView.ChartArea.EnableAnimations = false;
chart.DefaultView.ChartArea.AxisX.LabelStep = 5;
chart.Width = 600;
chart.Height = 400;
SeriesMapping sm = new SeriesMapping();
sm.ItemsSource = (this.DataContext as ExamplesDataContext).RandomProducts;
sm.SeriesDefinition = new BarSeriesDefinition() { ShowItemLabels = false, ItemStyle = this.LayoutRoot.Resources["ExportStyle"] as Style };
sm.ItemMappings.Add(new ItemMapping("UnitPRice", DataPointMember.YValue));
chart.SeriesMappings.Add(sm);
chart.EndInit();
chart.Measure(new System.Windows.Size(chart.Width, chart.Height));
chart.Arrange(new System.Windows.Rect(new Point(0, 0), chart.DesiredSize));
Section section = new Section();
Paragraph paragraph = new Paragraph();

MemoryStream ms = new MemoryStream();
RadChart1.ExportToImage(ms, new PngBitmapEncoder());
ImageInline image = new ImageInline(ms, new Size(700, 500), "png");

paragraph.Inlines.Add(image);
section.Blocks.Add(paragraph);
document.Sections.Add(section);

ms.Close();
#endregion
}
