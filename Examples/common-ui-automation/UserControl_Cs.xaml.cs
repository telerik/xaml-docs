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

#region common-ui-automation_0
using Telerik.Windows.Automation.Peers; 

public partial class App : Application
{
    public App()
    {
        AutomationManager.AutomationMode = AutomationMode.Disabled;
        this.InitializeComponent();
    }
}
#endregion
}