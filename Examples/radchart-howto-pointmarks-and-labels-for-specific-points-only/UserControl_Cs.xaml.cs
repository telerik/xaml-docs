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

#region radchart-howto-pointmarks-and-labels-for-specific-points-only_0
public class Data : INotifyPropertyChanged
{
  private DateTime _date;
  private Visibility _pointMarkVisibility;
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
   public Visibility PointMarkVisibility
   {
    get
     {
      return _pointMarkVisibility;
     }
    private set
     {
      if (object.Equals(this._pointMarkVisibility, value))
      return;
      this._pointMarkVisibility = value;
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
     if (this.Date.Day%5 != 0)
     this.PointMarkVisibility = Visibility.Collapsed;
     else
     this.PointMarkVisibility = Visibility.Visible;
   }
}
#endregion

#region radchart-howto-pointmarks-and-labels-for-specific-points-only_2
List<Data> exportData = new List<Data>();
DateTime baseDate = new DateTime(2011, 1, 1);
Random r = new Random();
for (int i = 0; i < 30; i++)
{
   exportData.Add(new Data(baseDate.AddDays(i), r.Next(-10, 20)));
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
chart.DataBound += (o, e) =>
{
    var dataSeries = chart.DefaultView.ChartArea.DataSeries.FirstOrDefault();   
    if (dataSeries != null)            
    {                             
        foreach (var point in dataSeries.ToList())  
        {
            DateTime myDate = DateTime.Parse(point.XCategory);
            if (myDate.Day % 5 != 0)
            {
                point.Label = " ";
            }   
        }   
    }    
};
#endregion
}
