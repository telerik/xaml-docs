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

#region radpdfviewer-document-model-radfixeddocument_0
	Stream stream = Application.GetResourceStream(new Uri("PdfViewerDemo;component/SampleData/test.pdf", UriKind.Relative)).Stream;
	RadFixedDocument document = new PdfFormatProvider(stream, FormatProviderSettings.ReadOnDemand).Import();
	this.pdfViewer.Document = document;
#endregion

#region radpdfviewer-document-model-radfixeddocument_1
	MemoryStream memoryStream = new MemoryStream();
	unseekableStream.CopyTo(memoryStream); 
#endregion

#region radpdfviewer-document-model-radfixeddocument_2

#endregion

#region radpdfviewer-document-model-radfixeddocument_3

#endregion

}
