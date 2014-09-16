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

#region radrichtextbox-features-search_0
private void SelectAllMatches(string toSearch)
{
    this.radRichTextBox.Document.Selection.Clear(); // this clears the selection before processing
    DocumentTextSearch search = new DocumentTextSearch(this.radRichTextBox.Document);
    foreach (var textRange in search.FindAll(toSearch))
    {
        this.radRichTextBox.Document.Selection.AddSelectionStart(textRange.StartPosition);
        this.radRichTextBox.Document.Selection.AddSelectionEnd(textRange.EndPosition);
    }
}
#endregion

#region radrichtextbox-features-search_2
toSearch = Regex.Escape(toSearch);
#endregion

#region radrichtextbox-features-search_4
this.radRichTextBox.ChangeTextHighlightColor(Colors.LightGray);  // will highlight all selected words in LightGray
this.radRichTextBox.ChangeFontSize(Unit.PointToDip(32));   // will increase the font size of the words to 30 DIP
this.radRichTextBox.ChangeFontFamily(new FontFamily("Comic Sans MS")); // will change the font family of the spans, containing these words.
#endregion

#region radrichtextbox-features-search_6
this.radRichTextBox.Document.Selection.Clear();
#endregion

#region radrichtextbox-features-search_8
private void ReplaceAllMatches(string toSearch, string toReplaceWith)
{
    this.radRichTextBox.Document.Selection.Clear(); // this clears the selection before processing
    DocumentTextSearch search = new DocumentTextSearch(this.radRichTextBox.Document);
    List<TextRange> rangesTrackingDocumentChanges = new List<TextRange>();
    foreach (var textRange in search.FindAll(toSearch))
    {
        TextRange newRange = new TextRange(new DocumentPosition(textRange.StartPosition, true), new DocumentPosition(textRange.EndPosition, true));
        rangesTrackingDocumentChanges.Add(newRange);
    }
    foreach (var textRange in rangesTrackingDocumentChanges)
    {
        this.radRichTextBox.Document.Selection.AddSelectionStart(textRange.StartPosition);
        this.radRichTextBox.Document.Selection.AddSelectionEnd(textRange.EndPosition);
        this.radRichTextBox.Insert(toReplaceWith);
        textRange.StartPosition.Dispose();
        textRange.EndPosition.Dispose();
    }
}
#endregion
}
