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
	
	#region radheatmap-populating-with-data_0
   public class TempInfo
    {
        public DateTime Year { get; set; }
        public string Month { get; set; }
        public double Temperature { get; set; }
        public double Rain { get; set; }
    }
	#endregion
	
	#region radheatmap-populating-with-data_1
DateTime date = new DateTime(2010, 1, 1);

var infos = new List<TempInfo>() 
{
    new TempInfo() { Year = date, Month = "Apr", Temperature = 17, Rain = 8.8},
    new TempInfo() { Year = date, Month = "May", Temperature = 20, Rain = 6.25},

    new TempInfo() { Year = date.AddYears(1), Month = "Jan", Temperature = 5, Rain=10.3},
    new TempInfo() { Year = date.AddYears(1), Month = "Feb", Temperature = 13, Rain = 9.8},
    new TempInfo() { Year = date.AddYears(1), Month = "Mar", Temperature = 21, Rain = 9.6},

    new TempInfo() { Year = date.AddYears(2), Month = "Jan", Temperature = 14, Rain = 11.5},
    new TempInfo() { Year = date.AddYears(2), Month = "Feb", Temperature = 19, Rain = 7.5},
    new TempInfo() { Year = date.AddYears(2), Month = "Mar", Temperature = 17, Rain = 10.1},
};
	#endregion
	}
	
}
