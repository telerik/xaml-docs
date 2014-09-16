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


#region radpdfviewer-showing-a-file_0
private void LoadFromStream(object sender, System.Windows.RoutedEventArgs e)
{
    Stream str = App.GetResourceStream(new System.Uri("PdfViewerDemo;component/SampleData/Sample.pdf", System.UriKind.Relative)).Stream;
    this.pdfViewer.DocumentSource = new PdfDocumentSource(str);
}        
#endregion

#region radpdfviewer-showing-a-file_1
private void LoadFromUri(object sender, System.Windows.RoutedEventArgs e)
{
    this.pdfViewer.DocumentSource = new PdfDocumentSource(new System.Uri("PdfViewerDemo;component/SampleData/Sample.pdf", System.UriKind.Relative)); 
}
#endregion

#region radpdfviewer-showing-a-file_2
public class Context
{
    public [string/Uri/Stream] Source { get; set; }
}
#endregion

#region radpdfviewer-showing-a-file_3
PdfFormatProvider provider = new PdfFormatProvider(stream, settings);
this.viewer.Document = provider.Import();
#endregion

#region radpdfviewer-showing-a-file_4
PdfDocumentSource source = new PdfDocumentSource(stream/uri, FormatProviderSettings.ReadAllAtOnce);      
#endregion

#region radpdfviewer-showing-a-file_5
this.viewer.DefaultFormatProviderSettings = FormatProviderSettings.ReadAllAtOnce;
this.viewer.DefaultFormatProviderSettings = FormatProviderSettings.ReadOnDemand;
#endregion


}
