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

		#region radmediaplayer-smoothstreaming_1
		private void RadMediaItem_StreamAttached(object sender, EventArgs e)
		{
			var item = sender as RadMediaItem;
			if (item != null)
			{
				var adaptiveSource = new AdaptiveStreamingSource();
				adaptiveSource.MediaElement = player.MediaElement;
				adaptiveSource.ManifestUrl = item.Source;
				adaptiveSource.StartPlayback();
			}
		}
		#endregion
	}
}
