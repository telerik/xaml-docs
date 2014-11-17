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

#region radtilelist-getting-started_4
public class Employee 
 {  
  public string FirstName
  {
   get;
   set;
  }
  public string LastName
  {
   get;
   set;
  }
  public string Occupation
  {
   get;
   set;
  }
  public int Salary
  {
   get;
   set;
  }
 }
#endregion





#region radtilelist-getting-started_6
public class Employee
{
  public Employee()
  { }
  public static ObservableCollection<Employee> GetEmployees()
  {
   ObservableCollection<Employee> employees = new ObservableCollection<Employee>();
   employees.Add(new Employee() { FirstName = "Sarah", LastName = "Blake", Occupation = "Suppliess Manager", Salary = 3500 });
   employees.Add(new Employee() { FirstName = "Jane", LastName = "Simpson", Occupation = "Security", Salary = 2000 });
   employees.Add(new Employee() { FirstName = "John", LastName = "Peterson", Occupation = "Consultant", Salary = 2600 });
   employees.Add(new Employee() { FirstName = "Peter", LastName = "Bush", Occupation = "Cashier", Salary = 2300 });
   return employees;
  }
}
#endregion

#region radtilelist-getting-started_8
public MainPage()
  {
   InitializeComponent();   
   this.RadTileList.ItemsSource = Employee.GetEmployees();
  }
#endregion
}
