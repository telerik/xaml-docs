---
title: Localization
page_title: Localization
description: Check our &quot;Localization&quot; documentation article for the RadSpellChecker {{ site.framework_name }} control.
slug: radspellchecker-localization
tags: localization
published: True
position: 4
---

# Localization

The built-in localization mechanism in Silverlight and WPF allows you to localize any string resource used by the __RadSpellChecker__ control. Once translated you might use your resources in both Silverlight and WPF projects without changing anything. You can find more information on the localization of the Telerik UI Suite {% if site.site_name == 'Silverlight' %}[here](http://www.telerik.com/help/silverlight/common-localization.html){% endif %}{% if site.site_name == 'WPF' %}[here](http://www.telerik.com/help/wpf/common-localization.html){% endif %}.

There are two ways to implement the localization - using Resource files or a custom localization manager.

## Supported Languages

__RadSpellChecker__ can be translated in one of the following supported languages using the framework’s localization mechanism:

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
        

* RadSpellChecker.resx - this resource file will store the English (default) resources for the spell-checker control. Set the __AccessModifier__ property to __Public__.
            

* RadSpellChecker.de.resx - this resource file will store the German resources for the spell-checker control. Set the __AccessModifier__ property to __No code generation__.
            

* RadSpellChecker.nl.resx - this resource file will store the Dutch resources for the spell-checker control. Set the __AccessModifier__ property to __No code generation__.
            

Here is the complete list of RadSpellChecker-related __Resource Keys__, which you should include in each of the resource files:
        

* __Documents_SpellCheckingDialog_Header__

* __Documents_SpellCheckingDialog_NotInDictionary__

* __Documents_SpellCheckingDialog_IgnoreAll__

* __Documents_SpellCheckingDialog_AddToDictionary__

* __Documents_SpellCheckingDialog_ChangeTo__

* __Documents_SpellCheckingDialog_Change__

* __Documents_SpellCheckingDialog_Suggestions__

* __Documents_SpellCheckingDialog_EditCustomDictionary__

* __Documents_SpellCheckingDialog_SpellingCheckIsComplete__

* __Ok__

* __Cancel__

* __SpellChecker_SpellingCheckIsCompleteMessageHeader__

* __SpellChecker_SpellingCheckIsCompleteMessage__

* __Documents_EditCustomDictionaryDialog_Header__

* __Documents_EditCustomDictionaryDialog_Word__

* __Documents_EditCustomDictionaryDialog_Dictionary__

* __Documents_EditCustomDictionaryDialog_Add__

* __Documents_EditCustomDictionaryDialog_Delete__

* __Documents_EditCustomDictionaryDialog_DeleteAll__

* __Documents_EditCustomDictionaryDialog_DeleteAllMessageHeader__

* __Documents_EditCustomDictionaryDialog_DeleteAllMessage__

* __Close__

The three files should keep the same resource keys, whereas the values must be the translated ones.
        

The last step is to instantiate the __LocalizationManager__ class and set its __ResourceManager__ to the resources that have been just created.

```C#
	LocalizationManager.Manager = new LocalizationManager()
	{
	   ResourceManager = RadSpellCheckerResources.ResourceManager
	};
```

If you rely on culture settings to load the right resources automatically, you have to write some code inside your application's project file. For example, if you have to support English and Dutch languages, you can store the localized strings in Resources.resx and Resources.nl.resx files. For the Resources.resx file you can set ResXFileCodeGenerator to Internal or Public and for others to No code generation. Then, open the project file in a text-mode and insert the code below into the <PropertyGroup> section. In this way you notify the framework about the supported cultures.

```XAML
	<SupportedCultures>en;nl</SupportedCultures>
```

## Localization Using Custom Localization Manager

__Telerik.Windows.Controls.LocalizationManager__ allows you to easily localize any of the Telerik controls. To apply custom localization to your controls, just instantiate your custom __LocalizationManager__ deriving from the LocalizationManager object and set it to the static property __LocalizationManager.Manager__ before the creation of the UI.
     
```C#
	LocalizationManager.Manager = new CustomLocalizationManager();
```

>Note that if you set the localization manager after the creation of the UI, some parts might remain not-localized.

What is left in order to fulfil the localization is to override the method __GetStringOverride()__. The logic is pretty simple, you just have to create a switch statement and return the correct translation for each resource key. Here is an example of how you can localize some of the strings in the two SpellCheckingDialogs:

```C#
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
```

If you don't want to hard-code your translation inside the source code, you can use resource files:        

```C#
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
```