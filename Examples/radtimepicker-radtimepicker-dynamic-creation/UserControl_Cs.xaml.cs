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

#region radtimepicker-radtimepicker-dynamic-creation_1
RadTimePicker timePicker = new RadTimePicker();
#endregion

#region radtimepicker-radtimepicker-dynamic-creation_3
public partial class Page : UserControl
 {
  public Page()
   {
     InitializeComponent();
     this.timePicker.SelectedTimeChanged += new 
                   EventHandler(timePicker_SelectedTimeChanged);
   }
  void timePicker_SelectedTimeChanged(object sender, EventArgs e)
   {
     this.text.Text = timePicker.SelectedTime.ToString();
   }
 }
#endregion

#region radtimepicker-radtimepicker-dynamic-creation_5
public partial class Page : UserControl
 {
  public Page()
   {
     InitializeComponent();
     this.timePicker.TimeInterval = new TimeSpan(0, 25, 0);
     this.timePicker.StartTime = new TimeSpan(2, 0, 0);
   }
 }
#endregion

#region radtimepicker-radtimepicker-dynamic-creation_6
public partial class Page : UserControl
 {
      public Page()
       {
         InitializeComponent();
         this.buttonBind.Click += new RoutedEventHandler(buttonBind_Click);
       }
       void buttonBind_Click(object sender, RoutedEventArgs e)
        {
           this.timePicker.ClockItemSource = LoadDataObjects();
        }
       public ObservableCollection<TimeSpan> LoadDataObjects()
        {
            ObservableCollection<TimeSpan> times = new ObservableCollection<TimeSpan>()
            { 
               new TimeSpan(9,0,0),
               new TimeSpan(10,0,0),
               new TimeSpan(10,5,0),
               new TimeSpan(10,22,0),
               new TimeSpan(10,38,0),
               new TimeSpan(11,54,0),
               new TimeSpan(12,56,0),
               new TimeSpan(12,59,0)
            };
            return times;
        }
#endregion
}
