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

#region radtreeview-populating-with-data-item-edit-template-selector_4
public class LeagueDataTemplateSelector : DataTemplateSelector
{
}
#endregion

#region radtreeview-populating-with-data-item-edit-template-selector_6
public class LeagueItemEditTemplateSelector : DataTemplateSelector
{
    private DataTemplate leagueTemplate;
    private DataTemplate divisionTemplate;
    private DataTemplate teamTemplate;
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
    public DataTemplate LeagueTemplate
    {
        get
        {
            return leagueTemplate;
        }
        set
        {
            leagueTemplate = value;
        }
    }
    public DataTemplate DivisionTemplate
    {
        get
        {
            return divisionTemplate;
        }
        set
        {
            divisionTemplate = value;
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
            teamTemplate = value;
        }
    }
}
#endregion
}
