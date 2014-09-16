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

#region radtreeview-how-to-bind-hierarchical-data-use-containerbindingcollection_0
public class Person
{
    public Person()
    {
    }
    public string Name
    {
        get;
        set;
    }
    public bool Selected
    {
        get;
        set;
    }
}
#endregion

#region radtreeview-how-to-bind-hierarchical-data-use-containerbindingcollection_2
public class Department
{
    public Department()
    {
        this.Employees = new List<Person>();
    }
    public string Name
    {
        get;
        set;
    }
    public bool Selected
    {
        get;
        set;
    }
    public bool Expanded
    {
        get;
        set;
    }
    public List<Person> Employees
    {
        get;
        set;
    }
}
#endregion

#region radtreeview-how-to-bind-hierarchical-data-use-containerbindingcollection_4
public class Organization
{
    public Organization()
    {
        this.Departments = new List<Department>();
    }
    public string Name
    {
        get;
        set;
    }
    public bool Selected
    {
        get;
        set;
    }
    public bool Expanded
    {
        get;
        set;
    }
    public List<Department> Departments
    {
        get;
        set;
    }
}
#endregion

#region radtreeview-how-to-bind-hierarchical-data-use-containerbindingcollection_6
public class DataSource : List<Organization>
{
    public DataSource()
    {
        Organization telerik = new Organization()
        {
            Name = "Telerik"
        };
        Department silverlight = new Department()
        {
            Name = "Silverlight"
        };
        Department wpf = new Department()
        {
            Name = "WPF"
        };
        telerik.Departments.Add( silverlight );
        telerik.Departments.Add( wpf );
        silverlight.Employees.Add( new Person()
        {
            Name = "John"
        } );
        silverlight.Employees.Add( new Person()
        {
            Name = "Ben"
        } );
        silverlight.Employees.Add( new Person()
        {
            Name = "Ann"
        } );
        wpf.Employees.Add( new Person()
        {
            Name = "Karoline"
        } );
        wpf.Employees.Add( new Person()
        {
            Name = "Simone"
        } );
        wpf.Employees.Add( new Person()
        {
            Name = "Eduard"
        } );
        this.Add( telerik );
    } 
}
#endregion

#region radtreeview-how-to-bind-hierarchical-data-use-containerbindingcollection_13
public DataSource()
{
    Organization telerik = new Organization()
    {
        Name = "Telerik",
        Expanded = true,
        Selected = false
    };
    Department silverlight = new Department()
    {
        Name = "Silverlight",
        Expanded = true,
        Selected = false
    };
    Department wpf = new Department()
    {
        Name = "WPF",
        Expanded = false,
        Selected = false
    };
    telerik.Departments.Add( silverlight );
    telerik.Departments.Add( wpf );
    silverlight.Employees.Add( new Person()
    {
        Name = "John",
        Selected = true
    } );
    silverlight.Employees.Add( new Person()
    {
        Name = "Ben",
        Selected = false
    } );
    silverlight.Employees.Add( new Person()
    {
        Name = "Ann",
        Selected = false
    } );
    wpf.Employees.Add( new Person()
    {
        Name = "Karoline",
        Selected = false
    } );
    wpf.Employees.Add( new Person()
    {
        Name = "Simone",
        Selected = false
    } );
    wpf.Employees.Add( new Person()
    {
        Name = "Eduard",
        Selected = false
    } );
    this.Add( telerik );
}
#endregion
}
