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

#region radchart-axes-axis_1
public class BinaryTemplateSelector : DataTemplateSelector
{
    public DataTemplate Template1
    {
        get;
        set;
    }
    public DataTemplate Template2
    {
        get;
        set;
    }
    public override DataTemplate SelectTemplate(object item, DependencyObject container)
    {
        DataTemplate tmp = this.Template1;
        this.Template1 = this.Template2;
        this.Template2 = tmp;
        return tmp;
    }
}
#endregion
}
