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

#region radpdfviewer-wiring-ui_0
private void tbCurrentPage_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
{
	TextBox textBox = sender as TextBox;
	if (textBox != null)
	{
		if (e.Key == System.Windows.Input.Key.Enter)
		{
			textBox.GetBindingExpression(TextBox.TextProperty).UpdateSource();
		}
	}
}

private void tbFind_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
{
    if (e.Key == System.Windows.Input.Key.Enter)
    {
        this.pdfViewer.Commands.FindCommand.Execute(this.tbFind.Text);
        this.btnPrev.Visibility = System.Windows.Visibility.Visible;
        this.btnNext.Visibility = System.Windows.Visibility.Visible;
    }
}
#endregion

}
