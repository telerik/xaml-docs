---
title: Localization
page_title: Localization
description: Check our &quot;Localization&quot; documentation article for the RadSpreadsheet {{ site.framework_name }} control.
slug: radspreadsheet-localization
tags: localization
published: True
position: 7
---

# Localization

The built-in localization mechanism in Silverlight and WPF allows you to localize any string resource used by the __RadSpreadsheet__ control. Once translated, you can use your resources in both Silverlight and WPF projects without changing anything. You can find more information on the localization of the Telerik UI Suite [here]({%slug  common-localization%}).      

There are two ways to implement localization - using Resource files or a custom localization manager.

* [Resource Files](#localization-using-resource-files)

* [Custom Localization Manager](#localization-using-custom-localization-manager)

## Supported Languages

__RadSpreadsheet__ can be translated in one of the following supported languages using the framework’s localization mechanism:

* English
* German
* Spanish
* French
* Italian
* Dutch
* Turkish

More information on how to achieve this you can find in the [Localization Using Built-in Resources](https://docs.telerik.com/devtools/wpf/common-localization#localization-using-built-in-resources) article.

## Localization Using Resource Files

You can base your localization on the standard resource files provided by the .NET framework. For that purpose you will have to create a separate .ResX file for each one of the languages that your application will support. Imagine that you want to translate your application into English, German and Dutch. In that regard, you will have to add three new resource files to your project:
        

* RadSpreadsheetResources.resx - this resource file will store the English (default) resources for the rich text box control. Set the __AccessModifier__ property to __Public__.
            

* RadSpreadsheetResources.de.resx - this resource file will store the German resources for the rich text box control. Set the __AccessModifier__ property to __No code generation__.
            

* RadSpreadsheetResources.nl.resx - this resource file will store the Dutch resources for the rich text box control. Set the __AccessModifier__ property to __No code generation__.
            

RadSpreadsheet is a complex control and its strings for localization are numerous. In order to be able to distinguish these resources, a unique identifier called resource key is assigned to each localizable string. A resource file which includes the complete list of the RadSpreadsheet-related __Resource Keys__ along with the strings they are associated with by default can be downloaded from the SDK repository [here](https://github.com/telerik/xaml-sdk/tree/master/).
        

The three files should keep the same resource keys, whereas the values must be the translated ones.
        

>tipIt is easiest to copy the default __RadSpreadsheetResources.resx__ file and rename it. Afterwards, go through all string and change only the Values for the strings that will be used in your application.
          

The last step is to instantiate the __LocalizationManager__ class and set its __ResourceManager__ to the resources that have been just created.
        



```C#
	            LocalizationManager.Manager = new LocalizationManager()
	            {
	                ResourceManager = RadSpreadsheetResources.ResourceManager
	            };
```

>tip Find a runnable project of the previous example in the [WPF Samples GitHub repository](https://github.com/telerik/xaml-sdk/tree/master/Spreadsheet/WPF/Localization).          

## Localization Using Custom Localization Manager

__Telerik.Windows.Controls.LocalizationManager__ allows you to easily localize any of the Telerik controls. To apply custom localization to your controls, just instantiate your custom __LocalizationManager__ deriving from the LocalizationManager object and set it to the static property __LocalizationManager.Manager__ before the creation of the UI.
        



```C#
	            LocalizationManager.Manager = new CustomLocalizationManager();
```



>Note that if you set the localization manager after the creation of the UI, some parts might remain not-localized.

What is left in order to fulfil the localization is to override the method __GetStringOverride()__. The logic is pretty simple, you just have to create a switch statement and return the correct translation for each resource key. Here is an example of how you can localize some of the strings in the FindReplaceDialog:
        



```C#
	    public class CustomLocalizationManager : LocalizationManager
	    {
	        public override string GetStringOverride(string key)
	        {
	            switch (key)
	            {
	                //----------------------
	                case "Spreadsheet_Workbook":
	                    return RadSpreadsheetResources.Spreadsheet_Workbook;
	                //----------------------
	            }
	            return base.GetStringOverride(key);
	        }
	    }
```



Of course, if you don't want to hard-code your translation inside the source code, you can always use resource files:
        



```C#
	        public override string GetStringOverride(string key)
	        {
	            switch (key)
	            {
	                case "Ok":
	                    return "~Ok~";
	                case "Cancel":
	                    return "~Cancel~";
	
	                //Insert any other keys that you need.
	            }
	            return base.GetStringOverride(key);
	        }
```


