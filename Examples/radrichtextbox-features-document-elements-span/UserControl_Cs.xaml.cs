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

#region radrichtextbox-features-document-elements-span_1
Section section = new Section();
Paragraph paragraph = new Paragraph();
Span span = new Span("Span declared in code-behind");
paragraph.Inlines.Add( span );
section.Blocks.Add( paragraph );
this.radRichTextBox.Document.Sections.Add( section );
#endregion

#region radrichtextbox-features-document-elements-span_4
Span span = new Span();
span.Text = "Thank you for choosing Telerik RadRichTextBox!";
#endregion
}
