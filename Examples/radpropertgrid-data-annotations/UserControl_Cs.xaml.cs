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
#region radpropertygrid-data-annotations_1
     public class Employee
    {       
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNum { get; set; } 
        public int Salary { get; set; }
        public string Occupation { get; set; }                          
        public DateTime StartingDate { get; set; }              
    }
#endregion
#region radpropertygrid-data-annotations_3
this.propertyGrid1.Item = new Employee()
            {
                FirstName = "Sarah",
                LastName = "Blake",
                PhoneNum = "(555) 943-231",
                Occupation = "Supplies Manager",              
                Salary = 3500,
                StartingDate = new DateTime(2005, 12, 4)
            };
#endregion
#region radpropertygrid-data-annotations_5
         //Rename the StartingDate property to Year in the UI
         [Display(Name = "Year")]
         public DateTime StartingDate { get; set; }

         //Set a description to the FirstName property and categorize it to be from the group "Personal Information"
         [Display(Description = "Employee's first name.", GroupName = "Personal Information")]
         public string FirstName { get; set; }

         //Set a description to the LastName property and categorize it to be from the group "Personal Information"
         [Display(Description = "Employee's last name.", GroupName = "Personal Information")]
         public string LastName { get; set; }
#endregion
#region radpropertygrid-data-annotations_7
         //Hide StartingDate from the UI
        [Browsable(false)]
        public DateTime StartingDate { get; set; }
#endregion
#region radpropertygrid-data-annotations_9
         //Set StartingDate as Read-Only
        [ReadOnly(true)]
        public DateTime StartingDate { get; set; }
#endregion
#region radpropertygrid-data-annotations_11
        [Display(Description = "Employee's first name.", GroupName="Personal Information")]
        public string FirstName { get; set; }        
        [Display(Description = "Employee's last name.", GroupName="Personal Information")]
        public string LastName { get; set; }
        [Display(Name = "Occupation", GroupName = "Job Description")]
        public string Occupation { get; set; }               
        [Browsable(false)]
        public int Salary { get; set; }
        [Display(Name = "Number", GroupName = "Job Description")]
        public string PhoneNum { get; set; }        
        [ReadOnly(true)]
        public DateTime StartingDate { get; set; } 
#endregion

}
