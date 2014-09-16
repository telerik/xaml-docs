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

#region radchart-howto-control-the-series_items-overlapping-via-zIndex-property_0
public class UserDataPoint
    {
        private double _y;
        private double _bubbleSize;
        private string _legendLabel;
        public UserDataPoint()
        {
        }
        public UserDataPoint(double x, double y)
        {
            this._y = y;
        }
        public double Y
        {
            get
            {
                return _y;
            }
            set
            {
                this._y = value;
            }
        }
        public double BubbleSize
        {
            get
            {
                return _bubbleSize;
            }
            set
            {
                this._bubbleSize = value;
            }
        }
        public string LegendLabel
        {
            get
            {
                return _legendLabel;
            }
            set
            {
                this._legendLabel = value;
            }
        }
    }
    public static class SeriesExtensions
    {    
        public static List<UserDataPoint> GetUserBubbleData()
        {
            List<UserDataPoint> points = new List<UserDataPoint>();
            points.Add(CreateBubbleUserDataPoint(20, -100));
            points.Add(CreateBubbleUserDataPoint(40, 100));
            points.Add(CreateBubbleUserDataPoint(80, -20));
            points.Add(CreateBubbleUserDataPoint(60, 10));
            return points;
        }
        private static UserDataPoint CreateBubbleUserDataPoint(double valueY, double bubbleSize)
        {
            UserDataPoint dataPnt = new UserDataPoint();
            dataPnt.Y = valueY;
            dataPnt.BubbleSize = bubbleSize;
            return dataPnt;
        }
      }
#endregion

#region radchart-howto-control-the-series_items-overlapping-via-zIndex-property_2
public class BubbleViewModel
    {
        private List<UserDataPoint> _bubbleData;
        public List<UserDataPoint> BubbleData
        {
            get
            {
                if (this._bubbleData == null)
                {
                    this._bubbleData = SeriesExtensions.GetUserBubbleData();
                }
                return this._bubbleData;
            }
        }
    }
#endregion

#region radchart-howto-control-the-series_items-overlapping-via-zIndex-property_5
public MainPage()
        {
            InitializeComponent();
            this.RadChart1.DefaultView.ChartArea.SelectionChanged += new EventHandler<ChartSelectionChangedEventArgs>(ChartArea_SelectionChanged);
        }
        void ChartArea_SelectionChanged(object sender, ChartSelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count == 1)
                SelectItem(e.AddedItems[0]);
        }
        private void SelectItem(DataPoint point)
        {
            var bubbles = this.RadChart1.DefaultView.ChartArea.ChildrenOfType<Bubble>();
            foreach (Bubble item in bubbles)
                item.ClearValue(Canvas.ZIndexProperty);
            Bubble selectedBubble = bubbles.SingleOrDefault(bubble => bubble.DataContext == point);
            if (selectedBubble != null)
                Canvas.SetZIndex(selectedBubble, 2000);
        }
}
#endregion
}
