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

#region radchart-features-tooltips_0
using System;
using System.Collections.ObjectModel;
namespace Silverlight.Help.RadChartSamples
{
    public class TradeData
    {
        public string Emission
        {
            get;
            set;
        }
        public DateTime FromDate
        {
            get;
            set;
        }
        public DateTime ToDate
        {
            get;
            set;
        }
        public double Open
        {
            get;
            set;
        }
        public double High
        {
            get;
            set;
        }
        public double Low
        {
            get;
            set;
        }
        public double Close
        {
            get;
            set;
        }
        public double Volume
        {
            get;
            set;
        }
        public static ObservableCollection<TradeData> GetWeeklyData( string code )
        {
            ObservableCollection<TradeData> tradeData;
            tradeData = new ObservableCollection<TradeData>() {
                new TradeData() { Emission="MSFT", FromDate = new DateTime( 2009, 8, 10 ), Open = 23.4600, High = 23.5500, Low = 23.3000, Close = 23.4200, Volume = 35258950 },
                new TradeData() { Emission="MSFT", FromDate = new DateTime( 2009, 8, 11 ), Open = 23.3200, High = 23.4000, Low = 23.0500, Close = 23.1300, Volume = 33611790 },
                new TradeData() { Emission="MSFT", FromDate = new DateTime( 2009, 8, 12 ), Open = 23.1300, High = 23.9000, Low = 23.0300, Close = 23.5300, Volume = 61936270 },
                new TradeData() { Emission="MSFT", FromDate = new DateTime( 2009, 8, 13 ), Open = 23.6300, High = 23.8500, Low = 23.4000, Close = 23.6200, Volume = 38951990 },
                new TradeData() { Emission="MSFT", FromDate = new DateTime( 2009, 8, 14 ), Open = 23.6200, High = 23.8000, Low = 23.5100, Close = 23.6900, Volume = 46328540 },
                new TradeData() { Emission="MSFT", FromDate = new DateTime( 2009, 8, 17 ), Open = 23.3200, High = 23.6000, Low = 23.2300, Close = 23.2500, Volume = 42462890 },
                new TradeData() { Emission="MSFT", FromDate = new DateTime( 2009, 8, 18 ), Open = 23.2900, High = 23.6520, Low = 23.2700, Close = 23.5800, Volume = 38831620 },
                new TradeData() { Emission="MSFT", FromDate = new DateTime( 2009, 8, 19 ), Open = 23.2500, High = 23.7200, Low = 23.2500, Close = 23.6500, Volume = 41814320 },
                new TradeData() { Emission="MSFT", FromDate = new DateTime( 2009, 8, 20 ), Open = 23.6000, High = 23.8700, Low = 23.5400, Close = 23.6700, Volume = 39502680 },
                new TradeData() { Emission="MSFT", FromDate = new DateTime( 2009, 8, 21 ), Open = 23.9300, High = 24.4200, Low = 23.7700, Close = 24.4100, Volume = 68995700},
                new TradeData() { Emission="MSFT", FromDate = new DateTime( 2009, 8, 24 ), Open = 24.4100, High = 24.7326, Low = 24.2800, Close = 24.6400, Volume = 54159300 },
                new TradeData() { Emission="MSFT", FromDate = new DateTime( 2009, 8, 25 ), Open = 24.6000, High = 24.8200, Low = 24.4600, Close = 24.6400, Volume = 43961480 },
                new TradeData() { Emission="MSFT", FromDate = new DateTime( 2009, 8, 26 ), Open = 24.5900, High = 24.7500, Low = 24.4200, Close = 24.5500, Volume = 41060010 },
                new TradeData() { Emission="MSFT", FromDate = new DateTime( 2009, 8, 27 ), Open = 24.4100, High = 24.7800, Low = 24.3000, Close = 24.6900, Volume = 45433940 },
                new TradeData() { Emission="MSFT", FromDate = new DateTime( 2009, 8, 28 ), Open = 25.0700, High = 25.4900, Low = 24.6100, Close = 24.6800, Volume = 55789640 },
                new TradeData() { Emission="MSFT", FromDate = new DateTime( 2009, 8, 31 ), Open = 24.5700, High = 24.8500, Low = 24.2900, Close = 24.6500, Volume = 49582950 },
                new TradeData() { Emission="MSFT", FromDate = new DateTime( 2009, 9, 1 ), Open = 24.3500, High = 24.7400, Low = 23.9000, Close = 24.0000, Volume = 62571800 },
                new TradeData() { Emission="MSFT", FromDate = new DateTime( 2009, 9, 2 ), Open = 23.8200, High = 24.1400, Low = 23.7800, Close = 23.8600, Volume = 40726040 },
                new TradeData() { Emission="MSFT", FromDate = new DateTime( 2009, 9, 3 ), Open = 23.9100, High = 24.1400, Low = 23.7600, Close = 24.1100, Volume = 34110810 },
                new TradeData() { Emission="MSFT", FromDate = new DateTime( 2009, 9, 4 ), Open = 24.0900, High = 24.8001, Low = 24.0800, Close = 24.6200, Volume = 44987570 },
                new TradeData() { Emission="MSFT", FromDate = new DateTime( 2009, 9, 8 ), Open = 24.6200, High = 24.8400, Low = 24.4100, Close = 24.8200, Volume = 52243880 } };
            return tradeData;
        }
    }
}
#endregion

#region radchart-features-tooltips_5
Telerik.Windows.Controls.RadChart radChart = new Telerik.Windows.Controls.RadChart();
SeriesMapping seriesMapping = new SeriesMapping();
seriesMapping.SeriesDefinition = new CandleStickSeriesDefinition();
seriesMapping.SeriesDefinition.ShowItemToolTips = true;
seriesMapping.SeriesDefinition.ItemToolTipFormat = "Open: #OPEN{C4} / Close: #CLOSE{C4}\nVolume: #DATAITEM.Volume{###,###,##0}";
seriesMapping.ItemMappings.Add( new ItemMapping( "Open", DataPointMember.Open) );
seriesMapping.ItemMappings.Add( new ItemMapping( "High", DataPointMember.High) );
seriesMapping.ItemMappings.Add( new ItemMapping( "Low", DataPointMember.Low) );
seriesMapping.ItemMappings.Add( new ItemMapping( "Close", DataPointMember.Close) );
radChart.SeriesMappings.Add( seriesMapping );
#endregion

#region radchart-features-tooltips_8
using System.Windows.Controls;
using System.Windows.Media;
namespace Silverlight.Help.RadChartSamples
{
    public partial class StockToolTipControl : UserControl
    {
        public StockToolTipControl()
        {
            InitializeComponent();
        }
        public double ChangeNetPercent
        {
            set
            {
                this.changeNetPercent.Text = value.ToString( "p" );
                this.arrow.Fill = new SolidColorBrush( value < 0.0 ? Colors.Red : Colors.Green );
                this.rotateTransform.Angle = value < 0.0 ? 0 : 180;
            }
        }
        public double Volume
        {
            set
            {
                this.volume.Text = value.ToString( ",##0" );
            }
        }
        public double OneYearTargetEst
        {
            set
            {
                this.oneYearTargetEst.Text = value.ToString( "C" );
            }
        }
        public double PERatio
        {
            set
            {
                this.peRatio.Text = value.ToString( "00.00" );
            }
        }
        public double ForwardingPE
        {
            set
            {
                this.forwardingPE.Text = value.ToString( "00.00" );
            }
        }
    }
}
#endregion

#region radchart-features-tooltips_11
private void ChartArea_ItemToolTipOpening( ItemToolTip2D tooltip, ItemToolTipEventArgs e )
{
    TradeData tradeData = e.DataPoint.DataItem as TradeData;
    StockToolTipControl stockToolTip = new StockToolTipControl();
    stockToolTip.ChangeNetPercent = 1 - ( tradeData.Close / tradeData.Open );
    stockToolTip.Volume = tradeData.Volume;
    //The next three properties shows some fictional data to illustrate the idea
    stockToolTip.OneYearTargetEst = tradeData.Close * 1.1;
    stockToolTip.PERatio = 16.80;
    stockToolTip.ForwardingPE = 17.93;
    tooltip.Content = stockToolTip;
}
#endregion
}
