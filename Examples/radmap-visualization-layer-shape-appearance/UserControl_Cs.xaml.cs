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

#region radmap_visualization_layer_shape_appearance_0
public partial class HighlightShapeOnMouseClick : UserControl
{
	public HighlightShapeOnMouseClick()
	{
		InitializeComponent();
	}

	private void MapShapeVisualizationCreated(object sender, MapShapeOperationEventArgs e)
	{
		if (e.Visualization != null)
		{
			// Attach mouse events to the map shape visualization.
			e.Visualization.MouseLeftButtonDown += this.Visualization_MouseLeftButtonDown;
		}
	}

	private void MapShapeVisualizationRemoved(object sender, MapShapeOperationEventArgs e)
	{
		if (e.Visualization != null)
		{
			// Detach mouse events to the map shape visualization.
			e.Visualization.MouseLeftButtonDown -= this.Visualization_MouseLeftButtonDown;
		}
	}

	private void Visualization_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
	{
		FrameworkElement elt = sender as FrameworkElement;
		if (elt != null)
		{
			MapShapeData data = elt.DataContext as MapShapeData;
			if (data.IsHighlighted)
			{
				data.UseRegularFill();
			}
			else
			{
				data.UseHighlightFill();
			}
		}

		e.Handled = true;
	}
}
#endregion

#region radmap_visualization_layer_shape_appearance_1

#endregion

}
