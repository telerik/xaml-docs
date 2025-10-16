---
title: Localization
page_title: Localization
description: Check our &quot;Localization&quot; documentation article for the RadPdfViewer {{ site.framework_name }} control.
slug: radpdfviewer-localization
tags: localization
published: True
position: 11
---

# Localization



The built-in localization mechanism in Silverlight and WPF allows you to localize any string resource used by the __RadPdfViewer__ control. Once translated you might use your resources in both Silverlight and WPF projects without changing anything. You can find more information on the localization of the Telerik UI suite [here]({%slug common-localization%}).

There are two ways to implement the localization - using Resource files or a custom localization manager.

## Supported Languages

__RadPdfViewer__ can be translated in one of the following supported languages using the framework’s localization mechanism:

* English
* German
* Spanish
* French
* Italian
* Dutch
* Turkish

More information on how to achieve this you can find in the [Localization Using Built-in Resources](https://docs.telerik.com/devtools/wpf/common-localization#localization-using-built-in-resources) article.

## Localization Using Resource Files

You can base your localization on the standard resource files provided by the .NET framework. For that purpose you will have to create a separate .ResX file for each one of the languages that your application supports. Imagine that you want to translate your application into English, German and Dutch. For this purpose you will have to add three new resource files to your project:
        

* RadPdfViewerResources.resx: This resource file will store the English (default) resources for the pdf viewer control. Set the __AccessModifier__ property to __Public__.
            

* RadPdfViewerResources.de.resx: This resource file will store the German resources for the pdf viewer control. Set the __AccessModifier__ property to __No code generation__.
            

* RadPdfViewerResources.nl.resx: This resource file will store the Dutch resources for the pdf viewer control. Set the __AccessModifier__ property to __No code generation__.
            

RadPdfViewer has several localization strings so in order to be able to distinguish these resources, a unique identifier called resource key is assigned to each localizable string. A resource file which includes the complete list of the RadPdfViewer-related __Resource Keys__ along with the strings they are associated with by default can be downloaded at our SDK repository [here](https://github.com/telerik/xaml-sdk).
        

The three files should keep the same resource keys, whereas the values must be the translated ones.
        

>tipIt is easiest to copy the default __RadPdfViewerResources.resx__ file and rename it. Afterwards, go through all string and change only the Values for the strings that will be used in your application.
          

The last step is to instantiate the __LocalizationManager__ class and set its __ResourceManager__ to the resources that have been just created.
        



```C#
	LocalizationManager.Manager = new LocalizationManager()
	{
	    ResourceManager = RadPdfViewerResources.ResourceManager
	};
```


>tip Find a runnable project of the previous example in the [WPF Samples GitHub repository](https://github.com/telerik/xaml-sdk/tree/master/PdfViewer/Localization).
          

## Localization Using Custom Localization Manager

__Telerik.Windows.Controls.LocalizationManager__ allows you to easily localize any of the Telerik controls. To apply custom localization to your controls, just instantiate your custom __LocalizationManager__ deriving from the LocalizationManager object and set it to the static property __LocalizationManager.Manager__ before the creation of the UI.
        



```C#
	            LocalizationManager.Manager = new CustomLocalizationManager();
```



>Note that if you set the localization manager after the creation of the UI, some parts might remain not-localized.

What is left in order to fulfil the localization is to override the method __GetStringOverride()__. The logic is pretty simple, you just have to create a switch statement and return the correct translation for each resource key. Here is an example of how you can localize the strings in the FindDialog:
        



```C#
	    public class CustomLocalizationManager : LocalizationManager
	    {
	        public override string GetStringOverride(string key)
	        {
	            switch (key)
	            {
	                //----------------------
		            case "BusyIndicatorLoading":
	                    return "Loading...";
	                case "FixedDocumentViewers_BeginningOfDocumentReachedMessage":
	                    return "You have reached the beginning of the document.";
	                case "FixedDocumentViewers_CaseSensitive":
	                    return "Case Sensitive";
	                case "FixedDocumentViewers_EndOfDocumentReachedMessage":
	                    return "You have reached the end of the document.";
	                case "FixedDocumentViewers_FindDialogHeader":
	                    return "Find";
	                case "FixedDocumentViewers_FindNext":
	                    return "Find Next";
	                case "FixedDocumentViewers_FindPrevious":
	                    return "Find Previous";
	                case "FixedDocumentViewers_Options":
	                    return "Options";
	                case "FixedDocumentViewers_SearchInTheDocument":
	                    return "Search in the document...dddddd";
	                case "FixedDocumentViewers_UseRegularExpression":
	                    return "Use Regular Expression";
	                case "FixedDocumentViewers_WholeWordsOnly":
	                    return "Whole Words Only";
	                case "FixedDocumentViewers_FitWidth":
	                    return "Fit Width";
	                case "FixedDocumentViewers_ZoomToPageLevel":
	                    return "Zoom to Page Level";
	                //----------------------
	            }
	            return base.GetStringOverride(key);
	        }
	    }
```



Of course, if you don't want to hard-code your translation inside the source code, you can always use resource files:
        



```C#
	    public class CustomLocalizationManager : LocalizationManager
	    {
	        public override string GetStringOverride(string key)
	        {
	            switch (key)
	            {
	                //----------------------
	                case "FixedDocumentViewers_BeginningOfDocumentReachedMessage":
	                    return MyRadPdfViewerResources.FixedDocumentViewers_BeginningOfDocumentReachedMessage;
	                //----------------------
	            }
	            return base.GetStringOverride(key);
	        }
	    }
```
