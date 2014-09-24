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

#region radexpressioneditor-getting-started_3
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
  public Employee()
  {
  }
  public static ObservableCollection<Employee> GetEmployees()
  {
   ObservableCollection<Employee> employees = new ObservableCollection<Employee>();
   employees.Add(new Employee() { FirstName = "Sarah", LastName = "Blake", Occupation = "Supplied Manager", StartingDate = new DateTime(2005, 04, 12), IsMarried = true, Salary = 3500 });
   employees.Add(new Employee() { FirstName = "Jane", LastName = "Simpson", Occupation = "Security", StartingDate = new DateTime(2008, 12, 03), IsMarried = true, Salary = 2000 });
   employees.Add(new Employee() { FirstName = "John", LastName = "Peterson", Occupation = "Consultant", StartingDate = new DateTime(2005, 04, 12), IsMarried = false, Salary = 2600 });
   employees.Add(new Employee() { FirstName = "Peter", LastName = "Bush", Occupation = "Cashier", StartingDate = new DateTime(2005, 04, 12), IsMarried = true, Salary = 2300 });
   return employees;
  }
 }
#endregion

#region radexpressioneditor-getting-started_5
public class MyViewModel
 {
  private ObservableCollection<Employee> employees;
  public ObservableCollection<Employee> Employees
  {
   get
   {
    if (this.employees == null)
    {
     this.employees = Employee.GetEmployees();
    }
    return this.employees;
   }
  }  
 }
#endregion

#region radexpressioneditor-getting-started_9
private FilterDescriptor<Employee> genericFilterDescriptor = new FilterDescriptor<Employee>();
private void ExpressionEditor_ExpressionChanged(object sender, Telerik.Windows.RadRoutedEventArgs e)
  {
   if (this.ExpressionEditor.Expression != null && this.ExpressionEditor.Expression.GetType() == typeof(Expression<Func<Employee, bool>>))
   {
    this.genericFilterDescriptor.FilteringExpression = (Expression<Func<Employee, bool>>)this.ExpressionEditor.Expression;
    if (!this.GridView.FilterDescriptors.Contains(this.genericFilterDescriptor))
    {
     this.GridView.FilterDescriptors.Add(this.genericFilterDescriptor);
    }
   }
   else if (this.ExpressionEditor.Expression == null)
   {
    if (this.GridView.FilterDescriptors.Contains(this.genericFilterDescriptor))
    {
     this.GridView.FilterDescriptors.Remove(this.genericFilterDescriptor);
    }    
   }
  }
#endregion
}
