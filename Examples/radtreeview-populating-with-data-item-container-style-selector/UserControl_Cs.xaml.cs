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

#region radtreeview-populating-with-data-item-container-style-selector_4
public class LeagueItemContainerStyleSelector : StyleSelector
{
}
#endregion

#region radtreeview-populating-with-data-item-container-style-selector_6
public class LeagueItemContainerStyleSelector : StyleSelector
{
    private Style leagueStyle;
    private Style divisionStyle;
    private Style teamStyle;
    public override Style SelectStyle( object item, DependencyObject container )
    {
        if ( item is League )
            return this.leagueStyle;
        else if ( item is Division )
            return this.divisionStyle;
        else if ( item is Team )
            return this.teamStyle;
        return null;
    }
    public Style LeagueStyle
    {
        get
        {
            return this.leagueStyle;
        }
        set
        {
            this.leagueStyle = value;
        }
    }
    public Style DivisionStyle
    {
        get
        {
            return this.divisionStyle;
        }
        set
        {
            this.divisionStyle = value;
        }
    }
    public Style TeamStyle
    {
        get
        {
            return this.teamStyle;
        }
        set
        {
            this.teamStyle = value;
        }
    }
}
#endregion
}
