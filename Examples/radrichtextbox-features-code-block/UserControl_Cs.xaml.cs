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

#region radrichtextbox-features-code-block_0
	string code = "this.IsCodeBlock = true;\nthis.IsCodeBlock = false;\nthis.IsCodeBlock = true;";
	CodeFormattingSettings formattingSettings = new CodeFormattingSettings(CodeLanguages.CSharp);
	formattingSettings.IsLineNumberingEnabled = true;
	formattingSettings.IsAlternatingLinesEnabled = true;

	this.radRichTextBox.InsertCodeBlock(code, formattingSettings);
#endregion

#region radrichtextbox-features-code-block_1
	this.radRichTextBox.DeleteCodeBlock(codeBlockRangeStart);
#endregion

#region radrichtextbox-features-code-block_2
StyleDefinition commentJS = new StyleDefinition("CommentJS", StyleType.Character);
commentJS.SpanProperties.ForeColor = Colors.Gray;
commentJS.IsCustom = false;
commentJS.IsPrimary = false;

this.radRichTextBox.Document.CodeFormatter.RegisterClassificationType(ClassificationTypes.Comment, CodeLanguages.JavaScript, commentJS);
#endregion
}
