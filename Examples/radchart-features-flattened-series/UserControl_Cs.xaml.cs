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

#region radchart-features-flattened-series_2
public Sample()
{
    InitializeComponent();
    this.radChart.SeriesMappings[ 0 ].GroupingSettings.ShouldFlattenSeries = true;
}
#endregion

#region radchart-features-flattened-series_5
private void CheckBox_Click( object sender, RoutedEventArgs e )
{
    bool? isChecked = ( sender as CheckBox ).IsChecked;
    if ( isChecked == null )
        return;
    this.radChart.SeriesMappings[ 0 ].GroupingSettings.ShouldFlattenSeries = ( bool )isChecked;
    this.radChart.Rebind();
}
#endregion
}
