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

#region radrichtextbox-features-positioning_0
string currentSpanText = this.radRichTextBox.Document.CaretPosition.GetCurrentSpanBox().Text;
#endregion

#region radrichtextbox-features-positioning_2
DocumentPosition position = new DocumentPosition( this.radRichTextBox.Document );
string currentSpanText = position.GetCurrentSpanBox().Text;
#endregion
}
