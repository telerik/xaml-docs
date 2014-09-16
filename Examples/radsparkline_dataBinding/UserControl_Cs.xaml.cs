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

#region radsparkline_dataBinding_1
Random r = new Random();
List<double> myData = new List<double>();
for (int i = 0; i < 20; i++)
{
myData.Add(r.Next(0,100));
}
myLinearSparkline.ItemsSource = myData;
#endregion

#region radsparkline_dataBinding_2
      public partial class MainPage : UserControl 
    {
        public MainPage() //MainWindow in WPF
        {
            InitializeComponent();
            DateTime today = DateTime.Today;

            List<MyCost> data = new List<MyCost>()
            {
                new MyCost() { Cost = 1, UnitCost = 2, MyDate=today },
                new MyCost() { Cost = 2, UnitCost = 4, MyDate= today.AddDays(1)},
                new MyCost() { Cost = 3, UnitCost = 6, MyDate=today.AddDays(2) },
                new MyCost() { Cost = 4, UnitCost = 4, MyDate=today.AddDays(3)},
                new MyCost() { Cost = 5, UnitCost = 8, MyDate=today.AddDays(4)},
            };
            this.DataContext = data;
        }
    }

    public class MyCost
    {
        public double Cost { get; set; }
        public double UnitCost { get; set; }
        public DateTime MyDate { get; set; }
    }
#endregion
}
