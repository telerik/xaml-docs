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

#region radrichtextbox-features-history_0
this.radRichTextBox.Document.History.Enabled = false;
#endregion

#region radrichtextbox-features-history_2
this.radRichTextBox.Document.History.Clear();
#endregion

#region radrichtextbox-features-history_4
private void UndoAction()
{
    this.radRichTextBox.Undo();
}
private void RedoAction()
{
    this.radRichTextBox.Redo();
}
#endregion

#region radrichtextbox-features-history_6
this.radRichTextBox.Document.History.Depth = 500;
#endregion
}
