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

#region radchart-styling-and-appearance-styling-axis-line_1
this.radChart.DefaultView.ChartArea.AxisX.AxisStyles.AxisLineStyle = this.Resources[ "AxisLineStyle" ] as Style;
this.radChart.DefaultView.ChartArea.AxisY.AxisStyles.AxisLineStyle = this.Resources[ "AxisLineStyle" ] as Style;
#endregion

#region radchart-styling-and-appearance-styling-axis-line_5
public MainPage()
{
InitializeComponent(); 
RadChart1.AddHandler(MouseLeftButtonDownEvent, new MouseButtonEventHandler(MouseLeftButtonDownEventHandler), true); 
}
#endregion

#region radchart-styling-and-appearance-styling-axis-line_7
public void MouseLeftButtonDownEventHandler(object sender, MouseButtonEventArgs e)
        {
            TextBlock txtBlock = e.OriginalSource as TextBlock;
            if (txtBlock == null)
                return;
            var axis = txtBlock.GetVisualParent<AxisX2D>();
            if (axis != null)
            {
                axis.Foreground = new SolidColorBrush(Colors.Red); 
            }            
        }
#endregion
}
