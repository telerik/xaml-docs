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

#region radrichtextbox-features-wire-up-ui-using-radribbonbar_2
public EditorSample()
{
    InitializeComponent();
    this.radRichTextBox.Document.PageLayoutSettings.Width = 200;
    this.radRichTextBox.Document.PageLayoutSettings.Height = 300;   
}
#endregion

#region radrichtextbox-features-wire-up-ui-using-radribbonbar_4
private void Bold_Click( object sender, RoutedEventArgs e )
{
    this.radRichTextBox.ToggleBold();
}
private void Italic_Click( object sender, RoutedEventArgs e )
{
    this.radRichTextBox.ToggleItalic();
}
private void Underline_Click( object sender, RoutedEventArgs e )
{
    this.radRichTextBox.ToggleUnderline();
}
#endregion

#region radrichtextbox-features-wire-up-ui-using-radribbonbar_6
private void radRtb_CurrentSpanStyleChanged( object sender, EventArgs e )
{
    var currRtbStyle = this.radRichTextBox.CurrentSpanStyle;
    this.Bold.IsChecked = currRtbStyle.FontWeight == FontWeights.Bold;
    this.Italic.IsChecked = currRtbStyle.FontStyle == FontStyles.Italic;
    this.Underline.IsChecked = currRtbStyle.Underline;
}
#endregion
}
