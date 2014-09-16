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

    #region radpropertygrid-defining-propertysets_2
    public class Ellipse
    {
        public Color FillColor { get; set; }
        public double RadiusX1 { get; set; }
        public double RadiusX2 { get; set; }
        public Point Center { get; set; }
    }

    public class RegularPolygon
    {
        public int CornersCount { get; set; }
        public Color FillColor { get; set; }
        public Point Center { get; set; }
        public double SideLength { get; set; }
    }

    public class ViewModel
    {
        public IEnumerable<object> Shapes
        {
            get
            {
                return new List<object>()
                {
                    new Ellipse()
                    { 
Center = new Point(1,1), 
FillColor = Colors.Red, 
RadiusX1 = 4, RadiusX2 = 2
},
                    new RegularPolygon()
                    { 
Center = new Point(3,2), 
FillColor = Colors.Blue, 
CornersCount = 3, 
SideLength = 10}
                };
            }
        }
    }


    #endregion
    #region radpropertygrid-defining-propertysets_4
      private void RadPropertyGrid_AutoGeneratingPropertyDefinition(object sender, Telerik.Windows.Controls.Data.PropertyGrid.AutoGeneratingPropertyDefinitionEventArgs e)
        {
            if (e.PropertyDefinition.DisplayName == "CornersCount")
            {
                e.PropertyDefinition.EditorTemplate = LayoutRoot.Resources["editorTemplate"] as DataTemplate;
            }
        }


 public class MyConverter : IValueConverter
    {
 
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return Int32.Parse(value.ToString());
        }
 
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return value;
        }
    }

    #endregion

}
