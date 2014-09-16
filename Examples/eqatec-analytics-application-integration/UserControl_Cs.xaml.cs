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

#region eqatec-analytics-application-integration_0
public App()
{         
    //The following code enables Telerik Analytics for your project
    var analyticsMonitor = Telerik.Windows.Analytics.TraceMonitor.Initialize(this, [product_key]);
    //Next Step: Enable analytics tracking for the Telerik controls that make sense to your business case. For example here is XAML code to enable tracking when a RadButton that downloads a file is clicked:
    //xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation" 
    //<telerik:RadButton Content="Click me" Height="50" telerik:Analytics.Name="DownloadButton" />
    //For more information go to: http://www.telerik.com/help/wpf/eqatec-analytics-application-integration.html
}
#endregion

#region eqatec-analytics-application-integration_1
        public App()
        {           
            var analyticsMonitor = Telerik.Windows.Analytics.TraceMonitor.Initialize(this, [product_key]);
        }
#endregion
}