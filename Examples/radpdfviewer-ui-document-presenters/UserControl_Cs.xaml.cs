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
	}

	#region radpdfviewer-ui-document-presenters_0
		this.radPdfViewer.FixedDocumentPresenter = this.viewer.GetRegisteredPresenter(FixedDocumentPresenterNames.FixedDocumentPagesPresenter);
	#endregion
	
	#region radpdfviewer-ui-document-presenters_1
		this.radPdfViewer.FixedDocumentPresenter = this.viewer.GetRegisteredPresenter(FixedDocumentPresenterNames.FixedDocumentSinglePageViewPresenter);
	#endregion
}
