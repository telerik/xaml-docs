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

#region radchart-features-tooltip_3
public class QuarterToVisibilityConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
        if (value == null)
        {
            return Visibility.Collapsed;
        }
        return Visibility.Visible;
    }
    public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
public class ProfitToBrushConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
        double profitDifference = (double)value;
        if (profitDifference < 0)
        {
            return new SolidColorBrush(Colors.Red);
        }
        if (profitDifference > 0)
        {
            return new SolidColorBrush(Colors.Green);
        }
        return new SolidColorBrush(Colors.Green);
    }
    public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
#endregion

#region radchart-features-tooltip_5
public class ProfitDifferenceContext
    {
        public string Quarter
        {
            get;
            set;
        }
        public double Profit
        {
            get;
            set;
        }
        public object PreviousQuarter
        {
            get;
            set;
        }
        public double PreviousDifference
        {
            get;
            set;
        }
        public object NextQuarter
        {
            get;
            set;
        }
        public double NextDifference
        {
            get;
            set;
        }
    }
#endregion

#region radchart-features-tooltip_7
  public MainPage()
        {
            InitializeComponent();
            List<ProfitDifferenceContext> items = CreateItems();
            this.chart.Series[0].ItemsSource = items;
        }

        private List<ProfitDifferenceContext> CreateItems()
        {
            List<ProfitDifferenceContext> items = new List<ProfitDifferenceContext>();
            Random r = new Random();
            const int itemsCount = 4;
            for (int i = 0; i < itemsCount; i++)
            {
                ProfitDifferenceContext profitDiffContext = new ProfitDifferenceContext()
                {
                    Quarter = string.Format("Q{0}", i + 1),
                    Profit = r.Next(1, 20),
                };
                items.Add(profitDiffContext);
            }
            for (int i = 0; i < itemsCount; i++)
            {
                ProfitDifferenceContext profitDiffContext = items[i];
                if (i > 0)
                {
                    ProfitDifferenceContext prevPoint = items[i - 1];
                    profitDiffContext.PreviousDifference = profitDiffContext.Profit - prevPoint.Profit;
                    profitDiffContext.PreviousQuarter = prevPoint.Quarter;
                }
                if (i < itemsCount - 1)
                {
                    ProfitDifferenceContext nextPoint = items[i + 1];
                    profitDiffContext.NextDifference = nextPoint.Profit - nextPoint.Profit;
                    profitDiffContext.NextQuarter = nextPoint.Quarter;
                }
            }
            return items;
        }
#endregion
}
