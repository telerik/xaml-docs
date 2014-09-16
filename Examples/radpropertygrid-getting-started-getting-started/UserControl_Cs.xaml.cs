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

#region radpropertygrid-getting-started-getting-started_4
this.PropertyGrid1.Item = new Employee() 
   { FirstName = "Sarah",
    LastName = "Blake", 
    Occupation = "Supplied Manager", 
    StartingDate = new DateTime(2005, 04, 12), 
    IsMarried = true, Salary = 3500, Gender = Gender.Female 
   };
#endregion

#region radpropertygrid-getting-started-getting-started_8
 DataContext = new Order()
            {
                OrderDate = new DateTime(1996, 7, 5),
                ShippedDate = new DateTime(1996, 8, 16),
                ShipAddress = "Luisenstr. 48",
                ShipCountry = "Germany",
                ShipName = "Toms Spezialitaten",
                ShipPostalCode = "44087",
                Employee = new Employee()
                {
                    FirstName = "Nancy",
                    LastName = "Davolio",
                    Title = "Sales Representative",
                    HomePhone = "(206) 555-9857",
                    Department = new Department() 
                    { 
                        Country = "USA",
                        ID = 1
                    }
                },

            };
#endregion

}
