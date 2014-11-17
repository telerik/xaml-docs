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

#region radrichtextbox-features-list-styles_0
ListStyle upperRomanHierarchical = new ListStyle();
upperRomanHierarchical.StyleLink = "Style1";

for (int i = 0; i < ListStyle.ListLevels; ++i)
{
	StringBuilder levelText = new StringBuilder();
	for (int j = 0; j < i + 1; ++j)
	{
		levelText.Append("{" + j + "}.");
	}

	upperRomanHierarchical.Levels.Add(new ListLevelStyle()
	{
		StartingIndex = 1,
		NumberingFormat = ListNumberingFormat.UpperRoman,
		LevelText = levelText.ToString(),
		Indent = 48 + i * 24
	});
}
#endregion

#region radrichtextbox-features-list-styles_2
Paragraph paragraph = this.radRichTextBox.Document.CaretPosition.GetCurrentParagraphBox().AssociatedParagraph;
#endregion

#region radrichtextbox-features-list-styles_4
ListStyle newListStyle = this.radRichTextBox.Document.AddCustomListStyle(upperRomanHierarchical);
DocumentList documentList = new DocumentList(newListStyle, this.radRichTextBox.Document);
#endregion

#region radrichtextbox-features-list-styles_6
paragraph.ListId = documentList.ID;
#endregion
}
