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
	
#region radpropertygrid-unbound-mode_2
    public class Employee
    {
        public string Name { get; set; }
        public DateTime HireDate { get; set; }
        public Department Department { get; set; }
    }
 
    public class Department
    {
        public string Name { get; set; }
        public int ID { get; set; }
    }
#endregion

    #region radpropertygrid-unbound-mode_4
    public MainPage()
        {
            InitializeComponent();
            this.rpg.Item = new Employee()
            {
                Name = "Nancy Davolio",
                HireDate = DateTime.Now,
                Department = new Department()
                {
                    ID = 1,
                    Name = "US Department"                    
                }
            };
        }
    #endregion

}
