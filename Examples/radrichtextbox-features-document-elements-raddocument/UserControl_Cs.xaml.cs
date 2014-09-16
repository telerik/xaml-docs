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
#region radrichtextbox-features-document-elements-raddocument_0
Section section = new Section();
this.radRichTextBox.Document.Sections.Add(section);
#endregion

#region radrichtextbox-features-document-elements-raddocument_1
this.radRichTextBox.InsertSectionBreak(SectionBreakType.NextPage);
#endregion

#region radrichtextbox-features-document-elements-raddocument_2
this.editor.Document.InsertSectionBreak(this.editor.Document.CaretPosition, this.editor.CurrentEditingStyle, SectionBreakType.NextPage);
#endregion
                
           
}
