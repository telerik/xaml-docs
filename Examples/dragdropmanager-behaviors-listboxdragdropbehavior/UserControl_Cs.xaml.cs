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

#region dragdropmanager-behaviors-listboxdragdropbehavior_5
protected override IEnumerable<object> CopyDraggedItems(ListBoxDragDropState state)
{
	return state.DraggedItems.OfType<Customer>().Select(c => c.Copy()).Cast<object>();
} 
#endregion

#region dragdropmanager-behaviors-listboxdragdropbehavior_6
public class CustomerToAppointmentConverter : DataConverter
{
}
#endregion


#region dragdropmanager-behaviors-listboxdragdropbehavior_7
public override string[] GetConvertToFormats()
{
	return new string[] { typeof(Appointment).FullName, typeof(Customer).FullName };
}
public override object ConvertTo(object data, string format)
{
	var customers = (IEnumerable)DataObjectHelper.GetData(data, typeof(Customer), false);
	if (customers != null && format == typeof(Appointment).FullName)
	{
		return customers.OfType<Customer>().Select(c => new Appointment { Subject = c.Name });
	}
	var appointments = (IEnumerable)DataObjectHelper.GetData(data, typeof(Appointment), false);
	if (appointments != null && format == typeof(Customer).FullName)
	{
		return appointments.OfType<Appointment>().Select(a => new Customer { Name = a.Subject });	
	}
	return null;
}

#endregion

}
