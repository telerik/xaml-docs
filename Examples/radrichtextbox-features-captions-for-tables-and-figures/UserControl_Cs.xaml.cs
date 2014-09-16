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



#region radrichtextbox-features-captions-for-tables-and-figures_1
public void InsertCaption(CaptionDefinition definition, string caption, bool includeLabel, bool insertBelow)
#endregion

#region radrichtextbox-features-captions-for-tables-and-figures_2
CaptionDefinition captionDefinition = new CaptionDefinition();
captionDefinition.Label = "testLabel";
captionDefinition.NumberingFormat = Documents.Model.Fields.NumberingFormat.Arabic;
captionDefinition.SeparatorType = Documents.Model.Fields.CaptionSeparatorType.Colon;
this.radRichTextBox1.InsertCaption(captionDefinition, "captionText", true, true);
#endregion

#region radrichtextbox-features-captions-for-tables-and-figures_3
this.radRichTextBox1.InsertCaption(this.editor.Document.CaptionDefinitions["Table"], "captionText", true, true);
#endregion

}
