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

#region radcalendar-xml-binding_1
// Make sure that more than one date can be selected:
calendar.SelectionMode = SelectionMode.Extended;
// Load the xml document and get the culture with wich the dates were serialized:
XDocument xmlSource = XDocument.Load("DataSource.xml");
CultureInfo usCulture = new CultureInfo("En-US");
// Add Get all the dates in the xml document and add them as selected dates:
foreach (var dateNode in xmlSource.Descendants("Date"))
{
    calendar.SelectedDates.Add(DateTime.Parse(dateNode.Value, usCulture.DateTimeFormat));
}
// Set the display date to the forst selected date, so that the selection is visible.
calendar.DisplayDate = (DateTime)calendar.SelectedDates[0];
#endregion
}
