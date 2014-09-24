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

#region radmenu-features-icons_1
public class MenuItem
{
    ...
    public Uri IconUrl
    {
        get;
        set;
    }
    public Image Icon
    {
        get
        {
            return new Image()
            {
                Source = new BitmapImage( this.IconUrl )
            };
        }
    }
    ...
}
#endregion
}
