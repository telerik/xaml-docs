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

#region raddataform-validation-item-level_0
    using System.ComponentModel.DataAnnotations
    //...
    public class Employee
    {
        [Required]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "LastName is required")]
        public string LastName { get; set; }

        [Range(21, 70)]
        public int Age { get; set; }

        [RegularExpression("[a-z]#[0-9]*")]
        public string EmployeeID { get; set; }
    }

#endregion
}
