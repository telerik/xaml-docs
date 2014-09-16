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

#region radscheduleview-features-appointments-custom-appointment_0
public class Task:Appointment
{
    private bool isDone;
    public bool IsDone
    {
        get
        {
             return this.Storage<Task>().isDone;
        }
        set
        {
             var storage = this.Storage<Task>();
             if (storage.isDone != value)
             {
                  storage.isDone = value;
                  this.OnPropertyChanged(() => this.IsDone);
             }
        }
    }
    public override IAppointment Copy()
    {
        var newAppointment = new Task();
        newAppointment.CopyFrom(this);
        return newAppointment;
    }
    public override void CopyFrom(IAppointment other)
    {
        var task = other as Task;
        if (task != null)
        {
                this.IsDone = task.IsDone;
        }
        base.CopyFrom(other);
    }
}
#endregion

#region radscheduleview-features-appointments-custom-appointment_2
public class TasksCollection : ObservableCollection<Task>
{
    public TasksCollection()
    {
         DateTime today = DateTime.Today;
         foreach (Task t in Enumerable.Range(9, 14).Select(i =>
            new Task
            {
                 Start = today.AddMinutes(i * 60 + 15),
                 End = today.AddMinutes((i + 1) * 60),
                 Subject = string.Format("Task num. {0}",i),
                 IsDone = today.AddMinutes((i + 1) * 60) < DateTime.Now
             }))
         {
          this.Add(t);
         }
    }
}
#endregion
}
