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

#region common-data-binding-style-selectors_0
public class StyleSelector
#endregion

#region common-data-binding-style-selectors_4
public virtual Style SelectStyle( object item, DependencyObject container );
#endregion

#region common-data-binding-style-selectors_6
public class SampleStyleSelector : StyleSelector
{
    public override Style SelectStyle( object item, DependencyObject container )
    {
        if ( item is League )
            return this.LeagueStyle;
        else if ( item is Division )
            return this.DivisionStyle;
        else if ( item is Team )
            return this.TeamStyle;
        return null;
    }
    public Style LeagueStyle
    {
        get;
        set;
    }
    public Style DivisionStyle
    {
        get;
        set;
    }
    public Style TeamStyle
    {
        get;
        set;
    }
}
#endregion
}
