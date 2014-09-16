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

#region radribbonview-screentips_1
ScreenTip.SetTitle(radRibbonGroupClipboard, "Clipboard");
#endregion

#region radribbonview-screentips_4
ScreenTip.SetTitle(radRibbonGroupClipboard, "Clipboard");
ScreenTip.SetDescription(radRibbonGroupClipboard, "Show the Clipboard Task options.");
#endregion

#region radribbonview-screentips_7
ScreenTip.SetTitle(radRibbonGroupClipboard, "Clipboard");
ScreenTip.SetDescription(radRibbonGroupClipboard, "Show the Clipboard Task options.");
ScreenTip.SetIcon(radRibbonGroupClipboard, new BitmapImage(new Uri("Images/IconMSOffice/ClipboardScreenTipIcon.png",UriKind.Relative)));
#endregion
}
