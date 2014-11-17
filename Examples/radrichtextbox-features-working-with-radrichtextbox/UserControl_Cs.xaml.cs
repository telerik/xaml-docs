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

#region radrichtextbox-features-working-with-radrichtextbox_3
private void radRichTextBox_CurrentSpanStyleChanged( object sender, EventArgs e )
{
    StyleDefinition style = this.radRichTextBox.CurrentEditingStyle;
    FontWeight fontWeight = style.SpanProperties.FontWeight;
    this.BoldButton.IsChecked = fontWeight == FontWeights.Bold;
}
#endregion
}
