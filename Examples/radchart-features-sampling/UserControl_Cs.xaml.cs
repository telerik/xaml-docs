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

#region radchart-features-sampling_2
public static class Statistics
    {
        public static double StdDev<TSource>(IEnumerable<TSource> source, Func<TSource, MyClass> selector)
        {
            return StdDev<TSource, MyClass>(source, selector);
        }
        public static double StdDev<TSource, TResult>(IEnumerable<TSource> source, Func<TSource, TResult> selector)
            where TResult : MyClass
        {
            int itemCount = source.Count();
            if (itemCount > 1)
            {
                IEnumerable<double> values = from i in source select Convert.ToDouble(selector(i).Y);
                double sum = SumAvg(values);
                return Math.Sqrt(sum / (itemCount - 1));
            }
            return 0;
        }
        private static double SumAvg(IEnumerable<double> values)
        {
            double average = values.Average();
            double sum = 0;
            foreach (double item in values)
            {
                sum += Math.Pow(item - average, 2);
            }
            return sum;
        }
    }
#endregion

#region radchart-features-sampling_4
public class StandardDeviationFunction : EnumerableSelectorAggregateFunction
    {
        protected override string AggregateMethodName
        {
            get
            {
                return "StdDev";
            }
        }
        protected override Type ExtensionMethodsType
        {
            get
            {
                return typeof(Statistics);
            }
        }
    }
#endregion

#region radchart-features-sampling_6
...
InitializeComponent();
RadChar1.DefaultView.ChartArea.AxisX.LabelStep = 4;
List<MyClass> data = new List<MyClass>();
            for (int i = 0; i < 1000; i++)
            {
                data.Add(new MyClass()
                {
                    Y  = i
                });
            }
  RadChar1.ItemsSource = data;
...
public class MyClass
{
public double Y { get; set; }
}
#endregion
}
