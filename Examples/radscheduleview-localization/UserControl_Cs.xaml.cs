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

#region radscheduleview-localization_0
LocalizationManager.Manager = new CustomLocalizationManager();
#endregion

#region radscheduleview-localization_2
LocalizationManager.Manager = new LocalizationManager()
{
   ResourceManager = ScheduleViewResources.ResourceManager
};
#endregion

#region radscheduleview-localization_4
public class CustomLocalizationManager : LocalizationManager
{
   public override string GetStringOverride( string key )
   {
       switch( key )
       {
           case "Timeline":
               return "Zeitline";
           case "Day":
               return "Tag";
           case "Week":
               return "Woche";
           case "Month":
               return "Monat";
           case "SaveAndCloseCommandText":
               return "Speichern & Sliessen";
           case "EditRecurrence":
               return "Serie bearbeithen";
           case "Categories":
               return "Kategrisieren";
       }
       return base.GetStringOverride( key );
   }
}
#endregion

#region radscheduleview-localization_6
public override string GetStringOverride( string key )
{
   switch( key )
   {
       //----------------------
       case "Timeline":
           return ScheduleViewResources.Timeline;
       //----------------------
   }
   return base.GetStringOverride( key );
}
#endregion

#region radscheduleview-localization_8
public partial class App : Application
{
   public App()
   {
       System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo( "nl" );
       System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo( "nl" );
       this.Startup += this.Application_Startup;
       this.Exit += this.Application_Exit;
       this.UnhandledException += this.Application_UnhandledException;
       InitializeComponent();
   }
}
#endregion
}
