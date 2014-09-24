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

#region gridview-getting-started2_4
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
    public int Age
    {
        get;
        set;
    }
    public bool IsMarried
    {
        get;
        set;
    }
}
#endregion

#region gridview-getting-started2_6
public class EmployeeService
{
    public static ObservableCollection<Employee> GetEmployees()
    {
        ObservableCollection<Employee> employees = new ObservableCollection<Employee>();
        Employee employee = new Employee();
        employee.FirstName = "Maria";
        employee.LastName = "Anders";
        employee.IsMarried = true;
        employee.Age = 24;
        employees.Add( employee );
        employee = new Employee();
        employee.FirstName = "Ana";
        employee.LastName = "Trujillo";
        employee.IsMarried = true;
        employee.Age = 44;
        employees.Add( employee );
        employee = new Employee();
        employee.FirstName = "Antonio";
        employee.LastName = "Moreno";
        employee.IsMarried = true;
        employee.Age = 33;
        employees.Add( employee );
        employee = new Employee();
        employee.FirstName = "Thomas";
        employee.LastName = "Hardy";
        employee.IsMarried = false;
        employee.Age = 13;
        employees.Add( employee );
        employee = new Employee();
        employee.FirstName = "Hanna";
        employee.LastName = "Moos";
        employee.IsMarried = false;
        employee.Age = 28;
        employees.Add( employee );
        employee = new Employee();
        employee.FirstName = "Frederique";
        employee.LastName = "Citeaux";
        employee.IsMarried = true;
        employee.Age = 67;
        employees.Add( employee );
        employee = new Employee();
        employee.FirstName = "Martin";
        employee.LastName = "Sommer";
        employee.IsMarried = false;
        employee.Age = 22;
        employees.Add( employee );
        employee = new Employee();
        employee.FirstName = "Laurence";
        employee.LastName = "Lebihan";
        employee.IsMarried = false;
        employee.Age = 32;
        employees.Add( employee );
        employee = new Employee();
        employee.FirstName = "Elizabeth";
        employee.LastName = "Lincoln";
        employee.IsMarried = false;
        employee.Age = 9;
        employees.Add( employee );
        employee = new Employee();
        employee.FirstName = "Victoria";
        employee.LastName = "Ashworth";
        employee.IsMarried = true;
        employee.Age = 29;
        employees.Add( employee );
        return employees;
    }
}
#endregion

#region gridview-getting-started2_8
this.radGridView.ItemsSource = EmployeeService.GetEmployees();
#endregion
}
