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

#region radnumericupdown-formatting_0-1
private RadNumericUpDown TestMethod()
{
   RadNumericUpDown numeric = new RadNumericUpDown();
   numeric.Value = 15.50;
   numeric.ValueFormat = ValueFormat.Numeric;
   numeric.NumberFormatInfo = new NumberFormatInfo() { NumberDecimalDigits = 0 };
   //ContentText is "16"
   return numeric;
 }
#endregion

#region radnumericupdown-formatting_0-2
private RadNumericUpDown TestMethod()
{
   RadNumericUpDown numeric = new RadNumericUpDown();
   numeric.Value = 15.50;
   numeric.ValueFormat = ValueFormat.Currency;
   numeric.NumberFormatInfo = new NumberFormatInfo() { CurrencyDecimalDigits = 2 };
   //ContentText is "$15.50"
   return numeric;
 }
#endregion

#region radnumericupdown-formatting_0-3
private RadNumericUpDown TestMethod()
{
   RadNumericUpDown numeric = new RadNumericUpDown();
   numeric.Value = 15.50;
   numeric.ValueFormat = ValueFormat.Percentage;
   numeric.NumberFormatInfo = new NumberFormatInfo() { PercentDecimalDigits = 1 };
   //ContentText is "%1500.5"
   return numeric;
 }
#endregion

#region radnumericupdown-formatting_2
private RadNumericUpDown TestMethod()
{
   RadNumericUpDown numeric = new RadNumericUpDown();
   numeric.Value = 10;
   numeric.ValueFormat = ValueFormat.Numeric;
   numeric.NumberFormatInfo = new NumberFormatInfo() { NumberDecimalDigits = 2 };
   numeric.CustomUnit = "meters";
   //the display result is "10.00 meters"
   return numeric;
}
#endregion
}
