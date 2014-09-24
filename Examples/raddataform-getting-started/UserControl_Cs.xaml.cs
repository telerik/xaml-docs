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

#region raddataform-getting-started_4
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
  public DateTime StartingDate
  {
   get;
   set;
  }
  public bool IsMarried
  {
   get;
   set;
  }
  public int Salary
  {
   get;
   set;
  }
  public Gender Gender
  {
   get;
   set;
  }
 }
#endregion

#region raddataform-getting-started_6
public enum Gender
 {
  Female,
  Male
 }
#endregion

#region raddataform-getting-started_8
public MainPage()
  {
   InitializeComponent();
   Employee employee = new Employee() 
      { FirstName = "Sarah", LastName = "Blake", Occupation = "Supplied Manager", StartingDate = new DateTime(2005, 04, 12), IsMarried = true, Salary = 3500,   Gender = Gender.Female };   this.DataForm1.CurrentItem = employee;
  }
#endregion

#region raddataform-getting-started_10
public class Employee
{
  public Employee()
  { }
  public static ObservableCollection<Employee> GetEmployees()
  {
   ObservableCollection<Employee> employees = new ObservableCollection<Employee>();
   employees.Add(new Employee() { FirstName = "Sarah", LastName = "Blake", Occupation = "Supplied Manager", StartingDate = new DateTime(2005, 04, 12), IsMarried = true, Salary = 3500, Gender = Gender.Female });
   employees.Add(new Employee() { FirstName = "Jane", LastName = "Simpson", Occupation = "Security", StartingDate = new DateTime(2008, 12, 03), IsMarried = true, Salary = 2000, Gender = Gender.Female });
   employees.Add(new Employee() { FirstName = "John", LastName = "Peterson", Occupation = "Consultant", StartingDate = new DateTime(2005, 04, 12), IsMarried = false, Salary = 2600, Gender = Gender.Male });
   employees.Add(new Employee() { FirstName = "Peter", LastName = "Bush", Occupation = "Cashier", StartingDate = new DateTime(2005, 04, 12), IsMarried = true, Salary = 2300, Gender = Gender.Male });
   return employees;
  }
}
#endregion

#region raddataform-getting-started_12
public MainPage()
  {
   InitializeComponent();   
   this.DataForm1.ItemsSource = Employee.GetEmployees();
  }
#endregion
}
