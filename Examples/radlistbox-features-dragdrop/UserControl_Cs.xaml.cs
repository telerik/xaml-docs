using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace WpfApplication1
{

#region radlistbox-features-dragdrop_0
public class ProductToOrderConverter: DataConverter
{
}
#endregion

#region radlistbox-features-dragdrop_1
public class ProductToOrderConverter : DataConverter
{
	public override string[] GetConvertToFormats()
	{
		return new string[] { typeof(Product).FullName, typeof(Order).FullName };
	}

	public override object ConvertTo(object data, string format)
	{
		var payload = (IEnumerable)DataObjectHelper.GetData(data, typeof(Product), false);
		if (payload != null)
		{
			return payload.OfType<Product>().Select(a => new Order {
				Name = a.Name,
				Quantity = 1
			});
		}
		return null;
	}
}
#endregion



#region radlistbox-features-dragdrop_2
public class Customer
{
	public string Name { get; set; }
	public int ID { get; set; }

	public Customer Copy()
	{
		return new Customer
		{
			Name = this.Name,
			ID = this.ID
		};
	}
}
#endregion

#region radlistbox-features-dragdrop_3
public ObservableCollection<Customer> CustomersSource { get; private set; }
public ObservableCollection<Appointment> AppointmentsSource { get; private set; }

public ViewModel()
{
	var monday = new DateTime(DateTime.Today.Year, DateTime.Today.Month, CalendarHelper.GetFirstDayOfWeek(DateTime.Today, DayOfWeek.Sunday).Day);

	this.CustomersSource = new ObservableCollection<Customer> 
	{
		new Customer { ID = 1, Name = "Customer 1" },
		new Customer { ID = 2, Name = "Customer 2" },
		new Customer { ID = 3, Name = "Customer 3" },
		new Customer { ID = 4, Name = "Customer 4" },
		new Customer { ID = 5, Name = "Customer 5" } 
	};

	this.AppointmentsSource = new ObservableCollection<Appointment> 
	{ 
		new Appointment { Start = monday, End = monday.AddHours(1), Subject = "Appointment 1" },
		new Appointment { Start = monday, End = monday.AddHours(1), Subject = "Appointment 2" },
		new Appointment { Start = monday, End = monday.AddHours(1), Subject = "Appointment 3" },
		new Appointment { Start = monday, End = monday.AddHours(1), Subject = "Appointment 4" },
		new Appointment { Start = monday, End = monday.AddHours(1), Subject = "Appointment 5" } 
	};

}
#endregion

#region radlistbox-features-dragdrop_4
public class AppointmentToCustomerConverter : DataConverter
{
	public override string[] GetConvertToFormats()
	{
		return new string[] { typeof(ScheduleViewDragDropPayload).FullName, typeof(Customer).FullName };
	}

	public override object ConvertTo(object data, string format)
	{

		var payload = DataObjectHelper.GetData(data, typeof(ScheduleViewDragDropPayload), false) as ScheduleViewDragDropPayload;
		if (payload != null)
		{
			var customers = payload.DraggedAppointments;
			return customers.OfType<Appointment>().Select(a => new Customer { Name = a.Subject });
		}		
		return null;
	}
}
#endregion

#region radlistbox-features-dragdrop_5
public class ScheduleViewDragDropBehavior : Telerik.Windows.Controls.ScheduleViewDragDropBehavior
{
	public object customers { get; set; }

	public override IEnumerable<IOccurrence> ConvertDraggedData(object data)
	{

		if (DataObjectHelper.GetDataPresent(data, typeof(Customer), false))
		{
			var customers = DataObjectHelper.GetData(data, typeof(Customer), true) as IEnumerable;
			if (customers != null)
			{
				var newApp = customers.OfType<Customer>().Select(c => new Appointment { Subject = c.Name });
				return newApp;
			}
		}

		return base.ConvertDraggedData(data);
	}
}
#endregion