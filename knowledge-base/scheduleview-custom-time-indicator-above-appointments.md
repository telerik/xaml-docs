---
title: Setting Custom Time Indicator to Appear Above Appointments in ScheduleView for UI for WPF
description: How to use custom time indicators in ScheduleView for UI for WPF to position them above appointments.
type: how-to
page_title: Custom Time Indicator Above Appointments in ScheduleView for UI for WPF
meta_title: Custom Time Indicator Above Appointments in ScheduleView for UI for WPF
slug: scheduleview-custom-time-indicator-above-appointments
tags: scheduleview, ui-for-wpf, timeindicator, appointmentsarea, panel.zindex
res_type: kb
ticketid: 1706373
---

## Environment

<table>
<tbody>
<tr>
<td> Product </td>
<td> ScheduleView for UI for WPF </td>
</tr>
<tr>
<td> Version </td>
<td> Current </td>
</tr>
</tbody>
</table>

## Description

I want the CurrentTimeIndicator in [ScheduleView](https://docs.telerik.com/devtools/wpf/controls/radscheduleview/overview) for UI for WPF to appear above appointments. By default, it is hosted in the TimeRulerLinesPanel, which places it behind appointments. I am looking for a solution to display a time indicator on top of the appointment area.

This knowledge base article also answers the following questions:
- How to set the timeline above appointments in ScheduleView?
- Can a custom time indicator in ScheduleView appear above appointments?
- How to position time indicators using ZIndex in ScheduleView?

## Solution

To achieve this, use the time indicators functionality instead of the CurrentTimeIndicator. Add a custom time indicator, and modify its behavior to resemble the CurrentTimeIndicator. Set the `Panel.ZIndex` of the `TimeIndicatorsPanel` to display the custom time indicator above appointments.

Follow these steps:

1. Create a helper class to fetch the current date and time.
   ```csharp
   public static class DateTimeHelper
   {
       public static DateTime DateTimeNow => DateTime.Now;
   }
   ```

2. Create a custom time indicator class that updates its time dynamically.
   ```csharp
   public class CustomTimeIndicator : TimeIndicator, INotifyPropertyChanged
   {
       private DateTime dateTime;
       private DispatcherTimer updateTimer;
       private bool isTimerRunning;

       public CustomTimeIndicator()
       {
           this.updateTimer = new DispatcherTimer()
           {
               Interval = TimeSpan.FromMinutes(1)
           };

           this.updateTimer.Tick += UpdateTimer_Tick;
       }

       private void UpdateTimer_Tick(object sender, EventArgs e)
       {
           this.CurrentDateTime = DateTime.Now;
       }

       public DateTime CurrentDateTime
       {
           get => this.dateTime;
           set
           {
               if (this.dateTime != value)
               {
                   this.dateTime = value;
                   RaisePropertyChanged(nameof(this.CurrentDateTime));
               }

               if (!this.isTimerRunning)
               {
                   this.isTimerRunning = true;
                   this.updateTimer.Start();
               }
           }
       }

       public event PropertyChangedEventHandler PropertyChanged;

       protected virtual void RaisePropertyChanged(string propertyName)
       {
           PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
       }

       public override DateTime GetDateTime()
       {
           return this.CurrentDateTime;
       }
   }
   ```

3. Add the custom time indicator to the `TimeIndicatorsCollection` in the XAML.
   ```xaml
   <telerik:RadScheduleView.TimeIndicatorsCollection>
       <telerik:TimeIndicatorsCollection>
           <local:CustomTimeIndicator CurrentDateTime="{x:Static local:DateTimeHelper.DateTimeNow}" Location="AppointmentsArea" />
       </telerik:TimeIndicatorsCollection>
   </telerik:RadScheduleView.TimeIndicatorsCollection>
   ```

4. Adjust the `Panel.ZIndex` of the `TimeIndicatorsPanel` to display the custom indicator above appointments.
   ```csharp
   private void RadScheduleView_Loaded(object sender, RoutedEventArgs e)
   {
       var scheduleView = (RadScheduleView)sender;

       var indicatorPanels = scheduleView.ChildrenOfType<TimeIndicatorsPanel>();

       foreach (var panel in indicatorPanels)
       {
           Panel.SetZIndex(panel, 2);
       }
   }
   ```

The custom time indicator will now appear above the appointments.

## See Also

- [RadScheduleView Overview](https://docs.telerik.com/devtools/wpf/controls/radscheduleview/overview)
- [Time Indicators in RadScheduleView](https://docs.telerik.com/devtools/wpf/controls/radscheduleview/features/timeindicators)
- [Custom TimeIndicator](https://docs.telerik.com/devtools/wpf/controls/radscheduleview/features/timeindicators#custom-timeindicator)
