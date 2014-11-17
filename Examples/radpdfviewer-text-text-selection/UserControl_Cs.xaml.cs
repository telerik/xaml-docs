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

#region radpdfviewer-text-text-selection_0
this.pdfViewer.Mode = Telerik.Windows.Documents.Fixed.UI.FixedDocumentViewerMode.TextSelection;
#endregion

#region radpdfviewer-text-text-selection_1
public void SetSelectionStart(TextPosition startPosition)
public void SetSelectionEnd(TextPosition endPosition)
public void SetSelection(TextPosition startPosition, TextPosition endPosition)

public void SelectAll()
public void Clear()

public string GetSelectedText()
public void GetSelectedTextAsync(Action<string> callback)
#endregion

#region radpdfviewer-text-text-selection_2
TextPosition start = new TextPosition(this.pdfViewer.Document.CaretPosition);
start.MoveToCurrentWordStart();
TextPosition end = new TextPosition(this.pdfViewer.Document.CaretPosition);
end.MoveToCurrentWordEnd();
this.pdfViewer.Document.Selection.SetSelection(start, end);
MessageBox.Show(this.pdfViewer.Document.Selection.GetSelectedText());
#endregion
}
