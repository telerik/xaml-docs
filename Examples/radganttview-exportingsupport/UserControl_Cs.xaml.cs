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

#region radganttview-exportingsupport-0
public class GanttPaginator : DocumentPaginator
{
	private IList<BitmapSource> exportImages;

	public GanttPaginator(IEnumerable<BitmapSource> exportImages)
	{
		this.exportImages = exportImages.ToList();
	}

	public override DocumentPage GetPage(int pageNumber)
	{
		var bitmap = this.exportImages[pageNumber];
		var imageSize = new Size(bitmap.Width, bitmap.Height);
		var image = new Image { Source = bitmap };
		image.Measure(imageSize);
		image.Arrange(new Rect(imageSize));
		image.UpdateLayout();
		return new DocumentPage(image);
	}

	public override bool IsPageCountValid
	{
		get { return true; }
	}

	public override int PageCount
	{
		get { return exportImages.Count(); }
	}

	public override Size PageSize
	{
		get
		{
			return new Size(796.8, 1123.2);
		}
		set
		{
			throw new NotImplementedException();
		}
	}

	public override IDocumentPaginatorSource Source
	{
		get { return null; }
	}
}
#endregion

#region radganttview-exportingsupport-1
public static class PrintingService
{
	public static void Print(RadGanttView ganttView)
	{
		var printDialog = new PrintDialog();
		if (printDialog.ShowDialog() == true)
		{
			var exportImages = Enumerable.Empty<BitmapSource>();
			var printingSettings = new ImageExportSettings(new Size(printDialog.PrintableAreaWidth, printDialog.PrintableAreaHeight), true, GanttArea.AllAreas);
			using (var export = ganttView.ExportingService.BeginExporting(printingSettings))
			{
				exportImages = export.ImageInfos.ToList().Select(info => info.Export());
			}

			var paginator = new GanttPaginator(exportImages);
			printDialog.PrintDocument(paginator, "Print demo");
		}
	}
}
#endregion

#region radganttview-exportingsupport-2
private void PrintButtonClick(object sender, RoutedEventArgs e)
{
	PrintingService.Print(this.GanttView);
}
#endregion

#region radganttview-exportingsupport-3
public static class PrintingService
{
	public static void Print(RadGanttView ganttView)
	{
		var isFirstPass = true;
		var exportImages = Enumerable.Empty<BitmapSource>();
		var enumerator = exportImages.GetEnumerator();
		var pd = new System.Windows.Printing.PrintDocument();
		pd.BeginPrint += pd_BeginPrint;
		pd.PrintPage += (s, e) =>
			{
				if (isFirstPass)
				{
					var printingSettings = new ImageExportSettings(e.PrintableArea, true, GanttArea.AllAreas);
					using (var export = ganttView.ExportingService.BeginExporting(printingSettings))
					{
						exportImages = export.ImageInfos.ToList().Select(info => info.Export());
						enumerator = exportImages.GetEnumerator();
						enumerator.MoveNext();
					}
					isFirstPass = false;
				}

				e.PageVisual = PrintPage(enumerator.Current);
				enumerator.MoveNext();
				e.HasMorePages = enumerator.Current != null;
			};
		pd.Print("Gantt");
	}

	static void pd_BeginPrint(object sender, System.Windows.Printing.BeginPrintEventArgs e)
	{
	}

	private static UIElement PrintPage(BitmapSource bitmap)
	{
		var bitmapSize = new System.Windows.Size(bitmap.PixelWidth, bitmap.PixelHeight);
		var image = new System.Windows.Controls.Image { Source = bitmap };
		image.Measure(bitmapSize);
		image.Arrange(new System.Windows.Rect(new System.Windows.Point(0, 0), bitmapSize));
		return image;
	}
}
#endregion

#region radganttview-exportingsupport-4

#endregion
#region radganttview-exportingsupport-5

#endregion

}
