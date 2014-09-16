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

#region raddataform-validation_0
private void DataForm1_ValidatingItem(object sender, System.ComponentModel.CancelEventArgs e)
  {   
   var employer = this.DataForm1.CurrentItem as Employee;
   if(employer.Salary < 1000)
   {
    RadWindow.Alert("You have to raise " + employer.LastName + " salary");
   }
  }
#endregion

#region raddataform-validation_2
public DateTime StartingDate
  {
   get
   {
    return this.startingDate;
   }
   set
   {
    if (value != this.startingDate)
    {
     if(value > DateTime.Now)
     {
      throw new ValidationException("Starting date should not be earlier than 2011");
     }
     else
     {
      this.startingDate = value;
      this.OnPropertyChanged("StartingDate");
     }     
    }
   }
  }
#endregion
}
