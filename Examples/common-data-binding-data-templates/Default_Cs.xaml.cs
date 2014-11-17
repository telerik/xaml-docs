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

#region common-data-binding-data-templates_1
this.listBox.ItemsSource = this.CreateSampleData();
#endregion

#region common-data-binding-data-templates_3
public class MyData
{
    public MyData( string color )
    {
        this.Color = color;
    }
    public string Color
    {
        get;
        set;
    }
}
#endregion
}
