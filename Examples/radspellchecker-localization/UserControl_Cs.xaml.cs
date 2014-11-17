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

#region radspellchecker-localization_0
LocalizationManager.Manager = new CustomLocalizationManager();
#endregion

#region radspellchecker-localization_1
public class CustomLocalizationManager : LocalizationManager
{
   public override string GetStringOverride(string key)
   {
       switch(key)
       {
           case "Documents_SpellCheckingDialog_Header":
               return "New Header";
           case "Documents_SpellCheckingDialog_NotInDictionary":
               return "New NotInDictionary Notification";
           case "Documents_SpellCheckingDialog_IgnoreAll":
               return "New Ignore All";
           case "Documents_SpellCheckingDialog_AddToDictionary":
               return "New Add to Dictionary";
           case "Documents_SpellCheckingDialog_ChangeTo":
               return "New Change to"; 
           case "Documents_SpellCheckingDialog_Change":
               return "New Change";
           case "Documents_SpellCheckingDialog_Suggestions":
               return "New Suggestions";
           case "Documents_SpellCheckingDialog_EditCustomDictionary":
               return "New Show EditCustomDictionary";
       }
       return base.GetStringOverride(key);
   }
}
#endregion

#region radspellchecker-localization_2
public override string GetStringOverride(string key)
{
   switch( key )
   {
       //----------------------
       case "Documents_SpellCheckingDialog_Header":
           return MyRadSpellcheckerResources.Documents_SpellCheckingDialog_Header;
       //----------------------
   }
   return base.GetStringOverride(key);
}
#endregion

#region radspellchecker-localization_3
LocalizationManager.Manager = new LocalizationManager()
{
   ResourceManager = RadSpellCheckerResources.ResourceManager
};
#endregion
}
