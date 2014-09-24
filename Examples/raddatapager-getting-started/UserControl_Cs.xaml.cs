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

#region raddatapager-getting-started_1
public class Employee
{
    public Employee( string name, string companyName, string title )
    {
        this.Name = name;
        this.CompanyName = companyName;
        this.Title = title;
    }
    public string Name
    {
        get;
        set;
    }
    public string CompanyName
    {
        get;
        set;
    }
    public string Title
    {
        get;
        set;
    }
}
#endregion

#region raddatapager-getting-started_4
ObservableCollection<Employee> employees = new ObservableCollection<Employee>();
employees.Add( new Employee( "Maria Anders", "Alfreds Futterkiste", "Sales Representative" ) );
employees.Add( new Employee( "Ana Trujillo", "Ana Trujillo Emparedados y helados", "Owner" ) );
employees.Add( new Employee( "Antonio Moreno", "Antonio Moreno Taqueria", "Owner" ) );
employees.Add( new Employee( "Thomas Hardy", "Around the Horn", "Sales Representative" ) );
employees.Add( new Employee( "Hanna Moos", "Blauer See Delikatessen", "Sales Representative" ) );
employees.Add( new Employee( "Frederique Citeaux", "Blondesddsl pere et fils", "Marketing Manager" ) );
employees.Add( new Employee( "Martin Sommer", "Bolido Comidas preparadas", "Owner" ) );
employees.Add( new Employee( "Laurence Lebihan", "Bon app'", "Owner" ) );
employees.Add( new Employee( "Elizabeth Lincoln", "Bottom-Dollar Markets", "Accounting manager" ) );
employees.Add( new Employee( "Victoria Ashworth", "B's Beverages", "Sales representative" ) );
this.radDataPager.Source = employees;
#endregion
}
