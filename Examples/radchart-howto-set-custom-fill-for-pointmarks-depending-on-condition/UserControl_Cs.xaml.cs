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

#region radchart-howto-set-custom-fill-for-pointmarks-depending-on-condition_0
public class Data : INotifyPropertyChanged
    {
        private DateTime _date;
        private SolidColorBrush _pointMarkFill;
        private int _yvalue;
        public Data(DateTime date, int yvalue)
        {
            this._date = date;
            this._yvalue = yvalue;
            this.UpdatePointMarkVisibility();
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public DateTime Date
        {
            get
            {
                return _date;
            }
            set
            {
                if (this._date == value)
                    return;
                this._date = value;
                this.OnPropertyChanged("Date");
            }
        }
        public int YValue
        {
            get
            {
                return _yvalue;
            }
            set
            {
                if (this._yvalue == value)
                    return;
                this._yvalue = value;
                this.OnPropertyChanged("YValue");
            }
        }
        public SolidColorBrush PointMarkFill
        {
            get
            {
                return _pointMarkFill;
            }
            private set
            {
                if (object.Equals(this._pointMarkFill, value))
                    return;
                this._pointMarkFill = value;
                this.OnPropertyChanged("PointMarkVisibility");
            }
        }
        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        private void UpdatePointMarkVisibility()
        {
            if (this.YValue > 0)
                this.PointMarkFill = new SolidColorBrush(Colors.Red);
            else
                this.PointMarkFill = new SolidColorBrush(Colors.Blue);
        }
    }
#endregion

#region radchart-howto-set-custom-fill-for-pointmarks-depending-on-condition_5
List<Data> exportData = new List<Data>();
DateTime baseDate = DateTime.Today;
Random r = new Random();
for (int i = 0; i < 30; i++)
{
exportData.Add(new Data(baseDate.AddDays(i), r.Next(-20, 20)));
}
SeriesMapping mapping = new SeriesMapping();
mapping.ItemMappings.Add(new ItemMapping("YValue", DataPointMember.YValue));
mapping.ItemMappings.Add(new ItemMapping("Date", DataPointMember.XCategory));
chart.ItemsSource = exportData;
chart.SeriesMappings.Add(mapping);
chart.DefaultView.ChartArea.AxisX.IsDateTime = true;
chart.DefaultView.ChartArea.AxisX.LabelRotationAngle = 45;
chart.DefaultView.ChartArea.AxisX.DefaultLabelFormat = "dd-MM-yy";
LineSeriesDefinition line = new LineSeriesDefinition();
chart.DefaultSeriesDefinition = line;
line.ShowPointMarks = true;
line.ShowItemLabels = true;
chart.DefaultSeriesDefinition.PointMarkItemStyle = this.Resources["MyPointMark_Style"] as Style;
chart.DefaultSeriesDefinition.SeriesItemLabelStyle = this.Resources["MySeriesItemLabel_Style"] as Style;
#endregion
}
