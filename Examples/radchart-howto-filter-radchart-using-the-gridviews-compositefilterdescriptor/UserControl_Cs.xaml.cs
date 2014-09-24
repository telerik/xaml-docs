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

#region radchart-howto-filter-radchart-using-the-gridviews-compositefilterdescriptor_0
public class MyDateObject
    {
        public double Value1 { get; set; }
        public double Value2 { get; set; }
        public double Value3 { get; set; }
        public DateTime Date { get; set; }
    }
    public class MyDataContext
    {
        public const int min = 21;
        public const int max = 79;
        public ObservableCollection<MyDateObject> List { get; set; }
        Random r = new Random();
        DateTime baseDate = DateTime.Today;
        public MyDataContext()
        {
            this.CreateChartData();
        }
        private void CreateChartData()
        {
            List = new ObservableCollection<MyDateObject>();
            for (int i = 0; i < 15; i++)
            {
                List.Add(new MyDateObject() { Value1 = r.Next(min, max), Value2 = r.Next(min, max), Value3 = r.Next(min, max), Date = baseDate.AddDays(i) });
            }
        }
    }
#endregion

#region radchart-howto-filter-radchart-using-the-gridviews-compositefilterdescriptor_3
CompositeFilterDescriptor chartFilterDescriptorCol = new CompositeFilterDescriptor();
private void GridView1_Filtered(object sender, Telerik.Windows.Controls.GridView.GridViewFilteredEventArgs e)
        {
            if (e.Added.Count() > 0)
            {
                foreach (FilterDescriptor filter in e.Added)
                {
                    FilterDescriptor gridFilterDescriptor = filter;
                    chartFilterDescriptorCol.FilterDescriptors.Add(gridFilterDescriptor);
                    chartFilterDescriptorCol.LogicalOperator = FilterCompositionLogicalOperator.Or;
                }
            }
                this.RadChart1.FilterDescriptors.Add(chartFilterDescriptorCol);                
        }
#endregion

#region radchart-howto-filter-radchart-using-the-gridviews-compositefilterdescriptor_6
CompositeFilterDescriptor chartFilterDescriptorCol = new CompositeFilterDescriptor();
        public MainPage()
        {
            InitializeComponent();
            RadChart1.DefaultView.ChartArea.AxisX.DefaultLabelFormat = "ddd\ndd.MM";
            MyDataContext context = new MyDataContext();
            this.DataContext = context;
        }
        private void GridView1_Filtered(object sender, Telerik.Windows.Controls.GridView.GridViewFilteredEventArgs e)
        {
            if (e.Added.Count() > 0)
            {
                foreach (FilterDescriptor filter in e.Added)
                {
                    FilterDescriptor gridFilterDescriptor = filter;
                    chartFilterDescriptorCol.FilterDescriptors.Add(gridFilterDescriptor);
                    chartFilterDescriptorCol.LogicalOperator = FilterCompositionLogicalOperator.Or;
                }
            }
                this.RadChart1.FilterDescriptors.Add(chartFilterDescriptorCol);                
        }
    }
    public class MyDateObject
    {
        public double Value1 { get; set; }
        public double Value2 { get; set; }
        public double Value3 { get; set; }
        public DateTime Date { get; set; }
    }
    public class MyDataContext
    {
        public const int min = 21;
        public const int max = 79;
        public ObservableCollection<MyDateObject> List { get; set; }
        Random r = new Random();
        DateTime baseDate = DateTime.Today;
        public MyDataContext()
        {
            this.CreateChartData();
        }
        private void CreateChartData()
        {
            List = new ObservableCollection<MyDateObject>();
            for (int i = 0; i < 15; i++)
            {
                List.Add(new MyDateObject() { Value1 = r.Next(min, max), Value2 = r.Next(min, max), Value3 = r.Next(min, max), Date = baseDate.AddDays(i) });
            }
        }
    }
#endregion
}
