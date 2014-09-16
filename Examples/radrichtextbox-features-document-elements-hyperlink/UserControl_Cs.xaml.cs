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

#region radrichtextbox-features-document-elements-hyperlink_0
HyperlinkInfo info = new HyperlinkInfo()
{
    NavigateUri = "http://demos.telerik.com/silverlight/#RichTextBox/TelerikEditor",
    Target = HyperlinkTargets.Blank,
    IsAnchor = false
};
this.richTextBox.InsertHyperlink(info, "RichTextBox demo");
#endregion

#region radrichtextbox-features-document-elements-hyperlink_1
HyperlinkInfo info = new HyperlinkInfo()
{
   NavigateUri = "bookmark1",
   Target = HyperlinkTargets.Self,
   IsAnchor = true
};
this.richTextBox.InsertHyperlink(info, "Link to Bookmark 1");
#endregion

#region radrichtextbox-features-document-elements-hyperlink_2
this.richTextBox.RemoveHyperlink();
#endregion

#region radrichtextbox-features-document-elements-hyperlink_3
HyperlinkRangeStart hyperlinkStart = new HyperlinkRangeStart();
HyperlinkRangeEnd hyperlinkEnd = new HyperlinkRangeEnd();
hyperlinkEnd.PairWithStart(hyperlinkStart);
HyperlinkInfo hyperlinkInfo = new HyperlinkInfo() { NavigateUri = "http://telerik.com", Target = HyperlinkTargets.Blank };
hyperlinkStart.HyperlinkInfo = hyperlinkInfo;
RadDocument document = new RadDocument();
Section section = new Section();
Paragraph paragraph = new Paragraph();
Span spanBefore = new Span("Text before the image ");
ImageInline image = new ImageInline(new Uri("/Telerik.Windows.Controls.RichTextBoxUI;component/Images/MSOffice/32/Picture.png", UriKind.Relative));
image.Size = new Size(32, 32);
Span spanAfter = new Span(" and some text after the image");
paragraph.Inlines.Add(hyperlinkStart);
paragraph.Inlines.Add(spanBefore);
paragraph.Inlines.Add(image);
paragraph.Inlines.Add(spanAfter);
section.Blocks.Add(paragraph);
Paragraph anotherParagraph = new Paragraph();
anotherParagraph.Inlines.Add(new Span("Another paragraph here and still in hyperlink"));
anotherParagraph.Inlines.Add(hyperlinkEnd);
section.Blocks.Add(anotherParagraph);
document.Sections.Add(section);
this.richTextBox.Document = document;
#endregion

#region radrichtextbox-features-document-elements-hyperlink_4
IEnumerable<HyperlinkRangeStart> links = this.richTextBox.Document.EnumerateChildrenOfType<HyperlinkRangeStart>();
foreach (HyperlinkRangeStart link in links)
{
    this.richTextBox.Document.CaretPosition.MoveToInline(link.FirstLayoutBox as InlineLayoutBox, 0);
    this.richTextBox.Document.Selection.SelectAnnotationRange(link);
    this.richTextBox.Delete(false);
    this.richTextBox.Insert("Removed hyperlink");
}
#endregion
}
