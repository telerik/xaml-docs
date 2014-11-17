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

#region radtimebar-localization_0
LocalizationManager.Manager = new LocalizationManager()
{
  ResourceManager = RadTimeBarResource.ResourceManager
};
#endregion

#region radtimebar-localization_2
CultureInfo culture = new CultureInfo("de");
System.Threading.Thread.CurrentThread.CurrentCulture = culture;
System.Threading.Thread.CurrentThread.CurrentUICulture = culture;
#endregion

#region radtimebar-localization_4
class CustomLocalizationManager : LocalizationManager
    {
        public override string GetStringOverride(string key)
        {
            switch (key)
            {
                case "Day":
                    return "Tag";
                case "Week":
                    return "Woche";
                case "Month":
                    return "Monat";
                case "Quarter":
                    return "Quartal";
            }
            return base.GetStringOverride(key);
        }
    }
#endregion

#region radtimebar-localization_6
LocalizationManager.Manager = new CustomLocalizationManager();
#endregion

#region radtimebar-localization_8
public App()
{
  System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("de");
  System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("de");
  this.Startup += this.Application_Startup;
  this.Exit += this.Application_Exit;
  this.UnhandledException += this.Application_UnhandledException;
  InitializeComponent();
}
#endregion
}
