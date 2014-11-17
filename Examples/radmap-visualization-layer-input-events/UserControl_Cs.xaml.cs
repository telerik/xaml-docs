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

#region radmap_visualization_layer_input_events_0
private void MapShapeVisualizationCreated(object sender, MapShapeOperationEventArgs e)
{
	if (e.Visualization != null)
	{
		// Attach mouse events to the map shape visualization.
		e.Visualization.MouseEnter += this.Visualization_MouseEnter;
		e.Visualization.MouseLeave += this.Visualization_MouseLeave;
	}
}

private void MapShapeVisualizationRemoved(object sender, MapShapeOperationEventArgs e)
{
	if (e.Visualization != null)
	{
		// Detach mouse events to the map shape visualization.
		e.Visualization.MouseEnter -= this.Visualization_MouseEnter;
		e.Visualization.MouseLeave -= this.Visualization_MouseLeave;
	}
}

private void Visualization_MouseEnter(object sender, MouseEventArgs e)
{
	// Highlight shape when mouse enter.
	FrameworkElement elt = sender as FrameworkElement;
	if (elt != null)
	{
		MapShapeData data = elt.DataContext as MapShapeData;
		data.UseHighlightFill();
	}
}

private void Visualization_MouseLeave(object sender, MouseEventArgs e)
{
	// Use regular fill when mouse leave the shape.
	FrameworkElement elt = sender as FrameworkElement;
	if (elt != null)
	{
		MapShapeData data = elt.DataContext as MapShapeData;
		data.UseRegularFill();
	}
}
#endregion
}
