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
				
#region radchartview-features-conversion_0
private void UIElement_MouseMove(object sender, MouseEventArgs e)
{
    Point mousePosition = e.GetPosition(radCartesianChart1);
    DataTuple tuple = radCartesianChart1.ConvertPointToData(mousePosition);

    string Category = (string)tuple.FirstValue;
    double Value = (double)tuple.SecondValue;
    //...
}
#endregion

#region radchartview-features-conversion_1

#endregion

#region radchartview-features-conversion_2

#endregion


		}
	}
}
