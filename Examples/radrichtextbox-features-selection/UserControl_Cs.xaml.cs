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

#region radrichtextbox-features-selection_0
DocumentPosition startPosition = this.radRichTextBox.Document.CaretPosition; //new DocumentPosition( this.radRichTextBox.Document );
DocumentPosition endPosition = new DocumentPosition(startPosition);
startPosition.MoveToCurrentWordStart();
endPosition.MoveToCurrentWordEnd();
this.radRichTextBox.Document.Selection.AddSelectionStart(startPosition);
this.radRichTextBox.Document.Selection.AddSelectionEnd(endPosition);
#endregion

#region radrichtextbox-features-selection_2
DocumentPosition position = new DocumentPosition(this.radRichTextBox.Document);
do
{
    //GetCurrentSpan().Text returns the word at the position
    string word = position.GetCurrentSpanBox().Text;
    if (word.Contains("RadRichTextBox"))
    {
        DocumentPosition wordEndPosition = new DocumentPosition(position);
        wordEndPosition.MoveToCurrentWordEnd();
        this.radRichTextBox.Document.Selection.AddSelectionStart(position);
        this.radRichTextBox.Document.Selection.AddSelectionEnd(wordEndPosition);
    }
} while (position.MoveToNextWordStart());
#endregion
}
