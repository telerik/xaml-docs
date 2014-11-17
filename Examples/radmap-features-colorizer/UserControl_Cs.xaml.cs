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

#region radmap-features-colorizer_10
private void ColorMeasureScale_PrepareCompleted( object sender, Telerik.Windows.Controls.Map.ShapeColorizerEventArgs e )
{
    ColorMeasureScale scale = sender as ColorMeasureScale;
    if ( scale != null )
    {
        //this lines of code modify the second last item and remove the last item.
        scale.RangeCollection[ scale.RangeCollection.Count - 2 ].MaxValue = scale.RangeCollection.Last().MaxValue;
        scale.RangeCollection.Remove( scale.RangeCollection.Last() );
    }
}
#endregion
}
