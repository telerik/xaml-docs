using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace WpfApplication2
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
    {
        #region radpdfviewer-document-model-exceptionhandling_0
        private void LoadFromUri(object sender, System.Windows.RoutedEventArgs e)
        {
            this.pdfViewer.DocumentSource = new PdfDocumentSource(new System.Uri("PdfViewerDemo;component/SampleData/Sample.pdf", System.UriKind.Relative));
            this.pdfViewer.DocumentSource.OnException += DocumentSource_OnException;
        }

        private void DocumentSource_OnException(object sender, OnExceptionEventArgs e)
        {
            NotSupportedFilterException filterException = e.Exception as NotSupportedFilterException;
            if (filterException != null)
            {
                // The document contains a filter which is not supported.
            }
        }

        #endregion
	}
}
