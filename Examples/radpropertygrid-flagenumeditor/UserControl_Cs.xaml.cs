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
	
#region radpropertygrid-flagenumeditor_0
[Flags]
public enum Permissions
	{
		Read = 1,
		Write = 2,
		Execute = 4
	}

#endregion

#region radpropertygrid-flagenumeditor_2
namespace RPG_WPF
{
    [Flags]
    public enum Permissions
    {
        All = -1,
        None = 0,
        Read = 1,
        Write = 2,
        Execute = 4
    }
}
#endregion

}
