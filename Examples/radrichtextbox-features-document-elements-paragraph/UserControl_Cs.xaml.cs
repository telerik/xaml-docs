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

#region radrichtextbox-features-document-elements-paragraph_1
Section section = new Section();
Paragraph paragraph = new Paragraph();
section.Blocks.Add( paragraph );
RadDocument document = new RadDocument();
document.Sections.Add(section);

this.radRichTextBox.Document = document;
#endregion

#region radrichtextbox-features-document-elements-paragraph_4
Section section = new Section();
Paragraph paragraph = new Paragraph();
Span span = new Span("Span declared in code-behind");
paragraph.Inlines.Add( span );
section.Blocks.Add( paragraph );
RadDocument document = new RadDocument();
document.Sections.Add(section);

this.radRichTextBox.Document = document;
#endregion
}
