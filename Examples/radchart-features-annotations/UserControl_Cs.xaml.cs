using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace WpfApplication1
{
	
	public partial class MainWindow: Window
	{
		public MainWindow()
        	{
            	InitializeComponent();
				
#region radchartview-features-annotations_0
cartesianChart.Annotations.Add(
    new CartesianGridLineAnnotation 
    { 
        Axis = cartesianChart.VerticalAxis, 
        Value = 6, Stroke = new SolidColorBrush(Colors.Red), 
        StrokeThickness = 1
    });
cartesianChart.Annotations.Add(
    new CartesianGridLineAnnotation 
    { 
        Axis = cartesianChart.HorizontalAxis, 
        Value = 2.8, Stroke = new SolidColorBrush(Colors.Blue), 
        StrokeThickness = 1
    });
#endregion

#region radchartview-features-annotations_1
polarChart.Annotations.Add(
    new PolarAxisGridLineAnnotation { Value = 2, Stroke = new SolidColorBrush(Colors.Red) });
polarChart.Annotations.Add(
    new PolarAxisGridLineAnnotation { Value = 7, Stroke = new SolidColorBrush(Colors.LightGreen) });
polarChart.Annotations.Add(
    new PolarAxisGridLineAnnotation { Value = 8, Stroke = new SolidColorBrush(Colors.LightBlue) });
#endregion

#region radchartview-features-annotations_2

#endregion


		}
	}
}
