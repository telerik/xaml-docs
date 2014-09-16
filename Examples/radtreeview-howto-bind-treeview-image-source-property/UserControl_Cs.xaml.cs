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

#region radtreeview-howto-bind-treeview-image-source-property_0
public class Person : INotifyPropertyChanged
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
    public string ImagePath
    {
        get;
        set;
    }
    // INotifyPropertyChanged implementation goes here
}
#endregion
}
