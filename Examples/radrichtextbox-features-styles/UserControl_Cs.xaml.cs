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

#region radrichtextbox-features-styles_0
StyleDefinition charStyle = new StyleDefinition();
charStyle.Type = StyleType.Character;
charStyle.SpanProperties.FontFamily = new FontFamily("Calibri");
charStyle.SpanProperties.FontSize = Unit.PointToDip(20);
charStyle.SpanProperties.ForeColor = Colors.Orange;
charStyle.DisplayName = "charStyle";
charStyle.Name = "charStyle";

this.editor.Document.StyleRepository.Add(charStyle);
#endregion

#region radrichtextbox-features-styles_1
StyleDefinition paragraphStyle = new StyleDefinition();
paragraphStyle.Type = StyleType.Paragraph;
paragraphStyle.ParagraphProperties.Background = Colors.Red;
paragraphStyle.ParagraphProperties.TextAlignment = RadTextAlignment.Center;
paragraphStyle.DisplayName = "paragraphStyle";
paragraphStyle.Name = "paragraphStyle";

this.editor.Document.StyleRepository.Add(paragraphStyle);
#endregion

#region radrichtextbox-features-styles_2
StyleDefinition linkedParagraphStyle = new StyleDefinition();
linkedParagraphStyle.Type = StyleType.Paragraph;
linkedParagraphStyle.ParagraphProperties.Background = Colors.Yellow;
linkedParagraphStyle.DisplayName = "linkedParagraphStyle";
linkedParagraphStyle.Name = "linkedParagraphStyle";

StyleDefinition linkedCharStyle = new StyleDefinition();
linkedCharStyle.Type = StyleType.Character;
linkedCharStyle.SpanProperties.FontWeight = FontWeights.Bold;
linkedCharStyle.SpanProperties.FontSize = Unit.PointToDip(30);
linkedCharStyle.SpanProperties.ForeColor = Colors.Purple;
linkedCharStyle.DisplayName = "linkedCharStyle";
linkedCharStyle.Name = "linkedCharStyle";
linkedParagraphStyle.LinkedStyle = linkedCharStyle;

this.editor.Document.StyleRepository.Add(linkedParagraphStyle);
this.editor.Document.StyleRepository.Add(linkedCharStyle);
#endregion

#region radrichtextbox-features-styles_3
this.editor.ChangeStyleName("linkedParagraphStyle");
#endregion

#region radrichtextbox-features-styles_4
table.StyleName = RadDocumentDefaultStyles.DefaultTableGridStyleName;
#endregion

#region radrichtextbox-features-styles_5
paragraph.StyleName = RadDocumentDefaultStyles.GetHeadingStyleNameByIndex(1);
#endregion
}
