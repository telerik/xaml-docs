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

#region radpdfviewer-text-text-position_0
public TextPosition(RadFixedDocument document) 
public TextPosition(RadFixedPage page)
public TextPosition(RadFixedPage page, int index) 
public TextPosition(TextPosition position)
#endregion

#region radpdfviewer-text-text-position_1
public bool MoveToNextPosition()
public bool MoveToPreviousPosition()
public bool MoveToPosition(TextPosition position)
public bool MoveToNextWord()
public bool MoveToPreviousWord()
public bool MoveToCurrentWordStart()
public bool MoveToCurrentWordEnd()
public bool MoveToLineStart()
public bool MoveToLineEnd()
public bool MoveLineUp()
public bool MoveLineDown()
public bool MoveToStartOfDocument()
public bool MoveToEndOfDocument()
#endregion

#region radpdfviewer-text-text-position_2
this.pdfViewer.Document.CaretPosition.MoveToEndOfDocument();
#endregion

#region radpdfviewer-text-text-position_3

#endregion

}
