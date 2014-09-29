---
title: Localization
page_title: Localization
description: Localization
slug: radtimebar-localization
tags: localization
published: True
position: 1
---

# Localization



## 

The built-in localization mechanism in Silverlight and WPF (which is available since __Q2 2011__) allows you to localize any string resource used by the standard __RadTimeBar__ control. Once translated you might use your resources in both Silverlight and WPF projects without changing anything.


__Localization using Resource Manager__

You can base your localization on the standard resource files provided by the .NET framework. For that purpose you will have to create a separate __.ResX file__ for each one of the languages that your application will support.
Imagine that you want to translate your schedule control into English and German. For that purpose you will have to add two new resource files to your project:

* __RadTimeBarResources.resx__ - this resource file will store the __English(default)__ resources for the ScheduleView control. Set the __AccessModifier__ property to __Public__. 

* __RadTimeBarResources.de.resx__ - this resource file will store the __German__ resources for the TimeBar control. Set the __AccessModifier__ property to __No code generation__. 

Now, having the needed files, it's time to illustrate the idea and localize for example the text for the Day, Week, Month and Quarter navigation strings. For that purpose you need to create four resource strings in each one of the resource files and translate them to the appropriate language.

>Note that the name of the resource string should be the same as the resource key for the string you are localizing i.e. the resource key for the Day is Day, for the Week is Week, for Month is Month and for the Quarter is Quarter.

The snapshot below shows the content of the __RadTimeBarResources.de.resx__ file. The Value column will contain the translation for the appropriate language:

![](images/radtimebar_resourcekeysTranslation.PNG)

The last step is to instantiate the __LocalizationManager__ class and set its __ResourceManager__ to the resources that have been just created.

#### __C#__

{{region radtimebar-localization_0}}
	LocalizationManager.Manager = new LocalizationManager()
	{
	  ResourceManager = RadTimeBarResource.ResourceManager
	};
	{{endregion}}



#### __VB.NET__

{{region radtimebar-localization_1}}
	LocalizationManager.Manager = New LocalizationManager()
	LocalizationManager.Manager.ResourceManager = ScheduleViewResources.ResourceManager
	{{endregion}}



>tipIf you rely on culture settings to load the right resources automatically, you have to write some code inside your application's project file. For example, if you have to support English and German languages, you can store the localized strings in Resources.resx and Resources.de.resx files. For the Resources.resx file you can set ResXFileCodeGenerator to Internal or Public and for others - to No code generation. Then, open the project file in a text-mode and insert the code below into the section. In this way you notify the framework about the supported cultures

#### __XML__

{{region radtimebar-localization}}
	          <SupportedCultures>en;de</SupportedCultures>
	{{endregion}}



To see the __RadTimeBar__localized in German for example you should set the *CurrentCulture *and *CurrentUICulture *in *App.xaml.cs/ App.xaml.vb* like this:

#### __C#__

{{region radtimebar-localization_2}}
	CultureInfo culture = new CultureInfo("de");
	System.Threading.Thread.CurrentThread.CurrentCulture = culture;
	System.Threading.Thread.CurrentThread.CurrentUICulture = culture;
	{{endregion}}



#### __VB.NET__

{{region radtimebar-localization_3}}
	Dim culture As New CultureInfo("de")
	System.Threading.Thread.CurrentThread.CurrentCulture = culture
	System.Threading.Thread.CurrentThread.CurrentUICulture = culture
	{{endregion}}



Here is how the localized *RadTimeBar* will look like:

![](images/radtimebar_localized.PNG)

__Localization Using Custom Localization Manager__

The other way to localize your __RadTimeBar__control is to create a class that derives from the __LocalizationManager__ object and to override its method __GetStringOverride()__. The logic is pretty simple, you just have to create a switch statement and return the correct translation for each resource key,____as it is shown below for German language:

#### __C#__

{{region radtimebar-localization_4}}
	class CustomLocalizationManager : LocalizationManager
	    {
	        public override string GetStringOverride(string key)
	        {
	            switch (key)
	            {
	                case "Day":
	                    return "Tag";
	                case "Week":
	                    return "Woche";
	                case "Month":
	                    return "Monat";
	                case "Quarter":
	                    return "Quartal";
	            }
	            return base.GetStringOverride(key);
	        }
	    }
	{{endregion}}



#### __VB.NET__

{{region radtimebar-localization_5}}
	Friend Class CustomLocalizationManager Inherits LocalizationManager
	Public Overrides Function GetStringOverride(ByVal key As String) As String
	   Select Case key
	          Case "Day"
	               Return "Tag"
	          Case "Week"
	               Return "Woche"
	          Case "Month"
	               Return "Monat"
	          Case "Quarter"
	               Return "Quartal"
	    End Select
	Return MyBase.GetStringOverride(key)
	End Function
	End Class
	{{endregion}}



To apply custom localization to your controls just instantiate your custom __LocalizationManager__ and set it to the static property __LocalizationManager.Manager__, before the creation of the UI.

#### __C#__

{{region radtimebar-localization_6}}
	LocalizationManager.Manager = new CustomLocalizationManager();
	{{endregion}}



#### __VB.NET__

{{region radtimebar-localization_7}}
	LocalizationManager.Manager = New CustomLocalizationManager()
	{{endregion}}



>

Note that you have to set the localization manager before the creation of the UI, otherwise some parts might remain not-localized.









Using Built-In Resources

RadTimeBar provides you with built-in resources for several cultures:  Spanish, German, Italian, Turkish, Dutch.

To change the default culture, you should set the __CurrentCulture__ and the __CurrentUICulture__of the __CurrentThread__. Note that this must happen in the code-behind of your __Application__ (__App.xaml.cs/ App.xaml.vb__) file, right before the UI initialization. The next code-snippet shows you how to change the __CurrentCulture__to __Dutch__.

#### __C#__

{{region radtimebar-localization_8}}
	public App()
	{
	  System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("de");
	  System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("de");
	  this.Startup += this.Application_Startup;
	  this.Exit += this.Application_Exit;
	  this.UnhandledException += this.Application_UnhandledException;
	  InitializeComponent();
	}
	{{endregion}}



#### __VB.NET__

{{region radtimebar-localization_9}}
	Public Sub New()
	   System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("de")
	   System.Threading.Thread.CurrentThread.CurrentUICulture = New System.Globalization.CultureInfo("de")
	   Me.Startup += Me.Application_Startup
	   Me.Exit += Me.Application_Exit
	   Me.UnhandledException += Me.Application_UnhandledException
	   InitializeComponent()
	End Sub
	{{endregion}}



RadTimeBar Resource Keys

The following __Resource Keys__ are available:

· Century 

· DecadeEnding 

· Quarter 

· QuarterShort 

· Week 

· WeekShort 
