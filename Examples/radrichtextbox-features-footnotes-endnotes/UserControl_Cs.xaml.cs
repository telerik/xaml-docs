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

#region radrichtextbox-features-footnotes-endnotes_1
public void InsertFootnote()
public void InsertFootnote(Note footnote)
public void InsertEndnote()
public void InsertEndnote(Note endnote)
#endregion

#region radrichtextbox-features-footnotes-endnotes_2
public static Note CreateCustomMarkFootnote(string symbol, FontFamily fontFamily = null)
public static Note CreateCustomMarkEndnote(string symbol, FontFamily fontFamily = null)
public static Note CreateDefaultFootnote()
public static Note CreateDefaultEndnote()
#endregion

#region radrichtextbox-features-footnotes-endnotes_3
Note note = Note.CreateCustomMarkFootnote("$", new FontFamily("Calibri"));
this.radRichtextBox.InsertFootnote(note);
#endregion

#region radrichtextbox-features-footnotes-endnotes_4
public void GoToNextFootnote()
public void GoToPreviousFootnote()
public void GoToNextEndnote()
public void GoToPreviousEndnote()
#endregion

#region radrichtextbox-features-footnotes-endnotes_5
EndnoteRangeStart noteRangeStart = this.radRichtextBox.Document.EnumerateChildrenOfType<EndnoteRangeStart>().FirstOrDefault();

if (noteRangeStart != null)
{ 
    this.radRichtextBox.ScrollToNote(noteRangeStart.Note);
}
#endregion
}
