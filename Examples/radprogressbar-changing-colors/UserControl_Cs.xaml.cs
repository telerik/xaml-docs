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
		public void Colors()
		{
			#region radprogressbar-changing-colors_1
			RadProgressBar myProgressBar = new RadProgressBar();
			// Set Background directly 
			myProgressBar.Background = new SolidColorBrush(Colors.Yellow);
			// Set Background using a Style
			Style myStyle = new Style(typeof(RadProgressBar));
			myStyle.Setters.Add(new Setter(RadProgressBar.BackgroundProperty, new SolidColorBrush(Colors.Yellow)));
			myProgressBar.Style = myStyle;
			#endregion

			#region radprogressbar-changing-colors_3
			// Set Foreground directly
			myProgressBar.Foreground = new SolidColorBrush(Colors.Yellow);
			// Set Foreground using a Style
			Style myStyle2 = new Style(typeof(RadProgressBar));
			myStyle2.Setters.Add(new Setter(RadProgressBar.ForegroundProperty, new SolidColorBrush(Colors.Yellow)));
			myProgressBar.Style = myStyle2;
			#endregion

			#region radprogressbar-changing-colors_5
			// Set BorderBrush  directly
			myProgressBar.BorderBrush = new SolidColorBrush(Colors.Red);
			// Set BorderBrush using a Style
			Style myStyle3 = new Style(typeof(RadProgressBar));
			myStyle3.Setters.Add(new Setter(RadProgressBar.BorderBrushProperty, new SolidColorBrush(Colors.Red)));
			myProgressBar.Style = myStyle3;
			#endregion
		}
	}

}
