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
    #region radrichtextbox-features-raddocumenteditor_0
		RadDocumentEditor documentEditor = new RadDocumentEditor(document);
    #endregion

	#region radrichtextbox-features-raddocumenteditor_1
		documentEditor.BeginUndoGroup();

		if (documentEditor.Document.CaretPosition.IsPositionInsideTable)
		{
			documentEditor.InsertTableRow();
			documentEditor.InsertTableRow();
			documentEditor.InsertTableRow();
			documentEditor.Document.Selection.Clear();
		}

		documentEditor.EndUndoGroup("Insert three table rows");
    #endregion
	
	#region radrichtextbox-features-raddocumenteditor_2
		documentEditor.BeginUndoGroup();

		if (documentEditor.Document.CaretPosition.IsPositionInsideTable)
		{
			documentEditor.InsertTableRow();
			documentEditor.InsertTableRow();
			documentEditor.InsertTableRow();
			documentEditor.Document.Selection.Clear();
		}

		documentEditor.CancelUndoGroup();
	#endregion
}
