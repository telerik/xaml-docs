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

#region radribbonview-localization_0
LocalizationManager.Manager = new LocalizationManager()
{
ResourceManager = RibbonResources.ResourceManager
};
#endregion

#region radribbonview-localization_2
public class CustomLocalizationManager : LocalizationManager
{
    public override string GetStringOverride( string key )
    {
        switch( key )
        {
            case "RibbonViewQATMinimize":
                return "Minimieren der Multifunktionsleiste";
            case "RibbonViewQATCustomize":
                return "Anpassen Sie die Symbolleiste";
            case "RibbonViewQATShowBelow":
                return "Zeigen unten die Multifunktionsleiste";
        }
        return base.GetStringOverride( key );
    }
}
#endregion

#region radribbonview-localization_4
public override string GetStringOverride( string key )
{
    switch( key )
    {
        //----------------------
        case "RibbonViewQATMinimize":
            return RibbonBarResources.RibbonBarQATMinimize;
        //----------------------
    }
    return base.GetStringOverride( key );
}
#endregion
}
