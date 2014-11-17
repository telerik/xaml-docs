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

#region raddocking-features-compass_0
Compass compass = new Compass();
compass.IsBottomIndicatorVisible = false;
compass.IsCenterIndicatorVisible = false;
#endregion

#region raddocking-features-compass_2
RootCompass rootCompass = new RootCompass();
rootCompass.IsLeftIndicatorVisible = false;
rootCompass.IsRightIndicatorVisible = false;
#endregion

#region raddocking-features-compass_4
public partial class CompassSample : UserControl
{
    public CompassSample()
    {
        InitializeComponent();
        radDocking.PreviewShowCompass += new EventHandler<Telerik.Windows.Controls.Docking.PreviewShowCompassEventArgs>( radDocking_PreviewShowCompass );
    }
    private void radDocking_PreviewShowCompass( object sender, Telerik.Windows.Controls.Docking.PreviewShowCompassEventArgs e )
    {
        e.Compass.Background = new SolidColorBrush( Colors.Red );
    }
}
#endregion
}
