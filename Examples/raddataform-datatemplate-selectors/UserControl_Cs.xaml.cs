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
	#region raddataform-datatemplate-selectors_0
	public class EmployeesEditTemplateSelector : Telerik.Windows.Controls.DataTemplateSelector
	{
		public override DataTemplate SelectTemplate(object item, DependencyObject container)
		{
			Employee employee = item as Employee;
			if (employee == null)
			{
				return null;
			}
			else if (employee.Salary > 2500)
			{
				return this.BigSalaryTemplate;
			}
			else
			{
				return this.SmallSalaryTemplate;
			}
		}

		public DataTemplate BigSalaryTemplate { get; set; }
		public DataTemplate SmallSalaryTemplate { get; set; }
	}
	#endregion
	#region raddataform-datatemplate-selectors_1
	public class EmployeesEditTemplateSelector : System.Windows.Controls.DataTemplateSelector
	{
		public override DataTemplate SelectTemplate(object item, DependencyObject container)
		{
			Employee employee = item as Employee;
			if (employee == null)
			{
				return null;
			}
			else if (employee.Salary > 2500)
			{
				return this.BigSalaryTemplate;
			}
			else
			{
				return this.SmallSalaryTemplate;
			}
		}

		public DataTemplate BigSalaryTemplate { get; set; }
		public DataTemplate SmallSalaryTemplate { get; set; }
	}
	#endregion
}
