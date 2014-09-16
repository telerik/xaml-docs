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

#region raddataform-integrate-with-radgridview_0
public class Employee : INotifyPropertyChanged
 {  
  public event PropertyChangedEventHandler PropertyChanged;
  private string firstName;
  private string lastName;
  private string ocupation;
  private DateTime startingDate;
  private bool isMarried;
  public string FirstName
  {
   get { return this.firstName; }
   set
   {
    if (value != this.firstName)
    {
     this.firstName = value;
     this.OnPropertyChanged("FirstName");
    }
   }
  }
  public string LastName
  {
   get { return this.lastName; }
   set
   {
    if (value != this.lastName)
    {
     this.lastName = value;
     this.OnPropertyChanged("LastName");
    }
   }
  }
  public string Ocupation
  {
   get { return this.ocupation; }
   set
   {
    if (value != this.ocupation)
    {
     this.ocupation = value;
     this.OnPropertyChanged("Ocupation");
    }
   }
  }
  public DateTime StartingDate
  {
   get { return this.startingDate; }
   set
   {
    if (value != this.startingDate)
    {
     this.startingDate = value;
     this.OnPropertyChanged("StartingDate");
    }
   }
  }
  public bool IsMarried
  {
   get
   {
    return this.isMarried;
   }
   set
   {
    if (this.isMarried != value)
    {
     this.isMarried = value;
     this.OnPropertyChanged("IsMarried");
    }
   }
  }
  private int salary;
  public int Salary
  {
   get
   {
    return this.salary;
   }
   set
   {
    if (this.salary != value)
    {
     this.salary = value;
     this.OnPropertyChanged("Salary");
    }
   }
  }
  public Employee()
  { }
  protected virtual void OnPropertyChanged(PropertyChangedEventArgs args)
  {
   PropertyChangedEventHandler handler = this.PropertyChanged;
   if (handler != null)
   {
    handler(this, args);
   }
  }
  private void OnPropertyChanged(string propertyName)
  {
   this.OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
  }
  public static ObservableCollection<Employee> GetEmployees()
  {
   ObservableCollection<Employee> employees = new ObservableCollection<Employee>();
   employees.Add(new Employee() { FirstName = "Sarah", LastName = "Blake", Ocupation = "Supplied Manager", StartingDate = new DateTime(2005, 04, 12), IsMarried = true, Salary = 3500 });
   employees.Add(new Employee() { FirstName = "Jane", LastName = "Simpson", Ocupation = "Security", StartingDate = new DateTime(2008, 12, 03), IsMarried = true, Salary = 2000 });
   employees.Add(new Employee() { FirstName = "John", LastName = "Peterson", Ocupation = "Consultant", StartingDate = new DateTime(2005, 04, 12), IsMarried = false, Salary = 2600 });
   employees.Add(new Employee() { FirstName = "Peter", LastName = "Bush", Ocupation = "Casheer", StartingDate = new DateTime(2005, 04, 12), IsMarried = true, Salary = 2300 });
   return employees;
  }
 }
#endregion

#region raddataform-integrate-with-radgridview_3
public MainPage()
  {
   InitializeComponent();   
   this.RadGridView1.ItemsSource = Employee.GetEmployees();  
  }
#endregion
}
