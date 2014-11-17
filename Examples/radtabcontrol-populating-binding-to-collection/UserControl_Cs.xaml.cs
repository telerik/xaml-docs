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

#region radtabcontrol-populating-binding-to-collection_0
public class Person
{
    public Person( string name, int age )
    {
        this.Name = name;
        this.Age = age;
    }
    public string Name
    {
        get;
        set;
    }
    public int Age
    {
        get;
        set;
    }
}
#endregion

#region radtabcontrol-populating-binding-to-collection_2
public class ViewModel
{
    public ViewModel()
    {
        this.Persons = new ObservableCollection<Person>();
        this.Persons.Add( new Person( "Ivan", 23 ) );
        this.Persons.Add( new Person( "Stefan", 34 ) );
        this.Persons.Add( new Person( "Maria", 16 ) );
        this.Persons.Add( new Person( "Michael", 78 ) );
    }
    public ObservableCollection<Person> Persons
    {
        get;
        set;
    }
}
#endregion
}
