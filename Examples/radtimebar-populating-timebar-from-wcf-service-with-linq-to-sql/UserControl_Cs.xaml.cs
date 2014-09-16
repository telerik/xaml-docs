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

#region radtimebar-populating-timebar-from-wcf-service-with-linq-to-sql_0
[ServiceContract]
public interface IService
{
[OperationContract]
List<SampleTable> GetTimeBarData();
}
#endregion

#region radtimebar-populating-timebar-from-wcf-service-with-linq-to-sql_2
public class Service : IService
{
  public List<SampleTable> GetTimeBarData()
  {
   TimeBarSampleDataContext context = new TimeBarSampleDataContext();
   var data = (from tb in context.SampleTables
   select tb).ToList();
   return data;
  }
}
#endregion

#region radtimebar-populating-timebar-from-wcf-service-with-linq-to-sql_5
public class ViewModel : INotifyPropertyChanged
    {
        private DateTime _StartDate = DateTime.MinValue;
        private DateTime _EndDate = DateTime.MinValue;
        private DateTime _VisibleStartDate = DateTime.MinValue;
        private DateTime _VisibleEndDate = DateTime.MinValue;
        private DateTime _SelectionStartDate = DateTime.MinValue;
        private DateTime _SelectionEndDate = DateTime.MinValue;
        public ViewModel()
        {
            // Create a new instance of the web service and get the data from the table
            ServiceClient service = new ServiceClient();
            service.GetTimeBarDataCompleted += new EventHandler<GetTimeBarDataCompletedEventArgs>(service_GetTimeBarDataCompleted);
            service.GetTimeBarDataAsync();
        }
        void service_GetTimeBarDataCompleted(object sender, GetTimeBarDataCompletedEventArgs e)
        {
            List<SampleTable> dataCollection = new List<SampleTable>(e.Result);
            if (dataCollection != null)
            {
                var data = dataCollection.Where(d => d.Id == 1).FirstOrDefault();
                this.SetDataContent(data);
            }
        }
        private void SetDataContent(SampleTable data)
        {
            this.StartDate = data.PeriodStart.Value;
            this.EndDate = data.PeriodEnd.Value;
            this.VisibleStartDate = data.VisiblePeriodStart.Value;
            this.VisibleEndDate = data.VisiblePeriodEnd.Value;
            this.SelectionStartDate = data.SelectionStart.Value;
            this.SelectionEndDate = data.SelectionEnd.Value;
        }
        public DateTime StartDate
        {
            get
            {
                return _StartDate;
            }
            set
            {
                if (this._StartDate == value)
                    return;
                this._StartDate = value;
                this.RaisePropertyChanged("StartDate");
            }
        }
        public DateTime EndDate
        {
            get
            {
                return _EndDate;
            }
            set
            {
                if (this._EndDate == value)
                    return;
                this._EndDate = value;
                this.RaisePropertyChanged("EndDate");
            }
        }
        public DateTime VisibleStartDate
        {
            get
            {
                return _VisibleStartDate;
            }
            set
            {
                if (this._VisibleStartDate == value)
                    return;
                this._VisibleStartDate = value;
                this.RaisePropertyChanged("VisibleStartDate");
            }
        }
        public DateTime VisibleEndDate
        {
            get
            {
                return _VisibleEndDate;
            }
            set
            {
                if (this._VisibleEndDate == value)
                    return;
                this._VisibleEndDate = value;
                this.RaisePropertyChanged("VisibleEndDate");
            }
        }
        public DateTime SelectionStartDate
        {
            get
            {
                return _SelectionStartDate;
            }
            set
            {
                if (this._SelectionStartDate == value)
                    return;
                this._SelectionStartDate = value;
                this.RaisePropertyChanged("SelectionStartDate");
            }
        }
        public DateTime SelectionEndDate
        {
            get
            {
                return _SelectionEndDate;
            }
            set
            {
                if (this._SelectionEndDate == value)
                    return;
                this._SelectionEndDate = value;
                this.RaisePropertyChanged("SelectionEndDate");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }  
    }
#endregion
}
