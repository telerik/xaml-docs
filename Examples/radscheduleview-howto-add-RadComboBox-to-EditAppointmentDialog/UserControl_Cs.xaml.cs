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

#region radscheduleview-howto-add-RadComboBox-to-EditAppointmentDialog_2
public class MyViewModel:ViewModelBase
{
    public ObservableCollection<Appointment> Appointments
    {
        get;
        private set;
    }
    public ObservableCollection<string> ComboBoxItems
    {
        get;
        private set;
    }
    public MyViewModel()
    {
        Appointments = new ObservableCollection<Appointment>() {
            new Appointment() {
                Subject="test app",
                Start = DateTime.Now,
                End = DateTime.Now.AddHours(2)
            }
        };
        ComboBoxItems = new ObservableCollection<string>() {
            "item1", "item2", "item3"
        };
    }
}
#endregion
}
