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

#region radtreemap-mappings_0
public class FileCustomMapping : CustomMapping
    {
        protected override void Apply(RadTreeMapItem treemapItem, object dataItem)
        {
            File file = dataItem as File;
            if (dataItem is File)
            {
                treemapItem.Background = new SolidColorBrush(Colors.Red);
            }
            else
            {
                treemapItem.Background = new SolidColorBrush(Colors.Blue);
            }
        }
        protected override void Clear(RadTreeMapItem treemapItem, object dataItem)
        {
            treemapItem.ClearValue(RadTreeMapItem.BackgroundProperty);
        }
    }
#endregion
}
