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

#region radimageeditor-localization_0
LocalizationManager.Manager = new CustomLocalizationManager();
#endregion

#region radimageeditor-localization_1
public class CustomLocalizationManager : LocalizationManager
{
   public override string GetStringOverride(string key)
   {
       switch(key)
       {
           case "ImageEditor_Resize":
               return "New Resize";
           case "ImageEditor_CanvasResize":
               return "New Canvas Resize";
           case "ImageEditor_Rotate90":
               return "New Rotate at 90";
           case "ImageEditor_Rotate180":
               return "New Rotate at 180";
           case "ImageEditor_Rotate270":
               return "New Rotate at 270";
           case "ImageEditor_RoundCorners":
               return "New Round Corners"; 
           case "ImageEditor_FlipHorizontal":
               return "New Flip Horizontal";
           case "ImageEditor_FlipVertical":
               return "New Flip Vertical";
           case "ImageEditor_Crop":
               return "New Crop";
           //...
       }
       return base.GetStringOverride(key);
   }
}
#endregion

#region radimageeditor-localization_2
public override string GetStringOverride(string key)
{
   switch( key )
   {
       //----------------------
       case "ImageEditor_Resize":
           return MyRadImageEditorResources.ImageEditor_Resize;
       //----------------------
   }
   return base.GetStringOverride(key);
}
#endregion

#region radimageeditor-localization_3
LocalizationManager.Manager = new LocalizationManager()
{
   ResourceManager = RadImageEditorResources.ResourceManager
};
#endregion
}
