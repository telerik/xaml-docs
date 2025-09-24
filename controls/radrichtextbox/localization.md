---
title: Localization
page_title: Localization
description: Check our &quot;Localization&quot; documentation article for the RadRichTextBox {{ site.framework_name }} control.
slug: radrichtextbox-localization
tags: localization
published: True
position: 12
---

# Localization

The built-in localization mechanism in Silverlight and WPF allows you to localize any string resource used by the __RadRichTextBox__ control. Once translated you might use your resources in both Silverlight and WPF projects without changing anything. You can find more information on the localization of the Telerik UI suite [here]({%slug common-localization%}).
      

There are two ways to implement the localization - using Resource files or a custom localization manager.

* [Resource Files](#localization-using-resource-files)

* [Custom Localization Manager](#localization-using-custom-localization-manager)

## Supported Languages

__RadRichTextBox__ can be translated in one of the following supported languages using the framework’s localization mechanism:

* English
* German
* Spanish
* French
* Italian
* Dutch
* Turkish

More information on how to achieve this you can find in the [Localization Using Built-in Resources]({%slug common-localization%}) article.

## Localization Using Resource Files

You can base your localization on the standard resource files provided by the .NET framework. For that purpose you will have to create a separate .ResX file for each one of the languages that your application supports. Imagine that you want to translate your application into English, German and Dutch. For this purpose you will have to add three new resource files to your project:        

* RadRichTextBoxResources.resx: This resource file will store the English (default) resources for the rich text box control. Set the __AccessModifier__ property to __Public__.            

* RadRichTextBoxResources.de.resx: This resource file will store the German resources for the rich text box control. Set the __AccessModifier__ property to __No code generation__.            

* RadRichTextBoxResources.nl.resx: This resource file will store the Dutch resources for the rich text box control. Set the __AccessModifier__ property to __No code generation__.            

RadRichTextBox is a complex control and its strings for localization are numerous. In order to be able to distinguish these resources, a unique identifier, called resource key is assigned to each localizable string. A resource file which includes the complete list of the RadRichTextBox-related __Resource Keys__ along with the strings they are associated with by default can be downloaded at our SDK repository [here](https://github.com/telerik/xaml-sdk).        

The three files should keep the same resource keys, whereas the values must be the translated ones.        

>tip It is easiest to copy the default __RadRichTextBoxResources.resx__ file and rename it. Afterwards, go through all string and change only the Values for the strings that will be used in your application.          

The last step is to instantiate the __LocalizationManager__ class and set its __ResourceManager__ to the resources that have been just created.        

  
```C#
	LocalizationManager.Manager = new LocalizationManager()
	{
	   ResourceManager = RadRichTextBoxResources.ResourceManager
	};
```

>tip You can download a runnable project of the previous example from our online SDK repository [here](https://github.com/telerik/xaml-sdk), the example is listed as __RichTextBox / Localization__.          

## Localization Using Custom Localization Manager

__Telerik.Windows.Controls.LocalizationManager__ allows you to easily localize any of the Telerik controls. To apply custom localization to your controls, just instantiate your custom __LocalizationManager__ deriving from the LocalizationManager object and set it to the static property __LocalizationManager.Manager__ before the creation of the UI.        

  
```C#
	LocalizationManager.Manager = new CustomLocalizationManager();
```

>Note that if you set the localization manager after the creation of the UI, some parts might remain not-localized.

What is left in order to fulfill the localization is to override the method __GetStringOverride()__. The logic is pretty simple, you just have to create a switch statement and return the correct translation for each resource key. Here is an example of how you can localize some of the strings in the FindReplaceDialog:        

  
```C#
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
```

If you don't want to hard-code your translation inside the source code, you can use resource files:        

  
```C#
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
```