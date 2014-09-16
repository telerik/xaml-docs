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

#region radscheduleview-features-recurrences-recurrencerule_0
var startDate = new DateTime(2011, 05, 11, 10, 0, 0);
var fitnessAppointment = new Appointment()
{
    Start = startDate,
    End = startDate.AddHours(2),
    Subject = "Fitness"
};
var recurrencePattern = new RecurrencePattern()
{
    Frequency = RecurrenceFrequency.Weekly,
    MaxOccurrences = 30,
    DaysOfWeekMask = RecurrenceDays.Monday | RecurrenceDays.Wednesday | RecurrenceDays.Friday
};        
fitnessAppointment.RecurrenceRule = new RecurrenceRule(recurrencePattern);
#endregion

#region radscheduleview-features-recurrences-recurrencerule_2
var startDate = new DateTime(2011, 05, 11, 10, 0, 0);
var fitnessAppointment = new Appointment()
{
    Start = startDate,
    End = startDate.AddHours(2),
    Subject = "Fitness"
};
#endregion

#region radscheduleview-features-recurrences-recurrencerule_4
var recurrencePattern = new RecurrencePattern()
{
    Frequency = RecurrenceFrequency.Daily,
    DaysOfWeekMask = RecurrenceDays.Wednesday,
    MaxOccurrences = 10
};
#endregion

#region radscheduleview-features-recurrences-recurrencerule_6
var rule = new RecurrenceRule(recurrencePattern);
#endregion

#region radscheduleview-features-recurrences-recurrencerule_8
var exceptionDate = fitnessAppointment.Copy()
exceptionDate.Start = fitnessAppointment.Start.AddDays(-1);
exceptionDate.End = fitnessAppointment.End.AddDays(-1);          
rule.AddException(startDate, exceptionDate);
#endregion

#region radscheduleview-features-recurrences-recurrencerule_10
fitnessAppointment.RecurrenceRule = rule;
#endregion
}
