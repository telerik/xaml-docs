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

#region xamlflix_scheduleview_30
    void MainPage_Loaded(object sender, RoutedEventArgs e)
{
    var appointments = new ObservableCollection<Appointment>();

Lets add one new appointment to the collection
appointments.Add(new Appointment()
 {
     Subject = "I'm a new Appointment",
     Start = new DateTime(2012, 7, 10, 12, 30, 00),
     End = new DateTime(2012, 7, 10, 14, 30, 00)


 });

#endregion

#region xamlflix_scheduleview_32
appointments.Add(new Appointment()
 {
     Subject = "I'm a new Appointment",
     Start = new DateTime(2012, 7, 10, 12, 30, 00),
     End = new DateTime(2012, 7, 10, 14, 30, 00)


 });

#endregion

#region xamlflix_scheduleview_34
using System.Windows;
using System.Windows.Controls;
using Telerik.Windows.Controls.ScheduleView;

namespace RadScheduleViewTutorial
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
            Loaded += new RoutedEventHandler(MainPage_Loaded);
        }

        void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            var appointments = new ObservableCollection<Appointment>();
            appointments.Add(new Appointment()
            {
                Subject = "I'm a new Appointment",
                Start = new DateTime(2012, 7, 10, 12, 30, 00),
                End = new DateTime(2012, 7, 10, 14, 30, 00)
            });

            xRadScheduleView.AppointmentsSource = appointments;
        }
    }
}

#endregion

#region xamlflix_scheduleview_36
public class CustomAppointment : Appointment
{
    public string customString;
    public string CustomString
    {
        get                        
        {
            return customString;
        }
        set
        {
        	if ( customString != value)
            {
                customString = value;
                OnPropertyChanged( () => this.customString );
            }
        }
    }
}
#endregion
#region xamlflix_scheduleview_38
public override IAppointment Copy()
{
    return base.Copy();
}

public override void CopyFrom(IAppointment other)
{
    base.CopyFrom(other);
}

#endregion
#region xamlflix_scheduleview_40
public override IAppointment Copy()
{
    var customAppointment = new CustomAppointment () ;
    customAppointment.CopyFrom( this );
    return customAppointment;
}

#endregion
#region xamlflix_scheduleview_42
public override void CopyFrom(IAppointment other)
 {
     var customAppointment = other as CustomAppointment;
     if ( customAppointment != null )
     {
         this.CustomString = customAppointment.CustomString;
     }
     base.CopyFrom( other );
 }
#endregion
#region xamlflix_scheduleview_44
public string CustomString
 {
     get                        
     {
       return  this.Storage<CustomAppointment>().customString;
     }
     set
     {
         var storage = this.Storage<CustomAppointment>();

     	if ( storage.customString != value)
         {
             storage.customString = value;
             OnPropertyChanged( () => this.customString );
         }
     }
 }
#endregion
#region xamlflix_scheduleview_46
void MainPage_Loaded(object sender, RoutedEventArgs e)
{
    var appointments = new ObservableCollection<CustomAppointment>();
    appointments.Add(new CustomAppointment()
    {
        Subject = "I'm a custom appointment",
        Start = new DateTime(2012, 3, 15, 14, 30, 00),
        End = new DateTime(2012, 3, 15, 16, 30, 00),
        CustomString = "I'm a custom string"

    });

    radScheduleView1.AppointmentsSource = appointments;

}

#endregion
#region xamlflix_scheduleview_48
void MainPage_Loaded(object sender, RoutedEventArgs e)
{
    var appointments = new ObservableCollection<Appointment>();
    appointments.Add(new Appointment()
    {
        Subject = "I'm a new appointment",
        Start = new DateTime(2012, 3, 15, 14, 30, 00),
        End = new DateTime(2012, 3, 15, 16, 30, 00),
    });

    radScheduleView1.AppointmentsSource = appointments;

}
#endregion
#region xamlflix_scheduleview_50
public ObservableCollection<Appointment> Appointments { get; set; }
public ObservableCollection<ResourceType> ResourceTypes { get; set; }
public ObservableCollection<Resource> ComboResources { get; set; }
#endregion

#region xamlflix_scheduleview_52
private Resource selectedResource;
 public Resource SelectedResource 
 {
     get { return selectedResource; }
     set
     {
     	if ( selectedResource != value)
         {
             selectedResource = value;
             OnPropertyChanged(() => this.SelectedResource);
         }
     }
 }
#endregion

#region xamlflix_scheduleview_54
public ScheduleViewVM()
{
    MakeAppointments();
    MakeResources();
}
#endregion

#region xamlflix_scheduleview_56
private void MakeAppointments()
{
    Appointments = new ObservableCollection<Appointment>();
    for ( int i = 0; i < 10; i++)
    {
        Appointments.Add(new Appointment()
        {
            Subject = "Appointment " + i.ToString(),
            Start = DateTime.Now.AddHours(i),
            End = DateTime.Now.AddHours(i).AddMinutes(30)

        });
    }
}
#endregion

#region xamlflix_scheduleview_58
private void MakeResources()
 {
     ResourceTypes = new ObservableCollection<ResourceType>();
     ResourceType rt = new ResourceType("Location");
     rt.Resources.Add(new Resource("Hall A", "Location"));
     rt.Resources.Add(new Resource("Hall B", "Location"));
     rt.Resources.Add(new Resource("Hall C", "Location"));
     ResourceTypes.Add(rt);

 }
#endregion

#region xamlflix_scheduleview_60
ResourceType newRT = new ResourceType("Speaker");
#endregion

#region xamlflix_scheduleview_62
ComboResources = new ObservableCollection<Resource>();
 ComboResources.Add(new Resource("Enchev", "Speaker"));
 ComboResources.Add(new Resource("Milev", "Speaker"));
 ComboResources.Add(new Resource("Donchev", "Speaker"));
#endregion

#region xamlflix_scheduleview_64
public Predicate<IAppointment> FilterValue
 {
     get { return Filter; }
 }
#endregion

#region xamlflix_scheduleview_66
public bool Filter(IAppointment appt)
{
    Appointment app = appt as Appointment;
    return app != null && FilterBySpeaker(app);
}
#endregion

#region xamlflix_scheduleview_68
public bool FilterBySpeaker(Appointment app)
{
    return SelectedResource == null || 
        app.Resources.Contains(SelectedResource);
}
#endregion

#region xamlflix_scheduleview_70
public Resource SelectedResource 
{
    get { return selectedResource; }
    set
    {
    	if ( selectedResource != value)
        {
            selectedResource = value;
            OnPropertyChanged(() => this.SelectedResource);
            OnPropertyChanged(() => this.FilterValue);
        }
    }
}
#endregion

#region xamlflix_scheduleview_72
using System.Collections.ObjectModel;
using System;
using Telerik.Windows.Controls.ScheduleView;
using Telerik.Windows.Controls;

namespace RadScheduleFiltering
{
    public class ScheduleViewVM : ViewModelBase
    {
        public ObservableCollection<Appointment> Appointments { get; set; }
        public ObservableCollection<ResourceType> ResourceTypes { get; set; }
        public ObservableCollection<Resource> ComboResources { get; set; }

        private Resource selectedResource;
        public Resource SelectedResource 
        {
            get { return selectedResource; }
            set
            {
            	if ( selectedResource != value)
                {
                    selectedResource = value;
                    OnPropertyChanged(() => this.SelectedResource);
                    OnPropertyChanged(() => this.FilterValue);
                }
            }
        }

        public ScheduleViewVM()
        {
            MakeAppointments();
            MakeResources();
        }

        private void MakeAppointments()
        {
            Appointments = new ObservableCollection<Appointment>();
            for ( int i = 0; i < 10; i++)
            {
                Appointments.Add(new Appointment()
                {
                    Subject = "Appointment " + i.ToString(),
                    Start = DateTime.Now.AddHours(i),
                    End = DateTime.Now.AddHours(i).AddMinutes(30)

                });
            }
        }

        private void MakeResources()
        {
            ResourceTypes = new ObservableCollection<ResourceType>();
            ResourceType rt = new ResourceType("Location");
            rt.Resources.Add(new Resource("Hall A", "Location"));
            rt.Resources.Add(new Resource("Hall B", "Location"));
            rt.Resources.Add(new Resource("Hall C", "Location"));
            ResourceTypes.Add(rt);

            ResourceType newRT = new ResourceType("Speaker");
            ComboResources = new ObservableCollection<Resource>();
            ComboResources.Add(new Resource("Enchev", "Speaker"));
            ComboResources.Add(new Resource("Milev", "Speaker"));
            ComboResources.Add(new Resource("Donchev", "Speaker"));

            newRT.Resources.AddRange(ComboResources);
            ResourceTypes.Add(newRT);

        }

        public Predicate<IAppointment> FilterValue
        {
            get { return Filter; }
        }

        public bool Filter(IAppointment appt)
        {
            Appointment app = appt as Appointment;
            return app != null && FilterBySpeaker(app);
        }

        public bool FilterBySpeaker(Appointment app)
        {
            return SelectedResource == null || 
                app.Resources.Contains(SelectedResource);
        }
    }
}
#endregion


}