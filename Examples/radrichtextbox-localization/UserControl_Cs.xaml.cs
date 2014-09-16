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

#region radrichtextbox-localization_0
LocalizationManager.Manager = new CustomLocalizationManager();
#endregion

#region radrichtextbox-localization_1
public class CustomLocalizationManager : LocalizationManager
{
   public override string GetStringOverride(string key)
   {
       switch(key)
       {
           case "Documents_FindReplaceDialog_FindNext":
               return "Weitersuchen";
           case "Documents_FindReplaceDialog_Header":
               return "Suchen und Ersetzen";
           case "Documents_FindReplaceDialog_Replace":
               return "Ersetzen";
           case "Documents_FindReplaceDialog_ReplaceAll":
               return "Alle ersetzen";
           case "Documents_FindReplaceDialog_ReplaceWith":
               return "Ersetzen durch"; 
           case "Documents_FindReplaceDialog_TextToFind":
               return "Suchen nach";
           case "Documents_FindReplaceDialog_RestartSearch":
               return "Zeigen unten die Multifunktionsleiste";
           case "Documents_FindReplaceDialog_SearchedTextNotFound":
               return "Der Suchbegriff wurde nicht gefunden";
       }
       return base.GetStringOverride(key);
   }
}
#endregion

#region radrichtextbox-localization_2
public override string GetStringOverride(string key)
{
   switch( key )
   {
       //----------------------
       case "Documents_FindReplaceDialog_TextToFind":
           return MyRadRichTextBoxResources.Documents_FindReplaceDialog_TextToFind;
       //----------------------
   }
   return base.GetStringOverride(key);
}
#endregion

#region radrichtextbox-localization_3
LocalizationManager.Manager = new LocalizationManager()
{
   ResourceManager = RadRichTextBoxResources.ResourceManager
};
#endregion
}
