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

#region raddatafilter-features-data-annotations_0
public class Person
{
    [Display( AutoGenerateFilter = false )]
    public string Name
    {
        get;
        set;
    }
    [Display( ShortName = "Company's Name" )]
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

#region raddatafilter-features-data-annotations_2

[Browsable(false)]
[Display(ShortName = "Company's Name")]
public string CompanyName
{
    get;
    set;
}
#endregion
}
