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

#region radnumericupdown-major-changes_0
[Range(0, 20)] 
        public int? Age 
        { 
            set; 
            get; 
        }
#endregion
}
