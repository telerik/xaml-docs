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

#region radrichtextbox-features-document-elements-section_0
Section section = new Section();
Paragraph paragraph = new Paragraph();
section.Blocks.Add(paragraph);
#endregion

#region radrichtextbox-features-document-elements-section_1
Section section = new Section();
this.radRichTextBox.Document.Sections.Add(section);
#endregion

#region radrichtextbox-features-document-elements-section_2
Header header = new Header() { Body = radDocument, IsLinkedToPrevious = false }; //radDocument is an instance of RadDocument, representing the content of a Header, 
                                                                                 //typically contains a few paragraphs
#endregion

#region radrichtextbox-features-document-elements-section_3
section.Headers.First = header;
#endregion

#region radrichtextbox-features-document-elements-section_4
this.editor.UpdateHeader(this.editor.Document.Sections.First, HeaderFooterType.First, header);
#endregion

#region radrichtextbox-features-document-elements-section_5
Section section = new Section();
Paragraph paragraph = new Paragraph();
section.Blocks.Add(paragraph);
#endregion

#region radrichtextbox-features-document-elements-section_6
this.radRichTextBox.Insert(FormattingSymbolLayoutBox.ENTER);
#endregion

#region radrichtextbox-features-document-elements-section_7
//When creating a Section programmatically
section.PageMargin = new Padding(40, 40, 30, 30);

//When the section has already been added to the document
this.editor.ChangeSectionPageMargin(new Padding(40, 40, 30, 30));
#endregion

#region radrichtextbox-features-document-elements-section_8
//When creating a Section programmatically
section.PageOrientation = PageOrientation.Landscape;

//When the section has already been added to the document
this.editor.ChangeSectionPageOrientation(PageOrientation.Landscape);
#endregion

#region radrichtextbox-features-document-elements-section_9
//When creating a Section programmatically
section.PageSize = PaperTypeConverter.ToSize(PaperTypes.A4);

//When the section has already been added to the document
this.editor.ChangeSectionPageSize(PaperTypeConverter.ToSize(PaperTypes.A4));
#endregion

}
