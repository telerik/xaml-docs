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

#region radchart-howto-binding-datapointmember-to-a-depenndency-property_1
public class MyObject : INotifyPropertyChanged
{
  private double _yValue = 0;
  public event PropertyChangedEventHandler PropertyChanged;
  public double yValue
  {
    get
    {
      return this._yValue;
    }
    set
    {
     if (this._yValue == value)
     return;
     this._yValue = value;
     this.OnPropertyChanged("yValue");
     }
   }
   protected virtual void OnPropertyChanged(string propertyName)
   {
     if (PropertyChanged != null)
     PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
   }
}
#endregion

#region radchart-howto-binding-datapointmember-to-a-depenndency-property_3
this.DataContext = new List<MyObject>() { new MyObject() };
#endregion
}
