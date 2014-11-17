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

#region radscheduleview-features-customizing-dialog-windows_0
public class CustomScheduleViewDialogHostFactory : ScheduleViewDialogHostFactory
{
    protected override IScheduleViewDialogHost CreateNew(ScheduleViewBase scheduleView, DialogType dialogType)
    {
        var host = base.CreateNew(scheduleView, dialogType);
        var window = host as RadWindow;
        // Set properties on RadWindow here.
        return host;
    }
}
#endregion

#region radscheduleview-features-customizing-dialog-windows_2
public class WindowDialogHost : Window, IScheduleViewDialogHost
{
	public new event EventHandler<WindowClosedEventArgs> Closed;
	public ScheduleViewBase ScheduleView
	{
		get;
		set;
	}
	protected override void OnClosed(System.EventArgs e)
	{
		base.OnClosed(e);
		if (this.Closed != null)
		{
			this.Closed(this, new WindowClosedEventArgs());
		}
	}
	public void Show(bool isModal)
	{
		if (this.Owner == null && this.ScheduleView != null)
		{
			this.Owner = this.ScheduleView.ParentOfType<Window>();
		}
		if (isModal)
		{
			this.ShowDialog();
		}
		else
		{
			this.Show();
		}
	}
}
#endregion


#region radscheduleview-features-customizing-dialog-windows_3
public class WindowDialogHost : ChildWindow, IScheduleViewDialogHost
{
	private bool opened;
		
	protected override void OnOpened()
	{
		base.OnOpened();
		this.opened = true;
	}
	protected override void OnClosed(System.EventArgs e)
	{
		base.OnClosed(e);
		if (this.Closed != null && this.opened)
		{
			this.opened = false;
			this.Closed(this, new WindowClosedEventArgs());
		}
	}

	public new event EventHandler<WindowClosedEventArgs> Closed;

	public ScheduleViewBase ScheduleView { get; set; }

	void IScheduleViewDialogHost.Close()
	{
		if (this.opened)
		{
			this.Close();
		}
	}

	public void Show(bool isModal)
	{
		this.Show();
	}
}
#endregion

#region radscheduleview-features-customizing-dialog-windows_4
public class CustomScheduleViewDialogHostFactory : IScheduleViewDialogHostFactory
{
    public virtual IScheduleViewDialogHost CreateNew(ScheduleViewBase scheduleView, DialogType dialogType)
    {
        var window = new WindowDialogHost
        {
            Content = new SchedulerDialog(),
            ScheduleView = scheduleView
            // Set additional properties here
        };
        return window;
     }    
}
#endregion

#region radscheduleview-features-customizing-dialog-windows_5
public class CustomScheduleViewDialogHostFactory : ScheduleViewDialogHostFactory
{
    protected override IScheduleViewDialogHost CreateNew(ScheduleViewBase scheduleView, DialogType dialogType)
    {
        var window = new WindowDialogHost
        {
            Content = new SchedulerDialog(),
            ScheduleView = scheduleView, 
            Width = 580,
            Height = 350,
            Background = new SolidColorBrush(Colors.LightSkyBlue)
            // Set additional properties here
        };
        return window;
    }
}

#endregion
}
