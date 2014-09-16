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

#region radchart-populating-with-data-series-mapping-items-source_0
using System;
using System.Collections.ObjectModel;
namespace ChartDataSources
{
    public class MyDateObject
    {
        public double Value { get; set; }
        public double Value2 { get; set; }
        public MyDateObject(double value, double value2)
        {
            this.Value = value;
            this.Value2 = value2; 
       }
        public static ObservableCollection<MyDateObject> GetData(int count)
        {
            Random r = new Random();
            ObservableCollection<MyDateObject> result = new ObservableCollection<MyDateObject>();
            for (int i = 0; i < count; i++)
            {
                result.Add(new MyDateObject(r.Next(0, 100), r.Next(0, 100)));
            }
            return result;
        }
    }
}
#endregion

#region radchart-populating-with-data-series-mapping-items-source_2
public class MyViewModel : ViewModelBase
    {
        private ObservableCollection<MyDateObject> _data;
        public ObservableCollection<MyDateObject> Data
        {
            get
            {
                return this._data;
            }
            set
            {
                if (this._data != value)
                {
                    this._data = value;
                    this.OnPropertyChanged("Data");
                }
            }
        }
        private ObservableCollection<MyDateObject> _mappingData;
        public ObservableCollection<MyDateObject> MappingData
        {
            get
            {
                return this._mappingData;
            }
            set
            {
                if (this._mappingData != value)
                {
                    this._mappingData = value;
                    this.OnPropertyChanged("MappingData");
                }
            }
        }
        public MyViewModel()
        {
            this.Data = MyDateObject.GetData(10);
            this.MappingData = MyDateObject.GetData(20);
        }
    }
#endregion
}
