---
title: Localization
page_title: Localization
description: Check our &quot;Localization&quot; documentation article for the RadImageEditor {{ site.framework_name }} control.
slug: radimageeditor-localization
tags: localization
published: True
position: 6
---

# Localization

The built-in localization mechanism in Silverlight and WPF allows you to localize any string resource used by the __RadImageEditor__ control. Once translated you might use your resources in both Silverlight and WPF projects without changing anything. You can find more information on the localization of the Telerik UI suite [here]({%slug common-localization%}).      

There are two ways to implement the localization - using Resource files or a custom localization manager.

## Supported Languages

__RadImageEditor__ can be translated in one of the following supported languages using the framework’s localization mechanism:

* English
* German
* Spanish
* French
* Italian
* Dutch
* Turkish

More information on how to achieve this you can find in the [Localization Using Built-in Resources](https://docs.telerik.com/devtools/wpf/common-localization#localization-using-built-in-resources) article.

## Localization Using Resource Files

You can base your localization on the standard resource files provided by the .NET framework. For that purpose you will have to create a separate .Resx file for each one of the languages that your application will support. Imagine that you want to translate your application into English, German and Dutch. In that regard, you will have to add three new resource files to your project:        

* RadImageEditorResources.resx - this resource file will store the English (default) resources for the image editor control. Set the __AccessModifier__ property to __Public__.            

* RadImageEditorResources.de.resx - this resource file will store the German resources for the image editor control. Set the __AccessModifier__ property to __No code generation__.            

* RadImageEditorResources.nl.resx - this resource file will store the Dutch resources for the image editor control. Set the __AccessModifier__ property to __No code generation__.
            
RadImageEditor is a complex control with numerous strings for localization. In order to be able to distinguish these resources, a unique identifier, called resource key is assigned to each localizable string. A resource file which includes the complete list of the RadImageEditor-related __Resource Keys__ along with the strings they are associated with by default can be downloaded at our SDK repository: [Localization](https://github.com/telerik/xaml-sdk/tree/master/ImageEditor/Localization).        

The three files should keep the same resource keys, whereas the values must be the translated ones.        

>tip It is easiest to copy the default __RadImageEditorResources.resx__ file and rename it. Afterwards, go through all string and change only the values for the strings that will be used in your application.          

The last step is to instantiate the __LocalizationManager__ class and set its __ResourceManager__ to the resources that have been just created.        

__Create LocalizationManager__  
```C#
	LocalizationManager.Manager = new LocalizationManager()
	{
	    ResourceManager = RadImageEditorResources.ResourceManager
	};
```

>tip You can download a runnable project of the previous example from our online SDK repository: [Localization](https://github.com/telerik/xaml-sdk/tree/master/ImageEditor/Localization).          

## Localization Using Custom Localization Manager

__Telerik.Windows.Controls.LocalizationManager__ allows you to easily localize any of the Telerik controls. To apply custom localization to your controls, just instantiate your custom __LocalizationManager__ deriving from the LocalizationManager object and set it to the static property __LocalizationManager.Manager__ before the creation of the UI.        

__Create custom LocalizationManager__  
```C#
	LocalizationManager.Manager = new CustomLocalizationManager();
```

>Note that if you set the localization manager after the creation of the UI, some parts might remain not-localized.

What is left in order to fulfill the localization, is to override the method __GetStringOverride()__. The logic is pretty simple, you just have to create a switch statement and return the correct translation for each resource key. Here is an example of how you can localize some of the strings in the two SpellCheckingDialogs:        

__Localize strings__  
```C#
	public class CustomLocalizationManager : LocalizationManager
	{
	    public override string GetStringOverride(string key)
	    {
	        switch (key)
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
```

Of course, if you don't want to hard-code your translation inside the source code, you can always use resource files.        

__Localization using resource files__  
```C#
	public override string GetStringOverride(string key)
	{
	    switch (key)
	    {
	        //----------------------
	        case "ImageEditor_Resize":
	            return MyRadImageEditorResources.ImageEditor_Resize;
	        //----------------------
	    }
	    return base.GetStringOverride(key);
	}
```

## See Also  
* [Localization SDK Example](https://github.com/telerik/xaml-sdk/tree/master/ImageEditor/Localization)
* [RadImageEditorUI]({%slug radimageeditor-features-radimageeditorui%})
