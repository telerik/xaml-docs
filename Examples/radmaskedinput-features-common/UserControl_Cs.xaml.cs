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

#region radmaskedinput-features-common_1
public class NumericValueToTextConverter : IValueConverter
{
 public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
 {
  if (value != null)
  {
   double doubleValue = 0d;
   decimal decimalValue = 0m;
   if (double.TryParse(value.ToString(), System.Globalization.NumberStyles.Number, culture, out doubleValue))
   {
    return "Double Value: " + doubleValue.ToString("n4");
   }
   else if (decimal.TryParse(value.ToString(), System.Globalization.NumberStyles.Any, culture, out decimalValue))
   {
    return "Decimal Value: " + decimalValue.ToString("c4");
   }
   else return value.ToString();
  }
  else
  {
   return value;
  }
 }
 public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
 {
  throw new NotImplementedException();
 }
}
#endregion
}
