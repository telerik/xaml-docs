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

#region gridview-template-selectors-overview_0
public class SampleTemplateSelector : DataTemplateSelector
{
    public override DataTemplate SelectTemplate( object item, DependencyObject container )
    {
        if ( item is League )
            return this.LeagueTemplate;
        else if ( item is Division )
            return this.DivisionTemplate;
        else if ( item is Team )
            return this.TeamTemplate;
        return null;
    }
    public DataTemplate LeagueTemplate
    {
        get;
        set;
    }
    public DataTemplate DivisionTemplate
    {
        get;
        set;
    }
    public DataTemplate TeamTemplate
    {
        get;
        set;
    }
}
#endregion
}
