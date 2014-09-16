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

#region radscheduleview-styles-and-templates-appointment-style_1
	public class AppointmentStyleSelector : OrientedAppointmentItemStyleSelector
	{
		public Style Room402AHorizontalStyle { get; set; }
		public Style Room401BHorizontalStyle { get; set; }
		public Style Room605AHorizontalStyle { get; set; }

		public Style Room402AVerticalStyle { get; set; }
		public Style Room401BVerticalStyle { get; set; }
		public Style Room605AVerticalStyle { get; set; }

		public override Style SelectStyle(object item, DependencyObject container, ViewDefinitionBase activeViewDefinition)
		{
			IAppointment appointment = item as IAppointment;
			if (appointment == null)
			{
				return base.SelectStyle(item, container, activeViewDefinition);
			}
			IResource resource = appointment.Resources.OfType<IResource>().FirstOrDefault((IResource r) => r.ResourceType == "Room");

			if (resource != null)
			{
				if (activeViewDefinition.GetOrientation() == Orientation.Horizontal)
				{
					switch (resource.ResourceName)
					{
						case "402A": return this.Room402AHorizontalStyle;
						case "401B": return this.Room401BHorizontalStyle;
						case "605A": return this.Room605AHorizontalStyle;
						default: break;
					}
				}
				else
				{
					switch (resource.ResourceName)
					{
						case "402A": return this.Room402AVerticalStyle;
						case "401B": return this.Room401BVerticalStyle;
						case "605A": return this.Room605AVerticalStyle;
						default: break;
					}
				}
			}
			return base.SelectStyle(item, container, activeViewDefinition);
		}
	}
#endregion
}
