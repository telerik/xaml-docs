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

#region common-localization_0
LocalizationManager.Manager = new CustomLocalizationManager();
#endregion

#region common-localization_2
LocalizationManager.Manager = new LocalizationManager()
{
   ResourceManager = GridViewResources.ResourceManager
};
#endregion

#region common-localization_5
public class CustomLocalizationManager : LocalizationManager
{
  public override string GetStringOverride( string key )
  {
      switch( key )
      {
          case "GridViewGroupPanelText":
              return "Zum gruppieren ziehen Sie den Spaltenkopf in diesen Bereich.";
          //---------------------- RadGridView Filter Dropdown items texts:
          case "GridViewClearFilter":
              return "Filter löschen";
          case "GridViewFilterShowRowsWithValueThat":
              return "Anzeigen der Werte mit Bedingung:";
          case "GridViewFilterSelectAll":
              return "Alles anzeigen";
          case "GridViewFilterContains":
              return "Enthält";
          case "GridViewFilterEndsWith":
              return "Endet mit";
          case "GridViewFilterIsContainedIn":
              return "Enthalten in";
          case "GridViewFilterIsEqualTo":
              return "Gleich";
          case "GridViewFilterIsGreaterThan":
              return "Grösser als ";
          case "GridViewFilterIsGreaterThanOrEqualTo":
              return "Grösser oder gleich";
          case "GridViewFilterIsLessThan":
              return "Kleiner als";
          case "GridViewFilterIsLessThanOrEqualTo":
              return "Kleiner oder gleich";
          case "GridViewFilterIsNotEqualTo":
              return "Ungleich";
          case "GridViewFilterStartsWith":
              return "Beginnt mit";
          case "GridViewFilterAnd":
              return "Und";
          case "GridViewFilter":
              return "Filter";
      }
      return base.GetStringOverride( key );
  }
#endregion

#region common-localization_7
public override string GetStringOverride( string key )
{
   switch( key )
   {
       //----------------------
       case "GridViewClearFilter":
           return GridViewResources.GridViewClearFilter;
       //----------------------
   }
   return base.GetStringOverride( key );
}
#endregion
}
