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

#region radrichtextbox-features-document-elements-bookmarks_0
private void ReplaceContentOfBookmark(string bookmarkName)
{
    BookmarkRangeStart bookmark = this.radRichTextBox.Document.GetBookmarkByName(bookmarkName);
    this.radRichTextBox.Document.Selection.SelectAnnotationRange(bookmark);
    this.radRichTextBox.Document.Delete(false);
    this.radRichTextBox.Insert(bookmarksToContent[bookmarkName]);
}
#endregion

#region radrichtextbox-features-document-elements-bookmarks_1
private void ChangeAllBookmarks(RadRichTextBox radRichTextBox)
{
    BookmarkRangeStart[] bookmarks = this.radRichTextBox.Document.GetAllBookmarks().ToArray<BookmarkRangeStart>();
    DocumentPosition start = new DocumentPosition(radRichTextBox.Document);
    DocumentPosition end = new DocumentPosition(radRichTextBox.Document);
    foreach (BookmarkRangeStart item in bookmarks)
    {
        radRichTextBox.Document.GoToBookmark(item);
        start.MoveToInline(item.FirstLayoutBox as InlineLayoutBox, 0);
        end.MoveToInline(item.End.FirstLayoutBox as InlineLayoutBox, 0);
        start.MoveToNextInline();
        radRichTextBox.Document.Selection.SetSelectionStart(start);
        radRichTextBox.Document.Selection.AddSelectionEnd(end);
        radRichTextBox.Delete(false);
        radRichTextBox.Insert(bookmarksToContent[item.Name]);
    }
}
#endregion
}
