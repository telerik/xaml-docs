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

#region radchart-howto-create-scatter-errorbars-and-boxplot-series_1
public partial class MainPage : UserControl 
    {
        public MainPage() //MainWindow() in WPF
        {
            InitializeComponent();
            DataSeries series = new DataSeries();
            series.Definition = new CustomCandleStickSeriesDefinition() { ItemStyle = this.LayoutRoot.Resources["CustomCandleStickStyle"] as Style };
            series.Add(new DataPoint() { Open = 10, High = 30, Low = 5, Close = 15 });
            series.Add(new DataPoint() { Open = 15, High = 40, Low = 10, Close = 20 });
            series.Add(new DataPoint() { Open = 20, High = 35, Low = 15, Close = 30 });
            series.Add(new DataPoint() { Open = 10, High = 25, Low = 5, Close = 18 });
            series.Add(new DataPoint() { Open = 15, High = 40, Low = 10, Close = 20 });
            series.Add(new DataPoint() { Open = 20, High = 35, Low = 9, Close = 30 });
            series.Add(new DataPoint() { Open = 10, High = 25, Low = 5, Close = 15 });
            series.Add(new DataPoint() { Open = 15, High = 30, Low = 7, Close = 25 });
            RadChart1.DefaultView.ChartArea.DataSeries.Add(series);
            RadChart1.DefaultView.ChartLegend.Visibility = System.Windows.Visibility.Collapsed;
            RadChart1.DefaultView.ChartArea.AxisX.Title = "Experiment No";
            RadChart1.DefaultView.ChartArea.AxisY.Title = "Results";
            RadChart1.DefaultView.ChartArea.AxisX.LayoutMode = AxisLayoutMode.Inside;
        }
    }
    public class CustomCandleStick : CandleStick
    {
        private ParametricLine CustomLine
        {
            get
            {
                return this.GetTemplateChild("PART_CustomLine") as ParametricLine;
            }
        }
        protected override void UpdateParametricLinesCoordinates(Size constraint)
        {
            base.UpdateParametricLinesCoordinates(constraint);
            double middleValue = (this.DataPoint.Open + this.DataPoint.Close) / 2;
            DataRange minRange = this.CalculateRange(middleValue) * constraint.Height;
            UpdateParametricLineCoordinates(this.CustomLine, this.Center - constraint.Width / 2, minRange.From, this.Center + constraint.Width / 2, minRange.From);
        }
        protected override void UpdateParametricLinesParameters()
        {
            base.UpdateParametricLinesParameters();
            UpdateParametricLineParameter(this.CustomLine, false);
        }
        private DataRange CalculateRange(double value)
        {
            DataRange axisRange = new DataRange(this.ChartArea.AxisY.ActualMinValue, this.ChartArea.AxisY.ActualMaxValue);
            double itemY = axisRange.Normalize(value);
            double zero = axisRange.Normalize(0d);
            DataRange restrictedRange = new DataRange(DataRange.Unit.Restrict(zero), itemY);
            return DataRange.Unit.Invert(restrictedRange);
        }
    }
    public class CustomCandleStickSeriesDefinition : CandleStickSeriesDefinition
    {
        public override IChartItem CreateChartItem()
        {
            return new CustomCandleStick();
        }
    }
#endregion

#region radchart-howto-create-scatter-errorbars-and-boxplot-series_4
public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
            RadChart1.DefaultView.ChartArea.AxisX.LayoutMode = AxisLayoutMode.Inside;
            RadChart1.DefaultView.ChartArea.AxisX.Title = "Experiment No";
            RadChart1.DefaultView.ChartArea.AxisY.Title = "Results";
            RadChart1.DefaultView.ChartArea.AxisY.IsZeroBased = true;
            RadChart1.DefaultView.ChartArea.AxisY.AutoRange = false;
            RadChart1.DefaultView.ChartArea.AxisY.AddRange(0, 20, 1);
            RadChart1.DefaultView.ChartArea.AxisX.LayoutMode = AxisLayoutMode.Inside;
            RadChart1.DefaultSeriesDefinition = new ScatterErrorBarSeriesDefinition() 
            { 
                PointSize = 12, 
                ItemStyle = this.LayoutRoot.Resources["CustomScatterPointStyle"] as Style 
            };
            SeriesMapping mapping = new SeriesMapping();
            mapping.ItemMappings.Add(new ItemMapping("YValue", DataPointMember.YValue));
            RadChart1.SeriesMappings.Add(mapping);
            RadChart1.ItemsSource = GetData();
            RadChart1.DefaultView.ChartArea.EnableAnimations = false;
        }
        private static List<ChartData> GetData()
        {
            List<ChartData> data = new List<ChartData>();
            data.Add(new ChartData() { YValue = 10, MinValue = 7, MaxValue = 12 });
            data.Add(new ChartData() { YValue = 6, MinValue = 4, MaxValue = 8 });
            data.Add(new ChartData() { YValue = 5, MinValue = 2, MaxValue = 7 });
            data.Add(new ChartData() { YValue = 8, MinValue = 6, MaxValue = 10 });
            data.Add(new ChartData() { YValue = 10, MinValue = 8, MaxValue = 12 });
            data.Add(new ChartData() { YValue = 4, MinValue = 3, MaxValue = 6 });
            data.Add(new ChartData() { YValue = 7, MinValue = 4, MaxValue = 9 });
            data.Add(new ChartData() { YValue = 11, MinValue = 8, MaxValue = 13 });
            return data;
        }
    }
    public class ScatterErrorBarSeriesDefinition : ScatterSeriesDefinition
    {
        public override IChartItem CreateChartItem()
        {
            return new ScatterErrorBar();
        }
    }
    public class ScatterErrorBar : ScatterPoint
    {
        /// <summary>
        /// Identifies the <see cref="MinValueY"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty MinValueYProperty = DependencyProperty.Register("MinValueY",
            typeof(double),
            typeof(ScatterErrorBar),
            new PropertyMetadata(0d));
        /// <summary>
        /// Identifies the <see cref="MaxValueY"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty MaxValueYProperty = DependencyProperty.Register("MaxValueY",
            typeof(double),
            typeof(ScatterErrorBar),
            new PropertyMetadata(0d));
        /// <summary>
        /// Gets or sets the MaxValueY.
        /// </summary>
        [Description("Gets or sets the MaxValueY")]
        public double MaxValueY
        {
            get
            {
                return (double)this.GetValue(MaxValueYProperty);
            }
            set
            {
                this.SetValue(MaxValueYProperty, value);
            }
        }
        /// <summary>
        /// Gets or sets the MinValueY.
        /// </summary>
        [Description("Gets or sets the MinValueY")]
        public double MinValueY
        {
            get
            {
                return (double)this.GetValue(MinValueYProperty);
            }
            set
            {
                this.SetValue(MinValueYProperty, value);
            }
        }
        protected override void CreatePoints(Size arrangedBounds)
        {
            base.CreatePoints(arrangedBounds);
            this.MinValueY = this.CalculateMinValueY(arrangedBounds);
            this.MaxValueY = this.CalculateMaxValueY(arrangedBounds);
        }
        private double CalculateMinValueY(Size arrangedBounds)
        {
            double minValue = (this.DataPoint.DataItem as ChartData).MinValue;
            DataRange minRange = this.CalculateRange(minValue) * arrangedBounds.Height;
            return minRange.From;
        }
        private double CalculateMaxValueY(Size arrangedBounds)
        {
            double maxValue = (this.DataPoint.DataItem as ChartData).MaxValue;
            DataRange maxRange = this.CalculateRange(maxValue) * arrangedBounds.Height;
            return maxRange.From;
        }
        private DataRange CalculateRange(double value)
        {
            DataRange axisRange = new DataRange(this.ChartArea.AxisY.ActualMinValue, this.ChartArea.AxisY.ActualMaxValue);
            double itemY = axisRange.Normalize(value);
            double zero = axisRange.Normalize(0d);
            DataRange restrictedRange = new DataRange(DataRange.Unit.Restrict(zero), itemY);
            return DataRange.Unit.Invert(restrictedRange);
        }
    }
    public class ChartData
    {
        public double YValue
        {
            get;
            set;
        }
        public double MinValue
        {
            get;
            set;
        }
        public double MaxValue
        {
            get;
            set;
        }
    }
#endregion
}
