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

#region raddatapager-change-page-size-dynamically_0
public class CountConverter : IValueConverter
 {
  public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
  {
   var items = (value as DataPagerPresenter).DataContext as SampleDataSource;
   int i = 1;
   List<int> result = new List<int>();
   foreach (var item in items.Collection)
   {
    if (i % 5 == 0)
    {
     result.Add(i);
    }
    i++;
   }
   return result;
  }
  public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
  {
   return value;
  }
 }
#endregion
}
