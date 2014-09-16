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

#region radscheduleview-styles-and-templates-appointment-template_1
public class Task : Appointment
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
	...
}
#endregion
#region radscheduleview-styles-and-templates-appointment-template_3
public class CustomAppointmentTemplateSelector : Telerik.Windows.Controls.ScheduleViewDataTemplateSelector
{
    public DataTemplate DayAppointmentTemplate { get; set; }
	public DataTemplate DefaultAppointmentTemplate { get; set; }
		

	public override DataTemplate SelectTemplate(object item, DependencyObject container, Telerik.Windows.Controls.ViewDefinitionBase activeViewDefinition)
	{
        if (activeViewDefinition is WeekViewDefinition)
            return this.DefaultAppointmentTemplate;

		if (activeViewDefinition is DayViewDefinition)
			return this.DayAppointmentTemplate;		

		return base.SelectTemplate(item, container, activeViewDefinition);
	}
}
#endregion
}
