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

#region radchart-features-trackball_3
private void ChartTrackBallBehavior_TrackInfoUpdated(object sender, TrackBallInfoEventArgs e)
{
    foreach (DataPointInfo info in e.Context.DataPointInfos)
    {
        info.DisplayHeader = "Custom data point header";
    }
    e.Header = "Sample header";
}
#endregion
}
