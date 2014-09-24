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

#region radtreeview-populating-with-data-item-template-selector_0
public class LeagueDataTemplateSelector : DataTemplateSelector
{
}
#endregion

#region radtreeview-populating-with-data-item-template-selector_2
private HierarchicalDataTemplate leagueTemplate;
private HierarchicalDataTemplate divisionTemplate;
private DataTemplate teamTemplate;
public LeagueDataTemplateSelector()
{
}
public override DataTemplate SelectTemplate( object item, DependencyObject container )
{
    if ( item is League )
        return this.leagueTemplate;
    else if ( item is Division )
        return this.divisionTemplate;
    else if ( item is Team )
        return this.teamTemplate;
    return null;
}
public HierarchicalDataTemplate LeagueTemplate
{
    get
    {
        return this.leagueTemplate;
    }
    set
    {
        this.leagueTemplate = value;
    }
}
public HierarchicalDataTemplate DivisionTemplate
{
    get
    {
        return this.divisionTemplate;
    }
    set
    {
        this.divisionTemplate = value;
    }
}
public DataTemplate TeamTemplate
{
    get
    {
        return teamTemplate;
    }
    set
    {
        this.teamTemplate = value;
    }
}
#endregion
}
