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

#region radcalendar-events_0
using System;
using System.Windows.Controls;
namespace EventsHandling
{
    public partial class Page : UserControl
    {
        public Page()
        {
            InitializeComponent();
            calendar.SelectionChanged += new EventHandler<SelectionChangedEventArgs>(calendar_SelectionChanged);
        }
        void calendar_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            message.Text = String.Format("{0} dates have been selected.", calendar.SelectedDates.Count);
        }
    }
}
#endregion

#region radcalendar-events_2
public Page()
{
    InitializeComponent();
    //Sign up for the event:
    this.LayoutRoot.AddHandler(RadCalendar.SelectionChangedEvent, new Telerik.Windows.Controls.SelectionChangedEventHandler(OnCalendarSelectionChanged));
}
private void OnCalendarSelectionChanged(object sender, Telerik.Windows.Controls.SelectionChangedEventArgs e)
{
}
#endregion
}
