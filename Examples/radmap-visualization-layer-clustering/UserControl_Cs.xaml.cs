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

#region radmap-visualization-layer-clustering_4
private void ExpandClusterToPolygon(object sender, MouseButtonEventArgs e)
{
    FrameworkElement element = sender as FrameworkElement;
    if (element != null)
    {
        ClusterData data = element.DataContext as ClusterData;
        if (data != null)
        {
            if (data.ClusterState != ClusterState.ExpandedToPolygon)
            {
                data.HideExpanded = false;
                data.ClusterState = ClusterState.ExpandedToPolygon;
            }
            else
            {
                data.ClusterState = ClusterState.Collapsed;
            }
        }
    }

    e.Handled = true;
}
#endregion
    #region radmap-visualization-layer-clustering_6
private void ExpandCluster(object sender, MouseButtonEventArgs e)
{
    FrameworkElement element = sender as FrameworkElement;
    if (element != null)
    {
        ClusterData data = element.DataContext as ClusterData;
        if (data != null)
        {
            if (data.ClusterState != ClusterState.Expanded)
            {
                data.HideExpanded = false;
                data.ClusterState = ClusterState.Expanded;
            }
            else
            {
                data.ClusterState = ClusterState.Collapsed;
            }
        }
    }

    e.Handled = true;
}
    #endregion

}
