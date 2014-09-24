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

#region radrichtextbox-features-clipboard-support_0
this.radRichTextBox.Copy();
this.radRichTextBox.Cut();
this.radRichTextBox.Paste();
#endregion

#region radrichtextbox-features-clipboard-support_1
    ClipboardEx.ClipboardHandlers.Clear();

    ClipboardHandler clipboardHandler = new ClipboardHandler();
    clipboardHandler.ClipboardDataFormat = DataFormats.Text;
    clipboardHandler.DocumentFormatProvider = new TxtFormatProvider();

    ClipboardEx.ClipboardHandlers.Add(clipboardHandler);
#endregion

#region radrichtextbox-features-clipboard-support_2
    public interface IExternalClipboard
    {
        bool ContainsFragment();
        DocumentFragment GetFragment();
        void SetFragment(DocumentFragment fragment);
    }
#endregion

#region radrichtextbox-features-clipboard-support_3
ClipboardEx.ExternalClipboard = new RichTextExternalClipboard();
#endregion
}
